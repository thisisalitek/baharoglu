Public Class cnt054_GarniDikis
    Dim bNoAction As Boolean = False

    Private Sub cnt054_GarniDikis_Initialize_Control(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control
        Try

            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafa.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafa)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)
           


            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable2)

            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("GarniDikis") = 0
              
                NeoTable2.Rows.Add(newdr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cnt054_GarniDikis_Initialize_Control_ForAppMode(ByVal sender As System.Windows.Forms.Control, ByVal e As System.EventArgs) Handles Me.Initialize_Control_ForAppMode
        Try


            tbRenk.Connection = Me.SqlConn
            OpenTable(tbRenk)
            tbCizgiRenkKafa.Connection = Me.SqlConn
            OpenTable(tbCizgiRenkKafa)
            tbIplik.Connection = Me.SqlConn
            OpenTable(tbIplik)
           

            NeoTable2.Connection = Me.SqlConn
            NeoTable2.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
            OpenTable(NeoTable2)


            If NeoTable2.Rows.Count <= 0 Then
                Dim newdr As DataRow = NeoTable2.NewRow
                newdr("GarniDikis") = 0

                NeoTable2.Rows.Add(newdr)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cnt054_GarniDikis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cnt054_GarniDikis_Save_Control(ByVal sender As System.Windows.Forms.Control, ByRef e As Module1.SaveEventArgs) Handles Me.Save_Control
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = SqlConn.SqlConnection

            If ApplicationMode = False Then
                For Each dr As DataRow In NeoTable2.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable2.Save()
            Else
                For Each dr As DataRow In NeoTable2.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                      
                        'dr("SipDetayParamID") = SipDetayParamID
                        dr("KategoriParamID") = KategoriParamID
                    End If
                Next
                NeoTable2.Save()
                If If0Null(NeoTable2.Rows(0).Item("GarniDikis")) > 0 Then
                    If (If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 And If0Null(MasterTable2.Rows(0).Item("bVar")) = 1) Or If0Null(MasterTable.Rows(0).Item("Secmeli")) = 0 Then
                        Dim Aciklamalar As New ArrayList
                        Dim Aciklamalar2 As New ArrayList
                        Dim sbuf As String = ""
                        Select Case If0Null(NeoTable2.Rows(0).Item("GarniDikis"))
                            Case 1 : sbuf = "REÇMELİ"
                            Case 2 : sbuf = "OVERLOKLU"
                            Case 3 : sbuf = "KARYOKALI"

                        End Select
                        Aciklamalar.Add("GARNİ DİKİŞ:" & sbuf)
                        Aciklamalar2.Add("GARNİ DİKİŞ:" & sbuf)
                        UretimBilgiYaz(SqlConn.SqlConnection, SipDetayID, "054", "GARNİ DİKİŞ", Aciklamalar, "")
                        SiparisBilgiYaz(SqlConn.SqlConnection, SipDetayID, "054", "GARNİ DİKİŞ", Aciklamalar2, "")
                    End If
                End If

                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub NeoTable1_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles NeoTable2.ColumnChanged
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


    Private Sub NeoTable1_BeforeSave(ByVal sender As System.Object, ByRef e As NeoDAC.NeoTableSaveEventArgs) Handles NeoTable2.BeforeSave
        NeoTable1_ColumnChanged(Nothing, Nothing)

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



   
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
