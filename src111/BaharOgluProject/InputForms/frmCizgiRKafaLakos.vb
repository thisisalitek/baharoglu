Public Class frmCizgiRKafaLakos

    Private Sub frmCizgiRKafaLakos_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If Trim(MasterLink.CurrentRow("Aciklama")) = "" Then
                e.Cancel = True
                MsgBox("Açıklama alanı boş olamaz!")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
