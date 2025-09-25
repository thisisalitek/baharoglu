Public Class cnt052_KazakYaka
    Dim bNoAction As Boolean = False

    Private Sub cnt052_KazakYaka_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafa.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafa)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)



            'NeoTable1.Connection = Me.SqlConn
            'NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            'OpenTable(NeoTable1)

            'If NeoTable1.Rows.Count < 4 Then
            '    For i As Integer = 1 To 4 - NeoTable1.Rows.Count
            '        Dim newdr As DataRow = NeoTable1.NewRow
            '        newdr("CizgiSayisi") = NeoTable1.Rows.Count + 1
            '        NeoTable1.Rows.Add(newdr)
            '    Next
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt052_KazakYaka_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try

            Debug.Print(bInitializing)
            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafa.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafa)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)


            'NeoTable1.Connection = Me.SqlConn
            'NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            'OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt052_KazakYaka_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""


            If MasterTable2.Rows.Count > 0 Then
                If If0Null(MasterTable2.Rows(0).Item("RenkID")) <= 0 Then
                    smsg &= "[KAZAK YAKA] Kazak yaka rengi seçilmemiş!" & vbNewLine
                    bCancel = True
                End If
            End If
            For i As Integer = 0 To NeoTable2.Rows.Count - 1
                Dim dr As DataRow = NeoTable2.Rows(i)
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[KAZAK YAKA] #" & i + 1 & " satırda renk seçilmemiş!" & vbNewLine
                        bCancel = True
                    End If
                End If
            Next


            e.Cancel = bCancel
            e.Message = smsg
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt052_KazakYaka_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub

           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt052_KazakYaka_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = SqlConn.SqlConnection

            If ApplicationMode = False Then
               
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
                    Dim sbuf As String = ""
                    Dim AnaRenk As String = ""

                    If MasterTable2.Rows.Count > 0 Then
                        AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(MasterTable2.Rows(0).Item("RenkID")))
                        sbuf = "KAZAK YAKA RENK:" & AnaRenk

                        If If0Null(MasterTable2.Rows(0).Item("CizgiSayisi")) <= 0 Then
                            sbuf &= "   ÇİZGİ :YOK "
                        Else
                            sbuf &= "   ÇİZGİ :" & If0Null(MasterTable2.Rows(0).Item("CizgiSayisi"))
                        End If
                        Aciklamalar.Add(sbuf)

                        '------------
                        Dim sSipBuf As String = ""

                        sSipBuf = "KAZAK YAKA RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(MasterTable2.Rows(0).Item("RenkID")))
                        Aciklamalar2.Add(sSipBuf)

                        If If0Null(MasterTable2.Rows(0).Item("CizgiSayisi")) <= 0 Then
                            sSipBuf = "DUBLE YAKA ÇİZGİ :YOK "
                        Else
                            sSipBuf = "DUBLE YAKA ÇİZGİ :" & If0Null(MasterTable2.Rows(0).Item("CizgiSayisi")) & "   RENKLER:"

                        End If

                        '--------------

                        Dim CizgiNo As Integer = 0
                        CizgiNo = 0
                        For Each dr As DataRow In NeoTable2.Rows
                            If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                                CizgiNo += 1
                                sbuf = CizgiNo & ". Çizgi ->  RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                                sbuf &= "     " & CizgiNo & ". Çizgi -> " & IfNull(dr("RKafa"), "")
                                Aciklamalar.Add(sbuf)
                                sSipBuf &= GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID"))) & " , "
                            End If
                        Next

                        Dim Tur As Double = 0
                        Dim TurArtis As Double = 0

                        Dim TTur As Double = 0

                        Dim BazIndex As Integer = 0

                        If MasterTable.Rows.Count > 0 And Bedenler.Count > 0 Then
                            Tur = If0Null(MasterTable.Rows(0).Item("Tur"))
                            TurArtis = If0Null(MasterTable.Rows(0).Item("TurArtis"))

                            For i As Integer = 0 To Bedenler.Count - 1
                                If CType(Bedenler(i), clsBeden).BazBeden = True Then
                                    BazIndex = i
                                    Exit For
                                End If
                            Next

                            If BazIndex < 0 Then BazIndex = 0
                            For i As Integer = 0 To BazIndex - 1
                                If Tur > 0 Then
                                    TTur += (Tur - (BazIndex - i) * TurArtis) * CType(Bedenler(i), clsBeden).Miktar
                                End If
                            Next

                            For i As Integer = BazIndex To Bedenler.Count - 1
                                If Tur > 0 Then
                                    TTur += (Tur + (i - BazIndex) * TurArtis) * CType(Bedenler(i), clsBeden).Miktar
                                End If

                            Next
                        Else
                            TTur = ToplamAdet * If0Null(MasterTable.Rows(0).Item("Tur"))
                        End If
                        Aciklamalar.Add("KAZAK YAKA TUR :" & If0Null(MasterTable.Rows(0).Item("Tur")) & "    T.Tur:" & TTur)

                        Aciklamalar2.Add(sSipBuf)
                        'If If0Null(MasterTable2.Rows(0).Item("CizgiSayisi")) > 0 Then
                        '    If Trim(DubleYakaCizgiRKafa) <> "" Then
                        '        sSipBuf = "DUBLE YAKA ÇİZGİ TÜR :" & DubleYakaCizgiRKafa
                        '        Aciklamalar2.Add(sSipBuf)
                        '    End If
                        'End If
                    End If

                    'Aciklamalar.Add("------------------------------")


                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "052", "KAZAK YAKA", Aciklamalar, AnaRenk)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "052", "KAZAK YAKA", Aciklamalar2, AnaRenk)
                End If
            End If
            '-----------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    'Private Sub NeoTable1_BeforeSave(ByVal sender As System.Object, ByRef e As NeoDAC.NeoTableSaveEventArgs) Handles NeoTable1.BeforeSave

    '    NeoTable2_ColumnChanged(Nothing, Nothing)
    'End Sub

    'Private Sub NeoTable2_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged
    '    Try
    '        If e Is Nothing Then Exit Sub
    '        If bNoAction = True Then Exit Sub
    '        bNoAction = True
    '        'Dim sn As Integer = 0
    '        'For i As Integer = 0 To NeoTable2.Rows.Count - 1
    '        '    Dim dr As DataRow = NeoTable2.Rows(i)
    '        '    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
    '        '        sn += 1
    '        '        dr("CizgiSayisi") = sn
    '        '    End If
    '        'Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    bNoAction = False
    'End Sub

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



    Private Sub SpinEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpinEdit1.EditValueChanged
        If Timer1.Enabled Then Exit Sub
        DefaultRKafaYukle()


        Try
            'If SpinEdit1.EditValue > 0 Then
            '    CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
            'Else
            '    CType(MasrafListesi.Item(0), clsMasraf).bUygula = False
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DefaultRKafaYukle()
        Try
            If bInitializing Then Exit Sub
            Dim CizgiSayi As Integer = 0
            For Each dr As DataRow In NeoTable2.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    CizgiSayi += 1
                End If
            Next
            If SpinEdit1.EditValue = CizgiSayi Then Exit Sub

            Dim a As Integer = 0
            For Each dr As DataRow In NeoTable2.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    a += 1
                End If
            Next
            If SpinEdit1.EditValue > a Then
                For i As Integer = 1 To SpinEdit1.EditValue - a
                    Dim newdr As DataRow = NeoTable2.NewRow
                    newdr("CizgiSayisi") = a + i
                    NeoTable2.Rows.Add(newdr)
                Next
            ElseIf SpinEdit1.EditValue < a Then
                For i As Integer = 1 To a - SpinEdit1.EditValue
                    NeoTable2.Rows(NeoTable2.Rows.Count - i).Delete()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
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
        MasrafListesi.Clear()
        MasrafListesi.Add(New clsMasraf("001", "Çizgi Farkı", False, 0))
    End Sub
End Class
