Public Class cnt012_LakosYaka
    Dim bNoAction As Boolean = False
    Dim YakaCizgiRKafa As String = ""

    Private Sub cnt012_Yaka_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            Me.Width = 275
            Me.Height = panelCaption.Height + RadioGroup1.Height + XtraTabControl2.Height + 20


            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafaLakos.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafaLakos)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)



            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            tbYakaEnleri.Connection = Me.SqlConn
            tbYakaEnleri.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & "  "
            OpenTable(tbYakaEnleri)

            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("Deleted") = 0

                NeoTable1.Rows.Add(newdr)
            End If


            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT     KategoriFiyat.BedenNo, KategoriFiyat.BedenKod, KategoriFiyat.Fiyat, KategoriFiyat.BazBedenMi " &
               "FROM         KategoriFiyat INNER JOIN " &
               "                      Kategoriler ON KategoriFiyat.KategoriID = Kategoriler.UstKategoriID " &
               "WHERE     (KategoriFiyat.Deleted = 0) AND (Kategoriler.Deleted = 0) AND RTRIM(LTRIM(KategoriFiyat.BedenKod))<>'' AND (Kategoriler.KategoriID = " & If0Null(MasterTable.Rows(0).Item("KategoriID")) & ") " &
               "ORDER BY KategoriFiyat.BedenNo "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                Dim bFound As Boolean = False
                For Each dr2 As DataRow In tbYakaEnleri.Rows
                    If dr2.RowState <> DataRowState.Deleted Then
                        If Trim(IfNull(dr("BedenKod"), "")) = Trim(IfNull(dr2("BedenKod"), "")) Then
                            bFound = True
                            Exit For
                        End If
                    End If
                Next

                If bFound = False And Trim(IfNull(dr("BedenKod"), "")) <> "" Then
                    Dim newdr As DataRow = tbYakaEnleri.NewRow
                    newdr("Deleted") = 0
                    newdr("BedenKod") = Trim(IfNull(dr("BedenKod"), ""))
                    tbYakaEnleri.Rows.Add(newdr)
                End If
            Next

            For Each dr2 As DataRow In tbYakaEnleri.Rows
                Dim bFound As Boolean = False
                For Each dr As DataRow In dt.Rows
                    If dr2.RowState <> DataRowState.Deleted Then
                        If Trim(IfNull(dr("BedenKod"), "")) = Trim(IfNull(dr2("BedenKod"), "")) Then
                            bFound = True
                            Exit For
                        End If
                    End If
                Next

                If bFound = False Then
                    dr2.Delete()
                End If
            Next

            dt.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt012_Yaka_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try

            Me.Width = 340
            Me.Height = 210
            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafaLakos.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafaLakos)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)


            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            tbYakaEnleri.Connection = Me.SqlConn
            tbYakaEnleri.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(tbYakaEnleri)

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

                NeoTable2.Rows.Add(newdr)
            End If

            Dim LakosYakaID As Long = 0

            If NeoTable2.Rows.Count > 0 Then
                LakosYakaID = NeoTable2.Rows(0).Item("nID")
            End If
            NeoTable3.Connection = Me.SqlConn
            NeoTable3.SelectCommand.CommandText &= " AND LakosYakaID>0 AND LakosYakaID=" & LakosYakaID & " "
            OpenTable(NeoTable3)
            If MasterTable.Rows.Count > 0 Then
                If MasterTable2.Rows.Count > 0 Then
                    MasterTable2.Rows(0).Item("IntParam1") = MasterTable.Rows(0).Item("IntParam1")
                End If
            End If

            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MasraflariUygula()
        Try
            MasrafListesi.Clear()
            MasrafListesi.Add(New clsMasraf("001", "Çizgi Farkı", False, 0))

            If MasrafListesi.Count > 0 Then
                If NeoTable2.Rows.Count > 0 Then
                    CType(MasrafListesi.Item(0), clsMasraf).bUygula = False

                    If If0Null(NeoTable2.Rows(0).Item("CizgiSayisi")) > 0 Then
                        CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cnt012_Yaka_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""


            If NeoTable2.Rows.Count > 0 Then
                If If0Null(NeoTable2.Rows(0).Item("RenkID")) <= 0 Then
                    smsg &= "[L/S YAKA] Yaka rengi seçilmemiş!" & vbNewLine
                    bCancel = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("CizgiRKafaLakosID")) <= 0 Then
                    smsg &= "[L/S YAKA] Çizgi seçilmemiş!" & vbNewLine
                    bCancel = True
                End If
            End If
            For i As Integer = 0 To NeoTable3.Rows.Count - 1
                Dim dr As DataRow = NeoTable3.Rows(i)
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[L/S YAKA] #" & i + 1 & " satırda renk seçilmemiş!" & vbNewLine
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

    Private Sub cnt012_Yaka_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt012_Yaka_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
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

                For Each dr As DataRow In tbYakaEnleri.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                tbYakaEnleri.Save()

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
                            dr("LakosYakaID") = If0Null(NeoTable2.Rows(0).Item("nID"))
                        End If
                    Next
                End If
                NeoTable3.Save()

            End If



            '------- URETIM BILGILERI -------
            If ApplicationMode = True Then
                If (If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 And If0Null(MasterTable2.Rows(0).Item("bVar")) = 1) Or If0Null(MasterTable.Rows(0).Item("Secmeli")) = 0 Then

                    Dim Aciklamalar As New ArrayList
                    Dim Aciklamalar2 As New ArrayList
                    Dim sbuf As String = ""
                    Dim AnaRenk As String = ""

                    If MasterTable2.Rows.Count > 0 Then
                        sbuf = "L/S YAKA ŞEKLİ : "
                        Select Case If0Null(MasterTable2.Rows(0).Item("IntParam1"))
                            Case 0 : sbuf &= "GÖMLEK YAKA"
                            Case 1 : sbuf &= "SİMİT YAKA"
                            Case 2 : sbuf &= "PİLOT YAKA"
                            Case 3 : sbuf &= "SIFIR YAKA"
                            Case 4 : sbuf &= "POLO YAKA"
                            Case 5 : sbuf &= "AYAKLI GÖMLEK"
                        End Select
                        Aciklamalar.Add(sbuf)
                        Aciklamalar2.Add(sbuf)


                    End If
                    If NeoTable2.Rows.Count > 0 Then
                        AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(NeoTable2.Rows(0).Item("RenkID")))
                        sbuf = "L/S YAKA RENK:" & AnaRenk
                        Aciklamalar.Add(sbuf)
                        Aciklamalar2.Add(sbuf)

                        sbuf = ""
                        Dim drLakosCizgi As DataRow = tbCizgiRenkKafaLakos.Rows.Find(If0Null(NeoTable2.Rows(0).Item("CizgiRKafaLakosID")))
                        If Not drLakosCizgi Is Nothing Then
                            sbuf = "L/S YAKA ÇİZGİ:" & IfNull(drLakosCizgi("Aciklama"), "")

                        End If

                        sbuf &= " / ÇİZGİ RENK:"

                        Dim nCizgi As Integer = 0

                        For Each dr As DataRow In NeoTable3.Rows
                            If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                                nCizgi += 1

                                Dim drRenk As DataRow = tbRenk.Rows.Find(If0Null(dr("RenkID")))
                                If Not drRenk Is Nothing Then
                                    sbuf &= "   " & nCizgi & ". Çizgi:" & IfNull(drRenk("RenkKod"), "")

                                End If

                            End If

                        Next

                        Aciklamalar.Add(sbuf)
                        Aciklamalar2.Add(sbuf)


                    End If



                    '----- TUR SAYILARI --------
                    Dim IpGramaj As Double = 0
                    Dim GramajArtis As Double = 0

                    Dim TIpGramaj As Double = 0

                    Dim BazIndex As Integer = 0

                    If NeoTable1.Rows.Count > 0 And Bedenler.Count > 0 Then
                        IpGramaj = If0Null(NeoTable1.Rows(0).Item("IpGramaj"))
                        GramajArtis = If0Null(NeoTable1.Rows(0).Item("GramajArtis"))

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
                        TIpGramaj = ToplamAdet * If0Null(NeoTable1.Rows(0).Item("IpGramaj"))
                    End If
                    Aciklamalar.Add("L/S YAKA Gramaj :" & If0Null(NeoTable1.Rows(0).Item("IpGramaj")) & "    T.Gramaj:" & TIpGramaj)
                    '---------------------

                    Dim BaslangicIndex As Integer = -1, BitisIndex As Integer = -1
                    For i As Integer = 0 To Bedenler.Count - 1
                        If CType(Bedenler(i), clsBeden).Miktar > 0 Then
                            BitisIndex = i
                            If BaslangicIndex < 0 Then
                                BaslangicIndex = i
                            End If
                        End If
                    Next
                    If BaslangicIndex >= 0 And BitisIndex >= 0 Then
                        Dim bIlk As Boolean = True

                        For Each dr As DataRow In tbYakaEnleri.Rows
                            Dim bFound As Boolean = False

                            If dr.RowState <> DataRowState.Deleted Then
                                For i As Integer = BaslangicIndex To BitisIndex
                                    If Trim(CType(Bedenler(i), clsBeden).BedenKod) = Trim(IfNull(dr("BedenKod"), "")) Then
                                        If bIlk = True Then
                                            bIlk = False
                                            sbuf = "L/S YAKA ENLERİ : "
                                        Else
                                            sbuf = "                  "
                                        End If

                                        sbuf &= "B" & Trim(CType(Bedenler(i), clsBeden).BedenKod)
                                        sbuf &= ":" & Space(4 - Len(Trim(CType(Bedenler(i), clsBeden).BedenKod)))
                                        sbuf &= If0Null(dr("En")) & "cm" & Space(4 - Len(CStr(If0Null(dr("En")))))
                                        If CType(Bedenler(i), clsBeden).Miktar > 0 Then
                                            sbuf &= CType(Bedenler(i), clsBeden).Miktar & " Adet"
                                            sbuf &= ""
                                            sbuf &= ""
                                        End If


                                        Aciklamalar.Add(sbuf)
                                    End If
                                Next

                            End If

                        Next
                    End If
                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "012", "L/S YAKA", Aciklamalar, AnaRenk)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "012", "L/S YAKA", Aciklamalar2, AnaRenk)
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

            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
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





    Private Sub LookUpEdit2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LookUpEdit2.KeyDown
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

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Try
            XtraTabControl2.SelectedTabPageIndex = RadioGroup1.SelectedIndex
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LookUpEdit3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdit3.EditValueChanged

    End Sub

    Private Sub NeoTable3_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable3.ColumnChanged
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
