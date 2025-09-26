Public Class frmAlimIrsaliyeleri

    Private Sub cmdAddNewIrsaliye_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddNewIrsaliye.Click
        Try
            Dim f As New frmIrsaliye_Giris
            With f
                
                .FormNew(0)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    RefreshForm(sender)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuYeniIrsaliye_Click(sender As System.Object, e As System.EventArgs) Handles mnuYeniIrsaliye.Click
        cmdAddNewIrsaliye_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuIrsaliyeDuzelt_Click(sender As System.Object, e As System.EventArgs) Handles mnuIrsaliyeDuzelt.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            If RowIndex < 0 Then Exit Sub
            Dim dr As DataRow = MasterTable.Rows(RowIndex)
            Dim f As New frmIrsaliye_Giris
            With f
                
                .KumasGirisID = If0Null(dr("KumasGirisID"))
                .FormEdit()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    RefreshForm(sender)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Try
            mnuIrsaliyeDuzelt_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuIrsaliyeSil_Click(sender As Object, e As System.EventArgs) Handles mnuIrsaliyeSil.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            If RowIndex < 0 Then Exit Sub
            Dim dr As DataRow = MasterTable.Rows(RowIndex)
            If MsgBox("Irsaliyeyi silmek istediginizden emin misiniz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Irsaliye Sil?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE KumasGiris SET Deleted = KumasGirisID WHERE KumasGirisID=" & If0Null(dr("KumasGirisID")) & " " & vbNewLine
            cmd.CommandText &= "UPDATE KumasGirisDetay SET Deleted = KumasGirisDetayID  WHERE KumasGirisID=" & If0Null(dr("KumasGirisID")) & " " & vbNewLine
            cmd.ExecuteNonQuery()
            RefreshForm(sender)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAlimIrsaliyeleri_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            cboGridIrsaliyeType.DataSource = GetIrsaliyeTypes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuYeniDevirFisi_Click(sender As System.Object, e As System.EventArgs) Handles mnuYeniDevirFisi.Click
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
    Private Sub cmdYeniDevirIrsaliyesi_Click(sender As System.Object, e As System.EventArgs) Handles cmdYeniDevirIrsaliyesi.Click
        Try
            Dim f As New frmIrsaliye_Giris
            With f
                
                .FormNew(1)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    RefreshForm(sender)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdYeniUretimIade_Click(sender As System.Object, e As System.EventArgs) Handles cmdYeniUretimIade.Click
        Try
            Dim f As New frmIrsaliye_Giris
            With f
                
                .FormNew(2)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    RefreshForm(sender)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuMikroyaGonder_Click(sender As System.Object, e As System.EventArgs) Handles mnuMikroyaGonder.Click
        Try
            If GridView1.SelectedRowsCount <= 0 Then Exit Sub
            Dim ar As New ArrayList
            For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                Dim dr As DataRow
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows()(i))
                If RowIndex >= 0 Then
                    dr = MasterTable.Rows(RowIndex)
                    ar.Add(If0Null(dr("KumasGirisID")))
                End If
            Next

            For i As Integer = 0 To ar.Count - 1
                Try
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = AppConn.dbConn
                    cmd.CommandText = "exec spENT_KumasGiris " & ar(i)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    If MsgBox("Hata:" & ex.Message & vbNewLine & "Diger aktarimlara devam etmek istiyor musunuz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Hata?") <> MsgBoxResult.Yes Then
                        Exit For
                    End If
                End Try
            Next
            RefreshForm(sender)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
