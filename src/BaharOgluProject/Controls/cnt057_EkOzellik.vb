Public Class cnt057_EkOzellik
    Dim bNoAction As Boolean = False

    Private Sub cnt056_EkFiyat_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try


            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            'If NeoTable1.Rows.Count <= 0 Then
            '    Dim newdr As DataRow = NeoTable1.NewRow
            '    newdr("Aciklama") = ""

            '    NeoTable1.Rows.Add(newdr)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt056_EkFiyat_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try


        


            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= "  AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)


            'If NeoTable1.Rows.Count <= 0 Then
            '    Dim newdr As DataRow = NeoTable1.NewRow
            '    newdr("ModelFarki") = 0

            '    NeoTable1.Rows.Add(newdr)
            'End If

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
                        newdr("Aciklama") = dr("Aciklama")
                        newdr("bStatik") = 1

                        NeoTable2.Rows.Add(newdr)

                    End If
                End If
            Next
            GridView1_FocusedRowChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cnt056_EkFiyat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt056_EkFiyat_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
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
            End If


            '------- URETIM BILGILERI -------
            If ApplicationMode = True Then
                If (If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 And If0Null(MasterTable2.Rows(0).Item("bVar")) = 1) Or If0Null(MasterTable.Rows(0).Item("Secmeli")) = 0 Then
                    Dim Aciklamalar As New ArrayList
                    Dim Aciklamalar2 As New ArrayList
                    Dim sbuf As String = ""
                    For Each dr As DataRow In NeoTable2.Rows
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then

                            If Trim(IfNull(dr("Aciklama"), "")) <> "" Then
                                Aciklamalar.Add(Trim(IfNull(dr("Aciklama"), "")))
                                Aciklamalar2.Add(Trim(IfNull(dr("Aciklama"), "")))
                            End If

                        End If
                    Next

                    'Aciklamalar.Add("------------------------------")
                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "057", "EK OZELLÄ°KLER", Aciklamalar, "")
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "057", "EK OZELLÄ°KLER", Aciklamalar2, "")
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
        bNoAction = False
    End Sub


    Private Sub NeoTable1_BeforeSave(ByVal sender As System.Object, ByRef e As NeoDAC.NeoTableSaveEventArgs) Handles NeoTable1.BeforeSave
        NeoTable1_ColumnChanged(Nothing, Nothing)

    End Sub

    Private Sub GridControl2_EditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.EditorKeyDown
        GridControl2_KeyDown(sender, e)
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

    Private Sub GridControl2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        Try
            If e.KeyCode = Keys.Delete And (e.Control Or e.Shift) Then
                Dim RowIndex As Integer = GridView2.GetDataSourceRowIndex(GridView2.FocusedRowHandle)
                If RowIndex < 0 Then Exit Sub
                If MsgBox("Satiri silmek istiyor musunuz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Satir sil?") <> MsgBoxResult.Yes Then Exit Sub
                NeoTable1.Rows(RowIndex).Delete()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        GridView1_FocusedRowChanged(Nothing, Nothing)
    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If GridView1.FocusedRowHandle < 0 Then
                GridView1.OptionsBehavior.Editable = True
                Exit Sub
            End If
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            Dim dr As DataRow = NeoTable2.Rows(RowIndex)
            If If0Null(dr("bStatik")) = 1 Then
                GridView1.OptionsBehavior.Editable = False
            Else
                GridView1.OptionsBehavior.Editable = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_EditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.EditorKeyDown
        GridControl1_KeyDown(sender, e)
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            If GridView1.OptionsBehavior.Editable = False Then Exit Sub
            If e.KeyCode = Keys.Delete And (e.Control Or e.Shift) Then
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
                Dim dr As DataRow = NeoTable2.Rows(RowIndex)
                If dr("bStatik") = 1 Then
                    GridView1.OptionsBehavior.Editable = False
                Else
                    If MsgBox("Satiri silmek istiyor musunuz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Satir Sil?") <> MsgBoxResult.Yes Then Exit Sub
                    dr.Delete()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
