Public Class frmIrsaliye_Giris 
    Public FormCode As String = "000004"
    
    Dim bFormNew As Boolean = False
    Public KumasGirisID As Long = 0
    Dim IrsaliyeType As Long = 0
    Dim Hammadde_SabitDepo As Boolean = False
    Dim bNoAction As Boolean = False
    Dim bGridNoFocus As Boolean = False

    Public Sub FormNew(IrsaliyeType_ As Long)
        IrsaliyeType = IrsaliyeType_
       
        bFormNew = True
        Me.ShowDialog()
    End Sub

    Public Sub FormEdit()
        bFormNew = False
        Me.ShowDialog()
    End Sub

    Private Sub CariKodButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCariKodu.ButtonClick, txtCariUnvan.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            
            If txtCariKodu.Properties.ReadOnly Then Exit Sub
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


    Private Sub CariKodButtonEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariKodu.KeyDown, txtCariUnvan.KeyDown
        If e.KeyCode = Keys.F10 Then
            CariKodButtonEdit_ButtonClick(Nothing, Nothing)
        End If
    End Sub


    Private Sub InitializeConnection()
        Try
            FirmConn.ConnectionString = AppConn.dbConnStr
            FirmConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmIrsaliye_Giris_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try

            Dim sbuf As String = ""
            Dim DepoNo As String = ""
            sbuf = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_SabitDepo", "False")
            If UCase(sbuf) = "TRUE" Then
                Hammadde_SabitDepo = True
                DepoNo = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_DepoNo", "")
                txtDepo.Properties.ReadOnly = True
            Else
                Hammadde_SabitDepo = False
            End If
            
            InitializeConnection()

            cboIrsaliyeType.Properties.DataSource = GetIrsaliyeTypes()

            If bFormNew Then
                OpenTable(DetailTable)
                OpenTable(MasterTable)

                Dim dr As DataRow
                dr = MasterTable.NewRow
                dr("Deleted") = 0
                dr("IrsaliyeType") = IrsaliyeType
                dr("IrsTarih") = AppConn.Today
                dr("IrsEvrakSeri") = ""
                Select Case IrsaliyeType
                    Case 0
                        dr("IrsEvrakSeri") = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType0", "HA")
                    Case 1
                        dr("IrsEvrakSeri") = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType1", "HD")
                    Case 2
                        dr("IrsEvrakSeri") = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType2", "UI")
                        dr("IsEmriNo") = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_UretimIadeIsEmriNo", "")
                End Select


                dr("Depo") = DepoNo

                MasterTable.Rows.Add(dr)
                MasterLink.MoveLast()
                FindIrsSeriSira()

                dr = DetailTable.NewRow
                dr("Deleted") = 0
                DetailTable.Rows.Add(dr)
                DetailLink.MoveLast()
            Else
                If KumasGirisID > 0 Then
                    MasterTable.SelectCommand.CommandText = Replace(MasterTable.SelectCommand.CommandText, "1=0", "KumasGirisID=" & KumasGirisID)
                    OpenTable(DetailTable)
                    OpenTable(MasterTable)
                    DetailLink.MoveLast()
                    IrsaliyeType = If0Null(MasterLink.CurrentRow("IrsaliyeType"))
                    If If0Null(MasterLink.CurrentRow("Transferred")) > 0 Then
                        MasterTable.DefaultView.AllowNew = False
                        MasterTable.DefaultView.AllowEdit = False
                        MasterTable.DefaultView.AllowDelete = False
                        DetailTable.DefaultView.AllowNew = False
                        DetailTable.DefaultView.AllowEdit = False
                        DetailTable.DefaultView.AllowDelete = False
                        MsgBox("Irsaliye Mikro sistemine gönderilmiş. Değiştiremezsiniz!")

                    Else
                        'MasterTable.LiveSave = False
                        'DetailTable.LiveSave = True
                    End If
                End If
            End If


            sbuf = GetSetting(AppConn.ApplicationCode, Me.FormCode, chkAnlikBaski.Name, "")
            If sbuf = "" Or UCase(sbuf) = "TRUE" Then
                chkAnlikBaski.Checked = True
            Else
                chkAnlikBaski.Checked = False
            End If

            Select Case IrsaliyeType
                Case 0


                Case Else
                    txtCariKodu.Visible = False
                    txtCariUnvan.Visible = False
                    lblCariKod.Visible = False
                    lblCariUnvan.Visible = False

            End Select

            If IrsaliyeType = 2 Then
                lblIsEmriNo.Visible = True
                txtIsEmriNo.Visible = True
            Else
                lblIsEmriNo.Visible = False
                txtIsEmriNo.Visible = False
            End If


            Select Case IrsaliyeType
                Case 0
                    Me.Text = "Alım irsaliyesi"
                Case 1
                    Me.Text = "Devir"
                Case 2
                    Me.Text = "Üretimden İade Giriş"

                Case Else
                    Me.Text = ""

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindIrsSeriSira()
        Try
            Dim IrsEvrakSeri As String = ""
            Dim IrsEvrakSira As Long = 1
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            IrsEvrakSeri = IfNull(MasterLink.CurrentRow("IrsEvrakSeri"), "")
            cmd.CommandText = "SELECT ISNULL(MAX(IrsEvrakSira),0) + 1 FROM KumasGiris WHERE Deleted = 0 AND IrsEvrakSeri='" & IrsEvrakSeri & "' "
            IrsEvrakSira = cmd.ExecuteScalar
            'MasterLink.CurrentRow("IrsEvrakSeri") = IrsEvrakSeri
            MasterLink.CurrentRow("IrsEvrakSira") = IrsEvrakSira
            MasterLink.CurrentRow.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDepo.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub

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

    Private Sub cmdGiris_Click(sender As System.Object, e As System.EventArgs) Handles cmdGiris.Click
        If FisBilgiKontrol() = False Then Exit Sub

        XtraTabControl1.SelectedTabPageIndex = 1

    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        Try
            If FisBilgiKontrol() = False Then Exit Sub
           
            If MsgBox("Kaydetmek istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Kaydet?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "DELETE FROM KumasGirisDetay WHERE KumasGirisID=" & If0Null(MasterLink.CurrentRow("KumasGirisID")) & " AND Miktar<=0 "
            cmd.ExecuteNonQuery()
            MasterTable.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function FisBilgiKontrol() As Boolean
        Try
            If MasterLink.CurrentRow Is Nothing Then Return False
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbTicari

            If IrsaliyeType = 0 Then
                If Trim(IfNull(MasterLink.CurrentRow("CariKod"), "")) = "" Then
                    MsgBox("Lütfen cari seçiniz!")
                    Return False
                End If
                cmd.CommandText = "SELECT COUNT(*) FROM CARI_HESAPLAR WHERE cari_kod='" & Replace(IfNull(MasterLink.CurrentRow("CariKod"), ""), "'", " ") & "' "
                If cmd.ExecuteScalar <= 0 Then
                    MsgBox("Cari kod mikroda bulunmuyor!")
                    Return False
                End If
            End If
            If Trim(IfNull(MasterLink.CurrentRow("Depo"), "")) = "" Then
                MsgBox("Lütfen depo seçiniz!")
                Return False
            End If
            If IsNumeric(Trim(IfNull(MasterLink.CurrentRow("Depo"), ""))) = False Then
                MsgBox("Lütfen depo no sayısal değil!")
                Return False
            End If

            cmd.CommandText = "SELECT COUNT(*) FROM DEPOLAR WHERE dep_no=" & If0Null(MasterLink.CurrentRow("Depo"))
            If cmd.ExecuteScalar <= 0 Then
                MsgBox("Depo no mikroda bulunmuyor!")
                Return False
            End If

            If IrsaliyeType = 2 Then
                cmd.CommandText = "SELECT COUNT(*) FROM ISEMIRLERI WHERE is_Kod='" & Replace(IfNull(MasterLink.CurrentRow("IsEmriNo"), ""), "'", " ") & "' "
                If cmd.ExecuteScalar <= 0 Then
                    MsgBox("İş emri mikroda bulunmuyor!")
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Try
            If MsgBox("Çıkmak istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Çıkış?") <> MsgBoxResult.Yes Then Exit Sub

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSatirOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdSatirOk.Click
        AddNewRow()
    End Sub

    Private Function AddNewRow() As Boolean
        Try
            If DetailLink.CurrentRow Is Nothing Then Return False
            If IsNumeric(txtMiktar.Text) Then
                If CDbl(txtMiktar.Text) > 0 Then
                    DetailLink.CurrentRow("Miktar") = CDbl(txtMiktar.Text)
                Else
                    Return False
                End If
            Else
                Return False
            End If
            DetailLink.CurrentRow.EndEdit()

            If chkAnlikBaski.Checked Then
                Yazdir(If0Null(MasterLink.CurrentRow("KumasGirisID")), If0Null(DetailLink.CurrentRow("KumasGirisDetayID")), True)
            End If
            Dim dr As DataRow = DetailTable.NewRow
            dr("Deleted") = 0
            dr("StokKod") = IfNull(DetailLink.CurrentRow("StokKod"), "")
            dr("StokIsmi") = IfNull(DetailLink.CurrentRow("StokIsmi"), "")
            dr("Parti") = IfNull(DetailLink.CurrentRow("Parti"), "")
            dr("LotNo") = If0Null(DetailLink.CurrentRow("LotNo"))
            dr("Birim") = IfNull(DetailLink.CurrentRow("Birim"), "")
            dr("Miktar") = 0
            DetailTable.Rows.Add(dr)
            DetailLink.MoveLast()
            txtMiktar.Text = ""
            'tmrMiktarFocus.Enabled = True
            txtMiktar.Focus()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub txtStokKodu_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtStokKodu.ButtonClick, txtStokIsmi.ButtonClick
        Try
            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            Dim f As New frmMikro_StokKartlari
            With f
                
                .FormSelect_PartiLot()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    DetailLink.CurrentRow("StokKod") = IfNull(.ReturnDataRow("sto_kod"), "")
                    DetailLink.CurrentRow("StokIsmi") = IfNull(.ReturnDataRow("sto_isim"), "")
                    DetailLink.CurrentRow("Birim") = IfNull(.ReturnDataRow("sto_birim1_ad"), "")

                    DetailLink.CurrentRow.EndEdit()
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_EditorKeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.EditorKeyDown
        GridControl1_KeyDown(sender, e)
    End Sub

    Private Sub GridControl1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        Try
            If e.KeyCode = Keys.Delete And (e.Control Or e.Shift) Then

                If DetailLink.CurrentRow Is Nothing Then Exit Sub
                bGridNoFocus = True
                If MsgBox("Satırı silmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Satır Sil?") <> MsgBoxResult.Yes Then Exit Sub
                DetailLink.CurrentRow.Delete()
                bGridNoFocus = False
            End If
        Catch ex As Exception

        End Try
        bGridNoFocus = False
    End Sub

    Private Sub txtMiktar_GotFocus(sender As Object, e As System.EventArgs) Handles txtMiktar.GotFocus
        txtMiktar.SelectionStart = 0
        txtMiktar.SelectAll()
    End Sub

    Private Sub txtLotNo_Click(sender As Object, e As System.EventArgs) Handles txtLotNo.Click
        txtLotNo.SelectionStart = 0
        txtLotNo.SelectAll()
    End Sub

    Private Sub txtParti_Click(sender As Object, e As System.EventArgs) Handles txtParti.Click
        txtParti.SelectionStart = 0
        txtParti.SelectAll()
    End Sub

    Private Sub txtMiktar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMiktar.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                'If Not IsNumeric(txtMiktar.Text) Then Exit Sub
                'If CDbl(txtMiktar.Text) <= 0 Then Exit Sub
                AddNewRow()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tmrMiktarFocus_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMiktarFocus.Tick
        tmrMiktarFocus.Enabled = False
        txtMiktar.Focus()
    End Sub

    Private Sub txtMiktar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiktar.KeyPress
        Try
            If e.KeyChar = "," Or e.KeyChar = "." Then
                e.KeyChar = DecimalPointer()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkAnlikBaski_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAnlikBaski.CheckedChanged
        Try
            SaveSetting(AppConn.ApplicationCode, Me.FormCode, chkAnlikBaski.Name, chkAnlikBaski.Checked.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTopluYazdir_Click(sender As System.Object, e As System.EventArgs) Handles cmdTopluYazdir.Click
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            Yazdir(MasterLink.CurrentRow("KumasGirisID"), 0, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Yazdir(KumasGirisID As Long, KumasGirisDetayID As Long, Invisible As Boolean)
        Try
            Dim f As New frmReportSelect
            With f
                .Parameters = New ArrayList


                .Parameters.Add(New SqlClient.SqlParameter("@KumasGirisID", KumasGirisID))
                .Parameters.Add(New SqlClient.SqlParameter("@KumasGirisDetayID", KumasGirisDetayID))

                
                .FormCode = Me.FormCode
                .PrintScript = MasterTable.SelectCommand.CommandText
                If Invisible Then
                    If Trim(cboYazici.Text) = "" Then
                        MsgBox("Lütfen yazıcı seçiniz!")
                        Exit Sub
                    End If
                    .FormPrintInvisible(cboYazici.Text)
                Else
                    .FormShow()
                End If


            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            cboYazici.Properties.Items.Clear()

            For Each p As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                cboYazici.Properties.Items.Add(p)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrintDetay_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnPrintDetay.ButtonClick
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            bGridNoFocus = True
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            If RowIndex < 0 Then Exit Sub
            Dim dr As DataRow = DetailTable.Rows(RowIndex)
            Yazdir(If0Null(dr("KumasGirisID")), If0Null(dr("KumasGirisDetayID")), chkAnlikBaski.Checked)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bGridNoFocus = False
    End Sub

    Private Sub GridControl1_LostFocus(sender As Object, e As System.EventArgs) Handles GridControl1.LostFocus
        '
    End Sub

    Private Sub MasterTable_ColumnChanged(sender As Object, e As System.Data.DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DetailTable_ColumnChanged(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles DetailTable.ColumnChanged
        Try
            If bNoAction Then Exit Sub
            bNoAction = True
            If e.Column.ColumnName = "Parti" Then
                e.Row("Parti") = UCaseEng(IfNull(e.Row("Parti"), ""))
            End If
            e.Row.EndEdit()
            bNoAction = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub txtStokKodu_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtStokKodu.KeyDown, txtStokIsmi.KeyDown
        If e.KeyCode = Keys.F10 Then
            txtStokKodu_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub GridView1_LostFocus(sender As Object, e As System.EventArgs) Handles GridView1.LostFocus
        Try
            If bGridNoFocus = True Then Exit Sub

            If DetailLink.CurrentRow Is Nothing Then Exit Sub
            DetailLink.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class