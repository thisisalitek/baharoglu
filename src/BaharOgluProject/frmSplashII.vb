Imports System.Windows.Forms


Public NotInheritable Class frmSplashII
    Dim bActivated As Boolean = False
    Dim bCanClose As Boolean = False
    Dim fmain As frmMainMenu

    Private Sub frmSplash_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If bActivated = True Then Exit Sub
        bActivated = True

        Timer1.Enabled = True
        Do While Timer1.Enabled

            Application.DoEvents()
        Loop


        Try
            Dim bLoginAgain As Boolean = False

LoginAgain:

            fmain = New frmMainMenu


            With fmain
                AppConn.ApplicationCode = "Baharoglu"




            End With

            anaform = fmain

            Timer2.Enabled = True
        Catch ex As Exception
            bCanClose = True

            MsgBox("Splash.Activated Error:" & ex.Message)
            Timer2.Enabled = True
        End Try

    End Sub

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).



    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bCanClose Then

    '        Me.Close()
    '    End If
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Timer2.Enabled = False

            fmain.FormShow(Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub

    
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
