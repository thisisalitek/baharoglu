<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanlananTahsilatVeOdemeler
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanlananTahsilatVeOdemeler))
        Me.chkGoster_Iptaller = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGoster_Kapalilar = New DevExpress.XtraEditors.CheckEdit()
        Me.MasterTable_nID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_Turu = New System.Data.DataColumn()
        Me.MasterTable_Tarih = New System.Data.DataColumn()
        Me.MasterTable_CariKod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_DigerUnvan = New System.Data.DataColumn()
        Me.MasterTable_Hesap = New System.Data.DataColumn()
        Me.MasterTable_TerminTarihi = New System.Data.DataColumn()
        Me.MasterTable_PersonelID = New System.Data.DataColumn()
        Me.MasterTable_Tutar = New System.Data.DataColumn()
        Me.MasterTable_GelenTutar = New System.Data.DataColumn()
        Me.MasterTable_DovizTipi = New System.Data.DataColumn()
        Me.MasterTable_DovizKuru = New System.Data.DataColumn()
        Me.MasterTable_TutarTL = New System.Data.DataColumn()
        Me.MasterTable_Aciklama = New System.Data.DataColumn()
        Me.MasterTable_Kapali = New System.Data.DataColumn()
        Me.MasterTable_KapanmaTarihi = New System.Data.DataColumn()
        Me.MasterTable_Iptal = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colnID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDigerUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHesap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerminTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonelID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGelenTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutarTL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKapali = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colKapanmaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIptal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbPersonel = New NeoDAC.NeoTable(Me.components)
        Me.tbPersonel_SaticiID = New System.Data.DataColumn()
        Me.tbPersonel_SaticiIsmi = New System.Data.DataColumn()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CariUnvanButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CariKodButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDoviz = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.cboHesap = New DevExpress.XtraEditors.ComboBoxEdit()
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
        CType(Me.chkGoster_Iptaller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGoster_Kapalilar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPersonel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CariUnvanButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CariKodButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDoviz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHesap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 522)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 445)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 445)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 120)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(893, 361)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(887, 330)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.cboHesap)
        Me.BaseTab2.Controls.Add(Me.LookUpEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl13)
        Me.BaseTab2.Controls.Add(Me.CheckEdit2)
        Me.BaseTab2.Controls.Add(Me.DateEdit3)
        Me.BaseTab2.Controls.Add(Me.LabelControl12)
        Me.BaseTab2.Controls.Add(Me.CheckEdit1)
        Me.BaseTab2.Controls.Add(Me.TextEdit7)
        Me.BaseTab2.Controls.Add(Me.LabelControl11)
        Me.BaseTab2.Controls.Add(Me.TextEdit6)
        Me.BaseTab2.Controls.Add(Me.LabelControl10)
        Me.BaseTab2.Controls.Add(Me.TextEdit5)
        Me.BaseTab2.Controls.Add(Me.LabelControl9)
        Me.BaseTab2.Controls.Add(Me.LabelControl8)
        Me.BaseTab2.Controls.Add(Me.TextEdit4)
        Me.BaseTab2.Controls.Add(Me.cboDoviz)
        Me.BaseTab2.Controls.Add(Me.LabelControl7)
        Me.BaseTab2.Controls.Add(Me.LabelControl6)
        Me.BaseTab2.Controls.Add(Me.TextEdit2)
        Me.BaseTab2.Controls.Add(Me.LabelControl3)
        Me.BaseTab2.Controls.Add(Me.TextEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl5)
        Me.BaseTab2.Controls.Add(Me.CariUnvanButtonEdit)
        Me.BaseTab2.Controls.Add(Me.LabelControl4)
        Me.BaseTab2.Controls.Add(Me.CariKodButtonEdit)
        Me.BaseTab2.Controls.Add(Me.DateEdit2)
        Me.BaseTab2.Controls.Add(Me.LabelControl2)
        Me.BaseTab2.Controls.Add(Me.DateEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(887, 330)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CariKodButtonEdit, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CariUnvanButtonEdit, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.cboDoviz, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit4, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit5, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit6, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.TextEdit7, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CheckEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit3, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.CheckEdit2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl13, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LookUpEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.cboHesap, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(887, 250)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnID, Me.colTuru, Me.colTarih, Me.colCariKod, Me.colCariUnvan, Me.colDigerUnvan, Me.colHesap, Me.colTerminTarihi, Me.colPersonelID, Me.colTutar, Me.colGelenTutar, Me.colDovizTipi, Me.colDovizKuru, Me.colTutarTL, Me.colAciklama, Me.colKapali, Me.colKapanmaTarihi, Me.colIptal, Me.colIntCode})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[Kapali] == 1"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 481)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_nID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_Turu, Me.MasterTable_Tarih, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_DigerUnvan, Me.MasterTable_Hesap, Me.MasterTable_TerminTarihi, Me.MasterTable_PersonelID, Me.MasterTable_Tutar, Me.MasterTable_GelenTutar, Me.MasterTable_DovizTipi, Me.MasterTable_DovizKuru, Me.MasterTable_TutarTL, Me.MasterTable_Aciklama, Me.MasterTable_Kapali, Me.MasterTable_KapanmaTarihi, Me.MasterTable_Iptal, Me.MasterTable_IntCode})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_nID}
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
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 311)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 304)
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
        'chkGoster_Iptaller
        '
        Me.chkGoster_Iptaller.Location = New System.Drawing.Point(642, 32)
        Me.chkGoster_Iptaller.MenuManager = Me.BarManager1
        Me.chkGoster_Iptaller.Name = "chkGoster_Iptaller"
        Me.chkGoster_Iptaller.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkGoster_Iptaller.Properties.Appearance.Options.UseForeColor = True
        Me.chkGoster_Iptaller.Properties.Caption = "Iptaller"
        Me.chkGoster_Iptaller.Size = New System.Drawing.Size(146, 21)
        Me.chkGoster_Iptaller.TabIndex = 15
        '
        'chkGoster_Kapalilar
        '
        Me.chkGoster_Kapalilar.EditValue = True
        Me.chkGoster_Kapalilar.Location = New System.Drawing.Point(642, 5)
        Me.chkGoster_Kapalilar.MenuManager = Me.BarManager1
        Me.chkGoster_Kapalilar.Name = "chkGoster_Kapalilar"
        Me.chkGoster_Kapalilar.Properties.Caption = "Kapalilar"
        Me.chkGoster_Kapalilar.Size = New System.Drawing.Size(146, 21)
        Me.chkGoster_Kapalilar.TabIndex = 14
        '
        'MasterTable_nID
        '
        Me.MasterTable_nID.AllowDBNull = False
        Me.MasterTable_nID.AutoIncrement = True
        Me.MasterTable_nID.ColumnName = "nID"
        Me.MasterTable_nID.DataType = GetType(Integer)
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
        'MasterTable_Turu
        '
        Me.MasterTable_Turu.ColumnName = "Turu"
        Me.MasterTable_Turu.DataType = GetType(Integer)
        '
        'MasterTable_Tarih
        '
        Me.MasterTable_Tarih.ColumnName = "Tarih"
        Me.MasterTable_Tarih.DataType = GetType(Date)
        '
        'MasterTable_CariKod
        '
        Me.MasterTable_CariKod.ColumnName = "CariKod"
        '
        'MasterTable_CariUnvan
        '
        Me.MasterTable_CariUnvan.ColumnName = "CariUnvan"
        '
        'MasterTable_DigerUnvan
        '
        Me.MasterTable_DigerUnvan.ColumnName = "DigerUnvan"
        '
        'MasterTable_Hesap
        '
        Me.MasterTable_Hesap.ColumnName = "Hesap"
        '
        'MasterTable_TerminTarihi
        '
        Me.MasterTable_TerminTarihi.ColumnName = "TerminTarihi"
        Me.MasterTable_TerminTarihi.DataType = GetType(Date)
        '
        'MasterTable_PersonelID
        '
        Me.MasterTable_PersonelID.ColumnName = "PersonelID"
        Me.MasterTable_PersonelID.DataType = GetType(Integer)
        '
        'MasterTable_Tutar
        '
        Me.MasterTable_Tutar.ColumnName = "Tutar"
        Me.MasterTable_Tutar.DataType = GetType(Double)
        '
        'MasterTable_GelenTutar
        '
        Me.MasterTable_GelenTutar.ColumnName = "GelenTutar"
        Me.MasterTable_GelenTutar.DataType = GetType(Double)
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
        'MasterTable_TutarTL
        '
        Me.MasterTable_TutarTL.ColumnName = "TutarTL"
        Me.MasterTable_TutarTL.DataType = GetType(Double)
        '
        'MasterTable_Aciklama
        '
        Me.MasterTable_Aciklama.ColumnName = "Aciklama"
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
        'MasterTable_Iptal
        '
        Me.MasterTable_Iptal.ColumnName = "Iptal"
        Me.MasterTable_Iptal.DataType = GetType(Integer)
        '
        'MasterTable_IntCode
        '
        Me.MasterTable_IntCode.ColumnName = "IntCode"
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM PlanlananTahsilatVeOdemeler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND (Kapali=0 OR K" & _
    "apali=@Kapali)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND (Iptal=0 OR Iptal=@Iptal)"
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Kapali", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "1"), New System.Data.SqlClient.SqlParameter("@Iptal", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "0")})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE PlanlananTahsilatVeOdemeler SET Deleted = nID  , ModifiedBy = @ModifiedBy " & _
    ", ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'colnID
        '
        Me.colnID.FieldName = "nID"
        Me.colnID.Name = "colnID"
        '
        'colTuru
        '
        Me.colTuru.FieldName = "Turu"
        Me.colTuru.Name = "colTuru"
        '
        'colTarih
        '
        Me.colTarih.FieldName = "Tarih"
        Me.colTarih.Name = "colTarih"
        Me.colTarih.Visible = True
        Me.colTarih.VisibleIndex = 0
        Me.colTarih.Width = 104
        '
        'colCariKod
        '
        Me.colCariKod.FieldName = "CariKod"
        Me.colCariKod.Name = "colCariKod"
        Me.colCariKod.Visible = True
        Me.colCariKod.VisibleIndex = 1
        Me.colCariKod.Width = 161
        '
        'colCariUnvan
        '
        Me.colCariUnvan.FieldName = "CariUnvan"
        Me.colCariUnvan.Name = "colCariUnvan"
        Me.colCariUnvan.Visible = True
        Me.colCariUnvan.VisibleIndex = 2
        Me.colCariUnvan.Width = 183
        '
        'colDigerUnvan
        '
        Me.colDigerUnvan.FieldName = "DigerUnvan"
        Me.colDigerUnvan.Name = "colDigerUnvan"
        Me.colDigerUnvan.Visible = True
        Me.colDigerUnvan.VisibleIndex = 3
        Me.colDigerUnvan.Width = 133
        '
        'colHesap
        '
        Me.colHesap.Caption = "Verilen Hesap"
        Me.colHesap.FieldName = "Hesap"
        Me.colHesap.Name = "colHesap"
        Me.colHesap.Visible = True
        Me.colHesap.VisibleIndex = 4
        Me.colHesap.Width = 270
        '
        'colTerminTarihi
        '
        Me.colTerminTarihi.FieldName = "TerminTarihi"
        Me.colTerminTarihi.Name = "colTerminTarihi"
        Me.colTerminTarihi.Visible = True
        Me.colTerminTarihi.VisibleIndex = 5
        Me.colTerminTarihi.Width = 126
        '
        'colPersonelID
        '
        Me.colPersonelID.FieldName = "PersonelID"
        Me.colPersonelID.Name = "colPersonelID"
        Me.colPersonelID.Visible = True
        Me.colPersonelID.VisibleIndex = 6
        '
        'colTutar
        '
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 7
        '
        'colGelenTutar
        '
        Me.colGelenTutar.FieldName = "GelenTutar"
        Me.colGelenTutar.Name = "colGelenTutar"
        Me.colGelenTutar.Visible = True
        Me.colGelenTutar.VisibleIndex = 8
        '
        'colDovizTipi
        '
        Me.colDovizTipi.FieldName = "DovizTipi"
        Me.colDovizTipi.Name = "colDovizTipi"
        Me.colDovizTipi.Visible = True
        Me.colDovizTipi.VisibleIndex = 9
        '
        'colDovizKuru
        '
        Me.colDovizKuru.FieldName = "DovizKuru"
        Me.colDovizKuru.Name = "colDovizKuru"
        Me.colDovizKuru.Visible = True
        Me.colDovizKuru.VisibleIndex = 10
        '
        'colTutarTL
        '
        Me.colTutarTL.FieldName = "TutarTL"
        Me.colTutarTL.Name = "colTutarTL"
        Me.colTutarTL.Visible = True
        Me.colTutarTL.VisibleIndex = 11
        '
        'colAciklama
        '
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 12
        '
        'colKapali
        '
        Me.colKapali.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colKapali.FieldName = "Kapali"
        Me.colKapali.Name = "colKapali"
        Me.colKapali.Visible = True
        Me.colKapali.VisibleIndex = 13
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
        'colKapanmaTarihi
        '
        Me.colKapanmaTarihi.FieldName = "KapanmaTarihi"
        Me.colKapanmaTarihi.Name = "colKapanmaTarihi"
        Me.colKapanmaTarihi.Visible = True
        Me.colKapanmaTarihi.VisibleIndex = 14
        Me.colKapanmaTarihi.Width = 126
        '
        'colIptal
        '
        Me.colIptal.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colIptal.FieldName = "Iptal"
        Me.colIptal.Name = "colIptal"
        Me.colIptal.Visible = True
        Me.colIptal.VisibleIndex = 15
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
        'colIntCode
        '
        Me.colIntCode.FieldName = "IntCode"
        Me.colIntCode.Name = "colIntCode"
        '
        'tbPersonel
        '
        Me.tbPersonel.Columns.AddRange(New System.Data.DataColumn() {Me.tbPersonel_SaticiID, Me.tbPersonel_SaticiIsmi})
        Me.tbPersonel.Connection = Me.FirmConn
        Me.tbPersonel.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SaticiID"}, True)})
        Me.tbPersonel.CurrentRow = Nothing
        Me.tbPersonel.DataSourceLink = Nothing
        Me.tbPersonel.DeleteCommand = Me.SqlCommand8
        Me.tbPersonel.Filter = ""
        Me.tbPersonel.InsertCommand = Me.SqlCommand6
        Me.tbPersonel.LiveSave = False
        Me.tbPersonel.MaxRecords = CType(0, Long)
        Me.tbPersonel.Name = "tbPersonel"
        Me.tbPersonel.ParentRelation_ChildColumns = Nothing
        Me.tbPersonel.ParentRelation_ParentColumns = Nothing
        Me.tbPersonel.ParentRelation_Table = Nothing
        Me.tbPersonel.Position = CType(-1, Long)
        Me.tbPersonel.PrimaryKey = New System.Data.DataColumn() {Me.tbPersonel_SaticiID}
        Me.tbPersonel.Quoted = False
        Me.tbPersonel.SelectCommand = Me.SqlCommand5
        Me.tbPersonel.TableName = "NeoTable1"
        Me.tbPersonel.Transaction = Nothing
        Me.tbPersonel.UpdateCommand = Me.SqlCommand7
        '
        'tbPersonel_SaticiID
        '
        Me.tbPersonel_SaticiID.AllowDBNull = False
        Me.tbPersonel_SaticiID.AutoIncrement = True
        Me.tbPersonel_SaticiID.ColumnName = "SaticiID"
        Me.tbPersonel_SaticiID.DataType = GetType(Integer)
        '
        'tbPersonel_SaticiIsmi
        '
        Me.tbPersonel_SaticiIsmi.ColumnName = "SaticiIsmi"
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT SaticiID,SaticiIsmi FROM Saticilar WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY SaticiIsmi" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
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
        Me.DateEdit1.Location = New System.Drawing.Point(103, 12)
        Me.DateEdit1.MenuManager = Me.BarManager1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit1.Size = New System.Drawing.Size(100, 22)
        Me.DateEdit1.TabIndex = 0
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "TerminTarihi", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(103, 157)
        Me.DateEdit2.MenuManager = Me.BarManager1
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit2.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit2.Size = New System.Drawing.Size(100, 22)
        Me.DateEdit2.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 163)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Termin tarihi"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 72)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl5.TabIndex = 52
        Me.LabelControl5.Text = "Diger ismi"
        '
        'CariUnvanButtonEdit
        '
        Me.CariUnvanButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariUnvan", True))
        Me.CariUnvanButtonEdit.EnterMoveNextControl = True
        Me.CariUnvanButtonEdit.Location = New System.Drawing.Point(286, 40)
        Me.CariUnvanButtonEdit.MenuManager = Me.BarManager1
        Me.CariUnvanButtonEdit.Name = "CariUnvanButtonEdit"
        Me.CariUnvanButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CariUnvanButtonEdit.Properties.ReadOnly = True
        Me.CariUnvanButtonEdit.Size = New System.Drawing.Size(372, 22)
        Me.CariUnvanButtonEdit.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 16)
        Me.LabelControl4.TabIndex = 51
        Me.LabelControl4.Text = "Cari"
        '
        'CariKodButtonEdit
        '
        Me.CariKodButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariKod", True))
        Me.CariKodButtonEdit.EnterMoveNextControl = True
        Me.CariKodButtonEdit.Location = New System.Drawing.Point(103, 40)
        Me.CariKodButtonEdit.MenuManager = Me.BarManager1
        Me.CariKodButtonEdit.Name = "CariKodButtonEdit"
        Me.CariKodButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CariKodButtonEdit.Properties.ReadOnly = True
        Me.CariKodButtonEdit.Size = New System.Drawing.Size(177, 22)
        Me.CariKodButtonEdit.TabIndex = 1
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "DigerUnvan", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(103, 69)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(555, 22)
        Me.TextEdit1.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 188)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Tutar"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Tutar", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(103, 185)
        Me.TextEdit2.MenuManager = Me.BarManager1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit2.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 102)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl6.TabIndex = 56
        Me.LabelControl6.Text = "Verilen hesap"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(219, 188)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl7.TabIndex = 58
        Me.LabelControl7.Text = "Doviz"
        '
        'cboDoviz
        '
        Me.cboDoviz.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "DovizTipi", True))
        Me.cboDoviz.EditValue = "TL"
        Me.cboDoviz.EnterMoveNextControl = True
        Me.cboDoviz.Location = New System.Drawing.Point(270, 185)
        Me.cboDoviz.Name = "cboDoviz"
        Me.cboDoviz.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDoviz.Properties.Items.AddRange(New Object() {"TL", "USD", "EUR", "CAD", "DKK", "SEK", "CHF", "NOK", "JPY", "SAR", "KWD", "AUD", "GBP", "IRR", "SYP", "JOD", "BGL", "RON", "ILS", "AZN"})
        Me.cboDoviz.Size = New System.Drawing.Size(65, 22)
        Me.cboDoviz.TabIndex = 7
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "DovizKuru", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(380, 185)
        Me.TextEdit4.MenuManager = Me.BarManager1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit4.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(344, 188)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl8.TabIndex = 61
        Me.LabelControl8.Text = "D.Kur"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "TutarTL", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(558, 185)
        Me.TextEdit5.MenuManager = Me.BarManager1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit5.TabIndex = 13
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(503, 188)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl9.TabIndex = 62
        Me.LabelControl9.Text = "Tutar TL"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama", True))
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(103, 213)
        Me.TextEdit6.MenuManager = Me.BarManager1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.MaxLength = 100
        Me.TextEdit6.Size = New System.Drawing.Size(414, 22)
        Me.TextEdit6.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 216)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl10.TabIndex = 64
        Me.LabelControl10.Text = "Aciklama"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "GelenTutar", True))
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(103, 241)
        Me.TextEdit7.MenuManager = Me.BarManager1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit7.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 247)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl11.TabIndex = 66
        Me.LabelControl11.Text = "Gelen tutar"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Kapali", True))
        Me.CheckEdit1.EnterMoveNextControl = True
        Me.CheckEdit1.Location = New System.Drawing.Point(101, 279)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "KAPALI"
        Me.CheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit1.Properties.ValueChecked = 1
        Me.CheckEdit1.Properties.ValueUnchecked = 0
        Me.CheckEdit1.Size = New System.Drawing.Size(102, 26)
        Me.CheckEdit1.TabIndex = 11
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KapanmaTarihi", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.EnterMoveNextControl = True
        Me.DateEdit3.Location = New System.Drawing.Point(316, 281)
        Me.DateEdit3.MenuManager = Me.BarManager1
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit3.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit3.Size = New System.Drawing.Size(100, 22)
        Me.DateEdit3.TabIndex = 12
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(218, 284)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl12.TabIndex = 69
        Me.LabelControl12.Text = "Kapanma tarihi"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Iptal", True))
        Me.CheckEdit2.EnterMoveNextControl = True
        Me.CheckEdit2.Location = New System.Drawing.Point(565, 282)
        Me.CheckEdit2.MenuManager = Me.BarManager1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit2.Properties.Caption = "Iptal"
        Me.CheckEdit2.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit2.Properties.ValueChecked = 1
        Me.CheckEdit2.Properties.ValueUnchecked = 0
        Me.CheckEdit2.Size = New System.Drawing.Size(108, 21)
        Me.CheckEdit2.TabIndex = 14
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(12, 128)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl13.TabIndex = 70
        Me.LabelControl13.Text = "Ilgili personel"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "PersonelID", True))
        Me.LookUpEdit1.EnterMoveNextControl = True
        Me.LookUpEdit1.Location = New System.Drawing.Point(103, 129)
        Me.LookUpEdit1.MenuManager = Me.BarManager1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaticiIsmi", "Satici Ismi", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaticiID", "Satici ID", 5, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit1.Properties.DataSource = Me.tbPersonel
        Me.LookUpEdit1.Properties.DisplayMember = "SaticiIsmi"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ShowHeader = False
        Me.LookUpEdit1.Properties.ValueMember = "SaticiID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(296, 22)
        Me.LookUpEdit1.TabIndex = 5
        '
        'cboHesap
        '
        Me.cboHesap.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Hesap", True))
        Me.cboHesap.EnterMoveNextControl = True
        Me.cboHesap.Location = New System.Drawing.Point(103, 99)
        Me.cboHesap.MenuManager = Me.BarManager1
        Me.cboHesap.Name = "cboHesap"
        Me.cboHesap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHesap.Size = New System.Drawing.Size(296, 22)
        Me.cboHesap.TabIndex = 4
        '
        'frmPlanlananTahsilatVeOdemeler
        '
        Me.ClientSize = New System.Drawing.Size(893, 545)
        Me.FormCode = "000029"
        Me.Name = "frmPlanlananTahsilatVeOdemeler"
        Me.Text = "Planlanan Tahsilatlar"
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
        CType(Me.chkGoster_Iptaller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGoster_Kapalilar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPersonel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CariUnvanButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CariKodButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDoviz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHesap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkGoster_Iptaller As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGoster_Kapalilar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MasterTable_nID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_Turu As System.Data.DataColumn
    Friend WithEvents MasterTable_Tarih As System.Data.DataColumn
    Friend WithEvents MasterTable_CariKod As System.Data.DataColumn
    Friend WithEvents MasterTable_CariUnvan As System.Data.DataColumn
    Friend WithEvents MasterTable_DigerUnvan As System.Data.DataColumn
    Friend WithEvents MasterTable_Hesap As System.Data.DataColumn
    Friend WithEvents MasterTable_TerminTarihi As System.Data.DataColumn
    Friend WithEvents MasterTable_PersonelID As System.Data.DataColumn
    Friend WithEvents MasterTable_Tutar As System.Data.DataColumn
    Friend WithEvents MasterTable_GelenTutar As System.Data.DataColumn
    Friend WithEvents MasterTable_DovizTipi As System.Data.DataColumn
    Friend WithEvents MasterTable_DovizKuru As System.Data.DataColumn
    Friend WithEvents MasterTable_TutarTL As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama As System.Data.DataColumn
    Friend WithEvents MasterTable_Kapali As System.Data.DataColumn
    Friend WithEvents MasterTable_KapanmaTarihi As System.Data.DataColumn
    Friend WithEvents MasterTable_Iptal As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colnID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDigerUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHesap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerminTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonelID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGelenTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutarTL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKapali As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKapanmaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIptal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbPersonel As NeoDAC.NeoTable
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CariUnvanButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CariKodButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboDoviz As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tbPersonel_SaticiID As System.Data.DataColumn
    Friend WithEvents tbPersonel_SaticiIsmi As System.Data.DataColumn
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboHesap As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand

End Class
