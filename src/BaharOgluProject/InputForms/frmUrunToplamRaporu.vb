Imports DevExpress.XtraEditors.Controls

Public Class frmUrunToplamRaporu

    Dim bDur As Boolean = False

    Private Sub CntUrunAgaci1_SelectedChanged(Sender As Object, e As UrunAgaciChangedEventArgs) Handles CntUrunAgaci1.SelectedChanged
        Try
            Dim filterCondition As String = ""


            GridView1.ActiveFilter.Clear()

            GridView1.ActiveFilter.Add(GridView1.Columns("KategoriKod"), New DevExpress.XtraGrid.Columns.ColumnFilterInfo("StartsWith([KategoriKod], '" & CntUrunAgaci1.aktifKategori.KategoriKod & "')"))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmUrunToplamRaporu_RefreshAfter_Click(sender As Object, e As ReportFormRefreshEventArgs) Handles MyBase.RefreshAfter_Click
        Listele()

    End Sub

    Private Sub Listele()
        Try
            bDur = False
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dtUrun As DataTable
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
                If RadioGroup1.SelectedIndex = 0 Then
                    tarihFilter &= "(Sevk.Tarih BETWEEN " & sStartDate(item.Baslangic) & " AND " & sEndDate(item.Bitis) & ") "
                Else
                    tarihFilter &= "(SD.Tarih BETWEEN " & sStartDate(item.Baslangic) & " AND " & sEndDate(item.Bitis) & ") "
                End If
            Next
            'MsgBox(tarihFilter)
            'Exit Sub
            cmd.Parameters.Clear()
            cmd.CommandTimeout = 600

            If RadioGroup1.SelectedIndex = 0 Then
                'cmd.CommandText = "SELECT SevkDetay.SipDetayID FROM SevkDetay INNER JOIN 
                '    Sevk ON Sevk.SevkID=SevkDetay.SevkID 
                '    WHERE Sevk.Deleted=0 AND SevkDetay.Deleted=0 AND (" & tarihFilter & ") 
                '    GROUP BY SevkDetay.SipDetayID
                ' "
                'da = New SqlClient.SqlDataAdapter(cmd)
                'Dim dtSD As New DataTable
                'Dim filterSD As String = ""
                'da.Fill(dtSD)
                'If dtSD.Rows.Count = 0 Then
                '    filterSD = " 1=0 "
                'Else
                '    filterSD = "SD.SipDetayID IN ("
                '    For i = 0 To dtSD.Rows.Count - 1
                '        filterSD &= dtSD.Rows(i)("SipDetayID")
                '        If i < dtSD.Rows.Count - 1 Then filterSD &= ", "

                '    Next
                '    filterSD &= ")"
                'End If
                'cmd.CommandText = "SELECT K.KategoriID, K.KategoriKod,KategoriIsim, COUNT(*) as TSiparis FROM Siparis S INNER JOIN
                'SipDetay SD ON S.SiparisID= SD.SiparisID INNER JOIN
                'Kategoriler K ON SD.KategoriID=K.KategoriID
                'WHERE S.Deleted=0 AND S.Iptal=0 AND SD.Deleted=0 AND " & filterSD & " 
                'GROUP BY K.KategoriID, K.KategoriKod,KategoriIsim "

                cmd.CommandText = "Select K.KategoriID, K.KategoriKod,KategoriIsim, COUNT(*) As TSiparis FROM Siparis S INNER JOIN
                SipDetay SD ON S.SiparisID= SD.SiparisID INNER JOIN
                Kategoriler K ON SD.KategoriID=K.KategoriID
                WHERE S.Deleted=0 AND S.Iptal=0 AND SD.Deleted=0 AND  SD.SipDetayID IN (SELECT SevkDetay.SipDetayID FROM SevkDetay INNER JOIN Sevk ON Sevk.SevkID=SevkDetay.SevkID WHERE Sevk.Deleted=0 AND Sevk.Onayli=1 AND Sevk.Iptal=0 AND SevkDetay.Deleted=0 AND  SevkDetay.sth_RECno>0 AND (" & tarihFilter & ") GROUP BY SevkDetay.SipDetayID )
                GROUP BY K.KategoriID, K.KategoriKod,KategoriIsim "
            Else
                cmd.CommandText = "SELECT K.KategoriID, K.KategoriKod,KategoriIsim, COUNT(*) as TSiparis FROM Siparis S INNER JOIN
                SipDetay SD ON S.SiparisID= SD.SiparisID INNER JOIN
                Kategoriler K ON SD.KategoriID=K.KategoriID
                WHERE S.Deleted=0 AND S.Iptal=0 AND SD.Deleted=0 AND  (" & tarihFilter & ")
                GROUP BY K.KategoriID, K.KategoriKod,KategoriIsim "
            End If

            da = New SqlClient.SqlDataAdapter(cmd)
            dtUrun = New DataTable()
            da.Fill(dtUrun)


            For Each item In liste
                Dim dcAdet As New DataColumn("A" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Int32"))
                dcAdet.DefaultValue = 0
                dtUrun.Columns.Add(dcAdet)
                If (chkShowFiyat.Checked) Then
                    Dim dcFiyat As New DataColumn("F" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Double"))
                    dcFiyat.DefaultValue = 0
                    dtUrun.Columns.Add(dcFiyat)
                End If
                If (chkShowTutar.Checked) Then
                    Dim dcTutar As New DataColumn("T" & item.Yil & "." & item.Ay.ToString("00"), System.Type.GetType("System.Double"))
                    dcTutar.DefaultValue = 0
                    dtUrun.Columns.Add(dcTutar)
                End If
            Next

            If (chkAdetFarklariGoster.Checked) Then
                For Each item In liste
                    For Each item2 In liste
                        If (item2.Yil > item.Yil And item2.Ay = item.Ay) Then
                            If (dtUrun.Columns.Contains("Fark." & item.Ay.ToString("00")) = False) Then
                                Dim dc As New DataColumn("Fark." & item.Ay.ToString("00"), System.Type.GetType("System.Int32"))
                                dc.DefaultValue = 0
                                dtUrun.Columns.Add(dc)
                                Dim dc2 As New DataColumn("Durum." & item.Ay.ToString("00"), System.Type.GetType("System.String"))
                                dc2.DefaultValue = 0
                                dtUrun.Columns.Add(dc2)
                            End If
                        End If
                    Next
                Next

            End If
            GridView1.Columns.Clear()
            GridControl1.DataSource = dtUrun
            GridView1.PopulateColumns()
            GridView1.BestFitColumns()
            GridView1.Columns("KategoriID").Visible = False
            GridView1.Columns("KategoriKod").SummaryItem.FieldName = "KategoriKod"
            GridView1.Columns("KategoriKod").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            GridView1.Columns("KategoriKod").SummaryItem.DisplayFormat = "T:{0:#,##0}"
            GridView1.Columns("TSiparis").SummaryItem.FieldName = "TSiparis"
            GridView1.Columns("TSiparis").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("TSiparis").SummaryItem.DisplayFormat = "{0:#,##0}"

            For Each item In liste

                GridView1.Columns("A" & item.Yil & "." & item.Ay.ToString("00")).SummaryItem.FieldName = "A" & item.Yil & "." & item.Ay.ToString("00")
                GridView1.Columns("A" & item.Yil & "." & item.Ay.ToString("00")).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns("A" & item.Yil & "." & item.Ay.ToString("00")).SummaryItem.DisplayFormat = "{0:#,##0.00}"


                If (chkShowTutar.Checked) Then
                    GridView1.Columns("T" & item.Yil & "." & item.Ay.ToString("00")).SummaryItem.FieldName = "T" & item.Yil & "." & item.Ay.ToString("00")
                    GridView1.Columns("T" & item.Yil & "." & item.Ay.ToString("00")).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    GridView1.Columns("T" & item.Yil & "." & item.Ay.ToString("00")).SummaryItem.DisplayFormat = "{0:#,##0.00}"
                End If
                If chkAdetFarklariGoster.Checked And dtUrun.Columns.Contains("Fark." & item.Ay.ToString("00")) Then

                    GridView1.Columns("Fark." & item.Ay.ToString("00")).SummaryItem.FieldName = "Fark." & item.Ay.ToString("00")
                    GridView1.Columns("Fark." & item.Ay.ToString("00")).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    GridView1.Columns("Fark." & item.Ay.ToString("00")).SummaryItem.DisplayFormat = "{0:#,##0.00}"

                End If
            Next
            If dtUrun.Rows.Count = 0 Then Exit Sub
            bDur = False
            btnDur.Visible = True
            ProgressBarControl1.Visible = True
            Dim aySiraNo As Integer = 0

            lblProgress.Text = aySiraNo.ToString() & "/" & liste.Count.ToString()

            panelFormTop.Visible = True

            btnRefresh.Enabled = False

            For Each item In liste
                Dim sonuc As DataTable = getUrunRapor(item.Baslangic, item.Bitis)
                ProgressBarControl1.Properties.Maximum = dtUrun.Rows.Count
                ProgressBarControl1.Position = 0
                aySiraNo += 1
                lblProgress.Text = aySiraNo.ToString() & "/" & liste.Count.ToString()
                For Each dr As DataRow In dtUrun.Rows
                    For Each dr2 As DataRow In sonuc.Rows
                        If (dr("KategoriID") = dr2("KategoriID")) Then
                            dr("A" & item.Yil & "." & item.Ay.ToString("00")) = dr2("TAdet")
                            If chkShowTutar.Checked Then
                                dr("T" & item.Yil & "." & item.Ay.ToString("00")) = Math.Round(dr2("TTutar"), 2)
                            End If
                            If chkShowFiyat.Checked Then
                                dr("F" & item.Yil & "." & item.Ay.ToString("00")) = 0
                                If (If0Null(dr2("TAdet")) > 0) Then
                                    dr("F" & item.Yil & "." & item.Ay.ToString("00")) = Math.Round(If0Null(dr2("TTutar")) / If0Null(dr2("TAdet")), 2)
                                End If
                            End If
                            Exit For
                        End If
                        Application.DoEvents()
                        If bDur Then GoTo Cikis
                    Next
                    ProgressBarControl1.Position += 1
                    Application.DoEvents()
                Next

                Application.DoEvents()

            Next
            For i = 0 To dtUrun.Rows.Count - 1
                ProgressBarControl1.Position = i + 1


                If chkAdetFarklariGoster.Checked Then
                    For Each item In liste
                        For Each item2 In liste
                            If (item2.Yil > item.Yil And item2.Ay = item.Ay) Then
                                Dim yeniAdet As Long = If0Null(dtUrun.Rows(i).Item("A" & item2.Yil & "." & item2.Ay.ToString("00")))
                                Dim eskiAdet As Long = If0Null(dtUrun.Rows(i).Item("A" & item.Yil & "." & item.Ay.ToString("00")))
                                dtUrun.Rows(i).Item("Fark." & item.Ay.ToString("00")) = yeniAdet - eskiAdet
                                dtUrun.Rows(i).Item("Durum." & item.Ay.ToString("00")) = ""
                                If eskiAdet = 0 And yeniAdet > 0 Then
                                    dtUrun.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Yeni"
                                ElseIf eskiAdet > 0 And yeniAdet = 0 Then
                                    dtUrun.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Gelmemiş"
                                ElseIf eskiAdet = 0 And yeniAdet = 0 Then
                                    dtUrun.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "-"
                                ElseIf eskiAdet > 0 And yeniAdet > 0 And eskiAdet > yeniAdet Then
                                    dtUrun.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Azalmış"
                                ElseIf eskiAdet > 0 And yeniAdet > 0 And eskiAdet < yeniAdet Then
                                    dtUrun.Rows(i).Item("Durum." & item.Ay.ToString("00")) = "Artmış"
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
        panelFormTop.Visible = False

        btnRefresh.Enabled = True
    End Sub

    Private Sub Listele_eski()

    End Sub


    Function getUrunRapor(Tarih1 As Date, Tarih2 As Date) As DataTable
        Dim sonuc As New Sonuc(0, 0, 0, 0, 0, 0)
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As DataTable

        cmd.Connection = AppConn.dbConn
        cmd.CommandTimeout = 60 * 10

        cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("@KategoriID", KategoriID)
        cmd.Parameters.AddWithValue("@Tarih1", Tarih1)
        cmd.Parameters.AddWithValue("@Tarih2", Tarih2)
        'cmd.Parameters.AddWithValue("@KategoriKod", CntUrunAgaci1.aktifKategori.KategoriKod & "%")
        If RadioGroup1.SelectedIndex = 0 Then
            'cmd.CommandText = "SELECT SevkDetay.SipDetayID FROM SevkDetay INNER JOIN 
            '        Sevk ON Sevk.SevkID=SevkDetay.SevkID 
            '        WHERE Sevk.Deleted=0 AND SevkDetay.Deleted=0 AND Sevk.Tarih BETWEEN @Tarih1 AND @Tarih2  
            '        GROUP BY SevkDetay.SipDetayID
            '     "
            'da = New SqlClient.SqlDataAdapter(cmd)
            'Dim dtSD As New DataTable
            'Dim filterSD As String = ""
            'da.Fill(dtSD)
            'If dtSD.Rows.Count = 0 Then
            '    filterSD = " 1=0 "
            'Else
            '    filterSD = "SD.SipDetayID IN ("
            '    For i = 0 To dtSD.Rows.Count - 1
            '        filterSD &= dtSD.Rows(i)("SipDetayID")
            '        If i < dtSD.Rows.Count - 1 Then filterSD &= ", "

            '    Next
            '    filterSD &= ")"
            'End If
            'cmd.CommandText = "SELECT SD.KategoriID, SUM(SD.TeslimMiktar) as TAdet, SUM(SD.Tutar * CASE S.DovizKuru WHEN 0 THEN 1 ELSE S.DovizKuru END) as TTutar, SUM(SD.Iskonto) as TIskontoTutar,SUM(NakitIskontoTutar) as TNakitIskontoTutar FROM SipDetay SD  INNER JOIN
            'Siparis S  ON S.SiparisID=SD.SiparisID INNER JOIN
            '    Kategoriler K ON SD.KategoriID=K.KategoriID 
            'WHERE S.Deleted=0 AND S.Iptal = 0 AND SD.Deleted=0 AND " & filterSD & "
            ' GROUP BY SD.KategoriID  "

            cmd.CommandText = "SELECT SD.KategoriID, SUM(X.SevkAdet) as TAdet, SUM((SD.Fiyat - SD.Fiyat*SD.Iskonto/100 - (SD.Fiyat - SD.Fiyat*SD.Iskonto/100)*SD.NakitIskonto/100 ) * X.SevkAdet * CASE S.DovizKuru WHEN 0 THEN 1 ELSE S.DovizKuru END) as TTutar FROM SipDetay SD  INNER JOIN
            Siparis S  ON S.SiparisID=SD.SiparisID INNER JOIN
                Kategoriler K ON SD.KategoriID=K.KategoriID INNER JOIN
                (
                    SELECT SevkDetay.SipDetayID,SUM(SevkDetay.Adet) as SevkAdet FROM SevkDetay INNER JOIN 
                    Sevk ON Sevk.SevkID=SevkDetay.SevkID 
                    WHERE Sevk.Deleted=0 AND SevkDetay.Deleted=0 AND Sevk.Onayli=1 AND Sevk.Iptal=0 
                    AND SevkDetay.sth_RECno>0 AND Sevk.Tarih BETWEEN @Tarih1 AND @Tarih2 
                    GROUP BY SevkDetay.SipDetayID
                ) X ON X.SipDetayID=SD.SipDetayID
            WHERE S.Deleted=0 AND S.Iptal = 0 AND SD.Deleted=0 
             GROUP BY SD.KategoriID  "
        Else
            cmd.CommandText = "SELECT SD.KategoriID, SUM(SD.Miktar) as TAdet, SUM(SD.Tutar * CASE S.DovizKuru WHEN 0 THEN 1 ELSE S.DovizKuru END) as TTutar, SUM(IskontoTutar) as TIskontoTutar,SUM(NakitIskontoTutar) as TNakitIskontoTutar FROM SipDetay SD  INNER JOIN
            Siparis S  ON S.SiparisID=SD.SiparisID INNER JOIN
                Kategoriler K ON SD.KategoriID=K.KategoriID
            WHERE S.Deleted=0 AND S.Iptal = 0 AND SD.Deleted=0 AND SD.Tarih BETWEEN @Tarih1 AND @Tarih2 
             GROUP BY SD.KategoriID  "
        End If
        da = New SqlClient.SqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)

        'If (dt.Rows.Count > 0) Then
        '    sonuc.TAdet = Math.Round(If0Null(dt.Rows(0).Item("TAdet")))
        '    If If0Null(dt.Rows(0).Item("TAdet")) > 0 Then
        '        sonuc.Fiyat = Math.Round(If0Null(dt.Rows(0).Item("TTutar")) / If0Null(dt.Rows(0).Item("TAdet")), 2)
        '    End If

        '    sonuc.TTutar = Math.Round(If0Null(dt.Rows(0).Item("TTutar")), 2)
        '    sonuc.TSezonIskTutar = Math.Round(If0Null(dt.Rows(0).Item("TIskontoTutar")), 2)
        '    sonuc.TNakitIskTutar = Math.Round(If0Null(dt.Rows(0).Item("TNakitIskontoTutar")), 2)
        '    sonuc.KategoriID = If0Null(dt.Rows(0).Item("KategoriID"))
        'End If

        da.Dispose()
        cmd.Dispose()

        Return dt

    End Function

    Class Sonuc
        Public TAdet As Double
        Public TTutar As Double
        Public Fiyat As Double
        Public TSezonIskTutar As Double
        Public TNakitIskTutar As Double
        Public TSiparis As Long
        Public KategoriID As Long

        Public Sub New(_TAdet As Double, _Fiyat As Double, _TTutar As Double, _TSezonIskTutar As Double, _TNakitIskTutar As Double, _TSiparis As Long)
            Me.TAdet = _TAdet
            Me.TTutar = _TTutar
            Me.Fiyat = _Fiyat
            Me.TSezonIskTutar = _TSezonIskTutar
            Me.TNakitIskTutar = _TNakitIskTutar
            Me.TSiparis = _TSiparis
            Me.KategoriID = 0

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

    Private Sub frmUrunToplamRaporu_Load(sender As Object, e As EventArgs) Handles Me.Load
        SpinEdit1.Value = Today.Year - 1
        SpinEdit2.Value = Today.Year

        chkTumAylar_CheckedChanged(Nothing, Nothing)

    End Sub
End Class


