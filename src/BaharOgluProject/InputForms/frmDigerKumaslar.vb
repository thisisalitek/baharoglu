Public Class frmDigerKumaslar

    Private Sub frmDigerKumaslar_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
          
            If Trim(IfNull(MasterLink.CurrentRow("KumasKod"), "")) = "" Then
                e.Cancel = True
                MsgBox("Lutfen kumas kod giriniz!")
                Exit Sub
            End If
           
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = FirmConn.SqlConnection
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@KumasKod", IfNull(MasterLink.CurrentRow("KumasKod"), "")))
            cmd.CommandText = "SELECT COUNT(*) FROM Kumaslar WHERE Deleted = 0 AND KumasID<>" & If0Null(MasterLink.CurrentRow("KumasID")) & " AND KumasKod=@KumasKod "
            If cmd.ExecuteScalar > 0 Then
                cmd.Dispose()
                e.Cancel = True
                MsgBox("Ayni koda ait baska bir kayit daha var.")
                Exit Sub
            End If
            cmd.Dispose()
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
