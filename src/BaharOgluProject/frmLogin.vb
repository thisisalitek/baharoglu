
Imports Microsoft.Win32
Imports System.Windows.Forms


Public Class frmLogin
    
    Dim bActivated As Boolean = False
    Dim Me_Orginal_Text As String = ""

    Public fMain As frmMainMenu

    Public Sub FormLogin()
        Try

            lblVer.Text = ProgramVersion
            LoadForm()
            Me.ShowDialog()
            
        Catch ex As Exception
            MsgBox("(FormLogin)" & ex.Message)
        End Try
    End Sub


    Private Sub LoadForm()
        Try

            dtToday.DateTime = Today()
            'txtVeriTabani.Text = Registry.GetValue(RegistryHive.CurrentUser.ToString & "\Piconn", "Database", "")
           
            txtUserName.Text = GetSetting("Piconn", "Login", txtUserName.Name, "admin")
           
            Dim sFileName As String = GetIniFileName()

            Dim Server As String, Database As String
            Dim Mikro_Server As String, Mikro_Database As String

            Server = INIRead(sFileName, "SQLCONN", "Server", "")
            Database = INIRead(sFileName, "SQLCONN", "Database", "")
            lblProbarDB.Text = Server & " - " & Database
            Mikro_Server = INIRead(sFileName, "MIKROCONN", "Server", "")
            Mikro_Database = INIRead(sFileName, "MIKROCONN", "Database", "")
            lblTicariDB.Text = Mikro_Server & " - " & Mikro_Database
        Catch ex As Exception
            MsgBox("(LoadForm) " & ex.Message)
        End Try

    End Sub


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        Try

            AppConn.ApplicationCode = "Baharoglu"
            Dim sFileName As String = GetIniFileName()

            Dim Server As String, Database As String, NTAuth As Boolean, DBUser As String, DBPassword As String
            Dim Mikro_Server As String, Mikro_Database As String, Mikro_NTAuth As Boolean, Mikro_DBUser As String, Mikro_DBPassword As String

            Server = INIRead(sFileName, "SQLCONN", "Server", "(local)")
            Database = INIRead(sFileName, "SQLCONN", "Database", "")
            Dim sbuf As String = INIRead(sFileName, "SQLCONN", "NTAuth", "False")
            NTAuth = CBool(sbuf)
            DBUser = INIRead(sFileName, "SQLCONN", "DBUserName", "sa")
            DBPassword = INIRead(sFileName, "SQLCONN", "DBPassword", "")

            AppConn.dbConnStr = CreateConnectionString(Server, Database, NTAuth, DBUser, DBPassword)
            AppConn.dbConn = ConnectSQL_ConnStr(AppConn.dbConnStr)

            Mikro_Server = INIRead(sFileName, "MIKROCONN", "Server", "(local)")
            Mikro_Database = INIRead(sFileName, "MIKROCONN", "Database", "")
            sbuf = INIRead(sFileName, "MIKROCONN", "NTAuth", "False")
            Mikro_NTAuth = CBool(sbuf)
            Mikro_DBUser = INIRead(sFileName, "MIKROCONN", "DBUserName", "sa")
            Mikro_DBPassword = INIRead(sFileName, "MIKROCONN", "DBPassword", "")

            AppConn.dbTicariStr = CreateConnectionString(Mikro_Server, Mikro_Database, Mikro_NTAuth, Mikro_DBUser, Mikro_DBPassword)
            AppConn.dbTicari = ConnectSQL_ConnStr(AppConn.dbTicariStr)

            AppConn.mainConnStr = AppConn.dbConnStr
            AppConn.mainConn = AppConn.dbConn

            If AppConn.dbConn.State <> ConnectionState.Open Then
                MsgBox("Veri taban�na ba�lan�lamad�!")
                Exit Sub
            Else
                If AppConn.dbTicari.State <> ConnectionState.Open Then
                    MsgBox("Veri taban�na ba�lant�s� var fakat Ticari veri taban�na ba�lan�lamad�!")
                    Exit Sub
                End If
            End If

            If LocalVersionControl() = False Then
                Exit Sub
            End If

            If AppConn.ActiveUser.Login(AppConn.dbConn, txtUserName.Text, txtPassword.Text) = False Then
                MsgBox("Giri� ba�ar�s�z! Kullan�c� ad� veya �ifre hatal�!")
                txtPassword.Text = ""
                txtPassword.Focus()
                Exit Sub
            End If
            SaveSetting("Piconn", "Login", txtUserName.Name, txtUserName.Text)
            AppConn.Today = dtToday.DateTime

            'If DemoKontrol(AppConn.dbConn) = False Then Exit Sub
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception

            MsgBox("(cmdLogin_click) " & ex.Message)
        End Try

    End Sub

    Private Function DemoKontrol(ByVal conn As SqlClient.SqlConnection) As Boolean
        Try
            Dim Tarih As Date


            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT GETDATE()"
            Tarih = cmd.ExecuteScalar
            'If Tarih >= DateSerial(2013, 3, 31) Then
            '    MsgBox("Unexpected error occured! Please contact your system administrator.", MsgBoxStyle.Critical)
            '    Return False
            'End If
            'If Tarih >= DateSerial(2013, 3, 1) Then
            '    MsgBox("Hata: 56-57-73-56-57", MsgBoxStyle.Critical)
            '    Return True
            'End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'ShowApplicationSelect()
    End Sub


    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Return Then
            cmdLogin_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If bActivated Then Exit Sub
        bActivated = True
        If Trim(txtUserName.Text) <> "" Then
            txtPassword.Focus()
        End If
    End Sub

   
    

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
           
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            dtToday.DateTime = Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Private Sub cmdConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfig.Click
        Try

            Dim f As New frmDBOptions
            f.FormShow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Dim bFormMouseDown As Boolean

    Dim MouseX As Integer
    Dim MouseY As Integer

    Private Sub frmLogin_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, Label3.MouseDown
        bFormMouseDown = True
        MouseX = e.X
        MouseY = e.Y
    End Sub

    Private Sub frmLogin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, Label3.MouseMove
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Me.Left += e.X - MouseX
                Me.Top += e.Y - MouseY
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, Label3.MouseUp
        bFormMouseDown = False
    End Sub
End Class