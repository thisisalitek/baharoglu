'Imports PiconnUtility.dynamoEmpire.PiconnUtility


Public Module modSQLFunctions

    Public glb_OpenningTable As Boolean = False

    Public Function OpenTable(ByRef bufTable1 As NeoDAC.NeoTable) As Boolean
        'Try
        If bufTable1 Is Nothing Then Return False

        If Not bufTable1.SelectCommand Is Nothing Then
            bufTable1.SelectCommand.CommandTimeout = 1800
        End If
        If Not bufTable1.InsertCommand Is Nothing Then
            bufTable1.InsertCommand.CommandTimeout = 1800
        End If
        If Not bufTable1.UpdateCommand Is Nothing Then
            bufTable1.UpdateCommand.CommandTimeout = 1800
        End If
        If Not bufTable1.DeleteCommand Is Nothing Then
            bufTable1.DeleteCommand.CommandTimeout = 1800
        End If
        If bufTable1.Active Then
            bufTable1.Close()
        End If
        bufTable1.Open()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Function



    Public Function NewFicheNo(ByVal conn As NeoDAC.NeoConnection, ByVal TableName As String, ByVal FieldName As String, Optional ByVal NumberFormat As String = "", Optional ByVal sDefaultNo As String = "", Optional ByVal Filter As String = "AND Deleted=0", Optional ByVal bWITHNOLOCK As Boolean = False, Optional ByVal bUCaseEng As Boolean = False, Optional ByVal Trans As SqlClient.SqlTransaction = Nothing) As String
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim NewNo As String = ""
            Dim WithNoLock As String = ""
            If bWITHNOLOCK Then
                WithNoLock = " WITH (NOLOCK) "
            End If
            cmd.Connection = conn.SqlConnection
            NumberFormat = Replace(NumberFormat, "'", " ")
            If InStr(NumberFormat, "_") <= 0 Then
                NumberFormat &= "%"
            End If
            cmd.Transaction = Trans
            cmd.CommandText = "SELECT TOP 1 " & FieldName & " FROM " & TableName & " " & WithNoLock & " WHERE " & FieldName & " like '" & NumberFormat & "' " & Filter & " ORDER BY " & FieldName & " DESC"
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                NewNo = IfNull(dt.Rows(0).Item(FieldName), "")
            End If
            dt.Dispose()
            da.Dispose()

            If Trim(NewNo) = "" Then
                If sDefaultNo <> "" Then
                    NewNo = sDefaultNo
                Else
                    NewNo = Replace(NumberFormat, "_", "0")
                    NewNo = IncBelgeNo(NewNo)
                End If
            Else
                NewNo = IncBelgeNo(NewNo)
            End If
            Dim nTekrar As Integer = 0

            If bUCaseEng Then
                NewNo = UCaseEng(NewNo)
            End If
