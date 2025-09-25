Public Class frmIlce

    Private Sub IlIDLookUpEdit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IlIDLookUpEdit.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmIl
                With f
                    
                    .FormShow()
                    OpenTable(tbIl)
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmIlce_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            OpenTable(tbIl)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
