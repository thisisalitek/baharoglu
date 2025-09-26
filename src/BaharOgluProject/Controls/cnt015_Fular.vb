Public Class cnt015_Fular
    Dim bNoAction As Boolean = False

    Private Sub cnt015_Fular_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try
            Me.Width = 287
            Me.Height = 143
            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)
            tbOrguTip.Connection = Me.SqlConn
            OpenTable(tbOrguTip)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt015_Fular_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try
            Me.Width = 272
            Me.Height = 158
            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)

            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)

            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)

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
                        NeoTable2.Rows.Add(newdr)

                    End If
                End If
            Next
            'MasraflariYukle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt015_Fular_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""

            For Each dr As DataRow In NeoTable2.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[FULAR] '" & IfNull(dr("ParcaIsmi"), "") & "' renk seÃ§ilmemis!" & vbNewLine
                        bCancel = True
                    End If
                   
                End If
            Next
            If MasterTable2.Rows.Count > 0 Then
                If If0Null(MasterTable2.Rows(0).Item("IntParam1")) <= 0 Then
                    smsg &= "[FULAR] sekil seÃ§ilmemis!" & vbNewLine
                    bCancel = True
                End If
            End If
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

                    For Each dr As DataRow In NeoTable2.Rows
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                            Dim sbuf As String = ""
                            sbuf = IfNull(dr("ParcaIsmi"), "") & "   IPLIK:" & GetIplikKodIsim(SqlConn.SqlConnection, If0Null(dr("Iplik")))
                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))

                            If bIlk Then
                                AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                                bIlk = False
                            End If

                            '--- Find total gramage in cloth --------
                            Dim TIpGramaj As Double = 0

                            Dim BazIndex As Integer = -1
                            Dim IpGramaj As Double = 0

                            Dim GramajArtis As Double = 0

                            If NeoTable1.Rows.Count > 0 And Bedenler.Count > 0 Then

                                IpGramaj = If0Null(NeoTable1.Rows(0).Item("IpGramaj"))
                                GramajArtis = 0
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
                                        TIpGramaj += (IpGramaj + (i) * GramajArtis) * CType(Bedenler(i), clsBeden).Miktar
                                    End If

                                Next


                            End If
                            '-------------------
                            sbuf &= vbTab & " Ä°P KG:" & Math.Round(TIpGramaj / 1000, 2)
                            Aciklamalar.Add(sbuf)

                            sbuf = IfNull(dr("ParcaIsmi"), "")
                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                            Aciklamalar2.Add(sbuf)


                        End If
                    Next
                    'Aciklamalar.Add("------------------------------")
                    If MasterTable2.Rows.Count > 0 Then
                        Dim sbuf As String = ""
                        Select Case If0Null(MasterTable2.Rows(0).Item("IntParam1"))
                            Case 1 : sbuf = "FULAR METAL : YUVARLAK"
                            Case 2 : sbuf = "FULAR METAL : OVAL"
                            Case 3 : sbuf = "FULAR METAL : KALKAN"
                            Case 99 : sbuf = "FULAR METAL : DÄ°ÄER"

                        End Select
                        If Trim(sbuf) <> "" Then
                            Aciklamalar.Add(sbuf)
                            Aciklamalar2.Add(sbuf)
                        End If

                    End If
                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "015", "FULAR", Aciklamalar, AnaRenk)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "015", "FULAR", Aciklamalar2, AnaRenk)
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
        ' MasraflariYukle()
    End Sub

    Private Sub GridControl1_EditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.EditorKeyDown
        GridControl1_KeyDown(sender, e)
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        Try
            If e.KeyCode = Keys.Delete And (e.Control Or e.Shift) Then
                If GridView1.FocusedRowHandle < 0 Then Exit Sub
                If MsgBox("Satir silmek istediginizden emin misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Satir Sil?") <> MsgBoxResult.Yes Then Exit Sub
                Dim RowIndex As Integer = 0
                RowIndex = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
                NeoTable1.Rows(RowIndex).Delete()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepositoryItemLookUpEdit1.KeyDown
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

    Private Sub cboOrguTip_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboOrguTip1.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmOrguTipi
                With f
                    
                    .FormShow_Lakos()
                End With
                OpenTable(tbOrguTip)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub NeoTable2_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged

        Try
            'If bNoAction Then Exit Sub
            'bNoAction = True

            'bNoAction = False
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub NeoTable1_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable1.ColumnChanged
        Try
         
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
