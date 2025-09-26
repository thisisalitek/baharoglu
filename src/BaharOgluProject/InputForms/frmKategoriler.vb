
Public Class frmKategoriler
    Public FormCode As String = "000004"


    'Dim aktifKategori As kategoriItem = New kategoriItem()
    Dim SipDetayID As Long = 0
    Dim OkulID As Long = 0

    Dim SiparisID As Long = 0
    Dim CariKod As String = ""
    Dim CariUnvan As String = ""

    Dim ApplicationMode_ As Boolean = False
    Dim bRefreshing As Boolean = False
    Dim bActivated As Boolean = False
    Dim bNoAction As Boolean = False
    Dim bSaved As Boolean = False

    'Dim Kopyala_KaynakKategoriID As Long = 0
    Dim bEkFiyatlariYukleme As Boolean = False

    Dim MikroBedenArray As New ArrayList
    Public MikroStokKod As String = ""
    Public MikroStokIsmi As String = ""
    Public DovizTipi As String = ""
    Public OkulFarki As Double = 0
    Dim bFormNew As Boolean = False

    Dim bRepairMode As Boolean = False

    Public Property ApplicationMode As Boolean
        Get
            Return ApplicationMode_
        End Get
        Set(ByVal value As Boolean)
            ApplicationMode_ = value
            'If value = True Then
            '    PanelControl5.Visible = False
            '    'PanelControl4.Visible = False
            '    panelOkul.Visible = True
            'Else
            '    PanelControl5.Visible = True
            '    'PanelControl4.Visible = True
            '    panelOkul.Visible = False
            'End If
        End Set
    End Property

    Public Sub FormShow()
        Try
            'Me.Text = "Urun Agaci"
            InitializeConnection()
            RefreshList()
            Me.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FormShow_NewSiparis(ByVal SipDetayID_ As Long)
        Try
            If SipDetayID_ <= 0 Then
                MsgBox("Yeni siparis aÃ§ilamadi. Tekrar deneyin.")
                Exit Sub
            End If
            Me.Text = "Yeni - Siparis Detay"
            InitializeConnection()
            SipDetayID = SipDetayID_
            ApplicationMode = True
            RefreshList()
            FindKategori()

            bFormNew = True
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FormShow_Edit(ByVal SipDetayID_ As Long)
        Try
            Me.Text = "Duzelt - Siparis Detay"

            InitializeConnection()
            bEkFiyatlariYukleme = True
            SipDetayID = SipDetayID_
            ApplicationMode = True
            RefreshList()
            FindKategori()



            'TreeView1.Enabled = False
            CntUrunAgaci1.Enabled = False
            panelLeft.Enabled = False
            bEkFiyatlariYukleme = False
            bFormNew = False
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub FormShow_Repair(ByVal SipDetayID_ As Long)
        Try
            Me.Text = "Duzelt - Siparis Detay"
            InitializeConnection()
            bEkFiyatlariYukleme = True
            SipDetayID = SipDetayID_
            ApplicationMode = True
            RefreshList()
            FindKategori()



            'TreeView1.Enabled = False
            CntUrunAgaci1.Enabled = False
            bEkFiyatlariYukleme = False
            bFormNew = False
            bRepairMode = True
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindKategori()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            ' , (SELECT COUNT(*) FROM Kategoriler WHERE UstKategoriID =Kategoriler.KategoriID ) as NodeSayisi
            cmd.CommandText = "SELECT     TOP 1 Kategoriler.KategoriID  FROM SipDetay INNER JOIN  " &
                " Kategoriler ON SipDetay.KategoriID = Kategoriler.KategoriID " &
                "WHERE  SipDetay.SipDetayID = " & SipDetayID & " " &
                " " &
                ""
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'Dim bKategori As Boolean
                'If (If0Null(dt.Rows(0).Item("NodeSayisi")) = 0) Then
                '    bKategori = False
                'Else
                '    bKategori = True
                'End If
                'aktifKategori = New kategoriItem(If0Null(dt.Rows(0).Item("UstKategoriID")), If0Null(dt.Rows(0).Item("KategoriID")), If0Null(dt.Rows(0).Item("KendiFiyatBedenKullan")), If0Null(dt.Rows(0).Item("KendiMasrafKullan")), bKategori)
                CntUrunAgaci1.findAndFocus(dt.Rows(0).Item("KategoriID"), New ArrayList())
                'Dim d = TreeView1.Nodes.Find(dt.Rows(0).Item("KategoriKod").ToString(), True)
                'If d.Length > 0 Then
                '    TreeView1.SelectedNode = d(0)
                'End If
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Dim kategoriDT As New DataTable

    'Private Sub LoadKategori(Optional loadAgain As Boolean = False)
    '    Try
    '        If (IO.File.Exists(GetMyDir() & "\kategoriler.xml")) And loadAgain = False Then
    '            TreeView1.Nodes.Clear()
    '            Dim serializer As New TreeViewSerializer()
    '            serializer.DeserializeTreeView(TreeView1, GetMyDir() & "\kategoriler.xml")

    '        Else

    '            load_kategoriDT()

    '            TreeView1.Nodes.Clear()


    '            AddKategori(0, Nothing)

    '            Dim serializer As New TreeViewSerializer()

    '            serializer.SerializeTreeView(TreeView1, GetMyDir() & "\kategoriler.xml")
    '        End If


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub load_kategoriDT()
    '    Try
    '        Dim cmd As New SqlClient.SqlCommand
    '        Dim da As SqlClient.SqlDataAdapter
    '        cmd.Connection = AppConn.dbConn
    '        cmd.CommandText = "Select *, (SELECT COUNT(*) FROM Kategoriler WHERE Deleted = 0 And UstKategoriID=K.KategoriID) as NodeCount  FROM Kategoriler K WHERE K.Deleted = 0 ORDER BY K.KategoriKod "
    '        da = New SqlClient.SqlDataAdapter(cmd)
    '        kategoriDT = New DataTable
    '        da.Fill(kategoriDT)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub AddKategori(ByVal UstKategoriID As Long, ByRef Node1 As TreeNode)
    '    Try
    '        'Dim cmd As New SqlClient.SqlCommand
    '        'Dim da As SqlClient.SqlDataAdapter
    '        'Dim dt As DataTable
    '        'cmd.Connection = AppConn.dbConn
    '        'cmd.CommandText = "SELECT * FROM Kategoriler WHERE Deleted = 0 And UstKategoriID = " & UstKategoriID & " ORDER BY KategoriKod "
    '        'da = New SqlClient.SqlDataAdapter(cmd)
    '        'dt = New DataTable
    '        'da.Fill(dt)
    '        If Not Node1 Is Nothing Then
    '            If Node1.Nodes.Count > 0 Then
    '                Node1.Nodes.Clear()
    '            End If
    '        End If
    '        Dim focusnode As TreeNode = Nothing

    '        Dim dt = (From kat In kategoriDT.Rows Where kat("UstKategoriID") = UstKategoriID).ToList()


    '        For Each dr As DataRow In dt
    '            Dim newnode As TreeNode
    '            If Node1 Is Nothing Then
    '                newnode = TreeView1.Nodes.Add(IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriKod"), "") & " - " & IfNull(dr("KategoriIsim"), ""))
    '            Else
    '                newnode = Node1.Nodes.Add(IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriKod"), "") & " - " & IfNull(dr("KategoriIsim"), ""))
    '            End If

    '            Dim bKategori As Boolean = False

    '            If (CType(dr("NodeCount"), Int32) > 0) Then
    '                bKategori = True
    '                newnode.ImageIndex = 0
    '                newnode.SelectedImageIndex = 0
    '            Else
    '                bKategori = False
    '                newnode.ImageIndex = 1
    '                newnode.SelectedImageIndex = 1
    '                If If0Null(dr("KendiFiyatBedenKullan")) = 1 Or If0Null(dr("KendiMasrafKullan")) = 1 Then
    '                    newnode.ForeColor = Color.Blue
    '                End If
    '            End If
    '            'cmd.CommandText = "SELECT COUNT(*) FROM Kategoriler WHERE UstKategoriID = " & dr("KategoriID").ToString()
    '            'If If0Null(cmd.ExecuteScalar()) = 0 Then


    '            'Dim nodsayisi = (From k In kategoriDT.Rows Where k("UstKategoriID") = dr("KategoriID") Select k).Count()
    '            'If nodsayisi = 0 Then
    '            '    newnode.ImageIndex = 1
    '            '    newnode.SelectedImageIndex = 1
    '            '    If If0Null(dr("KendiFiyatBedenKullan")) = 1 Or If0Null(dr("KendiMasrafKullan")) = 1 Then
    '            '        newnode.ForeColor = Color.Blue
    '            '    End If
    '            '    bKategori = False
    '            'Else
    '            '    bKategori = True
    '            'End If

    '            'bKategori = True

    '            newnode.Tag = New kategoriItem(If0Null(dr("UstKategoriID")), If0Null(dr("KategoriID")), If0Null(dr("KendiFiyatBedenKullan")), If0Null(dr("KendiMasrafKullan")), bKategori)
    '            AddKategori(If0Null(dr("KategoriID")), newnode)


    '            If aktifKategori.KategoriID > 0 Then
    '                If CType(newnode.Tag, kategoriItem).KategoriID = aktifKategori.KategoriID Then
    '                    focusnode = newnode
    '                End If
    '            End If
    '        Next
    '        'dt.Dispose()
    '        'da.Dispose()
    '        'hooop aktif kategori buralardaysa focuslanalim 
    '        If aktifKategori.KategoriID > 0 Then
    '            TreeView1.SelectedNode = focusnode
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Private Sub RefreshList(Optional loadAgain As Boolean = False)
        Try


            SiparisMusteriBilgisiYukle()
            bRefreshing = True


            If ApplicationMode Then
                tbSipDetayFiyatlar.SelectCommand.Parameters("@SipDetayID").Value = SipDetayID
                OpenTable(tbSipDetayFiyatlar)
                tbSipDetayEkFiyatlar.SelectCommand.Parameters("@SipDetayID").Value = SipDetayID
                OpenTable(tbSipDetayEkFiyatlar)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bRefreshing = False
    End Sub

    Private Sub SiparisMusteriBilgisiYukle()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "Select Siparis.* FROM Siparis INNER JOIN 
                SipDetay ON Siparis.SiparisID=SipDetay.SiparisID
                WHERE  SipDetay.SipDetayID=" & SipDetayID & " "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                SiparisID = If0Null(dt.Rows(0).Item("SiparisID"))
                CariKod = IfNull(dt.Rows(0).Item("CariKod"), "")
                CariUnvan = IfNull(dt.Rows(0).Item("CariUnvan"), "")
                txtMusteri.Text = CariKod & " - " & CariUnvan
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("() " & ex.Message)
        End Try
    End Sub


    Private Sub cmdOzellikleriEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOzellikleriEkle.Click
        Try
            XtraTabControl1.SelectedTabPageIndex = 1
            For Each ct As Control In panelOzellikler.Controls
                If CType(ct, BaseControl).KategoriID <> CntUrunAgaci1.aktifKategori.KategoriID Then
                    panelOzellikler.Controls.Remove(ct)
                    ct.Dispose()
                End If

            Next
            If panelOzellikler.Controls.Count <= 0 Then
                panelOzellikler.Controls.Clear()
            End If
            For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cboSecenekler.Items
                If item.Value = "057" Or item.Value = "056" Or item.Value = "055" Then
                    If item.CheckState = CheckState.Unchecked Then
                        item.CheckState = CheckState.Checked
                    End If
                End If

            Next

            For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cboSecenekler.Items
                Dim bFound As Boolean = False
                For Each ct As Control In panelOzellikler.Controls
                    If CType(ct, BaseControl).Code = item.Value Then
                        bFound = True
                        If item.CheckState = CheckState.Unchecked Then
                            CType(ct, BaseControl).Deleted = True
                        End If
                        Exit For
                    End If
                Next
                If bFound = False Then
                    If item.CheckState = CheckState.Checked Then
                        AddParam(item.Value, CntUrunAgaci1.aktifKategori.KategoriID, 0)
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddParam(ByVal ParamType As String, ByVal KategoriID As Long, ByVal KategoriParamID As Long)
        Try
            Select Case ParamType
                Case "001"
                    Dim ct As New cnt001_Kumas
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID

                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "002"
                    Dim ct As New cnt002_Lastik
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID

                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "003"
                    Dim ct As New cnt003_Yaka
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "004"
                    Dim ct As New cnt004_DubleLastikCep
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "005"
                    Dim ct As New cnt005_DubleLastikPilotYaka
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "006"
                    Dim ct As New cnt006_DubleLastik
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "007"
                    Dim ct As New cnt007_DubleYaka
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "008"
                    Dim ct As New cnt008_TorbaliBant
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "009"
                    Dim ct As New cnt009_Kumas2
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "010"
                    Dim ct As New cnt010_GomlekParams
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "011"
                    Dim ct As New cnt011_LakosKumas
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "012"
                    Dim ct As New cnt012_LakosYaka
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "013"
                    Dim ct As New cnt013_Manset2cm
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "014"
                    Dim ct As New cnt014_Manset6cm
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "015"
                    Dim ct As New cnt015_Fular
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "016"
                    Dim ct As New cnt016_Kravat
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "017"
                    Dim ct As New cnt017_DubleLastikIcCep
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "018"
                    Dim ct As New cnt018_EtekManset
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "019"
                    Dim ct As New cnt019_Kaskorse
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "020"
                    Dim ct As New cnt020_GogusManset
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "021"
                    Dim ct As New cnt021_CepKapagi
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "051"
                    'Dim ct As New cnt051_Tip
                    'ct.KategoriID = KategoriID
                    'ct.KategoriParamID = KategoriParamID
                    'ct.SqlConn = FirmConn
                    'ct.ApplicationMode = ApplicationMode
                    'ct.SipDetayID = SipDetayID
                    'ct
                    'ct.Initialize()
                    'panelOzellikler.Controls.Add(ct)
                Case "052"
                    Dim ct As New cnt052_KazakYaka
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)

                Case "053"
                    'Dim ct As New cnt053_DigerSecenek
                    'ct.KategoriID = KategoriID
                    'ct.KategoriParamID = KategoriParamID
                    'ct.SqlConn = FirmConn
                    'ct.ApplicationMode = ApplicationMode
                    'ct.SipDetayID = SipDetayID
                    'ct
                    'ct.Initialize()
                    'panelOzellikler.Controls.Add(ct)
                Case "054"
                    Dim ct As New cnt054_GarniDikis
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "055"
                    Dim ct As New cnt055_Secenek
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "056"
                    Dim ct As New cnt056_EkFiyat
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)
                Case "057"
                    Dim ct As New cnt057_EkOzellik
                    ct.KategoriID = KategoriID
                    ct.KategoriParamID = KategoriParamID
                    ct.SqlConn = FirmConn
                    ct.ApplicationMode = ApplicationMode
                    ct.SipDetayID = SipDetayID
                    ct.Initialize()
                    panelOzellikler.Controls.Add(ct)



                Case Else

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmKategoriler_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If bActivated Then Exit Sub
        bActivated = True
        'If Not TreeView1.SelectedNode Is Nothing Then
        '    TreeView1_AfterSelect(Nothing, Nothing)
        'End If
        If bRepairMode Then
            tmrRapair.Enabled = True
        End If
    End Sub
    Private Sub frmKategoriler_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmKategoriler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False



            tbSipDetay.SelectCommand.CommandText &= " And SipDetayID=" & SipDetayID
            OpenTable(tbSipDetay)

            If tbSipDetay.Rows.Count > 0 Then
                If bFormNew = False Then
                    tbSipDetay.Rows(0).Item("bSerbestFiyat") = 1
                    tbSipDetay.Rows(0).EndEdit()
                End If
            End If
            'Debug.Print(tbOkul.Rows.Count)
            'cboOkul.Properties.DataSource = tbOkul
            If MikroStokKod <> "" Then
                If tbSipDetay.Rows.Count > 0 Then
                    tbSipDetay.Rows(0).Item("StokKod") = MikroStokKod
                    tbSipDetay.Rows(0).Item("StokIsmi") = MikroStokIsmi
                End If
            End If
            If bFormNew Then
                If tbSipDetay.Rows.Count > 0 Then
                    tbSipDetay.Rows(0).Item("OkulFarki") = OkulFarki
                End If
            End If
            OpenTable(tbOkul)
            Load_cboRenkler()

            If ApplicationMode Then
                If DovizTipi = "" Or DovizTipi = "TL" Then

                Else
                    colBrutFiyat.OptionsColumn.AllowEdit = True
                    colBrutFiyat.AppearanceCell.BackColor = Color.White
                    colBrutFiyat.AppearanceCell.BackColor2 = Color.White
                End If

            End If
            If AppConn.ActiveUser.bAdmin Then
                chkSerbestFiyat.Enabled = True
            Else
                chkSerbestFiyat.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InitializeConnection()
        Try
            FirmConn.ConnectionString = AppConn.dbConnStr
            FirmConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ShowAktifKategori(ByVal bKategori As Boolean)
        Try
            lblAktifKategoriKod.Text = CntUrunAgaci1.aktifKategori.KategoriKod
            lblAktifKategoriIsim.Text = CntUrunAgaci1.aktifKategori.KategoriIsim

            'Dim cmd As New SqlClient.SqlCommand
            'Dim da As SqlClient.SqlDataAdapter
            'Dim dt As DataTable
            'cmd.Connection = AppConn.dbConn
            'cmd.Parameters.Clear()
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@KategoriID", aktifKategori.KategoriID))
            'cmd.CommandText = "Select * From Kategoriler Where Deleted = 0 And KategoriID =@KategoriID "
            'da = New SqlClient.SqlDataAdapter(cmd)
            'dt = New DataTable
            'da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            '    lblAktifKategoriKod.Text = IfNull(dt.Rows(0).Item("KategoriKod"), "")
            '    lblAktifKategoriIsim.Text = IfNull(dt.Rows(0).Item("KategoriIsim"), "") & " ID" & aktifKategori.KategoriID
            '    lblAktifKategoriEntKod.Text = IfNull(dt.Rows(0).Item("IntCode"), "")
            'End If
            'dt.Dispose()
            'da.Dispose()
            'cmd.Dispose()
        Catch ex As Exception
            MsgBox("(ShowAktifKategori) " & ex.Message)
        End Try

    End Sub

    Private Sub LoadParams(ByVal bKategori As Boolean)
        Try
            LoadingShow()
            For Each ct As Control In panelOzellikler.Controls
                ct.Dispose()
            Next
            panelOzellikler.Controls.Clear()
            If CntUrunAgaci1.aktifKategori.KategoriID <= 0 Then
                LoadingHide()
                Exit Sub
            End If
            If bKategori = False Then
                Dim cmd As New SqlClient.SqlCommand
                Dim da As SqlClient.SqlDataAdapter
                Dim dt As DataTable
                cmd.Connection = AppConn.dbConn
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlClient.SqlParameter("@KategoriID", CntUrunAgaci1.aktifKategori.KategoriID))
                'cmd.CommandText = "SELECT * FROM KategoriParam WHERE Deleted = 0 And KategoriID=@KategoriID ORDER BY ParamType"
                cmd.CommandText = "SELECT * FROM KategoriParam LEFT OUTER JOIN " &
                    " ParamSira ON KategoriParam.ParamType=ParamSira.ParamType " &
                    " WHERE Deleted = 0  And KategoriID=@KategoriID " &
                    " ORDER BY ParamSira.SiraNo "

                da = New SqlClient.SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                For Each dr As DataRow In dt.Rows
                    AddParam(IfNull(dr("ParamType"), ""), If0Null(dr("KategoriID")), If0Null(dr("KategoriParamID")))
                Next
                dt.Dispose()
                da.Dispose()
                cmd.Dispose()

                Try
                    For Each Item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cboSecenekler.Items
                        Item.CheckState = CheckState.Unchecked
                    Next
                    For Each ct As Control In panelOzellikler.Controls
                        Try
                            For Each Item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cboSecenekler.Items
                                If CType(ct, BaseControl).Code = Item.Value Then
                                    Item.CheckState = CheckState.Checked
                                End If
                            Next
                        Catch ex As Exception

                        End Try
                    Next
                Catch ex As Exception
                    LoadingHide()
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
        LoadingHide()
    End Sub

    Private Sub FiyatlariGoster()
        Try
            If CntUrunAgaci1.aktifKategori.bKategori Then
                tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
            Else
                If (CntUrunAgaci1.aktifKategori.KendiFiyatBedenKullan = 1) Then
                    tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                Else
                    tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.UstKategoriID
                End If

            End If

            OpenTable(tbKategoriFiyat)


            If CntUrunAgaci1.aktifKategori.bKategori Then
                tbKategoriEkFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
            Else
                If (CntUrunAgaci1.aktifKategori.KendiMasrafKullan = 1) Then
                    tbKategoriEkFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                Else
                    tbKategoriEkFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.UstKategoriID
                End If

            End If

            OpenTable(tbKategoriEkFiyat)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSaveOzellik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveOzellik.Click
        Try
            If cmdSaveOzellik.Enabled = False Then Exit Sub

            If bRepairMode = False Then
                If XtraTabControl2.SelectedTabPageIndex = 1 Or XtraTabControl2.SelectedTabPageIndex = 2 Then

                Else
                    Exit Sub
                End If
            End If
            If tbSipDetay.Rows.Count <= 0 Then Exit Sub
            If If0Null(tbSipDetay.Rows(0).Item("OkulID")) <= 0 Then
                MsgBox("Luten okul seÃ§iniz!")
                Exit Sub
            End If
            If Trim(IfNull(tbSipDetay.Rows(0).Item("BolumKod"), "")) = "" Then
                MsgBox("Luten bÃ¶lum seÃ§iniz! Hangi 4+4+4 olacak?")
                Exit Sub
            End If
            If IfNull(tbSipDetay.Rows(0).Item("Tarih"), DateSerial(1900, 1, 1)) > IfNull(tbSipDetay.Rows(0).Item("TerminTarihi"), DateSerial(1900, 1, 1)) Then
                MsgBox("Termin tarihi siparis tarihinden kuÃ§uk olamaz!")
                Exit Sub
            End If
            If bRepairMode = False Then
                If MsgBox("Kaydetmek istediginizden emin misiniz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kaydet?") <> MsgBoxResult.Yes Then Exit Sub
            End If

            If Save() = True Then
                bSaved = True
                If ApplicationMode Then

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Save() As Boolean
        Try

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable
            cmd.Connection = AppConn.dbConn

            If ApplicationMode = True Then
                cmd.CommandText = "DELETE FROM SipDetayUretimBilgi WHERE SipDetayID=" & SipDetayID & " " & vbNewLine
                cmd.CommandText &= "DELETE FROM SipDetayBilgi WHERE SipDetayID=" & SipDetayID & " " & vbNewLine
                cmd.ExecuteNonQuery()
            End If

            For Each ct As Control In panelOzellikler.Controls
                If TypeOf ct Is BaseControl Then
                    If tbSipDetay.Rows.Count > 0 Then
                        CType(ct, BaseControl).ToplamAdet = If0Null(tbSipDetay.Rows(0).Item("Miktar"))
                        Dim Bdn As New ArrayList
                        If (CntUrunAgaci1.aktifKategori.KendiFiyatBedenKullan) Then
                            cmd.CommandText = "SELECT     Kategoriler.KategoriID, KategoriFiyat.BedenNo, KategoriFiyat.BedenKod, KategoriFiyat.Fiyat, KategoriFiyat.BazBedenMi " &
                           "FROM         Kategoriler INNER JOIN " &
                           "                      KategoriFiyat ON Kategoriler.KategoriID = KategoriFiyat.KategoriID " &
                           "WHERE     (Kategoriler.Deleted = 0) And (Kategoriler.KategoriID = " & CntUrunAgaci1.aktifKategori.KategoriID & ") And (KategoriFiyat.Deleted = 0)  " &
                           "ORDER BY KategoriFiyat.BedenNo " &
                           ""
                        Else
                            cmd.CommandText = "SELECT     Kategoriler.KategoriID, KategoriFiyat.BedenNo, KategoriFiyat.BedenKod, KategoriFiyat.Fiyat, KategoriFiyat.BazBedenMi " &
                           "FROM         Kategoriler INNER JOIN " &
                           "                      KategoriFiyat ON Kategoriler.KategoriID = KategoriFiyat.KategoriID " &
                           "WHERE     (Kategoriler.Deleted = 0) And (Kategoriler.KategoriID = " & CntUrunAgaci1.aktifKategori.UstKategoriID & ") And (KategoriFiyat.Deleted = 0)  " &
                           "ORDER BY KategoriFiyat.BedenNo " &
                           ""
                        End If

                        da = New SqlClient.SqlDataAdapter(cmd)
                        dt = New DataTable
                        da.Fill(dt)
                        For Each dr As DataRow In dt.Rows
                            Dim bFound As Boolean = False
                            Dim cBeden As New clsBeden
                            Dim bBazBedenFound As Boolean = False
                            cBeden.BedenKod = IfNull(dr("BedenKod"), "")
                            For Each dr2 As DataRow In tbSipDetayFiyatlar.Rows
                                If dr2.RowState <> DataRowState.Deleted And dr2.RowState <> DataRowState.Detached Then
                                    If IfNull(dr("BedenKod"), "") = IfNull(dr2("BedenKod"), "") Then
                                        cBeden.Miktar = If0Null(dr2("Miktar"))
                                        If If0Null(dr("BazBedenMi")) <> 0 Then
                                            cBeden.BazBeden = True
                                            bBazBedenFound = True
                                        End If
                                        Bdn.Add(cBeden)
                                        bFound = True
                                        Exit For
                                    End If

                                End If
                            Next

                        Next
                        dt.Dispose()
                        da.Dispose()

                        CType(ct, BaseControl).Bedenler = Bdn
                    Else
                        CType(ct, BaseControl).ToplamAdet = 0
                    End If


                    CType(ct, BaseControl).Save()
                End If
            Next
            If ApplicationMode = True Then

                cmd.CommandText = "UPDATE SipDetayParam SET Deleted =SipDetayParamID  WHERE SipDetayParamID IN ( " &
                    "SELECT  SipDetayParam.SipDetayParamID FROM         KategoriParam INNER JOIN " &
                    "                      SipDetayParam ON KategoriParam.KategoriParamID = SipDetayParam.KategoriParamID " &
                    "WHERE     (SipDetayParam.SipDetayID = " & SipDetayID & ") And (KategoriParam.Deleted = 0) And (KategoriParam.KategoriID <>" & CntUrunAgaci1.aktifKategori.KategoriID & ") " &
                    ") "
                cmd.ExecuteNonQuery()
                If tbSipDetay.Rows.Count > 0 Then

                    tbSipDetay.Rows(0).Item("KategoriID") = CntUrunAgaci1.aktifKategori.KategoriID
                    Try
                        If IfNull(tbSipDetay.Rows(0).Item("StokKod"), "") = "" Then
                            Dim StokKod As String = ""
                            cmd.CommandText = "SELECT IntCode FROM Kategoriler WHERE Deleted = 0 And KategoriID = " & CntUrunAgaci1.aktifKategori.KategoriID
                            da = New SqlClient.SqlDataAdapter(cmd)
                            dt = New DataTable
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                StokKod = IfNull(dt.Rows(0).Item("IntCode"), "")
                            End If
                            da.Dispose()
                            dt.Dispose()
                            If Trim(StokKod) <> "" Then
                                Dim cmdMikro As New SqlClient.SqlCommand
                                Dim daMikro As SqlClient.SqlDataAdapter
                                Dim dtMikro As DataTable
                                cmdMikro.Connection = AppConn.dbTicari
                                cmdMikro.Parameters.Clear()
                                cmdMikro.Parameters.Add(New SqlClient.SqlParameter("@StokKod", StokKod))
                                cmdMikro.CommandText = "SELECT sto_Guid,sto_kod,sto_isim FROM STOKLAR WHERE sto_kod=@StokKod "
                                daMikro = New SqlClient.SqlDataAdapter(cmdMikro)
                                dtMikro = New DataTable
                                daMikro.Fill(dtMikro)
                                If dtMikro.Rows.Count > 0 Then
                                    tbSipDetay.Rows(0).Item("StokKod") = IfNull(dtMikro.Rows(0).Item("sto_kod"), "")
                                    tbSipDetay.Rows(0).Item("StokIsmi") = IfNull(dtMikro.Rows(0).Item("sto_isim"), "")
                                Else
                                    MsgBox("Bu urun kategorisinin mikrodaki stok kodu yanlis!")

                                End If
                                daMikro.Dispose()
                                dtMikro.Dispose()
                                cmdMikro.Dispose()

                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim TMiktar As Double = 0
                    Dim OrtFiyat As Double = 0
                    Dim TTutar As Double = 0
                    Dim IskontoTutar As Double = 0
                    Dim NakitIskontoTutar As Double = 0
                    For i = 0 To tbSipDetayFiyatlar.Rows.Count - 1
                        TMiktar += IfNull(tbSipDetayFiyatlar.Rows(i).Item("Miktar"), 0)
                        TTutar += IfNull(tbSipDetayFiyatlar.Rows(i).Item("Tutar"), 0)
                        Dim isk1 As Double = IfNull(tbSipDetayFiyatlar.Rows(i).Item("Iskonto"), 0)
                        Dim isk2 As Double = IfNull(tbSipDetayFiyatlar.Rows(i).Item("NakitIskonto"), 0)
                        Dim BrutFiyat As Double = IfNull(tbSipDetayFiyatlar.Rows(i).Item("BrutFiyat"), 0)
                        Dim miktar As Double = IfNull(tbSipDetayFiyatlar.Rows(i).Item("Miktar"), 0)
                        IskontoTutar += miktar * BrutFiyat * isk1 / 100
                        NakitIskontoTutar += miktar * (BrutFiyat - BrutFiyat * isk1 / 100) * isk2 / 100
                    Next
                    If TMiktar > 0 Then OrtFiyat = TTutar / TMiktar

                    tbSipDetay.Rows(0).Item("Miktar") = TMiktar
                    tbSipDetay.Rows(0).Item("Tutar") = TTutar
                    tbSipDetay.Rows(0).Item("Fiyat") = OrtFiyat
                    tbSipDetay.Rows(0).Item("IskontoTutar") = IskontoTutar
                    tbSipDetay.Rows(0).Item("NakitIskontoTutar") = NakitIskontoTutar
                    tbSipDetay.Rows(0).EndEdit()

                End If

                tbSipDetay.Save()
                'If ApplicationMode Then
                '    cmd.CommandText = "UPDATE SipDetay SET IskontoTutar=SDF.IskontoTutar,NakitIskontoTutar= SDF.NakitIskontoTutar   FROM SipDetay INNER JOIN
                '    (SELECT SipDetayID, SUM(BrutFiyat*Miktar * Iskonto/100) as IskontoTutar,SUM(Miktar*(BrutFiyat - BrutFiyat * Iskonto/100)*NakitIskonto/100) as  NakitIskontoTutar FROM SipDetayFiyatlar 

                '    GROUP BY SipDetayID) SDF ON SDF.SipDetayID = SipDetay.SipDetayID
                '    WHERE SipDetay.SipDetayID=" & SipDetayID & "  "
                '    cmd.ExecuteNonQuery()

                'End If
                tbSipDetayFiyatlar.Save()
                tbSipDetayEkFiyatlar.Save()
                If SipDetayRenkler(AppConn.dbConn, SipDetayID) = False Then

                End If
                Return True
            Else
                MsgBox("Ok")
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub cmdCancelOzellik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelOzellik.Click
        Try
            'LoadParams(True)
            If ApplicationMode = False Then
                XtraTabControl1.SelectedTabPageIndex = 0
            Else
                Me.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboOkul_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboOkul.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                Dim f As New frmOkullar
                With f

                    .FormShow()
                End With
                OpenTable(tbOkul)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub tbSipDetay_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tbSipDetay.ColumnChanged
        Try
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub frmKategoriler_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            If XtraTabControl1.SelectedTabPageIndex = 0 Then
                cmdOzellikleriEkle_Click(Nothing, Nothing)
            End If

        End If

        If e.KeyCode = Keys.F2 Then
            cmdSaveOzellik_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmdKaydetFiyat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKaydetFiyat.Click
        Try
            If (CntUrunAgaci1.aktifKategori.bKategori = False) Then
                Dim KendiFiyatBedenKullan As Long = 0, KendiMasrafKullan As Long = 0
                If (chkKategori_KendiFiyatBeden.Checked) Then KendiFiyatBedenKullan = 1
                If (chkKategori_KendiMasraf.Checked) Then KendiMasrafKullan = 1
                If (CntUrunAgaci1.aktifKategori.KendiFiyatBedenKullan <> KendiFiyatBedenKullan Or CntUrunAgaci1.aktifKategori.KendiMasrafKullan <> KendiMasrafKullan) Then
                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = AppConn.dbConn
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@UserID", AppConn.ActiveUser.UserID)

                    'If (aktifKategori.KendiFiyatBedenKullan = 0 And KendiFiyatBedenKullan = 1) Then
                    '    cmd.CommandText = "INSERT INTO  KategoriFiyat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriID, BedenNo, BedenKod, Fiyat, BazBedenMi) " &
                    '        "SELECT Deleted, @UserID, GETDATE(),  @UserID, GETDATE(), " & aktifKategori.KategoriID & " , BedenNo, BedenKod, Fiyat, BazBedenMi FROM KategoriFiyat " &
                    '        " WHERE KategoriID = " & aktifKategori.UstKategoriID & " And Not BedenKod IN (SELECT BedenKod FROM KategoriFiyat WHERE KategoriID = " & aktifKategori.KategoriID & ") "
                    '    cmd.ExecuteNonQuery()

                    'End If
                    'If (aktifKategori.KendiMasrafKullan = 0 And KendiMasrafKullan = 1) Then
                    '    cmd.CommandText = "INSERT INTO  KategoriEkFiyat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriID, MasrafKod, MasrafIsmi, Fiyat, BedenArtis) " &
                    '        "SELECT Deleted, @UserID, GETDATE(),  @UserID, GETDATE(),  " & aktifKategori.KategoriID & ", MasrafKod, MasrafIsmi, Fiyat, BedenArtis FROM  KategoriEkFiyat " &
                    '        " WHERE KategoriID = " & aktifKategori.UstKategoriID & " And Not MasrafKod IN (SELECT MasrafKod FROM KategoriEkFiyat WHERE KategoriID = " & aktifKategori.KategoriID & ") "
                    '    cmd.ExecuteNonQuery()

                    'End If
                    cmd.CommandText = "UPDATE Kategoriler SET  KendiFiyatBedenKullan = " & KendiFiyatBedenKullan & ", KendiMasrafKullan= " & KendiMasrafKullan & " , ModifiedBy=@UserID, ModifiedDate=GETDATE() WHERE KategoriID=" & CntUrunAgaci1.aktifKategori.KategoriID
                    cmd.ExecuteNonQuery()
                    CntUrunAgaci1.aktifKategori.KendiFiyatBedenKullan = KendiFiyatBedenKullan
                    CntUrunAgaci1.aktifKategori.KendiMasrafKullan = KendiMasrafKullan
                    'TreeView1.SelectedNode.Tag = aktifKategori
                    'qwerty
                End If
            End If

            Dim bFound As Boolean = False
            If chkKategori_KendiFiyatBeden.Checked Or CntUrunAgaci1.aktifKategori.bKategori Then
                For i As Integer = 0 To tbKategoriFiyat.Rows.Count - 1
                    Dim dr As DataRow = tbKategoriFiyat.Rows(i)
                    If dr.RowState <> DataRowState.Deleted Then
                        dr("BedenNo") = i + 1
                        dr("KategoriID") = CntUrunAgaci1.aktifKategori.KategoriID
                        If bFound = True Then
                            If If0Null(dr("BazBedenMi")) = 1 Then
                                dr("BazBedenMi") = 0
                            End If
                        End If
                        If If0Null(dr("BazBedenMi")) = 1 Then
                            bFound = True
                        End If
                    End If
                Next
                If bFound = False Then
                    For i As Integer = 0 To tbKategoriFiyat.Rows.Count - 1
                        Dim dr As DataRow = tbKategoriFiyat.Rows(i)
                        If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                            dr("BazBedenMi") = 1
                            dr.EndEdit()
                            Exit For
                        End If
                    Next
                End If
                tbKategoriFiyat.Save()

            End If

            If chkKategori_KendiMasraf.Checked Or CntUrunAgaci1.aktifKategori.bKategori Then
                For i As Integer = 0 To tbKategoriEkFiyat.Rows.Count - 1
                    Dim dr As DataRow = tbKategoriEkFiyat.Rows(i)
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        dr("KategoriID") = CntUrunAgaci1.aktifKategori.KategoriID
                    End If
                Next
                tbKategoriEkFiyat.Save()
            End If


            If chkKategori_KendiFiyatBeden.Checked And chkKategori_KendiMasraf.Checked Then
                MsgBox("Bedenler,Fiyatlar  +  Masraf kalemleri kaydedildi")
            ElseIf chkKategori_KendiFiyatBeden.Checked Then
                MsgBox("Sadece Bedenler,Fiyatlar  kaydedildi")
            ElseIf chkKategori_KendiMasraf.Checked Then
                MsgBox("Sadece Masraf kalemleri kaydedildi")
            End If


            XtraTabControl1.SelectedTabPageIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_EditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.EditorKeyDown
        GridControl1_KeyDown(sender, e)

    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        Try
            If e.KeyCode = Keys.Delete And (e.Shift Or e.Control) Then
                mnuFiyatSil_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbKategoriFiyat_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tbKategoriFiyat.ColumnChanged
        Try
            If bNoAction Then Exit Sub
            bNoAction = True
            If e.Column.ColumnName = "BazBedenMi" Then
                For i As Integer = 0 To tbKategoriFiyat.Rows.Count - 1
                    Dim dr As DataRow = tbKategoriFiyat.Rows(i)
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If If0Null(dr("KategoriFiyatID")) <> If0Null(e.Row("KategoriFiyatID")) Then
                            dr("BazBedenMi") = 0
                        End If
                    End If
                Next
                e.Row("BazBedenMi") = 1
            End If
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub


    Private Sub mnuMoveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoveUp.Click
        Try
            If GridView1.FocusedRowHandle <= 0 Then Exit Sub
            Dim oldRowHandle As Integer = GridView1.FocusedRowHandle

            Dim rowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            Dim dr As DataRow = tbKategoriFiyat.Rows(rowIndex)
            Dim newdr As DataRow = tbKategoriFiyat.NewRow
            newdr.ItemArray = dr.ItemArray
            tbKategoriFiyat.Rows.Remove(dr)
            tbKategoriFiyat.Rows.InsertAt(newdr, rowIndex - 1)

            GridView1.FocusedRowHandle = oldRowHandle - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuMoveDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoveDown.Click
        Try
            If GridView1.FocusedRowHandle >= GridView1.RowCount - 1 Then Exit Sub
            Dim oldRowHandle As Integer = GridView1.FocusedRowHandle

            Dim rowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            Dim dr As DataRow = tbKategoriFiyat.Rows(rowIndex)
            Dim newdr As DataRow = tbKategoriFiyat.NewRow
            newdr.ItemArray = dr.ItemArray
            tbKategoriFiyat.Rows.Remove(dr)
            tbKategoriFiyat.Rows.InsertAt(newdr, rowIndex + 1)

            GridView1.FocusedRowHandle = oldRowHandle + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuFiyatSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFiyatSil.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            If MsgBox("Satir silmek istediginizden emin misiniz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Satir sil?") <> MsgBoxResult.Yes Then Exit Sub

            Dim rowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            tbKategoriFiyat.Rows(rowIndex).Delete()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            XtraTabControl2.SelectedTabPageIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdDevam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevam.Click
        Try
            If SiparisKontrol() = False Then Exit Sub


            XtraTabPage4.PageVisible = True
            XtraTabControl1.SelectedTabPageIndex = 3
            FiyatlariYukle()
            XtraTabControl2.SelectedTabPageIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function SiparisKontrol() As Boolean
        Try
            Dim smsg As String = ""
            Dim bOk As Boolean = True
            For Each ct As BaseControl In panelOzellikler.Controls
                If ct.IsOk = False Then
                    smsg &= ct.OkayControlMsg & vbNewLine
                    bOk = False
                End If
            Next
            If bOk Then
                txtSiparisKontrol.Visible = False
            Else
                txtSiparisKontrol.Text = smsg
                txtSiparisKontrol.Visible = True
            End If
            Return bOk
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Private Sub FiyatlariYukle()
        Try
            If chkSerbestFiyat.Checked = False Then
                Dim cmd As New SqlClient.SqlCommand
                Dim da As SqlClient.SqlDataAdapter
                Dim dt As DataTable
                cmd.Connection = AppConn.dbConn
                'cmd.CommandText = "SELECT  UstKategoriID   FROM Kategoriler WHERE Deleted = 0 And  KategoriID = " & KategoriID
                'da = New SqlClient.SqlDataAdapter(cmd)
                'dt = New DataTable
                'da.Fill(dt)
                'If dt.Rows.Count > 0 Then
                '    tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = If0Null(dt.Rows(0).Item("UstKategoriID"))
                '    OpenTable(tbKategoriFiyat)
                'End If
                'dt.Dispose()
                'da.Dispose()
                If (CntUrunAgaci1.aktifKategori.bKategori = False And CntUrunAgaci1.aktifKategori.KendiFiyatBedenKullan = 1) Then
                    tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                Else
                    tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.UstKategoriID
                End If

                OpenTable(tbKategoriFiyat)

                For Each dr As DataRow In tbKategoriFiyat.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        Dim bFound As Boolean = False
                        For Each dr2 As DataRow In tbSipDetayFiyatlar.Rows
                            If dr2.RowState <> DataRowState.Deleted And dr2.RowState <> DataRowState.Detached Then
                                'cmd.CommandText = "SELECT Top 1 KategoriID FROM SipDetay WHERE Deleted = 0 And SipDetayID = " & If0Null(dr2("SipDetayID"))
                                'da = New SqlClient.SqlDataAdapter(cmd)
                                'dt = New DataTable

                                If IfNull(dr("BedenKod"), "") = IfNull(dr2("BedenKod"), "") Then
                                    bFound = True
                                    dr2("BazFiyat") = If0Null(dr("Fiyat"))
                                    Exit For
                                End If
                            End If
                        Next
                        If bFound = False Then
                            Dim newdr As DataRow = tbSipDetayFiyatlar.NewRow
                            newdr("SipDetayID") = SipDetayID
                            newdr("BedenKod") = IfNull(dr("BedenKod"), "")
                            newdr("BazFiyat") = If0Null(dr("Fiyat"))
                            tbSipDetayFiyatlar.Rows.Add(newdr)

                        End If
                    End If
                Next
                cmd.Dispose()


                'Okul farkini uygula
                For Each dr2 As DataRow In tbSipDetayFiyatlar.Rows
                    If dr2.RowState <> DataRowState.Deleted And dr2.RowState <> DataRowState.Detached Then
                        dr2("BazFiyat") = If0Null(dr2("BazFiyat")) * (1 + OkulFarki / 100)
                    End If
                Next
                tbSipDetay.Rows(0).Item("OkulFarki") = OkulFarki
                EkFiyatlariYukle()
            End If

            cmdIskontoUygula_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EkFiyatlariYukle()
        Try
            If bEkFiyatlariYukleme = True Then Exit Sub
            Dim k As Long = 0
            Do While k <= tbSipDetayEkFiyatlar.Rows.Count - 1
                Dim dr As DataRow = tbSipDetayEkFiyatlar.Rows(k)
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If dr.RowState = DataRowState.Added Then
                        tbSipDetayEkFiyatlar.Rows.RemoveAt(k)
                    Else
                        dr.Delete()
                        k += 1
                    End If
                Else
                    k += 1
                End If
            Loop

            Dim Fiyat As Double = 0
            Dim BedenArtis As Double = 0
            Dim Uygulanmislar As New ArrayList

            For Each ct As BaseControl In panelOzellikler.Controls

                For i As Integer = 0 To ct.MasrafListesi.Count - 1
                    With CType(ct.MasrafListesi(i), ClsMasraf)
                        Dim bFound As Boolean = False
                        If ct.Code <> "056" And ct.Code <> "001" And ct.Code <> "011" And ct.Code <> "009" Then
                            For j As Integer = 0 To Uygulanmislar.Count - 1
                                If .MasrafKod = Uygulanmislar(j) Then
                                    bFound = True
                                    Exit For
                                End If
                            Next
                        End If
                        If .bUygula And bFound = False Then
                            If ct.Code = "056" Or ct.Code = "001" Or (ct.Code = "009" And .MasrafKod <> "011" And .MasrafKod <> "012") Or ct.Code = "011" Then
                                Dim newdr As DataRow = tbSipDetayEkFiyatlar.NewRow
                                newdr("SipDetayID") = SipDetayID
                                newdr("MasrafKod") = .MasrafKod
                                newdr("MasrafIsmi") = .MasrafIsmi
                                newdr("EkFiyat") = .Fiyat * .Carpan
                                newdr("BedenArtis") = .BedenFarki
                                tbSipDetayEkFiyatlar.Rows.Add(newdr)
                                Uygulanmislar.Add(.MasrafKod)
                                Fiyat += .Fiyat * .Carpan
                                BedenArtis += .BedenFarki
                            Else
                                If .MasrafKod = "S01" Then
                                    Dim newdr As DataRow = tbSipDetayEkFiyatlar.NewRow
                                    newdr("SipDetayID") = SipDetayID
                                    newdr("MasrafKod") = .MasrafKod
                                    newdr("MasrafIsmi") = .MasrafIsmi
                                    newdr("EkFiyat") = .Fiyat * .Carpan
                                    newdr("BedenArtis") = .BedenFarki
                                    tbSipDetayEkFiyatlar.Rows.Add(newdr)
                                    Uygulanmislar.Add(.MasrafKod)
                                    Fiyat += .Fiyat * .Carpan
                                Else
                                    Dim cmd As New SqlClient.SqlCommand
                                    Dim da As SqlClient.SqlDataAdapter
                                    Dim dt As New DataTable
                                    cmd.Connection = AppConn.dbConn
                                    If (CntUrunAgaci1.aktifKategori.bKategori = False And CntUrunAgaci1.aktifKategori.KendiMasrafKullan = 1) Then
                                        cmd.CommandText = "SELECT     KategoriEkFiyat.MasrafKod, KategoriEkFiyat.MasrafIsmi, KategoriEkFiyat.Fiyat, KategoriEkFiyat.BedenArtis " &
                                                "FROM         KategoriEkFiyat  " &
                                                "WHERE     (KategoriEkFiyat.Deleted = 0) And (KategoriEkFiyat.KategoriID = " & CntUrunAgaci1.aktifKategori.KategoriID & ") And KategoriEkFiyat.MasrafKod='" & .MasrafKod & "' " &
                                                " ORDER BY KategoriEkFiyatID DESC"
                                    Else
                                        cmd.CommandText = "SELECT     KategoriEkFiyat.MasrafKod, KategoriEkFiyat.MasrafIsmi, KategoriEkFiyat.Fiyat, KategoriEkFiyat.BedenArtis " &
                                                "FROM         KategoriEkFiyat  " &
                                                "WHERE     (KategoriEkFiyat.Deleted = 0) AND (KategoriEkFiyat.KategoriID = " & CntUrunAgaci1.aktifKategori.UstKategoriID & ") AND KategoriEkFiyat.MasrafKod='" & .MasrafKod & "' " &
                                                " ORDER BY KategoriEkFiyatID DESC"
                                    End If


                                    da = New SqlClient.SqlDataAdapter(cmd)
                                    dt = New DataTable
                                    da.Fill(dt)
                                    If dt.Rows.Count > 0 Then
                                        Fiyat += If0Null(dt.Rows(0).Item("Fiyat")) * .Carpan
                                        BedenArtis += If0Null(dt.Rows(0).Item("BedenArtis"))
                                        'txtSummary.Text &= .MasrafKod & "-" & .MasrafIsmi & " : " & If0Null(dt.Rows(0).Item("Fiyat"))
                                        'If .BedenFarki > 0 Then
                                        '    txtSummary.Text &= "   Beden Fark : " & If0Null(dt.Rows(0).Item("BedenArtis"))
                                        'End If
                                        'txtSummary.Text &= vbNewLine
                                        Dim newdr As DataRow = tbSipDetayEkFiyatlar.NewRow
                                        newdr("SipDetayID") = SipDetayID
                                        newdr("MasrafKod") = .MasrafKod
                                        newdr("MasrafIsmi") = .MasrafIsmi
                                        newdr("EkFiyat") = If0Null(dt.Rows(0).Item("Fiyat")) * .Carpan
                                        newdr("BedenArtis") = If0Null(dt.Rows(0).Item("BedenArtis"))
                                        tbSipDetayEkFiyatlar.Rows.Add(newdr)
                                        Uygulanmislar.Add(.MasrafKod)
                                    End If
                                End If
                            End If


                        End If
                    End With

                Next

            Next


            'ORGU TIPLERI ILE FERMUAR 
            Dim bFermuarVarMi As Boolean = False
            For Each dr As DataRow In tbSipDetayEkFiyatlar.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    If IfNull(dr("MasrafKod"), "") = "009" Then
                        bFermuarVarMi = True
                        Exit For
                    End If
                End If

            Next

            If bFermuarVarMi Then
                For Each dr As DataRow In tbSipDetayEkFiyatlar.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If IfNull(dr("MasrafKod"), "") = "005" Then
                            dr.Delete()
                            Exit For
                        End If
                    End If
                Next
            End If
            For Each dr As DataRow In tbSipDetayFiyatlar.Rows
                If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                    dr("BrutFiyat") = If0Null(dr("BazFiyat")) + Fiyat
                End If
            Next
        Catch ex As Exception
            MsgBox("(EkFiyatlariYukle) " & ex.Message)
        End Try
    End Sub

    Private Sub cmdKategoriKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKategoriKaydet.Click
        Try
            If MsgBox("Kategoriyi kaydetmek istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kaydet?") <> MsgBoxResult.Yes Then Exit Sub
            For Each ct As Control In panelOzellikler.Controls
                If TypeOf ct Is BaseControl Then
                    CType(ct, BaseControl).Save()
                End If
            Next
            tbKategori.Save()
            MsgBox("Ok")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cmdIskontoUygula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIskontoUygula.Click
        Try
            If txtIskonto.Text = "" And txtNakitIskonto.Text = "" Then Exit Sub

            For Each dr2 As DataRow In tbSipDetayFiyatlar.Rows
                If dr2.RowState <> DataRowState.Deleted And dr2.RowState <> DataRowState.Detached Then
                    If IsNumeric(txtIskonto.Text) Then
                        If CDbl(txtIskonto.Text) > 100 Then
                            dr2("Iskonto") = 100
                        Else
                            dr2("Iskonto") = CDbl(txtIskonto.Text)
                        End If
                    Else
                        If Trim(txtIskonto.Text) <> "" Then
                            dr2("Iskonto") = 0
                        End If

                    End If

                    If IsNumeric(txtNakitIskonto.Text) Then
                        If CDbl(txtNakitIskonto.Text) > 100 Then
                            dr2("NakitIskonto") = 100
                        Else
                            dr2("NakitIskonto") = CDbl(txtNakitIskonto.Text)
                        End If
                    Else
                        If Trim(txtNakitIskonto.Text) <> "" Then
                            dr2("NakitIskonto") = 0
                        End If
                    End If
                    If If0Null(dr2("Iskonto")) + If0Null(dr2("NakitIskonto")) > 100 Then
                        dr2("NakitIskonto") = 100 - If0Null(dr2("Iskonto"))
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowEkFiyat()
        Try

            Dim MasrafListesi As New ArrayList
            MasrafListesi.Add(New ClsMasraf("001", "Ã‡izgi Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("002", "Duble Lastik", False, 0))
            MasrafListesi.Add(New ClsMasraf("003", "Arma", False, 0))
            MasrafListesi.Add(New ClsMasraf("004", "Ozel Etiket", False, 0))
            MasrafListesi.Add(New ClsMasraf("005", "Orgu Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("006", "Model Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("007", "ParÃ§a Model", False, 0))
            MasrafListesi.Add(New ClsMasraf("008", "Astar", False, 0))
            MasrafListesi.Add(New ClsMasraf("009", "Fermuar", False, 0))
            MasrafListesi.Add(New ClsMasraf("010", "Omuz ReÃ§me", False, 0))
            MasrafListesi.Add(New ClsMasraf("011", "Cep Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("012", "Farkli Kumas", False, 0))
            MasrafListesi.Add(New ClsMasraf("013", "Manset Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("014", "Uzun Kol Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("015", "Kapson Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("016", "Ã‡itÃ§it Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("017", "Kapson Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("018", "On Kapak Farki", False, 0))
            MasrafListesi.Add(New ClsMasraf("S02", "Kumas Farki", False, 0))


            For i As Integer = 0 To MasrafListesi.Count - 1
                Dim bFound As Boolean = False
                For Each dr As DataRow In tbKategoriEkFiyat.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        If IfNull(dr("MasrafKod"), "") = CType(MasrafListesi.Item(i), ClsMasraf).MasrafKod Then
                            bFound = True
                            Exit For
                        End If
                    End If
                Next
                If bFound = False Then
                    If Mid(CType(MasrafListesi.Item(i), ClsMasraf).MasrafKod, 1, 1) <> "S" Then
                        Dim newdr As DataRow = tbKategoriEkFiyat.NewRow
                        newdr("MasrafKod") = CType(MasrafListesi.Item(i), ClsMasraf).MasrafKod
                        newdr("MasrafIsmi") = CType(MasrafListesi.Item(i), ClsMasraf).MasrafIsmi
                        newdr("Fiyat") = CType(MasrafListesi.Item(i), ClsMasraf).Fiyat
                        newdr("BedenArtis") = CType(MasrafListesi.Item(i), ClsMasraf).BedenFarki
                        If CntUrunAgaci1.aktifKategori.bKategori = False And CntUrunAgaci1.aktifKategori.KendiMasrafKullan = 1 Then
                            newdr("KategoriID") = CntUrunAgaci1.aktifKategori.KategoriID
                        Else
                            newdr("KategoriID") = CntUrunAgaci1.aktifKategori.UstKategoriID
                        End If

                        tbKategoriEkFiyat.Rows.Add(newdr)
                    End If
                End If

            Next


            'Dim cmd As New SqlClient.SqlCommand
            'Dim da As SqlClient.SqlDataAdapter
            'Dim dtParams As DataTable
            'cmd.Connection = AppConn.dbConn
            'cmd.CommandText = "SELECT     KategoriParam.ParamType " & _
            '    "FROM         KategoriParam INNER JOIN " & _
            '    "                      Kategoriler ON KategoriParam.KategoriID = Kategoriler.KategoriID " & _
            '    "WHERE     (Kategoriler.UstKategoriID = " & KategoriID & ") " & _
            '    "GROUP BY KategoriParam.ParamType " & _
            '    "ORDER BY KategoriParam.ParamType"
            'da = New SqlClient.SqlDataAdapter(cmd)
            'dtParams = New DataTable
            'da.Fill(dtParams)

            'For Each drParam As DataRow In dtParams.Rows
            '    Dim MasrafListesi As New ArrayList
            '    Select Case IfNull(drParam("ParamType"), "")
            '        Case "001"
            '            Dim ct As New cnt001_Kumas
            '            MasrafListesi = ct.MasrafListesi
            '        Case "002"
            '            Dim ct As New cnt002_Lastik
            '            MasrafListesi = ct.MasrafListesi
            '        Case "003"
            '            Dim ct As New cnt003_Yaka
            '            MasrafListesi = ct.MasrafListesi
            '        Case "004"
            '            Dim ct As New cnt004_DubleLastikCep
            '            MasrafListesi = ct.MasrafListesi
            '        Case "005"
            '            Dim ct As New cnt005_DubleLastikPilotYaka
            '            MasrafListesi = ct.MasrafListesi
            '        Case "006"
            '            Dim ct As New cnt006_DubleLastik
            '            MasrafListesi = ct.MasrafListesi
            '        Case "007"
            '            Dim ct As New cnt007_DubleYaka
            '            MasrafListesi = ct.MasrafListesi
            '        Case "008"
            '            Dim ct As New cnt008_TorbaliBant
            '            MasrafListesi = ct.MasrafListesi
            '        Case "009"
            '            Dim ct As New cnt009_Kumas2
            '            MasrafListesi = ct.MasrafListesi
            '        Case "051"
            '            'Dim ct As New cnt051_Tip
            '            'MasrafListesi = ct.MasrafListesi

            '        Case "052"
            '            Dim ct As New cnt052_KazakYaka
            '            MasrafListesi = ct.MasrafListesi
            '        Case "053"
            '            'Dim ct As New cnt053_DigerSecenek
            '            'MasrafListesi = ct.MasrafListesi

            '        Case "054"
            '            Dim ct As New cnt054_GarniDikis
            '            MasrafListesi = ct.MasrafListesi

            '        Case "055"
            '            Dim ct As New cnt055_Secenek
            '            MasrafListesi = ct.MasrafListesi

            '        Case "056"
            '            Dim ct As New cnt056_EkFiyat
            '            MasrafListesi = ct.MasrafListesi

            '        Case "057"
            '            Dim ct As New cnt057_EkOzellik
            '            MasrafListesi = ct.MasrafListesi

            '        Case Else

            '    End Select

            '    For i As Integer = 0 To MasrafListesi.Count - 1
            '        Dim bFound As Boolean = False
            '        For Each dr As DataRow In tbKategoriEkFiyat.Rows
            '            If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
            '                If IfNull(dr("MasrafKod"), "") = CType(MasrafListesi.Item(i), clsMasraf).MasrafKod Then
            '                    bFound = True
            '                    Exit For
            '                End If
            '            End If
            '        Next
            '        If bFound = False Then
            '            If Mid(CType(MasrafListesi.Item(i), clsMasraf).MasrafKod, 1, 1) <> "S" Then
            '                Dim newdr As DataRow = tbKategoriEkFiyat.NewRow
            '                newdr("MasrafKod") = CType(MasrafListesi.Item(i), clsMasraf).MasrafKod
            '                newdr("MasrafIsmi") = CType(MasrafListesi.Item(i), clsMasraf).MasrafIsmi
            '                newdr("Fiyat") = CType(MasrafListesi.Item(i), clsMasraf).Fiyat
            '                newdr("BedenArtis") = CType(MasrafListesi.Item(i), clsMasraf).BedenFarki
            '                newdr("KategoriID") = KategoriID
            '                tbKategoriEkFiyat.Rows.Add(newdr)
            '            End If
            '        End If

            '    Next
            'Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub tbSipDetayFiyatlar_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tbSipDetayFiyatlar.ColumnChanged
        Try
            If bNoAction = True Then Exit Sub
            bNoAction = True
            If e.Column.ColumnName = "Iskonto" Or e.Column.ColumnName = "NakitIskonto" Or e.Column.ColumnName = "BrutFiyat" Or e.Column.ColumnName = "BazFiyat" Then
                Dim Kalan As Double = If0Null(e.Row("BrutFiyat"))
                Kalan = Kalan - If0Null(e.Row("BrutFiyat")) * If0Null(e.Row("Iskonto")) / 100
                Kalan = Kalan - Kalan * If0Null(e.Row("NakitIskonto")) / 100
                e.Row("NetFiyat") = Kalan
                e.Row("Tutar") = If0Null(e.Row("NetFiyat")) * If0Null(e.Row("Miktar"))

            End If

            If e.Column.ColumnName = "Miktar" Then
                e.Row("Tutar") = If0Null(e.Row("NetFiyat")) * If0Null(e.Row("Miktar"))
            End If
            e.Row.EndEdit()
            bNoAction = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bNoAction = False
    End Sub


    Private Sub cmdGeri_AdetlerFiyatlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeri_AdetlerFiyatlar.Click
        Try
            XtraTabControl2.SelectedTabPageIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmKategoriler_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If bSaved = False Then
                Dim ret As MsgBoxResult = MsgBox("Kaydetmek istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kaydet?")
                If ret = MsgBoxResult.Cancel Then
                    e.Cancel = True
                    Exit Sub
                Else
                    If ret = MsgBoxResult.Yes Then
                        If Save() = False Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeri.Click
        Try
            XtraTabControl1.SelectedTabPageIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mnuOzellikSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOzellikSec.Click, ToolStripMenuItem5.Click, mnuOzellikSecimSayfasi.Click
        If (ApplicationMode) Then Exit Sub

        XtraTabControl1.SelectedTabPageIndex = 0

    End Sub

    Private Sub tbKategori_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tbKategori.ColumnChanged
        Try
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkGridBazBedenMi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGridBazBedenMi.CheckedChanged
        '
    End Sub

    Private Sub chkGridBazBedenMi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGridBazBedenMi.Click
        Try
            'tbKategoriFiyat
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim RowIndex As Long = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            tbKategoriFiyat.Rows(RowIndex).Item("BazBedenMi") = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XtraTabControl2_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl2.SelectedPageChanged
        Try
            If e.PrevPage.Name = XtraTabPage5.Name And e.Page.Name = XtraTabPage6.Name Then


                Dim TTutar As Double = 0, TMiktar As Double
                For Each dr As DataRow In tbSipDetayFiyatlar.Rows
                    If dr.RowState <> DataRowState.Deleted And dr.RowState <> DataRowState.Detached Then
                        TTutar += If0Null(dr("Tutar"))
                        TMiktar += If0Null(dr("Miktar"))
                    End If
                Next
                If tbSipDetay.Rows.Count > 0 Then
                    tbSipDetay.Rows(0).Item("Tutar") = TTutar
                    tbSipDetay.Rows(0).Item("Miktar") = TMiktar
                    If TMiktar <> 0 Then
                        tbSipDetay.Rows(0).Item("Fiyat") = TTutar / TMiktar
                    Else
                        tbSipDetay.Rows(0).Item("Fiyat") = 0
                    End If
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdMikroStokKod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMikroStokKod.Click
        Try
            If tbSipDetay.Rows.Count <= 0 Then Exit Sub
            Dim f As New frmMikro_StokKartlari
            With f

                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    tbSipDetay.Rows(0).Item("StokKod") = IfNull(.ReturnDataRow("sto_kod"), "")
                    tbSipDetay.Rows(0).Item("StokIsmi") = IfNull(.ReturnDataRow("sto_isim"), "")
                End If
                Load_cboRenkler()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Load_cboRenkler()
        Try
            cboRenkler.Items.Clear()

            MikroBedenArray = New ArrayList

            If tbSipDetayFiyatlar.Rows.Count <= 0 Then Exit Sub

            If Trim(IfNull(tbSipDetay.Rows(0).Item("StokKod"), "")) = "" Then
                Exit Sub
            End If

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable
            Dim dtRenk As DataTable
            Dim dtBeden As DataTable

            cmd.Connection = AppConn.dbTicari
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@sto_kod", IfNull(tbSipDetay.Rows(0).Item("StokKod"), "")))


            cmd.CommandText = "SELECT * FROM STOK_RENK_TANIMLARI WHERE 1=1 "
            da = New SqlClient.SqlDataAdapter(cmd)
            dtRenk = New DataTable
            da.Fill(dtRenk)
            If dtRenk.Rows.Count > 0 Then
                For i = 1 To 60
                    Dim Renk As String = Mid(IfNull(dtRenk.Rows(0).Item("rnk_kirilim_" & i), ""), 1, 50)
                    If Trim(Renk) = "" Then
                        Exit For
                    Else
                        cboRenkler.Items.Add(Renk)
                    End If

                Next
            End If

            cmd.CommandText = "SELECT * FROM STOK_BEDEN_TANIMLARI WHERE 1=1 "
            da = New SqlClient.SqlDataAdapter(cmd)
            dtBeden = New DataTable
            da.Fill(dtBeden)
            If dtBeden.Rows.Count > 0 Then
                For i = 1 To 40
                    Dim BedenKod As String = IfNull(dtBeden.Rows(0).Item("bdn_kirilim_" & i), "")
                    If Trim(BedenKod) = "" Then
                        Exit For
                    Else
                        MikroBedenArray.Add(BedenKod)
                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grFiyatlar_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grFiyatlar.EditorKeyDown
        Try
            If e.KeyCode = Keys.Return Then
                SendKeys.Send("{DOWN}")
                SendKeys.Send("{ENTER}")
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub tmrRapair_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRapair.Tick
        tmrRapair.Enabled = False
        cmdSaveOzellik_Click(Nothing, Nothing)

    End Sub

    Private Sub chkSerbestFiyat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSerbestFiyat.CheckedChanged

        Try
            If chkSerbestFiyat.Checked Then
                colBrutFiyat.OptionsColumn.AllowEdit = True
                colBrutFiyat.AppearanceCell.BackColor = Color.White
                colBrutFiyat.AppearanceCell.BackColor2 = Color.White
            Else
                colBrutFiyat.OptionsColumn.AllowEdit = False
                colBrutFiyat.AppearanceCell.BackColor = Color.Silver
                colBrutFiyat.AppearanceCell.BackColor2 = Color.Silver
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmKategoriler_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub BedenlerFiyatlarTurHesaplariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BedenlerFiyatlarTurHesaplariToolStripMenuItem.Click, ToolStripMenuItem6.Click, mnuBedenlerFiyatlarMasraflar.Click
        If (ApplicationMode) Then Exit Sub

        XtraTabControl1.SelectedTabPageIndex = 2

    End Sub

    Private Sub UygulamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UygulamaToolStripMenuItem.Click, ToolStripMenuItem7.Click, mnuUygulama.Click
        If (ApplicationMode) Then Exit Sub

        XtraTabControl1.SelectedTabPageIndex = 1
    End Sub

    Private Sub chkKategori_KendiFiyatBeden_CheckedChanged(sender As Object, e As EventArgs) Handles chkKategori_KendiFiyatBeden.CheckedChanged
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable

            cmd.Connection = AppConn.dbConn


            If (chkKategori_KendiFiyatBeden.Checked) Then


                GridControl1.Enabled = True
                If (CntUrunAgaci1.aktifKategori.bKategori = False) Then
                    cmd.CommandText = "SELECT COUNT(*) FROM KategoriFiyat WHERE Deleted = 0 AND KategoriID=" & CntUrunAgaci1.aktifKategori.KategoriID
                    If If0Null(cmd.ExecuteScalar()) > 0 Then
                        tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                        OpenTable(tbKategoriFiyat)
                    Else
                        tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                        OpenTable(tbKategoriFiyat)

                        cmd.CommandText = "SELECT * FROM KategoriFiyat WHERE KategoriID = " & CntUrunAgaci1.aktifKategori.UstKategoriID
                        da = New SqlClient.SqlDataAdapter(cmd)
                        dt = New DataTable
                        da.Fill(dt)
                        For Each dr As DataRow In dt.Rows
                            Dim newdr As DataRow = tbKategoriFiyat.NewRow()
                            newdr("KategoriID") = CntUrunAgaci1.aktifKategori.KategoriID
                            newdr("BedenNo") = dr("BedenNo")
                            newdr("BedenKod") = dr("BedenKod")
                            newdr("Fiyat") = dr("Fiyat")
                            newdr("BazBedenMi") = dr("BazBedenMi")
                            tbKategoriFiyat.Rows.Add(newdr)

                        Next
                    End If
                End If

            Else
                GridControl1.Enabled = False
                tbKategoriFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.UstKategoriID
                OpenTable(tbKategoriFiyat)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub chkKategori_KendiMasraf_CheckedChanged(sender As Object, e As EventArgs) Handles chkKategori_KendiMasraf.CheckedChanged
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable

            cmd.Connection = AppConn.dbConn

            If (chkKategori_KendiMasraf.Checked) Then
                grEkMasraflar.Enabled = True

                If (CntUrunAgaci1.aktifKategori.bKategori = False) Then
                    cmd.CommandText = "SELECT COUNT(*) FROM KategoriEkFiyat WHERE Deleted = 0 AND KategoriID=" & CntUrunAgaci1.aktifKategori.KategoriID
                    If If0Null(cmd.ExecuteScalar()) > 0 Then
                        tbKategoriEkFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                        OpenTable(tbKategoriEkFiyat)
                    Else
                        tbKategoriEkFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.KategoriID
                        OpenTable(tbKategoriEkFiyat)

                        cmd.CommandText = "SELECT * FROM KategoriEkFiyat WHERE KategoriID = " & CntUrunAgaci1.aktifKategori.UstKategoriID
                        da = New SqlClient.SqlDataAdapter(cmd)
                        dt = New DataTable
                        da.Fill(dt)
                        For Each dr As DataRow In dt.Rows
                            Dim newdr As DataRow = tbKategoriEkFiyat.NewRow()
                            newdr("KategoriID") = CntUrunAgaci1.aktifKategori.KategoriID
                            newdr("MasrafKod") = dr("MasrafKod")
                            newdr("MasrafIsmi") = dr("MasrafIsmi")
                            newdr("Fiyat") = dr("Fiyat")
                            newdr("BedenArtis") = dr("BedenArtis")
                            tbKategoriEkFiyat.Rows.Add(newdr)

                        Next
                    End If
                End If

            Else
                grEkMasraflar.Enabled = False
                tbKategoriEkFiyat.SelectCommand.Parameters("@KategoriID").Value = CntUrunAgaci1.aktifKategori.UstKategoriID
                OpenTable(tbKategoriEkFiyat)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub CntUrunAgaci1_SelectedChanged(Sender As Object, e As UrunAgaciChangedEventArgs) Handles CntUrunAgaci1.SelectedChanged
        Try
            If bActivated = False Then Exit Sub
            'Dim bKategori As Boolean = False
            If bRefreshing Then Exit Sub


            XtraTabPage8.PageVisible = False

            mnuOzellikSecimSayfasi.Enabled = True


            If CntUrunAgaci1.aktifKategori.bKategori = True Then
                XtraTabControl1.SelectedTabPageIndex = 4
            End If


            If ApplicationMode = True Then
                XtraTabPage1.PageVisible = False
                XtraTabPage2.PageVisible = True
                XtraTabPage3.PageVisible = False
                XtraTabPage4.PageVisible = True
                XtraTabPage8.PageVisible = False
                cmdDevam.Enabled = True
                cmdKategoriKaydet.Enabled = False
            Else
                XtraTabPage1.PageVisible = True
                XtraTabPage2.PageVisible = True
                XtraTabPage3.PageVisible = True
                XtraTabPage4.PageVisible = False
                XtraTabPage8.PageVisible = True
                cmdDevam.Enabled = False
                cmdKategoriKaydet.Enabled = True
            End If
            'mnuOzellikSecimSayfasi.Enabled = False
            'End If

            ShowAktifKategori(CntUrunAgaci1.aktifKategori.bKategori)

            LoadParams(CntUrunAgaci1.aktifKategori.bKategori)



            If ApplicationMode Then
                If CntUrunAgaci1.aktifKategori.bKategori = False Then
                    XtraTabControl1.SelectedTabPageIndex = 1
                Else
                    XtraTabControl1.SelectedTabPageIndex = 4
                End If
            Else
                If CntUrunAgaci1.aktifKategori.bKategori Then
                    chkKategori_KendiFiyatBeden.Checked = True
                    chkKategori_KendiMasraf.Checked = True
                    panelKendiFiyatBeden.Visible = False
                    panelKendiMasraf.Visible = False
                    mnuOzellikSecimSayfasi.Enabled = False
                Else
                    chkKategori_KendiFiyatBeden.Checked = False
                    chkKategori_KendiMasraf.Checked = False
                    panelKendiFiyatBeden.Visible = True
                    panelKendiMasraf.Visible = True
                    mnuOzellikSecimSayfasi.Enabled = True
                    If (CntUrunAgaci1.aktifKategori.KendiFiyatBedenKullan = 1) Then
                        chkKategori_KendiFiyatBeden.Checked = True
                    Else
                        chkKategori_KendiFiyatBeden.Checked = False
                    End If

                    If (CntUrunAgaci1.aktifKategori.KendiMasrafKullan = 1) Then
                        chkKategori_KendiMasraf.Checked = True
                    Else
                        chkKategori_KendiMasraf.Checked = False
                    End If
                End If


                FiyatlariGoster()
                ShowEkFiyat()
                If CntUrunAgaci1.aktifKategori.bKategori = False Then
                    If panelOzellikler.Controls.Count <= 0 Then
                        XtraTabControl1.SelectedTabPageIndex = 0
                    Else
                        XtraTabControl1.SelectedTabPageIndex = 1
                    End If
                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

