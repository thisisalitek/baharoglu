Public Class frmKargolar

    Private Sub frmKargolar_ButtonDeleteBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteBeforeClick
        Try
            If RelationControl(FirmConn, MasterLink.CurrentRow(0), "Irsaliye", "KargoID") Then
                MsgBox(BaseTText("Bu kayit irsaliyelere baglidir. Silemezsiniz."))
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmKargolar_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If Trim(IfNull(MasterLink.CurrentRow("KargoIsmi"), "")) = "" Then
                e.Cancel = True
                MsgBox("Kargo ismi boş olamaz!")
                Exit Sub
            End If
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
