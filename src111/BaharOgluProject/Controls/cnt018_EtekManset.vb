﻿Public Class cnt018_EtekManset
    Dim bNoAction As Boolean = False
    Dim YakaCizgiRKafa As String = ""

    Private Sub cnt018_EtekManset_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            Me.Width = 300
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

    Private Sub cnt018_EtekManset_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
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

             

                NeoTable2.Rows.Add(newdr)
            End If

            Dim EtekMansetID As Long = 0

            If NeoTable2.Rows.Count > 0 Then
                EtekMansetID = NeoTable2.Rows(0).Item("nID")
            End If
            NeoTable3.Connection = Me.SqlConn
            NeoTable3.SelectCommand.CommandText &= " AND EtekMansetID>0 AND EtekMansetID=" & EtekMansetID & " "
            OpenTable(NeoTable3)


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



    Private Sub cnt018_EtekManset_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""


            If NeoTable2.Rows.Count > 0 Then
                If If0Null(NeoTable2.Rows(0).Item("RenkID")) <= 0 Then
                    smsg &= "[ETEK MANŞET] Rengi seçilmemiş!" & vbNewLine
                    bCancel = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("CizgiRKafaLakosID")) <= 0 Then
                    smsg &= "[ETEK MANŞET] Çizgi seçilmemiş!" & vbNewLine
                    bCancel = True
                End If

            End If


            For i As Integer = 0 To NeoTable3.Rows.Count - 1
                Dim dr As DataRow = NeoTable3.Rows(i)
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[ETEK MANŞET] #" & i + 1 & " satırda renk seçilmemiş!" & vbNewLine
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

    Private Sub cnt018_EtekManset_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt018_EtekManset_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
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
                            dr("EtekMansetID") = If0Null(NeoTable2.Rows(0).Item("nID"))
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
                    Dim AnaRenk1 As String = ""
                    Dim AnaRenk2 As String = ""
                    Dim sGramajArtis As String = ""

                    If NeoTable2.Rows.Count > 0 Then
                        AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(NeoTable2.Rows(0).Item("RenkID")))
                        sbuf = "ETEK MANŞET(6cm) RENK:" & AnaRenk
                        Dim nCizgi As Integer = 0

                        For Each dr As DataRow In NeoTable3.Rows
                            If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                                nCizgi += 1

                                Dim drRenk As DataRow = tbRenk.Rows.Find(If0Null(dr("RenkID")))
                                If Not drRenk Is Nothing Then
                                    sbuf &= "    " & nCizgi & ". Çizgi:" & IfNull(drRenk("RenkKod"), "")

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
                        sGramajArtis = "  grArtış:" & GramajArtis
                    End If
                    Aciklamalar.Add("ETEK MANŞET(6cm) Gramaj :" & IpGramaj & " " & sGramajArtis & "    T.Gramaj:" & TIpGramaj & " ")

                    Aciklamalar.Add("ETEK MANŞET(6cm) Adedi :" & ToplamAdet & " Tarak 6 cm Manşet")
                    '---------------------

                    

                    Dim AnaRenkTam As String
                    AnaRenkTam = AnaRenk
                    If Trim(AnaRenk1) <> "" Then
                        AnaRenkTam &= " / Garni1:" & AnaRenk1
                    End If
                    If Trim(AnaRenk2) <> "" Then
                        AnaRenkTam &= " / Garni2:" & AnaRenk2
                    End If

                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "018", "ETEK MANŞET(6cm)", Aciklamalar, AnaRenkTam)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "018", "ETEK MANŞET(6cm)", Aciklamalar2, AnaRenkTam)
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

    Private Sub LookUpEdit4_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NeoTable3_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable3.ColumnChanged
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbGarni1Cizgiler_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs)
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbGarni2Cizgiler_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs)
        Try
            e.Row.EndEdit()
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
