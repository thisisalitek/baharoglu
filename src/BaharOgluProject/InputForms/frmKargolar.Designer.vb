<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKargolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKargolar))
        Me.MasterTable_KargoID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_KargoIsmi = New System.Data.DataColumn()
        Me.MasterTable_KargoWebLink = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colKargoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKargoIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKargoWebLink = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.KargoIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeletedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CreatedBySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CreatedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ModifiedBySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ModifiedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.KargoIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KargoWebLinkTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForKargoID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCreatedBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCreatedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModifiedBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModifiedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForKargoIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKargoWebLink = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPasif = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
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
        CType(Me.KargoIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KargoIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KargoWebLinkTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKargoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKargoIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKargoWebLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(627, 77)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 392)
        Me.barDockControlBottom.Size = New System.Drawing.Size(627, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 315)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(627, 77)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 315)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 120)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(627, 231)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(621, 200)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(621, 200)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(621, 120)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKargoID, Me.colKargoIsmi, Me.colKargoWebLink, Me.colPasif})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 351)
        Me.panelBottom.Size = New System.Drawing.Size(627, 41)
        '
        'PanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(429, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Size = New System.Drawing.Size(627, 31)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KargoID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_KargoIsmi, Me.MasterTable_KargoWebLink, Me.MasterTable_Pasif})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KargoID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KargoID}
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
        Me.txtTopInfo.Size = New System.Drawing.Size(627, 12)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 181)
        Me.lblMainWarning1.Size = New System.Drawing.Size(621, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 174)
        Me.panelAuthCodes.Size = New System.Drawing.Size(621, 26)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(621, 61)
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
        'MasterTable_KargoID
        '
        Me.MasterTable_KargoID.AllowDBNull = False
        Me.MasterTable_KargoID.AutoIncrement = True
        Me.MasterTable_KargoID.ColumnName = "KargoID"
        Me.MasterTable_KargoID.DataType = GetType(Integer)
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
        'MasterTable_KargoIsmi
        '
        Me.MasterTable_KargoIsmi.ColumnName = "KargoIsmi"
        '
        'MasterTable_KargoWebLink
        '
        Me.MasterTable_KargoWebLink.ColumnName = "KargoWebLink"
        '
        'MasterTable_Pasif
        '
        Me.MasterTable_Pasif.ColumnName = "Pasif"
        Me.MasterTable_Pasif.DataType = GetType(Integer)
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM Kargolar WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KargoID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "UPDATE Kargolar SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deleted = @Deleted , ModifiedBy = @ModifiedBy , ModifiedDat" & _
    "e = GETDATE() , KargoIsmi = @KargoIsmi , KargoWebLink = @KargoWebLink" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " , Pasif " & _
    "= @Pasif" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE KargoID = @KargoID"
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Kargolar SET Deleted = KargoID  , ModifiedBy = @ModifiedBy , ModifiedDate " & _
    "= GETDATE()   WHERE KargoID = @KargoID"
        '
        'colKargoID
        '
        Me.colKargoID.FieldName = "KargoID"
        Me.colKargoID.Name = "colKargoID"
        '
        'colKargoIsmi
        '
        Me.colKargoIsmi.FieldName = "KargoIsmi"
        Me.colKargoIsmi.Name = "colKargoIsmi"
        Me.colKargoIsmi.Visible = True
        Me.colKargoIsmi.VisibleIndex = 0
        Me.colKargoIsmi.Width = 150
        '
        'colKargoWebLink
        '
        Me.colKargoWebLink.FieldName = "KargoWebLink"
        Me.colKargoWebLink.Name = "colKargoWebLink"
        Me.colKargoWebLink.Visible = True
        Me.colKargoWebLink.VisibleIndex = 1
        Me.colKargoWebLink.Width = 238
        '
        'colPasif
        '
        Me.colPasif.FieldName = "Pasif"
        Me.colPasif.Name = "colPasif"
        Me.colPasif.Visible = True
        Me.colPasif.VisibleIndex = 2
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.KargoIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeletedSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CreatedBySpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CreatedDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModifiedBySpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModifiedDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KargoIsmiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KargoWebLinkTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasifCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKargoID, Me.ItemForDeleted, Me.ItemForCreatedBy, Me.ItemForCreatedDate, Me.ItemForModifiedBy, Me.ItemForModifiedDate})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(781, 179, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(621, 200)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'KargoIDSpinEdit
        '
        Me.KargoIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KargoID", True))
        Me.KargoIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.KargoIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.KargoIDSpinEdit.MenuManager = Me.BarManager1
        Me.KargoIDSpinEdit.Name = "KargoIDSpinEdit"
        Me.KargoIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.KargoIDSpinEdit.Size = New System.Drawing.Size(0, 22)
        Me.KargoIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.KargoIDSpinEdit.TabIndex = 4
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
        'CreatedBySpinEdit
        '
        Me.CreatedBySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CreatedBy", True))
        Me.CreatedBySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CreatedBySpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.CreatedBySpinEdit.MenuManager = Me.BarManager1
        Me.CreatedBySpinEdit.Name = "CreatedBySpinEdit"
        Me.CreatedBySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CreatedBySpinEdit.Size = New System.Drawing.Size(0, 22)
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
        Me.CreatedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CreatedDateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.CreatedDateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.CreatedDateDateEdit.Size = New System.Drawing.Size(0, 22)
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
        Me.ModifiedBySpinEdit.Size = New System.Drawing.Size(0, 22)
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
        Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.ModifiedDateDateEdit.Size = New System.Drawing.Size(0, 22)
        Me.ModifiedDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.ModifiedDateDateEdit.TabIndex = 9
        '
        'KargoIsmiTextEdit
        '
        Me.KargoIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KargoIsmi", True))
        Me.KargoIsmiTextEdit.EnterMoveNextControl = True
        Me.KargoIsmiTextEdit.Location = New System.Drawing.Point(107, 12)
        Me.KargoIsmiTextEdit.MenuManager = Me.BarManager1
        Me.KargoIsmiTextEdit.Name = "KargoIsmiTextEdit"
        Me.KargoIsmiTextEdit.Size = New System.Drawing.Size(325, 22)
        Me.KargoIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.KargoIsmiTextEdit.TabIndex = 10
        '
        'KargoWebLinkTextEdit
        '
        Me.KargoWebLinkTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KargoWebLink", True))
        Me.KargoWebLinkTextEdit.EnterMoveNextControl = True
        Me.KargoWebLinkTextEdit.Location = New System.Drawing.Point(107, 38)
        Me.KargoWebLinkTextEdit.MenuManager = Me.BarManager1
        Me.KargoWebLinkTextEdit.Name = "KargoWebLinkTextEdit"
        Me.KargoWebLinkTextEdit.Size = New System.Drawing.Size(502, 22)
        Me.KargoWebLinkTextEdit.StyleController = Me.DataLayoutControl1
        Me.KargoWebLinkTextEdit.TabIndex = 11
        '
        'PasifCheckEdit
        '
        Me.PasifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Pasif", True))
        Me.PasifCheckEdit.EnterMoveNextControl = True
        Me.PasifCheckEdit.Location = New System.Drawing.Point(12, 64)
        Me.PasifCheckEdit.MenuManager = Me.BarManager1
        Me.PasifCheckEdit.Name = "PasifCheckEdit"
        Me.PasifCheckEdit.Properties.Caption = "Pasif"
        Me.PasifCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PasifCheckEdit.Properties.ValueChecked = 1
        Me.PasifCheckEdit.Properties.ValueUnchecked = 0
        Me.PasifCheckEdit.Size = New System.Drawing.Size(597, 21)
        Me.PasifCheckEdit.StyleController = Me.DataLayoutControl1
        Me.PasifCheckEdit.TabIndex = 12
        '
        'ItemForKargoID
        '
        Me.ItemForKargoID.Control = Me.KargoIDSpinEdit
        Me.ItemForKargoID.CustomizationFormText = "Kargo ID"
        Me.ItemForKargoID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKargoID.Name = "ItemForKargoID"
        Me.ItemForKargoID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForKargoID.Text = "Kargo ID"
        Me.ItemForKargoID.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForKargoID.TextToControlDistance = 5
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(621, 200)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKargoIsmi, Me.ItemForKargoWebLink, Me.ItemForPasif, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(601, 180)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForKargoIsmi
        '
        Me.ItemForKargoIsmi.Control = Me.KargoIsmiTextEdit
        Me.ItemForKargoIsmi.CustomizationFormText = "Kargo Ismi"
        Me.ItemForKargoIsmi.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKargoIsmi.Name = "ItemForKargoIsmi"
        Me.ItemForKargoIsmi.Size = New System.Drawing.Size(424, 26)
        Me.ItemForKargoIsmi.Text = "Kargo Ismi"
        Me.ItemForKargoIsmi.TextSize = New System.Drawing.Size(90, 16)
        Me.ItemForKargoIsmi.TextToControlDistance = 5
        '
        'ItemForKargoWebLink
        '
        Me.ItemForKargoWebLink.Control = Me.KargoWebLinkTextEdit
        Me.ItemForKargoWebLink.CustomizationFormText = "Kargo Web Link"
        Me.ItemForKargoWebLink.Location = New System.Drawing.Point(0, 26)
        Me.ItemForKargoWebLink.Name = "ItemForKargoWebLink"
        Me.ItemForKargoWebLink.Size = New System.Drawing.Size(601, 26)
        Me.ItemForKargoWebLink.Text = "Kargo Web Link"
        Me.ItemForKargoWebLink.TextSize = New System.Drawing.Size(90, 16)
        Me.ItemForKargoWebLink.TextToControlDistance = 5
        '
        'ItemForPasif
        '
        Me.ItemForPasif.Control = Me.PasifCheckEdit
        Me.ItemForPasif.CustomizationFormText = "Pasif"
        Me.ItemForPasif.Location = New System.Drawing.Point(0, 52)
        Me.ItemForPasif.Name = "ItemForPasif"
        Me.ItemForPasif.Size = New System.Drawing.Size(601, 128)
        Me.ItemForPasif.Text = "Pasif"
        Me.ItemForPasif.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForPasif.TextToControlDistance = 0
        Me.ItemForPasif.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(424, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(177, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmKargolar
        '
        Me.ClientSize = New System.Drawing.Size(627, 415)
        Me.FormCode = "000020"
        Me.Name = "frmKargolar"
        Me.Text = "Kargo ve Sevk Türleri"
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
        CType(Me.KargoIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KargoIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KargoWebLinkTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKargoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKargoIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKargoWebLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MasterTable_KargoID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_KargoIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_KargoWebLink As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents KargoIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeletedSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CreatedBySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CreatedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ModifiedBySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ModifiedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents KargoIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KargoWebLinkTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasifCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForKargoID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreatedBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreatedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModifiedBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModifiedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForKargoIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKargoWebLink As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPasif As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colKargoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKargoIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKargoWebLink As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

End Class
