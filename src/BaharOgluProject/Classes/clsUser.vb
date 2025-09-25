Public Class clsUser
    Public UserID As Long
    Public UserName As String
    Public FullName As String
    Public bAdmin As Boolean = False

    Private mVar_NewRecordAuthCode As String = ""
    Public Property NewRecordAuthCode() As String
        Get
            Return mVar_NewRecordAuthCode
        End Get
        Set(ByVal value As String)
            mVar_NewRecordAuthCode = value
        End Set
    End Property

    Private mVar_CanReadAuthCode As String = ""
    Public Property CanReadAuthCode() As String
        Get
            Return mVar_CanReadAuthCode
        End Get
        Set(ByVal value As String)
            mVar_CanReadAuthCode = value
        End Set
    End Property

    Private mVar_CanWriteAuthCode As String = ""
    Public Property CanWriteAuthCode() As String
        Get
            Return mVar_CanWriteAuthCode
        End Get
        Set(ByVal value As String)
            mVar_CanWriteAuthCode = value
        End Set
    End Property

    Private mVar_CanDeleteAuthCode As String = ""
    Public Property CanDeleteAuthCode() As String
        Get
            Return mVar_CanDeleteAuthCode
        End Get
        Set(ByVal value As String)
            mVar_CanDeleteAuthCode = value
        End Set
    End Property

    Public Function Login(ByVal conn As SqlClient.SqlConnection, ByVal sUserName As String, ByVal sPassword As String, Optional ByVal sTerminalCode As String = "", Optional ByVal sCardCode As String = "") As Boolean
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            'Dim crp As New Crypto("MessageBox")

            cmd.Connection = conn
            cmd.Parameters.Add(New SqlClient.SqlParameter("@UserName", sUserName))
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@Password", crp.Encrypt(sPassword)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Password", sPassword))
            cmd.CommandText = "SELECT * FROM Users WHERE Deleted = 0 AND (UserName=@UserName AND Password=@Password )"
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                dt.Dispose()
                da.Dispose()
                cmd.Dispose()
                Return False
            Else
                With dt.Rows(0)
                    UserID = If0Null(.Item("UserID"))
                    UserName = IfNull(.Item("UserName"), "")
                    FullName = IfNull(.Item("FullName"), "")
                    If If0Null(.Item("bAdmin")) = 1 Then
                        bAdmin = True
                    Else
                        bAdmin = False
                    End If
                End With
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
End Class
