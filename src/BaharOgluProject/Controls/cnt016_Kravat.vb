Public Class cnt016_Kravat
    Dim bNoAction As Boolean = False

    Private Sub cnt016_Kravat_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try
            Me.Width = 253
            Me.Height = 210
            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt016_Kravat_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try
            Me.Width = 253
            Me.Height = 263
            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)

            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)

           
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
                      
                        NeoTable2.Rows.Add(newdr)

                    End If
                End If
            Next
            'MasraflariYukle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt016_Kravat_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try
            Dim bCancel As Boolean = False
            Dim smsg As String = ""

            For Each dr As DataRow In NeoTable2.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If If0Null(dr("RenkID")) <= 0 Then
                        smsg &= "[KRAVAT] '" & IfNull(dr("ParcaIsmi"), "") & "' renk seçilmemiş!" & vbNewLine
                        bCancel = True
                    End If

                End If
            Next
            If MasterTable2.Rows.Count > 0 Then
                If If0Null(MasterTable2.Rows(0).Item("IntParam1")) <> 0 And Trim(IfNull(MasterTable2.Rows(0).Item("CharParam1"), "")) = "" Then
                    smsg &= "[KRAVAT] Yazı boş olamaz!" & vbNewLine
                    bCancel = True
                End If
            End If
            e.Cancel = bCancel
            e.Message = smsg

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
                            sbuf = IfNull(dr("ParcaIsmi"), "") & "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))

                            If bIlk Then
                                AnaRenk = GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                                bIlk = False
                            End If

                            Aciklamalar.Add(sbuf)

                            sbuf = IfNull(dr("ParcaIsmi"), "")
                            sbuf &= "   RENK:" & GetRenkKodIsim(SqlConn.SqlConnection, If0Null(dr("RenkID")))
                            Aciklamalar2.Add(sbuf)


                        End If
                    Next

                    If MasterTable2.Rows.Count > 0 Then
                        If If0Null(MasterTable2.Rows(0).Item("IntParam1")) = 1 Then
                            Dim sbuf As String = ""
                            sbuf = "KRAVAT YAZISI : " & IfNull(MasterTable2.Rows(0).Item("CharParam1"), "")
                            Aciklamalar.Add(sbuf)
                            Aciklamalar2.Add(sbuf)
                        End If



                    End If
                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "016", "KRAVAT", Aciklamalar, AnaRenk)
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "016", "KRAVAT", Aciklamalar2, AnaRenk)
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
                If MsgBox("Satır silmek istediğinizden emin misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Satır Sil?") <> MsgBoxResult.Yes Then Exit Sub
                Dim RowIndex As Integer = 0
                RowIndex = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
                NeoTable1.Rows(RowIndex).Delete()

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

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Try
            If RadioGroup1.SelectedIndex = 0 Then
                TextEdit1.Visible = False
            Else
                TextEdit1.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
