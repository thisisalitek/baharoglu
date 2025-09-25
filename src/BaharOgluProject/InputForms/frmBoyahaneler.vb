Public Class frmBoyahaneler

    Private Sub frmBoyahaneler_ButtonDeleteBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteBeforeClick
        Try
            If RelationControl(FirmConn, MasterLink.CurrentRow(0), "Siparis", "BoyahaneID") Then
                MsgBox(BaseTText("Bu kayit siparislere baglidir. Silemezsiniz."))
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBoyahaneler_ButtonSaveBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If Trim(IfNull(MasterLink.CurrentRow("Boyahane"), "")) = "" Then
                e.Cancel = True
                MsgBox("Lutfen isim giriniz!")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
