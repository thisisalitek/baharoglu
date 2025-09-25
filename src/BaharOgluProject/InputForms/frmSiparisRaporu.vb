Public Class frmSiparisRaporu

    Dim OrginalCommandText As String = ""

    Public Sub FormShow_SelectSiparis(ByVal CariKod As String, Optional filter As String = "", Optional bMultiSelect As Boolean = True)
        Try
            If Trim(CariKod) <> "" Then
                MasterTable.SelectCommand.CommandText &= " AND  Siparis.CariKod='" & Replace(CariKod, "'", " ") & "' " & filter & " "

            Else
                MasterTable.SelectCommand.CommandText &= filter & " "

            End If
            OrginalCommandText = MasterTable.SelectCommand.CommandText
            Me.FormSelect(True, , bMultiSelect)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSiparisiAc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSiparisiAc.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim SiparisID As Long = GridView1.GetDataRow(GridView1.FocusedRowHandle)("SiparisID") ' If0Null(MasterLink.CurrentRow("SiparisID"))
            Dim f As New frmSiparisler
            With f

                .FormShowOneItem(SiparisID, False, , , Me, True, True)

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmSiparisRaporu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try

            'Dim sbuf As String
            If NavBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded Then
                SaveSetting(AppConn.ApplicationCode, Me.FormCode, "NavBarControl1.OptionsNavPane.NavPaneState", "1")
            Else
                SaveSetting(AppConn.ApplicationCode, Me.FormCode, "NavBarControl1.OptionsNavPane.NavPaneState", "")
            End If
            SaveSetting(AppConn.ApplicationCode, Me.FormCode, "NavBarControl1.Width", NavBarControl1.Width)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisRaporu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If DesignMode Then Exit Sub

            'LoadKategori()
            'NavBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            'Dim sbuf As String = GetSetting(AppConn.ApplicationCode, Me.FormCode, "NavBarControl1.OptionsNavPane.NavPaneState", "")
            'If sbuf = "1" Then
            '    NavBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
            'Else
            '    NavBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
            'End If
            'sbuf = GetSetting(AppConn.ApplicationCode, Me.FormCode, "NavBarControl1.Width", "")
            'If IsNumeric(sbuf) Then
            '    If CLng(sbuf) > 1000 Then sbuf = 1000
            '    If CLng(sbuf) < 37 Then sbuf = 37
            '    NavBarControl1.Width = CInt(sbuf)
            'End If
            OpenTable(tbUsers)
            OpenTable(tbBoyahaneler)
            OpenTable(tbSiparisAlanlar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkHaftaSonra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHaftaSonra.CheckedChanged
        Try
            If chkHaftaSonra.Checked Then
                TrackBarControl1.Enabled = True
                '
                HaftaAyarla()
            Else
                TrackBarControl1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HaftaAyarla()
        Try
            dtFormDate1.DateTime = AppConn.Today.AddDays(-1 * (AppConn.Today.DayOfWeek - 1))

            Dim tmpTarih2 As DateTime = DateAdd(DateInterval.Day, (7 - AppConn.Today.DayOfWeek), AppConn.Today)
            If TrackBarControl1.Value > 0 Then
                tmpTarih2 = DateAdd(DateInterval.Day, 7 * TrackBarControl1.Value, tmpTarih2)
                chkHaftaSonra.Text = "Bu Hafta - " & TrackBarControl1.Value & " Hafta Sonra"
            Else
                chkHaftaSonra.Text = "Bu Hafta"
            End If
            dtFormDate2.DateTime = tmpTarih2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TrackBarControl1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarControl1.EditValueChanged
        HaftaAyarla()
    End Sub



    Private Sub frmSiparisRaporu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.R And e.Control And e.Alt Then
                If GridView1.RowCount <= 0 Then Exit Sub
                If MsgBox("Listedeki siparişler onarılacaktır. Onaylıyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Onar?") <> MsgBoxResult.Yes Then Exit Sub
                RepairSipDetay()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RepairSipDetay()
        Try
            If GridView1.RowCount <= 0 Then Exit Sub
            RepositoryItemProgressBar1.Maximum = GridView1.RowCount

            For i As Integer = 0 To GridView1.RowCount - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(i)
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    If Not dr Is Nothing Then
                        Dim cmd As New SqlClient.SqlCommand
                        Dim da As SqlClient.SqlDataAdapter
                        Dim dt As DataTable
                        cmd.Connection = AppConn.dbConn
                        cmd.CommandText = "SELECT Siparis.SiparisID ,Siparis.DovizTipi , Siparis.OkulFarki , SipDetay.SipDetayID  " &
                            " ,SipDetay.StokKod,SipDetay.StokIsmi  FROM SipDetay INNER JOIN " &
                            " Siparis ON SipDetay.SiparisID  = Siparis.SiparisID " &
                            " WHERE SipDetay.Deleted = 0 AND SipDetay.SipDetayID = " & If0Null(dr("SipDetayID"))
                        da = New SqlClient.SqlDataAdapter(cmd)
                        dt = New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Dim f As New frmKategoriler

                            f.MikroStokKod = IfNull(dt.Rows(0).Item("StokKod"), "")
                            f.MikroStokIsmi = IfNull(dt.Rows(0).Item("StokIsmi"), "")
                            f.DovizTipi = IfNull(dt.Rows(0).Item("DovizTipi"), "")
                            f.OkulFarki = If0Null(dt.Rows(0).Item("OkulFarki"))
                            f.FormShow_Repair(If0Null(dt.Rows(0).Item("SipDetayID")))
                        End If
                        dt.Dispose()
                        da.Dispose()
                        cmd.Dispose()
                    End If
                End If
                BarEditItem1.EditValue = i
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mnuSetUretimde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetUretimde.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            If AppConn.ActiveUser.bAdmin = False Then
                MsgBox("Yetkili kullanicilar uretim durumunu degistirebilir!")
                Exit Sub
            End If
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If
            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "") ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "URETIMDE" Then
                MsgBox("Bu sipariş zaten üretimde!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'URETIMDE' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='URETIMDE' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "URETIMDE"
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSetBitti_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSetBitti.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            Dim cmd As New SqlClient.SqlCommand
            Dim trans As SqlClient.SqlTransaction
            Dim bFasonda As Boolean = False
            cmd.Connection = AppConn.dbConn
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                    If If0Null(dr("FasondaMi")) = 1 Then
                        bFasonda = True
                    End If
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            If bFasonda Then
                If MsgBox("Uretim fasonda gorunuyor! Yinede BITTI olarak isaretleyip ayni zamanda fason fisini kapatmak istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Fason fisi kapat?") <> MsgBoxResult.Yes Then Exit Sub
                Try
                    trans = cmd.Connection.BeginTransaction
                    cmd.Transaction = trans
                    cmd.CommandText = "UPDATE FasonFis SET Kapali=1 , KapanmaTarihi=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME) WHERE Deleted = 0 AND Iptal = 0 AND SipDetayID IN (" & sSipDetayID & ") "
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "UPDATE SipDetay SET FasondaMi=0 WHERE  SipDetayID IN (" & sSipDetayID & ") "
                    cmd.ExecuteNonQuery()

                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox("Fason fisleri kapatilamadi!. Islemler geri alindi. Fason fislernizi kontrol ediniz." & vbNewLine & "Hata: " & ex.Message)
                End Try
            End If
            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "BITTI" Then
                MsgBox("Bu sipariş zaten bitmiş!")
                Exit Sub
            End If
            If bFasonda = False Then

                If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'BITTI' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub

            End If

            cmd.CommandText = "UPDATE SipDetay SET Durumu='BITTI' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "BITTI"
                    dr("FasondaMi") = 0

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSetBos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSetBos.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If


            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "" Then

                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu '' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()

            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = ""
                    dr.EndEdit()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSetOrgude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetOrgude.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")   ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "ORGUDE" Then
                MsgBox("Bu sipariş zaten örgüde!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'ORGUDE' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='ORGUDE' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()

            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "ORGUDE"
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSiparisYaz_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSiparisYaz.Click
        Try
            'If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim onaysiz As Integer = 0
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    If If0Null(dr("Onayli")) = 0 Then
                        onaysiz += 1
                    End If
                End If
            Next

            If onaysiz > 0 Then
                If MsgBox("Yazdirilacak siparisler icinde " & onaysiz & " adet ONAYSIZ siparis var. Devam etmek istiyor musunuz?", MsgBoxStyle.YesNoCancel, "ONAYSIZ siparis var") <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If
            Dim PrintScript As String = "SELECT * FROM Siparis WHERE Deleted = 0 AND SiparisID = @SiparisID "


            Dim f As New frmReportSelect
            With f
                .Parameters = New ArrayList

                Dim pr As New SqlClient.SqlParameter("@SiparisID", If0Null(GridView1.GetDataRow(GridView1.FocusedRowHandle)("SiparisID")))
                .Parameters.Add(pr)
                Dim sSipDetayID As String = "-99999"
                For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                    Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                    If RowIndex >= 0 Then
                        Dim dr As DataRow = MasterTable.Rows(RowIndex)
                        sSipDetayID &= " , " & If0Null(dr("SipDetayID")) & " "
                    End If
                Next
                Dim prDetayID As New SqlClient.SqlParameter("@SipDetayIDler", sSipDetayID)
                .Parameters.Add(prDetayID)
                For Each pr2 As SqlClient.SqlParameter In MasterTable.SelectCommand.Parameters
                    If pr2.ParameterName <> pr.ParameterName Then
                        .Parameters.Add(New SqlClient.SqlParameter(pr2.ParameterName, pr2.Value))
                    End If
                Next
                If AppConn.ActiveUser.bAdmin Then .Parameters.Add(New SqlClient.SqlParameter("@bAdmin", 1)) Else .Parameters.Add(New SqlClient.SqlParameter("@bAdmin", 1))
                .Parameters.Add(New SqlClient.SqlParameter("@UserID", AppConn.ActiveUser.UserID))


                .FormCode = "000008"
                .PrintScript = PrintScript
                .FormShow()

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSetKesimde_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSetKesimde.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "KESIMDE" Then
                MsgBox("Bu sipariş zaten kesimde!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'KESIMDE' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='KESIMDE' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()

            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "KESIMDE"
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSetBoyada_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSetBoyada.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If
            Dim BoyahaneID As Integer = 0
            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu <> "BOYADA" Then
                If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'BOYADA' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            End If
            Dim f As New frmBoyahaneler
            f.FormSelect()
            If f.DialogResult = DialogResult.OK Then
                BoyahaneID = f.ReturnDataRow("BoyahaneID")
                OpenTable(tbBoyahaneler)
            End If





            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='BOYADA', BoyahaneID=" & BoyahaneID & " , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()

            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "BOYADA"
                    dr("BoyahaneID") = BoyahaneID
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuSetDepoda_Click(sender As Object, e As EventArgs) Handles mnuSetDepoda.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "DEPODA" Then
                MsgBox("Bu sipariş zaten depoda!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'DEPODA' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='DEPODA' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "DEPODA"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSiparisRaporu_RefreshBefore_Click(sender As Object, ByRef e As ReportFormRefreshEventArgs) Handles Me.RefreshBefore_Click
        Try
            MasterTable.SelectCommand.CommandText = OrginalCommandText
            If chkSeceneklerdeFasonOlanlar.Checked Then
                MasterTable.SelectCommand.CommandText &= " AND SipDetay.SipDetayID IN (SELECT SipDetayID  FROM SipDetayParam SDP INNER JOIN " & vbNewLine &
                    " SipDetayParam_055_Secenek SEC ON  SDP.SipDetayParamID = SEC.SipDetayParamID  " & vbNewLine &
                    " WHERE SEC.Fason=1) " & vbNewLine

            End If
            If chkSiparisTarihineGore.Checked Then
                MasterTable.SelectCommand.CommandText &= " AND (SipDetay.Tarih BETWEEN @FormDate1 AND @FormDate2 ) " & vbNewLine
            Else
                MasterTable.SelectCommand.CommandText &= " AND (SipDetay.TerminTarihi BETWEEN @FormDate1 AND @FormDate2 ) " & vbNewLine
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub CheckedListBoxControl1_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles CheckedListBoxControl1.ItemCheck
        Try
            GridView1.Columns("Durumu").ClearFilter()
            Dim filter As String = ""
            For i As Integer = 0 To CheckedListBoxControl1.Items.Count - 1
                If CheckedListBoxControl1.Items(i).CheckState = CheckState.Checked Then
                    filter &= "[Durumu]='" & CheckedListBoxControl1.Items(i).Value.ToString & "' OR "

                End If
            Next
            If Trim(filter) = "" Then Exit Sub

            filter = Mid(filter, 1, Len(filter) - 4)
            'MsgBox(GridView1.Columns("Durumu").FilterInfo.FilterString)
            Dim cfil As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(filter)

            GridView1.ActiveFilter.Add(GridView1.Columns("Durumu"), cfil)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdDurumuHepsi_Click(sender As Object, e As EventArgs) Handles cmdDurumuHepsi.Click
        For i As Integer = 0 To CheckedListBoxControl1.Items.Count - 1
            CheckedListBoxControl1.Items(i).CheckState = CheckState.Unchecked
        Next
    End Sub


    'Private Sub LoadKategori()
    '    Try
    '        NavBarControl1.Groups.Clear()
    '        NavBarControl1.Groups.Add(New DevExpress.XtraNavBar.NavBarGroup("Kategori Filtre"))

    '        Dim NavBarGroupContainer1 As New DevExpress.XtraNavBar.NavBarGroupControlContainer

    '        Dim TreeView1 As New TreeView
    '        AddKategori(TreeView1, 0, Nothing)
    '        NavBarGroupContainer1.Controls.Add(TreeView1)
    '        TreeView1.BringToFront()
    '        TreeView1.Dock = DockStyle.Fill
    '        AddHandler TreeView1.AfterSelect, AddressOf TreeView1_AfterSelect
    '        NavBarControl1.Groups(NavBarControl1.Groups.Count - 1).ControlContainer = NavBarGroupContainer1
    '        'NavBarControl1.Groups(NavBarControl1.Groups.Count - 1).
    '        For Each node1 As TreeNode In TreeView1.Nodes
    '            node1.Expand()
    '            'For Each node2 As TreeNode In node1.Nodes
    '            '    node2.Expand()
    '            'Next
    '        Next

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub AddKategori(ByRef TreeView1 As TreeView, ByVal UstKategoriID As Long, ByRef Node1 As TreeNode)
    '    Try
    '        Dim cmd As New SqlClient.SqlCommand
    '        Dim da As SqlClient.SqlDataAdapter
    '        Dim dt As DataTable
    '        cmd.Connection = AppConn.dbConn
    '        cmd.CommandText = "SELECT * FROM Kategoriler WHERE Deleted = 0 AND UstKategoriID = " & UstKategoriID & " ORDER BY KategoriKod "
    '        da = New SqlClient.SqlDataAdapter(cmd)
    '        dt = New DataTable
    '        da.Fill(dt)
    '        For Each dr As DataRow In dt.Rows
    '            Dim newnode As TreeNode
    '            If Node1 Is Nothing Then

    '                newnode = TreeView1.Nodes.Add(IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriKod"), "") & " - " & IfNull(dr("KategoriIsim"), ""))
    '                newnode.Tag = IfNull(dr("KategoriKod"), "")
    '                AddKategori(TreeView1, If0Null(dr("KategoriID")), newnode)
    '            Else

    '                newnode = Node1.Nodes.Add(IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriKod"), "") & " - " & IfNull(dr("KategoriIsim"), ""))
    '                newnode.Tag = IfNull(dr("KategoriKod"), "")
    '                AddKategori(TreeView1, If0Null(dr("KategoriID")), newnode)
    '            End If

    '        Next
    '        dt.Dispose()
    '        da.Dispose()

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    '    Try
    '        Dim TreeView1 As TreeView = CType(sender, TreeView)

    '        Dim bKategori As Boolean = False


    '        If TreeView1.SelectedNode Is Nothing Then Exit Sub
    '        If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub
    '        'Dim edit As DevExpress.XtraEditors.GridLookUpEdit = CType(sender, DevExpress.XtraEditors.GridLookUpEdit)
    '        'Dim gw As DevExpress.XtraGrid.Views.Grid.GridView = edit.Properties.View
    '        Dim filterCondition As String = ""


    '        GridView1.ActiveFilter.Clear()

    '        GridView1.ActiveFilter.Add(GridView1.Columns("KategoriKod"), New DevExpress.XtraGrid.Columns.ColumnFilterInfo("StartsWith([KategoriKod], '" & TreeView1.SelectedNode.Tag.ToString & "')"))



    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    'Private Sub cmdKategoriBul_Click(sender As Object, e As EventArgs)
    '    Try
    '        LoadKategori()
    '        If Trim(txtKategoriArama.Text) = "" Then Exit Sub
    '        Dim TreeView1 As TreeView = NavBarControl1.Groups(NavBarControl1.Groups.Count - 1).ControlContainer.Controls(0)
    '        For Each node As TreeNode In TreeView1.Nodes
    '            Dim bFound As Boolean = False
    '            bFound = FindTextInNodes(node, txtKategoriArama.Text)
    '            If bFound = False Then
    '                node.Remove()

    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    '    Private Function FindTextInNodes(mainNode As TreeNode, keyword As String) As Boolean
    '        Try
    '            If UCaseEng(mainNode.Text).Contains(UCaseEng(keyword)) Then
    '                Return True
    '            End If
    '            Dim bGenelBulundu As Boolean = False
    'basa:
    '            For Each node As TreeNode In mainNode.Nodes
    '                Dim bFound As Boolean = False
    '                bFound = FindTextInNodes(node, keyword)
    '                If bFound = False Then
    '                    'If node.Nodes.Count > 0 Then
    '                    node.Remove()
    '                    GoTo basa
    '                    'End If
    '                Else
    '                    bGenelBulundu = True
    '                End If
    '            Next
    '            Return bGenelBulundu
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        Return False
    '    End Function

    '    Private Sub txtKategoriArama_KeyDown(sender As Object, e As KeyEventArgs)
    '        If e.KeyCode = Keys.Return Then
    '            cmdKategoriBul_Click(Nothing, Nothing)
    '        End If
    '    End Sub

    Dim panelLeft_EskiGenislik As Integer = 0
    Private Sub NavBarControl1_NavPaneStateChanged(sender As Object, e As EventArgs) Handles NavBarControl1.NavPaneStateChanged

        'If panelKategoriArama.Visible Then
        '    panelKategoriArama.Visible = False
        '    panelLeft_EskiGenislik = panelLeft.Width
        '    panelLeft.Width = 40

        'Else
        '    panelLeft.Width = panelLeft_EskiGenislik
        '    panelKategoriArama.Visible = True

        'End If

    End Sub

    Private Sub FasonFisiniAcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FasonFisiniAcToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            If RowIndex < 0 Then Exit Sub
            If If0Null(MasterTable.Rows(RowIndex).Item("FasondaMi")) = 0 Then Exit Sub

            Dim SipDetayID As Long = MasterTable.Rows(RowIndex).Item("SipDetayID")

            Dim f As New frmFason
            With f

                .Form1Item(SipDetayID)

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmSiparisRaporu_Shown(sender As Object, e As EventArgs) Handles Me.Shown


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OrginalCommandText = MasterTable.SelectCommand.CommandText
    End Sub

    Private Sub mnuSetKilis_Click(sender As Object, e As EventArgs) Handles mnuSetKilis.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "KILIS" Then
                MsgBox("Bu sipariş zaten kilis te!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'KILIS' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='KILIS' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "KILIS"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdRefreshList_Click(sender As Object, e As EventArgs) Handles cmdRefreshList.Click
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub KayitBilgisiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KayitBilgisiToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            Dim SipDetayID As Long = MasterTable.Rows(RowIndex)("SipDetayID")

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT SipDetayID, CreatedBy,CreatedDate,ModifiedBy,ModifiedDate FROM SipDetay WHERE SipDetayID = " + SipDetayID.ToString
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim sText As String = ""
                sText = "ID" & vbTab & vbTab & ": " & dt.Rows(0)("SipDetayID").ToString & vbNewLine
                sText &= "Oluşturan" & vbTab & vbTab & ": " & GetUserFullName(MasterConn.SqlConnection, If0Null(dt.Rows(0)("CreatedBy"))) & vbNewLine
                sText &= "Oluşturma Tarihi" & vbTab & ": " & IfNull(dt.Rows(0)("CreatedDate"), DateSerial(1900, 1, 1)) & vbNewLine
                sText &= "Değiştiren" & vbTab & vbTab & ": " & GetUserFullName(MasterConn.SqlConnection, If0Null(dt.Rows(0)("ModifiedBy"))) & vbNewLine
                sText &= "Değiştirme Tarihi" & vbTab & ": " & IfNull(dt.Rows(0)("ModifiedDate"), DateSerial(1900, 1, 1)) & vbNewLine
                MsgBox(sText, MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Kayıt Bilgisi")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FasondaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FasondaToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "FASONDA" Then
                MsgBox("Bu sipariş zaten fasonda te!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'FASONDA' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='FASONDA' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "FASONDA"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ÜretimHazırlıkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜretimHazırlıkToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "HAZIRLIK" Then
                MsgBox("Bu sipariş zaten Hazırlık ta!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'HAZIRLIK' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='HAZIRLIK' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "HAZIRLIK"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ÜtüdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜtüdeToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "UTUDE" Then
                MsgBox("Bu sipariş zaten ütüde!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'UTUDE' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='UTUDE' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()

            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "UTUDE"
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub YakaÖrgüToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YakaÖrgüToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If
            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "YAKA-ORGU" Then
                MsgBox("Bu sipariş zaten Yaka-Örgü de!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'YAKA ÖRGÜ' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='YAKA-ORGU' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "YAKA-ORGU"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub KesimHazirlikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KesimHazirlikToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim sSipDetayID As String = "-99999"
            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    sSipDetayID &= " , " & If0Null(dr("SipDetayID"))
                End If
            Next
            If GridView1.GetSelectedRows.Length >= 10 Then
                Dim sifre = InputBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparis degisimi yapilacaktir. Guvenlik icin giris sifrenizi giriniz", "Kullanici:" &
                                     AppConn.ActiveUser.UserName, "")
                If Trim(sifre) = "" Then Exit Sub
                If AppConn.ActiveUser.Login(AppConn.dbConn, AppConn.ActiveUser.UserName, sifre) = False Then
                    MsgBox("Sifre hatali!")
                    Exit Sub
                End If
            End If

            Dim Durumu As String = IfNull(GridView1.GetDataRow(GridView1.FocusedRowHandle)("Durumu"), "")  ' IfNull(MasterLink.CurrentRow("Durumu"), "")
            If Durumu = "KESIM-HAZIRLIK" Then
                MsgBox("Bu sipariş zaten Kesim-Hazırlıkta!")
                Exit Sub
            End If
            If MsgBox(GridView1.GetSelectedRows.Length.ToString() & " adet siparişin durumunu 'KESIM HAZIRLIK' olarak değiştirmek istediğinizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Durumu Değiştir?") <> MsgBoxResult.Yes Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "UPDATE SipDetay SET Durumu='KESIM-HAZIRLIK' , ModifiedBy=" & AppConn.ActiveUser.UserID & ",ModifiedDate=GETDATE() WHERE Deleted = 0 AND SipDetayID IN (" & sSipDetayID & ") "
            cmd.ExecuteNonQuery()


            For i As Integer = 0 To GridView1.GetSelectedRows.Length - 1
                Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.GetSelectedRows(i))
                If RowIndex >= 0 Then
                    Dim dr As DataRow = MasterTable.Rows(RowIndex)
                    dr("Durumu") = "KESIM-HAZIRLIK"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CntUrunAgaci1_SelectedChanged(Sender As Object, e As UrunAgaciChangedEventArgs) Handles CntUrunAgaci1.SelectedChanged
        Try
            'Dim TreeView1 As TreeView = CType(Sender, TreeView)

            'Dim bKategori As Boolean = False


            'If TreeView1.SelectedNode Is Nothing Then Exit Sub
            'If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub

            Dim filterCondition As String = ""


            GridView1.ActiveFilter.Clear()

            GridView1.ActiveFilter.Add(GridView1.Columns("KategoriKod"), New DevExpress.XtraGrid.Columns.ColumnFilterInfo("StartsWith([KategoriKod], '" & CntUrunAgaci1.aktifKategori.KategoriKod & "')"))


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
