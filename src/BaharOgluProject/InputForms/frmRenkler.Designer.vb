<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenkler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRenkler))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RenkIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.RenkKodTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RenkIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IntCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForRenkID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForRenkKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRenkIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIntCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPasif = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colRenkID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRenkKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRenkIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterTable_RenkID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_RenkKod = New System.Data.DataColumn()
        Me.MasterTable_RenkIsmi = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
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
        CType(Me.RenkIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenkKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenkIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRenkID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRenkKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRenkIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(596, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 367)
        Me.barDockControlBottom.Size = New System.Drawing.Size(596, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 300)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(596, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 300)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 124)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(596, 202)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(590, 174)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(590, 174)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(590, 94)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRenkID, Me.colRenkKod, Me.colRenkIsmi, Me.colIntCode, Me.colPasif})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 326)
        Me.panelBottom.Size = New System.Drawing.Size(596, 41)
        '
        'basePanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(398, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Location = New System.Drawing.Point(0, 87)
        Me.panelFormTop.Size = New System.Drawing.Size(596, 37)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_RenkID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_RenkKod, Me.MasterTable_RenkIsmi, Me.MasterTable_IntCode, Me.MasterTable_Pasif})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"RenkID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_RenkID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(887, 291)
        Me.BaseTab4.Tag = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(596, 20)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 155)
        Me.lblMainWarning1.Size = New System.Drawing.Size(590, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 148)
        Me.panelAuthCodes.Size = New System.Drawing.Size(590, 26)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(590, 61)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM Renkler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 AND Pasif=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Renkler SET Deleted = RenkID  , ModifiedBy = @ModifiedBy , ModifiedDate = " &
    "GETDATE()   WHERE RenkID = @RenkID"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RenkIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RenkKodTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RenkIsmiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IntCodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasifCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForRenkID})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(484, 392, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(590, 174)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RenkIDSpinEdit
        '
        Me.RenkIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "RenkID", True))
        Me.RenkIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RenkIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.RenkIDSpinEdit.MenuManager = Me.BarManager1
        Me.RenkIDSpinEdit.Name = "RenkIDSpinEdit"
        Me.RenkIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RenkIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.RenkIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.RenkIDSpinEdit.TabIndex = 4
        '
        'RenkKodTextEdit
        '
        Me.RenkKodTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "RenkKod", True))
        Me.RenkKodTextEdit.EnterMoveNextControl = True
        Me.RenkKodTextEdit.Location = New System.Drawing.Point(63, 12)
        Me.RenkKodTextEdit.MenuManager = Me.BarManager1
        Me.RenkKodTextEdit.Name = "RenkKodTextEdit"
        Me.RenkKodTextEdit.Size = New System.Drawing.Size(185, 20)
        Me.RenkKodTextEdit.StyleController = Me.DataLayoutControl1
        Me.RenkKodTextEdit.TabIndex = 5
        '
        'RenkIsmiTextEdit
        '
        Me.RenkIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "RenkIsmi", True))
        Me.RenkIsmiTextEdit.EnterMoveNextControl = True
        Me.RenkIsmiTextEdit.Location = New System.Drawing.Point(63, 36)
        Me.RenkIsmiTextEdit.MenuManager = Me.BarManager1
        Me.RenkIsmiTextEdit.Name = "RenkIsmiTextEdit"
        Me.RenkIsmiTextEdit.Size = New System.Drawing.Size(309, 20)
        Me.RenkIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.RenkIsmiTextEdit.TabIndex = 6
        '
        'IntCodeTextEdit
        '
        Me.IntCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IntCode", True))
        Me.IntCodeTextEdit.EnterMoveNextControl = True
        Me.IntCodeTextEdit.Location = New System.Drawing.Point(63, 60)
        Me.IntCodeTextEdit.MenuManager = Me.BarManager1
        Me.IntCodeTextEdit.Name = "IntCodeTextEdit"
        Me.IntCodeTextEdit.Size = New System.Drawing.Size(449, 20)
        Me.IntCodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.IntCodeTextEdit.TabIndex = 7
        '
        'PasifCheckEdit
        '
        Me.PasifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Pasif", True))
        Me.PasifCheckEdit.EnterMoveNextControl = True
        Me.PasifCheckEdit.Location = New System.Drawing.Point(12, 84)
        Me.PasifCheckEdit.MenuManager = Me.BarManager1
        Me.PasifCheckEdit.Name = "PasifCheckEdit"
        Me.PasifCheckEdit.Properties.Caption = "Pasif"
        Me.PasifCheckEdit.Size = New System.Drawing.Size(566, 19)
        Me.PasifCheckEdit.StyleController = Me.DataLayoutControl1
        Me.PasifCheckEdit.TabIndex = 8
        '
        'ItemForRenkID
        '
        Me.ItemForRenkID.Control = Me.RenkIDSpinEdit
        Me.ItemForRenkID.CustomizationFormText = "Renk ID"
        Me.ItemForRenkID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRenkID.Name = "ItemForRenkID"
        Me.ItemForRenkID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForRenkID.Text = "Renk ID"
        Me.ItemForRenkID.TextSize = New System.Drawing.Size(50, 20)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(590, 174)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForRenkKod, Me.ItemForRenkIsmi, Me.ItemForIntCode, Me.ItemForPasif, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(570, 154)
        '
        'ItemForRenkKod
        '
        Me.ItemForRenkKod.Control = Me.RenkKodTextEdit
        Me.ItemForRenkKod.CustomizationFormText = "Renk Kod"
        Me.ItemForRenkKod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRenkKod.Name = "ItemForRenkKod"
        Me.ItemForRenkKod.Size = New System.Drawing.Size(240, 24)
        Me.ItemForRenkKod.Text = "Renk Kod"
        Me.ItemForRenkKod.TextSize = New System.Drawing.Size(46, 13)
        '
        'ItemForRenkIsmi
        '
        Me.ItemForRenkIsmi.Control = Me.RenkIsmiTextEdit
        Me.ItemForRenkIsmi.CustomizationFormText = "Renk Ismi"
        Me.ItemForRenkIsmi.Location = New System.Drawing.Point(0, 24)
        Me.ItemForRenkIsmi.Name = "ItemForRenkIsmi"
        Me.ItemForRenkIsmi.Size = New System.Drawing.Size(364, 24)
        Me.ItemForRenkIsmi.Text = "Renk Ismi"
        Me.ItemForRenkIsmi.TextSize = New System.Drawing.Size(46, 13)
        '
        'ItemForIntCode
        '
        Me.ItemForIntCode.Control = Me.IntCodeTextEdit
        Me.ItemForIntCode.CustomizationFormText = "Int Code"
        Me.ItemForIntCode.Location = New System.Drawing.Point(0, 48)
        Me.ItemForIntCode.Name = "ItemForIntCode"
        Me.ItemForIntCode.Size = New System.Drawing.Size(504, 24)
        Me.ItemForIntCode.Text = "Int Code"
        Me.ItemForIntCode.TextSize = New System.Drawing.Size(46, 13)
        '
        'ItemForPasif
        '
        Me.ItemForPasif.Control = Me.PasifCheckEdit
        Me.ItemForPasif.CustomizationFormText = "Pasif"
        Me.ItemForPasif.Location = New System.Drawing.Point(0, 72)
        Me.ItemForPasif.Name = "ItemForPasif"
        Me.ItemForPasif.Size = New System.Drawing.Size(570, 82)
        Me.ItemForPasif.Text = "Pasif"
        Me.ItemForPasif.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForPasif.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(240, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(330, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(364, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(206, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(504, 48)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(66, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'colRenkID
        '
        Me.colRenkID.FieldName = "RenkID"
        Me.colRenkID.Name = "colRenkID"
        '
        'colRenkKod
        '
        Me.colRenkKod.FieldName = "RenkKod"
        Me.colRenkKod.Name = "colRenkKod"
        Me.colRenkKod.Visible = True
        Me.colRenkKod.VisibleIndex = 0
        Me.colRenkKod.Width = 178
        '
        'colRenkIsmi
        '
        Me.colRenkIsmi.FieldName = "RenkIsmi"
        Me.colRenkIsmi.Name = "colRenkIsmi"
        Me.colRenkIsmi.Visible = True
        Me.colRenkIsmi.VisibleIndex = 1
        Me.colRenkIsmi.Width = 304
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
        'MasterTable_RenkID
        '
        Me.MasterTable_RenkID.AllowDBNull = False
        Me.MasterTable_RenkID.AutoIncrement = True
        Me.MasterTable_RenkID.ColumnName = "RenkID"
        Me.MasterTable_RenkID.DataType = GetType(Integer)
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
        'MasterTable_RenkKod
        '
        Me.MasterTable_RenkKod.ColumnName = "RenkKod"
        '
        'MasterTable_RenkIsmi
        '
        Me.MasterTable_RenkIsmi.ColumnName = "RenkIsmi"
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
        'frmRenkler
        '
        Me.ClientSize = New System.Drawing.Size(596, 390)
        Me.FormCode = "000001"
        Me.Name = "frmRenkler"
        Me.Text = "Renkler"
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
        CType(Me.RenkIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RenkKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RenkIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRenkID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRenkKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRenkIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents RenkIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RenkKodTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RenkIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IntCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasifCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForRenkID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForRenkKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRenkIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIntCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPasif As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colRenkID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRenkKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRenkIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents MasterTable_RenkID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_RenkKod As System.Data.DataColumn
    Friend WithEvents MasterTable_RenkIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn

End Class
