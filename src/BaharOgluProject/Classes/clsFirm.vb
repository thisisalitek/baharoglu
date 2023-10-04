
Public Class clsFirm
    Private mVar_FirmID As Long
    Private mVar_FirmCode As String
    Private mVar_FirmDefinition As String
    Private mVar_Addr1 As String
    Private mVar_Addr2 As String
    Private mVar_Town As String
    Private mVar_City As String
    Private mVar_Country As String
    Private mVar_TaxOffice As String
    Private mVar_TaxNumber As String
    Private mVar_Passive As Long
    Private mVar_ConnFirmID As Long

    Public Property FirmID() As Long
        Get
            Return mVar_FirmID
        End Get
        Set(ByVal value As Long)
            mVar_FirmID = value
        End Set
    End Property

    Public Property FirmCode() As String
        Get
            Return mVar_FirmCode
        End Get
        Set(ByVal value As String)
            mVar_FirmCode = value
        End Set
    End Property

    Public Property FirmDefinition() As String
        Get
            Return mVar_FirmDefinition
        End Get
        Set(ByVal value As String)
            mVar_FirmDefinition = value
        End Set
    End Property

    Public Property Addr1() As String
        Get
            Return mVar_Addr1
        End Get
        Set(ByVal value As String)
            mVar_Addr1 = value
        End Set
    End Property

    Public Property Addr2() As String
        Get
            Return mVar_Addr2
        End Get
        Set(ByVal value As String)
            mVar_Addr2 = value
        End Set
    End Property

    Public Property Town() As String
        Get
            Return mVar_Town
        End Get
        Set(ByVal value As String)
            mVar_Town = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return mVar_City
        End Get
        Set(ByVal value As String)
            mVar_City = value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return mVar_Country
        End Get
        Set(ByVal value As String)
            mVar_Country = value
        End Set
    End Property

    Public Property TaxOffice() As String
        Get
            Return mVar_TaxOffice
        End Get
        Set(ByVal value As String)
            mVar_TaxOffice = value
        End Set
    End Property

    Public Property TaxNumber() As String
        Get
            Return mVar_TaxNumber
        End Get
        Set(ByVal value As String)
            mVar_TaxNumber = value
        End Set
    End Property

    Public Property Passive() As Long
        Get
            Return mVar_Passive
        End Get
        Set(ByVal value As Long)
            mVar_Passive = value
        End Set
    End Property

    Public Property ConnFirmID() As Long
        Get
            Return mVar_ConnFirmID
        End Get
        Set(ByVal value As Long)
            mVar_ConnFirmID = value
        End Set
    End Property
End Class

