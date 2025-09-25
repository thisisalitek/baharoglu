Public Class frmDovizKurlari
    Private Sub frmDovizKurlari_ButtonNewClick(Sender As Object, e As EventArgs) Handles MyBase.ButtonNewClick
        If MasterLink.CurrentRow Is Nothing Then Exit Sub
        MasterLink.CurrentRow("CurrDate") = Today



    End Sub

    Private Sub btnDownloadDovzKur_Click(sender As Object, e As EventArgs) Handles btnDownloadDovzKur.Click
        Try
            LoadingShow("Doviz kurlari indiriliyor...")
            Dim tcmb As New TCMB_Doviz

            tcmb.DovizKuruAl()
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
