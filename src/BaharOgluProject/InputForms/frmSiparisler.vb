Public Class frmSiparisler

    Dim SiparisType As Long = 0
    Dim tcmb As New TCMB_Doviz

    Public Sub FormShow_CariSiparis(Optional ByVal bDialog As Boolean = True, Optional ByVal bControlMasterConn As Boolean = False, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal Owner As Form = Nothing)
        Try
            Me.FormCode = "000008"
            Me.Text = "Müşteri Sipariş"
            SiparisType = 0
            MasterTable.SelectCommand.CommandText &= " AND SiparisType=0 "
            Me.FormShow(bDialog, bControlMasterConn, bControlFirmConn, Owner)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FormShow_DepoSiparis(Optional ByVal bDialog As Boolean = True, Optional ByVal bControlMasterConn As Boolean = False, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal Owner As Form = Nothing)
        Try
            Me.FormCode = "000018"
            Me.Text = "Depo Sipariş"
            SiparisType = 1
            MasterTable.SelectCommand.CommandText &= " AND SiparisType=1 "
            Me.FormShow(bDialog, bControlMasterConn, bControlFirmConn, Owner)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisler_ButtonDeleteBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteBeforeClick
        'e.Cancel = True
        'Exit Sub
        Try
            If UCaseEng(AppConn.ActiveUser.UserName) <> "ADMIN" Then
                MsgBox("Siparisi ADMIN den baskasi silemez!")
                e.Cancel = True
                Exit Sub
            End If
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT COUNT(*) FROM SipDetay INNER JOIN  " &
                " SevkDetay On SevkDetay.SipDetayID = SipDetay. SipDetayID INNER JOIN  " &
                " Sevk ON Sevk.SevkID = SevkDetay.SevkID   " &
                " WHERE SipDetay.Deleted = 0 And Sevk.Deleted = 0 And SevkDetay.Deleted = 0 And SipDetay.SiparisID = " & MasterLink.CurrentRow("SiparisID")
            If If0Null(cmd.ExecuteScalar()) > 0 Then
                e.Cancel = True
                MsgBox("Bu siparis sevk hareketlerine baglidir. Silemezsiniz. Once sevk hareketini siliniz.")
                Exit Sub
            End If

            e.Cancel = False

        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisler_ButtonNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.ButtonNewClick
        Try
            With MasterLink.CurrentRow
                .Item("Tarih") = AppConn.Today
                .Item("SiparisType") = SiparisType

            End With
            YeniSipNo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub YeniSipNo()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim dt As DataTable
            Dim da As SqlClient.SqlDataAdapter
            Dim Seri As String = ""
            Dim Sira As Long = 0
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "Select TOP 1 S.SipEvrakSeri,L.Sira  FROM Siparis S INNER JOIN  " &
                "(Select SipEvrakSeri,MAX(SipEvrakSira) As Sira FROM Siparis WHERE Deleted = 0 " &
                "GROUP BY SipEvrakSeri) L On S.SipEvrakSeri = L.SipEvrakSeri " &
                "WHERE S.Deleted = 0  " &
                "ORDER BY S.SiparisID DESC " &
                ""
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Seri = IfNull(dt.Rows(0).Item("SipEvrakSeri"), "")
                Sira = If0Null(dt.Rows(0).Item("Sira"))
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()

            With MasterLink.CurrentRow

                .Item("SipEvrakSeri") = Seri
                .Item("SipEvrakSira") = Sira + 1
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisler_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If If0Null(MasterLink.CurrentRow("SaticiID")) = 0 Then
                e.Cancel = True
                MsgBox("Lutfen satici seciniz!")

                Exit Sub
            End If
            If IfNull(MasterLink.CurrentRow("DovizTipi"), "") <> "TL" And If0Null(MasterLink.CurrentRow("DovizKuru")) = 0 Then
                e.Cancel = True
                MsgBox("Lutfen doviz kuru giriniz!")

                Exit Sub
            End If
            UpdateToplamlar()
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "Select COUNT(*) FROM Siparis WHERE Deleted = 0 And SipEvrakSeri = '" & Replace(IfNull(MasterLink.CurrentRow("SipEvrakSeri"), ""), "'", "") & "' AND SipEvrakSira=" & If0Null(MasterLink.CurrentRow("SipEvrakSira")) & " AND SiparisID<>" & If0Null(MasterLink.CurrentRow("SiparisID")) & " "

            If cmd.ExecuteScalar > 0 Then
                MsgBox("Aynı sipariş numarasından başka bir kayıt var. Sıradaki numara verilecektir.")
                YeniSipNo()
            End If
            If If0Null(MasterLink.CurrentRow("SiparisType")) = 1 Then
                If Trim(IfNull(MasterLink.CurrentRow("Depo"), "")) = "" Then
                    e.Cancel = True
                    MsgBox("Kaynak depo seçiniz!")
                    Exit Sub
                End If
                If Trim(IfNull(MasterLink.CurrentRow("Depo2"), "")) = "" Then
                    e.Cancel = True
                    MsgBox("Hedef depo seçiniz!")
                    Exit Sub
                End If
                If IfNull(MasterLink.CurrentRow("Depo"), "") = IfNull(MasterLink.CurrentRow("Depo2"), "") Then
                    e.Cancel = True
                    MsgBox("Depolar farklı olmak zorunda")
                    Exit Sub
                End If
                MasterLink.CurrentRow("CariKod") = ""
                MasterLink.CurrentRow("CariUnvan") = ""
                MasterLink.EndEdit()
            ElseIf If0Null(MasterLink.CurrentRow("SiparisType")) = 0 Then
                If Trim(IfNull(MasterLink.CurrentRow("CariKod"), "")) = "" Then
                    e.Cancel = True
                    MsgBox("Lütfen cari kart seçiniz!")
                    Exit Sub
                End If

                MasterLink.CurrentRow("Depo") = ""
                MasterLink.CurrentRow("Depo2") = ""
                MasterLink.EndEdit()
            End If

            For Each dr As DataRow In DetailTable.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("Bagli")) = 1 Then
                        If BagliSatirBedenAdetControl(If0Null(dr("SipDetayID")), If0Null(dr("BagliSipDetayID"))) = False Then
                            e.Cancel = True
                            Exit Sub
                        End If

                    End If
                End If
            Next
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            OpenTable(tbOkul)
            OpenTable(tbKategori)
            OpenTable(tbUsers)
            OpenTable(tbSaticilar)
            OpenTable(NeoTable1)
            OpenTable(tbBoyahaneler)
            LoadSiparisType()
            If AppConn.ActiveUser.bAdmin Then
                panelAdmin.Visible = True
            Else
                panelAdmin.Visible = False
            End If
            cboSiparisType.EditValue = SiparisType
            cboSiparisType_EditValueChanged(Nothing, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGridSipDetayRemove_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnGridSipDetayRemove.ButtonClick
        Try
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            If MsgBox("Satır silmek istediğinizden emin misiniz?") <> MsgBoxResult.Yes Then Exit Sub
            DetailLink.CurrentRow.Delete()
            UpdateToplamlar()
            MasterTable.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGridSipDetayRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGridSipDetayRemove.Click
        Try
            If EditMode = False Then
                MsgBox("Değiştirme modu pasif!")
                Exit Sub
            End If
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            If MsgBox("Satır silmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Satır Sil?") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
            DetailLink.CurrentRow.Delete()
            UpdateToplamlar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAddSipDetay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSipDetay.Click
        Try
            If EditMode = False Then
                MsgBox("Değiştirme modu pasif!")
                Exit Sub
            End If

            Dim newdr As DataRow = DetailTable.NewRow
            newdr("Deleted") = 0

            newdr("Tarih") = AppConn.Today
            newdr("TerminTarihi") = AppConn.Today
            newdr("SiparisiAlan") = AppConn.ActiveUser.FullName
            DetailTable.Rows.Add(newdr)
            DetailLink.MoveLast()
            MasterTable.Save()
            Dim SipDetayID As Long
            SipDetayID = If0Null(DetailTable.Rows(DetailTable.Rows.Count - 1).Item("SipDetayID"))
            If SipDetayID <= 0 Then
                MsgBox("Yeni sipariş açılamadı. Tekrar deneyin.")
                Exit Sub
            End If
            Dim f As New frmKategoriler


            f.txtMusteri.Text = IfNull(MasterLink.CurrentRow("CariKod"), "") & " - " & IfNull(MasterLink.CurrentRow("CariUnvan"), "")
            f.DovizTipi = IfNull(MasterLink.CurrentRow("DovizTipi"), "")
            f.OkulFarki = If0Null(MasterLink.CurrentRow("OkulFarki"))
            f.FormShow_NewSiparis(SipDetayID)
            If f.DialogResult <> Windows.Forms.DialogResult.OK Then

                DetailLink.CurrentRow.Delete()
                f.Dispose()
                MasterTable.Save()
                If DetailTable.Rows.Count > 0 Then
                    If DetailTable.Rows(DetailTable.Rows.Count - 1).RowState = DataRowState.Deleted Then
                        DetailTable.Rows.RemoveAt(DetailTable.Rows.Count - 1)
                    End If

                End If
                Exit Sub
            End If
            If f.tbSipDetay.Rows.Count > 0 Then
                For Each dc As DataColumn In f.tbSipDetay.Columns
                    If DetailTable.Columns.Contains(dc.ColumnName) Then
                        DetailLink.CurrentRow(dc.ColumnName) = f.tbSipDetay.Rows(0).Item(dc.ColumnName)
                    End If
                Next
                UpdateAnaRenk(DetailLink.CurrentRow("SipDetayID"))
            End If
            UpdateToplamlar()
            MasterTable.Save()
            ShowCurrentRow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGridSipDetay_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnGridSipDetay.ButtonClick
        Try
            If EditMode = False Then
                MsgBox("Değiştirme modu pasif!")
                Exit Sub
            End If
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            Dim SipDetayID As Long = 0
            SipDetayID = If0Null(DetailLink.CurrentRow("SipDetayID"))

            Dim f As New frmKategoriler

            f.txtMusteri.Text = IfNull(MasterLink.CurrentRow("CariKod"), "") & " - " & IfNull(MasterLink.CurrentRow("CariUnvan"), "")
            f.MikroStokKod = DetailLink.CurrentRow("StokKod")
            f.MikroStokIsmi = DetailLink.CurrentRow("StokIsmi")
            f.DovizTipi = IfNull(MasterLink.CurrentRow("DovizTipi"), "")
            f.OkulFarki = If0Null(MasterLink.CurrentRow("OkulFarki"))
            If AppConn.ActiveUser.bAdmin = False And IfNull(DetailLink.CurrentRow("Durumu"), "") <> "" Then
                MsgBox("Bu sipariste degisiklik yapamazsiniz. Siparis durumu:" + IfNull(DetailLink.CurrentRow("Durumu"), "") + vbNewLine + "Degisikligi sadece supervizor yetkisi olan kisiler yapabilir!")

                f.cmdSaveOzellik.Enabled = False
            End If
            f.FormShow_Edit(SipDetayID)

            If f.tbSipDetay.Rows.Count > 0 Then
                For Each dc As DataColumn In f.tbSipDetay.Columns
                    If DetailTable.Columns.Contains(dc.ColumnName) Then
                        DetailLink.CurrentRow(dc.ColumnName) = f.tbSipDetay.Rows(0).Item(dc.ColumnName)
                    End If
                Next
                UpdateAnaRenk(DetailLink.CurrentRow("SipDetayID"))
            End If

            UpdateToplamlar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateAnaRenk(ByVal SipDetayID As Long)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim dt As DataTable
            Dim da As SqlClient.SqlDataAdapter
            cmd.Connection = MasterTable.Connection.SqlConnection
            cmd.Transaction = MasterTable.Transaction
            cmd.CommandTimeout = 60 * 20
            cmd.CommandText = "UPDATE SipDetay SET AnaRenk=SUBSTRING(dbo.fnSipDetay_AnaRenk(" & SipDetayID & "),1,200),Bedenler=SUBSTRING(REPLACE(dbo.fnListe_SipDetayBedenler(" & SipDetayID & "), CHAR(13) + CHAR(10), ' | '),1,300) WHERE SipDetayID = " & SipDetayID
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CariKodButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCariKodu.ButtonClick, txtCariUnvan.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If txtCariKodu.Properties.ReadOnly Then Exit Sub
            Dim f As New frmMikro_Cariler
            With f

                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    MasterLink.CurrentRow("CariKod") = IfNull(.ReturnDataRow("cari_kod"), "")
                    MasterLink.CurrentRow("CariUnvan") = IfNull(.ReturnDataRow("CariUnvan"), "")
                    MasterLink.CurrentRow.EndEdit()
                    txtBakiye.Text = Format(GetCariBakiye(AppConn.dbTicari, IfNull(MasterLink.CurrentRow("CariKod"), "")), "#,##0.00")
                    txtRiskBakiye.Text = Format(GetCariRiskBakiye(AppConn.dbTicari, IfNull(MasterLink.CurrentRow("CariKod"), "")), "#,##0.00")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CariKodButtonEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariKodu.KeyDown, txtCariUnvan.KeyDown
        If e.KeyCode = Keys.F10 Then
            CariKodButtonEdit_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmdOnayla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOnayla.Click
        Try
            If EditMode = False Then
                Beep()
                Beep()

                Exit Sub
            End If
            If If0Null(MasterLink.CurrentRow("Onayli")) <> 1 Then
                If BedenKontrol() = False Then
                    Exit Sub
                End If
                For Each dr As DataRow In DetailTable.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If If0Null(dr("Bagli")) = 1 Then
                            If BagliSatirBedenAdetControl(If0Null(dr("SipDetayID")), If0Null(dr("BagliSipDetayID"))) = False Then

                                Exit Sub
                            End If

                        End If
                    End If
                Next

                If MsgBox("Onaylamak istiyor musunuz?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Onayla?") <> MsgBoxResult.Yes Then Exit Sub
                MasterTable.Save()
                Dim cmd As New SqlClient.SqlCommand
                Try
                    cmd.Connection = AppConn.dbConn
                    cmd.CommandTimeout = 600 * 3
                    If If0Null(MasterLink.CurrentRow("SiparisType")) = 0 Then
                        cmd.CommandText = "exec spENT_Siparis " & If0Null(MasterLink.CurrentRow("SiparisID"))
                    Else
                        cmd.CommandText = "exec spENT_DepoSiparis " & If0Null(MasterLink.CurrentRow("SiparisID"))
                    End If

                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Mikro Entegrasyon hatası:" & ex.Message)
                    Exit Sub
                End Try
                EditMode = True
                MasterLink.CurrentRow("Onayli") = 1
                MasterLink.CurrentRow("Onaylayan") = AppConn.ActiveUser.UserID
                MasterLink.CurrentRow("OnayTarihi") = Now
            Else
                If MsgBox("Onayı kaldırmak istiyor musunuz?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Critical, "Onayla?") <> MsgBoxResult.Yes Then Exit Sub
                MasterLink.CurrentRow("Onayli") = 0
                MasterLink.CurrentRow("Onaylayan") = 0
                MasterLink.CurrentRow("OnayTarihi") = DateSerial(1900, 1, 1)
            End If
            MasterLink.CurrentRow.EndEdit()
            MasterTable.Save()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cmdIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIptal.Click
        Try
            If EditMode = False Then
                Beep()
                Beep()

                Exit Sub
            End If
            If If0Null(MasterLink.CurrentRow("Iptal")) <> 1 Then
                If MsgBox("Iptal etmek istiyor musunuz?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Critical, "Onayla?") <> MsgBoxResult.Yes Then Exit Sub
                Dim sbuf As String = InputBox("Iptal nedeni nedir?", "Iptal Nedeni?", "")
                If Trim(sbuf) = "" Then
                    MsgBox("Iptal nedeni girmelisiniz!")
                    Exit Sub
                End If
                MasterLink.CurrentRow("Iptal") = 1
                MasterLink.CurrentRow("IptalNedeni") = Mid(Replace(sbuf, "'", " "), 1, 50)

            Else
                If MsgBox("İptali kaldırmak istiyor musunuz?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Critical, "Onayla?") <> MsgBoxResult.Yes Then Exit Sub
                MasterLink.CurrentRow("Iptal") = 0
            End If
            MasterLink.CurrentRow.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkOnayli_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOnayli.CheckedChanged
        Try
            If chkOnayli.Checked Then
                cmdOnayla.Text = "Onayı kaldır"
            Else
                cmdOnayla.Text = "Onayla"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkIptal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIptal.CheckedChanged
        Try
            If chkIptal.Checked Then
                cmdIptal.Text = "İptali kaldır"
            Else
                cmdIptal.Text = "(X) İptal"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateToplamlar()
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            Dim TTutar As Double = 0
            For Each dr As DataRow In DetailTable.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    TTutar += If0Null(dr("Tutar"))
                End If
            Next
            MasterLink.CurrentRow("AraToplam") = TTutar

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MasterTable_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            If bNoAction Then Exit Sub
            bNoAction = True
            If e.Column.ColumnName = "KdvOran" Or e.Column.ColumnName = "VadeFarkiOran" Or e.Column.ColumnName = "AraToplam" Or e.Column.ColumnName = "OkulFarki" Then
                e.Row("VadeFarkiTutar") = Math.Round(If0Null(e.Row("VadeFarkiOran")) * If0Null(e.Row("AraToplam")) / 100, 2)

                e.Row("KdvTutar") = Math.Round(If0Null(e.Row("KdvOran")) * (If0Null(e.Row("AraToplam")) + If0Null(e.Row("VadeFarkiTutar"))) / 100, 2)
                e.Row("GenelToplam") = Math.Round(If0Null(e.Row("KdvTutar")) + If0Null(e.Row("AraToplam")) + If0Null(e.Row("VadeFarkiTutar")), 2)
                If Trim(IfNull(e.Row("DovizTipi"), "")) = "" Or IfNull(e.Row("DovizTipi"), "") = "TL" Then
                    e.Row("DovizKuru") = 1
                End If
                'If If0Null(e.Row("DovizKuru")) <> 0 Then
                e.Row("DovizliTutar") = Math.Round(If0Null(e.Row("GenelToplam")) * If0Null(e.Row("DovizKuru")), 2)
                'Else
                '    e.Row("DovizliTutar") = 0
                'End If
                e.Row("NAraToplam") = Math.Round(If0Null(e.Row("AraToplam")) * (1 + (If0Null(e.Row("OkulFarki")) / 100)), 2)
                e.Row("NKdvTutar") = Math.Round(If0Null(e.Row("KdvTutar")) * (1 + (If0Null(e.Row("OkulFarki")) / 100)), 2)
                e.Row("NGenelToplam") = Math.Round(If0Null(e.Row("NAraToplam")) + If0Null(e.Row("NKdvTutar")), 2)
            End If

            If e.Column.ColumnName = "DovizTipi" Then

                e.Row("DovizKuru") = tcmb.getDovizKur(IfNull(e.Row("DovizTipi"), ""), Today)
                e.Row("DovizliTutar") = Math.Round(If0Null(e.Row("GenelToplam")) * If0Null(e.Row("DovizKuru")), 2)
            End If

            If e.Column.ColumnName = "DovizKuru" Then

                'If If0Null(e.Row("DovizKuru")) <> 0 Then
                e.Row("DovizliTutar") = Math.Round(If0Null(e.Row("GenelToplam")) * If0Null(e.Row("DovizKuru")), 2)
                'Else
                '    e.Row("DovizliTutar") = 0
                'End If
            End If

            e.Row.EndEdit()

            bNoAction = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub frmSiparisler_ShowRecord(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.ShowRecord
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            txtBakiye.Text = Format(GetCariBakiye(AppConn.dbTicari, IfNull(MasterLink.CurrentRow("CariKod"), "")), "#,##0.00")
            txtRiskBakiye.Text = Format(GetCariRiskBakiye(AppConn.dbTicari, IfNull(MasterLink.CurrentRow("CariKod"), "")), "#,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkShowIptal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowIptal.CheckedChanged
        Try
            If chkShowIptal.Checked Then
                MasterTable.SelectCommand.Parameters("@Iptal").Value = 1
            Else
                MasterTable.SelectCommand.Parameters("@Iptal").Value = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtStokKod_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtStokKod.ButtonClick, txtStokIsmi.ButtonClick
        Try
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            Dim f As New frmMikro_StokKartlari
            With f

                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    DetailLink.CurrentRow("StokKod") = IfNull(.ReturnDataRow("sto_kod"), "")
                    DetailLink.CurrentRow("StokIsmi") = IfNull(.ReturnDataRow("sto_isim"), "")
                    DetailLink.CurrentRow.EndEdit()
                    Aciklama1TextEdit.Focus()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtStokKod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStokKod.KeyDown, txtStokIsmi.KeyDown
        If e.KeyCode = Keys.F10 Then
            txtStokKod_ButtonClick(sender, Nothing)
        End If
    End Sub

    Private Sub KopyalaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopyalaToolStripMenuItem.Click
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            Dim NewSiparisID As Long = 0
            If MsgBox("Siparişi kopyalamak istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kopyala?") <> MsgBoxResult.Yes Then Exit Sub

            NewSiparisID = CopySiparis(If0Null(MasterLink.CurrentRow("SiparisID")), AppConn.ActiveUser.UserID)
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim siparisno As String = ""
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT * FROM Siparis WHERE SiparisID = " & NewSiparisID
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                siparisno = "ID:" & NewSiparisID & "   Siparis Seri/Sira: " & IfNull(dt.Rows(0).Item("SipEvrakSeri"), "") & "-" & If0Null(dt.Rows(0).Item("SipEvrakSira"))

            End If
            dt.Dispose()
            da.Dispose()


            MsgBox("Yeni sipariş " & siparisno)
            btnRefresh_ItemClick(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDepo.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If txtDepo.Properties.ReadOnly Then Exit Sub

            Dim f As New frmMikro_Depolar
            With f

                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    MasterLink.CurrentRow("Depo") = IfNull(.ReturnDataRow("dep_no"), "")
                    MasterLink.CurrentRow.EndEdit()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepo.KeyDown
        If e.KeyCode = Keys.F10 Then
            txtDepo_ButtonClick(Nothing, Nothing)
        End If
    End Sub


    Private Sub txtDepo2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDepo2.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If txtDepo2.Properties.ReadOnly Then Exit Sub

            Dim f As New frmMikro_Depolar
            With f

                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    MasterLink.CurrentRow("Depo2") = IfNull(.ReturnDataRow("dep_no"), "")
                    MasterLink.CurrentRow.EndEdit()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepo2.KeyDown
        If e.KeyCode = Keys.F10 Then
            txtDepo2_ButtonClick(Nothing, Nothing)
        End If
    End Sub


    Private Sub LoadSiparisType()
        Try
            Dim dc1 As New DataColumn("DisplayMember", GetType(String))
            Dim dc2 As New DataColumn("ValueMember", GetType(Long))
            Dim dt As New DataTable
            dt.Columns.Add(dc1)
            dt.Columns.Add(dc2)

            Dim newdr As DataRow
            newdr = dt.NewRow
            newdr("DisplayMember") = "Müşteri Sipariş"
            newdr("ValueMember") = 0
            dt.Rows.Add(newdr)

            newdr = dt.NewRow
            newdr("DisplayMember") = "Depo Sipariş"
            newdr("ValueMember") = 1
            dt.Rows.Add(newdr)

            cboGridSiparisType.DataSource = dt
            cboSiparisType.Properties.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboSiparisType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSiparisType.EditValueChanged
        Try
            If cboSiparisType.EditValue Is Nothing Then Exit Sub
            Select Case If0Null(cboSiparisType.EditValue)
                Case 0
                    txtDepo.Properties.ReadOnly = True
                    txtDepo2.Properties.ReadOnly = True
                    txtCariKodu.Properties.ReadOnly = False
                    txtCariUnvan.Properties.ReadOnly = False
                Case 1
                    txtDepo.Properties.ReadOnly = False
                    txtDepo2.Properties.ReadOnly = False
                    txtCariKodu.Properties.ReadOnly = True
                    txtCariUnvan.Properties.ReadOnly = True
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisler_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.T And e.Control And e.Alt Then
                If MsgBox("Renk beden kontrolü yapılacak! onaylıyor musunuz?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Onay?") <> MsgBoxResult.Yes Then Exit Sub
                If BedenKontrol() = True Then
                    MsgBox("başarılı")
                Else
                    MsgBox("başarısız :-(")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function BedenKontrol() As Boolean
        Try
            For Each drSipDetay As DataRow In DetailTable.Rows
                If drSipDetay.RowState <> DataRowState.Deleted And drSipDetay.RowState <> DataRowState.Detached Then
                    Dim cmdMikro As New SqlClient.SqlCommand
                    Dim cmd As New SqlClient.SqlCommand
                    Dim da As SqlClient.SqlDataAdapter

                    Dim dtSipDetayFiyatlar As DataTable

                    cmd.Connection = AppConn.dbConn
                    cmdMikro.Connection = AppConn.dbTicari
                    cmdMikro.Parameters.Clear()


                    cmd.CommandText = "SELECT * FROM SipDetayFiyatlar WHERE Deleted = 0 AND Miktar>0 AND SipDetayID=" & If0Null(drSipDetay("SipDetayID"))
                    da = New SqlClient.SqlDataAdapter(cmd)
                    dtSipDetayFiyatlar = New DataTable
                    da.Fill(dtSipDetayFiyatlar)
                    For Each dr As DataRow In dtSipDetayFiyatlar.Rows
                        Dim BedenNo As Integer = 1
                        Dim RenkNo As Integer = 1
                        Dim BdnHarNo As Integer = 0

                        BedenNo = GetBedenKirilim("", IfNull(dr("BedenKod"), ""))

                        RenkNo = GetRenkKirilim("", IfNull(dr("RenkKod"), ""))


                        BdnHarNo = (RenkNo - 1) * 40 + BedenNo
                        cmd.CommandText = "UPDATE SipDetayFiyatlar SET BdnHarNo=" & BdnHarNo & " WHERE SipDetayFiyatAdetID = " & If0Null(dr("SipDetayFiyatAdetID"))
                        cmd.ExecuteNonQuery()
                    Next

                    da.Dispose()




                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Function GetRenkKirilim(ByVal RenkKod As String, ByVal Renk As String) As Integer
        Try
            If Trim(Renk) = "" Then Return 0

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim RenkKirilim As Integer = 0
            cmd.Connection = AppConn.dbTicari
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@rnk_kodu", RenkKod))
            cmd.CommandText = "SELECT * FROM STOK_RENK_TANIMLARI WHERE 1=1 "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 1 To 60
                    If IfNull(dt.Rows(0).Item("rnk_kirilim_" & i), "") = Renk Then
                        RenkKirilim = i
                        Exit For
                    End If
                Next
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return RenkKirilim
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Private Function GetBedenKirilim(ByVal BedenKod As String, ByVal Beden As String) As Integer
        Try
            If Trim(Beden) = "" Then Return 0

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim BedenKirilim As Integer = 0
            cmd.Connection = AppConn.dbTicari
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@bdn_kodu", BedenKod))
            cmd.CommandText = "SELECT * FROM STOK_BEDEN_TANIMLARI WHERE 1=1 "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 1 To 40
                    If IfNull(dt.Rows(0).Item("bdn_kirilim_" & i), "") = Beden Then
                        BedenKirilim = i
                        Exit For
                    End If
                Next
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()

            Return BedenKirilim
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Private Sub mnuSipDetayBagla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSipDetayBagla.Click
        Try
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If DetailLink.CurrentRow("Bagli") <> 0 Then
                MsgBox("Zaten bağlı.")
                Exit Sub
            End If
            If DetailLink.Position <= 0 Then
                MsgBox("Zaten en üst satırı seçtiniz!")
                Exit Sub
            End If

            Dim ConnID As Long = 0
            DetailLink.MovePrevious()
            ConnID = If0Null(DetailLink.CurrentRow("SipDetayID"))
            DetailLink.MoveNext()
            If BagliSatirBedenAdetControl(If0Null(DetailLink.CurrentRow("SipDetayID")), ConnID) = False Then
                Exit Sub
            End If


            If MsgBox("Satırı bir üst satıra bağlayacaksınız. Onaylıyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Bağla?") <> MsgBoxResult.Yes Then Exit Sub
            DetailLink.CurrentRow("BagliSipDetayID") = ConnID
            DetailLink.CurrentRow("Bagli") = 1
            DetailLink.CurrentRow.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSipDetayBaglantiIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSipDetayBaglantiIptal.Click
        Try
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If MsgBox("Bağlantıyı iptal etmek istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Bağlantı İptal?") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
            DetailLink.CurrentRow("Bagli") = 0
            DetailLink.CurrentRow("BagliSipDetayID") = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function BagliSatirBedenAdetControl(ByVal SipDetayID As Long, ByVal SipDetayID2 As Long) As Boolean
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim dt2 As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT * FROM SipDetayFiyatlar WHERE Deleted = 0 AND SipDetayID=" & SipDetayID & "  AND Miktar>0  ORDER BY BedenKod "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            cmd.CommandText = "SELECT * FROM SipDetayFiyatlar WHERE Deleted = 0 AND SipDetayID=" & SipDetayID2 & "  AND Miktar>0  ORDER BY BedenKod "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt2 = New DataTable
            da.Fill(dt2)

            If dt.Rows.Count <> dt2.Rows.Count Then
                MsgBox("Bağlanan satırların beden kodları tutarsız. Kontrol ediniz!")
            End If
            For i = 0 To dt.Rows.Count - 1
                If IfNull(dt.Rows(i).Item("BedenKod"), "") <> IfNull(dt2.Rows(i).Item("BedenKod"), "") Then
                    MsgBox("Bağlanan satırların beden kodları tutarsız. Kontrol ediniz! Bdn:" & IfNull(dt.Rows(i).Item("BedenKod"), "") & " ≠ " & IfNull(dt2.Rows(i).Item("BedenKod"), ""))
                    Return False
                End If
                If If0Null(dt.Rows(i).Item("Miktar")) <> If0Null(dt2.Rows(i).Item("Miktar")) Then
                    MsgBox("Bağlanan satırların miktarları tutarsız. Kontrol ediniz! Bdn:" & IfNull(dt.Rows(i).Item("BedenKod"), "") & "   Miktar:" & If0Null(dt.Rows(i).Item("Miktar")) & " ≠ " & If0Null(dt2.Rows(i).Item("Miktar")))
                    Return False
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub GridControl1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub frmSiparisler_ButtonSaveAfterClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveAfterClick
        Try
            For Each dr As DataRow In DetailTable.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    UpdateAnaRenk(If0Null(dr("SipDetayID")))

                End If
            Next
        Catch ex As Exception
            e.Cancel = True
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
                OpenTable(tbSaticilar)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SatirSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatirSilToolStripMenuItem.Click
        Try
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If (MsgBox("Satiri silmek istediginizden emin misiniz?", MsgBoxStyle.YesNo, "Satir sil?") <> MsgBoxResult.Yes) Then Exit Sub
            DetailLink.CurrentRow.Delete()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LookUpEdit2_KeyDown(sender As Object, e As KeyEventArgs) Handles LookUpEdit2.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmSipAlanlar
                With f

                    .FormShow()
                End With
                OpenTable(NeoTable1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
