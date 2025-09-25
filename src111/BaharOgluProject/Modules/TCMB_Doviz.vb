Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Web
Imports System.Xml

Class dovizdata
    Public Property hata As String
    Public Property dvz As DataSet
End Class


Public Class TCMB_Doviz
    Private TCMB_DovizAdresURL As String = "http://www.tcmb.gov.tr/kurlar/today.xml"
    Public Currleri As String() = {"USD", "EUR", "GBP", "RUB"}
    Private dvzd As dovizdata = New dovizdata()




    Public Sub start()
        DovizKuruAl()
    End Sub

    Public Sub DovizKuruAl()
        Dim myComm As SqlCommand = New SqlCommand()
        Dim dta As SqlDataAdapter = New SqlDataAdapter(myComm)
        Dim dts As DataTable = New DataTable()
        myComm.Connection = AppConn.dbConn
        dvzd.hata = ""

        Try
            Dim sonTarih As DateTime = getSonDovizKuruTarihi()
            sonTarih = sonTarih.AddDays(1)

            While sonTarih.ToString("yyyy-MM-dd") <= DateTime.Today.ToString("yyyy-MM-dd")

                If sonTarih.DayOfWeek = DayOfWeek.Saturday OrElse sonTarih.DayOfWeek = DayOfWeek.Sunday Then
                Else

                    Try
                        Dim ds As DataSet = New DataSet()
                        ds.ReadXml(getDovizKurURL(sonTarih))
                        dvzd.dvz = ds
                        InsertKur(dvzd)
                    Catch ex As System.Exception
                    End Try
                End If

                sonTarih = sonTarih.AddDays(1)
            End While

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertKur(ByVal ddt As dovizdata)
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = AppConn.dbConn
            Dim dta As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            Dim kurtarihi As DateTime = Convert.ToDateTime(ddt.dvz.Tables(0).Rows(0)(1).ToString())
            kurtarihi = kurtarihi.AddDays(1)

            If kurtarihi.DayOfWeek = DayOfWeek.Saturday Then
                kurtarihi = kurtarihi.AddDays(2)
            ElseIf kurtarihi.DayOfWeek = DayOfWeek.Sunday Then
                kurtarihi = kurtarihi.AddDays(1)
            End If

            For Each rw As DataRow In ddt.dvz.Tables(1).Rows
                Dim Doviz As String = rw(10).ToString()

                If Currleri.Contains(Doviz) Then
                    cmd.CommandText = "SELECT COUNT(*) FROM DovizKurlari WHERE Curr='" & Doviz & "' AND CurrDate=" & SQLDateTime(kurtarihi)

                    If CInt(cmd.ExecuteScalar()) = 0 Then
                        Dim DovizAlis As Double = 0
                        Dim DovizSatis As Double = 0
                        Dim EfektifAlis As Double = 0
                        Dim EfektifSatis As Double = 0
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add(New SqlParameter("@Tarih", kurtarihi))
                        cmd.Parameters.Add(New SqlParameter("@Curr", Doviz))
                        DovizAlis = If(rw(3).ToString() <> "", Convert.ToDouble(rw(3).ToString().Replace(".", DecimalPointer)), 0)
                        DovizSatis = If(rw(4).ToString() <> "", Convert.ToDouble(rw(4).ToString().Replace(".", DecimalPointer)), 0)
                        EfektifAlis = If(rw(5).ToString() <> "", Convert.ToDouble(rw(5).ToString().Replace(".", DecimalPointer)), 0)
                        EfektifSatis = If(rw(6).ToString() <> "", Convert.ToDouble(rw(6).ToString().Replace(".", DecimalPointer)), 0)
                        cmd.Parameters.Add(New SqlParameter("@Alis", DovizAlis))
                        cmd.Parameters.Add(New SqlParameter("@Satis", DovizSatis))
                        cmd.Parameters.Add(New SqlParameter("@EAlis", EfektifAlis))
                        cmd.Parameters.Add(New SqlParameter("@ESatis", EfektifSatis))
                        cmd.CommandText = "INSERT INTO DovizKurlari (CreatedBy,CreatedDate,ModifiedBy,ModifiedDate, CurrDate, Curr, Rate1, Rate2, Rate3, Rate4) " & Environment.NewLine & " VALUES (0,GETDATE(),0,GETDATE(), @Tarih, @Curr, @Alis, @Satis, @EAlis, @ESatis) " + Environment.NewLine & ""
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function getSonDovizKuruTarihi() As DateTime
        Dim sonTarih As DateTime = New DateTime(DateTime.Today.Year, 1, 1)
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = AppConn.dbConn

        cmd.CommandText = "SELECT MAX(CurrDate) FROM DovizKurlari "
        Dim varSonTarih = cmd.ExecuteScalar()

        If IsDBNull(varSonTarih) = False Then
            sonTarih = CType(varSonTarih, DateTime)
        End If

        Return sonTarih
    End Function

    Private Function getDovizKurURL(ByVal tarih As DateTime) As String
        Return "http://www.tcmb.gov.tr/kurlar/" & tarih.ToString("yyyyMM") & "/" + tarih.ToString("ddMMyyyy") & ".xml"
    End Function

    Public Function getDovizKur(Doviz As String, Tarih As DateTime) As Double
        Try
            If (Doviz.Trim() = "" Or Doviz.Trim() = "TL") Then
                Return 1
            End If
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable

            cmd.Connection = AppConn.dbConn
            cmd.Parameters.AddWithValue("@Doviz", Doviz)
            cmd.Parameters.AddWithValue("@Tarih", Tarih)

            cmd.CommandText = "SELECT TOP 1 * FROM DovizKurlari WHERE CurrDate<=@Tarih AND Curr=@Doviz ORDER BY CurrDate DESC"
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return dt.Rows(0)("Rate2")
            Else
                Return 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 1
    End Function



End Class



