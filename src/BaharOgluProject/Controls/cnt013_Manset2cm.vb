Public Class cnt013_Manset2cm
    Dim bNoAction As Boolean = False
    Dim YakaCizgiRKafa As String = ""

    Private Sub cnt013_Manset2cm_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            Me.Width = 258
            Me.Height = 87


            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafaLakos.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafaLakos)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)



            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("Deleted") = 0

                NeoTable1.Rows.Add(newdr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt013_Manset2cm_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try

            Me.Width = 370
            Me.Height = 280
            XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True
            XtraTabPage1.PageVisible = False

            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafaLakos.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafaLakos)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)


            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)


            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("Deleted") = 0

                NeoTable1.Rows.Add(newdr)
            End If

        

            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("RenkID") = 0
                newdr("Iplik") = NeoTable1.Rows(0).Item("Iplik")
                newdr("IpGramaj") = NeoTable1.Rows(0).Item("IpGramaj")
                newdr("GramajArtis") = NeoTable1.Rows(0).Item("GramajArtis")

                newdr("Garni1_Iplik") = NeoTable1.Rows(0).Item("Iplik")
                newdr("Garni1_IpGramaj") = NeoTable1.Rows(0).Item("IpGramaj")
                newdr("Garni1_GramajArtis") = NeoTable1.Rows(0).Item("GramajArtis")

                newdr("Garni2_Iplik") = NeoTable1.Rows(0).Item("Iplik")
                newdr("Garni2_IpGramaj") = NeoTable1.Rows(0).Item("IpGramaj")
                newdr("Garni2_GramajArtis") = NeoTable1.Rows(0).Item("GramajArtis")

                NeoTable2.Rows.Add(newdr)
            End If

            Dim Manset2cmID As Long = 0

            If NeoTable2.Rows.Count > 0 Then
                Manset2cmID = NeoTable2.Rows(0).Item("nID")
            End If
            NeoTable3.Connection = Me.SqlConn
            NeoTable3.SelectCommand.CommandText &= " AND Manset2cmID>0 AND Manset2cmID=" & Manset2cmID & " "
            OpenTable(NeoTable3)

            tbGarni1Cizgiler.Connection = Me.SqlConn
            tbGarni1Cizgiler.SelectCommand.CommandText &= " AND Manset2cmID>0 AND Manset2cmID=" & Manset2cmID & " "
            OpenTable(tbGarni1Cizgiler)

            tbGarni2Cizgiler.Connection = Me.SqlConn
            tbGarni2Cizgiler.SelectCommand.CommandText &= " AND Manset2cmID>0 AND Manset2cmID=" & Manset2cmID & " "
            OpenTable(tbGarni2Cizgiler)

            MasraflariUygula()
            ShowHide_Garni()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MasraflariUygula()
        Try
            MasrafListesi.Clear()
            MasrafListesi.Add(New clsMasraf("001", "Ã‡izgi Farki", False, 0))

            If MasrafListesi.Count > 0 Then
                If NeoTable2.Rows.Count > 0 Then
                    CType(MasrafListesi.Item(0), clsMasraf).bUygula = False

                    If If0Null(NeoTable2.Rows(0).Item("CizgiSayisi")) > 0 Or If0Null(NeoTable2.Rows(0).Item("Garni1_CizgiSayisi")) > 0 Or If0Null(NeoTable2.Rows(0).Item("Garni2_CizgiSayisi")) > 0 Then
                        CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cnt013_Manset2cm_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""


            If NeoTable2.Rows.Count > 0 Then
                If If0Null(NeoTable2.Rows(0).Item("RenkID")) <= 0 Then
                    smsg &= "[MANÅET(2cm)] Yaka rengi seÃ§ilmemis!" & vbNewLine
                    bCancel = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("CizgiRKafaLakosID")) <= 0 Then
                    smsg &= "[MANÅET(2cm)] Ã‡izgi seÃ§ilmemis!" & vbNewLine
                    bCancel = True
                End If

                If If0Null(NeoTable2.Rows(0).Item("bGarni1")) = 1 Then
                    If If0Null(NeoTable2.Rows(0).Item("Garni1_RenkID")) <= 0 Then
                        smsg &= "[MANÅET(2cm)] Garni 1 Yaka rengi seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If
                    If If0Null(NeoTable2.Rows(0).Item("Garni1_CizgiRKafaLakosID")) <= 0 Then
                        smsg &= "[MANÅET(2cm)] Garni 1 Ã‡izgi seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If
                End If

                If If0Null(NeoTable2.Rows(0).Item("bGarni2")) = 1 Then
                    If If0Null(NeoTable2.Rows(0).Item("Garni2_RenkID")) <= 0 Then
                        smsg &= "[MANÅET(2cm)] Garni 2 Yaka rengi seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If
                    If If0Null(NeoTable2.Rows(0).Item("Garni2_CizgiRKafaLakosID")) <= 0 Then
                        smsg &= "[MANÅET(2cm)] Garni 2 Ã‡izgi seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If

                End If
            End If


            For i As Integer = 0 To NeoTable3.Rows.Count - 1
                Dim dr As DataRow = NeoTable3.Rows(i)
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[MANÅET(2cm)] #" & i + 1 & " satirda renk seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If

                End If
            Next

            If If0Null(NeoTable2.Rows(0).Item("bGarni1")) = 1 Then
                For i As Integer = 0 To tbGarni1Cizgiler.Rows.Count - 1
                    Dim dr As DataRow = tbGarni1Cizgiler.Rows(i)
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If If0Null(dr("RenkID")) <= 0 Then
                            smsg &= "[MANÅET(2cm)] Garni1 #" & i + 1 & " satirda renk seÃ§ilmemis!" & vbNewLine
                            bCancel = True
                        End If

                    End If
                Next
            End If

            If If0Null(NeoTable2.Rows(0).Item("bGarni2")) = 1 Then
                For i As Integer = 0 To tbGarni2Cizgiler.Rows.Count - 1
                    Dim dr As DataRow = tbGarni2Cizgiler.Rows(i)
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If If0Null(dr("RenkID")) <= 0 Then
                            smsg &= "[MANÅET(2cm)] Garni2 #" & i + 1 & " satirda renk seÃ§ilmemis!" & vbNewLine
                            bCancel = True
                        End If

                    End If
                Next
            End If
            e.Cancel = bCancel
            e.Message = smsg
            MasraflariUygula()
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt013_Manset2cm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt013_Manset2cm_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = SqlConn.SqlConnection

            If ApplicationMode = False Then
                For Each dr As DataRow In NeoTable1.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable1.Save()
            Else
                For Each dr As DataRow In NeoTable2.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("SipDetayParamID") = SipDetayParamID
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable2.Save()

                If NeoTable2.Rows.Count > 0 Then
                    For Each dr As DataRow In NeoTable3.Rows
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                            dr("Manset2cmID") = If0Null(NeoTable2.Rows(0).Item("nID"))
                        End If
                    Next
                    For Each dr As DataRow In tbGarni1Cizgiler.Rows
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                            dr("Manset2cmID") = If0Null(NeoTable2.Rows(0).Item("nID"))
                        End If
                    Next
                    For Each dr As DataRow In tbGarni2Cizgiler.Rows
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                            dr("Manset2cmID") = If0Null(NeoTable2.Rows(0).Item("nID"))
                        End If
                    Next
                End If
                NeoTable3.Save()
                tbGarni1Cizgiler.Save()
                tbGarni2Cizgiler.Save()

            End If



            '------- URETIM BILGILERI -------
            If ApplicationMode = True Then
                If (If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 And If0Null(MasterTable2.Rows(0).Item("bVar")) = 1) Or If0Null(MasterTable.Rows(0).Item("Secmeli")) = 0 Then

                    Dim Aciklamalar As New ArrayList
                    Dim Aciklamalar2 As New ArrayList
                    Dim sbuf As String = ""
                    Dim AnaRenk As String = ""
                    Dim AnaRenk1 As String = ""
                    Dim AnaRenk2 As String = ""
                    Dim sGramajArtis As String = ""

                    If NeoTable2.Rows.Count > 0 Then
                        AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(NeoTable2.Rows(0).Item("RenkID")))
                        sbuf = "MANÅET(2cm) RENK:" & AnaRenk
                        Dim nCizgi As Integer = 0

                        For Each dr As DataRow In NeoTable3.Rows
                            If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                                nCizgi += 1

                                Dim drRenk As DataRow = tbRenk.Rows.Find(If0Null(dr("RenkID")))
                                If Not drRenk Is Nothing Then
                                    sbuf &= "    " & nCizgi & ". Ã‡izgi:" & IfNull(drRenk("RenkKod"), "")

                                End If

                            End If

                        Next
                        Aciklamalar.Add(sbuf)
                        Aciklamalar2.Add(sbuf)

                        'Garni 1
                        If If0Null(NeoTable2.Rows(0).Item("bGarni1")) = 1 Then
                            AnaRenk1 = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(NeoTable2.Rows(0).Item("Garni1_RenkID")))
                            sbuf = "MANÅET(2cm) Garni1 RENK:" & AnaRenk1
                            nCizgi = 0

                            For Each dr As DataRow In tbGarni1Cizgiler.Rows
                                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                                    nCizgi += 1

                                    Dim drRenk As DataRow = tbRenk.Rows.Find(If0Null(dr("RenkID")))
                                    If Not drRenk Is Nothing Then
                                        sbuf &= "    " & nCizgi & ". Ã‡izgi:" & IfNull(drRenk("RenkKod"), "")

                                    End If

                                End If

                            Next
                            Aciklamalar.Add(sbuf)
                            Aciklamalar2.Add(sbuf)
                        End If


                        'Garni 2
                        If If0Null(NeoTable2.Rows(0).Item("bGarni2")) = 1 Then
                            AnaRenk2 = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(NeoTable2.Rows(0).Item("Garni2_RenkID")))
                            sbuf = "MANÅET(2cm) Garni2 RENK:" & AnaRenk2
                            nCizgi = 0

                            For Each dr As DataRow In tbGarni2Cizgiler.Rows
                                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                                    nCizgi += 1

                                    Dim drRenk As DataRow = tbRenk.Rows.Find(If0Null(dr("RenkID")))
                                    If Not drRenk Is Nothing Then
                                        sbuf &= "    " & nCizgi & ". Ã‡izgi:" & IfNull(drRenk("RenkKod"), "")

                                    End If

                                End If

                            Next
                            Aciklamalar.Add(sbuf)
                            Aciklamalar2.Add(sbuf)
                        End If

                    End If


                    '----- TUR SAYILARI --------
                    Dim IpGramaj As Double = 0
                    Dim GramajArtis As Double = 0

                    Dim TIpGramaj As Double = 0

                    Dim BazIndex As Integer = 0


                    '-------normal------------
                    IpGramaj = If0Null(NeoTable2.Rows(0).Item("IpGramaj"))
                    GramajArtis = If0Null(NeoTable2.Rows(0).Item("GramajArtis"))
                    TIpGramaj = 0
                    BazIndex = 0
                    If Bedenler.Count > 0 Then
                        

                        For i As Integer = 0 To Bedenler.Count - 1
                            If CType(Bedenler(i), clsBeden).BazBeden = True Then
                                BazIndex = i
                                Exit For
                            End If
                        Next

                        If BazIndex < 0 Then BazIndex = 0
                        For i As Integer = 0 To BazIndex - 1
                            If IpGramaj > 0 Then
                                TIpGramaj += (IpGramaj - (BazIndex - i) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                            End If
                        Next

                        For i As Integer = BazIndex To Bedenler.Count - 1
                            If IpGramaj > 0 Then
                                TIpGramaj += (IpGramaj + (i - BazIndex) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                            End If

                        Next
                    Else
                        TIpGramaj = ToplamAdet * IpGramaj
                    End If

                    sGramajArtis = ""
                    If GramajArtis > 0 Then
                        sGramajArtis = "  grArtis:" & GramajArtis
                    End If
                    Aciklamalar.Add("MANÅET(2cm) Gramaj :" & IpGramaj & " " & sGramajArtis & "    T.Gramaj:" & TIpGramaj & " ")

                    Aciklamalar.Add("MANÅET(2cm) Adedi :" & ToplamAdet & " Tarak 3.5 cm Manset")
                    '---------------------

                    '-------Garni 1------------
                    If NeoTable2.Rows(0).Item("bGarni1") = 1 Then
                        IpGramaj = If0Null(NeoTable2.Rows(0).Item("Garni1_IpGramaj"))
                        GramajArtis = If0Null(NeoTable2.Rows(0).Item("Garni1_GramajArtis"))
                        TIpGramaj = 0
                        BazIndex = 0
                        If Bedenler.Count > 0 Then


                            For i As Integer = 0 To Bedenler.Count - 1
                                If CType(Bedenler(i), clsBeden).BazBeden = True Then
                                    BazIndex = i
                                    Exit For
                                End If
                            Next

                            If BazIndex < 0 Then BazIndex = 0
                            For i As Integer = 0 To BazIndex - 1
                                If IpGramaj > 0 Then
                                    TIpGramaj += (IpGramaj - (BazIndex - i) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                End If
                            Next

                            For i As Integer = BazIndex To Bedenler.Count - 1
                                If IpGramaj > 0 Then
                                    TIpGramaj += (IpGramaj + (i - BazIndex) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                End If

                            Next
                        Else
                            TIpGramaj = ToplamAdet * IpGramaj
                        End If

                        sGramajArtis = ""
                        If GramajArtis > 0 Then
                            sGramajArtis = "  grArtis:" & GramajArtis
                        End If

                        Aciklamalar.Add("MANÅET(2cm) Garni 1 Gramaj :" & IpGramaj & " " & sGramajArtis & "    T.Gramaj:" & TIpGramaj)
                        Aciklamalar.Add("MANÅET(2cm) Garni 1 Adedi :" & ToplamAdet & " Tarak 3.5 cm Manset")

                       
                        
                    End If
                    '---------------------


                    '-------Garni 2------------
                    If NeoTable2.Rows(0).Item("bGarni2") = 1 Then
                        IpGramaj = If0Null(NeoTable2.Rows(0).Item("Garni2_IpGramaj"))
                        GramajArtis = If0Null(NeoTable2.Rows(0).Item("Garni2_GramajArtis"))
                        TIpGramaj = 0
                        BazIndex = 0
                        If Bedenler.Count > 0 Then

                            For i As Integer = 0 To Bedenler.Count - 1
                                If CType(Bedenler(i), clsBeden).BazBeden = True Then
                                    BazIndex = i
                                    Exit For
                                End If
                            Next

                            If BazIndex < 0 Then BazIndex = 0
                            For i As Integer = 0 To BazIndex - 1
                                If IpGramaj > 0 Then
                                    TIpGramaj += (IpGramaj - (BazIndex - i) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                End If
                            Next

                            For i As Integer = BazIndex To Bedenler.Count - 1
                                If IpGramaj > 0 Then
                                    TIpGramaj += (IpGramaj + (i - BazIndex) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                End If

                            Next
                        Else
                            TIpGramaj = ToplamAdet * IpGramaj
                        End If

                        sGramajArtis = ""
                        If GramajArtis > 0 Then
                            sGramajArtis = "  grArtis:" & GramajArtis
                        End If

                        Aciklamalar.Add("MANÅET(2cm) Garni 2 Gramaj :" & IpGramaj & " " & sGramajArtis & "    T.Gramaj:" & TIpGramaj)
                        Aciklamalar.Add("MANÅET(2cm) Garni 2 Adedi :" & ToplamAdet & " Tarak 3.5 cm Manset")

                    End If

                    '---------------------

                    Dim AnaRenkTam As String
                    AnaRenkTam = AnaRenk
                    If Trim(AnaRenk1) <> "" Then
                        AnaRenkTam &= " / Garni1:" & AnaRenk1
                    End If
                    If Trim(AnaRenk2) <> "" Then
                        AnaRenkTam &= " / Garni2:" & AnaRenk2
                    End If

                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "013", "MANÅET(2cm)", Aciklamalar, AnaRenkTam)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "013", "MANÅET(2cm)", Aciklamalar2, AnaRenkTam)
                End If
            End If
            '-----------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub NeoTable1_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable1.ColumnChanged
        Try
            If e Is Nothing Then Exit Sub
            'If bNoAction = True Then Exit Sub
            'bNoAction = True
            'Dim sn As Integer = 0
            'For i As Integer = 0 To NeoTable1.Rows.Count - 1
            '    Dim dr As DataRow = NeoTable1.Rows(i)
            '    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
            '        sn += 1
            '        dr("CizgiSayisi") = sn
            '    End If
            'Next
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'bNoAction = False
    End Sub


    Private Sub NeoTable1_BeforeSave(ByVal sender As System.Object, ByRef e As NeoDAC.NeoTableSaveEventArgs) Handles NeoTable1.BeforeSave
        'NeoTable1_ColumnChanged(Nothing, Nothing)
        'NeoTable2_ColumnChanged(Nothing, Nothing)
    End Sub

    Private Sub NeoTable2_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged
        Try
            If e Is Nothing Then Exit Sub
            If bNoAction = True Then Exit Sub
            bNoAction = True
            If e.Column.ColumnName = "CizgiRKafaLakosID" Then
                Dim i As Integer = 0
                Do While i <= NeoTable3.Rows.Count - 1
                    If NeoTable3.Rows(i).RowState = DataRowState.Added Then
                        NeoTable3.Rows.RemoveAt(i)
                    Else
                        If NeoTable3.Rows(i).RowState <> DataRowState.Deleted And NeoTable3.Rows(i).RowState <> DataRowState.Detached Then
                            NeoTable3.Rows(i).Delete()
                            i += 1
                        Else
                            i += 1
                        End If
                    End If
                Loop
                Dim dr As DataRow = tbCizgiRenkKafaLakos.Rows.Find(e.Row("CizgiRKafaLakosID"))
                If Not dr Is Nothing Then
                    e.Row("CizgiSayisi") = If0Null(dr("CizgiSayisi"))
                    For j = 1 To If0Null(dr("CizgiSayisi"))
                        Dim newdr As DataRow = NeoTable3.NewRow

                        newdr("CizgiNo") = j
                        NeoTable3.Rows.Add(newdr)
                    Next

                End If
            End If

            If e.Column.ColumnName = "Garni1_CizgiRKafaLakosID" Then
                Dim i As Integer = 0
                Do While i <= tbGarni1Cizgiler.Rows.Count - 1
                    If tbGarni1Cizgiler.Rows(i).RowState = DataRowState.Added Then
                        tbGarni1Cizgiler.Rows.RemoveAt(i)
                    Else
                        If tbGarni1Cizgiler.Rows(i).RowState <> DataRowState.Deleted And tbGarni1Cizgiler.Rows(i).RowState <> DataRowState.Detached Then
                            tbGarni1Cizgiler.Rows(i).Delete()
                            i += 1
                        Else
                            i += 1
                        End If
                    End If
                Loop
                Dim dr As DataRow = tbCizgiRenkKafaLakos.Rows.Find(e.Row("Garni1_CizgiRKafaLakosID"))
                If Not dr Is Nothing Then
                    e.Row("Garni1_CizgiSayisi") = If0Null(dr("CizgiSayisi"))
                    For j = 1 To If0Null(dr("CizgiSayisi"))
                        Dim newdr As DataRow = tbGarni1Cizgiler.NewRow

                        newdr("CizgiNo") = j
                        tbGarni1Cizgiler.Rows.Add(newdr)
                    Next

                End If
            End If

            If e.Column.ColumnName = "Garni2_CizgiRKafaLakosID" Then
                Dim i As Integer = 0
                Do While i <= tbGarni2Cizgiler.Rows.Count - 1
                    If tbGarni2Cizgiler.Rows(i).RowState = DataRowState.Added Then
                        tbGarni2Cizgiler.Rows.RemoveAt(i)
                    Else
                        If tbGarni2Cizgiler.Rows(i).RowState <> DataRowState.Deleted And tbGarni2Cizgiler.Rows(i).RowState <> DataRowState.Detached Then
                            tbGarni2Cizgiler.Rows(i).Delete()
                            i += 1
                        Else
                            i += 1
                        End If
                    End If
                Loop
                Dim dr As DataRow = tbCizgiRenkKafaLakos.Rows.Find(e.Row("Garni2_CizgiRKafaLakosID"))
                If Not dr Is Nothing Then
                    e.Row("Garni2_CizgiSayisi") = If0Null(dr("CizgiSayisi"))
                    For j = 1 To If0Null(dr("CizgiSayisi"))
                        Dim newdr As DataRow = tbGarni2Cizgiler.NewRow

                        newdr("CizgiNo") = j
                        tbGarni2Cizgiler.Rows.Add(newdr)
                    Next

                End If
            End If

            If e.Column.ColumnName = "bGarni1" Then
                If If0Null(e.Row("bGarni1")) = 0 Then
                    e.Row("bGarni2") = 0
                End If
            End If
            e.Row.EndEdit()
            MasraflariUygula()
            ShowHide_Garni()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub ShowHide_Garni()
        Try
            If NeoTable2.Rows.Count = 0 Then Exit Sub
            If If0Null(NeoTable2.Rows(0).Item("bGarni1")) = 1 Then
                XtraTabPage3.PageVisible = True
                If If0Null(NeoTable2.Rows(0).Item("bGarni2")) = 1 Then
                    XtraTabPage4.PageVisible = True
                End If
            Else
                XtraTabPage3.PageVisible = False
                XtraTabPage4.PageVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub MasterTable2_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable2.ColumnChanged
    '    Try
    '        If bInitializing Then Exit Sub
    '        If e.Column.ColumnName = "CizgiSayisi" Then
    '            DefaultRKafaYukle()
    '            e.Row.EndEdit()
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub





    Private Sub LookUpEdit2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LookUpEdit2.KeyDown, RepositoryItemLookUpEdit1.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmRenkler
                With f
                    
                    .FormShow()
                End With
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

    Private Sub LookUpEdit3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdit3.EditValueChanged

    End Sub

    Private Sub LookUpEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit4.EditValueChanged

    End Sub

    Private Sub NeoTable3_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable3.ColumnChanged
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbGarni1Cizgiler_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles tbGarni1Cizgiler.ColumnChanged
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbGarni2Cizgiler_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles tbGarni2Cizgiler.ColumnChanged
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
