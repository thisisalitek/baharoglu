<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cnt056_EkFiyat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnt056_EkFiyat))
        Me.NeoTable1 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable1_nID = New System.Data.DataColumn()
        Me.NeoTable1_Deleted = New System.Data.DataColumn()
        Me.NeoTable1_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable1_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable1_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable1_Aciklama = New System.Data.DataColumn()
        Me.NeoTable1_Fiyat = New System.Data.DataColumn()
        Me.NeoTable1_BedenArtis = New System.Data.DataColumn()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriParamID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
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
        Me.NeoTable2_Aciklama = New System.Data.DataColumn()
        Me.NeoTable2_Fiyat = New System.Data.DataColumn()
        Me.NeoTable2_BedenArtis = New System.Data.DataColumn()
        Me.NeoTable2_bStatik = New System.Data.DataColumn()
        Me.SqlCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand30 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand29 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand31 = New System.Data.SqlClient.SqlCommand()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tmrMasrafYukle = New System.Windows.Forms.Timer(Me.components)
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
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.Size = New System.Drawing.Size(168, 17)
        Me.lblCaption.Text = "Ek Fiyat"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Size = New System.Drawing.Size(273, 135)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl2)
        Me.XtraTabPage1.Size = New System.Drawing.Size(265, 107)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Size = New System.Drawing.Size(265, 107)
        '
        'panelCaption
        '
        Me.panelCaption.Size = New System.Drawing.Size(273, 26)
        '
        'chkSecmeli
        '
        Me.chkSecmeli.Location = New System.Drawing.Point(211, 4)
        Me.chkSecmeli.Visible = False
        '
        'chkVar
        '
        Me.chkVar.Location = New System.Drawing.Point(172, 4)
        '
        'NeoTable1
        '
        Me.NeoTable1.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable1_nID, Me.NeoTable1_Deleted, Me.NeoTable1_CreatedBy, Me.NeoTable1_CreatedDate, Me.NeoTable1_ModifiedBy, Me.NeoTable1_ModifiedDate, Me.NeoTable1_KategoriParamID, Me.NeoTable1_Aciklama, Me.NeoTable1_Fiyat, Me.NeoTable1_BedenArtis})
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
        'NeoTable1_Aciklama
        '
        Me.NeoTable1_Aciklama.ColumnName = "Aciklama"
        '
        'NeoTable1_Fiyat
        '
        Me.NeoTable1_Fiyat.ColumnName = "Fiyat"
        Me.NeoTable1_Fiyat.DataType = GetType(Double)
        '
        'NeoTable1_BedenArtis
        '
        Me.NeoTable1_BedenArtis.ColumnName = "BedenArtis"
        Me.NeoTable1_BedenArtis.DataType = GetType(Double)
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KategoriParam_056_EkFiyat SET Deleted = nID  , ModifiedBy = @ModifiedBy , " & _
            "ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         KategoriParam_056_EkFiyat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM CizgiRenkKafa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Tip='YAKA'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT IplikID" & Global.Microsoft.VisualBasic.ChrW(9) & ",IplikKod,IplikIsmi FROM Iplikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(306, 181)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit2.TabIndex = 5
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = "DELETE FROM SipDetayParam_051_Tip WHERE nID = @nID"
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = resources.GetString("SqlCommand18.CommandText")
        Me.SqlCommand18.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_051_Tip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = "UPDATE SipDetayParam_051_Tip SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SipDetayParamID = @SipDetayParamID , SourceID " & _
            "= @SourceID , KategoriParamID = @KategoriParamID , Tip = @Tip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE nID = @nID"
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT * FROM Renkler WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.SqlCommand23.CommandText = "UPDATE SipDetayParam_002_Lastik_Kol SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SipDetayParamID = @SipDetayParamID , So" & _
            "urceID = @SourceID , KategoriParamID = @KategoriParamID , CizgiSayisi = @CizgiSa" & _
            "yisi , RKafa = @RKafa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE nID = @nID"
        '
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT * FROM Fason" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.NeoTable1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(265, 107)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnID, Me.colKategoriParamID, Me.colAciklama, Me.colFiyat})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'colAciklama
        '
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 0
        Me.colAciklama.Width = 166
        '
        'colFiyat
        '
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 1
        Me.colFiyat.Width = 54
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Aciklama", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RKafa", "RKafa", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "Cizgi Sayisi", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "RKafa"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "RKafa"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "RenkKod"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "RenkID"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.NeoTable2
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.GridControl1.Size = New System.Drawing.Size(265, 107)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'NeoTable2
        '
        Me.NeoTable2.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable2_nID, Me.NeoTable2_Deleted, Me.NeoTable2_CreatedBy, Me.NeoTable2_CreatedDate, Me.NeoTable2_ModifiedBy, Me.NeoTable2_ModifiedDate, Me.NeoTable2_SipDetayParamID, Me.NeoTable2_SourceID, Me.NeoTable2_KategoriParamID, Me.NeoTable2_Aciklama, Me.NeoTable2_Fiyat, Me.NeoTable2_BedenArtis, Me.NeoTable2_bStatik})
        Me.NeoTable2.Connection = Me.SqlConn
        Me.NeoTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable2.CurrentRow = Nothing
        Me.NeoTable2.DataSourceLink = Nothing
        Me.NeoTable2.DeleteCommand = Me.SqlCommand32
        Me.NeoTable2.Filter = ""
        Me.NeoTable2.InsertCommand = Me.SqlCommand30
        Me.NeoTable2.LiveSave = False
        Me.NeoTable2.MaxRecords = CType(0, Long)
        Me.NeoTable2.Name = "NeoTable2"
        Me.NeoTable2.ParentRelation_ChildColumns = Nothing
        Me.NeoTable2.ParentRelation_ParentColumns = Nothing
        Me.NeoTable2.ParentRelation_Table = Nothing
        Me.NeoTable2.Position = CType(-1, Long)
        Me.NeoTable2.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable2_nID}
        Me.NeoTable2.Quoted = False
        Me.NeoTable2.SelectCommand = Me.SqlCommand29
        Me.NeoTable2.TableName = "NeoTable2"
        Me.NeoTable2.Transaction = Nothing
        Me.NeoTable2.UpdateCommand = Me.SqlCommand31
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
        'NeoTable2_Aciklama
        '
        Me.NeoTable2_Aciklama.ColumnName = "Aciklama"
        '
        'NeoTable2_Fiyat
        '
        Me.NeoTable2_Fiyat.ColumnName = "Fiyat"
        Me.NeoTable2_Fiyat.DataType = GetType(Double)
        '
        'NeoTable2_BedenArtis
        '
        Me.NeoTable2_BedenArtis.ColumnName = "BedenArtis"
        Me.NeoTable2_BedenArtis.DataType = GetType(Double)
        '
        'NeoTable2_bStatik
        '
        Me.NeoTable2_bStatik.ColumnName = "bStatik"
        Me.NeoTable2_bStatik.DataType = GetType(Integer)
        '
        'SqlCommand32
        '
        Me.SqlCommand32.CommandText = "UPDATE SipDetayParam_056_EkFiyat SET Deleted = nID  , ModifiedBy = @ModifiedBy , " & _
            "ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand30
        '
        Me.SqlCommand30.CommandText = resources.GetString("SqlCommand30.CommandText")
        '
        'SqlCommand29
        '
        Me.SqlCommand29.CommandText = "SELECT * FROM SipDetayParam_056_EkFiyat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 "
        '
        'SqlCommand31
        '
        Me.SqlCommand31.CommandText = resources.GetString("SqlCommand31.CommandText")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.GridColumn3.FieldName = "Aciklama"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 169
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "Fiyat"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 55
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Aciklama", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RKafa", "RKafa", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "Cizgi Sayisi", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "RKafa"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit3.ValueMember = "RKafa"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "RenkKod"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit4.ValueMember = "RenkID"
        '
        'tmrMasrafYukle
        '
        '
        'cnt056_EkFiyat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Caption = "Ek Fiyat"
        Me.Code = "056"
        Me.Controls.Add(Me.TextEdit2)
        Me.Name = "cnt056_EkFiyat"
        Me.Size = New System.Drawing.Size(281, 169)
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
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeoTable1 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriParamID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents NeoTable2 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents NeoTable1_nID As System.Data.DataColumn
    Friend WithEvents NeoTable1_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable1_Aciklama As System.Data.DataColumn
    Friend WithEvents NeoTable1_Fiyat As System.Data.DataColumn
    Friend WithEvents NeoTable1_BedenArtis As System.Data.DataColumn
    Friend WithEvents NeoTable2_nID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable2_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable2_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable2_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable2_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable2_SipDetayParamID As System.Data.DataColumn
    Friend WithEvents NeoTable2_SourceID As System.Data.DataColumn
    Friend WithEvents NeoTable2_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Aciklama As System.Data.DataColumn
    Friend WithEvents NeoTable2_Fiyat As System.Data.DataColumn
    Friend WithEvents NeoTable2_BedenArtis As System.Data.DataColumn
    Friend WithEvents NeoTable2_bStatik As System.Data.DataColumn
    Friend WithEvents tmrMasrafYukle As System.Windows.Forms.Timer

End Class
