Public Class frmKategoriItem
    
    Dim KategoriID As Long

    Dim UstKategoriID As Long
    Dim UstKategoriKod As String

    Public Sub FormNew(ByVal UstKategoriID_ As Long)
        Try
            UstKategoriID = UstKategoriID_
            If UstKategoriID_ > 0 Then
                Dim cmd As New SqlClient.SqlCommand
                Dim da As SqlClient.SqlDataAdapter
                Dim dt As DataTable
                cmd.Connection = AppConn.dbConn
                cmd.CommandText = "SELECT * FROM Kategoriler WHERE Deleted = 0 AND KategoriID=" & UstKategoriID_

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then

                    UstKategoriKod = IfNull(dt.Rows(0).Item("KategoriKod"), "")
                Else

                End If
                dt.Dispose()
                da.Dispose()
            End If
            txtUstKod.Text = UstKategoriKod
            txtKategoriKod.Text = UstKategoriKod & "."
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FormEdit(ByVal KategoriID_ As Long)
        Try
            KategoriID = KategoriID_
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT K.KategoriID,K.UstKategoriID,K.KategoriKod,K.KategoriIsim,K.StokKodFormat, K.IntCode, U.KategoriKod as UKategoriKod,U.KategoriIsim as UKategoriIsim  FROM Kategoriler K LEFT OUTER JOIN " & _
                " Kategoriler U ON K.UstKategoriID = U.KategoriID " & _
                " WHERE K.Deleted = 0 AND K.KategoriID=" & KategoriID
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                UstKategoriID = If0Null(dt.Rows(0).Item("UstKategoriID"))
                UstKategoriKod = IfNull(dt.Rows(0).Item("UKategoriKod"), "")
                txtKategoriKod.Text = IfNull(dt.Rows(0).Item("KategoriKod"), "")
                txtKategoriIsim.Text = IfNull(dt.Rows(0).Item("KategoriIsim"), "")
                txtStokKodFormati.Text = IfNull(dt.Rows(0).Item("StokKodFormat"), "")
                txtIntCode.Text = IfNull(dt.Rows(0).Item("IntCode"), "")
            Else

            End If
            dt.Dispose()
            da.Dispose()
            txtUstKod.Text = UstKategoriKod


            Me.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Trim(txtKategoriKod.Text) = "" Then
                MsgBox("Kategori kod boş olamaz!")
                Exit Sub
            End If
            If Trim(txtKategoriKod.Text) = Trim(UstKategoriKod) Then
                MsgBox("Üst kategori ile Kategori kodu aynı olamaz.")
                Exit Sub
            End If
            If Trim(UstKategoriKod) <> "" Then
                If Mid(txtKategoriKod.Text, 1, UstKategoriKod.Length) <> UstKategoriKod Then
                    MsgBox("Kategori kodunun üst kodu tutarsız.")
                    Exit Sub
                End If
            End If
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@KategoriKod", Trim(txtKategoriKod.Text)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@KategoriIsim", Trim(txtKategoriIsim.Text)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@UstKategoriID", UstKategoriID))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@IntCode", txtIntCode.Text))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@StokKodFormat", Trim(txtStokKodFormati.Text)))
            cmd.CommandText = "SELECT COUNT(*) FROM Kategoriler WHERE Deleted = 0 AND KategoriID <> " & KategoriID & " AND KategoriKod = @KategoriKod "
            If cmd.ExecuteScalar > 0 Then
                MsgBox("Aynı koddan başka bir kayıt daha var!")
                Exit Sub
            End If
            If KategoriID = 0 Then
                cmd.CommandText = "INSERT INTO Kategoriler (Deleted,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate, UstKategoriID, KategoriKod, KategoriIsim,StokKodFormat, IntCode) " & _
                " VALUES (0," & AppConn.ActiveUser.UserID & ",GETDATE()," & AppConn.ActiveUser.UserID & ",GETDATE(), @UstKategoriID, @KategoriKod, @KategoriIsim,@StokKodFormat, @IntCode) "
            Else
                cmd.CommandText = "UPDATE Kategoriler SET ModifiedBy =" & AppConn.ActiveUser.UserID & " ,ModifiedDate=GETDATE()  , UstKategoriID=@UstKategoriID, KategoriKod=@KategoriKod, KategoriIsim=@KategoriIsim,StokKodFormat=@StokKodFormat, IntCode=@IntCode WHERE KategoriID=" & KategoriID & "  "

            End If
            cmd.ExecuteNonQuery()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmKategoriItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                cmdCancel_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim f As New frmMikro_StokKartlari
            With f
                
                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    txtIntCode.Text = IfNull(.ReturnDataRow("sto_kod"), "")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class