Public Class frmOkullar

    Private Sub frmOkullar_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If If0Null(MasterLink.CurrentRow("IlceID")) = 0 Then
                e.Cancel = True
                MsgBox("Lütfen il/ilçe seçiniz!")
                Exit Sub
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmOkullar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            OpenTable(tbIl)
            OpenTable(tbIlce)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GridLookUpEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridLookUpEdit1.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmIlce
                With f
                    
                    .FormShow()
                End With
                OpenTable(tbIlce)
                OpenTable(tbIl)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterTable_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            If e.Column.ColumnName = "IlceID" Then
                Dim dr As DataRow = tbIlce.Rows.Find(If0Null(e.Row("IlceID")))
                If Not dr Is Nothing Then
                    e.Row("IlID") = dr("IlID")
                End If

            End If
            e.Row.EndEdit()
           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
