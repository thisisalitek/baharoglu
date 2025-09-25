<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFasonTanim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFasonTanim))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colFasonID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFasonAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenFark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.FasonIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeletedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FasonAciklamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FiyatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BedenFarkTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForFasonID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForFasonAciklama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFiyat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForBedenFark = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.MasterTable_FasonID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_FasonAciklama = New System.Data.DataColumn()
        Me.MasterTable_Fiyat = New System.Data.DataColumn()
        Me.MasterTable_BedenFark = New System.Data.DataColumn()
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
        CType(Me.FasonIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasonAciklamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiyatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedenFarkTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFasonID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFasonAciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForBedenFark, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'barDockControlTop
        '
        Me.barDockControlTop.Size = New System.Drawing.Size(941, 77)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 564)
        Me.barDockControlBottom.Size = New System.Drawing.Size(941, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(941, 77)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 120)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(941, 403)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(935, 372)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(887, 376)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(935, 292)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFasonID, Me.colDeleted, Me.colFasonAciklama, Me.colFiyat, Me.colBedenFark})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 523)
        Me.panelBottom.Size = New System.Drawing.Size(941, 41)
        '
        'PanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(743, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Size = New System.Drawing.Size(941, 31)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_FasonID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_FasonAciklama, Me.MasterTable_Fiyat, Me.MasterTable_BedenFark})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"FasonID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_FasonID}
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
        Me.txtTopInfo.Size = New System.Drawing.Size(941, 12)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 353)
        Me.lblMainWarning1.Size = New System.Drawing.Size(935, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 350)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(935, 61)
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
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Fason " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted=0 "
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_FasonID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "UPDATE Fason SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deleted = @Deleted , ModifiedBy = @ModifiedBy , ModifiedDate =" & _
    " GETDATE() , FasonAciklama = @FasonAciklama , Fiyat = @Fiyat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " , BedenFark = @Be" & _
    "denFark" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE FasonID = @FasonID"
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Fason SET Deleted = FasonID  , ModifiedBy = @ModifiedBy , ModifiedDate = G" & _
    "ETDATE()   WHERE FasonID = @FasonID"
        '
        'colFasonID
        '
        Me.colFasonID.FieldName = "FasonID"
        Me.colFasonID.Name = "colFasonID"
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colFasonAciklama
        '
        Me.colFasonAciklama.FieldName = "FasonAciklama"
        Me.colFasonAciklama.Name = "colFasonAciklama"
        Me.colFasonAciklama.Visible = True
        Me.colFasonAciklama.VisibleIndex = 0
        Me.colFasonAciklama.Width = 232
        '
        'colFiyat
        '
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 1
        '
        'colBedenFark
        '
        Me.colBedenFark.FieldName = "BedenFark"
        Me.colBedenFark.Name = "colBedenFark"
        Me.colBedenFark.Visible = True
        Me.colBedenFark.VisibleIndex = 2
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.FasonIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeletedSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FasonAciklamaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FiyatTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.BedenFarkTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForFasonID, Me.ItemForDeleted})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(960, 223, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(887, 376)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'FasonIDSpinEdit
        '
        Me.FasonIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonID", True))
        Me.FasonIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FasonIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.FasonIDSpinEdit.MenuManager = Me.BarManager1
        Me.FasonIDSpinEdit.Name = "FasonIDSpinEdit"
        Me.FasonIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FasonIDSpinEdit.Size = New System.Drawing.Size(0, 22)
        Me.FasonIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.FasonIDSpinEdit.TabIndex = 4
        '
        'DeletedSpinEdit
        '
        Me.DeletedSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Deleted", True))
        Me.DeletedSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DeletedSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.DeletedSpinEdit.MenuManager = Me.BarManager1
        Me.DeletedSpinEdit.Name = "DeletedSpinEdit"
        Me.DeletedSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeletedSpinEdit.Size = New System.Drawing.Size(0, 22)
        Me.DeletedSpinEdit.StyleController = Me.DataLayoutControl1
        Me.DeletedSpinEdit.TabIndex = 5
        '
        'FasonAciklamaTextEdit
        '
        Me.FasonAciklamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "FasonAciklama", True))
        Me.FasonAciklamaTextEdit.EnterMoveNextControl = True
        Me.FasonAciklamaTextEdit.Location = New System.Drawing.Point(106, 12)
        Me.FasonAciklamaTextEdit.MenuManager = Me.BarManager1
        Me.FasonAciklamaTextEdit.Name = "FasonAciklamaTextEdit"
        Me.FasonAciklamaTextEdit.Size = New System.Drawing.Size(769, 22)
        Me.FasonAciklamaTextEdit.StyleController = Me.DataLayoutControl1
        Me.FasonAciklamaTextEdit.TabIndex = 6
        '
        'FiyatTextEdit
        '
        Me.FiyatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Fiyat", True))
        Me.FiyatTextEdit.EnterMoveNextControl = True
        Me.FiyatTextEdit.Location = New System.Drawing.Point(106, 38)
        Me.FiyatTextEdit.MenuManager = Me.BarManager1
        Me.FiyatTextEdit.Name = "FiyatTextEdit"
        Me.FiyatTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.FiyatTextEdit.StyleController = Me.DataLayoutControl1
        Me.FiyatTextEdit.TabIndex = 7
        '
        'BedenFarkTextEdit
        '
        Me.BedenFarkTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "BedenFark", True))
        Me.BedenFarkTextEdit.EnterMoveNextControl = True
        Me.BedenFarkTextEdit.Location = New System.Drawing.Point(106, 64)
        Me.BedenFarkTextEdit.MenuManager = Me.BarManager1
        Me.BedenFarkTextEdit.Name = "BedenFarkTextEdit"
        Me.BedenFarkTextEdit.Size = New System.Drawing.Size(334, 22)
        Me.BedenFarkTextEdit.StyleController = Me.DataLayoutControl1
        Me.BedenFarkTextEdit.TabIndex = 8
        '
        'ItemForFasonID
        '
        Me.ItemForFasonID.Control = Me.FasonIDSpinEdit
        Me.ItemForFasonID.CustomizationFormText = "Fason ID"
        Me.ItemForFasonID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFasonID.Name = "ItemForFasonID"
        Me.ItemForFasonID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFasonID.Text = "Fason ID"
        Me.ItemForFasonID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFasonID.TextToControlDistance = 5
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(887, 376)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForFasonAciklama, Me.ItemForFiyat, Me.ItemForBedenFark, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(867, 356)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForFasonAciklama
        '
        Me.ItemForFasonAciklama.Control = Me.FasonAciklamaTextEdit
        Me.ItemForFasonAciklama.CustomizationFormText = "Fason Aciklama"
        Me.ItemForFasonAciklama.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFasonAciklama.Name = "ItemForFasonAciklama"
        Me.ItemForFasonAciklama.Size = New System.Drawing.Size(867, 26)
        Me.ItemForFasonAciklama.Text = "Fason Aciklama"
        Me.ItemForFasonAciklama.TextSize = New System.Drawing.Size(89, 16)
        Me.ItemForFasonAciklama.TextToControlDistance = 5
        '
        'ItemForFiyat
        '
        Me.ItemForFiyat.Control = Me.FiyatTextEdit
        Me.ItemForFiyat.CustomizationFormText = "Fiyat"
        Me.ItemForFiyat.Location = New System.Drawing.Point(0, 26)
        Me.ItemForFiyat.Name = "ItemForFiyat"
        Me.ItemForFiyat.Size = New System.Drawing.Size(432, 26)
        Me.ItemForFiyat.Text = "Fiyat"
        Me.ItemForFiyat.TextSize = New System.Drawing.Size(89, 16)
        Me.ItemForFiyat.TextToControlDistance = 5
        '
        'ItemForBedenFark
        '
        Me.ItemForBedenFark.Control = Me.BedenFarkTextEdit
        Me.ItemForBedenFark.CustomizationFormText = "Beden Fark"
        Me.ItemForBedenFark.Location = New System.Drawing.Point(0, 52)
        Me.ItemForBedenFark.Name = "ItemForBedenFark"
        Me.ItemForBedenFark.Size = New System.Drawing.Size(432, 304)
        Me.ItemForBedenFark.Text = "Beden Fark"
        Me.ItemForBedenFark.TextSize = New System.Drawing.Size(89, 16)
        Me.ItemForBedenFark.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(432, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(435, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(432, 52)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(435, 304)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'MasterTable_FasonID
        '
        Me.MasterTable_FasonID.AllowDBNull = False
        Me.MasterTable_FasonID.AutoIncrement = True
        Me.MasterTable_FasonID.ColumnName = "FasonID"
        Me.MasterTable_FasonID.DataType = GetType(Integer)
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
        'MasterTable_FasonAciklama
        '
        Me.MasterTable_FasonAciklama.ColumnName = "FasonAciklama"
        '
        'MasterTable_Fiyat
        '
        Me.MasterTable_Fiyat.ColumnName = "Fiyat"
        Me.MasterTable_Fiyat.DataType = GetType(Double)
        '
        'MasterTable_BedenFark
        '
        Me.MasterTable_BedenFark.ColumnName = "BedenFark"
        Me.MasterTable_BedenFark.DataType = GetType(Double)
        '
        'frmFasonTanim
        '
        Me.ClientSize = New System.Drawing.Size(941, 587)
        Me.FormCode = "000011"
        Me.Name = "frmFasonTanim"
        Me.Text = "Fason Tanımları"
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
        CType(Me.FasonIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasonAciklamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiyatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedenFarkTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFasonID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFasonAciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForBedenFark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents FasonIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeletedSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FasonAciklamaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FiyatTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BedenFarkTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForFasonID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForFasonAciklama As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFiyat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForBedenFark As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colFasonID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFasonAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenFark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents MasterTable_FasonID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_FasonAciklama As System.Data.DataColumn
    Friend WithEvents MasterTable_Fiyat As System.Data.DataColumn
    Friend WithEvents MasterTable_BedenFark As System.Data.DataColumn

End Class
