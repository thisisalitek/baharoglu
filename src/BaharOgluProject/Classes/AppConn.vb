Imports System.Windows.Forms



Public Class cAppConn
    Implements IDisposable

    Dim mVar_dbConn As SqlClient.SqlConnection
    Dim mVar_mainConn As SqlClient.SqlConnection
    Dim mVar_dbTicari As SqlClient.SqlConnection
    Dim mVar_ActiveUser As clsUser
    Dim mVar_ActiveFirm As clsFirm
    Dim mVar_ActiveOffice As clsFirmOffice
    Dim mVar_ApplicationCode As String
    Dim mVar_Today As Date
    Dim mVar_MainSPID As Long = 0
    Dim mVar_dbSPID As Long = 0
    Dim mVar_dbConnStr As String = ""
    Dim mVar_mainConnStr As String = ""
    Dim mVar_dbTicariStr As String = ""

    Dim mVar_DefaultCurrencyID As Long = 0
    Dim mVar_DefaultCurrencyCode As String = ""

    Dim mVar_ReportCurrencyID As Long = 0
    Dim mVar_ReportCurrencyCode As String = ""

    'Dim mVar_Language As typeLanguage = typeLanguage.Turkish
    Dim mVar_Language As String = "TR"

    Dim mVar_Y As Long = 0

    Dim mVar_WarehouseID As Guid
    ' Dim mVar_DepartmentID As Long = 0

    Dim mVar_FormSecurityTable As DataTable

    'Dim mVar_LanguageDB As DataTable
    'Dim mVar_CustomLanguageDB As DataTable


    Public Sub New()
        mVar_dbConn = New SqlClient.SqlConnection
        mVar_mainConn = New SqlClient.SqlConnection
        mVar_ActiveUser = New clsUser
        mVar_ActiveFirm = New clsFirm
        mVar_ActiveOffice = New clsFirmOffice
        mVar_FormSecurityTable = New DataTable
        mVar_PiconnLanguage = New PiconnLanguage

    End Sub

    Public Property dbTicari() As SqlClient.SqlConnection
        Get
            Return mVar_dbTicari

        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            mVar_dbTicari = value
        End Set
    End Property

    Public Property dbTicariStr() As String
        Get
            Return mVar_dbTicariStr

        End Get
        Set(ByVal value As String)
            mVar_dbTicariStr = value
        End Set
    End Property

    Public Property dbConn() As SqlClient.SqlConnection
        Get
            Return mVar_dbConn

        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            mVar_dbConn = value
        End Set
    End Property

    Public Property dbConnStr() As String
        Get
            Return mVar_dbConnStr

        End Get
        Set(ByVal value As String)
            mVar_dbConnStr = value
        End Set
    End Property

    Public Property mainConn() As SqlClient.SqlConnection
        Get
            Return mVar_mainConn
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            mVar_mainConn = value
        End Set
    End Property

    Public Property mainConnStr() As String
        Get
            Return mVar_mainConnStr

        End Get
        Set(ByVal value As String)
            mVar_mainConnStr = value
        End Set
    End Property

    'Dim mVar_MikroConn As SqlClient.SqlConnection
    'Public Property MikroConn() As SqlClient.SqlConnection
    '    Get
    '        Return mVar_MikroConn

    '    End Get
    '    Set(ByVal value As SqlClient.SqlConnection)
    '        mVar_MikroConn = value
    '    End Set
    'End Property

    'Dim mVar_MikroConnStr As String = ""
    'Public Property MikroConnStr() As String
    '    Get
    '        Return mVar_MikroConnStr

    '    End Get
    '    Set(ByVal value As String)
    '        mVar_MikroConnStr = value
    '    End Set

    'End Property

    Public Property ActiveUser() As clsUser
        Get
            Return mVar_ActiveUser

        End Get
        Set(ByVal value As clsUser)
            mVar_ActiveUser = value
        End Set
    End Property

    Public Property ActiveFirm() As clsFirm
        Get
            Return mVar_ActiveFirm
        End Get
        Set(ByVal value As clsFirm)
            mVar_ActiveFirm = value
        End Set
    End Property

    Public Property ActiveOffice() As clsFirmOffice
        Get
            Return mVar_ActiveOffice
        End Get
        Set(ByVal value As clsFirmOffice)
            mVar_ActiveOffice = value
        End Set
    End Property




    Public Property ApplicationCode() As String
        Get
            Return mVar_ApplicationCode
        End Get
        Set(ByVal value As String)
            mVar_ApplicationCode = value
        End Set
    End Property

    Public Property Today() As Date
        Get
            Return mVar_Today
        End Get
        Set(ByVal value As Date)
            mVar_Today = value
        End Set
    End Property

    'Public Property MainSPID() As Long
    '    Get
    '        Return mVar_MainSPID
    '    End Get
    '    Set(ByVal value As Long)
    '        mVar_MainSPID = value
    '    End Set
    'End Property

    Public Property dbSPID() As Long
        Get
            Return mVar_dbSPID
        End Get
        Set(ByVal value As Long)
            mVar_dbSPID = value
        End Set
    End Property

    Public Property DefaultCurrencyCode() As String
        Get
            Return mVar_DefaultCurrencyCode

        End Get
        Set(ByVal value As String)
            mVar_DefaultCurrencyCode = value
        End Set
    End Property

    Public Property ReportCurrencyCode() As String
        Get
            Return mVar_ReportCurrencyCode

        End Get
        Set(ByVal value As String)
            mVar_ReportCurrencyCode = value
        End Set
    End Property

    Public Property DefaultCurrencyID() As Long
        Get
            Return mVar_DefaultCurrencyID

        End Get
        Set(ByVal value As Long)
            mVar_DefaultCurrencyID = value
        End Set
    End Property

    Public Property ReportCurrencyID() As Long
        Get
            Return mVar_ReportCurrencyID

        End Get
        Set(ByVal value As Long)
            mVar_ReportCurrencyID = value
        End Set
    End Property

    'Public Property Language() As typeLanguage
    '    Get
    '        Return mVar_Language

    '    End Get
    '    Set(ByVal value As typeLanguage)
    '        mVar_Language = value
    '    End Set
    'End Property

    Public Property Language() As String
        Get
            Return mVar_Language

        End Get
        Set(ByVal value As String)
            mVar_Language = value
        End Set
    End Property

    Public Property Y() As Long
        Get
            Return mVar_Y

        End Get
        Set(ByVal value As Long)
            mVar_Y = value
        End Set
    End Property

    Dim mVar_WarehouseCode As String
    Public Property WarehouseCode() As String
        Get
            Return mVar_WarehouseCode
        End Get
        Set(ByVal value As String)
            mVar_WarehouseCode = value
        End Set
    End Property

    Public Property WarehouseID() As Guid
        Get
            Return mVar_WarehouseID

        End Get
        Set(ByVal value As Guid)
            mVar_WarehouseID = value
        End Set
    End Property

    'Public Property DepartmentID() As Long
    '    Get
    '        Return mVar_DepartmentID

    '    End Get
    '    Set(ByVal value As Long)
    '        mVar_DepartmentID = value
    '    End Set
    'End Property

    'Public Property LanguageDB() As DataTable
    '    Get
    '        Return mVar_LanguageDB
    '    End Get
    '    Set(ByVal value As DataTable)
    '        mVar_LanguageDB = value
    '    End Set
    'End Property
    'Public Property CustomLanguageDB() As DataTable
    '    Get
    '        Return mVar_CustomLanguageDB
    '    End Get
    '    Set(ByVal value As DataTable)
    '        mVar_CustomLanguageDB = value
    '    End Set
    'End Property

    Public Function LoadLanguage() As Boolean
        Try
            mVar_PiconnLanguage = New PiconnLanguage()
            Dim LanguageDB_FileName As String = GetMyDir() & "\LanguageDB.xml"
            Dim CustomLanguageDB_FileName As String = GetMyDir() & "\CustomLanguageDB.xml"
            If IO.File.Exists(LanguageDB_FileName) Then
                Dim ds As New DataSet
                ds.ReadXml(LanguageDB_FileName)
                mVar_PiconnLanguage.LanguageDB = ds.Tables(0)
                ds.Tables.RemoveAt(0)

            End If
            Dim bFoundCustoLang As Boolean = False
            If IO.File.Exists(CustomLanguageDB_FileName) Then
                Dim ds As New DataSet
                Try

                    ds.ReadXml(CustomLanguageDB_FileName)
                Catch ex As Exception

                End Try
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        mVar_PiconnLanguage.CustomizedLanguageDB = ds.Tables(0)
                        ds.Tables.RemoveAt(0)
                        bFoundCustoLang = True
                    End If

                End If

            Else


            End If
            If bFoundCustoLang = False Then
                If Not mVar_PiconnLanguage.LanguageDB Is Nothing Then
                    mVar_PiconnLanguage.CustomizedLanguageDB = New DataTable

                    For Each dc As DataColumn In mVar_PiconnLanguage.LanguageDB.Columns
                        mVar_PiconnLanguage.CustomizedLanguageDB.Columns.Add(New DataColumn(dc.ColumnName, dc.DataType))
                    Next
                End If
            End If
            If Not mVar_PiconnLanguage.LanguageDB Is Nothing Then
                mVar_PiconnLanguage.LanguageDB.TableName = "LangPiconnCevahir"
            End If
            If Not mVar_PiconnLanguage.CustomizedLanguageDB Is Nothing Then
                mVar_PiconnLanguage.CustomizedLanguageDB.TableName = "LangPiconnCevahir"
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function Connect() As Boolean

        mVar_dbConnStr = pConnectionString()

        mVar_dbConn = ConnectSQL_ConnStr(mVar_dbConnStr, False)
        If mVar_dbConn.State = ConnectionState.Open Then
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = mVar_dbConn
                cmd.CommandText = "SELECT @@SPID"
                mVar_dbSPID = cmd.ExecuteScalar
                cmd.Dispose()
                Return True
            Catch ex As Exception
                Return False
            End Try

        Else
            Return False
        End If
    End Function

    Public Function GetFormSecurity(ByVal FormCode As String) As FormSecurity
        Dim c As New FormSecurity
        Try
            If mVar_FormSecurityTable Is Nothing Then GoTo Cikis
            If mVar_FormSecurityTable.Rows.Count <= 0 Then GoTo Cikis
            c.FormCode = FormCode
            c.ApplicationCode = mVar_ApplicationCode
            For Each dr As DataRow In mVar_FormSecurityTable.Rows
                If IfNull(dr("FormCode"), "") = FormCode Then
                    If IfNull(dr("CanRead"), 1) = 0 Then c.CanRead = False Else c.CanRead = True
                    If IfNull(dr("CanWrite"), 1) = 0 Then c.CanWrite = False Else c.CanWrite = True
                    If IfNull(dr("CanDelete"), 1) = 0 Then c.CanDelete = False Else c.CanDelete = True
                    If IfNull(dr("CanPrintGrid"), 1) = 0 Then c.CanPrintGrid = False Else c.CanPrintGrid = True
                    If IfNull(dr("CanPrintForm"), 1) = 0 Then c.CanPrintForm = False Else c.CanPrintForm = True
                    If IfNull(dr("CanExport"), 1) = 0 Then c.CanExport = False Else c.CanExport = True
                    If IfNull(dr("CanExportExcel"), 1) = 0 Then c.CanExportExcel = False Else c.CanExportExcel = True
                    If IfNull(dr("CanExportTxt"), 1) = 0 Then c.CanExportTxt = False Else c.CanExportTxt = True
                    If IfNull(dr("CanExportCsv"), 1) = 0 Then c.CanExportCsv = False Else c.CanExportCsv = True
                    If IfNull(dr("CanExportPdf"), 1) = 0 Then c.CanExportPdf = False Else c.CanExportPdf = True
                    If IfNull(dr("CanExportHtml"), 1) = 0 Then c.CanExportHtml = False Else c.CanExportHtml = True
                End If
            Next

            Return c
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
Cikis:
        Return New FormSecurity
    End Function

    Public Function InitFormSecurity() As Boolean
        Try
            ' mVar_FormSecurityTable = PrepareFormSecurities()
            'Debug.Print(mVar_FormSecurityTable.Rows.Count)
            'For Each dr As DataRow In mVar_FormSecurityTable.Rows
            '    Dim s As String = ""
            '    For Each dc As DataColumn In mVar_FormSecurityTable.Columns
            '        s &= dc.ColumnName & ":" & IfNull(dr(dc.ColumnName), "") & " | "
            '    Next
            '    Debug.Print(s)
            'Next
        Catch ex As Exception
            MsgBox("(InitFormSecurity) " & ex.Message)
        End Try

    End Function

    '        Private Function PrepareFormSecurities() As DataTable
    '            Try

    '                Dim m_Node As Xml.XmlNode
    '                Dim app_Node As Xml.XmlNode
    '                Dim XmlForms As New Xml.XmlDocument
    '                Dim dt As New DataTable
    '                Dim cmd As New SqlClient.SqlCommand
    '                Dim da As SqlClient.SqlDataAdapter
    '                Dim dt2 As DataTable
    '                If Trim(PiconnUtility.dynamoEmpire.PiconnUtility.GetApplicationForms.InnerXml) = "" Then GoTo Cikis
    '                XmlForms.LoadXml(PiconnUtility.dynamoEmpire.PiconnUtility.GetApplicationForms.InnerXml)

    '                'Debug.Print(XmlForms.InnerXml.ToString)
    '                cmd = New SqlClient.SqlCommand
    '                cmd.Connection = mVar_mainConn
    '                cmd.CommandText = "SELECT * FROM FormSecurity WHERE 1=0 "
    '                dt = New DataTable
    '                da = New SqlClient.SqlDataAdapter(cmd)
    '                da.Fill(dt)
    '                da.Dispose()
    '                cmd.Dispose()
    '                For Each app_Node In XmlForms.SelectNodes("/Root/Application")
    '                    If app_Node.SelectSingleNode("ApplicationCode").InnerText = "Piconn.Cevahir" Then
    '                        'Debug.Print(app_Node.SelectNodes("Forms/Form").Count)
    '                        For Each m_Node In app_Node.SelectNodes("Forms/Form")

    '                            Dim dr As DataRow = dt.NewRow
    '                            dr("ApplicationCode") = mVar_ApplicationCode
    '                            dr("FormCode") = m_Node.SelectSingleNode("FormCode").InnerText
    '                            dr("CanRead") = 0
    '                            dr("CanWrite") = 0
    '                            dr("CanDelete") = 0
    '                            dr("CanPrintGrid") = 0
    '                            dr("CanPrintForm") = 0
    '                            dr("CanExport") = 0
    '                            dr("CanExportExcel") = 0
    '                            dr("CanExportTxt") = 0
    '                            dr("CanExportCsv") = 0
    '                            dr("CanExportPdf") = 0
    '                            dr("CanExportHtml") = 0

    '                            If Trim(IfNull(dr("FormCode"), "")) <> "" Then
    '                                Debug.Print(IfNull(dr("FormCode"), ""))
    '                                'USER a bak
    '                                cmd = New SqlClient.SqlCommand
    '                                cmd.Connection = mVar_mainConn
    '                                cmd.Parameters.Clear()
    '                                cmd.Parameters.Add(New SqlClient.SqlParameter("@ApplicationCode", "Piconn.Cevahir"))
    '                                cmd.Parameters.Add(New SqlClient.SqlParameter("@FormCode", IfNull(dr("FormCode"), "")))
    '                                cmd.CommandText = "SELECT TOP 1 * FROM FormSecurity " & _
    '                                    "WHERE     (Deleted = 0) AND (UserID = " & mVar_ActiveUser.UserID & ") AND (FormCode = @FormCode) AND (ApplicationCode=@ApplicationCode) " & _
    '                                    "ORDER BY FormSecurityID DESC"
    '                                dt2 = New DataTable
    '                                da = New SqlClient.SqlDataAdapter(cmd)
    '                                da.Fill(dt2)
    '                                If dt2.Rows.Count > 0 Then
    '                                    dr("CanRead") = IfNull(dt2.Rows(0).Item("CanRead"), 0)
    '                                    dr("CanWrite") = IfNull(dt2.Rows(0).Item("CanWrite"), 0)
    '                                    dr("CanDelete") = IfNull(dt2.Rows(0).Item("CanDelete"), 0)
    '                                    dr("CanPrintGrid") = IfNull(dt2.Rows(0).Item("CanPrintGrid"), 0)
    '                                    dr("CanPrintForm") = IfNull(dt2.Rows(0).Item("CanPrintForm"), 0)
    '                                    dr("CanExport") = IfNull(dt2.Rows(0).Item("CanExport"), 0)
    '                                    dr("CanExportExcel") = IfNull(dt2.Rows(0).Item("CanExportExcel"), 0)
    '                                    dr("CanExportTxt") = IfNull(dt2.Rows(0).Item("CanExportTxt"), 0)
    '                                    dr("CanExportCsv") = IfNull(dt2.Rows(0).Item("CanExportCsv"), 0)
    '                                    dr("CanExportPdf") = IfNull(dt2.Rows(0).Item("CanExportPdf"), 0)
    '                                    dr("CanExportHtml") = IfNull(dt2.Rows(0).Item("CanExportHtml"), 0)
    '                                End If
    '                                dt2.Dispose()
    '                                da.Dispose()
    '                                cmd.Dispose()


    '                                'User ın dahil olduğu gruplara bak
    '                                cmd = New SqlClient.SqlCommand
    '                                cmd.Connection = mVar_mainConn
    '                                cmd.Parameters.Clear()
    '                                cmd.Parameters.Add(New SqlClient.SqlParameter("@ApplicationCode", mVar_ApplicationCode))
    '                                cmd.Parameters.Add(New SqlClient.SqlParameter("@FormCode", IfNull(dr("FormCode"), "")))
    '                                cmd.CommandText = "SELECT     SUM(CASE ISNULL(FormSecurity.CanRead, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanRead END) AS CanRead, " & _
    '                                            "                      SUM(CASE ISNULL(FormSecurity.CanWrite, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanWrite END) AS CanWrite,  " & _
    '                                            "                      SUM(CASE ISNULL(FormSecurity.CanDelete, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanDelete END) AS CanDelete,  " & _
    '                                            "                      SUM(CASE ISNULL(FormSecurity.CanPrintGrid, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanPrintGrid END) AS CanPrintGrid,  " & _
    '                                            "                      SUM(CASE ISNULL(FormSecurity.CanPrintForm, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanPrintForm END) AS CanPrintForm,  " & _
    '                                            "                      SUM(CASE ISNULL(FormSecurity.CanExport, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanExport END) AS CanExport,  " & _
    '                                            "                      SUM(CASE ISNULL(FormSecurity.CanExportExcel, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanExportExcel END)  " & _
    '                                            "                      AS CanExportExcel, SUM(CASE ISNULL(FormSecurity.CanExportTxt, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanExportTxt END)  " & _
    '                                            "                      AS CanExportTxt, SUM(CASE ISNULL(FormSecurity.CanExportCsv, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanExportCsv END)  " & _
    '                                            "                      AS CanExportCsv, SUM(CASE ISNULL(FormSecurity.CanExportPdf, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanExportPdf END)  " & _
    '                                            "                      AS CanExportPdf, SUM(CASE ISNULL(FormSecurity.CanExportHtml, 0) WHEN 1 THEN 1000 ELSE FormSecurity.CanExportHtml END)  " & _
    '                                            "                      AS CanExportHtml " & _
    '                                            "FROM         FormSecurity INNER JOIN " & _
    '                                            "                      UserConnGroup ON FormSecurity.UserGroupID = UserConnGroup.Piconn_UserGroupID " & _
    '                                            "WHERE     (FormSecurity.Deleted = 0) AND (FormSecurity.FormCode = @FormCode) AND (FormSecurity.UserID = 0) AND  " & _
    '                                            "                      (UserConnGroup.Deleted = 0) AND (UserConnGroup.Piconn_UserID = " & mVar_ActiveUser.UserID & ") AND (FormSecurity.ApplicationCode = @ApplicationCode) "
    '                                dt2 = New DataTable
    '                                da = New SqlClient.SqlDataAdapter(cmd)
    '                                da.Fill(dt2)
    '                                If dt2.Rows.Count > 0 Then
    '                                    If dr("CanRead") = 0 Then dr("CanRead") = IfNull(dt2.Rows(0).Item("CanRead"), 0)
    '                                    If dr("CanWrite") = 0 Then dr("CanWrite") = IfNull(dt2.Rows(0).Item("CanWrite"), 0)
    '                                    If dr("CanDelete") = 0 Then dr("CanDelete") = IfNull(dt2.Rows(0).Item("CanDelete"), 0)
    '                                    If dr("CanPrintGrid") = 0 Then dr("CanPrintGrid") = IfNull(dt2.Rows(0).Item("CanPrintGrid"), 0)
    '                                    If dr("CanPrintForm") = 0 Then dr("CanPrintForm") = IfNull(dt2.Rows(0).Item("CanPrintForm"), 0)
    '                                    If dr("CanExport") = 0 Then dr("CanExport") = IfNull(dt2.Rows(0).Item("CanExport"), 0)
    '                                    If dr("CanExportExcel") = 0 Then dr("CanExportExcel") = IfNull(dt2.Rows(0).Item("CanExportExcel"), 0)
    '                                    If dr("CanExportTxt") = 0 Then dr("CanExportTxt") = IfNull(dt2.Rows(0).Item("CanExportTxt"), 0)
    '                                    If dr("CanExportCsv") = 0 Then dr("CanExportCsv") = IfNull(dt2.Rows(0).Item("CanExportCsv"), 0)
    '                                    If dr("CanExportPdf") = 0 Then dr("CanExportPdf") = IfNull(dt2.Rows(0).Item("CanExportPdf"), 0)
    '                                    If dr("CanExportHtml") = 0 Then dr("CanExportHtml") = IfNull(dt2.Rows(0).Item("CanExportHtml"), 0)
    '                                End If
    '                                dt2.Dispose()
    '                                da.Dispose()
    '                                cmd.Dispose()

    '                                If dr("CanRead") >= 0 Then dr("CanRead") = 1 Else dr("CanRead") = 0
    '                                If dr("CanWrite") >= 0 Then dr("CanWrite") = 1 Else dr("CanWrite") = 0
    '                                If dr("CanDelete") >= 0 Then dr("CanDelete") = 1 Else dr("CanDelete") = 0
    '                                If dr("CanPrintGrid") >= 0 Then dr("CanPrintGrid") = 1 Else dr("CanPrintGrid") = 0
    '                                If dr("CanPrintForm") >= 0 Then dr("CanPrintForm") = 1 Else dr("CanPrintForm") = 0
    '                                If dr("CanExport") >= 0 Then dr("CanExport") = 1 Else dr("CanExport") = 0
    '                                If dr("CanExportExcel") >= 0 Then dr("CanExportExcel") = 1 Else dr("CanExportExcel") = 0
    '                                If dr("CanExportTxt") >= 0 Then dr("CanExportTxt") = 1 Else dr("CanExportTxt") = 0
    '                                If dr("CanExportCsv") >= 0 Then dr("CanExportCsv") = 1 Else dr("CanExportCsv") = 0
    '                                If dr("CanExportPdf") >= 0 Then dr("CanExportPdf") = 1 Else dr("CanExportPdf") = 0
    '                                If dr("CanExportHtml") >= 0 Then dr("CanExportHtml") = 1 Else dr("CanExportHtml") = 0
    '                                dt.Rows.Add(dr)
    '                            End If
    '                        Next

    '                    End If
    '                Next

    '                Return dt
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    'Cikis:
    '            Return Nothing
    '        End Function

    Public Function LicenseControl() As Boolean

    End Function

    Public Sub Close()

    End Sub

    Dim mVar_PiconnLanguage As PiconnLanguage
    Public Property PiconnLanguage() As PiconnLanguage
        Get
            Return mVar_PiconnLanguage

        End Get
        Set(ByVal value As PiconnLanguage)
            mVar_PiconnLanguage = value
        End Set
    End Property


    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
                If Not mVar_dbConn Is Nothing Then
                    If mVar_dbConn.State = ConnectionState.Open Then
                        mVar_dbConn.Close()
                        Do While mVar_dbConn.State = ConnectionState.Open
                            Application.DoEvents()
                        Loop
                    End If
                    mVar_dbConn.Dispose()
                End If


            End If

            If Not mVar_dbConn Is Nothing Then
                If mVar_dbConn.State = ConnectionState.Open Then
                    mVar_dbConn.Close()
                    Do While mVar_dbConn.State = ConnectionState.Open
                        Application.DoEvents()
                    Loop
                End If
                mVar_dbConn.Dispose()
            End If


            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

