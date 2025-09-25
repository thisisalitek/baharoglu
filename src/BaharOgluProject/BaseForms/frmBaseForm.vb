

Public Class frmBaseForm

#Region "Events"
    Public Event ButtonNewClick(ByVal Sender As Object, ByVal e As System.EventArgs)
    Public Event ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ButtonSaveAfterClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event ButtonCancelClick(ByVal Sender As Object, ByVal e As System.EventArgs)

    Public Event ButtonDeleteBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ButtonDeleteAfterClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event FormDateChange(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ButtonFormPrintBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ButtonFormPrintAfterClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event ButtonRefreshClick(ByVal Sender As Object, ByVal e As System.EventArgs)
    Public Event Before_FormShow(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event After_FormShow(ByVal Sender As Object, ByVal e As System.EventArgs)
    Public Event EditModeChanged(ByVal Sender As Object, ByVal e As System.EventArgs)
    Public Event ShowRecord(ByVal Sender As Object, ByVal e As System.EventArgs)

    Public Event BeforeImport(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event BeforeImportPrepare(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event AfterImport(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ImportData(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event BeforeImport_Detail1(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event BeforeImportPrepare_Detail1(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event AfterImport_Detail1(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ImportData_Detail1(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event BeforeImport_Detail2(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event BeforeImportPrepare_Detail2(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event AfterImport_Detail2(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ImportData_Detail2(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event BeforeImport_Detail3(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event BeforeImportPrepare_Detail3(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event AfterImport_Detail3(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ImportData_Detail3(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event BeforeImport_Detail4(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event BeforeImportPrepare_Detail4(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event AfterImport_Detail4(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ImportData_Detail4(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)

    Public Event BeforeImport_Detail5(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event BeforeImportPrepare_Detail5(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event AfterImport_Detail5(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)
    Public Event ImportData_Detail5(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs)




#End Region

#Region "Variables"


    Public ReturnDataRow As DataRow
    Public ReturnDataRows() As DataRow


    Public bSelectionMode As Boolean = False
    Public bNoAction As Boolean = False

    Private mVar_FormCode As String = ""
    Public Property FormCode() As String
        Get

            Return mVar_FormCode
        End Get
        Set(ByVal value As String)
            mVar_FormCode = value
        End Set
    End Property


    Private mVar_TableName As String = ""
    Public Property TableName() As String
        Get
            Return mVar_TableName
        End Get
        Set(ByVal value As String)
            mVar_TableName = value
        End Set
    End Property

    Private mVar_PrintScript As String = ""
    Public Property PrintScript() As String
        Get
            Return mVar_PrintScript
        End Get
        Set(ByVal value As String)
            mVar_PrintScript = value
        End Set
    End Property

    Private mVar_UseDataImport As Boolean = True
    Public Property UseDataImport() As Boolean
        Get
            Return mVar_UseDataImport
        End Get
        Set(ByVal value As Boolean)
            mVar_UseDataImport = value
        End Set
    End Property

    Private mVar_UseStandartImport As Boolean = True
    Public Property UseStandartImport() As Boolean
        Get
            Return mVar_UseStandartImport
        End Get
        Set(ByVal value As Boolean)
            mVar_UseStandartImport = value
        End Set
    End Property


    Dim bFormDateChanging As Boolean = False

    Public bFormOpenning As Boolean = False
    Public bMultiSelect As Boolean = False

    Public bNoPositionChange As Boolean = False
    Public IsDialog As Boolean = False

    Public ImportTable As New DataTable
    Public ImportDetailTable1 As New DataTable
    Public ImportDetailTable2 As New DataTable
    Public ImportDetailTable3 As New DataTable
    Public ImportDetailTable4 As New DataTable
    Public ImportDetailTable5 As New DataTable

    Private mVar_FillAuthCodes As Boolean = True
    Public Property FillAuthCodes() As Boolean
        Get

            Return mVar_FillAuthCodes
        End Get
        Set(ByVal value As Boolean)
            mVar_FillAuthCodes = value
        End Set
    End Property

#End Region

    Public bWaitMasterOpening As Boolean = False
    Dim bDisableBeforChanges_Off As Boolean = False
    Public bFormShowOneItem As Boolean = False
    Dim bAddingNew As Boolean = False
    Dim FormDateRadioGroup_SelectedIndex = 1

    Dim mVar_EditMode As Boolean = False
    Public Property EditMode() As Boolean
        Get
            Return mVar_EditMode
        End Get
        Set(ByVal value As Boolean)
            mVar_EditMode = value
            If value = True Then
                MasterTable.DefaultView.AllowEdit = True
                MasterTable.DefaultView.AllowNew = True
                MasterTable.DefaultView.AllowDelete = True
                DetailTable.DefaultView.AllowEdit = True
                DetailTable.DefaultView.AllowNew = True
                DetailTable.DefaultView.AllowDelete = True
                DetailTable2.DefaultView.AllowEdit = True
                DetailTable2.DefaultView.AllowNew = True
                DetailTable2.DefaultView.AllowDelete = True
                DetailTable3.DefaultView.AllowEdit = True
                DetailTable3.DefaultView.AllowNew = True
                DetailTable3.DefaultView.AllowDelete = True
                DetailTable4.DefaultView.AllowEdit = True
                DetailTable4.DefaultView.AllowNew = True
                DetailTable4.DefaultView.AllowDelete = True
                DetailTable5.DefaultView.AllowEdit = True
                DetailTable5.DefaultView.AllowNew = True
                DetailTable5.DefaultView.AllowDelete = True

                For Each dc As DataColumn In MasterTable.Columns
                    If dc.AutoIncrement = False Then
                        dc.ReadOnly = False
                    End If

                Next
                GridView1.ActiveFilter.Clear()
                DisableBeforChanges()
            Else

                MasterTable.DefaultView.AllowEdit = False
                MasterTable.DefaultView.AllowNew = False
                MasterTable.DefaultView.AllowDelete = False
                DetailTable.DefaultView.AllowEdit = False
                DetailTable.DefaultView.AllowNew = False
                DetailTable.DefaultView.AllowDelete = False
                DetailTable2.DefaultView.AllowEdit = False
                DetailTable2.DefaultView.AllowNew = False
                DetailTable2.DefaultView.AllowDelete = False
                DetailTable3.DefaultView.AllowEdit = False
                DetailTable3.DefaultView.AllowNew = False
                DetailTable3.DefaultView.AllowDelete = False
                DetailTable4.DefaultView.AllowEdit = False
                DetailTable4.DefaultView.AllowNew = False
                DetailTable4.DefaultView.AllowDelete = False
                DetailTable5.DefaultView.AllowEdit = False
                DetailTable5.DefaultView.AllowNew = False
                DetailTable5.DefaultView.AllowDelete = False
                For Each dc As DataColumn In MasterTable.Columns
                    If dc.AutoIncrement = False Then
                        dc.ReadOnly = True
                    End If
                Next
                EnableAfterChanges()
            End If


            RaiseEvent EditModeChanged(Me, Nothing)
        End Set
    End Property

    Public Sub FormShow(Optional ByVal bDialog As Boolean = True, Optional ByVal bControlMasterConn As Boolean = False, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal Owner As Form = Nothing)

        If bControlMasterConn Then
            If AppConn.mainConn.State <> ConnectionState.Open Then
                MsgBox("Piconn Master Veri tabanı bağlantısı yok!")
                Exit Sub
            End If
        End If
        If bControlFirmConn Then
            If AppConn.dbConn.State <> ConnectionState.Open Then
                MsgBox("Piconn Veri tabanı bağlantısı yok!")
                Exit Sub
            End If
        End If
        If InitFormSecurity() = False Then Exit Sub
        Dim e As New ItemFormSaveEventArgs
        RaiseEvent Before_FormShow(New Object, e)
        If e.Cancel Then Exit Sub
        IsDialog = bDialog
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
        RaiseEvent After_FormShow(New Object, New EventArgs)
    End Sub

    Public Sub FormSelect(Optional ByVal bControlMasterConn As Boolean = True, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal bMultiSelect_ As Boolean = False)
        If bControlMasterConn Then
            If AppConn.mainConn.State <> ConnectionState.Open Then
                MsgBox("Piconn Master Veri tabanı bağlantısı yok!")
                Exit Sub
            End If
        End If
        If bControlFirmConn Then
            If AppConn.dbConn.State <> ConnectionState.Open Then
                MsgBox("Piconn Veri tabanı bağlantısı yok!")
                Exit Sub
            End If
        End If
        panelBottom.Visible = True
        bSelectionMode = True
        bMultiSelect = bMultiSelect_
        If bMultiSelect Then
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Else
            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        End If
        If InitFormSecurity() = False Then Exit Sub
        Me.ShowDialog()

    End Sub



    Public Function FormShowOneItem(ByVal OneItemID As Object, Optional ByVal bDialog As Boolean = True, Optional ByVal bControlMasterConn As Boolean = False, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal Owner As Form = Nothing, Optional ByVal bCanEdit As Boolean = False, Optional ByVal bCanDelete As Boolean = False, Optional ByVal DontShow As Boolean = False) As Boolean
        Try


            bFormShowOneItem = True
            If bControlMasterConn Then
                If AppConn.mainConn.State <> ConnectionState.Open Then
                    MsgBox("Piconn Master connection does not exist.")
                    Return False
                End If
            End If
            If bControlFirmConn Then
                If AppConn.dbConn.State <> ConnectionState.Open Then
                    MsgBox("Piconn Firm connection does not exist.")
                    Return False
                End If
            End If
            If InitFormSecurity() = False Then Return False

            If bCanEdit = False Then
                BaseTab1.PageEnabled = False
                BaseTab1.PageVisible = False
                Bar1.Visible = False
            Else

                If bCanDelete = False Then
                    btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Else
                    btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If
            End If
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim sFilter As String = ""
            If MasterTable.SelectCommand.Parameters.Contains("@" & MasterTable.Columns(0).ColumnName) Then
                MasterTable.SelectCommand.Parameters("@" & MasterTable.Columns(0).ColumnName).Value = OneItemID
            Else
                MasterTable.SelectCommand.Parameters.Add(New SqlClient.SqlParameter("@" & MasterTable.Columns(0).ColumnName, OneItemID))
            End If
            sFilter = " AND " & MasterTable.Columns(0).ColumnName & " = @" & MasterTable.Columns(0).ColumnName & " "
            If InStr(UCase(MasterTable.SelectCommand.CommandText), "WHERE") > 0 Then
                MasterTable.SelectCommand.CommandText &= sFilter
            Else
                MasterTable.SelectCommand.CommandText &= " WHERE 1=1 " & sFilter
            End If




            XtraTabControl1.SelectedTabPage = BaseTab2

            If DontShow = False Then

                Try
                    LoadingShow()
                    Me.MdiParent = anaform
                    Me.Show()
                    LoadingHide()
                Catch ex As Exception
                    LoadingHide()
                    MsgBox(ex.Message)
                End Try
            Else
                frmItemForm_Load(Nothing, Nothing)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function InitFormSecurity() As Boolean
        Dim FormSec As New FormSecurity
        If Me.FormCode = "" Then
            Return True
        End If
        FormSec = AppConn.GetFormSecurity(Me.FormCode)
        With FormSec
            If .CanRead = False Then Return False
            If .CanWrite = False Then
                btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If .CanDelete = False Then
                btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
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
                    btnExportTXT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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

    Public Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        'tmrBekle.Enabled = True
        'Do While tmrBekle.Enabled
        '    Application.DoEvents()
        'Loop


        ShowCurrentRow(True)

    End Sub

    Public Sub ShowCurrentRow(Optional ByVal bShowTab1ToTab2 As Boolean = False, Optional ByVal bDontSelect As Boolean = False)
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            If bSelectionMode And bDontSelect = False Then
                cmdSelect_Click(Nothing, Nothing)
            Else
                'Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
                'Dim dr As DataRow = CType(GridControl1.DataSource, NeoDAC.NeoTable).Rows(RowIndex)
                'If dr Is Nothing Then Exit Sub
                'Application.DoEvents()
                'GetOneItem(dr(0))
                If bShowTab1ToTab2 Then
                    If XtraTabControl1.SelectedTabPageIndex = 0 Then
                        XtraTabControl1.SelectedTabPage = BaseTab2
                    End If
                End If

                RaiseEvent ShowRecord(New Object, New EventArgs)

            End If
        Catch ex As Exception
            MsgBox("(ShowCurrentRow) " & ex.Message)
        End Try
    End Sub

    Private Sub GetOneItem(ByVal OneItemID As Long)
        If MasterTable.SelectCommand.Parameters.Contains("@FormDate1") = True Then
            MasterTable.SelectCommand.Parameters("@FormDate1").Value = DateSerial(1899, 12, 30)
        End If
        If MasterTable.SelectCommand.Parameters.Contains("@FormDate2") = True Then
            MasterTable.SelectCommand.Parameters("@FormDate2").Value = DateSerial(2099, 12, 31)

        End If


        Dim sFilter As String = ""
        If MasterTable.SelectCommand.Parameters.Contains("@" & MasterTable.Columns(0).ColumnName) Then
            MasterTable.SelectCommand.Parameters("@" & MasterTable.Columns(0).ColumnName).Value = OneItemID
        Else
            MasterTable.SelectCommand.Parameters.Add(New SqlClient.SqlParameter("@" & MasterTable.Columns(0).ColumnName, OneItemID))
        End If
        sFilter = " AND " & MasterTable.Columns(0).ColumnName & " = @" & MasterTable.Columns(0).ColumnName & " "
        If InStr(UCase(MasterTable.SelectCommand.CommandText), "WHERE") > 0 Then
            MasterTable.SelectCommand.CommandText &= sFilter
        Else
            MasterTable.SelectCommand.CommandText &= " WHERE 1=1 " & sFilter
        End If
        bWaitMasterOpening = True
        MasterTable.Rows.Clear()
        OpenTable(MasterTable)
        bWaitMasterOpening = False
        MasterLink_PositionChanged_BaseForm(Nothing, Nothing)
        RaiseEvent ShowRecord(Nothing, Nothing)
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

    Private Sub frmItemForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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

    Private Sub frmBaseForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Bar1.Visible Then
                If btnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always And btnCancel.Enabled = True Then
                    If MsgBox(BaseTText("Form verileri değişti. Kaydetmeden çıkmak istedinize emin misiniz?"), MsgBoxStyle.Information + MsgBoxStyle.YesNo, BaseTText("Çıkış?")) <> MsgBoxResult.Yes Then
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub frmItemForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If bSelectionMode Then
            Select Case e.KeyCode
                Case Keys.F2
                    cmdSelect_Click(Nothing, Nothing)
                Case Keys.Escape
                    cmdCancel_Click(Nothing, Nothing)

            End Select
        Else
            Select Case e.KeyCode
                Case Keys.F6
                    GridControl1_DoubleClick(Nothing, Nothing)
            End Select
        End If

        If e.KeyCode = Keys.L And e.Control = True And e.Alt = True Then
            'ShowLanguageOptions(Me.Name, AppConn)
        End If

        'Select Case e.KeyCode
        '    Case Keys.F5
        '        If btnRefresh.Enabled And btnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
        '            btnRefresh_ItemClick(Nothing, Nothing)
        '        End If
        'End Select
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        Dim dr As DataRow
        Dim dt As New DataTable




        Try
            If GridView1.GetSelectedRows().Count <= 0 Then
                MsgBox(BaseTText("Hiç seçili nesne yok!"))
                Exit Sub

            End If
            ReDim ReturnDataRows(0)

            For i As Integer = 0 To GridView1.GetSelectedRows().Length - 1
                ReDim Preserve ReturnDataRows(UBound(ReturnDataRows) + 1)
                If TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                    ReturnDataRows(UBound(ReturnDataRows)) = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable).Rows(GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i)))
                ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                    ReturnDataRows(UBound(ReturnDataRows)) = CType(GridControl1.DataSource, NeoDAC.NeoTable).Rows(GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i)))
                ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                    ReturnDataRows(UBound(ReturnDataRows)) = CType(GridControl1.DataSource, NeoDAC.NeoTable).Rows(GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i)))
                End If

            Next
            ReturnDataRow = ReturnDataRows(1)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub DisableBeforChanges()
        Try

            If bDisableBeforChanges_Off = True Then Exit Sub
            'If bAddingNew = False Then
            '    If XtraTabControl1.SelectedTabPageIndex = 0 Then Exit Sub
            'End If

            For i As Integer = 0 To Bar1.LinksPersistInfo.Count - 1
                If Bar1.LinksPersistInfo.Item(i).Item.Name = btnSave.Name Then
                    Bar1.LinksPersistInfo.Item(i).Item.Enabled = True
                ElseIf Bar1.LinksPersistInfo.Item(i).Item.Name = btnCancel.Name Then
                    Bar1.LinksPersistInfo.Item(i).Item.Enabled = True
                ElseIf Bar1.LinksPersistInfo.Item(i).Item.Name = btnApprove.Name Or Bar1.LinksPersistInfo.Item(i).Item.Name = btnDisapprove.Name Then
                    'Bişey yapma
                Else

                    Bar1.LinksPersistInfo.Item(i).Item.Enabled = False
                End If
            Next

            If bSelectionMode Then
                cmdSelect.Enabled = False
                cmdCancel.Enabled = False
            End If
            GridControl1.Enabled = False
            If XtraTabControl1.SelectedTabPage.Handle = BaseTab1.Handle Then
                XtraTabControl1.SelectedTabPage = BaseTab2
            End If
            panelFormDateFilter.Enabled = False

            BaseTab1.PageEnabled = False

           
            'conMenuDocuments.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub EnableAfterChanges()
        Try

            For i As Integer = 0 To Bar1.LinksPersistInfo.Count - 1
                If Bar1.LinksPersistInfo.Item(i).Item.Name = btnSave.Name Then
                    Bar1.LinksPersistInfo.Item(i).Item.Enabled = False
                ElseIf Bar1.LinksPersistInfo.Item(i).Item.Name = btnCancel.Name Then
                    Bar1.LinksPersistInfo.Item(i).Item.Enabled = False
                ElseIf Bar1.LinksPersistInfo.Item(i).Item.Name = btnApprove.Name Or Bar1.LinksPersistInfo.Item(i).Item.Name = btnDisapprove.Name Then
                    'Bişey yapma
                Else
                    Bar1.LinksPersistInfo.Item(i).Item.Enabled = True
                End If
            Next

            If bSelectionMode Then
                cmdSelect.Enabled = True
                cmdCancel.Enabled = True
            End If
            GridControl1.Enabled = True
            panelFormDateFilter.Enabled = True
            BaseTab1.PageEnabled = True

            'If Not GridControl1.DataSource Is Nothing Then
            '    If TypeOf GridControl1.DataSource Is C1.Data.Express.C1ExpressView Then

            '        CType(GridControl1.DataSource, C1.Data.Express.C1ExpressView).RowStateFilter = C1.Data.DataViewRowStateEnum.CurrentRows
            '    End If
            'End If

        
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#Region "Bar Butons"

    Public Sub btnRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        Dim bRefresh As Boolean = False
        Try
            'Dim ID As Long = 0
            'If bAddingNew Then
            '    ID = If0Null(MasterLink.CurrentRow(0))
            'End If

            Dim OldFocusedRowHandle As Integer = GridView1.FocusedRowHandle
            SetMasterFormDateParameters()
            bNoAction = True
            If Not GridControl1.DataSource Is Nothing Then
                If TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                    'CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable).Close()
                    'CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable).Open()
                    bWaitMasterOpening = True
                    OpenTable(CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable))
                    bWaitMasterOpening = False
                    MasterLink_PositionChanged_BaseForm(Nothing, Nothing)
                    bRefresh = True
                ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                    'CType(GridControl1.DataSource, NeoDAC.NeoTable).Close()
                    'CType(GridControl1.DataSource, NeoDAC.NeoTable).Open()
                    bWaitMasterOpening = True
                    OpenTable(CType(GridControl1.DataSource, NeoDAC.NeoTable))
                    bWaitMasterOpening = False

                    MasterLink_PositionChanged_BaseForm(Nothing, Nothing)
                    bRefresh = True
                End If
            End If
            If bAddingNew = False Then
                If OldFocusedRowHandle >= 0 And GridView1.RowCount > 0 Then
                    If GridView1.RowCount - 1 >= OldFocusedRowHandle Then
                        GridView1.FocusedRowHandle = OldFocusedRowHandle
                    Else
                        GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    End If
                End If
                If GridView1.FocusedRowHandle >= 0 Then
                    'GridControl1_DoubleClick(Nothing, Nothing)

                    ShowCurrentRow(False, True)
                End If
            End If

        Catch ex As Exception
            MsgBox("(btnRefresh_ItemClick) " & ex.Message)
        End Try
        bWaitMasterOpening = False
        bNoAction = False
        If bRefresh = True Then
            RaiseEvent ButtonRefreshClick(sender, e)
        End If

    End Sub

    Public Sub btnNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        Try

            bNoAction = True
            If Not GridControl1.DataSource Is Nothing Then


                If Not MasterTable Is Nothing Then
                    If MasterTable.Active = False Then
                        MasterTable.Active = True
                    End If
                    EditMode = True

                    Dim dr As DataRow
                    dr = MasterTable.NewRow
                    If MasterTable.Columns(0).DataType.ToString = GetType(System.Guid).ToString Then
                        dr(0) = Guid.NewGuid

                        MasterTable.Rows.Add(dr)
                        MasterLink.MoveLast()
                    Else
                        If MasterTable.Columns.Contains("Deleted") Then
                            dr("Deleted") = -1
                        End If


                        MasterTable.Rows.Add(dr)

                        MasterTable.Save()

                        MasterLink.MoveLast()
                    End If




                    bNoAction = False

                    MasterLink_PositionChanged_BaseForm(Nothing, Nothing)

                    bAddingNew = True
                    'DisableBeforChanges()
                    'bAddingNew = False
                    EmtyListControl()
                    XtraTabControl1.SelectedTabPage = BaseTab2
                    RaiseEvent ButtonNewClick(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox("(btnNew_ItemClick) " & ex.Message)
        End Try
        bNoAction = False
        'bAddingNew = False
    End Sub


#End Region



    Private Sub tmrBekle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBekle.Tick
        tmrBekle.Enabled = False
    End Sub

    Private Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        bDisableBeforChanges_Off = True
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = 0
        End If
        Application.DoEvents()
        bDisableBeforChanges_Off = False
    End Sub

    Private Sub btnPrior_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrior.ItemClick
        bDisableBeforChanges_Off = True
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle > 0 Then
                GridView1.FocusedRowHandle -= 1
            End If
        End If
        Application.DoEvents()
        bDisableBeforChanges_Off = False
    End Sub

    Private Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        bDisableBeforChanges_Off = True
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle < GridView1.RowCount - 1 Then
                GridView1.FocusedRowHandle += 1
            End If
        End If
        Application.DoEvents()
        bDisableBeforChanges_Off = False
    End Sub

    Private Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        bDisableBeforChanges_Off = True
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        End If
        Application.DoEvents()
        bDisableBeforChanges_Off = False
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

    Private Sub dtFormDate1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFormDate1.EditValueChanged
        If bFormDateChanging Then Exit Sub
        bFormDateChanging = True
        RaiseEvent FormDateChange(sender, e)
        bFormDateChanging = False
    End Sub

   
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()



    End Sub


    Private Sub frmItemForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub

            If AppConn.dbConnStr = "" Then Exit Sub
            If AppConn.ApplicationCode Is Nothing Then
                'MsgBox("ApplicationCode belirtilmemiş!")
                'Exit Sub
                AppConn.ApplicationCode = "PiconnCevahir"
            End If
            Dim sBuf As String = ""

            'UST TARIH FILTRESI

            Try
                If bFormShowOneItem = False Then
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
                    If bFormShowOneItem = True Then
                        dtFormDate1.DateTime = DateSerial(1899, 12, 30)
                        dtFormDate2.DateTime = DateSerial(2099, 12, 31)
                        panelFormDateFilter.Visible = False
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
                Else
                    'dtFormDate1.DateTime = DateSerial(AppConn.Today.Year, 1, 1)
                    'dtFormDate2.DateTime = AppConn.Today
                End If



            Catch ex As Exception

            End Try

            '----------------------



            bNoAction = True
            bFormOpenning = True

            InitializeConnections()



            Set_UserInfo_Parameters()

            If MasterTable.Columns.Count <= 0 Then
                MsgBox("LÜTFEN TABLO KOLONLARINI CREATE EDINIZ!")
            End If

            Set_DataTables_TableName()
            EditMode = False

            RefreshAuthCodes()

            Dim bRunPositionChange As Boolean = False

            If DetailTable.Columns.Count > 0 And Not DetailTable.SelectCommand Is Nothing Then
                OpenTable(DetailTable)
            End If
            If DetailTable2.Columns.Count > 0 And Not DetailTable2.SelectCommand Is Nothing Then
                OpenTable(DetailTable2)
            End If
            If DetailTable3.Columns.Count > 0 And Not DetailTable3.SelectCommand Is Nothing Then
                OpenTable(DetailTable3)
            End If
            If DetailTable4.Columns.Count > 0 And Not DetailTable4.SelectCommand Is Nothing Then
                OpenTable(DetailTable4)
            End If
            If DetailTable5.Columns.Count > 0 And Not DetailTable5.SelectCommand Is Nothing Then
                OpenTable(DetailTable5)
            End If
            btnRefresh_ItemClick(Nothing, Nothing)



            LoadGridView(Me.FormCode, GridView1)

            GridView1.ClearColumnsFilter()

            RaiseEvent FormDateChange(sender, e)
            EnableAfterChanges()

            GridView1_RowCountChanged(Nothing, Nothing)

          


            '--- Grid Menu ----------
            If Not GridControl1.ContextMenuStrip Is Nothing Then

                If GridControl1.ContextMenuStrip.Name = conMenuGrid.Name Then

                Else
                    'Dim conMenu1 As System.Windows.Forms.ContextMenuStrip = CType( , System.Windows.Forms.ContextMenuStrip)
                    GridControl1.ContextMenuStrip.Items.Add("-")
                    Do While conMenuGrid.Items.Count > 0
                        Dim m As System.Windows.Forms.ToolStripItem = conMenuGrid.Items(0)
                        conMenuGrid.Items.Remove(m)

                        GridControl1.ContextMenuStrip.Items.Add(m)
                    Loop
                End If
            End If

            If mVar_UseDataImport = False Then
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            If bFormShowOneItem Then
                ShowCurrentRow(True)
            ElseIf bSelectionMode = False Then
                ShowCurrentRow(False)
            End If


        Catch ex As Exception
            MsgBox("(frmItemForm_Load) " & ex.Message)
        End Try
        bNoAction = False
        bFormOpenning = False
        bWaitMasterOpening = False

        'Try

        '    AppConn.PiconnLanguage.WalkInControl(Me.Name, Me)
        '    Application.DoEvents()
        '    If InStr(Me.Text, Me.FormCode) <= 0 Then Me.Text &= "  (" & Me.FormCode & ")"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Set_UserInfo_Parameters()
        Try
            If MasterTable.Columns.Contains("CreatedBy") Then
                If MasterTable.InsertCommand.Parameters.Contains("@CreatedBy") Then
                    MasterTable.InsertCommand.Parameters("@CreatedBy").Value = AppConn.ActiveUser.UserID
                End If
                If MasterTable.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    MasterTable.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If
            If MasterTable.Columns.Contains("ModifiedBy") Then
                If MasterTable.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    MasterTable.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If
                If MasterTable.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    MasterTable.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If

            If DetailTable.Columns.Contains("CreatedBy") Then
                If DetailTable.InsertCommand.Parameters.Contains("@CreatedBy") Then
                    DetailTable.InsertCommand.Parameters("@CreatedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If
            If DetailTable.Columns.Contains("ModifiedBy") Then
                If DetailTable.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If

            If DetailTable2.Columns.Contains("CreatedBy") Then
                If DetailTable2.InsertCommand.Parameters.Contains("@CreatedBy") Then
                    DetailTable2.InsertCommand.Parameters("@CreatedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable2.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable2.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If
            If DetailTable2.Columns.Contains("ModifiedBy") Then
                If DetailTable2.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable2.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable2.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable2.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If

            If DetailTable3.Columns.Contains("CreatedBy") Then
                If DetailTable3.InsertCommand.Parameters.Contains("@CreatedBy") Then
                    DetailTable3.InsertCommand.Parameters("@CreatedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable3.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable3.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If
            If DetailTable3.Columns.Contains("ModifiedBy") Then
                If DetailTable3.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable3.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable3.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable3.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If

            If DetailTable4.Columns.Contains("CreatedBy") Then
                If DetailTable4.InsertCommand.Parameters.Contains("@CreatedBy") Then
                    DetailTable4.InsertCommand.Parameters("@CreatedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable4.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable4.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If
            If DetailTable4.Columns.Contains("ModifiedBy") Then
                If DetailTable4.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable4.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable4.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable4.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If

            If DetailTable5.Columns.Contains("CreatedBy") Then
                If DetailTable5.InsertCommand.Parameters.Contains("@CreatedBy") Then
                    DetailTable5.InsertCommand.Parameters("@CreatedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable5.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable5.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If
            If DetailTable5.Columns.Contains("ModifiedBy") Then
                If DetailTable5.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable5.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If
                If DetailTable5.InsertCommand.Parameters.Contains("@ModifiedBy") Then
                    DetailTable5.InsertCommand.Parameters("@ModifiedBy").Value = AppConn.ActiveUser.UserID
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Public Sub SetMasterFormDateParameters()
        Try
            Dim dtGridTable As New NeoDAC.NeoTable(Me.components)
            If TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                dtGridTable = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable)

            ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                dtGridTable = CType(GridControl1.DataSource, NeoDAC.NeoTable)
            End If

            If dtGridTable.SelectCommand Is Nothing Then Exit Sub
            If dtGridTable.SelectCommand.Parameters.Contains("@FormDate1") = True Then
                If chkDate1.Checked Then
                    dtGridTable.SelectCommand.Parameters("@FormDate1").Value = dtFormDate1.DateTime
                Else
                    dtGridTable.SelectCommand.Parameters("@FormDate1").Value = DateSerial(1899, 12, 30)
                End If

            End If
            If dtGridTable.SelectCommand.Parameters.Contains("@FormDate2") = True Then
                If chkDate2.Checked Then
                    If dtFormDate2.DateTime < DateSerial(1899, 12, 30) Then dtFormDate2.DateTime = DateSerial(1899, 12, 30)
                    Dim tmpTarih2 As DateTime = dtFormDate2.DateTime
                    tmpTarih2 = DateAdd(DateInterval.Hour, 23, tmpTarih2)
                    tmpTarih2 = DateAdd(DateInterval.Minute, 59, tmpTarih2)
                    tmpTarih2 = DateAdd(DateInterval.Second, 59, tmpTarih2)

                    dtGridTable.SelectCommand.Parameters("@FormDate2").Value = tmpTarih2


                Else
                    dtGridTable.SelectCommand.Parameters("@FormDate2").Value = DateSerial(2099, 12, 31)
                End If
            End If



        Catch ex As Exception
            MsgBox("(SetMasterFormDateParameters) " & ex.Message)
        End Try
    End Sub

    Public Function CreateCopy(Optional ByVal bDetailTable1 As Boolean = True, Optional ByVal bDetailTable2 As Boolean = True, Optional ByVal bDetailTable3 As Boolean = True, Optional ByVal bDetailTable4 As Boolean = True, Optional ByVal bDetailTable5 As Boolean = True) As Boolean
        Try
            If MasterLink.CurrentRow Is Nothing Then Return False
            bNoAction = True
            EditMode = True
            Dim master_dr As DataRow
            master_dr = MasterTable.NewRow
            For Each dc As DataColumn In MasterTable.Columns
                Try
                    If dc.AutoIncrement = False Then
                        master_dr(dc.ColumnName) = MasterLink.CurrentRow(dc.ColumnName)
                    End If
                Catch ex As Exception

                End Try
            Next
            If MasterTable.Columns.Contains("Deleted") Then
                master_dr("Deleted") = -1
            End If

            MasterTable.Rows.Add(master_dr)
            MasterTable.Save()

            If DetailTable.Columns.Count > 0 And bDetailTable1 = True Then
                Dim copyDetailTable As New NeoDAC.NeoTable(Me.components)
                copyDetailTable = DetailTable.Copy()
                DetailTable.Rows.Clear()
                For Each dr As DataRow In copyDetailTable.Rows
                    dr(DetailTable.ParentRelation_ChildColumns(0)) = master_dr(DetailTable.ParentRelation_ParentColumns(0))
                    Dim newDr As DataRow
                    newDr = DetailTable.NewRow
                    For Each dc As DataColumn In copyDetailTable.Columns
                        If dc.AutoIncrement = False Then
                            newDr(dc.ColumnName) = dr(dc.ColumnName)
                        End If
                    Next
                    DetailTable.Rows.Add(newDr)
                Next


            End If

            If DetailTable2.Columns.Count > 0 And bDetailTable2 = True Then
                Dim copyDetailTable2 As New NeoDAC.NeoTable(Me.components)
                copyDetailTable2 = DetailTable2.Copy()
                DetailTable2.Rows.Clear()
                For Each dr As DataRow In copyDetailTable2.Rows
                    dr(DetailTable2.ParentRelation_ChildColumns(0)) = master_dr(DetailTable2.ParentRelation_ParentColumns(0))
                    Dim newDr As DataRow
                    newDr = DetailTable2.NewRow
                    For Each dc As DataColumn In copyDetailTable2.Columns
                        If dc.AutoIncrement = False Then
                            newDr(dc.ColumnName) = dr(dc.ColumnName)
                        End If
                    Next
                    DetailTable2.Rows.Add(newDr)
                Next

            End If

            If DetailTable3.Columns.Count > 0 And bDetailTable3 = True Then
                Dim copyDetailTable3 As New NeoDAC.NeoTable(Me.components)
                copyDetailTable3 = DetailTable3.Copy()
                DetailTable3.Rows.Clear()
                For Each dr As DataRow In copyDetailTable3.Rows

                    dr(DetailTable3.ParentRelation_ChildColumns(0)) = master_dr(DetailTable3.ParentRelation_ParentColumns(0))
                    Dim newDr As DataRow
                    newDr = DetailTable3.NewRow
                    For Each dc As DataColumn In copyDetailTable3.Columns
                        If dc.AutoIncrement = False Then
                            newDr(dc.ColumnName) = dr(dc.ColumnName)
                        End If
                    Next
                    DetailTable3.Rows.Add(newDr)
                Next

            End If

            If DetailTable4.Columns.Count > 0 And bDetailTable4 = True Then
                Dim copyDetailTable4 As New NeoDAC.NeoTable(Me.components)
                copyDetailTable4 = DetailTable4.Copy()
                DetailTable4.Rows.Clear()
                For Each dr As DataRow In copyDetailTable4.Rows
                    dr(DetailTable4.ParentRelation_ChildColumns(0)) = master_dr(DetailTable4.ParentRelation_ParentColumns(0))
                    Dim newDr As DataRow
                    newDr = DetailTable4.NewRow
                    For Each dc As DataColumn In copyDetailTable4.Columns
                        If dc.AutoIncrement = False Then
                            newDr(dc.ColumnName) = dr(dc.ColumnName)
                        End If
                    Next
                    DetailTable4.Rows.Add(newDr)
                Next

            End If

            If DetailTable5.Columns.Count > 0 And bDetailTable5 = True Then
                Dim copyDetailTable5 As New NeoDAC.NeoTable(Me.components)
                copyDetailTable5 = DetailTable5.Copy()
                DetailTable5.Rows.Clear()
                For Each dr As DataRow In copyDetailTable5.Rows
                    dr(DetailTable5.ParentRelation_ChildColumns(0)) = master_dr(DetailTable5.ParentRelation_ParentColumns(0))
                    Dim newDr As DataRow
                    newDr = DetailTable5.NewRow
                    For Each dc As DataColumn In copyDetailTable5.Columns
                        If dc.AutoIncrement = False Then
                            newDr(dc.ColumnName) = dr(dc.ColumnName)
                        End If
                    Next
                    DetailTable5.Rows.Add(newDr)
                Next

            End If

            bNoPositionChange = True
            MasterLink.MoveLast()
            bNoPositionChange = False
            bNoAction = False
            'MasterLink_PositionChanged_BaseForm(Nothing, Nothing)


            DisableBeforChanges()
            bNoPositionChange = False
            bNoAction = False
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoPositionChange = False
        bNoAction = False
        Return False
    End Function

   
    Private Sub btnExportExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportExcel.ItemClick
        GridExport(typePiconnExport.XLS, dlgExport, GridView1)
    End Sub

    Private Sub btnExportPDF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportPDF.ItemClick
        GridExport(typePiconnExport.PDF, dlgExport, GridView1)
    End Sub

    Private Sub btnExportTXT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportTXT.ItemClick
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


    Private Sub btnHelp_ShortCuts_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHelp_ShortCuts.ItemClick
        'Dim f As New PiconnHelp.frmItemFormShortCuts
        'With f
        '    .FormShow()
        '    .Dispose()
        'End With
    End Sub

  




    Private Sub btnCancel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Try

            If btnCancel.Visibility <> DevExpress.XtraBars.BarItemVisibility.Always Or btnCancel.Enabled = False Then Exit Sub
            If MasterTable.Active = False Then Exit Sub
            If MasterLink.Position < 0 Then Exit Sub
            If MsgBox(BaseTText("Yaptığınız değişiklikler geri alınacak, emin misiniz?"), MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, BaseTText("Vazgeç?")) <> MsgBoxResult.Yes Then Exit Sub
            If MasterTable.Active Then MasterTable.RejectChanges()
            If DetailTable.Active Then DetailTable.RejectChanges()
            If DetailTable2.Active Then DetailTable2.RejectChanges()
            If DetailTable3.Active Then DetailTable3.RejectChanges()
            If DetailTable4.Active Then DetailTable4.RejectChanges()
            If DetailTable5.Active Then DetailTable5.RejectChanges()

            If bAddingNew Then
                btnRefresh_ItemClick(Nothing, Nothing)
            End If
            bNoAction = True

            GridControl1_DoubleClick(Nothing, Nothing)
            RaiseEvent ButtonCancelClick(sender, e)
        Catch ex As Exception
            MsgBox("(btnCancel_ItemClick) " & ex.Message)
        End Try
        EditMode = False
        bNoPositionChange = False
        bNoAction = False
        bAddingNew = False
        bWaitMasterOpening = False
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try


            If Bar1.Visible = False Then Exit Sub
            If btnDelete.Visibility <> DevExpress.XtraBars.BarItemVisibility.Always Or btnDelete.Enabled = False Then Exit Sub
            txtTopInfo.Focus()
            If Delete(sender, e) = True Then
                XtraTabControl1.SelectedTabPageIndex = 0
                btnRefresh_ItemClick(Nothing, Nothing)
                bAddingNew = False
            Else
                EditMode = False
            End If
        Catch ex As Exception
            EditMode = False
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Delete(ByVal sender As Object, ByVal e As EventArgs) As Boolean

        Dim SQL As String = "", sbuf As String = ""
        Dim trans As SqlClient.SqlTransaction
        Try

            Delete = False

            If MasterTable.Active = False Then Exit Function
            If MasterLink.CurrentRow Is Nothing Then Exit Function
            If MasterLink.Position < 0 Then Exit Function

            Dim e1 As New ItemFormSaveEventArgs

            ShowCurrentRow(True)

            RaiseEvent ButtonDeleteBeforeClick(sender, e1)
            If e1.Cancel Then
                Exit Function
            End If

            If MsgBox(BaseTText("Kaydı silmek istediğinizden emin misiniz?"), MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, BaseTText("Sil?")) <> MsgBoxResult.Yes Then GoTo Cikis

            EditMode = True

            bNoAction = True

            trans = MasterTable.Connection.BeginTransaction(IsolationLevel.ReadUncommitted)
            MasterTable.Transaction = trans

            MasterLink.CurrentRow.Delete()
            MasterTable.Save()



            RaiseEvent ButtonDeleteAfterClick(sender, e1)
            If e1.Cancel Then
                trans.Rollback()
                Return False
            End If

            trans.Commit()
            Delete = True
        Catch ex As Exception
            Delete = False
            If Not trans Is Nothing Then trans.Rollback()

            MsgBox("(Delete) " & ex.Message)
            bNoPositionChange = False
            bNoAction = False
            Exit Function
        End Try
Cikis:
        EditMode = False
        bNoPositionChange = False
        bNoAction = False

    End Function

    Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If Bar1.Visible = False Then Exit Sub
        If btnSave.Visibility <> DevExpress.XtraBars.BarItemVisibility.Always Or btnSave.Enabled = False Then Exit Sub
        txtTopInfo.Focus()
        If Save(sender, e) = True Then

            btnRefresh_ItemClick(Nothing, Nothing)
            bAddingNew = False
        End If
    End Sub

    Public Function Save(ByVal sender As Object, ByVal e As EventArgs) As Boolean

        Dim SQL As String = "", sbuf As String = ""
        Dim trans As SqlClient.SqlTransaction
        Try

            Save = False

            If MasterTable.Active = False Then Exit Function
            If MasterLink.CurrentRow Is Nothing Then Exit Function
            If MasterLink.Position < 0 Then Exit Function

            Dim e1 As New ItemFormSaveEventArgs


            RaiseEvent ButtonSaveBeforeClick(sender, e1)
            If e1.Cancel Then
                Exit Function
            End If
            Dim ret As MsgBoxResult = MsgBox(BaseTText("Kaydetmek istediğinizden emin misiniz?"), MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, BaseTText("Kaydet?"))

            If ret = MsgBoxResult.No Then
                If MasterTable.Active Then MasterTable.RejectChanges()
                If DetailTable.Active Then DetailTable.RejectChanges()
                If DetailTable2.Active Then DetailTable2.RejectChanges()
                If DetailTable3.Active Then DetailTable3.RejectChanges()
                If DetailTable4.Active Then DetailTable4.RejectChanges()
                If DetailTable5.Active Then DetailTable5.RejectChanges()

                GoTo Cikis
            End If
            If ret = MsgBoxResult.Cancel Then
                Return False
            End If


            trans = MasterTable.Connection.BeginTransaction(IsolationLevel.ReadUncommitted)
            MasterTable.Transaction = trans

            bNoAction = True
            If MasterTable.Columns.Contains("Deleted") Then
                MasterLink.CurrentRow("Deleted") = 0
            End If

            If MasterLink.CurrentRow.IsEdit Then
                MasterLink.CurrentRow.EndEdit()
            End If


            Save = MasterTable.Save()
            bNoPositionChange = False
            bNoAction = False

            RaiseEvent ButtonSaveAfterClick(sender, e1)
            If e1.Cancel Then
                trans.Rollback()
                Return False
            End If
            trans.Commit()

        Catch ex As Exception
            Save = False
            If Not trans Is Nothing Then trans.Rollback()
            MsgBox("(Save) " & ex.Message)

            bNoPositionChange = False
            bNoAction = False
            Exit Function
        End Try
Cikis:
        EditMode = False
        bNoPositionChange = False
        bNoAction = False

    End Function



    Private Function ColumnReplaceValue(ByVal Sql As String, ByVal dc As DataColumn, ByVal dr As DataRow) As String
        Try
            Dim sbuf As String = Sql
            sbuf = Replace(sbuf, "@" & dc.ColumnName & ",", "@" & dc.ColumnName & "@,")
            sbuf = Replace(sbuf, "@" & dc.ColumnName & " ", "@" & dc.ColumnName & "@ ")
            sbuf = Replace(sbuf, "@" & dc.ColumnName & ")", "@" & dc.ColumnName & "@)")

            Select Case dc.DataType.ToString
                Case GetType(Double).ToString, GetType(Single).ToString
                    sbuf = Replace(sbuf, "@" & dc.ColumnName & "@", CommaToPoint(If0Null(dr(dc.ColumnName))))
                Case GetType(Date).ToString, GetType(DateTime).ToString
                    sbuf = Replace(sbuf, "@" & dc.ColumnName & "@", SQLDateTime(IfNull(dr(dc.ColumnName), DateSerial(1900, 1, 1))))
                Case GetType(String).ToString, GetType(Char).ToString
                    sbuf = Replace(sbuf, "@" & dc.ColumnName & "@", "'" & Replace(IfNull(dr(dc.ColumnName), ""), "'", "''") & "'")
                Case GetType(Byte()).ToString
                    If IsDBNull(dr(dc.ColumnName)) Then
                        sbuf = Replace(sbuf, "@" & dc.ColumnName & "@", "null")
                    Else
                        Dim b() As Byte = dr(dc.ColumnName)
                        Dim sHexByte As String = "null"
                        If b.Length > 0 Then
                            sHexByte = BitConverter.ToString(b)
                            sHexByte = Replace(sHexByte, "-", "")
                            sHexByte = "0x" & sHexByte
                        End If

                        'sHexByte.Replace("-", "")

                        'For i As Integer = 0 To b.Length - 1

                        '    sHexByte &= Format(b(i), "X2")


                        'Next
                        sbuf = Replace(sbuf, "@" & dc.ColumnName & "@", sHexByte)
                    End If

                Case Else
                    sbuf = Replace(sbuf, "@" & dc.ColumnName & "@", If0Null(dr(dc.ColumnName)))
            End Select

            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Sql
    End Function
    'Private Sub MasterTable_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
    '    If EditMode = False Then

    '    End If
    '    'If bNoAction Then Exit Sub
    '    'If bNoPositionChange Then Exit Sub
    '    'If bFormOpenning Then Exit Sub

    '    'bNoAction = True
    '    'DisableBeforChanges()
    '    'bNoAction = False

    'End Sub

    Private Function GetTableName() As String
        Try
            If MasterTable.UpdateCommand Is Nothing Then Return ""
            If MasterTable.UpdateCommand.CommandText = "" Then Return ""

            Return GetTableNameFromUpdateCommand(MasterTable.UpdateCommand.CommandText)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Private Sub Set_DataTables_TableName()
        Try
            If Not MasterTable.UpdateCommand Is Nothing Then
                If MasterTable.UpdateCommand.CommandText <> "" Then
                    MasterTable.TableName = GetTableNameFromUpdateCommand(MasterTable.UpdateCommand.CommandText)
                End If
            End If

            If Not DetailTable.UpdateCommand Is Nothing Then
                If DetailTable.UpdateCommand.CommandText <> "" Then
                    DetailTable.TableName = GetTableNameFromUpdateCommand(DetailTable.UpdateCommand.CommandText)
                End If
            End If
            If Not DetailTable2.UpdateCommand Is Nothing Then
                If DetailTable2.UpdateCommand.CommandText <> "" Then
                    DetailTable2.TableName = GetTableNameFromUpdateCommand(DetailTable2.UpdateCommand.CommandText)
                End If
            End If
            If Not DetailTable3.UpdateCommand Is Nothing Then
                If DetailTable3.UpdateCommand.CommandText <> "" Then
                    DetailTable3.TableName = GetTableNameFromUpdateCommand(DetailTable3.UpdateCommand.CommandText)
                End If
            End If
            If Not DetailTable4.UpdateCommand Is Nothing Then
                If DetailTable4.UpdateCommand.CommandText <> "" Then
                    DetailTable4.TableName = GetTableNameFromUpdateCommand(DetailTable4.UpdateCommand.CommandText)
                End If
            End If
            If Not DetailTable5.UpdateCommand Is Nothing Then
                If DetailTable5.UpdateCommand.CommandText <> "" Then
                    DetailTable5.TableName = GetTableNameFromUpdateCommand(DetailTable5.UpdateCommand.CommandText)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function GetTableNameFromUpdateCommand(ByVal UpdateCommandText As String) As String
        Try
            Dim sbuf As String
            Dim i As Integer = 0
            Dim sTableName As String = ""
            Do While Split(UpdateCommandText, " ")(i) <> ""
                sbuf = Trim(Split(UpdateCommandText, " ")(i))
                If i = 0 And UCase(sbuf) <> "UPDATE" Then
                    Exit Do
                End If
                If i = 1 Then
                    sTableName = Trim(sbuf)
                    Exit Do
                End If
                i += 1
            Loop
            Return sTableName
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Private Sub MasterLink_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterLink.CurrentChanged
        '

    End Sub

    Private Sub MasterLink_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterLink.CurrentItemChanged
        '
    End Sub

    Private Sub MasterLink_DataMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterLink.DataMemberChanged
        '
    End Sub


    Public Sub MasterLink_PositionChanged_BaseForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterLink.PositionChanged
        Try
            'If bFormOpenning Then Exit Sub

            If bWaitMasterOpening Then Exit Sub
            If bNoPositionChange Then Exit Sub

            bNoPositionChange = True

            Try
                If MasterLink.CurrentRow Is Nothing Then Exit Sub
                If MasterTable.Columns.Contains("IsApproved") Then
                    If If0Null(MasterLink.CurrentRow("IsApproved")) <> 0 Then
                        btnDisapprove.Enabled = True
                        btnApprove.Enabled = False
                    Else
                        btnDisapprove.Enabled = False
                        btnApprove.Enabled = True
                    End If
                Else
                    btnDisapprove.Enabled = False
                    btnApprove.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            bNoPositionChange = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoPositionChange = False
    End Sub



    Private Sub btnFormPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormPrint.ItemClick
        Try
            ShowCurrentRow(True)
            If MasterTable.Columns.Count <= 0 Then Exit Sub
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If GridView1.SelectedRowsCount > 1 Then
                MsgBox(BaseTText("Lütfen tek kayıt seçiniz."))
                Exit Sub
            End If
            Dim e2 As New ItemFormSaveEventArgs
            RaiseEvent ButtonFormPrintBeforeClick(sender, e2)
            If e2.Cancel Then
                Exit Sub
            End If
           
            If Trim(PrintScript) = "" Then
                If MasterTable.SelectCommand.CommandType = CommandType.Text Then
                    PrintScript = MasterTable.SelectCommand.CommandText
                    If InStr(PrintScript, "WHERE ") <> 0 Then
                        PrintScript = Replace(PrintScript, "WHERE ", "WHERE " & MasterTable.Columns(0).ColumnName & "=@" & MasterTable.Columns(0).ColumnName & " AND ")
                    Else
                        PrintScript &= " WHERE " & MasterTable.Columns(0).ColumnName & "=@" & MasterTable.Columns(0).ColumnName
                    End If

                End If
            End If


            Dim f As New frmReportSelect
            With f
                .Parameters = New ArrayList

                Dim pr As New SqlClient.SqlParameter("@" & MasterTable.Columns(0).ColumnName, MasterLink.CurrentRow(0))
                .Parameters.Add(pr)
                For Each pr2 As SqlClient.SqlParameter In MasterTable.SelectCommand.Parameters
                    If pr2.ParameterName <> pr.ParameterName Then
                        .Parameters.Add(New SqlClient.SqlParameter(pr2.ParameterName, pr2.Value))
                    End If
                Next
                If AppConn.ActiveUser.bAdmin Then .Parameters.Add(New SqlClient.SqlParameter("@bAdmin", 1)) Else .Parameters.Add(New SqlClient.SqlParameter("@bAdmin", 1))

                .Parameters.Add(New SqlClient.SqlParameter("@UserID", AppConn.ActiveUser.UserID))


                .FormCode = Me.FormCode
                .PrintScript = PrintScript
                .FormShow()

            End With
            Dim e3 As New ItemFormSaveEventArgs
            RaiseEvent ButtonFormPrintAfterClick(sender, e3)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mnuUserRecordInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserRecordInfo.Click
        Try
            If GridControl1.DataSource Is Nothing Then Exit Sub
            Dim Table1 As NeoDAC.NeoTable
            Dim nID As Long
            Dim CreatedBy As Long
            Dim CreatedDate As Date
            Dim ModifiedBy As Long
            Dim ModifiedDate As Date

            If TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                If CType(GridControl1.DataSource, NeoDAC.NeoLink).CurrentRow Is Nothing Then Exit Sub
                nID = If0Null(CType(GridControl1.DataSource, NeoDAC.NeoLink).CurrentRow(0))
                Table1 = CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable)
                If Table1.Columns.Contains("CreatedBy") Then
                    CreatedBy = If0Null(CType(GridControl1.DataSource, NeoDAC.NeoLink).CurrentRow("CreatedBy"))
                End If
                If Table1.Columns.Contains("CreatedDate") Then
                    CreatedDate = IfNull(CType(GridControl1.DataSource, NeoDAC.NeoLink).CurrentRow("CreatedDate"), DateSerial(1900, 1, 1))
                End If
                If Table1.Columns.Contains("ModifiedBy") Then
                    ModifiedBy = If0Null(CType(GridControl1.DataSource, NeoDAC.NeoLink).CurrentRow("ModifiedBy"))
                End If
                If Table1.Columns.Contains("ModifiedDate") Then
                    ModifiedDate = IfNull(CType(GridControl1.DataSource, NeoDAC.NeoLink).CurrentRow("ModifiedDate"), DateSerial(1900, 1, 1))
                End If
            ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then

                Table1 = CType(GridControl1.DataSource, NeoDAC.NeoTable)
                Dim dr As DataRow
                Try
                    dr = Table1.Rows(GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle))
                Catch ex As Exception

                End Try
                If dr Is Nothing Then Exit Sub
                nID = If0Null(dr(0))

                If Table1.Columns.Contains("CreatedBy") Then
                    CreatedBy = If0Null(dr("CreatedBy"))
                End If
                If Table1.Columns.Contains("CreatedDate") Then
                    CreatedDate = IfNull(dr("CreatedDate"), DateSerial(1900, 1, 1))
                End If
                If Table1.Columns.Contains("ModifiedBy") Then
                    ModifiedBy = If0Null(dr("ModifiedBy"))
                End If
                If Table1.Columns.Contains("ModifiedDate") Then
                    ModifiedDate = IfNull(dr("ModifiedDate"), DateSerial(1900, 1, 1))
                End If
            End If
            'If IsNullGuid(nID) Then Exit Sub
            Dim sText As String = ""
            sText = "ID" & vbTab & vbTab & ": " & nID.ToString & vbNewLine
            sText &= "Oluşturan" & vbTab & vbTab & ": " & GetUserFullName(MasterConn.SqlConnection, CreatedBy) & vbNewLine
            sText &= "Oluşturma Tarihi" & vbTab & ": " & CreatedDate & vbNewLine
            sText &= "Değiştiren" & vbTab & vbTab & ": " & GetUserFullName(MasterConn.SqlConnection, ModifiedBy) & vbNewLine
            sText &= "Değiştirme Tarihi" & vbTab & ": " & ModifiedDate & vbNewLine
            MsgBox(sText, MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Kayıt Bilgisi")
            'MsgBox(sText, MsgBoxStyle.Information, "Kayıt Bilgisi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            EmtyListControl()
        Catch ex As Exception
            MsgBox("(XtraTabControl1_SelectedPageChanged) " & ex.Message)
        End Try
    End Sub

    'Private Sub XtraTabControl1_SelectedPageChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles XtraTabControl1.SelectedPageChanging

    'End Sub

    Private Sub EmtyListControl()
        Try
            btnEdit.Enabled = False
            If XtraTabControl1.TabPages.Count <= 0 Then Exit Sub
            For Each p As DevExpress.XtraTab.XtraTabPage In XtraTabControl1.TabPages
                If p.Tag Is Nothing Then
                    p.Tag = p.PageEnabled
                End If
            Next

            If GridView1.RowCount <= 0 And bAddingNew = False Then
                For Each p As DevExpress.XtraTab.XtraTabPage In XtraTabControl1.TabPages
                    If p.Handle <> BaseTab1.Handle Then
                        p.PageEnabled = False
                        'p.PageVisible = False
                    End If
                Next

                'XtraTabControl1.SelectedTabPageIndex = 0
            Else
                For Each p As DevExpress.XtraTab.XtraTabPage In XtraTabControl1.TabPages
                    If p.Handle <> BaseTab1.Handle Then
                        p.PageEnabled = CBool(p.Tag)
                        'p.PageVisible = CBool(p.Tag)
                    End If
                Next
                If XtraTabControl1.SelectedTabPage.Handle = BaseTab2.Handle Then
                    If EditMode = False Then
                        If Not MasterLink.CurrentRow Is Nothing Then
                            btnEdit.Enabled = True
                        End If
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("(EmtyListControl) " & ex.Message)
        End Try
    End Sub

    Private Sub GridView1_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.RowCountChanged
        Try
            EmtyListControl()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshList.Click
        btnRefresh_ItemClick(Nothing, Nothing)
    End Sub

    Private Sub btnEdit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        If MasterTable.Rows.Count > 0 And Not MasterLink.CurrentRow Is Nothing Then
            EditMode = True
        End If

    End Sub





    Private Sub DetailTable_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles DetailTable.ColumnChanging, DetailTable2.ColumnChanging, DetailTable3.ColumnChanging, DetailTable4.ColumnChanging, DetailTable5.ColumnChanging
        If EditMode = False Then
            'GetOneItem(MasterTable.Rows(0).Item(0))

            'Debug.Print(MasterTable.ExtendedProperties.Count)
            If e.Row.RowState <> DataRowState.Detached And e.Row.RowState <> DataRowState.Added Then
                e.Row.CancelEdit()
                e.Row.RejectChanges()


            End If


            'EditFormWarning()


            Exit Sub

        End If
    End Sub





    Private Sub DetailTable_RowDeleting(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles DetailTable.RowDeleting, DetailTable2.RowDeleting, DetailTable3.RowDeleting
        If EditMode = False Then
            If e.Row.RowState <> DataRowState.Detached And e.Row.RowState <> DataRowState.Added Then
                e.Row.CancelEdit()
                e.Row.RejectChanges()
            End If

            EditFormWarning()

            Exit Sub
        End If
    End Sub

    Public Sub EditFormWarning()
        Beep()
        ShowError("Lütfen değiştirme butonunu kullanarak kayıt değiştiriniz!")
    End Sub
    Private Sub tmrShowError_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShowError.Tick
        Try
            If IsNumeric(tmrShowError.Tag) Then
                tmrShowError.Tag += 1

                If CLng(tmrShowError.Tag) > 16 Then
                    txtTopInfo.Text = ""
                    txtTopInfo.ForeColor = Drawing.SystemColors.InfoText
                    txtTopInfo.BackColor = Drawing.Color.White
                    tmrShowError.Enabled = False
                    tmrShowError.Tag = 0
                End If
            Else
                'tmrShowError.Enabled = False
                tmrShowError.Tag = 0
            End If
            If txtTopInfo.ForeColor = txtTopInfo.BackColor Then
                txtTopInfo.ForeColor = Drawing.Color.Red
                txtTopInfo.BackColor = Drawing.SystemColors.Info
            Else
                txtTopInfo.ForeColor = txtTopInfo.BackColor
                txtTopInfo.BackColor = Drawing.SystemColors.Info
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ShowError(ByVal ErrorText As String)
        txtTopInfo.Text = ErrorText
        tmrShowError.Tag = 0
        tmrShowError.Enabled = True
    End Sub



    Private Sub mnuShowRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowRecord.Click
        ShowCurrentRow(True, True)
    End Sub

    Private Sub btnExportXml_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportXml.ItemClick
        Try
            With dlgExport
                .DefaultExt = "xml"
                .Filter = "Xml Files (*.xml)|*.xml|All Files (*.*)|*.*"
                If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

            End With


            If Not GridControl1.DataSource Is Nothing Then
                If TypeOf GridControl1.DataSource Is NeoDAC.NeoLink Then
                    With CType(CType(GridControl1.DataSource, NeoDAC.NeoLink).DataSource, NeoDAC.NeoTable)
                        .WriteXml(dlgExport.FileName, XmlWriteMode.WriteSchema)

                    End With
                ElseIf TypeOf GridControl1.DataSource Is NeoDAC.NeoTable Then
                    With CType(GridControl1.DataSource, NeoDAC.NeoTable)
                        .WriteXml(dlgExport.FileName, XmlWriteMode.WriteSchema)
                    End With
                End If
            End If

        Catch ex As Exception
            MsgBox("(btnExportXml_ItemClick) " & ex.Message)
        End Try
    End Sub

    Private Sub btnImport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImport.ItemClick
        Try
            Dim e1 As New ItemFormSaveEventArgs
            RaiseEvent BeforeImportPrepare(sender, e1)
            If e1.Cancel Then Exit Sub


            If ImportTable.Columns.Count <= 0 Then
                For Each dc As DataColumn In MasterTable.Columns
                    Dim newdc As New DataColumn(dc.ColumnName, dc.DataType)
                    newdc.DefaultValue = dc.DefaultValue
                    newdc.AutoIncrement = dc.AutoIncrement
                    newdc.AutoIncrementSeed = dc.AutoIncrementSeed
                    newdc.AutoIncrementStep = dc.AutoIncrementStep
                    newdc.Caption = dc.Caption
                    ImportTable.Columns.Add(newdc)
                Next
            End If
            ImportTable.Rows.Clear()

            'Dim f As New frmImportSelect
            'With f
            '    
            '    .ImportTable = ImportTable
            '    .FormShow(Me.FormCode)
            '    If .DialogResult <> Windows.Forms.DialogResult.OK Then
            '        .Dispose()
            '        Exit Sub
            '    End If
            '    ImportTable = .ImportTable
            '    .Dispose()

            'End With

            'IMPORT IŞLEMİ
            RaiseEvent BeforeImport(sender, e1) 'burada kontrol edilecek veri
            If e1.Cancel Then Exit Sub

            'veri kontrolü başarılı ki bu adıma gelmiş
            If mVar_UseStandartImport = True Then

                For Each dr As DataRow In ImportTable.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        Dim newdr As DataRow = MasterTable.NewRow

                        For Each dc As DataColumn In MasterTable.Columns
                            Dim bFound As Boolean = False
                            If ImportTable.Columns.Contains(dc.ColumnName) And dc.AutoIncrement = False Then
                                If Not IsDBNull(dr(dc.ColumnName)) Then
                                    newdr(dc.ColumnName) = dr(dc.ColumnName)
                                Else
                                    newdr(dc.ColumnName) = MasterTable.Columns(dc.ColumnName).DefaultValue
                                End If

                            End If
                        Next
                        If MasterTable.Columns.Contains("Deleted") Then
                            If ImportTable.Columns.Contains("Deleted") Then
                                dr("Deleted") = 0
                            End If

                        End If
                        MasterTable.Rows.Add(newdr)
                        MasterTable.Save()
                    End If
                Next

            Else
                RaiseEvent ImportData(sender, e1)
                If e1.Cancel Then Exit Sub
            End If


            '
            RaiseEvent AfterImport(sender, e1)
            If e1.Cancel Then Exit Sub
            btnRefresh_ItemClick(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ImportData_For_Detail1()
        Try
            Dim e1 As New ItemFormSaveEventArgs
            RaiseEvent BeforeImportPrepare_Detail1(New Object, e1)
            If e1.Cancel Then Exit Sub
            EditMode = True

            If ImportDetailTable1.Columns.Count <= 0 Then
                For Each dc As DataColumn In DetailTable.Columns
                    Dim newdc As New DataColumn(dc.ColumnName, dc.DataType)
                    newdc.DefaultValue = dc.DefaultValue
                    newdc.AutoIncrement = dc.AutoIncrement
                    newdc.AutoIncrementSeed = dc.AutoIncrementSeed
                    newdc.AutoIncrementStep = dc.AutoIncrementStep
                    newdc.Caption = dc.Caption
                    ImportDetailTable1.Columns.Add(newdc)
                Next
            End If
            ImportDetailTable1.Rows.Clear()

            'Dim f As New frmImportSelect
            'With f
            '    
            '    .ImportTable = ImportDetailTable1
            '    .FormShow(Me.FormCode & "-DT1")
            '    If .DialogResult <> Windows.Forms.DialogResult.OK Then
            '        .Dispose()
            '        Exit Sub
            '    End If
            '    ImportDetailTable1 = .ImportTable
            '    .Dispose()

            'End With

            'IMPORT IŞLEMİ
            RaiseEvent BeforeImport_Detail1(New Object, e1) 'burada kontrol edilecek veri
            If e1.Cancel Then Exit Sub

            'veri kontrolü başarılı ki bu adıma gelmiş
            If mVar_UseStandartImport = True Then

                For Each dr As DataRow In ImportTable.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        Dim newdr As DataRow = DetailTable.NewRow

                        For Each dc As DataColumn In DetailTable.Columns
                            Dim bFound As Boolean = False
                            If ImportTable.Columns.Contains(dc.ColumnName) And dc.AutoIncrement = False Then
                                If Not IsDBNull(dr(dc.ColumnName)) Then
                                    newdr(dc.ColumnName) = dr(dc.ColumnName)
                                Else
                                    newdr(dc.ColumnName) = DetailTable.Columns(dc.ColumnName).DefaultValue
                                End If

                            End If
                        Next
                        If DetailTable.Columns.Contains("Deleted") Then
                            dr("Deleted") = 0
                        End If
                        DetailTable.Rows.Add(newdr)
                        DetailTable.Save()
                    End If
                Next

            Else
                RaiseEvent ImportData_Detail1(New Object, e1)
                If e1.Cancel Then Exit Sub
            End If


            '
            RaiseEvent AfterImport_Detail1(New Object, e1)
            If e1.Cancel Then Exit Sub
            'btnRefresh_ItemClick(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLanguageOptions.ItemClick
        'ShowLanguageOptions(Me.Name, AppConn)
    End Sub


    Public Function BaseTText(ByVal sText As String) As String
        'If AppConn Is Nothing Then Return sText
        'If AppConn.PiconnLanguage Is Nothing Then Return sText
        'Return AppConn.PiconnLanguage.TText(sText)
        Return sText
    End Function


    Private Sub cboAuthCodes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAuthCodes.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                'Dim f As New frmAuthCodes
                'With f
                '    
                '    .FormShow()
                '    RefreshAuthCodes()
                'End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefreshAuthCodes()
        Try
            If MasterTable.Columns.Contains("AuthCode") = False Or FillAuthCodes = False Then
                panelAuthCodes.Visible = False
                Exit Sub
            End If
            cboAuthCodes.Visible = False
            cboAuthCodes.Properties.Items.Clear()

            OpenTable(AuthCodes)
            For Each dr As DataRow In AuthCodes.Rows
                cboAuthCodes.Properties.Items.Add(IfNull(dr("AuthCode"), ""))
            Next
            If cboAuthCodes.DataBindings.Count <= 0 Then
                Me.cboAuthCodes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "AuthCode", True))
            End If
            cboAuthCodes.Visible = True

            Dim bFound As Boolean = False

            For Each col As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
                If col.FieldName = "AuthCode" Then
                    bFound = True
                    Exit For
                End If
            Next

            If bFound = False Then
                Dim colGridAuthCol As New DevExpress.XtraGrid.Columns.GridColumn
                GridView1.Columns.Add(colGridAuthCol)
                With colGridAuthCol
                    .Caption = "Yetki Kodu"
                    .Name = "colGridAuthCol"
                    .FieldName = "AuthCode"
                    .Visible = True
                    .VisibleIndex = GridView1.VisibleColumns.Count - 1
                    .Width = 80
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterTable_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            e.Row.EndEdit()
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
End Class



Public Class ItemFormSaveEventArgs
    Inherits System.EventArgs
    Public Cancel As Boolean = False
    Public SQL As String = ""
    Public RowState As DataRowState
    Public RowIndex As Integer = -1
    Public Transaction As SqlClient.SqlTransaction
End Class