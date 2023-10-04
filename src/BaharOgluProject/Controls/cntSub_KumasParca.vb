Public Class cntSub_KumasParca
    Public Bedendizi() As String = {"B24", "B26", "B28", "B30", "B32", "B34", "B36", "B38", "B40", "B42", "B44", "B46", "B48", "B50", "B52", "B54"}
    Public Property ParcaIsmi As String
        Get
            Return txtParcaIsmi.Text
        End Get
        Set(ByVal value As String)
            txtParcaIsmi.Text = value
        End Set
    End Property

    Dim dr As DataRow
    'Public DataColumns As DataColumnCollection
    Public Property Row As DataRow
        Get
            If Not GridControl1.DataSource Is Nothing Then
                dr("ParcaIsmi") = txtParcaIsmi.Text
                Dim dt As DataTable = GridControl1.DataSource
                For Each dr2 As DataRow In dt.Rows
                    dr(IfNull(dr2("Beden"), "")) = If0Null(dr2("Miktar"))
                    dr.EndEdit()
                Next
            End If
            Return dr
        End Get
        Set(ByVal value As DataRow)
            dr = value
        End Set
    End Property

    Public RowIndex As Integer = -1

    Public Function Initialize() As Boolean
        Try
            Dim dt As New DataTable
            dt.Columns.Add(New DataColumn("Beden", GetType(String)))
            dt.Columns.Add(New DataColumn("Miktar", GetType(Double)))
            txtParcaIsmi.Text = IfNull(dr("ParcaIsmi"), "")
            For i As Integer = 0 To Bedendizi.Length - 1
                Dim newdr As DataRow = dt.NewRow
                newdr("Beden") = Bedendizi(i)
                newdr("Miktar") = If0Null(dr(Bedendizi(i)))
                dt.Rows.Add(newdr)
            Next
            GridControl1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
End Class
