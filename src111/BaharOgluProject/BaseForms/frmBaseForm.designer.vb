
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseForm
    Inherits DevExpress.XtraEditors.XtraForm
    'Inherits Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFirst = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLast = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFormPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarSubItem()
        Me.btnExportExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportTXT = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportCSV = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportHTML = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportXml = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLanguageOptions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnApprove = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDisapprove = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHelp = New DevExpress.XtraBars.BarSubItem()
        Me.btnHelp_ShortCuts = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnHelp1 = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDocumentView_Tile = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDocumentView_Icon = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDocumentView_List = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDocumentView_Detail = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDocumentView_LargeIcon = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuRecordInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.BaseTab1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.conMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuShowRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserRecordInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panelFormDateFilter = New DevExpress.XtraEditors.PanelControl()
        Me.basePanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSetDate_Last1Year = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetDate_Last6Months = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetDate_Last3Months = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetDate_ThisYear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetDate_ThisMonth = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetDate_Today = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefreshList = New DevExpress.XtraEditors.SimpleButton()
        Me.chkDate2 = New DevExpress.XtraEditors.CheckEdit()
        Me.dtFormDate2 = New DevExpress.XtraEditors.DateEdit()
        Me.chkDate1 = New DevExpress.XtraEditors.CheckEdit()
        Me.dtFormDate1 = New DevExpress.XtraEditors.DateEdit()
        Me.lblMainWarning1 = New DevExpress.XtraEditors.LabelControl()
        Me.BaseTab2 = New DevExpress.XtraTab.XtraTabPage()
        Me.panelAuthCodes = New DevExpress.XtraEditors.PanelControl()
        Me.panelAuthCodesRight = New DevExpress.XtraEditors.PanelControl()
        Me.cboAuthCodes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblAuthCodeCaption = New DevExpress.XtraEditors.LabelControl()
        Me.BaseTab4 = New DevExpress.XtraTab.XtraTabPage()
        Me.DocumentLargeImages = New System.Windows.Forms.ImageList(Me.components)
        Me.DocumentSmallImages = New System.Windows.Forms.ImageList(Me.components)
        Me.popupDocumentView = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.panelBottom = New DevExpress.XtraEditors.PanelControl()
        Me.basePanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSelect = New DevExpress.XtraEditors.SimpleButton()
        Me.panelFormTop = New DevExpress.XtraEditors.PanelControl()
        Me.tmrBekle = New System.Windows.Forms.Timer(Me.components)
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog()
        Me.FirmConn = New NeoDAC.NeoConnection(Me.components)
        Me.MasterConn = New NeoDAC.NeoConnection(Me.components)
        Me.dlgDocumentFileOpen = New System.Windows.Forms.OpenFileDialog()
        Me.MasterTable = New NeoDAC.NeoTable(Me.components)
        Me.MasterLink = New NeoDAC.NeoLink(Me.components)
        Me.DetailTable = New NeoDAC.NeoTable(Me.components)
        Me.DetailLink = New NeoDAC.NeoLink(Me.components)
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.dlgDocumentFileSave = New System.Windows.Forms.SaveFileDialog()
        Me.DetailTable2 = New NeoDAC.NeoTable(Me.components)
        Me.DetailLink2 = New NeoDAC.NeoLink(Me.components)
        Me.DetailTable3 = New NeoDAC.NeoTable(Me.components)
        Me.DetailLink3 = New NeoDAC.NeoLink(Me.components)
        Me.txtTopInfo = New DevExpress.XtraEditors.TextEdit()
        Me.tmrShowError = New System.Windows.Forms.Timer(Me.components)
        Me.DetailTable4 = New NeoDAC.NeoTable(Me.components)
        Me.DetailLink4 = New NeoDAC.NeoLink(Me.components)
        Me.DetailTable5 = New NeoDAC.NeoTable(Me.components)
        Me.DetailLink5 = New NeoDAC.NeoLink(Me.components)
        Me.AuthCodes = New NeoDAC.NeoTable(Me.components)
        Me.AuthCodes_AuthCode = New System.Data.DataColumn()
        Me.AuthCodes_SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.AuthCodes_SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AuthCodes_SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AuthCodes_SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.TicariConn = New NeoDAC.NeoConnection(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.BaseTab1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conMenuGrid.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormDateFilter.SuspendLayout()
        CType(Me.basePanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.basePanelControl1.SuspendLayout()
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseTab2.SuspendLayout()
        CType(Me.panelAuthCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAuthCodes.SuspendLayout()
        CType(Me.panelAuthCodesRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAuthCodesRight.SuspendLayout()
        CType(Me.cboAuthCodes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupDocumentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.basePanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.basePanelControl3.SuspendLayout()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRefresh, Me.btnPrintGrid, Me.btnExport, Me.btnExportExcel, Me.btnExportPDF, Me.btnExportTXT, Me.btnExportCSV, Me.btnExportHTML, Me.btnHelp1, Me.btnNew, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.btnFirst, Me.btnPrior, Me.btnNext, Me.btnLast, Me.btnFormPrint, Me.btnHelp, Me.btnHelp_ShortCuts, Me.mnuDocumentView_Tile, Me.mnuDocumentView_Icon, Me.mnuDocumentView_List, Me.mnuDocumentView_Detail, Me.mnuDocumentView_LargeIcon, Me.btnApprove, Me.btnDisapprove, Me.mnuRecordInfo, Me.btnEdit, Me.btnExportXml, Me.btnImport, Me.btnLanguageOptions})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 43
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.btnNew, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCancel), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFirst), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrior), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNext), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLast), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFormPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrintGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnApprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDisapprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btnHelp, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnNew
        '
        Me.btnNew.Caption = "Yeni"
        Me.btnNew.Glyph = CType(resources.GetObject("btnNew.Glyph"), System.Drawing.Image)
        Me.btnNew.Hint = "Yeni"
        Me.btnNew.Id = 17
        Me.btnNew.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.btnNew.Name = "btnNew"
        Me.btnNew.ShortcutKeyDisplayString = "Ctrl+ N"
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Değiştir"
        Me.btnEdit.Glyph = Global.ProbarSiparis.My.Resources.Resources.note_edit
        Me.btnEdit.Hint = "Değiştir"
        Me.btnEdit.Id = 39
        Me.btnEdit.Name = "btnEdit"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Kaydet"
        Me.btnSave.Enabled = False
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Hint = "Kaydet"
        Me.btnSave.Id = 18
        Me.btnSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Vazgeç"
        Me.btnCancel.Enabled = False
        Me.btnCancel.Glyph = CType(resources.GetObject("btnCancel.Glyph"), System.Drawing.Image)
        Me.btnCancel.Hint = "Vazgeç"
        Me.btnCancel.Id = 19
        Me.btnCancel.Name = "btnCancel"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Tazele"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Hint = "Listele"
        Me.btnRefresh.Id = 0
        Me.btnRefresh.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.ShortcutKeyDisplayString = "F5"
        '
        'btnFirst
        '
        Me.btnFirst.Caption = "Ilk Kayıt"
        Me.btnFirst.Glyph = CType(resources.GetObject("btnFirst.Glyph"), System.Drawing.Image)
        Me.btnFirst.Hint = "İlk Kayıt"
        Me.btnFirst.Id = 23
        Me.btnFirst.Name = "btnFirst"
        '
        'btnPrior
        '
        Me.btnPrior.Caption = "Bir Önceki Kayıt"
        Me.btnPrior.Glyph = CType(resources.GetObject("btnPrior.Glyph"), System.Drawing.Image)
        Me.btnPrior.Hint = "Önceki Kayıt"
        Me.btnPrior.Id = 24
        Me.btnPrior.Name = "btnPrior"
        '
        'btnNext
        '
        Me.btnNext.Caption = "Bir Sonraki Kayıt"
        Me.btnNext.Glyph = CType(resources.GetObject("btnNext.Glyph"), System.Drawing.Image)
        Me.btnNext.Hint = "Sonraki Kayıt"
        Me.btnNext.Id = 25
        Me.btnNext.Name = "btnNext"
        '
        'btnLast
        '
        Me.btnLast.Caption = "Son Kayıt"
        Me.btnLast.Glyph = CType(resources.GetObject("btnLast.Glyph"), System.Drawing.Image)
        Me.btnLast.Hint = "En Son Kayıt"
        Me.btnLast.Id = 26
        Me.btnLast.Name = "btnLast"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Sil"
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Hint = "Sil"
        Me.btnDelete.Id = 20
        Me.btnDelete.Name = "btnDelete"
        '
        'btnFormPrint
        '
        Me.btnFormPrint.Caption = "Form Yazdır"
        Me.btnFormPrint.Glyph = Global.ProbarSiparis.My.Resources.Resources.PrintDirectLarge
        Me.btnFormPrint.Hint = "Kaydı Yazdır"
        Me.btnFormPrint.Id = 27
        Me.btnFormPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.btnFormPrint.Name = "btnFormPrint"
        '
        'btnPrintGrid
        '
        Me.btnPrintGrid.Caption = "Liste Yazdır"
        Me.btnPrintGrid.Glyph = Global.ProbarSiparis.My.Resources.Resources.DXGrid
        Me.btnPrintGrid.Hint = "Grid Yazdır"
        Me.btnPrintGrid.Id = 5
        Me.btnPrintGrid.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                Or System.Windows.Forms.Keys.P))
        Me.btnPrintGrid.Name = "btnPrintGrid"
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
        Me.btnExport.Hint = "Dışarı Al (Export)"
        Me.btnExport.Id = 8
        Me.btnExport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportPDF), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportTXT), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportCSV), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportHTML), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportXml, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLanguageOptions)})
        Me.btnExport.Name = "btnExport"
        Me.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Caption = "Excel"
        Me.btnExportExcel.Id = 9
        Me.btnExportExcel.Name = "btnExportExcel"
        '
        'btnExportPDF
        '
        Me.btnExportPDF.Caption = "PDF"
        Me.btnExportPDF.Id = 10
        Me.btnExportPDF.Name = "btnExportPDF"
        '
        'btnExportTXT
        '
        Me.btnExportTXT.Caption = "Txt"
        Me.btnExportTXT.Id = 11
        Me.btnExportTXT.Name = "btnExportTXT"
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Caption = "CSV"
        Me.btnExportCSV.Id = 12
        Me.btnExportCSV.Name = "btnExportCSV"
        '
        'btnExportHTML
        '
        Me.btnExportHTML.Caption = "Html"
        Me.btnExportHTML.Id = 13
        Me.btnExportHTML.Name = "btnExportHTML"
        '
        'btnExportXml
        '
        Me.btnExportXml.Caption = "Data Export"
        Me.btnExportXml.Id = 40
        Me.btnExportXml.Name = "btnExportXml"
        '
        'btnImport
        '
        Me.btnImport.Caption = "Data Import"
        Me.btnImport.Id = 41
        Me.btnImport.Name = "btnImport"
        '
        'btnLanguageOptions
        '
        Me.btnLanguageOptions.Caption = "Language Options"
        Me.btnLanguageOptions.Glyph = Global.ProbarSiparis.My.Resources.Resources.LanguageIcon_16x16
        Me.btnLanguageOptions.Id = 42
        Me.btnLanguageOptions.Name = "btnLanguageOptions"
        '
        'btnApprove
        '
        Me.btnApprove.Caption = "Onayla"
        Me.btnApprove.Glyph = CType(resources.GetObject("btnApprove.Glyph"), System.Drawing.Image)
        Me.btnApprove.Hint = "Onayla"
        Me.btnApprove.Id = 35
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnDisapprove
        '
        Me.btnDisapprove.Caption = "Onayı Kaldır"
        Me.btnDisapprove.Glyph = CType(resources.GetObject("btnDisapprove.Glyph"), System.Drawing.Image)
        Me.btnDisapprove.Hint = "Onayı Kaldır"
        Me.btnDisapprove.Id = 36
        Me.btnDisapprove.Name = "btnDisapprove"
        Me.btnDisapprove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnDisapprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnHelp
        '
        Me.btnHelp.Caption = "Yardım"
        Me.btnHelp.Glyph = Global.ProbarSiparis.My.Resources.Resources.help
        Me.btnHelp.Hint = "Yardım"
        Me.btnHelp.Id = 28
        Me.btnHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnHelp_ShortCuts)})
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'btnHelp_ShortCuts
        '
        Me.btnHelp_ShortCuts.Caption = "Kısa Yollar"
        Me.btnHelp_ShortCuts.Id = 29
        Me.btnHelp_ShortCuts.Name = "btnHelp_ShortCuts"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = False
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        Me.Bar3.Visible = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(893, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 468)
        Me.barDockControlBottom.Size = New System.Drawing.Size(893, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 401)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(893, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 401)
        '
        'btnHelp1
        '
        Me.btnHelp1.Caption = "Yardım"
        Me.btnHelp1.Glyph = Global.ProbarSiparis.My.Resources.Resources.help3
        Me.btnHelp1.Id = 16
        Me.btnHelp1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
        Me.btnHelp1.Name = "btnHelp1"
        '
        'mnuDocumentView_Tile
        '
        Me.mnuDocumentView_Tile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.mnuDocumentView_Tile.Caption = "Döşeme"
        Me.mnuDocumentView_Tile.Id = 30
        Me.mnuDocumentView_Tile.Name = "mnuDocumentView_Tile"
        '
        'mnuDocumentView_Icon
        '
        Me.mnuDocumentView_Icon.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.mnuDocumentView_Icon.Caption = "Simge"
        Me.mnuDocumentView_Icon.Down = True
        Me.mnuDocumentView_Icon.Id = 31
        Me.mnuDocumentView_Icon.Name = "mnuDocumentView_Icon"
        '
        'mnuDocumentView_List
        '
        Me.mnuDocumentView_List.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.mnuDocumentView_List.Caption = "Liste"
        Me.mnuDocumentView_List.Id = 32
        Me.mnuDocumentView_List.Name = "mnuDocumentView_List"
        '
        'mnuDocumentView_Detail
        '
        Me.mnuDocumentView_Detail.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.mnuDocumentView_Detail.Caption = "Ayrıntılar"
        Me.mnuDocumentView_Detail.Id = 33
        Me.mnuDocumentView_Detail.Name = "mnuDocumentView_Detail"
        '
        'mnuDocumentView_LargeIcon
        '
        Me.mnuDocumentView_LargeIcon.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.mnuDocumentView_LargeIcon.Caption = "Büyük Simge"
        Me.mnuDocumentView_LargeIcon.Id = 34
        Me.mnuDocumentView_LargeIcon.Name = "mnuDocumentView_LargeIcon"
        '
        'mnuRecordInfo
        '
        Me.mnuRecordInfo.Caption = "Kayıt Bilgisi"
        Me.mnuRecordInfo.Id = 38
        Me.mnuRecordInfo.Name = "mnuRecordInfo"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 108)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(893, 319)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.BaseTab1, Me.BaseTab2, Me.BaseTab4})
        '
        'BaseTab1
        '
        Me.BaseTab1.Controls.Add(Me.GridControl1)
        Me.BaseTab1.Controls.Add(Me.panelFormDateFilter)
        Me.BaseTab1.Controls.Add(Me.lblMainWarning1)
        Me.BaseTab1.Name = "BaseTab1"
        Me.BaseTab1.Size = New System.Drawing.Size(887, 291)
        Me.BaseTab1.Text = "Liste"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.conMenuGrid
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(887, 211)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'conMenuGrid
        '
        Me.conMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowRecord, Me.mnuUserRecordInfo})
        Me.conMenuGrid.Name = "conMenuGrid"
        Me.conMenuGrid.Size = New System.Drawing.Size(160, 48)
        '
        'mnuShowRecord
        '
        Me.mnuShowRecord.Name = "mnuShowRecord"
        Me.mnuShowRecord.ShortcutKeyDisplayString = ""
        Me.mnuShowRecord.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.mnuShowRecord.Size = New System.Drawing.Size(159, 22)
        Me.mnuShowRecord.Text = "Kaydı Göster"
        '
        'mnuUserRecordInfo
        '
        Me.mnuUserRecordInfo.Name = "mnuUserRecordInfo"
        Me.mnuUserRecordInfo.Size = New System.Drawing.Size(159, 22)
        Me.mnuUserRecordInfo.Text = "Kayıt Bilgisi"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak istediğiniz kolonu buraya sürükleyiniz..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Controls.Add(Me.basePanelControl1)
        Me.panelFormDateFilter.Controls.Add(Me.cmdRefreshList)
        Me.panelFormDateFilter.Controls.Add(Me.chkDate2)
        Me.panelFormDateFilter.Controls.Add(Me.dtFormDate2)
        Me.panelFormDateFilter.Controls.Add(Me.chkDate1)
        Me.panelFormDateFilter.Controls.Add(Me.dtFormDate1)
        Me.panelFormDateFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFormDateFilter.Location = New System.Drawing.Point(0, 0)
        Me.panelFormDateFilter.Name = "panelFormDateFilter"
        Me.panelFormDateFilter.Size = New System.Drawing.Size(887, 61)
        Me.panelFormDateFilter.TabIndex = 9
        Me.panelFormDateFilter.Visible = False
        '
        'basePanelControl1
        '
        Me.basePanelControl1.Controls.Add(Me.btnSetDate_Last1Year)
        Me.basePanelControl1.Controls.Add(Me.btnSetDate_Last6Months)
        Me.basePanelControl1.Controls.Add(Me.btnSetDate_Last3Months)
        Me.basePanelControl1.Controls.Add(Me.btnSetDate_ThisYear)
        Me.basePanelControl1.Controls.Add(Me.btnSetDate_ThisMonth)
        Me.basePanelControl1.Controls.Add(Me.btnSetDate_Today)
        Me.basePanelControl1.Location = New System.Drawing.Point(242, 3)
        Me.basePanelControl1.Name = "basePanelControl1"
        Me.basePanelControl1.Size = New System.Drawing.Size(197, 56)
        Me.basePanelControl1.TabIndex = 13
        '
        'btnSetDate_Last1Year
        '
        Me.btnSetDate_Last1Year.Location = New System.Drawing.Point(129, 30)
        Me.btnSetDate_Last1Year.Name = "btnSetDate_Last1Year"
        Me.btnSetDate_Last1Year.Size = New System.Drawing.Size(56, 23)
        Me.btnSetDate_Last1Year.TabIndex = 5
        Me.btnSetDate_Last1Year.Text = "Son 1 yil"
        '
        'btnSetDate_Last6Months
        '
        Me.btnSetDate_Last6Months.Location = New System.Drawing.Point(67, 30)
        Me.btnSetDate_Last6Months.Name = "btnSetDate_Last6Months"
        Me.btnSetDate_Last6Months.Size = New System.Drawing.Size(56, 23)
        Me.btnSetDate_Last6Months.TabIndex = 4
        Me.btnSetDate_Last6Months.Text = "Son 6 ay"
        '
        'btnSetDate_Last3Months
        '
        Me.btnSetDate_Last3Months.Location = New System.Drawing.Point(5, 30)
        Me.btnSetDate_Last3Months.Name = "btnSetDate_Last3Months"
        Me.btnSetDate_Last3Months.Size = New System.Drawing.Size(56, 23)
        Me.btnSetDate_Last3Months.TabIndex = 3
        Me.btnSetDate_Last3Months.Text = "Son 3 ay"
        '
        'btnSetDate_ThisYear
        '
        Me.btnSetDate_ThisYear.Location = New System.Drawing.Point(129, 3)
        Me.btnSetDate_ThisYear.Name = "btnSetDate_ThisYear"
        Me.btnSetDate_ThisYear.Size = New System.Drawing.Size(56, 23)
        Me.btnSetDate_ThisYear.TabIndex = 2
        Me.btnSetDate_ThisYear.Text = "Bu yıl"
        '
        'btnSetDate_ThisMonth
        '
        Me.btnSetDate_ThisMonth.Location = New System.Drawing.Point(67, 3)
        Me.btnSetDate_ThisMonth.Name = "btnSetDate_ThisMonth"
        Me.btnSetDate_ThisMonth.Size = New System.Drawing.Size(56, 23)
        Me.btnSetDate_ThisMonth.TabIndex = 1
        Me.btnSetDate_ThisMonth.Text = "Bu ay"
        '
        'btnSetDate_Today
        '
        Me.btnSetDate_Today.Location = New System.Drawing.Point(5, 3)
        Me.btnSetDate_Today.Name = "btnSetDate_Today"
        Me.btnSetDate_Today.Size = New System.Drawing.Size(56, 23)
        Me.btnSetDate_Today.TabIndex = 0
        Me.btnSetDate_Today.Text = "Bugun"
        '
        'cmdRefreshList
        '
        Me.cmdRefreshList.Image = Global.ProbarSiparis.My.Resources.Resources.repeat
        Me.cmdRefreshList.Location = New System.Drawing.Point(501, 6)
        Me.cmdRefreshList.Name = "cmdRefreshList"
        Me.cmdRefreshList.Size = New System.Drawing.Size(92, 46)
        Me.cmdRefreshList.TabIndex = 11
        Me.cmdRefreshList.Text = "Listele"
        '
        'chkDate2
        '
        Me.chkDate2.Location = New System.Drawing.Point(8, 34)
        Me.chkDate2.Name = "chkDate2"
        Me.chkDate2.Properties.Appearance.Options.UseTextOptions = True
        Me.chkDate2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkDate2.Properties.Caption = "Bitiş Tarihi"
        Me.chkDate2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkDate2.Size = New System.Drawing.Size(99, 19)
        Me.chkDate2.TabIndex = 2
        '
        'dtFormDate2
        '
        Me.dtFormDate2.EditValue = Nothing
        Me.dtFormDate2.Location = New System.Drawing.Point(113, 33)
        Me.dtFormDate2.Name = "dtFormDate2"
        Me.dtFormDate2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFormDate2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFormDate2.Size = New System.Drawing.Size(123, 20)
        Me.dtFormDate2.TabIndex = 3
        '
        'chkDate1
        '
        Me.chkDate1.Location = New System.Drawing.Point(8, 8)
        Me.chkDate1.Name = "chkDate1"
        Me.chkDate1.Properties.Appearance.Options.UseTextOptions = True
        Me.chkDate1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkDate1.Properties.Caption = "Başlangıç Tarihi"
        Me.chkDate1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkDate1.Size = New System.Drawing.Size(99, 19)
        Me.chkDate1.TabIndex = 0
        '
        'dtFormDate1
        '
        Me.dtFormDate1.EditValue = Nothing
        Me.dtFormDate1.Location = New System.Drawing.Point(113, 7)
        Me.dtFormDate1.Name = "dtFormDate1"
        Me.dtFormDate1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFormDate1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFormDate1.Size = New System.Drawing.Size(123, 20)
        Me.dtFormDate1.TabIndex = 1
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMainWarning1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 272)
        Me.lblMainWarning1.Name = "lblMainWarning1"
        Me.lblMainWarning1.Size = New System.Drawing.Size(887, 19)
        Me.lblMainWarning1.TabIndex = 2
        Me.lblMainWarning1.Text = "Uyarı: Kaydı getirmek için ""F6"" tuşu veya listeyi çift tıklayın. Kaydı değiştirme" &
    "k için ""Değiştir"" butonunu kullanınız."
        Me.lblMainWarning1.Visible = False
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.panelAuthCodes)
        Me.BaseTab2.Name = "BaseTab2"
        Me.BaseTab2.Size = New System.Drawing.Size(887, 289)
        Me.BaseTab2.Text = "Form"
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Controls.Add(Me.panelAuthCodesRight)
        Me.panelAuthCodes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 263)
        Me.panelAuthCodes.Name = "panelAuthCodes"
        Me.panelAuthCodes.Size = New System.Drawing.Size(887, 26)
        Me.panelAuthCodes.TabIndex = 0
        '
        'panelAuthCodesRight
        '
        Me.panelAuthCodesRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelAuthCodesRight.Controls.Add(Me.cboAuthCodes)
        Me.panelAuthCodesRight.Controls.Add(Me.lblAuthCodeCaption)
        Me.panelAuthCodesRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelAuthCodesRight.Location = New System.Drawing.Point(529, 2)
        Me.panelAuthCodesRight.Name = "panelAuthCodesRight"
        Me.panelAuthCodesRight.Size = New System.Drawing.Size(356, 22)
        Me.panelAuthCodesRight.TabIndex = 2
        '
        'cboAuthCodes
        '
        Me.cboAuthCodes.Dock = System.Windows.Forms.DockStyle.Right
        Me.cboAuthCodes.EditValue = ""
        Me.cboAuthCodes.Location = New System.Drawing.Point(167, 0)
        Me.cboAuthCodes.MenuManager = Me.BarManager1
        Me.cboAuthCodes.Name = "cboAuthCodes"
        Me.cboAuthCodes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cboAuthCodes.Properties.Appearance.Options.UseFont = True
        Me.cboAuthCodes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("cboAuthCodes.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cboAuthCodes.Size = New System.Drawing.Size(189, 22)
        Me.cboAuthCodes.TabIndex = 0
        Me.cboAuthCodes.ToolTip = "Authentication Codes"
        '
        'lblAuthCodeCaption
        '
        Me.lblAuthCodeCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAuthCodeCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblAuthCodeCaption.Location = New System.Drawing.Point(44, 5)
        Me.lblAuthCodeCaption.Name = "lblAuthCodeCaption"
        Me.lblAuthCodeCaption.Size = New System.Drawing.Size(119, 13)
        Me.lblAuthCodeCaption.TabIndex = 1
        Me.lblAuthCodeCaption.Text = "Yetki Kodu"
        '
        'BaseTab4
        '
        Me.BaseTab4.Name = "BaseTab4"
        Me.BaseTab4.PageVisible = False
        Me.BaseTab4.Size = New System.Drawing.Size(887, 289)
        Me.BaseTab4.Text = "Raporlar"
        '
        'DocumentLargeImages
        '
        Me.DocumentLargeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.DocumentLargeImages.ImageSize = New System.Drawing.Size(36, 36)
        Me.DocumentLargeImages.TransparentColor = System.Drawing.Color.Black
        '
        'DocumentSmallImages
        '
        Me.DocumentSmallImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.DocumentSmallImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.DocumentSmallImages.TransparentColor = System.Drawing.Color.Black
        '
        'popupDocumentView
        '
        Me.popupDocumentView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDocumentView_LargeIcon), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDocumentView_Tile), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDocumentView_Icon), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDocumentView_List), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDocumentView_Detail)})
        Me.popupDocumentView.Manager = Me.BarManager1
        Me.popupDocumentView.Name = "popupDocumentView"
        '
        'panelBottom
        '
        Me.panelBottom.Controls.Add(Me.basePanelControl3)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 427)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(893, 41)
        Me.panelBottom.TabIndex = 5
        Me.panelBottom.Visible = False
        '
        'basePanelControl3
        '
        Me.basePanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.basePanelControl3.Controls.Add(Me.cmdCancel)
        Me.basePanelControl3.Controls.Add(Me.cmdSelect)
        Me.basePanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.basePanelControl3.Location = New System.Drawing.Point(695, 2)
        Me.basePanelControl3.Name = "basePanelControl3"
        Me.basePanelControl3.Size = New System.Drawing.Size(196, 37)
        Me.basePanelControl3.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(100, 1)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 34)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Vazgeç"
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(5, 1)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(89, 34)
        Me.cmdSelect.TabIndex = 0
        Me.cmdSelect.Text = "Seç (F2)"
        '
        'panelFormTop
        '
        Me.panelFormTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFormTop.Location = New System.Drawing.Point(0, 77)
        Me.panelFormTop.Name = "panelFormTop"
        Me.panelFormTop.Size = New System.Drawing.Size(893, 31)
        Me.panelFormTop.TabIndex = 6
        Me.panelFormTop.Visible = False
        '
        'tmrBekle
        '
        Me.tmrBekle.Interval = 300
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Security=True;"
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
        'MasterConn
        '
        Me.MasterConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Security=True;"
        Me.MasterConn.Name = "MasterConn"
        Me.MasterConn.UserInfo_AuthCodeFieldName = "AuthCode"
        Me.MasterConn.UserInfo_CanDeleteAuthCode = ""
        Me.MasterConn.UserInfo_CanReadAuthCode = ""
        Me.MasterConn.UserInfo_CanWriteAuthCode = ""
        Me.MasterConn.UserInfo_CreatedDateFieldName = "CreatedDate"
        Me.MasterConn.UserInfo_CreatedUserFieldName = "CreatedBy"
        Me.MasterConn.UserInfo_ModifiedDateFieldName = "ModifiedDate"
        Me.MasterConn.UserInfo_ModifiedUserFieldName = "ModifiedBy"
        Me.MasterConn.UserInfo_NewRecordAuthCode = ""
        Me.MasterConn.UserInfo_UserID = Nothing
        '
        'dlgDocumentFileOpen
        '
        Me.dlgDocumentFileOpen.Filter = "Tüm Dosyalar (*.*)|*.*"
        '
        'MasterTable
        '
        Me.MasterTable.Connection = Me.FirmConn
        Me.MasterTable.CurrentRow = Nothing
        Me.MasterTable.DataSourceLink = Me.MasterLink
        Me.MasterTable.DeleteCommand = Nothing
        Me.MasterTable.Filter = ""
        Me.MasterTable.InsertCommand = Nothing
        Me.MasterTable.LiveSave = False
        Me.MasterTable.MaxRecords = CType(0, Long)
        Me.MasterTable.Name = "MasterTable"
        Me.MasterTable.ParentRelation_ChildColumns = Nothing
        Me.MasterTable.ParentRelation_ParentColumns = Nothing
        Me.MasterTable.ParentRelation_Table = Nothing
        Me.MasterTable.Position = CType(-1, Long)
        Me.MasterTable.Quoted = True
        Me.MasterTable.SaveQueryFile = True
        Me.MasterTable.SelectCommand = Nothing
        Me.MasterTable.TableName = "SqlDataTable1"
        Me.MasterTable.Transaction = Nothing
        Me.MasterTable.UpdateCommand = Nothing
        '
        'MasterLink
        '
        Me.MasterLink.DataSource = Me.MasterTable
        Me.MasterLink.Name = "MasterLink"
        Me.MasterLink.Synchronized = True
        '
        'DetailTable
        '
        Me.DetailTable.Connection = Me.FirmConn
        Me.DetailTable.CurrentRow = Nothing
        Me.DetailTable.DataSourceLink = Me.DetailLink
        Me.DetailTable.DeleteCommand = Nothing
        Me.DetailTable.Filter = ""
        Me.DetailTable.InsertCommand = Nothing
        Me.DetailTable.LiveSave = False
        Me.DetailTable.MaxRecords = CType(0, Long)
        Me.DetailTable.Name = "DetailTable"
        Me.DetailTable.ParentRelation_ChildColumns = Nothing
        Me.DetailTable.ParentRelation_ParentColumns = Nothing
        Me.DetailTable.ParentRelation_Table = Nothing
        Me.DetailTable.Position = CType(-1, Long)
        Me.DetailTable.Quoted = True
        Me.DetailTable.SaveQueryFile = True
        Me.DetailTable.SelectCommand = Nothing
        Me.DetailTable.TableName = "SqlDataTable1"
        Me.DetailTable.Transaction = Nothing
        Me.DetailTable.UpdateCommand = Nothing
        '
        'DetailLink
        '
        Me.DetailLink.DataSource = Me.DetailTable
        Me.DetailLink.Name = "DetailLink"
        Me.DetailLink.Synchronized = True
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'DetailTable2
        '
        Me.DetailTable2.Connection = Me.FirmConn
        Me.DetailTable2.CurrentRow = Nothing
        Me.DetailTable2.DataSourceLink = Me.DetailLink2
        Me.DetailTable2.DeleteCommand = Nothing
        Me.DetailTable2.Filter = ""
        Me.DetailTable2.InsertCommand = Nothing
        Me.DetailTable2.LiveSave = False
        Me.DetailTable2.MaxRecords = CType(0, Long)
        Me.DetailTable2.Name = "DetailTable2"
        Me.DetailTable2.ParentRelation_ChildColumns = Nothing
        Me.DetailTable2.ParentRelation_ParentColumns = Nothing
        Me.DetailTable2.ParentRelation_Table = Nothing
        Me.DetailTable2.Position = CType(-1, Long)
        Me.DetailTable2.Quoted = True
        Me.DetailTable2.SaveQueryFile = True
        Me.DetailTable2.SelectCommand = Nothing
        Me.DetailTable2.TableName = "SqlDataTable1"
        Me.DetailTable2.Transaction = Nothing
        Me.DetailTable2.UpdateCommand = Nothing
        '
        'DetailLink2
        '
        Me.DetailLink2.DataSource = Me.DetailTable2
        Me.DetailLink2.Name = "DetailLink2"
        Me.DetailLink2.Synchronized = True
        '
        'DetailTable3
        '
        Me.DetailTable3.Connection = Me.FirmConn
        Me.DetailTable3.CurrentRow = Nothing
        Me.DetailTable3.DataSourceLink = Me.DetailLink3
        Me.DetailTable3.DeleteCommand = Nothing
        Me.DetailTable3.Filter = ""
        Me.DetailTable3.InsertCommand = Nothing
        Me.DetailTable3.LiveSave = False
        Me.DetailTable3.MaxRecords = CType(0, Long)
        Me.DetailTable3.Name = "DetailTable3"
        Me.DetailTable3.ParentRelation_ChildColumns = Nothing
        Me.DetailTable3.ParentRelation_ParentColumns = Nothing
        Me.DetailTable3.ParentRelation_Table = Nothing
        Me.DetailTable3.Position = CType(-1, Long)
        Me.DetailTable3.Quoted = True
        Me.DetailTable3.SaveQueryFile = True
        Me.DetailTable3.SelectCommand = Nothing
        Me.DetailTable3.TableName = "SqlDataTable1"
        Me.DetailTable3.Transaction = Nothing
        Me.DetailTable3.UpdateCommand = Nothing
        '
        'DetailLink3
        '
        Me.DetailLink3.DataSource = Me.DetailTable3
        Me.DetailLink3.Name = "DetailLink3"
        Me.DetailLink3.Synchronized = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTopInfo.EditValue = ""
        Me.txtTopInfo.Location = New System.Drawing.Point(0, 67)
        Me.txtTopInfo.MenuManager = Me.BarManager1
        Me.txtTopInfo.Name = "txtTopInfo"
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Properties.ReadOnly = True
        Me.txtTopInfo.Size = New System.Drawing.Size(893, 10)
        Me.txtTopInfo.TabIndex = 9
        '
        'tmrShowError
        '
        Me.tmrShowError.Interval = 200
        '
        'DetailTable4
        '
        Me.DetailTable4.Connection = Me.FirmConn
        Me.DetailTable4.CurrentRow = Nothing
        Me.DetailTable4.DataSourceLink = Me.DetailLink4
        Me.DetailTable4.DeleteCommand = Nothing
        Me.DetailTable4.Filter = ""
        Me.DetailTable4.InsertCommand = Nothing
        Me.DetailTable4.LiveSave = False
        Me.DetailTable4.MaxRecords = CType(0, Long)
        Me.DetailTable4.Name = "DetailTable4"
        Me.DetailTable4.ParentRelation_ChildColumns = Nothing
        Me.DetailTable4.ParentRelation_ParentColumns = Nothing
        Me.DetailTable4.ParentRelation_Table = Nothing
        Me.DetailTable4.Position = CType(-1, Long)
        Me.DetailTable4.Quoted = True
        Me.DetailTable4.SaveQueryFile = True
        Me.DetailTable4.SelectCommand = Nothing
        Me.DetailTable4.TableName = "SqlDataTable1"
        Me.DetailTable4.Transaction = Nothing
        Me.DetailTable4.UpdateCommand = Nothing
        '
        'DetailLink4
        '
        Me.DetailLink4.DataSource = Me.DetailTable4
        Me.DetailLink4.Name = "DetailLink4"
        Me.DetailLink4.Synchronized = True
        '
        'DetailTable5
        '
        Me.DetailTable5.Connection = Me.FirmConn
        Me.DetailTable5.CurrentRow = Nothing
        Me.DetailTable5.DataSourceLink = Me.DetailLink5
        Me.DetailTable5.DeleteCommand = Nothing
        Me.DetailTable5.Filter = ""
        Me.DetailTable5.InsertCommand = Nothing
        Me.DetailTable5.LiveSave = False
        Me.DetailTable5.MaxRecords = CType(0, Long)
        Me.DetailTable5.Name = "DetailTable5"
        Me.DetailTable5.ParentRelation_ChildColumns = Nothing
        Me.DetailTable5.ParentRelation_ParentColumns = Nothing
        Me.DetailTable5.ParentRelation_Table = Nothing
        Me.DetailTable5.Position = CType(-1, Long)
        Me.DetailTable5.Quoted = True
        Me.DetailTable5.SaveQueryFile = True
        Me.DetailTable5.SelectCommand = Nothing
        Me.DetailTable5.TableName = "SqlDataTable1"
        Me.DetailTable5.Transaction = Nothing
        Me.DetailTable5.UpdateCommand = Nothing
        '
        'DetailLink5
        '
        Me.DetailLink5.DataSource = Me.DetailTable5
        Me.DetailLink5.Name = "DetailLink5"
        Me.DetailLink5.Synchronized = True
        '
        'AuthCodes
        '
        Me.AuthCodes.Columns.AddRange(New System.Data.DataColumn() {Me.AuthCodes_AuthCode})
        Me.AuthCodes.Connection = Me.FirmConn
        Me.AuthCodes.CurrentRow = Nothing
        Me.AuthCodes.DataSourceLink = Nothing
        Me.AuthCodes.DeleteCommand = Me.AuthCodes_SqlCommand4
        Me.AuthCodes.Filter = ""
        Me.AuthCodes.InsertCommand = Me.AuthCodes_SqlCommand2
        Me.AuthCodes.LiveSave = False
        Me.AuthCodes.MaxRecords = CType(0, Long)
        Me.AuthCodes.Name = "AuthCodes"
        Me.AuthCodes.ParentRelation_ChildColumns = Nothing
        Me.AuthCodes.ParentRelation_ParentColumns = Nothing
        Me.AuthCodes.ParentRelation_Table = Nothing
        Me.AuthCodes.Position = CType(-1, Long)
        Me.AuthCodes.Quoted = False
        Me.AuthCodes.SelectCommand = Me.AuthCodes_SqlCommand1
        Me.AuthCodes.TableName = "NeoTable1"
        Me.AuthCodes.Transaction = Nothing
        Me.AuthCodes.UpdateCommand = Me.AuthCodes_SqlCommand3
        '
        'AuthCodes_AuthCode
        '
        Me.AuthCodes_AuthCode.ColumnName = "AuthCode"
        '
        'AuthCodes_SqlCommand1
        '
        Me.AuthCodes_SqlCommand1.CommandText = "SELECT AuthCode FROM WMS_AuthCodes WHERE Deleted = 0 "
        '
        'TicariConn
        '
        Me.TicariConn.ConnectionString = "Data Source=(local)\SqlExpress;Initial Catalog=MikroDB_V14_TEST;Integrated Securi" &
    "ty=True;"
        Me.TicariConn.Name = "TicariConn"
        Me.TicariConn.UserInfo_AuthCodeFieldName = ""
        Me.TicariConn.UserInfo_CanDeleteAuthCode = ""
        Me.TicariConn.UserInfo_CanReadAuthCode = ""
        Me.TicariConn.UserInfo_CanWriteAuthCode = ""
        Me.TicariConn.UserInfo_CreatedDateFieldName = "CreatedDate"
        Me.TicariConn.UserInfo_CreatedUserFieldName = "CreatedBy"
        Me.TicariConn.UserInfo_ModifiedDateFieldName = "ModifiedDate"
        Me.TicariConn.UserInfo_ModifiedUserFieldName = "ModifiedBy"
        Me.TicariConn.UserInfo_NewRecordAuthCode = ""
        Me.TicariConn.UserInfo_UserID = Nothing
        '
        'frmBaseForm
        '
        Me.ClientSize = New System.Drawing.Size(893, 491)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.panelFormTop)
        Me.Controls.Add(Me.txtTopInfo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaseForm"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.BaseTab1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conMenuGrid.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormDateFilter.ResumeLayout(False)
        CType(Me.basePanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.basePanelControl1.ResumeLayout(False)
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseTab2.ResumeLayout(False)
        CType(Me.panelAuthCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAuthCodes.ResumeLayout(False)
        CType(Me.panelAuthCodesRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAuthCodesRight.ResumeLayout(False)
        CType(Me.cboAuthCodes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupDocumentView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.basePanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.basePanelControl3.ResumeLayout(False)
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Public WithEvents Bar1 As DevExpress.XtraBars.Bar
    Public WithEvents Bar2 As DevExpress.XtraBars.Bar
    Public WithEvents Bar3 As DevExpress.XtraBars.Bar
    Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents btnExportTXT As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportCSV As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportHTML As DevExpress.XtraBars.BarButtonItem
    Public WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents BaseTab1 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents BaseTab2 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnPrintGrid As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExport As DevExpress.XtraBars.BarSubItem
    Public WithEvents btnExportExcel As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportPDF As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnHelp1 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents panelBottom As DevExpress.XtraEditors.PanelControl
    Public WithEvents basePanelControl3 As DevExpress.XtraEditors.PanelControl
    Public WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cmdSelect As DevExpress.XtraEditors.SimpleButton
    Public WithEvents panelFormTop As DevExpress.XtraEditors.PanelControl
    Public WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Public WithEvents tmrBekle As System.Windows.Forms.Timer
    Public WithEvents btnFirst As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnPrior As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnLast As DevExpress.XtraBars.BarButtonItem
    Public WithEvents dlgExport As System.Windows.Forms.SaveFileDialog
    Public WithEvents btnFormPrint As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnHelp As DevExpress.XtraBars.BarSubItem
    Public WithEvents btnHelp_ShortCuts As DevExpress.XtraBars.BarButtonItem
    Public WithEvents FirmConn As NeoDAC.NeoConnection
    Public WithEvents MasterConn As NeoDAC.NeoConnection
    Public WithEvents mnuDocumentView_Tile As DevExpress.XtraBars.BarButtonItem
    Public WithEvents mnuDocumentView_Icon As DevExpress.XtraBars.BarButtonItem
    Public WithEvents mnuDocumentView_List As DevExpress.XtraBars.BarButtonItem
    Public WithEvents mnuDocumentView_Detail As DevExpress.XtraBars.BarButtonItem
    Public WithEvents dlgDocumentFileOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents mnuDocumentView_LargeIcon As DevExpress.XtraBars.BarButtonItem
    Public WithEvents DocumentLargeImages As System.Windows.Forms.ImageList
    Public WithEvents DocumentSmallImages As System.Windows.Forms.ImageList
    Public WithEvents MasterTable As NeoDAC.NeoTable
    Public WithEvents DetailTable As NeoDAC.NeoTable
    Public WithEvents MasterLink As NeoDAC.NeoLink
    Public WithEvents DetailLink As NeoDAC.NeoLink
    Public WithEvents popupDocumentView As DevExpress.XtraBars.PopupMenu
    Public WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Public WithEvents dlgDocumentFileSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents BaseTab4 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents btnApprove As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnDisapprove As DevExpress.XtraBars.BarButtonItem
    Public WithEvents DetailTable2 As NeoDAC.NeoTable
    Public WithEvents DetailLink2 As NeoDAC.NeoLink
    Public WithEvents DetailTable3 As NeoDAC.NeoTable
    Public WithEvents DetailLink3 As NeoDAC.NeoLink
    Public WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents txtTopInfo As DevExpress.XtraEditors.TextEdit
    Public WithEvents mnuRecordInfo As DevExpress.XtraBars.BarButtonItem
    Public WithEvents mnuUserRecordInfo As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents conMenuGrid As System.Windows.Forms.ContextMenuStrip
    Public WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Public WithEvents tmrShowError As System.Windows.Forms.Timer
    Public WithEvents lblMainWarning1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents mnuShowRecord As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents btnExportXml As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnImport As DevExpress.XtraBars.BarButtonItem
    Public WithEvents DetailTable4 As NeoDAC.NeoTable
    Public WithEvents DetailLink4 As NeoDAC.NeoLink
    Public WithEvents DetailTable5 As NeoDAC.NeoTable
    Public WithEvents DetailLink5 As NeoDAC.NeoLink
    Public WithEvents btnLanguageOptions As DevExpress.XtraBars.BarButtonItem
    Public WithEvents AuthCodes_SqlCommand4 As System.Data.SqlClient.SqlCommand
    Public WithEvents AuthCodes_SqlCommand2 As System.Data.SqlClient.SqlCommand
    Public WithEvents AuthCodes_SqlCommand1 As System.Data.SqlClient.SqlCommand
    Public WithEvents AuthCodes_SqlCommand3 As System.Data.SqlClient.SqlCommand
    Public WithEvents AuthCodes As NeoDAC.NeoTable
    Public WithEvents panelAuthCodes As DevExpress.XtraEditors.PanelControl
    Private WithEvents panelAuthCodesRight As DevExpress.XtraEditors.PanelControl
    Public WithEvents cboAuthCodes As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents lblAuthCodeCaption As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AuthCodes_AuthCode As System.Data.DataColumn
    Public WithEvents panelFormDateFilter As DevExpress.XtraEditors.PanelControl
    Public WithEvents cmdRefreshList As DevExpress.XtraEditors.SimpleButton
    Public WithEvents chkDate2 As DevExpress.XtraEditors.CheckEdit
    Public WithEvents dtFormDate2 As DevExpress.XtraEditors.DateEdit
    Public WithEvents chkDate1 As DevExpress.XtraEditors.CheckEdit
    Public WithEvents dtFormDate1 As DevExpress.XtraEditors.DateEdit
    Public WithEvents TicariConn As NeoDAC.NeoConnection
    Friend WithEvents basePanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSetDate_Last1Year As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_Last6Months As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_Last3Months As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_ThisYear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_ThisMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_Today As DevExpress.XtraEditors.SimpleButton

End Class
