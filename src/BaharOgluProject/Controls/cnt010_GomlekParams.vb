Public Class cnt010_GomlekParams
    Dim bNoAction As Boolean = False

    Private Sub cnt010_GomlekParams_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("Pensli") = 0
                newdr("Yaka") = 0
                newdr("Cepli") = 0
                NeoTable1.Rows.Add(newdr)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt010_GomlekParams_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try

            NeoTable1.Connection = Me.SqlConn
            NeoTable1.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable1)

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND SipDetayParamID=" & SipDetayParamID & " "
            OpenTable(NeoTable2)


            If NeoTable1.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable1.NewRow
                newdr("Pensli") = 0
                newdr("Yaka") = 0
                newdr("Cepli") = 0
                NeoTable1.Rows.Add(newdr)
            End If

            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("Pensli") = NeoTable1.Rows(0).Item("Pensli")
                newdr("Yaka") = NeoTable1.Rows(0).Item("Yaka")
                newdr("Cepli") = NeoTable1.Rows(0).Item("Cepli")
                NeoTable2.Rows.Add(newdr)
            End If

            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MasraflariUygula()
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt010_GomlekParams_IsOkay(ByVal sender As System.Windows.Forms.Control, ByRef e As IsOkayEventArgs) Handles Me.IsOkay
        MasraflariUygula()
    End Sub

    Private Sub cnt010_GomlekParams_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cnt010_GomlekParams_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
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

                    If MasterTable2.Rows.Count > 0 Then
                        If NeoTable2.Rows.Count > 0 Then
                            With NeoTable2.Rows(0)
                                If If0Null(.Item("Pensli")) <> 0 Then
                                    Aciklamalar.Add("PENSLÄ°")
                                    Aciklamalar2.Add("PENSLÄ°")
                                End If
                                If If0Null(.Item("Yaka")) = 0 Then
                                    Aciklamalar.Add("DÄ°K YAKA")
                                    Aciklamalar2.Add("DÄ°K YAKA")
                                Else
                                    Aciklamalar.Add("BEBE YAKA")
                                    Aciklamalar2.Add("BEBE YAKA")
                                End If

                                If If0Null(.Item("Cepli")) <> 0 Then
                                    Aciklamalar.Add("CEPLÄ°")
                                    Aciklamalar2.Add("CEPLÄ°")
                                Else
                                    Aciklamalar.Add("CEPSÄ°Z")
                                    Aciklamalar2.Add("CEPSÄ°Z")
                                End If
                            End With
                        End If

                    End If
                    'Aciklamalar.Add("------------------------------")

                    UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "010", "GOMLEK PARAMETRELERÄ°", Aciklamalar, "")
                    SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "010", "GOMLEK PARAMETRELERÄ°", Aciklamalar2, "")
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

            MasraflariUygula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub



    Private Sub NeoTable1_BeforeSave(ByVal sender As System.Object, ByRef e As NeoDAC.NeoTableSaveEventArgs) Handles NeoTable1.BeforeSave
        NeoTable1_ColumnChanged(Nothing, Nothing)

    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MasraflariUygula()
    End Sub
End Class
