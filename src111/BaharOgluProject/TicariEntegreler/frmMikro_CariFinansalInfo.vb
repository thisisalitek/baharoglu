Public Class frmMikro_CariFinansalInfo 
    
    Public Sub FormShow(ByVal CariKod As String)
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class