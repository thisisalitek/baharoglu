<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cnt015_Fular
    Inherits ProbarSiparis.BaseControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnt015_Fular))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.NeoTable1 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable1_nID = New System.Data.DataColumn()
        Me.NeoTable1_Deleted = New System.Data.DataColumn()
        Me.NeoTable1_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable1_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable1_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable1_ParcaIsmi = New System.Data.DataColumn()
        Me.NeoTable1_Iplik = New System.Data.DataColumn()
        Me.NeoTable1_IpGramaj = New System.Data.DataColumn()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriParamID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcaIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIplik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbIplik = New NeoDAC.NeoTable(Me.components)
        Me.tbIplik_IplikID = New System.Data.DataColumn()
        Me.tbIplik_Deleted = New System.Data.DataColumn()
        Me.tbIplik_CreatedBy = New System.Data.DataColumn()
        Me.tbIplik_CreatedDate = New System.Data.DataColumn()
        Me.tbIplik_ModifiedBy = New System.Data.DataColumn()
        Me.tbIplik_ModifiedDate = New System.Data.DataColumn()
        Me.tbIplik_IplikKod = New System.Data.DataColumn()
        Me.tbIplik_IplikIsmi = New System.Data.DataColumn()
        Me.tbIplik_IntCode = New System.Data.DataColumn()
        Me.tbIplik_Pasif = New System.Data.DataColumn()
        Me.tbIplik_StokFiltre = New System.Data.DataColumn()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.colIpGramaj = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboOrguTip1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbOrguTip = New NeoDAC.NeoTable(Me.components)
        Me.tbOrguTip_OrguTipID = New System.Data.DataColumn()
        Me.tbOrguTip_OrguTipKod = New System.Data.DataColumn()
        Me.tbOrguTip_OrguTipIsmi = New System.Data.DataColumn()
        Me.tbOrguTip_Fiyat = New System.Data.DataColumn()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.MasterTable_KategoriParamID = New System.Data.DataColumn()
        Me.MasterTable_KategoriID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_ParamType = New System.Data.DataColumn()
        Me.MasterTable_Param1 = New System.Data.DataColumn()
        Me.MasterTable_Param2 = New System.Data.DataColumn()
        Me.MasterTable_Param3 = New System.Data.DataColumn()
        Me.MasterTable_Param4 = New System.Data.DataColumn()
        Me.MasterTable_Param5 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt1 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt2 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt3 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt4 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt5 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat1 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat2 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat3 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat4 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat5 = New System.Data.DataColumn()
        Me.MasterTable_KategoriParamID_1 = New System.Data.DataColumn()
        Me.MasterTable_KategoriID_1 = New System.Data.DataColumn()
        Me.MasterTable_Deleted_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamType_1 = New System.Data.DataColumn()
        Me.MasterTable_Param1_1 = New System.Data.DataColumn()
        Me.MasterTable_Param2_1 = New System.Data.DataColumn()
        Me.MasterTable_Param3_1 = New System.Data.DataColumn()
        Me.MasterTable_Param4_1 = New System.Data.DataColumn()
        Me.MasterTable_Param5_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt1_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt2_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt3_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt4_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamInt5_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat1_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat2_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat3_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat4_1 = New System.Data.DataColumn()
        Me.MasterTable_ParamFloat5_1 = New System.Data.DataColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.NeoTable2 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable2_nID = New System.Data.DataColumn()
        Me.NeoTable2_Deleted = New System.Data.DataColumn()
        Me.NeoTable2_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable2_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable2_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable2_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable2_SipDetayParamID = New System.Data.DataColumn()
        Me.NeoTable2_SourceID = New System.Data.DataColumn()
        Me.NeoTable2_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable2_ParcaIsmi = New System.Data.DataColumn()
        Me.NeoTable2_Iplik = New System.Data.DataColumn()
        Me.NeoTable2_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable2_RenkID = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSipDetayParamID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRenkID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboGridRenk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbRenk = New NeoDAC.NeoTable(Me.components)
        Me.tbRenk_RenkID = New System.Data.DataColumn()
        Me.tbRenk_RenkKod = New System.Data.DataColumn()
        Me.tbRenk_RenkIsmi = New System.Data.DataColumn()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCaption.SuspendLayout()
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrguTip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOrguTip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGridRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.Size = New System.Drawing.Size(159, 17)
        Me.lblCaption.Text = "Fular"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(264, 124)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Size = New System.Drawing.Size(256, 96)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Controls.Add(Me.RadioGroup1)
        Me.XtraTabPage2.Size = New System.Drawing.Size(256, 96)
        '
        'panelCaption
        '
        Me.panelCaption.Size = New System.Drawing.Size(264, 26)
        '
        'chkSecmeli
        '
        Me.chkSecmeli.Location = New System.Drawing.Point(202, 4)
        '
        'chkVar
        '
        Me.chkVar.Location = New System.Drawing.Point(163, 4)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.NeoTable1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.cboOrguTip1})
        Me.GridControl1.Size = New System.Drawing.Size(256, 96)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'NeoTable1
        '
        Me.NeoTable1.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable1_nID, Me.NeoTable1_Deleted, Me.NeoTable1_CreatedBy, Me.NeoTable1_CreatedDate, Me.NeoTable1_ModifiedBy, Me.NeoTable1_ModifiedDate, Me.NeoTable1_KategoriParamID, Me.NeoTable1_ParcaIsmi, Me.NeoTable1_Iplik, Me.NeoTable1_IpGramaj})
        Me.NeoTable1.Connection = Me.SqlConn
        Me.NeoTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable1.CurrentRow = Nothing
        Me.NeoTable1.DataSourceLink = Nothing
        Me.NeoTable1.DeleteCommand = Me.SqlCommand4
        Me.NeoTable1.Filter = ""
        Me.NeoTable1.InsertCommand = Me.SqlCommand2
        Me.NeoTable1.LiveSave = False
        Me.NeoTable1.MaxRecords = CType(0, Long)
        Me.NeoTable1.Name = "NeoTable1"
        Me.NeoTable1.ParentRelation_ChildColumns = Nothing
        Me.NeoTable1.ParentRelation_ParentColumns = Nothing
        Me.NeoTable1.ParentRelation_Table = Nothing
        Me.NeoTable1.Position = CType(-1, Long)
        Me.NeoTable1.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable1_nID}
        Me.NeoTable1.Quoted = False
        Me.NeoTable1.SelectCommand = Me.SqlCommand1
        Me.NeoTable1.TableName = "NeoTable1"
        Me.NeoTable1.Transaction = Nothing
        Me.NeoTable1.UpdateCommand = Me.SqlCommand3
        '
        'NeoTable1_nID
        '
        Me.NeoTable1_nID.AllowDBNull = False
        Me.NeoTable1_nID.AutoIncrement = True
        Me.NeoTable1_nID.ColumnName = "nID"
        Me.NeoTable1_nID.DataType = GetType(Integer)
        '
        'NeoTable1_Deleted
        '
        Me.NeoTable1_Deleted.ColumnName = "Deleted"
        Me.NeoTable1_Deleted.DataType = GetType(Integer)
        '
        'NeoTable1_CreatedBy
        '
        Me.NeoTable1_CreatedBy.ColumnName = "CreatedBy"
        Me.NeoTable1_CreatedBy.DataType = GetType(Integer)
        '
        'NeoTable1_CreatedDate
        '
        Me.NeoTable1_CreatedDate.ColumnName = "CreatedDate"
        Me.NeoTable1_CreatedDate.DataType = GetType(Date)
        '
        'NeoTable1_ModifiedBy
        '
        Me.NeoTable1_ModifiedBy.ColumnName = "ModifiedBy"
        Me.NeoTable1_ModifiedBy.DataType = GetType(Integer)
        '
        'NeoTable1_ModifiedDate
        '
        Me.NeoTable1_ModifiedDate.ColumnName = "ModifiedDate"
        Me.NeoTable1_ModifiedDate.DataType = GetType(Date)
        '
        'NeoTable1_KategoriParamID
        '
        Me.NeoTable1_KategoriParamID.ColumnName = "KategoriParamID"
        Me.NeoTable1_KategoriParamID.DataType = GetType(Integer)
        '
        'NeoTable1_ParcaIsmi
        '
        Me.NeoTable1_ParcaIsmi.ColumnName = "ParcaIsmi"
        '
        'NeoTable1_Iplik
        '
        Me.NeoTable1_Iplik.ColumnName = "Iplik"
        Me.NeoTable1_Iplik.DataType = GetType(Integer)
        '
        'NeoTable1_IpGramaj
        '
        Me.NeoTable1_IpGramaj.ColumnName = "IpGramaj"
        Me.NeoTable1_IpGramaj.DataType = GetType(Double)
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KategoriParam_015_Fular SET Deleted = nID  , ModifiedBy = @ModifiedBy , Mo" & _
            "difiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM KategoriParam_015_Fular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 "
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnID, Me.colKategoriParamID, Me.colKategoriID, Me.colParcaIsmi, Me.colIplik, Me.colIpGramaj})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnID
        '
        Me.colnID.FieldName = "nID"
        Me.colnID.Name = "colnID"
        '
        'colKategoriParamID
        '
        Me.colKategoriParamID.FieldName = "KategoriParamID"
        Me.colKategoriParamID.Name = "colKategoriParamID"
        '
        'colKategoriID
        '
        Me.colKategoriID.FieldName = "KategoriID"
        Me.colKategoriID.Name = "colKategoriID"
        '
        'colParcaIsmi
        '
        Me.colParcaIsmi.FieldName = "ParcaIsmi"
        Me.colParcaIsmi.Name = "colParcaIsmi"
        Me.colParcaIsmi.Visible = True
        Me.colParcaIsmi.VisibleIndex = 0
        Me.colParcaIsmi.Width = 78
        '
        'colIplik
        '
        Me.colIplik.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIplik.FieldName = "Iplik"
        Me.colIplik.Name = "colIplik"
        Me.colIplik.Visible = True
        Me.colIplik.VisibleIndex = 1
        Me.colIplik.Width = 108
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.tbIplik
        Me.RepositoryItemLookUpEdit1.DisplayMember = "IplikKod"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "IplikID"
        '
        'tbIplik
        '
        Me.tbIplik.Columns.AddRange(New System.Data.DataColumn() {Me.tbIplik_IplikID, Me.tbIplik_Deleted, Me.tbIplik_CreatedBy, Me.tbIplik_CreatedDate, Me.tbIplik_ModifiedBy, Me.tbIplik_ModifiedDate, Me.tbIplik_IplikKod, Me.tbIplik_IplikIsmi, Me.tbIplik_IntCode, Me.tbIplik_Pasif, Me.tbIplik_StokFiltre})
        Me.tbIplik.Connection = Me.SqlConn
        Me.tbIplik.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"IplikID"}, True)})
        Me.tbIplik.CurrentRow = Nothing
        Me.tbIplik.DataSourceLink = Nothing
        Me.tbIplik.DeleteCommand = Me.SqlCommand8
        Me.tbIplik.Filter = ""
        Me.tbIplik.InsertCommand = Me.SqlCommand6
        Me.tbIplik.LiveSave = False
        Me.tbIplik.MaxRecords = CType(0, Long)
        Me.tbIplik.Name = "tbIplik"
        Me.tbIplik.ParentRelation_ChildColumns = Nothing
        Me.tbIplik.ParentRelation_ParentColumns = Nothing
        Me.tbIplik.ParentRelation_Table = Nothing
        Me.tbIplik.Position = CType(-1, Long)
        Me.tbIplik.PrimaryKey = New System.Data.DataColumn() {Me.tbIplik_IplikID}
        Me.tbIplik.Quoted = False
        Me.tbIplik.SelectCommand = Me.SqlCommand5
        Me.tbIplik.TableName = "NeoTable2"
        Me.tbIplik.Transaction = Nothing
        Me.tbIplik.UpdateCommand = Me.SqlCommand7
        '
        'tbIplik_IplikID
        '
        Me.tbIplik_IplikID.AllowDBNull = False
        Me.tbIplik_IplikID.AutoIncrement = True
        Me.tbIplik_IplikID.ColumnName = "IplikID"
        Me.tbIplik_IplikID.DataType = GetType(Integer)
        '
        'tbIplik_Deleted
        '
        Me.tbIplik_Deleted.ColumnName = "Deleted"
        Me.tbIplik_Deleted.DataType = GetType(Integer)
        '
        'tbIplik_CreatedBy
        '
        Me.tbIplik_CreatedBy.ColumnName = "CreatedBy"
        Me.tbIplik_CreatedBy.DataType = GetType(Integer)
        '
        'tbIplik_CreatedDate
        '
        Me.tbIplik_CreatedDate.ColumnName = "CreatedDate"
        Me.tbIplik_CreatedDate.DataType = GetType(Date)
        '
        'tbIplik_ModifiedBy
        '
        Me.tbIplik_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbIplik_ModifiedBy.DataType = GetType(Integer)
        '
        'tbIplik_ModifiedDate
        '
        Me.tbIplik_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbIplik_ModifiedDate.DataType = GetType(Date)
        '
        'tbIplik_IplikKod
        '
        Me.tbIplik_IplikKod.ColumnName = "IplikKod"
        '
        'tbIplik_IplikIsmi
        '
        Me.tbIplik_IplikIsmi.ColumnName = "IplikIsmi"
        '
        'tbIplik_IntCode
        '
        Me.tbIplik_IntCode.ColumnName = "IntCode"
        '
        'tbIplik_Pasif
        '
        Me.tbIplik_Pasif.ColumnName = "Pasif"
        Me.tbIplik_Pasif.DataType = GetType(Integer)
        '
        'tbIplik_StokFiltre
        '
        Me.tbIplik_StokFiltre.ColumnName = "StokFiltre"
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM Iplikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where Deleted= 0 "
        '
        'colIpGramaj
        '
        Me.colIpGramaj.Caption = "İp Grm."
        Me.colIpGramaj.FieldName = "IpGramaj"
        Me.colIpGramaj.Name = "colIpGramaj"
        Me.colIpGramaj.Visible = True
        Me.colIpGramaj.VisibleIndex = 2
        Me.colIpGramaj.Width = 47
        '
        'cboOrguTip1
        '
        Me.cboOrguTip1.AutoHeight = False
        Me.cboOrguTip1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboOrguTip1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrguTip1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrguTipKod", "Orgu Tip Kod", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrguTipIsmi", "Orgu Tip Ismi", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrguTipID", "Orgu Tip ID", 78, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.cboOrguTip1.DataSource = Me.tbOrguTip
        Me.cboOrguTip1.DisplayMember = "OrguTipKod"
        Me.cboOrguTip1.Name = "cboOrguTip1"
        Me.cboOrguTip1.NullText = ""
        Me.cboOrguTip1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboOrguTip1.ValueMember = "OrguTipID"
        '
        'tbOrguTip
        '
        Me.tbOrguTip.Columns.AddRange(New System.Data.DataColumn() {Me.tbOrguTip_OrguTipID, Me.tbOrguTip_OrguTipKod, Me.tbOrguTip_OrguTipIsmi, Me.tbOrguTip_Fiyat})
        Me.tbOrguTip.Connection = Me.SqlConn
        Me.tbOrguTip.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"OrguTipID"}, True)})
        Me.tbOrguTip.CurrentRow = Nothing
        Me.tbOrguTip.DataSourceLink = Nothing
        Me.tbOrguTip.DeleteCommand = Me.SqlCommand20
        Me.tbOrguTip.Filter = ""
        Me.tbOrguTip.InsertCommand = Me.SqlCommand18
        Me.tbOrguTip.LiveSave = False
        Me.tbOrguTip.MaxRecords = CType(0, Long)
        Me.tbOrguTip.Name = "tbOrguTip"
        Me.tbOrguTip.ParentRelation_ChildColumns = Nothing
        Me.tbOrguTip.ParentRelation_ParentColumns = Nothing
        Me.tbOrguTip.ParentRelation_Table = Nothing
        Me.tbOrguTip.Position = CType(-1, Long)
        Me.tbOrguTip.PrimaryKey = New System.Data.DataColumn() {Me.tbOrguTip_OrguTipID}
        Me.tbOrguTip.Quoted = False
        Me.tbOrguTip.SelectCommand = Me.SqlCommand17
        Me.tbOrguTip.TableName = "NeoTable3"
        Me.tbOrguTip.Transaction = Nothing
        Me.tbOrguTip.UpdateCommand = Me.SqlCommand19
        '
        'tbOrguTip_OrguTipID
        '
        Me.tbOrguTip_OrguTipID.AllowDBNull = False
        Me.tbOrguTip_OrguTipID.AutoIncrement = True
        Me.tbOrguTip_OrguTipID.ColumnName = "OrguTipID"
        Me.tbOrguTip_OrguTipID.DataType = GetType(Integer)
        '
        'tbOrguTip_OrguTipKod
        '
        Me.tbOrguTip_OrguTipKod.ColumnName = "OrguTipKod"
        '
        'tbOrguTip_OrguTipIsmi
        '
        Me.tbOrguTip_OrguTipIsmi.ColumnName = "OrguTipIsmi"
        '
        'tbOrguTip_Fiyat
        '
        Me.tbOrguTip_Fiyat.ColumnName = "Fiyat"
        Me.tbOrguTip_Fiyat.DataType = GetType(Double)
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     OrguTipID, OrguTipKod, OrguTipIsmi,Fiyat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         OrguTipleri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WH" & _
            "ERE Deleted = 0 AND bLakos=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY OrguTipKod"
        '
        'MasterTable_KategoriParamID
        '
        Me.MasterTable_KategoriParamID.AllowDBNull = False
        Me.MasterTable_KategoriParamID.AutoIncrement = True
        Me.MasterTable_KategoriParamID.ColumnName = "KategoriParamID"
        Me.MasterTable_KategoriParamID.DataType = GetType(Integer)
        '
        'MasterTable_KategoriID
        '
        Me.MasterTable_KategoriID.ColumnName = "KategoriID"
        Me.MasterTable_KategoriID.DataType = GetType(Integer)
        '
        'MasterTable_Deleted
        '
        Me.MasterTable_Deleted.ColumnName = "Deleted"
        Me.MasterTable_Deleted.DataType = GetType(Integer)
        '
        'MasterTable_ParamType
        '
        Me.MasterTable_ParamType.ColumnName = "ParamType"
        '
        'MasterTable_Param1
        '
        Me.MasterTable_Param1.ColumnName = "Param1"
        '
        'MasterTable_Param2
        '
        Me.MasterTable_Param2.ColumnName = "Param2"
        '
        'MasterTable_Param3
        '
        Me.MasterTable_Param3.ColumnName = "Param3"
        '
        'MasterTable_Param4
        '
        Me.MasterTable_Param4.ColumnName = "Param4"
        '
        'MasterTable_Param5
        '
        Me.MasterTable_Param5.ColumnName = "Param5"
        '
        'MasterTable_ParamInt1
        '
        Me.MasterTable_ParamInt1.ColumnName = "ParamInt1"
        Me.MasterTable_ParamInt1.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt2
        '
        Me.MasterTable_ParamInt2.ColumnName = "ParamInt2"
        Me.MasterTable_ParamInt2.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt3
        '
        Me.MasterTable_ParamInt3.ColumnName = "ParamInt3"
        Me.MasterTable_ParamInt3.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt4
        '
        Me.MasterTable_ParamInt4.ColumnName = "ParamInt4"
        Me.MasterTable_ParamInt4.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt5
        '
        Me.MasterTable_ParamInt5.ColumnName = "ParamInt5"
        Me.MasterTable_ParamInt5.DataType = GetType(Integer)
        '
        'MasterTable_ParamFloat1
        '
        Me.MasterTable_ParamFloat1.ColumnName = "ParamFloat1"
        Me.MasterTable_ParamFloat1.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat2
        '
        Me.MasterTable_ParamFloat2.ColumnName = "ParamFloat2"
        Me.MasterTable_ParamFloat2.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat3
        '
        Me.MasterTable_ParamFloat3.ColumnName = "ParamFloat3"
        Me.MasterTable_ParamFloat3.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat4
        '
        Me.MasterTable_ParamFloat4.ColumnName = "ParamFloat4"
        Me.MasterTable_ParamFloat4.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat5
        '
        Me.MasterTable_ParamFloat5.ColumnName = "ParamFloat5"
        Me.MasterTable_ParamFloat5.DataType = GetType(Double)
        '
        'MasterTable_KategoriParamID_1
        '
        Me.MasterTable_KategoriParamID_1.AutoIncrement = True
        Me.MasterTable_KategoriParamID_1.ColumnName = "KategoriParamID"
        Me.MasterTable_KategoriParamID_1.DataType = GetType(Integer)
        '
        'MasterTable_KategoriID_1
        '
        Me.MasterTable_KategoriID_1.ColumnName = "KategoriID"
        Me.MasterTable_KategoriID_1.DataType = GetType(Integer)
        '
        'MasterTable_Deleted_1
        '
        Me.MasterTable_Deleted_1.ColumnName = "Deleted"
        Me.MasterTable_Deleted_1.DataType = GetType(Integer)
        '
        'MasterTable_ParamType_1
        '
        Me.MasterTable_ParamType_1.ColumnName = "ParamType"
        '
        'MasterTable_Param1_1
        '
        Me.MasterTable_Param1_1.ColumnName = "Param1"
        '
        'MasterTable_Param2_1
        '
        Me.MasterTable_Param2_1.ColumnName = "Param2"
        '
        'MasterTable_Param3_1
        '
        Me.MasterTable_Param3_1.ColumnName = "Param3"
        '
        'MasterTable_Param4_1
        '
        Me.MasterTable_Param4_1.ColumnName = "Param4"
        '
        'MasterTable_Param5_1
        '
        Me.MasterTable_Param5_1.ColumnName = "Param5"
        '
        'MasterTable_ParamInt1_1
        '
        Me.MasterTable_ParamInt1_1.ColumnName = "ParamInt1"
        Me.MasterTable_ParamInt1_1.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt2_1
        '
        Me.MasterTable_ParamInt2_1.ColumnName = "ParamInt2"
        Me.MasterTable_ParamInt2_1.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt3_1
        '
        Me.MasterTable_ParamInt3_1.ColumnName = "ParamInt3"
        Me.MasterTable_ParamInt3_1.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt4_1
        '
        Me.MasterTable_ParamInt4_1.ColumnName = "ParamInt4"
        Me.MasterTable_ParamInt4_1.DataType = GetType(Integer)
        '
        'MasterTable_ParamInt5_1
        '
        Me.MasterTable_ParamInt5_1.ColumnName = "ParamInt5"
        Me.MasterTable_ParamInt5_1.DataType = GetType(Integer)
        '
        'MasterTable_ParamFloat1_1
        '
        Me.MasterTable_ParamFloat1_1.ColumnName = "ParamFloat1"
        Me.MasterTable_ParamFloat1_1.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat2_1
        '
        Me.MasterTable_ParamFloat2_1.ColumnName = "ParamFloat2"
        Me.MasterTable_ParamFloat2_1.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat3_1
        '
        Me.MasterTable_ParamFloat3_1.ColumnName = "ParamFloat3"
        Me.MasterTable_ParamFloat3_1.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat4_1
        '
        Me.MasterTable_ParamFloat4_1.ColumnName = "ParamFloat4"
        Me.MasterTable_ParamFloat4_1.DataType = GetType(Double)
        '
        'MasterTable_ParamFloat5_1
        '
        Me.MasterTable_ParamFloat5_1.ColumnName = "ParamFloat5"
        Me.MasterTable_ParamFloat5_1.DataType = GetType(Double)
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.NeoTable2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGridRenk})
        Me.GridControl2.Size = New System.Drawing.Size(256, 68)
        Me.GridControl2.TabIndex = 3
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'NeoTable2
        '
        Me.NeoTable2.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable2_nID, Me.NeoTable2_Deleted, Me.NeoTable2_CreatedBy, Me.NeoTable2_CreatedDate, Me.NeoTable2_ModifiedBy, Me.NeoTable2_ModifiedDate, Me.NeoTable2_SipDetayParamID, Me.NeoTable2_SourceID, Me.NeoTable2_KategoriParamID, Me.NeoTable2_ParcaIsmi, Me.NeoTable2_Iplik, Me.NeoTable2_IpGramaj, Me.NeoTable2_RenkID})
        Me.NeoTable2.Connection = Me.SqlConn
        Me.NeoTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable2.CurrentRow = Nothing
        Me.NeoTable2.DataSourceLink = Nothing
        Me.NeoTable2.DeleteCommand = Me.SqlCommand12
        Me.NeoTable2.Filter = ""
        Me.NeoTable2.InsertCommand = Me.SqlCommand10
        Me.NeoTable2.LiveSave = False
        Me.NeoTable2.MaxRecords = CType(0, Long)
        Me.NeoTable2.Name = "NeoTable2"
        Me.NeoTable2.ParentRelation_ChildColumns = Nothing
        Me.NeoTable2.ParentRelation_ParentColumns = Nothing
        Me.NeoTable2.ParentRelation_Table = Nothing
        Me.NeoTable2.Position = CType(-1, Long)
        Me.NeoTable2.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable2_nID}
        Me.NeoTable2.Quoted = False
        Me.NeoTable2.SelectCommand = Me.SqlCommand9
        Me.NeoTable2.TableName = "NeoTable2"
        Me.NeoTable2.Transaction = Nothing
        Me.NeoTable2.UpdateCommand = Me.SqlCommand11
        '
        'NeoTable2_nID
        '
        Me.NeoTable2_nID.AllowDBNull = False
        Me.NeoTable2_nID.AutoIncrement = True
        Me.NeoTable2_nID.ColumnName = "nID"
        Me.NeoTable2_nID.DataType = GetType(Integer)
        '
        'NeoTable2_Deleted
        '
        Me.NeoTable2_Deleted.ColumnName = "Deleted"
        Me.NeoTable2_Deleted.DataType = GetType(Integer)
        '
        'NeoTable2_CreatedBy
        '
        Me.NeoTable2_CreatedBy.ColumnName = "CreatedBy"
        Me.NeoTable2_CreatedBy.DataType = GetType(Integer)
        '
        'NeoTable2_CreatedDate
        '
        Me.NeoTable2_CreatedDate.ColumnName = "CreatedDate"
        Me.NeoTable2_CreatedDate.DataType = GetType(Date)
        '
        'NeoTable2_ModifiedBy
        '
        Me.NeoTable2_ModifiedBy.ColumnName = "ModifiedBy"
        Me.NeoTable2_ModifiedBy.DataType = GetType(Integer)
        '
        'NeoTable2_ModifiedDate
        '
        Me.NeoTable2_ModifiedDate.ColumnName = "ModifiedDate"
        Me.NeoTable2_ModifiedDate.DataType = GetType(Date)
        '
        'NeoTable2_SipDetayParamID
        '
        Me.NeoTable2_SipDetayParamID.ColumnName = "SipDetayParamID"
        Me.NeoTable2_SipDetayParamID.DataType = GetType(Integer)
        '
        'NeoTable2_SourceID
        '
        Me.NeoTable2_SourceID.ColumnName = "SourceID"
        Me.NeoTable2_SourceID.DataType = GetType(Integer)
        '
        'NeoTable2_KategoriParamID
        '
        Me.NeoTable2_KategoriParamID.ColumnName = "KategoriParamID"
        Me.NeoTable2_KategoriParamID.DataType = GetType(Integer)
        '
        'NeoTable2_ParcaIsmi
        '
        Me.NeoTable2_ParcaIsmi.ColumnName = "ParcaIsmi"
        '
        'NeoTable2_Iplik
        '
        Me.NeoTable2_Iplik.ColumnName = "Iplik"
        Me.NeoTable2_Iplik.DataType = GetType(Integer)
        '
        'NeoTable2_IpGramaj
        '
        Me.NeoTable2_IpGramaj.ColumnName = "IpGramaj"
        Me.NeoTable2_IpGramaj.DataType = GetType(Double)
        '
        'NeoTable2_RenkID
        '
        Me.NeoTable2_RenkID.ColumnName = "RenkID"
        Me.NeoTable2_RenkID.DataType = GetType(Integer)
        '
        'SqlCommand12
        '
        Me.SqlCommand12.CommandText = "UPDATE SipDetayParam_015_Fular SET Deleted = nID  , ModifiedBy = @ModifiedBy , Mo" & _
            "difiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand10
        '
        Me.SqlCommand10.CommandText = resources.GetString("SqlCommand10.CommandText")
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT * FROM SipDetayParam_015_Fular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 "
        '
        'SqlCommand11
        '
        Me.SqlCommand11.CommandText = resources.GetString("SqlCommand11.CommandText")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colSipDetayParamID, Me.GridColumn4, Me.colRenkID})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "nID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'colSipDetayParamID
        '
        Me.colSipDetayParamID.FieldName = "SipDetayParamID"
        Me.colSipDetayParamID.Name = "colSipDetayParamID"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "ParcaIsmi"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 91
        '
        'colRenkID
        '
        Me.colRenkID.Caption = "İp Rengi"
        Me.colRenkID.ColumnEdit = Me.cboGridRenk
        Me.colRenkID.FieldName = "RenkID"
        Me.colRenkID.Name = "colRenkID"
        Me.colRenkID.Visible = True
        Me.colRenkID.VisibleIndex = 1
        Me.colRenkID.Width = 96
        '
        'cboGridRenk
        '
        Me.cboGridRenk.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboGridRenk.AutoHeight = False
        Me.cboGridRenk.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboGridRenk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridRenk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.cboGridRenk.DataSource = Me.tbRenk
        Me.cboGridRenk.DisplayMember = "RenkKod"
        Me.cboGridRenk.Name = "cboGridRenk"
        Me.cboGridRenk.NullText = ""
        Me.cboGridRenk.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboGridRenk.ValueMember = "RenkID"
        '
        'tbRenk
        '
        Me.tbRenk.Columns.AddRange(New System.Data.DataColumn() {Me.tbRenk_RenkID, Me.tbRenk_RenkKod, Me.tbRenk_RenkIsmi})
        Me.tbRenk.Connection = Me.SqlConn
        Me.tbRenk.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"RenkID"}, True)})
        Me.tbRenk.CurrentRow = Nothing
        Me.tbRenk.DataSourceLink = Nothing
        Me.tbRenk.DeleteCommand = Me.SqlCommand16
        Me.tbRenk.Filter = ""
        Me.tbRenk.InsertCommand = Me.SqlCommand14
        Me.tbRenk.LiveSave = False
        Me.tbRenk.MaxRecords = CType(0, Long)
        Me.tbRenk.Name = "tbRenk"
        Me.tbRenk.ParentRelation_ChildColumns = Nothing
        Me.tbRenk.ParentRelation_ParentColumns = Nothing
        Me.tbRenk.ParentRelation_Table = Nothing
        Me.tbRenk.Position = CType(-1, Long)
        Me.tbRenk.PrimaryKey = New System.Data.DataColumn() {Me.tbRenk_RenkID}
        Me.tbRenk.Quoted = False
        Me.tbRenk.SelectCommand = Me.SqlCommand13
        Me.tbRenk.TableName = "NeoTable3"
        Me.tbRenk.Transaction = Nothing
        Me.tbRenk.UpdateCommand = Me.SqlCommand15
        '
        'tbRenk_RenkID
        '
        Me.tbRenk_RenkID.AllowDBNull = False
        Me.tbRenk_RenkID.AutoIncrement = True
        Me.tbRenk_RenkID.ColumnName = "RenkID"
        Me.tbRenk_RenkID.DataType = GetType(Integer)
        '
        'tbRenk_RenkKod
        '
        Me.tbRenk_RenkKod.ColumnName = "RenkKod"
        '
        'tbRenk_RenkIsmi
        '
        Me.tbRenk_RenkIsmi.ColumnName = "RenkIsmi"
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT     RenkID, RenkKod, RenkIsmi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Renkler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & _
            "RDER BY RenkKod"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterTable2, "IntParam1", True))
        Me.RadioGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadioGroup1.Location = New System.Drawing.Point(0, 68)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Yuvarlak"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Oval"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Kalkan"), New DevExpress.XtraEditors.Controls.RadioGroupItem(99, "Diğer")})
        Me.RadioGroup1.Size = New System.Drawing.Size(256, 28)
        Me.RadioGroup1.TabIndex = 4
        '
        'cnt015_Fular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Caption = "Fular"
        Me.Code = "015"
        Me.Name = "cnt015_Fular"
        Me.Size = New System.Drawing.Size(272, 158)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCaption.ResumeLayout(False)
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrguTip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOrguTip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGridRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NeoTable1 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colnID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriParamID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcaIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIplik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIpGramaj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbIplik As NeoDAC.NeoTable
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MasterTable_KategoriParamID As System.Data.DataColumn
    Friend WithEvents MasterTable_KategoriID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamType As System.Data.DataColumn
    Friend WithEvents MasterTable_Param1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param2 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param3 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param4 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param5 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt2 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt3 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt4 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt5 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat2 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat3 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat4 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat5 As System.Data.DataColumn
    Friend WithEvents MasterTable_KategoriParamID_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_KategoriID_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamType_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param1_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param2_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param3_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param4_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Param5_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt1_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt2_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt3_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt4_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamInt5_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat1_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat2_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat3_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat4_1 As System.Data.DataColumn
    Friend WithEvents MasterTable_ParamFloat5_1 As System.Data.DataColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NeoTable2 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colSipDetayParamID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRenkID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboGridRenk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tbRenk As NeoDAC.NeoTable
    Friend WithEvents tbRenk_RenkID As System.Data.DataColumn
    Friend WithEvents tbRenk_RenkKod As System.Data.DataColumn
    Friend WithEvents tbRenk_RenkIsmi As System.Data.DataColumn
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbOrguTip As NeoDAC.NeoTable
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbIplik_IplikID As System.Data.DataColumn
    Friend WithEvents tbIplik_Deleted As System.Data.DataColumn
    Friend WithEvents tbIplik_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbIplik_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbIplik_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbIplik_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikKod As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikIsmi As System.Data.DataColumn
    Friend WithEvents tbIplik_IntCode As System.Data.DataColumn
    Friend WithEvents tbIplik_Pasif As System.Data.DataColumn
    Friend WithEvents tbIplik_StokFiltre As System.Data.DataColumn
    Friend WithEvents cboOrguTip1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tbOrguTip_OrguTipID As System.Data.DataColumn
    Friend WithEvents tbOrguTip_OrguTipKod As System.Data.DataColumn
    Friend WithEvents tbOrguTip_OrguTipIsmi As System.Data.DataColumn
    Friend WithEvents tbOrguTip_Fiyat As System.Data.DataColumn
    Friend WithEvents NeoTable1_nID As System.Data.DataColumn
    Friend WithEvents NeoTable1_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable1_ParcaIsmi As System.Data.DataColumn
    Friend WithEvents NeoTable1_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable1_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable2_nID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable2_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable2_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable2_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable2_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable2_SipDetayParamID As System.Data.DataColumn
    Friend WithEvents NeoTable2_SourceID As System.Data.DataColumn
    Friend WithEvents NeoTable2_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable2_ParcaIsmi As System.Data.DataColumn
    Friend WithEvents NeoTable2_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable2_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable2_RenkID As System.Data.DataColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup

End Class
