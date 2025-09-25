Public Class frmSevkler
    Dim SevkTipi As Integer = 0
    Dim dtSevkSipDetay As New DataTable

    Public Sub FormShow_Irsaliye(Optional ByVal bDialog As Boolean = True, Optional ByVal bControlMasterConn As Boolean = False, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal Owner As Form = Nothing)
        Try
            Me.FormCode = "000025"
            Me.Text = "Sevk Irsaliyeleri"
            SevkTipi = 0
            MasterTable.SelectCommand.CommandText &= " AND SevkTipi=0 "
            txtDepo.Properties.ReadOnly = True
            txtDepo2.Properties.ReadOnly = True
            Me.FormShow(bDialog, bControlMasterConn, bControlFirmConn, Owner)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FormShow_DepoSevk(Optional ByVal bDialog As Boolean = True, Optional ByVal bControlMasterConn As Boolean = False, Optional ByVal bControlFirmConn As Boolean = True, Optional ByVal Owner As Form = Nothing)
        Try
            Me.FormCode = "000026"
            Me.Text = "Depo Sevk Islemleri"
            SevkTipi = 1
            MasterTable.SelectCommand.CommandText &= " AND SevkTipi=1 "
            CariKodButtonEdit.Properties.ReadOnly = True
            CariUnvanButtonEdit.Properties.ReadOnly = True
            Me.FormShow(bDialog, bControlMasterConn, bControlFirmConn, Owner)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CariKodButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CariKodButtonEdit.ButtonClick, CariUnvanButtonEdit.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If CariKodButtonEdit.Properties.ReadOnly Then Exit Sub
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

    Private Sub cmdSiparisEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiparisEkle.Click
        Try
            If EditMode = False Then
                Beep()

                Exit Sub
            End If
            If MasterLink.CurrentRow Is Nothing Then Exit Sub

            If SevkTipi = 0 Then
                If IfNull(MasterLink.CurrentRow("CariKod"), "") = "" Then
                    MsgBox("Lütfen cari kod seçiniz!")
                    Exit Sub
                End If
            End If

            Dim f As New frmSiparisRaporu
            With f
                .FormShow_SelectSiparis(IfNull(MasterLink.CurrentRow("CariKod"), ""), " AND SipDetay.Durumu<>'BITTI'  AND Siparis.SiparisType=" & SevkTipi)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    For i = 0 To .ReturnDataRows.Length - 1
                        Dim bFound As Boolean = False
                        For Each dr As DataRow In DetailTable.Rows
                            If If0Null(dr("SipDetayID")) = If0Null(.ReturnDataRows(i).Item("SipDetayID")) Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound = False Then
                            Dim newdr As DataRow = DetailTable.NewRow
                            newdr("SiparisID") = If0Null(.ReturnDataRows(i).Item("SiparisID"))
                            newdr("SipDetayID") = If0Null(.ReturnDataRows(i).Item("SipDetayID"))

                            DetailTable.Rows.Add(newdr)
                        End If
                    Next
                    If (DetailTable2.Rows.Count = 0) Then
                        Dim newPaket As DataRow = DetailTable2.NewRow
                        newPaket("PaketNo") = 1
                        newPaket("NetAgirlik") = 0
                        newPaket("Dara") = 0
                        newPaket("BrutAgirlik") = 0

                        DetailTable2.Rows.Add(newPaket)
                        txtAktifPaketNo.Text = 1
                        txtAktifPaketNo.ClosePopup()

                    End If

                    Load_dtSevkSipDetay()
                    If If0Null(MasterLink.CurrentRow("CekiListesiUygula")) = 0 Then
                        Load_dtSipDetay_CekiListesiz()

                    End If
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

    Private Sub frmIrsaliyeler_ButtonNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.ButtonNewClick
        Try
            MasterLink.CurrentRow("SevkTipi") = SevkTipi
            MasterLink.CurrentRow("Tarih") = Today
            MasterLink.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub frmIrsaliyeler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            OpenTable(tbKategori)
            OpenTable(tbOkul)
            OpenTable(tbKargolar)
            Load_dtSevkSipDetay()
            SonPaketNo_Goster()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterLink_PositionChanged(sender As Object, e As EventArgs) Handles MasterLink.PositionChanged
        Try
            'If MasterLink.Position < 0 Then Exit Sub
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If bNoAction Then Exit Sub
            bNoAction = True
            'DetailTable3.SelectCommand.Parameters("@SevkID").Value = MasterLink.CurrentRow("SevkID")
            'OpenTable(DetailTable3)

            Load_dtSevkSipDetay()
            'Load_dtSipDetay_CekiListesiz()

            'DetailTable3e_EkAlanlarEkleGoster()

            SonPaketNo_Goster()
            ShowHide_CekiListesiIslemi()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub cboKargo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKargo.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmKargolar
                f.FormShow()
                OpenTable(tbKargolar)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSevkler_ButtonSaveAfterClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles MyBase.ButtonSaveAfterClick
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = MasterTable.Connection.SqlConnection
            cmd.Transaction = MasterTable.Transaction

            Dim sipdetayIDArray As New ArrayList


            For Each dr As DataRow In DetailTable3.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    'cmd.CommandText = "UPDATE SipDetayFiyatlar SET TeslimMiktar = ISNULL((SELECT SUM(Adet)  FROM SevkDetay WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "'),0)   " & _
                    '    " WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "' "
                    cmd.CommandText = "UPDATE SipDetayFiyatlar SET TeslimMiktar = ISNULL((SELECT SUM(SevkDetay.Adet)  FROM SevkDetay INNER JOIN " &
                        " Sevk ON Sevk.SevkID = SevkDetay.SevkID " &
                        " WHERE Sevk.Deleted=0 AND Sevk.Iptal=0 AND SevkDetay.Deleted = 0 And  SevkDetay.SipDetayID=" & dr("SipDetayID") & " And SevkDetay.BedenKod='" & dr("BedenKod") & "'),0)   " &
                        " WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "' "

                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "SELECT SUM(Adet) FROM SevkDetay WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "' "
                    dr("TeslimMiktar") = cmd.ExecuteScalar
                    sipdetayIDArray.Add(dr("SipDetayID"))

                Else
                    dr.RejectChanges()
                    'cmd.CommandText = "UPDATE SipDetayFiyatlar SET TeslimMiktar = ISNULL((SELECT SUM(Adet)  FROM SevkDetay WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "'),0)   " &
                    '    " WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "' "

                    cmd.CommandText = "UPDATE SipDetayFiyatlar SET TeslimMiktar = ISNULL((SELECT SUM(SevkDetay.Adet)  FROM SevkDetay INNER JOIN " &
                        " Sevk ON Sevk.SevkID = SevkDetay.SevkID " &
                        " WHERE Sevk.Deleted=0 AND Sevk.Iptal=0 AND SevkDetay.Deleted = 0 And  SevkDetay.SipDetayID=" & dr("SipDetayID") & " And SevkDetay.BedenKod='" & dr("BedenKod") & "'),0)   " &
                        " WHERE Deleted = 0 AND  SipDetayID=" & dr("SipDetayID") & " AND BedenKod='" & dr("BedenKod") & "' "

                    sipdetayIDArray.Add(dr("SipDetayID"))
                    dr.Delete()

                    cmd.ExecuteNonQuery()

                End If

            Next

            For i As Integer = 0 To sipdetayIDArray.Count - 1
                cmd.CommandText = "UPDATE SipDetay SET TeslimMiktar = ISNULL((SELECT SUM(SevkDetay.Adet)  FROM SevkDetay INNER JOIN " &
                    " Sevk ON Sevk.SevkID = SevkDetay.SevkID " &
                    " WHERE Sevk.Deleted = 0 AND Sevk.Iptal=0 AND SevkDetay.Deleted = 0 And  SevkDetay.SipDetayID=" & sipdetayIDArray(i) & "),0)   " &
                     " WHERE Deleted = 0 And  SipDetayID=" & sipdetayIDArray(i) & "  "
                cmd.ExecuteNonQuery()

                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlClient.SqlParameter("@TeslimEksikOran", glb_TeslimEksikOran))
                cmd.Parameters.Add(New SqlClient.SqlParameter("@TeslimFazlaOran", glb_TeslimFazlaOran))
                If MasterLink.CurrentRow("Iptal") = 0 Then
                    cmd.CommandText = "UPDATE SipDetay SET Durumu='BITTI' " & vbNewLine &
                    " WHERE SipDetayID =" & sipdetayIDArray(i) & " AND Durumu<>'BITTI' AND Miktar>0 " & vbNewLine &
                    " AND (  " & vbNewLine &
                    "	((Miktar-TeslimMiktar)>=0 AND (100*ABS(Miktar-TeslimMiktar) /Miktar)<=@TeslimEksikOran)  " & vbNewLine &
                    "		OR  " & vbNewLine &
                    "	((Miktar-TeslimMiktar)<0 AND (100*ABS(Miktar-TeslimMiktar) /Miktar)>=@TeslimFazlaOran) " & vbNewLine &
                    "	) "
                Else
                    cmd.CommandText = "UPDATE SipDetay SET Durumu='' " & vbNewLine &
                    " WHERE SipDetayID =" & sipdetayIDArray(i) & " AND Durumu='BITTI' AND Miktar>0 " & vbNewLine &
                    " AND (  " & vbNewLine &
                    "	(Miktar>=TeslimMiktar AND (100*ABS(Miktar-TeslimMiktar) /Miktar)>@TeslimEksikOran)  " & vbNewLine &
                    "	) "
                End If
                
                cmd.ExecuteNonQuery()
            Next


            Dim mesaj As String = ""
            If MasterLink.CurrentRow("Iptal") = 0 Then


                For Each dr As DataRow In DetailTable3.Rows
                    If dr.RowState <> DataRowState.Deleted Then
                        If If0Null(dr("Adet")) > 0 Then
                            If If0Null(dr("TeslimMiktar")) > (If0Null(dr("SipMiktar")) + If0Null(dr("SipMiktar")) * glb_TeslimFazlaOran / 100) Then
                                mesaj &= "Siparis No:" & IfNull(dr("SiparisNo"), "") & " Beden Kod:" & IfNull(dr("BedenKod"), "") & "  Siparis Miktar:" & If0Null(dr("SipMiktar")) & " Teslim Edilen:" & If0Null(dr("TeslimMiktar")) & " // Teslim miktari siparis miktarindan fazla! " & vbNewLine

                            ElseIf If0Null(dr("TeslimMiktar")) < (If0Null(dr("SipMiktar")) - (If0Null(dr("SipMiktar")) * glb_TeslimEksikOran / 100)) Then
                                mesaj &= "Siparis No:" & IfNull(dr("SiparisNo"), "") & " Beden Kod:" & IfNull(dr("BedenKod"), "") & "  Siparis Miktar:" & If0Null(dr("SipMiktar")) & " Teslim Edilen:" & If0Null(dr("TeslimMiktar")) & " // Teslim miktari siparis miktarindan eksik! " & vbNewLine

                            End If
                        End If

                    End If
                Next
                If mesaj <> "" Then
                    If MsgBox(mesaj & vbNewLine & "Yinede cikis yapmak istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Devam?") <> MsgBoxResult.Yes Then
                        e.Cancel = True
                        Exit Sub
                    End If
                End If

            End If



            'Siparis detay durumlarini otomatik 'BITTI' durumuna gecir. asagi ve yukari tasma oranlarina gore.

            For Each dr As DataRow In DetailTable.Rows
                If dr.RowState <> DataRowState.Deleted Then

                    cmd.CommandText = "UPDATE SipDetay SET Durumu='BITTI' FROM SipDetay INNER JOIN " &
                    " (SELECT SipDetayID,SUM(Miktar) as SipMiktar, SUM(TeslimMiktar) as TesMiktar FROM SipDetayFiyatlar " &
                    " WHERE Deleted = 0 And Miktar > 0 And TeslimMiktar > 0 " &
                    " GROUP BY SipDetayID " &
                    " HAVING SUM(TeslimMiktar)>=(SUM(Miktar) - SUM(Miktar)*5/100)) X ON X.SipDetayID = SipDetay.SipDetayID " &
                    " WHERE SipDetay.Deleted = 0 AND SipDetay.Durumu<>'BITTI' AND SipDetay.SipDetayID=" & If0Null(dr("SipDetayID"))
                    cmd.ExecuteNonQuery()


                End If
            Next
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ShowHide_CekiListesiIslemi()
        Try
            'If If0Null(MasterLink.CurrentRow("CekiListesiUygula")) = 1 Then
            If CheckEdit1.Checked Then
                panelSipDetay.Visible = True
                panelYeniPaket.Visible = True
                XtraTabPage2.PageVisible = True

            Else
                panelSipDetay.Visible = False
                panelYeniPaket.Visible = False
                XtraTabPage2.PageVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SonPaketNo_Goster()
        Try
            Dim MaxPaketNo As Long = 0
            For Each dr As DataRow In DetailTable2.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If If0Null(dr("PaketNo")) > MaxPaketNo Then
                        MaxPaketNo = If0Null(dr("PaketNo"))
                    End If
                End If
            Next
            txtAktifPaketNo.Text = MaxPaketNo
            txtAktifPaketNo.ClosePopup()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdYeniPaket_Click(sender As Object, e As EventArgs) Handles cmdYeniPaket.Click
        Try
            Dim MaxPaketNo As Long = 0
            For Each dr As DataRow In DetailTable2.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If If0Null(dr("PaketNo")) > MaxPaketNo Then
                        MaxPaketNo = If0Null(dr("PaketNo"))
                    End If
                End If
            Next

            If MaxPaketNo > 0 Then
                Dim bFound As Boolean = False
                For Each dr As DataRow In DetailTable3.Rows
                    If dr.RowState <> DataRowState.Deleted Then
                        If If0Null(dr("PaketNo")) = MaxPaketNo Then
                            bFound = True
                            Exit For
                        End If
                    End If
                Next
                If bFound = False Then
                    Beep()
                    Exit Sub

                End If
            End If

            MaxPaketNo += 1

            Dim newdr As DataRow = DetailTable2.NewRow
            newdr("PaketNo") = MaxPaketNo
            newdr("NetAgirlik") = 0
            newdr("Dara") = 0
            newdr("BrutAgirlik") = 0
            DetailTable2.Rows.Add(newdr)

            txtAktifPaketNo.Text = MaxPaketNo
            txtAktifPaketNo.ClosePopup()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            If e.Column.ColumnName = "CekiListesiUygula" Then
                ShowHide_CekiListesiIslemi()

            End If
            'If e.Column.ColumnName = "YurtDisi" Then
            '    If e.Row("YurtDisi") = 1 Then
            '        e.Row("CekiListesiUygula") = 1
            '    End If
            'End If
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DetailTable3_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles DetailTable3.ColumnChanged
        Try

            'If e.Column.ColumnName = "SipDetayID" Then
            '    e.Row("NetFiyat") = 0
            '    e.Row("StokKod") = "stok kod"
            '    e.Row("KategoriIsim") = "kategori isim"
            '    e.Row("KategoriKod") = "kategori kod"
            '    e.Row("Okul") = "okul"

            'End If
            If e.Column.ColumnName = "Adet" Then
                e.Row("Tutar") = Math.Round(If0Null(e.Row("Adet")) * If0Null(e.Row("NetFiyat")), 2)
            End If
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub frmSevkler_ButtonSaveBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            Dim TAdet As Double = 0
            Dim paketarray As New ArrayList
            For Each dr As DataRow In DetailTable3.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    Dim bFound As Boolean = False
                    For i As Integer = 0 To paketarray.Count - 1
                        If paketarray(i) = If0Null(dr("PaketNo")) Then
                            bFound = True
                            Exit Sub
                        End If
                    Next
                    If bFound = False Then
                        paketarray.Add(If0Null(dr("PaketNo")))
                    End If

                    TAdet += If0Null(dr("Adet"))
                End If
            Next

            MasterLink.CurrentRow("ToplamPaket") = paketarray.Count
            MasterLink.CurrentRow("ToplamAdet") = TAdet
            MasterLink.CurrentRow.EndEdit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSevkler_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                cmdSiparisEkle_Click(Nothing, Nothing)

            End If
            If e.KeyCode = Keys.F6 Then
                If MasterLink.CurrentRow Is Nothing Then Exit Sub
                If If0Null(MasterLink.CurrentRow("CekiListesiUygula")) <> 1 Then
                    Exit Sub
                End If
                cmdPaketeEkle_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComboBoxEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.EditValueChanged
        Try
            LabelControl8.Text = "Tasima evrak no"
            Select Case ComboBoxEdit1.Text
                Case "Hava" : LabelControl8.Text = "Airway bill"
                Case "Deniz" : LabelControl8.Text = "Seaway bill"
                Case "Kara" : LabelControl8.Text = "Tır plaka"
                Case Else

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Prepare_dtSevkSipDetay()
        Try
            dtSevkSipDetay = New DataTable
            With dtSevkSipDetay.Columns
                .Add(New DataColumn("SiparisID", GetType(Long)))
                .Add(New DataColumn("SipDetayID", GetType(Long)))
                .Add(New DataColumn("SipDetayFiyatAdetID", GetType(Long)))
                .Add(New DataColumn("Tarih", GetType(Date)))
                .Add(New DataColumn("SipEvrakSeri", GetType(String)))
                .Add(New DataColumn("SipEvrakSira", GetType(Long)))
                .Add(New DataColumn("KategoriKod", GetType(String)))
                .Add(New DataColumn("KategoriIsim", GetType(String)))
                .Add(New DataColumn("Okul", GetType(String)))
                .Add(New DataColumn("BedenKod", GetType(String)))
                .Add(New DataColumn("StokKod", GetType(String)))
                .Add(New DataColumn("RenkKod", GetType(String)))
                .Add(New DataColumn("SipMiktar", GetType(Double)))
                .Add(New DataColumn("Miktar", GetType(Double)))
                .Add(New DataColumn("TeslimMiktar", GetType(Double)))
                .Add(New DataColumn("Kalan", GetType(Double)))
                .Add(New DataColumn("NetFiyat", GetType(Double)))
            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Load_dtSevkSipDetay()
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            Prepare_dtSevkSipDetay()
            dtSevkSipDetay.Rows.Clear()
            grSiparisDetay.DataSource = dtSevkSipDetay
            If If0Null(MasterLink.CurrentRow("CekiListesiUygula")) = 0 Then Exit Sub

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn



            For Each dr As DataRow In DetailTable.Rows
                If dr.RowState <> DataRowState.Deleted Then


                    cmd.CommandText = "SELECT * FROM (SELECT  Siparis.SiparisID ,SipDetay.SipDetayID, SipDetayFiyatlar.SipDetayFiyatAdetID, Siparis.Tarih, Siparis.SipEvrakSeri,Siparis.SipEvrakSira , SipDetay.StokKod, Okullar.OkulKod, Okullar.OkulIsmi, Kategoriler.KategoriKod, Kategoriler.KategoriIsim, SipDetayFiyatlar.BedenKod, SipDetayFiyatlar.Miktar, SipDetayFiyatlar.RenkKod, " &
                        "               SipDetayFiyatlar.TeslimMiktar,SipDetay.AnaRenk , SipDetayFiyatlar.NetFiyat " &
                        " , dbo.fnBedenNo(SipDetay.KategoriID,SipDetayFiyatlar.BedenKod) as BedenNo " &
                        " FROM  SipDetay INNER JOIN " &
                        "               Siparis ON Siparis.SiparisID = SipDetay.SiparisID INNER JOIN " &
                        "               Kategoriler ON SipDetay.KategoriID = Kategoriler.KategoriID INNER JOIN " &
                        "               SipDetayFiyatlar ON SipDetay.SipDetayID = SipDetayFiyatlar.SipDetayID LEFT OUTER JOIN " &
                        "               Okullar ON SipDetay.OkulID = Okullar.OkulID " &
                        " WHERE SipDetay.SipDetayID = " & If0Null(dr("SipDetayID")) & " AND (SipDetayFiyatlar.Miktar>0 OR  SipDetayFiyatlar.TeslimMiktar>0) " &
                        ") X " &
                        " ORDER BY X.BedenNo "
                    da = New SqlClient.SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then

                        For Each drdetay As DataRow In dt.Rows

                            Dim newdr As DataRow = dtSevkSipDetay.NewRow
                            newdr("SiparisID") = If0Null(drdetay("SiparisID"))
                            newdr("SipDetayID") = If0Null(drdetay("SipDetayID"))
                            newdr("SipDetayFiyatAdetID") = If0Null(drdetay("SipDetayFiyatAdetID"))

                            newdr("Tarih") = IfNull(drdetay("Tarih"), DateSerial(1900, 1, 1))
                            newdr("SipEvrakSeri") = IfNull(drdetay("SipEvrakSeri"), "")
                            newdr("SipEvrakSira") = If0Null(drdetay("SipEvrakSira"))

                            newdr("KategoriKod") = IfNull(drdetay("KategoriKod"), "")
                            newdr("KategoriIsim") = IfNull(drdetay("KategoriIsim"), "")
                            newdr("Okul") = IfNull(drdetay("OkulKod"), "") & "-" & IfNull(drdetay("OkulIsmi"), "")
                            newdr("BedenKod") = IfNull(drdetay("BedenKod"), "")
                            newdr("StokKod") = IfNull(drdetay("StokKod"), "")
                            newdr("RenkKod") = IfNull(drdetay("RenkKod"), "")
                            newdr("NetFiyat") = If0Null(drdetay("NetFiyat"))
                            newdr("SipMiktar") = If0Null(drdetay("Miktar"))
                            newdr("TeslimMiktar") = If0Null(drdetay("TeslimMiktar"))
                            newdr("Kalan") = If0Null(drdetay("Miktar")) - If0Null(drdetay("TeslimMiktar"))
                            newdr("Miktar") = 0
                            newdr.EndEdit()
                            dtSevkSipDetay.Rows.Add(newdr)
                        Next


                    End If
                    dt.Dispose()
                    da.Dispose()



                End If
            Next


            grSiparisDetay.DataSource = dtSevkSipDetay


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Load_dtSipDetay_CekiListesiz()
        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn



            For Each dr As DataRow In DetailTable.Rows
                If dr.RowState <> DataRowState.Deleted Then


                    cmd.CommandText = "SELECT * FROM (SELECT  Siparis.SiparisID ,SipDetay.SipDetayID, SipDetayFiyatlar.SipDetayFiyatAdetID ,Siparis.Tarih, Siparis.SipEvrakSeri + '-' + CAST(Siparis.SipEvrakSira as VARCHAR(10)) as SiparisNo , SipDetay.StokKod, Okullar.OkulKod, Okullar.OkulIsmi, Kategoriler.KategoriKod, Kategoriler.KategoriIsim, SipDetayFiyatlar.BedenKod, SipDetayFiyatlar.Miktar, SipDetayFiyatlar.RenkKod, " &
                        "               SipDetayFiyatlar.TeslimMiktar,SipDetay.AnaRenk ,SipDetayFiyatlar.Miktar as SipMiktar, SipDetayFiyatlar.NetFiyat , SipDetayFiyatlar.Miktar - SipDetayFiyatlar.TeslimMiktar  as Kalan " &
                        " , dbo.fnBedenNo(SipDetay.KategoriID,SipDetayFiyatlar.BedenKod) as BedenNo " &
                        "FROM  SipDetay INNER JOIN " &
                        "               Siparis ON Siparis.SiparisID = SipDetay.SiparisID INNER JOIN " &
                        "               Kategoriler ON SipDetay.KategoriID = Kategoriler.KategoriID INNER JOIN " &
                        "               SipDetayFiyatlar ON SipDetay.SipDetayID = SipDetayFiyatlar.SipDetayID LEFT OUTER JOIN " &
                        "               Okullar ON SipDetay.OkulID = Okullar.OkulID " &
                        "WHERE SipDetay.SipDetayID = " & If0Null(dr("SipDetayID")) & " AND (SipDetayFiyatlar.Miktar>0 OR  SipDetayFiyatlar.TeslimMiktar>0) " &
                       ") X " &
                        " ORDER BY X.BedenNo "

                    da = New SqlClient.SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then

                        For Each drdetay As DataRow In dt.Rows
                            Dim bFound As Boolean = False
                            For Each dr2 As DataRow In DetailTable3.Rows
                                If dr2.RowState <> DataRowState.Deleted Then
                                    If If0Null(dr2("SipDetayID")) = If0Null(drdetay("SipDetayID")) And IfNull(dr2("BedenKod"), "") = IfNull(drdetay("BedenKod"), "") Then
                                        bFound = True
                                    End If
                                End If
                            Next
                            If bFound = False Then
                                Dim newdr As DataRow = DetailTable3.NewRow
                                'newdr("SiparisID") = If0Null(drdetay("SiparisID"))
                                newdr("SipDetayID") = If0Null(drdetay("SipDetayID"))
                                newdr("SipDetayFiyatAdetID") = If0Null(drdetay("SipDetayFiyatAdetID"))

                                newdr("PaketNo") = DetailTable2.Rows(DetailTable2.Rows.Count - 1).Item("PaketNo")
                                newdr("BedenKod") = IfNull(drdetay("BedenKod"), "")
                                newdr("Adet") = 0
                                newdr("Tutar") = 0
                                newdr("DetayAciklama") = ""
                                newdr("RenkKod") = IfNull(drdetay("AnaRenk"), "")
                                newdr("DetayAciklama") = ""
                                newdr("SipMiktar") = If0Null(drdetay("SipMiktar"))
                                newdr("TeslimMiktar") = If0Null(drdetay("TeslimMiktar"))
                                newdr("SiparisNo") = IfNull(drdetay("SiparisNo"), "")
                                newdr("NetFiyat") = If0Null(drdetay("NetFiyat"))

                                newdr("StokKod") = IfNull(drdetay("StokKod"), "")

                                newdr("KategoriKod") = IfNull(drdetay("KategoriKod"), "")
                                newdr("Okul") = IfNull(drdetay("OkulKod"), "") & "-" & IfNull(drdetay("OkulIsmi"), "")
                                newdr("KategoriIsim") = IfNull(drdetay("KategoriIsim"), "")
                                newdr("StokKod") = IfNull(drdetay("StokKod"), "")
                                newdr("Kalan") = If0Null(drdetay("Kalan"))
                                newdr.EndEdit()
                                DetailTable3.Rows.Add(newdr)

                            End If

                        Next


                    End If
                    dt.Dispose()
                    da.Dispose()



                End If
            Next


            'grSiparisDetay.DataSource = dtSevkSipDetay


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmdPaketeEkle_Click(sender As Object, e As EventArgs) Handles cmdPaketeEkle.Click
        Try
            If EditMode = False Then
                Beep()
                Exit Sub
            End If
            If (DetailTable2.Rows.Count = 0) Then
                Dim newPaket As DataRow = DetailTable2.NewRow
                newPaket("PaketNo") = 1
                newPaket("NetAgirlik") = 0
                newPaket("Dara") = 0
                newPaket("BrutAgirlik") = 0

                DetailTable2.Rows.Add(newPaket)
                txtAktifPaketNo.Text = 1
            End If
            For Each dr As DataRow In dtSevkSipDetay.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If If0Null(dr("Miktar")) > 0 Then
                        Dim newdr As DataRow = DetailTable3.NewRow
                        newdr("SipDetayID") = If0Null(dr("SipDetayID"))
                        newdr("SipDetayFiyatAdetID") = If0Null(dr("SipDetayFiyatAdetID"))
                        newdr("SevkPaketID") = 0 ' DetailTable2.Rows(DetailTable2.Rows.Count - 1).Item("SevkPaketID")
                        newdr("PaketNo") = txtAktifPaketNo.Text ' DetailTable2.Rows(DetailTable2.Rows.Count - 1).Item("PaketNo")
                        newdr("SiparisNo") = IfNull(dr("SipEvrakSeri"), "") & "-" & If0Null(dr("SipEvrakSira"))
                        newdr("BedenKod") = IfNull(dr("BedenKod"), "")
                        newdr("RenkKod") = IfNull(dr("RenkKod"), "")
                        newdr("KategoriKod") = IfNull(dr("KategoriKod"), "")
                        newdr("KategoriIsim") = IfNull(dr("KategoriIsim"), "")
                        newdr("Okul") = IfNull(dr("Okul"), "")
                        newdr("StokKod") = IfNull(dr("StokKod"), "")
                        newdr("NetFiyat") = If0Null(dr("NetFiyat"))
                        newdr("SipMiktar") = If0Null(dr("SipMiktar"))
                        newdr("TeslimMiktar") = If0Null(dr("TeslimMiktar"))

                        newdr("Adet") = If0Null(dr("Miktar"))
                        newdr.EndEdit()
                        DetailTable3.Rows.Add(newdr)
                        dr("Miktar") = 0
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            ShowHide_CekiListesiIslemi()
        End If
    End Sub

    Private Sub CheckEdit2_Click(sender As Object, e As EventArgs) Handles CheckEdit2.Click
        Try
            'If MasterLink.CurrentRow Is Nothing Then Exit Sub
            'If MasterLink.AllowEdit = False Then Exit Sub
            'If CheckEdit2.Checked Then

            '    MasterLink.CurrentRow("CekiListesiUygula") = 1
            '    MasterLink.CurrentRow.EndEdit()

            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSevkDetayOzet_Click(sender As Object, e As EventArgs) Handles cmdSevkDetayOzet.Click
        Try
            If grDetayView.GetSelectedRows.Length = 0 Then
                MsgBox("Secili detay yok!")
                Exit Sub
            End If

            Dim TAdet As Double = 0
            Dim TTutar As Double = 0
            Dim Paketler As New ArrayList
            For i As Integer = 0 To grDetayView.GetSelectedRows.Length - 1
                If grDetayView.IsGroupRow(grDetayView.GetSelectedRows(i)) = False Then
                    Dim RowIndex As Integer = grDetayView.GetDataSourceRowIndex(grDetayView.GetSelectedRows(i))
                    If RowIndex >= 0 Then
                        Dim dr As DataRow = DetailTable3.Rows(RowIndex)
                        TAdet += If0Null(dr("Adet"))
                        TTutar += If0Null(dr("Tutar"))

                        Dim bFound As Boolean = False
                        For j As Integer = 0 To Paketler.Count - 1
                            If Paketler(j) = If0Null(dr("PaketNo")) Then
                                bFound = True
                                Exit For
                            End If
                        Next
                        If bFound = False Then
                            Paketler.Add(If0Null(dr("PaketNo")))

                        End If
                    End If
                End If
            Next

            MsgBox("Paket sayisi:" & Paketler.Count & "  T.Adet:" & Format(TAdet, "#,##0.###") & "  T.Tutar:" & Format(TTutar, "#,##0.00"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisler_ButtonNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.ButtonNewClick
        Try
            With MasterLink.CurrentRow
                .Item("Tarih") = AppConn.Today
                .Item("SevkTipi") = SevkTipi

            End With
            YeniSevkNo()
            ShowHide_CekiListesiIslemi()
            Load_dtSevkSipDetay()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub YeniSevkNo()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim dt As DataTable
            Dim da As SqlClient.SqlDataAdapter
            Dim Seri As String = ""
            Dim Sira As Long = 0
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT TOP 1 S.SevkEvrakSeri,L.Sira  FROM Sevk S INNER JOIN  " &
                "(SELECT SevkEvrakSeri,MAX(SevkEvrakSira) as Sira FROM Sevk WHERE Deleted = 0 " &
                "GROUP BY SevkEvrakSeri) L ON S.SevkEvrakSeri = L.SevkEvrakSeri " &
                "WHERE S.Deleted = 0  " &
                "ORDER BY S.SevkID DESC " &
                ""
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Seri = IfNull(dt.Rows(0).Item("SevkEvrakSeri"), "")
                Sira = If0Null(dt.Rows(0).Item("Sira"))
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()

            With MasterLink.CurrentRow

                .Item("SevkEvrakSeri") = Seri
                .Item("SevkEvrakSira") = Sira + 1
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSevkSatirSil_Click(sender As Object, e As EventArgs) Handles cmdSevkSatirSil.Click
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If If0Null(MasterLink.CurrentRow("CekiListesiUygula")) <> 1 Then Exit Sub
            If grDetayView.GetSelectedRows.Length = 0 Then
                MsgBox("Secili detay yok!")
                Exit Sub
            End If
            If MsgBox(grDetayView.GetSelectedRows.Length & " tane satir silinecektir. Onayliyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Satir sil?") <> MsgBoxResult.Yes Then Exit Sub

Basa:
            If grDetayView.GetSelectedRows.Length > 0 Then
                Dim RowIndex As Integer = grDetayView.GetDataSourceRowIndex(grDetayView.GetSelectedRows(0))
                If RowIndex >= 0 Then
                    DetailTable3.Rows(RowIndex).Delete()
                    GoTo Basa
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOnayla_Click(sender As Object, e As EventArgs) Handles cmdOnayla.Click
        Try
            If EditMode = False Then
                Beep()
                Application.DoEvents()
                Beep()

                Exit Sub
            End If

            If If0Null(MasterLink.CurrentRow("Onayli")) <> 1 Then


                If MsgBox("Onaylamak istiyor musunuz?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Onayla?") <> MsgBoxResult.Yes Then Exit Sub
                MasterTable.Save()
                Dim cmd As New SqlClient.SqlCommand
                Try
                    cmd.Connection = AppConn.dbConn
                    cmd.CommandTimeout = 600 * 3
                    If If0Null(MasterLink.CurrentRow("SevkTipi")) = 0 Then
                        cmd.CommandText = "exec spENT_Sevk " & If0Null(MasterLink.CurrentRow("SevkID"))
                    Else
                        cmd.CommandText = "exec spENT_DepoSevk " & If0Null(MasterLink.CurrentRow("SevkID"))
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

    Private Sub cmdIptal_Click(sender As Object, e As EventArgs) Handles cmdIptal.Click
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

    Private Sub cmdSonPaketiSil_Click(sender As Object, e As EventArgs) Handles cmdSonPaketiSil.Click


        Try
            Dim MaxPaketNo As Long = 0
            For Each dr As DataRow In DetailTable2.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If If0Null(dr("PaketNo")) > MaxPaketNo Then
                        MaxPaketNo = If0Null(dr("PaketNo"))
                    End If
                End If
            Next
            If MaxPaketNo <= 0 Then Exit Sub

            For Each dr As DataRow In DetailTable3.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If If0Null(dr("PaketNo")) = MaxPaketNo Then
                        MsgBox("Son paket kullanilmis. Once satirdan siliniz!")
                        Exit Sub
                    End If
                End If
            Next

            If MsgBox("Paket no :" & MaxPaketNo & " numarali bos paketi silmek istediginizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Paket sil?") <> MsgBoxResult.Yes Then Exit Sub

            For Each dr As DataRow In DetailTable2.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If If0Null(dr("PaketNo")) = MaxPaketNo Then
                        dr.Delete()
                        Exit For
                    End If
                End If
            Next

            SonPaketNo_Goster()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'SipMiktar , TeslimMiktar , Kalan , Miktar
    Dim eskiMiktar As Double = 0
    Private Sub grSiparisDetayView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grSiparisDetayView.CellValueChanged
        Try
            If e.Column.FieldName = "Miktar" Then
                Dim TeslimMiktar As Double = grSiparisDetayView.GetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("TeslimMiktar"))
                Dim Kalan As Double = grSiparisDetayView.GetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("Kalan"))
                Dim SipMiktar As Double = grSiparisDetayView.GetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("SipMiktar"))
                Dim Miktar As Double = grSiparisDetayView.GetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("Miktar"))

                TeslimMiktar = TeslimMiktar + (e.Value - eskiMiktar)
                Kalan = Kalan - (e.Value - eskiMiktar)
                grSiparisDetayView.SetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("TeslimMiktar"), TeslimMiktar)
                grSiparisDetayView.SetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("Kalan"), Kalan)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grSiparisDetayView_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grSiparisDetayView.CellValueChanging
        Try

            If e.Column.FieldName = "Miktar" Then
                eskiMiktar = 0
                Dim sbuf As Object
                sbuf = grSiparisDetayView.GetRowCellValue(e.RowHandle, grSiparisDetayView.Columns("Miktar"))
                If Not sbuf Is Nothing Then
                    If IsNumeric(sbuf) Then
                        eskiMiktar = CDbl(sbuf)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim eskiAdet As Double = 0
    Private Sub grDetayView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grDetayView.CellValueChanged
        Try
            If e.Column.FieldName = "Adet" Then
                Dim TeslimMiktar As Double = grDetayView.GetRowCellValue(e.RowHandle, grDetayView.Columns("TeslimMiktar"))
                Dim Kalan As Double = grDetayView.GetRowCellValue(e.RowHandle, grDetayView.Columns("Kalan"))
                Dim SipMiktar As Double = grDetayView.GetRowCellValue(e.RowHandle, grDetayView.Columns("SipMiktar"))


                TeslimMiktar = TeslimMiktar + (e.Value - eskiAdet)
                Kalan = Kalan - (e.Value - eskiAdet)
                grDetayView.SetRowCellValue(e.RowHandle, grDetayView.Columns("TeslimMiktar"), TeslimMiktar)
                grDetayView.SetRowCellValue(e.RowHandle, grDetayView.Columns("Kalan"), Kalan)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grDetayView_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grDetayView.CellValueChanging
        Try

            If e.Column.FieldName = "Adet" Then
                eskiMiktar = 0
                Dim sbuf As Object
                sbuf = grDetayView.GetRowCellValue(e.RowHandle, grDetayView.Columns("Adet"))
                If Not sbuf Is Nothing Then
                    If IsNumeric(sbuf) Then
                        eskiAdet = CDbl(sbuf)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim DuzeltilecekSipDetayIDListesi As New ArrayList


    Private Sub frmSevkler_ButtonDeleteBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteBeforeClick
        Try


            For Each dr As DataRow In DetailTable3.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    DuzeltilecekSipDetayIDListesi.Add(dr("SipDetayID"))
                Else
                    dr.RejectChanges()
                    DuzeltilecekSipDetayIDListesi.Add(dr("SipDetayID"))
                    dr.Delete()
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSevkler_ButtonDeleteAfterClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteAfterClick
        Try

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = MasterTable.Connection.SqlConnection
            cmd.Transaction = MasterTable.Transaction

            For i As Integer = 0 To DuzeltilecekSipDetayIDListesi.Count - 1
                cmd.CommandText = "UPDATE SipDetayFiyatlar SET TeslimMiktar = XX.Adet FROM SipDetayFiyatlar INNER JOIN " &
                " (SELECT SDF.SipDetayID, SUM(SevkDetay.Adet) As Adet, SevkDetay.BedenKod FROM SipDetayFiyatlar SDF INNER JOIN  " &
                " SevkDetay ON SevkDetay.SipDetayID = SDF.SipDetayID AND SevkDetay.BedenKod = SDF.BedenKod INNER JOIN " &
                " Sevk On SevkDetay.SevkID = Sevk.SevkID  " &
                " WHERE  Sevk.Deleted = 0 AND Sevk.Iptal=0 AND SevkDetay.Deleted = 0   " &
                " GROUP BY SDF.SipDetayID, SevkDetay.BedenKod " &
                " ) XX ON XX.SipDetayID = SipDetayFiyatlar.SipDetayID  AND XX.BedenKod = SipDetayFiyatlar.BedenKod " &
                " WHERE SipDetayFiyatlar.SipDetayID = " & DuzeltilecekSipDetayIDListesi(i)
                cmd.ExecuteNonQuery()

                cmd.CommandText = "UPDATE SipDetay SET TeslimMiktar = ISNULL((SELECT SUM(SevkDetay.Adet)  FROM SevkDetay INNER JOIN " &
                    " Sevk ON Sevk.SevkID = SevkDetay.SevkID " &
                    " WHERE Sevk.Deleted = 0 AND Sevk.Iptal=0 AND SevkDetay.Deleted = 0 And  SevkDetay.SipDetayID=" & DuzeltilecekSipDetayIDListesi(i) & "),0)   " &
                     " WHERE Deleted = 0 And  SipDetayID=" & DuzeltilecekSipDetayIDListesi(i) & "  "
                cmd.ExecuteNonQuery()


            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
