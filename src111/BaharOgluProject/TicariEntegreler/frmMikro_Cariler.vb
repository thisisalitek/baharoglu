Public Class frmMikro_Cariler

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Timer1.Enabled = False
            If GridView1.FocusedRowHandle < 0 Then Exit Sub

            Dim RowIndex As Integer
            RowIndex = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)

            Dim carikod As String = IfNull(MasterTable.Rows(RowIndex).Item("cari_kod"), "")
            txtBakiye.Text = Format(GetCariBakiye(AppConn.dbTicari, carikod), "#,##0.00")
            txtRiskBakiye.Text = Format(GetCariRiskBakiye(AppConn.dbTicari, carikod), "#,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_ColumnFilterChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.ColumnFilterChanged
        Timer1.Enabled = False
        Application.DoEvents()
        Timer1.Enabled = True
    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Timer1.Enabled = False
        Application.DoEvents()
        Timer1.Enabled = True
    End Sub
End Class
