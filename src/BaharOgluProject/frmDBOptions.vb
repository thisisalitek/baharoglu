Public Class frmDBOptions 
    Public Sub FormShow()
        Me.ShowDialog()
    End Sub
    Private Sub frmDBOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
           
            Dim sFileName As String = GetIniFileName()


            txtServer.Text = INIRead(sFileName, "SQLCONN", "Server", "(local)")
            txtDatabase.Text = INIRead(sFileName, "SQLCONN", "Database", "")
            Dim sbuf As String = INIRead(sFileName, "SQLCONN", "NTAuth", "False")
            chkNTAuth.Checked = CBool(sbuf)
            txtDBUser.Text = INIRead(sFileName, "SQLCONN", "DBUserName", "sa")
            txtDBPassword.Text = INIRead(sFileName, "SQLCONN", "DBPassword", "")


            txtMikro_Server.Text = INIRead(sFileName, "MIKROCONN", "Server", "(local)")
            txtMikro_Database.Text = INIRead(sFileName, "MIKROCONN", "Database", "")
            sbuf = INIRead(sFileName, "MIKROCONN", "NTAuth", "False")
            chkMikro_NTAuth.Checked = CBool(sbuf)
            txtMikro_DBUser.Text = INIRead(sFileName, "MIKROCONN", "DBUserName", "sa")
            txtMikro_DBPassword.Text = INIRead(sFileName, "MIKROCONN", "DBPassword", "")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try

            Dim sFileName As String = GetIniFileName()


            INIWrite(sFileName, "SQLCONN", "Server", txtServer.Text)
            INIWrite(sFileName, "SQLCONN", "Database", txtDatabase.Text)
            INIWrite(sFileName, "SQLCONN", "NTAuth", chkNTAuth.Checked.ToString)

            INIWrite(sFileName, "SQLCONN", "DBUserName", txtDBUser.Text)
            INIWrite(sFileName, "SQLCONN", "DBPassword", txtDBPassword.Text)


            INIWrite(sFileName, "MIKROCONN", "Server", txtMikro_Server.Text)
            INIWrite(sFileName, "MIKROCONN", "Database", txtMikro_Database.Text)
            INIWrite(sFileName, "MIKROCONN", "NTAuth", chkMikro_NTAuth.Checked.ToString)
            INIWrite(sFileName, "MIKROCONN", "DBUserName", txtMikro_DBUser.Text)
            INIWrite(sFileName, "MIKROCONN", "DBPassword", txtMikro_DBPassword.Text)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTestProbarDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestProbarDB.Click
        Try
            Dim connstr As String

            connstr = CreateConnectionString(txtServer.Text, txtDatabase.Text, chkNTAuth.Checked, txtDBUser.Text, txtDBPassword.Text)
            Dim conn As SqlClient.SqlConnection = ConnectSQL_ConnStr(connstr)
            If conn.State = ConnectionState.Open Then
                conn.Close()
                MsgBox("Bağlantı başarılı :-)")
            Else
                MsgBox("Bağlantı başarısız :-(")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTestMikroDB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTestMikroDB.Click
        Try
            Dim connstr As String

            connstr = CreateConnectionString(txtMikro_Server.Text, txtMikro_Database.Text, chkMikro_NTAuth.Checked, txtMikro_DBUser.Text, txtMikro_DBPassword.Text)
            Dim conn As SqlClient.SqlConnection = ConnectSQL_ConnStr(connstr)
            If conn.State = ConnectionState.Open Then
                conn.Close()
                MsgBox("Bağlantı başarılı :-)")
            Else
                MsgBox("Bağlantı başarısız :-(")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkNTAuth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNTAuth.CheckedChanged
        Try
            If chkNTAuth.Checked Then
                txtDBUser.Enabled = False
                txtDBPassword.Enabled = False
            Else
                txtDBUser.Enabled = True
                txtDBPassword.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkMikro_NTAuth_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMikro_NTAuth.CheckedChanged
        Try
            If chkMikro_NTAuth.Checked Then
                txtMikro_DBUser.Enabled = False
                txtMikro_DBPassword.Enabled = False
            Else
                txtMikro_DBUser.Enabled = True
                txtMikro_DBPassword.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCreateDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateDB.Click
        Try
            Dim connstr As String

            connstr = CreateConnectionString(txtServer.Text, "master", chkNTAuth.Checked, txtDBUser.Text, txtDBPassword.Text)
            Dim conn As SqlClient.SqlConnection = ConnectSQL_ConnStr(connstr)
            If conn.State <> ConnectionState.Open Then

                MsgBox("Bağlantı başarısız :-(")
                Exit Sub
            End If

            If AddDatabase(conn, txtDatabase.Text) = True Then
                MsgBox("Veri tabanı başarı ile oluşturuldu :-)")
            End If


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Function AddDatabase(ByVal conn As SqlClient.SqlConnection, ByVal DatabaseName As String) As Boolean
        On Error GoTo HELL
        If conn.State <> ConnectionState.Open Then Exit Function
        Dim cmd As New SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim bBulundu As Boolean = False
        Dim bVar As Boolean = False
        Dim sFilePath As String = ""
        
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM master..sysdatabases WHERE name like '" & DatabaseName & "'"
        rs = cmd.ExecuteReader
        If rs.Read Then
            bBulundu = True
        End If
        rs.Close()
        If bBulundu Then
            
            MsgBox("Bu veri tabanı mevcut. Başka bir veri tabanı ismi deneyiniz!")
            Return False

        End If

        If bBulundu = False Then
            cmd.CommandText = "select top 1 filename from sysfiles"
            rs = cmd.ExecuteReader
            If rs.Read Then
                sFilePath = IfNull(rs("filename"), "")
            End If
            rs.Close()
            sFilePath = IO.Path.GetDirectoryName(sFilePath)

            cmd.CommandText = "CREATE DATABASE [" & DatabaseName & "]  ON (NAME = N'" & DatabaseName & "_Data', FILENAME = N'" & sFilePath & "\" & DatabaseName & ".MDF' , SIZE = 10, FILEGROWTH = 10%) LOG ON (NAME = N'" & DatabaseName & "_Log', FILENAME = N'" & sFilePath & "\" & DatabaseName & "_Log.LDF' , SIZE = 1, FILEGROWTH = 10%) COLLATE Turkish_CI_AS" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'autoclose', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'bulkcopy', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'trunc. log', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'torn page detection', N'true'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'read only', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'dbo use', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'single', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'autoshrink', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'ANSI null default', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'recursive triggers', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'ANSI nulls', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'concat null yields null', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'cursor close on commit', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'default to local cursor', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'quoted identifier', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'ANSI warnings', N'false'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'auto create statistics', N'true'" & vbNewLine
            cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'auto update statistics', N'true'" & vbNewLine
            'cmd.CommandText &= "if( (@@microsoftversion / power(2, 24) = 8) and (@@microsoftversion & 0xffff >= 724) )  exec sp_dboption N'" & DatabaseName & "', N'db chaining', N'false'" & vbNewLine


            cmd.ExecuteNonQuery()

            cmd.Connection.ChangeDatabase(DatabaseName)
            If RunVersionScript(cmd.Connection, "sql_dbcreator.sql") Then
                GoTo basarili
            Else
                MsgBox("Veri tabanı script hatası oluştu. Sistem yöneticiniz ile görüşünüz.")
                Return False
            End If
        End If
basarili:
        
        cmd.Dispose()
        
        Return True
        Exit Function
HELL:
        RaiseError(Me.Name, "AddDatabase")
    End Function

End Class