<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrguTipi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrguTipi))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colOrguTipID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrguTipKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrguTipIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.OrguTipIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OrguTipKodTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrguTipIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IntCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForOrguTipID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForOrguTipKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOrguTipIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIntCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPasif = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenArtis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterTable_OrguTipID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_OrguTipKod = New System.Data.DataColumn()
        Me.MasterTable_OrguTipIsmi = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
        Me.MasterTable_Fiyat = New System.Data.DataColumn()
        Me.MasterTable_BedenArtis = New System.Data.DataColumn()
        Me.MasterTable_bLakos = New System.Data.DataColumn()
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrguTipIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrguTipKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrguTipIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrguTipID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrguTipKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrguTipIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(498, 63)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 406)
        Me.barDockControlBottom.Size = New System.Drawing.Size(498, 20)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 343)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(498, 63)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 343)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 114)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(498, 251)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(490, 223)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(490, 223)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(490, 143)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrguTipID, Me.colOrguTipKod, Me.colOrguTipIsmi, Me.colIntCode, Me.colPasif, Me.colFiyat, Me.colBedenArtis})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'panelBottom
        '
        Me.panelBottom.Location = New System.Drawing.Point(0, 365)
        Me.panelBottom.Size = New System.Drawing.Size(498, 41)
        '
        'PanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(298, 4)
        '
        'panelFormTop
        '
        Me.panelFormTop.Location = New System.Drawing.Point(0, 83)
        Me.panelFormTop.Size = New System.Drawing.Size(498, 31)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_OrguTipID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_OrguTipKod, Me.MasterTable_OrguTipIsmi, Me.MasterTable_IntCode, Me.MasterTable_Pasif, Me.MasterTable_Fiyat, Me.MasterTable_BedenArtis, Me.MasterTable_bLakos})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"OrguTipID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_OrguTipID}
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
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(498, 20)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 204)
        Me.lblMainWarning1.Size = New System.Drawing.Size(490, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 197)
        Me.panelAuthCodes.Size = New System.Drawing.Size(490, 26)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(490, 61)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM OrguTipleri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_OrguTipID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE OrguTipleri SET Deleted = OrguTipID  , ModifiedBy = @ModifiedBy , Modified" & _
            "Date = GETDATE()   WHERE OrguTipID = @OrguTipID"
        '
        'colOrguTipID
        '
        Me.colOrguTipID.FieldName = "OrguTipID"
        Me.colOrguTipID.Name = "colOrguTipID"
        '
        'colOrguTipKod
        '
        Me.colOrguTipKod.FieldName = "OrguTipKod"
        Me.colOrguTipKod.Name = "colOrguTipKod"
        Me.colOrguTipKod.Visible = True
        Me.colOrguTipKod.VisibleIndex = 0
        Me.colOrguTipKod.Width = 115
        '
        'colOrguTipIsmi
        '
        Me.colOrguTipIsmi.FieldName = "OrguTipIsmi"
        Me.colOrguTipIsmi.Name = "colOrguTipIsmi"
        Me.colOrguTipIsmi.Visible = True
        Me.colOrguTipIsmi.VisibleIndex = 1
        Me.colOrguTipIsmi.Width = 192
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
        Me.colPasif.FieldName = "Pasif"
        Me.colPasif.Name = "colPasif"
        Me.colPasif.Visible = True
        Me.colPasif.VisibleIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.OrguTipIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OrguTipKodTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OrguTipIsmiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IntCodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasifCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOrguTipID})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1023, 187, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(490, 223)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Fiyat", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(73, 65)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 9
        '
        'OrguTipIDSpinEdit
        '
        Me.OrguTipIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OrguTipID", True))
        Me.OrguTipIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OrguTipIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.OrguTipIDSpinEdit.MenuManager = Me.BarManager1
        Me.OrguTipIDSpinEdit.Name = "OrguTipIDSpinEdit"
        Me.OrguTipIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrguTipIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.OrguTipIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.OrguTipIDSpinEdit.TabIndex = 4
        '
        'OrguTipKodTextEdit
        '
        Me.OrguTipKodTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OrguTipKod", True))
        Me.OrguTipKodTextEdit.EnterMoveNextControl = True
        Me.OrguTipKodTextEdit.Location = New System.Drawing.Point(73, 5)
        Me.OrguTipKodTextEdit.MenuManager = Me.BarManager1
        Me.OrguTipKodTextEdit.Name = "OrguTipKodTextEdit"
        Me.OrguTipKodTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.OrguTipKodTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrguTipKodTextEdit.TabIndex = 5
        '
        'OrguTipIsmiTextEdit
        '
        Me.OrguTipIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OrguTipIsmi", True))
        Me.OrguTipIsmiTextEdit.EnterMoveNextControl = True
        Me.OrguTipIsmiTextEdit.Location = New System.Drawing.Point(73, 35)
        Me.OrguTipIsmiTextEdit.MenuManager = Me.BarManager1
        Me.OrguTipIsmiTextEdit.Name = "OrguTipIsmiTextEdit"
        Me.OrguTipIsmiTextEdit.Size = New System.Drawing.Size(305, 20)
        Me.OrguTipIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrguTipIsmiTextEdit.TabIndex = 6
        '
        'IntCodeTextEdit
        '
        Me.IntCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IntCode", True))
        Me.IntCodeTextEdit.EnterMoveNextControl = True
        Me.IntCodeTextEdit.Location = New System.Drawing.Point(73, 95)
        Me.IntCodeTextEdit.MenuManager = Me.BarManager1
        Me.IntCodeTextEdit.Name = "IntCodeTextEdit"
        Me.IntCodeTextEdit.Size = New System.Drawing.Size(412, 20)
        Me.IntCodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.IntCodeTextEdit.TabIndex = 7
        '
        'PasifCheckEdit
        '
        Me.PasifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Pasif", True))
        Me.PasifCheckEdit.EnterMoveNextControl = True
        Me.PasifCheckEdit.Location = New System.Drawing.Point(5, 125)
        Me.PasifCheckEdit.MenuManager = Me.BarManager1
        Me.PasifCheckEdit.Name = "PasifCheckEdit"
        Me.PasifCheckEdit.Properties.Caption = "Pasif"
        Me.PasifCheckEdit.Size = New System.Drawing.Size(480, 18)
        Me.PasifCheckEdit.StyleController = Me.DataLayoutControl1
        Me.PasifCheckEdit.TabIndex = 8
        '
        'ItemForOrguTipID
        '
        Me.ItemForOrguTipID.Control = Me.OrguTipIDSpinEdit
        Me.ItemForOrguTipID.CustomizationFormText = "Orgu Tip ID"
        Me.ItemForOrguTipID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOrguTipID.Name = "ItemForOrguTipID"
        Me.ItemForOrguTipID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOrguTipID.Text = "Orgu Tip ID"
        Me.ItemForOrguTipID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForOrguTipID.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(490, 223)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOrguTipKod, Me.ItemForOrguTipIsmi, Me.ItemForIntCode, Me.ItemForPasif, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(490, 223)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForOrguTipKod
        '
        Me.ItemForOrguTipKod.Control = Me.OrguTipKodTextEdit
        Me.ItemForOrguTipKod.CustomizationFormText = "Orgu Tip Kod"
        Me.ItemForOrguTipKod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOrguTipKod.Name = "ItemForOrguTipKod"
        Me.ItemForOrguTipKod.Size = New System.Drawing.Size(278, 30)
        Me.ItemForOrguTipKod.Text = "Orgu Tip Kod"
        Me.ItemForOrguTipKod.TextSize = New System.Drawing.Size(63, 13)
        Me.ItemForOrguTipKod.TextToControlDistance = 5
        '
        'ItemForOrguTipIsmi
        '
        Me.ItemForOrguTipIsmi.Control = Me.OrguTipIsmiTextEdit
        Me.ItemForOrguTipIsmi.CustomizationFormText = "Orgu Tip Ismi"
        Me.ItemForOrguTipIsmi.Location = New System.Drawing.Point(0, 30)
        Me.ItemForOrguTipIsmi.Name = "ItemForOrguTipIsmi"
        Me.ItemForOrguTipIsmi.Size = New System.Drawing.Size(383, 30)
        Me.ItemForOrguTipIsmi.Text = "Orgu Tip Ismi"
        Me.ItemForOrguTipIsmi.TextSize = New System.Drawing.Size(63, 13)
        Me.ItemForOrguTipIsmi.TextToControlDistance = 5
        '
        'ItemForIntCode
        '
        Me.ItemForIntCode.Control = Me.IntCodeTextEdit
        Me.ItemForIntCode.CustomizationFormText = "Int Code"
        Me.ItemForIntCode.Location = New System.Drawing.Point(0, 90)
        Me.ItemForIntCode.Name = "ItemForIntCode"
        Me.ItemForIntCode.Size = New System.Drawing.Size(490, 30)
        Me.ItemForIntCode.Text = "Int Code"
        Me.ItemForIntCode.TextSize = New System.Drawing.Size(63, 13)
        Me.ItemForIntCode.TextToControlDistance = 5
        '
        'ItemForPasif
        '
        Me.ItemForPasif.Control = Me.PasifCheckEdit
        Me.ItemForPasif.CustomizationFormText = "Pasif"
        Me.ItemForPasif.Location = New System.Drawing.Point(0, 120)
        Me.ItemForPasif.Name = "ItemForPasif"
        Me.ItemForPasif.Size = New System.Drawing.Size(490, 103)
        Me.ItemForPasif.Text = "Pasif"
        Me.ItemForPasif.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForPasif.TextToControlDistance = 0
        Me.ItemForPasif.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(278, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(212, 30)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(383, 30)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(107, 30)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Fiyat Farki"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(215, 30)
        Me.LayoutControlItem1.Text = "Fiyat Farki"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(63, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(215, 60)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(275, 30)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'colFiyat
        '
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 4
        '
        'colBedenArtis
        '
        Me.colBedenArtis.FieldName = "BedenArtis"
        Me.colBedenArtis.Name = "colBedenArtis"
        '
        'MasterTable_OrguTipID
        '
        Me.MasterTable_OrguTipID.AllowDBNull = False
        Me.MasterTable_OrguTipID.AutoIncrement = True
        Me.MasterTable_OrguTipID.ColumnName = "OrguTipID"
        Me.MasterTable_OrguTipID.DataType = GetType(Integer)
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
        'MasterTable_OrguTipKod
        '
        Me.MasterTable_OrguTipKod.ColumnName = "OrguTipKod"
        '
        'MasterTable_OrguTipIsmi
        '
        Me.MasterTable_OrguTipIsmi.ColumnName = "OrguTipIsmi"
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
        'MasterTable_Fiyat
        '
        Me.MasterTable_Fiyat.ColumnName = "Fiyat"
        Me.MasterTable_Fiyat.DataType = GetType(Double)
        '
        'MasterTable_BedenArtis
        '
        Me.MasterTable_BedenArtis.ColumnName = "BedenArtis"
        Me.MasterTable_BedenArtis.DataType = GetType(Double)
        '
        'MasterTable_bLakos
        '
        Me.MasterTable_bLakos.ColumnName = "bLakos"
        Me.MasterTable_bLakos.DataType = GetType(Integer)
        '
        'frmOrguTipi
        '
        Me.ClientSize = New System.Drawing.Size(498, 426)
        Me.FormCode = "000002"
        Me.Name = "frmOrguTipi"
        Me.Text = "Orgu Tipleri"
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrguTipIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrguTipKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrguTipIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrguTipID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrguTipKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrguTipIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents OrguTipIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OrguTipKodTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrguTipIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IntCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasifCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForOrguTipID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForOrguTipKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOrguTipIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIntCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPasif As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colOrguTipID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrguTipKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrguTipIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenArtis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterTable_OrguTipID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_OrguTipKod As System.Data.DataColumn
    Friend WithEvents MasterTable_OrguTipIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn
    Friend WithEvents MasterTable_Fiyat As System.Data.DataColumn
    Friend WithEvents MasterTable_BedenArtis As System.Data.DataColumn
    Friend WithEvents MasterTable_bLakos As System.Data.DataColumn

End Class
