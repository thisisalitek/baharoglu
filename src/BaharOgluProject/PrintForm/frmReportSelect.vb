'Imports PiconnUtility.dynamoEmpire.PiconnUtility

Public Class frmReportSelect

    Public FormCode As String = ""
    
    Public PrintScript As String = ""
    Public Parameters As New ArrayList
    Public DataSource As Object = Nothing
    Dim bPrintFromDataSource As Boolean = False
    Dim bInvisiblePrint As Boolean = False
    Dim PrinterName As String = ""

    Dim DefaultReportDesignID As Guid

    Public Sub FormShow(Optional ByVal DataSource_ As Object = Nothing)
        DataSource = DataSource_
        If Not DataSource Is Nothing Then
            bPrintFromDataSource = True

        Else
            bPrintFromDataSource = False
        End If
        RefreshList()
        Me.ShowDialog()
    End Sub

    Public Sub FormPrintInvisible(Optional ByVal PrinterName_ As String = "", Optional ByVal DataSource_ As Object = Nothing, Optional ByVal ReportDesignID As Object = Nothing)
        Try
            bInvisiblePrint = True
            DefaultReportDesignID = ReportDesignID

            PrinterName = PrinterName_
            DataSource = DataSource_
            If Not DataSource Is Nothing Then
                bPrintFromDataSource = True

            Else
                bPrintFromDataSource = False
            End If
            RefreshList()
            If GridView1.RowCount <= 0 Then
                Me.ShowDialog()
            Else
                mnuPrint_Click(Nothing, Nothing)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefreshList()
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Dim oldRow As Integer
        Try
            oldRow = GridView1.FocusedRowHandle
            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6

            cmd.CommandText = "SELECT ReportID, ReportName,bDefault, CASE bDefault WHEN 1 THEN '*' ELSE '' END as sDefault,CASE ReportType WHEN 0 THEN 'FORM' WHEN 1 THEN 'RAW' WHEN 2 THEN 'EXTERNAL' ELSE '' END as sReportType,ReportType FROM  Piconn_ReportDesigns " & _
            " WHERE Deleted = 0 AND FormCode = @FormCode "
            If IsNullGuid(DefaultReportDesignID) = False Then
                cmd.CommandText &= " AND ReportID='" & DefaultReportDesignID.ToString & "' "
            Else
                If bInvisiblePrint Then
                    cmd.CommandText &= " AND bDefault=1 "
                End If
            End If

            cmd.CommandText &= "ORDER BY ReportName"

            cmd.Parameters.Clear()


            cmd.Parameters.Add(New SqlClient.SqlParameter("@FormCode", FormCode))
            da = New SqlClient.SqlDataAdapter(cmd)

            da.Fill(dt)
            GridControl1.DataSource = dt
            If oldRow >= 0 And GridView1.RowCount > 0 Then
                If oldRow > GridView1.RowCount - 1 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                Else
                    GridView1.FocusedRowHandle = oldRow
                End If
            End If
        Catch ex As Exception
            MsgBox("(RefreshList) " & ex.Message)
        End Try

    End Sub


    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        If bPrintFromDataSource = False Then
            PrintFromScript()
        Else
            PrintFromDataSource()
        End If
    End Sub

    Private Sub PrintFromScript()
        Dim dr As DataRow
        Dim cReportDesing As New clsReportDesing
        dr = GridView1.GetFocusedDataRow
        If dr Is Nothing Then Exit Sub
        Try
            cReportDesing = GetReportLayout(AppConn.dbConn, IfNullGuid(dr("ReportID")))
            Select Case cReportDesing.ReportType
                Case 0
                    PrintFromScript_Form(cReportDesing)
                Case 1 'Raw

                Case 2 'External
                    PrintFromScript_External(cReportDesing)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintFromDataSource()
        Dim dr As DataRow
        Dim cReportDesing As New clsReportDesing
        dr = GridView1.GetFocusedDataRow
        If dr Is Nothing Then Exit Sub
        Try
            cReportDesing = GetReportLayout(AppConn.dbConn, IfNull(dr("ReportID"), 0))
            Select Case cReportDesing.ReportType
                Case 0 'form
                    PrintFromDataSource_Form(cReportDesing)
                Case 1 'Raw

                Case 2 'External

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintFromScript_Form(ByVal cReportDesing As clsReportDesing)


        Dim xrep As New XtraReport1

        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Dim bFound As Boolean = False

        Try



            If cReportDesing.ReportData.Length > 0 Then
                xrep.LoadLayout(cReportDesing.ReportData)
            End If
            If Trim(cReportDesing.ReportSQL) <> "" Then
                cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6

                cmd.CommandText = cReportDesing.ReportSQL
                cmd.Parameters.Clear()
                If Not Parameters Is Nothing Then
                    For Each pr As SqlClient.SqlParameter In Parameters
                        If Trim(pr.ParameterName) <> "" Then
                            If Mid(pr.ParameterName, 1, 1) <> "@" Then
                                pr.ParameterName = "@" & pr.ParameterName
                            End If
                        End If
                        bFound = False
                        For Each pr2 As SqlClient.SqlParameter In cmd.Parameters
                            If pr.ParameterName = pr2.ParameterName Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound = False Then

                            cmd.Parameters.Add(New SqlClient.SqlParameter(pr.ParameterName, pr.Value))

                        End If

                    Next
                End If
                If cmd.Parameters.Contains("@FormDate1") = False Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@FormDate1", Today))

                End If
                If cmd.Parameters.Contains("@FormDate2") = False Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@FormDate2", Today))

                End If

                da = New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                xrep.DataSource = dt
            Else
                xrep.DataSource = New DataTable
            End If
            xrep.ShowPrintMarginsWarning = False
            xrep.ShowPrintStatusDialog = False
            xrep.CreateDocument()

            xrep.Parameters.Clear()
            For Each pr As SqlClient.SqlParameter In cmd.Parameters
                Dim newpr As New DevExpress.XtraReports.Parameters.Parameter

                newpr.Name = Replace(pr.ParameterName, "@", "")
                newpr.Value = pr.Value

                xrep.Parameters.Add(newpr)
            Next

            Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(xrep)


            If bInvisiblePrint = False Then
                'xrep.Print

                pt.ShowRibbonPreviewDialog()

            Else

                If PrinterName = "" Then
                    'xrep.Print()
                    pt.Print()

                Else
                    'xrep.Print(PrinterName)
                    pt.Print(PrinterName)

                End If
            End If
            If xrep.isPrinted Then
                If Trim(cReportDesing.AfterPrintSQL) <> "" Then
                    cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6

                    cmd.CommandText = cReportDesing.AfterPrintSQL
                    cmd.Parameters.Clear()
                    If Not Parameters Is Nothing Then
                        For Each pr As SqlClient.SqlParameter In Parameters
                            If Trim(pr.ParameterName) <> "" Then
                                If Mid(pr.ParameterName, 1, 1) <> "@" Then
                                    pr.ParameterName = "@" & pr.ParameterName
                                End If
                            End If
                            bFound = False
                            For Each pr2 As SqlClient.SqlParameter In cmd.Parameters
                                If pr.ParameterName = pr2.ParameterName Then
                                    bFound = True
                                    Exit For
                                End If
                            Next
                            If bFound = False Then

                                cmd.Parameters.Add(New SqlClient.SqlParameter(pr.ParameterName, pr.Value))

                            End If

                        Next
                    End If
                    If cmd.Parameters.Contains("@FormDate1") = False Then
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@FormDate1", Today))

                    End If
                    If cmd.Parameters.Contains("@FormDate2") = False Then
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@FormDate2", Today))

                    End If

                    cmd.ExecuteNonQuery()

                End If
            End If
        Catch ex As Exception
            MsgBox("(PrintFromScript_Form) " & ex.Message)
        End Try
    End Sub

    Private Sub PrintFromDataSource_Form(ByVal cReportDesing As clsReportDesing)
        Dim xrep As New XtraReport1
        Try

            If cReportDesing.ReportData.Length > 0 Then
                xrep.LoadLayout(cReportDesing.ReportData)
            End If

            xrep.DataSource = DataSource
            If TypeOf DataSource Is NeoDAC.NeoTable Then
                If Not CType(DataSource, NeoDAC.NeoTable).SelectCommand Is Nothing Then
                    For Each pr As SqlClient.SqlParameter In CType(DataSource, NeoDAC.NeoTable).SelectCommand.Parameters
                        Dim item As New DevExpress.XtraReports.Parameters.Parameter
                        Dim paramName As String = Replace(pr.ParameterName, "@", "")
                        Dim bFound As Boolean = False
                        item.Name = paramName
                        item.Value = pr.Value
                        For i As Integer = 0 To xrep.Parameters.Count - 1
                            If xrep.Parameters(i).Name = paramName Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound Then
                            xrep.Parameters(paramName).Value = pr.Value
                        Else
                            xrep.Parameters.Add(item)
                        End If

                    Next
                End If
            End If

            xrep.ShowPrintMarginsWarning = False
            xrep.ShowPrintStatusDialog = False
            xrep.CreateDocument()

            '
            Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(xrep)


            If bInvisiblePrint = False Then
                'xrep.ShowRibbonPreviewDialog()
                pt.ShowRibbonPreviewDialog()

            Else
                If PrinterName = "" Then
                    'xrep.Print()
                    pt.Print()

                Else
                    'xrep.Print(PrinterName)
                    pt.Print(PrinterName)
                End If
            End If

        Catch ex As Exception
            MsgBox("(PrintFromDataSource_Form) " & ex.Message)
        End Try


    End Sub

    Private Sub PrintFromScript_External(ByVal cReportDesing As clsReportDesing)


        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Dim bFound As Boolean = False
        Dim ExternalFile As String = ""
        Try



            If cReportDesing.ReportDataByteArray.Length = 0 Then
                Exit Sub
            End If
            Dim enc As New System.Text.UTF8Encoding
            ExternalFile = enc.GetString(cReportDesing.ReportDataByteArray)
            If Trim(ExternalFile) = "" Then Exit Sub

            If Trim(cReportDesing.ReportSQL) <> "" Then
                cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
                cmd.CommandText = cReportDesing.ReportSQL
                cmd.Parameters.Clear()
                If Not Parameters Is Nothing Then
                    For Each pr As SqlClient.SqlParameter In Parameters
                        If Trim(pr.ParameterName) <> "" Then
                            If Mid(pr.ParameterName, 1, 1) <> "@" Then
                                pr.ParameterName = "@" & pr.ParameterName
                            End If
                        End If
                        bFound = False
                        For Each pr2 As SqlClient.SqlParameter In cmd.Parameters
                            If pr.ParameterName = pr2.ParameterName Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound = False Then

                            cmd.Parameters.Add(New SqlClient.SqlParameter(pr.ParameterName, pr.Value))

                        End If

                    Next
                End If
                If cmd.Parameters.Contains("@FormDate1") = False Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@FormDate1", Today))

                End If
                If cmd.Parameters.Contains("@FormDate2") = False Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@FormDate2", Today))

                End If

                da = New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                da.Dispose()
            Else
                dt = New DataTable
            End If

            Dim ExecExternalFile As String = ""
            For Each dr As DataRow In dt.Rows
                ExecExternalFile = ExternalFile
                For Each dc As DataColumn In dt.Columns
                    ExecExternalFile = Replace(ExecExternalFile, "[" & dc.ColumnName & "]", IfNull(dr(dc.ColumnName), ""))
                Next
                Try
                    Shell(ExecExternalFile, AppWinStyle.NormalFocus, False)
                Catch ex As Exception

                End Try
            Next
            dt.Dispose()

            cmd.Dispose()
        Catch ex As Exception
            MsgBox("(PrintFromScript_External) " & ex.Message)
        End Try
    End Sub

    Private Sub PrintFromDataSource_External(ByVal cReportDesing As clsReportDesing)
        Dim ExternalFile As String = ""
        Try


            If cReportDesing.ReportDataByteArray.Length = 0 Then
                Exit Sub
            End If
            Dim enc As New System.Text.UTF8Encoding
            ExternalFile = enc.GetString(cReportDesing.ReportDataByteArray)
            If Trim(ExternalFile) = "" Then Exit Sub

            If TypeOf DataSource Is NeoDAC.NeoTable Then

                Dim ExecExternalFile As String = ""
                For Each dr As DataRow In CType(DataSource, NeoDAC.NeoTable).Rows
                    ExecExternalFile = ExternalFile
                    For Each dc As DataColumn In CType(DataSource, NeoDAC.NeoTable).Columns
                        ExecExternalFile = Replace(ExecExternalFile, "[" & dc.ColumnName & "]", dr(dc.ColumnName))
                    Next
                    If Not CType(DataSource, NeoDAC.NeoTable).SelectCommand Is Nothing Then
                        For Each pr As SqlClient.SqlParameter In CType(DataSource, NeoDAC.NeoTable).SelectCommand.Parameters
                            ExecExternalFile = Replace(ExecExternalFile, "[" & pr.ParameterName & "]", IfNull(pr.Value, ""))

                        Next
                    End If

                    Try
                        Shell(ExecExternalFile, AppWinStyle.NormalFocus, False)
                    Catch ex As Exception

                    End Try
                Next

            ElseIf TypeOf DataSource Is DataTable Then
                Dim ExecExternalFile As String = ""
                For Each dr As DataRow In CType(DataSource, DataTable).Rows
                    ExecExternalFile = ExternalFile
                    For Each dc As DataColumn In CType(DataSource, DataTable).Columns
                        ExecExternalFile = Replace(ExecExternalFile, "[" & dc.ColumnName & "]", IfNull(dr(dc.ColumnName), ""))
                    Next
                    Try
                        Shell(ExecExternalFile, AppWinStyle.NormalFocus, False)
                    Catch ex As Exception

                    End Try
                Next
            End If



        Catch ex As Exception
            MsgBox("(PrintFromDataSource_External) " & ex.Message)
        End Try
    End Sub

    Private Sub mnuNewReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuNewReport.Click
        Try
            Dim f As New frmReportItem
            With f
                
                .FormCode = FormCode
                .Parameters = Parameters
                .PrintScript = PrintScript
                .FormNew(DataSource)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    RefreshList()
                    If CType(GridControl1.DataSource, DataTable).Rows.Count = 1 Then
                        mnuSetDefault_Click(Nothing, Nothing)
                    End If
                End If
                .Dispose()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuEditReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditReport.Click
        'Try

        Dim dr As DataRow
            dr = GridView1.GetFocusedDataRow
            If dr Is Nothing Then Exit Sub

            Dim f As New frmReportItem

            With f
                

                .ReportID = IfNullGuid(dr("ReportID"))
                .PrintScript = PrintScript
                .Parameters = Parameters
                .FormEdit(DataSource)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    RefreshList()
                End If
                .Dispose()
            End With
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub conMenuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conMenuPrint.Click
        mnuPrint_Click(Nothing, Nothing)
    End Sub

    Private Sub conMenuEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles conMenuEdit.Click
        mnuEditReport_Click(Nothing, Nothing)
    End Sub

    Private Sub conMenuNewReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles conMenuNewReport.Click
        mnuNewReport_Click(Nothing, Nothing)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        mnuPrint_Click(Nothing, Nothing)
    End Sub

    Private Sub frmReportSelect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Windows.Forms.Keys.F2
                mnuPrint_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub mnuDeleteReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDeleteReport.Click
        Dim dr As DataRow
        dr = GridView1.GetFocusedDataRow
        If dr Is Nothing Then Exit Sub
        If MsgBox(AppConn.PiconnLanguage.TText("Rapor tasarımını silmek istediğinizden emin misiniz?"), MsgBoxStyle.YesNo, AppConn.PiconnLanguage.TText("Rapor Sil?")) <> MsgBoxResult.Yes Then Exit Sub
        Dim cmd As New SqlClient.SqlCommand
        Try
            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportID", dr("ReportID")))
            cmd.CommandText = "UPDATE Piconn_ReportDesigns SET Deleted = RowID , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE ReportID=@ReportID"
            cmd.ExecuteNonQuery()
            RefreshList()
        Catch ex As Exception
            MsgBox("(DeleteReport) " & ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub conMenuDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles conMenuDelete.Click
        mnuDeleteReport_Click(Nothing, Nothing)
    End Sub

    Private Function PrepareForExport() As XtraReport1
        Dim dr As DataRow
        dr = GridView1.GetFocusedDataRow
        If dr Is Nothing Then Return Nothing

        Dim xrep As New XtraReport1
        Dim cReportDesing As New clsReportDesing
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Dim bFound As Boolean = False
        Try
            cReportDesing = GetReportLayout(AppConn.dbConn, IfNull(dr("ReportID"), 0))
            If cReportDesing.ReportData.Length > 0 Then
                xrep.LoadLayout(cReportDesing.ReportData)
            End If
            If Trim(cReportDesing.ReportSQL) <> "" Then
                cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
                cmd.CommandText = cReportDesing.ReportSQL
                cmd.Parameters.Clear()
                If Not Parameters Is Nothing Then
                    For Each pr As SqlClient.SqlParameter In Parameters
                        If Trim(pr.ParameterName) <> "" Then
                            If Mid(pr.ParameterName, 1, 1) <> "@" Then
                                pr.ParameterName = "@" & pr.ParameterName
                            End If
                        End If
                        bFound = False
                        For Each pr2 As SqlClient.SqlParameter In cmd.Parameters
                            If pr.ParameterName = pr2.ParameterName Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound = False Then

                            cmd.Parameters.Add(New SqlClient.SqlParameter(pr.ParameterName, pr.Value))

                        End If

                    Next
                End If
                da = New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                xrep.DataSource = dt
            Else
                xrep.DataSource = New DataTable
            End If
            xrep.ShowPrintMarginsWarning = False
            xrep.ShowPrintStatusDialog = False
            xrep.CreateDocument()
            Return xrep
        Catch ex As Exception
            MsgBox("(cmdDesign_Click) " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub mnuExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportExcel.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "Xls"
        dlgExport.Filter = "Excel Files (*.XLS)|*.XLS|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            xrep.ExportToXls(.FileName)
        End With
    End Sub

    Private Sub mnuExportHTML_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportHTML.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "HTM"
        dlgExport.Filter = "HTML Files (*.HTM)|*.HTM|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            xrep.ExportToHtml(.FileName)
        End With
    End Sub

    Private Sub mnuExportCSV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportCSV.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "CSV"
        dlgExport.Filter = "CSV Files (*.CSV)|*.CSV|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            Dim s As New DevExpress.XtraPrinting.CsvExportOptions
            s.Separator = ";"
            xrep.ExportToCsv(.FileName, s)
        End With
    End Sub

    Private Sub mnuExportTEXT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportTEXT.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "TXT"
        dlgExport.Filter = "Text Files (*.TXT)|*.TXT|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            Dim s As New DevExpress.XtraPrinting.TextExportOptions
            s.Separator = vbTab
            xrep.ExportToText(.FileName, s)
        End With
    End Sub

    Private Sub mnuExportPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportPDF.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "PDF"
        dlgExport.Filter = "Acrobat Files (*.PDF)|*.PDF|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            xrep.ExportToPdf(.FileName)
        End With
    End Sub

    Private Sub mnuExportRTF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportRTF.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "RTF"
        dlgExport.Filter = "Rich Text Files (*.RTF)|*.RTF|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            xrep.ExportToRtf(.FileName)
        End With
    End Sub

    Private Sub mnuExportMHT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportMHT.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "MHT"
        dlgExport.Filter = "MHT Files (*.MHT)|*.MHT|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            xrep.ExportToMht(.FileName)
        End With
    End Sub

    Private Sub mnuExportImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExportImage.Click
        Dim xrep As XtraReport1
        xrep = PrepareForExport()
        If xrep Is Nothing Then Exit Sub
        dlgExport.DefaultExt = "jpg"
        dlgExport.Filter = "JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|Bitmap (*.bmp)|*.BMP|GIF (*.gif)|*.gif|TIFF (*.tif;*.tiff)|*.tif;*.tiff|PNG (*.png)|*.png|Tüm dosyalar (*.*)|*.*"
        'dlgExport.Filter &= "Bitmap (*.bmp)|*.BMP|GIF (*.gif)|*.gif|TIFF (*.tif;*.tiff)|*.tif;*.tiff|PNG (*.png)|*.png|Tüm dosyalar (*.*)|*.*"
        dlgExport.FileName = FormCode
        With dlgExport
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            xrep.ExportToImage(.FileName)
        End With
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        mnuExportExcel_Click(Nothing, Nothing)
    End Sub

    Private Sub HTMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLToolStripMenuItem.Click
        mnuExportHTML_Click(Nothing, Nothing)
    End Sub

    Private Sub PDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDFToolStripMenuItem.Click
        mnuExportPDF_Click(Nothing, Nothing)
    End Sub

    Private Sub TEXTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEXTToolStripMenuItem.Click
        mnuExportTEXT_Click(Nothing, Nothing)
    End Sub

    Private Sub CSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSVToolStripMenuItem.Click
        mnuExportCSV_Click(Nothing, Nothing)
    End Sub

    Private Sub ImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        mnuExportImage_Click(Nothing, Nothing)
    End Sub

    Private Sub MHTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MHTToolStripMenuItem.Click
        mnuExportMHT_Click(Nothing, Nothing)
    End Sub

    Private Sub RichTextFormatRTFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextFormatRTFToolStripMenuItem.Click
        mnuExportRTF_Click(Nothing, Nothing)
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        mnuPrint_Click(Nothing, Nothing)
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Return Then
            GridControl1_DoubleClick(Nothing, Nothing)
        Else
            frmReportSelect_KeyDown(sender, e)
        End If

    End Sub

    Private Sub mnuSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetDefault.Click
        Try

            Dim dr As DataRow
            dr = GridView1.GetFocusedDataRow
            If dr Is Nothing Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@FormCode", FormCode))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportID", dr("ReportID")))

            cmd.CommandText = "UPDATE Piconn_ReportDesigns SET bDefault=0 WHERE Deleted = 0 AND FormCode = @FormCode "
            cmd.ExecuteNonQuery()
            cmd.CommandText = "UPDATE Piconn_ReportDesigns SET bDefault=1 WHERE Deleted = 0 AND ReportID=@ReportID"
            cmd.ExecuteNonQuery()
            RefreshList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuDesingExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDesingExport.Click
        Try
            Dim dr As DataRow
            dr = GridView1.GetFocusedDataRow
            If dr Is Nothing Then Exit Sub

            Dim cReportDesing As New clsReportDesing
            cReportDesing = GetReportLayout(AppConn.dbConn, IfNull(dr("ReportID"), 0))
            Dim xml1 As New Xml.XmlDocument
            Dim mNode As Xml.XmlNode
            Dim pNode As Xml.XmlNode
            Dim en As Xml.XmlDeclaration = xml1.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            xml1.AppendChild(en)


            mNode = xml1.CreateElement("ReportDesingExport")

            pNode = xml1.CreateElement("FormCode")
            pNode.InnerText = cReportDesing.FormCode
            mNode.AppendChild(pNode)

            pNode = xml1.CreateElement("ReportName")
            pNode.InnerText = cReportDesing.ReportName
            mNode.AppendChild(pNode)

            pNode = xml1.CreateElement("ReportSQL")
            pNode.InnerText = cReportDesing.ReportSQL
            mNode.AppendChild(pNode)

            pNode = xml1.CreateElement("ReportData")
            If Not cReportDesing.ReportData Is Nothing Then
                Dim enc As New System.Text.UTF8Encoding
                pNode.InnerText = enc.GetString(cReportDesing.ReportData.ToArray)
            End If
            mNode.AppendChild(pNode)

            xml1.AppendChild(mNode)

            With dlgDesingExport
                .FileName = IfNull(dr("ReportName"), "") & ".xml"
                If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
                xml1.Save(.FileName)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuDesingImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDesingImport.Click
        Try


            Dim cReportDesing As New clsReportDesing

            Dim xml1 As New Xml.XmlDocument

            With dlgDesingImport
                If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
                xml1.Load(.FileName)
            End With

            'Dim mNode As Xml.XmlNode
            'Dim pNode As Xml.XmlNode
            'Dim en As Xml.XmlDeclaration = xml1.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            'xml1.AppendChild(en)
            If Not xml1.SelectSingleNode("/ReportDesingExport") Is Nothing Then
                If Not xml1.SelectSingleNode("/ReportDesingExport/FormCode") Is Nothing Then
                    cReportDesing.FormCode = xml1.SelectSingleNode("/ReportDesingExport/FormCode").InnerText
                End If
                If Not xml1.SelectSingleNode("/ReportDesingExport/ReportName") Is Nothing Then
                    cReportDesing.ReportName = xml1.SelectSingleNode("/ReportDesingExport/ReportName").InnerText
                End If
                If Not xml1.SelectSingleNode("/ReportDesingExport/ReportSQL") Is Nothing Then
                    cReportDesing.ReportSQL = xml1.SelectSingleNode("/ReportDesingExport/ReportSQL").InnerText
                End If
                If Not xml1.SelectSingleNode("/ReportDesingExport/ReportData") Is Nothing Then

                    If Trim(xml1.SelectSingleNode("/ReportDesingExport/ReportData").InnerText) <> "" Then
                        Dim enc1 As New System.Text.UTF8Encoding
                        Dim b As Byte()
                        b = enc1.GetBytes(xml1.SelectSingleNode("/ReportDesingExport/ReportData").InnerText)
                        cReportDesing.ReportData = New IO.MemoryStream
                        cReportDesing.ReportData.Write(b, 0, b.Length)
                    End If
                End If
            End If
            If Me.FormCode <> cReportDesing.FormCode Then
                If MsgBox("Bu tasarım başka bir form için hazırlanmış. Yinede içeri almak istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "FormCode Farklı") <> MsgBoxResult.Yes Then Exit Sub
            End If
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim bFound As Boolean = False
            Dim sReportName As String = cReportDesing.ReportName
            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
Basa:
            bFound = False
            cmd.Parameters.Clear()
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportID", 0))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportName", sReportName))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportData", SqlDbType.Image))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@FormCode", Me.FormCode))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportSQL", SqlDbType.Image))
            cmd.Parameters("@ReportData").Value = DBNull.Value
            cmd.Parameters("@ReportSQL").Value = DBNull.Value
            cmd.CommandText = "SELECT ReportID FROM Piconn_ReportDesigns WHERE Deleted = 0 AND FormCode=@FormCode AND ReportName=@ReportName "
            dt = New DataTable
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                bFound = True
            End If
            dt.Dispose()
            da.Dispose()

            If bFound Then
                sReportName = InputBox("'" & sReportName & "' rapor isminden başka bir kayıt var. Yeni bir isim giriniz.", "Yeni rapor ismi", sReportName)
                If sReportName = "" Then
                    MsgBox("Rapor ismi girmediniz. Rapor içeri alınamadı!")
                    Exit Sub
                End If
                GoTo Basa
            End If
            cmd.Parameters("@ReportData").Value = cReportDesing.ReportData.ToArray
            Dim enc As New System.Text.UTF8Encoding
            cmd.Parameters("@ReportSQL").Value = enc.GetBytes(cReportDesing.ReportSQL)


            cmd.CommandText = "INSERT INTO Piconn_ReportDesigns (Deleted ,CreatedBy,CreatedDate,ModifiedBy ,ModifiedDate,ApplicationCode,FormCode,ReportName,ReportData,ReportSQL) VALUES (" & _
            "0," & AppConn.ActiveUser.UserID & ",GETDATE()," & AppConn.ActiveUser.UserID & ",GETDATE(),'',@FormCode, @ReportName,@ReportData,@ReportSQL)"

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            RefreshList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub conMenuSetDefault_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles conMenuSetDefault.Click
        mnuSetDefault_Click(Nothing, Nothing)
    End Sub

    Private Sub conMenuDesingExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles conMenuDesingExport.Click
        mnuDesingExport_Click(Nothing, Nothing)
    End Sub

    Private Sub conMenuDesingImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles conMenuDesingImport.Click
        mnuDesingImport_Click(Nothing, Nothing)
    End Sub
End Class