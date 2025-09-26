<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKumasKatalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKumasKatalog))
        Me.MasterTable_KumasKatalogID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_KatalogKod = New System.Data.DataColumn()
        Me.MasterTable_KatalogIsmi = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colKumasKatalogID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKatalogKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKatalogIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.KumasKatalogIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeletedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CreatedBySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CreatedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ModifiedBySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ModifiedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.KatalogKodTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KatalogIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IntCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForKumasKatalogID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCreatedBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCreatedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModifiedBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModifiedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForKatalogKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKatalogIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIntCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPasif = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
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
        CType(Me.dtFormDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.KumasKatalogIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KatalogKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KatalogIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKumasKatalogID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKatalogKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKatalogIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 104)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(893, 326)
        '
        'BaseTab1
        '
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(885, 218)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKumasKatalogID, Me.colKatalogKod, Me.colKatalogIsmi, Me.colIntCode, Me.colPasif})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KumasKatalogID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_KatalogKod, Me.MasterTable_KatalogIsmi, Me.MasterTable_IntCode, Me.MasterTable_Pasif})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KumasKatalogID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KumasKatalogID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'BaseTab4
        '
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
        'MasterTable_KumasKatalogID
        '
        Me.MasterTable_KumasKatalogID.AllowDBNull = False
        Me.MasterTable_KumasKatalogID.AutoIncrement = True
        Me.MasterTable_KumasKatalogID.ColumnName = "KumasKatalogID"
        Me.MasterTable_KumasKatalogID.DataType = GetType(Integer)
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
        'MasterTable_KatalogKod
        '
        Me.MasterTable_KatalogKod.ColumnName = "KatalogKod"
        '
        'MasterTable_KatalogIsmi
        '
        Me.MasterTable_KatalogIsmi.ColumnName = "KatalogIsmi"
        '
        'MasterTable_IntCode
        '
        Me.MasterTable_IntCode.ColumnName = "IntCode"
        '
        'MasterTable_Pasif
        '
        Me.MasterTable_Pasif.ColumnName = "Pasif"
        Me.MasterTable_Pasif.DataType = GetType(Integer)
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM KumasKatalogu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KumasKatalogID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KumasKatalogu SET Deleted = KumasKatalogID  , ModifiedBy = @ModifiedBy , M" & _
            "odifiedDate = GETDATE()   WHERE KumasKatalogID = @KumasKatalogID"
        '
        'colKumasKatalogID
        '
        Me.colKumasKatalogID.FieldName = "KumasKatalogID"
        Me.colKumasKatalogID.Name = "colKumasKatalogID"
        '
        'colKatalogKod
        '
        Me.colKatalogKod.FieldName = "KatalogKod"
        Me.colKatalogKod.Name = "colKatalogKod"
        Me.colKatalogKod.Visible = True
        Me.colKatalogKod.VisibleIndex = 0
        Me.colKatalogKod.Width = 105
        '
        'colKatalogIsmi
        '
        Me.colKatalogIsmi.FieldName = "KatalogIsmi"
        Me.colKatalogIsmi.Name = "colKatalogIsmi"
        Me.colKatalogIsmi.Visible = True
        Me.colKatalogIsmi.VisibleIndex = 1
        Me.colKatalogIsmi.Width = 243
        '
        'colIntCode
        '
        Me.colIntCode.FieldName = "IntCode"
        Me.colIntCode.Name = "colIntCode"
        Me.colIntCode.Visible = True
        Me.colIntCode.VisibleIndex = 2
        '
        'colPasif
        '
        Me.colPasif.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colPasif.FieldName = "Pasif"
        Me.colPasif.Name = "colPasif"
        Me.colPasif.Visible = True
        Me.colPasif.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.KumasKatalogIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeletedSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CreatedBySpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CreatedDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModifiedBySpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModifiedDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KatalogKodTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KatalogIsmiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IntCodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasifCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKumasKatalogID, Me.ItemForDeleted, Me.ItemForCreatedBy, Me.ItemForCreatedDate, Me.ItemForModifiedBy, Me.ItemForModifiedDate})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1165, 349, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(885, 298)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'KumasKatalogIDSpinEdit
        '
        Me.KumasKatalogIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KumasKatalogID", True))
        Me.KumasKatalogIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.KumasKatalogIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.KumasKatalogIDSpinEdit.MenuManager = Me.BarManager1
        Me.KumasKatalogIDSpinEdit.Name = "KumasKatalogIDSpinEdit"
        Me.KumasKatalogIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.KumasKatalogIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.KumasKatalogIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.KumasKatalogIDSpinEdit.TabIndex = 4
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
        Me.DeletedSpinEdit.TabIndex = 5
        '
        'CreatedBySpinEdit
        '
        Me.CreatedBySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CreatedBy", True))
        Me.CreatedBySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CreatedBySpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.CreatedBySpinEdit.MenuManager = Me.BarManager1
        Me.CreatedBySpinEdit.Name = "CreatedBySpinEdit"
        Me.CreatedBySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CreatedBySpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.CreatedBySpinEdit.StyleController = Me.DataLayoutControl1
        Me.CreatedBySpinEdit.TabIndex = 6
        '
        'CreatedDateDateEdit
        '
        Me.CreatedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CreatedDate", True))
        Me.CreatedDateDateEdit.EditValue = Nothing
        Me.CreatedDateDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.CreatedDateDateEdit.MenuManager = Me.BarManager1
        Me.CreatedDateDateEdit.Name = "CreatedDateDateEdit"
        Me.CreatedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CreatedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CreatedDateDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.CreatedDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.CreatedDateDateEdit.TabIndex = 7
        '
        'ModifiedBySpinEdit
        '
        Me.ModifiedBySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "ModifiedBy", True))
        Me.ModifiedBySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ModifiedBySpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.ModifiedBySpinEdit.MenuManager = Me.BarManager1
        Me.ModifiedBySpinEdit.Name = "ModifiedBySpinEdit"
        Me.ModifiedBySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ModifiedBySpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.ModifiedBySpinEdit.StyleController = Me.DataLayoutControl1
        Me.ModifiedBySpinEdit.TabIndex = 8
        '
        'ModifiedDateDateEdit
        '
        Me.ModifiedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "ModifiedDate", True))
        Me.ModifiedDateDateEdit.EditValue = Nothing
        Me.ModifiedDateDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.ModifiedDateDateEdit.MenuManager = Me.BarManager1
        Me.ModifiedDateDateEdit.Name = "ModifiedDateDateEdit"
        Me.ModifiedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifiedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ModifiedDateDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.ModifiedDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.ModifiedDateDateEdit.TabIndex = 9
        '
        'KatalogKodTextEdit
        '
        Me.KatalogKodTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KatalogKod", True))
        Me.KatalogKodTextEdit.EnterMoveNextControl = True
        Me.KatalogKodTextEdit.Location = New System.Drawing.Point(68, 5)
        Me.KatalogKodTextEdit.MenuManager = Me.BarManager1
        Me.KatalogKodTextEdit.Name = "KatalogKodTextEdit"
        Me.KatalogKodTextEdit.Size = New System.Drawing.Size(158, 20)
        Me.KatalogKodTextEdit.StyleController = Me.DataLayoutControl1
        Me.KatalogKodTextEdit.TabIndex = 10
        '
        'KatalogIsmiTextEdit
        '
        Me.KatalogIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KatalogIsmi", True))
        Me.KatalogIsmiTextEdit.EnterMoveNextControl = True
        Me.KatalogIsmiTextEdit.Location = New System.Drawing.Point(68, 35)
        Me.KatalogIsmiTextEdit.MenuManager = Me.BarManager1
        Me.KatalogIsmiTextEdit.Name = "KatalogIsmiTextEdit"
        Me.KatalogIsmiTextEdit.Size = New System.Drawing.Size(390, 20)
        Me.KatalogIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.KatalogIsmiTextEdit.TabIndex = 11
        '
        'IntCodeTextEdit
        '
        Me.IntCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IntCode", True))
        Me.IntCodeTextEdit.EnterMoveNextControl = True
        Me.IntCodeTextEdit.Location = New System.Drawing.Point(68, 65)
        Me.IntCodeTextEdit.MenuManager = Me.BarManager1
        Me.IntCodeTextEdit.Name = "IntCodeTextEdit"
        Me.IntCodeTextEdit.Size = New System.Drawing.Size(390, 20)
        Me.IntCodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.IntCodeTextEdit.TabIndex = 12
        '
        'PasifCheckEdit
        '
        Me.PasifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Pasif", True))
        Me.PasifCheckEdit.EnterMoveNextControl = True
        Me.PasifCheckEdit.Location = New System.Drawing.Point(5, 95)
        Me.PasifCheckEdit.MenuManager = Me.BarManager1
        Me.PasifCheckEdit.Name = "PasifCheckEdit"
        Me.PasifCheckEdit.Properties.Caption = "Pasif"
        Me.PasifCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PasifCheckEdit.Properties.ValueChecked = 1
        Me.PasifCheckEdit.Properties.ValueUnchecked = 0
        Me.PasifCheckEdit.Size = New System.Drawing.Size(453, 18)
        Me.PasifCheckEdit.StyleController = Me.DataLayoutControl1
        Me.PasifCheckEdit.TabIndex = 13
        '
        'ItemForKumasKatalogID
        '
        Me.ItemForKumasKatalogID.Control = Me.KumasKatalogIDSpinEdit
        Me.ItemForKumasKatalogID.CustomizationFormText = "Kumas Katalog ID"
        Me.ItemForKumasKatalogID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKumasKatalogID.Name = "ItemForKumasKatalogID"
        Me.ItemForKumasKatalogID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForKumasKatalogID.Text = "Kumas Katalog ID"
        Me.ItemForKumasKatalogID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForKumasKatalogID.TextToControlDistance = 5
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
        Me.ItemForDeleted.TextToControlDistance = 5
        '
        'ItemForCreatedBy
        '
        Me.ItemForCreatedBy.Control = Me.CreatedBySpinEdit
        Me.ItemForCreatedBy.CustomizationFormText = "Created By"
        Me.ItemForCreatedBy.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCreatedBy.Name = "ItemForCreatedBy"
        Me.ItemForCreatedBy.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCreatedBy.Text = "Created By"
        Me.ItemForCreatedBy.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCreatedBy.TextToControlDistance = 5
        '
        'ItemForCreatedDate
        '
        Me.ItemForCreatedDate.Control = Me.CreatedDateDateEdit
        Me.ItemForCreatedDate.CustomizationFormText = "Created Date"
        Me.ItemForCreatedDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCreatedDate.Name = "ItemForCreatedDate"
        Me.ItemForCreatedDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCreatedDate.Text = "Created Date"
        Me.ItemForCreatedDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCreatedDate.TextToControlDistance = 5
        '
        'ItemForModifiedBy
        '
        Me.ItemForModifiedBy.Control = Me.ModifiedBySpinEdit
        Me.ItemForModifiedBy.CustomizationFormText = "Modified By"
        Me.ItemForModifiedBy.Location = New System.Drawing.Point(0, 0)
        Me.ItemForModifiedBy.Name = "ItemForModifiedBy"
        Me.ItemForModifiedBy.Size = New System.Drawing.Size(0, 0)
        Me.ItemForModifiedBy.Text = "Modified By"
        Me.ItemForModifiedBy.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForModifiedBy.TextToControlDistance = 5
        '
        'ItemForModifiedDate
        '
        Me.ItemForModifiedDate.Control = Me.ModifiedDateDateEdit
        Me.ItemForModifiedDate.CustomizationFormText = "Modified Date"
        Me.ItemForModifiedDate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForModifiedDate.Name = "ItemForModifiedDate"
        Me.ItemForModifiedDate.Size = New System.Drawing.Size(0, 0)
        Me.ItemForModifiedDate.Text = "Modified Date"
        Me.ItemForModifiedDate.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForModifiedDate.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(885, 298)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKatalogKod, Me.ItemForKatalogIsmi, Me.ItemForIntCode, Me.ItemForPasif, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(885, 298)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForKatalogKod
        '
        Me.ItemForKatalogKod.Control = Me.KatalogKodTextEdit
        Me.ItemForKatalogKod.CustomizationFormText = "Katalog Kod"
        Me.ItemForKatalogKod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKatalogKod.Name = "ItemForKatalogKod"
        Me.ItemForKatalogKod.Size = New System.Drawing.Size(231, 30)
        Me.ItemForKatalogKod.Text = "Katalog Kod"
        Me.ItemForKatalogKod.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForKatalogKod.TextToControlDistance = 5
        '
        'ItemForKatalogIsmi
        '
        Me.ItemForKatalogIsmi.Control = Me.KatalogIsmiTextEdit
        Me.ItemForKatalogIsmi.CustomizationFormText = "Katalog Ismi"
        Me.ItemForKatalogIsmi.Location = New System.Drawing.Point(0, 30)
        Me.ItemForKatalogIsmi.Name = "ItemForKatalogIsmi"
        Me.ItemForKatalogIsmi.Size = New System.Drawing.Size(463, 30)
        Me.ItemForKatalogIsmi.Text = "Katalog Ismi"
        Me.ItemForKatalogIsmi.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForKatalogIsmi.TextToControlDistance = 5
        '
        'ItemForIntCode
        '
        Me.ItemForIntCode.Control = Me.IntCodeTextEdit
        Me.ItemForIntCode.CustomizationFormText = "Int Code"
        Me.ItemForIntCode.Location = New System.Drawing.Point(0, 60)
        Me.ItemForIntCode.Name = "ItemForIntCode"
        Me.ItemForIntCode.Size = New System.Drawing.Size(463, 30)
        Me.ItemForIntCode.Text = "Int Code"
        Me.ItemForIntCode.TextSize = New System.Drawing.Size(58, 13)
        Me.ItemForIntCode.TextToControlDistance = 5
        '
        'ItemForPasif
        '
        Me.ItemForPasif.Control = Me.PasifCheckEdit
        Me.ItemForPasif.CustomizationFormText = "Pasif"
        Me.ItemForPasif.Location = New System.Drawing.Point(0, 90)
        Me.ItemForPasif.Name = "ItemForPasif"
        Me.ItemForPasif.Size = New System.Drawing.Size(463, 208)
        Me.ItemForPasif.Text = "Pasif"
        Me.ItemForPasif.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForPasif.TextToControlDistance = 0
        Me.ItemForPasif.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(463, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(422, 298)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(231, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(232, 30)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmKumasKatalog
        '
        Me.ClientSize = New System.Drawing.Size(893, 491)
        Me.FormCode = "000013"
        Me.Name = "frmKumasKatalog"
        Me.Text = "Kumas Katalog"
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
        CType(Me.dtFormDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.KumasKatalogIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KatalogKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KatalogIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKumasKatalogID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKatalogKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKatalogIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MasterTable_KumasKatalogID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_KatalogKod As System.Data.DataColumn
    Friend WithEvents MasterTable_KatalogIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents KumasKatalogIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeletedSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CreatedBySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CreatedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ModifiedBySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ModifiedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents KatalogKodTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KatalogIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IntCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasifCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForKumasKatalogID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreatedBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreatedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModifiedBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModifiedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForKatalogKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKatalogIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIntCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPasif As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colKumasKatalogID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKatalogKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKatalogIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn

End Class