Tekrar:

            cmd.CommandText = "SELECT TOP 1 " & FieldName & " FROM " & TableName & " " & WithNoLock & " WHERE " & FieldName & " = '" & NewNo & "' " & Filter & " "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'NewNo = IfNull(dt.Rows(0).Item(FieldName), "")
                NewNo = IncBelgeNo(NewNo)


                nTekrar += 1
                If nTekrar < 10 Then
                    GoTo Tekrar
                End If
            End If
            dt.Dispose()
            da.Dispose()

            cmd.Dispose()
            Return NewNo
        Catch ex As Exception
            'MsgBox("(NewFicheNo) TableName:" & TableName & " FieldName:" & FieldName & vbNewLine & ex.Message)
        End Try
        Return ""
    End Function

    Public Function SipDetayRenkler(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "IF NOT EXISTS(SELECT * FROM SipDetayRenkler WHERE SipDetayID=" & SipDetayID & ") BEGIN " & vbNewLine & _
                                  " INSERT INTO SipDetayRenkler (Deleted,CreatedDate,ModifiedDate,SipDetayID) " & vbNewLine & _
                                  " VALUES (0,GETDATE(),GETDATE()," & SipDetayID & ")" & vbNewLine & _
                                  " END "
            cmd.ExecuteNonQuery()

            If SipDetayRenkler_002_Lastik(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_003_Yaka(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_004_DubleLastikCep(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_005_DubleLastikPilotYaka(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_006_DubleLastik(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_007_DubleYaka(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_012_Lakos(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_013_Manset2cm(conn, SipDetayID, trans) = False Then
                Return False
            End If

            If SipDetayRenkler_014_Manset6cm(conn, SipDetayID, trans) = False Then
                Return False
            End If
            If SipDetayRenkler_018_EtekManseti(conn, SipDetayID, trans) = False Then
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_002_Lastik(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim RenkKol As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod , Renkler2.RenkKod as RenkKod2 FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '002' LEFT OUTER JOIN " & vbNewLine & _
                " Renkler Renkler2 ON SipDetayParam.RenkID2 = Renkler2.RenkID AND SipDetayParam.ParamType = '002' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
                RenkKol = Replace(IfNull(dt.Rows(0).Item("RenkKod2"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_002_Lastik.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_002_Lastik INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_002_Lastik.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_002_Lastik.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_002_Lastik.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(0).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(0).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()

                cmd.CommandText = "SELECT SipDetayParam_002_Lastik_Kol.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_002_Lastik_Kol INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_002_Lastik_Kol.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_002_Lastik_Kol.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_002_Lastik_Kol.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    CizgiRenkler &= " KOL:"
                End If
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If


            If Trim(RenkKol) <> "" Then
                Renk = Mid(Renk & "/Kol:" & RenkKol, 1, 50)
            Else
                Renk = Mid(Renk, 1, 50)
            End If

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R002_Lastik='" & Renk & "' , R002_LastikCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_002_Lastik) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_003_Yaka(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '003' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_003_Yaka.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_003_Yaka INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_003_Yaka.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_003_Yaka.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_003_Yaka.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()

            
            End If

            Renk = Mid(Renk, 1, 50)

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R003_Yaka='" & Renk & "' , R003_YakaCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_003_Yaka) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_004_DubleLastikCep(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '004' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_004_DubleLastikCep.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_004_DubleLastikCep INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_004_DubleLastikCep.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_004_DubleLastikCep.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_004_DubleLastikCep.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If

            Renk = Mid(Renk, 1, 50)

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R004_DubleLastikCep='" & Renk & "' , R004_DubleLastikCepCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_004_DubleLastikCep) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_005_DubleLastikPilotYaka(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '005' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_005_DubleLastikPilotYaka.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_005_DubleLastikPilotYaka INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_005_DubleLastikPilotYaka.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_005_DubleLastikPilotYaka.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_005_DubleLastikPilotYaka.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If

            Renk = Mid(Renk, 1, 50)

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R005_DubleLastikPilotYaka='" & Renk & "' , R005_DubleLastikPilotYakaCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_005_DubleLastikPilotYaka) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_006_DubleLastik(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim RenkKol As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod , Renkler2.RenkKod as RenkKod2 FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '006' LEFT OUTER JOIN " & vbNewLine & _
                " Renkler Renkler2 ON SipDetayParam.RenkID2 = Renkler2.RenkID AND SipDetayParam.ParamType = '006' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
                RenkKol = Replace(IfNull(dt.Rows(0).Item("RenkKod2"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_006_DubleLastik.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_006_DubleLastik INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_006_DubleLastik.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_006_DubleLastik.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_006_DubleLastik.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(0).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(0).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()

                cmd.CommandText = "SELECT SipDetayParam_006_DubleLastik_Kol.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_006_DubleLastik_Kol INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_006_DubleLastik_Kol.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_006_DubleLastik_Kol.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_006_DubleLastik_Kol.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    CizgiRenkler &= " KOL:"
                End If
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If


            If Trim(RenkKol) <> "" Then
                Renk = Mid(Renk & "/Kol:" & RenkKol, 1, 50)
            Else
                Renk = Mid(Renk, 1, 50)
            End If

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R006_DubleLastik='" & Renk & "' , R006_DubleLastikCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_002_Lastik) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_007_DubleYaka(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '007' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_007_DubleYaka.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_007_DubleYaka INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_007_DubleYaka.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_007_DubleYaka.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_007_DubleYaka.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If

            Renk = Mid(Renk, 1, 50)

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R007_DubleYaka='" & Renk & "' , R007_DubleYakaCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_007_DubleYaka) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_008_TorbaliBant(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim SipDetayParamID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParam.SipDetayParamID, SipDetayParam.SipDetayID,Renkler.RenkKod FROM SipDetayParam INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam.RenkID = Renkler.RenkID  AND SipDetayParam.ParamType = '008' " & vbNewLine & _
                "  WHERE SipDetayParam.SipDetayID = " & SipDetayID

            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                SipDetayParamID = If0Null(dt.Rows(0).Item("SipDetayParamID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If SipDetayParamID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT SipDetayParam_008_TorbaliBant.CizgiSayisi , Renkler.RenkKod   FROM SipDetayParam_008_TorbaliBant INNER JOIN " & vbNewLine & _
                    " Renkler ON SipDetayParam_008_TorbaliBant.RenkID = Renkler.RenkID  " & vbNewLine & _
                    " WHERE SipDetayParam_008_TorbaliBant.SipDetayParamID = " & SipDetayParamID & " " & vbNewLine & _
                    " ORDER BY SipDetayParam_008_TorbaliBant.CizgiSayisi"

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiSayisi")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If

            Renk = Mid(Renk, 1, 50)

            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R008_TorbaliBant='" & Renk & "' , R008_TorbaliBantCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_008_TorbaliBant) : " & ex.Message)
        End Try
        Return False
    End Function


    Private Function SipDetayRenkler_012_Lakos(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim nID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT Renkler.RenkKod ,SipDetayParam_012_LakosYaka.nID FROM SipDetayParam_012_LakosYaka INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam_012_LakosYaka.RenkID = Renkler.RenkID INNER JOIN " & vbNewLine & _
                " SipDetayParam ON SipDetayParam_012_LakosYaka.SipDetayParamID = SipDetayParam.SipDetayParamID " & vbNewLine & _
                " WHERE  SipDetayParam.SipDetayID=" & SipDetayID
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
               
                nID = If0Null(dt.Rows(0).Item("nID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If nID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT Renkler.RenkKod , SipDetayParam_012_LakosYaka_Cizgiler.CizgiNo FROM SipDetayParam_012_LakosYaka_Cizgiler INNER JOIN " & vbNewLine & _
                   " Renkler ON SipDetayParam_012_LakosYaka_Cizgiler.RenkID = Renkler.RenkID  " & vbNewLine & _
                   " WHERE  SipDetayParam_012_LakosYaka_Cizgiler.LakosYakaID=" & nID & " " & vbNewLine & _
                   " ORDER BY SipDetayParam_012_LakosYaka_Cizgiler.CizgiNo "
                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiNo")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If
            Renk = Mid(Renk, 1, 50)
            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R012_LakosYaka='" & Renk & "' , R012_LakosYakaCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_012_Lakos) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_013_Manset2cm(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim nID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT Renkler.RenkKod ,SipDetayParam_013_Manset2cm.nID FROM SipDetayParam_013_Manset2cm INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam_013_Manset2cm.RenkID = Renkler.RenkID INNER JOIN " & vbNewLine & _
                " SipDetayParam ON SipDetayParam_013_Manset2cm.SipDetayParamID = SipDetayParam.SipDetayParamID " & vbNewLine & _
                " WHERE  SipDetayParam.SipDetayID=" & SipDetayID
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                nID = If0Null(dt.Rows(0).Item("nID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If nID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT Renkler.RenkKod , SipDetayParam_013_Manset2cm_Cizgiler.CizgiNo FROM SipDetayParam_013_Manset2cm_Cizgiler INNER JOIN " & vbNewLine & _
                   " Renkler ON SipDetayParam_013_Manset2cm_Cizgiler.RenkID = Renkler.RenkID  " & vbNewLine & _
                   " WHERE  SipDetayParam_013_Manset2cm_Cizgiler.Manset2cmID=" & nID & " " & vbNewLine & _
                   " ORDER BY SipDetayParam_013_Manset2cm_Cizgiler.CizgiNo "
                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiNo")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If
            Renk = Mid(Renk, 1, 50)
            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R013_Manset2cm='" & Renk & "' , R013_Manset2cmCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_013_Manset2cm) : " & ex.Message)
        End Try
        Return False
    End Function

    Private Function SipDetayRenkler_014_Manset6cm(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim nID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT Renkler.RenkKod ,SipDetayParam_014_Manset6cm.nID FROM SipDetayParam_014_Manset6cm INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam_014_Manset6cm.RenkID = Renkler.RenkID INNER JOIN " & vbNewLine & _
                " SipDetayParam ON SipDetayParam_014_Manset6cm.SipDetayParamID = SipDetayParam.SipDetayParamID " & vbNewLine & _
                " WHERE  SipDetayParam.SipDetayID=" & SipDetayID
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                nID = If0Null(dt.Rows(0).Item("nID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If nID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT Renkler.RenkKod , SipDetayParam_014_Manset6cm_Cizgiler.CizgiNo FROM SipDetayParam_014_Manset6cm_Cizgiler INNER JOIN " & vbNewLine & _
                   " Renkler ON SipDetayParam_014_Manset6cm_Cizgiler.RenkID = Renkler.RenkID  " & vbNewLine & _
                   " WHERE  SipDetayParam_014_Manset6cm_Cizgiler.Manset6cmID=" & nID & " " & vbNewLine & _
                   " ORDER BY SipDetayParam_014_Manset6cm_Cizgiler.CizgiNo "
                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiNo")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If
            Renk = Mid(Renk, 1, 50)
            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R014_Manset6cm='" & Renk & "' , R014_Manset6cmCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_014_Manset6cm) : " & ex.Message)
        End Try
        Return False
    End Function


    Private Function SipDetayRenkler_018_EtekManseti(conn As SqlClient.SqlConnection, SipDetayID As Long, Optional trans As SqlClient.SqlTransaction = Nothing)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim nID As Long = 0
            Dim Renk As String = ""
            Dim CizgiRenkler As String = ""
            cmd.Connection = conn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT Renkler.RenkKod ,SipDetayParam_018_EtekManset.nID FROM SipDetayParam_018_EtekManset INNER JOIN " & vbNewLine & _
                " Renkler ON SipDetayParam_018_EtekManset.RenkID = Renkler.RenkID INNER JOIN " & vbNewLine & _
                " SipDetayParam ON SipDetayParam_018_EtekManset.SipDetayParamID = SipDetayParam.SipDetayParamID " & vbNewLine & _
                " WHERE  SipDetayParam.SipDetayID=" & SipDetayID
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                nID = If0Null(dt.Rows(0).Item("nID"))
                Renk = Replace(IfNull(dt.Rows(0).Item("RenkKod"), ""), "'", " ")
            End If
            dt.Dispose()
            da.Dispose()

            If nID > 0 Then
                CizgiRenkler = ""
                cmd.CommandText = "SELECT Renkler.RenkKod , SipDetayParam_018_EtekManset_Cizgiler.CizgiNo FROM SipDetayParam_018_EtekManset_Cizgiler INNER JOIN " & vbNewLine & _
                   " Renkler ON SipDetayParam_018_EtekManset_Cizgiler.RenkID = Renkler.RenkID  " & vbNewLine & _
                   " WHERE  SipDetayParam_018_EtekManset_Cizgiler.EtekMansetID=" & nID & " " & vbNewLine & _
                   " ORDER BY SipDetayParam_018_EtekManset_Cizgiler.CizgiNo "
                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    CizgiRenkler &= "Ç" & If0Null(dt.Rows(i).Item("CizgiNo")) & ":" & IfNull(dt.Rows(i).Item("RenkKod"), "")
                    If i < dt.Rows.Count - 1 Then
                        CizgiRenkler &= " / "
                    End If
                Next
                dt.Dispose()
                da.Dispose()
            End If
            Renk = Mid(Renk, 1, 50)
            CizgiRenkler = Mid(CizgiRenkler, 1, 100)
            cmd.CommandText = " UPDATE SipDetayRenkler SET R018_EtekManseti='" & Renk & "' , R018_EtekMansetiCizgiler='" & CizgiRenkler & "' WHERE SipDetayID=" & SipDetayID & " "
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("(SipDetayRenkler_018_EtekManseti) : " & ex.Message)
        End Try
        Return False
    End Function



    Public Function GetUserFullName(ByVal conn As SqlClient.SqlConnection, ByVal UserID As Long) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM Users WHERE Deleted = 0 AND UserID=" & UserID
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                sbuf = IfNull(dt.Rows(0).Item("FullName"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Function UretimBilgiYaz(ByVal conn As SqlClient.SqlConnection, ByVal SipDetayID As Long, ByVal GrupKod As String, ByVal GrupIsmi As String, ByVal Aciklamalar As ArrayList, AnaRenk As String, Optional ByVal bTemizle As Boolean = True) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@SipDetayID", SipDetayID))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@GrupKod", Mid(GrupKod, 1, 20)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@GrupIsmi", Mid(GrupIsmi, 1, 50)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Aciklama", ""))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@AnaRenk", Mid(AnaRenk, 1, 100)))
            If bTemizle Then
                cmd.CommandText = "DELETE FROM SipDetayUretimBilgi WHERE SipDetayID=@SipDetayID AND GrupKod=@GrupKod "
                cmd.ExecuteNonQuery()
            End If
            Dim bIlk As Boolean = True
            Dim Reserve1 As String = ""
            For Each Aciklama As String In Aciklamalar
                If bIlk = True Then
                    Reserve1 = "1"
                    bIlk = False
                Else
                    Reserve1 = ""
                End If
                cmd.Parameters("@Aciklama").Value = Mid(Aciklama, 1, 250)
                cmd.CommandText = "INSERT INTO SipDetayUretimBilgi (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, GrupKod,GrupIsmi, Aciklama,AnaRenk,Reserve1,Reserve2,Reserve3) VALUES " & _
                    "( 0, 1, GETDATE(), 1,  GETDATE(), @SipDetayID, @GrupKod, @GrupIsmi, @Aciklama ,@AnaRenk,'" & Reserve1 & "','','' )"
                cmd.ExecuteNonQuery()
            Next
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Function SiparisBilgiYaz(ByVal conn As SqlClient.SqlConnection, ByVal SipDetayID As Long, ByVal GrupKod As String, ByVal GrupIsmi As String, ByVal Aciklamalar As ArrayList, AnaRenk As String, Optional ByVal bTemizle As Boolean = True) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@SipDetayID", SipDetayID))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@GrupKod", Mid(GrupKod, 1, 20)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@GrupIsmi", Mid(GrupIsmi, 1, 50)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Aciklama", ""))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@AnaRenk", Mid(AnaRenk, 1, 100)))
            If bTemizle Then
                cmd.CommandText = "DELETE FROM SipDetayBilgi WHERE SipDetayID=@SipDetayID AND GrupKod=@GrupKod "
                cmd.ExecuteNonQuery()
            End If
            Dim bIlk As Boolean = True
            Dim Reserve1 As String = ""
            For Each Aciklama As String In Aciklamalar
                If bIlk = True Then
                    Reserve1 = "1"
                    bIlk = False
                Else
                    Reserve1 = ""
                End If
                cmd.Parameters("@Aciklama").Value = Mid(Aciklama, 1, 250)
                cmd.CommandText = "INSERT INTO SipDetayBilgi (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, GrupKod,GrupIsmi, Aciklama,AnaRenk,Reserve1,Reserve2,Reserve3) VALUES " & _
                    "( 0, 1, GETDATE(), 1,  GETDATE(), @SipDetayID, @GrupKod, @GrupIsmi, @Aciklama ,@AnaRenk,'" & Reserve1 & "','','' )"
                cmd.ExecuteNonQuery()
            Next
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function


    Public Function GetIplikKodIsim(ByVal conn As SqlClient.SqlConnection, ByVal IplikID As Long) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT     IplikKod , IplikIsmi " & _
                "FROM         Iplikler " & _
                "WHERE     (Deleted = 0) AND (IplikID = " & IplikID & ") "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'sbuf = IfNull(dt.Rows(0).Item("IplikKod"), "") & "-" & IfNull(dt.Rows(0).Item("IplikIsmi"), "")
                sbuf = IfNull(dt.Rows(0).Item("IplikIsmi"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Function GetRenkKodIsim(ByVal conn As SqlClient.SqlConnection, ByVal RenkID As Long) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT     RenkKod , RenkIsmi " & _
                "FROM         Renkler " & _
                "WHERE     (Deleted = 0) AND (RenkID = " & RenkID & ") "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                sbuf = IfNull(dt.Rows(0).Item("RenkKod"), "") '& "-" & IfNull(dt.Rows(0).Item("RenkIsmi"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function


    Public Function GetOrguTip(ByVal conn As SqlClient.SqlConnection, ByVal OrguTipID As Long) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT     OrguTipKod , OrguTipIsmi " & _
                "FROM         OrguTipleri " & _
                "WHERE     (Deleted = 0) AND (OrguTipID = " & OrguTipID & ") "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'sbuf = IfNull(dt.Rows(0).Item("OrguTipKod"), "") & "-" & IfNull(dt.Rows(0).Item("OrguTipIsmi"), "")
                sbuf = IfNull(dt.Rows(0).Item("OrguTipKod"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Function GetKategoriKod(ByVal conn As SqlClient.SqlConnection, ByVal KategoriID As Long) As String
        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT  KategoriKod FROM Kategoriler WHERE Deleted = 0 AND KategoriID=" & KategoriID & " "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                sbuf = IfNull(dt.Rows(0).Item("KategoriKod"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""

    End Function

    Public Function GetKumasKatalogKodIsim(ByVal conn As SqlClient.SqlConnection, ByVal KumasKatalogID As Long) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT     KatalogKod , KatalogIsmi " & _
                "FROM         KumasKatalogu " & _
                "WHERE     (Deleted = 0) AND (KumasKatalogID = " & KumasKatalogID & ") "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'sbuf = IfNull(dt.Rows(0).Item("KatalogKod"), "") & "-" & IfNull(dt.Rows(0).Item("KatalogIsmi"), "")
                sbuf = IfNull(dt.Rows(0).Item("KatalogKod"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Function GetKumasKodIsim(ByVal conn As SqlClient.SqlConnection, ByVal KumasID As Long) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            Dim sbuf As String = ""
            cmd.Connection = conn
            cmd.CommandText = "SELECT     KumasKod , KumasIsmi " & _
                "FROM         Kumaslar " & _
                "WHERE     (Deleted = 0) AND (KumasID = " & KumasID & ") "
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'sbuf = IfNull(dt.Rows(0).Item("KumasKod"), "") & "-" & IfNull(dt.Rows(0).Item("KumasIsmi"), "")
                sbuf = IfNull(dt.Rows(0).Item("KumasKod"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return sbuf
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Function RelationControl(ByVal conn As NeoDAC.NeoConnection, ByVal Table1IDValue As Object, ByVal Table2 As String, ByVal Table2FieldName As String, Optional ByVal AdditionalFilter As String = "") As Boolean
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            Dim count As Long
            cmd.Connection = conn.SqlConnection
            cmd.Parameters.Add(New SqlClient.SqlParameter("@" & Table2FieldName, Table1IDValue))
            cmd.CommandText = "SELECT COUNT(*) FROM " & Table2 & " WHERE Deleted = 0 AND " & Table2FieldName & " = @" & Table2FieldName & " " & AdditionalFilter
            count = If0Null(cmd.ExecuteScalar)
            cmd.Dispose()
            If count > 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox("(RelationControl) " & ex.Message)
        End Try
        Return False
    End Function


    Public Function GetIrsaliyeTypes() As DataTable
        Try
            Dim dt As New DataTable
            dt.Columns.Add(New DataColumn("DisplayMember", GetType(String)))
            dt.Columns.Add(New DataColumn("ValueMember", GetType(String)))
            Dim dr As DataRow
            dr = dt.NewRow
            dr("DisplayMember") = "Alım Irsaliyesi"
            dr("ValueMember") = 0
            dt.Rows.Add(dr)

            dr = dt.NewRow
            dr("DisplayMember") = "Devir"
            dr("ValueMember") = 1
            dt.Rows.Add(dr)

            dr = dt.NewRow
            dr("DisplayMember") = "Uretimden Iade"
            dr("ValueMember") = 2
            dt.Rows.Add(dr)

            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return New DataTable
    End Function
End Module


Public Structure typeTripleAmount
    Public Amount As Double
    Public Amount2 As Double
    Public Amount3 As Double
    Public bError As Boolean
    Public ErrorString As String
End Structure

Public Structure typeBalance
    Public Debit As Double
    Public Credit As Double
    Public Balance As Double
    Public bError As Boolean
    Public ErrorString As String
    Public DueDate As Date
    Public DueDay As Double
End Structure

Public Enum typeVariant
    VariantA = 1
    VariantB = 2
    VariantC = 3
End Enum