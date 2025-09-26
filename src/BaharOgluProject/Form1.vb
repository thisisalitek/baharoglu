Public Class Form1




    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            InitializeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub InitializeConnection()
        Try
            'NeoConnection1.ConnectionString = AppConn.dbConnStr

            'NeoConnection1.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs)
        Try
            Dim f As New frmAlimIrsaliyeleri
            With f
                
                .FormShow(False)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        Dim f As New frmSevkler

        f.FormShow(False)

    End Sub

    Private Sub CntUrunAgaci1_Selected_Changed(Sender As Object, e As UrunAgaciChangedEventArgs) 
        Try


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Button1ToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim f As New frmSipAlanlar
            With f
                .MdiParent = anaform
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
