Module modCopySiparis
    Public Function CopySiparis(ByVal SiparisID As Long, UserID As Long) As Long
        Dim trans As SqlClient.SqlTransaction
        Try
            Dim NewSiparisID As Long = 0
            trans = AppConn.dbConn.BeginTransaction
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim Seri As String = "A"
            Dim Sira As Long = 0
            cmd.Connection = AppConn.dbConn
            cmd.Transaction = trans


            cmd.CommandText = "Select TOP 1 S.SipEvrakSeri,L.Sira  FROM Siparis S WITH (NOLOCK) INNER JOIN  " &
                "(Select SipEvrakSeri,MAX(SipEvrakSira) As Sira FROM Siparis WITH (NOLOCK) WHERE Deleted = 0 " &
                "GROUP BY SipEvrakSeri) L On S.SipEvrakSeri = L.SipEvrakSeri " &
                "WHERE S.Deleted = 0  " &
                "ORDER BY S.SiparisID DESC " &
                ""
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Seri = IfNull(dt.Rows(0).Item("SipEvrakSeri"), "")
                Sira = If0Null(dt.Rows(0).Item("Sira"))
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Parameters.AddWithValue("@Seri", Seri)
            cmd.CommandText = "INSERT INTO Siparis (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Tarih, SipEvrakSeri, SipEvrakSira, SiparisNo, CariKod, CariUnvan, Aciklama1, Aciklama2, Aciklama3, Onayli, Onaylayan, OnayTarihi, Iptal, IptalNedeni, AraToplam, KdvOran, KdvTutar, GenelToplam, DovizTipi, DovizKuru, DovizliTutar, OkulFarki, NAraToplam, NKdvTutar, NGenelToplam,SiparisType,Depo,Depo2) " &
                "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & SQLDateTime(Today) & ", @Seri, ISNULL((SELECT max(SipEvrakSira) FROM Siparis S WHERE S.Deleted = 0 And S.SipEvrakSeri =@Seri),0) + 1 as SipEvrakSira, SiparisNo, CariKod, CariUnvan, Aciklama1, Aciklama2, Aciklama3, 0 as Onayli,0 as Onaylayan,'1900-1-1' as OnayTarihi, Iptal, IptalNedeni, AraToplam, KdvOran, KdvTutar, GenelToplam, DovizTipi, DovizKuru, DovizliTutar, OkulFarki, NAraToplam, NKdvTutar, NGenelToplam,SiparisType,Depo,Depo2 " &
                "FROM Siparis " &
                "WHERE SiparisID = " & SiparisID & " " &
                " " &
                "SELECT SCOPE_IDENTITY() "
            NewSiparisID = If0Null(cmd.ExecuteScalar)
            If NewSiparisID <= 0 Then
                trans.Rollback()
                MsgBox("Ä°slem basarisiz!")
                Return 0
            End If
            If CopySipDetay(trans, SiparisID, NewSiparisID, UserID) = False Then
                trans.Rollback()
                MsgBox("Ä°slem basarisiz!")
                Return 0
            End If
            trans.Commit()

            Return NewSiparisID
        Catch ex As Exception
            If Not trans Is Nothing Then trans.Rollback()
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Private Function CopySipDetay(ByVal trans As SqlClient.SqlTransaction, ByVal KaynakSiparisID As Long, ByVal HedefSiparisID As Long, UserID As Long) As Boolean

        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayID FROM SipDetay WHERE Deleted = 0 AND SiparisID = " & KaynakSiparisID & "  ORDER BY SipDetayID "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                Dim SipDetayID As Long = 0
                cmd.CommandText = "INSERT INTO SipDetay (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SiparisID, StokKod, StokRecNo, SiparisAciklama, OkulID, BolumKod, KategoriID, Miktar, Maliyet, Fiyat, Tutar, Tarih, TerminTarihi, MusteriSipNo, SiparisiAlan, Iptal, Resim1, Resim2, Resim3, Resim4, Resim5, StokIsmi) " &
                    "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSiparisID & ", StokKod, StokRecNo, SiparisAciklama, OkulID, BolumKod, KategoriID, Miktar, Maliyet, Fiyat, Tutar, " & SQLDateTime(Today) & ", " & SQLDateTime(Today) & ", MusteriSipNo, SiparisiAlan, Iptal, Resim1, Resim2, Resim3, Resim4, Resim5, StokIsmi " &
                    "FROM SipDetay " &
                    "WHERE SipDetayID = " & If0Null(dr("SipDetayID")) & " " &
                    " " &
                    "SELECT SCOPE_IDENTITY() "
                SipDetayID = If0Null(cmd.ExecuteScalar)

                If CopySipDetayBilgiler(trans, If0Null(dr("SipDetayID")), SipDetayID, UserID) = False Then
                    Return False
                End If
                If CopySipDetayParam(trans, If0Null(dr("SipDetayID")), SipDetayID, UserID) = False Then
                    Return False
                End If
            Next
            dt.Dispose()
            da.Dispose()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Function CopySipDetayBilgiler(ByVal trans As SqlClient.SqlTransaction, ByVal KaynakSipDetayID As Long, ByVal HedefSipDetayID As Long, UserID As Long) As Boolean

        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.Transaction = trans
            cmd.CommandText = "INSERT INTO SipDetayBilgi (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, GrupKod, GrupIsmi, Aciklama) " & vbNewLine &
                "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayID & ", GrupKod, GrupIsmi, Aciklama " & vbNewLine &
                "FROM SipDetayBilgi " & vbNewLine &
                "WHERE SipDetayID = " & KaynakSipDetayID & " " & vbNewLine &
                "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayEkFiyatlar (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, MasrafKod, MasrafIsmi, EkFiyat, BedenArtis) " & vbNewLine &
               "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayID & ", MasrafKod, MasrafIsmi, EkFiyat, BedenArtis " & vbNewLine &
               "FROM SipDetayEkFiyatlar " & vbNewLine &
               "WHERE SipDetayID = " & KaynakSipDetayID & " " & vbNewLine &
               "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayFiyatlar (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, BedenKod, BazFiyat, BrutFiyat, Iskonto, NakitIskonto, NetFiyat, Miktar, Tutar, KategoriFiyatID) " & vbNewLine &
                   "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayID & ", BedenKod, BazFiyat, BrutFiyat, Iskonto, NakitIskonto, NetFiyat, Miktar, Tutar, KategoriFiyatID " & vbNewLine &
                   "FROM SipDetayFiyatlar " & vbNewLine &
                   "WHERE SipDetayID = " & KaynakSipDetayID & " " & vbNewLine &
                   "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayUretimBilgi (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, GrupKod, GrupIsmi, Aciklama) " & vbNewLine &
                  "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayID & ", GrupKod, GrupIsmi, Aciklama " & vbNewLine &
                  "FROM SipDetayUretimBilgi " & vbNewLine &
                  "WHERE SipDetayID = " & KaynakSipDetayID & " " & vbNewLine &
                  "" & vbNewLine

            cmd.ExecuteNonQuery()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function


    Private Function CopySipDetayParam(ByVal trans As SqlClient.SqlTransaction, ByVal KaynakSipDetayID As Long, ByVal HedefSipDetayID As Long, UserID As Long) As Boolean

        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.Transaction = trans
            cmd.CommandText = "SELECT SipDetayParamID FROM SipDetayParam WHERE Deleted = 0 AND SipDetayID = " & KaynakSipDetayID & "  ORDER BY SipDetayParamID "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                Dim SipDetayParamID As Long = 0
                cmd.CommandText = "INSERT INTO SipDetayParam (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayID, ParamType, KategoriParamID, HammaddeID, Tur, TurArtis, BelTur, BelTurArtis, KolTur, KolTurArtis, RenkID, CizgiSayisi, IntParam1, RenkID2, CizgiSayisi2, bVar, IntParam2, IntParam3, CharParam1) " &
                    "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayID & ", ParamType, KategoriParamID, HammaddeID, Tur, TurArtis, BelTur, BelTurArtis, KolTur, KolTurArtis, RenkID, CizgiSayisi, IntParam1, RenkID2, CizgiSayisi2, bVar, IntParam2, IntParam3, CharParam1 " &
                    "FROM SipDetayParam " &
                    "WHERE SipDetayParamID = " & If0Null(dr("SipDetayParamID")) & " " &
                    " " &
                    "SELECT SCOPE_IDENTITY() "
                SipDetayParamID = If0Null(cmd.ExecuteScalar)

                If CopySipDetayParamDetay(trans, If0Null(dr("SipDetayParamID")), SipDetayParamID, UserID) = False Then
                    Return False
                End If
            Next
            dt.Dispose()
            da.Dispose()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Function CopySipDetayParamDetay(ByVal trans As SqlClient.SqlTransaction, ByVal KaynakSipDetayParamID As Long, ByVal HedefSipDetayParamID As Long, UserID As Long) As Boolean

        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.Transaction = trans
            cmd.CommandText = "INSERT INTO SipDetayParam_001_Kumas (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, ParcaIsmi, Iplik, IpGramaj, KumasGramaj, GramajArtis, RenkID, OrguTip) " & vbNewLine &
                "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, ParcaIsmi, Iplik, IpGramaj, KumasGramaj, GramajArtis, RenkID, OrguTip " & vbNewLine &
                "FROM SipDetayParam_001_Kumas " & vbNewLine &
                "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
                "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_002_Lastik ( Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
                "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(),  " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
                "FROM SipDetayParam_002_Lastik " & vbNewLine &
                "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
                "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_002_Lastik_Kol ( Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
                "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
                "FROM SipDetayParam_002_Lastik_Kol " & vbNewLine &
                "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
                "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_003_Yaka ( Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
                "SELECT   Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
                "FROM SipDetayParam_003_Yaka " & vbNewLine &
                "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
                "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_004_DubleLastikCep (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
                 "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
                 "FROM SipDetayParam_004_DubleLastikCep " & vbNewLine &
                 "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
                 "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_005_DubleLastikPilotYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
               "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
               "FROM SipDetayParam_005_DubleLastikPilotYaka " & vbNewLine &
               "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
               "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_006_DubleLastik (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
             "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
             "FROM SipDetayParam_006_DubleLastik " & vbNewLine &
             "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
             "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_007_DubleYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
            "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
            "FROM SipDetayParam_007_DubleYaka " & vbNewLine &
            "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
            "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_008_TorbaliBant (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
               "SELECT  Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
               "FROM SipDetayParam_008_TorbaliBant " & vbNewLine &
               "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
               "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_009_Kumas2 (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, ParcaIsmi, KumasKatalogID, KumasID, RenkID) " & vbNewLine &
             "SELECT  Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(),  " & HedefSipDetayParamID & ", SourceID, KategoriParamID, ParcaIsmi, KumasKatalogID, KumasID, RenkID " & vbNewLine &
             "FROM SipDetayParam_009_Kumas2 " & vbNewLine &
             "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
             "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_009_Kumas2_Detay (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, SolOnCep, SagOnCep, SolArkaCep, SagArkaCep, GizliCep, CepKumasArtis, OverlokNakis, FarkliKumas, Biye, BiyeDeger) " & vbNewLine &
            "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, SolOnCep, SagOnCep, SolArkaCep, SagArkaCep, GizliCep, CepKumasArtis, OverlokNakis, FarkliKumas, Biye, BiyeDeger " & vbNewLine &
            "FROM SipDetayParam_009_Kumas2_Detay " & vbNewLine &
            "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
            "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_010_GomlekParams (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, Pensli, Yaka, Cepli) " & vbNewLine &
              "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, Pensli, Yaka, Cepli " & vbNewLine &
              "FROM SipDetayParam_010_GomlekParams " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_011_LakosKumas (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, ParcaIsmi, OrguTip, Iplik, IpGramaj, KumasGramaj, GramajArtis, RenkID) " & vbNewLine &
                "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, ParcaIsmi, OrguTip, Iplik, IpGramaj, KumasGramaj, GramajArtis, RenkID " & vbNewLine &
                "FROM SipDetayParam_011_LakosKumas " & vbNewLine &
                "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
                "" & vbNewLine

            cmd.CommandText &= "DECLARE @LakosYakaID INT " & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_012_LakosYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi) " & vbNewLine &
              "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi " & vbNewLine &
              "FROM SipDetayParam_012_LakosYaka " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "SELECT @LakosYakaID=SCOPE_IDENTITY() " & vbNewLine &
              "" & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_012_LakosYaka_Cizgiler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, LakosYakaID, CizgiNo, RenkID) " & vbNewLine &
            "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), @LakosYakaID, CizgiNo, RenkID " & vbNewLine &
            "FROM SipDetayParam_012_LakosYaka_Cizgiler " & vbNewLine &
            "WHERE Deleted = 0 AND  LakosYakaID IN (SELECT nID FROM SipDetayParam_012_LakosYaka WHERE Deleted = 0 AND SipDetayParamID = " & KaynakSipDetayParamID & ") " & vbNewLine &
            "" & vbNewLine

            cmd.CommandText &= "DECLARE @Manset2cmID INT " & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_013_Manset2cm (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi) " & vbNewLine &
              "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi " & vbNewLine &
              "FROM SipDetayParam_013_Manset2cm " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "SELECT @Manset2cmID=SCOPE_IDENTITY() " & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_013_Manset2cm_Cizgiler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Manset2cmID, CizgiNo, RenkID) " & vbNewLine &
            "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), @Manset2cmID , CizgiNo, RenkID " & vbNewLine &
            "FROM SipDetayParam_013_Manset2cm_Cizgiler " & vbNewLine &
            "WHERE Deleted = 0 AND  Manset2cmID IN (SELECT nID FROM SipDetayParam_013_Manset2cm WHERE Deleted = 0 AND SipDetayParamID = " & KaynakSipDetayParamID & ") " & vbNewLine &
            "" & vbNewLine

            cmd.CommandText &= "DECLARE @Manset6cmID INT " & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_014_Manset6cm (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi) " & vbNewLine &
              "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi " & vbNewLine &
              "FROM SipDetayParam_014_Manset6cm " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "SELECT @Manset6cmID=SCOPE_IDENTITY() " & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_014_Manset6cm_Cizgiler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Manset6cmID, CizgiNo, RenkID) " & vbNewLine &
            "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), @Manset6cmID , CizgiNo, RenkID " & vbNewLine &
            "FROM SipDetayParam_014_Manset6cm_Cizgiler " & vbNewLine &
            "WHERE Deleted = 0 AND  Manset6cmID IN (SELECT nID FROM SipDetayParam_014_Manset6cm WHERE Deleted = 0 AND SipDetayParamID = " & KaynakSipDetayParamID & ") " & vbNewLine &
            ""


            cmd.CommandText &= "INSERT INTO SipDetayParam_015_Fular (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, ParcaIsmi, Iplik, IpGramaj, RenkID) " & vbNewLine &
               "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(),  " & HedefSipDetayParamID & ", SourceID, KategoriParamID, ParcaIsmi, Iplik, IpGramaj, RenkID " & vbNewLine &
               "FROM SipDetayParam_015_Fular " & vbNewLine &
               "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
               "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_016_Kravat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, ParcaIsmi, RenkID) " & vbNewLine &
              "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(),  " & HedefSipDetayParamID & ", SourceID, KategoriParamID, ParcaIsmi, RenkID " & vbNewLine &
              "FROM SipDetayParam_016_Kravat " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_017_DubleLastikIcCep (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID) " & vbNewLine &
              "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(),  " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID, RKafa, CizgiRKafaID " & vbNewLine &
              "FROM SipDetayParam_017_DubleLastikIcCep " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "" & vbNewLine

            cmd.CommandText &= "DECLARE @EtekMansetID INT " & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_018_EtekManset (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi, Iplik, IpGramaj, GramajArtis) " & vbNewLine &
              "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi, Iplik, IpGramaj, GramajArtis " & vbNewLine &
              "FROM SipDetayParam_018_EtekManset " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "SELECT @EtekMansetID=SCOPE_IDENTITY() " & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_018_EtekManset_Cizgiler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, EtekMansetID, CizgiNo, RenkID) " & vbNewLine &
            "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), @EtekMansetID , CizgiNo, RenkID " & vbNewLine &
            "FROM SipDetayParam_018_EtekManset_Cizgiler " & vbNewLine &
            "WHERE Deleted = 0 AND  EtekMansetID IN (SELECT nID FROM SipDetayParam_018_EtekManset WHERE Deleted = 0 AND SipDetayParamID = " & KaynakSipDetayParamID & ") " & vbNewLine &
            ""

            cmd.CommandText &= "DECLARE @KaskorseID INT " & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_019_Kaskorse (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, RenkID, Iplik, IpGramaj, GramajArtis) " & vbNewLine &
              "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, RenkID, Iplik, IpGramaj, GramajArtis " & vbNewLine &
              "FROM SipDetayParam_019_Kaskorse " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "SELECT @KaskorseID=SCOPE_IDENTITY() " & vbNewLine


            cmd.CommandText &= "DECLARE @GogusMansetID INT " & vbNewLine
            cmd.CommandText &= "INSERT INTO SipDetayParam_020_GogusManset (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi, Iplik, IpGramaj, GramajArtis) " & vbNewLine &
              "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, RenkID, CizgiRKafaLakosID, CizgiSayisi, Iplik, IpGramaj, GramajArtis " & vbNewLine &
              "FROM SipDetayParam_020_GogusManset " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "SELECT @GogusMansetID=SCOPE_IDENTITY() " & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_020_GogusManset_Cizgiler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, GogusMansetID, CizgiNo, RenkID) " & vbNewLine &
            "SELECT Deleted, " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), @GogusMansetID , CizgiNo, RenkID " & vbNewLine &
            "FROM SipDetayParam_020_GogusManset_Cizgiler " & vbNewLine &
            "WHERE Deleted = 0 AND  GogusMansetID IN (SELECT nID FROM SipDetayParam_020_GogusManset WHERE Deleted = 0 AND SipDetayParamID = " & KaynakSipDetayParamID & ") " & vbNewLine &
            ""




            cmd.CommandText &= "INSERT INTO SipDetayParam_052_KazakYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, CizgiSayisi, RenkID) " & vbNewLine &
             "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, CizgiSayisi, RenkID " & vbNewLine &
             "FROM SipDetayParam_052_KazakYaka " & vbNewLine &
             "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
             "" & vbNewLine

            'cmd.CommandText &= "INSERT INTO SipDetayParam_054_GarniDikis (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, GarniDikis) " & vbNewLine &
            '   "SELECT Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, GarniDikis " & vbNewLine &
            '   "FROM SipDetayParam_054_GarniDikis " & vbNewLine &
            '   "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
            '   "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_055_Secenek (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, ModelFarki, ParcaModel, Astar, Femuar, OmuzRecme, Arma, OzelEtiket, Fason, FasonID, MansetFarki, UzunKolFarki) " & vbNewLine &
              "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, ModelFarki, ParcaModel, Astar, Femuar, OmuzRecme, Arma, OzelEtiket, Fason, FasonID, MansetFarki, UzunKolFarki " & vbNewLine &
              "FROM SipDetayParam_055_Secenek " & vbNewLine &
              "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
              "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_056_EkFiyat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, Aciklama, Fiyat, BedenArtis, bStatik) " & vbNewLine &
             "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, Aciklama, Fiyat, BedenArtis, bStatik " & vbNewLine &
             "FROM SipDetayParam_056_EkFiyat " & vbNewLine &
             "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
             "" & vbNewLine

            cmd.CommandText &= "INSERT INTO SipDetayParam_057_EkOzellikler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, SipDetayParamID, SourceID, KategoriParamID, Aciklama, bStatik) " & vbNewLine &
            "SELECT Deleted,  " & UserID & ", GETDATE(), " & UserID & ", GETDATE(), " & HedefSipDetayParamID & ", SourceID, KategoriParamID, Aciklama, bStatik " & vbNewLine &
            "FROM SipDetayParam_057_EkOzellikler " & vbNewLine &
            "WHERE SipDetayParamID = " & KaynakSipDetayParamID & " " & vbNewLine &
            "" & vbNewLine

            cmd.ExecuteNonQuery()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function


End Module
