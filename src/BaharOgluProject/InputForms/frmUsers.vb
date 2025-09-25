Public Class frmUsers

    Private Sub frmUsers_Before_FormShow(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.Before_FormShow
        Try
            If AppConn.ActiveUser.bAdmin = False Then
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmUsers_ButtonDeleteBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteBeforeClick
        Try
            If UCaseEng(Trim(IfNull(MasterLink.CurrentRow("UserName"), ""))) = "ADMIN" Then
                e.Cancel = True
                MsgBox("Bu kullanıcıyı silemezsiniz!")
                Exit Sub
            End If
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmUsers_ButtonNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.ButtonNewClick

    End Sub

    Private Sub frmUsers_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If Trim(IfNull(MasterLink.CurrentRow("UserName"), "")) = "" Then
                e.Cancel = True
                MsgBox("Lütfen bir kullanıcı adı giriniz!")
                Exit Sub
            End If
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
