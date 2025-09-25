<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigerKumaslar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDigerKumaslar))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colKumasID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKumasKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKumasIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.KumasIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeletedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CreatedBySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CreatedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ModifiedBySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ModifiedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.KumasKodTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KumasIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IntCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForKumasID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCreatedBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCreatedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModifiedBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForModifiedDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForKumasKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKumasIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIntCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPasif = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenArtis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterTable_KumasID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_Tip = New System.Data.DataColumn()
        Me.MasterTable_KumasKod = New System.Data.DataColumn()
        Me.MasterTable_KumasIsmi = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
        Me.MasterTable_Fiyat = New System.Data.DataColumn()
        Me.MasterTable_BedenArtis = New System.Data.DataColumn()
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
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KumasIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KumasKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KumasIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKumasID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKumasKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKumasIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(595, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 434)
        Me.barDockControlBottom.Size = New System.Drawing.Size(595, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 367)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(595, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 367)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 108)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(595, 285)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(589, 257)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(589, 257)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(589, 177)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKumasID, Me.colTip, Me.colKumasKod, Me.colKumasIsmi, Me.colIntCode, Me.colPasif, Me.colFiyat, Me.colBedenArtis})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 393)
        Me.panelBottom.Size = New System.Drawing.Size(595, 41)
        '
        'basePanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(397, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Size = New System.Drawing.Size(595, 31)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KumasID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_Tip, Me.MasterTable_KumasKod, Me.MasterTable_KumasIsmi, Me.MasterTable_IntCode, Me.MasterTable_Pasif, Me.MasterTable_Fiyat, Me.MasterTable_BedenArtis})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KumasID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KumasID}
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
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(595, 10)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 238)
        Me.lblMainWarning1.Size = New System.Drawing.Size(589, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 231)
        Me.panelAuthCodes.Size = New System.Drawing.Size(589, 26)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(589, 61)
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
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Kumaslar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (Deleted = 0)"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KumasID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE Kumaslar SET Deleted = KumasID  , ModifiedBy = @ModifiedBy , ModifiedDate " &
    "= GETDATE()   WHERE KumasID = @KumasID"
        '
        'colKumasID
        '
        Me.colKumasID.FieldName = "KumasID"
        Me.colKumasID.Name = "colKumasID"
        '
        'colTip
        '
        Me.colTip.FieldName = "Tip"
        Me.colTip.Name = "colTip"
        Me.colTip.Width = 82
        '
        'colKumasKod
        '
        Me.colKumasKod.FieldName = "KumasKod"
        Me.colKumasKod.Name = "colKumasKod"
        Me.colKumasKod.Visible = True
        Me.colKumasKod.VisibleIndex = 0
        Me.colKumasKod.Width = 110
        '
        'colKumasIsmi
        '
        Me.colKumasIsmi.FieldName = "KumasIsmi"
        Me.colKumasIsmi.Name = "colKumasIsmi"
        Me.colKumasIsmi.Visible = True
        Me.colKumasIsmi.VisibleIndex = 1
        Me.colKumasIsmi.Width = 200
        '
        'colIntCode
        '
        Me.colIntCode.FieldName = "IntCode"
        Me.colIntCode.Name = "colIntCode"
        Me.colIntCode.Visible = True
        Me.colIntCode.VisibleIndex = 2
        Me.colIntCode.Width = 67
        '
        'colPasif
        '
        Me.colPasif.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colPasif.FieldName = "Pasif"
        Me.colPasif.Name = "colPasif"
        Me.colPasif.Visible = True
        Me.colPasif.VisibleIndex = 3
        Me.colPasif.Width = 46
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.KumasIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeletedSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CreatedBySpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CreatedDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModifiedBySpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ModifiedDateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KumasKodTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KumasIsmiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IntCodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasifCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKumasID, Me.ItemForDeleted, Me.ItemForCreatedBy, Me.ItemForCreatedDate, Me.ItemForModifiedBy, Me.ItemForModifiedDate})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(919, 206, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(589, 257)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Fiyat", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(70, 60)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(98, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 15
        '
        'KumasIDSpinEdit
        '
        Me.KumasIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KumasID", True))
        Me.KumasIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.KumasIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.KumasIDSpinEdit.MenuManager = Me.BarManager1
        Me.KumasIDSpinEdit.Name = "KumasIDSpinEdit"
        Me.KumasIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.KumasIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.KumasIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.KumasIDSpinEdit.TabIndex = 4
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
        Me.CreatedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
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
        Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ModifiedDateDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.ModifiedDateDateEdit.StyleController = Me.DataLayoutControl1
        Me.ModifiedDateDateEdit.TabIndex = 9
        '
        'KumasKodTextEdit
        '
        Me.KumasKodTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KumasKod", True))
        Me.KumasKodTextEdit.EnterMoveNextControl = True
        Me.KumasKodTextEdit.Location = New System.Drawing.Point(70, 12)
        Me.KumasKodTextEdit.MenuManager = Me.BarManager1
        Me.KumasKodTextEdit.Name = "KumasKodTextEdit"
        Me.KumasKodTextEdit.Size = New System.Drawing.Size(173, 20)
        Me.KumasKodTextEdit.StyleController = Me.DataLayoutControl1
        Me.KumasKodTextEdit.TabIndex = 11
        '
        'KumasIsmiTextEdit
        '
        Me.KumasIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "KumasIsmi", True))
        Me.KumasIsmiTextEdit.EnterMoveNextControl = True
        Me.KumasIsmiTextEdit.Location = New System.Drawing.Point(70, 36)
        Me.KumasIsmiTextEdit.MenuManager = Me.BarManager1
        Me.KumasIsmiTextEdit.Name = "KumasIsmiTextEdit"
        Me.KumasIsmiTextEdit.Size = New System.Drawing.Size(342, 20)
        Me.KumasIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.KumasIsmiTextEdit.TabIndex = 12
        '
        'IntCodeTextEdit
        '
        Me.IntCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IntCode", True))
        Me.IntCodeTextEdit.EnterMoveNextControl = True
        Me.IntCodeTextEdit.Location = New System.Drawing.Point(70, 84)
        Me.IntCodeTextEdit.MenuManager = Me.BarManager1
        Me.IntCodeTextEdit.Name = "IntCodeTextEdit"
        Me.IntCodeTextEdit.Size = New System.Drawing.Size(342, 20)
        Me.IntCodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.IntCodeTextEdit.TabIndex = 13
        '
        'PasifCheckEdit
        '
        Me.PasifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Pasif", True))
        Me.PasifCheckEdit.EnterMoveNextControl = True
        Me.PasifCheckEdit.Location = New System.Drawing.Point(12, 108)
        Me.PasifCheckEdit.MenuManager = Me.BarManager1
        Me.PasifCheckEdit.Name = "PasifCheckEdit"
        Me.PasifCheckEdit.Properties.Caption = "Pasif"
        Me.PasifCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.PasifCheckEdit.Properties.ValueChecked = 1
        Me.PasifCheckEdit.Properties.ValueUnchecked = 0
        Me.PasifCheckEdit.Size = New System.Drawing.Size(400, 19)
        Me.PasifCheckEdit.StyleController = Me.DataLayoutControl1
        Me.PasifCheckEdit.TabIndex = 14
        '
        'ItemForKumasID
        '
        Me.ItemForKumasID.Control = Me.KumasIDSpinEdit
        Me.ItemForKumasID.CustomizationFormText = "Kumas ID"
        Me.ItemForKumasID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKumasID.Name = "ItemForKumasID"
        Me.ItemForKumasID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForKumasID.Text = "Kumas ID"
        Me.ItemForKumasID.TextSize = New System.Drawing.Size(50, 20)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(589, 257)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKumasKod, Me.ItemForKumasIsmi, Me.ItemForIntCode, Me.ItemForPasif, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(569, 237)
        '
        'ItemForKumasKod
        '
        Me.ItemForKumasKod.Control = Me.KumasKodTextEdit
        Me.ItemForKumasKod.CustomizationFormText = "Kumas Kod"
        Me.ItemForKumasKod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKumasKod.Name = "ItemForKumasKod"
        Me.ItemForKumasKod.Size = New System.Drawing.Size(235, 24)
        Me.ItemForKumasKod.Text = "Kumas Kod"
        Me.ItemForKumasKod.TextSize = New System.Drawing.Size(53, 13)
        '
        'ItemForKumasIsmi
        '
        Me.ItemForKumasIsmi.Control = Me.KumasIsmiTextEdit
        Me.ItemForKumasIsmi.CustomizationFormText = "Kumas Ismi"
        Me.ItemForKumasIsmi.Location = New System.Drawing.Point(0, 24)
        Me.ItemForKumasIsmi.Name = "ItemForKumasIsmi"
        Me.ItemForKumasIsmi.Size = New System.Drawing.Size(404, 24)
        Me.ItemForKumasIsmi.Text = "Kumas Ismi"
        Me.ItemForKumasIsmi.TextSize = New System.Drawing.Size(53, 13)
        '
        'ItemForIntCode
        '
        Me.ItemForIntCode.Control = Me.IntCodeTextEdit
        Me.ItemForIntCode.CustomizationFormText = "Int Code"
        Me.ItemForIntCode.Location = New System.Drawing.Point(0, 72)
        Me.ItemForIntCode.Name = "ItemForIntCode"
        Me.ItemForIntCode.Size = New System.Drawing.Size(404, 24)
        Me.ItemForIntCode.Text = "Int Code"
        Me.ItemForIntCode.TextSize = New System.Drawing.Size(53, 13)
        '
        'ItemForPasif
        '
        Me.ItemForPasif.Control = Me.PasifCheckEdit
        Me.ItemForPasif.CustomizationFormText = "Pasif"
        Me.ItemForPasif.Location = New System.Drawing.Point(0, 96)
        Me.ItemForPasif.Name = "ItemForPasif"
        Me.ItemForPasif.Size = New System.Drawing.Size(404, 141)
        Me.ItemForPasif.Text = "Pasif"
        Me.ItemForPasif.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForPasif.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(404, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(165, 237)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(235, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(169, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Fiyat Farkı"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(160, 24)
        Me.LayoutControlItem1.Text = "Fiyat Farkı"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(160, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(244, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
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
        'MasterTable_KumasID
        '
        Me.MasterTable_KumasID.AllowDBNull = False
        Me.MasterTable_KumasID.AutoIncrement = True
        Me.MasterTable_KumasID.ColumnName = "KumasID"
        Me.MasterTable_KumasID.DataType = GetType(Integer)
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
        'MasterTable_KumasKod
        '
        Me.MasterTable_KumasKod.ColumnName = "KumasKod"
        '
        'MasterTable_KumasIsmi
        '
        Me.MasterTable_KumasIsmi.ColumnName = "KumasIsmi"
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
        'frmDigerKumaslar
        '
        Me.ClientSize = New System.Drawing.Size(595, 457)
        Me.FormCode = "000014"
        Me.Name = "frmDigerKumaslar"
        Me.Text = "Diğer Kumaşlar"
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
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KumasIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedBySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KumasKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KumasIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKumasID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKumasKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKumasIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIntCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents KumasIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeletedSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CreatedBySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CreatedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ModifiedBySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ModifiedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents KumasKodTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KumasIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IntCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasifCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForKumasID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreatedBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCreatedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModifiedBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForModifiedDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForKumasKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKumasIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIntCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPasif As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colKumasID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKumasKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKumasIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenArtis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterTable_KumasID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_Tip As System.Data.DataColumn
    Friend WithEvents MasterTable_KumasKod As System.Data.DataColumn
    Friend WithEvents MasterTable_KumasIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn
    Friend WithEvents MasterTable_Fiyat As System.Data.DataColumn
    Friend WithEvents MasterTable_BedenArtis As System.Data.DataColumn

End Class
