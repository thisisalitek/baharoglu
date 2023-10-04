Module modReport
    Public Class clsReportDesing
        Public ReportData As New IO.MemoryStream
        Public ReportSQL As String = ""
        Public AfterPrintSQL As String = ""
        Public ReportName As String = ""
        Public FormCode As String = ""
        Public ReportDataByteArray As Byte()
        Public ReportType As Long = 0
    End Class

    Public Function GetReportLayout(ByVal Conn As SqlClient.SqlConnection, ByVal ReportID As Guid) As clsReportDesing
        Dim cmd As New SqlClient.SqlCommand
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As New DataTable
        Dim cReportDesing As New clsReportDesing

        Try

            cmd.Connection = Conn
            cmd.CommandText = "SELECT * FROM Piconn_ReportDesigns WHERE ReportID = '" & ReportID.ToString & "'"
            dt = New DataTable
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                If IsDBNull(dt.Rows(0).Item("ReportData")) Then
                    cReportDesing.ReportData = New IO.MemoryStream
                Else
                    Dim b As Byte()
                    b = dt.Rows(0).Item("ReportData")
                    cReportDesing.ReportData = New IO.MemoryStream
                    cReportDesing.ReportData.Write(b, 0, b.Length)
                    cReportDesing.ReportDataByteArray = b

                End If
                If IsDBNull(dt.Rows(0).Item("ReportSQL")) Then
                    cReportDesing.ReportSQL = ""
                Else
                    Dim b As Byte()
                    b = dt.Rows(0).Item("ReportSQL")
                    Dim enc As New System.Text.UTF8Encoding
                    cReportDesing.ReportSQL = enc.GetString(b)
                End If

                If IsDBNull(dt.Rows(0).Item("AfterPrintSQL")) Then
                    cReportDesing.AfterPrintSQL = ""
                Else
                    Dim b As Byte()
                    b = dt.Rows(0).Item("AfterPrintSQL")
                    Dim enc As New System.Text.UTF8Encoding
                    cReportDesing.AfterPrintSQL = enc.GetString(b)
                End If
                cReportDesing.ReportName = IfNull(dt.Rows(0).Item("ReportName"), "")
                cReportDesing.FormCode = IfNull(dt.Rows(0).Item("FormCode"), "")
                cReportDesing.ReportType = If0Null(dt.Rows(0).Item("ReportType"))
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
        Catch ex As Exception

            MsgBox("(RefreshList) " & ex.Message)
        End Try
        Return cReportDesing
    End Function


End Module
