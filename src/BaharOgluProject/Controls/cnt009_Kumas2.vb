Public Class cnt009_Kumas2
    Dim ParcaSayisi As Integer = 0
    Dim bNoAction As Boolean = False

    Private Sub cnt009_Kumas2_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try
            Me.Width = 585
            Me.Height = 505
            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)

            tbKumasKatalog.Connection = Me.SqlConn
            OpenTable(tbKumasKatalog)

            tbKumas.Connection = Me.SqlConn
            OpenTable(tbKumas)

            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)
            'ParcaSayisi = NeoTable1.Rows.Count
            'bNoAction = True
            'txtParcaSayisi.EditValue = NeoTable1.Rows.Count
            'bNoAction = False
            'Dim dtParca As DataTable
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dtParca As New DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT ParcaNo , ParcaIsmi FROM KategoriParam_009_Kumas2 " & _
                " WHERE Deleted = 0 AND KategoriParamID = " & KategoriParamID & " " & _
                " GROUP BY ParcaNo , ParcaIsmi " & _
                " ORDER BY ParcaNo "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dtParca)
            ParcaSayisi = dtParca.Rows.Count
            bNoAction = True
            txtParcaSayisi.EditValue = dtParca.Rows.Count
            bNoAction = False
            refresh_panelParcalar()

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable2)

            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("KategoriParamID") = KategoriParamID

                NeoTable2.Rows.Add(newdr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub cnt009_Kumas2_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try
            Me.Width = 431
            Me.Height = 240
            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)

            tbKumasKatalog.Connection = Me.SqlConn
            OpenTable(tbKumasKatalog)

            tbKumas.Connection = Me.SqlConn
            OpenTable(tbKumas)

            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable2)

            NeoTable3.Connection = Me.SqlConn
            NeoTable3.SelectCommand.CommandText &= " AND KategoriParamID>0 AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable3)


            NeoTable4.Connection = Me.SqlConn
            NeoTable4.SelectCommand.CommandText &= " AND KategoriParamID>0 AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable4)

            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("KategoriParamID") = KategoriParamID

                NeoTable2.Rows.Add(newdr)
            End If


            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dtParca As New DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT ParcaNo , ParcaIsmi,KategoriParamID FROM KategoriParam_009_Kumas2 " & _
                " WHERE Deleted = 0 AND KategoriParamID = " & KategoriParamID & " " & _
                " GROUP BY ParcaNo , ParcaIsmi,KategoriParamID " & _
                " ORDER BY ParcaNo  "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dtParca)
            ParcaSayisi = dtParca.Rows.Count

            For Each dr As DataRow In dtParca.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    Dim bFound As Boolean = False
                    For Each dr2 As DataRow In NeoTable3.Rows
                        If dr2.RowState <> DataRowState.Deleted And dr2.RowState <> DataRowState.Detached Then
                            If If0Null(dr2("SourceID")) = If0Null(dr("ParcaNo")) Then
                                bFound = True
                                Exit For
                            End If
                        End If
                    Next

                    If bFound = False Then
                        Dim newdr As DataRow = NeoTable3.NewRow
                        newdr("SourceID") = dr("ParcaNo")
                        newdr("KategoriParamID") = dr("KategoriParamID")
                        newdr("SipDetayParamID") = SipDetayParamID
                        newdr("ParcaIsmi") = dr("ParcaIsmi")
                        newdr("KumasKatalogID") = 0
                        newdr("KumasID") = 0
                        newdr("RenkID") = 0
                        NeoTable3.Rows.Add(newdr)

                    End If
                End If
            Next

            If NeoTable4.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable4.NewRow
                newdr("KategoriParamID") = KategoriParamID
                With NeoTable2.Rows(0)
                    newdr("SolOnCep") = .Item("SolOnCep")
                    newdr("SagOnCep") = .Item("SagOnCep")
                    newdr("SolArkaCep") = .Item("SolArkaCep")
                    newdr("SagArkaCep") = .Item("SagArkaCep")
                    newdr("GizliCep") = .Item("GizliCep")
                    newdr("CepKumasArtis") = .Item("CepKumasArtis")
                    If If0Null(.Item("OverlokNakis")) = 0 Or If0Null(.Item("OverlokNakis")) = 2 Then
                        newdr("OverlokNakis") = 0
                    ElseIf If0Null(.Item("OverlokNakis")) = 1 Then
                        newdr("OverlokNakis") = 1
                    End If

                    newdr("FarkliKumas") = .Item("FarkliKumas")
                    newdr("Biye") = .Item("Biye")
                    newdr("BiyeDeger") = .Item("BiyeDeger")
                End With

                NeoTable4.Rows.Add(newdr)
            End If

            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MasraflariUygula()
        Try
            MasrafListesi.Clear()
            MasrafListesi.Add(New clsMasraf("012", "Farkli Kumas", False, 0))
            MasrafListesi.Add(New clsMasraf("011", "Cep Farki(Sol On)", False, 0))
            MasrafListesi.Add(New clsMasraf("011", "Cep Farki(Sag On)", False, 0))
            MasrafListesi.Add(New clsMasraf("011", "Cep Farki(Sol Arka)", False, 0))
            MasrafListesi.Add(New clsMasraf("011", "Cep Farki(Sag Arka)", False, 0))
            MasrafListesi.Add(New clsMasraf("011", "Cep Farki(Gizli Cep)", False, 0))


            If NeoTable4.Rows.Count > 0 Then
                CType(MasrafListesi.Item(0), clsMasraf).bUygula = False
                CType(MasrafListesi.Item(1), clsMasraf).bUygula = False

                With NeoTable4.Rows(0)
                    If If0Null(.Item("SolOnCep")) <> 0 Then
                        CType(MasrafListesi.Item(1), clsMasraf).bUygula = True
                    End If
                    If If0Null(.Item("SagOnCep")) <> 0 Then
                        CType(MasrafListesi.Item(2), clsMasraf).bUygula = True
                    End If
                    If If0Null(.Item("SolArkaCep")) <> 0 Then
                        CType(MasrafListesi.Item(3), clsMasraf).bUygula = True
                    End If
                    If If0Null(.Item("SagArkaCep")) <> 0 Then
                        CType(MasrafListesi.Item(4), clsMasraf).bUygula = True
                    End If
                    If If0Null(.Item("GizliCep")) <> 0 Then
                        CType(MasrafListesi.Item(5), clsMasraf).bUygula = True
                    End If
                    'Or If0Null(.Item("SagOnCep")) <> 0 Or If0Null(.Item("")) <> 0 Or If0Null(.Item("")) <> 0 Or If0Null(.Item("")) <> 0 Then

                    'End If

                    'If If0Null(.Item("SolOnCep")) <> 0 Or If0Null(.Item("SagOnCep")) <> 0 Or If0Null(.Item("SolArkaCep")) <> 0 Or If0Null(.Item("SagArkaCep")) <> 0 Or If0Null(.Item("GizliCep")) <> 0 Then
                    '    CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
                    'End If
                    If If0Null(.Item("FarkliKumas")) <> 0 Then
                        CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
                    End If
                End With
            End If

            For Each dr As DataRow In NeoTable3.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("KumasID")) > 0 Then
                        Dim drKumas As DataRow = tbKumas.Rows.Find(If0Null(dr("KumasID")))
                        If Not drKumas Is Nothing Then
                            If If0Null(drKumas("Fiyat")) > 0 Then
                                Dim bFound As Boolean = False
                                For i As Integer = 0 To MasrafListesi.Count - 1
                                    If CType(MasrafListesi(i), clsMasraf).MasrafIsmi = IfNull(drKumas("KumasIsmi"), "") Then
                                        bFound = True
                                        Exit For
                                    End If
                                Next
                                If bFound = False Then
                                    MasrafListesi.Add(New clsMasraf("S02", IfNull(drKumas("KumasIsmi"), "") & " KUMAÅ FARKI", True, If0Null(drKumas("Fiyat"))))
                                End If

                            End If

                        End If

                    End If

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub refresh_panelParcalar()
        Try
            Do While panelParcalar.Controls.Count > 0
                panelParcalar.Controls(0).Dispose()
            Loop
            If MasterTable.Rows.Count <= 0 Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim BedenDizi() As String
            Dim data1 As New DataTable
            Dim dtKategori As New DataTable
            Dim bKendiFiyatBedenKullan As Boolean = False
            Dim UstKategoriID As Long = 0

            'Dim dtParca As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT * FROM Kategoriler WHERE KategoriID=" & Me.KategoriID

            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dtKategori)
            If dtKategori.Rows.Count > 0 Then
                If dtKategori.Rows(0)("KendiFiyatBedenKullan") = 1 Then
                    bKendiFiyatBedenKullan = True
                    UstKategoriID = dtKategori.Rows(0)("UstKategoriID")
                End If
            Else


                End If

            If bKendiFiyatBedenKullan = True Then
                cmd.CommandText = "SELECT   DISTINCT  KategoriFiyat.BedenNo, KategoriFiyat.BedenKod, KategoriFiyat.Fiyat, KategoriFiyat.BazBedenMi " &
              "FROM         KategoriFiyat INNER JOIN " &
              "                      Kategoriler ON KategoriFiyat.KategoriID = Kategoriler.KategoriID " &
              "WHERE     (KategoriFiyat.Deleted = 0) AND (Kategoriler.Deleted = 0) AND RTRIM(LTRIM(KategoriFiyat.BedenKod))<>'' AND (Kategoriler.KategoriID = " & If0Null(MasterTable.Rows(0).Item("KategoriID")) & ") " &
              "ORDER BY KategoriFiyat.BedenNo "
            Else
                cmd.CommandText = "SELECT   DISTINCT  KategoriFiyat.BedenNo, KategoriFiyat.BedenKod, KategoriFiyat.Fiyat, KategoriFiyat.BazBedenMi " &
              "FROM         KategoriFiyat INNER JOIN " &
              "                      Kategoriler ON KategoriFiyat.KategoriID = Kategoriler.UstKategoriID " &
              "WHERE     (KategoriFiyat.Deleted = 0) AND (Kategoriler.Deleted = 0) AND RTRIM(LTRIM(KategoriFiyat.BedenKod))<>'' AND (Kategoriler.KategoriID = " & If0Null(MasterTable.Rows(0).Item("KategoriID")) & ") " &
              "ORDER BY KategoriFiyat.BedenNo "
            End If



            'KendiFiyatBedenKullan
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                dt.Dispose()
                da.Dispose()
                cmd.Dispose()
                Exit Sub
            End If
            ReDim BedenDizi(dt.Rows.Count - 1)
            data1.Columns.Add(New DataColumn("nID", GetType(Long)))
            data1.Columns.Add(New DataColumn("ParcaIsmi", GetType(String)))
            For i = 0 To dt.Rows.Count - 1
                If data1.Columns.Contains(Trim(IfNull(dt.Rows(i).Item("BedenKod"), ""))) = False Then
                    BedenDizi(i) = Trim(IfNull(dt.Rows(i).Item("BedenKod"), ""))
                    data1.Columns.Add(New DataColumn(Trim(IfNull(dt.Rows(i).Item("BedenKod"), "")), GetType(Double)))
                End If
            Next
            Dim newrow As DataRow = data1.NewRow
            newrow("nID") = 0
            newrow("ParcaIsmi") = ""
            data1.Rows.Add(newrow)
            For i As Integer = 0 To txtParcaSayisi.EditValue - 1
                Dim dtParca As New DataTable
                cmd.CommandText = "SELECT * FROM KategoriParam_009_Kumas2 WHERE Deleted = 0 AND KategoriParamID=" & KategoriParamID & " AND ParcaNo=" & i + 1

                da = New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dtParca)

                If dtParca.Rows.Count > 0 Then
                    newrow("ParcaIsmi") = IfNull(dtParca.Rows(0).Item("ParcaIsmi"), "")
                End If
                For Each dr As DataRow In dtParca.Rows
                    If data1.Columns.Contains(Trim(IfNull(dr("BedenKod"), ""))) Then
                        newrow(Trim(IfNull(dr("BedenKod"), ""))) = If0Null(dr("Miktar"))
                    End If

                Next
                dtParca.Dispose()
                da.Dispose()

                Dim ct As New cntSub_KumasParca
                ct.Row = newrow
                ct.Bedendizi = BedenDizi

                ct.RowIndex = i
                ct.Initialize()

                panelParcalar.Controls.Add(ct)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt009_Kumas2_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""

            For Each dr As DataRow In NeoTable3.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("KumasKatalogID")) <= 0 Then
                        smsg &= "[KUMAS] '" & IfNull(dr("ParcaIsmi"), "") & "' katalog seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If
                    If Mid(KategoriKod, 1, 3) = "M.7" Then
                    Else
                        If If0Null(dr("KumasID")) <= 0 Then
                            smsg &= "[KUMAS] '" & IfNull(dr("ParcaIsmi"), "") & "' kumas seÃ§ilmemis!" & vbNewLine
                            bCancel = True
                        End If
                    End If

                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[KUMAS] '" & IfNull(dr("ParcaIsmi"), "") & "' renk seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If
                End If
            Next
            e.Cancel = bCancel
            e.Message = smsg
            MasraflariUygula()
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cnt009_Kumas2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub

            If Mid(KategoriKod, 1, 3) = "M.7" Then
                GridView2.Columns.Remove(GridView2.Columns("KumasID"))
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt009_Kumas2_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
        Try
            If ApplicationMode = False Then
                NeoTable1.Rows.Clear()
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = AppConn.dbConn
                cmd.CommandText = "DELETE FROM KategoriParam_009_Kumas2 WHERE KategoriParamID=" & KategoriParamID
                cmd.ExecuteNonQuery()
                Dim ParcaNo As Integer = 0
                For Each ct As cntSub_KumasParca In panelParcalar.Controls
                    Dim dr As DataRow = ct.Row
                    ParcaNo += 1
                    For i = 0 To ct.Bedendizi.Length - 1
                        Dim newdr As DataRow = NeoTable1.NewRow
                        newdr("ParcaNo") = ParcaNo
                        newdr("ParcaIsmi") = ct.Row("ParcaIsmi")
                        newdr("BedenKod") = ct.Bedendizi(i)
                        newdr("Miktar") = ct.Row(ct.Bedendizi(i))
                        NeoTable1.Rows.Add(newdr)

                    Next
                    'For Each dc As DataColumn In NeoTable1.Columns
                    '    NeoTable1.Rows(ct.RowIndex).Item(dc.ColumnName) = dr(dc.ColumnName)
                    'Next
                Next

                For Each dr As DataRow In NeoTable1.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable1.Save()
                For Each dr As DataRow In NeoTable2.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("KategoriParamID") = KategoriParamID
                        'Debug.Print("nID:" & If0Null(dr("nID")) & "   SO:" & If0Null(dr("SolOnCep")) & "   SaO:" & If0Null(dr("SagOnCep")))
                    End If
                Next
                NeoTable2.Save()

            Else
                For Each dr As DataRow In NeoTable3.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("SipDetayParamID") = SipDetayParamID
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable3.Save()

                For Each dr As DataRow In NeoTable4.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("SipDetayParamID") = SipDetayParamID
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable4.Save()

            End If


            '------- URETIM BILGILERI -------
            If ApplicationMode = True Then
                If (If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 And If0Null(MasterTable2.Rows(0).Item("bVar")) = 1) Or If0Null(MasterTable.Rows(0).Item("Secmeli")) = 0 Then

                    Dim Aciklamalar As New ArrayList
                    Dim AciklamalarBilgi As New ArrayList
                    Dim sbuf As String = ""
                    Dim AnaRenk As String = ""
                    Dim bIlk As Boolean = True
                    For Each dr As DataRow In NeoTable3.Rows
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then

                            sbuf = IfNull(dr("ParcaIsmi"), "") & "   KATALOG:" & GetKumasKatalogKodIsim(SqlConn.SqlConnection, If0Null(dr("KumasKatalogID")))
                            If Mid(KategoriKod, 1, 3) = "M.7" Then

                            Else
                                sbuf &= "   KUMAÅ:" & GetKumasKodIsim(SqlConn.SqlConnection, If0Null(dr("KumasID")))
                            End If
                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                            If bIlk Then
                                AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                                bIlk = False
                            End If
                            Aciklamalar.Add(sbuf)


                            sbuf = IfNull(dr("ParcaIsmi"), "") & " "
                            If Mid(KategoriKod, 1, 3) = "M.7" Then
                            Else
                                sbuf &= "   KUMAÅ:" & GetKumasKodIsim(SqlConn.SqlConnection, If0Null(dr("KumasID"))) & "    KATALOG:" & GetKumasKatalogKodIsim(SqlConn.SqlConnection, If0Null(dr("KumasKatalogID")))
                            End If

                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                            AciklamalarBilgi.Add(sbuf)
                        End If
                    Next
                    If NeoTable4.Rows.Count > 0 Then
                        With NeoTable4.Rows(0)
                            If If0Null(.Item("SolOnCep")) = 0 And If0Null(.Item("SagOnCep")) = 0 And If0Null(.Item("SolArkaCep")) = 0 And If0Null(.Item("SagArkaCep")) = 0 And If0Null(.Item("GizliCep")) = 0 Then
                                'Aciklamalar.Add("CEP: YOK")
                            Else
                                sbuf = "CEP: "
                                If If0Null(.Item("SolOnCep")) = 1 Then
                                    sbuf &= "[SOL ON] "
                                End If
                                If If0Null(.Item("SagOnCep")) = 1 Then
                                    sbuf &= "[SAÄ ON] "
                                End If
                                If If0Null(.Item("SolArkaCep")) = 1 Then
                                    sbuf &= "[SOL ARKA] "
                                End If
                                If If0Null(.Item("SagArkaCep")) = 1 Then
                                    sbuf &= "[SAÄ ARKA] "
                                End If
                                If If0Null(.Item("GizliCep")) = 1 Then
                                    sbuf &= "[GÄ°ZLÄ° CEP] "
                                End If
                                Aciklamalar.Add(sbuf)
                                AciklamalarBilgi.Add(sbuf)
                            End If


                            If If0Null(.Item("OverlokNakis")) = 0 Then
                                'sbuf = "OVERLOK-NAKIÅ: YOK"
                            Else
                                sbuf = "OVERLOK-NAKIÅ: VAR"
                                Aciklamalar.Add(sbuf)
                                AciklamalarBilgi.Add(sbuf)
                            End If


                            If If0Null(.Item("FarkliKumas")) = 0 Then
                                'sbuf = "FARKLI KUMAÅ: YOK"
                            Else
                                sbuf = "FARKLI KUMAÅ: VAR"
                                Aciklamalar.Add(sbuf)
                                AciklamalarBilgi.Add(sbuf)
                            End If


                            If If0Null(.Item("Biye")) = 0 Then
                                'sbuf = "BÄ°YE: YOK"
                            Else
                                sbuf = "BÄ°YE: VAR"
                                If If0Null(.Item("BiyeDeger")) > 0 Then
                                    sbuf &= "    " & If0Null(.Item("BiyeDeger")) & "cm"
                                End If
                                Aciklamalar.Add(sbuf)
                                AciklamalarBilgi.Add(sbuf)
                            End If

                        End With
                    End If
                    'Aciklamalar.Add("------------------------------")

                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "009", "KUMAS", Aciklamalar, AnaRenk)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "009", "KUMAS", AciklamalarBilgi, AnaRenk)
                End If
            End If
            '-----------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckEdit7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit7.CheckedChanged
        Try
            If CheckEdit7.Checked Then
                TextEdit2.Visible = True
            Else
                TextEdit2.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtParcaSayisi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParcaSayisi.EditValueChanged
        Try
            If bNoAction = True Then Exit Sub

            If txtParcaSayisi.EditValue > ParcaSayisi Then
                For i = 1 To txtParcaSayisi.EditValue - ParcaSayisi
                    Dim newdr As DataRow = NeoTable1.NewRow
                    newdr("KategoriParamID") = KategoriParamID
                    newdr("Deleted") = 0
                    NeoTable1.Rows.Add(newdr)
                Next
                ParcaSayisi = txtParcaSayisi.EditValue
                refresh_panelParcalar()
            ElseIf txtParcaSayisi.EditValue < ParcaSayisi Then
                For i = 1 To ParcaSayisi - txtParcaSayisi.EditValue
                    For j = NeoTable1.Rows.Count - 1 To 0 Step -1
                        If NeoTable1.Rows(j).RowState = DataRowState.Added Then
                            NeoTable1.Rows.RemoveAt(j)
                            Exit For
                        Else
                            If NeoTable1.Rows(j).RowState <> DataRowState.Deleted And NeoTable1.Rows(j).RowState <> DataRowState.Detached Then
                                NeoTable1.Rows(j).Delete()
                                Exit For
                            End If
                        End If
                    Next
                Next
                ParcaSayisi = txtParcaSayisi.EditValue
                refresh_panelParcalar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
    Private Sub cboGridRenk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGridRenk.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmRenkler
                With f
                    
                    .FormShow()
                End With
                OpenTable(tbRenk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboGridKumas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGridKumas.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmDigerKumaslar
                With f
                    
                    .FormShow()
                End With
                OpenTable(tbKumas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboGridKumasKatalog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGridKumasKatalog.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmKumasKatalog
                With f
                    
                    .FormShow()
                End With
                OpenTable(tbKumasKatalog)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MasraflariUygula()
    End Sub

    'Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged, CheckEdit2.CheckedChanged, CheckEdit3.CheckedChanged, CheckEdit4.CheckedChanged, CheckEdit5.CheckedChanged
    '    Try
    '        If CheckEdit1.Checked Or CheckEdit2.Checked Or CheckEdit3.Checked Or CheckEdit4.Checked Or CheckEdit5.Checked Then
    '            CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
    '        Else
    '            CType(MasrafListesi.Item(0), clsMasraf).bUygula = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub CheckEdit6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit6.CheckedChanged
    '    Try
    '        If CheckEdit6.Checked Then
    '            CType(MasrafListesi.Item(1), clsMasraf).bUygula = True
    '            'Else
    '            '    CType(MasrafListesi.Item(1), clsMasraf).bUygula = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub NeoTable4_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable4.ColumnChanged

        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NeoTable2_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged
        Try
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
