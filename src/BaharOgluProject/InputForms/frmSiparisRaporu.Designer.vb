<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiparisRaporu
    Inherits ProbarSiparis.frmBaseReport

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiparisRaporu))
        Dim KategoriItem1 As ProbarSiparis.kategoriItem = New ProbarSiparis.kategoriItem()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colSipDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbSiparisAlanlar = New NeoDAC.NeoTable(Me.components)
        Me.tbSiparisAlanlar_SiparisAlanID = New System.Data.DataColumn()
        Me.tbSiparisAlanlar_SipAlanIsmi = New System.Data.DataColumn()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.colSipEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnayli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnaylayan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBolumKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriIsim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerminTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteriSipNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisiAlanID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colBedenler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSiparisiAc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DurumunuDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜretimHazırlıkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetUretimde = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetOrgude = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetBoyada = New System.Windows.Forms.ToolStripMenuItem()
        Me.KesimHazirlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetKesimde = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜtüdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetDepoda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetKilis = New System.Windows.Forms.ToolStripMenuItem()
        Me.FasondaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YakaÖrgüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetBitti = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSetBos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FasonFisiniAcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSiparisYaz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.KayitBilgisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colOdemeDurumu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdenen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSiparisType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.TrackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
        Me.chkHaftaSonra = New DevExpress.XtraEditors.CheckEdit()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.colsAnaRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDurumu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToplamTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdDurumuHepsi = New DevExpress.XtraEditors.SimpleButton()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.CntUrunAgaci1 = New ProbarSiparis.cntUrunAgaci()
        Me.colKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkDurumu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslimMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasondaMi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.chkSeceneklerdeFasonOlanlar = New DevExpress.XtraEditors.CheckEdit()
        Me.colR012_LakosYaka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR012_LakosYakaCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlceIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR002_Lastik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR002_LastikCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR003_Yaka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR003_YakaCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR004_DubleLastikCep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR004_DubleLastikCepCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR005_DubleLastikPilotYaka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR005_DubleLastikPilotYakaCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR006_DubleLastik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR006_DubleLastikCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR007_DubleYaka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR007_DubleYakaCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR008_TorbaliBant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR008_TorbaliBantCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR013_Manset2cm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR013_Manset2cmCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR014_Manset6cm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR014_Manset6cmCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR018_EtekManseti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR018_EtekMansetiCizgiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaticiIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSonSevkTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSonSevkEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbUsers = New NeoDAC.NeoTable(Me.components)
        Me.tbUsers_UserID = New System.Data.DataColumn()
        Me.tbUsers_UserName = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkAdet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkKdvTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkToplamTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlkSevkTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlkSevkEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkDovizTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeFarkiOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeFarkiTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkVadeFarkiTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNakitIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskontoTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNakitIskontoTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSiparisTarihineGore = New DevExpress.XtraEditors.CheckEdit()
        Me.tbBoyahaneler = New NeoDAC.NeoTable(Me.components)
        Me.tbBoyahaneler_BoyahaneID = New System.Data.DataColumn()
        Me.tbBoyahaneler_Boyahane = New System.Data.DataColumn()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.colBoyahane = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MasterTable_SiparisID = New System.Data.DataColumn()
        Me.MasterTable_SipEvrakSeri = New System.Data.DataColumn()
        Me.MasterTable_SipEvrakSira = New System.Data.DataColumn()
        Me.MasterTable_CariKod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_Onayli = New System.Data.DataColumn()
        Me.MasterTable_Onaylayan = New System.Data.DataColumn()
        Me.MasterTable_Iptal = New System.Data.DataColumn()
        Me.MasterTable_BolumKod = New System.Data.DataColumn()
        Me.MasterTable_KategoriID = New System.Data.DataColumn()
        Me.MasterTable_KategoriKod = New System.Data.DataColumn()
        Me.MasterTable_KategoriIsim = New System.Data.DataColumn()
        Me.MasterTable_Miktar = New System.Data.DataColumn()
        Me.MasterTable_TerminTarihi = New System.Data.DataColumn()
        Me.MasterTable_MusteriSipNo = New System.Data.DataColumn()
        Me.MasterTable_Bedenler = New System.Data.DataColumn()
        Me.MasterTable_OkulKod = New System.Data.DataColumn()
        Me.MasterTable_Tarih = New System.Data.DataColumn()
        Me.MasterTable_SiparisNo = New System.Data.DataColumn()
        Me.MasterTable_SipDetayID = New System.Data.DataColumn()
        Me.MasterTable_OdemeDurumu = New System.Data.DataColumn()
        Me.MasterTable_Odenen = New System.Data.DataColumn()
        Me.MasterTable_sSiparisType = New System.Data.DataColumn()
        Me.MasterTable_AnaRenk = New System.Data.DataColumn()
        Me.MasterTable_Durumu = New System.Data.DataColumn()
        Me.MasterTable_BoyahaneID = New System.Data.DataColumn()
        Me.MasterTable_SiparisAlanID = New System.Data.DataColumn()
        Me.MasterTable_Iskonto = New System.Data.DataColumn()
        Me.MasterTable_NakitIskonto = New System.Data.DataColumn()
        Me.MasterTable_IskontoTutar = New System.Data.DataColumn()
        Me.MasterTable_NakitIskontoTutar = New System.Data.DataColumn()
        Me.MasterTable_Fiyat = New System.Data.DataColumn()
        Me.MasterTable_Tutar = New System.Data.DataColumn()
        Me.MasterTable_VadeFarkiOran = New System.Data.DataColumn()
        Me.MasterTable_VadeFarkiTutar = New System.Data.DataColumn()
        Me.MasterTable_KdvOran = New System.Data.DataColumn()
        Me.MasterTable_KdvTutari = New System.Data.DataColumn()
        Me.MasterTable_ToplamTutar = New System.Data.DataColumn()
        Me.MasterTable_DovizTipi = New System.Data.DataColumn()
        Me.MasterTable_DovizTutar = New System.Data.DataColumn()
        Me.MasterTable_DovizKuru = New System.Data.DataColumn()
        Me.MasterTable_TeslimMiktar = New System.Data.DataColumn()
        Me.MasterTable_Kalan = New System.Data.DataColumn()
        Me.MasterTable_SevkDurumu = New System.Data.DataColumn()
        Me.MasterTable_IlkSevkTarihi = New System.Data.DataColumn()
        Me.MasterTable_IlkSevkEvrakNo = New System.Data.DataColumn()
        Me.MasterTable_SonSevkTarihi = New System.Data.DataColumn()
        Me.MasterTable_SonSevkEvrakNo = New System.Data.DataColumn()
        Me.MasterTable_SevkAdet = New System.Data.DataColumn()
        Me.MasterTable_SevkTutar = New System.Data.DataColumn()
        Me.MasterTable_SevkVadeFarkiTutar = New System.Data.DataColumn()
        Me.MasterTable_SevkKdvTutar = New System.Data.DataColumn()
        Me.MasterTable_SevkToplamTutar = New System.Data.DataColumn()
        Me.MasterTable_SevkDovizTutar = New System.Data.DataColumn()
        Me.MasterTable_FasondaMi = New System.Data.DataColumn()
        Me.MasterTable_OkulIsmi = New System.Data.DataColumn()
        Me.MasterTable_IlceID = New System.Data.DataColumn()
        Me.MasterTable_IlID = New System.Data.DataColumn()
        Me.MasterTable_IlIsmi = New System.Data.DataColumn()
        Me.MasterTable_IlceIsmi = New System.Data.DataColumn()
        Me.MasterTable_R002_Lastik = New System.Data.DataColumn()
        Me.MasterTable_R002_LastikCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R003_Yaka = New System.Data.DataColumn()
        Me.MasterTable_R003_YakaCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R004_DubleLastikCep = New System.Data.DataColumn()
        Me.MasterTable_R004_DubleLastikCepCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R005_DubleLastikPilotYaka = New System.Data.DataColumn()
        Me.MasterTable_R005_DubleLastikPilotYakaCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R006_DubleLastik = New System.Data.DataColumn()
        Me.MasterTable_R006_DubleLastikCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R007_DubleYaka = New System.Data.DataColumn()
        Me.MasterTable_R007_DubleYakaCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R008_TorbaliBant = New System.Data.DataColumn()
        Me.MasterTable_R008_TorbaliBantCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R012_LakosYaka = New System.Data.DataColumn()
        Me.MasterTable_R012_LakosYakaCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R013_Manset2cm = New System.Data.DataColumn()
        Me.MasterTable_R013_Manset2cmCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R014_Manset6cm = New System.Data.DataColumn()
        Me.MasterTable_R014_Manset6cmCizgiler = New System.Data.DataColumn()
        Me.MasterTable_R018_EtekManseti = New System.Data.DataColumn()
        Me.MasterTable_R018_EtekMansetiCizgiler = New System.Data.DataColumn()
        Me.MasterTable_SaticiIsmi = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.BaseTab1.SuspendLayout()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormDateFilter.SuspendLayout()
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSiparisAlanlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHaftaSonra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLeft.SuspendLayout()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeceneklerdeFasonOlanlar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSiparisTarihineGore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBoyahaneler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1190, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1190, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 439)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(1190, 67)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 439)
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.MasterTable
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(257, 0)
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit5})
        Me.GridControl1.Size = New System.Drawing.Size(927, 230)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSipDetayID, Me.colSiparisID, Me.colSipEvrakSeri, Me.colSipEvrakSira, Me.colsSiparisType, Me.colCariKod, Me.colCariUnvan, Me.colDurumu, Me.colBoyahane, Me.colOnayli, Me.colOnaylayan, Me.colIptal, Me.colBolumKod, Me.colKategoriID, Me.colKategoriKod, Me.colKategoriIsim, Me.colsAnaRenk, Me.colMiktar, Me.colTerminTarihi, Me.colMusteriSipNo, Me.colSiparisiAlanID, Me.colBedenler, Me.colIlceID, Me.colIlID, Me.colOkulIsmi, Me.colOkulKod, Me.colTarih, Me.colSiparisNo, Me.colOdemeDurumu, Me.colOdenen, Me.colIskontoTutar, Me.colNakitIskontoTutar, Me.colIskonto, Me.colNakitIskonto, Me.colFiyat, Me.colKdvOran, Me.colKdvTutari, Me.colTutar, Me.colVadeFarkiOran, Me.colVadeFarkiTutar, Me.colToplamTutar, Me.colDovizTipi, Me.colDovizKuru, Me.colDovizTutar, Me.colTeslimMiktar, Me.colKalan, Me.colSevkDurumu, Me.colIlkSevkTarihi, Me.colIlkSevkEvrakNo, Me.colSonSevkTarihi, Me.colSonSevkEvrakNo, Me.colSevkAdet, Me.colSevkTutar, Me.colSevkVadeFarkiTutar, Me.colSevkKdvTutar, Me.colSevkToplamTutar, Me.colSevkDovizTutar, Me.colFasondaMi, Me.colIlceIsmi, Me.colIlIsmi, Me.colR012_LakosYaka, Me.colR012_LakosYakaCizgiler, Me.colR002_Lastik, Me.colR002_LastikCizgiler, Me.colR003_Yaka, Me.colR003_YakaCizgiler, Me.colR004_DubleLastikCep, Me.colR004_DubleLastikCepCizgiler, Me.colR005_DubleLastikPilotYaka, Me.colR005_DubleLastikPilotYakaCizgiler, Me.colR006_DubleLastik, Me.colR006_DubleLastikCizgiler, Me.colR007_DubleYaka, Me.colR007_DubleYakaCizgiler, Me.colR008_TorbaliBant, Me.colR008_TorbaliBantCizgiler, Me.colR013_Manset2cm, Me.colR013_Manset2cmCizgiler, Me.colR014_Manset6cm, Me.colR014_Manset6cmCizgiler, Me.colR018_EtekManseti, Me.colR018_EtekMansetiCizgiler, Me.colSaticiIsmi, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Text
        Me.GridView1.OptionsLayout.LayoutVersion = "1.9"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'BarManager1
        '
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem1})
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1})
        '
        'Bar2
        '
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        '
        'panelFormTop
        '
        Me.panelFormTop.Location = New System.Drawing.Point(0, 171)
        Me.panelFormTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelFormTop.Size = New System.Drawing.Size(1190, 36)
        '
        'btnRefresh
        '
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 207)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1190, 258)
        '
        'BaseTab1
        '
        Me.BaseTab1.Controls.Add(Me.SplitterControl1)
        Me.BaseTab1.Controls.Add(Me.panelLeft)
        Me.BaseTab1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseTab1.Size = New System.Drawing.Size(1184, 230)
        Me.BaseTab1.Controls.SetChildIndex(Me.panelLeft, 0)
        Me.BaseTab1.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.BaseTab1.Controls.SetChildIndex(Me.GridControl1, 0)
        '
        'btnFirst
        '
        Me.btnFirst.Glyph = CType(resources.GetObject("btnFirst.Glyph"), System.Drawing.Image)
        '
        'btnPrior
        '
        Me.btnPrior.Glyph = CType(resources.GetObject("btnPrior.Glyph"), System.Drawing.Image)
        '
        'btnNext
        '
        Me.btnNext.Glyph = CType(resources.GetObject("btnNext.Glyph"), System.Drawing.Image)
        '
        'btnLast
        '
        Me.btnLast.Glyph = CType(resources.GetObject("btnLast.Glyph"), System.Drawing.Image)
        '
        'btnPrintGrid
        '
        Me.btnPrintGrid.Glyph = CType(resources.GetObject("btnPrintGrid.Glyph"), System.Drawing.Image)
        '
        'btnExport
        '
        Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
        '
        'btnHelp
        '
        Me.btnHelp.Glyph = CType(resources.GetObject("btnHelp.Glyph"), System.Drawing.Image)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_SiparisID, Me.MasterTable_SipEvrakSeri, Me.MasterTable_SipEvrakSira, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_Onayli, Me.MasterTable_Onaylayan, Me.MasterTable_Iptal, Me.MasterTable_BolumKod, Me.MasterTable_KategoriID, Me.MasterTable_KategoriKod, Me.MasterTable_KategoriIsim, Me.MasterTable_Miktar, Me.MasterTable_TerminTarihi, Me.MasterTable_MusteriSipNo, Me.MasterTable_Bedenler, Me.MasterTable_OkulKod, Me.MasterTable_Tarih, Me.MasterTable_SiparisNo, Me.MasterTable_SipDetayID, Me.MasterTable_OdemeDurumu, Me.MasterTable_Odenen, Me.MasterTable_sSiparisType, Me.MasterTable_AnaRenk, Me.MasterTable_Durumu, Me.MasterTable_BoyahaneID, Me.MasterTable_SiparisAlanID, Me.MasterTable_Iskonto, Me.MasterTable_NakitIskonto, Me.MasterTable_IskontoTutar, Me.MasterTable_NakitIskontoTutar, Me.MasterTable_Fiyat, Me.MasterTable_Tutar, Me.MasterTable_VadeFarkiOran, Me.MasterTable_VadeFarkiTutar, Me.MasterTable_KdvOran, Me.MasterTable_KdvTutari, Me.MasterTable_ToplamTutar, Me.MasterTable_DovizTipi, Me.MasterTable_DovizTutar, Me.MasterTable_DovizKuru, Me.MasterTable_TeslimMiktar, Me.MasterTable_Kalan, Me.MasterTable_SevkDurumu, Me.MasterTable_IlkSevkTarihi, Me.MasterTable_IlkSevkEvrakNo, Me.MasterTable_SonSevkTarihi, Me.MasterTable_SonSevkEvrakNo, Me.MasterTable_SevkAdet, Me.MasterTable_SevkTutar, Me.MasterTable_SevkVadeFarkiTutar, Me.MasterTable_SevkKdvTutar, Me.MasterTable_SevkToplamTutar, Me.MasterTable_SevkDovizTutar, Me.MasterTable_FasondaMi, Me.MasterTable_OkulIsmi, Me.MasterTable_IlceID, Me.MasterTable_IlID, Me.MasterTable_IlIsmi, Me.MasterTable_IlceIsmi, Me.MasterTable_R002_Lastik, Me.MasterTable_R002_LastikCizgiler, Me.MasterTable_R003_Yaka, Me.MasterTable_R003_YakaCizgiler, Me.MasterTable_R004_DubleLastikCep, Me.MasterTable_R004_DubleLastikCepCizgiler, Me.MasterTable_R005_DubleLastikPilotYaka, Me.MasterTable_R005_DubleLastikPilotYakaCizgiler, Me.MasterTable_R006_DubleLastik, Me.MasterTable_R006_DubleLastikCizgiler, Me.MasterTable_R007_DubleYaka, Me.MasterTable_R007_DubleYakaCizgiler, Me.MasterTable_R008_TorbaliBant, Me.MasterTable_R008_TorbaliBantCizgiler, Me.MasterTable_R012_LakosYaka, Me.MasterTable_R012_LakosYakaCizgiler, Me.MasterTable_R013_Manset2cm, Me.MasterTable_R013_Manset2cmCizgiler, Me.MasterTable_R014_Manset6cm, Me.MasterTable_R014_Manset6cmCizgiler, Me.MasterTable_R018_EtekManseti, Me.MasterTable_R018_EtekMansetiCizgiler, Me.MasterTable_SaticiIsmi, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate})
        Me.MasterTable.Connection = Me.FirmConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SiparisID", "SipDetayID"}, True)})
        Me.MasterTable.DataSourceLink = Me.MasterLink
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_SiparisID, Me.MasterTable_SipDetayID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'panelBottom
        '
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelBottom.Size = New System.Drawing.Size(1190, 41)
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(992, 2)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'btnFormPrint
        '
        Me.btnFormPrint.Glyph = CType(resources.GetObject("btnFormPrint.Glyph"), System.Drawing.Image)
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Controls.Add(Me.chkSiparisTarihineGore)
        Me.panelFormDateFilter.Controls.Add(Me.chkSeceneklerdeFasonOlanlar)
        Me.panelFormDateFilter.Controls.Add(Me.GroupControl1)
        Me.panelFormDateFilter.Controls.Add(Me.chkHaftaSonra)
        Me.panelFormDateFilter.Controls.Add(Me.TrackBarControl1)
        Me.panelFormDateFilter.Location = New System.Drawing.Point(0, 67)
        Me.panelFormDateFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelFormDateFilter.Size = New System.Drawing.Size(1190, 104)
        Me.panelFormDateFilter.Visible = True
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.TrackBarControl1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkHaftaSonra, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.cmdRefreshList, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkSeceneklerdeFasonOlanlar, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkSiparisTarihineGore, 0)
        '
        'cmdRefreshList
        '
        Me.cmdRefreshList.Image = CType(resources.GetObject("cmdRefreshList.Image"), System.Drawing.Image)
        Me.cmdRefreshList.Location = New System.Drawing.Point(917, 5)
        Me.cmdRefreshList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        '
        'chkDate2
        '
        Me.chkDate2.EditValue = True
        Me.chkDate2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDate2.Properties.Appearance.Options.UseTextOptions = True
        Me.chkDate2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkDate2.Properties.Caption = "Bitis Tarihi"
        '
        'dtFormDate2
        '
        Me.dtFormDate2.EditValue = Nothing
        Me.dtFormDate2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'chkDate1
        '
        Me.chkDate1.EditValue = True
        Me.chkDate1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDate1.Properties.Appearance.Options.UseTextOptions = True
        Me.chkDate1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkDate1.Properties.Caption = "Baslangic Tarihi"
        '
        'dtFormDate1
        '
        Me.dtFormDate1.EditValue = Nothing
        Me.dtFormDate1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        'barItem_RowCount
        '
        Me.barItem_RowCount.Caption = "0"
        '
        'btnLanguageOptions
        '
        Me.btnLanguageOptions.Glyph = CType(resources.GetObject("btnLanguageOptions.Glyph"), System.Drawing.Image)
        '
        'TicariConn
        '
        Me.TicariConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=MikroDB_V16_BAHAR2020;Integrated Secu" &
    "rity=True;"
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        '
        'colSipDetayID
        '
        Me.colSipDetayID.Caption = "#Takip No"
        Me.colSipDetayID.FieldName = "SipDetayID"
        Me.colSipDetayID.Name = "colSipDetayID"
        Me.colSipDetayID.Visible = True
        Me.colSipDetayID.VisibleIndex = 0
        Me.colSipDetayID.Width = 70
        '
        'colSiparisID
        '
        Me.colSiparisID.FieldName = "SiparisID"
        Me.colSiparisID.Name = "colSiparisID"
        '
        'colSipEvrakSeri
        '
        Me.colSipEvrakSeri.Caption = "Siparisi Alan"
        Me.colSipEvrakSeri.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colSipEvrakSeri.FieldName = "SiparisiAlanID"
        Me.colSipEvrakSeri.Name = "colSipEvrakSeri"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SiparisAlanID", "Siparis Alan ID", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SiparisAlan", "Siparis Alan", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.tbSiparisAlanlar
        Me.RepositoryItemLookUpEdit4.DisplayMember = "SiparisAlan"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "SiparisAlanID"
        '
        'tbSiparisAlanlar
        '
        Me.tbSiparisAlanlar.Columns.AddRange(New System.Data.DataColumn() {Me.tbSiparisAlanlar_SiparisAlanID, Me.tbSiparisAlanlar_SipAlanIsmi})
        Me.tbSiparisAlanlar.Connection = Me.FirmConn
        Me.tbSiparisAlanlar.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SiparisAlanID"}, True)})
        Me.tbSiparisAlanlar.CurrentRow = Nothing
        Me.tbSiparisAlanlar.DataSourceLink = Nothing
        Me.tbSiparisAlanlar.DeleteCommand = Me.SqlCommand8
        Me.tbSiparisAlanlar.Filter = ""
        Me.tbSiparisAlanlar.InsertCommand = Me.SqlCommand6
        Me.tbSiparisAlanlar.LiveSave = False
        Me.tbSiparisAlanlar.MaxRecords = CType(0, Long)
        Me.tbSiparisAlanlar.Name = "tbSiparisAlanlar"
        Me.tbSiparisAlanlar.ParentRelation_ChildColumns = Nothing
        Me.tbSiparisAlanlar.ParentRelation_ParentColumns = Nothing
        Me.tbSiparisAlanlar.ParentRelation_Table = Nothing
        Me.tbSiparisAlanlar.Position = CType(-1, Long)
        Me.tbSiparisAlanlar.PrimaryKey = New System.Data.DataColumn() {Me.tbSiparisAlanlar_SiparisAlanID}
        Me.tbSiparisAlanlar.Quoted = False
        Me.tbSiparisAlanlar.SelectCommand = Me.SqlCommand5
        Me.tbSiparisAlanlar.TableName = "NeoTable1"
        Me.tbSiparisAlanlar.Transaction = Nothing
        Me.tbSiparisAlanlar.UpdateCommand = Me.SqlCommand7
        '
        'tbSiparisAlanlar_SiparisAlanID
        '
        Me.tbSiparisAlanlar_SiparisAlanID.AllowDBNull = False
        Me.tbSiparisAlanlar_SiparisAlanID.AutoIncrement = True
        Me.tbSiparisAlanlar_SiparisAlanID.ColumnName = "SiparisAlanID"
        Me.tbSiparisAlanlar_SiparisAlanID.DataType = GetType(Integer)
        '
        'tbSiparisAlanlar_SipAlanIsmi
        '
        Me.tbSiparisAlanlar_SipAlanIsmi.ColumnName = "SipAlanIsmi"
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT SiparisAlanID, SipAlanIsmi FROM SiparisAlanlar WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'colSipEvrakSira
        '
        Me.colSipEvrakSira.FieldName = "SipEvrakSira"
        Me.colSipEvrakSira.Name = "colSipEvrakSira"
        Me.colSipEvrakSira.Width = 99
        '
        'colCariKod
        '
        Me.colCariKod.FieldName = "CariKod"
        Me.colCariKod.Name = "colCariKod"
        Me.colCariKod.Visible = True
        Me.colCariKod.VisibleIndex = 11
        '
        'colCariUnvan
        '
        Me.colCariUnvan.FieldName = "CariUnvan"
        Me.colCariUnvan.Name = "colCariUnvan"
        Me.colCariUnvan.Visible = True
        Me.colCariUnvan.VisibleIndex = 12
        Me.colCariUnvan.Width = 113
        '
        'colOnayli
        '
        Me.colOnayli.FieldName = "Onayli"
        Me.colOnayli.Name = "colOnayli"
        Me.colOnayli.Visible = True
        Me.colOnayli.VisibleIndex = 45
        '
        'colOnaylayan
        '
        Me.colOnaylayan.FieldName = "Onaylayan"
        Me.colOnaylayan.Name = "colOnaylayan"
        '
        'colIptal
        '
        Me.colIptal.FieldName = "Iptal"
        Me.colIptal.Name = "colIptal"
        Me.colIptal.Visible = True
        Me.colIptal.VisibleIndex = 46
        '
        'colBolumKod
        '
        Me.colBolumKod.FieldName = "BolumKod"
        Me.colBolumKod.Name = "colBolumKod"
        Me.colBolumKod.Visible = True
        Me.colBolumKod.VisibleIndex = 15
        '
        'colKategoriID
        '
        Me.colKategoriID.FieldName = "KategoriID"
        Me.colKategoriID.Name = "colKategoriID"
        '
        'colKategoriKod
        '
        Me.colKategoriKod.Caption = "Ürün Kod"
        Me.colKategoriKod.FieldName = "KategoriKod"
        Me.colKategoriKod.Name = "colKategoriKod"
        Me.colKategoriKod.Visible = True
        Me.colKategoriKod.VisibleIndex = 8
        '
        'colKategoriIsim
        '
        Me.colKategoriIsim.Caption = "Ürün İsmi"
        Me.colKategoriIsim.FieldName = "KategoriIsim"
        Me.colKategoriIsim.Name = "colKategoriIsim"
        Me.colKategoriIsim.Visible = True
        Me.colKategoriIsim.VisibleIndex = 9
        Me.colKategoriIsim.Width = 179
        '
        'colMiktar
        '
        Me.colMiktar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.colMiktar.AppearanceCell.Options.UseFont = True
        Me.colMiktar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.colMiktar.AppearanceHeader.Options.UseFont = True
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 19
        Me.colMiktar.Width = 95
        '
        'colTerminTarihi
        '
        Me.colTerminTarihi.FieldName = "TerminTarihi"
        Me.colTerminTarihi.Name = "colTerminTarihi"
        Me.colTerminTarihi.Visible = True
        Me.colTerminTarihi.VisibleIndex = 7
        Me.colTerminTarihi.Width = 104
        '
        'colMusteriSipNo
        '
        Me.colMusteriSipNo.FieldName = "MusteriSipNo"
        Me.colMusteriSipNo.Name = "colMusteriSipNo"
        Me.colMusteriSipNo.Width = 98
        '
        'colSiparisiAlanID
        '
        Me.colSiparisiAlanID.Caption = "Şiparişi Alan"
        Me.colSiparisiAlanID.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colSiparisiAlanID.FieldName = "SiparisAlanID"
        Me.colSiparisiAlanID.Name = "colSiparisiAlanID"
        Me.colSiparisiAlanID.Visible = True
        Me.colSiparisiAlanID.VisibleIndex = 47
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SipAlanIsmi", "Sip Alan Ismi", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SiparisAlanID", "Siparis Alan ID", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.tbSiparisAlanlar
        Me.RepositoryItemLookUpEdit5.DisplayMember = "SipAlanIsmi"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ValueMember = "SiparisAlanID"
        '
        'colBedenler
        '
        Me.colBedenler.FieldName = "Bedenler"
        Me.colBedenler.Name = "colBedenler"
        Me.colBedenler.Visible = True
        Me.colBedenler.VisibleIndex = 16
        Me.colBedenler.Width = 180
        '
        'colIlceID
        '
        Me.colIlceID.FieldName = "IlceID"
        Me.colIlceID.Name = "colIlceID"
        '
        'colIlID
        '
        Me.colIlID.FieldName = "IlID"
        Me.colIlID.Name = "colIlID"
        '
        'colOkulIsmi
        '
        Me.colOkulIsmi.FieldName = "OkulIsmi"
        Me.colOkulIsmi.Name = "colOkulIsmi"
        Me.colOkulIsmi.Visible = True
        Me.colOkulIsmi.VisibleIndex = 14
        Me.colOkulIsmi.Width = 129
        '
        'colOkulKod
        '
        Me.colOkulKod.FieldName = "OkulKod"
        Me.colOkulKod.Name = "colOkulKod"
        '
        'colTarih
        '
        Me.colTarih.FieldName = "Tarih"
        Me.colTarih.Name = "colTarih"
        Me.colTarih.Visible = True
        Me.colTarih.VisibleIndex = 6
        Me.colTarih.Width = 98
        '
        'colSiparisNo
        '
        Me.colSiparisNo.FieldName = "SiparisNo"
        Me.colSiparisNo.Name = "colSiparisNo"
        Me.colSiparisNo.Visible = True
        Me.colSiparisNo.VisibleIndex = 1
        Me.colSiparisNo.Width = 87
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSiparisiAc, Me.ToolStripMenuItem1, Me.DurumunuDeğiştirToolStripMenuItem, Me.ToolStripMenuItem4, Me.FasonFisiniAcToolStripMenuItem, Me.ToolStripMenuItem3, Me.mnuSiparisYaz, Me.ToolStripMenuItem5, Me.KayitBilgisiToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 158)
        '
        'mnuSiparisiAc
        '
        Me.mnuSiparisiAc.Name = "mnuSiparisiAc"
        Me.mnuSiparisiAc.Size = New System.Drawing.Size(179, 26)
        Me.mnuSiparisiAc.Text = "Sipariş Fişini Aç"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
        '
        'DurumunuDeğiştirToolStripMenuItem
        '
        Me.DurumunuDeğiştirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜretimHazırlıkToolStripMenuItem, Me.mnuSetUretimde, Me.mnuSetOrgude, Me.mnuSetBoyada, Me.KesimHazirlikToolStripMenuItem, Me.mnuSetKesimde, Me.ÜtüdeToolStripMenuItem, Me.mnuSetDepoda, Me.mnuSetKilis, Me.FasondaToolStripMenuItem, Me.YakaÖrgüToolStripMenuItem, Me.mnuSetBitti, Me.ToolStripMenuItem2, Me.mnuSetBos})
        Me.DurumunuDeğiştirToolStripMenuItem.Name = "DurumunuDeğiştirToolStripMenuItem"
        Me.DurumunuDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.DurumunuDeğiştirToolStripMenuItem.Text = "Durumunu Değiştir"
        '
        'ÜretimHazırlıkToolStripMenuItem
        '
        Me.ÜretimHazırlıkToolStripMenuItem.Name = "ÜretimHazırlıkToolStripMenuItem"
        Me.ÜretimHazırlıkToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ÜretimHazırlıkToolStripMenuItem.Text = "Hazırlık"
        '
        'mnuSetUretimde
        '
        Me.mnuSetUretimde.Name = "mnuSetUretimde"
        Me.mnuSetUretimde.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetUretimde.Text = "Üretimde"
        '
        'mnuSetOrgude
        '
        Me.mnuSetOrgude.Name = "mnuSetOrgude"
        Me.mnuSetOrgude.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetOrgude.Text = "Örgüde"
        '
        'mnuSetBoyada
        '
        Me.mnuSetBoyada.Name = "mnuSetBoyada"
        Me.mnuSetBoyada.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetBoyada.Text = "Boyada"
        '
        'KesimHazirlikToolStripMenuItem
        '
        Me.KesimHazirlikToolStripMenuItem.Name = "KesimHazirlikToolStripMenuItem"
        Me.KesimHazirlikToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.KesimHazirlikToolStripMenuItem.Text = "Kesim Hazirlik"
        '
        'mnuSetKesimde
        '
        Me.mnuSetKesimde.Name = "mnuSetKesimde"
        Me.mnuSetKesimde.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetKesimde.Text = "Kesimde"
        '
        'ÜtüdeToolStripMenuItem
        '
        Me.ÜtüdeToolStripMenuItem.Name = "ÜtüdeToolStripMenuItem"
        Me.ÜtüdeToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ÜtüdeToolStripMenuItem.Text = "Ütüde"
        '
        'mnuSetDepoda
        '
        Me.mnuSetDepoda.Name = "mnuSetDepoda"
        Me.mnuSetDepoda.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetDepoda.Text = "Depoda"
        '
        'mnuSetKilis
        '
        Me.mnuSetKilis.Name = "mnuSetKilis"
        Me.mnuSetKilis.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetKilis.Text = "Kilis'te"
        '
        'FasondaToolStripMenuItem
        '
        Me.FasondaToolStripMenuItem.Name = "FasondaToolStripMenuItem"
        Me.FasondaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FasondaToolStripMenuItem.Text = "Fasonda"
        '
        'YakaÖrgüToolStripMenuItem
        '
        Me.YakaÖrgüToolStripMenuItem.Name = "YakaÖrgüToolStripMenuItem"
        Me.YakaÖrgüToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.YakaÖrgüToolStripMenuItem.Text = "Yaka Örgü"
        '
        'mnuSetBitti
        '
        Me.mnuSetBitti.Name = "mnuSetBitti"
        Me.mnuSetBitti.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetBitti.Text = "Bitti"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(145, 6)
        '
        'mnuSetBos
        '
        Me.mnuSetBos.Name = "mnuSetBos"
        Me.mnuSetBos.Size = New System.Drawing.Size(148, 22)
        Me.mnuSetBos.Text = "Boş"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(176, 6)
        '
        'FasonFisiniAcToolStripMenuItem
        '
        Me.FasonFisiniAcToolStripMenuItem.Name = "FasonFisiniAcToolStripMenuItem"
        Me.FasonFisiniAcToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.FasonFisiniAcToolStripMenuItem.Text = "Fason fisini ac"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 6)
        '
        'mnuSiparisYaz
        '
        Me.mnuSiparisYaz.Image = Global.ProbarSiparis.My.Resources.Resources.print_16
        Me.mnuSiparisYaz.Name = "mnuSiparisYaz"
        Me.mnuSiparisYaz.Size = New System.Drawing.Size(179, 26)
        Me.mnuSiparisYaz.Text = "Yazdır"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(176, 6)
        '
        'KayitBilgisiToolStripMenuItem
        '
        Me.KayitBilgisiToolStripMenuItem.Image = Global.ProbarSiparis.My.Resources.Resources.user_16
        Me.KayitBilgisiToolStripMenuItem.Name = "KayitBilgisiToolStripMenuItem"
        Me.KayitBilgisiToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.KayitBilgisiToolStripMenuItem.Text = "Kayit bilgisi"
        '
        'colOdemeDurumu
        '
        Me.colOdemeDurumu.FieldName = "OdemeDurumu"
        Me.colOdemeDurumu.Name = "colOdemeDurumu"
        Me.colOdemeDurumu.Visible = True
        Me.colOdemeDurumu.VisibleIndex = 13
        Me.colOdemeDurumu.Width = 135
        '
        'colOdenen
        '
        Me.colOdenen.FieldName = "Odenen"
        Me.colOdenen.Name = "colOdenen"
        Me.colOdenen.Width = 96
        '
        'colsSiparisType
        '
        Me.colsSiparisType.Caption = "Türü"
        Me.colsSiparisType.FieldName = "sSiparisType"
        Me.colsSiparisType.Name = "colsSiparisType"
        Me.colsSiparisType.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sSiparisType", "Sayi: {0}")})
        Me.colsSiparisType.Visible = True
        Me.colsSiparisType.VisibleIndex = 2
        Me.colsSiparisType.Width = 106
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(252, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 230)
        Me.SplitterControl1.TabIndex = 4
        Me.SplitterControl1.TabStop = False
        '
        'TrackBarControl1
        '
        Me.TrackBarControl1.EditValue = Nothing
        Me.TrackBarControl1.Enabled = False
        Me.TrackBarControl1.Location = New System.Drawing.Point(162, 64)
        Me.TrackBarControl1.MenuManager = Me.BarManager1
        Me.TrackBarControl1.Name = "TrackBarControl1"
        Me.TrackBarControl1.Properties.AutoSize = False
        Me.TrackBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.TrackBarControl1.Properties.Maximum = 20
        Me.TrackBarControl1.Size = New System.Drawing.Size(280, 30)
        Me.TrackBarControl1.TabIndex = 12
        '
        'chkHaftaSonra
        '
        Me.chkHaftaSonra.EnterMoveNextControl = True
        Me.chkHaftaSonra.Location = New System.Drawing.Point(10, 64)
        Me.chkHaftaSonra.MenuManager = Me.BarManager1
        Me.chkHaftaSonra.Name = "chkHaftaSonra"
        Me.chkHaftaSonra.Properties.Appearance.Options.UseTextOptions = True
        Me.chkHaftaSonra.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkHaftaSonra.Properties.AutoHeight = False
        Me.chkHaftaSonra.Properties.Caption = "Bu Hafta - ? Hafta Sonra"
        Me.chkHaftaSonra.Size = New System.Drawing.Size(147, 32)
        Me.chkHaftaSonra.TabIndex = 13
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemProgressBar1
        Me.BarEditItem1.Id = 20
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 207
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.Step = 1
        '
        'colsAnaRenk
        '
        Me.colsAnaRenk.Caption = "Ana Renk"
        Me.colsAnaRenk.FieldName = "AnaRenk"
        Me.colsAnaRenk.Name = "colsAnaRenk"
        Me.colsAnaRenk.Visible = True
        Me.colsAnaRenk.VisibleIndex = 10
        Me.colsAnaRenk.Width = 143
        '
        'colDurumu
        '
        Me.colDurumu.FieldName = "Durumu"
        Me.colDurumu.Name = "colDurumu"
        Me.colDurumu.Visible = True
        Me.colDurumu.VisibleIndex = 3
        Me.colDurumu.Width = 103
        '
        'colFiyat
        '
        Me.colFiyat.DisplayFormat.FormatString = "#,##0.00"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 20
        '
        'colKdvOran
        '
        Me.colKdvOran.FieldName = "KdvOran"
        Me.colKdvOran.Name = "colKdvOran"
        Me.colKdvOran.Visible = True
        Me.colKdvOran.VisibleIndex = 21
        '
        'colKdvTutari
        '
        Me.colKdvTutari.Caption = "TL Kdv Tutar"
        Me.colKdvTutari.DisplayFormat.FormatString = "#,##0.00"
        Me.colKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvTutari.FieldName = "KdvTutari"
        Me.colKdvTutari.Name = "colKdvTutari"
        Me.colKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutari", "{0:#,##0.00}")})
        Me.colKdvTutari.Visible = True
        Me.colKdvTutari.VisibleIndex = 22
        '
        'colTutar
        '
        Me.colTutar.Caption = "TL Sip. Toplam"
        Me.colTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:#,##0.00}")})
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 23
        '
        'colToplamTutar
        '
        Me.colToplamTutar.Caption = "TL KDV'li Sip. Toplam"
        Me.colToplamTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamTutar.FieldName = "ToplamTutar"
        Me.colToplamTutar.Name = "colToplamTutar"
        Me.colToplamTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamTutar", "{0:#,##0.00}")})
        Me.colToplamTutar.Visible = True
        Me.colToplamTutar.VisibleIndex = 26
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckedListBoxControl1)
        Me.GroupControl1.Controls.Add(Me.Panel1)
        Me.GroupControl1.Location = New System.Drawing.Point(448, 4)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(454, 96)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Durumu"
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.CheckedListBoxControl1.Appearance.Options.UseBackColor = True
        Me.CheckedListBoxControl1.CheckOnClick = True
        Me.CheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("HAZIRLIK", "Hazırlık"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("URETIMDE", "Üretimde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("ORGUDE", "Örgüde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("BOYADA", "Boyada"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("KESIM-HAZIRLIK", "Kesim Hazirlik"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("KESIMDE", "Kesimde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("UTUDE", "Ütüde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("DEPODA", "Depoda"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("KILIS", "Kilis' te"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("FASONDA", "Fasonda"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("YAKA-ORGU", "Yaka Örgü"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("BITTI", "Bitti"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("", "{Boş}")})
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(2, 20)
        Me.CheckedListBoxControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckedListBoxControl1.MultiColumn = True
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(387, 74)
        Me.CheckedListBoxControl1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdDurumuHepsi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(389, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(63, 74)
        Me.Panel1.TabIndex = 1
        '
        'cmdDurumuHepsi
        '
        Me.cmdDurumuHepsi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdDurumuHepsi.Location = New System.Drawing.Point(0, 45)
        Me.cmdDurumuHepsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdDurumuHepsi.Name = "cmdDurumuHepsi"
        Me.cmdDurumuHepsi.Size = New System.Drawing.Size(63, 29)
        Me.cmdDurumuHepsi.TabIndex = 0
        Me.cmdDurumuHepsi.Text = "Hepsi"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Nothing
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 252
        Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar
        Me.NavBarControl1.Size = New System.Drawing.Size(252, 230)
        Me.NavBarControl1.TabIndex = 4
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
        '
        'panelLeft
        '
        Me.panelLeft.Controls.Add(Me.CntUrunAgaci1)
        Me.panelLeft.Controls.Add(Me.NavBarControl1)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(252, 230)
        Me.panelLeft.TabIndex = 5
        '
        'CntUrunAgaci1
        '
        Me.CntUrunAgaci1.aktifKategori = KategoriItem1
        Me.CntUrunAgaci1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CntUrunAgaci1.Editable = False
        Me.CntUrunAgaci1.Location = New System.Drawing.Point(0, 0)
        Me.CntUrunAgaci1.Name = "CntUrunAgaci1"
        Me.CntUrunAgaci1.Size = New System.Drawing.Size(252, 230)
        Me.CntUrunAgaci1.TabIndex = 5
        '
        'colKalan
        '
        Me.colKalan.FieldName = "Kalan"
        Me.colKalan.Name = "colKalan"
        Me.colKalan.Visible = True
        Me.colKalan.VisibleIndex = 33
        Me.colKalan.Width = 108
        '
        'colSevkDurumu
        '
        Me.colSevkDurumu.FieldName = "SevkDurumu"
        Me.colSevkDurumu.Name = "colSevkDurumu"
        Me.colSevkDurumu.Visible = True
        Me.colSevkDurumu.VisibleIndex = 34
        Me.colSevkDurumu.Width = 103
        '
        'colTeslimMiktar
        '
        Me.colTeslimMiktar.FieldName = "TeslimMiktar"
        Me.colTeslimMiktar.Name = "colTeslimMiktar"
        Me.colTeslimMiktar.Visible = True
        Me.colTeslimMiktar.VisibleIndex = 32
        Me.colTeslimMiktar.Width = 100
        '
        'colFasondaMi
        '
        Me.colFasondaMi.Caption = "Fasonda Mi?"
        Me.colFasondaMi.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colFasondaMi.FieldName = "FasondaMi"
        Me.colFasondaMi.Name = "colFasondaMi"
        Me.colFasondaMi.Visible = True
        Me.colFasondaMi.VisibleIndex = 5
        Me.colFasondaMi.Width = 89
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'chkSeceneklerdeFasonOlanlar
        '
        Me.chkSeceneklerdeFasonOlanlar.Location = New System.Drawing.Point(917, 75)
        Me.chkSeceneklerdeFasonOlanlar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSeceneklerdeFasonOlanlar.MenuManager = Me.BarManager1
        Me.chkSeceneklerdeFasonOlanlar.Name = "chkSeceneklerdeFasonOlanlar"
        Me.chkSeceneklerdeFasonOlanlar.Properties.Caption = "Seceneklerde Fason olanlar"
        Me.chkSeceneklerdeFasonOlanlar.Size = New System.Drawing.Size(200, 19)
        Me.chkSeceneklerdeFasonOlanlar.TabIndex = 15
        '
        'colR012_LakosYaka
        '
        Me.colR012_LakosYaka.FieldName = "R012_LakosYaka"
        Me.colR012_LakosYaka.Name = "colR012_LakosYaka"
        Me.colR012_LakosYaka.Visible = True
        Me.colR012_LakosYaka.VisibleIndex = 50
        '
        'colR012_LakosYakaCizgiler
        '
        Me.colR012_LakosYakaCizgiler.FieldName = "R012_LakosYakaCizgiler"
        Me.colR012_LakosYakaCizgiler.Name = "colR012_LakosYakaCizgiler"
        Me.colR012_LakosYakaCizgiler.Visible = True
        Me.colR012_LakosYakaCizgiler.VisibleIndex = 51
        '
        'colIlceIsmi
        '
        Me.colIlceIsmi.Caption = "Ilce"
        Me.colIlceIsmi.FieldName = "IlceIsmi"
        Me.colIlceIsmi.Name = "colIlceIsmi"
        Me.colIlceIsmi.Visible = True
        Me.colIlceIsmi.VisibleIndex = 48
        '
        'colIlIsmi
        '
        Me.colIlIsmi.Caption = "Il"
        Me.colIlIsmi.FieldName = "IlIsmi"
        Me.colIlIsmi.Name = "colIlIsmi"
        Me.colIlIsmi.Visible = True
        Me.colIlIsmi.VisibleIndex = 49
        '
        'colR002_Lastik
        '
        Me.colR002_Lastik.FieldName = "R002_Lastik"
        Me.colR002_Lastik.Name = "colR002_Lastik"
        '
        'colR002_LastikCizgiler
        '
        Me.colR002_LastikCizgiler.FieldName = "R002_LastikCizgiler"
        Me.colR002_LastikCizgiler.Name = "colR002_LastikCizgiler"
        '
        'colR003_Yaka
        '
        Me.colR003_Yaka.FieldName = "R003_Yaka"
        Me.colR003_Yaka.Name = "colR003_Yaka"
        '
        'colR003_YakaCizgiler
        '
        Me.colR003_YakaCizgiler.FieldName = "R003_YakaCizgiler"
        Me.colR003_YakaCizgiler.Name = "colR003_YakaCizgiler"
        '
        'colR004_DubleLastikCep
        '
        Me.colR004_DubleLastikCep.FieldName = "R004_DubleLastikCep"
        Me.colR004_DubleLastikCep.Name = "colR004_DubleLastikCep"
        '
        'colR004_DubleLastikCepCizgiler
        '
        Me.colR004_DubleLastikCepCizgiler.FieldName = "R004_DubleLastikCepCizgiler"
        Me.colR004_DubleLastikCepCizgiler.Name = "colR004_DubleLastikCepCizgiler"
        '
        'colR005_DubleLastikPilotYaka
        '
        Me.colR005_DubleLastikPilotYaka.FieldName = "R005_DubleLastikPilotYaka"
        Me.colR005_DubleLastikPilotYaka.Name = "colR005_DubleLastikPilotYaka"
        '
        'colR005_DubleLastikPilotYakaCizgiler
        '
        Me.colR005_DubleLastikPilotYakaCizgiler.FieldName = "R005_DubleLastikPilotYakaCizgiler"
        Me.colR005_DubleLastikPilotYakaCizgiler.Name = "colR005_DubleLastikPilotYakaCizgiler"
        '
        'colR006_DubleLastik
        '
        Me.colR006_DubleLastik.FieldName = "R006_DubleLastik"
        Me.colR006_DubleLastik.Name = "colR006_DubleLastik"
        '
        'colR006_DubleLastikCizgiler
        '
        Me.colR006_DubleLastikCizgiler.FieldName = "R006_DubleLastikCizgiler"
        Me.colR006_DubleLastikCizgiler.Name = "colR006_DubleLastikCizgiler"
        '
        'colR007_DubleYaka
        '
        Me.colR007_DubleYaka.FieldName = "R007_DubleYaka"
        Me.colR007_DubleYaka.Name = "colR007_DubleYaka"
        '
        'colR007_DubleYakaCizgiler
        '
        Me.colR007_DubleYakaCizgiler.FieldName = "R007_DubleYakaCizgiler"
        Me.colR007_DubleYakaCizgiler.Name = "colR007_DubleYakaCizgiler"
        '
        'colR008_TorbaliBant
        '
        Me.colR008_TorbaliBant.FieldName = "R008_TorbaliBant"
        Me.colR008_TorbaliBant.Name = "colR008_TorbaliBant"
        '
        'colR008_TorbaliBantCizgiler
        '
        Me.colR008_TorbaliBantCizgiler.FieldName = "R008_TorbaliBantCizgiler"
        Me.colR008_TorbaliBantCizgiler.Name = "colR008_TorbaliBantCizgiler"
        '
        'colR013_Manset2cm
        '
        Me.colR013_Manset2cm.FieldName = "R013_Manset2cm"
        Me.colR013_Manset2cm.Name = "colR013_Manset2cm"
        '
        'colR013_Manset2cmCizgiler
        '
        Me.colR013_Manset2cmCizgiler.FieldName = "R013_Manset2cmCizgiler"
        Me.colR013_Manset2cmCizgiler.Name = "colR013_Manset2cmCizgiler"
        '
        'colR014_Manset6cm
        '
        Me.colR014_Manset6cm.FieldName = "R014_Manset6cm"
        Me.colR014_Manset6cm.Name = "colR014_Manset6cm"
        '
        'colR014_Manset6cmCizgiler
        '
        Me.colR014_Manset6cmCizgiler.FieldName = "R014_Manset6cmCizgiler"
        Me.colR014_Manset6cmCizgiler.Name = "colR014_Manset6cmCizgiler"
        '
        'colR018_EtekManseti
        '
        Me.colR018_EtekManseti.FieldName = "R018_EtekManseti"
        Me.colR018_EtekManseti.Name = "colR018_EtekManseti"
        '
        'colR018_EtekMansetiCizgiler
        '
        Me.colR018_EtekMansetiCizgiler.FieldName = "R018_EtekMansetiCizgiler"
        Me.colR018_EtekMansetiCizgiler.Name = "colR018_EtekMansetiCizgiler"
        '
        'colSaticiIsmi
        '
        Me.colSaticiIsmi.FieldName = "SaticiIsmi"
        Me.colSaticiIsmi.Name = "colSaticiIsmi"
        Me.colSaticiIsmi.Visible = True
        Me.colSaticiIsmi.VisibleIndex = 52
        '
        'colSonSevkTarihi
        '
        Me.colSonSevkTarihi.Caption = "Son Sevk Tarihi"
        Me.colSonSevkTarihi.FieldName = "SonSevkTarihi"
        Me.colSonSevkTarihi.Name = "colSonSevkTarihi"
        Me.colSonSevkTarihi.Visible = True
        Me.colSonSevkTarihi.VisibleIndex = 37
        Me.colSonSevkTarihi.Width = 96
        '
        'colSonSevkEvrakNo
        '
        Me.colSonSevkEvrakNo.Caption = "Son Sevk Evrak no"
        Me.colSonSevkEvrakNo.FieldName = "SonSevkEvrakNo"
        Me.colSonSevkEvrakNo.Name = "colSonSevkEvrakNo"
        Me.colSonSevkEvrakNo.Visible = True
        Me.colSonSevkEvrakNo.VisibleIndex = 38
        Me.colSonSevkEvrakNo.Width = 120
        '
        'colDovizKuru
        '
        Me.colDovizKuru.FieldName = "DovizKuru"
        Me.colDovizKuru.Name = "colDovizKuru"
        Me.colDovizKuru.Visible = True
        Me.colDovizKuru.VisibleIndex = 28
        '
        'colDovizTipi
        '
        Me.colDovizTipi.FieldName = "DovizTipi"
        Me.colDovizTipi.Name = "colDovizTipi"
        Me.colDovizTipi.Visible = True
        Me.colDovizTipi.VisibleIndex = 27
        '
        'tbUsers
        '
        Me.tbUsers.Columns.AddRange(New System.Data.DataColumn() {Me.tbUsers_UserID, Me.tbUsers_UserName})
        Me.tbUsers.Connection = Me.FirmConn
        Me.tbUsers.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"UserID"}, True)})
        Me.tbUsers.CurrentRow = Nothing
        Me.tbUsers.DataSourceLink = Nothing
        Me.tbUsers.DeleteCommand = Me.SqlCommand12
        Me.tbUsers.Filter = ""
        Me.tbUsers.InsertCommand = Me.SqlCommand10
        Me.tbUsers.LiveSave = False
        Me.tbUsers.MaxRecords = CType(0, Long)
        Me.tbUsers.Name = "tbUsers"
        Me.tbUsers.ParentRelation_ChildColumns = Nothing
        Me.tbUsers.ParentRelation_ParentColumns = Nothing
        Me.tbUsers.ParentRelation_Table = Nothing
        Me.tbUsers.Position = CType(-1, Long)
        Me.tbUsers.PrimaryKey = New System.Data.DataColumn() {Me.tbUsers_UserID}
        Me.tbUsers.Quoted = False
        Me.tbUsers.SelectCommand = Me.SqlCommand9
        Me.tbUsers.TableName = "NeoTable1"
        Me.tbUsers.Transaction = Nothing
        Me.tbUsers.UpdateCommand = Me.SqlCommand11
        '
        'tbUsers_UserID
        '
        Me.tbUsers_UserID.AllowDBNull = False
        Me.tbUsers_UserID.AutoIncrement = True
        Me.tbUsers_UserID.ColumnName = "UserID"
        Me.tbUsers_UserID.DataType = GetType(Integer)
        '
        'tbUsers_UserName
        '
        Me.tbUsers_UserName.ColumnName = "UserName"
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT UserID, UserName FROM Users WHERE Deleted=0"
        '
        'colCreatedBy
        '
        Me.colCreatedBy.Caption = "Oluşturan"
        Me.colCreatedBy.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "User ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.tbUsers
        Me.RepositoryItemLookUpEdit1.DisplayMember = "UserName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "UserID"
        '
        'colCreatedDate
        '
        Me.colCreatedDate.Caption = "Oluşturma Zamanı"
        Me.colCreatedDate.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss"
        Me.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.Caption = "Son Değiştiren"
        Me.colModifiedBy.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 53
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "User ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.tbUsers
        Me.RepositoryItemLookUpEdit2.DisplayMember = "UserName"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "UserID"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.Caption = "Değiştirme Zamanı"
        Me.colModifiedDate.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss"
        Me.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Visible = True
        Me.colModifiedDate.VisibleIndex = 54
        '
        'colSevkAdet
        '
        Me.colSevkAdet.Caption = "Sevk Adet"
        Me.colSevkAdet.DisplayFormat.FormatString = "#,##0"
        Me.colSevkAdet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSevkAdet.FieldName = "SevkAdet"
        Me.colSevkAdet.Name = "colSevkAdet"
        Me.colSevkAdet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SevkAdet", "{0:#,##0}")})
        Me.colSevkAdet.Visible = True
        Me.colSevkAdet.VisibleIndex = 39
        '
        'colSevkTutar
        '
        Me.colSevkTutar.Caption = "TL Sevk Toplam"
        Me.colSevkTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colSevkTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSevkTutar.FieldName = "SevkTutar"
        Me.colSevkTutar.Name = "colSevkTutar"
        Me.colSevkTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SevkTutar", "{0:#,##0.00}")})
        Me.colSevkTutar.Visible = True
        Me.colSevkTutar.VisibleIndex = 40
        '
        'colSevkKdvTutar
        '
        Me.colSevkKdvTutar.Caption = "TL Sevk KdvTutar"
        Me.colSevkKdvTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colSevkKdvTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSevkKdvTutar.FieldName = "SevkKdvTutar"
        Me.colSevkKdvTutar.Name = "colSevkKdvTutar"
        Me.colSevkKdvTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SevkKdvTutar", "{0:#,##0.00}")})
        Me.colSevkKdvTutar.Visible = True
        Me.colSevkKdvTutar.VisibleIndex = 42
        Me.colSevkKdvTutar.Width = 91
        '
        'colSevkToplamTutar
        '
        Me.colSevkToplamTutar.Caption = "TL KDV' li Sevk Tutar"
        Me.colSevkToplamTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colSevkToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSevkToplamTutar.FieldName = "SevkToplamTutar"
        Me.colSevkToplamTutar.Name = "colSevkToplamTutar"
        Me.colSevkToplamTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SevkToplamTutar", "{0:#,##0.00}")})
        Me.colSevkToplamTutar.Visible = True
        Me.colSevkToplamTutar.VisibleIndex = 43
        Me.colSevkToplamTutar.Width = 108
        '
        'colIlkSevkTarihi
        '
        Me.colIlkSevkTarihi.Caption = "Ilk Sevk Tarihi"
        Me.colIlkSevkTarihi.FieldName = "IlkSevkTarihi"
        Me.colIlkSevkTarihi.Name = "colIlkSevkTarihi"
        Me.colIlkSevkTarihi.Visible = True
        Me.colIlkSevkTarihi.VisibleIndex = 35
        '
        'colIlkSevkEvrakNo
        '
        Me.colIlkSevkEvrakNo.Caption = "Ilk Sevk Evrak No"
        Me.colIlkSevkEvrakNo.FieldName = "IlkSevkEvrakNo"
        Me.colIlkSevkEvrakNo.Name = "colIlkSevkEvrakNo"
        Me.colIlkSevkEvrakNo.Visible = True
        Me.colIlkSevkEvrakNo.VisibleIndex = 36
        Me.colIlkSevkEvrakNo.Width = 107
        '
        'colDovizTutar
        '
        Me.colDovizTutar.Caption = "Dovizli Sip. Tutar"
        Me.colDovizTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDovizTutar.FieldName = "DovizTutar"
        Me.colDovizTutar.Name = "colDovizTutar"
        Me.colDovizTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DovizTutar", "{0:#,##0.00}")})
        Me.colDovizTutar.Visible = True
        Me.colDovizTutar.VisibleIndex = 29
        Me.colDovizTutar.Width = 101
        '
        'colSevkDovizTutar
        '
        Me.colSevkDovizTutar.Caption = "Dovizli Sevk Tutar"
        Me.colSevkDovizTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colSevkDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSevkDovizTutar.FieldName = "SevkDovizTutar"
        Me.colSevkDovizTutar.Name = "colSevkDovizTutar"
        Me.colSevkDovizTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SevkDovizTutar", "{0:#,##0.00}")})
        Me.colSevkDovizTutar.Visible = True
        Me.colSevkDovizTutar.VisibleIndex = 44
        Me.colSevkDovizTutar.Width = 127
        '
        'colVadeFarkiOran
        '
        Me.colVadeFarkiOran.Caption = "Vade Fark%"
        Me.colVadeFarkiOran.FieldName = "VadeFarkiOran"
        Me.colVadeFarkiOran.Name = "colVadeFarkiOran"
        Me.colVadeFarkiOran.Visible = True
        Me.colVadeFarkiOran.VisibleIndex = 24
        '
        'colVadeFarkiTutar
        '
        Me.colVadeFarkiTutar.Caption = "TL Sip. Vade Farki"
        Me.colVadeFarkiTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colVadeFarkiTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVadeFarkiTutar.FieldName = "VadeFarkiTutar"
        Me.colVadeFarkiTutar.Name = "colVadeFarkiTutar"
        Me.colVadeFarkiTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VadeFarkiTutar", "{0:#,##0.00}")})
        Me.colVadeFarkiTutar.Visible = True
        Me.colVadeFarkiTutar.VisibleIndex = 25
        '
        'colSevkVadeFarkiTutar
        '
        Me.colSevkVadeFarkiTutar.Caption = "TL Sevk Vade Farki"
        Me.colSevkVadeFarkiTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colSevkVadeFarkiTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSevkVadeFarkiTutar.FieldName = "SevkVadeFarkiTutar"
        Me.colSevkVadeFarkiTutar.Name = "colSevkVadeFarkiTutar"
        Me.colSevkVadeFarkiTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SevkVadeFarkiTutar", "{0:#,##0.00}")})
        Me.colSevkVadeFarkiTutar.Visible = True
        Me.colSevkVadeFarkiTutar.VisibleIndex = 41
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Sezon Isk%"
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.Visible = True
        Me.colIskonto.VisibleIndex = 17
        '
        'colNakitIskonto
        '
        Me.colNakitIskonto.Caption = "Nakit Isk %"
        Me.colNakitIskonto.FieldName = "NakitIskonto"
        Me.colNakitIskonto.Name = "colNakitIskonto"
        Me.colNakitIskonto.Visible = True
        Me.colNakitIskonto.VisibleIndex = 18
        '
        'colIskontoTutar
        '
        Me.colIskontoTutar.Caption = "Sezon Isk. Tutar"
        Me.colIskontoTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colIskontoTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIskontoTutar.FieldName = "IskontoTutar"
        Me.colIskontoTutar.Name = "colIskontoTutar"
        Me.colIskontoTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IskontoTutar", "{0:#,##0.00}")})
        Me.colIskontoTutar.Visible = True
        Me.colIskontoTutar.VisibleIndex = 30
        '
        'colNakitIskontoTutar
        '
        Me.colNakitIskontoTutar.Caption = "Nakit Isk. Tutar"
        Me.colNakitIskontoTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colNakitIskontoTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNakitIskontoTutar.FieldName = "NakitIskontoTutar"
        Me.colNakitIskontoTutar.Name = "colNakitIskontoTutar"
        Me.colNakitIskontoTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NakitIskontoTutar", "{0:#,##0.00}")})
        Me.colNakitIskontoTutar.Visible = True
        Me.colNakitIskontoTutar.VisibleIndex = 31
        '
        'chkSiparisTarihineGore
        '
        Me.chkSiparisTarihineGore.Location = New System.Drawing.Point(917, 55)
        Me.chkSiparisTarihineGore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSiparisTarihineGore.MenuManager = Me.BarManager1
        Me.chkSiparisTarihineGore.Name = "chkSiparisTarihineGore"
        Me.chkSiparisTarihineGore.Properties.Caption = "Siparis Tarihine Gore Listele"
        Me.chkSiparisTarihineGore.Size = New System.Drawing.Size(200, 19)
        Me.chkSiparisTarihineGore.TabIndex = 16
        '
        'tbBoyahaneler
        '
        Me.tbBoyahaneler.Columns.AddRange(New System.Data.DataColumn() {Me.tbBoyahaneler_BoyahaneID, Me.tbBoyahaneler_Boyahane})
        Me.tbBoyahaneler.Connection = Me.FirmConn
        Me.tbBoyahaneler.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"BoyahaneID"}, True)})
        Me.tbBoyahaneler.CurrentRow = Nothing
        Me.tbBoyahaneler.DataSourceLink = Nothing
        Me.tbBoyahaneler.DeleteCommand = Me.SqlCommand16
        Me.tbBoyahaneler.Filter = ""
        Me.tbBoyahaneler.InsertCommand = Me.SqlCommand14
        Me.tbBoyahaneler.LiveSave = False
        Me.tbBoyahaneler.MaxRecords = CType(0, Long)
        Me.tbBoyahaneler.Name = "tbBoyahaneler"
        Me.tbBoyahaneler.ParentRelation_ChildColumns = Nothing
        Me.tbBoyahaneler.ParentRelation_ParentColumns = Nothing
        Me.tbBoyahaneler.ParentRelation_Table = Nothing
        Me.tbBoyahaneler.Position = CType(-1, Long)
        Me.tbBoyahaneler.PrimaryKey = New System.Data.DataColumn() {Me.tbBoyahaneler_BoyahaneID}
        Me.tbBoyahaneler.Quoted = False
        Me.tbBoyahaneler.SelectCommand = Me.SqlCommand13
        Me.tbBoyahaneler.TableName = "NeoTable1"
        Me.tbBoyahaneler.Transaction = Nothing
        Me.tbBoyahaneler.UpdateCommand = Me.SqlCommand15
        '
        'tbBoyahaneler_BoyahaneID
        '
        Me.tbBoyahaneler_BoyahaneID.AllowDBNull = False
        Me.tbBoyahaneler_BoyahaneID.AutoIncrement = True
        Me.tbBoyahaneler_BoyahaneID.ColumnName = "BoyahaneID"
        Me.tbBoyahaneler_BoyahaneID.DataType = GetType(Integer)
        '
        'tbBoyahaneler_Boyahane
        '
        Me.tbBoyahaneler_Boyahane.ColumnName = "Boyahane"
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT BoyahaneID, Boyahane FROM Boyahaneler WHERE Deleted=0"
        '
        'colBoyahane
        '
        Me.colBoyahane.Caption = "Boyahane"
        Me.colBoyahane.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colBoyahane.FieldName = "BoyahaneID"
        Me.colBoyahane.Name = "colBoyahane"
        Me.colBoyahane.Visible = True
        Me.colBoyahane.VisibleIndex = 4
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Boyahane", "Boyahane", 58, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BoyahaneID", "Boyahane ID", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.tbBoyahaneler
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Boyahane"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ValueMember = "BoyahaneID"
        '
        'MasterTable_SiparisID
        '
        Me.MasterTable_SiparisID.AllowDBNull = False
        Me.MasterTable_SiparisID.AutoIncrement = True
        Me.MasterTable_SiparisID.ColumnName = "SiparisID"
        Me.MasterTable_SiparisID.DataType = GetType(Integer)
        '
        'MasterTable_SipEvrakSeri
        '
        Me.MasterTable_SipEvrakSeri.ColumnName = "SipEvrakSeri"
        '
        'MasterTable_SipEvrakSira
        '
        Me.MasterTable_SipEvrakSira.ColumnName = "SipEvrakSira"
        Me.MasterTable_SipEvrakSira.DataType = GetType(Integer)
        '
        'MasterTable_CariKod
        '
        Me.MasterTable_CariKod.ColumnName = "CariKod"
        '
        'MasterTable_CariUnvan
        '
        Me.MasterTable_CariUnvan.ColumnName = "CariUnvan"
        '
        'MasterTable_Onayli
        '
        Me.MasterTable_Onayli.ColumnName = "Onayli"
        Me.MasterTable_Onayli.DataType = GetType(Integer)
        '
        'MasterTable_Onaylayan
        '
        Me.MasterTable_Onaylayan.ColumnName = "Onaylayan"
        Me.MasterTable_Onaylayan.DataType = GetType(Integer)
        '
        'MasterTable_Iptal
        '
        Me.MasterTable_Iptal.ColumnName = "Iptal"
        Me.MasterTable_Iptal.DataType = GetType(Integer)
        '
        'MasterTable_BolumKod
        '
        Me.MasterTable_BolumKod.ColumnName = "BolumKod"
        '
        'MasterTable_KategoriID
        '
        Me.MasterTable_KategoriID.ColumnName = "KategoriID"
        Me.MasterTable_KategoriID.DataType = GetType(Integer)
        '
        'MasterTable_KategoriKod
        '
        Me.MasterTable_KategoriKod.ColumnName = "KategoriKod"
        '
        'MasterTable_KategoriIsim
        '
        Me.MasterTable_KategoriIsim.ColumnName = "KategoriIsim"
        '
        'MasterTable_Miktar
        '
        Me.MasterTable_Miktar.ColumnName = "Miktar"
        Me.MasterTable_Miktar.DataType = GetType(Double)
        '
        'MasterTable_TerminTarihi
        '
        Me.MasterTable_TerminTarihi.ColumnName = "TerminTarihi"
        Me.MasterTable_TerminTarihi.DataType = GetType(Date)
        '
        'MasterTable_MusteriSipNo
        '
        Me.MasterTable_MusteriSipNo.ColumnName = "MusteriSipNo"
        '
        'MasterTable_Bedenler
        '
        Me.MasterTable_Bedenler.ColumnName = "Bedenler"
        '
        'MasterTable_OkulKod
        '
        Me.MasterTable_OkulKod.ColumnName = "OkulKod"
        '
        'MasterTable_Tarih
        '
        Me.MasterTable_Tarih.ColumnName = "Tarih"
        Me.MasterTable_Tarih.DataType = GetType(Date)
        '
        'MasterTable_SiparisNo
        '
        Me.MasterTable_SiparisNo.ColumnName = "SiparisNo"
        '
        'MasterTable_SipDetayID
        '
        Me.MasterTable_SipDetayID.AllowDBNull = False
        Me.MasterTable_SipDetayID.AutoIncrement = True
        Me.MasterTable_SipDetayID.ColumnName = "SipDetayID"
        Me.MasterTable_SipDetayID.DataType = GetType(Integer)
        '
        'MasterTable_OdemeDurumu
        '
        Me.MasterTable_OdemeDurumu.ColumnName = "OdemeDurumu"
        '
        'MasterTable_Odenen
        '
        Me.MasterTable_Odenen.ColumnName = "Odenen"
        Me.MasterTable_Odenen.DataType = GetType(Double)
        '
        'MasterTable_sSiparisType
        '
        Me.MasterTable_sSiparisType.ColumnName = "sSiparisType"
        '
        'MasterTable_AnaRenk
        '
        Me.MasterTable_AnaRenk.ColumnName = "AnaRenk"
        '
        'MasterTable_Durumu
        '
        Me.MasterTable_Durumu.ColumnName = "Durumu"
        '
        'MasterTable_BoyahaneID
        '
        Me.MasterTable_BoyahaneID.ColumnName = "BoyahaneID"
        Me.MasterTable_BoyahaneID.DataType = GetType(Integer)
        '
        'MasterTable_SiparisAlanID
        '
        Me.MasterTable_SiparisAlanID.ColumnName = "SiparisAlanID"
        Me.MasterTable_SiparisAlanID.DataType = GetType(Integer)
        '
        'MasterTable_Iskonto
        '
        Me.MasterTable_Iskonto.ColumnName = "Iskonto"
        Me.MasterTable_Iskonto.DataType = GetType(Double)
        '
        'MasterTable_NakitIskonto
        '
        Me.MasterTable_NakitIskonto.ColumnName = "NakitIskonto"
        Me.MasterTable_NakitIskonto.DataType = GetType(Double)
        '
        'MasterTable_IskontoTutar
        '
        Me.MasterTable_IskontoTutar.ColumnName = "IskontoTutar"
        Me.MasterTable_IskontoTutar.DataType = GetType(Double)
        '
        'MasterTable_NakitIskontoTutar
        '
        Me.MasterTable_NakitIskontoTutar.ColumnName = "NakitIskontoTutar"
        Me.MasterTable_NakitIskontoTutar.DataType = GetType(Double)
        '
        'MasterTable_Fiyat
        '
        Me.MasterTable_Fiyat.ColumnName = "Fiyat"
        Me.MasterTable_Fiyat.DataType = GetType(Double)
        '
        'MasterTable_Tutar
        '
        Me.MasterTable_Tutar.ColumnName = "Tutar"
        Me.MasterTable_Tutar.DataType = GetType(Double)
        '
        'MasterTable_VadeFarkiOran
        '
        Me.MasterTable_VadeFarkiOran.ColumnName = "VadeFarkiOran"
        Me.MasterTable_VadeFarkiOran.DataType = GetType(Double)
        '
        'MasterTable_VadeFarkiTutar
        '
        Me.MasterTable_VadeFarkiTutar.ColumnName = "VadeFarkiTutar"
        Me.MasterTable_VadeFarkiTutar.DataType = GetType(Double)
        '
        'MasterTable_KdvOran
        '
        Me.MasterTable_KdvOran.ColumnName = "KdvOran"
        Me.MasterTable_KdvOran.DataType = GetType(Double)
        '
        'MasterTable_KdvTutari
        '
        Me.MasterTable_KdvTutari.ColumnName = "KdvTutari"
        Me.MasterTable_KdvTutari.DataType = GetType(Double)
        '
        'MasterTable_ToplamTutar
        '
        Me.MasterTable_ToplamTutar.ColumnName = "ToplamTutar"
        Me.MasterTable_ToplamTutar.DataType = GetType(Double)
        '
        'MasterTable_DovizTipi
        '
        Me.MasterTable_DovizTipi.ColumnName = "DovizTipi"
        '
        'MasterTable_DovizTutar
        '
        Me.MasterTable_DovizTutar.ColumnName = "DovizTutar"
        Me.MasterTable_DovizTutar.DataType = GetType(Double)
        '
        'MasterTable_DovizKuru
        '
        Me.MasterTable_DovizKuru.ColumnName = "DovizKuru"
        Me.MasterTable_DovizKuru.DataType = GetType(Double)
        '
        'MasterTable_TeslimMiktar
        '
        Me.MasterTable_TeslimMiktar.ColumnName = "TeslimMiktar"
        Me.MasterTable_TeslimMiktar.DataType = GetType(Double)
        '
        'MasterTable_Kalan
        '
        Me.MasterTable_Kalan.ColumnName = "Kalan"
        Me.MasterTable_Kalan.DataType = GetType(Double)
        '
        'MasterTable_SevkDurumu
        '
        Me.MasterTable_SevkDurumu.ColumnName = "SevkDurumu"
        '
        'MasterTable_IlkSevkTarihi
        '
        Me.MasterTable_IlkSevkTarihi.ColumnName = "IlkSevkTarihi"
        Me.MasterTable_IlkSevkTarihi.DataType = GetType(Date)
        '
        'MasterTable_IlkSevkEvrakNo
        '
        Me.MasterTable_IlkSevkEvrakNo.ColumnName = "IlkSevkEvrakNo"
        '
        'MasterTable_SonSevkTarihi
        '
        Me.MasterTable_SonSevkTarihi.ColumnName = "SonSevkTarihi"
        Me.MasterTable_SonSevkTarihi.DataType = GetType(Date)
        '
        'MasterTable_SonSevkEvrakNo
        '
        Me.MasterTable_SonSevkEvrakNo.ColumnName = "SonSevkEvrakNo"
        '
        'MasterTable_SevkAdet
        '
        Me.MasterTable_SevkAdet.ColumnName = "SevkAdet"
        Me.MasterTable_SevkAdet.DataType = GetType(Double)
        '
        'MasterTable_SevkTutar
        '
        Me.MasterTable_SevkTutar.ColumnName = "SevkTutar"
        Me.MasterTable_SevkTutar.DataType = GetType(Double)
        '
        'MasterTable_SevkVadeFarkiTutar
        '
        Me.MasterTable_SevkVadeFarkiTutar.ColumnName = "SevkVadeFarkiTutar"
        Me.MasterTable_SevkVadeFarkiTutar.DataType = GetType(Double)
        '
        'MasterTable_SevkKdvTutar
        '
        Me.MasterTable_SevkKdvTutar.ColumnName = "SevkKdvTutar"
        Me.MasterTable_SevkKdvTutar.DataType = GetType(Double)
        '
        'MasterTable_SevkToplamTutar
        '
        Me.MasterTable_SevkToplamTutar.ColumnName = "SevkToplamTutar"
        Me.MasterTable_SevkToplamTutar.DataType = GetType(Double)
        '
        'MasterTable_SevkDovizTutar
        '
        Me.MasterTable_SevkDovizTutar.ColumnName = "SevkDovizTutar"
        Me.MasterTable_SevkDovizTutar.DataType = GetType(Double)
        '
        'MasterTable_FasondaMi
        '
        Me.MasterTable_FasondaMi.ColumnName = "FasondaMi"
        Me.MasterTable_FasondaMi.DataType = GetType(Integer)
        '
        'MasterTable_OkulIsmi
        '
        Me.MasterTable_OkulIsmi.ColumnName = "OkulIsmi"
        '
        'MasterTable_IlceID
        '
        Me.MasterTable_IlceID.ColumnName = "IlceID"
        Me.MasterTable_IlceID.DataType = GetType(Integer)
        '
        'MasterTable_IlID
        '
        Me.MasterTable_IlID.ColumnName = "IlID"
        Me.MasterTable_IlID.DataType = GetType(Integer)
        '
        'MasterTable_IlIsmi
        '
        Me.MasterTable_IlIsmi.ColumnName = "IlIsmi"
        '
        'MasterTable_IlceIsmi
        '
        Me.MasterTable_IlceIsmi.ColumnName = "IlceIsmi"
        '
        'MasterTable_R002_Lastik
        '
        Me.MasterTable_R002_Lastik.ColumnName = "R002_Lastik"
        '
        'MasterTable_R002_LastikCizgiler
        '
        Me.MasterTable_R002_LastikCizgiler.ColumnName = "R002_LastikCizgiler"
        '
        'MasterTable_R003_Yaka
        '
        Me.MasterTable_R003_Yaka.ColumnName = "R003_Yaka"
        '
        'MasterTable_R003_YakaCizgiler
        '
        Me.MasterTable_R003_YakaCizgiler.ColumnName = "R003_YakaCizgiler"
        '
        'MasterTable_R004_DubleLastikCep
        '
        Me.MasterTable_R004_DubleLastikCep.ColumnName = "R004_DubleLastikCep"
        '
        'MasterTable_R004_DubleLastikCepCizgiler
        '
        Me.MasterTable_R004_DubleLastikCepCizgiler.ColumnName = "R004_DubleLastikCepCizgiler"
        '
        'MasterTable_R005_DubleLastikPilotYaka
        '
        Me.MasterTable_R005_DubleLastikPilotYaka.ColumnName = "R005_DubleLastikPilotYaka"
        '
        'MasterTable_R005_DubleLastikPilotYakaCizgiler
        '
        Me.MasterTable_R005_DubleLastikPilotYakaCizgiler.ColumnName = "R005_DubleLastikPilotYakaCizgiler"
        '
        'MasterTable_R006_DubleLastik
        '
        Me.MasterTable_R006_DubleLastik.ColumnName = "R006_DubleLastik"
        '
        'MasterTable_R006_DubleLastikCizgiler
        '
        Me.MasterTable_R006_DubleLastikCizgiler.ColumnName = "R006_DubleLastikCizgiler"
        '
        'MasterTable_R007_DubleYaka
        '
        Me.MasterTable_R007_DubleYaka.ColumnName = "R007_DubleYaka"
        '
        'MasterTable_R007_DubleYakaCizgiler
        '
        Me.MasterTable_R007_DubleYakaCizgiler.ColumnName = "R007_DubleYakaCizgiler"
        '
        'MasterTable_R008_TorbaliBant
        '
        Me.MasterTable_R008_TorbaliBant.ColumnName = "R008_TorbaliBant"
        '
        'MasterTable_R008_TorbaliBantCizgiler
        '
        Me.MasterTable_R008_TorbaliBantCizgiler.ColumnName = "R008_TorbaliBantCizgiler"
        '
        'MasterTable_R012_LakosYaka
        '
        Me.MasterTable_R012_LakosYaka.ColumnName = "R012_LakosYaka"
        '
        'MasterTable_R012_LakosYakaCizgiler
        '
        Me.MasterTable_R012_LakosYakaCizgiler.ColumnName = "R012_LakosYakaCizgiler"
        '
        'MasterTable_R013_Manset2cm
        '
        Me.MasterTable_R013_Manset2cm.ColumnName = "R013_Manset2cm"
        '
        'MasterTable_R013_Manset2cmCizgiler
        '
        Me.MasterTable_R013_Manset2cmCizgiler.ColumnName = "R013_Manset2cmCizgiler"
        '
        'MasterTable_R014_Manset6cm
        '
        Me.MasterTable_R014_Manset6cm.ColumnName = "R014_Manset6cm"
        '
        'MasterTable_R014_Manset6cmCizgiler
        '
        Me.MasterTable_R014_Manset6cmCizgiler.ColumnName = "R014_Manset6cmCizgiler"
        '
        'MasterTable_R018_EtekManseti
        '
        Me.MasterTable_R018_EtekManseti.ColumnName = "R018_EtekManseti"
        '
        'MasterTable_R018_EtekMansetiCizgiler
        '
        Me.MasterTable_R018_EtekMansetiCizgiler.ColumnName = "R018_EtekMansetiCizgiler"
        '
        'MasterTable_SaticiIsmi
        '
        Me.MasterTable_SaticiIsmi.ColumnName = "SaticiIsmi"
        '
        'MasterTable_CreatedBy
        '
        Me.MasterTable_CreatedBy.ColumnName = "CreatedBy"
        Me.MasterTable_CreatedBy.DataType = GetType(Integer)
        '
        'MasterTable_CreatedDate
        '
        Me.MasterTable_CreatedDate.ColumnName = "CreatedDate"
        Me.MasterTable_CreatedDate.DataType = GetType(Date)
        '
        'MasterTable_ModifiedBy
        '
        Me.MasterTable_ModifiedBy.ColumnName = "ModifiedBy"
        Me.MasterTable_ModifiedBy.DataType = GetType(Integer)
        '
        'MasterTable_ModifiedDate
        '
        Me.MasterTable_ModifiedDate.ColumnName = "ModifiedDate"
        Me.MasterTable_ModifiedDate.DataType = GetType(Date)
        '
        'frmSiparisRaporu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1190, 535)
        Me.FillOnFormOpening = False
        Me.FormCode = "000017"
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSiparisRaporu"
        Me.Text = "Sipariş Raporu"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.panelBottom, 0)
        Me.Controls.SetChildIndex(Me.panelFormDateFilter, 0)
        Me.Controls.SetChildIndex(Me.panelFormTop, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.BaseTab1.ResumeLayout(False)
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormDateFilter.ResumeLayout(False)
        Me.panelFormDateFilter.PerformLayout()
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSiparisAlanlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHaftaSonra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLeft.ResumeLayout(False)
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeceneklerdeFasonOlanlar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSiparisTarihineGore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBoyahaneler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colSipDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnayli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnaylayan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBolumKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriIsim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerminTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteriSipNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisiAlanID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuSiparisiAc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colsSiparisType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeDurumu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdenen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents TrackBarControl1 As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents chkHaftaSonra As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents colsAnaRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDurumu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DurumunuDeğiştirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetUretimde As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetBitti As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSetBos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetOrgude As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSiparisYaz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuSetBoyada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetKesimde As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetDepoda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDurumuHepsi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents colTeslimMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkDurumu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FasonFisiniAcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFasondaMi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSeceneklerdeFasonOlanlar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colR012_LakosYaka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR012_LakosYakaCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlceIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR002_Lastik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR002_LastikCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR003_Yaka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR003_YakaCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR004_DubleLastikCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR004_DubleLastikCepCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR005_DubleLastikPilotYaka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR005_DubleLastikPilotYakaCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR006_DubleLastik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR006_DubleLastikCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR007_DubleYaka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR007_DubleYakaCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR008_TorbaliBant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR008_TorbaliBantCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR013_Manset2cm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR013_Manset2cmCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR014_Manset6cm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR014_Manset6cmCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR018_EtekManseti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR018_EtekMansetiCizgiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuSetKilis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colSonSevkTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSonSevkEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KayitBilgisiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colDovizTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FasondaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜretimHazırlıkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜtüdeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbUsers As NeoDAC.NeoTable
    Friend WithEvents SqlCommand8 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As SqlClient.SqlCommand
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YakaÖrgüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KesimHazirlikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colSevkAdet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkKdvTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkToplamTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlkSevkTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlkSevkEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkDovizTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeFarkiOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeFarkiTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkVadeFarkiTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNakitIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskontoTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNakitIskontoTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CntUrunAgaci1 As cntUrunAgaci
    Friend WithEvents chkSiparisTarihineGore As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tbBoyahaneler As NeoDAC.NeoTable
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colBoyahane As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbSiparisAlanlar As NeoDAC.NeoTable
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MasterTable_SiparisID As DataColumn
    Friend WithEvents MasterTable_SipEvrakSeri As DataColumn
    Friend WithEvents MasterTable_SipEvrakSira As DataColumn
    Friend WithEvents MasterTable_CariKod As DataColumn
    Friend WithEvents MasterTable_CariUnvan As DataColumn
    Friend WithEvents MasterTable_Onayli As DataColumn
    Friend WithEvents MasterTable_Onaylayan As DataColumn
    Friend WithEvents MasterTable_Iptal As DataColumn
    Friend WithEvents MasterTable_BolumKod As DataColumn
    Friend WithEvents MasterTable_KategoriID As DataColumn
    Friend WithEvents MasterTable_KategoriKod As DataColumn
    Friend WithEvents MasterTable_KategoriIsim As DataColumn
    Friend WithEvents MasterTable_Miktar As DataColumn
    Friend WithEvents MasterTable_TerminTarihi As DataColumn
    Friend WithEvents MasterTable_MusteriSipNo As DataColumn
    Friend WithEvents MasterTable_Bedenler As DataColumn
    Friend WithEvents MasterTable_OkulKod As DataColumn
    Friend WithEvents MasterTable_Tarih As DataColumn
    Friend WithEvents MasterTable_SiparisNo As DataColumn
    Friend WithEvents MasterTable_SipDetayID As DataColumn
    Friend WithEvents MasterTable_OdemeDurumu As DataColumn
    Friend WithEvents MasterTable_Odenen As DataColumn
    Friend WithEvents MasterTable_sSiparisType As DataColumn
    Friend WithEvents MasterTable_AnaRenk As DataColumn
    Friend WithEvents MasterTable_Durumu As DataColumn
    Friend WithEvents MasterTable_BoyahaneID As DataColumn
    Friend WithEvents MasterTable_SiparisAlanID As DataColumn
    Friend WithEvents MasterTable_Iskonto As DataColumn
    Friend WithEvents MasterTable_NakitIskonto As DataColumn
    Friend WithEvents MasterTable_IskontoTutar As DataColumn
    Friend WithEvents MasterTable_NakitIskontoTutar As DataColumn
    Friend WithEvents MasterTable_Fiyat As DataColumn
    Friend WithEvents MasterTable_Tutar As DataColumn
    Friend WithEvents MasterTable_VadeFarkiOran As DataColumn
    Friend WithEvents MasterTable_VadeFarkiTutar As DataColumn
    Friend WithEvents MasterTable_KdvOran As DataColumn
    Friend WithEvents MasterTable_KdvTutari As DataColumn
    Friend WithEvents MasterTable_ToplamTutar As DataColumn
    Friend WithEvents MasterTable_DovizTipi As DataColumn
    Friend WithEvents MasterTable_DovizTutar As DataColumn
    Friend WithEvents MasterTable_DovizKuru As DataColumn
    Friend WithEvents MasterTable_TeslimMiktar As DataColumn
    Friend WithEvents MasterTable_Kalan As DataColumn
    Friend WithEvents MasterTable_SevkDurumu As DataColumn
    Friend WithEvents MasterTable_IlkSevkTarihi As DataColumn
    Friend WithEvents MasterTable_IlkSevkEvrakNo As DataColumn
    Friend WithEvents MasterTable_SonSevkTarihi As DataColumn
    Friend WithEvents MasterTable_SonSevkEvrakNo As DataColumn
    Friend WithEvents MasterTable_SevkAdet As DataColumn
    Friend WithEvents MasterTable_SevkTutar As DataColumn
    Friend WithEvents MasterTable_SevkVadeFarkiTutar As DataColumn
    Friend WithEvents MasterTable_SevkKdvTutar As DataColumn
    Friend WithEvents MasterTable_SevkToplamTutar As DataColumn
    Friend WithEvents MasterTable_SevkDovizTutar As DataColumn
    Friend WithEvents MasterTable_FasondaMi As DataColumn
    Friend WithEvents MasterTable_OkulIsmi As DataColumn
    Friend WithEvents MasterTable_IlceID As DataColumn
    Friend WithEvents MasterTable_IlID As DataColumn
    Friend WithEvents MasterTable_IlIsmi As DataColumn
    Friend WithEvents MasterTable_IlceIsmi As DataColumn
    Friend WithEvents MasterTable_R002_Lastik As DataColumn
    Friend WithEvents MasterTable_R002_LastikCizgiler As DataColumn
    Friend WithEvents MasterTable_R003_Yaka As DataColumn
    Friend WithEvents MasterTable_R003_YakaCizgiler As DataColumn
    Friend WithEvents MasterTable_R004_DubleLastikCep As DataColumn
    Friend WithEvents MasterTable_R004_DubleLastikCepCizgiler As DataColumn
    Friend WithEvents MasterTable_R005_DubleLastikPilotYaka As DataColumn
    Friend WithEvents MasterTable_R005_DubleLastikPilotYakaCizgiler As DataColumn
    Friend WithEvents MasterTable_R006_DubleLastik As DataColumn
    Friend WithEvents MasterTable_R006_DubleLastikCizgiler As DataColumn
    Friend WithEvents MasterTable_R007_DubleYaka As DataColumn
    Friend WithEvents MasterTable_R007_DubleYakaCizgiler As DataColumn
    Friend WithEvents MasterTable_R008_TorbaliBant As DataColumn
    Friend WithEvents MasterTable_R008_TorbaliBantCizgiler As DataColumn
    Friend WithEvents MasterTable_R012_LakosYaka As DataColumn
    Friend WithEvents MasterTable_R012_LakosYakaCizgiler As DataColumn
    Friend WithEvents MasterTable_R013_Manset2cm As DataColumn
    Friend WithEvents MasterTable_R013_Manset2cmCizgiler As DataColumn
    Friend WithEvents MasterTable_R014_Manset6cm As DataColumn
    Friend WithEvents MasterTable_R014_Manset6cmCizgiler As DataColumn
    Friend WithEvents MasterTable_R018_EtekManseti As DataColumn
    Friend WithEvents MasterTable_R018_EtekMansetiCizgiler As DataColumn
    Friend WithEvents MasterTable_SaticiIsmi As DataColumn
    Friend WithEvents MasterTable_CreatedBy As DataColumn
    Friend WithEvents MasterTable_CreatedDate As DataColumn
    Friend WithEvents MasterTable_ModifiedBy As DataColumn
    Friend WithEvents MasterTable_ModifiedDate As DataColumn
    Friend WithEvents tbUsers_UserID As DataColumn
    Friend WithEvents tbUsers_UserName As DataColumn
    Friend WithEvents SqlCommand12 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As SqlClient.SqlCommand
    Friend WithEvents tbBoyahaneler_BoyahaneID As DataColumn
    Friend WithEvents tbBoyahaneler_Boyahane As DataColumn
    Friend WithEvents SqlCommand16 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As SqlClient.SqlCommand
    Friend WithEvents tbSiparisAlanlar_SiparisAlanID As DataColumn
    Friend WithEvents tbSiparisAlanlar_SipAlanIsmi As DataColumn
End Class
