Public Class frmFasonTanim

    Private Sub frmFasonTanim_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If IfNull(MasterLink.CurrentRow("FasonAciklama"), "") = "" Then
                e.Cancel = True
                MsgBox("Fason Açıklama boş olamaz!")

                Exit Sub
            End If
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
