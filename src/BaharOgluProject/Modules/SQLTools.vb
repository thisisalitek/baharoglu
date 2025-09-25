
Public Module SQLTools
    Public Name As String = "SQLTools"

    Public Function ConnectSQL_ConnStr(ByVal ConnectionString As String, Optional ByVal bShowError As Boolean = True) As SqlClient.SqlConnection
        On Error GoTo HELL
        ConnectSQL_ConnStr = New SqlClient.SqlConnection

        ConnectSQL_ConnStr.ConnectionString = ConnectionString

        ConnectSQL_ConnStr.Open()

      

        Exit Function
HELL:
        If bShowError Then
            RaiseError(Name, "ConnectSQL_ConnStr")
        End If

    End Function

    Public Function CreateConnectionString(ByVal Server As String, ByVal Database As String, ByVal NTAuth As Boolean, ByVal DBUserName As String, ByVal DBPassword As String, Optional ByVal SQLNative As Boolean = False, Optional ByVal ApplicationName As String = "PiconnCevahir") As String
        If NTAuth Then
            Return "Server=" & Server & ";Database=" & Database & ";Trusted_Connection=Yes;Application Name=" & ApplicationName & ";"
        Else
            Return "Server=" & Server & ";Database=" & Database & ";User ID=" & DBUserName & ";Password=" & DBPassword & ";Trusted_Connection=False;Application Name=" & ApplicationName & ";"
        End If
    End Function

    Public Function ConnectSQL(Optional ByVal IniFileName As String = "Database.ini", Optional ByVal IniSection As String = "SQLCONN", Optional ByVal ApplicationName As String = "PiconnCevahir") As SqlClient.SqlConnection
        On Error GoTo HELL
        ConnectSQL = New SqlClient.SqlConnection
        Dim sFileName As String

        'Dim crp As New Crypto("MessageBox")
        Dim sbuf As String
        Dim Server As String, Database As String, NTAuth As Boolean, DBUserName As String, DBPassword As String = "", SQLNative As Boolean
        If InStr(IniFileName, "\") Then
            sFileName = IniFileName
        Else
            sFileName = GetMyDir() & "\" & IniFileName
        End If

        Server = INIRead(sFileName, IniSection, "Server", "(local)")
        Database = INIRead(sFileName, IniSection, "Database", "")
        sbuf = INIRead(sFileName, IniSection, "NTAuth", "False")
        NTAuth = CBool(sbuf)
        sbuf = INIRead(sFileName, IniSection, "SQLNative", "False")
        SQLNative = CBool(sbuf)
        DBUserName = INIRead(sFileName, IniSection, "DBUserName", "sa")
        sbuf = INIRead(sFileName, IniSection, "DBPassword", "")
        If sbuf.Trim <> "" Then
            'DBPassword = crp.Decrypt(sbuf)
            DBPassword = sbuf
        End If

        If Server = "" Or Database = "" Then
            Return New SqlClient.SqlConnection
        End If
        Return ConnectSQL_ConnStr(CreateConnectionString(Server, Database, NTAuth, DBUserName, DBPassword, SQLNative, ApplicationName), False)

        Exit Function
HELL:
        RaiseError(Name, "ConnectSQL")
    End Function

    Public Function pConnectionString(Optional ByVal IniFileName As String = "Database.ini", Optional ByVal IniSection As String = "SQLCONN", Optional ByVal ApplicationName As String = "PiconnCevahir", Optional ByVal sDatabase As String = "") As String
        On Error GoTo HELL
        Dim sFileName As String

        'Dim crp As New Crypto("MessageBox")
        Dim sbuf As String
        Dim Server As String, Database As String, NTAuth As Boolean, DBUserName As String, DBPassword As String = "", SQLNative As Boolean
        If InStr(IniFileName, "\") Then
            sFileName = IniFileName
        Else
            sFileName = GetMyDir() & "\" & IniFileName
        End If

        Server = INIRead(sFileName, IniSection, "Server", "(local)")
        If sDatabase = "" Then
            Database = INIRead(sFileName, IniSection, "Database", "")
        Else
            Database = sDatabase
        End If
        sbuf = INIRead(sFileName, IniSection, "NTAuth", "False")
        NTAuth = CBool(sbuf)
        sbuf = INIRead(sFileName, IniSection, "SQLNative", "False")
        SQLNative = CBool(sbuf)
        DBUserName = INIRead(sFileName, IniSection, "DBUserName", "sa")
        sbuf = INIRead(sFileName, IniSection, "DBPassword", "")
        If sbuf.Trim <> "" Then
            'DBPassword = crp.Decrypt(sbuf)
            DBPassword = sbuf
        End If

        If Server = "" Or Database = "" Then
            Return ""
        End If
        Return CreateConnectionString(Server, Database, NTAuth, DBUserName, DBPassword, SQLNative, ApplicationName)

        Exit Function
HELL:
        RaiseError(Name, "ConnectSQL")
    End Function
End Module

