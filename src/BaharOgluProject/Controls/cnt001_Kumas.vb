Public Class cnt001_Kumas
    Dim bNoAction As Boolean = False

    Private Sub cnt1000_Kumas_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try
            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt001_Kumas_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try
            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)
            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)

            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbOrguTip.Connection = Me.SqlConn
            OpenTable(tbOrguTip)

            For Each dr As DataRow In NeoTable1.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    Dim bFound As Boolean = False
                    For Each dr2 As DataRow In NeoTable2.Rows
                        If dr2.RowState <> DataRowState.Deleted And dr2.RowState <> DataRowState.Detached Then
                            If If0Null(dr2("SourceID")) = If0Null(dr("nID")) Then
                                bFound = True
                                Exit For
                            End If
                        End If
                    Next

                    If bFound = False Then
                        Dim newdr As DataRow = NeoTable2.NewRow
                        newdr("SourceID") = dr("nID")
                        newdr("KategoriParamID") = dr("KategoriParamID")
                        newdr("SipDetayParamID") = SipDetayParamID
                        newdr("ParcaIsmi") = dr("ParcaIsmi")
                        newdr("Iplik") = dr("Iplik")
                        newdr("IpGramaj") = dr("IpGramaj")
                        newdr("KumasGramaj") = dr("KumasGramaj")
                        newdr("GramajArtis") = dr("GramajArtis")
                        NeoTable2.Rows.Add(newdr)

                    End If
                End If
            Next
            MasraflariYukle()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt001_Kumas_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""

            For Each dr As DataRow In NeoTable2.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("Iplik")) <= 0 Then
                        smsg &= "[TRIKO KUMAS] '" & IfNull(dr("ParcaIsmi"), "") & "' iplik seçilmemiş!" & vbNewLine
                        bCancel = True
                    End If
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[TRIKO KUMAS] '" & IfNull(dr("ParcaIsmi"), "") & "' renk seçilmemiş!" & vbNewLine
                        bCancel = True
                    End If
                    If Mid(KategoriKod, 1, 3) = "M.6" Then

                    Else
                        If If0Null(dr("OrguTip")) <= 0 Then
                            smsg &= "[TRIKO KUMAS] '" & IfNull(dr("ParcaIsmi"), "") & "' örgü tipi seçilmemiş!" & vbNewLine
                            bCancel = True
                        End If
                    End If

                End If
            Next
            e.Cancel = bCancel
            e.Message = smsg
            'MasraflariUygula()
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cnt1000_Kumas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


            If Mid(KategoriKod, 1, 3) = "M.6" Then
                GridView2.Columns.Remove(GridView2.Columns("OrguTip"))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt1000_Kumas_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
        Try
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
            End If

            '------- URETIM BILGILERI -------
            If ApplicationMode = True Then
                If (If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 And If0Null(MasterTable2.Rows(0).Item("bVar")) = 1) Or If0Null(MasterTable.Rows(0).Item("Secmeli")) = 0 Then

                    Dim Aciklamalar As New ArrayList
                    Dim Aciklamalar2 As New ArrayList
                    Dim AnaRenk As String = ""
                    Dim bIlk As Boolean = True

                    For index As Integer = 0 To NeoTable2.Rows.Count - 1
                        Dim dr As DataRow = NeoTable2.Rows(index)
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                            Dim sbuf As String = ""
                            sbuf = IfNull(dr("ParcaIsmi"), "") & "   IPLIK:" & GetIplikKodIsim(SqlConn.SqlConnection, If0Null(dr("Iplik")))
                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                            If bIlk Then
                                AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                                bIlk = False
                            End If
                            If Mid(KategoriKod, 1, 3) = "M.6" Then

                            Else
                                sbuf &= "   ÖRGÜ TİPİ:" & GetOrguTip(SqlConn.SqlConnection, If0Null(dr("OrguTip")))
                            End If



                            '--- Find total gramage in cloth --------
                            Dim TIpGramaj As Double = 0
                            Dim TKumasGramaj As Double = 0
                            Dim BazIndex As Integer = -1
                            Dim IpGramaj As Double = 0
                            Dim KumasGramaj As Double = 0
                            Dim GramajArtis As Double = 0

                            If NeoTable1.Rows.Count > 0 And Bedenler.Count > 0 Then

                                IpGramaj = If0Null(NeoTable1.Rows(index).Item("IpGramaj"))
                                KumasGramaj = If0Null(NeoTable1.Rows(index).Item("KumasGramaj"))
                                GramajArtis = If0Null(NeoTable1.Rows(index).Item("GramajArtis"))
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
                                    If KumasGramaj > 0 Then
                                        TKumasGramaj += (KumasGramaj - (BazIndex - i) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                    End If
                                Next

                                For i As Integer = BazIndex To Bedenler.Count - 1
                                    If IpGramaj > 0 Then
                                        TIpGramaj += (IpGramaj + (i - BazIndex) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                    End If
                                    If KumasGramaj > 0 Then
                                        TKumasGramaj += (KumasGramaj + (i - BazIndex) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                    End If
                                Next


                            End If
                            '-------------------
                            sbuf &= vbTab & " İP KG:" & Math.Round(TIpGramaj / 1000, 2) & vbTab & " KUMAŞ KG:" & Math.Round(TKumasGramaj / 1000, 2)
                            Aciklamalar.Add(sbuf)

                            sbuf = IfNull(dr("ParcaIsmi"), "")
                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                            sbuf &= "   IPLIK:" & GetIplikKodIsim(SqlConn.SqlConnection, If0Null(dr("Iplik")))
                            If Mid(KategoriKod, 1, 3) = "M.6" Then

                            Else
                                sbuf &= "   ÖRGÜ TİPİ:" & GetOrguTip(SqlConn.SqlConnection, If0Null(dr("OrguTip")))
                            End If
                            Aciklamalar2.Add(sbuf)
                        End If
                    Next
                    'Aciklamalar.Add("------------------------------")

                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "001", "TRİKO KUMAS", Aciklamalar, AnaRenk)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "001", "TRİKO KUMAS", Aciklamalar2, AnaRenk)
                End If
            End If
            '-----------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MasraflariYukle()
    End Sub

    Private Sub GridControl1_EditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.EditorKeyDown
        GridControl1_KeyDown(sender, e)
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        Try
            If e.KeyCode = Keys.Delete And (e.Control Or e.Shift) Then
                If GridView1.FocusedRowHandle < 0 Then Exit Sub
                If MsgBox("Satır silmek istediğinizden emin misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Satır Sil?") <> MsgBoxResult.Yes Then Exit Sub
                Dim RowIndex As Integer = 0
                RowIndex = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
                NeoTable1.Rows(RowIndex).Delete()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepositoryItemLookUpEdit1.KeyDown, RepositoryItemLookUpEdit2.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmIplik
                With f

                    .FormShow()
                End With
                OpenTable(tbIplik)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboGridRenk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGridRenk.KeyDown
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

    Private Sub cboOrguTip_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboOrguTip.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmOrguTipi
                With f

                    .FormShow_Normal()
                End With
                OpenTable(tbOrguTip)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub NeoTable2_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged
        If bNoAction Then Exit Sub
        bNoAction = True
        MasraflariYukle()
        bNoAction = False
    End Sub

    Private Sub MasraflariYukle()
        Try
            MasrafListesi.Clear()
            For Each dr As DataRow In NeoTable2.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("OrguTip")) > 0 Then
                        Dim drOrgu As DataRow = tbOrguTip.Rows.Find(If0Null(dr("OrguTip")))
                        If Not drOrgu Is Nothing Then
                            If If0Null(drOrgu("Fiyat")) > 0 Then
                                Dim bFound As Boolean = False
                                For i As Integer = 0 To MasrafListesi.Count - 1
                                    If CType(MasrafListesi(i), clsMasraf).MasrafIsmi = IfNull(drOrgu("OrguTipIsmi"), "") Then
                                        bFound = True
                                        Exit For
                                    End If
                                Next
                                If bFound = False Then
                                    MasrafListesi.Add(New clsMasraf("005", IfNull(drOrgu("OrguTipIsmi"), ""), True, If0Null(drOrgu("Fiyat"))))
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

    Private Sub NeoTable2_TableNewRow(ByVal sender As System.Object, ByVal e As System.Data.DataTableNewRowEventArgs) Handles NeoTable2.TableNewRow
        Try

            If Mid(KategoriKod, 1, 3) = "M.6" Then
                e.Row("OrguTip") = 0
            Else
                e.Row("OrguTip") = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
