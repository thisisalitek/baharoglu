Module modMikro
    Public Function GetCariBakiye(ByVal conn As SqlClient.SqlConnection, ByVal CariKod As String) As Double
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim Bakiye As Double = 0
            cmd.Connection = conn
            cmd.CommandText = "SELECT ISNULL(A,0) as A,ISNULL(B,0) as B,ISNULL(C,0) as C,ISNULL(D,0) as D,ISNULL(E,0) as E,ISNULL(F,0) as F FROM dbo.fn_CariHesapDurum('0',0,'" & CariKod & "',0,NULL,NULL,'','',0) "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Bakiye = Math.Round(If0Null(dt.Rows(0).Item("E")) - If0Null(dt.Rows(0).Item("F")), 2)
            End If
            da.Dispose()
            dt.Dispose()
            cmd.Dispose()
            Return Bakiye
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Public Function GetCariRiskBakiye(ByVal conn As SqlClient.SqlConnection, ByVal CariKod As String) As Double
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim Risk As Double = 0
            cmd.Connection = conn
            cmd.CommandText = "SELECT    ISNULL(SUM(mRisk), 0) AS mRisk  " &
                "            FROM         (SELECT     [#msg_S_1720] AS nTipNo, [msg_S_0300] AS dtVadeTarihi, [msg_S_1475\T] AS mRisk  " &
                "   FROM          dbo.fn_CariRiskFoyu(0, '" & CariKod & "', Getdate(), Getdate(),Getdate(), 0, '',0,0) ) XXX  " &
                "  WHERE     (nTipNo = 2 OR nTipNo = 4 OR nTipNo = 7) AND (dtVadeTarihi >= Getdate()) " &
                ""
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Risk = Math.Round(If0Null(dt.Rows(0).Item("mRisk")), 2)
            End If
            da.Dispose()
            dt.Dispose()
            cmd.Dispose()
            Return Risk
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Return 0
    End Function

End Module
