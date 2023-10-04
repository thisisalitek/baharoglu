Public Class frmKumasKatalog

    Private Sub frmKumasKatalog_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If Trim(IfNull(MasterLink.CurrentRow("KatalogKod"), "")) = "" Then
                e.Cancel = True
                MsgBox("Lütfen katalog kodunu giriniz!")
                Exit Sub
            End If
            If Trim(IfNull(MasterLink.CurrentRow("KatalogIsmi"), "")) = "" Then
                e.Cancel = True
                MsgBox("Lütfen katalog ismini giriniz!")
                Exit Sub
            End If
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = FirmConn.SqlConnection
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@KatalogKod", IfNull(MasterLink.CurrentRow("KatalogKod"), "")))
            cmd.CommandText = "SELECT COUNT(*) FROM KumasKatalogu WHERE Deleted = 0 AND KumasKatalogID<>" & If0Null(MasterLink.CurrentRow("KumasKatalogID")) & " AND KatalogKod=@KatalogKod "
            If cmd.ExecuteScalar > 0 Then
                cmd.Dispose()
                e.Cancel = True
                MsgBox("Aynı koda ait başka bir kayıt daha var.")
                Exit Sub
            End If
            cmd.Dispose()
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
