<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseReport
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseReport))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFirst = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLast = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFormPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarSubItem()
        Me.btnExportExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportTxt = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportCSV = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportHTML = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLanguageOptions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFormPrint1Tane = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barItem_RecordTime = New DevExpress.XtraBars.BarStaticItem()
        Me.barItem_RowCount = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.panelFormTop = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.BaseTab1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog()
        Me.MasterConn = New NeoDAC.NeoConnection(Me.components)
        Me.FirmConn = New NeoDAC.NeoConnection(Me.components)
        Me.MasterTable = New NeoDAC.NeoTable(Me.components)
        Me.MasterLink = New NeoDAC.NeoLink(Me.components)
        Me.panelBottom = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSelect = New DevExpress.XtraEditors.SimpleButton()
        Me.panelFormDateFilter = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
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
        Me.DetailTable = New NeoDAC.NeoTable(Me.components)
        Me.DetailLink = New NeoDAC.NeoLink(Me.components)
        Me.TicariConn = New NeoDAC.NeoConnection(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.BaseTab1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormDateFilter.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRefresh, Me.btnFirst, Me.btnPrior, Me.btnNext, Me.btnLast, Me.btnPrintGrid, Me.btnExport, Me.btnExportExcel, Me.btnHelp, Me.btnExportPDF, Me.btnExportTxt, Me.btnExportCSV, Me.btnExportHTML, Me.btnFormPrint, Me.BarLargeButtonItem1, Me.barItem_RecordTime, Me.barItem_RowCount, Me.btnLanguageOptions, Me.btnFormPrint1Tane})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 21
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFirst, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrior), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNext), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLast), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrintGrid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFormPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnHelp), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.btnFormPrint1Tane, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", "")})
        Me.Bar1.Text = "Tools"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Listele"
        Me.btnRefresh.Glyph = Global.ProbarSiparis.My.Resources.Resources.repeat
        Me.btnRefresh.Id = 0
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnFirst
        '
        Me.btnFirst.Caption = "ï¿½lk Kayï¿½t"
        Me.btnFirst.Glyph = Global.ProbarSiparis.My.Resources.Resources.skip_backward
        Me.btnFirst.Id = 1
        Me.btnFirst.Name = "btnFirst"
        '
        'btnPrior
        '
        Me.btnPrior.Caption = "ï¿½nceki Kayï¿½t"
        Me.btnPrior.Glyph = Global.ProbarSiparis.My.Resources.Resources.rewind1
        Me.btnPrior.Id = 2
        Me.btnPrior.Name = "btnPrior"
        '
        'btnNext
        '
        Me.btnNext.Caption = "Sonraki Kayï¿½t"
        Me.btnNext.Glyph = Global.ProbarSiparis.My.Resources.Resources.fast_forward
        Me.btnNext.Id = 3
        Me.btnNext.Name = "btnNext"
        '
        'btnLast
        '
        Me.btnLast.Caption = "Son Kayï¿½t"
        Me.btnLast.Glyph = Global.ProbarSiparis.My.Resources.Resources.skip_forward
        Me.btnLast.Id = 4
        Me.btnLast.Name = "btnLast"
        '
        'btnPrintGrid
        '
        Me.btnPrintGrid.Caption = "Liste Yazdï¿½r"
        Me.btnPrintGrid.Glyph = Global.ProbarSiparis.My.Resources.Resources.DXGrid
        Me.btnPrintGrid.Id = 5
        Me.btnPrintGrid.Name = "btnPrintGrid"
        '
        'btnFormPrint
        '
        Me.btnFormPrint.Caption = "Yazdï¿½r"
        Me.btnFormPrint.Glyph = Global.ProbarSiparis.My.Resources.Resources.PrintDirectLarge
        Me.btnFormPrint.Id = 14
        Me.btnFormPrint.Name = "btnFormPrint"
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Glyph = Global.ProbarSiparis.My.Resources.Resources.globe_32
        Me.btnExport.Id = 7
        Me.btnExport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportPDF), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportTxt), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportCSV), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportHTML), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLanguageOptions)})
        Me.btnExport.Name = "btnExport"
        Me.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Caption = "Excel"
        Me.btnExportExcel.Id = 8
        Me.btnExportExcel.Name = "btnExportExcel"
        '
        'btnExportPDF
        '
        Me.btnExportPDF.Caption = "PDF"
        Me.btnExportPDF.Id = 10
        Me.btnExportPDF.Name = "btnExportPDF"
        '
        'btnExportTxt
        '
        Me.btnExportTxt.Caption = "Txt"
        Me.btnExportTxt.Id = 11
        Me.btnExportTxt.Name = "btnExportTxt"
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
        'btnLanguageOptions
        '
        Me.btnLanguageOptions.Caption = "Language Options"
        Me.btnLanguageOptions.Glyph = Global.ProbarSiparis.My.Resources.Resources.LanguageIcon_16x16
        Me.btnLanguageOptions.Id = 19
        Me.btnLanguageOptions.Name = "btnLanguageOptions"
        '
        'btnHelp
        '
        Me.btnHelp.Caption = "Yardï¿½m"
        Me.btnHelp.Glyph = Global.ProbarSiparis.My.Resources.Resources.help1
        Me.btnHelp.Id = 9
        Me.btnHelp.Name = "btnHelp"
        '
        'btnFormPrint1Tane
        '
        Me.btnFormPrint1Tane.Caption = "1Tane Yazdir"
        Me.btnFormPrint1Tane.Glyph = Global.ProbarSiparis.My.Resources.Resources.PrintDirectLarge1tane
        Me.btnFormPrint1Tane.Id = 20
        Me.btnFormPrint1Tane.Name = "btnFormPrint1Tane"
        ToolTipTitleItem1.Text = "1 Tane yazdir"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "1 TANE SECï¿½Lï¿½ OLANï¿½ YAZDï¿½R. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F9 VARSAYï¿½LAN TASARï¿½Mï¿½ , VARSAYï¿½LAN YAZï¿½Cï¿½YA Dï¿½REKT" &
    " YAZDï¿½Rï¿½R"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnFormPrint1Tane.SuperTip = SuperToolTip1
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barItem_RecordTime), New DevExpress.XtraBars.LinkPersistInfo(Me.barItem_RowCount)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barItem_RecordTime
        '
        Me.barItem_RecordTime.Border = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.barItem_RecordTime.Caption = "0 sn"
        Me.barItem_RecordTime.Id = 17
        Me.barItem_RecordTime.Name = "barItem_RecordTime"
        Me.barItem_RecordTime.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barItem_RowCount
        '
        Me.barItem_RowCount.Border = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.barItem_RowCount.Caption = "0 Kayï¿½t"
        Me.barItem_RowCount.Id = 18
        Me.barItem_RowCount.Name = "barItem_RowCount"
        Me.barItem_RowCount.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(645, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 506)
        Me.barDockControlBottom.Size = New System.Drawing.Size(645, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 439)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(645, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 439)
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "BarLargeButtonItem1"
        Me.BarLargeButtonItem1.Id = 15
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'panelFormTop
        '
        Me.panelFormTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFormTop.Location = New System.Drawing.Point(0, 128)
        Me.panelFormTop.Name = "panelFormTop"
        Me.panelFormTop.Size = New System.Drawing.Size(645, 72)
        Me.panelFormTop.TabIndex = 4
        Me.panelFormTop.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 200)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(645, 265)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.BaseTab1})
        '
        'BaseTab1
        '
        Me.BaseTab1.Controls.Add(Me.GridControl1)
        Me.BaseTab1.Name = "BaseTab1"
        Me.BaseTab1.Size = New System.Drawing.Size(639, 237)
        Me.BaseTab1.Text = "Liste"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(639, 237)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak istediï¿½iniz kolonu buraya sï¿½rï¿½kleyiniz..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'MasterConn
        '
        Me.MasterConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Securi" &
    "ty=True;"
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
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Securi" &
    "ty=True;"
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
        'MasterTable
        '
        Me.MasterTable.Connection = Nothing
        Me.MasterTable.CurrentRow = Nothing
        Me.MasterTable.DataSourceLink = Nothing
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
        Me.MasterTable.SelectCommand = Nothing
        Me.MasterTable.TableName = "SqlDataTable1"
        Me.MasterTable.Transaction = Nothing
        Me.MasterTable.UpdateCommand = Nothing
        '
        'MasterLink
        '
        Me.MasterLink.Name = "MasterLink"
        Me.MasterLink.Synchronized = True
        '
        'panelBottom
        '
        Me.panelBottom.Controls.Add(Me.PanelControl3)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 465)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(645, 41)
        Me.panelBottom.TabIndex = 11
        Me.panelBottom.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.cmdCancel)
        Me.PanelControl3.Controls.Add(Me.cmdSelect)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl3.Location = New System.Drawing.Point(447, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(196, 37)
        Me.PanelControl3.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(100, 1)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 34)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Vazgeï¿½"
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(5, 1)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(89, 34)
        Me.cmdSelect.TabIndex = 0
        Me.cmdSelect.Text = "Seï¿½ (F2)"
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Controls.Add(Me.PanelControl1)
        Me.panelFormDateFilter.Controls.Add(Me.cmdRefreshList)
        Me.panelFormDateFilter.Controls.Add(Me.chkDate2)
        Me.panelFormDateFilter.Controls.Add(Me.dtFormDate2)
        Me.panelFormDateFilter.Controls.Add(Me.chkDate1)
        Me.panelFormDateFilter.Controls.Add(Me.dtFormDate1)
        Me.panelFormDateFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFormDateFilter.Location = New System.Drawing.Point(0, 67)
        Me.panelFormDateFilter.Name = "panelFormDateFilter"
        Me.panelFormDateFilter.Size = New System.Drawing.Size(645, 61)
        Me.panelFormDateFilter.TabIndex = 12
        Me.panelFormDateFilter.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnSetDate_Last1Year)
        Me.PanelControl1.Controls.Add(Me.btnSetDate_Last6Months)
        Me.PanelControl1.Controls.Add(Me.btnSetDate_Last3Months)
        Me.PanelControl1.Controls.Add(Me.btnSetDate_ThisYear)
        Me.PanelControl1.Controls.Add(Me.btnSetDate_ThisMonth)
        Me.PanelControl1.Controls.Add(Me.btnSetDate_Today)
        Me.PanelControl1.Location = New System.Drawing.Point(245, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(197, 56)
        Me.PanelControl1.TabIndex = 12
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
        Me.btnSetDate_ThisYear.Text = "Bu yil"
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
        Me.cmdRefreshList.Location = New System.Drawing.Point(452, 6)
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
        Me.chkDate2.Properties.Caption = "T2"
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
        Me.chkDate1.Properties.Caption = "T1"
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
        'DetailTable
        '
        Me.DetailTable.Connection = Nothing
        Me.DetailTable.CurrentRow = Nothing
        Me.DetailTable.DataSourceLink = Nothing
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
        Me.DetailTable.Quoted = False
        Me.DetailTable.SelectCommand = Nothing
        Me.DetailTable.TableName = "NeoTable1"
        Me.DetailTable.Transaction = Nothing
        Me.DetailTable.UpdateCommand = Nothing
        '
        'DetailLink
        '
        Me.DetailLink.Name = "DetailLink"
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
        'frmBaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 535)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.panelFormTop)
        Me.Controls.Add(Me.panelFormDateFilter)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBaseReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBaseReport"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.BaseTab1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormDateFilter.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Bar3 As DevExpress.XtraBars.Bar
    Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Public WithEvents Bar1 As DevExpress.XtraBars.Bar
    Public WithEvents Bar2 As DevExpress.XtraBars.Bar
    Public WithEvents panelFormTop As DevExpress.XtraEditors.PanelControl
    Public WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Public WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents BaseTab1 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents btnFirst As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnPrior As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnLast As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnPrintGrid As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExport As DevExpress.XtraBars.BarSubItem
    Public WithEvents btnHelp As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportExcel As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportPDF As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportTxt As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportCSV As DevExpress.XtraBars.BarButtonItem
    Public WithEvents btnExportHTML As DevExpress.XtraBars.BarButtonItem
    Public WithEvents dlgExport As System.Windows.Forms.SaveFileDialog
    Public WithEvents MasterConn As NeoDAC.NeoConnection
    Public WithEvents FirmConn As NeoDAC.NeoConnection
    Public WithEvents MasterTable As NeoDAC.NeoTable
    Public WithEvents MasterLink As NeoDAC.NeoLink
    Public WithEvents panelBottom As DevExpress.XtraEditors.PanelControl
    Public WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Public WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cmdSelect As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnFormPrint As DevExpress.XtraBars.BarButtonItem
    Public WithEvents panelFormDateFilter As DevExpress.XtraEditors.PanelControl
    Public WithEvents cmdRefreshList As DevExpress.XtraEditors.SimpleButton
    Public WithEvents chkDate2 As DevExpress.XtraEditors.CheckEdit
    Public WithEvents dtFormDate2 As DevExpress.XtraEditors.DateEdit
    Public WithEvents chkDate1 As DevExpress.XtraEditors.CheckEdit
    Public WithEvents dtFormDate1 As DevExpress.XtraEditors.DateEdit
    Public WithEvents barItem_RecordTime As DevExpress.XtraBars.BarStaticItem
    Public WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Public WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents barItem_RowCount As DevExpress.XtraBars.BarStaticItem
    Public WithEvents btnLanguageOptions As DevExpress.XtraBars.BarButtonItem
    Public WithEvents DetailTable As NeoDAC.NeoTable
    Public WithEvents DetailLink As NeoDAC.NeoLink
    Public WithEvents TicariConn As NeoDAC.NeoConnection
    Friend WithEvents btnFormPrint1Tane As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSetDate_Last1Year As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_Last6Months As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_Last3Months As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_ThisYear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_ThisMonth As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetDate_Today As DevExpress.XtraEditors.SimpleButton
End Class
