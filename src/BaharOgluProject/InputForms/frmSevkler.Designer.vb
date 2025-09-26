<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSevkler
    Inherits ProbarSiparis.frmBaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSevkler))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grDetay = New DevExpress.XtraGrid.GridControl()
        Me.grDetayView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSevkDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkPaketID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPaketNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetayAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRenkKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayFiyatAdetID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerminTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslimMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelYeniPaket = New System.Windows.Forms.Panel()
        Me.txtAktifPaketNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdSevkSatirSil = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdYeniPaket = New DevExpress.XtraEditors.SimpleButton()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.panelSipDetay = New System.Windows.Forms.Panel()
        Me.grSiparisDetay = New DevExpress.XtraGrid.GridControl()
        Me.grSiparisDetayView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenKod1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbKategori = New NeoDAC.NeoTable(Me.components)
        Me.tbKategori_KategoriID = New System.Data.DataColumn()
        Me.tbKategori_UstKategoriID = New System.Data.DataColumn()
        Me.tbKategori_KategoriKod = New System.Data.DataColumn()
        Me.tbKategori_KategoriIsim = New System.Data.DataColumn()
        Me.tbKategori_StokKodFormat = New System.Data.DataColumn()
        Me.tbKategori_IntCode = New System.Data.DataColumn()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbOkul = New NeoDAC.NeoTable(Me.components)
        Me.tbOkul_OkulID = New System.Data.DataColumn()
        Me.tbOkul_OkulKod = New System.Data.DataColumn()
        Me.tbOkul_OkulIsmi = New System.Data.DataColumn()
        Me.tbOkul_IlceID = New System.Data.DataColumn()
        Me.tbOkul_IlID = New System.Data.DataColumn()
        Me.tbOkul_IlIsmi = New System.Data.DataColumn()
        Me.tbOkul_IlceIsmi = New System.Data.DataColumn()
        Me.tbOkul_DisplayText = New System.Data.DataColumn()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmdPaketeEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.grPaket = New DevExpress.XtraGrid.GridControl()
        Me.grPaketView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSevkPaketID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaketNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrutAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYukseklik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdSonPaketiSil = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.panelAdmin = New DevExpress.XtraEditors.PanelControl()
        Me.chkIptal = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.chkOnayli = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdOnayla = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.panelDepo = New System.Windows.Forms.Panel()
        Me.txtDepo = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepo2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.cboKargo = New DevExpress.XtraEditors.LookUpEdit()
        Me.tbKargolar = New NeoDAC.NeoTable(Me.components)
        Me.tbKargolar_KargoID = New System.Data.DataColumn()
        Me.tbKargolar_KargoIsmi = New System.Data.DataColumn()
        Me.SqlCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand30 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand29 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand31 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdSevkDetayOzet = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToplamPaketTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ToplamMiktarTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSiparisEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.KargoEvrakNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CariUnvanButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CariKodButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.IrsEvrakSiraSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IrsEvrakSeriTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.colSevkID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkBelgeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKargoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKargoEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYurtDisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnayli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnaylayan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptalNedeni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCekiListesiUygula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DetailTable_SevkSipDetayID = New System.Data.DataColumn()
        Me.DetailTable_Deleted = New System.Data.DataColumn()
        Me.DetailTable_CreatedBy = New System.Data.DataColumn()
        Me.DetailTable_CreatedDate = New System.Data.DataColumn()
        Me.DetailTable_ModifiedBy = New System.Data.DataColumn()
        Me.DetailTable_ModifiedDate = New System.Data.DataColumn()
        Me.DetailTable_SevkID = New System.Data.DataColumn()
        Me.DetailTable_SiparisID = New System.Data.DataColumn()
        Me.DetailTable_SipDetayID = New System.Data.DataColumn()
        Me.MasterTable_SevkID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_SevkTipi = New System.Data.DataColumn()
        Me.MasterTable_Tarih = New System.Data.DataColumn()
        Me.MasterTable_SevkEvrakSeri = New System.Data.DataColumn()
        Me.MasterTable_SevkEvrakSira = New System.Data.DataColumn()
        Me.MasterTable_SevkBelgeNo = New System.Data.DataColumn()
        Me.MasterTable_CariKod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_Aciklama1 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama2 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama3 = New System.Data.DataColumn()
        Me.MasterTable_TasimaTuru = New System.Data.DataColumn()
        Me.MasterTable_KargoID = New System.Data.DataColumn()
        Me.MasterTable_KargoEvrakNo = New System.Data.DataColumn()
        Me.MasterTable_YurtDisi = New System.Data.DataColumn()
        Me.MasterTable_Onayli = New System.Data.DataColumn()
        Me.MasterTable_Onaylayan = New System.Data.DataColumn()
        Me.MasterTable_OnayTarihi = New System.Data.DataColumn()
        Me.MasterTable_Iptal = New System.Data.DataColumn()
        Me.MasterTable_IptalNedeni = New System.Data.DataColumn()
        Me.MasterTable_Depo = New System.Data.DataColumn()
        Me.MasterTable_Depo2 = New System.Data.DataColumn()
        Me.MasterTable_ToplamAdet = New System.Data.DataColumn()
        Me.MasterTable_ToplamPaket = New System.Data.DataColumn()
        Me.MasterTable_CekiListesiUygula = New System.Data.DataColumn()
        Me.DetailTable2_SevkPaketID = New System.Data.DataColumn()
        Me.DetailTable2_Deleted = New System.Data.DataColumn()
        Me.DetailTable2_CreatedBy = New System.Data.DataColumn()
        Me.DetailTable2_CreatedDate = New System.Data.DataColumn()
        Me.DetailTable2_ModifiedBy = New System.Data.DataColumn()
        Me.DetailTable2_ModifiedDate = New System.Data.DataColumn()
        Me.DetailTable2_SevkID = New System.Data.DataColumn()
        Me.DetailTable2_PaketNo = New System.Data.DataColumn()
        Me.DetailTable2_NetAgirlik = New System.Data.DataColumn()
        Me.DetailTable2_Dara = New System.Data.DataColumn()
        Me.DetailTable2_BrutAgirlik = New System.Data.DataColumn()
        Me.DetailTable2_En = New System.Data.DataColumn()
        Me.DetailTable2_Boy = New System.Data.DataColumn()
        Me.DetailTable2_Yukseklik = New System.Data.DataColumn()
        Me.DetailTable3_SevkDetayID = New System.Data.DataColumn()
        Me.DetailTable3_Deleted = New System.Data.DataColumn()
        Me.DetailTable3_CreatedBy = New System.Data.DataColumn()
        Me.DetailTable3_CreatedDate = New System.Data.DataColumn()
        Me.DetailTable3_ModifiedBy = New System.Data.DataColumn()
        Me.DetailTable3_ModifiedDate = New System.Data.DataColumn()
        Me.DetailTable3_SevkID = New System.Data.DataColumn()
        Me.DetailTable3_SipDetayID = New System.Data.DataColumn()
        Me.DetailTable3_SipDetayFiyatAdetID = New System.Data.DataColumn()
        Me.DetailTable3_SevkPaketID = New System.Data.DataColumn()
        Me.DetailTable3_PaketNo = New System.Data.DataColumn()
        Me.DetailTable3_BedenKod = New System.Data.DataColumn()
        Me.DetailTable3_Adet = New System.Data.DataColumn()
        Me.DetailTable3_DetayAciklama = New System.Data.DataColumn()
        Me.DetailTable3_RenkKod = New System.Data.DataColumn()
        Me.DetailTable3_sth_RECno = New System.Data.DataColumn()
        Me.DetailTable3_sth_evrakno_seri = New System.Data.DataColumn()
        Me.DetailTable3_sth_evrakno_sira = New System.Data.DataColumn()
        Me.DetailTable3_sth_satirno = New System.Data.DataColumn()
        Me.DetailTable3_KategoriKod = New System.Data.DataColumn()
        Me.DetailTable3_KategoriIsim = New System.Data.DataColumn()
        Me.DetailTable3_Okul = New System.Data.DataColumn()
        Me.DetailTable3_NetFiyat = New System.Data.DataColumn()
        Me.DetailTable3_StokKod = New System.Data.DataColumn()
        Me.DetailTable3_SiparisNo = New System.Data.DataColumn()
        Me.DetailTable3_Tarih = New System.Data.DataColumn()
        Me.DetailTable3_TerminTarihi = New System.Data.DataColumn()
        Me.DetailTable3_SipMiktar = New System.Data.DataColumn()
        Me.DetailTable3_TeslimMiktar = New System.Data.DataColumn()
        Me.DetailTable3_Tutar = New System.Data.DataColumn()
        Me.DetailTable3_Kalan = New System.Data.DataColumn()
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
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grDetay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grDetayView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelYeniPaket.SuspendLayout()
        CType(Me.txtAktifPaketNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSipDetay.SuspendLayout()
        CType(Me.grSiparisDetay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grSiparisDetayView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOkul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.grPaket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grPaketView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.panelAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAdmin.SuspendLayout()
        CType(Me.chkIptal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOnayli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDepo.SuspendLayout()
        CType(Me.txtDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKargolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ToplamPaketTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToplamMiktarTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KargoEvrakNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CariUnvanButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CariKodButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrsEvrakSiraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrsEvrakSeriTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'barDockControlTop
        '
        Me.barDockControlTop.Size = New System.Drawing.Size(1232, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 583)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1232, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 516)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(1232, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 516)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 108)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1232, 434)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(1226, 406)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.XtraTabControl2)
        Me.BaseTab2.Controls.Add(Me.PanelControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(1226, 406)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.XtraTabControl2, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(1226, 326)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSevkID, Me.colSevkTipi, Me.colTarih, Me.colSevkEvrakSeri, Me.colSevkEvrakSira, Me.colSevkBelgeNo, Me.colCariKod, Me.colCariUnvan, Me.colAciklama1, Me.colAciklama2, Me.colAciklama3, Me.colKargoID, Me.colKargoEvrakNo, Me.colYurtDisi, Me.colOnayli, Me.colOnaylayan, Me.colOnayTarihi, Me.colIptal, Me.colIptalNedeni, Me.colDepo, Me.colDepo2, Me.colCekiListesiUygula})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnPrintGrid
        '
        Me.btnPrintGrid.Glyph = CType(resources.GetObject("btnPrintGrid.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnExport
        '
        Me.btnExport.Glyph = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnHelp1
        '
        Me.btnHelp1.Glyph = CType(resources.GetObject("btnHelp1.ImageOptions.Image"), System.Drawing.Image)
        '
        'panelBottom
        '
        Me.panelBottom.Location = New System.Drawing.Point(0, 542)
        Me.panelBottom.Size = New System.Drawing.Size(1232, 41)
        '
        'basePanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(1034, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Size = New System.Drawing.Size(1232, 31)
        '
        'btnNew
        '
        Me.btnNew.Glyph = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnSave
        '
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnCancel
        '
        Me.btnCancel.Glyph = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnDelete
        '
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnFirst
        '
        Me.btnFirst.Glyph = CType(resources.GetObject("btnFirst.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnPrior
        '
        Me.btnPrior.Glyph = CType(resources.GetObject("btnPrior.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnNext
        '
        Me.btnNext.Glyph = CType(resources.GetObject("btnNext.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnLast
        '
        Me.btnLast.Glyph = CType(resources.GetObject("btnLast.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnFormPrint
        '
        Me.btnFormPrint.Glyph = CType(resources.GetObject("btnFormPrint.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnHelp
        '
        Me.btnHelp.Glyph = CType(resources.GetObject("btnHelp.ImageOptions.Image"), System.Drawing.Image)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_SevkID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_SevkTipi, Me.MasterTable_Tarih, Me.MasterTable_SevkEvrakSeri, Me.MasterTable_SevkEvrakSira, Me.MasterTable_SevkBelgeNo, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_Aciklama1, Me.MasterTable_Aciklama2, Me.MasterTable_Aciklama3, Me.MasterTable_TasimaTuru, Me.MasterTable_KargoID, Me.MasterTable_KargoEvrakNo, Me.MasterTable_YurtDisi, Me.MasterTable_Onayli, Me.MasterTable_Onaylayan, Me.MasterTable_OnayTarihi, Me.MasterTable_Iptal, Me.MasterTable_IptalNedeni, Me.MasterTable_Depo, Me.MasterTable_Depo2, Me.MasterTable_ToplamAdet, Me.MasterTable_ToplamPaket, Me.MasterTable_CekiListesiUygula})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SevkID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_SevkID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'DetailTable
        '
        Me.DetailTable.Columns.AddRange(New System.Data.DataColumn() {Me.DetailTable_SevkSipDetayID, Me.DetailTable_Deleted, Me.DetailTable_CreatedBy, Me.DetailTable_CreatedDate, Me.DetailTable_ModifiedBy, Me.DetailTable_ModifiedDate, Me.DetailTable_SevkID, Me.DetailTable_SiparisID, Me.DetailTable_SipDetayID})
        Me.DetailTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SevkSipDetayID"}, True)})
        Me.DetailTable.DeleteCommand = Me.SqlCommand8
        Me.DetailTable.InsertCommand = Me.SqlCommand6
        Me.DetailTable.ParentRelation_ChildColumns = New String() {"SevkID"}
        Me.DetailTable.ParentRelation_ParentColumns = New String() {"SevkID"}
        Me.DetailTable.ParentRelation_Table = Me.MasterTable
        Me.DetailTable.PrimaryKey = New System.Data.DataColumn() {Me.DetailTable_SevkSipDetayID}
        Me.DetailTable.SelectCommand = Me.SqlCommand5
        Me.DetailTable.UpdateCommand = Me.SqlCommand7
        '
        'MasterLink
        '
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(887, 381)
        Me.BaseTab4.Tag = True
        '
        'btnApprove
        '
        Me.btnApprove.Glyph = CType(resources.GetObject("btnApprove.ImageOptions.Image"), System.Drawing.Image)
        '
        'btnDisapprove
        '
        Me.btnDisapprove.Glyph = CType(resources.GetObject("btnDisapprove.ImageOptions.Image"), System.Drawing.Image)
        '
        'DetailTable2
        '
        Me.DetailTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DetailTable2_SevkPaketID, Me.DetailTable2_Deleted, Me.DetailTable2_CreatedBy, Me.DetailTable2_CreatedDate, Me.DetailTable2_ModifiedBy, Me.DetailTable2_ModifiedDate, Me.DetailTable2_SevkID, Me.DetailTable2_PaketNo, Me.DetailTable2_NetAgirlik, Me.DetailTable2_Dara, Me.DetailTable2_BrutAgirlik, Me.DetailTable2_En, Me.DetailTable2_Boy, Me.DetailTable2_Yukseklik})
        Me.DetailTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SevkPaketID"}, True)})
        Me.DetailTable2.DeleteCommand = Me.SqlCommand12
        Me.DetailTable2.InsertCommand = Me.SqlCommand10
        Me.DetailTable2.ParentRelation_ChildColumns = New String() {"SevkID"}
        Me.DetailTable2.ParentRelation_ParentColumns = New String() {"SevkID"}
        Me.DetailTable2.ParentRelation_Table = Me.MasterTable
        Me.DetailTable2.PrimaryKey = New System.Data.DataColumn() {Me.DetailTable2_SevkPaketID}
        Me.DetailTable2.SelectCommand = Me.SqlCommand9
        Me.DetailTable2.UpdateCommand = Me.SqlCommand11
        '
        'DetailTable3
        '
        Me.DetailTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DetailTable3_SevkDetayID, Me.DetailTable3_Deleted, Me.DetailTable3_CreatedBy, Me.DetailTable3_CreatedDate, Me.DetailTable3_ModifiedBy, Me.DetailTable3_ModifiedDate, Me.DetailTable3_SevkID, Me.DetailTable3_SipDetayID, Me.DetailTable3_SipDetayFiyatAdetID, Me.DetailTable3_SevkPaketID, Me.DetailTable3_PaketNo, Me.DetailTable3_BedenKod, Me.DetailTable3_Adet, Me.DetailTable3_DetayAciklama, Me.DetailTable3_RenkKod, Me.DetailTable3_sth_RECno, Me.DetailTable3_sth_evrakno_seri, Me.DetailTable3_sth_evrakno_sira, Me.DetailTable3_sth_satirno, Me.DetailTable3_KategoriKod, Me.DetailTable3_KategoriIsim, Me.DetailTable3_Okul, Me.DetailTable3_NetFiyat, Me.DetailTable3_StokKod, Me.DetailTable3_SiparisNo, Me.DetailTable3_Tarih, Me.DetailTable3_TerminTarihi, Me.DetailTable3_SipMiktar, Me.DetailTable3_TeslimMiktar, Me.DetailTable3_Tutar, Me.DetailTable3_Kalan})
        Me.DetailTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SevkDetayID"}, True)})
        Me.DetailTable3.DeleteCommand = Me.SqlCommand16
        Me.DetailTable3.InsertCommand = Me.SqlCommand14
        Me.DetailTable3.ParentRelation_ChildColumns = New String() {"SevkID"}
        Me.DetailTable3.ParentRelation_ParentColumns = New String() {"SevkID"}
        Me.DetailTable3.ParentRelation_Table = Me.MasterTable
        Me.DetailTable3.PrimaryKey = New System.Data.DataColumn() {Me.DetailTable3_SevkDetayID}
        Me.DetailTable3.SelectCommand = Me.SqlCommand13
        Me.DetailTable3.UpdateCommand = Me.SqlCommand15
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Location = New System.Drawing.Point(0, 67)
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(1232, 10)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Glyph = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Appearance.Options.UseBackColor = True
        Me.lblMainWarning1.Appearance.Options.UseFont = True
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 387)
        Me.lblMainWarning1.Size = New System.Drawing.Size(1226, 19)
        '
        'DetailTable4
        '
        Me.DetailTable4.DeleteCommand = Me.SqlCommand28
        Me.DetailTable4.InsertCommand = Me.SqlCommand26
        Me.DetailTable4.SelectCommand = Me.SqlCommand25
        Me.DetailTable4.UpdateCommand = Me.SqlCommand27
        '
        'btnLanguageOptions
        '
        Me.btnLanguageOptions.Glyph = CType(resources.GetObject("btnLanguageOptions.ImageOptions.Image"), System.Drawing.Image)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 380)
        Me.panelAuthCodes.Size = New System.Drawing.Size(1226, 26)
        '
        'cboAuthCodes
        '
        Me.cboAuthCodes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cboAuthCodes.Properties.Appearance.Options.UseFont = True
        '
        'lblAuthCodeCaption
        '
        Me.lblAuthCodeCaption.Appearance.Options.UseTextOptions = True
        Me.lblAuthCodeCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Size = New System.Drawing.Size(1226, 61)
        Me.panelFormDateFilter.Visible = True
        '
        'cmdRefreshList
        '
        Me.cmdRefreshList.Image = CType(resources.GetObject("cmdRefreshList.ImageOptions.Image"), System.Drawing.Image)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM Sevk " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND Tarih BETWEEN @FormDate1 AND @FormDa" &
    "te2 "
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime), New System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime)})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_IrsaliyeID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Sevk SET Deleted = SevkID  , ModifiedBy = @ModifiedBy , ModifiedDate = GET" &
    "DATE()   WHERE SevkID = @SevkID"
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM SevkSipDetay WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_IrsDetayID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = resources.GetString("SqlCommand7.CommandText")
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "UPDATE SevkSipDetay SET Deleted = SevkSipDetayID  , ModifiedBy = @ModifiedBy , Mo" &
    "difiedDate = GETDATE()   WHERE SevkSipDetayID = @SevkSipDetayID"
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT * FROM SevkPaket WHERE Deleted = 0 "
        '
        'SqlCommand10
        '
        Me.SqlCommand10.CommandText = resources.GetString("SqlCommand10.CommandText")
        Me.SqlCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_IrsPaketID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand11
        '
        Me.SqlCommand11.CommandText = resources.GetString("SqlCommand11.CommandText")
        '
        'SqlCommand12
        '
        Me.SqlCommand12.CommandText = "UPDATE SevkPaket SET Deleted = SevkPaketID  , ModifiedBy = @ModifiedBy , Modified" &
    "Date = GETDATE()   WHERE SevkPaketID = @SevkPaketID"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 164)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.Size = New System.Drawing.Size(1226, 216)
        Me.XtraTabControl2.TabIndex = 1
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage2})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel3)
        Me.XtraTabPage3.Controls.Add(Me.Splitter1)
        Me.XtraTabPage3.Controls.Add(Me.panelSipDetay)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1220, 188)
        Me.XtraTabPage3.Text = "Siparis"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.grDetay)
        Me.Panel3.Controls.Add(Me.panelYeniPaket)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(643, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(577, 188)
        Me.Panel3.TabIndex = 4
        '
        'grDetay
        '
        Me.grDetay.DataSource = Me.DetailTable3
        Me.grDetay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grDetay.Location = New System.Drawing.Point(0, 44)
        Me.grDetay.MainView = Me.grDetayView
        Me.grDetay.MenuManager = Me.BarManager1
        Me.grDetay.Name = "grDetay"
        Me.grDetay.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4})
        Me.grDetay.Size = New System.Drawing.Size(577, 144)
        Me.grDetay.TabIndex = 0
        Me.grDetay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grDetayView})
        '
        'grDetayView
        '
        Me.grDetayView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSevkDetayID, Me.colSevkID2, Me.colSevkPaketID1, Me.colPaketNo1, Me.colBedenKod, Me.colAdet, Me.colDetayAciklama, Me.colRenkKod, Me.colSipDetayID, Me.colSipDetayFiyatAdetID, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.colTarih1, Me.colTerminTarihi, Me.colTeslimMiktar, Me.colSipMiktar, Me.colTutar, Me.colKalan})
        Me.grDetayView.GridControl = Me.grDetay
        Me.grDetayView.GroupCount = 1
        Me.grDetayView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Adet", Me.colAdet, "{0:#,##0.###}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Me.colTutar, "{0:#,##0.###}")})
        Me.grDetayView.Name = "grDetayView"
        Me.grDetayView.OptionsBehavior.AutoExpandAllGroups = True
        Me.grDetayView.OptionsSelection.MultiSelect = True
        Me.grDetayView.OptionsView.ColumnAutoWidth = False
        Me.grDetayView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.grDetayView.OptionsView.ShowFooter = True
        Me.grDetayView.OptionsView.ShowGroupedColumns = True
        Me.grDetayView.OptionsView.ShowGroupPanel = False
        Me.grDetayView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPaketNo1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSevkDetayID
        '
        Me.colSevkDetayID.FieldName = "SevkDetayID"
        Me.colSevkDetayID.Name = "colSevkDetayID"
        Me.colSevkDetayID.OptionsColumn.AllowEdit = False
        '
        'colSevkID2
        '
        Me.colSevkID2.FieldName = "SevkID"
        Me.colSevkID2.Name = "colSevkID2"
        Me.colSevkID2.OptionsColumn.AllowEdit = False
        '
        'colSevkPaketID1
        '
        Me.colSevkPaketID1.Caption = "#Paket No"
        Me.colSevkPaketID1.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colSevkPaketID1.FieldName = "SevkPaketID"
        Me.colSevkPaketID1.Name = "colSevkPaketID1"
        Me.colSevkPaketID1.OptionsColumn.AllowEdit = False
        Me.colSevkPaketID1.Width = 105
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaketNo", "Paket No", 60, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SevkPaketID", "Sevk Paket ID", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.DetailTable2
        Me.RepositoryItemLookUpEdit4.DisplayMember = "PaketNo"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ShowHeader = False
        Me.RepositoryItemLookUpEdit4.ValueMember = "SevkPaketID"
        '
        'colPaketNo1
        '
        Me.colPaketNo1.FieldName = "PaketNo"
        Me.colPaketNo1.Name = "colPaketNo1"
        Me.colPaketNo1.OptionsColumn.AllowEdit = False
        Me.colPaketNo1.Visible = True
        Me.colPaketNo1.VisibleIndex = 0
        '
        'colBedenKod
        '
        Me.colBedenKod.FieldName = "BedenKod"
        Me.colBedenKod.Name = "colBedenKod"
        Me.colBedenKod.OptionsColumn.AllowEdit = False
        Me.colBedenKod.Visible = True
        Me.colBedenKod.VisibleIndex = 8
        '
        'colAdet
        '
        Me.colAdet.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.colAdet.AppearanceCell.Options.UseFont = True
        Me.colAdet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.colAdet.AppearanceHeader.Options.UseFont = True
        Me.colAdet.FieldName = "Adet"
        Me.colAdet.Name = "colAdet"
        Me.colAdet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Adet", "{0:0.##}")})
        Me.colAdet.Visible = True
        Me.colAdet.VisibleIndex = 9
        '
        'colDetayAciklama
        '
        Me.colDetayAciklama.FieldName = "DetayAciklama"
        Me.colDetayAciklama.Name = "colDetayAciklama"
        Me.colDetayAciklama.OptionsColumn.AllowEdit = False
        '
        'colRenkKod
        '
        Me.colRenkKod.FieldName = "RenkKod"
        Me.colRenkKod.Name = "colRenkKod"
        Me.colRenkKod.OptionsColumn.AllowEdit = False
        Me.colRenkKod.Visible = True
        Me.colRenkKod.VisibleIndex = 6
        '
        'colSipDetayID
        '
        Me.colSipDetayID.FieldName = "SipDetayID"
        Me.colSipDetayID.Name = "colSipDetayID"
        Me.colSipDetayID.OptionsColumn.AllowEdit = False
        '
        'colSipDetayFiyatAdetID
        '
        Me.colSipDetayFiyatAdetID.FieldName = "SipDetayFiyatAdetID"
        Me.colSipDetayFiyatAdetID.Name = "colSipDetayFiyatAdetID"
        Me.colSipDetayFiyatAdetID.OptionsColumn.AllowEdit = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "NetFiyat"
        Me.GridColumn7.FieldName = "NetFiyat"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "KategoriKod"
        Me.GridColumn8.FieldName = "KategoriKod"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 99
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "KategoriIsim"
        Me.GridColumn9.FieldName = "KategoriIsim"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.GridColumn9.Width = 148
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Okul"
        Me.GridColumn10.FieldName = "Okul"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 150
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "StokKod"
        Me.GridColumn11.FieldName = "StokKod"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Siparis No"
        Me.GridColumn12.FieldName = "SiparisNo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 107
        '
        'colTarih1
        '
        Me.colTarih1.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colTarih1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTarih1.FieldName = "Tarih"
        Me.colTarih1.Name = "colTarih1"
        '
        'colTerminTarihi
        '
        Me.colTerminTarihi.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colTerminTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTerminTarihi.FieldName = "TerminTarihi"
        Me.colTerminTarihi.Name = "colTerminTarihi"
        '
        'colTeslimMiktar
        '
        Me.colTeslimMiktar.Caption = "Tes.Miktar"
        Me.colTeslimMiktar.DisplayFormat.FormatString = "#,##0.###"
        Me.colTeslimMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTeslimMiktar.FieldName = "TeslimMiktar"
        Me.colTeslimMiktar.Name = "colTeslimMiktar"
        Me.colTeslimMiktar.Visible = True
        Me.colTeslimMiktar.VisibleIndex = 10
        '
        'colSipMiktar
        '
        Me.colSipMiktar.DisplayFormat.FormatString = "#,##0.###"
        Me.colSipMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSipMiktar.FieldName = "SipMiktar"
        Me.colSipMiktar.Name = "colSipMiktar"
        Me.colSipMiktar.Visible = True
        Me.colSipMiktar.VisibleIndex = 11
        '
        'colTutar
        '
        Me.colTutar.Caption = "Tutar"
        Me.colTutar.DisplayFormat.FormatString = "#,##0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.OptionsColumn.AllowEdit = False
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:0.##}")})
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 12
        '
        'colKalan
        '
        Me.colKalan.DisplayFormat.FormatString = "#,##0.###"
        Me.colKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKalan.FieldName = "Kalan"
        Me.colKalan.Name = "colKalan"
        Me.colKalan.Visible = True
        Me.colKalan.VisibleIndex = 13
        '
        'panelYeniPaket
        '
        Me.panelYeniPaket.Controls.Add(Me.txtAktifPaketNo)
        Me.panelYeniPaket.Controls.Add(Me.cmdSevkSatirSil)
        Me.panelYeniPaket.Controls.Add(Me.LabelControl12)
        Me.panelYeniPaket.Controls.Add(Me.cmdYeniPaket)
        Me.panelYeniPaket.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelYeniPaket.Location = New System.Drawing.Point(0, 0)
        Me.panelYeniPaket.Name = "panelYeniPaket"
        Me.panelYeniPaket.Size = New System.Drawing.Size(577, 44)
        Me.panelYeniPaket.TabIndex = 1
        Me.panelYeniPaket.Visible = False
        '
        'txtAktifPaketNo
        '
        Me.txtAktifPaketNo.EnterMoveNextControl = True
        Me.txtAktifPaketNo.Location = New System.Drawing.Point(87, 6)
        Me.txtAktifPaketNo.MenuManager = Me.BarManager1
        Me.txtAktifPaketNo.Name = "txtAktifPaketNo"
        Me.txtAktifPaketNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAktifPaketNo.Properties.Appearance.Options.UseFont = True
        Me.txtAktifPaketNo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.txtAktifPaketNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAktifPaketNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaketNo", "Paket No", 60, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SevkPaketID", "Sevk Paket ID", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtAktifPaketNo.Properties.DataSource = Me.DetailTable2
        Me.txtAktifPaketNo.Properties.DisplayMember = "PaketNo"
        Me.txtAktifPaketNo.Properties.NullText = ""
        Me.txtAktifPaketNo.Properties.ShowHeader = False
        Me.txtAktifPaketNo.Properties.ValueMember = "PaketNo"
        Me.txtAktifPaketNo.Size = New System.Drawing.Size(88, 26)
        Me.txtAktifPaketNo.TabIndex = 15
        '
        'cmdSevkSatirSil
        '
        Me.cmdSevkSatirSil.Location = New System.Drawing.Point(351, 3)
        Me.cmdSevkSatirSil.Name = "cmdSevkSatirSil"
        Me.cmdSevkSatirSil.Size = New System.Drawing.Size(114, 33)
        Me.cmdSevkSatirSil.TabIndex = 14
        Me.cmdSevkSatirSil.Text = "Satir Sil"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial Narrow", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(23, 12)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Aktif paket"
        '
        'cmdYeniPaket
        '
        Me.cmdYeniPaket.Location = New System.Drawing.Point(193, 3)
        Me.cmdYeniPaket.Name = "cmdYeniPaket"
        Me.cmdYeniPaket.Size = New System.Drawing.Size(114, 33)
        Me.cmdYeniPaket.TabIndex = 1
        Me.cmdYeniPaket.Text = "Yeni Paket"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(637, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(6, 188)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'panelSipDetay
        '
        Me.panelSipDetay.Controls.Add(Me.grSiparisDetay)
        Me.panelSipDetay.Controls.Add(Me.Panel2)
        Me.panelSipDetay.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSipDetay.Location = New System.Drawing.Point(0, 0)
        Me.panelSipDetay.Name = "panelSipDetay"
        Me.panelSipDetay.Size = New System.Drawing.Size(637, 188)
        Me.panelSipDetay.TabIndex = 3
        Me.panelSipDetay.Visible = False
        '
        'grSiparisDetay
        '
        Me.grSiparisDetay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSiparisDetay.Location = New System.Drawing.Point(0, 45)
        Me.grSiparisDetay.MainView = Me.grSiparisDetayView
        Me.grSiparisDetay.MenuManager = Me.BarManager1
        Me.grSiparisDetay.Name = "grSiparisDetay"
        Me.grSiparisDetay.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.grSiparisDetay.Size = New System.Drawing.Size(637, 143)
        Me.grSiparisDetay.TabIndex = 1
        Me.grSiparisDetay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grSiparisDetayView})
        '
        'grSiparisDetayView
        '
        Me.grSiparisDetayView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colSipEvrakSeri, Me.colSipEvrakSira, Me.colKategoriID, Me.colKategoriID1, Me.colOkulID, Me.colStokKod, Me.colBedenKod1, Me.GridColumn5, Me.colSevkMiktar, Me.GridColumn2, Me.colSipMiktar1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn13})
        Me.grSiparisDetayView.GridControl = Me.grSiparisDetay
        Me.grSiparisDetayView.Name = "grSiparisDetayView"
        Me.grSiparisDetayView.OptionsView.ColumnAutoWidth = False
        Me.grSiparisDetayView.OptionsView.ShowGroupedColumns = True
        Me.grSiparisDetayView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tarih"
        Me.GridColumn1.FieldName = "Tarih"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 83
        '
        'colSipEvrakSeri
        '
        Me.colSipEvrakSeri.FieldName = "SipEvrakSeri"
        Me.colSipEvrakSeri.Name = "colSipEvrakSeri"
        Me.colSipEvrakSeri.OptionsColumn.AllowEdit = False
        Me.colSipEvrakSeri.Visible = True
        Me.colSipEvrakSeri.VisibleIndex = 0
        Me.colSipEvrakSeri.Width = 87
        '
        'colSipEvrakSira
        '
        Me.colSipEvrakSira.FieldName = "SipEvrakSira"
        Me.colSipEvrakSira.Name = "colSipEvrakSira"
        Me.colSipEvrakSira.OptionsColumn.AllowEdit = False
        Me.colSipEvrakSira.Visible = True
        Me.colSipEvrakSira.VisibleIndex = 1
        Me.colSipEvrakSira.Width = 102
        '
        'colKategoriID
        '
        Me.colKategoriID.Caption = "KategoriKod"
        Me.colKategoriID.FieldName = "KategoriKod"
        Me.colKategoriID.Name = "colKategoriID"
        Me.colKategoriID.OptionsColumn.AllowEdit = False
        Me.colKategoriID.Visible = True
        Me.colKategoriID.VisibleIndex = 2
        Me.colKategoriID.Width = 85
        '
        'colKategoriID1
        '
        Me.colKategoriID1.Caption = "Kategori Isim"
        Me.colKategoriID1.FieldName = "KategoriIsim"
        Me.colKategoriID1.Name = "colKategoriID1"
        Me.colKategoriID1.OptionsColumn.AllowEdit = False
        Me.colKategoriID1.Visible = True
        Me.colKategoriID1.VisibleIndex = 3
        Me.colKategoriID1.Width = 144
        '
        'colOkulID
        '
        Me.colOkulID.Caption = "Okul"
        Me.colOkulID.FieldName = "Okul"
        Me.colOkulID.Name = "colOkulID"
        Me.colOkulID.OptionsColumn.AllowEdit = False
        Me.colOkulID.Width = 176
        '
        'colStokKod
        '
        Me.colStokKod.FieldName = "StokKod"
        Me.colStokKod.Name = "colStokKod"
        Me.colStokKod.OptionsColumn.AllowEdit = False
        '
        'colBedenKod1
        '
        Me.colBedenKod1.Caption = "Beden"
        Me.colBedenKod1.FieldName = "BedenKod"
        Me.colBedenKod1.Name = "colBedenKod1"
        Me.colBedenKod1.OptionsColumn.AllowEdit = False
        Me.colBedenKod1.Visible = True
        Me.colBedenKod1.VisibleIndex = 4
        Me.colBedenKod1.Width = 55
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Sip.Miktar"
        Me.GridColumn5.FieldName = "SipMiktar"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 68
        '
        'colSevkMiktar
        '
        Me.colSevkMiktar.Caption = "Tes.Miktar"
        Me.colSevkMiktar.FieldName = "TeslimMiktar"
        Me.colSevkMiktar.Name = "colSevkMiktar"
        Me.colSevkMiktar.OptionsColumn.AllowEdit = False
        Me.colSevkMiktar.Visible = True
        Me.colSevkMiktar.VisibleIndex = 6
        Me.colSevkMiktar.Width = 71
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Kalan"
        Me.GridColumn2.FieldName = "Kalan"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 7
        Me.GridColumn2.Width = 63
        '
        'colSipMiktar1
        '
        Me.colSipMiktar1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.colSipMiktar1.AppearanceCell.Options.UseFont = True
        Me.colSipMiktar1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.colSipMiktar1.AppearanceHeader.Options.UseFont = True
        Me.colSipMiktar1.FieldName = "Miktar"
        Me.colSipMiktar1.Name = "colSipMiktar1"
        Me.colSipMiktar1.Visible = True
        Me.colSipMiktar1.VisibleIndex = 8
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "SiparisID"
        Me.GridColumn3.FieldName = "SiparisID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "SipDetayID"
        Me.GridColumn4.FieldName = "SipDetayID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "SipDetayFiyatAdetID"
        Me.GridColumn6.FieldName = "SipDetayFiyatAdetID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "RenkKod"
        Me.GridColumn13.FieldName = "RenkKod"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 10
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriKod", "Kategori Kod", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriIsim", "Kategori Isim", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriID", "Kategori ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.tbKategori
        Me.RepositoryItemLookUpEdit1.DisplayMember = "KategoriKod"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "KategoriID"
        '
        'tbKategori
        '
        Me.tbKategori.Columns.AddRange(New System.Data.DataColumn() {Me.tbKategori_KategoriID, Me.tbKategori_UstKategoriID, Me.tbKategori_KategoriKod, Me.tbKategori_KategoriIsim, Me.tbKategori_StokKodFormat, Me.tbKategori_IntCode})
        Me.tbKategori.Connection = Me.FirmConn
        Me.tbKategori.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriID"}, True)})
        Me.tbKategori.CurrentRow = Nothing
        Me.tbKategori.DataSourceLink = Nothing
        Me.tbKategori.DeleteCommand = Me.SqlCommand20
        Me.tbKategori.Filter = ""
        Me.tbKategori.InsertCommand = Me.SqlCommand18
        Me.tbKategori.LiveSave = False
        Me.tbKategori.MaxRecords = CType(0, Long)
        Me.tbKategori.Name = "tbKategori"
        Me.tbKategori.ParentRelation_ChildColumns = Nothing
        Me.tbKategori.ParentRelation_ParentColumns = Nothing
        Me.tbKategori.ParentRelation_Table = Nothing
        Me.tbKategori.Position = CType(-1, Long)
        Me.tbKategori.PrimaryKey = New System.Data.DataColumn() {Me.tbKategori_KategoriID}
        Me.tbKategori.Quoted = False
        Me.tbKategori.SelectCommand = Me.SqlCommand17
        Me.tbKategori.TableName = "NeoTable1"
        Me.tbKategori.Transaction = Nothing
        Me.tbKategori.UpdateCommand = Me.SqlCommand19
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
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     KategoriID, UstKategoriID, KategoriKod, KategoriIsim, StokKodFormat, I" &
    "ntCode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Kategoriler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted=0"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriKod", "Kategori Kod", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriIsim", "Kategori Isim", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriID", "Kategori ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.tbKategori
        Me.RepositoryItemLookUpEdit2.DisplayMember = "KategoriIsim"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "KategoriID"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "Display Text", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OkulID", "Okul ID", 58, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.tbOkul
        Me.RepositoryItemLookUpEdit3.DisplayMember = "DisplayText"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit3.ValueMember = "OkulID"
        '
        'tbOkul
        '
        Me.tbOkul.Columns.AddRange(New System.Data.DataColumn() {Me.tbOkul_OkulID, Me.tbOkul_OkulKod, Me.tbOkul_OkulIsmi, Me.tbOkul_IlceID, Me.tbOkul_IlID, Me.tbOkul_IlIsmi, Me.tbOkul_IlceIsmi, Me.tbOkul_DisplayText})
        Me.tbOkul.Connection = Me.FirmConn
        Me.tbOkul.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"OkulID"}, True)})
        Me.tbOkul.CurrentRow = Nothing
        Me.tbOkul.DataSourceLink = Nothing
        Me.tbOkul.DeleteCommand = Me.SqlCommand24
        Me.tbOkul.Filter = ""
        Me.tbOkul.InsertCommand = Me.SqlCommand22
        Me.tbOkul.LiveSave = False
        Me.tbOkul.MaxRecords = CType(0, Long)
        Me.tbOkul.Name = "tbOkul"
        Me.tbOkul.ParentRelation_ChildColumns = Nothing
        Me.tbOkul.ParentRelation_ParentColumns = Nothing
        Me.tbOkul.ParentRelation_Table = Nothing
        Me.tbOkul.Position = CType(-1, Long)
        Me.tbOkul.PrimaryKey = New System.Data.DataColumn() {Me.tbOkul_OkulID}
        Me.tbOkul.Quoted = False
        Me.tbOkul.SelectCommand = Me.SqlCommand21
        Me.tbOkul.TableName = "NeoTable1"
        Me.tbOkul.Transaction = Nothing
        Me.tbOkul.UpdateCommand = Me.SqlCommand23
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
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = resources.GetString("SqlCommand21.CommandText")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 45)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdPaketeEkle)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(488, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(149, 45)
        Me.Panel4.TabIndex = 1
        '
        'cmdPaketeEkle
        '
        Me.cmdPaketeEkle.Appearance.Options.UseTextOptions = True
        Me.cmdPaketeEkle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdPaketeEkle.Location = New System.Drawing.Point(3, 4)
        Me.cmdPaketeEkle.Name = "cmdPaketeEkle"
        Me.cmdPaketeEkle.Size = New System.Drawing.Size(110, 32)
        Me.cmdPaketeEkle.TabIndex = 0
        Me.cmdPaketeEkle.Text = "(+) Ekle (F6)"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.grPaket)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(881, 163)
        Me.XtraTabPage2.Text = "Paketler"
        '
        'grPaket
        '
        Me.grPaket.DataSource = Me.DetailLink2
        Me.grPaket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPaket.Location = New System.Drawing.Point(0, 0)
        Me.grPaket.MainView = Me.grPaketView
        Me.grPaket.MenuManager = Me.BarManager1
        Me.grPaket.Name = "grPaket"
        Me.grPaket.Size = New System.Drawing.Size(881, 119)
        Me.grPaket.TabIndex = 0
        Me.grPaket.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grPaketView})
        '
        'grPaketView
        '
        Me.grPaketView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSevkPaketID, Me.colSevkID1, Me.colPaketNo, Me.colNetAgirlik, Me.colDara, Me.colBrutAgirlik, Me.colEn, Me.colBoy, Me.colYukseklik})
        Me.grPaketView.GridControl = Me.grPaket
        Me.grPaketView.Name = "grPaketView"
        Me.grPaketView.OptionsView.ColumnAutoWidth = False
        Me.grPaketView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.grPaketView.OptionsView.ShowGroupPanel = False
        Me.grPaketView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPaketNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSevkPaketID
        '
        Me.colSevkPaketID.FieldName = "SevkPaketID"
        Me.colSevkPaketID.Name = "colSevkPaketID"
        Me.colSevkPaketID.OptionsColumn.AllowEdit = False
        '
        'colSevkID1
        '
        Me.colSevkID1.FieldName = "SevkID"
        Me.colSevkID1.Name = "colSevkID1"
        Me.colSevkID1.OptionsColumn.AllowEdit = False
        '
        'colPaketNo
        '
        Me.colPaketNo.FieldName = "PaketNo"
        Me.colPaketNo.Name = "colPaketNo"
        Me.colPaketNo.OptionsColumn.AllowEdit = False
        Me.colPaketNo.Visible = True
        Me.colPaketNo.VisibleIndex = 0
        Me.colPaketNo.Width = 83
        '
        'colNetAgirlik
        '
        Me.colNetAgirlik.FieldName = "NetAgirlik"
        Me.colNetAgirlik.Name = "colNetAgirlik"
        Me.colNetAgirlik.Visible = True
        Me.colNetAgirlik.VisibleIndex = 1
        Me.colNetAgirlik.Width = 95
        '
        'colDara
        '
        Me.colDara.FieldName = "Dara"
        Me.colDara.Name = "colDara"
        Me.colDara.Visible = True
        Me.colDara.VisibleIndex = 2
        '
        'colBrutAgirlik
        '
        Me.colBrutAgirlik.FieldName = "BrutAgirlik"
        Me.colBrutAgirlik.Name = "colBrutAgirlik"
        Me.colBrutAgirlik.Visible = True
        Me.colBrutAgirlik.VisibleIndex = 3
        '
        'colEn
        '
        Me.colEn.FieldName = "En"
        Me.colEn.Name = "colEn"
        Me.colEn.Visible = True
        Me.colEn.VisibleIndex = 4
        '
        'colBoy
        '
        Me.colBoy.FieldName = "Boy"
        Me.colBoy.Name = "colBoy"
        Me.colBoy.Visible = True
        Me.colBoy.VisibleIndex = 5
        '
        'colYukseklik
        '
        Me.colYukseklik.FieldName = "Yukseklik"
        Me.colYukseklik.Name = "colYukseklik"
        Me.colYukseklik.Visible = True
        Me.colYukseklik.VisibleIndex = 6
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.cmdSonPaketiSil)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 119)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(881, 44)
        Me.PanelControl4.TabIndex = 1
        '
        'cmdSonPaketiSil
        '
        Me.cmdSonPaketiSil.Location = New System.Drawing.Point(10, 8)
        Me.cmdSonPaketiSil.Name = "cmdSonPaketiSil"
        Me.cmdSonPaketiSil.Size = New System.Drawing.Size(114, 33)
        Me.cmdSonPaketiSil.TabIndex = 2
        Me.cmdSonPaketiSil.Text = "Son paketi sil"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.panelAdmin)
        Me.PanelControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.CheckEdit2)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.panelDepo)
        Me.PanelControl1.Controls.Add(Me.cboKargo)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.KargoEvrakNoTextEdit)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.CariUnvanButtonEdit)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.CariKodButtonEdit)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.IrsEvrakSiraSpinEdit)
        Me.PanelControl1.Controls.Add(Me.IrsEvrakSeriTextEdit)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1226, 164)
        Me.PanelControl1.TabIndex = 2
        '
        'panelAdmin
        '
        Me.panelAdmin.Controls.Add(Me.chkIptal)
        Me.panelAdmin.Controls.Add(Me.cmdIptal)
        Me.panelAdmin.Controls.Add(Me.chkOnayli)
        Me.panelAdmin.Controls.Add(Me.cmdOnayla)
        Me.panelAdmin.Location = New System.Drawing.Point(1000, 3)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.Size = New System.Drawing.Size(224, 68)
        Me.panelAdmin.TabIndex = 44
        '
        'chkIptal
        '
        Me.chkIptal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Iptal", True))
        Me.chkIptal.Location = New System.Drawing.Point(10, 37)
        Me.chkIptal.MenuManager = Me.BarManager1
        Me.chkIptal.Name = "chkIptal"
        Me.chkIptal.Properties.Caption = "Ä°ptal?"
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
        Me.cmdIptal.Location = New System.Drawing.Point(83, 36)
        Me.cmdIptal.Name = "cmdIptal"
        Me.cmdIptal.Size = New System.Drawing.Size(112, 25)
        Me.cmdIptal.TabIndex = 3
        Me.cmdIptal.Text = "(X) Ä°ptal"
        '
        'chkOnayli
        '
        Me.chkOnayli.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Onayli", True))
        Me.chkOnayli.Location = New System.Drawing.Point(10, 11)
        Me.chkOnayli.MenuManager = Me.BarManager1
        Me.chkOnayli.Name = "chkOnayli"
        Me.chkOnayli.Properties.Caption = "Onayli?"
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
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "TasimaTuru", True))
        Me.ComboBoxEdit1.EnterMoveNextControl = True
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(108, 65)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"", "Kara", "Hava", "Deniz", "Konteyner", "Demiryolu", "Kargo"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(128, 20)
        Me.ComboBoxEdit1.TabIndex = 43
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(11, 66)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl13.TabIndex = 42
        Me.LabelControl13.Text = "Tasima Turu"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "YurtDisi", True))
        Me.CheckEdit2.EnterMoveNextControl = True
        Me.CheckEdit2.Location = New System.Drawing.Point(571, 90)
        Me.CheckEdit2.MenuManager = Me.BarManager1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Caption = "Yurt disi mi?"
        Me.CheckEdit2.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit2.Properties.ValueChecked = 1
        Me.CheckEdit2.Properties.ValueUnchecked = 0
        Me.CheckEdit2.Size = New System.Drawing.Size(148, 19)
        Me.CheckEdit2.TabIndex = 41
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CekiListesiUygula", True))
        Me.CheckEdit1.EnterMoveNextControl = True
        Me.CheckEdit1.Location = New System.Drawing.Point(571, 61)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Ceki listesi kullan"
        Me.CheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit1.Properties.ValueChecked = 1
        Me.CheckEdit1.Properties.ValueUnchecked = 0
        Me.CheckEdit1.Size = New System.Drawing.Size(148, 19)
        Me.CheckEdit1.TabIndex = 40
        '
        'panelDepo
        '
        Me.panelDepo.Controls.Add(Me.txtDepo)
        Me.panelDepo.Controls.Add(Me.LabelControl7)
        Me.panelDepo.Controls.Add(Me.LabelControl6)
        Me.panelDepo.Controls.Add(Me.txtDepo2)
        Me.panelDepo.Location = New System.Drawing.Point(760, 3)
        Me.panelDepo.Name = "panelDepo"
        Me.panelDepo.Size = New System.Drawing.Size(191, 61)
        Me.panelDepo.TabIndex = 39
        Me.panelDepo.Visible = False
        '
        'txtDepo
        '
        Me.txtDepo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Depo", True))
        Me.txtDepo.EnterMoveNextControl = True
        Me.txtDepo.Location = New System.Drawing.Point(94, 5)
        Me.txtDepo.MenuManager = Me.BarManager1
        Me.txtDepo.Name = "txtDepo"
        Me.txtDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDepo.Size = New System.Drawing.Size(79, 20)
        Me.txtDepo.TabIndex = 14
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(4, 34)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Hedef Depo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "Kaynak Depo"
        '
        'txtDepo2
        '
        Me.txtDepo2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Depo2", True))
        Me.txtDepo2.EnterMoveNextControl = True
        Me.txtDepo2.Location = New System.Drawing.Point(94, 31)
        Me.txtDepo2.MenuManager = Me.BarManager1
        Me.txtDepo2.Name = "txtDepo2"
        Me.txtDepo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDepo2.Size = New System.Drawing.Size(79, 20)
        Me.txtDepo2.TabIndex = 15
        '
        'cboKargo
        '
        Me.cboKargo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KargoID", True))
        Me.cboKargo.EnterMoveNextControl = True
        Me.cboKargo.Location = New System.Drawing.Point(301, 88)
        Me.cboKargo.MenuManager = Me.BarManager1
        Me.cboKargo.Name = "cboKargo"
        Me.cboKargo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboKargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKargo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KargoIsmi", "Kargo Ismi", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KargoID", "Kargo ID", 5, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKargo.Properties.DataSource = Me.tbKargolar
        Me.cboKargo.Properties.DisplayMember = "KargoIsmi"
        Me.cboKargo.Properties.NullText = ""
        Me.cboKargo.Properties.ShowHeader = False
        Me.cboKargo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboKargo.Properties.ValueMember = "KargoID"
        Me.cboKargo.Size = New System.Drawing.Size(177, 20)
        Me.cboKargo.TabIndex = 38
        '
        'tbKargolar
        '
        Me.tbKargolar.Columns.AddRange(New System.Data.DataColumn() {Me.tbKargolar_KargoID, Me.tbKargolar_KargoIsmi})
        Me.tbKargolar.Connection = Me.FirmConn
        Me.tbKargolar.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KargoID"}, True)})
        Me.tbKargolar.CurrentRow = Nothing
        Me.tbKargolar.DataSourceLink = Nothing
        Me.tbKargolar.DeleteCommand = Me.SqlCommand32
        Me.tbKargolar.Filter = ""
        Me.tbKargolar.InsertCommand = Me.SqlCommand30
        Me.tbKargolar.LiveSave = False
        Me.tbKargolar.MaxRecords = CType(0, Long)
        Me.tbKargolar.Name = "tbKargolar"
        Me.tbKargolar.ParentRelation_ChildColumns = Nothing
        Me.tbKargolar.ParentRelation_ParentColumns = Nothing
        Me.tbKargolar.ParentRelation_Table = Nothing
        Me.tbKargolar.Position = CType(-1, Long)
        Me.tbKargolar.PrimaryKey = New System.Data.DataColumn() {Me.tbKargolar_KargoID}
        Me.tbKargolar.Quoted = False
        Me.tbKargolar.SelectCommand = Me.SqlCommand29
        Me.tbKargolar.TableName = "NeoTable1"
        Me.tbKargolar.Transaction = Nothing
        Me.tbKargolar.UpdateCommand = Me.SqlCommand31
        '
        'tbKargolar_KargoID
        '
        Me.tbKargolar_KargoID.AllowDBNull = False
        Me.tbKargolar_KargoID.AutoIncrement = True
        Me.tbKargolar_KargoID.ColumnName = "KargoID"
        Me.tbKargolar_KargoID.DataType = GetType(Integer)
        '
        'tbKargolar_KargoIsmi
        '
        Me.tbKargolar_KargoIsmi.ColumnName = "KargoIsmi"
        '
        'SqlCommand29
        '
        Me.SqlCommand29.CommandText = "SELECT KargoID , KargoIsmi FROM Kargolar WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(301, 71)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl11.TabIndex = 37
        Me.LabelControl11.Text = "Kargo/Sevk tipi"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cmdSevkDetayOzet)
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Controls.Add(Me.cmdSiparisEkle)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 117)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1222, 45)
        Me.PanelControl2.TabIndex = 0
        '
        'cmdSevkDetayOzet
        '
        Me.cmdSevkDetayOzet.Image = Global.ProbarSiparis.My.Resources.Resources.Actions_help_hint_icon_32
        Me.cmdSevkDetayOzet.Location = New System.Drawing.Point(681, 6)
        Me.cmdSevkDetayOzet.Name = "cmdSevkDetayOzet"
        Me.cmdSevkDetayOzet.Size = New System.Drawing.Size(161, 34)
        Me.cmdSevkDetayOzet.TabIndex = 38
        Me.cmdSevkDetayOzet.Text = "Secilenlerin ozeti"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToplamPaketTextEdit)
        Me.Panel1.Controls.Add(Me.ToplamMiktarTextEdit)
        Me.Panel1.Controls.Add(Me.LabelControl10)
        Me.Panel1.Controls.Add(Me.LabelControl9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(880, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 41)
        Me.Panel1.TabIndex = 37
        '
        'ToplamPaketTextEdit
        '
        Me.ToplamPaketTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "ToplamPaket", True))
        Me.ToplamPaketTextEdit.EnterMoveNextControl = True
        Me.ToplamPaketTextEdit.Location = New System.Drawing.Point(57, 6)
        Me.ToplamPaketTextEdit.MenuManager = Me.BarManager1
        Me.ToplamPaketTextEdit.Name = "ToplamPaketTextEdit"
        Me.ToplamPaketTextEdit.Properties.ReadOnly = True
        Me.ToplamPaketTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ToplamPaketTextEdit.TabIndex = 24
        '
        'ToplamMiktarTextEdit
        '
        Me.ToplamMiktarTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "ToplamAdet", True))
        Me.ToplamMiktarTextEdit.EnterMoveNextControl = True
        Me.ToplamMiktarTextEdit.Location = New System.Drawing.Point(217, 5)
        Me.ToplamMiktarTextEdit.MenuManager = Me.BarManager1
        Me.ToplamMiktarTextEdit.Name = "ToplamMiktarTextEdit"
        Me.ToplamMiktarTextEdit.Properties.ReadOnly = True
        Me.ToplamMiktarTextEdit.Size = New System.Drawing.Size(109, 20)
        Me.ToplamMiktarTextEdit.TabIndex = 25
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(173, 8)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl10.TabIndex = 36
        Me.LabelControl10.Text = "T.Adet"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(8, 9)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl9.TabIndex = 35
        Me.LabelControl9.Text = "T.Paket"
        '
        'cmdSiparisEkle
        '
        Me.cmdSiparisEkle.Location = New System.Drawing.Point(7, 6)
        Me.cmdSiparisEkle.Name = "cmdSiparisEkle"
        Me.cmdSiparisEkle.Size = New System.Drawing.Size(161, 34)
        Me.cmdSiparisEkle.TabIndex = 0
        Me.cmdSiparisEkle.Text = "(+) Siparis Ekle (F3)"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Tarih", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(108, 5)
        Me.DateEdit1.MenuManager = Me.BarManager1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(115, 20)
        Me.DateEdit1.TabIndex = 26
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(9, 92)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Tasima evrak no"
        '
        'KargoEvrakNoTextEdit
        '
        Me.KargoEvrakNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KargoEvrakNo", True))
        Me.KargoEvrakNoTextEdit.EnterMoveNextControl = True
        Me.KargoEvrakNoTextEdit.Location = New System.Drawing.Point(108, 89)
        Me.KargoEvrakNoTextEdit.MenuManager = Me.BarManager1
        Me.KargoEvrakNoTextEdit.Name = "KargoEvrakNoTextEdit"
        Me.KargoEvrakNoTextEdit.Size = New System.Drawing.Size(177, 20)
        Me.KargoEvrakNoTextEdit.TabIndex = 23
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(301, 36)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 31
        Me.LabelControl5.Text = "Cari Unvan"
        '
        'CariUnvanButtonEdit
        '
        Me.CariUnvanButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariUnvan", True))
        Me.CariUnvanButtonEdit.EnterMoveNextControl = True
        Me.CariUnvanButtonEdit.Location = New System.Drawing.Point(391, 33)
        Me.CariUnvanButtonEdit.MenuManager = Me.BarManager1
        Me.CariUnvanButtonEdit.Name = "CariUnvanButtonEdit"
        Me.CariUnvanButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CariUnvanButtonEdit.Size = New System.Drawing.Size(363, 20)
        Me.CariUnvanButtonEdit.TabIndex = 14
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Cari kod"
        '
        'CariKodButtonEdit
        '
        Me.CariKodButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariKod", True))
        Me.CariKodButtonEdit.EnterMoveNextControl = True
        Me.CariKodButtonEdit.Location = New System.Drawing.Point(108, 33)
        Me.CariKodButtonEdit.MenuManager = Me.BarManager1
        Me.CariKodButtonEdit.Name = "CariKodButtonEdit"
        Me.CariKodButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CariKodButtonEdit.Size = New System.Drawing.Size(177, 20)
        Me.CariKodButtonEdit.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(489, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Evrak Sira"
        '
        'IrsEvrakSiraSpinEdit
        '
        Me.IrsEvrakSiraSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SevkEvrakSira", True))
        Me.IrsEvrakSiraSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IrsEvrakSiraSpinEdit.EnterMoveNextControl = True
        Me.IrsEvrakSiraSpinEdit.Location = New System.Drawing.Point(553, 5)
        Me.IrsEvrakSiraSpinEdit.MenuManager = Me.BarManager1
        Me.IrsEvrakSiraSpinEdit.Name = "IrsEvrakSiraSpinEdit"
        Me.IrsEvrakSiraSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IrsEvrakSiraSpinEdit.Properties.IsFloatValue = False
        Me.IrsEvrakSiraSpinEdit.Properties.Mask.EditMask = "N00"
        Me.IrsEvrakSiraSpinEdit.Size = New System.Drawing.Size(103, 20)
        Me.IrsEvrakSiraSpinEdit.TabIndex = 12
        '
        'IrsEvrakSeriTextEdit
        '
        Me.IrsEvrakSeriTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SevkEvrakSeri", True))
        Me.IrsEvrakSeriTextEdit.EnterMoveNextControl = True
        Me.IrsEvrakSeriTextEdit.Location = New System.Drawing.Point(391, 5)
        Me.IrsEvrakSeriTextEdit.MenuManager = Me.BarManager1
        Me.IrsEvrakSeriTextEdit.Name = "IrsEvrakSeriTextEdit"
        Me.IrsEvrakSeriTextEdit.Properties.MaxLength = 4
        Me.IrsEvrakSeriTextEdit.Size = New System.Drawing.Size(91, 20)
        Me.IrsEvrakSeriTextEdit.TabIndex = 11
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(301, 8)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Evrak Seri"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Tarih"
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = resources.GetString("SqlCommand13.CommandText")
        '
        'SqlCommand14
        '
        Me.SqlCommand14.CommandText = resources.GetString("SqlCommand14.CommandText")
        Me.SqlCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_IrsSiparisID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand15
        '
        Me.SqlCommand15.CommandText = resources.GetString("SqlCommand15.CommandText")
        '
        'SqlCommand16
        '
        Me.SqlCommand16.CommandText = "UPDATE SevkDetay SET Deleted = SevkDetayID  , ModifiedBy = @ModifiedBy , Modified" &
    "Date = GETDATE()   WHERE SevkDetayID = @SevkDetayID"
        '
        'colSevkID
        '
        Me.colSevkID.FieldName = "SevkID"
        Me.colSevkID.Name = "colSevkID"
        Me.colSevkID.Visible = True
        Me.colSevkID.VisibleIndex = 0
        '
        'colSevkTipi
        '
        Me.colSevkTipi.FieldName = "SevkTipi"
        Me.colSevkTipi.Name = "colSevkTipi"
        Me.colSevkTipi.Visible = True
        Me.colSevkTipi.VisibleIndex = 1
        '
        'colTarih
        '
        Me.colTarih.FieldName = "Tarih"
        Me.colTarih.Name = "colTarih"
        Me.colTarih.Visible = True
        Me.colTarih.VisibleIndex = 2
        '
        'colSevkEvrakSeri
        '
        Me.colSevkEvrakSeri.FieldName = "SevkEvrakSeri"
        Me.colSevkEvrakSeri.Name = "colSevkEvrakSeri"
        Me.colSevkEvrakSeri.Visible = True
        Me.colSevkEvrakSeri.VisibleIndex = 3
        '
        'colSevkEvrakSira
        '
        Me.colSevkEvrakSira.FieldName = "SevkEvrakSira"
        Me.colSevkEvrakSira.Name = "colSevkEvrakSira"
        Me.colSevkEvrakSira.Visible = True
        Me.colSevkEvrakSira.VisibleIndex = 4
        '
        'colSevkBelgeNo
        '
        Me.colSevkBelgeNo.FieldName = "SevkBelgeNo"
        Me.colSevkBelgeNo.Name = "colSevkBelgeNo"
        Me.colSevkBelgeNo.Visible = True
        Me.colSevkBelgeNo.VisibleIndex = 5
        '
        'colCariKod
        '
        Me.colCariKod.FieldName = "CariKod"
        Me.colCariKod.Name = "colCariKod"
        Me.colCariKod.Visible = True
        Me.colCariKod.VisibleIndex = 6
        '
        'colCariUnvan
        '
        Me.colCariUnvan.FieldName = "CariUnvan"
        Me.colCariUnvan.Name = "colCariUnvan"
        Me.colCariUnvan.Visible = True
        Me.colCariUnvan.VisibleIndex = 7
        '
        'colAciklama1
        '
        Me.colAciklama1.FieldName = "Aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Visible = True
        Me.colAciklama1.VisibleIndex = 8
        '
        'colAciklama2
        '
        Me.colAciklama2.FieldName = "Aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Visible = True
        Me.colAciklama2.VisibleIndex = 9
        '
        'colAciklama3
        '
        Me.colAciklama3.FieldName = "Aciklama3"
        Me.colAciklama3.Name = "colAciklama3"
        Me.colAciklama3.Visible = True
        Me.colAciklama3.VisibleIndex = 10
        '
        'colKargoID
        '
        Me.colKargoID.FieldName = "KargoID"
        Me.colKargoID.Name = "colKargoID"
        Me.colKargoID.Visible = True
        Me.colKargoID.VisibleIndex = 11
        '
        'colKargoEvrakNo
        '
        Me.colKargoEvrakNo.FieldName = "KargoEvrakNo"
        Me.colKargoEvrakNo.Name = "colKargoEvrakNo"
        Me.colKargoEvrakNo.Visible = True
        Me.colKargoEvrakNo.VisibleIndex = 12
        '
        'colYurtDisi
        '
        Me.colYurtDisi.FieldName = "YurtDisi"
        Me.colYurtDisi.Name = "colYurtDisi"
        Me.colYurtDisi.Visible = True
        Me.colYurtDisi.VisibleIndex = 13
        '
        'colOnayli
        '
        Me.colOnayli.FieldName = "Onayli"
        Me.colOnayli.Name = "colOnayli"
        Me.colOnayli.Visible = True
        Me.colOnayli.VisibleIndex = 14
        '
        'colOnaylayan
        '
        Me.colOnaylayan.FieldName = "Onaylayan"
        Me.colOnaylayan.Name = "colOnaylayan"
        Me.colOnaylayan.Visible = True
        Me.colOnaylayan.VisibleIndex = 15
        '
        'colOnayTarihi
        '
        Me.colOnayTarihi.FieldName = "OnayTarihi"
        Me.colOnayTarihi.Name = "colOnayTarihi"
        Me.colOnayTarihi.Visible = True
        Me.colOnayTarihi.VisibleIndex = 16
        '
        'colIptal
        '
        Me.colIptal.FieldName = "Iptal"
        Me.colIptal.Name = "colIptal"
        Me.colIptal.Visible = True
        Me.colIptal.VisibleIndex = 17
        '
        'colIptalNedeni
        '
        Me.colIptalNedeni.FieldName = "IptalNedeni"
        Me.colIptalNedeni.Name = "colIptalNedeni"
        Me.colIptalNedeni.Visible = True
        Me.colIptalNedeni.VisibleIndex = 18
        '
        'colDepo
        '
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 19
        '
        'colDepo2
        '
        Me.colDepo2.FieldName = "Depo2"
        Me.colDepo2.Name = "colDepo2"
        Me.colDepo2.Visible = True
        Me.colDepo2.VisibleIndex = 20
        '
        'colCekiListesiUygula
        '
        Me.colCekiListesiUygula.FieldName = "CekiListesiUygula"
        Me.colCekiListesiUygula.Name = "colCekiListesiUygula"
        Me.colCekiListesiUygula.Visible = True
        Me.colCekiListesiUygula.VisibleIndex = 21
        '
        'DetailTable_SevkSipDetayID
        '
        Me.DetailTable_SevkSipDetayID.AllowDBNull = False
        Me.DetailTable_SevkSipDetayID.AutoIncrement = True
        Me.DetailTable_SevkSipDetayID.ColumnName = "SevkSipDetayID"
        Me.DetailTable_SevkSipDetayID.DataType = GetType(Integer)
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
        'DetailTable_SevkID
        '
        Me.DetailTable_SevkID.ColumnName = "SevkID"
        Me.DetailTable_SevkID.DataType = GetType(Integer)
        '
        'DetailTable_SiparisID
        '
        Me.DetailTable_SiparisID.ColumnName = "SiparisID"
        Me.DetailTable_SiparisID.DataType = GetType(Integer)
        '
        'DetailTable_SipDetayID
        '
        Me.DetailTable_SipDetayID.ColumnName = "SipDetayID"
        Me.DetailTable_SipDetayID.DataType = GetType(Integer)
        '
        'MasterTable_SevkID
        '
        Me.MasterTable_SevkID.AllowDBNull = False
        Me.MasterTable_SevkID.AutoIncrement = True
        Me.MasterTable_SevkID.ColumnName = "SevkID"
        Me.MasterTable_SevkID.DataType = GetType(Integer)
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
        'MasterTable_SevkTipi
        '
        Me.MasterTable_SevkTipi.ColumnName = "SevkTipi"
        Me.MasterTable_SevkTipi.DataType = GetType(Integer)
        '
        'MasterTable_Tarih
        '
        Me.MasterTable_Tarih.ColumnName = "Tarih"
        Me.MasterTable_Tarih.DataType = GetType(Date)
        '
        'MasterTable_SevkEvrakSeri
        '
        Me.MasterTable_SevkEvrakSeri.ColumnName = "SevkEvrakSeri"
        '
        'MasterTable_SevkEvrakSira
        '
        Me.MasterTable_SevkEvrakSira.ColumnName = "SevkEvrakSira"
        Me.MasterTable_SevkEvrakSira.DataType = GetType(Integer)
        '
        'MasterTable_SevkBelgeNo
        '
        Me.MasterTable_SevkBelgeNo.ColumnName = "SevkBelgeNo"
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
        'MasterTable_TasimaTuru
        '
        Me.MasterTable_TasimaTuru.ColumnName = "TasimaTuru"
        '
        'MasterTable_KargoID
        '
        Me.MasterTable_KargoID.ColumnName = "KargoID"
        Me.MasterTable_KargoID.DataType = GetType(Integer)
        '
        'MasterTable_KargoEvrakNo
        '
        Me.MasterTable_KargoEvrakNo.ColumnName = "KargoEvrakNo"
        '
        'MasterTable_YurtDisi
        '
        Me.MasterTable_YurtDisi.ColumnName = "YurtDisi"
        Me.MasterTable_YurtDisi.DataType = GetType(Integer)
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
        'MasterTable_Depo
        '
        Me.MasterTable_Depo.ColumnName = "Depo"
        '
        'MasterTable_Depo2
        '
        Me.MasterTable_Depo2.ColumnName = "Depo2"
        '
        'MasterTable_ToplamAdet
        '
        Me.MasterTable_ToplamAdet.ColumnName = "ToplamAdet"
        Me.MasterTable_ToplamAdet.DataType = GetType(Double)
        '
        'MasterTable_ToplamPaket
        '
        Me.MasterTable_ToplamPaket.ColumnName = "ToplamPaket"
        Me.MasterTable_ToplamPaket.DataType = GetType(Double)
        '
        'MasterTable_CekiListesiUygula
        '
        Me.MasterTable_CekiListesiUygula.ColumnName = "CekiListesiUygula"
        Me.MasterTable_CekiListesiUygula.DataType = GetType(Integer)
        '
        'DetailTable2_SevkPaketID
        '
        Me.DetailTable2_SevkPaketID.AllowDBNull = False
        Me.DetailTable2_SevkPaketID.AutoIncrement = True
        Me.DetailTable2_SevkPaketID.ColumnName = "SevkPaketID"
        Me.DetailTable2_SevkPaketID.DataType = GetType(Integer)
        '
        'DetailTable2_Deleted
        '
        Me.DetailTable2_Deleted.ColumnName = "Deleted"
        Me.DetailTable2_Deleted.DataType = GetType(Integer)
        '
        'DetailTable2_CreatedBy
        '
        Me.DetailTable2_CreatedBy.ColumnName = "CreatedBy"
        Me.DetailTable2_CreatedBy.DataType = GetType(Integer)
        '
        'DetailTable2_CreatedDate
        '
        Me.DetailTable2_CreatedDate.ColumnName = "CreatedDate"
        Me.DetailTable2_CreatedDate.DataType = GetType(Date)
        '
        'DetailTable2_ModifiedBy
        '
        Me.DetailTable2_ModifiedBy.ColumnName = "ModifiedBy"
        Me.DetailTable2_ModifiedBy.DataType = GetType(Integer)
        '
        'DetailTable2_ModifiedDate
        '
        Me.DetailTable2_ModifiedDate.ColumnName = "ModifiedDate"
        Me.DetailTable2_ModifiedDate.DataType = GetType(Date)
        '
        'DetailTable2_SevkID
        '
        Me.DetailTable2_SevkID.ColumnName = "SevkID"
        Me.DetailTable2_SevkID.DataType = GetType(Integer)
        '
        'DetailTable2_PaketNo
        '
        Me.DetailTable2_PaketNo.ColumnName = "PaketNo"
        Me.DetailTable2_PaketNo.DataType = GetType(Integer)
        '
        'DetailTable2_NetAgirlik
        '
        Me.DetailTable2_NetAgirlik.ColumnName = "NetAgirlik"
        Me.DetailTable2_NetAgirlik.DataType = GetType(Double)
        '
        'DetailTable2_Dara
        '
        Me.DetailTable2_Dara.ColumnName = "Dara"
        Me.DetailTable2_Dara.DataType = GetType(Double)
        '
        'DetailTable2_BrutAgirlik
        '
        Me.DetailTable2_BrutAgirlik.ColumnName = "BrutAgirlik"
        Me.DetailTable2_BrutAgirlik.DataType = GetType(Double)
        '
        'DetailTable2_En
        '
        Me.DetailTable2_En.ColumnName = "En"
        Me.DetailTable2_En.DataType = GetType(Double)
        '
        'DetailTable2_Boy
        '
        Me.DetailTable2_Boy.ColumnName = "Boy"
        Me.DetailTable2_Boy.DataType = GetType(Double)
        '
        'DetailTable2_Yukseklik
        '
        Me.DetailTable2_Yukseklik.ColumnName = "Yukseklik"
        Me.DetailTable2_Yukseklik.DataType = GetType(Double)
        '
        'DetailTable3_SevkDetayID
        '
        Me.DetailTable3_SevkDetayID.AllowDBNull = False
        Me.DetailTable3_SevkDetayID.AutoIncrement = True
        Me.DetailTable3_SevkDetayID.ColumnName = "SevkDetayID"
        Me.DetailTable3_SevkDetayID.DataType = GetType(Integer)
        '
        'DetailTable3_Deleted
        '
        Me.DetailTable3_Deleted.ColumnName = "Deleted"
        Me.DetailTable3_Deleted.DataType = GetType(Integer)
        '
        'DetailTable3_CreatedBy
        '
        Me.DetailTable3_CreatedBy.ColumnName = "CreatedBy"
        Me.DetailTable3_CreatedBy.DataType = GetType(Integer)
        '
        'DetailTable3_CreatedDate
        '
        Me.DetailTable3_CreatedDate.ColumnName = "CreatedDate"
        Me.DetailTable3_CreatedDate.DataType = GetType(Date)
        '
        'DetailTable3_ModifiedBy
        '
        Me.DetailTable3_ModifiedBy.ColumnName = "ModifiedBy"
        Me.DetailTable3_ModifiedBy.DataType = GetType(Integer)
        '
        'DetailTable3_ModifiedDate
        '
        Me.DetailTable3_ModifiedDate.ColumnName = "ModifiedDate"
        Me.DetailTable3_ModifiedDate.DataType = GetType(Date)
        '
        'DetailTable3_SevkID
        '
        Me.DetailTable3_SevkID.ColumnName = "SevkID"
        Me.DetailTable3_SevkID.DataType = GetType(Integer)
        '
        'DetailTable3_SipDetayID
        '
        Me.DetailTable3_SipDetayID.ColumnName = "SipDetayID"
        Me.DetailTable3_SipDetayID.DataType = GetType(Integer)
        '
        'DetailTable3_SipDetayFiyatAdetID
        '
        Me.DetailTable3_SipDetayFiyatAdetID.ColumnName = "SipDetayFiyatAdetID"
        Me.DetailTable3_SipDetayFiyatAdetID.DataType = GetType(Integer)
        '
        'DetailTable3_SevkPaketID
        '
        Me.DetailTable3_SevkPaketID.ColumnName = "SevkPaketID"
        '
        'DetailTable3_PaketNo
        '
        Me.DetailTable3_PaketNo.ColumnName = "PaketNo"
        Me.DetailTable3_PaketNo.DataType = GetType(Integer)
        '
        'DetailTable3_BedenKod
        '
        Me.DetailTable3_BedenKod.ColumnName = "BedenKod"
        '
        'DetailTable3_Adet
        '
        Me.DetailTable3_Adet.ColumnName = "Adet"
        Me.DetailTable3_Adet.DataType = GetType(Double)
        '
        'DetailTable3_DetayAciklama
        '
        Me.DetailTable3_DetayAciklama.ColumnName = "DetayAciklama"
        '
        'DetailTable3_RenkKod
        '
        Me.DetailTable3_RenkKod.ColumnName = "RenkKod"
        '
        'DetailTable3_sth_RECno
        '
        Me.DetailTable3_sth_RECno.ColumnName = "sth_RECno"
        Me.DetailTable3_sth_RECno.DataType = GetType(Integer)
        '
        'DetailTable3_sth_evrakno_seri
        '
        Me.DetailTable3_sth_evrakno_seri.ColumnName = "sth_evrakno_seri"
        '
        'DetailTable3_sth_evrakno_sira
        '
        Me.DetailTable3_sth_evrakno_sira.ColumnName = "sth_evrakno_sira"
        Me.DetailTable3_sth_evrakno_sira.DataType = GetType(Integer)
        '
        'DetailTable3_sth_satirno
        '
        Me.DetailTable3_sth_satirno.ColumnName = "sth_satirno"
        Me.DetailTable3_sth_satirno.DataType = GetType(Integer)
        '
        'DetailTable3_KategoriKod
        '
        Me.DetailTable3_KategoriKod.ColumnName = "KategoriKod"
        '
        'DetailTable3_KategoriIsim
        '
        Me.DetailTable3_KategoriIsim.ColumnName = "KategoriIsim"
        '
        'DetailTable3_Okul
        '
        Me.DetailTable3_Okul.ColumnName = "Okul"
        '
        'DetailTable3_NetFiyat
        '
        Me.DetailTable3_NetFiyat.ColumnName = "NetFiyat"
        Me.DetailTable3_NetFiyat.DataType = GetType(Double)
        '
        'DetailTable3_StokKod
        '
        Me.DetailTable3_StokKod.ColumnName = "StokKod"
        '
        'DetailTable3_SiparisNo
        '
        Me.DetailTable3_SiparisNo.ColumnName = "SiparisNo"
        '
        'DetailTable3_Tarih
        '
        Me.DetailTable3_Tarih.ColumnName = "Tarih"
        Me.DetailTable3_Tarih.DataType = GetType(Date)
        '
        'DetailTable3_TerminTarihi
        '
        Me.DetailTable3_TerminTarihi.ColumnName = "TerminTarihi"
        Me.DetailTable3_TerminTarihi.DataType = GetType(Date)
        '
        'DetailTable3_SipMiktar
        '
        Me.DetailTable3_SipMiktar.ColumnName = "SipMiktar"
        Me.DetailTable3_SipMiktar.DataType = GetType(Double)
        '
        'DetailTable3_TeslimMiktar
        '
        Me.DetailTable3_TeslimMiktar.ColumnName = "TeslimMiktar"
        Me.DetailTable3_TeslimMiktar.DataType = GetType(Double)
        '
        'DetailTable3_Tutar
        '
        Me.DetailTable3_Tutar.ColumnName = "Tutar"
        Me.DetailTable3_Tutar.DataType = GetType(Double)
        '
        'DetailTable3_Kalan
        '
        Me.DetailTable3_Kalan.ColumnName = "Kalan"
        Me.DetailTable3_Kalan.DataType = GetType(Double)
        '
        'frmSevkler
        '
        Me.ClientSize = New System.Drawing.Size(1232, 606)
        Me.FormCode = "000025"
        Me.Name = "frmSevkler"
        Me.Text = "Sevk fisleri"
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
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.grDetay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grDetayView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelYeniPaket.ResumeLayout(False)
        Me.panelYeniPaket.PerformLayout()
        CType(Me.txtAktifPaketNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSipDetay.ResumeLayout(False)
        CType(Me.grSiparisDetay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grSiparisDetayView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOkul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.grPaket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grPaketView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.panelAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAdmin.ResumeLayout(False)
        CType(Me.chkIptal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOnayli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDepo.ResumeLayout(False)
        Me.panelDepo.PerformLayout()
        CType(Me.txtDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKargolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ToplamPaketTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToplamMiktarTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KargoEvrakNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CariUnvanButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CariKodButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrsEvrakSiraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrsEvrakSeriTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents IrsEvrakSeriTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IrsEvrakSiraSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CariKodButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents CariUnvanButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents KargoEvrakNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToplamPaketTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToplamMiktarTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDepo2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDepo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdSiparisEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grSiparisDetay As DevExpress.XtraGrid.GridControl
    Friend WithEvents grSiparisDetayView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSipEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colKategoriID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenKod1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbKategori As NeoDAC.NeoTable
    Friend WithEvents tbKategori_KategoriID As System.Data.DataColumn
    Friend WithEvents tbKategori_UstKategoriID As System.Data.DataColumn
    Friend WithEvents tbKategori_KategoriKod As System.Data.DataColumn
    Friend WithEvents tbKategori_KategoriIsim As System.Data.DataColumn
    Friend WithEvents tbKategori_StokKodFormat As System.Data.DataColumn
    Friend WithEvents tbKategori_IntCode As System.Data.DataColumn
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbOkul As NeoDAC.NeoTable
    Friend WithEvents tbOkul_OkulID As System.Data.DataColumn
    Friend WithEvents tbOkul_OkulKod As System.Data.DataColumn
    Friend WithEvents tbOkul_OkulIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_IlceID As System.Data.DataColumn
    Friend WithEvents tbOkul_IlID As System.Data.DataColumn
    Friend WithEvents tbOkul_IlIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_IlceIsmi As System.Data.DataColumn
    Friend WithEvents tbOkul_DisplayText As System.Data.DataColumn
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSevkID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkBelgeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKargoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKargoEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYurtDisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnayli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnaylayan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnayTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptalNedeni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCekiListesiUygula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbKargolar As NeoDAC.NeoTable
    Friend WithEvents tbKargolar_KargoID As System.Data.DataColumn
    Friend WithEvents tbKargolar_KargoIsmi As System.Data.DataColumn
    Friend WithEvents SqlCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DetailTable_SevkSipDetayID As System.Data.DataColumn
    Friend WithEvents DetailTable_Deleted As System.Data.DataColumn
    Friend WithEvents DetailTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents DetailTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents DetailTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents DetailTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents DetailTable_SevkID As System.Data.DataColumn
    Friend WithEvents DetailTable_SiparisID As System.Data.DataColumn
    Friend WithEvents DetailTable_SipDetayID As System.Data.DataColumn
    Friend WithEvents cboKargo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grDetay As DevExpress.XtraGrid.GridControl
    Friend WithEvents grDetayView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents panelDepo As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grPaket As DevExpress.XtraGrid.GridControl
    Friend WithEvents grPaketView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSevkPaketID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaketNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrutAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkPaketID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaketNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetayAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRenkKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipDetayFiyatAdetID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelYeniPaket As System.Windows.Forms.Panel
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdYeniPaket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelSipDetay As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdPaketeEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerminTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslimMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MasterTable_SevkID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_SevkTipi As System.Data.DataColumn
    Friend WithEvents MasterTable_Tarih As System.Data.DataColumn
    Friend WithEvents MasterTable_SevkEvrakSeri As System.Data.DataColumn
    Friend WithEvents MasterTable_SevkEvrakSira As System.Data.DataColumn
    Friend WithEvents MasterTable_SevkBelgeNo As System.Data.DataColumn
    Friend WithEvents MasterTable_CariKod As System.Data.DataColumn
    Friend WithEvents MasterTable_CariUnvan As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama2 As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama3 As System.Data.DataColumn
    Friend WithEvents MasterTable_TasimaTuru As System.Data.DataColumn
    Friend WithEvents MasterTable_KargoID As System.Data.DataColumn
    Friend WithEvents MasterTable_KargoEvrakNo As System.Data.DataColumn
    Friend WithEvents MasterTable_YurtDisi As System.Data.DataColumn
    Friend WithEvents MasterTable_Onayli As System.Data.DataColumn
    Friend WithEvents MasterTable_Onaylayan As System.Data.DataColumn
    Friend WithEvents MasterTable_OnayTarihi As System.Data.DataColumn
    Friend WithEvents MasterTable_Iptal As System.Data.DataColumn
    Friend WithEvents MasterTable_IptalNedeni As System.Data.DataColumn
    Friend WithEvents MasterTable_Depo As System.Data.DataColumn
    Friend WithEvents MasterTable_Depo2 As System.Data.DataColumn
    Friend WithEvents MasterTable_ToplamAdet As System.Data.DataColumn
    Friend WithEvents MasterTable_ToplamPaket As System.Data.DataColumn
    Friend WithEvents MasterTable_CekiListesiUygula As System.Data.DataColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSevkDetayOzet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmdSevkSatirSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DetailTable2_SevkPaketID As System.Data.DataColumn
    Friend WithEvents DetailTable2_Deleted As System.Data.DataColumn
    Friend WithEvents DetailTable2_CreatedBy As System.Data.DataColumn
    Friend WithEvents DetailTable2_CreatedDate As System.Data.DataColumn
    Friend WithEvents DetailTable2_ModifiedBy As System.Data.DataColumn
    Friend WithEvents DetailTable2_ModifiedDate As System.Data.DataColumn
    Friend WithEvents DetailTable2_SevkID As System.Data.DataColumn
    Friend WithEvents DetailTable2_PaketNo As System.Data.DataColumn
    Friend WithEvents DetailTable2_NetAgirlik As System.Data.DataColumn
    Friend WithEvents DetailTable2_Dara As System.Data.DataColumn
    Friend WithEvents DetailTable2_BrutAgirlik As System.Data.DataColumn
    Friend WithEvents DetailTable2_En As System.Data.DataColumn
    Friend WithEvents DetailTable2_Boy As System.Data.DataColumn
    Friend WithEvents DetailTable2_Yukseklik As System.Data.DataColumn
    Friend WithEvents colEn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYukseklik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panelAdmin As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkIptal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkOnayli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdOnayla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAktifPaketNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdSonPaketiSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DetailTable3_SevkDetayID As System.Data.DataColumn
    Friend WithEvents DetailTable3_Deleted As System.Data.DataColumn
    Friend WithEvents DetailTable3_CreatedBy As System.Data.DataColumn
    Friend WithEvents DetailTable3_CreatedDate As System.Data.DataColumn
    Friend WithEvents DetailTable3_ModifiedBy As System.Data.DataColumn
    Friend WithEvents DetailTable3_ModifiedDate As System.Data.DataColumn
    Friend WithEvents DetailTable3_SevkID As System.Data.DataColumn
    Friend WithEvents DetailTable3_SipDetayID As System.Data.DataColumn
    Friend WithEvents DetailTable3_SipDetayFiyatAdetID As System.Data.DataColumn
    Friend WithEvents DetailTable3_SevkPaketID As System.Data.DataColumn
    Friend WithEvents DetailTable3_PaketNo As System.Data.DataColumn
    Friend WithEvents DetailTable3_BedenKod As System.Data.DataColumn
    Friend WithEvents DetailTable3_Adet As System.Data.DataColumn
    Friend WithEvents DetailTable3_DetayAciklama As System.Data.DataColumn
    Friend WithEvents DetailTable3_RenkKod As System.Data.DataColumn
    Friend WithEvents DetailTable3_sth_RECno As System.Data.DataColumn
    Friend WithEvents DetailTable3_sth_evrakno_seri As System.Data.DataColumn
    Friend WithEvents DetailTable3_sth_evrakno_sira As System.Data.DataColumn
    Friend WithEvents DetailTable3_sth_satirno As System.Data.DataColumn
    Friend WithEvents DetailTable3_KategoriKod As System.Data.DataColumn
    Friend WithEvents DetailTable3_KategoriIsim As System.Data.DataColumn
    Friend WithEvents DetailTable3_Okul As System.Data.DataColumn
    Friend WithEvents DetailTable3_NetFiyat As System.Data.DataColumn
    Friend WithEvents DetailTable3_StokKod As System.Data.DataColumn
    Friend WithEvents DetailTable3_SiparisNo As System.Data.DataColumn
    Friend WithEvents DetailTable3_Tarih As System.Data.DataColumn
    Friend WithEvents DetailTable3_TerminTarihi As System.Data.DataColumn
    Friend WithEvents DetailTable3_SipMiktar As System.Data.DataColumn
    Friend WithEvents DetailTable3_TeslimMiktar As System.Data.DataColumn
    Friend WithEvents DetailTable3_Tutar As System.Data.DataColumn
    Friend WithEvents DetailTable3_Kalan As System.Data.DataColumn
    Friend WithEvents colKalan As DevExpress.XtraGrid.Columns.GridColumn

End Class