'Public Enum typeLanguage
'    Turkish = 0
'    English = 1
'    German = 2
'    Italian = 3
'    Russian = 4
'    Bulgarian = 5
'    Greek = 6
'    Spanish = 7
'End Enum

Public Class FormSecurity
    Private mvar_FormCode As String = ""
    Private mvar_ApplicationCode As String = ""

    Private mvar_CanRead As Boolean = True
    Private mvar_CanWrite As Boolean = True
    Private mvar_CanDelete As Boolean = True
    Private mvar_CanPrintGrid As Boolean = True
    Private mvar_CanPrintForm As Boolean = True
    Private mvar_CanExport As Boolean = True
    Private mvar_CanExportExcel As Boolean = True
    Private mvar_CanExportTxt As Boolean = True
    Private mvar_CanExportCsv As Boolean = True
    Private mvar_CanExportPdf As Boolean = True
    Private mvar_CanExportHtml As Boolean = True

    Public Property FormCode() As String
        Get
            Return mvar_FormCode
        End Get
        Set(ByVal value As String)
            mvar_FormCode = value
        End Set
    End Property

    Public Property ApplicationCode() As String
        Get
            Return mvar_ApplicationCode
        End Get
        Set(ByVal value As String)
            mvar_ApplicationCode = value
        End Set
    End Property

    Public Property CanRead() As Boolean
        Get
            Return mvar_CanRead
        End Get
        Set(ByVal value As Boolean)
            mvar_CanRead = value
        End Set
    End Property

    Public Property CanWrite() As Boolean
        Get
            Return mvar_CanWrite
        End Get
        Set(ByVal value As Boolean)
            mvar_CanWrite = value
        End Set
    End Property

    Public Property CanDelete() As Boolean
        Get
            Return mvar_CanDelete
        End Get
        Set(ByVal value As Boolean)
            mvar_CanDelete = value
        End Set
    End Property

    Public Property CanPrintGrid() As Boolean
        Get
            Return mvar_CanPrintGrid
        End Get
        Set(ByVal value As Boolean)
            mvar_CanPrintGrid = value
        End Set
    End Property

    Public Property CanPrintForm() As Boolean
        Get
            Return mvar_CanPrintForm
        End Get
        Set(ByVal value As Boolean)
            mvar_CanPrintForm = value
        End Set
    End Property

    Public Property CanExport() As Boolean
        Get
            Return mvar_CanExport
        End Get
        Set(ByVal value As Boolean)
            mvar_CanExport = value
            If value = False Then
                mvar_CanExportExcel = False
                mvar_CanExportTxt = False
                mvar_CanExportCsv = False
                mvar_CanExportPdf = False
                mvar_CanExportHtml = False
            End If
        End Set
    End Property

    Public Property CanExportExcel() As Boolean
        Get
            Return mvar_CanExportExcel
        End Get
        Set(ByVal value As Boolean)
            If mvar_CanExport = False Then
                mvar_CanExportExcel = False
            Else
                mvar_CanExportExcel = value
            End If

        End Set
    End Property

    Public Property CanExportTxt() As Boolean
        Get
            Return mvar_CanExportTxt
        End Get
        Set(ByVal value As Boolean)
            If mvar_CanExport = False Then
                mvar_CanExportTxt = False
            Else
                mvar_CanExportTxt = value
            End If
        End Set
    End Property

    Public Property CanExportCsv() As Boolean
        Get
            Return mvar_CanExportCsv
        End Get
        Set(ByVal value As Boolean)
            If mvar_CanExport = False Then
                mvar_CanExportCsv = False
            Else
                mvar_CanExportCsv = value
            End If
        End Set
    End Property

    Public Property CanExportPdf() As Boolean
        Get
            Return mvar_CanExportPdf
        End Get
        Set(ByVal value As Boolean)
            If mvar_CanExport = False Then
                mvar_CanExportPdf = False
            Else
                mvar_CanExportPdf = value
            End If
        End Set
    End Property

    Public Property CanExportHtml() As Boolean
        Get
            Return mvar_CanExportHtml
        End Get
        Set(ByVal value As Boolean)
            If mvar_CanExport = False Then
                mvar_CanExportHtml = False
            Else
                mvar_CanExportHtml = value
            End If
        End Set
    End Property

End Class


