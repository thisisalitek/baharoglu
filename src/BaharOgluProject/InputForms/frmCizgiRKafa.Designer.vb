<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCizgiRKafa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCizgiRKafa))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colCizgiRKafaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCizgiSayisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRKafa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.CizgiRKafaIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TipComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.AciklamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RKafaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForCizgiRKafaID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForTip = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAciklama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRKafa = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MasterTable_CizgiRKafaID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_Tip = New System.Data.DataColumn()
        Me.MasterTable_Aciklama = New System.Data.DataColumn()
        Me.MasterTable_CizgiSayisi = New System.Data.DataColumn()
        Me.MasterTable_RKafa = New System.Data.DataColumn()
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
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CizgiRKafaIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AciklamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RKafaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCizgiRKafaID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRKafa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.DockRow = 0
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        '
        'Bar2
        '
        Me.Bar2.DockRow = 1
        Me.Bar2.FloatLocation = New System.Drawing.Point(350, 161)
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
        Me.GridControl1.Size = New System.Drawing.Size(885, 218)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCizgiRKafaID, Me.colTip, Me.colAciklama, Me.colCizgiSayisi, Me.colRKafa})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_CizgiRKafaID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_Tip, Me.MasterTable_Aciklama, Me.MasterTable_CizgiSayisi, Me.MasterTable_RKafa})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"CizgiRKafaID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_CizgiRKafaID}
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
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM CizgiRenkKafa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_CizgiRKafaID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE CizgiRenkKafa SET Deleted = CizgiRKafaID  , ModifiedBy = @ModifiedBy , Mod" & _
            "ifiedDate = GETDATE()   WHERE CizgiRKafaID = @CizgiRKafaID"
        '
        'colCizgiRKafaID
        '
        Me.colCizgiRKafaID.FieldName = "CizgiRKafaID"
        Me.colCizgiRKafaID.Name = "colCizgiRKafaID"
        '
        'colTip
        '
        Me.colTip.FieldName = "Tip"
        Me.colTip.Name = "colTip"
        Me.colTip.Visible = True
        Me.colTip.VisibleIndex = 0
        Me.colTip.Width = 104
        '
        'colAciklama
        '
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 1
        Me.colAciklama.Width = 136
        '
        'colCizgiSayisi
        '
        Me.colCizgiSayisi.FieldName = "CizgiSayisi"
        Me.colCizgiSayisi.Name = "colCizgiSayisi"
        Me.colCizgiSayisi.Visible = True
        Me.colCizgiSayisi.VisibleIndex = 2
        Me.colCizgiSayisi.Width = 78
        '
        'colRKafa
        '
        Me.colRKafa.FieldName = "RKafa"
        Me.colRKafa.Name = "colRKafa"
        Me.colRKafa.Visible = True
        Me.colRKafa.VisibleIndex = 3
        Me.colRKafa.Width = 390
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.SpinEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.CizgiRKafaIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TipComboBoxEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AciklamaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RKafaTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCizgiRKafaID})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(512, 266, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(885, 298)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CizgiSayisi", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.EnterMoveNextControl = True
        Me.SpinEdit1.Location = New System.Drawing.Point(61, 65)
        Me.SpinEdit1.MenuManager = Me.BarManager1
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.IsFloatValue = False
        Me.SpinEdit1.Properties.Mask.EditMask = "N00"
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.SpinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(104, 20)
        Me.SpinEdit1.StyleController = Me.DataLayoutControl1
        Me.SpinEdit1.TabIndex = 0
        '
        'CizgiRKafaIDSpinEdit
        '
        Me.CizgiRKafaIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CizgiRKafaID", True))
        Me.CizgiRKafaIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CizgiRKafaIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.CizgiRKafaIDSpinEdit.MenuManager = Me.BarManager1
        Me.CizgiRKafaIDSpinEdit.Name = "CizgiRKafaIDSpinEdit"
        Me.CizgiRKafaIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CizgiRKafaIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.CizgiRKafaIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CizgiRKafaIDSpinEdit.TabIndex = 4
        '
        'TipComboBoxEdit
        '
        Me.TipComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Tip", True))
        Me.TipComboBoxEdit.EnterMoveNextControl = True
        Me.TipComboBoxEdit.Location = New System.Drawing.Point(61, 5)
        Me.TipComboBoxEdit.MenuManager = Me.BarManager1
        Me.TipComboBoxEdit.Name = "TipComboBoxEdit"
        Me.TipComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TipComboBoxEdit.Properties.Items.AddRange(New Object() {"LASTIK", "TORBALI BANT", "YAKA", "DUBLE YAKA", "DUBLE LASTIK", "DUBLE LASTIK CEP", "DUBLE LASTIK PILOT YAKA"})
        Me.TipComboBoxEdit.Size = New System.Drawing.Size(274, 20)
        Me.TipComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.TipComboBoxEdit.TabIndex = 5
        '
        'AciklamaTextEdit
        '
        Me.AciklamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Aciklama", True))
        Me.AciklamaTextEdit.EnterMoveNextControl = True
        Me.AciklamaTextEdit.Location = New System.Drawing.Point(61, 35)
        Me.AciklamaTextEdit.MenuManager = Me.BarManager1
        Me.AciklamaTextEdit.Name = "AciklamaTextEdit"
        Me.AciklamaTextEdit.Size = New System.Drawing.Size(334, 20)
        Me.AciklamaTextEdit.StyleController = Me.DataLayoutControl1
        Me.AciklamaTextEdit.TabIndex = 6
        '
        'RKafaTextEdit
        '
        Me.RKafaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "RKafa", True))
        Me.RKafaTextEdit.EnterMoveNextControl = True
        Me.RKafaTextEdit.Location = New System.Drawing.Point(61, 95)
        Me.RKafaTextEdit.MenuManager = Me.BarManager1
        Me.RKafaTextEdit.Name = "RKafaTextEdit"
        Me.RKafaTextEdit.Size = New System.Drawing.Size(819, 20)
        Me.RKafaTextEdit.StyleController = Me.DataLayoutControl1
        Me.RKafaTextEdit.TabIndex = 8
        '
        'ItemForCizgiRKafaID
        '
        Me.ItemForCizgiRKafaID.Control = Me.CizgiRKafaIDSpinEdit
        Me.ItemForCizgiRKafaID.CustomizationFormText = "Cizgi RKafa ID"
        Me.ItemForCizgiRKafaID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCizgiRKafaID.Name = "ItemForCizgiRKafaID"
        Me.ItemForCizgiRKafaID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCizgiRKafaID.Text = "Cizgi RKafa ID"
        Me.ItemForCizgiRKafaID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCizgiRKafaID.TextToControlDistance = 5
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
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTip, Me.ItemForAciklama, Me.ItemForRKafa, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(885, 298)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForTip
        '
        Me.ItemForTip.Control = Me.TipComboBoxEdit
        Me.ItemForTip.CustomizationFormText = "Tip"
        Me.ItemForTip.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTip.Name = "ItemForTip"
        Me.ItemForTip.Size = New System.Drawing.Size(340, 30)
        Me.ItemForTip.Text = "Tip"
        Me.ItemForTip.TextSize = New System.Drawing.Size(51, 13)
        Me.ItemForTip.TextToControlDistance = 5
        '
        'ItemForAciklama
        '
        Me.ItemForAciklama.Control = Me.AciklamaTextEdit
        Me.ItemForAciklama.CustomizationFormText = "Aciklama"
        Me.ItemForAciklama.Location = New System.Drawing.Point(0, 30)
        Me.ItemForAciklama.Name = "ItemForAciklama"
        Me.ItemForAciklama.Size = New System.Drawing.Size(400, 30)
        Me.ItemForAciklama.Text = "Aciklama"
        Me.ItemForAciklama.TextSize = New System.Drawing.Size(51, 13)
        Me.ItemForAciklama.TextToControlDistance = 5
        '
        'ItemForRKafa
        '
        Me.ItemForRKafa.Control = Me.RKafaTextEdit
        Me.ItemForRKafa.CustomizationFormText = "RKafa"
        Me.ItemForRKafa.Location = New System.Drawing.Point(0, 90)
        Me.ItemForRKafa.Name = "ItemForRKafa"
        Me.ItemForRKafa.Size = New System.Drawing.Size(885, 208)
        Me.ItemForRKafa.Text = "RKafa"
        Me.ItemForRKafa.TextSize = New System.Drawing.Size(51, 13)
        Me.ItemForRKafa.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(340, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(545, 30)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(170, 60)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(715, 30)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(400, 30)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(485, 30)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SpinEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Çizgi sayısı"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(170, 30)
        Me.LayoutControlItem1.Text = "Çizgi sayısı"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(51, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'MasterTable_CizgiRKafaID
        '
        Me.MasterTable_CizgiRKafaID.AllowDBNull = False
        Me.MasterTable_CizgiRKafaID.AutoIncrement = True
        Me.MasterTable_CizgiRKafaID.ColumnName = "CizgiRKafaID"
        Me.MasterTable_CizgiRKafaID.DataType = GetType(Integer)
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
        'MasterTable_Tip
        '
        Me.MasterTable_Tip.ColumnName = "Tip"
        '
        'MasterTable_Aciklama
        '
        Me.MasterTable_Aciklama.ColumnName = "Aciklama"
        '
        'MasterTable_CizgiSayisi
        '
        Me.MasterTable_CizgiSayisi.ColumnName = "CizgiSayisi"
        Me.MasterTable_CizgiSayisi.DataType = GetType(Integer)
        '
        'MasterTable_RKafa
        '
        Me.MasterTable_RKafa.ColumnName = "RKafa"
        '
        'frmCizgiRKafa
        '
        Me.ClientSize = New System.Drawing.Size(893, 491)
        Me.FormCode = "000009"
        Me.Name = "frmCizgiRKafa"
        Me.Text = "Çizgi Renk Kafa"
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
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CizgiRKafaIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AciklamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RKafaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCizgiRKafaID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRKafa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CizgiRKafaIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TipComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents AciklamaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RKafaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForCizgiRKafaID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForTip As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAciklama As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRKafa As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCizgiRKafaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCizgiSayisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRKafa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents MasterTable_CizgiRKafaID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_Tip As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama As System.Data.DataColumn
    Friend WithEvents MasterTable_CizgiSayisi As System.Data.DataColumn
    Friend WithEvents MasterTable_RKafa As System.Data.DataColumn

End Class
