Public Class frmOrguTipi
    Public Sub FormShow_Normal(Optional ByVal bDialog As Boolean = True)

        Try
            Me.FormCode = "000002"
            Me.Text = "Örgü Tipleri"
            MasterTable.SelectCommand.CommandText &= " AND bLakos=0 "
            If bDialog = True Then
                Me.ShowDialog()
            Else
                Me.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FormShow_Lakos(Optional ByVal bDialog As Boolean = True)
        Try
            Me.FormCode = "000015"
            Me.Text = "Lakos Örgü Tipleri"
            MasterTable.SelectCommand.CommandText &= " AND bLakos=1 "
            If bDialog = True Then
                Me.ShowDialog()
            Else
                Me.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmOrguTipi_ButtonNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.ButtonNewClick
        Try
            If Me.FormCode = "000015" Then
                MasterLink.CurrentRow("bLakos") = 1
            Else
                MasterLink.CurrentRow("bLakos") = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
