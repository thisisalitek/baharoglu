Public Class ClsMasraf
    Public MasrafKod As String
    Public MasrafIsmi As String
    Public bUygula As Boolean
    Public Fiyat As Double
    Public BedenFarki As Double
    Public Carpan As Integer = 1

    Sub New()
        MasrafKod = ""
        MasrafIsmi = ""
        bUygula = 0
        Fiyat = 0
        BedenFarki = 0
        Carpan = 1
    End Sub

    Sub New(ByVal MasrafKod_ As String, ByVal MasrafIsmi_ As String, ByVal bUygula_ As Boolean, ByVal Fiyat_ As Double)
        MasrafKod = MasrafKod_
        MasrafIsmi = MasrafIsmi_
        bUygula = bUygula_
        Fiyat = Fiyat_
        Carpan = 1
    End Sub
End Class
