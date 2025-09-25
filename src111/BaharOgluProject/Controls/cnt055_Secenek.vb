Public Class cnt055_Secenek
    Dim bNoAction As Boolean = False

    Private Sub cnt055_Secenek_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            tbFason.Connection = Me.SqlConn
            OpenTable(tbFason)


            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("ModelFarki") = 0
                newdr("ParcaModel") = 0
                newdr("Astar") = 0
                newdr("Femuar") = 0
                newdr("OmuzRecme") = 0
                newdr("Arma") = 0
                newdr("OzelEtiket") = 0
                newdr("Fason") = 0
                newdr("FasonID") = 0
                newdr("MansetFarki") = 0
                newdr("UzunKolFarki") = 0

                NeoTable1.Rows.Add(newdr)
            Else
                If If0Null(NeoTable1.Rows(0).Item("Arma")) <= 0 Then
                    chkArma.Checked = False
                Else
                    chkArma.Checked = True
                End If
                chkArma_CheckedChanged(Nothing, Nothing)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt055_Secenek_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try


            tbFason.Connection = Me.SqlConn
            OpenTable(tbFason)


            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)


            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("ModelFarki") = 0
                newdr("ParcaModel") = 0
                newdr("Astar") = 0
                newdr("Femuar") = 0
                newdr("OmuzRecme") = 0
                newdr("Arma") = 0
                newdr("OzelEtiket") = 0
                newdr("Fason") = 0
                newdr("FasonID") = 0
                newdr("MansetFarki") = 0
                newdr("UzunKolFarki") = 0
                NeoTable1.Rows.Add(newdr)
            End If

            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("ModelFarki") = NeoTable1.Rows(0).Item("ModelFarki")
                newdr("ParcaModel") = NeoTable1.Rows(0).Item("ParcaModel")
                newdr("Astar") = NeoTable1.Rows(0).Item("Astar")
                newdr("Femuar") = NeoTable1.Rows(0).Item("Femuar")
                newdr("OmuzRecme") = NeoTable1.Rows(0).Item("OmuzRecme")
                newdr("Arma") = NeoTable1.Rows(0).Item("Arma")
                newdr("OzelEtiket") = NeoTable1.Rows(0).Item("OzelEtiket")
                newdr("Fason") = NeoTable1.Rows(0).Item("Fason")
                newdr("FasonID") = NeoTable1.Rows(0).Item("FasonID")
                newdr("MansetFarki") = NeoTable1.Rows(0).Item("MansetFarki")
                newdr("UzunKolFarki") = NeoTable1.Rows(0).Item("UzunKolFarki")
                NeoTable2.Rows.Add(newdr)

                If If0Null(NeoTable1.Rows(0).Item("Arma")) <= 0 Then
                    chkArma2.Checked = False
                Else
                    chkArma2.Checked = True
                End If
                chkArma2_CheckedChanged(Nothing, Nothing)
            Else
                If If0Null(NeoTable2.Rows(0).Item("Arma")) <= 0 Then
                    chkArma2.Checked = False
                Else
                    chkArma2.Checked = True
                End If
                chkArma2_CheckedChanged(Nothing, Nothing)
            End If

            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MasraflariUygula()
        Try
            MasrafListesi.Clear()
            MasrafListesi.Add(New clsMasraf("006", "Model Farkı", False, 0))
            MasrafListesi.Add(New clsMasraf("007", "Parça Model", False, 0))
            MasrafListesi.Add(New clsMasraf("008", "Astar", False, 0))
            MasrafListesi.Add(New clsMasraf("009", "Fermuar", False, 0))
            MasrafListesi.Add(New clsMasraf("010", "Omuz Reçme", False, 0))
            MasrafListesi.Add(New clsMasraf("003", "Arma", False, 0))
            MasrafListesi.Add(New clsMasraf("004", "Özel Etiket", False, 0))
            MasrafListesi.Add(New clsMasraf("S01", "Fason", False, 0))
            MasrafListesi.Add(New clsMasraf("013", "Manşet Farkı", False, 0))
            MasrafListesi.Add(New clsMasraf("014", "Uzun Kol Farkı", False, 0))

            If NeoTable2.Rows.Count <= 0 Then Exit Sub

            If MasrafListesi.Count > 0 Then
                If If0Null(NeoTable2.Rows(0).Item("ModelFarki")) <> 0 Then
                    CType(MasrafListesi.Item(0), clsMasraf).bUygula = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("ParcaModel")) <> 0 Then
                    CType(MasrafListesi.Item(1), clsMasraf).bUygula = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("Astar")) <> 0 Then
                    CType(MasrafListesi.Item(2), clsMasraf).bUygula = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("Femuar")) <> 0 Then
                    CType(MasrafListesi.Item(3), clsMasraf).bUygula = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("OmuzRecme")) <> 0 Then
                    CType(MasrafListesi.Item(4), clsMasraf).bUygula = True
                End If

                If If0Null(NeoTable2.Rows(0).Item("Arma")) <> 0 Then
                    CType(MasrafListesi.Item(5), clsMasraf).Carpan = If0Null(NeoTable2.Rows(0).Item("Arma"))
                    CType(MasrafListesi.Item(5), clsMasraf).bUygula = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("OzelEtiket")) <> 0 Then
                    CType(MasrafListesi.Item(6), clsMasraf).bUygula = True
                End If

                If If0Null(NeoTable2.Rows(0).Item("Fason")) <> 0 Then
                    If If0Null(NeoTable2.Rows(0).Item("FasonID")) > 0 Then
                        Dim drFason As DataRow = tbFason.Rows.Find(If0Null(NeoTable2.Rows(0).Item("FasonID")))
                        If Not drFason Is Nothing Then
                            If If0Null(drFason("Fiyat")) > 0 Then
                                CType(MasrafListesi.Item(7), clsMasraf).bUygula = True
                                CType(MasrafListesi.Item(7), clsMasraf).Fiyat = If0Null(drFason("Fiyat"))
                            End If

                        End If

                    End If
                End If


                If If0Null(NeoTable2.Rows(0).Item("MansetFarki")) <> 0 Then
                    CType(MasrafListesi.Item(8), clsMasraf).bUygula = True
                End If
                If If0Null(NeoTable2.Rows(0).Item("UzunKolFarki")) <> 0 Then
                    CType(MasrafListesi.Item(9), clsMasraf).bUygula = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt055_Secenek_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        Try

            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt055_Secenek_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cnt055_Secenek_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = SqlConn.SqlConnection

            If ApplicationMode = False Then
                For Each dr As DataRow In NeoTable1.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If If0Null(dr("Fason")) = 0 Then
                            dr("FasonID") = 0
                        End If
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable1.Save()
            Else
                For Each dr As DataRow In NeoTable2.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If If0Null(dr("Fason")) = 0 Then
                            dr("FasonID") = 0
                        End If
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

                    If MasterTable2.Rows.Count > 0 Then
                        If NeoTable2.Rows.Count > 0 Then
                            With NeoTable2.Rows(0)
                                If If0Null(.Item("ModelFarki")) <> 0 Then
                                    Aciklamalar.Add("MODEL FARKI: VAR")
                                    Aciklamalar2.Add("MODEL FARKI: VAR")
                                End If
                                If If0Null(.Item("Astar")) <> 0 Then
                                    Aciklamalar.Add("ASTAR: VAR")
                                    Aciklamalar2.Add("ASTAR: VAR")
                                End If
                                If If0Null(.Item("Femuar")) <> 0 Then
                                    Aciklamalar.Add("FERMUAR: VAR")
                                    Aciklamalar2.Add("FERMUAR: VAR")
                                End If
                                If If0Null(.Item("OmuzRecme")) <> 0 Then
                                    Aciklamalar.Add("OMUZ REÇME: VAR")
                                    Aciklamalar2.Add("OMUZ REÇME: VAR")
                                End If
                                If If0Null(.Item("Arma")) > 0 Then
                                    Aciklamalar.Add("ARMA: VAR (" & If0Null(.Item("Arma")) & " adet)")
                                    Aciklamalar2.Add("ARMA: VAR (" & If0Null(.Item("Arma")) & " adet)")
                                End If
                                If If0Null(.Item("OzelEtiket")) <> 0 Then
                                    Aciklamalar.Add("ÖZEL ETİKET: VAR")
                                    Aciklamalar2.Add("ÖZEL ETİKET: VAR")
                                End If
                                If If0Null(.Item("Fason")) <> 0 And If0Null(.Item("FasonID")) > 0 Then
                                    Aciklamalar.Add("FASON: VAR")
                                    Aciklamalar2.Add("FASON: VAR")
                                End If
                            End With
                        End If

                    End If
                    'Aciklamalar.Add("------------------------------")

                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "055", "SEÇENEKLER", Aciklamalar, "")
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "055", "SEÇENEKLER", Aciklamalar2, "")
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
            If bNoAction = True Then Exit Sub
            bNoAction = True

            e.Row.EndEdit()
            If If0Null(e.Row("Fason")) = 1 Then
                LookUpEdit1.Visible = True
            Else

                LookUpEdit1.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub

    Private Sub NeoTable2_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged
        Try
            If e Is Nothing Then Exit Sub
            If bNoAction = True Then Exit Sub
            bNoAction = True

            e.Row.EndEdit()
            If If0Null(e.Row("Fason")) = 1 Then
                LookUpEdit2.Visible = True
            Else

                LookUpEdit2.Visible = False
            End If
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub



    Private Sub NeoTable1_BeforeSave(ByVal sender As System.Object, ByRef e As NeoDAC.NeoTableSaveEventArgs) Handles NeoTable1.BeforeSave
        NeoTable1_ColumnChanged(Nothing, Nothing)

    End Sub



    Private Sub chkArma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArma.CheckedChanged

        Try
            If NeoTable1.Rows.Count <= 0 Then Exit Sub
            If bNoAction Then Exit Sub
            bNoAction = True
            If chkArma.Checked = True Then
                If NeoTable1.Rows(0).Item("Arma") = 0 Then
                    NeoTable1.Rows(0).Item("Arma") = 1
                End If

                NeoTable1.Rows(0).EndEdit()
                txtArmaSayisi.Visible = True
            Else
                NeoTable1.Rows(0).Item("Arma") = 0
                txtArmaSayisi.Visible = False
                NeoTable1.Rows(0).EndEdit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
        TextEdit1.Focus()
    End Sub

    Private Sub chkArma2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArma2.CheckedChanged

        Try
            If NeoTable2.Rows.Count <= 0 Then Exit Sub
            If bNoAction Then Exit Sub
            bNoAction = True
            If chkArma2.Checked = True Then
                If NeoTable2.Rows(0).Item("Arma") = 0 Then
                    NeoTable2.Rows(0).Item("Arma") = 1
                End If

                NeoTable2.Rows(0).EndEdit()
                txtArmaSayisi2.Visible = True

            Else
                NeoTable2.Rows(0).Item("Arma") = 0
                txtArmaSayisi2.Visible = False
                NeoTable2.Rows(0).EndEdit()
            End If
            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
        TextEdit1.Focus()
    End Sub

    Private Sub chkFason_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFason.CheckedChanged
        If chkFason.Checked Then
            LookUpEdit1.Visible = True
        Else

            LookUpEdit1.Visible = False
        End If
        TextEdit1.Focus()
    End Sub

    Private Sub chkFason2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFason2.CheckedChanged

        Try
            If chkFason2.Checked Then
                LookUpEdit2.Visible = True
                If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("Fason") = 1

            Else

                LookUpEdit2.Visible = False
                If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("Fason") = 0

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


    Private Sub txtArmaSayisi2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArmaSayisi2.EditValueChanged
        Try
            TextEdit1.Focus()
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("Arma") = If0Null(txtArmaSayisi2.EditValue)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkModelFarki_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkModelFarki.CheckedChanged
        Try
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("ModelFarki") = chkModelFarki.EditValue

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkParcaModel_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkParcaModel.CheckedChanged
        Try
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("ParcaModel") = chkParcaModel.EditValue

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub chkAstar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAstar.CheckedChanged
        Try
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("Astar") = chkAstar.EditValue

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub chkOmuzRecme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOmuzRecme.CheckedChanged
        Try
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("OmuzRecme") = chkOmuzRecme.EditValue

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkFermuar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFermuar.CheckedChanged
        Try
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("Femuar") = chkFermuar.EditValue
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkOzelEtiket_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOzelEtiket.CheckedChanged
        Try
            If NeoTable2.Rows.Count > 0 Then NeoTable2.Rows(NeoTable2.Rows.Count - 1).Item("OzelEtiket") = chkOzelEtiket.EditValue
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
