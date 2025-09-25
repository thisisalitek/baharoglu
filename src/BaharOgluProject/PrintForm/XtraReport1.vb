Imports DevExpress.XtraPrinting

Public Class XtraReport1

    Private _isPrinted As Boolean = False
    Public Property isPrinted() As Boolean
        Get
            Return _isPrinted
        End Get
        Set(ByVal value As Boolean)
            _isPrinted = value
        End Set
    End Property
    Private Sub XtraReport1_PrintProgress(sender As Object, e As PrintProgressEventArgs) Handles Me.PrintProgress
        Me.isPrinted = True

    End Sub
End Class