
Public Class frmBaseReport

    Public bFormOpenning As Boolean = False

    Private mVar_FormCode As String = ""
    Public Event RefreshBefore_Click(ByVal sender As Object, ByRef e As ReportFormRefreshEventArgs)
    Public Event RefreshAfter_Click(ByVal sender As Object, ByVal e As ReportFormRefreshEventArgs)

    Dim FormDateRadioGroup_SelectedIndex = 1

    Public Property FormCode() As String
        Get
            Return mVar_FormCode
        End Get
        Set(ByVal value As String)
            mVar_FormCode = value
        End Set
    End Property

    Private mVar_FillOnFormOpening As Boolean = True
    Public Property FillOnFormOpening() As Boolean
        Get
            Return mVar_FillOnFormOpening
        End Get
        Set(ByVal value As Boolean)
            mVar_FillOnFormOpening = value
        End Set
    End Property


    Public ReturnDataRow As DataRow
    Public ReturnDataRows As DataRow()

    
    Dim bSelectionMode As Boolean = False
    Public bNoAction As Boolean = False

    Public Sub FormShow(Optional ByVal bDialog As Boolean = False, Optional ByVal Owner As Form = Nothing)

        If AppConn.dbConn.State <> ConnectionState.Open Then
            MsgBox("Piconn Veri tabani baglantisi yok!")
            Exit Sub
        End If
        If InitFormSecurity() = False Then Exit Sub

        If bDialog Then
            If Owner Is Nothing Then
                Me.ShowDialog()
            Else
                Me.ShowDialog(Owner)
            End If

        Else
            If Owner Is Nothing Then
                Me.Show()
            Else
                Me.Show(Owner)
            End If
        End If
    End Sub

    Public Sub FormSelect(Optional ByVal bDialog As Boolean = True, Optional ByVal Owner As Form = Nothing, Optional ByVal bMultiSelect As Boolean = False)
        'If AppConn.mainConn.State <> ConnectionState.Open Then
        '    MsgBox("Piconn Master " & BaseTText("Veri tabanï¿½ baï¿½lantï¿½sï¿½ yok!"))
        '    Exit Sub
        'End If
        If AppConn.dbConn.State <> ConnectionState.Open Then
            MsgBox("Piconn " & BaseTText("Firma Veri tabani baglantisi kurulamadi!"))
            Exit Sub
        End If
        If InitFormSecurity() = False Then Exit Sub
        panelBottom.Visible = True
        If bMultiSelect Then
            GridView1.OptionsSelection.MultiSelect = True
        Else
            GridView1.OptionsSelection.MultiSelect = False
        End If
        bSelectionMode = True
        If bDialog Then
            Me.ShowDialog(Owner)
        Else
            Me.Show(Owner)
        End If
    End Sub

    Private Function InitFormSecurity() As Boolean
        Dim FormSec As New FormSecurity
        FormSec = AppConn.GetFormSecurity(Me.FormCode)
        With FormSec
            If .CanRead = False Then Return False
            'If .CanWrite = False Then
            '    btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End If
            'If .CanDelete = False Then
            '    btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End If

            If .CanPrintGrid = False Then
                btnPrintGrid.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If .CanPrintForm = False Then
                btnFormPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If .CanExport = False Then
                btnExport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                If .CanExportExcel = False Then
                    btnExportExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
                If .CanExportTxt = False Then
                    btnExportTxt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If

                If .CanExportCsv = False Then
                    btnExportCSV.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
                If .CanExportPdf = False Then
                    btnExportPDF.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
                If .CanExportHtml = False Then
                    btnExportHTML.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
            End If
        End With
        Return True
    End Function
    Private Sub frmBaseReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                If btnRefresh.Enabled And btnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    btnRefresh_ItemClick(Nothing, Nothing)
                End If
            Case Keys.F2
                If bSelectionMode And cmdSelect.Visible = True And cmdSelect.Enabled Then
                    cmdSelect_Click(Nothing, Nothing)
                End If

            Case Keys.Escape
                Me.Close()

            Case Keys.F9
                baseform_yazdir(True, True)
        End Select


        If e.KeyCode = Keys.L And e.Control = True And e.Alt = True Then
            'ShowLanguageOptions(Me.Name, AppConn)
        End If
    End Sub

    Private Sub btnRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        RefreshForm(sender)
    End Sub

    Public Sub RefreshForm(ByVal sender As System.Object)
        Try
            barItem_RecordTime.Caption = ""
            barItem_RowCount.Caption = ""

            Dim StartTime As Date = Now

            Dim eBefore As New ReportFormRefreshEventArgs
            RaiseEvent RefreshBefore_Click(sender, eBefore)
            If eBefore.Cancel Then
                Exit Sub
            End If
            SetMasterFormDateParameters()
            If Not GridControl1.DataSource Is Nothing Then
                'If TypeOf GridControl1.DataSource Is C1.Data.Express.C1ExpressTable Then
                '    CType(GridControl1.DataSource, C1.Data.Express.C1ExpressTable).ConnectionComponent.Fill()
                'ElseIf TypeOf GridControl1.DataSource Is C1.Data.Express.C1ExpressView Then
                '    CType(GridControl1.DataSource, C1.Data.Express.C1ExpressView).ExpressTable.ConnectionComponent.Fill()
                'ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then

                'End If
            End If

            If Not DetailTable.SelectCommand Is Nothing Then
                If DetailTable.SelectCommand.CommandText <> "" Then
                    OpenTable(DetailTable)
                End If

            End If

            If Not MasterTable.SelectCommand Is Nothing Then
                If MasterTable.SelectCommand.CommandText <> "" Then
                    OpenTable(MasterTable)
                End If

            End If
            Dim eAfter As New ReportFormRefreshEventArgs
            RaiseEvent RefreshAfter_Click(sender, eAfter)
            barItem_RowCount.Caption = GridView1.RowCount & " kayit"
            Dim diffTime As Long
            diffTime = DateDiff(DateInterval.Second, StartTime, Now)
            If diffTime >= 3600 Then
                barItem_RecordTime.Caption &= Math.Round(diffTime / 3600, 0, MidpointRounding.AwayFromZero) & "sa  "
            End If
            If diffTime >= 60 Then
                barItem_RecordTime.Caption &= Math.Round((diffTime Mod 3600) / 60, 0, MidpointRounding.AwayFromZero) & "dk  "
            End If
            barItem_RecordTime.Caption &= (diffTime Mod 60) & "sn  "

        Catch ex As Exception
            MsgBox("(btnRefresh_ItemClick) " & ex.Message)
        End Try
    End Sub

    Private Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = 0
        End If
    End Sub

    Private Sub btnPrior_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrior.ItemClick
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle > 0 Then
                GridView1.FocusedRowHandle -= 1
            End If
        End If
    End Sub

    Private Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle < GridView1.RowCount - 1 Then
                GridView1.FocusedRowHandle += 1
            End If
        End If
    End Sub

    Private Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        End If
    End Sub

    Private Sub btnExportExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportExcel.ItemClick
        GridExport(typePiconnExport.XLS, dlgExport, GridView1)
    End Sub

    Private Sub btnExportPDF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportPDF.ItemClick
        GridExport(typePiconnExport.PDF, dlgExport, GridView1)
    End Sub

    Private Sub btnExportTxt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportTxt.ItemClick
        GridExport(typePiconnExport.TXT, dlgExport, GridView1)
    End Sub

    Private Sub btnExportCSV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportCSV.ItemClick
        GridExport(typePiconnExport.CSV, dlgExport, GridView1)
    End Sub

    Private Sub btnExportHTML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportHTML.ItemClick
        GridExport(typePiconnExport.HTML, dlgExport, GridView1)
    End Sub


    Private Sub btnPrintGrid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintGrid.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub ExportGridViewLayout()
        On Error Resume Next
        Dim FileName As String
        Dim sw As IO.StreamWriter
        If Not IO.Directory.Exists(GetMyDir() & "\ExportedLayouts") Then
            IO.Directory.CreateDirectory(GetMyDir() & "\ExportedLayouts")
        End If
        FileName = GetMyDir() & "\ExportedLayouts\" & AppConn.ActiveUser.UserName & "_" & Me.Name & "_gridview1_" & ".xml"
        GridView1.SaveLayoutToXml(FileName)


    End Sub
    Private Sub frmBaseReport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            If Me.FormCode <> "" And AppConn.ApplicationCode <> "" Then
                SaveSetting(AppConn.ApplicationCode, Me.FormCode, "FormDateFilter", FormDateRadioGroup_SelectedIndex)

                SaveGridView(Me.FormCode, GridView1)
                ExportGridViewLayout()
            End If
        Catch ex As Exception
            MsgBox("(frmItemForm_FormClosed) " & ex.Message)
        End Try


    End Sub

    Private Sub frmBaseReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub
            If AppConn.dbConnStr = "" Then Exit Sub
            'UST TARIH FILTRESI

            Dim sBuf As String = ""
            Try
                dtFormDate1.DateTime = DateSerial(AppConn.Today.Year, 1, 1)
                dtFormDate2.DateTime = AppConn.Today

                sBuf = GetSetting(AppConn.ApplicationCode, Me.FormCode, "FormDateFilter", "")

                If sBuf = "" Or Not IsNumeric(sBuf) Then
                    FormDateRadioGroup_SelectedIndex = 1

                Else
                    If CInt(sBuf) >= 0 And CInt(sBuf) <= 5 Then
                        FormDateRadioGroup_SelectedIndex = CInt(sBuf)
                    Else
                        FormDateRadioGroup_SelectedIndex = 1
                    End If
                End If
                Select Case FormDateRadioGroup_SelectedIndex
                    Case 0 : btnSetDate_Today_Click(Nothing, Nothing)
                    Case 1 : btnSetDate_ThisMonth_Click(Nothing, Nothing)
                    Case 2 : btnSetDate_ThisYear_Click(Nothing, Nothing)
                    Case 3 : btnSetDate_Last3Months_Click(Nothing, Nothing)
                    Case 4 : btnSetDate_Last6Months_Click(Nothing, Nothing)
                    Case 5 : btnSetDate_Last1Year_Click(Nothing, Nothing)

                End Select

                SetMasterFormDateParameters()

            Catch ex As Exception

            End Try

            bNoAction = True
            bFormOpenning = True

            InitializeConnections()

            If Not DetailTable.SelectCommand Is Nothing And DetailTable.Active = False Then
                DetailTable.SelectCommand.CommandTimeout = 600
                If Trim(DetailTable.SelectCommand.CommandText) <> "" Then
                    If mVar_FillOnFormOpening = True Then
                        RefreshForm(Nothing)
                    End If
                End If
            End If

            If Not MasterTable.SelectCommand Is Nothing And MasterTable.Active = False Then
                MasterTable.SelectCommand.CommandTimeout = 600
                If Trim(MasterTable.SelectCommand.CommandText) <> "" Then
                    If mVar_FillOnFormOpening = True Then
                        RefreshForm(Nothing)
                    End If

                End If

            End If
            'RecreateInsertCommand(MasterTable, AppConn.ActiveUser.UserID)

            LoadGridView(Me.FormCode, GridView1)
        Catch ex As Exception
            MsgBox("(frmBaseReport_Load) " & ex.Message)
        End Try
        bNoAction = False
        bFormOpenning = False

        'Try
        '    If Not AppConn.PiconnLanguage Is Nothing Then
        '        AppConn.PiconnLanguage.WalkInControl(Me.Name, Me)
        '        Application.DoEvents()
        '    End If
        '    If InStr(Me.Text, Me.FormCode) <= 0 Then Me.Text &= "  (" & Me.FormCode & ")"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim cDt As NeoDAC.NeoTable



        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            If GridView1.GetSelectedRows().Count <= 0 Then
                MsgBox(BaseTText("Hiï¿½ seï¿½ili nesne yok!"))
                Exit Sub

            End If
            If TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                cDt = CType(GridControl1.DataSource, NeoDAC.NeoTable)
            ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                cDt = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable)
            Else
                Exit Sub
            End If


            If GridView1.OptionsSelection.MultiSelect = False Then


                dr = cDt.Rows(GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle))
                If dr Is Nothing Then Exit Sub
                ReDim ReturnDataRows(0)
                ReturnDataRows(0) = dr
                ReturnDataRow = dr
            Else


                Dim SelRows() As Integer = GridView1.GetSelectedRows()

                ReDim ReturnDataRows(SelRows.Length - 1)
                For i As Integer = 0 To SelRows.Length - 1
                    'ReDim Preserve ReturnDataRows(UBound(ReturnDataRows) + 1)

                    'Dim dr2 As C1.Data.C1DataRow = cDt.NeoDAC.NeoTable.Rows(GridView1.GetDataSourceRowIndex(SelRows(i)))
                    'ReturnDataRows(UBound(ReturnDataRows)) = cDt.Rows(GridView1.GetDataSourceRowIndex(SelRows(i)))
                    ReturnDataRows(i) = cDt.Rows(GridView1.GetDataSourceRowIndex(SelRows(i)))
                    If i = 0 Then
                        ReturnDataRow = cDt.Rows(GridView1.GetDataSourceRowIndex(SelRows(i)))
                    End If
                Next

            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        If bSelectionMode And cmdSelect.Visible = True And cmdSelect.Enabled Then
            cmdSelect_Click(Nothing, Nothing)

        End If
    End Sub

    Public Sub InitializeConnections()
        Try
            If DesignMode Then Exit Sub
            If FirmConn.State <> ConnectionState.Open Then
                If AppConn.dbConnStr <> "" Then
                    FirmConn.ConnectionString = AppConn.dbConnStr
                    FirmConn.UserInfo_UserID = AppConn.ActiveUser.UserID : FirmConn.WriteAuthCodeToNewRecord = True
                    If Trim(AppConn.ActiveUser.NewRecordAuthCode) <> "" Then
                        FirmConn.UserInfo_NewRecordAuthCode = AppConn.ActiveUser.NewRecordAuthCode
                    Else
                        FirmConn.UserInfo_NewRecordAuthCode = AppConn.ActiveOffice.NewRecordAuthCode
                    End If

                    FirmConn.UserInfo_CanReadAuthCode = AppConn.ActiveUser.CanReadAuthCode
                    FirmConn.UserInfo_CanWriteAuthCode = AppConn.ActiveUser.CanWriteAuthCode
                    FirmConn.UserInfo_CanDeleteAuthCode = AppConn.ActiveUser.CanDeleteAuthCode
                    FirmConn.Open()
                End If
            End If
            If MasterConn.State <> ConnectionState.Open Then
                If AppConn.mainConnStr <> "" Then
                    MasterConn.ConnectionString = AppConn.mainConnStr
                    MasterConn.UserInfo_UserID = AppConn.ActiveUser.UserID : MasterConn.WriteAuthCodeToNewRecord = True
                    If Trim(AppConn.ActiveUser.NewRecordAuthCode) <> "" Then
                        MasterConn.UserInfo_NewRecordAuthCode = AppConn.ActiveUser.NewRecordAuthCode
                    Else
                        MasterConn.UserInfo_NewRecordAuthCode = AppConn.ActiveOffice.NewRecordAuthCode
                    End If
                    MasterConn.UserInfo_CanReadAuthCode = AppConn.ActiveUser.CanReadAuthCode
                    MasterConn.UserInfo_CanWriteAuthCode = AppConn.ActiveUser.CanWriteAuthCode
                    MasterConn.UserInfo_CanDeleteAuthCode = AppConn.ActiveUser.CanDeleteAuthCode
                    MasterConn.Open()
                End If
            End If

            If TicariConn.State <> ConnectionState.Open Then
                If AppConn.dbTicariStr <> "" Then
                    TicariConn.ConnectionString = AppConn.dbTicariStr
                    TicariConn.UserInfo_UserID = AppConn.ActiveUser.UserID : TicariConn.WriteAuthCodeToNewRecord = True
                    If Trim(AppConn.ActiveUser.NewRecordAuthCode) <> "" Then
                        TicariConn.UserInfo_NewRecordAuthCode = AppConn.ActiveUser.NewRecordAuthCode
                    Else
                        TicariConn.UserInfo_NewRecordAuthCode = AppConn.ActiveOffice.NewRecordAuthCode
                    End If
                    TicariConn.UserInfo_CanReadAuthCode = AppConn.ActiveUser.CanReadAuthCode
                    TicariConn.UserInfo_CanWriteAuthCode = AppConn.ActiveUser.CanWriteAuthCode
                    TicariConn.UserInfo_CanDeleteAuthCode = AppConn.ActiveUser.CanDeleteAuthCode
                    TicariConn.Open()
                End If
            End If
        Catch ex As Exception
            MsgBox("(InitializeConnections) " & ex.Message)
        End Try
    End Sub

    Private Sub cmdRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshList.Click
        btnRefresh_ItemClick(Nothing, Nothing)
    End Sub

    Public Sub SetMasterFormDateParameters()
        Try

            If MasterTable.SelectCommand Is Nothing Then Exit Sub

            If MasterTable.SelectCommand.Parameters.Contains("@FormDate1") = False And InStr(UCase(MasterTable.SelectCommand.CommandText), "@FORMDATE1") > 0 Then
                MasterTable.SelectCommand.Parameters.Add(New SqlClient.SqlParameter("@FormDate1", GetType(Date)))
            End If

            If MasterTable.SelectCommand.Parameters.Contains("@FormDate2") = False And InStr(UCase(MasterTable.SelectCommand.CommandText), "@FORMDATE2") > 0 Then
                MasterTable.SelectCommand.Parameters.Add(New SqlClient.SqlParameter("@FormDate2", GetType(Date)))
            End If



            If MasterTable.SelectCommand.Parameters.Contains("@FormDate1") = True Then
                If chkDate1.Checked Then
                    MasterTable.SelectCommand.Parameters("@FormDate1").Value = dtFormDate1.DateTime
                Else
                    MasterTable.SelectCommand.Parameters("@FormDate1").Value = DateSerial(1899, 12, 30)
                End If

            End If
            If MasterTable.SelectCommand.Parameters.Contains("@FormDate2") = True Then
                If chkDate2.Checked Then
                    Dim tmpTarih2 As DateTime = dtFormDate2.DateTime
                    tmpTarih2 = DateAdd(DateInterval.Hour, 23, tmpTarih2)
                    tmpTarih2 = DateAdd(DateInterval.Minute, 59, tmpTarih2)
                    tmpTarih2 = DateAdd(DateInterval.Second, 59, tmpTarih2)

                    MasterTable.SelectCommand.Parameters("@FormDate2").Value = tmpTarih2

                Else
                    MasterTable.SelectCommand.Parameters("@FormDate2").Value = DateSerial(2099, 12, 31)
                End If
            End If
        Catch ex As Exception
            MsgBox("(SetMasterFormDateParameters) " & ex.Message)
        End Try
    End Sub


    Private Sub chkDate1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate1.CheckedChanged
        If chkDate1.Checked Then
            dtFormDate1.Properties.ReadOnly = False
        Else
            dtFormDate1.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub chkDate2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate2.CheckedChanged
        If chkDate2.Checked Then
            dtFormDate2.Properties.ReadOnly = False
        Else
            dtFormDate2.Properties.ReadOnly = True
        End If
    End Sub



   
    Private Sub btnLanguageOptions_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLanguageOptions.ItemClick
        'ShowLanguageOptions(Me.Name, AppConn)
    End Sub

    Public Function BaseTText(ByVal sText As String) As String
        'If AppConn Is Nothing Then Return sText
        'If AppConn.PiconnLanguage Is Nothing Then Return sText
        'Return AppConn.PiconnLanguage.TText(sText)
        Return sText
    End Function

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If bSelectionMode Then
            If e.KeyCode = Keys.Return Then
                GridControl1_DoubleClick(Nothing, Nothing)
            End If
        End If
    End Sub


    'Private Sub btnFormPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormPrint.ItemClick
    '    Try

    '        If MasterTable.Columns.Count <= 0 Then Exit Sub


    '        'If Trim(PrintScript) = "" Then
    '        Dim PrintScript As String = ""
    '        If MasterTable.SelectCommand.CommandType = CommandType.Text Then
    '            PrintScript = MasterTable.SelectCommand.CommandText
    '            If InStr(PrintScript, "WHERE ") <> 0 Then
    '                PrintScript = Replace(PrintScript, "WHERE ", "WHERE " & MasterTable.Columns(0).ColumnName & "=@" & MasterTable.Columns(0).ColumnName & " AND ")
    '            Else
    '                PrintScript &= " WHERE " & MasterTable.Columns(0).ColumnName & "=@" & MasterTable.Columns(0).ColumnName
    '            End If

    '        End If
    '        'End If


    '        Dim f As New frmReportSelect
    '        With f
    '            .Parameters = New ArrayList
    '            Dim RowIndex As Long = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
    '            If RowIndex < 0 Then Exit Sub

    '            Dim pr As New SqlClient.SqlParameter("@" & MasterTable.Columns(0).ColumnName, MasterTable.Rows(RowIndex).Item(0))
    '            .Parameters.Add(pr)
    '            For Each pr2 As SqlClient.SqlParameter In MasterTable.SelectCommand.Parameters
    '                If pr2.ParameterName <> pr.ParameterName Then
    '                    .Parameters.Add(New SqlClient.SqlParameter(pr2.ParameterName, pr2.Value))
    '                End If
    '            Next
    '            
    '            .FormCode = Me.FormCode
    '            .PrintScript = PrintScript
    '            .FormShow()

    '        End With

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Private Sub btnFormPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormPrint.ItemClick
        baseform_yazdir(False, False)
    End Sub



    Private Sub btnFormPrint1Tane_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormPrint1Tane.ItemClick
        baseform_yazdir(True, False)
    End Sub

    Public Sub baseform_yazdir(b1tane As Boolean, bInvisible As Boolean, Optional baskisayisi As Integer = 0)
        Try
            If GridControl1.DataSource Is Nothing Then Exit Sub
            If b1tane And GridView1.FocusedRowHandle < 0 Then
                MsgBox("Lutfen bir kayit seciniz!")
                Exit Sub
            End If
            Dim DataSource As Object
            Dim sSort As String = ""
            Dim Filter As String = ""
            For i As Integer = 0 To GridView1.SortInfo.Count - 1
                sSort &= "[" & GridView1.SortInfo.Item(i).Column.FieldName & "]"
                If GridView1.SortInfo.Item(i).SortOrder = DevExpress.Data.ColumnSortOrder.Descending Then
                    sSort &= " DESC"
                Else
                    sSort &= " ASC"
                End If
                If i < GridView1.SortInfo.Count - 1 Then
                    sSort &= ","
                End If
            Next


            If GridView1.ActiveFilterString <> "" Then
                'Dim nTable As NeoDAC.NeoTable = CType(GridControl1.DataSource, NeoDAC.NeoTable)
                Dim IDler As New ArrayList
                Dim FilterFieldName As String
                If TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                    FilterFieldName = CType(GridControl1.DataSource, NeoDAC.NeoTable).Columns(0).ColumnName
                ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                    FilterFieldName = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable).Columns(0).ColumnName
                ElseIf TypeOf GridControl1.DataSource Is DataTable Then
                    FilterFieldName = CType(GridControl1.DataSource, DataTable).Columns(0).ColumnName
                Else
                    Exit Sub
                End If

                If b1tane = False Then
                    For i As Long = 0 To GridView1.RowCount - 1
                        'Dim RowIndex As Long = GridView1.GetDataSourceRowIndex(i)
                        IDler.Add(GridView1.GetRowCellValue(i, GridView1.Columns(FilterFieldName)))
                    Next
                Else  'eger 1 tane basilacaksa
                    'Dim RowIndex As Long = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
                    IDler.Add(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(FilterFieldName)))
                End If

                If IDler.Count > 0 Then
                    Filter = FilterFieldName & " IN ("
                    For i As Long = 0 To IDler.Count - 1
                        Filter &= IDler(i)
                        If i < IDler.Count - 1 Then
                            Filter &= ","
                        End If
                    Next
                    Filter &= ")"
                End If
            Else
                Filter = ""
            End If
            If TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                DataSource = CType(GridControl1.DataSource, NeoDAC.NeoTable)
                CType(DataSource, NeoDAC.NeoTable).DefaultView.RowFilter = Filter
                CType(DataSource, NeoDAC.NeoTable).DefaultView.Sort = sSort
                'CType(DataSource, DataTable).DefaultView.RowFilter = GridView1.ActiveFilterString
                'CType(DataSource, DataTable).DefaultView.Sort = sSort

            ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then

                DataSource = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable)
                CType(DataSource, NeoDAC.NeoTable).DefaultView.RowFilter = Filter
                CType(DataSource, NeoDAC.NeoTable).DefaultView.Sort = sSort
                'CType(DataSource, DataTable).DefaultView.RowFilter = GridView1.ActiveFilterString
                'CType(DataSource, DataTable).DefaultView.Sort = sSort

            ElseIf TypeOf GridControl1.DataSource Is DataTable Then
                DataSource = CType(GridControl1.DataSource, DataTable)
                CType(DataSource, DataTable).DefaultView.RowFilter = Filter
                CType(DataSource, DataTable).DefaultView.Sort = sSort
            Else
                Exit Sub
            End If
            If DataSource Is Nothing Then Exit Sub

            Dim f As New frmReportSelect
            With f
                .Parameters = New ArrayList

                'Dim pr As SqlClient.SqlParameter

                For Each pr2 As SqlClient.SqlParameter In MasterTable.SelectCommand.Parameters
                    'If pr2.ParameterName <> pr.ParameterName Then
                    .Parameters.Add(New SqlClient.SqlParameter(pr2.ParameterName, pr2.Value))
                    'End If
                Next

                .FormCode = Me.FormCode
                .PrintScript = ""
                If AppConn.ActiveUser.bAdmin Then .Parameters.Add(New SqlClient.SqlParameter("@bAdmin", 1)) Else .Parameters.Add(New SqlClient.SqlParameter("@bAdmin", 1))
                .Parameters.Add(New SqlClient.SqlParameter("@UserID", AppConn.ActiveUser.UserID))

                If bInvisible = False Then
                    .FormShow(DataSource)
                Else
                    .FormPrintInvisible(, DataSource)
                End If
            End With

            If TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                DataSource = CType(GridControl1.DataSource, NeoDAC.NeoTable)
                CType(DataSource, NeoDAC.NeoTable).DefaultView.RowFilter = ""
                CType(DataSource, NeoDAC.NeoTable).DefaultView.Sort = ""

            ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then

                DataSource = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable)
                CType(DataSource, NeoDAC.NeoTable).DefaultView.RowFilter = ""
                CType(DataSource, NeoDAC.NeoTable).DefaultView.Sort = ""

            ElseIf TypeOf GridControl1.DataSource Is DataTable Then
                DataSource = CType(GridControl1.DataSource, DataTable)
                CType(DataSource, DataTable).DefaultView.RowFilter = ""
                CType(DataSource, DataTable).DefaultView.Sort = ""
            
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSetDate_Today_Click(sender As Object, e As EventArgs) Handles btnSetDate_Today.Click
        chkDate1.Checked = True
        chkDate2.Checked = True
        dtFormDate1.DateTime = Today
        dtFormDate2.DateTime = Today
        FormDateRadioGroup_SelectedIndex = 0
    End Sub

    Private Sub btnSetDate_ThisMonth_Click(sender As Object, e As EventArgs) Handles btnSetDate_ThisMonth.Click
        chkDate1.Checked = True
        chkDate2.Checked = True
        dtFormDate1.DateTime = DateSerial(Today.Year, Today.Month, 1)
        dtFormDate2.DateTime = DateSerial(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))
        FormDateRadioGroup_SelectedIndex = 1
    End Sub

    Private Sub btnSetDate_ThisYear_Click(sender As Object, e As EventArgs) Handles btnSetDate_ThisYear.Click
        chkDate1.Checked = True
        chkDate2.Checked = True
        dtFormDate1.DateTime = DateSerial(Today.Year, 1, 1)
        dtFormDate2.DateTime = DateSerial(Today.Year, 12, 31)
        FormDateRadioGroup_SelectedIndex = 2
    End Sub

    Private Sub btnSetDate_Last3Months_Click(sender As Object, e As EventArgs) Handles btnSetDate_Last3Months.Click
        chkDate1.Checked = True
        chkDate2.Checked = True
        dtFormDate1.DateTime = Today.AddMonths(-3)
        dtFormDate2.DateTime = Today
        FormDateRadioGroup_SelectedIndex = 3
    End Sub

    Private Sub btnSetDate_Last6Months_Click(sender As Object, e As EventArgs) Handles btnSetDate_Last6Months.Click
        chkDate1.Checked = True
        chkDate2.Checked = True
        dtFormDate1.DateTime = Today.AddMonths(-6)
        dtFormDate2.DateTime = Today
        FormDateRadioGroup_SelectedIndex = 4
    End Sub

    Private Sub btnSetDate_Last1Year_Click(sender As Object, e As EventArgs) Handles btnSetDate_Last1Year.Click
        chkDate1.Checked = True
        chkDate2.Checked = True
        dtFormDate1.DateTime = Today.AddYears(-1)
        dtFormDate2.DateTime = Today
        FormDateRadioGroup_SelectedIndex = 5
    End Sub

    Private Sub frmBaseReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class


Public Class ReportFormRefreshEventArgs
    Inherits System.EventArgs
    Public Cancel As Boolean = False

End Class