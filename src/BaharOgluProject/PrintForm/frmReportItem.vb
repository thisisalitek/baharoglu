'Imports PiconnUtility.dynamoEmpire.PiconnUtility

Public Class frmReportItem
    
   
    Public PrintScript As String = ""
    Dim xRep As New XtraReport1
    Public ReportID As Guid
    Dim ReportLayout As New System.IO.MemoryStream
    Public Parameters As New ArrayList
    Public FormCode As String = ""
    Dim bShowSQLpanel As Boolean = False
    Public DataSource As Object = Nothing
    Dim bPrintFromDataSource As Boolean = False
    Dim ExternalFile As String = ""

    Dim RawFileName As String = ""

    Public Sub FormNew(Optional ByVal DataSource_ As Object = Nothing)
        xRep = New XtraReport1
        
        ReportLayout = New System.IO.MemoryStream
        DataSource = DataSource_
        If Not DataSource Is Nothing Then
            bPrintFromDataSource = True
            cmdSQL.Visible = False
        Else
            bPrintFromDataSource = False
            LoadSQLPanel()
        End If
        cboReportType.Properties.ReadOnly = False


        Me.ShowDialog()
    End Sub

    Public Sub FormEdit(Optional ByVal DataSource_ As Object = Nothing)
        xRep = New XtraReport1
        ReportLayout = New System.IO.MemoryStream
        ExternalFile = ""
        DataSource = DataSource_
        If Not DataSource Is Nothing Then
            bPrintFromDataSource = True
            cmdSQL.Visible = False
        Else
            bPrintFromDataSource = False
            LoadSQLPanel()

        End If
        LoadForm()
        Me.ShowDialog()
    End Sub

    Private Sub LoadForm()
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Try

            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
            cmd.CommandText = "SELECT * FROM Piconn_ReportDesigns WHERE ReportID = '" & ReportID.ToString & "'"
            dt = New DataTable
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtReportName.Text = IfNull(dt.Rows(0).Item("ReportName"), "")
                For i As Integer = 0 To cboReportType.Properties.Items.Count - 1
                    If CType(cboReportType.Properties.Items(i), clsMember).ValueMember = If0Null(dt.Rows(0).Item("ReportType")) Then
                        cboReportType.SelectedIndex = i
                        Exit For
                    End If
                Next
                Select Case If0Null(dt.Rows(0).Item("ReportType"))
                    Case 0
                        If IsDBNull(dt.Rows(0).Item("ReportData")) Then
                            ReportLayout = New IO.MemoryStream
                        Else
                            Dim b As Byte()
                            'Dim enc As New System.Text.UnicodeEncoding
                            b = dt.Rows(0).Item("ReportData")

                            ReportLayout = New IO.MemoryStream
                            ReportLayout.Write(b, 0, b.Length)
                            If ReportLayout.Length > 0 Then

                                CType(xRep, System.ComponentModel.ISupportInitialize).BeginInit()
                                'xRep.SuspendLayout()

                                xRep.LoadLayout(ReportLayout)
                                CType(xRep, System.ComponentModel.ISupportInitialize).EndInit()
                            End If
                        End If
                    Case 1 'RAW PRINT

                    Case 2 'EXTERNAL
                        Dim b As Byte()
                        Dim enc As New System.Text.UTF8Encoding
                        b = dt.Rows(0).Item("ReportData")

                        If IsDBNull(dt.Rows(0).Item("ReportData")) Then
                            ExternalFile = ""
                        Else
                            ExternalFile = enc.GetString(b)
                        End If

                End Select

                FormCode = IfNull(dt.Rows(0).Item("FormCode"), "")

                If IsDBNull(dt.Rows(0).Item("ReportSQL")) Then
                    txtSQL.Text = PrintScript
                Else
                    Dim b As Byte()
                    Dim enc As New System.Text.UTF8Encoding
                    b = dt.Rows(0).Item("ReportSQL")
                    txtSQL.Text = enc.GetString(b)
                End If
            End If
            dt.Dispose()
            da.Dispose()

        Catch ex As Exception

            MsgBox("(LoadForm) " & ex.Message)
        End Try

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim bFound As Boolean = False
        Dim ReportType As Long = 0
        Try
            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
            cmd.Parameters.Clear()
            txtReportName.Text = Replace(txtReportName.Text, "'", " ")
            If TypeOf cboReportType.EditValue Is clsMember Then
                ReportType = CType(cboReportType.EditValue, clsMember).ValueMember
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportID", ReportID))

            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportName", txtReportName.Text))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportData", SqlDbType.Image))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@FormCode", FormCode))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportType", ReportType))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ReportSQL", SqlDbType.Image))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@AfterPrintSQL", SqlDbType.Image))
            cmd.Parameters("@ReportData").Value = DBNull.Value
            cmd.Parameters("@ReportSQL").Value = DBNull.Value
            cmd.Parameters("@AfterPrintSQL").Value = DBNull.Value

            cmd.CommandText = "SELECT COUNT(*) FROM Piconn_ReportDesigns WHERE Deleted = 0 AND ReportID<>@ReportID AND FormCode=@FormCode AND ReportName=@ReportName "

            If cmd.ExecuteScalar > 0 Then
                bFound = True
            End If


            If bFound Then

                cmd.Dispose()
                MsgBox(AppConn.PiconnLanguage.TText("Ayni raport isminden baþka bir kayit daha var. Lütfen rapor ismini degistiriniz."))

                Exit Sub
            End If



            Select Case CType(cboReportType.SelectedItem, clsMember).ValueMember
                Case 0
                    ReportLayout = New IO.MemoryStream
                    xRep.SaveLayout(ReportLayout)
                    cmd.Parameters("@ReportData").Value = ReportLayout.ToArray
                Case 1 'RAW Print

                Case 2 'External

                    Dim b As Byte()
                    Dim enc1 As New System.Text.UTF8Encoding
                    b = enc1.GetBytes(ExternalFile)
                    cmd.Parameters("@ReportData").Value = b

            End Select



            Dim enc As New System.Text.UTF8Encoding
            cmd.Parameters("@ReportSQL").Value = enc.GetBytes(txtSQL.Text)
            cmd.Parameters("@AfterPrintSQL").Value = enc.GetBytes(txtPrintedSQL.Text)
            If IsNullGuid(ReportID) = True Then
                cmd.CommandText = "INSERT INTO Piconn_ReportDesigns (Deleted ,CreatedBy,CreatedDate,ModifiedBy ,ModifiedDate,ApplicationCode,FormCode,ReportName,ReportData,ReportSQL,ReportType,AfterPrintSQL) VALUES (" &
                "0," & AppConn.ActiveUser.UserID & ",GETDATE()," & AppConn.ActiveUser.UserID & ",GETDATE(),'',@FormCode, @ReportName,@ReportData,@ReportSQL,@ReportType,@AfterPrintSQL)"

            Else
                cmd.CommandText = "UPDATE Piconn_ReportDesigns SET Deleted = 0 ,ModifiedBy = " & AppConn.ActiveUser.UserID & ",ReportName=@ReportName,ReportData=@ReportData,ReportSQL=@ReportSQL, AfterPrintSQL=@AfterPrintSQL WHERE ReportID=@ReportID"
            End If
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("(cmdSave_Click) " & ex.Message)
        End Try

    End Sub

    Private Sub cmdDesign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesign.Click
        Try
            cboReportType.Properties.ReadOnly = True

            Select Case CType(cboReportType.SelectedItem, clsMember).ValueMember

                Case 1
                    With OpenFileDialog1
                        If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
                        RawFileName = .FileName
                    End With
                Case 2
                    Dim f As New frmExternalExe

                    f.ExternalFile = ExternalFile
                    f.FormShow()
                    If f.DialogResult = Windows.Forms.DialogResult.OK Then
                        ExternalFile = f.ExternalFile
                    End If
                    f.Dispose()
                Case Else
                    If bPrintFromDataSource = False Then
                        DesingFromScript()
                    Else
                        DesingFromDataSource()
                    End If
            End Select


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DesingFromScript()
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Dim bFound As Boolean = False
        Try

            cmd.Connection = AppConn.dbConn : cmd.CommandTimeout = 600 * 6
            cmd.CommandText = txtSQL.Text
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

                        'cmd.Parameters.Add(New SqlClient.SqlParameter(pr.ParameterName, OleDb.OleDbType.Double, pr.Size, ParameterDirection.InputOutput, True, pr.Precision, pr.Scale, pr.SourceColumn, DataRowVersion.Original, pr.Value))
                        cmd.Parameters.Add(New SqlClient.SqlParameter(pr.ParameterName, pr.Value))
                    End If

                Next
            End If
            If Trim(cmd.CommandText) <> "" Then
                da = New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                xRep.DataSource = dt
            End If
            xRep.CreateDocument()
            'xRep.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
            'Dim d As IO.DirectoryInfo

            xRep.Parameters.Clear()
            For Each pr As SqlClient.SqlParameter In cmd.Parameters
                Dim newpr As New DevExpress.XtraReports.Parameters.Parameter

                newpr.Name = Replace(pr.ParameterName, "@", "")
                newpr.Value = pr.Value

                xRep.Parameters.Add(newpr)
            Next
            xRep.SaveLayout(GetMyDir() & "\lastdesing.rpx")


            Dim pt As New DevExpress.XtraReports.UI.ReportDesignTool(xRep)
            pt.ShowRibbonDesignerDialog()

        Catch ex As Exception
            MsgBox("(DesingFromScript) " & ex.Message)
        End Try
    End Sub

    Private Sub DesingFromDataSource()
       
        Try
            'CType(xRep, System.ComponentModel.ISupportInitialize).BeginInit()
            ''xRep.SuspendLayout()

            'If TypeOf DataSource Is Devart.Data.SqlServer.SqlDataTable Then
            '    Dim dt As Devart.Data.SqlServer.SqlDataTable = CType(DataSource, Devart.Data.SqlServer.SqlDataTable) '.Copy
            '    'dt.FetchAll = False

            '    xRep.DataSource = dt.DefaultView.ToTable
            '    'Debug.Print(dt.DataSet.DataSetName)
            '    'xRep.DataSource = dt
            'Else
            '    xRep.DataSource = DataSource
            'End If

            xRep.DataSource = DataSource

            If TypeOf DataSource Is NeoDAC.NeoTable Then
                If Not CType(DataSource, NeoDAC.NeoTable).SelectCommand Is Nothing Then
                    For Each pr As SqlClient.SqlParameter In CType(DataSource, NeoDAC.NeoTable).SelectCommand.Parameters

                        Dim item As New DevExpress.XtraReports.Parameters.Parameter
                        Dim paramName As String = Replace(pr.ParameterName, "@", "")
                        Dim bFound As Boolean = False
                        item.Name = paramName
                        item.Value = pr.Value
                        For i As Integer = 0 To xRep.Parameters.Count - 1
                            If xRep.Parameters(i).Name = paramName Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound Then
                            xRep.Parameters(paramName).Value = pr.Value
                        Else
                            xRep.Parameters.Add(item)
                        End If

                    Next
                End If
            End If

            xRep.CreateDocument(True)
          

          


            'CType(xRep, System.ComponentModel.ISupportInitialize).EndInit()

            'xRep.SaveLayout(GetMyDir() & "\lastdesing.rpx")

            'xRep.ShowRibbonDesignerDialog()
            Dim pt As New DevExpress.XtraReports.UI.ReportDesignTool(xRep)
            pt.ShowRibbonDesignerDialog()


        Catch ex As Exception
            MsgBox("(DesingFromDataSource) " & ex.Message)
        End Try
    End Sub

    Private Sub ShowHideSQLPanel()
        Try

            If bShowSQLpanel Then
                'If UCaseEng(AppConn.ActiveUser.UserName) <> "ADMIN" Then
                '    bShowSQLpanel = False
                '    Exit Sub
                'End If
                Me.Height = 500
                panelSQL.Visible = True
            Else
                Me.Height = panelTop.Height + 30
                panelSQL.Visible = False
                CenterMe()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LoadReportTypes()
        Try
            cboReportType.Properties.Items.Clear()

            Dim cMember As clsMember
            cMember = New clsMember
            cMember.DisplayMember = "FORM"
            cMember.ValueMember = 0
            cboReportType.Properties.Items.Add(cMember)

            cMember = New clsMember
            cMember.DisplayMember = "RAW"
            cMember.ValueMember = 1
            cboReportType.Properties.Items.Add(cMember)
            cboReportType.SelectedIndex = 0

            cMember = New clsMember
            cMember.DisplayMember = "EXTERNAL"
            cMember.ValueMember = 2
            cboReportType.Properties.Items.Add(cMember)
            cboReportType.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmReportItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowHideSQLPanel()
    End Sub

    Private Sub cmdSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSQL.Click
        If bShowSQLpanel = True Then
            bShowSQLpanel = False
        Else
            bShowSQLpanel = True
        End If
        ShowHideSQLPanel()
    End Sub

    Private Sub LoadSQLPanel()
        Try
            txtParameters.Text = ""
            If Not Parameters Is Nothing Then
                For Each pr As SqlClient.SqlParameter In Parameters
                    txtParameters.Text &= pr.ParameterName & " = " & pr.Value.ToString & vbNewLine
                Next
            End If
            txtSQL.Text = PrintScript
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadReportTypes()
        
    End Sub

    Private Sub CenterMe()
        Try
            Me.Top = CInt(Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            Me.Left = CInt(Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class