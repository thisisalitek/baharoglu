Public Class clsFirmOffice
    Private mVar_FirmOfficeID As Guid
    Private mVar_FirmID As Long
    Private mVar_FirmOfficeCode As String
    Private mVar_FirmOfficeName As String
    Private mVar_Addr1 As String
    Private mVar_Addr2 As String
    Private mVar_Town As String
    Private mVar_City As String
    Private mVar_Country As String

    Private mVar_Tel1 As String
    Private mVar_Tel2 As String
    Private mVar_Fax As String
    Private mVar_Email1 As String
    Private mVar_Email2 As String
    Private mVar_URL As String
    Private mVar_NewRecordAuthCode As String

    Private mVar_Passive As Long


    Public Property FirmOfficeID() As Guid
        Get
            Return mVar_FirmOfficeID
        End Get
        Set(ByVal value As Guid)
            mVar_FirmOfficeID = value
        End Set
    End Property

    Public Property FirmID() As Long
        Get
            Return mVar_FirmID
        End Get
        Set(ByVal value As Long)
            mVar_FirmID = value
        End Set
    End Property

    Public Property FirmOfficeCode() As String
        Get
            Return mVar_FirmOfficeCode
        End Get
        Set(ByVal value As String)
            mVar_FirmOfficeCode = value
        End Set
    End Property

    Public Property FirmOfficeName() As String
        Get
            Return mVar_FirmOfficeName
        End Get
        Set(ByVal value As String)
            mVar_FirmOfficeName = value
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

    Public Property Tel1() As String
        Get
            Return mVar_Tel1
        End Get
        Set(ByVal value As String)
            mVar_Tel1 = value
        End Set
    End Property

    Public Property Tel2() As String
        Get
            Return mVar_Tel2
        End Get
        Set(ByVal value As String)
            mVar_Tel2 = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return mVar_Fax
        End Get
        Set(ByVal value As String)
            mVar_Fax = value
        End Set
    End Property

    Public Property Email1() As String
        Get
            Return mVar_Email1
        End Get
        Set(ByVal value As String)
            mVar_Email1 = value
        End Set
    End Property

    Public Property Email2() As String
        Get
            Return mVar_Email2
        End Get
        Set(ByVal value As String)
            mVar_Email2 = value
        End Set
    End Property

    Public Property URL() As String
        Get
            Return mVar_URL
        End Get
        Set(ByVal value As String)
            mVar_URL = value
        End Set
    End Property

    Public Property NewRecordAuthCode() As String
        Get
            Return mVar_NewRecordAuthCode
        End Get
        Set(ByVal value As String)
            mVar_NewRecordAuthCode = value
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


    Public Function Load(ByVal conn As SqlClient.SqlConnection, ByVal nID As Guid) As Boolean
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim bFound As Boolean = False
            cmd.Connection = conn
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@FirmOfficeID", nID))
            cmd.CommandText = "SELECT * FROM FirmOffice WHERE Deleted = 0 AND FirmOfficeID=@FirmOfficeID "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    FirmOfficeID = .Item("FirmOfficeID")
                    FirmOfficeCode = IfNull(.Item("FirmOfficeCode"), "")
                    FirmOfficeName = IfNull(.Item("FirmOfficeName"), "")
                    Addr1 = IfNull(.Item("Addr1"), "")
                    Addr2 = IfNull(.Item("Addr2"), "")
                    City = IfNull(.Item("City"), "")
                    'Town = IfNull(.Item("Town"), "")
                    Country = IfNull(.Item("Country"), "")
                    Tel1 = IfNull(.Item("Tel1"), "")
                    Tel2 = IfNull(.Item("Tel2"), "")
                    Fax = IfNull(.Item("Fax"), "")
                    Email1 = IfNull(.Item("Email1"), "")
                    Email2 = IfNull(.Item("Email2"), "")
                    URL = IfNull(.Item("Url"), "")
                    NewRecordAuthCode = IfNull(.Item("NewRecordAuthCode"), "")

                    Passive = If0Null(.Item("Passive"))
                End With
                bFound = True
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
            Return bFound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
End Class
