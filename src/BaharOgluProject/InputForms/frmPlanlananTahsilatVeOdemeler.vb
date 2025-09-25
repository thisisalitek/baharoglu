Public Class frmPlanlananTahsilatVeOdemeler

    Private Sub chkGoster_Kapalilar_CheckedChanged(sender As Object, e As EventArgs) Handles chkGoster_Kapalilar.CheckedChanged, chkGoster_Iptaller.CheckedChanged
        Try
            If chkGoster_Kapalilar.Checked Then
                MasterTable.SelectCommand.Parameters("@Kapali").Value = 1
            Else
                MasterTable.SelectCommand.Parameters("@Kapali").Value = 0
            End If

            If chkGoster_Iptaller.Checked Then
                MasterTable.SelectCommand.Parameters("@Iptal").Value = 1
            Else
                MasterTable.SelectCommand.Parameters("@Iptal").Value = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            If bNoAction Then Exit Sub
            bNoAction = True
            If e.Column.ColumnName = "Kapali" Then
                If e.Row("Kapali") = 1 Then
                    e.Row("KapanmaTarihi") = Today

                End If

            End If

            If e.Column.ColumnName = "Tutar" Or e.Column.ColumnName = "DovizTipi" Or e.Column.ColumnName = "DovizKuru" Then
                Dim DovizKur As Double = 1
                If IfNull(e.Row("DovizTipi"), "") = "TL" Or IfNull(e.Row("DovizTipi"), "") = "" Then
                    e.Row("DovizKuru") = 1

                End If
                If If0Null(e.Row("DovizKuru")) > 0 Then
                    DovizKur = If0Null(e.Row("DovizKuru"))
                End If

                e.Row("TutarTL") = If0Null(e.Row("Tutar")) * If0Null(e.Row("DovizKuru"))

            End If

            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub frmPlanlananTahsilatVeOdemeler_ButtonNewClick(Sender As Object, e As EventArgs) Handles Me.ButtonNewClick
        Try
            bNoAction = True
            With MasterLink.CurrentRow
                .Item("Tarih") = AppConn.Today
                .Item("TerminTarihi") = AppConn.Today
                .Item("Turu") = 1
                .Item("DovizTipi") = "TL"
                .Item("DovizKuru") = 1
                .EndEdit()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub


    Private Sub CariKodButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CariKodButtonEdit.ButtonClick, CariUnvanButtonEdit.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            ' If CariKodButtonEdit.Properties.ReadOnly Then Exit Sub
            Dim f As New frmMikro_Cariler
            With f
                
                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    MasterLink.CurrentRow("CariKod") = IfNull(.ReturnDataRow("cari_kod"), "")
                    MasterLink.CurrentRow("CariUnvan") = IfNull(.ReturnDataRow("CariUnvan"), "")
                    MasterLink.CurrentRow.EndEdit()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CariKodButtonEdit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CariKodButtonEdit.KeyDown, CariUnvanButtonEdit.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                CariKodButtonEdit_ButtonClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub LabelControl10_Click(sender As Object, e As EventArgs) Handles LabelControl10.Click

    End Sub

    Private Sub frmPlanlananTahsilatVeOdemeler_ButtonSaveAfterClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveAfterClick
        Load_Hesaplar()

    End Sub
   
    Private Sub frmPlanlananTahsilatVeOdemeler_ButtonSaveBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If Trim(IfNull(MasterLink.CurrentRow("CariKod"), "")) = "" Then
                e.Cancel = True
                MsgBox("Lutfen cari seciniz!")
                Exit Sub
            End If


        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Load_Hesaplar()
        Try
            cboHesap.Properties.Items.Clear()
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT Hesap FROM PlanlananTahsilatVeOdemeler WITH(NOLOCK) WHERE Deleted = 0 GROUP BY Hesap"
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                cboHesap.Properties.Items.Add(IfNull(dr("Hesap"), ""))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPlanlananTahsilatVeOdemeler_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            OpenTable(tbPersonel)
            Load_Hesaplar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LookUpEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles LookUpEdit1.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmSaticilar
                With f
                    
                    .FormShow()

                End With
                OpenTable(tbPersonel)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
