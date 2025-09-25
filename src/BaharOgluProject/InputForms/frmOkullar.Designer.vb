<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOkullar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOkullar))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colOkulID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOkulIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.tbIlce = New NeoDAC.NeoTable(Me.components)
        Me.tbIlce_IlceID = New System.Data.DataColumn()
        Me.tbIlce_IlID = New System.Data.DataColumn()
        Me.tbIlce_IlceIsmi = New System.Data.DataColumn()
        Me.tbIlce_IlIsmi = New System.Data.DataColumn()
        Me.tbIlce_DisplayMember = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIlceID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlceIsmi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbIl = New NeoDAC.NeoTable(Me.components)
        Me.tbIl_IlID = New System.Data.DataColumn()
        Me.tbIl_IlIsmi = New System.Data.DataColumn()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIlceID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlIsmi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlceIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisplayMember = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkulIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DeletedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OkulKodTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OkulIsmiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForOkulID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDeleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForOkulKod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForOkulIsmi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MasterTable_OkulID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_OkulKod = New System.Data.DataColumn()
        Me.MasterTable_OkulIsmi = New System.Data.DataColumn()
        Me.MasterTable_IlceID = New System.Data.DataColumn()
        Me.MasterTable_IlID = New System.Data.DataColumn()
        Me.MasterTable_Tel = New System.Data.DataColumn()
        Me.MasterTable_Fax = New System.Data.DataColumn()
        Me.MasterTable_Adres = New System.Data.DataColumn()
        Me.MasterTable_OkulTurID = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIlce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkulIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkulKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkulIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOkulID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOkulKod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOkulIsmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(535, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 341)
        Me.barDockControlBottom.Size = New System.Drawing.Size(535, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 274)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(535, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 274)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 108)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(535, 192)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(529, 164)
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.DataLayoutControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(529, 164)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DataLayoutControl1, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemGridLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(529, 84)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOkulID, Me.colDeleted, Me.colOkulKod, Me.colOkulIsmi, Me.colIlID, Me.colIlceID, Me.colIntCode})
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
        Me.panelBottom.Location = New System.Drawing.Point(0, 300)
        Me.panelBottom.Size = New System.Drawing.Size(535, 41)
        '
        'basePanelControl3
        '
        Me.basePanelControl3.Location = New System.Drawing.Point(337, 2)
        '
        'panelFormTop
        '
        Me.panelFormTop.Size = New System.Drawing.Size(535, 31)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_OkulID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_OkulKod, Me.MasterTable_OkulIsmi, Me.MasterTable_IlceID, Me.MasterTable_IlID, Me.MasterTable_Tel, Me.MasterTable_Fax, Me.MasterTable_Adres, Me.MasterTable_OkulTurID, Me.MasterTable_IntCode})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"OkulID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_OkulID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(893, 305)
        Me.BaseTab4.Tag = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        Me.txtTopInfo.Size = New System.Drawing.Size(535, 10)
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMainWarning1.Location = New System.Drawing.Point(0, 145)
        Me.lblMainWarning1.Size = New System.Drawing.Size(529, 19)
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 138)
        Me.panelAuthCodes.Size = New System.Drawing.Size(529, 26)
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
        Me.panelFormDateFilter.Size = New System.Drawing.Size(529, 61)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM Okullar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.SqlCommand4.CommandText = "UPDATE Okullar SET Deleted = OkulID  , ModifiedBy = @ModifiedBy , ModifiedDate = " &
    "GETDATE()   WHERE OkulID = @OkulID"
        '
        'colOkulID
        '
        Me.colOkulID.FieldName = "OkulID"
        Me.colOkulID.Name = "colOkulID"
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colOkulKod
        '
        Me.colOkulKod.FieldName = "OkulKod"
        Me.colOkulKod.Name = "colOkulKod"
        Me.colOkulKod.Visible = True
        Me.colOkulKod.VisibleIndex = 0
        Me.colOkulKod.Width = 117
        '
        'colOkulIsmi
        '
        Me.colOkulIsmi.FieldName = "OkulIsmi"
        Me.colOkulIsmi.Name = "colOkulIsmi"
        Me.colOkulIsmi.Visible = True
        Me.colOkulIsmi.VisibleIndex = 1
        Me.colOkulIsmi.Width = 142
        '
        'colIlceID
        '
        Me.colIlceID.Caption = "İlçe/Semt/Belde"
        Me.colIlceID.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colIlceID.FieldName = "IlceID"
        Me.colIlceID.Name = "colIlceID"
        Me.colIlceID.Visible = True
        Me.colIlceID.VisibleIndex = 3
        Me.colIlceID.Width = 146
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.tbIlce
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "IlceIsmi"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "IlceID"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'tbIlce
        '
        Me.tbIlce.Columns.AddRange(New System.Data.DataColumn() {Me.tbIlce_IlceID, Me.tbIlce_IlID, Me.tbIlce_IlceIsmi, Me.tbIlce_IlIsmi, Me.tbIlce_DisplayMember})
        Me.tbIlce.Connection = Me.FirmConn
        Me.tbIlce.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"IlceID"}, True)})
        Me.tbIlce.CurrentRow = Nothing
        Me.tbIlce.DataSourceLink = Nothing
        Me.tbIlce.DeleteCommand = Me.SqlCommand12
        Me.tbIlce.Filter = ""
        Me.tbIlce.InsertCommand = Me.SqlCommand10
        Me.tbIlce.LiveSave = False
        Me.tbIlce.MaxRecords = CType(0, Long)
        Me.tbIlce.Name = "tbIlce"
        Me.tbIlce.ParentRelation_ChildColumns = Nothing
        Me.tbIlce.ParentRelation_ParentColumns = Nothing
        Me.tbIlce.ParentRelation_Table = Nothing
        Me.tbIlce.Position = CType(-1, Long)
        Me.tbIlce.PrimaryKey = New System.Data.DataColumn() {Me.tbIlce_IlceID}
        Me.tbIlce.Quoted = False
        Me.tbIlce.SelectCommand = Me.SqlCommand9
        Me.tbIlce.TableName = "NeoTable1"
        Me.tbIlce.Transaction = Nothing
        Me.tbIlce.UpdateCommand = Me.SqlCommand11
        '
        'tbIlce_IlceID
        '
        Me.tbIlce_IlceID.AllowDBNull = False
        Me.tbIlce_IlceID.AutoIncrement = True
        Me.tbIlce_IlceID.ColumnName = "IlceID"
        Me.tbIlce_IlceID.DataType = GetType(Integer)
        '
        'tbIlce_IlID
        '
        Me.tbIlce_IlID.ColumnName = "IlID"
        Me.tbIlce_IlID.DataType = GetType(Integer)
        '
        'tbIlce_IlceIsmi
        '
        Me.tbIlce_IlceIsmi.ColumnName = "IlceIsmi"
        '
        'tbIlce_IlIsmi
        '
        Me.tbIlce_IlIsmi.ColumnName = "IlIsmi"
        '
        'tbIlce_DisplayMember
        '
        Me.tbIlce_DisplayMember.ColumnName = "DisplayMember"
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = resources.GetString("SqlCommand9.CommandText")
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIlceID2, Me.colIlIsmi, Me.colIlceIsmi1, Me.colIlID2})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colIlceID2
        '
        Me.colIlceID2.FieldName = "IlceID"
        Me.colIlceID2.Name = "colIlceID2"
        '
        'colIlIsmi
        '
        Me.colIlIsmi.FieldName = "IlIsmi"
        Me.colIlIsmi.Name = "colIlIsmi"
        Me.colIlIsmi.Visible = True
        Me.colIlIsmi.VisibleIndex = 0
        Me.colIlIsmi.Width = 126
        '
        'colIlceIsmi1
        '
        Me.colIlceIsmi1.FieldName = "IlceIsmi"
        Me.colIlceIsmi1.Name = "colIlceIsmi1"
        Me.colIlceIsmi1.Visible = True
        Me.colIlceIsmi1.VisibleIndex = 1
        Me.colIlceIsmi1.Width = 174
        '
        'colIlID2
        '
        Me.colIlID2.FieldName = "IlID"
        Me.colIlID2.Name = "colIlID2"
        '
        'colIlID
        '
        Me.colIlID.Caption = "İl/Şehir"
        Me.colIlID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIlID.FieldName = "IlID"
        Me.colIlID.Name = "colIlID"
        Me.colIlID.Visible = True
        Me.colIlID.VisibleIndex = 2
        Me.colIlID.Width = 124
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlIsmi", "Il Ismi", 38, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlID", "Il ID", 43, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.tbIl
        Me.RepositoryItemLookUpEdit1.DisplayMember = "IlIsmi"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "IlID"
        '
        'tbIl
        '
        Me.tbIl.Columns.AddRange(New System.Data.DataColumn() {Me.tbIl_IlID, Me.tbIl_IlIsmi})
        Me.tbIl.Connection = Me.FirmConn
        Me.tbIl.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"IlID"}, True)})
        Me.tbIl.CurrentRow = Nothing
        Me.tbIl.DataSourceLink = Nothing
        Me.tbIl.DeleteCommand = Me.SqlCommand8
        Me.tbIl.Filter = ""
        Me.tbIl.InsertCommand = Me.SqlCommand6
        Me.tbIl.LiveSave = False
        Me.tbIl.MaxRecords = CType(0, Long)
        Me.tbIl.Name = "tbIl"
        Me.tbIl.ParentRelation_ChildColumns = Nothing
        Me.tbIl.ParentRelation_ParentColumns = Nothing
        Me.tbIl.ParentRelation_Table = Nothing
        Me.tbIl.Position = CType(-1, Long)
        Me.tbIl.PrimaryKey = New System.Data.DataColumn() {Me.tbIl_IlID}
        Me.tbIl.Quoted = False
        Me.tbIl.SelectCommand = Me.SqlCommand5
        Me.tbIl.TableName = "NeoTable1"
        Me.tbIl.Transaction = Nothing
        Me.tbIl.UpdateCommand = Me.SqlCommand7
        '
        'tbIl_IlID
        '
        Me.tbIl_IlID.AllowDBNull = False
        Me.tbIl_IlID.AutoIncrement = True
        Me.tbIl_IlID.ColumnName = "IlID"
        Me.tbIl_IlID.DataType = GetType(Integer)
        '
        'tbIl_IlIsmi
        '
        Me.tbIl_IlIsmi.ColumnName = "IlIsmi"
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT IlID,IlIsmi FROM Il" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Order BY IlIsmi"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit4)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit3)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit2)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.GridLookUpEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.OkulIDSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DeletedSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OkulKodTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.OkulIsmiTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MasterLink
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOkulID, Me.ItemForDeleted})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(395, 195, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(529, 138)
        Me.DataLayoutControl1.TabIndex = 1
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Fax", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(351, 84)
        Me.TextEdit4.MenuManager = Me.BarManager1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit4.StyleController = Me.DataLayoutControl1
        Me.TextEdit4.TabIndex = 10
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Tel", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(105, 84)
        Me.TextEdit3.MenuManager = Me.BarManager1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit3.StyleController = Me.DataLayoutControl1
        Me.TextEdit3.TabIndex = 9
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Adres", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(105, 60)
        Me.TextEdit2.MenuManager = Me.BarManager1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(395, 20)
        Me.TextEdit2.StyleController = Me.DataLayoutControl1
        Me.TextEdit2.TabIndex = 8
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IntCode", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(105, 132)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(259, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 7
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IlceID", True))
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.EnterMoveNextControl = True
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(105, 108)
        Me.GridLookUpEdit1.MenuManager = Me.BarManager1
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.tbIlce
        Me.GridLookUpEdit1.Properties.DisplayMember = "DisplayMember"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.ShowFooter = False
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "IlceID"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(259, 20)
        Me.GridLookUpEdit1.StyleController = Me.DataLayoutControl1
        Me.GridLookUpEdit1.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIlceID1, Me.colIlIsmi1, Me.colIlceIsmi, Me.colIlID1, Me.colDisplayMember})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colIlceID1
        '
        Me.colIlceID1.FieldName = "IlceID"
        Me.colIlceID1.Name = "colIlceID1"
        '
        'colIlIsmi1
        '
        Me.colIlIsmi1.FieldName = "IlIsmi"
        Me.colIlIsmi1.Name = "colIlIsmi1"
        Me.colIlIsmi1.Visible = True
        Me.colIlIsmi1.VisibleIndex = 0
        Me.colIlIsmi1.Width = 129
        '
        'colIlceIsmi
        '
        Me.colIlceIsmi.FieldName = "IlceIsmi"
        Me.colIlceIsmi.Name = "colIlceIsmi"
        Me.colIlceIsmi.Visible = True
        Me.colIlceIsmi.VisibleIndex = 1
        Me.colIlceIsmi.Width = 192
        '
        'colIlID1
        '
        Me.colIlID1.FieldName = "IlID"
        Me.colIlID1.Name = "colIlID1"
        '
        'colDisplayMember
        '
        Me.colDisplayMember.FieldName = "DisplayMember"
        Me.colDisplayMember.Name = "colDisplayMember"
        '
        'OkulIDSpinEdit
        '
        Me.OkulIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OkulID", True))
        Me.OkulIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OkulIDSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.OkulIDSpinEdit.MenuManager = Me.BarManager1
        Me.OkulIDSpinEdit.Name = "OkulIDSpinEdit"
        Me.OkulIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OkulIDSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.OkulIDSpinEdit.StyleController = Me.DataLayoutControl1
        Me.OkulIDSpinEdit.TabIndex = 4
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
        'OkulKodTextEdit
        '
        Me.OkulKodTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OkulKod", True))
        Me.OkulKodTextEdit.EnterMoveNextControl = True
        Me.OkulKodTextEdit.Location = New System.Drawing.Point(105, 12)
        Me.OkulKodTextEdit.MenuManager = Me.BarManager1
        Me.OkulKodTextEdit.Name = "OkulKodTextEdit"
        Me.OkulKodTextEdit.Size = New System.Drawing.Size(108, 20)
        Me.OkulKodTextEdit.StyleController = Me.DataLayoutControl1
        Me.OkulKodTextEdit.TabIndex = 6
        '
        'OkulIsmiTextEdit
        '
        Me.OkulIsmiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "OkulIsmi", True))
        Me.OkulIsmiTextEdit.EnterMoveNextControl = True
        Me.OkulIsmiTextEdit.Location = New System.Drawing.Point(105, 36)
        Me.OkulIsmiTextEdit.MenuManager = Me.BarManager1
        Me.OkulIsmiTextEdit.Name = "OkulIsmiTextEdit"
        Me.OkulIsmiTextEdit.Size = New System.Drawing.Size(395, 20)
        Me.OkulIsmiTextEdit.StyleController = Me.DataLayoutControl1
        Me.OkulIsmiTextEdit.TabIndex = 7
        '
        'ItemForOkulID
        '
        Me.ItemForOkulID.Control = Me.OkulIDSpinEdit
        Me.ItemForOkulID.CustomizationFormText = "Okul ID"
        Me.ItemForOkulID.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOkulID.Name = "ItemForOkulID"
        Me.ItemForOkulID.Size = New System.Drawing.Size(0, 0)
        Me.ItemForOkulID.Text = "Okul ID"
        Me.ItemForOkulID.TextSize = New System.Drawing.Size(50, 20)
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(512, 164)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOkulKod, Me.ItemForOkulIsmi, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(492, 48)
        '
        'ItemForOkulKod
        '
        Me.ItemForOkulKod.Control = Me.OkulKodTextEdit
        Me.ItemForOkulKod.CustomizationFormText = "Okul Kod"
        Me.ItemForOkulKod.Location = New System.Drawing.Point(0, 0)
        Me.ItemForOkulKod.Name = "ItemForOkulKod"
        Me.ItemForOkulKod.Size = New System.Drawing.Size(205, 24)
        Me.ItemForOkulKod.Text = "Okul Kod"
        Me.ItemForOkulKod.TextSize = New System.Drawing.Size(88, 13)
        '
        'ItemForOkulIsmi
        '
        Me.ItemForOkulIsmi.Control = Me.OkulIsmiTextEdit
        Me.ItemForOkulIsmi.CustomizationFormText = "Okul Ismi"
        Me.ItemForOkulIsmi.Location = New System.Drawing.Point(0, 24)
        Me.ItemForOkulIsmi.Name = "ItemForOkulIsmi"
        Me.ItemForOkulIsmi.Size = New System.Drawing.Size(492, 24)
        Me.ItemForOkulIsmi.Text = "Okul Ismi"
        Me.ItemForOkulIsmi.TextSize = New System.Drawing.Size(88, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(205, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(287, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridLookUpEdit1
        Me.LayoutControlItem1.CustomizationFormText = "İlçe/Semt"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(356, 24)
        Me.LayoutControlItem1.Text = "İl / İlçe"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(88, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(356, 96)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(136, 48)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextEdit1
        Me.LayoutControlItem2.CustomizationFormText = "Entegrasyon Kodu"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(356, 24)
        Me.LayoutControlItem2.Text = "Entegrasyon Kodu"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextEdit2
        Me.LayoutControlItem3.CustomizationFormText = "Adres"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(492, 24)
        Me.LayoutControlItem3.Text = "Adres"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextEdit3
        Me.LayoutControlItem4.CustomizationFormText = "Tel"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem4.Text = "Tel"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TextEdit4
        Me.LayoutControlItem5.CustomizationFormText = "Faks"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(246, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem5.Text = "Faks"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 13)
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlceIsmi", "Ilce Ismi", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlceID", "Ilce ID", 54, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.tbIlce
        Me.RepositoryItemLookUpEdit2.DisplayMember = "IlceIsmi"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "IlceID"
        '
        'MasterTable_OkulID
        '
        Me.MasterTable_OkulID.AllowDBNull = False
        Me.MasterTable_OkulID.AutoIncrement = True
        Me.MasterTable_OkulID.ColumnName = "OkulID"
        Me.MasterTable_OkulID.DataType = GetType(Integer)
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
        'MasterTable_OkulKod
        '
        Me.MasterTable_OkulKod.ColumnName = "OkulKod"
        '
        'MasterTable_OkulIsmi
        '
        Me.MasterTable_OkulIsmi.ColumnName = "OkulIsmi"
        '
        'MasterTable_IlceID
        '
        Me.MasterTable_IlceID.ColumnName = "IlceID"
        Me.MasterTable_IlceID.DataType = GetType(Integer)
        '
        'MasterTable_IlID
        '
        Me.MasterTable_IlID.ColumnName = "IlID"
        Me.MasterTable_IlID.DataType = GetType(Integer)
        '
        'MasterTable_Tel
        '
        Me.MasterTable_Tel.ColumnName = "Tel"
        '
        'MasterTable_Fax
        '
        Me.MasterTable_Fax.ColumnName = "Fax"
        '
        'MasterTable_Adres
        '
        Me.MasterTable_Adres.ColumnName = "Adres"
        '
        'MasterTable_OkulTurID
        '
        Me.MasterTable_OkulTurID.ColumnName = "OkulTurID"
        Me.MasterTable_OkulTurID.DataType = GetType(Integer)
        '
        'MasterTable_IntCode
        '
        Me.MasterTable_IntCode.ColumnName = "IntCode"
        '
        'colIntCode
        '
        Me.colIntCode.Caption = "Entegrasyon Kodu"
        Me.colIntCode.FieldName = "IntCode"
        Me.colIntCode.Name = "colIntCode"
        Me.colIntCode.Visible = True
        Me.colIntCode.VisibleIndex = 4
        Me.colIntCode.Width = 142
        '
        'frmOkullar
        '
        Me.ClientSize = New System.Drawing.Size(535, 364)
        Me.FormCode = "000005"
        Me.Name = "frmOkullar"
        Me.Text = "Okullar"
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
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIlce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkulIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletedSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkulKodTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkulIsmiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOkulID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOkulKod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOkulIsmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colOkulID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOkulIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbIl As NeoDAC.NeoTable
    Friend WithEvents tbIl_IlID As System.Data.DataColumn
    Friend WithEvents tbIl_IlIsmi As System.Data.DataColumn
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbIlce As NeoDAC.NeoTable
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIlceID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlceIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OkulIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DeletedSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OkulKodTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OkulIsmiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForOkulID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDeleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForOkulKod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForOkulIsmi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIlceID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlceIsmi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbIlce_IlceID As System.Data.DataColumn
    Friend WithEvents tbIlce_IlID As System.Data.DataColumn
    Friend WithEvents tbIlce_IlceIsmi As System.Data.DataColumn
    Friend WithEvents tbIlce_IlIsmi As System.Data.DataColumn
    Friend WithEvents tbIlce_DisplayMember As System.Data.DataColumn
    Friend WithEvents colIlIsmi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisplayMember As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterTable_OkulID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_OkulKod As System.Data.DataColumn
    Friend WithEvents MasterTable_OkulIsmi As System.Data.DataColumn
    Friend WithEvents MasterTable_IlceID As System.Data.DataColumn
    Friend WithEvents MasterTable_IlID As System.Data.DataColumn
    Friend WithEvents MasterTable_Tel As System.Data.DataColumn
    Friend WithEvents MasterTable_Fax As System.Data.DataColumn
    Friend WithEvents MasterTable_Adres As System.Data.DataColumn
    Friend WithEvents MasterTable_OkulTurID As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

End Class
