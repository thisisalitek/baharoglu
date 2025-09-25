<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFason
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFason))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colFasonFisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasonTuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasonTermin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasonEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasonEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasonBelgeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colKapali = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colKapanmaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipTermin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDurumu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnaRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CariUnvanButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CariKodButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.IrsEvrakSiraSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IrsEvrakSeriTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSiparisSec = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.chkGoster_Kapalilar = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGoster_Iptaller = New DevExpress.XtraEditors.CheckEdit()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateEdit5 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.MasterTable_FasonFisID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_FasonTuru = New System.Data.DataColumn()
        Me.MasterTable_Tarih = New System.Data.DataColumn()
        Me.MasterTable_FasonTermin = New System.Data.DataColumn()
        Me.MasterTable_FasonEvrakSeri = New System.Data.DataColumn()
        Me.MasterTable_FasonEvrakSira = New System.Data.DataColumn()
        Me.MasterTable_FasonBelgeNo = New System.Data.DataColumn()
        Me.MasterTable_CariKod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_Aciklama1 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama2 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama3 = New System.Data.DataColumn()
        Me.MasterTable_SiparisID = New System.Data.DataColumn()
        Me.MasterTable_SipDetayID = New System.Data.DataColumn()
        Me.MasterTable_Adet = New System.Data.DataColumn()
        Me.MasterTable_Agirlik = New System.Data.DataColumn()
        Me.MasterTable_Iptal = New System.Data.DataColumn()
        Me.MasterTable_Kapali = New System.Data.DataColumn()
        Me.MasterTable_KapanmaTarihi = New System.Data.DataColumn()
        Me.MasterTable_Parca = New System.Data.DataColumn()
        Me.MasterTable_SipEvrakSeri = New System.Data.DataColumn()
        Me.MasterTable_SipEvrakSira = New System.Data.DataColumn()
        Me.MasterTable_StokKod = New System.Data.DataColumn()
        Me.MasterTable_SipCariKod = New System.Data.DataColumn()
        Me.MasterTable_SipCariUnvan = New System.Data.DataColumn()
        Me.MasterTable_Miktar = New System.Data.DataColumn()
        Me.MasterTable_SipTermin = New System.Data.DataColumn()
        Me.MasterTable_SipTarihi = New System.Data.DataColumn()
        Me.MasterTable_Durumu = New System.Data.DataColumn()
        Me.MasterTable_AnaRenk = New System.Data.DataColumn()
        Me.MasterTable_Bedenler = New System.Data.DataColumn()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.colParca = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CariUnvanButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CariKodButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrsEvrakSiraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrsEvrakSeriTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGoster_Kapalilar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGoster_Iptaller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DateEdit5.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(957, 77)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 652)
        Me.barDockControlBottom.Size = New System.Drawing.Size(957, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 575)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(957, 77)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 575)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 120)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(957, 491)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(951, 460)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.ComboBoxEdit2)
        Me.BaseTab2.Controls.Add(Me.LabelControl24)
        Me.BaseTab2.Controls.Add(Me.TextEdit14)
        Me.BaseTab2.Controls.Add(Me.LabelControl23)
        Me.BaseTab2.Controls.Add(Me.TextEdit13)
        Me.BaseTab2.Controls.Add(Me.LabelControl22)
        Me.BaseTab2.Controls.Add(Me.TextEdit12)
        Me.BaseTab2.Controls.Add(Me.LabelControl21)
        Me.BaseTab2.Controls.Add(Me.TextEdit11)
        Me.BaseTab2.Controls.Add(Me.LabelControl20)
        Me.BaseTab2.Controls.Add(Me.LabelControl19)
        Me.BaseTab2.Controls.Add(Me.DateEdit5)
        Me.BaseTab2.Controls.Add(Me.TextEdit9)
        Me.BaseTab2.Controls.Add(Me.LabelControl17)
        Me.BaseTab2.Controls.Add(Me.cmdSiparisSec)
        Me.BaseTab2.Controls.Add(Me.GroupControl1)
        Me.BaseTab2.Controls.Add(Me.TextEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl8)
        Me.BaseTab2.Controls.Add(Me.CheckEdit2)
        Me.BaseTab2.Controls.Add(Me.CheckEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl5)
        Me.BaseTab2.Controls.Add(Me.CariUnvanButtonEdit)
        Me.BaseTab2.Controls.Add(Me.LabelControl4)
        Me.BaseTab2.Controls.Add(Me.CariKodButtonEdit)
        Me.BaseTab2.Controls.Add(Me.LabelControl6)
        Me.BaseTab2.Controls.Add(Me.IrsEvrakSiraSpinEdit)
        Me.BaseTab2.Controls.Add(Me.IrsEvrakSeriTextEdit)
        Me.BaseTab2.Controls.Add(Me.LabelControl7)
        Me.BaseTab2.Controls.Add(Me.ComboBoxEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl3)
        Me.BaseTab2.Controls.Add(Me.DateEdit2)
        Me.BaseTab2.Controls.Add(Me.LabelControl2)
        Me.BaseTab2.Controls.Add(Me.DateEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(951, 460)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.ComboBoxEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.IrsEvrakSeriTextEdit, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.IrsEvrakSiraSpinEdit, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CariKodButtonEdit, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CariUnvanButtonEdit, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CheckEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CheckEdit2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.cmdSiparisSec, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl17, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit9, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit5, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl19, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl20, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit11, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl21, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit12, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl22, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit13, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl23, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit14, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl24, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.ComboBoxEdit2, 0)
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(951, 380)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFasonFisID, Me.colFasonTuru, Me.colTarih, Me.colFasonTermin, Me.colFasonEvrakSeri, Me.colFasonEvrakSira, Me.colFasonBelgeNo, Me.colCariKod, Me.colCariUnvan, Me.colAciklama1, Me.colAciklama2, Me.colAciklama3, Me.colSiparisID, Me.colSipDetayID, Me.colAdet, Me.colAgirlik, Me.colIptal, Me.colKapali, Me.colKapanmaTarihi, Me.colSipEvrakSeri, Me.colSipEvrakSira, Me.colStokKod, Me.colSipCariKod, Me.colSipCariUnvan, Me.colMiktar, Me.colSipTermin, Me.colSipTarihi, Me.colDurumu, Me.colAnaRenk, Me.colBedenler, Me.colParca})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsLayout.LayoutVersion = "1.0"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'panelBottom
        '
        Me.panelBottom.Location = New System.Drawing.Point(0, 611)
        Me.panelBottom.Size = New System.Drawing.Size(957, 41)
        '
        'PanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(759, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Size = New System.Drawing.Size(957, 31)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_FasonFisID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_FasonTuru, Me.MasterTable_Tarih, Me.MasterTable_FasonTermin, Me.MasterTable_FasonEvrakSeri, Me.MasterTable_FasonEvrakSira, Me.MasterTable_FasonBelgeNo, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_Aciklama1, Me.MasterTable_Aciklama2, Me.MasterTable_Aciklama3, Me.MasterTable_SiparisID, Me.MasterTable_SipDetayID, Me.MasterTable_Adet, Me.MasterTable_Agirlik, Me.MasterTable_Iptal, Me.MasterTable_Kapali, Me.MasterTable_KapanmaTarihi, Me.MasterTable_Parca, Me.MasterTable_SipEvrakSeri, Me.MasterTable_SipEvrakSira, Me.MasterTable_StokKod, Me.MasterTable_SipCariKod, Me.MasterTable_SipCariUnvan, Me.MasterTable_Miktar, Me.MasterTable_SipTermin, Me.MasterTable_SipTarihi, Me.MasterTable_Durumu, Me.MasterTable_AnaRenk, Me.MasterTable_Bedenler})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"FasonFisID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_FasonFisID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(887, 276)
        Me.BaseTab4.Tag = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(957, 12)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 441)
        Me.lblMainWarning1.Size = New System.Drawing.Size(951, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 434)
        Me.panelAuthCodes.Size = New System.Drawing.Size(951, 26)
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
        Me.panelFormDateFilter.Controls.Add(Me.chkGoster_Iptaller)
        Me.panelFormDateFilter.Controls.Add(Me.chkGoster_Kapalilar)
        Me.panelFormDateFilter.Size = New System.Drawing.Size(951, 61)
        Me.panelFormDateFilter.Visible = True
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate2, 0)
        
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.cmdRefreshList, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkGoster_Kapalilar, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkGoster_Iptaller, 0)
        '
        'FormDateRadioGroup
        '
        
        
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
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Kapali", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0"), New System.Data.SqlClient.SqlParameter("@Iptal", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_FasonFisID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE FasonFis SET Deleted = FasonFisID  , ModifiedBy = @ModifiedBy , ModifiedDa" & _
    "te = GETDATE()   WHERE FasonFisID = @FasonFisID"
        '
        'colFasonFisID
        '
        Me.colFasonFisID.FieldName = "FasonFisID"
        Me.colFasonFisID.Name = "colFasonFisID"
        '
        'colFasonTuru
        '
        Me.colFasonTuru.FieldName = "FasonTuru"
        Me.colFasonTuru.Name = "colFasonTuru"
        Me.colFasonTuru.Visible = True
        Me.colFasonTuru.VisibleIndex = 0
        Me.colFasonTuru.Width = 84
        '
        'colTarih
        '
        Me.colTarih.FieldName = "Tarih"
        Me.colTarih.Name = "colTarih"
        Me.colTarih.Visible = True
        Me.colTarih.VisibleIndex = 1
        '
        'colFasonTermin
        '
        Me.colFasonTermin.FieldName = "FasonTermin"
        Me.colFasonTermin.Name = "colFasonTermin"
        Me.colFasonTermin.Visible = True
        Me.colFasonTermin.VisibleIndex = 2
        Me.colFasonTermin.Width = 98
        '
        'colFasonEvrakSeri
        '
        Me.colFasonEvrakSeri.Caption = "F.Evrak Seri"
        Me.colFasonEvrakSeri.FieldName = "FasonEvrakSeri"
        Me.colFasonEvrakSeri.Name = "colFasonEvrakSeri"
        Me.colFasonEvrakSeri.Visible = True
        Me.colFasonEvrakSeri.VisibleIndex = 3
        Me.colFasonEvrakSeri.Width = 88
        '
        'colFasonEvrakSira
        '
        Me.colFasonEvrakSira.Caption = "F.Evrak Sira"
        Me.colFasonEvrakSira.FieldName = "FasonEvrakSira"
        Me.colFasonEvrakSira.Name = "colFasonEvrakSira"
        Me.colFasonEvrakSira.Visible = True
        Me.colFasonEvrakSira.VisibleIndex = 4
        Me.colFasonEvrakSira.Width = 93
        '
        'colFasonBelgeNo
        '
        Me.colFasonBelgeNo.Caption = "F.BelgeNo"
        Me.colFasonBelgeNo.FieldName = "FasonBelgeNo"
        Me.colFasonBelgeNo.Name = "colFasonBelgeNo"
        Me.colFasonBelgeNo.Visible = True
        Me.colFasonBelgeNo.VisibleIndex = 5
        Me.colFasonBelgeNo.Width = 107
        '
        'colCariKod
        '
        Me.colCariKod.Caption = "F.Cari Kod"
        Me.colCariKod.FieldName = "CariKod"
        Me.colCariKod.Name = "colCariKod"
        Me.colCariKod.Visible = True
        Me.colCariKod.VisibleIndex = 6
        Me.colCariKod.Width = 90
        '
        'colCariUnvan
        '
        Me.colCariUnvan.Caption = "F.Cari Unvan"
        Me.colCariUnvan.FieldName = "CariUnvan"
        Me.colCariUnvan.Name = "colCariUnvan"
        Me.colCariUnvan.Visible = True
        Me.colCariUnvan.VisibleIndex = 7
        Me.colCariUnvan.Width = 104
        '
        'colAciklama1
        '
        Me.colAciklama1.FieldName = "Aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Visible = True
        Me.colAciklama1.VisibleIndex = 24
        Me.colAciklama1.Width = 77
        '
        'colAciklama2
        '
        Me.colAciklama2.FieldName = "Aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Visible = True
        Me.colAciklama2.VisibleIndex = 25
        Me.colAciklama2.Width = 77
        '
        'colAciklama3
        '
        Me.colAciklama3.FieldName = "Aciklama3"
        Me.colAciklama3.Name = "colAciklama3"
        Me.colAciklama3.Visible = True
        Me.colAciklama3.VisibleIndex = 26
        Me.colAciklama3.Width = 77
        '
        'colSiparisID
        '
        Me.colSiparisID.FieldName = "SiparisID"
        Me.colSiparisID.Name = "colSiparisID"
        '
        'colSipDetayID
        '
        Me.colSipDetayID.FieldName = "SipDetayID"
        Me.colSipDetayID.Name = "colSipDetayID"
        '
        'colAdet
        '
        Me.colAdet.DisplayFormat.FormatString = "#,##0.###"
        Me.colAdet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAdet.FieldName = "Adet"
        Me.colAdet.Name = "colAdet"
        Me.colAdet.Visible = True
        Me.colAdet.VisibleIndex = 13
        '
        'colAgirlik
        '
        Me.colAgirlik.DisplayFormat.FormatString = "#,##0.###"
        Me.colAgirlik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAgirlik.FieldName = "Agirlik"
        Me.colAgirlik.Name = "colAgirlik"
        Me.colAgirlik.Visible = True
        Me.colAgirlik.VisibleIndex = 14
        '
        'colIptal
        '
        Me.colIptal.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colIptal.FieldName = "Iptal"
        Me.colIptal.Name = "colIptal"
        Me.colIptal.Visible = True
        Me.colIptal.VisibleIndex = 15
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
        'colKapali
        '
        Me.colKapali.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colKapali.FieldName = "Kapali"
        Me.colKapali.Name = "colKapali"
        Me.colKapali.Visible = True
        Me.colKapali.VisibleIndex = 16
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
        'colKapanmaTarihi
        '
        Me.colKapanmaTarihi.FieldName = "KapanmaTarihi"
        Me.colKapanmaTarihi.Name = "colKapanmaTarihi"
        Me.colKapanmaTarihi.Visible = True
        Me.colKapanmaTarihi.VisibleIndex = 17
        Me.colKapanmaTarihi.Width = 109
        '
        'colSipEvrakSeri
        '
        Me.colSipEvrakSeri.FieldName = "SipEvrakSeri"
        Me.colSipEvrakSeri.Name = "colSipEvrakSeri"
        Me.colSipEvrakSeri.Visible = True
        Me.colSipEvrakSeri.VisibleIndex = 8
        Me.colSipEvrakSeri.Width = 99
        '
        'colSipEvrakSira
        '
        Me.colSipEvrakSira.FieldName = "SipEvrakSira"
        Me.colSipEvrakSira.Name = "colSipEvrakSira"
        Me.colSipEvrakSira.Visible = True
        Me.colSipEvrakSira.VisibleIndex = 11
        Me.colSipEvrakSira.Width = 99
        '
        'colStokKod
        '
        Me.colStokKod.FieldName = "StokKod"
        Me.colStokKod.Name = "colStokKod"
        '
        'colSipCariKod
        '
        Me.colSipCariKod.FieldName = "SipCariKod"
        Me.colSipCariKod.Name = "colSipCariKod"
        Me.colSipCariKod.Visible = True
        Me.colSipCariKod.VisibleIndex = 9
        Me.colSipCariKod.Width = 89
        '
        'colSipCariUnvan
        '
        Me.colSipCariUnvan.FieldName = "SipCariUnvan"
        Me.colSipCariUnvan.Name = "colSipCariUnvan"
        Me.colSipCariUnvan.Visible = True
        Me.colSipCariUnvan.VisibleIndex = 10
        Me.colSipCariUnvan.Width = 103
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Sip Miktar"
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 20
        '
        'colSipTermin
        '
        Me.colSipTermin.FieldName = "SipTermin"
        Me.colSipTermin.Name = "colSipTermin"
        Me.colSipTermin.Visible = True
        Me.colSipTermin.VisibleIndex = 19
        Me.colSipTermin.Width = 82
        '
        'colSipTarihi
        '
        Me.colSipTarihi.FieldName = "SipTarihi"
        Me.colSipTarihi.Name = "colSipTarihi"
        Me.colSipTarihi.Visible = True
        Me.colSipTarihi.VisibleIndex = 18
        '
        'colDurumu
        '
        Me.colDurumu.FieldName = "Durumu"
        Me.colDurumu.Name = "colDurumu"
        Me.colDurumu.Visible = True
        Me.colDurumu.VisibleIndex = 21
        '
        'colAnaRenk
        '
        Me.colAnaRenk.FieldName = "AnaRenk"
        Me.colAnaRenk.Name = "colAnaRenk"
        Me.colAnaRenk.Visible = True
        Me.colAnaRenk.VisibleIndex = 22
        '
        'colBedenler
        '
        Me.colBedenler.FieldName = "Bedenler"
        Me.colBedenler.Name = "colBedenler"
        Me.colBedenler.Visible = True
        Me.colBedenler.VisibleIndex = 23
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tarih"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Tarih", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(114, 68)
        Me.DateEdit1.MenuManager = Me.BarManager1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit1.Size = New System.Drawing.Size(123, 22)
        Me.DateEdit1.TabIndex = 3
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonTermin", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(114, 96)
        Me.DateEdit2.MenuManager = Me.BarManager1
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit2.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit2.Size = New System.Drawing.Size(123, 22)
        Me.DateEdit2.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 99)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Tarmin tarihi"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Fason Turu"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonTuru", True))
        Me.ComboBoxEdit1.EnterMoveNextControl = True
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(114, 12)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Boya", "Örgü", "Dikiş", "Nakış", "Fason Üretim", "Diğer"})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(206, 22)
        Me.ComboBoxEdit1.TabIndex = 0
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Kapali", True))
        Me.CheckEdit1.EnterMoveNextControl = True
        Me.CheckEdit1.Location = New System.Drawing.Point(112, 328)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Kapali"
        Me.CheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit1.Properties.ValueChecked = 1
        Me.CheckEdit1.Properties.ValueUnchecked = 0
        Me.CheckEdit1.Size = New System.Drawing.Size(90, 27)
        Me.CheckEdit1.TabIndex = 12
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 160)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl5.TabIndex = 48
        Me.LabelControl5.Text = "F.Cari Unvan"
        '
        'CariUnvanButtonEdit
        '
        Me.CariUnvanButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariUnvan", True))
        Me.CariUnvanButtonEdit.EnterMoveNextControl = True
        Me.CariUnvanButtonEdit.Location = New System.Drawing.Point(114, 157)
        Me.CariUnvanButtonEdit.MenuManager = Me.BarManager1
        Me.CariUnvanButtonEdit.Name = "CariUnvanButtonEdit"
        Me.CariUnvanButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CariUnvanButtonEdit.Size = New System.Drawing.Size(372, 22)
        Me.CariUnvanButtonEdit.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 132)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "Fason cari kod"
        '
        'CariKodButtonEdit
        '
        Me.CariKodButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariKod", True))
        Me.CariKodButtonEdit.EnterMoveNextControl = True
        Me.CariKodButtonEdit.Location = New System.Drawing.Point(114, 129)
        Me.CariKodButtonEdit.MenuManager = Me.BarManager1
        Me.CariKodButtonEdit.Name = "CariKodButtonEdit"
        Me.CariKodButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CariKodButtonEdit.Size = New System.Drawing.Size(177, 22)
        Me.CariKodButtonEdit.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(212, 43)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl6.TabIndex = 46
        Me.LabelControl6.Text = "Evrak Sira"
        '
        'IrsEvrakSiraSpinEdit
        '
        Me.IrsEvrakSiraSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonEvrakSira", True))
        Me.IrsEvrakSiraSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IrsEvrakSiraSpinEdit.EnterMoveNextControl = True
        Me.IrsEvrakSiraSpinEdit.Location = New System.Drawing.Point(276, 40)
        Me.IrsEvrakSiraSpinEdit.MenuManager = Me.BarManager1
        Me.IrsEvrakSiraSpinEdit.Name = "IrsEvrakSiraSpinEdit"
        Me.IrsEvrakSiraSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IrsEvrakSiraSpinEdit.Properties.IsFloatValue = False
        Me.IrsEvrakSiraSpinEdit.Properties.Mask.EditMask = "N00"
        Me.IrsEvrakSiraSpinEdit.Size = New System.Drawing.Size(103, 22)
        Me.IrsEvrakSiraSpinEdit.TabIndex = 2
        '
        'IrsEvrakSeriTextEdit
        '
        Me.IrsEvrakSeriTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonEvrakSeri", True))
        Me.IrsEvrakSeriTextEdit.EnterMoveNextControl = True
        Me.IrsEvrakSeriTextEdit.Location = New System.Drawing.Point(114, 40)
        Me.IrsEvrakSeriTextEdit.MenuManager = Me.BarManager1
        Me.IrsEvrakSeriTextEdit.Name = "IrsEvrakSeriTextEdit"
        Me.IrsEvrakSeriTextEdit.Properties.MaxLength = 4
        Me.IrsEvrakSeriTextEdit.Size = New System.Drawing.Size(91, 22)
        Me.IrsEvrakSeriTextEdit.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(11, 43)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl7.TabIndex = 45
        Me.LabelControl7.Text = "Evrak Seri"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Iptal", True))
        Me.CheckEdit2.EnterMoveNextControl = True
        Me.CheckEdit2.Location = New System.Drawing.Point(112, 396)
        Me.CheckEdit2.MenuManager = Me.BarManager1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit2.Properties.Caption = "Iptal"
        Me.CheckEdit2.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit2.Properties.ValueChecked = 1
        Me.CheckEdit2.Properties.ValueUnchecked = 0
        Me.CheckEdit2.Size = New System.Drawing.Size(90, 21)
        Me.CheckEdit2.TabIndex = 14
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonBelgeNo", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(326, 68)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(160, 22)
        Me.TextEdit1.TabIndex = 10
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(270, 74)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl8.TabIndex = 52
        Me.LabelControl8.Text = "Belge No"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.TextEdit10)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.TextEdit8)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.TextEdit7)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.TextEdit6)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.TextEdit5)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.TextEdit4)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.DateEdit4)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.DateEdit3)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Location = New System.Drawing.Point(522, 40)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(392, 370)
        Me.GroupControl1.TabIndex = 16
        Me.GroupControl1.Text = "Siparis bilgileri"
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Durumu", True))
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(86, 265)
        Me.TextEdit10.MenuManager = Me.BarManager1
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.MaxLength = 4
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Size = New System.Drawing.Size(181, 22)
        Me.TextEdit10.TabIndex = 9
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(26, 268)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl18.TabIndex = 58
        Me.LabelControl18.Text = "Durumu"
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Miktar", True))
        Me.TextEdit8.EnterMoveNextControl = True
        Me.TextEdit8.Location = New System.Drawing.Point(86, 122)
        Me.TextEdit8.MenuManager = Me.BarManager1
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.MaxLength = 4
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Size = New System.Drawing.Size(123, 22)
        Me.TextEdit8.TabIndex = 4
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(5, 125)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl16.TabIndex = 56
        Me.LabelControl16.Text = "Sip. Adet"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "AnaRenk", True))
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(86, 237)
        Me.TextEdit7.MenuManager = Me.BarManager1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.MaxLength = 4
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(301, 22)
        Me.TextEdit7.TabIndex = 8
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(21, 240)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl15.TabIndex = 54
        Me.LabelControl15.Text = "Ana renk"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Bedenler", True))
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(86, 208)
        Me.TextEdit6.MenuManager = Me.BarManager1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.MaxLength = 4
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(301, 22)
        Me.TextEdit6.TabIndex = 7
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(21, 211)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl14.TabIndex = 52
        Me.LabelControl14.Text = "Bedenler"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipCariUnvan", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(86, 180)
        Me.TextEdit5.MenuManager = Me.BarManager1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.MaxLength = 4
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(301, 22)
        Me.TextEdit5.TabIndex = 6
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(36, 183)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl13.TabIndex = 50
        Me.LabelControl13.Text = "Unvan"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipCariKod", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(86, 152)
        Me.TextEdit4.MenuManager = Me.BarManager1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.MaxLength = 4
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(301, 22)
        Me.TextEdit4.TabIndex = 5
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(29, 155)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl12.TabIndex = 48
        Me.LabelControl12.Text = "Musteri"
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipTermin", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.EnterMoveNextControl = True
        Me.DateEdit4.Location = New System.Drawing.Point(86, 90)
        Me.DateEdit4.MenuManager = Me.BarManager1
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit4.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit4.Properties.ReadOnly = True
        Me.DateEdit4.Size = New System.Drawing.Size(123, 22)
        Me.DateEdit4.TabIndex = 3
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(5, 93)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl11.TabIndex = 46
        Me.LabelControl11.Text = "Termin"
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipTarihi", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.EnterMoveNextControl = True
        Me.DateEdit3.Location = New System.Drawing.Point(86, 62)
        Me.DateEdit3.MenuManager = Me.BarManager1
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit3.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit3.Properties.ReadOnly = True
        Me.DateEdit3.Size = New System.Drawing.Size(123, 22)
        Me.DateEdit3.TabIndex = 2
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipEvrakSira", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(144, 34)
        Me.TextEdit3.MenuManager = Me.BarManager1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.MaxLength = 4
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(82, 22)
        Me.TextEdit3.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(5, 65)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl10.TabIndex = 43
        Me.LabelControl10.Text = "Tarih"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "SipEvrakSeri", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(86, 34)
        Me.TextEdit2.MenuManager = Me.BarManager1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.MaxLength = 4
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(52, 22)
        Me.TextEdit2.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(5, 37)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl9.TabIndex = 6
        Me.LabelControl9.Text = "Siparis No"
        '
        'cmdSiparisSec
        '
        Me.cmdSiparisSec.Appearance.Options.UseTextOptions = True
        Me.cmdSiparisSec.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdSiparisSec.Location = New System.Drawing.Point(522, 3)
        Me.cmdSiparisSec.Name = "cmdSiparisSec"
        Me.cmdSiparisSec.Size = New System.Drawing.Size(166, 31)
        Me.cmdSiparisSec.TabIndex = 54
        Me.cmdSiparisSec.Text = "Siparis sec (F3)"
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Adet", True))
        Me.TextEdit9.EnterMoveNextControl = True
        Me.TextEdit9.Location = New System.Drawing.Point(276, 213)
        Me.TextEdit9.MenuManager = Me.BarManager1
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.MaxLength = 4
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(123, 22)
        Me.TextEdit9.TabIndex = 8
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(244, 216)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(26, 16)
        Me.LabelControl17.TabIndex = 58
        Me.LabelControl17.Text = "Adet"
        '
        'chkGoster_Kapalilar
        '
        Me.chkGoster_Kapalilar.Location = New System.Drawing.Point(642, 8)
        Me.chkGoster_Kapalilar.MenuManager = Me.BarManager1
        Me.chkGoster_Kapalilar.Name = "chkGoster_Kapalilar"
        Me.chkGoster_Kapalilar.Properties.Caption = "Kapali fisleri goster"
        Me.chkGoster_Kapalilar.Size = New System.Drawing.Size(146, 21)
        Me.chkGoster_Kapalilar.TabIndex = 12
        '
        'chkGoster_Iptaller
        '
        Me.chkGoster_Iptaller.Location = New System.Drawing.Point(642, 35)
        Me.chkGoster_Iptaller.MenuManager = Me.BarManager1
        Me.chkGoster_Iptaller.Name = "chkGoster_Iptaller"
        Me.chkGoster_Iptaller.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkGoster_Iptaller.Properties.Appearance.Options.UseForeColor = True
        Me.chkGoster_Iptaller.Properties.Caption = "Iptal fisleri goster"
        Me.chkGoster_Iptaller.Size = New System.Drawing.Size(146, 21)
        Me.chkGoster_Iptaller.TabIndex = 13
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KapatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 28)
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.KapatToolStripMenuItem.Text = "Kapat"
        '
        'DateEdit5
        '
        Me.DateEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KapanmaTarihi", True))
        Me.DateEdit5.EditValue = Nothing
        Me.DateEdit5.EnterMoveNextControl = True
        Me.DateEdit5.Location = New System.Drawing.Point(114, 365)
        Me.DateEdit5.MenuManager = Me.BarManager1
        Me.DateEdit5.Name = "DateEdit5"
        Me.DateEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit5.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit5.Size = New System.Drawing.Size(123, 22)
        Me.DateEdit5.TabIndex = 13
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(11, 368)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl19.TabIndex = 60
        Me.LabelControl19.Text = "Kapanma tarihi"
        '
        'TextEdit11
        '
        Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama1", True))
        Me.TextEdit11.EnterMoveNextControl = True
        Me.TextEdit11.Location = New System.Drawing.Point(114, 241)
        Me.TextEdit11.MenuManager = Me.BarManager1
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Size = New System.Drawing.Size(372, 22)
        Me.TextEdit11.TabIndex = 9
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(11, 244)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl20.TabIndex = 62
        Me.LabelControl20.Text = "Aciklama 1"
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama2", True))
        Me.TextEdit12.EnterMoveNextControl = True
        Me.TextEdit12.Location = New System.Drawing.Point(114, 269)
        Me.TextEdit12.MenuManager = Me.BarManager1
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Size = New System.Drawing.Size(372, 22)
        Me.TextEdit12.TabIndex = 10
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(11, 272)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl21.TabIndex = 64
        Me.LabelControl21.Text = "Aciklama 2"
        '
        'TextEdit13
        '
        Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama3", True))
        Me.TextEdit13.EnterMoveNextControl = True
        Me.TextEdit13.Location = New System.Drawing.Point(114, 297)
        Me.TextEdit13.MenuManager = Me.BarManager1
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Size = New System.Drawing.Size(372, 22)
        Me.TextEdit13.TabIndex = 11
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(11, 300)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl22.TabIndex = 66
        Me.LabelControl22.Text = "Aciklama 3"
        '
        'TextEdit14
        '
        Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Agirlik", True))
        Me.TextEdit14.EnterMoveNextControl = True
        Me.TextEdit14.Location = New System.Drawing.Point(114, 213)
        Me.TextEdit14.MenuManager = Me.BarManager1
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Size = New System.Drawing.Size(123, 22)
        Me.TextEdit14.TabIndex = 7
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(11, 216)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl23.TabIndex = 68
        Me.LabelControl23.Text = "Agirlik/Kg"
        '
        'MasterTable_FasonFisID
        '
        Me.MasterTable_FasonFisID.AllowDBNull = False
        Me.MasterTable_FasonFisID.AutoIncrement = True
        Me.MasterTable_FasonFisID.ColumnName = "FasonFisID"
        Me.MasterTable_FasonFisID.DataType = GetType(Integer)
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
        'MasterTable_FasonTuru
        '
        Me.MasterTable_FasonTuru.ColumnName = "FasonTuru"
        '
        'MasterTable_Tarih
        '
        Me.MasterTable_Tarih.ColumnName = "Tarih"
        Me.MasterTable_Tarih.DataType = GetType(Date)
        '
        'MasterTable_FasonTermin
        '
        Me.MasterTable_FasonTermin.ColumnName = "FasonTermin"
        Me.MasterTable_FasonTermin.DataType = GetType(Date)
        '
        'MasterTable_FasonEvrakSeri
        '
        Me.MasterTable_FasonEvrakSeri.ColumnName = "FasonEvrakSeri"
        '
        'MasterTable_FasonEvrakSira
        '
        Me.MasterTable_FasonEvrakSira.ColumnName = "FasonEvrakSira"
        Me.MasterTable_FasonEvrakSira.DataType = GetType(Integer)
        '
        'MasterTable_FasonBelgeNo
        '
        Me.MasterTable_FasonBelgeNo.ColumnName = "FasonBelgeNo"
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
        'MasterTable_SiparisID
        '
        Me.MasterTable_SiparisID.ColumnName = "SiparisID"
        Me.MasterTable_SiparisID.DataType = GetType(Integer)
        '
        'MasterTable_SipDetayID
        '
        Me.MasterTable_SipDetayID.ColumnName = "SipDetayID"
        Me.MasterTable_SipDetayID.DataType = GetType(Integer)
        '
        'MasterTable_Adet
        '
        Me.MasterTable_Adet.ColumnName = "Adet"
        Me.MasterTable_Adet.DataType = GetType(Double)
        '
        'MasterTable_Agirlik
        '
        Me.MasterTable_Agirlik.ColumnName = "Agirlik"
        Me.MasterTable_Agirlik.DataType = GetType(Double)
        '
        'MasterTable_Iptal
        '
        Me.MasterTable_Iptal.ColumnName = "Iptal"
        Me.MasterTable_Iptal.DataType = GetType(Integer)
        '
        'MasterTable_Kapali
        '
        Me.MasterTable_Kapali.ColumnName = "Kapali"
        Me.MasterTable_Kapali.DataType = GetType(Integer)
        '
        'MasterTable_KapanmaTarihi
        '
        Me.MasterTable_KapanmaTarihi.ColumnName = "KapanmaTarihi"
        Me.MasterTable_KapanmaTarihi.DataType = GetType(Date)
        '
        'MasterTable_Parca
        '
        Me.MasterTable_Parca.ColumnName = "Parca"
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
        'MasterTable_StokKod
        '
        Me.MasterTable_StokKod.ColumnName = "StokKod"
        '
        'MasterTable_SipCariKod
        '
        Me.MasterTable_SipCariKod.ColumnName = "SipCariKod"
        '
        'MasterTable_SipCariUnvan
        '
        Me.MasterTable_SipCariUnvan.ColumnName = "SipCariUnvan"
        '
        'MasterTable_Miktar
        '
        Me.MasterTable_Miktar.ColumnName = "Miktar"
        Me.MasterTable_Miktar.DataType = GetType(Double)
        '
        'MasterTable_SipTermin
        '
        Me.MasterTable_SipTermin.ColumnName = "SipTermin"
        Me.MasterTable_SipTermin.DataType = GetType(Date)
        '
        'MasterTable_SipTarihi
        '
        Me.MasterTable_SipTarihi.ColumnName = "SipTarihi"
        Me.MasterTable_SipTarihi.DataType = GetType(Date)
        '
        'MasterTable_Durumu
        '
        Me.MasterTable_Durumu.ColumnName = "Durumu"
        '
        'MasterTable_AnaRenk
        '
        Me.MasterTable_AnaRenk.ColumnName = "AnaRenk"
        '
        'MasterTable_Bedenler
        '
        Me.MasterTable_Bedenler.ColumnName = "Bedenler"
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Parca", True))
        Me.ComboBoxEdit2.EnterMoveNextControl = True
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(114, 185)
        Me.ComboBoxEdit2.MenuManager = Me.BarManager1
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"LAKOS", "YAKA", "SELANIK", "INTERLOK", "SUPREM30/1", "SUPREM20/1"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(206, 22)
        Me.ComboBoxEdit2.TabIndex = 69
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(11, 188)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl24.TabIndex = 70
        Me.LabelControl24.Text = "Parça"
        '
        'colParca
        '
        Me.colParca.FieldName = "Parca"
        Me.colParca.Name = "colParca"
        Me.colParca.Visible = True
        Me.colParca.VisibleIndex = 12
        Me.colParca.Width = 144
        '
        'frmFason
        '
        Me.ClientSize = New System.Drawing.Size(957, 675)
        Me.FormCode = "000027"
        Me.Name = "frmFason"
        Me.Text = "Fason fisleri"
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
        Me.BaseTab2.PerformLayout()
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
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CariUnvanButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CariKodButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrsEvrakSiraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrsEvrakSeriTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGoster_Kapalilar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGoster_Iptaller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DateEdit5.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colFasonFisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFasonTuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFasonTermin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFasonEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFasonEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFasonBelgeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKapali As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKapanmaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipTermin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSipTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDurumu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnaRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CariUnvanButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CariKodButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IrsEvrakSiraSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IrsEvrakSeriTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSiparisSec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkGoster_Iptaller As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGoster_Kapalilar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KapatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit5 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MasterTable_FasonFisID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_FasonTuru As System.Data.DataColumn
    Friend WithEvents MasterTable_Tarih As System.Data.DataColumn
    Friend WithEvents MasterTable_FasonTermin As System.Data.DataColumn
    Friend WithEvents MasterTable_FasonEvrakSeri As System.Data.DataColumn
    Friend WithEvents MasterTable_FasonEvrakSira As System.Data.DataColumn
    Friend WithEvents MasterTable_FasonBelgeNo As System.Data.DataColumn
    Friend WithEvents MasterTable_CariKod As System.Data.DataColumn
    Friend WithEvents MasterTable_CariUnvan As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama2 As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama3 As System.Data.DataColumn
    Friend WithEvents MasterTable_SiparisID As System.Data.DataColumn
    Friend WithEvents MasterTable_SipDetayID As System.Data.DataColumn
    Friend WithEvents MasterTable_Adet As System.Data.DataColumn
    Friend WithEvents MasterTable_Agirlik As System.Data.DataColumn
    Friend WithEvents MasterTable_Iptal As System.Data.DataColumn
    Friend WithEvents MasterTable_Kapali As System.Data.DataColumn
    Friend WithEvents MasterTable_KapanmaTarihi As System.Data.DataColumn
    Friend WithEvents MasterTable_Parca As System.Data.DataColumn
    Friend WithEvents MasterTable_SipEvrakSeri As System.Data.DataColumn
    Friend WithEvents MasterTable_SipEvrakSira As System.Data.DataColumn
    Friend WithEvents MasterTable_StokKod As System.Data.DataColumn
    Friend WithEvents MasterTable_SipCariKod As System.Data.DataColumn
    Friend WithEvents MasterTable_SipCariUnvan As System.Data.DataColumn
    Friend WithEvents MasterTable_Miktar As System.Data.DataColumn
    Friend WithEvents MasterTable_SipTermin As System.Data.DataColumn
    Friend WithEvents MasterTable_SipTarihi As System.Data.DataColumn
    Friend WithEvents MasterTable_Durumu As System.Data.DataColumn
    Friend WithEvents MasterTable_AnaRenk As System.Data.DataColumn
    Friend WithEvents MasterTable_Bedenler As System.Data.DataColumn
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colParca As DevExpress.XtraGrid.Columns.GridColumn

End Class
