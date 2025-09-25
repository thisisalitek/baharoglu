<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSiparisler
    Inherits ProbarSiparis.frmBaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiparisler))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TarihDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.cboOdemeDurumu = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.cboSiparisType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDepo2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDepo = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtRiskBakiye = New DevExpress.XtraEditors.TextEdit()
        Me.txtBakiye = New DevExpress.XtraEditors.TextEdit()
        Me.SiparisIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeletedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SipEvrakSeriTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SipEvrakSiraSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.txtCariKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCariUnvan = New DevExpress.XtraEditors.ButtonEdit()
        Me.Aciklama1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Aciklama2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Aciklama3TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForSiparisID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForTarih = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCariKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAciklama1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSipEvrakSeri = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSipEvrakSira = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAciklama2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCariUnvan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAciklama3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSipDetayBagla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSipDetayBaglantiIptal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SatirSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSipDetayID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGridSipDetayRemove = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colSipDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGridSipDetay = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colSipDetayID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbOkul = New NeoDAC.NeoTable(Me.components)
        Me.tbOkul_OkulID = New System.Data.DataColumn()
        Me.tbOkul_OkulKod = New System.Data.DataColumn()
        Me.tbOkul_OkulIsmi = New System.Data.DataColumn()
        Me.tbOkul_IlceID = New System.Data.DataColumn()
        Me.tbOkul_IlID = New System.Data.DataColumn()
        Me.tbOkul_IlIsmi = New System.Data.DataColumn()
        Me.tbOkul_IlceIsmi = New System.Data.DataColumn()
        Me.tbOkul_DisplayText = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.colKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbKategori = New NeoDAC.NeoTable(Me.components)
        Me.tbKategori_KategoriID = New System.Data.DataColumn()
        Me.tbKategori_UstKategoriID = New System.Data.DataColumn()
        Me.tbKategori_KategoriKod = New System.Data.DataColumn()
        Me.tbKategori_KategoriIsim = New System.Data.DataColumn()
        Me.tbKategori_StokKodFormat = New System.Data.DataColumn()
        Me.tbKategori_IntCode = New System.Data.DataColumn()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.colKategoriID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDurumu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colBoyahane = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbBoyahaneler = New NeoDAC.NeoTable(Me.components)
        Me.tbBoyahaneler_BoyahaneID = New System.Data.DataColumn()
        Me.tbBoyahaneler_Boyahane = New System.Data.DataColumn()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.colStokRecNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenelToplam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizliTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerminTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBolumKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtStokKod = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colStokIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtStokIsmi = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colBagli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colBagliSipDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskontoTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNakitIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNakitIskontoTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKdvOran = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.cboDoviz = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.NeoTable1 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable1_SiparisAlanID = New System.Data.DataColumn()
        Me.NeoTable1_Deleted = New System.Data.DataColumn()
        Me.NeoTable1_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable1_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable1_SipAlanIsmi = New System.Data.DataColumn()
        Me.NeoTable1_IntCode = New System.Data.DataColumn()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.tbSaticilar = New NeoDAC.NeoTable(Me.components)
        Me.tbSaticilar_SaticiID = New System.Data.DataColumn()
        Me.tbSaticilar_SaticiIsmi = New System.Data.DataColumn()
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddSipDetay = New DevExpress.XtraEditors.SimpleButton()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.panelAdmin = New DevExpress.XtraEditors.PanelControl()
        Me.chkIptal = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.chkOnayli = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdOnayla = New DevExpress.XtraEditors.SimpleButton()
        Me.colOnayli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colOnaylayan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbUsers = New NeoDAC.NeoTable(Me.components)
        Me.tbUsers_UserID = New System.Data.DataColumn()
        Me.tbUsers_UserName = New System.Data.DataColumn()
        Me.tbUsers_FullName = New System.Data.DataColumn()
        Me.colOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colIptalNedeni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkShowIptal = New DevExpress.XtraEditors.CheckEdit()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAraToplam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenelToplam1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTipi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizliTutar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvOran1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboGridSiparisType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colOdemeDurumu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdenen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaticiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colDovizGuncelleme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeFarkiOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeFarkiTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSeri1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSira1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnayli1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnaylayan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnayTarihi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptalNedeni1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAraToplam1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvOran2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenelToplam2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTipi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizKuru2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizliTutar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulFarki = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNAraToplam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNKdvTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNGenelToplam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeDurumu1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdenen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaticiID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizGuncelleme1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeFarkiOran1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeFarkiTutar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DetailTable_SipDetayID = New System.Data.DataColumn()
        Me.DetailTable_Deleted = New System.Data.DataColumn()
        Me.DetailTable_CreatedBy = New System.Data.DataColumn()
        Me.DetailTable_CreatedDate = New System.Data.DataColumn()
        Me.DetailTable_ModifiedBy = New System.Data.DataColumn()
        Me.DetailTable_ModifiedDate = New System.Data.DataColumn()
        Me.DetailTable_SiparisID = New System.Data.DataColumn()
        Me.DetailTable_StokKod = New System.Data.DataColumn()
        Me.DetailTable_StokRecNo = New System.Data.DataColumn()
        Me.DetailTable_SiparisAciklama = New System.Data.DataColumn()
        Me.DetailTable_OkulID = New System.Data.DataColumn()
        Me.DetailTable_BolumKod = New System.Data.DataColumn()
        Me.DetailTable_KategoriID = New System.Data.DataColumn()
        Me.DetailTable_Miktar = New System.Data.DataColumn()
        Me.DetailTable_Maliyet = New System.Data.DataColumn()
        Me.DetailTable_Fiyat = New System.Data.DataColumn()
        Me.DetailTable_Tutar = New System.Data.DataColumn()
        Me.DetailTable_Tarih = New System.Data.DataColumn()
        Me.DetailTable_TerminTarihi = New System.Data.DataColumn()
        Me.DetailTable_MusteriSipNo = New System.Data.DataColumn()
        Me.DetailTable_SiparisiAlan = New System.Data.DataColumn()
        Me.DetailTable_Iptal = New System.Data.DataColumn()
        Me.DetailTable_Resim1 = New System.Data.DataColumn()
        Me.DetailTable_Resim2 = New System.Data.DataColumn()
        Me.DetailTable_Resim3 = New System.Data.DataColumn()
        Me.DetailTable_Resim4 = New System.Data.DataColumn()
        Me.DetailTable_Resim5 = New System.Data.DataColumn()
        Me.DetailTable_StokIsmi = New System.Data.DataColumn()
        Me.DetailTable_Bagli = New System.Data.DataColumn()
        Me.DetailTable_BagliSipDetayID = New System.Data.DataColumn()
        Me.DetailTable_OkulFarki = New System.Data.DataColumn()
        Me.DetailTable_Durumu = New System.Data.DataColumn()
        Me.DetailTable_TeslimMiktar = New System.Data.DataColumn()
        Me.DetailTable_AnaRenk = New System.Data.DataColumn()
        Me.DetailTable_Bedenler = New System.Data.DataColumn()
        Me.DetailTable_bSerbestFiyat = New System.Data.DataColumn()
        Me.DetailTable_Hazirlanan = New System.Data.DataColumn()
        Me.DetailTable_FasondaMi = New System.Data.DataColumn()
        Me.DetailTable_FasonFisID = New System.Data.DataColumn()
        Me.DetailTable_Iskonto = New System.Data.DataColumn()
        Me.DetailTable_NakitIskonto = New System.Data.DataColumn()
        Me.DetailTable_IskontoTutar = New System.Data.DataColumn()
        Me.DetailTable_NakitIskontoTutar = New System.Data.DataColumn()
        Me.DetailTable_sip_Guid = New System.Data.DataColumn()
        Me.DetailTable_BoyahaneID = New System.Data.DataColumn()
        Me.MasterTable_SiparisID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_Tarih = New System.Data.DataColumn()
        Me.MasterTable_SipEvrakSeri = New System.Data.DataColumn()
        Me.MasterTable_SipEvrakSira = New System.Data.DataColumn()
        Me.MasterTable_SiparisNo = New System.Data.DataColumn()
        Me.MasterTable_CariKod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_Aciklama1 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama2 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama3 = New System.Data.DataColumn()
        Me.MasterTable_Onayli = New System.Data.DataColumn()
        Me.MasterTable_Onaylayan = New System.Data.DataColumn()
        Me.MasterTable_OnayTarihi = New System.Data.DataColumn()
        Me.MasterTable_Iptal = New System.Data.DataColumn()
        Me.MasterTable_IptalNedeni = New System.Data.DataColumn()
        Me.MasterTable_AraToplam = New System.Data.DataColumn()
        Me.MasterTable_KdvOran = New System.Data.DataColumn()
        Me.MasterTable_KdvTutar = New System.Data.DataColumn()
        Me.MasterTable_GenelToplam = New System.Data.DataColumn()
        Me.MasterTable_DovizTipi = New System.Data.DataColumn()
        Me.MasterTable_DovizKuru = New System.Data.DataColumn()
        Me.MasterTable_DovizliTutar = New System.Data.DataColumn()
        Me.MasterTable_OkulFarki = New System.Data.DataColumn()
        Me.MasterTable_NAraToplam = New System.Data.DataColumn()
        Me.MasterTable_NKdvTutar = New System.Data.DataColumn()
        Me.MasterTable_NGenelToplam = New System.Data.DataColumn()
        Me.MasterTable_SiparisType = New System.Data.DataColumn()
        Me.MasterTable_Depo = New System.Data.DataColumn()
        Me.MasterTable_Depo2 = New System.Data.DataColumn()
        Me.MasterTable_OdemeDurumu = New System.Data.DataColumn()
        Me.MasterTable_Odenen = New System.Data.DataColumn()
        Me.MasterTable_SaticiID = New System.Data.DataColumn()
        Me.MasterTable_DovizGuncelleme = New System.Data.DataColumn()
        Me.MasterTable_VadeFarkiOran = New System.Data.DataColumn()
        Me.MasterTable_VadeFarkiTutar = New System.Data.DataColumn()
        Me.MasterTable_SiparisAlanID = New System.Data.DataColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.BaseTab1.SuspendLayout()
        Me.BaseTab2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.basePanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.basePanelControl3.SuspendLayout()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupDocumentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelAuthCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAuthCodes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormDateFilter.SuspendLayout()
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TarihDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarihDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOdemeDurumu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSiparisType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRiskBakiye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBakiye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiparisIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SipEvrakSeriTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SipEvrakSiraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCariKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCariUnvan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aciklama1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aciklama2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aciklama3TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSiparisID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTarih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCariKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAciklama1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSipEvrakSeri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSipEvrakSira, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAciklama2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCariUnvan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAciklama3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGridSipDetayRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGridSipDetay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOkul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBoyahaneler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKdvOran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDoviz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSaticilar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAdmin.SuspendLayout()
        CType(Me.chkIptal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOnayli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowIptal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.cboGridSiparisType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        '
        'Bar2
        '
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        '
        'Bar3
        '
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 629)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 562)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 562)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 118)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(893, 470)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(887, 442)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.XtraTabControl2)
        Me.BaseTab2.Controls.Add(Me.panelAdmin)
        Me.BaseTab2.Size = New System.Drawing.Size(887, 381)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAdmin, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.XtraTabControl2, 0)
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(887, 362)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSiparisID2, Me.colDeleted1, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colTarih2, Me.colSipEvrakSeri1, Me.colSipEvrakSira1, Me.colSiparisNo1, Me.colCariKod1, Me.colCariUnvan1, Me.colAciklama11, Me.colAciklama21, Me.colAciklama31, Me.colOnayli1, Me.colOnaylayan1, Me.colOnayTarihi1, Me.colIptal1, Me.colIptalNedeni1, Me.colAraToplam1, Me.colKdvOran2, Me.colKdvTutar2, Me.colGenelToplam2, Me.colDovizTipi2, Me.colDovizKuru2, Me.colDovizliTutar2, Me.colOkulFarki, Me.colNAraToplam, Me.colNKdvTutar, Me.colNGenelToplam, Me.colSiparisType1, Me.colDepo1, Me.colDepo21, Me.colOdemeDurumu1, Me.colOdenen1, Me.colSaticiID1, Me.colDovizGuncelleme1, Me.colVadeFarkiOran1, Me.colVadeFarkiTutar1})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'panelBottom
        '
        Me.panelBottom.Location = New System.Drawing.Point(0, 588)
        '
        'panelFormTop
        '
        Me.panelFormTop.Location = New System.Drawing.Point(0, 87)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_SiparisID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_Tarih, Me.MasterTable_SipEvrakSeri, Me.MasterTable_SipEvrakSira, Me.MasterTable_SiparisNo, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_Aciklama1, Me.MasterTable_Aciklama2, Me.MasterTable_Aciklama3, Me.MasterTable_Onayli, Me.MasterTable_Onaylayan, Me.MasterTable_OnayTarihi, Me.MasterTable_Iptal, Me.MasterTable_IptalNedeni, Me.MasterTable_AraToplam, Me.MasterTable_KdvOran, Me.MasterTable_KdvTutar, Me.MasterTable_GenelToplam, Me.MasterTable_DovizTipi, Me.MasterTable_DovizKuru, Me.MasterTable_DovizliTutar, Me.MasterTable_OkulFarki, Me.MasterTable_NAraToplam, Me.MasterTable_NKdvTutar, Me.MasterTable_NGenelToplam, Me.MasterTable_SiparisType, Me.MasterTable_Depo, Me.MasterTable_Depo2, Me.MasterTable_OdemeDurumu, Me.MasterTable_Odenen, Me.MasterTable_SaticiID, Me.MasterTable_DovizGuncelleme, Me.MasterTable_VadeFarkiOran, Me.MasterTable_VadeFarkiTutar, Me.MasterTable_SiparisAlanID})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SiparisID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_SiparisID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'DetailTable
        '
        Me.DetailTable.Columns.AddRange(New System.Data.DataColumn() {Me.DetailTable_SipDetayID, Me.DetailTable_Deleted, Me.DetailTable_CreatedBy, Me.DetailTable_CreatedDate, Me.DetailTable_ModifiedBy, Me.DetailTable_ModifiedDate, Me.DetailTable_SiparisID, Me.DetailTable_StokKod, Me.DetailTable_StokRecNo, Me.DetailTable_SiparisAciklama, Me.DetailTable_OkulID, Me.DetailTable_BolumKod, Me.DetailTable_KategoriID, Me.DetailTable_Miktar, Me.DetailTable_Maliyet, Me.DetailTable_Fiyat, Me.DetailTable_Tutar, Me.DetailTable_Tarih, Me.DetailTable_TerminTarihi, Me.DetailTable_MusteriSipNo, Me.DetailTable_SiparisiAlan, Me.DetailTable_Iptal, Me.DetailTable_Resim1, Me.DetailTable_Resim2, Me.DetailTable_Resim3, Me.DetailTable_Resim4, Me.DetailTable_Resim5, Me.DetailTable_StokIsmi, Me.DetailTable_Bagli, Me.DetailTable_BagliSipDetayID, Me.DetailTable_OkulFarki, Me.DetailTable_Durumu, Me.DetailTable_TeslimMiktar, Me.DetailTable_AnaRenk, Me.DetailTable_Bedenler, Me.DetailTable_bSerbestFiyat, Me.DetailTable_Hazirlanan, Me.DetailTable_FasondaMi, Me.DetailTable_FasonFisID, Me.DetailTable_Iskonto, Me.DetailTable_NakitIskonto, Me.DetailTable_IskontoTutar, Me.DetailTable_NakitIskontoTutar, Me.DetailTable_sip_Guid, Me.DetailTable_BoyahaneID})
        Me.DetailTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SipDetayID"}, True)})
        Me.DetailTable.DeleteCommand = Me.SqlCommand8
        Me.DetailTable.InsertCommand = Me.SqlCommand6
        Me.DetailTable.ParentRelation_ChildColumns = New String() {"SiparisID"}
        Me.DetailTable.ParentRelation_ParentColumns = New String() {"SiparisID"}
        Me.DetailTable.ParentRelation_Table = Me.MasterTable
        Me.DetailTable.PrimaryKey = New System.Data.DataColumn() {Me.DetailTable_SipDetayID}
        Me.DetailTable.SelectCommand = Me.SqlCommand5
        Me.DetailTable.UpdateCommand = Me.SqlCommand7
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(887, 371)
        Me.BaseTab4.Tag = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(893, 20)
        Me.txtTopInfo.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 423)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 355)
        '
        'cboAuthCodes
        '
        Me.cboAuthCodes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cboAuthCodes.Properties.Appearance.Options.UseFont = True
        '
        'lblAuthCodeCaption
        '
        Me.lblAuthCodeCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Controls.Add(Me.chkShowIptal)
        Me.panelFormDateFilter.Visible = True
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.cmdRefreshList, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkShowIptal, 0)
        '
        'chkDate2
        '
        Me.chkDate2.Properties.Appearance.Options.UseTextOptions = True
        Me.chkDate2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        '
        'dtFormDate2
        '
        Me.dtFormDate2.EditValue = Nothing
        '
        'chkDate1
        '
        Me.chkDate1.Properties.Appearance.Options.UseTextOptions = True
        Me.chkDate1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        '
        'dtFormDate1
        '
        Me.dtFormDate1.EditValue = Nothing
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM Siparis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND Tarih BETWEEN @FormDate1 AND @Fo" &
    "rmDate2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND (Iptal =0 OR Iptal = @Iptal)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime), New System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime), New System.Data.SqlClient.SqlParameter("@Iptal", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0"), New System.Data.SqlClient.SqlParameter("@SipDetayIDLer", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "")})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_SiparisID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Siparis SET Deleted = SiparisID  , ModifiedBy = @ModifiedBy , ModifiedDate" &
    " = GETDATE()   WHERE SiparisID = @SiparisID"
        '
        'colSiparisID
        '
        Me.colSiparisID.FieldName = "SiparisID"
        Me.colSiparisID.Name = "colSiparisID"
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colTarih
        '
        Me.colTarih.FieldName = "Tarih"
        Me.colTarih.Name = "colTarih"
        Me.colTarih.Visible = True
        Me.colTarih.VisibleIndex = 1
        '
        'colSipEvrakSeri
        '
        Me.colSipEvrakSeri.FieldName = "SipEvrakSeri"
        Me.colSipEvrakSeri.Name = "colSipEvrakSeri"
        Me.colSipEvrakSeri.Visible = True
        Me.colSipEvrakSeri.VisibleIndex = 2
        '
        'colSipEvrakSira
        '
        Me.colSipEvrakSira.DisplayFormat.FormatString = "00000"
        Me.colSipEvrakSira.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSipEvrakSira.FieldName = "SipEvrakSira"
        Me.colSipEvrakSira.Name = "colSipEvrakSira"
        Me.colSipEvrakSira.Visible = True
        Me.colSipEvrakSira.VisibleIndex = 3
        '
        'colSiparisNo
        '
        Me.colSiparisNo.FieldName = "SiparisNo"
        Me.colSiparisNo.Name = "colSiparisNo"
        Me.colSiparisNo.Visible = True
        Me.colSiparisNo.VisibleIndex = 4
        '
        'colCariKod
        '
        Me.colCariKod.FieldName = "CariKod"
        Me.colCariKod.Name = "colCariKod"
        Me.colCariKod.Visible = True
        Me.colCariKod.VisibleIndex = 5
        '
        'colCariUnvan
        '
        Me.colCariUnvan.FieldName = "CariUnvan"
        Me.colCariUnvan.Name = "colCariUnvan"
        Me.colCariUnvan.Visible = True
        Me.colCariUnvan.VisibleIndex = 6
        '
        'colAciklama1
        '
        Me.colAciklama1.FieldName = "Aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Visible = True
        Me.colAciklama1.VisibleIndex = 11
        '
        'colAciklama2
        '
        Me.colAciklama2.FieldName = "Aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Visible = True
        Me.colAciklama2.VisibleIndex = 12
        '
        'colAciklama3
        '
        Me.colAciklama3.FieldName = "Aciklama3"
        Me.colAciklama3.Name = "colAciklama3"
        Me.colAciklama3.Visible = True
        Me.colAciklama3.VisibleIndex = 13
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TarihDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.cboOdemeDurumu)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit10)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.cboSiparisType)
        Me.DataLayoutControl1.Controls.Add(Me.txtDepo2)
        Me.DataLayoutControl1.Controls.Add(Me.txtDepo)
        Me.DataLayoutControl1.Controls.Add(Me.txtRiskBakiye)
        Me.DataLayoutControl1.Controls.Add(Me.txtBakiye)
        Me.DataLayoutControl1.Controls.Add(Me.SiparisIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeletedSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SipEvrakSeriTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SipEvrakSiraSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.txtCariKodu)
        Me.DataLayoutControl1.Controls.Add(Me.txtCariUnvan)
        Me.DataLayoutControl1.Controls.Add(Me.Aciklama1TextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.Aciklama2TextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.Aciklama3TextEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForSiparisID, Me.ItemForDeleted})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(411, 284, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(877, 146)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TarihDateEdit
        '
        Me.TarihDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Tarih", True))
        Me.TarihDateEdit.EditValue = Nothing
        Me.TarihDateEdit.EnterMoveNextControl = True
        Me.TarihDateEdit.Location = New System.Drawing.Point(648, 12)
        Me.TarihDateEdit.MenuManager = Me.BarManager1
        Me.TarihDateEdit.Name = "TarihDateEdit"
        Me.TarihDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TarihDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TarihDateEdit.Size = New System.Drawing.Size(217, 20)
        Me.TarihDateEdit.StyleController = Me.DataLayoutControl1
        Me.TarihDateEdit.TabIndex = 4
        '
        'cboOdemeDurumu
        '
        Me.cboOdemeDurumu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OdemeDurumu", True))
        Me.cboOdemeDurumu.EnterMoveNextControl = True
        Me.cboOdemeDurumu.Location = New System.Drawing.Point(468, 84)
        Me.cboOdemeDurumu.MenuManager = Me.BarManager1
        Me.cboOdemeDurumu.Name = "cboOdemeDurumu"
        Me.cboOdemeDurumu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOdemeDurumu.Properties.Items.AddRange(New Object() {"", "ÖDEMESİ GELDİ", "KISMİ ÖDEME"})
        Me.cboOdemeDurumu.Size = New System.Drawing.Size(161, 20)
        Me.cboOdemeDurumu.StyleController = Me.DataLayoutControl1
        Me.cboOdemeDurumu.TabIndex = 12
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Odenen", True))
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(712, 84)
        Me.TextEdit10.MenuManager = Me.BarManager1
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Size = New System.Drawing.Size(89, 20)
        Me.TextEdit10.StyleController = Me.DataLayoutControl1
        Me.TextEdit10.TabIndex = 13
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OkulFarki", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(781, 36)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(84, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 7
        '
        'cboSiparisType
        '
        Me.cboSiparisType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SiparisType", True))
        Me.cboSiparisType.Location = New System.Drawing.Point(91, 12)
        Me.cboSiparisType.MenuManager = Me.BarManager1
        Me.cboSiparisType.Name = "cboSiparisType"
        Me.cboSiparisType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSiparisType.Properties.DisplayMember = "DisplayMember"
        Me.cboSiparisType.Properties.NullText = ""
        Me.cboSiparisType.Properties.ShowHeader = False
        Me.cboSiparisType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboSiparisType.Properties.ValueMember = "ValueMember"
        Me.cboSiparisType.Size = New System.Drawing.Size(152, 20)
        Me.cboSiparisType.StyleController = Me.DataLayoutControl1
        Me.cboSiparisType.TabIndex = 0
        '
        'txtDepo2
        '
        Me.txtDepo2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Depo2", True))
        Me.txtDepo2.EnterMoveNextControl = True
        Me.txtDepo2.Location = New System.Drawing.Point(358, 60)
        Me.txtDepo2.MenuManager = Me.BarManager1
        Me.txtDepo2.Name = "txtDepo2"
        Me.txtDepo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDepo2.Size = New System.Drawing.Size(214, 20)
        Me.txtDepo2.StyleController = Me.DataLayoutControl1
        Me.txtDepo2.TabIndex = 9
        '
        'txtDepo
        '
        Me.txtDepo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Depo", True))
        Me.txtDepo.EnterMoveNextControl = True
        Me.txtDepo.Location = New System.Drawing.Point(91, 60)
        Me.txtDepo.MenuManager = Me.BarManager1
        Me.txtDepo.Name = "txtDepo"
        Me.txtDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDepo.Size = New System.Drawing.Size(184, 20)
        Me.txtDepo.StyleController = Me.DataLayoutControl1
        Me.txtDepo.TabIndex = 8
        '
        'txtRiskBakiye
        '
        Me.txtRiskBakiye.EnterMoveNextControl = True
        Me.txtRiskBakiye.Location = New System.Drawing.Point(285, 84)
        Me.txtRiskBakiye.MenuManager = Me.BarManager1
        Me.txtRiskBakiye.Name = "txtRiskBakiye"
        Me.txtRiskBakiye.Properties.ReadOnly = True
        Me.txtRiskBakiye.Size = New System.Drawing.Size(100, 20)
        Me.txtRiskBakiye.StyleController = Me.DataLayoutControl1
        Me.txtRiskBakiye.TabIndex = 11
        '
        'txtBakiye
        '
        Me.txtBakiye.EnterMoveNextControl = True
        Me.txtBakiye.Location = New System.Drawing.Point(91, 84)
        Me.txtBakiye.MenuManager = Me.BarManager1
        Me.txtBakiye.Name = "txtBakiye"
        Me.txtBakiye.Properties.ReadOnly = True
        Me.txtBakiye.Size = New System.Drawing.Size(111, 20)
        Me.txtBakiye.StyleController = Me.DataLayoutControl1
        Me.txtBakiye.TabIndex = 10
        '
        'SiparisIDSpinEdit
        '
        Me.SiparisIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SiparisID", True))
        Me.SiparisIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SiparisIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.SiparisIDSpinEdit.MenuManager = Me.BarManager1
        Me.SiparisIDSpinEdit.Name = "SiparisIDSpinEdit"
        Me.SiparisIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SiparisIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.SiparisIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.SiparisIDSpinEdit.TabIndex = 1
        '
        'DeletedSpinEdit
        '
        Me.DeletedSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Deleted", True))
        Me.DeletedSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DeletedSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.DeletedSpinEdit.MenuManager = Me.BarManager1
        Me.DeletedSpinEdit.Name = "DeletedSpinEdit"
        Me.DeletedSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeletedSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.DeletedSpinEdit.StyleController = Me.DataLayoutControl1
        Me.DeletedSpinEdit.TabIndex = 1
        '
        'SipEvrakSeriTextEdit
        '
        Me.SipEvrakSeriTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipEvrakSeri", True))
        Me.SipEvrakSeriTextEdit.EnterMoveNextControl = True
        Me.SipEvrakSeriTextEdit.Location = New System.Drawing.Point(326, 12)
        Me.SipEvrakSeriTextEdit.MenuManager = Me.BarManager1
        Me.SipEvrakSeriTextEdit.Name = "SipEvrakSeriTextEdit"
        Me.SipEvrakSeriTextEdit.Size = New System.Drawing.Size(81, 20)
        Me.SipEvrakSeriTextEdit.StyleController = Me.DataLayoutControl1
        Me.SipEvrakSeriTextEdit.TabIndex = 2
        '
        'SipEvrakSiraSpinEdit
        '
        Me.SipEvrakSiraSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipEvrakSira", True))
        Me.SipEvrakSiraSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SipEvrakSiraSpinEdit.EnterMoveNextControl = True
        Me.SipEvrakSiraSpinEdit.Location = New System.Drawing.Point(490, 12)
        Me.SipEvrakSiraSpinEdit.MenuManager = Me.BarManager1
        Me.SipEvrakSiraSpinEdit.Name = "SipEvrakSiraSpinEdit"
        Me.SipEvrakSiraSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SipEvrakSiraSpinEdit.Properties.DisplayFormat.FormatString = "00000"
        Me.SipEvrakSiraSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SipEvrakSiraSpinEdit.Properties.IsFloatValue = False
        Me.SipEvrakSiraSpinEdit.Properties.Mask.EditMask = "00000"
        Me.SipEvrakSiraSpinEdit.Size = New System.Drawing.Size(75, 20)
        Me.SipEvrakSiraSpinEdit.StyleController = Me.DataLayoutControl1
        Me.SipEvrakSiraSpinEdit.TabIndex = 3
        '
        'txtCariKodu
        '
        Me.txtCariKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariKod", True))
        Me.txtCariKodu.EnterMoveNextControl = True
        Me.txtCariKodu.Location = New System.Drawing.Point(91, 36)
        Me.txtCariKodu.MenuManager = Me.BarManager1
        Me.txtCariKodu.Name = "txtCariKodu"
        Me.txtCariKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCariKodu.Size = New System.Drawing.Size(216, 20)
        Me.txtCariKodu.StyleController = Me.DataLayoutControl1
        Me.txtCariKodu.TabIndex = 5
        '
        'txtCariUnvan
        '
        Me.txtCariUnvan.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariUnvan", True))
        Me.txtCariUnvan.EnterMoveNextControl = True
        Me.txtCariUnvan.Location = New System.Drawing.Point(390, 36)
        Me.txtCariUnvan.MenuManager = Me.BarManager1
        Me.txtCariUnvan.Name = "txtCariUnvan"
        Me.txtCariUnvan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCariUnvan.Size = New System.Drawing.Size(308, 20)
        Me.txtCariUnvan.StyleController = Me.DataLayoutControl1
        Me.txtCariUnvan.TabIndex = 6
        '
        'Aciklama1TextEdit
        '
        Me.Aciklama1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama1", True))
        Me.Aciklama1TextEdit.EnterMoveNextControl = True
        Me.Aciklama1TextEdit.Location = New System.Drawing.Point(91, 108)
        Me.Aciklama1TextEdit.MenuManager = Me.BarManager1
        Me.Aciklama1TextEdit.Name = "Aciklama1TextEdit"
        Me.Aciklama1TextEdit.Size = New System.Drawing.Size(284, 20)
        Me.Aciklama1TextEdit.StyleController = Me.DataLayoutControl1
        Me.Aciklama1TextEdit.TabIndex = 14
        '
        'Aciklama2TextEdit
        '
        Me.Aciklama2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama2", True))
        Me.Aciklama2TextEdit.EnterMoveNextControl = True
        Me.Aciklama2TextEdit.Location = New System.Drawing.Point(458, 108)
        Me.Aciklama2TextEdit.MenuManager = Me.BarManager1
        Me.Aciklama2TextEdit.Name = "Aciklama2TextEdit"
        Me.Aciklama2TextEdit.Size = New System.Drawing.Size(106, 20)
        Me.Aciklama2TextEdit.StyleController = Me.DataLayoutControl1
        Me.Aciklama2TextEdit.TabIndex = 15
        '
        'Aciklama3TextEdit
        '
        Me.Aciklama3TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama3", True))
        Me.Aciklama3TextEdit.EnterMoveNextControl = True
        Me.Aciklama3TextEdit.Location = New System.Drawing.Point(647, 108)
        Me.Aciklama3TextEdit.MenuManager = Me.BarManager1
        Me.Aciklama3TextEdit.Name = "Aciklama3TextEdit"
        Me.Aciklama3TextEdit.Size = New System.Drawing.Size(218, 20)
        Me.Aciklama3TextEdit.StyleController = Me.DataLayoutControl1
        Me.Aciklama3TextEdit.TabIndex = 16
        '
        'ItemForSiparisID
        '
        Me.ItemForSiparisID.Control = Me.SiparisIDSpinEdit
        Me.ItemForSiparisID.CustomizationFormText = "Siparis ID"
        Me.ItemForSiparisID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForSiparisID.Name = "ItemForSiparisID"
        Me.ItemForSiparisID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForSiparisID.Text = "Siparis ID"
        Me.ItemForSiparisID.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForDeleted
        '
        Me.ItemForDeleted.Control = Me.DeletedSpinEdit
        Me.ItemForDeleted.CustomizationFormText = "Deleted"
        Me.ItemForDeleted.Location = New System.Drawing.Point(0, 0)
        Me.ItemForDeleted.Name = "ItemForDeleted"
        Me.ItemForDeleted.Size = New System.Drawing.Size(0, 0)
        Me.ItemForDeleted.Text = "Deleted"
        Me.ItemForDeleted.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(877, 146)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTarih, Me.ItemForCariKod, Me.ItemForAciklama1, Me.ItemForSipEvrakSeri, Me.ItemForSipEvrakSira, Me.ItemForAciklama2, Me.ItemForCariUnvan, Me.ItemForAciklama3, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(857, 126)
        '
        'ItemForTarih
        '
        Me.ItemForTarih.Control = Me.TarihDateEdit
        Me.ItemForTarih.CustomizationFormText = "Tarih"
        Me.ItemForTarih.Location = New System.Drawing.Point(557, 0)
        Me.ItemForTarih.Name = "ItemForTarih"
        Me.ItemForTarih.Size = New System.Drawing.Size(300, 24)
        Me.ItemForTarih.Text = "Tarih"
        Me.ItemForTarih.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForCariKod
        '
        Me.ItemForCariKod.Control = Me.txtCariKodu
        Me.ItemForCariKod.CustomizationFormText = "Cari Kod"
        Me.ItemForCariKod.Location = New System.Drawing.Point(0, 24)
        Me.ItemForCariKod.Name = "ItemForCariKod"
        Me.ItemForCariKod.Size = New System.Drawing.Size(299, 24)
        Me.ItemForCariKod.Text = "Cari Kod"
        Me.ItemForCariKod.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForAciklama1
        '
        Me.ItemForAciklama1.Control = Me.Aciklama1TextEdit
        Me.ItemForAciklama1.CustomizationFormText = "Aciklama1"
        Me.ItemForAciklama1.Location = New System.Drawing.Point(0, 96)
        Me.ItemForAciklama1.Name = "ItemForAciklama1"
        Me.ItemForAciklama1.Size = New System.Drawing.Size(367, 30)
        Me.ItemForAciklama1.Text = "Aciklama1"
        Me.ItemForAciklama1.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForSipEvrakSeri
        '
        Me.ItemForSipEvrakSeri.Control = Me.SipEvrakSeriTextEdit
        Me.ItemForSipEvrakSeri.CustomizationFormText = "Sip Evrak Seri"
        Me.ItemForSipEvrakSeri.Location = New System.Drawing.Point(235, 0)
        Me.ItemForSipEvrakSeri.Name = "ItemForSipEvrakSeri"
        Me.ItemForSipEvrakSeri.Size = New System.Drawing.Size(164, 24)
        Me.ItemForSipEvrakSeri.Text = "Sip Evrak Seri"
        Me.ItemForSipEvrakSeri.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForSipEvrakSira
        '
        Me.ItemForSipEvrakSira.Control = Me.SipEvrakSiraSpinEdit
        Me.ItemForSipEvrakSira.CustomizationFormText = "Sip Evrak Sira"
        Me.ItemForSipEvrakSira.Location = New System.Drawing.Point(399, 0)
        Me.ItemForSipEvrakSira.Name = "ItemForSipEvrakSira"
        Me.ItemForSipEvrakSira.Size = New System.Drawing.Size(158, 24)
        Me.ItemForSipEvrakSira.Text = "Sip Evrak Sira"
        Me.ItemForSipEvrakSira.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForAciklama2
        '
        Me.ItemForAciklama2.Control = Me.Aciklama2TextEdit
        Me.ItemForAciklama2.CustomizationFormText = "Aciklama2"
        Me.ItemForAciklama2.Location = New System.Drawing.Point(367, 96)
        Me.ItemForAciklama2.Name = "ItemForAciklama2"
        Me.ItemForAciklama2.Size = New System.Drawing.Size(189, 30)
        Me.ItemForAciklama2.Text = "Aciklama2"
        Me.ItemForAciklama2.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForCariUnvan
        '
        Me.ItemForCariUnvan.Control = Me.txtCariUnvan
        Me.ItemForCariUnvan.CustomizationFormText = "Cari Unvan"
        Me.ItemForCariUnvan.Location = New System.Drawing.Point(299, 24)
        Me.ItemForCariUnvan.Name = "ItemForCariUnvan"
        Me.ItemForCariUnvan.Size = New System.Drawing.Size(391, 24)
        Me.ItemForCariUnvan.Text = "Cari Unvan"
        Me.ItemForCariUnvan.TextSize = New System.Drawing.Size(74, 13)
        '
        'ItemForAciklama3
        '
        Me.ItemForAciklama3.Control = Me.Aciklama3TextEdit
        Me.ItemForAciklama3.CustomizationFormText = "Aciklama3"
        Me.ItemForAciklama3.Location = New System.Drawing.Point(556, 96)
        Me.ItemForAciklama3.Name = "ItemForAciklama3"
        Me.ItemForAciklama3.Size = New System.Drawing.Size(301, 30)
        Me.ItemForAciklama3.Text = "Aciklama3"
        Me.ItemForAciklama3.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtBakiye
        Me.LayoutControlItem1.CustomizationFormText = "Bakiye"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem1.Text = "Bakiye"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtRiskBakiye
        Me.LayoutControlItem2.CustomizationFormText = "Risk Bakiye"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(194, 72)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(183, 24)
        Me.LayoutControlItem2.Text = "Risk Bakiye"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(74, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(793, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(64, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDepo
        Me.LayoutControlItem3.CustomizationFormText = "Depo"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem3.Text = "Depo"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtDepo2
        Me.LayoutControlItem4.CustomizationFormText = "Hedef depo"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(267, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem4.Text = "Hedef depo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(74, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(564, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(293, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboSiparisType
        Me.LayoutControlItem5.CustomizationFormText = "Türü"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem5.Text = "Türü"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextEdit10
        Me.LayoutControlItem7.CustomizationFormText = "Ödenen"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(621, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem7.Text = "Ödenen"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cboOdemeDurumu
        Me.LayoutControlItem6.CustomizationFormText = "Ödeme Durumu"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(377, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem6.Text = "Ödeme Durumu"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TextEdit1
        Me.LayoutControlItem8.CustomizationFormText = "Okul Farkı(%)"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(690, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(167, 24)
        Me.LayoutControlItem8.Text = "Okul Farkı(%)"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(74, 13)
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.GridControl2.DataSource = Me.DetailLink
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 200)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.BarManager1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.btnGridSipDetay, Me.btnGridSipDetayRemove, Me.RepositoryItemLookUpEdit4, Me.txtStokKod, Me.txtStokIsmi, Me.RepositoryItemCheckEdit3, Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit6})
        Me.GridControl2.Size = New System.Drawing.Size(881, 44)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSipDetayBagla, Me.mnuSipDetayBaglantiIptal, Me.ToolStripMenuItem1, Me.SatirSilToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(179, 88)
        '
        'mnuSipDetayBagla
        '
        Me.mnuSipDetayBagla.Name = "mnuSipDetayBagla"
        Me.mnuSipDetayBagla.Size = New System.Drawing.Size(178, 26)
        Me.mnuSipDetayBagla.Text = "Ustteki Satıra Bağla"
        '
        'mnuSipDetayBaglantiIptal
        '
        Me.mnuSipDetayBaglantiIptal.Image = Global.ProbarSiparis.My.Resources.Resources.delete_16
        Me.mnuSipDetayBaglantiIptal.Name = "mnuSipDetayBaglantiIptal"
        Me.mnuSipDetayBaglantiIptal.Size = New System.Drawing.Size(178, 26)
        Me.mnuSipDetayBaglantiIptal.Text = "Bağlantıyı iptal et"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 6)
        '
        'SatirSilToolStripMenuItem
        '
        Me.SatirSilToolStripMenuItem.Name = "SatirSilToolStripMenuItem"
        Me.SatirSilToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.SatirSilToolStripMenuItem.Text = "Satir Sil"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSipDetayID1, Me.colSipDetayID, Me.colSipDetayID3, Me.colSiparisID1, Me.colOkulID, Me.colKategoriID, Me.colKategoriID1, Me.colMiktar, Me.colDurumu, Me.colBoyahane, Me.colStokRecNo, Me.colSiparisAciklama, Me.colFiyat, Me.colTutar, Me.colDovizTipi, Me.colDovizKuru, Me.colGenelToplam, Me.colDovizliTutar, Me.colKdvOran, Me.colKdvTutar, Me.colTarih1, Me.colTerminTarihi, Me.colSipDetayID2, Me.colBolumKod, Me.colStokKod, Me.colStokIsmi, Me.colBagli, Me.colBagliSipDetayID, Me.colIskonto, Me.colIskontoTutar, Me.colNakitIskonto, Me.colNakitIskontoTutar})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[Bagli] == 1"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsLayout.LayoutVersion = "1.2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView2.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSipDetayID1
        '
        Me.colSipDetayID1.Caption = "Sil"
        Me.colSipDetayID1.ColumnEdit = Me.btnGridSipDetayRemove
        Me.colSipDetayID1.FieldName = "SipDetayID"
        Me.colSipDetayID1.Name = "colSipDetayID1"
        Me.colSipDetayID1.Visible = True
        Me.colSipDetayID1.VisibleIndex = 21
        Me.colSipDetayID1.Width = 40
        '
        'btnGridSipDetayRemove
        '
        Me.btnGridSipDetayRemove.AutoHeight = False
        Me.btnGridSipDetayRemove.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "X", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnGridSipDetayRemove.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnGridSipDetayRemove.Name = "btnGridSipDetayRemove"
        Me.btnGridSipDetayRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colSipDetayID
        '
        Me.colSipDetayID.Caption = ">>>"
        Me.colSipDetayID.ColumnEdit = Me.btnGridSipDetay
        Me.colSipDetayID.FieldName = "SipDetayID"
        Me.colSipDetayID.Name = "colSipDetayID"
        Me.colSipDetayID.Visible = True
        Me.colSipDetayID.VisibleIndex = 0
        Me.colSipDetayID.Width = 37
        '
        'btnGridSipDetay
        '
        Me.btnGridSipDetay.AutoHeight = False
        Me.btnGridSipDetay.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnGridSipDetay.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.btnGridSipDetay.Name = "btnGridSipDetay"
        Me.btnGridSipDetay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colSipDetayID3
        '
        Me.colSipDetayID3.Caption = "#TakipNo"
        Me.colSipDetayID3.FieldName = "SipDetayID"
        Me.colSipDetayID3.Name = "colSipDetayID3"
        Me.colSipDetayID3.OptionsColumn.AllowEdit = False
        Me.colSipDetayID3.Visible = True
        Me.colSipDetayID3.VisibleIndex = 1
        Me.colSipDetayID3.Width = 71
        '
        'colSiparisID1
        '
        Me.colSiparisID1.FieldName = "SiparisID"
        Me.colSiparisID1.Name = "colSiparisID1"
        Me.colSiparisID1.OptionsColumn.AllowEdit = False
        '
        'colOkulID
        '
        Me.colOkulID.Caption = "Okul Ismi"
        Me.colOkulID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colOkulID.FieldName = "OkulID"
        Me.colOkulID.Name = "colOkulID"
        Me.colOkulID.OptionsColumn.AllowEdit = False
        Me.colOkulID.Visible = True
        Me.colOkulID.VisibleIndex = 8
        Me.colOkulID.Width = 230
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OkulKod", "Okul Kod", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OkulIsmi", "Okul Ismi", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlceIsmi", "Ilce Ismi", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlIsmi", "Il Ismi", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OkulID", "Okul ID", 58, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.tbOkul
        Me.RepositoryItemLookUpEdit1.DisplayMember = "DisplayText"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "OkulID"
        '
        'tbOkul
        '
        Me.tbOkul.Columns.AddRange(New System.Data.DataColumn() {Me.tbOkul_OkulID, Me.tbOkul_OkulKod, Me.tbOkul_OkulIsmi, Me.tbOkul_IlceID, Me.tbOkul_IlID, Me.tbOkul_IlIsmi, Me.tbOkul_IlceIsmi, Me.tbOkul_DisplayText})
        Me.tbOkul.Connection = Me.FirmConn
        Me.tbOkul.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"OkulID"}, True)})
        Me.tbOkul.CurrentRow = Nothing
        Me.tbOkul.DataSourceLink = Nothing
        Me.tbOkul.DeleteCommand = Me.SqlCommand12
        Me.tbOkul.Filter = ""
        Me.tbOkul.InsertCommand = Me.SqlCommand10
        Me.tbOkul.LiveSave = False
        Me.tbOkul.MaxRecords = CType(0, Long)
        Me.tbOkul.Name = "tbOkul"
        Me.tbOkul.ParentRelation_ChildColumns = Nothing
        Me.tbOkul.ParentRelation_ParentColumns = Nothing
        Me.tbOkul.ParentRelation_Table = Nothing
        Me.tbOkul.Position = CType(-1, Long)
        Me.tbOkul.PrimaryKey = New System.Data.DataColumn() {Me.tbOkul_OkulID}
        Me.tbOkul.Quoted = False
        Me.tbOkul.SelectCommand = Me.SqlCommand9
        Me.tbOkul.TableName = "NeoTable1"
        Me.tbOkul.Transaction = Nothing
        Me.tbOkul.UpdateCommand = Me.SqlCommand11
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
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = resources.GetString("SqlCommand9.CommandText")
        '
        'colKategoriID
        '
        Me.colKategoriID.Caption = "Kategori Kod"
        Me.colKategoriID.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colKategoriID.FieldName = "KategoriID"
        Me.colKategoriID.Name = "colKategoriID"
        Me.colKategoriID.OptionsColumn.AllowEdit = False
        Me.colKategoriID.Visible = True
        Me.colKategoriID.VisibleIndex = 2
        Me.colKategoriID.Width = 89
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.tbKategori
        Me.RepositoryItemLookUpEdit2.DisplayMember = "KategoriKod"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "KategoriID"
        '
        'tbKategori
        '
        Me.tbKategori.Columns.AddRange(New System.Data.DataColumn() {Me.tbKategori_KategoriID, Me.tbKategori_UstKategoriID, Me.tbKategori_KategoriKod, Me.tbKategori_KategoriIsim, Me.tbKategori_StokKodFormat, Me.tbKategori_IntCode})
        Me.tbKategori.Connection = Me.FirmConn
        Me.tbKategori.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriID"}, True)})
        Me.tbKategori.CurrentRow = Nothing
        Me.tbKategori.DataSourceLink = Nothing
        Me.tbKategori.DeleteCommand = Me.SqlCommand16
        Me.tbKategori.Filter = ""
        Me.tbKategori.InsertCommand = Me.SqlCommand14
        Me.tbKategori.LiveSave = False
        Me.tbKategori.MaxRecords = CType(0, Long)
        Me.tbKategori.Name = "tbKategori"
        Me.tbKategori.ParentRelation_ChildColumns = Nothing
        Me.tbKategori.ParentRelation_ParentColumns = Nothing
        Me.tbKategori.ParentRelation_Table = Nothing
        Me.tbKategori.Position = CType(-1, Long)
        Me.tbKategori.PrimaryKey = New System.Data.DataColumn() {Me.tbKategori_KategoriID}
        Me.tbKategori.Quoted = False
        Me.tbKategori.SelectCommand = Me.SqlCommand13
        Me.tbKategori.TableName = "NeoTable1"
        Me.tbKategori.Transaction = Nothing
        Me.tbKategori.UpdateCommand = Me.SqlCommand15
        '
        'tbKategori_KategoriID
        '
        Me.tbKategori_KategoriID.AllowDBNull = False
        Me.tbKategori_KategoriID.AutoIncrement = True
        Me.tbKategori_KategoriID.ColumnName = "KategoriID"
        Me.tbKategori_KategoriID.DataType = GetType(Integer)
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
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT     KategoriID, UstKategoriID, KategoriKod, KategoriIsim, StokKodFormat, I" &
    "ntCode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Kategoriler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted=0"
        '
        'colKategoriID1
        '
        Me.colKategoriID1.Caption = "Kategori Isim"
        Me.colKategoriID1.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colKategoriID1.FieldName = "KategoriID"
        Me.colKategoriID1.Name = "colKategoriID1"
        Me.colKategoriID1.OptionsColumn.AllowEdit = False
        Me.colKategoriID1.Visible = True
        Me.colKategoriID1.VisibleIndex = 3
        Me.colKategoriID1.Width = 181
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriIsim", "Kategori Isim", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriID", "Kategori ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriKod", "Kategori Kod", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.tbKategori
        Me.RepositoryItemLookUpEdit4.DisplayMember = "KategoriIsim"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit4.ValueMember = "KategoriID"
        '
        'colMiktar
        '
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.OptionsColumn.AllowEdit = False
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 9
        '
        'colDurumu
        '
        Me.colDurumu.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colDurumu.FieldName = "Durumu"
        Me.colDurumu.Name = "colDurumu"
        Me.colDurumu.OptionsColumn.AllowEdit = False
        Me.colDurumu.OptionsColumn.ReadOnly = True
        Me.colDurumu.Visible = True
        Me.colDurumu.VisibleIndex = 4
        Me.colDurumu.Width = 113
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"", "URETIMDE", "ORGUDE", "BITTI"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colBoyahane
        '
        Me.colBoyahane.Caption = "Boyahane"
        Me.colBoyahane.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.colBoyahane.FieldName = "BoyahaneID"
        Me.colBoyahane.Name = "colBoyahane"
        Me.colBoyahane.Visible = True
        Me.colBoyahane.VisibleIndex = 6
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BoyahaneID", "Boyahane ID", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Boyahane", "Boyahane", 58, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.tbBoyahaneler
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Boyahane"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ValueMember = "BoyahaneID"
        '
        'tbBoyahaneler
        '
        Me.tbBoyahaneler.Columns.AddRange(New System.Data.DataColumn() {Me.tbBoyahaneler_BoyahaneID, Me.tbBoyahaneler_Boyahane})
        Me.tbBoyahaneler.Connection = Me.FirmConn
        Me.tbBoyahaneler.CurrentRow = Nothing
        Me.tbBoyahaneler.DataSourceLink = Nothing
        Me.tbBoyahaneler.DeleteCommand = Me.SqlCommand24
        Me.tbBoyahaneler.Filter = ""
        Me.tbBoyahaneler.InsertCommand = Me.SqlCommand22
        Me.tbBoyahaneler.LiveSave = False
        Me.tbBoyahaneler.MaxRecords = CType(0, Long)
        Me.tbBoyahaneler.Name = "tbBoyahaneler"
        Me.tbBoyahaneler.ParentRelation_ChildColumns = Nothing
        Me.tbBoyahaneler.ParentRelation_ParentColumns = Nothing
        Me.tbBoyahaneler.ParentRelation_Table = Nothing
        Me.tbBoyahaneler.Position = CType(-1, Long)
        Me.tbBoyahaneler.Quoted = False
        Me.tbBoyahaneler.SelectCommand = Me.SqlCommand21
        Me.tbBoyahaneler.TableName = "NeoTable1"
        Me.tbBoyahaneler.Transaction = Nothing
        Me.tbBoyahaneler.UpdateCommand = Me.SqlCommand23
        '
        'tbBoyahaneler_BoyahaneID
        '
        Me.tbBoyahaneler_BoyahaneID.AutoIncrement = True
        Me.tbBoyahaneler_BoyahaneID.ColumnName = "BoyahaneID"
        Me.tbBoyahaneler_BoyahaneID.DataType = GetType(Integer)
        '
        'tbBoyahaneler_Boyahane
        '
        Me.tbBoyahaneler_Boyahane.ColumnName = "Boyahane"
        '
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = "SELECT BoyahaneID, Boyahane FROM Boyahaneler WHERE Deleted = 0 "
        '
        'colStokRecNo
        '
        Me.colStokRecNo.FieldName = "StokRecNo"
        Me.colStokRecNo.Name = "colStokRecNo"
        Me.colStokRecNo.OptionsColumn.AllowEdit = False
        '
        'colSiparisAciklama
        '
        Me.colSiparisAciklama.FieldName = "SiparisAciklama"
        Me.colSiparisAciklama.Name = "colSiparisAciklama"
        Me.colSiparisAciklama.OptionsColumn.AllowEdit = False
        Me.colSiparisAciklama.Visible = True
        Me.colSiparisAciklama.VisibleIndex = 20
        Me.colSiparisAciklama.Width = 141
        '
        'colFiyat
        '
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.OptionsColumn.AllowEdit = False
        '
        'colTutar
        '
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.OptionsColumn.AllowEdit = False
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 13
        '
        'colDovizTipi
        '
        Me.colDovizTipi.FieldName = "DovizTipi"
        Me.colDovizTipi.Name = "colDovizTipi"
        Me.colDovizTipi.OptionsColumn.AllowEdit = False
        Me.colDovizTipi.Visible = True
        Me.colDovizTipi.VisibleIndex = 17
        '
        'colDovizKuru
        '
        Me.colDovizKuru.FieldName = "DovizKuru"
        Me.colDovizKuru.Name = "colDovizKuru"
        Me.colDovizKuru.OptionsColumn.AllowEdit = False
        Me.colDovizKuru.Visible = True
        Me.colDovizKuru.VisibleIndex = 18
        '
        'colGenelToplam
        '
        Me.colGenelToplam.FieldName = "GenelToplam"
        Me.colGenelToplam.Name = "colGenelToplam"
        Me.colGenelToplam.OptionsColumn.AllowEdit = False
        Me.colGenelToplam.Visible = True
        Me.colGenelToplam.VisibleIndex = 16
        '
        'colDovizliTutar
        '
        Me.colDovizliTutar.FieldName = "DovizliTutar"
        Me.colDovizliTutar.Name = "colDovizliTutar"
        Me.colDovizliTutar.OptionsColumn.AllowEdit = False
        Me.colDovizliTutar.Visible = True
        Me.colDovizliTutar.VisibleIndex = 19
        '
        'colKdvOran
        '
        Me.colKdvOran.FieldName = "KdvOran"
        Me.colKdvOran.Name = "colKdvOran"
        Me.colKdvOran.OptionsColumn.AllowEdit = False
        Me.colKdvOran.Visible = True
        Me.colKdvOran.VisibleIndex = 14
        Me.colKdvOran.Width = 49
        '
        'colKdvTutar
        '
        Me.colKdvTutar.FieldName = "KdvTutar"
        Me.colKdvTutar.Name = "colKdvTutar"
        Me.colKdvTutar.OptionsColumn.AllowEdit = False
        Me.colKdvTutar.Visible = True
        Me.colKdvTutar.VisibleIndex = 15
        '
        'colTarih1
        '
        Me.colTarih1.FieldName = "Tarih"
        Me.colTarih1.Name = "colTarih1"
        Me.colTarih1.OptionsColumn.AllowEdit = False
        Me.colTarih1.Visible = True
        Me.colTarih1.VisibleIndex = 5
        '
        'colTerminTarihi
        '
        Me.colTerminTarihi.FieldName = "TerminTarihi"
        Me.colTerminTarihi.Name = "colTerminTarihi"
        Me.colTerminTarihi.OptionsColumn.AllowEdit = False
        Me.colTerminTarihi.Visible = True
        Me.colTerminTarihi.VisibleIndex = 7
        Me.colTerminTarihi.Width = 104
        '
        'colSipDetayID2
        '
        Me.colSipDetayID2.FieldName = "SipDetayID"
        Me.colSipDetayID2.Name = "colSipDetayID2"
        '
        'colBolumKod
        '
        Me.colBolumKod.FieldName = "BolumKod"
        Me.colBolumKod.Name = "colBolumKod"
        Me.colBolumKod.OptionsColumn.AllowEdit = False
        Me.colBolumKod.Visible = True
        Me.colBolumKod.VisibleIndex = 22
        '
        'colStokKod
        '
        Me.colStokKod.Caption = "Mikro Stok Kod"
        Me.colStokKod.ColumnEdit = Me.txtStokKod
        Me.colStokKod.FieldName = "StokKod"
        Me.colStokKod.Name = "colStokKod"
        Me.colStokKod.Visible = True
        Me.colStokKod.VisibleIndex = 11
        Me.colStokKod.Width = 153
        '
        'txtStokKod
        '
        Me.txtStokKod.AutoHeight = False
        Me.txtStokKod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtStokKod.Name = "txtStokKod"
        '
        'colStokIsmi
        '
        Me.colStokIsmi.Caption = "Mikro Stok Ismi"
        Me.colStokIsmi.ColumnEdit = Me.txtStokIsmi
        Me.colStokIsmi.FieldName = "StokIsmi"
        Me.colStokIsmi.Name = "colStokIsmi"
        Me.colStokIsmi.Visible = True
        Me.colStokIsmi.VisibleIndex = 12
        Me.colStokIsmi.Width = 216
        '
        'txtStokIsmi
        '
        Me.txtStokIsmi.AutoHeight = False
        Me.txtStokIsmi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtStokIsmi.Name = "txtStokIsmi"
        '
        'colBagli
        '
        Me.colBagli.Caption = "Bağlı?"
        Me.colBagli.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.colBagli.FieldName = "Bagli"
        Me.colBagli.Name = "colBagli"
        Me.colBagli.OptionsColumn.AllowEdit = False
        Me.colBagli.Visible = True
        Me.colBagli.VisibleIndex = 10
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit3.ValueChecked = 1
        Me.RepositoryItemCheckEdit3.ValueUnchecked = 0
        '
        'colBagliSipDetayID
        '
        Me.colBagliSipDetayID.FieldName = "BagliSipDetayID"
        Me.colBagliSipDetayID.Name = "colBagliSipDetayID"
        Me.colBagliSipDetayID.OptionsColumn.AllowEdit = False
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Sezon Isk.%"
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.OptionsColumn.AllowEdit = False
        Me.colIskonto.Visible = True
        Me.colIskonto.VisibleIndex = 23
        '
        'colIskontoTutar
        '
        Me.colIskontoTutar.Caption = "Sezon Isk. Tutar"
        Me.colIskontoTutar.FieldName = "IskontoTutar"
        Me.colIskontoTutar.Name = "colIskontoTutar"
        Me.colIskontoTutar.OptionsColumn.AllowEdit = False
        Me.colIskontoTutar.Visible = True
        Me.colIskontoTutar.VisibleIndex = 24
        '
        'colNakitIskonto
        '
        Me.colNakitIskonto.Caption = "Nakit Isk. %"
        Me.colNakitIskonto.FieldName = "NakitIskonto"
        Me.colNakitIskonto.Name = "colNakitIskonto"
        Me.colNakitIskonto.OptionsColumn.AllowEdit = False
        Me.colNakitIskonto.Visible = True
        Me.colNakitIskonto.VisibleIndex = 25
        '
        'colNakitIskontoTutar
        '
        Me.colNakitIskontoTutar.Caption = "Nakit Isk. Tutar"
        Me.colNakitIskontoTutar.FieldName = "NakitIskontoTutar"
        Me.colNakitIskontoTutar.Name = "colNakitIskontoTutar"
        Me.colNakitIskontoTutar.OptionsColumn.AllowEdit = False
        Me.colNakitIskontoTutar.Visible = True
        Me.colNakitIskontoTutar.VisibleIndex = 26
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM SipDetay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted=0  "
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = resources.GetString("SqlCommand7.CommandText")
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "UPDATE SipDetay SET Deleted = SipDetayID  , ModifiedBy = @ModifiedBy , ModifiedDa" &
    "te = GETDATE()   WHERE SipDetayID = @SipDetayID"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 34)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl2.Size = New System.Drawing.Size(887, 321)
        Me.XtraTabControl2.TabIndex = 3
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl2)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Controls.Add(Me.SplitterControl1)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(881, 293)
        Me.XtraTabPage1.Text = "Sipariş"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SpinEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.TextEdit3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtKdvOran)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.TextEdit5)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.TextEdit4)
        Me.PanelControl1.Controls.Add(Me.TextEdit2)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.TextEdit7)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.TextEdit6)
        Me.PanelControl1.Controls.Add(Me.cboDoviz)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 244)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(881, 49)
        Me.PanelControl1.TabIndex = 4
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "VadeFarkiOran", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.EnterMoveNextControl = True
        Me.SpinEdit1.Location = New System.Drawing.Point(110, 21)
        Me.SpinEdit1.MenuManager = Me.BarManager1
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.EditFormat.FormatString = "#,##0,00"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(63, 20)
        Me.SpinEdit1.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(140, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl3.TabIndex = 43
        Me.LabelControl3.Text = "%"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "VadeFarkiTutar", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(179, 21)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit3.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(179, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 42
        Me.LabelControl4.Text = "Vade Farki"
        '
        'txtKdvOran
        '
        Me.txtKdvOran.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KdvOran", True))
        Me.txtKdvOran.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtKdvOran.EnterMoveNextControl = True
        Me.txtKdvOran.Location = New System.Drawing.Point(275, 21)
        Me.txtKdvOran.MenuManager = Me.BarManager1
        Me.txtKdvOran.Name = "txtKdvOran"
        Me.txtKdvOran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtKdvOran.Properties.IsFloatValue = False
        Me.txtKdvOran.Properties.Mask.EditMask = "N00"
        Me.txtKdvOran.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtKdvOran.Size = New System.Drawing.Size(52, 20)
        Me.txtKdvOran.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(333, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 39
        Me.LabelControl1.Text = "Kdv Tutar"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "GenelToplam", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(428, 21)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(103, 20)
        Me.TextEdit5.TabIndex = 5
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(438, 7)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl12.TabIndex = 38
        Me.LabelControl12.Text = "Genel Toplam"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "AraToplam", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(8, 21)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(95, 20)
        Me.TextEdit4.TabIndex = 0
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KdvTutar", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(329, 21)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(90, 20)
        Me.TextEdit2.TabIndex = 4
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(295, 7)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl11.TabIndex = 37
        Me.LabelControl11.Text = "Kdv %"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(8, 7)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl10.TabIndex = 36
        Me.LabelControl10.Text = "Ara Toplam"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(713, 7)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl15.TabIndex = 31
        Me.LabelControl15.Text = "Yerel Tutar"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "DovizliTutar", True))
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(713, 21)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(106, 20)
        Me.TextEdit7.TabIndex = 8
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(635, 7)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl14.TabIndex = 30
        Me.LabelControl14.Text = "Kur"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(551, 7)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl13.TabIndex = 29
        Me.LabelControl13.Text = "Para Birimi"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "DovizKuru", True))
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(635, 21)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(66, 20)
        Me.TextEdit6.TabIndex = 7
        '
        'cboDoviz
        '
        Me.cboDoviz.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "DovizTipi", True))
        Me.cboDoviz.EditValue = "TL"
        Me.cboDoviz.EnterMoveNextControl = True
        Me.cboDoviz.Location = New System.Drawing.Point(551, 21)
        Me.cboDoviz.Name = "cboDoviz"
        Me.cboDoviz.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDoviz.Properties.Items.AddRange(New Object() {"TL", "USD", "EUR", "CAD", "DKK", "SEK", "CHF", "NOK", "JPY", "SAR", "KWD", "AUD", "GBP", "IRR", "SYP", "JOD", "BGL", "RON", "ILS", "AZN"})
        Me.cboDoviz.Size = New System.Drawing.Size(65, 20)
        Me.cboDoviz.TabIndex = 6
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 195)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(881, 5)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.DataLayoutControl1)
        Me.PanelControl2.Controls.Add(Me.PanelControl4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(881, 195)
        Me.PanelControl2.TabIndex = 3
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LookUpEdit2)
        Me.PanelControl4.Controls.Add(Me.LookUpEdit1)
        Me.PanelControl4.Controls.Add(Me.LabelControl5)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.cmdAddSipDetay)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 148)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(877, 45)
        Me.PanelControl4.TabIndex = 2
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SiparisAlanID", True))
        Me.LookUpEdit2.Location = New System.Drawing.Point(333, 21)
        Me.LookUpEdit2.MenuManager = Me.BarManager1
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SipAlanIsmi", "Sip Alan Ismi", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SiparisAlanID", "Siparis Alan ID", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit2.Properties.DataSource = Me.NeoTable1
        Me.LookUpEdit2.Properties.DisplayMember = "SipAlanIsmi"
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.ShowHeader = False
        Me.LookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit2.Properties.ValueMember = "SiparisAlanID"
        Me.LookUpEdit2.Size = New System.Drawing.Size(195, 20)
        Me.LookUpEdit2.TabIndex = 4
        '
        'NeoTable1
        '
        Me.NeoTable1.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable1_SiparisAlanID, Me.NeoTable1_Deleted, Me.NeoTable1_CreatedBy, Me.NeoTable1_CreatedDate, Me.NeoTable1_ModifiedBy, Me.NeoTable1_ModifiedDate, Me.NeoTable1_SipAlanIsmi, Me.NeoTable1_IntCode})
        Me.NeoTable1.Connection = Me.FirmConn
        Me.NeoTable1.CurrentRow = Nothing
        Me.NeoTable1.DataSourceLink = Nothing
        Me.NeoTable1.DeleteCommand = Me.SqlCommand20
        Me.NeoTable1.Filter = ""
        Me.NeoTable1.InsertCommand = Me.SqlCommand18
        Me.NeoTable1.LiveSave = False
        Me.NeoTable1.MaxRecords = CType(0, Long)
        Me.NeoTable1.Name = "NeoTable1"
        Me.NeoTable1.ParentRelation_ChildColumns = Nothing
        Me.NeoTable1.ParentRelation_ParentColumns = Nothing
        Me.NeoTable1.ParentRelation_Table = Nothing
        Me.NeoTable1.Position = CType(-1, Long)
        Me.NeoTable1.Quoted = False
        Me.NeoTable1.SelectCommand = Me.SqlCommand17
        Me.NeoTable1.TableName = "NeoTable1"
        Me.NeoTable1.Transaction = Nothing
        Me.NeoTable1.UpdateCommand = Me.SqlCommand19
        '
        'NeoTable1_SiparisAlanID
        '
        Me.NeoTable1_SiparisAlanID.AutoIncrement = True
        Me.NeoTable1_SiparisAlanID.ColumnName = "SiparisAlanID"
        Me.NeoTable1_SiparisAlanID.DataType = GetType(Integer)
        '
        'NeoTable1_Deleted
        '
        Me.NeoTable1_Deleted.ColumnName = "Deleted"
        Me.NeoTable1_Deleted.DataType = GetType(Integer)
        '
        'NeoTable1_CreatedBy
        '
        Me.NeoTable1_CreatedBy.ColumnName = "CreatedBy"
        Me.NeoTable1_CreatedBy.DataType = GetType(Integer)
        '
        'NeoTable1_CreatedDate
        '
        Me.NeoTable1_CreatedDate.ColumnName = "CreatedDate"
        Me.NeoTable1_CreatedDate.DataType = GetType(Date)
        '
        'NeoTable1_ModifiedBy
        '
        Me.NeoTable1_ModifiedBy.ColumnName = "ModifiedBy"
        Me.NeoTable1_ModifiedBy.DataType = GetType(Integer)
        '
        'NeoTable1_ModifiedDate
        '
        Me.NeoTable1_ModifiedDate.ColumnName = "ModifiedDate"
        Me.NeoTable1_ModifiedDate.DataType = GetType(Date)
        '
        'NeoTable1_SipAlanIsmi
        '
        Me.NeoTable1_SipAlanIsmi.ColumnName = "SipAlanIsmi"
        '
        'NeoTable1_IntCode
        '
        Me.NeoTable1_IntCode.ColumnName = "IntCode"
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT * FROM SiparisAlanlar WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SaticiID", True))
        Me.LookUpEdit1.EnterMoveNextControl = True
        Me.LookUpEdit1.Location = New System.Drawing.Point(138, 20)
        Me.LookUpEdit1.MenuManager = Me.BarManager1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaticiIsmi", "Satici Ismi", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaticiID", "Satici ID", 5, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit1.Properties.DataSource = Me.tbSaticilar
        Me.LookUpEdit1.Properties.DisplayMember = "SaticiIsmi"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ShowHeader = False
        Me.LookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit1.Properties.ValueMember = "SaticiID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(152, 20)
        Me.LookUpEdit1.TabIndex = 2
        '
        'tbSaticilar
        '
        Me.tbSaticilar.Columns.AddRange(New System.Data.DataColumn() {Me.tbSaticilar_SaticiID, Me.tbSaticilar_SaticiIsmi})
        Me.tbSaticilar.Connection = Me.FirmConn
        Me.tbSaticilar.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SaticiID"}, True)})
        Me.tbSaticilar.CurrentRow = Nothing
        Me.tbSaticilar.DataSourceLink = Nothing
        Me.tbSaticilar.DeleteCommand = Me.SqlCommand28
        Me.tbSaticilar.Filter = ""
        Me.tbSaticilar.InsertCommand = Me.SqlCommand26
        Me.tbSaticilar.LiveSave = False
        Me.tbSaticilar.MaxRecords = CType(0, Long)
        Me.tbSaticilar.Name = "tbSaticilar"
        Me.tbSaticilar.ParentRelation_ChildColumns = Nothing
        Me.tbSaticilar.ParentRelation_ParentColumns = Nothing
        Me.tbSaticilar.ParentRelation_Table = Nothing
        Me.tbSaticilar.Position = CType(-1, Long)
        Me.tbSaticilar.PrimaryKey = New System.Data.DataColumn() {Me.tbSaticilar_SaticiID}
        Me.tbSaticilar.Quoted = False
        Me.tbSaticilar.SelectCommand = Me.SqlCommand25
        Me.tbSaticilar.TableName = "NeoTable1"
        Me.tbSaticilar.Transaction = Nothing
        Me.tbSaticilar.UpdateCommand = Me.SqlCommand27
        '
        'tbSaticilar_SaticiID
        '
        Me.tbSaticilar_SaticiID.AllowDBNull = False
        Me.tbSaticilar_SaticiID.AutoIncrement = True
        Me.tbSaticilar_SaticiID.ColumnName = "SaticiID"
        Me.tbSaticilar_SaticiID.DataType = GetType(Integer)
        '
        'tbSaticilar_SaticiIsmi
        '
        Me.tbSaticilar_SaticiIsmi.ColumnName = "SaticiIsmi"
        '
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT SaticiID, SaticiIsmi FROM Saticilar WHERE Deleted=0"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl5.Location = New System.Drawing.Point(332, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Siparisi Alan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(138, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Satici"
        '
        'cmdAddSipDetay
        '
        Me.cmdAddSipDetay.Location = New System.Drawing.Point(8, 15)
        Me.cmdAddSipDetay.Name = "cmdAddSipDetay"
        Me.cmdAddSipDetay.Size = New System.Drawing.Size(96, 25)
        Me.cmdAddSipDetay.TabIndex = 0
        Me.cmdAddSipDetay.Text = "(+) Ekle"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 43
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'panelAdmin
        '
        Me.panelAdmin.Controls.Add(Me.chkIptal)
        Me.panelAdmin.Controls.Add(Me.cmdIptal)
        Me.panelAdmin.Controls.Add(Me.chkOnayli)
        Me.panelAdmin.Controls.Add(Me.cmdOnayla)
        Me.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAdmin.Location = New System.Drawing.Point(0, 0)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.Size = New System.Drawing.Size(887, 34)
        Me.panelAdmin.TabIndex = 4
        '
        'chkIptal
        '
        Me.chkIptal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Iptal", True))
        Me.chkIptal.Location = New System.Drawing.Point(278, 7)
        Me.chkIptal.MenuManager = Me.BarManager1
        Me.chkIptal.Name = "chkIptal"
        Me.chkIptal.Properties.Caption = "İptal?"
        Me.chkIptal.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkIptal.Properties.ReadOnly = True
        Me.chkIptal.Properties.ValueChecked = 1
        Me.chkIptal.Properties.ValueUnchecked = 0
        Me.chkIptal.Size = New System.Drawing.Size(62, 19)
        Me.chkIptal.TabIndex = 4
        '
        'cmdIptal
        '
        Me.cmdIptal.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdIptal.Appearance.Options.UseForeColor = True
        Me.cmdIptal.Location = New System.Drawing.Point(346, 5)
        Me.cmdIptal.Name = "cmdIptal"
        Me.cmdIptal.Size = New System.Drawing.Size(120, 25)
        Me.cmdIptal.TabIndex = 3
        Me.cmdIptal.Text = "(X) İptal"
        '
        'chkOnayli
        '
        Me.chkOnayli.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Onayli", True))
        Me.chkOnayli.Location = New System.Drawing.Point(10, 7)
        Me.chkOnayli.MenuManager = Me.BarManager1
        Me.chkOnayli.Name = "chkOnayli"
        Me.chkOnayli.Properties.Caption = "Onaylı?"
        Me.chkOnayli.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkOnayli.Properties.ReadOnly = True
        Me.chkOnayli.Properties.ValueChecked = 1
        Me.chkOnayli.Properties.ValueUnchecked = 0
        Me.chkOnayli.Size = New System.Drawing.Size(73, 19)
        Me.chkOnayli.TabIndex = 2
        '
        'cmdOnayla
        '
        Me.cmdOnayla.Location = New System.Drawing.Point(83, 5)
        Me.cmdOnayla.Name = "cmdOnayla"
        Me.cmdOnayla.Size = New System.Drawing.Size(112, 25)
        Me.cmdOnayla.TabIndex = 1
        Me.cmdOnayla.Text = "Onayla"
        '
        'colOnayli
        '
        Me.colOnayli.Caption = "Onaylı?"
        Me.colOnayli.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colOnayli.FieldName = "Onayli"
        Me.colOnayli.Name = "colOnayli"
        Me.colOnayli.Visible = True
        Me.colOnayli.VisibleIndex = 14
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
        'colOnaylayan
        '
        Me.colOnaylayan.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colOnaylayan.FieldName = "Onaylayan"
        Me.colOnaylayan.Name = "colOnaylayan"
        Me.colOnaylayan.Visible = True
        Me.colOnaylayan.VisibleIndex = 15
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "User ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.tbUsers
        Me.RepositoryItemLookUpEdit3.DisplayMember = "FullName"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ShowHeader = False
        Me.RepositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit3.ValueMember = "UserID"
        '
        'tbUsers
        '
        Me.tbUsers.Columns.AddRange(New System.Data.DataColumn() {Me.tbUsers_UserID, Me.tbUsers_UserName, Me.tbUsers_FullName})
        Me.tbUsers.Connection = Me.FirmConn
        Me.tbUsers.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"UserID"}, True)})
        Me.tbUsers.CurrentRow = Nothing
        Me.tbUsers.DataSourceLink = Nothing
        Me.tbUsers.DeleteCommand = Me.SqlCommand20
        Me.tbUsers.Filter = ""
        Me.tbUsers.InsertCommand = Me.SqlCommand18
        Me.tbUsers.LiveSave = False
        Me.tbUsers.MaxRecords = CType(0, Long)
        Me.tbUsers.Name = "tbUsers"
        Me.tbUsers.ParentRelation_ChildColumns = Nothing
        Me.tbUsers.ParentRelation_ParentColumns = Nothing
        Me.tbUsers.ParentRelation_Table = Nothing
        Me.tbUsers.Position = CType(-1, Long)
        Me.tbUsers.PrimaryKey = New System.Data.DataColumn() {Me.tbUsers_UserID}
        Me.tbUsers.Quoted = False
        Me.tbUsers.SelectCommand = Me.SqlCommand17
        Me.tbUsers.TableName = "NeoTable1"
        Me.tbUsers.Transaction = Nothing
        Me.tbUsers.UpdateCommand = Me.SqlCommand19
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
        'tbUsers_FullName
        '
        Me.tbUsers_FullName.ColumnName = "FullName"
        '
        'colOnayTarihi
        '
        Me.colOnayTarihi.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm"
        Me.colOnayTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOnayTarihi.FieldName = "OnayTarihi"
        Me.colOnayTarihi.Name = "colOnayTarihi"
        Me.colOnayTarihi.Visible = True
        Me.colOnayTarihi.VisibleIndex = 16
        '
        'colIptal
        '
        Me.colIptal.Caption = "İptal?"
        Me.colIptal.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colIptal.FieldName = "Iptal"
        Me.colIptal.Name = "colIptal"
        Me.colIptal.Visible = True
        Me.colIptal.VisibleIndex = 17
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit2.ValueChecked = 1
        Me.RepositoryItemCheckEdit2.ValueUnchecked = 0
        '
        'colIptalNedeni
        '
        Me.colIptalNedeni.FieldName = "IptalNedeni"
        Me.colIptalNedeni.Name = "colIptalNedeni"
        Me.colIptalNedeni.Visible = True
        Me.colIptalNedeni.VisibleIndex = 18
        '
        'chkShowIptal
        '
        Me.chkShowIptal.Location = New System.Drawing.Point(610, 24)
        Me.chkShowIptal.MenuManager = Me.BarManager1
        Me.chkShowIptal.Name = "chkShowIptal"
        Me.chkShowIptal.Properties.Caption = "İptalleride göster"
        Me.chkShowIptal.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkShowIptal.Properties.ValueChecked = 1
        Me.chkShowIptal.Properties.ValueUnchecked = 0
        Me.chkShowIptal.Size = New System.Drawing.Size(134, 19)
        Me.chkShowIptal.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KopyalaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 26)
        '
        'KopyalaToolStripMenuItem
        '
        Me.KopyalaToolStripMenuItem.Name = "KopyalaToolStripMenuItem"
        Me.KopyalaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KopyalaToolStripMenuItem.Text = "Kopyala"
        '
        'colDepo
        '
        Me.colDepo.Caption = "Depo"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 7
        '
        'colDepo2
        '
        Me.colDepo2.Caption = "Hedef Depo"
        Me.colDepo2.FieldName = "Depo2"
        Me.colDepo2.Name = "colDepo2"
        Me.colDepo2.Visible = True
        Me.colDepo2.VisibleIndex = 8
        '
        'colAraToplam
        '
        Me.colAraToplam.FieldName = "AraToplam"
        Me.colAraToplam.Name = "colAraToplam"
        Me.colAraToplam.Visible = True
        Me.colAraToplam.VisibleIndex = 19
        '
        'colGenelToplam1
        '
        Me.colGenelToplam1.FieldName = "GenelToplam"
        Me.colGenelToplam1.Name = "colGenelToplam1"
        Me.colGenelToplam1.Visible = True
        Me.colGenelToplam1.VisibleIndex = 22
        '
        'colDovizKuru1
        '
        Me.colDovizKuru1.FieldName = "DovizKuru"
        Me.colDovizKuru1.Name = "colDovizKuru1"
        '
        'colDovizTipi1
        '
        Me.colDovizTipi1.FieldName = "DovizTipi"
        Me.colDovizTipi1.Name = "colDovizTipi1"
        '
        'colDovizliTutar1
        '
        Me.colDovizliTutar1.FieldName = "DovizliTutar"
        Me.colDovizliTutar1.Name = "colDovizliTutar1"
        '
        'colKdvOran1
        '
        Me.colKdvOran1.FieldName = "KdvOran"
        Me.colKdvOran1.Name = "colKdvOran1"
        '
        'colKdvTutar1
        '
        Me.colKdvTutar1.FieldName = "KdvTutar"
        Me.colKdvTutar1.Name = "colKdvTutar1"
        '
        'colSiparisType
        '
        Me.colSiparisType.ColumnEdit = Me.cboGridSiparisType
        Me.colSiparisType.FieldName = "SiparisType"
        Me.colSiparisType.Name = "colSiparisType"
        Me.colSiparisType.Visible = True
        Me.colSiparisType.VisibleIndex = 0
        Me.colSiparisType.Width = 101
        '
        'cboGridSiparisType
        '
        Me.cboGridSiparisType.AutoHeight = False
        Me.cboGridSiparisType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridSiparisType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueMember", "ValueMember", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboGridSiparisType.DisplayMember = "DisplayMember"
        Me.cboGridSiparisType.Name = "cboGridSiparisType"
        Me.cboGridSiparisType.NullText = ""
        Me.cboGridSiparisType.ShowHeader = False
        Me.cboGridSiparisType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboGridSiparisType.ValueMember = "ValueMember"
        '
        'colOdemeDurumu
        '
        Me.colOdemeDurumu.Caption = "Ödeme Durumu"
        Me.colOdemeDurumu.FieldName = "OdemeDurumu"
        Me.colOdemeDurumu.Name = "colOdemeDurumu"
        Me.colOdemeDurumu.Visible = True
        Me.colOdemeDurumu.VisibleIndex = 9
        Me.colOdemeDurumu.Width = 112
        '
        'colOdenen
        '
        Me.colOdenen.Caption = "Ödenen"
        Me.colOdenen.FieldName = "Odenen"
        Me.colOdenen.Name = "colOdenen"
        Me.colOdenen.Visible = True
        Me.colOdenen.VisibleIndex = 10
        '
        'colSaticiID
        '
        Me.colSaticiID.Caption = "Satici"
        Me.colSaticiID.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colSaticiID.FieldName = "SaticiID"
        Me.colSaticiID.Name = "colSaticiID"
        Me.colSaticiID.Visible = True
        Me.colSaticiID.VisibleIndex = 23
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaticiIsmi", "Satici Ismi", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaticiID", "Satici ID", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.tbSaticilar
        Me.RepositoryItemLookUpEdit5.DisplayMember = "SaticiIsmi"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ShowHeader = False
        Me.RepositoryItemLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit5.ValueMember = "SaticiID"
        '
        'colDovizGuncelleme
        '
        Me.colDovizGuncelleme.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.colDovizGuncelleme.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDovizGuncelleme.FieldName = "DovizGuncelleme"
        Me.colDovizGuncelleme.Name = "colDovizGuncelleme"
        Me.colDovizGuncelleme.Visible = True
        Me.colDovizGuncelleme.VisibleIndex = 24
        '
        'colVadeFarkiOran
        '
        Me.colVadeFarkiOran.Caption = "Vade Farki %"
        Me.colVadeFarkiOran.FieldName = "VadeFarkiOran"
        Me.colVadeFarkiOran.Name = "colVadeFarkiOran"
        Me.colVadeFarkiOran.Visible = True
        Me.colVadeFarkiOran.VisibleIndex = 20
        '
        'colVadeFarkiTutar
        '
        Me.colVadeFarkiTutar.Caption = "Vade Farki"
        Me.colVadeFarkiTutar.FieldName = "VadeFarkiTutar"
        Me.colVadeFarkiTutar.Name = "colVadeFarkiTutar"
        Me.colVadeFarkiTutar.Visible = True
        Me.colVadeFarkiTutar.VisibleIndex = 21
        '
        'colSiparisID2
        '
        Me.colSiparisID2.FieldName = "SiparisID"
        Me.colSiparisID2.Name = "colSiparisID2"
        '
        'colDeleted1
        '
        Me.colDeleted1.FieldName = "Deleted"
        Me.colDeleted1.Name = "colDeleted1"
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        '
        'colTarih2
        '
        Me.colTarih2.FieldName = "Tarih"
        Me.colTarih2.Name = "colTarih2"
        Me.colTarih2.Visible = True
        Me.colTarih2.VisibleIndex = 0
        '
        'colSipEvrakSeri1
        '
        Me.colSipEvrakSeri1.FieldName = "SipEvrakSeri"
        Me.colSipEvrakSeri1.Name = "colSipEvrakSeri1"
        Me.colSipEvrakSeri1.Visible = True
        Me.colSipEvrakSeri1.VisibleIndex = 1
        '
        'colSipEvrakSira1
        '
        Me.colSipEvrakSira1.FieldName = "SipEvrakSira"
        Me.colSipEvrakSira1.Name = "colSipEvrakSira1"
        Me.colSipEvrakSira1.Visible = True
        Me.colSipEvrakSira1.VisibleIndex = 2
        '
        'colSiparisNo1
        '
        Me.colSiparisNo1.FieldName = "SiparisNo"
        Me.colSiparisNo1.Name = "colSiparisNo1"
        Me.colSiparisNo1.Visible = True
        Me.colSiparisNo1.VisibleIndex = 3
        '
        'colCariKod1
        '
        Me.colCariKod1.FieldName = "CariKod"
        Me.colCariKod1.Name = "colCariKod1"
        Me.colCariKod1.Visible = True
        Me.colCariKod1.VisibleIndex = 4
        '
        'colCariUnvan1
        '
        Me.colCariUnvan1.FieldName = "CariUnvan"
        Me.colCariUnvan1.Name = "colCariUnvan1"
        Me.colCariUnvan1.Visible = True
        Me.colCariUnvan1.VisibleIndex = 5
        '
        'colAciklama11
        '
        Me.colAciklama11.FieldName = "Aciklama1"
        Me.colAciklama11.Name = "colAciklama11"
        Me.colAciklama11.Visible = True
        Me.colAciklama11.VisibleIndex = 6
        '
        'colAciklama21
        '
        Me.colAciklama21.FieldName = "Aciklama2"
        Me.colAciklama21.Name = "colAciklama21"
        Me.colAciklama21.Visible = True
        Me.colAciklama21.VisibleIndex = 7
        '
        'colAciklama31
        '
        Me.colAciklama31.FieldName = "Aciklama3"
        Me.colAciklama31.Name = "colAciklama31"
        Me.colAciklama31.Visible = True
        Me.colAciklama31.VisibleIndex = 8
        '
        'colOnayli1
        '
        Me.colOnayli1.FieldName = "Onayli"
        Me.colOnayli1.Name = "colOnayli1"
        Me.colOnayli1.Visible = True
        Me.colOnayli1.VisibleIndex = 9
        '
        'colOnaylayan1
        '
        Me.colOnaylayan1.FieldName = "Onaylayan"
        Me.colOnaylayan1.Name = "colOnaylayan1"
        Me.colOnaylayan1.Visible = True
        Me.colOnaylayan1.VisibleIndex = 10
        '
        'colOnayTarihi1
        '
        Me.colOnayTarihi1.FieldName = "OnayTarihi"
        Me.colOnayTarihi1.Name = "colOnayTarihi1"
        Me.colOnayTarihi1.Visible = True
        Me.colOnayTarihi1.VisibleIndex = 11
        '
        'colIptal1
        '
        Me.colIptal1.FieldName = "Iptal"
        Me.colIptal1.Name = "colIptal1"
        Me.colIptal1.Visible = True
        Me.colIptal1.VisibleIndex = 12
        '
        'colIptalNedeni1
        '
        Me.colIptalNedeni1.FieldName = "IptalNedeni"
        Me.colIptalNedeni1.Name = "colIptalNedeni1"
        Me.colIptalNedeni1.Visible = True
        Me.colIptalNedeni1.VisibleIndex = 13
        '
        'colAraToplam1
        '
        Me.colAraToplam1.FieldName = "AraToplam"
        Me.colAraToplam1.Name = "colAraToplam1"
        Me.colAraToplam1.Visible = True
        Me.colAraToplam1.VisibleIndex = 14
        '
        'colKdvOran2
        '
        Me.colKdvOran2.FieldName = "KdvOran"
        Me.colKdvOran2.Name = "colKdvOran2"
        Me.colKdvOran2.Visible = True
        Me.colKdvOran2.VisibleIndex = 15
        '
        'colKdvTutar2
        '
        Me.colKdvTutar2.FieldName = "KdvTutar"
        Me.colKdvTutar2.Name = "colKdvTutar2"
        Me.colKdvTutar2.Visible = True
        Me.colKdvTutar2.VisibleIndex = 16
        '
        'colGenelToplam2
        '
        Me.colGenelToplam2.FieldName = "GenelToplam"
        Me.colGenelToplam2.Name = "colGenelToplam2"
        Me.colGenelToplam2.Visible = True
        Me.colGenelToplam2.VisibleIndex = 17
        '
        'colDovizTipi2
        '
        Me.colDovizTipi2.FieldName = "DovizTipi"
        Me.colDovizTipi2.Name = "colDovizTipi2"
        Me.colDovizTipi2.Visible = True
        Me.colDovizTipi2.VisibleIndex = 18
        '
        'colDovizKuru2
        '
        Me.colDovizKuru2.FieldName = "DovizKuru"
        Me.colDovizKuru2.Name = "colDovizKuru2"
        Me.colDovizKuru2.Visible = True
        Me.colDovizKuru2.VisibleIndex = 19
        '
        'colDovizliTutar2
        '
        Me.colDovizliTutar2.FieldName = "DovizliTutar"
        Me.colDovizliTutar2.Name = "colDovizliTutar2"
        Me.colDovizliTutar2.Visible = True
        Me.colDovizliTutar2.VisibleIndex = 20
        '
        'colOkulFarki
        '
        Me.colOkulFarki.FieldName = "OkulFarki"
        Me.colOkulFarki.Name = "colOkulFarki"
        Me.colOkulFarki.Visible = True
        Me.colOkulFarki.VisibleIndex = 21
        '
        'colNAraToplam
        '
        Me.colNAraToplam.FieldName = "NAraToplam"
        Me.colNAraToplam.Name = "colNAraToplam"
        Me.colNAraToplam.Visible = True
        Me.colNAraToplam.VisibleIndex = 22
        '
        'colNKdvTutar
        '
        Me.colNKdvTutar.FieldName = "NKdvTutar"
        Me.colNKdvTutar.Name = "colNKdvTutar"
        Me.colNKdvTutar.Visible = True
        Me.colNKdvTutar.VisibleIndex = 23
        '
        'colNGenelToplam
        '
        Me.colNGenelToplam.FieldName = "NGenelToplam"
        Me.colNGenelToplam.Name = "colNGenelToplam"
        Me.colNGenelToplam.Visible = True
        Me.colNGenelToplam.VisibleIndex = 24
        '
        'colSiparisType1
        '
        Me.colSiparisType1.FieldName = "SiparisType"
        Me.colSiparisType1.Name = "colSiparisType1"
        Me.colSiparisType1.Visible = True
        Me.colSiparisType1.VisibleIndex = 25
        '
        'colDepo1
        '
        Me.colDepo1.FieldName = "Depo"
        Me.colDepo1.Name = "colDepo1"
        Me.colDepo1.Visible = True
        Me.colDepo1.VisibleIndex = 26
        '
        'colDepo21
        '
        Me.colDepo21.FieldName = "Depo2"
        Me.colDepo21.Name = "colDepo21"
        Me.colDepo21.Visible = True
        Me.colDepo21.VisibleIndex = 27
        '
        'colOdemeDurumu1
        '
        Me.colOdemeDurumu1.FieldName = "OdemeDurumu"
        Me.colOdemeDurumu1.Name = "colOdemeDurumu1"
        Me.colOdemeDurumu1.Visible = True
        Me.colOdemeDurumu1.VisibleIndex = 28
        '
        'colOdenen1
        '
        Me.colOdenen1.FieldName = "Odenen"
        Me.colOdenen1.Name = "colOdenen1"
        Me.colOdenen1.Visible = True
        Me.colOdenen1.VisibleIndex = 29
        '
        'colSaticiID1
        '
        Me.colSaticiID1.FieldName = "SaticiID"
        Me.colSaticiID1.Name = "colSaticiID1"
        Me.colSaticiID1.Visible = True
        Me.colSaticiID1.VisibleIndex = 30
        '
        'colDovizGuncelleme1
        '
        Me.colDovizGuncelleme1.FieldName = "DovizGuncelleme"
        Me.colDovizGuncelleme1.Name = "colDovizGuncelleme1"
        Me.colDovizGuncelleme1.Visible = True
        Me.colDovizGuncelleme1.VisibleIndex = 31
        '
        'colVadeFarkiOran1
        '
        Me.colVadeFarkiOran1.FieldName = "VadeFarkiOran"
        Me.colVadeFarkiOran1.Name = "colVadeFarkiOran1"
        Me.colVadeFarkiOran1.Visible = True
        Me.colVadeFarkiOran1.VisibleIndex = 32
        '
        'colVadeFarkiTutar1
        '
        Me.colVadeFarkiTutar1.FieldName = "VadeFarkiTutar"
        Me.colVadeFarkiTutar1.Name = "colVadeFarkiTutar1"
        Me.colVadeFarkiTutar1.Visible = True
        Me.colVadeFarkiTutar1.VisibleIndex = 33
        '
        'DetailTable_SipDetayID
        '
        Me.DetailTable_SipDetayID.AllowDBNull = False
        Me.DetailTable_SipDetayID.AutoIncrement = True
        Me.DetailTable_SipDetayID.ColumnName = "SipDetayID"
        Me.DetailTable_SipDetayID.DataType = GetType(Integer)
        '
        'DetailTable_Deleted
        '
        Me.DetailTable_Deleted.ColumnName = "Deleted"
        Me.DetailTable_Deleted.DataType = GetType(Integer)
        '
        'DetailTable_CreatedBy
        '
        Me.DetailTable_CreatedBy.ColumnName = "CreatedBy"
        Me.DetailTable_CreatedBy.DataType = GetType(Integer)
        '
        'DetailTable_CreatedDate
        '
        Me.DetailTable_CreatedDate.ColumnName = "CreatedDate"
        Me.DetailTable_CreatedDate.DataType = GetType(Date)
        '
        'DetailTable_ModifiedBy
        '
        Me.DetailTable_ModifiedBy.ColumnName = "ModifiedBy"
        Me.DetailTable_ModifiedBy.DataType = GetType(Integer)
        '
        'DetailTable_ModifiedDate
        '
        Me.DetailTable_ModifiedDate.ColumnName = "ModifiedDate"
        Me.DetailTable_ModifiedDate.DataType = GetType(Date)
        '
        'DetailTable_SiparisID
        '
        Me.DetailTable_SiparisID.ColumnName = "SiparisID"
        Me.DetailTable_SiparisID.DataType = GetType(Integer)
        '
        'DetailTable_StokKod
        '
        Me.DetailTable_StokKod.ColumnName = "StokKod"
        '
        'DetailTable_StokRecNo
        '
        Me.DetailTable_StokRecNo.ColumnName = "StokRecNo"
        Me.DetailTable_StokRecNo.DataType = GetType(Integer)
        '
        'DetailTable_SiparisAciklama
        '
        Me.DetailTable_SiparisAciklama.ColumnName = "SiparisAciklama"
        '
        'DetailTable_OkulID
        '
        Me.DetailTable_OkulID.ColumnName = "OkulID"
        Me.DetailTable_OkulID.DataType = GetType(Integer)
        '
        'DetailTable_BolumKod
        '
        Me.DetailTable_BolumKod.ColumnName = "BolumKod"
        '
        'DetailTable_KategoriID
        '
        Me.DetailTable_KategoriID.ColumnName = "KategoriID"
        Me.DetailTable_KategoriID.DataType = GetType(Integer)
        '
        'DetailTable_Miktar
        '
        Me.DetailTable_Miktar.ColumnName = "Miktar"
        Me.DetailTable_Miktar.DataType = GetType(Double)
        '
        'DetailTable_Maliyet
        '
        Me.DetailTable_Maliyet.ColumnName = "Maliyet"
        Me.DetailTable_Maliyet.DataType = GetType(Double)
        '
        'DetailTable_Fiyat
        '
        Me.DetailTable_Fiyat.ColumnName = "Fiyat"
        Me.DetailTable_Fiyat.DataType = GetType(Double)
        '
        'DetailTable_Tutar
        '
        Me.DetailTable_Tutar.ColumnName = "Tutar"
        Me.DetailTable_Tutar.DataType = GetType(Double)
        '
        'DetailTable_Tarih
        '
        Me.DetailTable_Tarih.ColumnName = "Tarih"
        Me.DetailTable_Tarih.DataType = GetType(Date)
        '
        'DetailTable_TerminTarihi
        '
        Me.DetailTable_TerminTarihi.ColumnName = "TerminTarihi"
        Me.DetailTable_TerminTarihi.DataType = GetType(Date)
        '
        'DetailTable_MusteriSipNo
        '
        Me.DetailTable_MusteriSipNo.ColumnName = "MusteriSipNo"
        '
        'DetailTable_SiparisiAlan
        '
        Me.DetailTable_SiparisiAlan.ColumnName = "SiparisiAlan"
        '
        'DetailTable_Iptal
        '
        Me.DetailTable_Iptal.ColumnName = "Iptal"
        Me.DetailTable_Iptal.DataType = GetType(Integer)
        '
        'DetailTable_Resim1
        '
        Me.DetailTable_Resim1.ColumnName = "Resim1"
        Me.DetailTable_Resim1.DataType = GetType(Byte())
        '
        'DetailTable_Resim2
        '
        Me.DetailTable_Resim2.ColumnName = "Resim2"
        Me.DetailTable_Resim2.DataType = GetType(Byte())
        '
        'DetailTable_Resim3
        '
        Me.DetailTable_Resim3.ColumnName = "Resim3"
        Me.DetailTable_Resim3.DataType = GetType(Byte())
        '
        'DetailTable_Resim4
        '
        Me.DetailTable_Resim4.ColumnName = "Resim4"
        Me.DetailTable_Resim4.DataType = GetType(Byte())
        '
        'DetailTable_Resim5
        '
        Me.DetailTable_Resim5.ColumnName = "Resim5"
        Me.DetailTable_Resim5.DataType = GetType(Byte())
        '
        'DetailTable_StokIsmi
        '
        Me.DetailTable_StokIsmi.ColumnName = "StokIsmi"
        '
        'DetailTable_Bagli
        '
        Me.DetailTable_Bagli.ColumnName = "Bagli"
        Me.DetailTable_Bagli.DataType = GetType(Integer)
        '
        'DetailTable_BagliSipDetayID
        '
        Me.DetailTable_BagliSipDetayID.ColumnName = "BagliSipDetayID"
        Me.DetailTable_BagliSipDetayID.DataType = GetType(Integer)
        '
        'DetailTable_OkulFarki
        '
        Me.DetailTable_OkulFarki.ColumnName = "OkulFarki"
        Me.DetailTable_OkulFarki.DataType = GetType(Double)
        '
        'DetailTable_Durumu
        '
        Me.DetailTable_Durumu.ColumnName = "Durumu"
        '
        'DetailTable_TeslimMiktar
        '
        Me.DetailTable_TeslimMiktar.ColumnName = "TeslimMiktar"
        Me.DetailTable_TeslimMiktar.DataType = GetType(Double)
        '
        'DetailTable_AnaRenk
        '
        Me.DetailTable_AnaRenk.ColumnName = "AnaRenk"
        '
        'DetailTable_Bedenler
        '
        Me.DetailTable_Bedenler.ColumnName = "Bedenler"
        '
        'DetailTable_bSerbestFiyat
        '
        Me.DetailTable_bSerbestFiyat.ColumnName = "bSerbestFiyat"
        Me.DetailTable_bSerbestFiyat.DataType = GetType(Integer)
        '
        'DetailTable_Hazirlanan
        '
        Me.DetailTable_Hazirlanan.ColumnName = "Hazirlanan"
        Me.DetailTable_Hazirlanan.DataType = GetType(Double)
        '
        'DetailTable_FasondaMi
        '
        Me.DetailTable_FasondaMi.ColumnName = "FasondaMi"
        Me.DetailTable_FasondaMi.DataType = GetType(Integer)
        '
        'DetailTable_FasonFisID
        '
        Me.DetailTable_FasonFisID.ColumnName = "FasonFisID"
        Me.DetailTable_FasonFisID.DataType = GetType(Integer)
        '
        'DetailTable_Iskonto
        '
        Me.DetailTable_Iskonto.ColumnName = "Iskonto"
        Me.DetailTable_Iskonto.DataType = GetType(Double)
        '
        'DetailTable_NakitIskonto
        '
        Me.DetailTable_NakitIskonto.ColumnName = "NakitIskonto"
        Me.DetailTable_NakitIskonto.DataType = GetType(Double)
        '
        'DetailTable_IskontoTutar
        '
        Me.DetailTable_IskontoTutar.ColumnName = "IskontoTutar"
        Me.DetailTable_IskontoTutar.DataType = GetType(Double)
        '
        'DetailTable_NakitIskontoTutar
        '
        Me.DetailTable_NakitIskontoTutar.ColumnName = "NakitIskontoTutar"
        Me.DetailTable_NakitIskontoTutar.DataType = GetType(Double)
        '
        'DetailTable_sip_Guid
        '
        Me.DetailTable_sip_Guid.ColumnName = "sip_Guid"
        Me.DetailTable_sip_Guid.DataType = GetType(System.Guid)
        '
        'DetailTable_BoyahaneID
        '
        Me.DetailTable_BoyahaneID.ColumnName = "BoyahaneID"
        Me.DetailTable_BoyahaneID.DataType = GetType(Integer)
        '
        'MasterTable_SiparisID
        '
        Me.MasterTable_SiparisID.AllowDBNull = False
        Me.MasterTable_SiparisID.AutoIncrement = True
        Me.MasterTable_SiparisID.ColumnName = "SiparisID"
        Me.MasterTable_SiparisID.DataType = GetType(Integer)
        '
        'MasterTable_Deleted
        '
        Me.MasterTable_Deleted.ColumnName = "Deleted"
        Me.MasterTable_Deleted.DataType = GetType(Integer)
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
        'MasterTable_Tarih
        '
        Me.MasterTable_Tarih.ColumnName = "Tarih"
        Me.MasterTable_Tarih.DataType = GetType(Date)
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
        'MasterTable_SiparisNo
        '
        Me.MasterTable_SiparisNo.ColumnName = "SiparisNo"
        '
        'MasterTable_CariKod
        '
        Me.MasterTable_CariKod.ColumnName = "CariKod"
        '
        'MasterTable_CariUnvan
        '
        Me.MasterTable_CariUnvan.ColumnName = "CariUnvan"
        '
        'MasterTable_Aciklama1
        '
        Me.MasterTable_Aciklama1.ColumnName = "Aciklama1"
        '
        'MasterTable_Aciklama2
        '
        Me.MasterTable_Aciklama2.ColumnName = "Aciklama2"
        '
        'MasterTable_Aciklama3
        '
        Me.MasterTable_Aciklama3.ColumnName = "Aciklama3"
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
        'MasterTable_OnayTarihi
        '
        Me.MasterTable_OnayTarihi.ColumnName = "OnayTarihi"
        Me.MasterTable_OnayTarihi.DataType = GetType(Date)
        '
        'MasterTable_Iptal
        '
        Me.MasterTable_Iptal.ColumnName = "Iptal"
        Me.MasterTable_Iptal.DataType = GetType(Integer)
        '
        'MasterTable_IptalNedeni
        '
        Me.MasterTable_IptalNedeni.ColumnName = "IptalNedeni"
        '
        'MasterTable_AraToplam
        '
        Me.MasterTable_AraToplam.ColumnName = "AraToplam"
        Me.MasterTable_AraToplam.DataType = GetType(Double)
        '
        'MasterTable_KdvOran
        '
        Me.MasterTable_KdvOran.ColumnName = "KdvOran"
        Me.MasterTable_KdvOran.DataType = GetType(Double)
        '
        'MasterTable_KdvTutar
        '
        Me.MasterTable_KdvTutar.ColumnName = "KdvTutar"
        Me.MasterTable_KdvTutar.DataType = GetType(Double)
        '
        'MasterTable_GenelToplam
        '
        Me.MasterTable_GenelToplam.ColumnName = "GenelToplam"
        Me.MasterTable_GenelToplam.DataType = GetType(Double)
        '
        'MasterTable_DovizTipi
        '
        Me.MasterTable_DovizTipi.ColumnName = "DovizTipi"
        '
        'MasterTable_DovizKuru
        '
        Me.MasterTable_DovizKuru.ColumnName = "DovizKuru"
        Me.MasterTable_DovizKuru.DataType = GetType(Double)
        '
        'MasterTable_DovizliTutar
        '
        Me.MasterTable_DovizliTutar.ColumnName = "DovizliTutar"
        Me.MasterTable_DovizliTutar.DataType = GetType(Double)
        '
        'MasterTable_OkulFarki
        '
        Me.MasterTable_OkulFarki.ColumnName = "OkulFarki"
        Me.MasterTable_OkulFarki.DataType = GetType(Double)
        '
        'MasterTable_NAraToplam
        '
        Me.MasterTable_NAraToplam.ColumnName = "NAraToplam"
        Me.MasterTable_NAraToplam.DataType = GetType(Double)
        '
        'MasterTable_NKdvTutar
        '
        Me.MasterTable_NKdvTutar.ColumnName = "NKdvTutar"
        Me.MasterTable_NKdvTutar.DataType = GetType(Double)
        '
        'MasterTable_NGenelToplam
        '
        Me.MasterTable_NGenelToplam.ColumnName = "NGenelToplam"
        Me.MasterTable_NGenelToplam.DataType = GetType(Double)
        '
        'MasterTable_SiparisType
        '
        Me.MasterTable_SiparisType.ColumnName = "SiparisType"
        Me.MasterTable_SiparisType.DataType = GetType(Integer)
        '
        'MasterTable_Depo
        '
        Me.MasterTable_Depo.ColumnName = "Depo"
        '
        'MasterTable_Depo2
        '
        Me.MasterTable_Depo2.ColumnName = "Depo2"
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
        'MasterTable_SaticiID
        '
        Me.MasterTable_SaticiID.ColumnName = "SaticiID"
        Me.MasterTable_SaticiID.DataType = GetType(Integer)
        '
        'MasterTable_DovizGuncelleme
        '
        Me.MasterTable_DovizGuncelleme.ColumnName = "DovizGuncelleme"
        Me.MasterTable_DovizGuncelleme.DataType = GetType(Date)
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
        'MasterTable_SiparisAlanID
        '
        Me.MasterTable_SiparisAlanID.ColumnName = "SiparisAlanID"
        Me.MasterTable_SiparisAlanID.DataType = GetType(Integer)
        '
        'frmSiparisler
        '
        Me.ClientSize = New System.Drawing.Size(893, 652)
        Me.FormCode = "000008"
        Me.Name = "frmSiparisler"
        Me.Text = "Siparişler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.txtTopInfo, 0)
        Me.Controls.SetChildIndex(Me.panelFormTop, 0)
        Me.Controls.SetChildIndex(Me.panelBottom, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.BaseTab1.ResumeLayout(False)
        Me.BaseTab2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.basePanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.basePanelControl3.ResumeLayout(False)
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupDocumentView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelAuthCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAuthCodes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormDateFilter.ResumeLayout(False)
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TarihDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarihDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOdemeDurumu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSiparisType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRiskBakiye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBakiye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiparisIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SipEvrakSeriTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SipEvrakSiraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCariKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCariUnvan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aciklama1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aciklama2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aciklama3TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSiparisID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTarih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCariKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAciklama1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSipEvrakSeri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSipEvrakSira, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAciklama2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCariUnvan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAciklama3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGridSipDetayRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGridSipDetay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOkul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBoyahaneler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKdvOran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDoviz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSaticilar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAdmin.ResumeLayout(False)
        CType(Me.chkIptal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOnayli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowIptal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.cboGridSiparisType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSipDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokRecNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents SiparisIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeletedSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TarihDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SipEvrakSeriTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SipEvrakSiraSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtCariKodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCariUnvan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Aciklama1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Aciklama2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Aciklama3TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForSiparisID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForTarih As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSipEvrakSeri As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSipEvrakSira As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCariKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCariUnvan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAciklama1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAciklama2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAciklama3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbOkul As NeoDAC.NeoTable
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbKategori As NeoDAC.NeoTable
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnGridSipDetay As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAddSipDetay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSipDetayID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGridSipDetayRemove As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents tbOkul_OkulID As System.Data.DataColumn
    Friend WithEvents tbOkul_OkulKod As System.Data.DataColumn
    Friend WithEvents tbOkul_OkulIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_IlceID As System.Data.DataColumn
    Friend WithEvents tbOkul_IlID As System.Data.DataColumn
    Friend WithEvents tbOkul_IlIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_IlceIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_DisplayText As System.Data.DataColumn
    Friend WithEvents colSiparisAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbKategori_KategoriID As System.Data.DataColumn
    Friend WithEvents tbKategori_UstKategoriID As System.Data.DataColumn
    Friend WithEvents tbKategori_KategoriKod As System.Data.DataColumn
    Friend WithEvents tbKategori_KategoriIsim As System.Data.DataColumn
    Friend WithEvents tbKategori_StokKodFormat As System.Data.DataColumn
    Friend WithEvents tbKategori_IntCode As System.Data.DataColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents panelAdmin As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkOnayli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdOnayla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkIptal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tbUsers As NeoDAC.NeoTable
    Friend WithEvents tbUsers_UserID As System.Data.DataColumn
    Friend WithEvents tbUsers_UserName As System.Data.DataColumn
    Friend WithEvents tbUsers_FullName As System.Data.DataColumn
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colOnayli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnaylayan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnayTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptalNedeni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDovizTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenelToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizliTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerminTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboDoviz As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSipDetayID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRiskBakiye As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBakiye As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkShowIptal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colStokKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBolumKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtStokKod As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colStokIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtStokIsmi As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KopyalaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDepo2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDepo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboSiparisType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboGridSiparisType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSiparisType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAraToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenelToplam1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizTipi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizliTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvOran1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBagli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colBagliSipDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuSipDetayBagla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSipDetayBaglantiIptal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboOdemeDurumu As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOdemeDurumu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdenen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colDurumu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtKdvOran As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colSipDetayID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbSaticilar As NeoDAC.NeoTable
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSaticiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SatirSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colDovizGuncelleme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeFarkiOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeFarkiTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskontoTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNakitIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNakitIskontoTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSiparisID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSeri1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSira1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnayli1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnaylayan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnayTarihi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptalNedeni1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAraToplam1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvOran2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenelToplam2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizTipi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizKuru2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizliTutar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulFarki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAraToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNKdvTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNGenelToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeDurumu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdenen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizGuncelleme1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeFarkiOran1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeFarkiTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbBoyahaneler As NeoDAC.NeoTable
    Friend WithEvents tbBoyahaneler_BoyahaneID As DataColumn
    Friend WithEvents tbBoyahaneler_Boyahane As DataColumn
    Friend WithEvents colBoyahane As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DetailTable_SipDetayID As DataColumn
    Friend WithEvents DetailTable_Deleted As DataColumn
    Friend WithEvents DetailTable_CreatedBy As DataColumn
    Friend WithEvents DetailTable_CreatedDate As DataColumn
    Friend WithEvents DetailTable_ModifiedBy As DataColumn
    Friend WithEvents DetailTable_ModifiedDate As DataColumn
    Friend WithEvents DetailTable_SiparisID As DataColumn
    Friend WithEvents DetailTable_StokKod As DataColumn
    Friend WithEvents DetailTable_StokRecNo As DataColumn
    Friend WithEvents DetailTable_SiparisAciklama As DataColumn
    Friend WithEvents DetailTable_OkulID As DataColumn
    Friend WithEvents DetailTable_BolumKod As DataColumn
    Friend WithEvents DetailTable_KategoriID As DataColumn
    Friend WithEvents DetailTable_Miktar As DataColumn
    Friend WithEvents DetailTable_Maliyet As DataColumn
    Friend WithEvents DetailTable_Fiyat As DataColumn
    Friend WithEvents DetailTable_Tutar As DataColumn
    Friend WithEvents DetailTable_Tarih As DataColumn
    Friend WithEvents DetailTable_TerminTarihi As DataColumn
    Friend WithEvents DetailTable_MusteriSipNo As DataColumn
    Friend WithEvents DetailTable_SiparisiAlan As DataColumn
    Friend WithEvents DetailTable_Iptal As DataColumn
    Friend WithEvents DetailTable_Resim1 As DataColumn
    Friend WithEvents DetailTable_Resim2 As DataColumn
    Friend WithEvents DetailTable_Resim3 As DataColumn
    Friend WithEvents DetailTable_Resim4 As DataColumn
    Friend WithEvents DetailTable_Resim5 As DataColumn
    Friend WithEvents DetailTable_StokIsmi As DataColumn
    Friend WithEvents DetailTable_Bagli As DataColumn
    Friend WithEvents DetailTable_BagliSipDetayID As DataColumn
    Friend WithEvents DetailTable_OkulFarki As DataColumn
    Friend WithEvents DetailTable_Durumu As DataColumn
    Friend WithEvents DetailTable_TeslimMiktar As DataColumn
    Friend WithEvents DetailTable_AnaRenk As DataColumn
    Friend WithEvents DetailTable_Bedenler As DataColumn
    Friend WithEvents DetailTable_bSerbestFiyat As DataColumn
    Friend WithEvents DetailTable_Hazirlanan As DataColumn
    Friend WithEvents DetailTable_FasondaMi As DataColumn
    Friend WithEvents DetailTable_FasonFisID As DataColumn
    Friend WithEvents DetailTable_Iskonto As DataColumn
    Friend WithEvents DetailTable_NakitIskonto As DataColumn
    Friend WithEvents DetailTable_IskontoTutar As DataColumn
    Friend WithEvents DetailTable_NakitIskontoTutar As DataColumn
    Friend WithEvents DetailTable_sip_Guid As DataColumn
    Friend WithEvents DetailTable_BoyahaneID As DataColumn
    Friend WithEvents MasterTable_SiparisID As DataColumn
    Friend WithEvents MasterTable_Deleted As DataColumn
    Friend WithEvents MasterTable_CreatedBy As DataColumn
    Friend WithEvents MasterTable_CreatedDate As DataColumn
    Friend WithEvents MasterTable_ModifiedBy As DataColumn
    Friend WithEvents MasterTable_ModifiedDate As DataColumn
    Friend WithEvents MasterTable_Tarih As DataColumn
    Friend WithEvents MasterTable_SipEvrakSeri As DataColumn
    Friend WithEvents MasterTable_SipEvrakSira As DataColumn
    Friend WithEvents MasterTable_SiparisNo As DataColumn
    Friend WithEvents MasterTable_CariKod As DataColumn
    Friend WithEvents MasterTable_CariUnvan As DataColumn
    Friend WithEvents MasterTable_Aciklama1 As DataColumn
    Friend WithEvents MasterTable_Aciklama2 As DataColumn
    Friend WithEvents MasterTable_Aciklama3 As DataColumn
    Friend WithEvents MasterTable_Onayli As DataColumn
    Friend WithEvents MasterTable_Onaylayan As DataColumn
    Friend WithEvents MasterTable_OnayTarihi As DataColumn
    Friend WithEvents MasterTable_Iptal As DataColumn
    Friend WithEvents MasterTable_IptalNedeni As DataColumn
    Friend WithEvents MasterTable_AraToplam As DataColumn
    Friend WithEvents MasterTable_KdvOran As DataColumn
    Friend WithEvents MasterTable_KdvTutar As DataColumn
    Friend WithEvents MasterTable_GenelToplam As DataColumn
    Friend WithEvents MasterTable_DovizTipi As DataColumn
    Friend WithEvents MasterTable_DovizKuru As DataColumn
    Friend WithEvents MasterTable_DovizliTutar As DataColumn
    Friend WithEvents MasterTable_OkulFarki As DataColumn
    Friend WithEvents MasterTable_NAraToplam As DataColumn
    Friend WithEvents MasterTable_NKdvTutar As DataColumn
    Friend WithEvents MasterTable_NGenelToplam As DataColumn
    Friend WithEvents MasterTable_SiparisType As DataColumn
    Friend WithEvents MasterTable_Depo As DataColumn
    Friend WithEvents MasterTable_Depo2 As DataColumn
    Friend WithEvents MasterTable_OdemeDurumu As DataColumn
    Friend WithEvents MasterTable_Odenen As DataColumn
    Friend WithEvents MasterTable_SaticiID As DataColumn
    Friend WithEvents MasterTable_DovizGuncelleme As DataColumn
    Friend WithEvents MasterTable_VadeFarkiOran As DataColumn
    Friend WithEvents MasterTable_VadeFarkiTutar As DataColumn
    Friend WithEvents MasterTable_SiparisAlanID As DataColumn
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NeoTable1 As NeoDAC.NeoTable
    Friend WithEvents NeoTable1_SiparisAlanID As DataColumn
    Friend WithEvents NeoTable1_Deleted As DataColumn
    Friend WithEvents NeoTable1_CreatedBy As DataColumn
    Friend WithEvents NeoTable1_CreatedDate As DataColumn
    Friend WithEvents NeoTable1_ModifiedBy As DataColumn
    Friend WithEvents NeoTable1_ModifiedDate As DataColumn
    Friend WithEvents NeoTable1_SipAlanIsmi As DataColumn
    Friend WithEvents NeoTable1_IntCode As DataColumn
    Friend WithEvents tbSaticilar_SaticiID As DataColumn
    Friend WithEvents tbSaticilar_SaticiIsmi As DataColumn
    Friend WithEvents SqlCommand28 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand25 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand27 As SqlClient.SqlCommand
End Class
