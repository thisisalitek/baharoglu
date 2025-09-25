Public Class clsBeden
    Private mVar_Miktar As Double
    Private mVar_BedenKod As String

    Public Property Miktar() As Double
        Get
            Return mVar_Miktar
        End Get
        Set(ByVal value As Double)
            mVar_Miktar = value
        End Set
    End Property

    Public Property BedenKod() As String
        Get
            Return mVar_BedenKod
        End Get
        Set(ByVal value As String)
            mVar_BedenKod = value
        End Set
    End Property

    Dim mVar_BazBeden As Boolean
    Public Property BazBeden() As Boolean
        Get
            Return mVar_BazBeden
        End Get
        Set(ByVal value As Boolean)
            mVar_BazBeden = value
        End Set
    End Property

End Class
