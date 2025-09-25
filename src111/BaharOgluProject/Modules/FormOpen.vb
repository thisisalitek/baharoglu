

Module FormOpen
    Public Sub MenuShowForm(ByVal Owner As Form, ByVal FormCode As String)
        Try

            Select Case FormCode
                Case "000001"
                    Dim f As New frmRenkler
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)
                Case "000002"
                    Dim f As New frmOrguTipi
                    f.FormCode = FormCode

                    f.FormShow_Normal(False)
                Case "000003"
                    Dim f As New frmIplik
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)
                Case "000004"
                    Dim f As New frmKategoriler
                    f.FormCode = FormCode

                    f.FormShow()

                Case "000005"
                    Dim f As New frmOkullar
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000006"
                    Dim f As New frmIl
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000007"
                    Dim f As New frmIlce
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)


                Case "000008"
                    Dim f As New frmSiparisler
                    f.FormCode = FormCode

                    f.FormShow_CariSiparis(False, False, , Owner)

                Case "000009"
                    Dim f As New frmCizgiRKafa
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000010"
                    Dim f As New frmCizgiRKafaLakos
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000011"
                    Dim f As New frmFasonTanim
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000012"
                    Dim f As New frmUsers
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000013"
                    Dim f As New frmKumasKatalog
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000014"
                    Dim f As New frmDigerKumaslar
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000015"
                    Dim f As New frmOrguTipi
                    f.FormCode = FormCode

                    f.FormShow_Lakos(False)

                'Case "000016"
                '    Dim f As New frmSiparisUretimBilgi
                '    f.FormCode = FormCode

                '    f.FormShow(False, Owner)

                Case "000017"
                    Dim f As New frmSiparisRaporu
                    f.FormCode = FormCode

                    f.FormShow(False, Owner)

                Case "000018"
                    Dim f As New frmSiparisler
                    f.FormCode = FormCode

                    f.FormShow_DepoSiparis(False, False, , Owner)

                Case "000019"
                    Dim f As New frmSevkler
                    f.FormCode = FormCode

                    f.FormShow_Irsaliye(False, False, , Owner)

                Case "000020"
                    Dim f As New frmKargolar
                    f.FormCode = FormCode

                    f.FormShow(False, False, , Owner)

                Case "000021"
                    Dim f As New frmSevkler
                    f.FormCode = FormCode

                    f.FormShow_DepoSevk(False, False, , Owner)

                Case "000022"
                    Dim f As New frmAlimIrsaliyeleri
                    f.FormCode = FormCode

                    f.FormShow(False)
                Case "000023"
                    Dim f As New frmHammaddeAyarlar
                    f.FormCode = FormCode

                    f.FormShow()

                Case "000024"
                    Dim f As New frmSiparisToplamRaporu
                    f.FormCode = FormCode

                    f.FormShow(False, Owner)

                Case "000025"
                    Dim f As New frmSevkler
                    f.FormCode = FormCode

                    f.FormShow_Irsaliye(False)
                Case "000026"
                    Dim f As New frmSevkler
                    f.FormCode = FormCode

                    f.FormShow_DepoSevk(False)
                Case "000027"
                    Dim f As New frmFason
                    f.FormCode = FormCode

                    f.FormShow(False)
                Case "000028"
                    Dim f As New frmSaticilar
                    f.FormCode = FormCode

                    f.FormShow(False)

                Case "000029"
                    Dim f As New frmPlanlananTahsilatVeOdemeler
                    f.FormCode = FormCode

                    f.FormShow(False)

                Case "000030"
                    Dim f As New frmKategoriReport
                    f.FormCode = FormCode

                    f.FormShow(False)
                Case "000031"
                    Dim f As New frmDovizKurlari
                    f.FormCode = FormCode

                    f.FormShow(False)
                Case "000032"
                    Dim f As New frmUrunToplamRaporu
                    f.FormCode = FormCode

                    f.FormShow(False)
                Case "E00001"
                    Dim f As New frmMikro_Cariler
                    f.FormCode = FormCode

                    f.FormShow(False, Owner)

                Case "E00002"
                    Dim f As New frmMikro_Depolar
                    f.FormCode = FormCode

                    f.FormShow(False, Owner)

                Case Else
                    'If UCase(Mid(FormCode, 1, 3)) = "USR" Then
                    '    Dim f As New frmUserReportForm
                    '    f.FormCode = FormCode
                    '    
                    '    f.UserFormShow(False)
                    'End If
            End Select


        Catch ex As Exception
            MsgBox("FormCode:" & FormCode & " Hata:" & ex.Message)
        End Try

    End Sub

End Module
