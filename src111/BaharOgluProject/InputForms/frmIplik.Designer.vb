<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIplik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIplik))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colIplikID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIplikKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIplikIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.IplikIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IplikKodTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IplikIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IntCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForIplikID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForIplikKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIplikIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIntCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPasif = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colStokFiltre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterTable_IplikID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_IplikKod = New System.Data.DataColumn()
        Me.MasterTable_IplikIsmi = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
        Me.MasterTable_StokFiltre = New System.Data.DataColumn()
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IplikIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IplikKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IplikIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIplikID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIplikKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIplikIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(560, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 423)
        Me.barDockControlBottom.Size = New System.Drawing.Size(560, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 356)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(560, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 356)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 124)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(560, 258)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(554, 230)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(554, 230)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(554, 150)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIplikID, Me.colIplikKod, Me.colIplikIsmi, Me.colIntCode, Me.colPasif, Me.colStokFiltre})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 382)
        Me.panelBottom.Size = New System.Drawing.Size(560, 41)
        '
        'basePanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(362, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Location = New System.Drawing.Point(0, 87)
        Me.panelFormTop.Size = New System.Drawing.Size(560, 37)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_IplikID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_IplikKod, Me.MasterTable_IplikIsmi, Me.MasterTable_IntCode, Me.MasterTable_Pasif, Me.MasterTable_StokFiltre})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"IplikID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_IplikID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(893, 289)
        Me.BaseTab4.Tag = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(560, 20)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 211)
        Me.lblMainWarning1.Size = New System.Drawing.Size(554, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 204)
        Me.panelAuthCodes.Size = New System.Drawing.Size(554, 26)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(554, 61)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM Iplikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_IplikID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Iplikler SET Deleted = IplikID  , ModifiedBy = @ModifiedBy , ModifiedDate " &
    "= GETDATE()   WHERE IplikID = @IplikID"
        '
        'colIplikID
        '
        Me.colIplikID.FieldName = "IplikID"
        Me.colIplikID.Name = "colIplikID"
        '
        'colIplikKod
        '
        Me.colIplikKod.FieldName = "IplikKod"
        Me.colIplikKod.Name = "colIplikKod"
        Me.colIplikKod.Visible = True
        Me.colIplikKod.VisibleIndex = 0
        '
        'colIplikIsmi
        '
        Me.colIplikIsmi.FieldName = "IplikIsmi"
        Me.colIplikIsmi.Name = "colIplikIsmi"
        Me.colIplikIsmi.Visible = True
        Me.colIplikIsmi.VisibleIndex = 1
        Me.colIplikIsmi.Width = 229
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
        Me.DataLayoutControl1.Controls.Add(Me.IplikIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IplikKodTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IplikIsmiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IntCodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasifCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIplikID})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(877, 258, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(554, 230)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "StokFiltre", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(95, 60)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(447, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 6
        '
        'IplikIDSpinEdit
        '
        Me.IplikIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IplikID", True))
        Me.IplikIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IplikIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.IplikIDSpinEdit.MenuManager = Me.BarManager1
        Me.IplikIDSpinEdit.Name = "IplikIDSpinEdit"
        Me.IplikIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IplikIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.IplikIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.IplikIDSpinEdit.TabIndex = 4
        '
        'IplikKodTextEdit
        '
        Me.IplikKodTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IplikKod", True))
        Me.IplikKodTextEdit.EnterMoveNextControl = True
        Me.IplikKodTextEdit.Location = New System.Drawing.Point(95, 12)
        Me.IplikKodTextEdit.MenuManager = Me.BarManager1
        Me.IplikKodTextEdit.Name = "IplikKodTextEdit"
        Me.IplikKodTextEdit.Size = New System.Drawing.Size(152, 20)
        Me.IplikKodTextEdit.StyleController = Me.DataLayoutControl1
        Me.IplikKodTextEdit.TabIndex = 5
        '
        'IplikIsmiTextEdit
        '
        Me.IplikIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IplikIsmi", True))
        Me.IplikIsmiTextEdit.EnterMoveNextControl = True
        Me.IplikIsmiTextEdit.Location = New System.Drawing.Point(95, 36)
        Me.IplikIsmiTextEdit.MenuManager = Me.BarManager1
        Me.IplikIsmiTextEdit.Name = "IplikIsmiTextEdit"
        Me.IplikIsmiTextEdit.Size = New System.Drawing.Size(314, 20)
        Me.IplikIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.IplikIsmiTextEdit.TabIndex = 6
        '
        'IntCodeTextEdit
        '
        Me.IntCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IntCode", True))
        Me.IntCodeTextEdit.EnterMoveNextControl = True
        Me.IntCodeTextEdit.Location = New System.Drawing.Point(95, 84)
        Me.IntCodeTextEdit.MenuManager = Me.BarManager1
        Me.IntCodeTextEdit.Name = "IntCodeTextEdit"
        Me.IntCodeTextEdit.Size = New System.Drawing.Size(309, 20)
        Me.IntCodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.IntCodeTextEdit.TabIndex = 7
        '
        'PasifCheckEdit
        '
        Me.PasifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Pasif", True))
        Me.PasifCheckEdit.EnterMoveNextControl = True
        Me.PasifCheckEdit.Location = New System.Drawing.Point(12, 108)
        Me.PasifCheckEdit.MenuManager = Me.BarManager1
        Me.PasifCheckEdit.Name = "PasifCheckEdit"
        Me.PasifCheckEdit.Properties.Caption = "Pasif"
        Me.PasifCheckEdit.Size = New System.Drawing.Size(530, 19)
        Me.PasifCheckEdit.StyleController = Me.DataLayoutControl1
        Me.PasifCheckEdit.TabIndex = 8
        '
        'ItemForIplikID
        '
        Me.ItemForIplikID.Control = Me.IplikIDSpinEdit
        Me.ItemForIplikID.CustomizationFormText = "Iplik ID"
        Me.ItemForIplikID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIplikID.Name = "ItemForIplikID"
        Me.ItemForIplikID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIplikID.Text = "Iplik ID"
        Me.ItemForIplikID.TextSize = New System.Drawing.Size(50, 20)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(554, 230)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIplikKod, Me.ItemForIplikIsmi, Me.ItemForIntCode, Me.ItemForPasif, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(534, 210)
        '
        'ItemForIplikKod
        '
        Me.ItemForIplikKod.Control = Me.IplikKodTextEdit
        Me.ItemForIplikKod.CustomizationFormText = "Iplik Kod"
        Me.ItemForIplikKod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIplikKod.Name = "ItemForIplikKod"
        Me.ItemForIplikKod.Size = New System.Drawing.Size(239, 24)
        Me.ItemForIplikKod.Text = "Iplik Kod"
        Me.ItemForIplikKod.TextSize = New System.Drawing.Size(78, 13)
        '
        'ItemForIplikIsmi
        '
        Me.ItemForIplikIsmi.Control = Me.IplikIsmiTextEdit
        Me.ItemForIplikIsmi.CustomizationFormText = "Iplik Ismi"
        Me.ItemForIplikIsmi.Location = New System.Drawing.Point(0, 24)
        Me.ItemForIplikIsmi.Name = "ItemForIplikIsmi"
        Me.ItemForIplikIsmi.Size = New System.Drawing.Size(401, 24)
        Me.ItemForIplikIsmi.Text = "Iplik Ismi"
        Me.ItemForIplikIsmi.TextSize = New System.Drawing.Size(78, 13)
        '
        'ItemForIntCode
        '
        Me.ItemForIntCode.Control = Me.IntCodeTextEdit
        Me.ItemForIntCode.CustomizationFormText = "Int Code"
        Me.ItemForIntCode.Location = New System.Drawing.Point(0, 72)
        Me.ItemForIntCode.Name = "ItemForIntCode"
        Me.ItemForIntCode.Size = New System.Drawing.Size(396, 24)
        Me.ItemForIntCode.Text = "Int Code"
        Me.ItemForIntCode.TextSize = New System.Drawing.Size(78, 13)
        '
        'ItemForPasif
        '
        Me.ItemForPasif.Control = Me.PasifCheckEdit
        Me.ItemForPasif.CustomizationFormText = "Pasif"
        Me.ItemForPasif.Location = New System.Drawing.Point(0, 96)
        Me.ItemForPasif.Name = "ItemForPasif"
        Me.ItemForPasif.Size = New System.Drawing.Size(534, 114)
        Me.ItemForPasif.Text = "Pasif"
        Me.ItemForPasif.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForPasif.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(239, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(295, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(401, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(133, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(396, 72)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(138, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Stok Kart Filtresi"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem1.Text = "Stok Kart Filtresi"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(78, 13)
        '
        'colStokFiltre
        '
        Me.colStokFiltre.FieldName = "StokFiltre"
        Me.colStokFiltre.Name = "colStokFiltre"
        Me.colStokFiltre.Visible = True
        Me.colStokFiltre.VisibleIndex = 4
        '
        'MasterTable_IplikID
        '
        Me.MasterTable_IplikID.AllowDBNull = False
        Me.MasterTable_IplikID.AutoIncrement = True
        Me.MasterTable_IplikID.ColumnName = "IplikID"
        Me.MasterTable_IplikID.DataType = GetType(Integer)
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
        'MasterTable_IplikKod
        '
        Me.MasterTable_IplikKod.ColumnName = "IplikKod"
        '
        'MasterTable_IplikIsmi
        '
        Me.MasterTable_IplikIsmi.ColumnName = "IplikIsmi"
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
        'MasterTable_StokFiltre
        '
        Me.MasterTable_StokFiltre.ColumnName = "StokFiltre"
        '
        'frmIplik
        '
        Me.ClientSize = New System.Drawing.Size(560, 446)
        Me.FormCode = "000003"
        Me.Name = "frmIplik"
        Me.Text = "İplikler"
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IplikIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IplikKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IplikIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIplikID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIplikKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIplikIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents IplikIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IplikKodTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IplikIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IntCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasifCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForIplikID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForIplikKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIplikIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIntCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPasif As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colIplikID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIplikKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIplikIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colStokFiltre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterTable_IplikID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_IplikKod As System.Data.DataColumn
    Friend WithEvents MasterTable_IplikIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn
    Friend WithEvents MasterTable_StokFiltre As System.Data.DataColumn

End Class
