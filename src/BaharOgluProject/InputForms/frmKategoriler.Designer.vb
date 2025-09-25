<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategoriler
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKategoriler))
        Dim KategoriItem1 As ProbarSiparis.kategoriItem = New ProbarSiparis.kategoriItem()
        Me.mnuOzellikSec = New System.Windows.Forms.ToolStripMenuItem()
        Me.BedenlerFiyatlarTurHesaplariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UygulamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.panelParametreler = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.paneltemp333 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.panelOzellikler = New System.Windows.Forms.FlowLayoutPanel()
        Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl()
        Me.txtSiparisKontrol = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.tbKategori = New NeoDAC.NeoTable(Me.components)
        Me.tbKategori_KategoriID = New System.Data.DataColumn()
        Me.tbKategori_Deleted = New System.Data.DataColumn()
        Me.tbKategori_CreatedBy = New System.Data.DataColumn()
        Me.tbKategori_CreatedDate = New System.Data.DataColumn()
        Me.tbKategori_ModifiedBy = New System.Data.DataColumn()
        Me.tbKategori_ModifiedDate = New System.Data.DataColumn()
        Me.tbKategori_UstKategoriID = New System.Data.DataColumn()
        Me.tbKategori_KategoriKod = New System.Data.DataColumn()
        Me.tbKategori_KategoriIsim = New System.Data.DataColumn()
        Me.tbKategori_StokKodFormat = New System.Data.DataColumn()
        Me.tbKategori_IntCode = New System.Data.DataColumn()
        Me.tbKategori_tempGrup = New System.Data.DataColumn()
        Me.tbKategori_Resim1 = New System.Data.DataColumn()
        Me.tbKategori_Resim2 = New System.Data.DataColumn()
        Me.tbKategori_Resim3 = New System.Data.DataColumn()
        Me.tbKategori_Resim4 = New System.Data.DataColumn()
        Me.tbKategori_Resim5 = New System.Data.DataColumn()
        Me.tbKategori_KendiFiyatBedenKullan = New System.Data.DataColumn()
        Me.tbKategori_KendiMasrafKullan = New System.Data.DataColumn()
        Me.FirmConn = New NeoDAC.NeoConnection(Me.components)
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdKategoriKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDevam = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelOzellik = New DevExpress.XtraEditors.SimpleButton()
        Me.tbSipDetay = New NeoDAC.NeoTable(Me.components)
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.tbOkul = New NeoDAC.NeoTable(Me.components)
        Me.tbOkul_OkulID = New System.Data.DataColumn()
        Me.tbOkul_OkulKod = New System.Data.DataColumn()
        Me.tbOkul_OkulIsmi = New System.Data.DataColumn()
        Me.tbOkul_IlceID = New System.Data.DataColumn()
        Me.tbOkul_IlID = New System.Data.DataColumn()
        Me.tbOkul_IlIsmi = New System.Data.DataColumn()
        Me.tbOkul_IlceIsmi = New System.Data.DataColumn()
        Me.tbOkul_DisplayText = New System.Data.DataColumn()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.cboSecenekler = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.cmdOzellikleriEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.lblAktifKategoriIsim = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl()
        Me.lblAktifKategoriEntKod = New DevExpress.XtraEditors.LabelControl()
        Me.lblAktifKategoriKod = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFiyatSil = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbKategoriFiyat = New NeoDAC.NeoTable(Me.components)
        Me.tbKategoriFiyat_KategoriFiyatID = New System.Data.DataColumn()
        Me.tbKategoriFiyat_Deleted = New System.Data.DataColumn()
        Me.tbKategoriFiyat_CreatedBy = New System.Data.DataColumn()
        Me.tbKategoriFiyat_CreatedDate = New System.Data.DataColumn()
        Me.tbKategoriFiyat_ModifiedBy = New System.Data.DataColumn()
        Me.tbKategoriFiyat_ModifiedDate = New System.Data.DataColumn()
        Me.tbKategoriFiyat_KategoriID = New System.Data.DataColumn()
        Me.tbKategoriFiyat_BedenNo = New System.Data.DataColumn()
        Me.tbKategoriFiyat_BedenKod = New System.Data.DataColumn()
        Me.tbKategoriFiyat_Fiyat = New System.Data.DataColumn()
        Me.tbKategoriFiyat_BazBedenMi = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKategoriFiyatID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBazBedenMi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkGridBazBedenMi = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.panelKendiFiyatBeden = New System.Windows.Forms.Panel()
        Me.chkKategori_KendiFiyatBeden = New System.Windows.Forms.CheckBox()
        Me.grEkMasraflar = New DevExpress.XtraGrid.GridControl()
        Me.tbKategoriEkFiyat = New NeoDAC.NeoTable(Me.components)
        Me.tbKategoriEkFiyat_KategoriEkFiyatID = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_Deleted = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_CreatedBy = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_CreatedDate = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_ModifiedBy = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_ModifiedDate = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_KategoriID = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_MasrafKod = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_MasrafIsmi = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_Fiyat = New System.Data.DataColumn()
        Me.tbKategoriEkFiyat_BedenArtis = New System.Data.DataColumn()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.grEkMasraflarView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasrafKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriEkFiyatID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelKendiMasraf = New System.Windows.Forms.Panel()
        Me.chkKategori_KendiMasraf = New System.Windows.Forms.CheckBox()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdKaydetFiyat = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.grFiyatlar = New DevExpress.XtraGrid.GridControl()
        Me.tbSipDetayFiyatlar = New NeoDAC.NeoTable(Me.components)
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.grFiyatlarView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSipDetayFiyatAdetID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenKod1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetayAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBazFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNakitIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRenkKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboRenkler = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colBdnHarNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriFiyatID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.chkSerbestFiyat = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdGeri = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.lblOkulFarki = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdIskontoUygula = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNakitIskonto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIskonto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdMikroStokKod = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit10 = New DevExpress.XtraEditors.PictureEdit()
        Me.cboBolumKod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboOkul = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOkulID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlceIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMusteri = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdGeri_AdetlerFiyatlar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSaveOzellik = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit9 = New DevExpress.XtraEditors.PictureEdit()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraScrollableControl2 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.PictureEdit7 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit8 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit6 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit5 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit4 = New DevExpress.XtraEditors.PictureEdit()
        Me.SplitterControl4 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.tbSipDetayEkFiyatlar = New NeoDAC.NeoTable(Me.components)
        Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_Deleted = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_CreatedBy = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_CreatedDate = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_ModifiedBy = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_ModifiedDate = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_SipDetayID = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_MasrafKod = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_MasrafIsmi = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_EkFiyat = New System.Data.DataColumn()
        Me.tbSipDetayEkFiyatlar_BedenArtis = New System.Data.DataColumn()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSipDetayEkFiyatID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkFiyatAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasrafKod1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenArtis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage10 = New DevExpress.XtraTab.XtraTabPage()
        Me.tmrRapair = New System.Windows.Forms.Timer(Me.components)
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.CntUrunAgaci1 = New ProbarSiparis.cntUrunAgaci()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOzellikSecimSayfasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBedenlerFiyatlarMasraflar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUygulama = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbSipDetay_SipDetayID = New System.Data.DataColumn()
        Me.tbSipDetay_Deleted = New System.Data.DataColumn()
        Me.tbSipDetay_CreatedBy = New System.Data.DataColumn()
        Me.tbSipDetay_CreatedDate = New System.Data.DataColumn()
        Me.tbSipDetay_ModifiedBy = New System.Data.DataColumn()
        Me.tbSipDetay_ModifiedDate = New System.Data.DataColumn()
        Me.tbSipDetay_SiparisID = New System.Data.DataColumn()
        Me.tbSipDetay_StokKod = New System.Data.DataColumn()
        Me.tbSipDetay_StokRecNo = New System.Data.DataColumn()
        Me.tbSipDetay_SiparisAciklama = New System.Data.DataColumn()
        Me.tbSipDetay_OkulID = New System.Data.DataColumn()
        Me.tbSipDetay_BolumKod = New System.Data.DataColumn()
        Me.tbSipDetay_KategoriID = New System.Data.DataColumn()
        Me.tbSipDetay_Miktar = New System.Data.DataColumn()
        Me.tbSipDetay_Maliyet = New System.Data.DataColumn()
        Me.tbSipDetay_Fiyat = New System.Data.DataColumn()
        Me.tbSipDetay_Tutar = New System.Data.DataColumn()
        Me.tbSipDetay_Tarih = New System.Data.DataColumn()
        Me.tbSipDetay_TerminTarihi = New System.Data.DataColumn()
        Me.tbSipDetay_MusteriSipNo = New System.Data.DataColumn()
        Me.tbSipDetay_SiparisiAlan = New System.Data.DataColumn()
        Me.tbSipDetay_Iptal = New System.Data.DataColumn()
        Me.tbSipDetay_Resim1 = New System.Data.DataColumn()
        Me.tbSipDetay_Resim2 = New System.Data.DataColumn()
        Me.tbSipDetay_Resim3 = New System.Data.DataColumn()
        Me.tbSipDetay_Resim4 = New System.Data.DataColumn()
        Me.tbSipDetay_Resim5 = New System.Data.DataColumn()
        Me.tbSipDetay_StokIsmi = New System.Data.DataColumn()
        Me.tbSipDetay_Bagli = New System.Data.DataColumn()
        Me.tbSipDetay_BagliSipDetayID = New System.Data.DataColumn()
        Me.tbSipDetay_OkulFarki = New System.Data.DataColumn()
        Me.tbSipDetay_Durumu = New System.Data.DataColumn()
        Me.tbSipDetay_TeslimMiktar = New System.Data.DataColumn()
        Me.tbSipDetay_AnaRenk = New System.Data.DataColumn()
        Me.tbSipDetay_Bedenler = New System.Data.DataColumn()
        Me.tbSipDetay_bSerbestFiyat = New System.Data.DataColumn()
        Me.tbSipDetay_Hazirlanan = New System.Data.DataColumn()
        Me.tbSipDetay_FasondaMi = New System.Data.DataColumn()
        Me.tbSipDetay_FasonFisID = New System.Data.DataColumn()
        Me.tbSipDetay_Iskonto = New System.Data.DataColumn()
        Me.tbSipDetay_NakitIskonto = New System.Data.DataColumn()
        Me.tbSipDetay_IskontoTutar = New System.Data.DataColumn()
        Me.tbSipDetay_NakitIskontoTutar = New System.Data.DataColumn()
        Me.tbSipDetay_sip_Guid = New System.Data.DataColumn()
        Me.tbSipDetay_BoyahaneID = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_BedenNo = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_Deleted = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_CreatedBy = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_CreatedDate = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_ModifiedBy = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_ModifiedDate = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_SipDetayID = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_BedenKod = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_BazFiyat = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_BrutFiyat = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_Iskonto = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_NakitIskonto = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_NetFiyat = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_Miktar = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_Tutar = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_KategoriFiyatID = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_DetayAciklama = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_RenkKod = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_BdnHarNo = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_TeslimMiktar = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_sip_RECno = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_sip_evrakno_seri = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_sip_evrakno_sira = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_sip_satirno = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_Hazirlanan = New System.Data.DataColumn()
        Me.tbSipDetayFiyatlar_sip_Guid = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelParametreler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelParametreler.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        Me.paneltemp333.SuspendLayout()
        CType(Me.txtSiparisKontrol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.tbSipDetay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOkul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSecenekler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl13.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.tbKategoriFiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGridBazBedenMi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelKendiFiyatBeden.SuspendLayout()
        CType(Me.grEkMasraflar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKategoriEkFiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grEkMasraflarView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelKendiMasraf.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.grFiyatlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSipDetayFiyatlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grFiyatlarView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRenkler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.chkSerbestFiyat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.txtNakitIskonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIskonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBolumKod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOkul.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMusteri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.PictureEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage9.SuspendLayout()
        Me.XtraScrollableControl2.SuspendLayout()
        CType(Me.PictureEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSipDetayEkFiyatlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuOzellikSec
        '
        Me.mnuOzellikSec.Name = "mnuOzellikSec"
        Me.mnuOzellikSec.Size = New System.Drawing.Size(219, 22)
        Me.mnuOzellikSec.Text = "Özellik Seçim Sayfası"
        '
        'BedenlerFiyatlarTurHesaplariToolStripMenuItem
        '
        Me.BedenlerFiyatlarTurHesaplariToolStripMenuItem.Name = "BedenlerFiyatlarTurHesaplariToolStripMenuItem"
        Me.BedenlerFiyatlarTurHesaplariToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.BedenlerFiyatlarTurHesaplariToolStripMenuItem.Text = "Bedenler, Fiyatlar, Masraflar"
        '
        'UygulamaToolStripMenuItem
        '
        Me.UygulamaToolStripMenuItem.Name = "UygulamaToolStripMenuItem"
        Me.UygulamaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.UygulamaToolStripMenuItem.Text = "Uygulama"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.png")
        Me.ImageList1.Images.SetKeyName(1, "blog_post.png")
        Me.ImageList1.Images.SetKeyName(2, "folder_add.png")
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(898, 14)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Visible = False
        '
        'panelParametreler
        '
        Me.panelParametreler.Controls.Add(Me.XtraTabControl3)
        Me.panelParametreler.Controls.Add(Me.PanelControl4)
        Me.panelParametreler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelParametreler.Location = New System.Drawing.Point(0, 0)
        Me.panelParametreler.Name = "panelParametreler"
        Me.panelParametreler.Size = New System.Drawing.Size(620, 507)
        Me.panelParametreler.TabIndex = 2
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl3.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage7
        Me.XtraTabControl3.Size = New System.Drawing.Size(616, 466)
        Me.XtraTabControl3.TabIndex = 4
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.paneltemp333)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(610, 438)
        Me.XtraTabPage7.Text = "Özellikler"
        '
        'paneltemp333
        '
        Me.paneltemp333.Controls.Add(Me.panelOzellikler)
        Me.paneltemp333.Controls.Add(Me.SplitterControl3)
        Me.paneltemp333.Controls.Add(Me.txtSiparisKontrol)
        Me.paneltemp333.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneltemp333.Location = New System.Drawing.Point(0, 0)
        Me.paneltemp333.Name = "paneltemp333"
        Me.paneltemp333.Size = New System.Drawing.Size(610, 438)
        Me.paneltemp333.TabIndex = 3
        '
        'panelOzellikler
        '
        Me.panelOzellikler.AutoScroll = True
        Me.panelOzellikler.AutoScrollMargin = New System.Drawing.Size(0, 1500)
        Me.panelOzellikler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelOzellikler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOzellikler.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelOzellikler.Location = New System.Drawing.Point(0, 0)
        Me.panelOzellikler.Name = "panelOzellikler"
        Me.panelOzellikler.Size = New System.Drawing.Size(610, 344)
        Me.panelOzellikler.TabIndex = 0
        '
        'SplitterControl3
        '
        Me.SplitterControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterControl3.Location = New System.Drawing.Point(0, 344)
        Me.SplitterControl3.Name = "SplitterControl3"
        Me.SplitterControl3.Size = New System.Drawing.Size(610, 5)
        Me.SplitterControl3.TabIndex = 2
        Me.SplitterControl3.TabStop = False
        '
        'txtSiparisKontrol
        '
        Me.txtSiparisKontrol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSiparisKontrol.Location = New System.Drawing.Point(0, 349)
        Me.txtSiparisKontrol.Name = "txtSiparisKontrol"
        Me.txtSiparisKontrol.Properties.Appearance.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSiparisKontrol.Properties.Appearance.Options.UseFont = True
        Me.txtSiparisKontrol.Size = New System.Drawing.Size(610, 89)
        Me.txtSiparisKontrol.TabIndex = 1
        Me.txtSiparisKontrol.Visible = False
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.XtraScrollableControl1)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.PageVisible = False
        Me.XtraTabPage8.Size = New System.Drawing.Size(610, 438)
        Me.XtraTabPage8.Text = "Resimler"
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.PictureEdit3)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl13)
        Me.XtraScrollableControl1.Controls.Add(Me.PictureEdit2)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl12)
        Me.XtraScrollableControl1.Controls.Add(Me.PictureEdit1)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl11)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(610, 438)
        Me.XtraScrollableControl1.TabIndex = 4
        '
        'PictureEdit3
        '
        Me.PictureEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbKategori, "Resim3", True))
        Me.PictureEdit3.Location = New System.Drawing.Point(467, 27)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit3.Size = New System.Drawing.Size(219, 212)
        Me.PictureEdit3.TabIndex = 5
        '
        'tbKategori
        '
        Me.tbKategori.Columns.AddRange(New System.Data.DataColumn() {Me.tbKategori_KategoriID, Me.tbKategori_Deleted, Me.tbKategori_CreatedBy, Me.tbKategori_CreatedDate, Me.tbKategori_ModifiedBy, Me.tbKategori_ModifiedDate, Me.tbKategori_UstKategoriID, Me.tbKategori_KategoriKod, Me.tbKategori_KategoriIsim, Me.tbKategori_StokKodFormat, Me.tbKategori_IntCode, Me.tbKategori_tempGrup, Me.tbKategori_Resim1, Me.tbKategori_Resim2, Me.tbKategori_Resim3, Me.tbKategori_Resim4, Me.tbKategori_Resim5, Me.tbKategori_KendiFiyatBedenKullan, Me.tbKategori_KendiMasrafKullan})
        Me.tbKategori.Connection = Me.FirmConn
        Me.tbKategori.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriID"}, True)})
        Me.tbKategori.CurrentRow = Nothing
        Me.tbKategori.DataSourceLink = Nothing
        Me.tbKategori.DeleteCommand = Me.SqlCommand28
        Me.tbKategori.Filter = ""
        Me.tbKategori.InsertCommand = Me.SqlCommand26
        Me.tbKategori.LiveSave = False
        Me.tbKategori.MaxRecords = CType(0, Long)
        Me.tbKategori.Name = "tbKategori"
        Me.tbKategori.ParentRelation_ChildColumns = Nothing
        Me.tbKategori.ParentRelation_ParentColumns = Nothing
        Me.tbKategori.ParentRelation_Table = Nothing
        Me.tbKategori.Position = CType(-1, Long)
        Me.tbKategori.PrimaryKey = New System.Data.DataColumn() {Me.tbKategori_KategoriID}
        Me.tbKategori.Quoted = False
        Me.tbKategori.SelectCommand = Me.SqlCommand25
        Me.tbKategori.TableName = "NeoTable1"
        Me.tbKategori.Transaction = Nothing
        Me.tbKategori.UpdateCommand = Me.SqlCommand27
        '
        'tbKategori_KategoriID
        '
        Me.tbKategori_KategoriID.AllowDBNull = False
        Me.tbKategori_KategoriID.AutoIncrement = True
        Me.tbKategori_KategoriID.ColumnName = "KategoriID"
        Me.tbKategori_KategoriID.DataType = GetType(Integer)
        '
        'tbKategori_Deleted
        '
        Me.tbKategori_Deleted.ColumnName = "Deleted"
        Me.tbKategori_Deleted.DataType = GetType(Integer)
        '
        'tbKategori_CreatedBy
        '
        Me.tbKategori_CreatedBy.ColumnName = "CreatedBy"
        Me.tbKategori_CreatedBy.DataType = GetType(Integer)
        '
        'tbKategori_CreatedDate
        '
        Me.tbKategori_CreatedDate.ColumnName = "CreatedDate"
        Me.tbKategori_CreatedDate.DataType = GetType(Date)
        '
        'tbKategori_ModifiedBy
        '
        Me.tbKategori_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbKategori_ModifiedBy.DataType = GetType(Integer)
        '
        'tbKategori_ModifiedDate
        '
        Me.tbKategori_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbKategori_ModifiedDate.DataType = GetType(Date)
        '
        'tbKategori_UstKategoriID
        '
        Me.tbKategori_UstKategoriID.ColumnName = "UstKategoriID"
        Me.tbKategori_UstKategoriID.DataType = GetType(Integer)
        '
        'tbKategori_KategoriKod
        '
        Me.tbKategori_KategoriKod.ColumnName = "KategoriKod"
        '
        'tbKategori_KategoriIsim
        '
        Me.tbKategori_KategoriIsim.ColumnName = "KategoriIsim"
        '
        'tbKategori_StokKodFormat
        '
        Me.tbKategori_StokKodFormat.ColumnName = "StokKodFormat"
        '
        'tbKategori_IntCode
        '
        Me.tbKategori_IntCode.ColumnName = "IntCode"
        '
        'tbKategori_tempGrup
        '
        Me.tbKategori_tempGrup.ColumnName = "tempGrup"
        '
        'tbKategori_Resim1
        '
        Me.tbKategori_Resim1.ColumnName = "Resim1"
        Me.tbKategori_Resim1.DataType = GetType(Byte())
        '
        'tbKategori_Resim2
        '
        Me.tbKategori_Resim2.ColumnName = "Resim2"
        Me.tbKategori_Resim2.DataType = GetType(Byte())
        '
        'tbKategori_Resim3
        '
        Me.tbKategori_Resim3.ColumnName = "Resim3"
        Me.tbKategori_Resim3.DataType = GetType(Byte())
        '
        'tbKategori_Resim4
        '
        Me.tbKategori_Resim4.ColumnName = "Resim4"
        Me.tbKategori_Resim4.DataType = GetType(Byte())
        '
        'tbKategori_Resim5
        '
        Me.tbKategori_Resim5.ColumnName = "Resim5"
        Me.tbKategori_Resim5.DataType = GetType(Byte())
        '
        'tbKategori_KendiFiyatBedenKullan
        '
        Me.tbKategori_KendiFiyatBedenKullan.ColumnName = "KendiFiyatBedenKullan"
        Me.tbKategori_KendiFiyatBedenKullan.DataType = GetType(Integer)
        '
        'tbKategori_KendiMasrafKullan
        '
        Me.tbKategori_KendiMasrafKullan.ColumnName = "KendiMasrafKullan"
        Me.tbKategori_KendiMasrafKullan.DataType = GetType(Integer)
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Server=(local);Database=ProbarSiparisDB2025;User ID=sa;Password=;Trusted_Connecti" &
    "on=True;"
        Me.FirmConn.Name = "FirmConn"
        Me.FirmConn.UserInfo_AuthCodeFieldName = "AuthCode"
        Me.FirmConn.UserInfo_CanDeleteAuthCode = ""
        Me.FirmConn.UserInfo_CanReadAuthCode = ""
        Me.FirmConn.UserInfo_CanWriteAuthCode = ""
        Me.FirmConn.UserInfo_CreatedDateFieldName = "CreatedDate"
        Me.FirmConn.UserInfo_CreatedUserFieldName = "CreatedBy"
        Me.FirmConn.UserInfo_ModifiedDateFieldName = "ModifiedDate"
        Me.FirmConn.UserInfo_ModifiedUserFieldName = "ModifiedBy"
        Me.FirmConn.UserInfo_NewRecordAuthCode = ""
        Me.FirmConn.UserInfo_UserID = Nothing
        '
        'SqlCommand28
        '
        Me.SqlCommand28.CommandText = "UPDATE Kategoriler SET Deleted = KategoriID  , ModifiedBy = @ModifiedBy , Modifie" &
    "dDate = GETDATE()   WHERE KategoriID = @KategoriID"
        '
        'SqlCommand26
        '
        Me.SqlCommand26.CommandText = resources.GetString("SqlCommand26.CommandText")
        Me.SqlCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KategoriID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT * FROM Kategoriler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 AND KategoriID = @KategoriID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlCommand25.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@KategoriID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand27
        '
        Me.SqlCommand27.CommandText = resources.GetString("SqlCommand27.CommandText")
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(467, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl13.TabIndex = 4
        Me.LabelControl13.Text = "Resim 3"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbKategori, "Resim2", True))
        Me.PictureEdit2.Location = New System.Drawing.Point(235, 27)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit2.Size = New System.Drawing.Size(219, 212)
        Me.PictureEdit2.TabIndex = 3
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(235, 8)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Resim 2"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbKategori, "Resim1", True))
        Me.PictureEdit1.Location = New System.Drawing.Point(3, 27)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Size = New System.Drawing.Size(219, 212)
        Me.PictureEdit1.TabIndex = 1
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(3, 8)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Resim 1"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.cmdKategoriKaydet)
        Me.PanelControl4.Controls.Add(Me.cmdDevam)
        Me.PanelControl4.Controls.Add(Me.cmdCancelOzellik)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 468)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(616, 37)
        Me.PanelControl4.TabIndex = 1
        '
        'cmdKategoriKaydet
        '
        Me.cmdKategoriKaydet.Location = New System.Drawing.Point(115, 5)
        Me.cmdKategoriKaydet.Name = "cmdKategoriKaydet"
        Me.cmdKategoriKaydet.Size = New System.Drawing.Size(102, 31)
        Me.cmdKategoriKaydet.TabIndex = 3
        Me.cmdKategoriKaydet.Text = "Kaydet 2"
        '
        'cmdDevam
        '
        Me.cmdDevam.Location = New System.Drawing.Point(7, 5)
        Me.cmdDevam.Name = "cmdDevam"
        Me.cmdDevam.Size = New System.Drawing.Size(102, 31)
        Me.cmdDevam.TabIndex = 2
        Me.cmdDevam.Text = "Devam >>>"
        '
        'cmdCancelOzellik
        '
        Me.cmdCancelOzellik.Location = New System.Drawing.Point(223, 5)
        Me.cmdCancelOzellik.Name = "cmdCancelOzellik"
        Me.cmdCancelOzellik.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancelOzellik.TabIndex = 1
        Me.cmdCancelOzellik.Text = "Vazgeç"
        '
        'tbSipDetay
        '
        Me.tbSipDetay.Columns.AddRange(New System.Data.DataColumn() {Me.tbSipDetay_SipDetayID, Me.tbSipDetay_Deleted, Me.tbSipDetay_CreatedBy, Me.tbSipDetay_CreatedDate, Me.tbSipDetay_ModifiedBy, Me.tbSipDetay_ModifiedDate, Me.tbSipDetay_SiparisID, Me.tbSipDetay_StokKod, Me.tbSipDetay_StokRecNo, Me.tbSipDetay_SiparisAciklama, Me.tbSipDetay_OkulID, Me.tbSipDetay_BolumKod, Me.tbSipDetay_KategoriID, Me.tbSipDetay_Miktar, Me.tbSipDetay_Maliyet, Me.tbSipDetay_Fiyat, Me.tbSipDetay_Tutar, Me.tbSipDetay_Tarih, Me.tbSipDetay_TerminTarihi, Me.tbSipDetay_MusteriSipNo, Me.tbSipDetay_SiparisiAlan, Me.tbSipDetay_Iptal, Me.tbSipDetay_Resim1, Me.tbSipDetay_Resim2, Me.tbSipDetay_Resim3, Me.tbSipDetay_Resim4, Me.tbSipDetay_Resim5, Me.tbSipDetay_StokIsmi, Me.tbSipDetay_Bagli, Me.tbSipDetay_BagliSipDetayID, Me.tbSipDetay_OkulFarki, Me.tbSipDetay_Durumu, Me.tbSipDetay_TeslimMiktar, Me.tbSipDetay_AnaRenk, Me.tbSipDetay_Bedenler, Me.tbSipDetay_bSerbestFiyat, Me.tbSipDetay_Hazirlanan, Me.tbSipDetay_FasondaMi, Me.tbSipDetay_FasonFisID, Me.tbSipDetay_Iskonto, Me.tbSipDetay_NakitIskonto, Me.tbSipDetay_IskontoTutar, Me.tbSipDetay_NakitIskontoTutar, Me.tbSipDetay_sip_Guid, Me.tbSipDetay_BoyahaneID})
        Me.tbSipDetay.Connection = Me.FirmConn
        Me.tbSipDetay.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SipDetayID"}, True)})
        Me.tbSipDetay.CurrentRow = Nothing
        Me.tbSipDetay.DataSourceLink = Nothing
        Me.tbSipDetay.DeleteCommand = Me.SqlCommand8
        Me.tbSipDetay.Filter = ""
        Me.tbSipDetay.InsertCommand = Me.SqlCommand6
        Me.tbSipDetay.LiveSave = False
        Me.tbSipDetay.MaxRecords = CType(0, Long)
        Me.tbSipDetay.Name = "tbSipDetay"
        Me.tbSipDetay.ParentRelation_ChildColumns = Nothing
        Me.tbSipDetay.ParentRelation_ParentColumns = Nothing
        Me.tbSipDetay.ParentRelation_Table = Nothing
        Me.tbSipDetay.Position = CType(-1, Long)
        Me.tbSipDetay.PrimaryKey = New System.Data.DataColumn() {Me.tbSipDetay_SipDetayID}
        Me.tbSipDetay.Quoted = False
        Me.tbSipDetay.SelectCommand = Me.SqlCommand5
        Me.tbSipDetay.TableName = "NeoTable1"
        Me.tbSipDetay.Transaction = Nothing
        Me.tbSipDetay.UpdateCommand = Me.SqlCommand7
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "UPDATE SipDetay SET Deleted = SipDetayID  , ModifiedBy = @ModifiedBy , ModifiedDa" &
    "te = GETDATE()   WHERE SipDetayID = @SipDetayID"
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_SipDetayID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM SipDetay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0  "
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = resources.GetString("SqlCommand7.CommandText")
        '
        'tbOkul
        '
        Me.tbOkul.Columns.AddRange(New System.Data.DataColumn() {Me.tbOkul_OkulID, Me.tbOkul_OkulKod, Me.tbOkul_OkulIsmi, Me.tbOkul_IlceID, Me.tbOkul_IlID, Me.tbOkul_IlIsmi, Me.tbOkul_IlceIsmi, Me.tbOkul_DisplayText})
        Me.tbOkul.Connection = Me.FirmConn
        Me.tbOkul.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"OkulID"}, True)})
        Me.tbOkul.CurrentRow = Nothing
        Me.tbOkul.DataSourceLink = Nothing
        Me.tbOkul.DeleteCommand = Me.SqlCommand4
        Me.tbOkul.Filter = ""
        Me.tbOkul.InsertCommand = Me.SqlCommand2
        Me.tbOkul.LiveSave = False
        Me.tbOkul.MaxRecords = CType(0, Long)
        Me.tbOkul.Name = "tbOkul"
        Me.tbOkul.ParentRelation_ChildColumns = Nothing
        Me.tbOkul.ParentRelation_ParentColumns = Nothing
        Me.tbOkul.ParentRelation_Table = Nothing
        Me.tbOkul.Position = CType(-1, Long)
        Me.tbOkul.PrimaryKey = New System.Data.DataColumn() {Me.tbOkul_OkulID}
        Me.tbOkul.Quoted = False
        Me.tbOkul.SelectCommand = Me.SqlCommand1
        Me.tbOkul.TableName = "NeoTable1"
        Me.tbOkul.Transaction = Nothing
        Me.tbOkul.UpdateCommand = Me.SqlCommand3
        '
        'tbOkul_OkulID
        '
        Me.tbOkul_OkulID.AllowDBNull = False
        Me.tbOkul_OkulID.AutoIncrement = True
        Me.tbOkul_OkulID.ColumnName = "OkulID"
        Me.tbOkul_OkulID.DataType = GetType(Integer)
        '
        'tbOkul_OkulKod
        '
        Me.tbOkul_OkulKod.ColumnName = "OkulKod"
        '
        'tbOkul_OkulIsmi
        '
        Me.tbOkul_OkulIsmi.ColumnName = "OkulIsmi"
        '
        'tbOkul_IlceID
        '
        Me.tbOkul_IlceID.ColumnName = "IlceID"
        Me.tbOkul_IlceID.DataType = GetType(Integer)
        '
        'tbOkul_IlID
        '
        Me.tbOkul_IlID.ColumnName = "IlID"
        Me.tbOkul_IlID.DataType = GetType(Integer)
        '
        'tbOkul_IlIsmi
        '
        Me.tbOkul_IlIsmi.ColumnName = "IlIsmi"
        '
        'tbOkul_IlceIsmi
        '
        Me.tbOkul_IlceIsmi.ColumnName = "IlceIsmi"
        '
        'tbOkul_DisplayText
        '
        Me.tbOkul_DisplayText.ColumnName = "DisplayText"
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        '
        'cboSecenekler
        '
        Me.cboSecenekler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboSecenekler.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("001", "Triko Kumaş"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("002", "Lastik"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("003", "Yaka"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("004", "Duble Lastik Cep"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("017", "Duble Lastik İç Cep (çift tarflılar için)"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("005", "Duble Lastik Pilot Yaka"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("006", "Duble Lastik"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("007", "Duble Yaka"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("008", "Torbalı Bant"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("009", "Etek/Gömlek/Pantolon/Badi Kumaş"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("052", "Kazak Yaka"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("054", "Garni Dikiş"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("010", "Gömlek Parametreleri (Yaka / Pens / Cep)"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("011", "L/S Kumaş"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("012", "L/S Yaka"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("013", "Lakos 2cm Manşet"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("014", "L/S 6cm Manşet"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("018", "Etek Manşet (6cm)"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("020", "Göğüs Manşet"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("019", "Kaşkorse"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("021", "Cep Kapağı"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("015", "Fular Özellikleri"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("016", "Kravat Özellikleri"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("055", "Model F. /Parça M./Astar/FarkArma/Ö. Etiket / Fason ... (Seçenekler)", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("056", "Ek Fiyat", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("057", "Ek Özellikler", System.Windows.Forms.CheckState.Checked)})
        Me.cboSecenekler.Location = New System.Drawing.Point(0, 0)
        Me.cboSecenekler.Name = "cboSecenekler"
        Me.cboSecenekler.Size = New System.Drawing.Size(620, 472)
        Me.cboSecenekler.TabIndex = 2
        '
        'cmdOzellikleriEkle
        '
        Me.cmdOzellikleriEkle.Location = New System.Drawing.Point(7, 4)
        Me.cmdOzellikleriEkle.Name = "cmdOzellikleriEkle"
        Me.cmdOzellikleriEkle.Size = New System.Drawing.Size(129, 26)
        Me.cmdOzellikleriEkle.TabIndex = 1
        Me.cmdOzellikleriEkle.Text = "(F5) Uygula >>>"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(267, 14)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 592)
        Me.SplitterControl1.TabIndex = 4
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.lblAktifKategoriIsim)
        Me.PanelControl6.Controls.Add(Me.PanelControl13)
        Me.PanelControl6.Controls.Add(Me.LabelControl1)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl6.Location = New System.Drawing.Point(272, 14)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(626, 57)
        Me.PanelControl6.TabIndex = 5
        '
        'lblAktifKategoriIsim
        '
        Me.lblAktifKategoriIsim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAktifKategoriIsim.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lblAktifKategoriIsim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAktifKategoriIsim.Location = New System.Drawing.Point(2, 33)
        Me.lblAktifKategoriIsim.Name = "lblAktifKategoriIsim"
        Me.lblAktifKategoriIsim.Size = New System.Drawing.Size(622, 22)
        Me.lblAktifKategoriIsim.TabIndex = 2
        '
        'PanelControl13
        '
        Me.PanelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl13.Controls.Add(Me.lblAktifKategoriEntKod)
        Me.PanelControl13.Controls.Add(Me.lblAktifKategoriKod)
        Me.PanelControl13.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl13.Location = New System.Drawing.Point(2, 15)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(622, 18)
        Me.PanelControl13.TabIndex = 4
        '
        'lblAktifKategoriEntKod
        '
        Me.lblAktifKategoriEntKod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAktifKategoriEntKod.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lblAktifKategoriEntKod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAktifKategoriEntKod.Location = New System.Drawing.Point(357, 0)
        Me.lblAktifKategoriEntKod.Name = "lblAktifKategoriEntKod"
        Me.lblAktifKategoriEntKod.Size = New System.Drawing.Size(265, 18)
        Me.lblAktifKategoriEntKod.TabIndex = 4
        '
        'lblAktifKategoriKod
        '
        Me.lblAktifKategoriKod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAktifKategoriKod.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lblAktifKategoriKod.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAktifKategoriKod.Location = New System.Drawing.Point(0, 0)
        Me.lblAktifKategoriKod.Name = "lblAktifKategoriKod"
        Me.lblAktifKategoriKod.Size = New System.Drawing.Size(357, 18)
        Me.lblAktifKategoriKod.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(622, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Aktif dal"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(272, 71)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(626, 535)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage10})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.cboSecenekler)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(620, 507)
        Me.XtraTabPage1.Text = "Seçenekler"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cmdOzellikleriEkle)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 472)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(620, 35)
        Me.PanelControl2.TabIndex = 3
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.panelParametreler)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(620, 507)
        Me.XtraTabPage2.Text = "Uygulama"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.SplitContainer1)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(620, 507)
        Me.XtraTabPage3.Text = "Fiyatlar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.panelKendiFiyatBeden)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grEkMasraflar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelKendiMasraf)
        Me.SplitContainer1.Size = New System.Drawing.Size(620, 467)
        Me.SplitContainer1.SplitterDistance = 317
        Me.SplitContainer1.TabIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.GridControl1.DataSource = Me.tbKategoriFiyat
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Enabled = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 44)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkGridBazBedenMi})
        Me.GridControl1.Size = New System.Drawing.Size(317, 423)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoveUp, Me.mnuMoveDown, Me.ToolStripMenuItem3, Me.mnuFiyatSil})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(131, 76)
        '
        'mnuMoveUp
        '
        Me.mnuMoveUp.Name = "mnuMoveUp"
        Me.mnuMoveUp.Size = New System.Drawing.Size(130, 22)
        Me.mnuMoveUp.Text = "Yukarı Taşı"
        '
        'mnuMoveDown
        '
        Me.mnuMoveDown.Name = "mnuMoveDown"
        Me.mnuMoveDown.Size = New System.Drawing.Size(130, 22)
        Me.mnuMoveDown.Text = "Aşağı Taşı"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(127, 6)
        '
        'mnuFiyatSil
        '
        Me.mnuFiyatSil.Name = "mnuFiyatSil"
        Me.mnuFiyatSil.Size = New System.Drawing.Size(130, 22)
        Me.mnuFiyatSil.Text = "Sil"
        '
        'tbKategoriFiyat
        '
        Me.tbKategoriFiyat.Columns.AddRange(New System.Data.DataColumn() {Me.tbKategoriFiyat_KategoriFiyatID, Me.tbKategoriFiyat_Deleted, Me.tbKategoriFiyat_CreatedBy, Me.tbKategoriFiyat_CreatedDate, Me.tbKategoriFiyat_ModifiedBy, Me.tbKategoriFiyat_ModifiedDate, Me.tbKategoriFiyat_KategoriID, Me.tbKategoriFiyat_BedenNo, Me.tbKategoriFiyat_BedenKod, Me.tbKategoriFiyat_Fiyat, Me.tbKategoriFiyat_BazBedenMi})
        Me.tbKategoriFiyat.Connection = Me.FirmConn
        Me.tbKategoriFiyat.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriFiyatID"}, True)})
        Me.tbKategoriFiyat.CurrentRow = Nothing
        Me.tbKategoriFiyat.DataSourceLink = Nothing
        Me.tbKategoriFiyat.DeleteCommand = Me.SqlCommand12
        Me.tbKategoriFiyat.Filter = ""
        Me.tbKategoriFiyat.InsertCommand = Me.SqlCommand10
        Me.tbKategoriFiyat.LiveSave = False
        Me.tbKategoriFiyat.MaxRecords = CType(0, Long)
        Me.tbKategoriFiyat.Name = "tbKategoriFiyat"
        Me.tbKategoriFiyat.ParentRelation_ChildColumns = Nothing
        Me.tbKategoriFiyat.ParentRelation_ParentColumns = Nothing
        Me.tbKategoriFiyat.ParentRelation_Table = Nothing
        Me.tbKategoriFiyat.Position = CType(-1, Long)
        Me.tbKategoriFiyat.PrimaryKey = New System.Data.DataColumn() {Me.tbKategoriFiyat_KategoriFiyatID}
        Me.tbKategoriFiyat.Quoted = False
        Me.tbKategoriFiyat.SelectCommand = Me.SqlCommand9
        Me.tbKategoriFiyat.TableName = "NeoTable1"
        Me.tbKategoriFiyat.Transaction = Nothing
        Me.tbKategoriFiyat.UpdateCommand = Me.SqlCommand11
        '
        'tbKategoriFiyat_KategoriFiyatID
        '
        Me.tbKategoriFiyat_KategoriFiyatID.AllowDBNull = False
        Me.tbKategoriFiyat_KategoriFiyatID.AutoIncrement = True
        Me.tbKategoriFiyat_KategoriFiyatID.ColumnName = "KategoriFiyatID"
        Me.tbKategoriFiyat_KategoriFiyatID.DataType = GetType(Integer)
        '
        'tbKategoriFiyat_Deleted
        '
        Me.tbKategoriFiyat_Deleted.ColumnName = "Deleted"
        Me.tbKategoriFiyat_Deleted.DataType = GetType(Integer)
        '
        'tbKategoriFiyat_CreatedBy
        '
        Me.tbKategoriFiyat_CreatedBy.ColumnName = "CreatedBy"
        Me.tbKategoriFiyat_CreatedBy.DataType = GetType(Integer)
        '
        'tbKategoriFiyat_CreatedDate
        '
        Me.tbKategoriFiyat_CreatedDate.ColumnName = "CreatedDate"
        Me.tbKategoriFiyat_CreatedDate.DataType = GetType(Date)
        '
        'tbKategoriFiyat_ModifiedBy
        '
        Me.tbKategoriFiyat_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbKategoriFiyat_ModifiedBy.DataType = GetType(Integer)
        '
        'tbKategoriFiyat_ModifiedDate
        '
        Me.tbKategoriFiyat_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbKategoriFiyat_ModifiedDate.DataType = GetType(Date)
        '
        'tbKategoriFiyat_KategoriID
        '
        Me.tbKategoriFiyat_KategoriID.ColumnName = "KategoriID"
        Me.tbKategoriFiyat_KategoriID.DataType = GetType(Integer)
        '
        'tbKategoriFiyat_BedenNo
        '
        Me.tbKategoriFiyat_BedenNo.ColumnName = "BedenNo"
        Me.tbKategoriFiyat_BedenNo.DataType = GetType(Integer)
        '
        'tbKategoriFiyat_BedenKod
        '
        Me.tbKategoriFiyat_BedenKod.ColumnName = "BedenKod"
        '
        'tbKategoriFiyat_Fiyat
        '
        Me.tbKategoriFiyat_Fiyat.ColumnName = "Fiyat"
        Me.tbKategoriFiyat_Fiyat.DataType = GetType(Double)
        '
        'tbKategoriFiyat_BazBedenMi
        '
        Me.tbKategoriFiyat_BazBedenMi.ColumnName = "BazBedenMi"
        Me.tbKategoriFiyat_BazBedenMi.DataType = GetType(Integer)
        '
        'SqlCommand12
        '
        Me.SqlCommand12.CommandText = "UPDATE KategoriFiyat SET Deleted = KategoriFiyatID  , ModifiedBy = @ModifiedBy , " &
    "ModifiedDate = GETDATE()   WHERE KategoriFiyatID = @KategoriFiyatID"
        '
        'SqlCommand10
        '
        Me.SqlCommand10.CommandText = resources.GetString("SqlCommand10.CommandText")
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT * FROM KategoriFiyat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 AND KategoriID = @KategoriID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORD" &
    "ER BY BedenNo"
        Me.SqlCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@KategoriID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand11
        '
        Me.SqlCommand11.CommandText = resources.GetString("SqlCommand11.CommandText")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKategoriFiyatID, Me.colKategoriID, Me.colDeleted, Me.colBedenNo, Me.colBedenKod, Me.colFiyat, Me.colBazBedenMi})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colKategoriFiyatID
        '
        Me.colKategoriFiyatID.FieldName = "KategoriFiyatID"
        Me.colKategoriFiyatID.Name = "colKategoriFiyatID"
        '
        'colKategoriID
        '
        Me.colKategoriID.FieldName = "KategoriID"
        Me.colKategoriID.Name = "colKategoriID"
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colBedenNo
        '
        Me.colBedenNo.FieldName = "BedenNo"
        Me.colBedenNo.Name = "colBedenNo"
        Me.colBedenNo.OptionsColumn.AllowEdit = False
        Me.colBedenNo.Width = 58
        '
        'colBedenKod
        '
        Me.colBedenKod.FieldName = "BedenKod"
        Me.colBedenKod.Name = "colBedenKod"
        Me.colBedenKod.Visible = True
        Me.colBedenKod.VisibleIndex = 0
        Me.colBedenKod.Width = 88
        '
        'colFiyat
        '
        Me.colFiyat.DisplayFormat.FormatString = "#,##0.00"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 1
        '
        'colBazBedenMi
        '
        Me.colBazBedenMi.AppearanceHeader.Options.UseTextOptions = True
        Me.colBazBedenMi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBazBedenMi.Caption = "Baz?"
        Me.colBazBedenMi.ColumnEdit = Me.chkGridBazBedenMi
        Me.colBazBedenMi.FieldName = "BazBedenMi"
        Me.colBazBedenMi.Name = "colBazBedenMi"
        Me.colBazBedenMi.Visible = True
        Me.colBazBedenMi.VisibleIndex = 2
        Me.colBazBedenMi.Width = 40
        '
        'chkGridBazBedenMi
        '
        Me.chkGridBazBedenMi.AutoHeight = False
        Me.chkGridBazBedenMi.Caption = "Check"
        Me.chkGridBazBedenMi.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.chkGridBazBedenMi.Name = "chkGridBazBedenMi"
        Me.chkGridBazBedenMi.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkGridBazBedenMi.ValueChecked = 1
        Me.chkGridBazBedenMi.ValueUnchecked = 0
        '
        'panelKendiFiyatBeden
        '
        Me.panelKendiFiyatBeden.Controls.Add(Me.chkKategori_KendiFiyatBeden)
        Me.panelKendiFiyatBeden.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelKendiFiyatBeden.Location = New System.Drawing.Point(0, 0)
        Me.panelKendiFiyatBeden.Name = "panelKendiFiyatBeden"
        Me.panelKendiFiyatBeden.Size = New System.Drawing.Size(317, 44)
        Me.panelKendiFiyatBeden.TabIndex = 1
        Me.panelKendiFiyatBeden.Visible = False
        '
        'chkKategori_KendiFiyatBeden
        '
        Me.chkKategori_KendiFiyatBeden.AutoSize = True
        Me.chkKategori_KendiFiyatBeden.Location = New System.Drawing.Point(7, 10)
        Me.chkKategori_KendiFiyatBeden.Name = "chkKategori_KendiFiyatBeden"
        Me.chkKategori_KendiFiyatBeden.Size = New System.Drawing.Size(229, 17)
        Me.chkKategori_KendiFiyatBeden.TabIndex = 0
        Me.chkKategori_KendiFiyatBeden.Text = "Bu urun kendi fiyat ve bedenlerini kullansin"
        Me.chkKategori_KendiFiyatBeden.UseVisualStyleBackColor = True
        '
        'grEkMasraflar
        '
        Me.grEkMasraflar.DataSource = Me.tbKategoriEkFiyat
        Me.grEkMasraflar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grEkMasraflar.Enabled = False
        Me.grEkMasraflar.Location = New System.Drawing.Point(0, 44)
        Me.grEkMasraflar.MainView = Me.grEkMasraflarView
        Me.grEkMasraflar.Name = "grEkMasraflar"
        Me.grEkMasraflar.Size = New System.Drawing.Size(299, 423)
        Me.grEkMasraflar.TabIndex = 5
        Me.grEkMasraflar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grEkMasraflarView})
        '
        'tbKategoriEkFiyat
        '
        Me.tbKategoriEkFiyat.Columns.AddRange(New System.Data.DataColumn() {Me.tbKategoriEkFiyat_KategoriEkFiyatID, Me.tbKategoriEkFiyat_Deleted, Me.tbKategoriEkFiyat_CreatedBy, Me.tbKategoriEkFiyat_CreatedDate, Me.tbKategoriEkFiyat_ModifiedBy, Me.tbKategoriEkFiyat_ModifiedDate, Me.tbKategoriEkFiyat_KategoriID, Me.tbKategoriEkFiyat_MasrafKod, Me.tbKategoriEkFiyat_MasrafIsmi, Me.tbKategoriEkFiyat_Fiyat, Me.tbKategoriEkFiyat_BedenArtis})
        Me.tbKategoriEkFiyat.Connection = Me.FirmConn
        Me.tbKategoriEkFiyat.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriEkFiyatID"}, True)})
        Me.tbKategoriEkFiyat.CurrentRow = Nothing
        Me.tbKategoriEkFiyat.DataSourceLink = Nothing
        Me.tbKategoriEkFiyat.DeleteCommand = Me.SqlCommand20
        Me.tbKategoriEkFiyat.Filter = ""
        Me.tbKategoriEkFiyat.InsertCommand = Me.SqlCommand18
        Me.tbKategoriEkFiyat.LiveSave = False
        Me.tbKategoriEkFiyat.MaxRecords = CType(0, Long)
        Me.tbKategoriEkFiyat.Name = "tbKategoriEkFiyat"
        Me.tbKategoriEkFiyat.ParentRelation_ChildColumns = Nothing
        Me.tbKategoriEkFiyat.ParentRelation_ParentColumns = Nothing
        Me.tbKategoriEkFiyat.ParentRelation_Table = Nothing
        Me.tbKategoriEkFiyat.Position = CType(-1, Long)
        Me.tbKategoriEkFiyat.PrimaryKey = New System.Data.DataColumn() {Me.tbKategoriEkFiyat_KategoriEkFiyatID}
        Me.tbKategoriEkFiyat.Quoted = False
        Me.tbKategoriEkFiyat.SelectCommand = Me.SqlCommand17
        Me.tbKategoriEkFiyat.TableName = "NeoTable1"
        Me.tbKategoriEkFiyat.Transaction = Nothing
        Me.tbKategoriEkFiyat.UpdateCommand = Me.SqlCommand19
        '
        'tbKategoriEkFiyat_KategoriEkFiyatID
        '
        Me.tbKategoriEkFiyat_KategoriEkFiyatID.AllowDBNull = False
        Me.tbKategoriEkFiyat_KategoriEkFiyatID.AutoIncrement = True
        Me.tbKategoriEkFiyat_KategoriEkFiyatID.ColumnName = "KategoriEkFiyatID"
        Me.tbKategoriEkFiyat_KategoriEkFiyatID.DataType = GetType(Integer)
        '
        'tbKategoriEkFiyat_Deleted
        '
        Me.tbKategoriEkFiyat_Deleted.ColumnName = "Deleted"
        Me.tbKategoriEkFiyat_Deleted.DataType = GetType(Integer)
        '
        'tbKategoriEkFiyat_CreatedBy
        '
        Me.tbKategoriEkFiyat_CreatedBy.ColumnName = "CreatedBy"
        Me.tbKategoriEkFiyat_CreatedBy.DataType = GetType(Integer)
        '
        'tbKategoriEkFiyat_CreatedDate
        '
        Me.tbKategoriEkFiyat_CreatedDate.ColumnName = "CreatedDate"
        Me.tbKategoriEkFiyat_CreatedDate.DataType = GetType(Date)
        '
        'tbKategoriEkFiyat_ModifiedBy
        '
        Me.tbKategoriEkFiyat_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbKategoriEkFiyat_ModifiedBy.DataType = GetType(Integer)
        '
        'tbKategoriEkFiyat_ModifiedDate
        '
        Me.tbKategoriEkFiyat_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbKategoriEkFiyat_ModifiedDate.DataType = GetType(Date)
        '
        'tbKategoriEkFiyat_KategoriID
        '
        Me.tbKategoriEkFiyat_KategoriID.ColumnName = "KategoriID"
        Me.tbKategoriEkFiyat_KategoriID.DataType = GetType(Integer)
        '
        'tbKategoriEkFiyat_MasrafKod
        '
        Me.tbKategoriEkFiyat_MasrafKod.ColumnName = "MasrafKod"
        '
        'tbKategoriEkFiyat_MasrafIsmi
        '
        Me.tbKategoriEkFiyat_MasrafIsmi.ColumnName = "MasrafIsmi"
        '
        'tbKategoriEkFiyat_Fiyat
        '
        Me.tbKategoriEkFiyat_Fiyat.ColumnName = "Fiyat"
        Me.tbKategoriEkFiyat_Fiyat.DataType = GetType(Double)
        '
        'tbKategoriEkFiyat_BedenArtis
        '
        Me.tbKategoriEkFiyat_BedenArtis.ColumnName = "BedenArtis"
        Me.tbKategoriEkFiyat_BedenArtis.DataType = GetType(Double)
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = "UPDATE KategoriEkFiyat SET Deleted = KategoriEkFiyatID  , ModifiedBy = @ModifiedB" &
    "y , ModifiedDate = GETDATE()   WHERE KategoriEkFiyatID = @KategoriEkFiyatID"
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = resources.GetString("SqlCommand18.CommandText")
        Me.SqlCommand18.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KategoriEkFiyatID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT * FROM KategoriEkFiyat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 AND KategoriID = @KategoriID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OR" &
    "DER BY MasrafKod"
        Me.SqlCommand17.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@KategoriID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = resources.GetString("SqlCommand19.CommandText")
        '
        'grEkMasraflarView
        '
        Me.grEkMasraflarView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colMasrafKod, Me.colKategoriID1, Me.colKategoriEkFiyatID, Me.colDeleted2})
        Me.grEkMasraflarView.GridControl = Me.grEkMasraflar
        Me.grEkMasraflarView.Name = "grEkMasraflarView"
        Me.grEkMasraflarView.OptionsCustomization.AllowFilter = False
        Me.grEkMasraflarView.OptionsCustomization.AllowGroup = False
        Me.grEkMasraflarView.OptionsCustomization.AllowQuickHideColumns = False
        Me.grEkMasraflarView.OptionsCustomization.AllowSort = False
        Me.grEkMasraflarView.OptionsView.ColumnAutoWidth = False
        Me.grEkMasraflarView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Masraf Ismi"
        Me.GridColumn1.FieldName = "MasrafIsmi"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 118
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fiyat"
        Me.GridColumn2.FieldName = "Fiyat"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Beden Artis"
        Me.GridColumn3.FieldName = "BedenArtis"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'colMasrafKod
        '
        Me.colMasrafKod.FieldName = "MasrafKod"
        Me.colMasrafKod.Name = "colMasrafKod"
        '
        'colKategoriID1
        '
        Me.colKategoriID1.FieldName = "KategoriID"
        Me.colKategoriID1.Name = "colKategoriID1"
        '
        'colKategoriEkFiyatID
        '
        Me.colKategoriEkFiyatID.FieldName = "KategoriEkFiyatID"
        Me.colKategoriEkFiyatID.Name = "colKategoriEkFiyatID"
        '
        'colDeleted2
        '
        Me.colDeleted2.FieldName = "Deleted"
        Me.colDeleted2.Name = "colDeleted2"
        '
        'panelKendiMasraf
        '
        Me.panelKendiMasraf.Controls.Add(Me.chkKategori_KendiMasraf)
        Me.panelKendiMasraf.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelKendiMasraf.Location = New System.Drawing.Point(0, 0)
        Me.panelKendiMasraf.Name = "panelKendiMasraf"
        Me.panelKendiMasraf.Size = New System.Drawing.Size(299, 44)
        Me.panelKendiMasraf.TabIndex = 6
        Me.panelKendiMasraf.Visible = False
        '
        'chkKategori_KendiMasraf
        '
        Me.chkKategori_KendiMasraf.AutoSize = True
        Me.chkKategori_KendiMasraf.Location = New System.Drawing.Point(12, 10)
        Me.chkKategori_KendiMasraf.Name = "chkKategori_KendiMasraf"
        Me.chkKategori_KendiMasraf.Size = New System.Drawing.Size(221, 17)
        Me.chkKategori_KendiMasraf.TabIndex = 1
        Me.chkKategori_KendiMasraf.Text = "Bu urun kendi masraf tanimlarini kullansin"
        Me.chkKategori_KendiMasraf.UseVisualStyleBackColor = True
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.cmdKaydetFiyat)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl7.Location = New System.Drawing.Point(0, 467)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(620, 40)
        Me.PanelControl7.TabIndex = 4
        '
        'cmdKaydetFiyat
        '
        Me.cmdKaydetFiyat.Location = New System.Drawing.Point(7, 4)
        Me.cmdKaydetFiyat.Name = "cmdKaydetFiyat"
        Me.cmdKaydetFiyat.Size = New System.Drawing.Size(129, 26)
        Me.cmdKaydetFiyat.TabIndex = 1
        Me.cmdKaydetFiyat.Text = "Fiyatları Kaydet"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage4.Controls.Add(Me.SplitterControl4)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl12)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(620, 507)
        Me.XtraTabPage4.Text = "Sipariş Tamamla"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 123)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl2.Size = New System.Drawing.Size(620, 384)
        Me.XtraTabControl2.TabIndex = 6
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage9})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.grFiyatlar)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl10)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(614, 356)
        Me.XtraTabPage5.Text = "Adetler/Fiyatlar"
        '
        'grFiyatlar
        '
        Me.grFiyatlar.DataSource = Me.tbSipDetayFiyatlar
        Me.grFiyatlar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grFiyatlar.Location = New System.Drawing.Point(0, 37)
        Me.grFiyatlar.MainView = Me.grFiyatlarView
        Me.grFiyatlar.Name = "grFiyatlar"
        Me.grFiyatlar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboRenkler})
        Me.grFiyatlar.Size = New System.Drawing.Size(614, 283)
        Me.grFiyatlar.TabIndex = 4
        Me.grFiyatlar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grFiyatlarView, Me.GridView3})
        '
        'tbSipDetayFiyatlar
        '
        Me.tbSipDetayFiyatlar.Columns.AddRange(New System.Data.DataColumn() {Me.tbSipDetayFiyatlar_BedenNo, Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID, Me.tbSipDetayFiyatlar_Deleted, Me.tbSipDetayFiyatlar_CreatedBy, Me.tbSipDetayFiyatlar_CreatedDate, Me.tbSipDetayFiyatlar_ModifiedBy, Me.tbSipDetayFiyatlar_ModifiedDate, Me.tbSipDetayFiyatlar_SipDetayID, Me.tbSipDetayFiyatlar_BedenKod, Me.tbSipDetayFiyatlar_BazFiyat, Me.tbSipDetayFiyatlar_BrutFiyat, Me.tbSipDetayFiyatlar_Iskonto, Me.tbSipDetayFiyatlar_NakitIskonto, Me.tbSipDetayFiyatlar_NetFiyat, Me.tbSipDetayFiyatlar_Miktar, Me.tbSipDetayFiyatlar_Tutar, Me.tbSipDetayFiyatlar_KategoriFiyatID, Me.tbSipDetayFiyatlar_DetayAciklama, Me.tbSipDetayFiyatlar_RenkKod, Me.tbSipDetayFiyatlar_BdnHarNo, Me.tbSipDetayFiyatlar_TeslimMiktar, Me.tbSipDetayFiyatlar_sip_RECno, Me.tbSipDetayFiyatlar_sip_evrakno_seri, Me.tbSipDetayFiyatlar_sip_evrakno_sira, Me.tbSipDetayFiyatlar_sip_satirno, Me.tbSipDetayFiyatlar_Hazirlanan, Me.tbSipDetayFiyatlar_sip_Guid})
        Me.tbSipDetayFiyatlar.Connection = Me.FirmConn
        Me.tbSipDetayFiyatlar.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SipDetayFiyatAdetID"}, True)})
        Me.tbSipDetayFiyatlar.CurrentRow = Nothing
        Me.tbSipDetayFiyatlar.DataSourceLink = Nothing
        Me.tbSipDetayFiyatlar.DeleteCommand = Me.SqlCommand16
        Me.tbSipDetayFiyatlar.Filter = ""
        Me.tbSipDetayFiyatlar.InsertCommand = Me.SqlCommand14
        Me.tbSipDetayFiyatlar.LiveSave = False
        Me.tbSipDetayFiyatlar.MaxRecords = CType(0, Long)
        Me.tbSipDetayFiyatlar.Name = "tbSipDetayFiyatlar"
        Me.tbSipDetayFiyatlar.ParentRelation_ChildColumns = Nothing
        Me.tbSipDetayFiyatlar.ParentRelation_ParentColumns = Nothing
        Me.tbSipDetayFiyatlar.ParentRelation_Table = Nothing
        Me.tbSipDetayFiyatlar.Position = CType(-1, Long)
        Me.tbSipDetayFiyatlar.PrimaryKey = New System.Data.DataColumn() {Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID}
        Me.tbSipDetayFiyatlar.Quoted = False
        Me.tbSipDetayFiyatlar.SelectCommand = Me.SqlCommand13
        Me.tbSipDetayFiyatlar.TableName = "NeoTable1"
        Me.tbSipDetayFiyatlar.Transaction = Nothing
        Me.tbSipDetayFiyatlar.UpdateCommand = Me.SqlCommand15
        '
        'SqlCommand16
        '
        Me.SqlCommand16.CommandText = "UPDATE SipDetayFiyatlar SET Deleted = SipDetayFiyatAdetID  , ModifiedBy = @Modifi" &
    "edBy , ModifiedDate = GETDATE()   WHERE SipDetayFiyatAdetID = @SipDetayFiyatAdet" &
    "ID"
        '
        'SqlCommand14
        '
        Me.SqlCommand14.CommandText = resources.GetString("SqlCommand14.CommandText")
        Me.SqlCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_SipDetayFiyatAdetID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = resources.GetString("SqlCommand13.CommandText")
        Me.SqlCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SipDetayID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand15
        '
        Me.SqlCommand15.CommandText = resources.GetString("SqlCommand15.CommandText")
        '
        'grFiyatlarView
        '
        Me.grFiyatlarView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSipDetayFiyatAdetID, Me.colDeleted1, Me.colSipDetayID, Me.colBedenKod1, Me.colDetayAciklama, Me.colBazFiyat, Me.colBrutFiyat, Me.colIskonto, Me.colNakitIskonto, Me.colNetFiyat, Me.colMiktar, Me.colTutar, Me.colRenkKod, Me.colBdnHarNo})
        Me.grFiyatlarView.GridControl = Me.grFiyatlar
        Me.grFiyatlarView.Name = "grFiyatlarView"
        Me.grFiyatlarView.OptionsLayout.LayoutVersion = "1.1"
        Me.grFiyatlarView.OptionsView.ColumnAutoWidth = False
        Me.grFiyatlarView.OptionsView.ShowFooter = True
        Me.grFiyatlarView.OptionsView.ShowGroupPanel = False
        '
        'colSipDetayFiyatAdetID
        '
        Me.colSipDetayFiyatAdetID.FieldName = "SipDetayFiyatAdetID"
        Me.colSipDetayFiyatAdetID.Name = "colSipDetayFiyatAdetID"
        '
        'colDeleted1
        '
        Me.colDeleted1.FieldName = "Deleted"
        Me.colDeleted1.Name = "colDeleted1"
        '
        'colSipDetayID
        '
        Me.colSipDetayID.FieldName = "SipDetayID"
        Me.colSipDetayID.Name = "colSipDetayID"
        '
        'colBedenKod1
        '
        Me.colBedenKod1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBedenKod1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBedenKod1.AppearanceCell.Options.UseBackColor = True
        Me.colBedenKod1.FieldName = "BedenKod"
        Me.colBedenKod1.Name = "colBedenKod1"
        Me.colBedenKod1.OptionsColumn.AllowEdit = False
        Me.colBedenKod1.Visible = True
        Me.colBedenKod1.VisibleIndex = 0
        Me.colBedenKod1.Width = 92
        '
        'colDetayAciklama
        '
        Me.colDetayAciklama.Caption = "Açıklama"
        Me.colDetayAciklama.FieldName = "DetayAciklama"
        Me.colDetayAciklama.Name = "colDetayAciklama"
        Me.colDetayAciklama.Visible = True
        Me.colDetayAciklama.VisibleIndex = 1
        Me.colDetayAciklama.Width = 87
        '
        'colBazFiyat
        '
        Me.colBazFiyat.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBazFiyat.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBazFiyat.AppearanceCell.Options.UseBackColor = True
        Me.colBazFiyat.DisplayFormat.FormatString = "#,##0.00"
        Me.colBazFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBazFiyat.FieldName = "BazFiyat"
        Me.colBazFiyat.Name = "colBazFiyat"
        Me.colBazFiyat.OptionsColumn.AllowEdit = False
        Me.colBazFiyat.Visible = True
        Me.colBazFiyat.VisibleIndex = 2
        Me.colBazFiyat.Width = 56
        '
        'colBrutFiyat
        '
        Me.colBrutFiyat.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBrutFiyat.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBrutFiyat.AppearanceCell.Options.UseBackColor = True
        Me.colBrutFiyat.DisplayFormat.FormatString = "#,##0.00"
        Me.colBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBrutFiyat.FieldName = "BrutFiyat"
        Me.colBrutFiyat.Name = "colBrutFiyat"
        Me.colBrutFiyat.OptionsColumn.AllowEdit = False
        Me.colBrutFiyat.Visible = True
        Me.colBrutFiyat.VisibleIndex = 3
        Me.colBrutFiyat.Width = 57
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Sezon Isk. %"
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.OptionsColumn.AllowEdit = False
        Me.colIskonto.Visible = True
        Me.colIskonto.VisibleIndex = 4
        Me.colIskonto.Width = 76
        '
        'colNakitIskonto
        '
        Me.colNakitIskonto.Caption = "Nakit Isk%"
        Me.colNakitIskonto.FieldName = "NakitIskonto"
        Me.colNakitIskonto.Name = "colNakitIskonto"
        Me.colNakitIskonto.OptionsColumn.AllowEdit = False
        Me.colNakitIskonto.Visible = True
        Me.colNakitIskonto.VisibleIndex = 5
        Me.colNakitIskonto.Width = 64
        '
        'colNetFiyat
        '
        Me.colNetFiyat.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNetFiyat.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNetFiyat.AppearanceCell.Options.UseBackColor = True
        Me.colNetFiyat.DisplayFormat.FormatString = "#,##0.00"
        Me.colNetFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNetFiyat.FieldName = "NetFiyat"
        Me.colNetFiyat.Name = "colNetFiyat"
        Me.colNetFiyat.OptionsColumn.AllowEdit = False
        Me.colNetFiyat.Visible = True
        Me.colNetFiyat.VisibleIndex = 6
        Me.colNetFiyat.Width = 62
        '
        'colMiktar
        '
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:0.##}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 7
        Me.colMiktar.Width = 44
        '
        'colTutar
        '
        Me.colTutar.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTutar.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colTutar.AppearanceCell.Options.UseBackColor = True
        Me.colTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.OptionsColumn.AllowEdit = False
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:0.##}")})
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 8
        Me.colTutar.Width = 65
        '
        'colRenkKod
        '
        Me.colRenkKod.ColumnEdit = Me.cboRenkler
        Me.colRenkKod.FieldName = "RenkKod"
        Me.colRenkKod.Name = "colRenkKod"
        Me.colRenkKod.Visible = True
        Me.colRenkKod.VisibleIndex = 9
        '
        'cboRenkler
        '
        Me.cboRenkler.AutoHeight = False
        Me.cboRenkler.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRenkler.Name = "cboRenkler"
        '
        'colBdnHarNo
        '
        Me.colBdnHarNo.FieldName = "BdnHarNo"
        Me.colBdnHarNo.Name = "colBdnHarNo"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSipDetayFiyatAdetID, Me.colDeleted1, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colSipDetayID, Me.colBedenKod1, Me.colBazFiyat, Me.colBrutFiyat, Me.colIskonto, Me.colNakitIskonto, Me.colNetFiyat, Me.colMiktar, Me.colTutar, Me.colKategoriFiyatID1})
        Me.GridView3.GridControl = Me.grFiyatlar
        Me.GridView3.Name = "GridView3"
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        Me.colCreatedBy.Visible = True
        Me.colCreatedBy.VisibleIndex = 1
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 9
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 10
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Visible = True
        Me.colModifiedDate.VisibleIndex = 11
        '
        'colKategoriFiyatID1
        '
        Me.colKategoriFiyatID1.FieldName = "KategoriFiyatID"
        Me.colKategoriFiyatID1.Name = "colKategoriFiyatID1"
        Me.colKategoriFiyatID1.Visible = True
        Me.colKategoriFiyatID1.VisibleIndex = 12
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.chkSerbestFiyat)
        Me.PanelControl10.Controls.Add(Me.cmdGeri)
        Me.PanelControl10.Controls.Add(Me.PanelControl8)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl10.Location = New System.Drawing.Point(0, 320)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(614, 36)
        Me.PanelControl10.TabIndex = 6
        '
        'chkSerbestFiyat
        '
        Me.chkSerbestFiyat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "bSerbestFiyat", True))
        Me.chkSerbestFiyat.Location = New System.Drawing.Point(145, 9)
        Me.chkSerbestFiyat.Name = "chkSerbestFiyat"
        Me.chkSerbestFiyat.Properties.Caption = "Serbest Fiyat(Eski Fiyat)"
        Me.chkSerbestFiyat.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkSerbestFiyat.Properties.ValueChecked = 1
        Me.chkSerbestFiyat.Properties.ValueUnchecked = 0
        Me.chkSerbestFiyat.Size = New System.Drawing.Size(151, 19)
        Me.chkSerbestFiyat.TabIndex = 6
        '
        'cmdGeri
        '
        Me.cmdGeri.Location = New System.Drawing.Point(5, 4)
        Me.cmdGeri.Name = "cmdGeri"
        Me.cmdGeri.Size = New System.Drawing.Size(88, 28)
        Me.cmdGeri.TabIndex = 1
        Me.cmdGeri.Text = "<< Geri"
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Controls.Add(Me.SimpleButton1)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl8.Location = New System.Drawing.Point(478, 2)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(134, 32)
        Me.PanelControl8.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(9, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 28)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Sipariş Bilgileri >>"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.lblOkulFarki)
        Me.PanelControl9.Controls.Add(Me.LabelControl20)
        Me.PanelControl9.Controls.Add(Me.cmdIskontoUygula)
        Me.PanelControl9.Controls.Add(Me.txtNakitIskonto)
        Me.PanelControl9.Controls.Add(Me.LabelControl17)
        Me.PanelControl9.Controls.Add(Me.txtIskonto)
        Me.PanelControl9.Controls.Add(Me.LabelControl16)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(614, 37)
        Me.PanelControl9.TabIndex = 5
        '
        'lblOkulFarki
        '
        Me.lblOkulFarki.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblOkulFarki.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.tbSipDetay, "OkulFarki", True))
        Me.lblOkulFarki.Location = New System.Drawing.Point(449, 11)
        Me.lblOkulFarki.Name = "lblOkulFarki"
        Me.lblOkulFarki.Size = New System.Drawing.Size(10, 19)
        Me.lblOkulFarki.TabIndex = 6
        Me.lblOkulFarki.Text = "0"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(367, 14)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl20.TabIndex = 5
        Me.LabelControl20.Text = "Okul Farkı (%) :"
        '
        'cmdIskontoUygula
        '
        Me.cmdIskontoUygula.Location = New System.Drawing.Point(500, 4)
        Me.cmdIskontoUygula.Name = "cmdIskontoUygula"
        Me.cmdIskontoUygula.Size = New System.Drawing.Size(119, 28)
        Me.cmdIskontoUygula.TabIndex = 4
        Me.cmdIskontoUygula.Text = "Iskonto uygula"
        '
        'txtNakitIskonto
        '
        Me.txtNakitIskonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "NakitIskonto", True))
        Me.txtNakitIskonto.EnterMoveNextControl = True
        Me.txtNakitIskonto.Location = New System.Drawing.Point(298, 12)
        Me.txtNakitIskonto.Name = "txtNakitIskonto"
        Me.txtNakitIskonto.Size = New System.Drawing.Size(62, 20)
        Me.txtNakitIskonto.TabIndex = 3
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(180, 16)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl17.TabIndex = 2
        Me.LabelControl17.Text = "Nakit/Diğer Iskonto (%)"
        '
        'txtIskonto
        '
        Me.txtIskonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Iskonto", True))
        Me.txtIskonto.EnterMoveNextControl = True
        Me.txtIskonto.Location = New System.Drawing.Point(104, 12)
        Me.txtIskonto.Name = "txtIskonto"
        Me.txtIskonto.Size = New System.Drawing.Size(62, 20)
        Me.txtIskonto.TabIndex = 1
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(7, 16)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl16.TabIndex = 0
        Me.LabelControl16.Text = "Sezon Iskonto (%)"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.cmdMikroStokKod)
        Me.XtraTabPage6.Controls.Add(Me.TextEdit5)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage6.Controls.Add(Me.TextEdit2)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage6.Controls.Add(Me.PictureEdit10)
        Me.XtraTabPage6.Controls.Add(Me.cboBolumKod)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage6.Controls.Add(Me.cboOkul)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage6.Controls.Add(Me.TextEdit4)
        Me.XtraTabPage6.Controls.Add(Me.TextEdit3)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage6.Controls.Add(Me.MemoEdit1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage6.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage6.Controls.Add(Me.DateEdit2)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage6.Controls.Add(Me.DateEdit1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage6.Controls.Add(Me.txtMusteri)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl11)
        Me.XtraTabPage6.Controls.Add(Me.PictureEdit9)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(614, 356)
        Me.XtraTabPage6.Text = "Sipariş Bilgileri"
        '
        'cmdMikroStokKod
        '
        Me.cmdMikroStokKod.Location = New System.Drawing.Point(393, 191)
        Me.cmdMikroStokKod.Name = "cmdMikroStokKod"
        Me.cmdMikroStokKod.Size = New System.Drawing.Size(39, 29)
        Me.cmdMikroStokKod.TabIndex = 107
        Me.cmdMikroStokKod.Text = "..."
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "StokIsmi", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(111, 214)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(276, 20)
        Me.TextEdit5.TabIndex = 7
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(7, 217)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl19.TabIndex = 106
        Me.LabelControl19.Text = "Mikro Stok Ismi"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "StokKod", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(111, 191)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(276, 20)
        Me.TextEdit2.TabIndex = 6
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(7, 194)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl18.TabIndex = 104
        Me.LabelControl18.Text = "Mikro Stok Kod"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(498, 207)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl15.TabIndex = 103
        Me.LabelControl15.Text = "Resim 2"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(498, 64)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl14.TabIndex = 102
        Me.LabelControl14.Text = "Resim 1"
        '
        'PictureEdit10
        '
        Me.PictureEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim1", True))
        Me.PictureEdit10.Location = New System.Drawing.Point(498, 77)
        Me.PictureEdit10.Name = "PictureEdit10"
        Me.PictureEdit10.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit10.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit10.Size = New System.Drawing.Size(137, 124)
        Me.PictureEdit10.TabIndex = 100
        '
        'cboBolumKod
        '
        Me.cboBolumKod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "BolumKod", True))
        Me.cboBolumKod.EnterMoveNextControl = True
        Me.cboBolumKod.Location = New System.Drawing.Point(111, 60)
        Me.cboBolumKod.Name = "cboBolumKod"
        Me.cboBolumKod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBolumKod.Properties.Items.AddRange(New Object() {"1. (4)", "2. (4+4)", "3. (4+4+4)", "4. Diger"})
        Me.cboBolumKod.Size = New System.Drawing.Size(101, 20)
        Me.cboBolumKod.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(7, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Bölüm (4+4+4)"
        '
        'cboOkul
        '
        Me.cboOkul.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "OkulID", True))
        Me.cboOkul.EnterMoveNextControl = True
        Me.cboOkul.Location = New System.Drawing.Point(111, 34)
        Me.cboOkul.Name = "cboOkul"
        Me.cboOkul.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboOkul.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboOkul.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOkul.Properties.DataSource = Me.tbOkul
        Me.cboOkul.Properties.DisplayMember = "DisplayText"
        Me.cboOkul.Properties.NullText = ""
        Me.cboOkul.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboOkul.Properties.ValueMember = "OkulID"
        Me.cboOkul.Properties.View = Me.GridLookUpEdit1View
        Me.cboOkul.Size = New System.Drawing.Size(499, 20)
        Me.cboOkul.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOkulID, Me.colOkulKod, Me.colOkulIsmi, Me.colIlIsmi, Me.colIlceIsmi})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOkulID
        '
        Me.colOkulID.FieldName = "OkulID"
        Me.colOkulID.Name = "colOkulID"
        '
        'colOkulKod
        '
        Me.colOkulKod.FieldName = "OkulKod"
        Me.colOkulKod.Name = "colOkulKod"
        Me.colOkulKod.Visible = True
        Me.colOkulKod.VisibleIndex = 0
        Me.colOkulKod.Width = 102
        '
        'colOkulIsmi
        '
        Me.colOkulIsmi.FieldName = "OkulIsmi"
        Me.colOkulIsmi.Name = "colOkulIsmi"
        Me.colOkulIsmi.Visible = True
        Me.colOkulIsmi.VisibleIndex = 1
        Me.colOkulIsmi.Width = 331
        '
        'colIlIsmi
        '
        Me.colIlIsmi.FieldName = "IlIsmi"
        Me.colIlIsmi.Name = "colIlIsmi"
        Me.colIlIsmi.Visible = True
        Me.colIlIsmi.VisibleIndex = 2
        Me.colIlIsmi.Width = 109
        '
        'colIlceIsmi
        '
        Me.colIlceIsmi.FieldName = "IlceIsmi"
        Me.colIlceIsmi.Name = "colIlceIsmi"
        Me.colIlceIsmi.Visible = True
        Me.colIlceIsmi.VisibleIndex = 3
        Me.colIlceIsmi.Width = 124
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(7, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Okul"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Tutar", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(111, 262)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(116, 22)
        Me.TextEdit4.TabIndex = 9
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Miktar", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(111, 236)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(116, 20)
        Me.TextEdit3.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(7, 265)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl10.TabIndex = 12
        Me.LabelControl10.Text = "Tutar"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(7, 239)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl9.TabIndex = 11
        Me.LabelControl9.Text = "Toplam Miktar"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "SiparisAciklama", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(111, 151)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.MaxLength = 100
        Me.MemoEdit1.Size = New System.Drawing.Size(267, 34)
        Me.MemoEdit1.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(7, 154)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Açıklama"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "MusteriSipNo", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(111, 125)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(238, 20)
        Me.TextEdit1.TabIndex = 4
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(7, 132)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Müşteri Sipariş No"
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "TerminTarihi", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(333, 102)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(126, 20)
        Me.DateEdit2.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(266, 105)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Termin Tarihi"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Tarih", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(111, 102)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(126, 20)
        Me.DateEdit1.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(7, 105)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Sipariş Tarihi"
        '
        'txtMusteri
        '
        Me.txtMusteri.EnterMoveNextControl = True
        Me.txtMusteri.Location = New System.Drawing.Point(111, 8)
        Me.txtMusteri.Name = "txtMusteri"
        Me.txtMusteri.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtMusteri.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMusteri.Properties.Appearance.Options.UseBackColor = True
        Me.txtMusteri.Properties.Appearance.Options.UseFont = True
        Me.txtMusteri.Size = New System.Drawing.Size(499, 20)
        Me.txtMusteri.TabIndex = 99
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Müşteri"
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.cmdGeri_AdetlerFiyatlar)
        Me.PanelControl11.Controls.Add(Me.cmdSaveOzellik)
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl11.Location = New System.Drawing.Point(0, 318)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(614, 38)
        Me.PanelControl11.TabIndex = 10
        '
        'cmdGeri_AdetlerFiyatlar
        '
        Me.cmdGeri_AdetlerFiyatlar.Location = New System.Drawing.Point(7, 4)
        Me.cmdGeri_AdetlerFiyatlar.Name = "cmdGeri_AdetlerFiyatlar"
        Me.cmdGeri_AdetlerFiyatlar.Size = New System.Drawing.Size(102, 31)
        Me.cmdGeri_AdetlerFiyatlar.TabIndex = 1
        Me.cmdGeri_AdetlerFiyatlar.Text = "<< Geri"
        '
        'cmdSaveOzellik
        '
        Me.cmdSaveOzellik.Location = New System.Drawing.Point(125, 4)
        Me.cmdSaveOzellik.Name = "cmdSaveOzellik"
        Me.cmdSaveOzellik.Size = New System.Drawing.Size(102, 31)
        Me.cmdSaveOzellik.TabIndex = 0
        Me.cmdSaveOzellik.Text = "(F2) Kaydet"
        '
        'PictureEdit9
        '
        Me.PictureEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim2", True))
        Me.PictureEdit9.Location = New System.Drawing.Point(498, 217)
        Me.PictureEdit9.Name = "PictureEdit9"
        Me.PictureEdit9.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit9.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit9.Size = New System.Drawing.Size(137, 124)
        Me.PictureEdit9.TabIndex = 101
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.XtraScrollableControl2)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(614, 356)
        Me.XtraTabPage9.Text = "Sipariş Resimleri"
        '
        'XtraScrollableControl2
        '
        Me.XtraScrollableControl2.Controls.Add(Me.PictureEdit7)
        Me.XtraScrollableControl2.Controls.Add(Me.PictureEdit8)
        Me.XtraScrollableControl2.Controls.Add(Me.PictureEdit6)
        Me.XtraScrollableControl2.Controls.Add(Me.PictureEdit5)
        Me.XtraScrollableControl2.Controls.Add(Me.PictureEdit4)
        Me.XtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl2.Name = "XtraScrollableControl2"
        Me.XtraScrollableControl2.Size = New System.Drawing.Size(614, 356)
        Me.XtraScrollableControl2.TabIndex = 3
        '
        'PictureEdit7
        '
        Me.PictureEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim5", True))
        Me.PictureEdit7.Location = New System.Drawing.Point(997, 14)
        Me.PictureEdit7.Name = "PictureEdit7"
        Me.PictureEdit7.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit7.Size = New System.Drawing.Size(243, 249)
        Me.PictureEdit7.TabIndex = 4
        '
        'PictureEdit8
        '
        Me.PictureEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim4", True))
        Me.PictureEdit8.Location = New System.Drawing.Point(749, 14)
        Me.PictureEdit8.Name = "PictureEdit8"
        Me.PictureEdit8.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit8.Size = New System.Drawing.Size(243, 249)
        Me.PictureEdit8.TabIndex = 3
        '
        'PictureEdit6
        '
        Me.PictureEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim3", True))
        Me.PictureEdit6.Location = New System.Drawing.Point(500, 14)
        Me.PictureEdit6.Name = "PictureEdit6"
        Me.PictureEdit6.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit6.Size = New System.Drawing.Size(243, 249)
        Me.PictureEdit6.TabIndex = 2
        '
        'PictureEdit5
        '
        Me.PictureEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim2", True))
        Me.PictureEdit5.Location = New System.Drawing.Point(252, 14)
        Me.PictureEdit5.Name = "PictureEdit5"
        Me.PictureEdit5.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit5.Size = New System.Drawing.Size(243, 249)
        Me.PictureEdit5.TabIndex = 1
        '
        'PictureEdit4
        '
        Me.PictureEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.tbSipDetay, "Resim1", True))
        Me.PictureEdit4.Location = New System.Drawing.Point(3, 14)
        Me.PictureEdit4.Name = "PictureEdit4"
        Me.PictureEdit4.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit4.Size = New System.Drawing.Size(243, 249)
        Me.PictureEdit4.TabIndex = 0
        '
        'SplitterControl4
        '
        Me.SplitterControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl4.Location = New System.Drawing.Point(0, 118)
        Me.SplitterControl4.Name = "SplitterControl4"
        Me.SplitterControl4.Size = New System.Drawing.Size(620, 5)
        Me.SplitterControl4.TabIndex = 8
        Me.SplitterControl4.TabStop = False
        '
        'PanelControl12
        '
        Me.PanelControl12.Controls.Add(Me.GridControl2)
        Me.PanelControl12.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl12.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(620, 118)
        Me.PanelControl12.TabIndex = 7
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.tbSipDetayEkFiyatlar
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(402, 114)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'tbSipDetayEkFiyatlar
        '
        Me.tbSipDetayEkFiyatlar.Columns.AddRange(New System.Data.DataColumn() {Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID, Me.tbSipDetayEkFiyatlar_Deleted, Me.tbSipDetayEkFiyatlar_CreatedBy, Me.tbSipDetayEkFiyatlar_CreatedDate, Me.tbSipDetayEkFiyatlar_ModifiedBy, Me.tbSipDetayEkFiyatlar_ModifiedDate, Me.tbSipDetayEkFiyatlar_SipDetayID, Me.tbSipDetayEkFiyatlar_MasrafKod, Me.tbSipDetayEkFiyatlar_MasrafIsmi, Me.tbSipDetayEkFiyatlar_EkFiyat, Me.tbSipDetayEkFiyatlar_BedenArtis})
        Me.tbSipDetayEkFiyatlar.Connection = Me.FirmConn
        Me.tbSipDetayEkFiyatlar.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SipDetayEkFiyatID"}, True)})
        Me.tbSipDetayEkFiyatlar.CurrentRow = Nothing
        Me.tbSipDetayEkFiyatlar.DataSourceLink = Nothing
        Me.tbSipDetayEkFiyatlar.DeleteCommand = Me.SqlCommand24
        Me.tbSipDetayEkFiyatlar.Filter = ""
        Me.tbSipDetayEkFiyatlar.InsertCommand = Me.SqlCommand22
        Me.tbSipDetayEkFiyatlar.LiveSave = False
        Me.tbSipDetayEkFiyatlar.MaxRecords = CType(0, Long)
        Me.tbSipDetayEkFiyatlar.Name = "tbSipDetayEkFiyatlar"
        Me.tbSipDetayEkFiyatlar.ParentRelation_ChildColumns = Nothing
        Me.tbSipDetayEkFiyatlar.ParentRelation_ParentColumns = Nothing
        Me.tbSipDetayEkFiyatlar.ParentRelation_Table = Nothing
        Me.tbSipDetayEkFiyatlar.Position = CType(-1, Long)
        Me.tbSipDetayEkFiyatlar.PrimaryKey = New System.Data.DataColumn() {Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID}
        Me.tbSipDetayEkFiyatlar.Quoted = False
        Me.tbSipDetayEkFiyatlar.SelectCommand = Me.SqlCommand21
        Me.tbSipDetayEkFiyatlar.TableName = "NeoTable1"
        Me.tbSipDetayEkFiyatlar.Transaction = Nothing
        Me.tbSipDetayEkFiyatlar.UpdateCommand = Me.SqlCommand23
        '
        'tbSipDetayEkFiyatlar_SipDetayEkFiyatID
        '
        Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID.AllowDBNull = False
        Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID.AutoIncrement = True
        Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID.ColumnName = "SipDetayEkFiyatID"
        Me.tbSipDetayEkFiyatlar_SipDetayEkFiyatID.DataType = GetType(Integer)
        '
        'tbSipDetayEkFiyatlar_Deleted
        '
        Me.tbSipDetayEkFiyatlar_Deleted.ColumnName = "Deleted"
        Me.tbSipDetayEkFiyatlar_Deleted.DataType = GetType(Integer)
        '
        'tbSipDetayEkFiyatlar_CreatedBy
        '
        Me.tbSipDetayEkFiyatlar_CreatedBy.ColumnName = "CreatedBy"
        Me.tbSipDetayEkFiyatlar_CreatedBy.DataType = GetType(Integer)
        '
        'tbSipDetayEkFiyatlar_CreatedDate
        '
        Me.tbSipDetayEkFiyatlar_CreatedDate.ColumnName = "CreatedDate"
        Me.tbSipDetayEkFiyatlar_CreatedDate.DataType = GetType(Date)
        '
        'tbSipDetayEkFiyatlar_ModifiedBy
        '
        Me.tbSipDetayEkFiyatlar_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbSipDetayEkFiyatlar_ModifiedBy.DataType = GetType(Integer)
        '
        'tbSipDetayEkFiyatlar_ModifiedDate
        '
        Me.tbSipDetayEkFiyatlar_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbSipDetayEkFiyatlar_ModifiedDate.DataType = GetType(Date)
        '
        'tbSipDetayEkFiyatlar_SipDetayID
        '
        Me.tbSipDetayEkFiyatlar_SipDetayID.ColumnName = "SipDetayID"
        Me.tbSipDetayEkFiyatlar_SipDetayID.DataType = GetType(Integer)
        '
        'tbSipDetayEkFiyatlar_MasrafKod
        '
        Me.tbSipDetayEkFiyatlar_MasrafKod.ColumnName = "MasrafKod"
        '
        'tbSipDetayEkFiyatlar_MasrafIsmi
        '
        Me.tbSipDetayEkFiyatlar_MasrafIsmi.ColumnName = "MasrafIsmi"
        '
        'tbSipDetayEkFiyatlar_EkFiyat
        '
        Me.tbSipDetayEkFiyatlar_EkFiyat.ColumnName = "EkFiyat"
        Me.tbSipDetayEkFiyatlar_EkFiyat.DataType = GetType(Double)
        '
        'tbSipDetayEkFiyatlar_BedenArtis
        '
        Me.tbSipDetayEkFiyatlar_BedenArtis.ColumnName = "BedenArtis"
        Me.tbSipDetayEkFiyatlar_BedenArtis.DataType = GetType(Double)
        '
        'SqlCommand24
        '
        Me.SqlCommand24.CommandText = "DELETE FROM  SipDetayEkFiyatlar WHERE SipDetayEkFiyatID = @SipDetayEkFiyatID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand22
        '
        Me.SqlCommand22.CommandText = resources.GetString("SqlCommand22.CommandText")
        Me.SqlCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_SipDetayEkFiyatID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = "SELECT * FROM SipDetayEkFiyatlar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 AND SipDetayID>0 and SipDetay" &
    "ID=@SipDetayID"
        Me.SqlCommand21.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SipDetayID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand23
        '
        Me.SqlCommand23.CommandText = resources.GetString("SqlCommand23.CommandText")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSipDetayEkFiyatID, Me.colSipDetayID1, Me.colEkFiyatAciklama, Me.colEkFiyat, Me.colMasrafKod1, Me.colBedenArtis})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSipDetayEkFiyatID
        '
        Me.colSipDetayEkFiyatID.FieldName = "SipDetayEkFiyatID"
        Me.colSipDetayEkFiyatID.Name = "colSipDetayEkFiyatID"
        '
        'colSipDetayID1
        '
        Me.colSipDetayID1.FieldName = "SipDetayID"
        Me.colSipDetayID1.Name = "colSipDetayID1"
        '
        'colEkFiyatAciklama
        '
        Me.colEkFiyatAciklama.Caption = "Ek Fiyat Açıklama"
        Me.colEkFiyatAciklama.FieldName = "MasrafIsmi"
        Me.colEkFiyatAciklama.Name = "colEkFiyatAciklama"
        Me.colEkFiyatAciklama.Visible = True
        Me.colEkFiyatAciklama.VisibleIndex = 0
        Me.colEkFiyatAciklama.Width = 270
        '
        'colEkFiyat
        '
        Me.colEkFiyat.DisplayFormat.FormatString = "#,##0.00"
        Me.colEkFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkFiyat.FieldName = "EkFiyat"
        Me.colEkFiyat.Name = "colEkFiyat"
        Me.colEkFiyat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EkFiyat", "{0:#,##0.00}")})
        Me.colEkFiyat.Visible = True
        Me.colEkFiyat.VisibleIndex = 1
        Me.colEkFiyat.Width = 67
        '
        'colMasrafKod1
        '
        Me.colMasrafKod1.FieldName = "MasrafKod"
        Me.colMasrafKod1.Name = "colMasrafKod1"
        '
        'colBedenArtis
        '
        Me.colBedenArtis.FieldName = "BedenArtis"
        Me.colBedenArtis.Name = "colBedenArtis"
        '
        'XtraTabPage10
        '
        Me.XtraTabPage10.Name = "XtraTabPage10"
        Me.XtraTabPage10.Size = New System.Drawing.Size(620, 507)
        Me.XtraTabPage10.Text = "XtraTabPage10"
        '
        'tmrRapair
        '
        Me.tmrRapair.Interval = 500
        '
        'panelLeft
        '
        Me.panelLeft.Controls.Add(Me.CntUrunAgaci1)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 14)
        Me.panelLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(267, 592)
        Me.panelLeft.TabIndex = 7
        '
        'CntUrunAgaci1
        '
        Me.CntUrunAgaci1.aktifKategori = KategoriItem1
        Me.CntUrunAgaci1.ContextAddMenu = Me.ContextMenuStrip1
        Me.CntUrunAgaci1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CntUrunAgaci1.Editable = True
        Me.CntUrunAgaci1.Location = New System.Drawing.Point(0, 0)
        Me.CntUrunAgaci1.Name = "CntUrunAgaci1"
        Me.CntUrunAgaci1.Size = New System.Drawing.Size(267, 592)
        Me.CntUrunAgaci1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'mnuOzellikSecimSayfasi
        '
        Me.mnuOzellikSecimSayfasi.Name = "mnuOzellikSecimSayfasi"
        Me.mnuOzellikSecimSayfasi.Size = New System.Drawing.Size(219, 22)
        Me.mnuOzellikSecimSayfasi.Text = "Özellik Seçim Sayfası"
        '
        'mnuBedenlerFiyatlarMasraflar
        '
        Me.mnuBedenlerFiyatlarMasraflar.Name = "mnuBedenlerFiyatlarMasraflar"
        Me.mnuBedenlerFiyatlarMasraflar.Size = New System.Drawing.Size(219, 22)
        Me.mnuBedenlerFiyatlarMasraflar.Text = "Bedenler, Fiyatlar, Masraflar"
        '
        'mnuUygulama
        '
        Me.mnuUygulama.Name = "mnuUygulama"
        Me.mnuUygulama.Size = New System.Drawing.Size(219, 22)
        Me.mnuUygulama.Text = "Uygulama"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem5.Text = "Özellik Seçim Sayfası"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem6.Text = "Bedenler, Fiyatlar, Masraflar"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem7.Text = "Uygulama"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'tbSipDetay_SipDetayID
        '
        Me.tbSipDetay_SipDetayID.AllowDBNull = False
        Me.tbSipDetay_SipDetayID.AutoIncrement = True
        Me.tbSipDetay_SipDetayID.ColumnName = "SipDetayID"
        Me.tbSipDetay_SipDetayID.DataType = GetType(Integer)
        '
        'tbSipDetay_Deleted
        '
        Me.tbSipDetay_Deleted.ColumnName = "Deleted"
        Me.tbSipDetay_Deleted.DataType = GetType(Integer)
        '
        'tbSipDetay_CreatedBy
        '
        Me.tbSipDetay_CreatedBy.ColumnName = "CreatedBy"
        Me.tbSipDetay_CreatedBy.DataType = GetType(Integer)
        '
        'tbSipDetay_CreatedDate
        '
        Me.tbSipDetay_CreatedDate.ColumnName = "CreatedDate"
        Me.tbSipDetay_CreatedDate.DataType = GetType(Date)
        '
        'tbSipDetay_ModifiedBy
        '
        Me.tbSipDetay_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbSipDetay_ModifiedBy.DataType = GetType(Integer)
        '
        'tbSipDetay_ModifiedDate
        '
        Me.tbSipDetay_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbSipDetay_ModifiedDate.DataType = GetType(Date)
        '
        'tbSipDetay_SiparisID
        '
        Me.tbSipDetay_SiparisID.ColumnName = "SiparisID"
        Me.tbSipDetay_SiparisID.DataType = GetType(Integer)
        '
        'tbSipDetay_StokKod
        '
        Me.tbSipDetay_StokKod.ColumnName = "StokKod"
        '
        'tbSipDetay_StokRecNo
        '
        Me.tbSipDetay_StokRecNo.ColumnName = "StokRecNo"
        Me.tbSipDetay_StokRecNo.DataType = GetType(Integer)
        '
        'tbSipDetay_SiparisAciklama
        '
        Me.tbSipDetay_SiparisAciklama.ColumnName = "SiparisAciklama"
        '
        'tbSipDetay_OkulID
        '
        Me.tbSipDetay_OkulID.ColumnName = "OkulID"
        Me.tbSipDetay_OkulID.DataType = GetType(Integer)
        '
        'tbSipDetay_BolumKod
        '
        Me.tbSipDetay_BolumKod.ColumnName = "BolumKod"
        '
        'tbSipDetay_KategoriID
        '
        Me.tbSipDetay_KategoriID.ColumnName = "KategoriID"
        Me.tbSipDetay_KategoriID.DataType = GetType(Integer)
        '
        'tbSipDetay_Miktar
        '
        Me.tbSipDetay_Miktar.ColumnName = "Miktar"
        Me.tbSipDetay_Miktar.DataType = GetType(Double)
        '
        'tbSipDetay_Maliyet
        '
        Me.tbSipDetay_Maliyet.ColumnName = "Maliyet"
        Me.tbSipDetay_Maliyet.DataType = GetType(Double)
        '
        'tbSipDetay_Fiyat
        '
        Me.tbSipDetay_Fiyat.ColumnName = "Fiyat"
        Me.tbSipDetay_Fiyat.DataType = GetType(Double)
        '
        'tbSipDetay_Tutar
        '
        Me.tbSipDetay_Tutar.ColumnName = "Tutar"
        Me.tbSipDetay_Tutar.DataType = GetType(Double)
        '
        'tbSipDetay_Tarih
        '
        Me.tbSipDetay_Tarih.ColumnName = "Tarih"
        Me.tbSipDetay_Tarih.DataType = GetType(Date)
        '
        'tbSipDetay_TerminTarihi
        '
        Me.tbSipDetay_TerminTarihi.ColumnName = "TerminTarihi"
        Me.tbSipDetay_TerminTarihi.DataType = GetType(Date)
        '
        'tbSipDetay_MusteriSipNo
        '
        Me.tbSipDetay_MusteriSipNo.ColumnName = "MusteriSipNo"
        '
        'tbSipDetay_SiparisiAlan
        '
        Me.tbSipDetay_SiparisiAlan.ColumnName = "SiparisiAlan"
        '
        'tbSipDetay_Iptal
        '
        Me.tbSipDetay_Iptal.ColumnName = "Iptal"
        Me.tbSipDetay_Iptal.DataType = GetType(Integer)
        '
        'tbSipDetay_Resim1
        '
        Me.tbSipDetay_Resim1.ColumnName = "Resim1"
        Me.tbSipDetay_Resim1.DataType = GetType(Byte())
        '
        'tbSipDetay_Resim2
        '
        Me.tbSipDetay_Resim2.ColumnName = "Resim2"
        Me.tbSipDetay_Resim2.DataType = GetType(Byte())
        '
        'tbSipDetay_Resim3
        '
        Me.tbSipDetay_Resim3.ColumnName = "Resim3"
        Me.tbSipDetay_Resim3.DataType = GetType(Byte())
        '
        'tbSipDetay_Resim4
        '
        Me.tbSipDetay_Resim4.ColumnName = "Resim4"
        Me.tbSipDetay_Resim4.DataType = GetType(Byte())
        '
        'tbSipDetay_Resim5
        '
        Me.tbSipDetay_Resim5.ColumnName = "Resim5"
        Me.tbSipDetay_Resim5.DataType = GetType(Byte())
        '
        'tbSipDetay_StokIsmi
        '
        Me.tbSipDetay_StokIsmi.ColumnName = "StokIsmi"
        '
        'tbSipDetay_Bagli
        '
        Me.tbSipDetay_Bagli.ColumnName = "Bagli"
        Me.tbSipDetay_Bagli.DataType = GetType(Integer)
        '
        'tbSipDetay_BagliSipDetayID
        '
        Me.tbSipDetay_BagliSipDetayID.ColumnName = "BagliSipDetayID"
        Me.tbSipDetay_BagliSipDetayID.DataType = GetType(Integer)
        '
        'tbSipDetay_OkulFarki
        '
        Me.tbSipDetay_OkulFarki.ColumnName = "OkulFarki"
        Me.tbSipDetay_OkulFarki.DataType = GetType(Double)
        '
        'tbSipDetay_Durumu
        '
        Me.tbSipDetay_Durumu.ColumnName = "Durumu"
        '
        'tbSipDetay_TeslimMiktar
        '
        Me.tbSipDetay_TeslimMiktar.ColumnName = "TeslimMiktar"
        Me.tbSipDetay_TeslimMiktar.DataType = GetType(Double)
        '
        'tbSipDetay_AnaRenk
        '
        Me.tbSipDetay_AnaRenk.ColumnName = "AnaRenk"
        '
        'tbSipDetay_Bedenler
        '
        Me.tbSipDetay_Bedenler.ColumnName = "Bedenler"
        '
        'tbSipDetay_bSerbestFiyat
        '
        Me.tbSipDetay_bSerbestFiyat.ColumnName = "bSerbestFiyat"
        Me.tbSipDetay_bSerbestFiyat.DataType = GetType(Integer)
        '
        'tbSipDetay_Hazirlanan
        '
        Me.tbSipDetay_Hazirlanan.ColumnName = "Hazirlanan"
        Me.tbSipDetay_Hazirlanan.DataType = GetType(Double)
        '
        'tbSipDetay_FasondaMi
        '
        Me.tbSipDetay_FasondaMi.ColumnName = "FasondaMi"
        Me.tbSipDetay_FasondaMi.DataType = GetType(Integer)
        '
        'tbSipDetay_FasonFisID
        '
        Me.tbSipDetay_FasonFisID.ColumnName = "FasonFisID"
        Me.tbSipDetay_FasonFisID.DataType = GetType(Integer)
        '
        'tbSipDetay_Iskonto
        '
        Me.tbSipDetay_Iskonto.ColumnName = "Iskonto"
        Me.tbSipDetay_Iskonto.DataType = GetType(Double)
        '
        'tbSipDetay_NakitIskonto
        '
        Me.tbSipDetay_NakitIskonto.ColumnName = "NakitIskonto"
        Me.tbSipDetay_NakitIskonto.DataType = GetType(Double)
        '
        'tbSipDetay_IskontoTutar
        '
        Me.tbSipDetay_IskontoTutar.ColumnName = "IskontoTutar"
        Me.tbSipDetay_IskontoTutar.DataType = GetType(Double)
        '
        'tbSipDetay_NakitIskontoTutar
        '
        Me.tbSipDetay_NakitIskontoTutar.ColumnName = "NakitIskontoTutar"
        Me.tbSipDetay_NakitIskontoTutar.DataType = GetType(Double)
        '
        'tbSipDetay_sip_Guid
        '
        Me.tbSipDetay_sip_Guid.ColumnName = "sip_Guid"
        Me.tbSipDetay_sip_Guid.DataType = GetType(System.Guid)
        '
        'tbSipDetay_BoyahaneID
        '
        Me.tbSipDetay_BoyahaneID.ColumnName = "BoyahaneID"
        Me.tbSipDetay_BoyahaneID.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_BedenNo
        '
        Me.tbSipDetayFiyatlar_BedenNo.ColumnName = "BedenNo"
        Me.tbSipDetayFiyatlar_BedenNo.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_SipDetayFiyatAdetID
        '
        Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID.AllowDBNull = False
        Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID.AutoIncrement = True
        Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID.ColumnName = "SipDetayFiyatAdetID"
        Me.tbSipDetayFiyatlar_SipDetayFiyatAdetID.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_Deleted
        '
        Me.tbSipDetayFiyatlar_Deleted.ColumnName = "Deleted"
        Me.tbSipDetayFiyatlar_Deleted.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_CreatedBy
        '
        Me.tbSipDetayFiyatlar_CreatedBy.ColumnName = "CreatedBy"
        Me.tbSipDetayFiyatlar_CreatedBy.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_CreatedDate
        '
        Me.tbSipDetayFiyatlar_CreatedDate.ColumnName = "CreatedDate"
        Me.tbSipDetayFiyatlar_CreatedDate.DataType = GetType(Date)
        '
        'tbSipDetayFiyatlar_ModifiedBy
        '
        Me.tbSipDetayFiyatlar_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbSipDetayFiyatlar_ModifiedBy.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_ModifiedDate
        '
        Me.tbSipDetayFiyatlar_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbSipDetayFiyatlar_ModifiedDate.DataType = GetType(Date)
        '
        'tbSipDetayFiyatlar_SipDetayID
        '
        Me.tbSipDetayFiyatlar_SipDetayID.ColumnName = "SipDetayID"
        Me.tbSipDetayFiyatlar_SipDetayID.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_BedenKod
        '
        Me.tbSipDetayFiyatlar_BedenKod.ColumnName = "BedenKod"
        '
        'tbSipDetayFiyatlar_BazFiyat
        '
        Me.tbSipDetayFiyatlar_BazFiyat.ColumnName = "BazFiyat"
        Me.tbSipDetayFiyatlar_BazFiyat.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_BrutFiyat
        '
        Me.tbSipDetayFiyatlar_BrutFiyat.ColumnName = "BrutFiyat"
        Me.tbSipDetayFiyatlar_BrutFiyat.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_Iskonto
        '
        Me.tbSipDetayFiyatlar_Iskonto.ColumnName = "Iskonto"
        Me.tbSipDetayFiyatlar_Iskonto.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_NakitIskonto
        '
        Me.tbSipDetayFiyatlar_NakitIskonto.ColumnName = "NakitIskonto"
        Me.tbSipDetayFiyatlar_NakitIskonto.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_NetFiyat
        '
        Me.tbSipDetayFiyatlar_NetFiyat.ColumnName = "NetFiyat"
        Me.tbSipDetayFiyatlar_NetFiyat.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_Miktar
        '
        Me.tbSipDetayFiyatlar_Miktar.ColumnName = "Miktar"
        Me.tbSipDetayFiyatlar_Miktar.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_Tutar
        '
        Me.tbSipDetayFiyatlar_Tutar.ColumnName = "Tutar"
        Me.tbSipDetayFiyatlar_Tutar.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_KategoriFiyatID
        '
        Me.tbSipDetayFiyatlar_KategoriFiyatID.ColumnName = "KategoriFiyatID"
        Me.tbSipDetayFiyatlar_KategoriFiyatID.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_DetayAciklama
        '
        Me.tbSipDetayFiyatlar_DetayAciklama.ColumnName = "DetayAciklama"
        '
        'tbSipDetayFiyatlar_RenkKod
        '
        Me.tbSipDetayFiyatlar_RenkKod.ColumnName = "RenkKod"
        '
        'tbSipDetayFiyatlar_BdnHarNo
        '
        Me.tbSipDetayFiyatlar_BdnHarNo.ColumnName = "BdnHarNo"
        Me.tbSipDetayFiyatlar_BdnHarNo.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_TeslimMiktar
        '
        Me.tbSipDetayFiyatlar_TeslimMiktar.ColumnName = "TeslimMiktar"
        Me.tbSipDetayFiyatlar_TeslimMiktar.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_sip_RECno
        '
        Me.tbSipDetayFiyatlar_sip_RECno.ColumnName = "sip_RECno"
        Me.tbSipDetayFiyatlar_sip_RECno.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_sip_evrakno_seri
        '
        Me.tbSipDetayFiyatlar_sip_evrakno_seri.ColumnName = "sip_evrakno_seri"
        '
        'tbSipDetayFiyatlar_sip_evrakno_sira
        '
        Me.tbSipDetayFiyatlar_sip_evrakno_sira.ColumnName = "sip_evrakno_sira"
        Me.tbSipDetayFiyatlar_sip_evrakno_sira.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_sip_satirno
        '
        Me.tbSipDetayFiyatlar_sip_satirno.ColumnName = "sip_satirno"
        Me.tbSipDetayFiyatlar_sip_satirno.DataType = GetType(Integer)
        '
        'tbSipDetayFiyatlar_Hazirlanan
        '
        Me.tbSipDetayFiyatlar_Hazirlanan.ColumnName = "Hazirlanan"
        Me.tbSipDetayFiyatlar_Hazirlanan.DataType = GetType(Double)
        '
        'tbSipDetayFiyatlar_sip_Guid
        '
        Me.tbSipDetayFiyatlar_sip_Guid.ColumnName = "sip_Guid"
        Me.tbSipDetayFiyatlar_sip_Guid.DataType = GetType(System.Guid)
        '
        'frmKategoriler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 606)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl6)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "frmKategoriler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Ağacı /Ürün Tanımlamaları"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelParametreler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelParametreler.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage7.ResumeLayout(False)
        Me.paneltemp333.ResumeLayout(False)
        CType(Me.txtSiparisKontrol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.tbSipDetay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOkul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSecenekler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl13.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.tbKategoriFiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGridBazBedenMi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelKendiFiyatBeden.ResumeLayout(False)
        Me.panelKendiFiyatBeden.PerformLayout()
        CType(Me.grEkMasraflar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKategoriEkFiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grEkMasraflarView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelKendiMasraf.ResumeLayout(False)
        Me.panelKendiMasraf.PerformLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.grFiyatlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSipDetayFiyatlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grFiyatlarView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRenkler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.chkSerbestFiyat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        CType(Me.txtNakitIskonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIskonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBolumKod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOkul.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMusteri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.PictureEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage9.ResumeLayout(False)
        Me.XtraScrollableControl2.ResumeLayout(False)
        CType(Me.PictureEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSipDetayEkFiyatlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panelParametreler As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents FirmConn As NeoDAC.NeoConnection
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelOzellik As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents paneltemp333 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents cmdOzellikleriEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelOzellikler As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAktifKategoriIsim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAktifKategoriKod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbOkul As NeoDAC.NeoTable
    Friend WithEvents tbOkul_OkulID As System.Data.DataColumn
    Friend WithEvents tbOkul_OkulKod As System.Data.DataColumn
    Friend WithEvents tbOkul_OkulIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_IlceID As System.Data.DataColumn
    Friend WithEvents tbOkul_IlID As System.Data.DataColumn
    Friend WithEvents tbOkul_IlIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_IlceIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_DisplayText As System.Data.DataColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbSipDetay As NeoDAC.NeoTable
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboSecenekler As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents tbKategoriFiyat As NeoDAC.NeoTable
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKategoriFiyatID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBazBedenMi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkGridBazBedenMi As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdKaydetFiyat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuMoveUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoveDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFiyatSil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdDevam As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbSipDetayFiyatlar As NeoDAC.NeoTable
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdKategoriKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grEkMasraflar As DevExpress.XtraGrid.GridControl
    Friend WithEvents grEkMasraflarView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbKategoriEkFiyat As NeoDAC.NeoTable
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colMasrafKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriEkFiyatID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbKategoriEkFiyat_KategoriEkFiyatID As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_Deleted As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_KategoriID As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_MasrafKod As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_MasrafIsmi As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_Fiyat As System.Data.DataColumn
    Friend WithEvents tbKategoriEkFiyat_BedenArtis As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_KategoriFiyatID As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_Deleted As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_KategoriID As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_BedenNo As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_BedenKod As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_Fiyat As System.Data.DataColumn
    Friend WithEvents tbKategoriFiyat_BazBedenMi As System.Data.DataColumn
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents txtSiparisKontrol As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents tbSipDetayEkFiyatlar As NeoDAC.NeoTable
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSipDetayEkFiyatID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipDetayID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkFiyatAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasrafKod1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbSipDetayEkFiyatlar_SipDetayEkFiyatID As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_Deleted As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_SipDetayID As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_MasrafKod As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_MasrafIsmi As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_EkFiyat As System.Data.DataColumn
    Friend WithEvents tbSipDetayEkFiyatlar_BedenArtis As System.Data.DataColumn
    Friend WithEvents colBedenArtis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitterControl4 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grFiyatlar As DevExpress.XtraGrid.GridControl
    Friend WithEvents grFiyatlarView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSipDetayFiyatAdetID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenKod1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBazFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNakitIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdGeri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdIskontoUygula As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNakitIskonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIskonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboBolumKod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboOkul As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOkulID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlceIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMusteri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdGeri_AdetlerFiyatlar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSaveOzellik As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriFiyatID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbKategori As NeoDAC.NeoTable
    Friend WithEvents SqlCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraScrollableControl2 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents PictureEdit7 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit8 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit6 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents mnuOzellikSec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit10 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit9 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblAktifKategoriEntKod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdMikroStokKod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colDetayAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRenkKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboRenkler As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colBdnHarNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblOkulFarki As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmrRapair As System.Windows.Forms.Timer
    Friend WithEvents chkSerbestFiyat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BedenlerFiyatlarTurHesaplariToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UygulamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XtraTabPage10 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents panelKendiFiyatBeden As Panel
    Friend WithEvents panelKendiMasraf As Panel
    Friend WithEvents tbKategori_KendiMasrafKullan As DataColumn
    Friend WithEvents tbKategori_KendiFiyatBedenKullan As DataColumn
    Friend WithEvents tbKategori_Resim5 As DataColumn
    Friend WithEvents tbKategori_Resim4 As DataColumn
    Friend WithEvents tbKategori_Resim3 As DataColumn
    Friend WithEvents tbKategori_Resim2 As DataColumn
    Friend WithEvents tbKategori_Resim1 As DataColumn
    Friend WithEvents tbKategori_tempGrup As DataColumn
    Friend WithEvents tbKategori_IntCode As DataColumn
    Friend WithEvents tbKategori_StokKodFormat As DataColumn
    Friend WithEvents tbKategori_KategoriIsim As DataColumn
    Friend WithEvents tbKategori_KategoriKod As DataColumn
    Friend WithEvents tbKategori_UstKategoriID As DataColumn
    Friend WithEvents tbKategori_ModifiedDate As DataColumn
    Friend WithEvents tbKategori_ModifiedBy As DataColumn
    Friend WithEvents tbKategori_CreatedDate As DataColumn
    Friend WithEvents tbKategori_CreatedBy As DataColumn
    Friend WithEvents tbKategori_Deleted As DataColumn
    Friend WithEvents tbKategori_KategoriID As DataColumn
    Friend WithEvents chkKategori_KendiFiyatBeden As CheckBox
    Friend WithEvents chkKategori_KendiMasraf As CheckBox
    Friend WithEvents CntUrunAgaci1 As cntUrunAgaci
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuOzellikSecimSayfasi As ToolStripMenuItem
    Friend WithEvents mnuBedenlerFiyatlarMasraflar As ToolStripMenuItem
    Friend WithEvents mnuUygulama As ToolStripMenuItem
    Friend WithEvents tbSipDetay_SipDetayID As DataColumn
    Friend WithEvents tbSipDetay_Deleted As DataColumn
    Friend WithEvents tbSipDetay_CreatedBy As DataColumn
    Friend WithEvents tbSipDetay_CreatedDate As DataColumn
    Friend WithEvents tbSipDetay_ModifiedBy As DataColumn
    Friend WithEvents tbSipDetay_ModifiedDate As DataColumn
    Friend WithEvents tbSipDetay_SiparisID As DataColumn
    Friend WithEvents tbSipDetay_StokKod As DataColumn
    Friend WithEvents tbSipDetay_StokRecNo As DataColumn
    Friend WithEvents tbSipDetay_SiparisAciklama As DataColumn
    Friend WithEvents tbSipDetay_OkulID As DataColumn
    Friend WithEvents tbSipDetay_BolumKod As DataColumn
    Friend WithEvents tbSipDetay_KategoriID As DataColumn
    Friend WithEvents tbSipDetay_Miktar As DataColumn
    Friend WithEvents tbSipDetay_Maliyet As DataColumn
    Friend WithEvents tbSipDetay_Fiyat As DataColumn
    Friend WithEvents tbSipDetay_Tutar As DataColumn
    Friend WithEvents tbSipDetay_Tarih As DataColumn
    Friend WithEvents tbSipDetay_TerminTarihi As DataColumn
    Friend WithEvents tbSipDetay_MusteriSipNo As DataColumn
    Friend WithEvents tbSipDetay_SiparisiAlan As DataColumn
    Friend WithEvents tbSipDetay_Iptal As DataColumn
    Friend WithEvents tbSipDetay_Resim1 As DataColumn
    Friend WithEvents tbSipDetay_Resim2 As DataColumn
    Friend WithEvents tbSipDetay_Resim3 As DataColumn
    Friend WithEvents tbSipDetay_Resim4 As DataColumn
    Friend WithEvents tbSipDetay_Resim5 As DataColumn
    Friend WithEvents tbSipDetay_StokIsmi As DataColumn
    Friend WithEvents tbSipDetay_Bagli As DataColumn
    Friend WithEvents tbSipDetay_BagliSipDetayID As DataColumn
    Friend WithEvents tbSipDetay_OkulFarki As DataColumn
    Friend WithEvents tbSipDetay_Durumu As DataColumn
    Friend WithEvents tbSipDetay_TeslimMiktar As DataColumn
    Friend WithEvents tbSipDetay_AnaRenk As DataColumn
    Friend WithEvents tbSipDetay_Bedenler As DataColumn
    Friend WithEvents tbSipDetay_bSerbestFiyat As DataColumn
    Friend WithEvents tbSipDetay_Hazirlanan As DataColumn
    Friend WithEvents tbSipDetay_FasondaMi As DataColumn
    Friend WithEvents tbSipDetay_FasonFisID As DataColumn
    Friend WithEvents tbSipDetay_Iskonto As DataColumn
    Friend WithEvents tbSipDetay_NakitIskonto As DataColumn
    Friend WithEvents tbSipDetay_IskontoTutar As DataColumn
    Friend WithEvents tbSipDetay_NakitIskontoTutar As DataColumn
    Friend WithEvents tbSipDetay_sip_Guid As DataColumn
    Friend WithEvents tbSipDetay_BoyahaneID As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_BedenNo As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_SipDetayFiyatAdetID As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_Deleted As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_CreatedBy As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_CreatedDate As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_ModifiedBy As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_ModifiedDate As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_SipDetayID As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_BedenKod As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_BazFiyat As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_BrutFiyat As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_Iskonto As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_NakitIskonto As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_NetFiyat As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_Miktar As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_Tutar As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_KategoriFiyatID As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_DetayAciklama As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_RenkKod As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_BdnHarNo As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_TeslimMiktar As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_sip_RECno As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_sip_evrakno_seri As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_sip_evrakno_sira As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_sip_satirno As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_Hazirlanan As DataColumn
    Friend WithEvents tbSipDetayFiyatlar_sip_Guid As DataColumn
End Class
