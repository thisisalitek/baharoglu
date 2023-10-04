<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cnt012_LakosYaka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnt012_LakosYaka))
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tbRenk = New NeoDAC.NeoTable(Me.components)
        Me.tbRenk_RenkID = New System.Data.DataColumn()
        Me.tbRenk_Deleted = New System.Data.DataColumn()
        Me.tbRenk_CreatedBy = New System.Data.DataColumn()
        Me.tbRenk_CreatedDate = New System.Data.DataColumn()
        Me.tbRenk_ModifiedBy = New System.Data.DataColumn()
        Me.tbRenk_ModifiedDate = New System.Data.DataColumn()
        Me.tbRenk_RenkKod = New System.Data.DataColumn()
        Me.tbRenk_RenkIsmi = New System.Data.DataColumn()
        Me.tbRenk_IntCode = New System.Data.DataColumn()
        Me.tbRenk_Pasif = New System.Data.DataColumn()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.NeoTable1 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable1_nID = New System.Data.DataColumn()
        Me.NeoTable1_Deleted = New System.Data.DataColumn()
        Me.NeoTable1_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable1_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable1_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable1_YakaTip = New System.Data.DataColumn()
        Me.NeoTable1_Iplik = New System.Data.DataColumn()
        Me.NeoTable1_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable1_GramajArtis = New System.Data.DataColumn()
        Me.NeoTable1_SimitKumasYuzde = New System.Data.DataColumn()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.tbCizgiRenkKafaLakos = New NeoDAC.NeoTable(Me.components)
        Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_Deleted = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_CreatedBy = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_CreatedDate = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_ModifiedBy = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_ModifiedDate = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_Aciklama = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_CizgiSayisi = New System.Data.DataColumn()
        Me.tbCizgiRenkKafaLakos_Gramaj = New System.Data.DataColumn()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.txtTurArtis = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTur = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.tbIplik = New NeoDAC.NeoTable(Me.components)
        Me.tbIplik_IplikID = New System.Data.DataColumn()
        Me.tbIplik_IplikKod = New System.Data.DataColumn()
        Me.tbIplik_IplikIsmi = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.NeoTable3 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable3_nID = New System.Data.DataColumn()
        Me.NeoTable3_Deleted = New System.Data.DataColumn()
        Me.NeoTable3_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable3_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable3_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable3_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable3_LakosYakaID = New System.Data.DataColumn()
        Me.NeoTable3_CizgiNo = New System.Data.DataColumn()
        Me.NeoTable3_RenkID = New System.Data.DataColumn()
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRenkID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
        Me.NeoTable2_RenkID = New System.Data.DataColumn()
        Me.NeoTable2_CizgiRKafaLakosID = New System.Data.DataColumn()
        Me.NeoTable2_CizgiSayisi = New System.Data.DataColumn()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RadioGroup2 = New DevExpress.XtraEditors.RadioGroup()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.tbYakaEnleri = New NeoDAC.NeoTable(Me.components)
        Me.tbYakaEnleri_nID = New System.Data.DataColumn()
        Me.tbYakaEnleri_Deleted = New System.Data.DataColumn()
        Me.tbYakaEnleri_CreatedBy = New System.Data.DataColumn()
        Me.tbYakaEnleri_CreatedDate = New System.Data.DataColumn()
        Me.tbYakaEnleri_ModifiedBy = New System.Data.DataColumn()
        Me.tbYakaEnleri_ModifiedDate = New System.Data.DataColumn()
        Me.tbYakaEnleri_KategoriParamID = New System.Data.DataColumn()
        Me.tbYakaEnleri_BedenKod = New System.Data.DataColumn()
        Me.tbYakaEnleri_En = New System.Data.DataColumn()
        Me.SqlCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand30 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand29 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand31 = New System.Data.SqlClient.SqlCommand()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriParamID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBedenKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCizgiRenkKafaLakos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTurArtis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.RadioGroup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbYakaEnleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCaption.Size = New System.Drawing.Size(183, 22)
        Me.lblCaption.Text = "Lakos Yaka"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(284, 253)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage1.Controls.Add(Me.RadioGroup1)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabPage1.Size = New System.Drawing.Size(278, 225)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabPage2.Size = New System.Drawing.Size(278, 225)
        '
        'SqlConn
        '
        Me.SqlConn.ConnectionString = "Server=(local)\SQLExpress;Database=ProbarSiparisDB;User ID=sa;Password=;Trusted_C" &
    "onnection=True;"
        '
        'panelCaption
        '
        Me.panelCaption.Margin = New System.Windows.Forms.Padding(5)
        Me.panelCaption.Size = New System.Drawing.Size(284, 26)
        '
        'chkSecmeli
        '
        Me.chkSecmeli.Location = New System.Drawing.Point(224, 2)
        Me.chkSecmeli.Margin = New System.Windows.Forms.Padding(4)
        '
        'chkVar
        '
        Me.chkVar.Location = New System.Drawing.Point(185, 2)
        Me.chkVar.Margin = New System.Windows.Forms.Padding(4)
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.tbRenk
        Me.RepositoryItemLookUpEdit1.DisplayMember = "RenkKod"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "RenkID"
        '
        'tbRenk
        '
        Me.tbRenk.Columns.AddRange(New System.Data.DataColumn() {Me.tbRenk_RenkID, Me.tbRenk_Deleted, Me.tbRenk_CreatedBy, Me.tbRenk_CreatedDate, Me.tbRenk_ModifiedBy, Me.tbRenk_ModifiedDate, Me.tbRenk_RenkKod, Me.tbRenk_RenkIsmi, Me.tbRenk_IntCode, Me.tbRenk_Pasif})
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
        Me.tbRenk.TableName = "NeoTable2"
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
        'tbRenk_Deleted
        '
        Me.tbRenk_Deleted.ColumnName = "Deleted"
        Me.tbRenk_Deleted.DataType = GetType(Integer)
        '
        'tbRenk_CreatedBy
        '
        Me.tbRenk_CreatedBy.ColumnName = "CreatedBy"
        Me.tbRenk_CreatedBy.DataType = GetType(Integer)
        '
        'tbRenk_CreatedDate
        '
        Me.tbRenk_CreatedDate.ColumnName = "CreatedDate"
        Me.tbRenk_CreatedDate.DataType = GetType(Date)
        '
        'tbRenk_ModifiedBy
        '
        Me.tbRenk_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbRenk_ModifiedBy.DataType = GetType(Integer)
        '
        'tbRenk_ModifiedDate
        '
        Me.tbRenk_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbRenk_ModifiedDate.DataType = GetType(Date)
        '
        'tbRenk_RenkKod
        '
        Me.tbRenk_RenkKod.ColumnName = "RenkKod"
        '
        'tbRenk_RenkIsmi
        '
        Me.tbRenk_RenkIsmi.ColumnName = "RenkIsmi"
        '
        'tbRenk_IntCode
        '
        Me.tbRenk_IntCode.ColumnName = "IntCode"
        '
        'tbRenk_Pasif
        '
        Me.tbRenk_Pasif.ColumnName = "Pasif"
        Me.tbRenk_Pasif.DataType = GetType(Integer)
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT * FROM Renkler WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NeoTable1
        '
        Me.NeoTable1.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable1_nID, Me.NeoTable1_Deleted, Me.NeoTable1_CreatedBy, Me.NeoTable1_CreatedDate, Me.NeoTable1_ModifiedBy, Me.NeoTable1_ModifiedDate, Me.NeoTable1_KategoriParamID, Me.NeoTable1_YakaTip, Me.NeoTable1_Iplik, Me.NeoTable1_IpGramaj, Me.NeoTable1_GramajArtis, Me.NeoTable1_SimitKumasYuzde})
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
        'NeoTable1_YakaTip
        '
        Me.NeoTable1_YakaTip.ColumnName = "YakaTip"
        Me.NeoTable1_YakaTip.DataType = GetType(Integer)
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
        'NeoTable1_GramajArtis
        '
        Me.NeoTable1_GramajArtis.ColumnName = "GramajArtis"
        Me.NeoTable1_GramajArtis.DataType = GetType(Double)
        '
        'NeoTable1_SimitKumasYuzde
        '
        Me.NeoTable1_SimitKumasYuzde.ColumnName = "SimitKumasYuzde"
        Me.NeoTable1_SimitKumasYuzde.DataType = GetType(Double)
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KategoriParam_012_LakosYaka SET Deleted = nID  , ModifiedBy = @ModifiedBy " &
    ", ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         KategoriParam_012_LakosYaka" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'tbCizgiRenkKafaLakos
        '
        Me.tbCizgiRenkKafaLakos.Columns.AddRange(New System.Data.DataColumn() {Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID, Me.tbCizgiRenkKafaLakos_Deleted, Me.tbCizgiRenkKafaLakos_CreatedBy, Me.tbCizgiRenkKafaLakos_CreatedDate, Me.tbCizgiRenkKafaLakos_ModifiedBy, Me.tbCizgiRenkKafaLakos_ModifiedDate, Me.tbCizgiRenkKafaLakos_Aciklama, Me.tbCizgiRenkKafaLakos_CizgiSayisi, Me.tbCizgiRenkKafaLakos_Gramaj})
        Me.tbCizgiRenkKafaLakos.Connection = Me.SqlConn
        Me.tbCizgiRenkKafaLakos.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"CizgiRKafaLakosID"}, True)})
        Me.tbCizgiRenkKafaLakos.CurrentRow = Nothing
        Me.tbCizgiRenkKafaLakos.DataSourceLink = Nothing
        Me.tbCizgiRenkKafaLakos.DeleteCommand = Me.SqlCommand8
        Me.tbCizgiRenkKafaLakos.Filter = ""
        Me.tbCizgiRenkKafaLakos.InsertCommand = Me.SqlCommand6
        Me.tbCizgiRenkKafaLakos.LiveSave = False
        Me.tbCizgiRenkKafaLakos.MaxRecords = CType(0, Long)
        Me.tbCizgiRenkKafaLakos.Name = "tbCizgiRenkKafaLakos"
        Me.tbCizgiRenkKafaLakos.ParentRelation_ChildColumns = Nothing
        Me.tbCizgiRenkKafaLakos.ParentRelation_ParentColumns = Nothing
        Me.tbCizgiRenkKafaLakos.ParentRelation_Table = Nothing
        Me.tbCizgiRenkKafaLakos.Position = CType(-1, Long)
        Me.tbCizgiRenkKafaLakos.PrimaryKey = New System.Data.DataColumn() {Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID}
        Me.tbCizgiRenkKafaLakos.Quoted = False
        Me.tbCizgiRenkKafaLakos.SelectCommand = Me.SqlCommand5
        Me.tbCizgiRenkKafaLakos.TableName = "NeoTable2"
        Me.tbCizgiRenkKafaLakos.Transaction = Nothing
        Me.tbCizgiRenkKafaLakos.UpdateCommand = Me.SqlCommand7
        '
        'tbCizgiRenkKafaLakos_CizgiRKafaLakosID
        '
        Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID.AllowDBNull = False
        Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID.AutoIncrement = True
        Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID.ColumnName = "CizgiRKafaLakosID"
        Me.tbCizgiRenkKafaLakos_CizgiRKafaLakosID.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafaLakos_Deleted
        '
        Me.tbCizgiRenkKafaLakos_Deleted.ColumnName = "Deleted"
        Me.tbCizgiRenkKafaLakos_Deleted.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafaLakos_CreatedBy
        '
        Me.tbCizgiRenkKafaLakos_CreatedBy.ColumnName = "CreatedBy"
        Me.tbCizgiRenkKafaLakos_CreatedBy.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafaLakos_CreatedDate
        '
        Me.tbCizgiRenkKafaLakos_CreatedDate.ColumnName = "CreatedDate"
        Me.tbCizgiRenkKafaLakos_CreatedDate.DataType = GetType(Date)
        '
        'tbCizgiRenkKafaLakos_ModifiedBy
        '
        Me.tbCizgiRenkKafaLakos_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbCizgiRenkKafaLakos_ModifiedBy.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafaLakos_ModifiedDate
        '
        Me.tbCizgiRenkKafaLakos_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbCizgiRenkKafaLakos_ModifiedDate.DataType = GetType(Date)
        '
        'tbCizgiRenkKafaLakos_Aciklama
        '
        Me.tbCizgiRenkKafaLakos_Aciklama.ColumnName = "Aciklama"
        '
        'tbCizgiRenkKafaLakos_CizgiSayisi
        '
        Me.tbCizgiRenkKafaLakos_CizgiSayisi.ColumnName = "CizgiSayisi"
        Me.tbCizgiRenkKafaLakos_CizgiSayisi.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafaLakos_Gramaj
        '
        Me.tbCizgiRenkKafaLakos_Gramaj.ColumnName = "Gramaj"
        Me.tbCizgiRenkKafaLakos_Gramaj.DataType = GetType(Double)
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM CizgiRenkKafaLakos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTurArtis
        '
        Me.txtTurArtis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "GramajArtis", True))
        Me.txtTurArtis.Location = New System.Drawing.Point(184, 17)
        Me.txtTurArtis.Name = "txtTurArtis"
        Me.txtTurArtis.Size = New System.Drawing.Size(47, 20)
        Me.txtTurArtis.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(194, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Artış"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(127, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "İp Grm."
        '
        'txtTur
        '
        Me.txtTur.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "IpGramaj", True))
        Me.txtTur.Location = New System.Drawing.Point(127, 17)
        Me.txtTur.Name = "txtTur"
        Me.txtTur.Size = New System.Drawing.Size(47, 20)
        Me.txtTur.TabIndex = 2
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "Iplik", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(3, 17)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit1.Properties.DataSource = Me.tbIplik
        Me.LookUpEdit1.Properties.DisplayMember = "IplikKod"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit1.Properties.ValueMember = "IplikID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(118, 20)
        Me.LookUpEdit1.TabIndex = 1
        '
        'tbIplik
        '
        Me.tbIplik.Columns.AddRange(New System.Data.DataColumn() {Me.tbIplik_IplikID, Me.tbIplik_IplikKod, Me.tbIplik_IplikIsmi})
        Me.tbIplik.Connection = Me.SqlConn
        Me.tbIplik.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"IplikID"}, True)})
        Me.tbIplik.CurrentRow = Nothing
        Me.tbIplik.DataSourceLink = Nothing
        Me.tbIplik.DeleteCommand = Me.SqlCommand12
        Me.tbIplik.Filter = ""
        Me.tbIplik.InsertCommand = Me.SqlCommand10
        Me.tbIplik.LiveSave = False
        Me.tbIplik.MaxRecords = CType(0, Long)
        Me.tbIplik.Name = "tbIplik"
        Me.tbIplik.ParentRelation_ChildColumns = Nothing
        Me.tbIplik.ParentRelation_ParentColumns = Nothing
        Me.tbIplik.ParentRelation_Table = Nothing
        Me.tbIplik.Position = CType(-1, Long)
        Me.tbIplik.PrimaryKey = New System.Data.DataColumn() {Me.tbIplik_IplikID}
        Me.tbIplik.Quoted = False
        Me.tbIplik.SelectCommand = Me.SqlCommand9
        Me.tbIplik.TableName = "NeoTable2"
        Me.tbIplik.Transaction = Nothing
        Me.tbIplik.UpdateCommand = Me.SqlCommand11
        '
        'tbIplik_IplikID
        '
        Me.tbIplik_IplikID.AllowDBNull = False
        Me.tbIplik_IplikID.AutoIncrement = True
        Me.tbIplik_IplikID.ColumnName = "IplikID"
        Me.tbIplik_IplikID.DataType = GetType(Integer)
        '
        'tbIplik_IplikKod
        '
        Me.tbIplik_IplikKod.ColumnName = "IplikKod"
        '
        'tbIplik_IplikIsmi
        '
        Me.tbIplik_IplikIsmi.ColumnName = "IplikIsmi"
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT IplikID" & Global.Microsoft.VisualBasic.ChrW(9) & ",IplikKod,IplikIsmi FROM Iplikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "HMD"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(306, 181)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit2.TabIndex = 5
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.NeoTable3
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 98)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(278, 127)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'NeoTable3
        '
        Me.NeoTable3.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable3_nID, Me.NeoTable3_Deleted, Me.NeoTable3_CreatedBy, Me.NeoTable3_CreatedDate, Me.NeoTable3_ModifiedBy, Me.NeoTable3_ModifiedDate, Me.NeoTable3_LakosYakaID, Me.NeoTable3_CizgiNo, Me.NeoTable3_RenkID})
        Me.NeoTable3.Connection = Me.SqlConn
        Me.NeoTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable3.CurrentRow = Nothing
        Me.NeoTable3.DataSourceLink = Nothing
        Me.NeoTable3.DeleteCommand = Me.SqlCommand28
        Me.NeoTable3.Filter = ""
        Me.NeoTable3.InsertCommand = Me.SqlCommand26
        Me.NeoTable3.LiveSave = False
        Me.NeoTable3.MaxRecords = CType(0, Long)
        Me.NeoTable3.Name = "NeoTable3"
        Me.NeoTable3.ParentRelation_ChildColumns = Nothing
        Me.NeoTable3.ParentRelation_ParentColumns = Nothing
        Me.NeoTable3.ParentRelation_Table = Nothing
        Me.NeoTable3.Position = CType(-1, Long)
        Me.NeoTable3.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable3_nID}
        Me.NeoTable3.Quoted = False
        Me.NeoTable3.SelectCommand = Me.SqlCommand25
        Me.NeoTable3.TableName = "NeoTable3"
        Me.NeoTable3.Transaction = Nothing
        Me.NeoTable3.UpdateCommand = Me.SqlCommand27
        '
        'NeoTable3_nID
        '
        Me.NeoTable3_nID.AllowDBNull = False
        Me.NeoTable3_nID.AutoIncrement = True
        Me.NeoTable3_nID.ColumnName = "nID"
        Me.NeoTable3_nID.DataType = GetType(Integer)
        '
        'NeoTable3_Deleted
        '
        Me.NeoTable3_Deleted.ColumnName = "Deleted"
        Me.NeoTable3_Deleted.DataType = GetType(Integer)
        '
        'NeoTable3_CreatedBy
        '
        Me.NeoTable3_CreatedBy.ColumnName = "CreatedBy"
        Me.NeoTable3_CreatedBy.DataType = GetType(Integer)
        '
        'NeoTable3_CreatedDate
        '
        Me.NeoTable3_CreatedDate.ColumnName = "CreatedDate"
        Me.NeoTable3_CreatedDate.DataType = GetType(Date)
        '
        'NeoTable3_ModifiedBy
        '
        Me.NeoTable3_ModifiedBy.ColumnName = "ModifiedBy"
        Me.NeoTable3_ModifiedBy.DataType = GetType(Integer)
        '
        'NeoTable3_ModifiedDate
        '
        Me.NeoTable3_ModifiedDate.ColumnName = "ModifiedDate"
        Me.NeoTable3_ModifiedDate.DataType = GetType(Date)
        '
        'NeoTable3_LakosYakaID
        '
        Me.NeoTable3_LakosYakaID.ColumnName = "LakosYakaID"
        Me.NeoTable3_LakosYakaID.DataType = GetType(Integer)
        '
        'NeoTable3_CizgiNo
        '
        Me.NeoTable3_CizgiNo.ColumnName = "CizgiNo"
        Me.NeoTable3_CizgiNo.DataType = GetType(Integer)
        '
        'NeoTable3_RenkID
        '
        Me.NeoTable3_RenkID.ColumnName = "RenkID"
        Me.NeoTable3_RenkID.DataType = GetType(Integer)
        '
        'SqlCommand28
        '
        Me.SqlCommand28.CommandText = "UPDATE SipDetayParam_012_LakosYaka_Cizgiler SET Deleted = nID  , ModifiedBy = @Mo" &
    "difiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand26
        '
        Me.SqlCommand26.CommandText = resources.GetString("SqlCommand26.CommandText")
        Me.SqlCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT * FROM SipDetayParam_012_LakosYaka_Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand27
        '
        Me.SqlCommand27.CommandText = resources.GetString("SqlCommand27.CommandText")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colRenkID})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "nID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "KategoriParamID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "KategoriID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "#"
        Me.GridColumn4.FieldName = "CizgiNo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 32
        '
        'colRenkID
        '
        Me.colRenkID.Caption = "Renk"
        Me.colRenkID.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colRenkID.FieldName = "RenkID"
        Me.colRenkID.Name = "colRenkID"
        Me.colRenkID.Visible = True
        Me.colRenkID.VisibleIndex = 1
        Me.colRenkID.Width = 131
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.tbRenk
        Me.RepositoryItemLookUpEdit2.DisplayMember = "RenkKod"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "RenkID"
        '
        'NeoTable2
        '
        Me.NeoTable2.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable2_nID, Me.NeoTable2_Deleted, Me.NeoTable2_CreatedBy, Me.NeoTable2_CreatedDate, Me.NeoTable2_ModifiedBy, Me.NeoTable2_ModifiedDate, Me.NeoTable2_SipDetayParamID, Me.NeoTable2_SourceID, Me.NeoTable2_KategoriParamID, Me.NeoTable2_RenkID, Me.NeoTable2_CizgiRKafaLakosID, Me.NeoTable2_CizgiSayisi})
        Me.NeoTable2.Connection = Me.SqlConn
        Me.NeoTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable2.CurrentRow = Nothing
        Me.NeoTable2.DataSourceLink = Nothing
        Me.NeoTable2.DeleteCommand = Me.SqlCommand20
        Me.NeoTable2.Filter = ""
        Me.NeoTable2.InsertCommand = Me.SqlCommand18
        Me.NeoTable2.LiveSave = False
        Me.NeoTable2.MaxRecords = CType(0, Long)
        Me.NeoTable2.Name = "NeoTable2"
        Me.NeoTable2.ParentRelation_ChildColumns = Nothing
        Me.NeoTable2.ParentRelation_ParentColumns = Nothing
        Me.NeoTable2.ParentRelation_Table = Nothing
        Me.NeoTable2.Position = CType(-1, Long)
        Me.NeoTable2.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable2_nID}
        Me.NeoTable2.Quoted = False
        Me.NeoTable2.SelectCommand = Me.SqlCommand17
        Me.NeoTable2.TableName = "NeoTable2"
        Me.NeoTable2.Transaction = Nothing
        Me.NeoTable2.UpdateCommand = Me.SqlCommand19
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
        'NeoTable2_RenkID
        '
        Me.NeoTable2_RenkID.ColumnName = "RenkID"
        Me.NeoTable2_RenkID.DataType = GetType(Integer)
        '
        'NeoTable2_CizgiRKafaLakosID
        '
        Me.NeoTable2_CizgiRKafaLakosID.ColumnName = "CizgiRKafaLakosID"
        Me.NeoTable2_CizgiRKafaLakosID.DataType = GetType(Integer)
        '
        'NeoTable2_CizgiSayisi
        '
        Me.NeoTable2_CizgiSayisi.ColumnName = "CizgiSayisi"
        Me.NeoTable2_CizgiSayisi.DataType = GetType(Integer)
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = "UPDATE SipDetayParam_012_LakosYaka SET Deleted = nID  , ModifiedBy = @ModifiedBy " &
    ", ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = resources.GetString("SqlCommand18.CommandText")
        Me.SqlCommand18.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_012_LakosYaka" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = resources.GetString("SqlCommand19.CommandText")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.RadioGroup2)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit3)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit2)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(278, 98)
        Me.PanelControl2.TabIndex = 5
        '
        'RadioGroup2
        '
        Me.RadioGroup2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterTable2, "IntParam1", True))
        Me.RadioGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioGroup2.Location = New System.Drawing.Point(2, 2)
        Me.RadioGroup2.Margin = New System.Windows.Forms.Padding(1)
        Me.RadioGroup2.Name = "RadioGroup2"
        Me.RadioGroup2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Gömlek"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Simit"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Pilot"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Sıfır"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Polo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "AyaklıGömlek")})
        Me.RadioGroup2.Size = New System.Drawing.Size(274, 44)
        Me.RadioGroup2.TabIndex = 9
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "CizgiRKafaLakosID", True))
        Me.LookUpEdit3.EnterMoveNextControl = True
        Me.LookUpEdit3.Location = New System.Drawing.Point(64, 74)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit3.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Çizgiler", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "#", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiRKafaLakosID", "Cizgi RKafa Lakos ID", 121, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit3.Properties.DataSource = Me.tbCizgiRenkKafaLakos
        Me.LookUpEdit3.Properties.DisplayMember = "Aciklama"
        Me.LookUpEdit3.Properties.NullText = ""
        Me.LookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit3.Properties.ValueMember = "CizgiRKafaLakosID"
        Me.LookUpEdit3.Size = New System.Drawing.Size(166, 20)
        Me.LookUpEdit3.TabIndex = 4
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "RenkID", True))
        Me.LookUpEdit2.EnterMoveNextControl = True
        Me.LookUpEdit2.Location = New System.Drawing.Point(64, 51)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit2.Properties.DataSource = Me.tbRenk
        Me.LookUpEdit2.Properties.DisplayMember = "RenkKod"
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit2.Properties.ValueMember = "RenkID"
        Me.LookUpEdit2.Size = New System.Drawing.Size(167, 20)
        Me.LookUpEdit2.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(9, 51)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "Renk"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 77)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "Çizgi"
        '
        'SqlCommand24
        '
        Me.SqlCommand24.CommandText = "DELETE FROM SipDetayParam_002_Lastik_Kol WHERE nID = @nID"
        '
        'SqlCommand22
        '
        Me.SqlCommand22.CommandText = resources.GetString("SqlCommand22.CommandText")
        Me.SqlCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_002_Lastik_Kol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'SqlCommand23
        '
        Me.SqlCommand23.CommandText = "UPDATE SipDetayParam_002_Lastik_Kol SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SipDetayParamID = @SipDetayParamID , So" &
    "urceID = @SourceID , KategoriParamID = @KategoriParamID , CizgiSayisi = @CizgiSa" &
    "yisi , RKafa = @RKafa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE nID = @nID"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 46)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.Size = New System.Drawing.Size(278, 179)
        Me.XtraTabControl2.TabIndex = 6
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl1)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(272, 151)
        Me.XtraTabPage3.Text = "Beden/En"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.tbYakaEnleri
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(272, 110)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'tbYakaEnleri
        '
        Me.tbYakaEnleri.Columns.AddRange(New System.Data.DataColumn() {Me.tbYakaEnleri_nID, Me.tbYakaEnleri_Deleted, Me.tbYakaEnleri_CreatedBy, Me.tbYakaEnleri_CreatedDate, Me.tbYakaEnleri_ModifiedBy, Me.tbYakaEnleri_ModifiedDate, Me.tbYakaEnleri_KategoriParamID, Me.tbYakaEnleri_BedenKod, Me.tbYakaEnleri_En})
        Me.tbYakaEnleri.Connection = Me.SqlConn
        Me.tbYakaEnleri.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.tbYakaEnleri.CurrentRow = Nothing
        Me.tbYakaEnleri.DataSourceLink = Nothing
        Me.tbYakaEnleri.DeleteCommand = Me.SqlCommand32
        Me.tbYakaEnleri.Filter = ""
        Me.tbYakaEnleri.InsertCommand = Me.SqlCommand30
        Me.tbYakaEnleri.LiveSave = False
        Me.tbYakaEnleri.MaxRecords = CType(0, Long)
        Me.tbYakaEnleri.Name = "tbYakaEnleri"
        Me.tbYakaEnleri.ParentRelation_ChildColumns = Nothing
        Me.tbYakaEnleri.ParentRelation_ParentColumns = Nothing
        Me.tbYakaEnleri.ParentRelation_Table = Nothing
        Me.tbYakaEnleri.Position = CType(-1, Long)
        Me.tbYakaEnleri.PrimaryKey = New System.Data.DataColumn() {Me.tbYakaEnleri_nID}
        Me.tbYakaEnleri.Quoted = False
        Me.tbYakaEnleri.SelectCommand = Me.SqlCommand29
        Me.tbYakaEnleri.TableName = "NeoTable4"
        Me.tbYakaEnleri.Transaction = Nothing
        Me.tbYakaEnleri.UpdateCommand = Me.SqlCommand31
        '
        'tbYakaEnleri_nID
        '
        Me.tbYakaEnleri_nID.AllowDBNull = False
        Me.tbYakaEnleri_nID.AutoIncrement = True
        Me.tbYakaEnleri_nID.ColumnName = "nID"
        Me.tbYakaEnleri_nID.DataType = GetType(Integer)
        '
        'tbYakaEnleri_Deleted
        '
        Me.tbYakaEnleri_Deleted.ColumnName = "Deleted"
        Me.tbYakaEnleri_Deleted.DataType = GetType(Integer)
        '
        'tbYakaEnleri_CreatedBy
        '
        Me.tbYakaEnleri_CreatedBy.ColumnName = "CreatedBy"
        Me.tbYakaEnleri_CreatedBy.DataType = GetType(Integer)
        '
        'tbYakaEnleri_CreatedDate
        '
        Me.tbYakaEnleri_CreatedDate.ColumnName = "CreatedDate"
        Me.tbYakaEnleri_CreatedDate.DataType = GetType(Date)
        '
        'tbYakaEnleri_ModifiedBy
        '
        Me.tbYakaEnleri_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbYakaEnleri_ModifiedBy.DataType = GetType(Integer)
        '
        'tbYakaEnleri_ModifiedDate
        '
        Me.tbYakaEnleri_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbYakaEnleri_ModifiedDate.DataType = GetType(Date)
        '
        'tbYakaEnleri_KategoriParamID
        '
        Me.tbYakaEnleri_KategoriParamID.ColumnName = "KategoriParamID"
        Me.tbYakaEnleri_KategoriParamID.DataType = GetType(Integer)
        '
        'tbYakaEnleri_BedenKod
        '
        Me.tbYakaEnleri_BedenKod.ColumnName = "BedenKod"
        '
        'tbYakaEnleri_En
        '
        Me.tbYakaEnleri_En.ColumnName = "En"
        Me.tbYakaEnleri_En.DataType = GetType(Double)
        '
        'SqlCommand32
        '
        Me.SqlCommand32.CommandText = "UPDATE KategoriParam_012_LakosYaka_Enler SET Deleted = nID  , ModifiedBy = @Modif" &
    "iedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand30
        '
        Me.SqlCommand30.CommandText = resources.GetString("SqlCommand30.CommandText")
        '
        'SqlCommand29
        '
        Me.SqlCommand29.CommandText = "SELECT * FROM KategoriParam_012_LakosYaka_Enler " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand31
        '
        Me.SqlCommand31.CommandText = resources.GetString("SqlCommand31.CommandText")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnID, Me.colKategoriParamID, Me.colBedenKod, Me.colEn})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnID
        '
        Me.colnID.FieldName = "nID"
        Me.colnID.Name = "colnID"
        Me.colnID.OptionsColumn.AllowEdit = False
        '
        'colKategoriParamID
        '
        Me.colKategoriParamID.FieldName = "KategoriParamID"
        Me.colKategoriParamID.Name = "colKategoriParamID"
        Me.colKategoriParamID.OptionsColumn.AllowEdit = False
        '
        'colBedenKod
        '
        Me.colBedenKod.FieldName = "BedenKod"
        Me.colBedenKod.Name = "colBedenKod"
        Me.colBedenKod.OptionsColumn.AllowEdit = False
        Me.colBedenKod.Visible = True
        Me.colBedenKod.VisibleIndex = 0
        Me.colBedenKod.Width = 86
        '
        'colEn
        '
        Me.colEn.FieldName = "En"
        Me.colEn.Name = "colEn"
        Me.colEn.Visible = True
        Me.colEn.VisibleIndex = 1
        Me.colEn.Width = 78
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LookUpEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtTur)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtTurArtis)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(272, 41)
        Me.PanelControl1.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Tur"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(272, 151)
        Me.XtraTabPage4.Text = "Diger"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "SimitKumasYuzde", True))
        Me.TextEdit1.Location = New System.Drawing.Point(72, 3)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit1.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Kumaşın % si"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterTable, "IntParam1", True))
        Me.RadioGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioGroup1.Location = New System.Drawing.Point(0, 0)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Gömlek"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Simit"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Pilot"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Sıfır"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Polo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "AyaklıGömlek")})
        Me.RadioGroup1.Size = New System.Drawing.Size(278, 46)
        Me.RadioGroup1.TabIndex = 7
        '
        'cnt012_LakosYaka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Caption = "Lakos Yaka"
        Me.Code = "012"
        Me.Controls.Add(Me.TextEdit2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cnt012_LakosYaka"
        Me.Size = New System.Drawing.Size(292, 287)
        Me.Controls.SetChildIndex(Me.TextEdit2, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.panelCaption, 0)
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
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCizgiRenkKafaLakos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTurArtis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.RadioGroup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbYakaEnleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeoTable1 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tbIplik As NeoDAC.NeoTable
    Friend WithEvents tbIplik_IplikID As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikKod As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikIsmi As System.Data.DataColumn
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbCizgiRenkKafaLakos As NeoDAC.NeoTable
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtTurArtis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbRenk As NeoDAC.NeoTable
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents NeoTable2 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colRenkID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbRenk_RenkID As System.Data.DataColumn
    Friend WithEvents tbRenk_Deleted As System.Data.DataColumn
    Friend WithEvents tbRenk_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbRenk_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbRenk_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbRenk_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbRenk_RenkKod As System.Data.DataColumn
    Friend WithEvents tbRenk_RenkIsmi As System.Data.DataColumn
    Friend WithEvents tbRenk_IntCode As System.Data.DataColumn
    Friend WithEvents tbRenk_Pasif As System.Data.DataColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents NeoTable1_nID As System.Data.DataColumn
    Friend WithEvents NeoTable1_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable1_YakaTip As System.Data.DataColumn
    Friend WithEvents NeoTable1_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable1_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable1_GramajArtis As System.Data.DataColumn
    Friend WithEvents NeoTable1_SimitKumasYuzde As System.Data.DataColumn
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NeoTable3 As NeoDAC.NeoTable
    Friend WithEvents NeoTable3_nID As System.Data.DataColumn
    Friend WithEvents NeoTable3_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable3_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable3_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable3_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable3_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable3_LakosYakaID As System.Data.DataColumn
    Friend WithEvents NeoTable3_CizgiNo As System.Data.DataColumn
    Friend WithEvents NeoTable3_RenkID As System.Data.DataColumn
    Friend WithEvents SqlCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbCizgiRenkKafaLakos_CizgiRKafaLakosID As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_Deleted As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_Aciklama As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_CizgiSayisi As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafaLakos_Gramaj As System.Data.DataColumn
    Friend WithEvents NeoTable2_nID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable2_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable2_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable2_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable2_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable2_SipDetayParamID As System.Data.DataColumn
    Friend WithEvents NeoTable2_SourceID As System.Data.DataColumn
    Friend WithEvents NeoTable2_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable2_RenkID As System.Data.DataColumn
    Friend WithEvents NeoTable2_CizgiRKafaLakosID As System.Data.DataColumn
    Friend WithEvents NeoTable2_CizgiSayisi As System.Data.DataColumn
    Friend WithEvents RadioGroup2 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents tbYakaEnleri As NeoDAC.NeoTable
    Friend WithEvents tbYakaEnleri_nID As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_Deleted As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_KategoriParamID As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_BedenKod As System.Data.DataColumn
    Friend WithEvents tbYakaEnleri_En As System.Data.DataColumn
    Friend WithEvents SqlCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriParamID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBedenKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
