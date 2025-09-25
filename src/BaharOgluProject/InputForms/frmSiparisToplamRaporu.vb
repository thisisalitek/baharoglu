Imports DevExpress.XtraEditors.Controls

Public Class frmSiparisToplamRaporu

    Dim bDur As Boolean = False

    Private Sub CntUrunAgaci1_SelectedChanged(Sender As Object, e As UrunAgaciChangedEventArgs) Handles CntUrunAgaci1.SelectedChanged

    End Sub

    Private Sub frmSiparisToplamRaporu_RefreshAfter_Click(sender As Object, e As ReportFormRefreshEventArgs) Handles MyBase.RefreshAfter_Click
        Listele()

    End Sub

    Private Sub Listele()
        Try
            bDur = False
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dtCari As DataTable
            cmd.Connection = AppConn.dbConn

            Dim liste = getYilAyListesi(New DateTime(SpinEdit1.Value, 1, 1), New DateTime(SpinEdit2.Value, 12, 31))


            Dim ind As Integer = 0
            While ind < liste.Count
                Dim bFound As Boolean = False
                For Each s In CheckedListBoxControl1.Items
                    If CType(s, CheckedListBoxItem).CheckState = CheckState.Checked And CType(s, CheckedListBoxItem).Value = liste(ind).Ay Then
                        bFound = True
                        Exit For
                    End If
                Next
                If bFound = False Then
                    liste.RemoveAt(ind)
                Else
                    ind += 1
                End If
            End While

            If liste.Count = 0 Then
                MsgBox("Hic tarih yok")
                Exit Sub
            End If
            Dim tarihFilter As String = ""
            For Each item In liste
                If tarihFilter <> "" Then tarihFilter &= " OR "
                tarihFilter &= "(SD.Tarih BETWEEN " & sStartDate(item.Baslangic) & " AND " & sEndDate(item.Bitis) & ") "
            Next
            'MsgBox(tarihFilter)
            'Exit Sub
            cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("@FormDate1", dtFormDate1.DateTime)
            'cmd.Parameters.AddWithValue("@FormDate2", dtFormDate2.DateTime)
            cmd.CommandText = "SELECT S.CariKod, (SELECT TOP 1 CariUnvan FROM Siparis WHERE CariKod = S.CariKod ORDER BY SiparisID DESC) as CariUnvan, 0 as TSiparis FROM Siparis S INNER JOIN
                SipDetay SD ON S.SiparisID= SD.SiparisID 
                WHERE S.Deleted=0 AND S.Iptal=0 AND SD.Deleted=0  AND (" & tarihFilter & ")
                GROUP BY S.CariKod "
            da = New SqlClient.SqlDataAdapter(cmd)
            dtCari = New DataTable()
            da.Fill(dtCari)


            For Each item In liste
                Dim dcAdet As New DataColumn("A" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Int32"))
                dtCari.Columns.Add(dcAdet)

                If (chkShowTutar.Checked) Then
                    Dim dcTutar As New DataColumn("T" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Double"))
                    dtCari.Columns.Add(dcTutar)
                End If
                If (chkIskontolariGoster.Checked) Then
                    Dim dc As New DataColumn("SezIsk" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Double"))
                    dtCari.Columns.Add(dc)
                    Dim dc2 As New DataColumn("NakIsk" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Double"))
                    dtCari.Columns.Add(dc2)
                End If
            Next
            If (chkAdetFarklariGoster.Checked) Then
                For Each item In liste
                    For Each item2 In liste
                        If (item2.Yil > item.Yil And item2.Ay = item.Ay) Then
                            If (dtCari.Columns.Contains("Fark." & item.Ay.ToString("00")) = False) Then
                                Dim dc As New DataColumn("Fark." & item.Ay.ToString("00"), System.Type.GetType("System.Int32"))
                                dtCari.Columns.Add(dc)
                                Dim dc2 As New DataColumn("Durum." & item.Ay.ToString("00"), System.Type.GetType("System.String"))
                                dtCari.Columns.Add(dc2)
                            End If
                        End If
                    Next
                Next

            End If
            GridView1.Columns.Clear()
            GridControl1.DataSource = dtCari
            GridView1.PopulateColumns()
            GridView1.BestFitColumns()

            If dtCari.Rows.Count = 0 Then Exit Sub
            bDur = False
            btnDur.Visible = True
            ProgressBarControl1.Visible = True
            ProgressBarControl1.Properties.Maximum = dtCari.Rows.Count
            btnRefresh.Enabled = False
            'LoadingShow("Hesaplamalar yapiliyor. Bekleyiniz...")
            For i = 0 To dtCari.Rows.Count - 1
                ProgressBarControl1.Position = i + 1

                For Each item In liste
                    Dim sonuc As Sonuc = getCariRapor(dtCari.Rows(i).Item("CariKod"), item.Baslangic, item.Bitis)

                    dtCari.Rows(i).Item("A" & item.Yil & "." & item.Ay.ToString("00")) = sonuc.TAdet
                    dtCari.Rows(i).Item("TSiparis") = sonuc.TSiparis

                    If (chkShowTutar.Checked) Then
                        dtCari.Rows(i).Item("T" & item.Yil & "." & item.Ay.ToString("00")) = sonuc.TTutar
                    End If
                    If (chkIskontolariGoster.Checked) Then
                        dtCari.Rows(i).Item("SezIsk" & item.Yil & "." & item.Ay.ToString("00")) = sonuc.TSezonIskTutar
                        dtCari.Rows(i).Item("NakIsk" & item.Yil & "." & item.Ay.ToString("00")) = sonuc.TNakitIskTutar
                    End If

                    Application.DoEvents()
                    If bDur Then GoTo Cikis
                Next
                If chkAdetFarklariGoster.Checked Then
                    For Each item In liste
                        For Each item2 In liste
                            If (item2.Yil > item.Yil And item2.Ay = item.Ay) Then
                                Dim yeniAdet As Long = dtCari.Rows(i).Item("A" & item2.Yil & "." & item2.Ay.ToString("00"))
                                Dim eskiAdet As Long = dtCari.Rows(i).Item("A" & item.Yil & "." & item.Ay.ToString("00"))
                                dtCari.Rows(i).Item("Fark." & item.Ay.ToString("00")) = yeniAdet - eskiAdet
                                dtCari.Rows(i).Item("Durum." & item.Ay.ToString("00")) = ""
                                If eskiAdet = 0 And yeniAdet > 0 Then
                                    dtCari.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Yeni"
                                ElseIf eskiAdet > 0 And yeniAdet = 0 Then
                                    dtCari.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Gelmemiş"
                                ElseIf eskiAdet = 0 And yeniAdet = 0 Then
                                    dtCari.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "-"
                                ElseIf eskiAdet > 0 And yeniAdet > 0 And eskiAdet > yeniAdet Then
                                    dtCari.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Azalmış"
                                ElseIf eskiAdet > 0 And yeniAdet > 0 And eskiAdet < yeniAdet Then
                                    dtCari.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Artmış"
                                End If

                            End If
                        Next
                    Next
                End If
            Next
            GridView1.BestFitColumns()

            MsgBox("bitti")
        Catch ex As Exception
            'LoadingHide()

            MsgBox(ex.Message)
        End Try
Cikis:
        bDur = False
        btnDur.Visible = False
        'LoadingHide()
        ProgressBarControl1.Visible = False
        btnRefresh.Enabled = True
    End Sub

    Private Sub Listele_eski()

    End Sub

    Function getCariRapor(CariKod As String, Tarih1 As Date, Tarih2 As Date) As Sonuc
        Dim sonuc As New Sonuc(0, 0, 0, 0, 0)
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As DataTable

        cmd.Connection = AppConn.dbConn
        cmd.CommandTimeout = 60 * 10

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@CariKod", CariKod)
        cmd.Parameters.AddWithValue("@Tarih1", Tarih1)
        cmd.Parameters.AddWithValue("@Tarih2", Tarih2)
        cmd.Parameters.AddWithValue("@KategoriKod", CntUrunAgaci1.aktifKategori.KategoriKod & "%")
        cmd.CommandText = "SELECT COUNT(*) as TSiparis, SUM(SD.Miktar) as TAdet, SUM(SD.Tutar * CASE S.DovizKuru WHEN 0 THEN 1 ELSE S.DovizKuru END) as TTutar, SUM(IskontoTutar) as TIskontoTutar,SUM(NakitIskontoTutar) as TNakitIskontoTutar FROM SipDetay SD  INNER JOIN
            Siparis S  ON S.SiparisID=SD.SiparisID INNER JOIN
            Kategoriler K ON SD.KategoriID = K.KategoriID
            WHERE S.Deleted=0 AND S.Iptal = 0 AND SD.Deleted=0 AND S.CariKod = @CariKod AND SD.Tarih BETWEEN @Tarih1 AND @Tarih2 
        --AND K.KategoriKod Like @KategoriKod
        "
        da = New SqlClient.SqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            sonuc.TAdet = Math.Round(If0Null(dt.Rows(0).Item("TAdet")))
            sonuc.TTutar = Math.Round(If0Null(dt.Rows(0).Item("TTutar")), 2)
            sonuc.TSezonIskTutar = Math.Round(If0Null(dt.Rows(0).Item("TIskontoTutar")), 2)
            sonuc.TNakitIskTutar = Math.Round(If0Null(dt.Rows(0).Item("TNakitIskontoTutar")), 2)
            sonuc.TSiparis = If0Null(dt.Rows(0).Item("TSiparis"))
        End If
        dt.Dispose()
        da.Dispose()
        cmd.Dispose()

        Return sonuc

    End Function

    Class Sonuc
        Public TAdet As Double
        Public TTutar As Double
        Public TSezonIskTutar As Double
        Public TNakitIskTutar As Double
        Public TSiparis As Long

        Public Sub New(_TAdet As Double, _TTutar As Double, _TSezonIskTutar As Double, _TNakitIskTutar As Double, _TSiparis As Long)
            Me.TAdet = _TAdet
            Me.TTutar = _TTutar
            Me.TSezonIskTutar = _TSezonIskTutar
            Me.TNakitIskTutar = _TNakitIskTutar
            Me.TSiparis = _TSiparis
        End Sub
    End Class

    Private Sub btnDur_Click(sender As Object, e As EventArgs) Handles btnDur.Click
        bDur = True
        Application.DoEvents()
    End Sub

    Private Sub chkTumAylar_CheckedChanged(sender As Object, e As EventArgs) Handles chkTumAylar.CheckedChanged
        If chkTumAylar.Checked Then
            For Each chk In CheckedListBoxControl1.Items
                CType(chk, CheckedListBoxItem).CheckState = CheckState.Checked
            Next
        Else

            For Each chk In CheckedListBoxControl1.Items
                If Today.Month = CType(chk, CheckedListBoxItem).Value Then
                    CType(chk, CheckedListBoxItem).CheckState = CheckState.Checked
                Else
                    CType(chk, CheckedListBoxItem).CheckState = CheckState.Unchecked
                End If

            Next
        End If
    End Sub

    Private Sub frmSiparisToplamRaporu_Load(sender As Object, e As EventArgs) Handles Me.Load
        SpinEdit1.Value = Today.Year - 1
        SpinEdit2.Value = Today.Year

        chkTumAylar_CheckedChanged(Nothing, Nothing)

    End Sub
End Class


