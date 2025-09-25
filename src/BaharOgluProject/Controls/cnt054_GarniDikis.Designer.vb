<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cnt054_GarniDikis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnt054_GarniDikis))
        Me.NeoTable2 = New NeoDAC.NeoTable(Me.components)
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.tbCizgiRenkKafa = New NeoDAC.NeoTable(Me.components)
        Me.tbCizgiRenkKafa_CizgiRKafaID = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_Deleted = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_CreatedBy = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_CreatedDate = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_ModifiedBy = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_ModifiedDate = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_Tip = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_Aciklama = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_CizgiSayisi = New System.Data.DataColumn()
        Me.tbCizgiRenkKafa_RKafa = New System.Data.DataColumn()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.tbIplik = New NeoDAC.NeoTable(Me.components)
        Me.tbIplik_IplikID = New System.Data.DataColumn()
        Me.tbIplik_IplikKod = New System.Data.DataColumn()
        Me.tbIplik_IplikIsmi = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
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
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.RadioGroup2 = New DevExpress.XtraEditors.RadioGroup()
        Me.NeoTable2_nID = New System.Data.DataColumn()
        Me.NeoTable2_Deleted = New System.Data.DataColumn()
        Me.NeoTable2_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable2_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable2_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable2_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable2_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable2_GarniDikis = New System.Data.DataColumn()
        Me.MasterTable2_SipDetayParamID = New System.Data.DataColumn()
        Me.MasterTable2_Deleted = New System.Data.DataColumn()
        Me.MasterTable2_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable2_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable2_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable2_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable2_SipDetayID = New System.Data.DataColumn()
        Me.MasterTable2_ParamType = New System.Data.DataColumn()
        Me.MasterTable2_KategoriParamID = New System.Data.DataColumn()
        Me.MasterTable2_HammaddeID = New System.Data.DataColumn()
        Me.MasterTable2_Tur = New System.Data.DataColumn()
        Me.MasterTable2_TurArtis = New System.Data.DataColumn()
        Me.MasterTable2_BelTur = New System.Data.DataColumn()
        Me.MasterTable2_BelTurArtis = New System.Data.DataColumn()
        Me.MasterTable2_KolTur = New System.Data.DataColumn()
        Me.MasterTable2_KolTurArtis = New System.Data.DataColumn()
        Me.MasterTable2_RenkID = New System.Data.DataColumn()
        Me.MasterTable2_CizgiSayisi = New System.Data.DataColumn()
        Me.MasterTable2_IntParam1 = New System.Data.DataColumn()
        Me.MasterTable2_RenkID2 = New System.Data.DataColumn()
        Me.MasterTable2_CizgiSayisi2 = New System.Data.DataColumn()
        Me.MasterTable2_bVar = New System.Data.DataColumn()
        Me.MasterTable2_IntParam2 = New System.Data.DataColumn()
        Me.MasterTable2_IntParam3 = New System.Data.DataColumn()
        Me.MasterTable2_CharParam1 = New System.Data.DataColumn()
        Me.MasterTable_KategoriParamID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_KategoriID = New System.Data.DataColumn()
        Me.MasterTable_ParamType = New System.Data.DataColumn()
        Me.MasterTable_Secmeli = New System.Data.DataColumn()
        Me.MasterTable_HammaddeID = New System.Data.DataColumn()
        Me.MasterTable_Tur = New System.Data.DataColumn()
        Me.MasterTable_TurArtis = New System.Data.DataColumn()
        Me.MasterTable_BelTur = New System.Data.DataColumn()
        Me.MasterTable_BelTurArtis = New System.Data.DataColumn()
        Me.MasterTable_KolTur = New System.Data.DataColumn()
        Me.MasterTable_KolTurArtis = New System.Data.DataColumn()
        Me.MasterTable_IpGramaj = New System.Data.DataColumn()
        Me.MasterTable_IpGramajArtis = New System.Data.DataColumn()
        Me.MasterTable_IntParam1 = New System.Data.DataColumn()
        Me.MasterTable_IntParam2 = New System.Data.DataColumn()
        Me.MasterTable_IntParam3 = New System.Data.DataColumn()
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
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCizgiRenkKafa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.Size = New System.Drawing.Size(58, 22)
        Me.lblCaption.Text = "Garni Dikiş"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Size = New System.Drawing.Size(159, 128)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.RadioGroup2)
        Me.XtraTabPage1.Size = New System.Drawing.Size(153, 100)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.RadioGroup1)
        Me.XtraTabPage2.Size = New System.Drawing.Size(153, 100)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KategoriParamID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_KategoriID, Me.MasterTable_ParamType, Me.MasterTable_Secmeli, Me.MasterTable_HammaddeID, Me.MasterTable_Tur, Me.MasterTable_TurArtis, Me.MasterTable_BelTur, Me.MasterTable_BelTurArtis, Me.MasterTable_KolTur, Me.MasterTable_KolTurArtis, Me.MasterTable_IpGramaj, Me.MasterTable_IpGramajArtis, Me.MasterTable_IntParam1, Me.MasterTable_IntParam2, Me.MasterTable_IntParam3})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriParamID"}, True)})
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KategoriParamID}
        '
        'panelCaption
        '
        Me.panelCaption.Size = New System.Drawing.Size(159, 26)
        '
        'chkSecmeli
        '
        Me.chkSecmeli.Location = New System.Drawing.Point(99, 2)
        Me.chkSecmeli.Visible = False
        '
        'MasterTable2
        '
        Me.MasterTable2.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable2_SipDetayParamID, Me.MasterTable2_Deleted, Me.MasterTable2_CreatedBy, Me.MasterTable2_CreatedDate, Me.MasterTable2_ModifiedBy, Me.MasterTable2_ModifiedDate, Me.MasterTable2_SipDetayID, Me.MasterTable2_ParamType, Me.MasterTable2_KategoriParamID, Me.MasterTable2_HammaddeID, Me.MasterTable2_Tur, Me.MasterTable2_TurArtis, Me.MasterTable2_BelTur, Me.MasterTable2_BelTurArtis, Me.MasterTable2_KolTur, Me.MasterTable2_KolTurArtis, Me.MasterTable2_RenkID, Me.MasterTable2_CizgiSayisi, Me.MasterTable2_IntParam1, Me.MasterTable2_RenkID2, Me.MasterTable2_CizgiSayisi2, Me.MasterTable2_bVar, Me.MasterTable2_IntParam2, Me.MasterTable2_IntParam3, Me.MasterTable2_CharParam1})
        Me.MasterTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SipDetayParamID"}, True)})
        Me.MasterTable2.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable2_SipDetayParamID}
        '
        'chkVar
        '
        Me.chkVar.Location = New System.Drawing.Point(60, 2)
        '
        'NeoTable2
        '
        Me.NeoTable2.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable2_nID, Me.NeoTable2_Deleted, Me.NeoTable2_CreatedBy, Me.NeoTable2_CreatedDate, Me.NeoTable2_ModifiedBy, Me.NeoTable2_ModifiedDate, Me.NeoTable2_KategoriParamID, Me.NeoTable2_GarniDikis})
        Me.NeoTable2.Connection = Me.SqlConn
        Me.NeoTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable2.CurrentRow = Nothing
        Me.NeoTable2.DataSourceLink = Nothing
        Me.NeoTable2.DeleteCommand = Me.SqlCommand4
        Me.NeoTable2.Filter = ""
        Me.NeoTable2.InsertCommand = Me.SqlCommand2
        Me.NeoTable2.LiveSave = False
        Me.NeoTable2.MaxRecords = CType(0, Long)
        Me.NeoTable2.Name = "NeoTable2"
        Me.NeoTable2.ParentRelation_ChildColumns = Nothing
        Me.NeoTable2.ParentRelation_ParentColumns = Nothing
        Me.NeoTable2.ParentRelation_Table = Nothing
        Me.NeoTable2.Position = CType(-1, Long)
        Me.NeoTable2.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable2_nID}
        Me.NeoTable2.Quoted = False
        Me.NeoTable2.SelectCommand = Me.SqlCommand1
        Me.NeoTable2.TableName = "NeoTable1"
        Me.NeoTable2.Transaction = Nothing
        Me.NeoTable2.UpdateCommand = Me.SqlCommand3
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE SipDetayParam_054_GarniDikis SET Deleted = nID  , ModifiedBy = @ModifiedBy" &
    " , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_054_GarniDikis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "UPDATE SipDetayParam_054_GarniDikis SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deleted = @Deleted , ModifiedBy = @Modi" &
    "fiedBy , ModifiedDate = GETDATE() , KategoriParamID = @KategoriParamID , GarniDi" &
    "kis = @GarniDikis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE nID = @nID"
        '
        'tbCizgiRenkKafa
        '
        Me.tbCizgiRenkKafa.Columns.AddRange(New System.Data.DataColumn() {Me.tbCizgiRenkKafa_CizgiRKafaID, Me.tbCizgiRenkKafa_Deleted, Me.tbCizgiRenkKafa_CreatedBy, Me.tbCizgiRenkKafa_CreatedDate, Me.tbCizgiRenkKafa_ModifiedBy, Me.tbCizgiRenkKafa_ModifiedDate, Me.tbCizgiRenkKafa_Tip, Me.tbCizgiRenkKafa_Aciklama, Me.tbCizgiRenkKafa_CizgiSayisi, Me.tbCizgiRenkKafa_RKafa})
        Me.tbCizgiRenkKafa.Connection = Me.SqlConn
        Me.tbCizgiRenkKafa.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"CizgiRKafaID"}, True)})
        Me.tbCizgiRenkKafa.CurrentRow = Nothing
        Me.tbCizgiRenkKafa.DataSourceLink = Nothing
        Me.tbCizgiRenkKafa.DeleteCommand = Me.SqlCommand8
        Me.tbCizgiRenkKafa.Filter = ""
        Me.tbCizgiRenkKafa.InsertCommand = Me.SqlCommand6
        Me.tbCizgiRenkKafa.LiveSave = False
        Me.tbCizgiRenkKafa.MaxRecords = CType(0, Long)
        Me.tbCizgiRenkKafa.Name = "tbCizgiRenkKafa"
        Me.tbCizgiRenkKafa.ParentRelation_ChildColumns = Nothing
        Me.tbCizgiRenkKafa.ParentRelation_ParentColumns = Nothing
        Me.tbCizgiRenkKafa.ParentRelation_Table = Nothing
        Me.tbCizgiRenkKafa.Position = CType(-1, Long)
        Me.tbCizgiRenkKafa.PrimaryKey = New System.Data.DataColumn() {Me.tbCizgiRenkKafa_CizgiRKafaID}
        Me.tbCizgiRenkKafa.Quoted = False
        Me.tbCizgiRenkKafa.SelectCommand = Me.SqlCommand5
        Me.tbCizgiRenkKafa.TableName = "NeoTable2"
        Me.tbCizgiRenkKafa.Transaction = Nothing
        Me.tbCizgiRenkKafa.UpdateCommand = Me.SqlCommand7
        '
        'tbCizgiRenkKafa_CizgiRKafaID
        '
        Me.tbCizgiRenkKafa_CizgiRKafaID.AllowDBNull = False
        Me.tbCizgiRenkKafa_CizgiRKafaID.AutoIncrement = True
        Me.tbCizgiRenkKafa_CizgiRKafaID.ColumnName = "CizgiRKafaID"
        Me.tbCizgiRenkKafa_CizgiRKafaID.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafa_Deleted
        '
        Me.tbCizgiRenkKafa_Deleted.ColumnName = "Deleted"
        Me.tbCizgiRenkKafa_Deleted.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafa_CreatedBy
        '
        Me.tbCizgiRenkKafa_CreatedBy.ColumnName = "CreatedBy"
        Me.tbCizgiRenkKafa_CreatedBy.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafa_CreatedDate
        '
        Me.tbCizgiRenkKafa_CreatedDate.ColumnName = "CreatedDate"
        Me.tbCizgiRenkKafa_CreatedDate.DataType = GetType(Date)
        '
        'tbCizgiRenkKafa_ModifiedBy
        '
        Me.tbCizgiRenkKafa_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbCizgiRenkKafa_ModifiedBy.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafa_ModifiedDate
        '
        Me.tbCizgiRenkKafa_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbCizgiRenkKafa_ModifiedDate.DataType = GetType(Date)
        '
        'tbCizgiRenkKafa_Tip
        '
        Me.tbCizgiRenkKafa_Tip.ColumnName = "Tip"
        '
        'tbCizgiRenkKafa_Aciklama
        '
        Me.tbCizgiRenkKafa_Aciklama.ColumnName = "Aciklama"
        '
        'tbCizgiRenkKafa_CizgiSayisi
        '
        Me.tbCizgiRenkKafa_CizgiSayisi.ColumnName = "CizgiSayisi"
        Me.tbCizgiRenkKafa_CizgiSayisi.DataType = GetType(Integer)
        '
        'tbCizgiRenkKafa_RKafa
        '
        Me.tbCizgiRenkKafa_RKafa.ColumnName = "RKafa"
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM CizgiRenkKafa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 AND Tip='YAKA'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.SqlCommand9.CommandText = "SELECT IplikID" & Global.Microsoft.VisualBasic.ChrW(9) & ",IplikKod,IplikIsmi FROM Iplikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 "
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
        Me.SqlCommand18.CommandText = "INSERT INTO SipDetayParam_051_Tip (" & Global.Microsoft.VisualBasic.ChrW(10) & "SipDetayParamID , SourceID , KategoriParamID " &
    ", Tip)" & Global.Microsoft.VisualBasic.ChrW(10) & " VALUES (" & Global.Microsoft.VisualBasic.ChrW(10) & "@SipDetayParamID , @SourceID , @KategoriParamID , @Tip)" & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT " &
    "@PRIMARYFIELD_nID = SCOPE_IDENTITY() " & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlCommand18.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_051_Tip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = "UPDATE SipDetayParam_051_Tip SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SipDetayParamID = @SipDetayParamID , SourceID " &
    "= @SourceID , KategoriParamID = @KategoriParamID , Tip = @Tip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE nID = @nID"
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
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT * FROM Fason" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RadioGroup1
        '
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "GarniDikis", True))
        Me.RadioGroup1.EditValue = 0
        Me.RadioGroup1.Location = New System.Drawing.Point(3, 3)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Yok"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Reçmeli"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Overloklu"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Karyokalı")})
        Me.RadioGroup1.Size = New System.Drawing.Size(141, 90)
        Me.RadioGroup1.TabIndex = 0
        '
        'RadioGroup2
        '
        Me.RadioGroup2.EditValue = 0
        Me.RadioGroup2.Enabled = False
        Me.RadioGroup2.Location = New System.Drawing.Point(5, 5)
        Me.RadioGroup2.Name = "RadioGroup2"
        Me.RadioGroup2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Yok"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Reçmeli"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Overloklu"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Karyokalı")})
        Me.RadioGroup2.Size = New System.Drawing.Size(141, 90)
        Me.RadioGroup2.TabIndex = 1
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
        'NeoTable2_KategoriParamID
        '
        Me.NeoTable2_KategoriParamID.ColumnName = "KategoriParamID"
        Me.NeoTable2_KategoriParamID.DataType = GetType(Integer)
        '
        'NeoTable2_GarniDikis
        '
        Me.NeoTable2_GarniDikis.ColumnName = "GarniDikis"
        Me.NeoTable2_GarniDikis.DataType = GetType(Integer)
        '
        'MasterTable2_SipDetayParamID
        '
        Me.MasterTable2_SipDetayParamID.AllowDBNull = False
        Me.MasterTable2_SipDetayParamID.AutoIncrement = True
        Me.MasterTable2_SipDetayParamID.ColumnName = "SipDetayParamID"
        Me.MasterTable2_SipDetayParamID.DataType = GetType(Integer)
        '
        'MasterTable2_Deleted
        '
        Me.MasterTable2_Deleted.ColumnName = "Deleted"
        Me.MasterTable2_Deleted.DataType = GetType(Integer)
        '
        'MasterTable2_CreatedBy
        '
        Me.MasterTable2_CreatedBy.ColumnName = "CreatedBy"
        Me.MasterTable2_CreatedBy.DataType = GetType(Integer)
        '
        'MasterTable2_CreatedDate
        '
        Me.MasterTable2_CreatedDate.ColumnName = "CreatedDate"
        Me.MasterTable2_CreatedDate.DataType = GetType(Date)
        '
        'MasterTable2_ModifiedBy
        '
        Me.MasterTable2_ModifiedBy.ColumnName = "ModifiedBy"
        Me.MasterTable2_ModifiedBy.DataType = GetType(Integer)
        '
        'MasterTable2_ModifiedDate
        '
        Me.MasterTable2_ModifiedDate.ColumnName = "ModifiedDate"
        Me.MasterTable2_ModifiedDate.DataType = GetType(Date)
        '
        'MasterTable2_SipDetayID
        '
        Me.MasterTable2_SipDetayID.ColumnName = "SipDetayID"
        Me.MasterTable2_SipDetayID.DataType = GetType(Integer)
        '
        'MasterTable2_ParamType
        '
        Me.MasterTable2_ParamType.ColumnName = "ParamType"
        '
        'MasterTable2_KategoriParamID
        '
        Me.MasterTable2_KategoriParamID.ColumnName = "KategoriParamID"
        Me.MasterTable2_KategoriParamID.DataType = GetType(Integer)
        '
        'MasterTable2_HammaddeID
        '
        Me.MasterTable2_HammaddeID.ColumnName = "HammaddeID"
        Me.MasterTable2_HammaddeID.DataType = GetType(Integer)
        '
        'MasterTable2_Tur
        '
        Me.MasterTable2_Tur.ColumnName = "Tur"
        Me.MasterTable2_Tur.DataType = GetType(Double)
        '
        'MasterTable2_TurArtis
        '
        Me.MasterTable2_TurArtis.ColumnName = "TurArtis"
        Me.MasterTable2_TurArtis.DataType = GetType(Double)
        '
        'MasterTable2_BelTur
        '
        Me.MasterTable2_BelTur.ColumnName = "BelTur"
        Me.MasterTable2_BelTur.DataType = GetType(Double)
        '
        'MasterTable2_BelTurArtis
        '
        Me.MasterTable2_BelTurArtis.ColumnName = "BelTurArtis"
        Me.MasterTable2_BelTurArtis.DataType = GetType(Double)
        '
        'MasterTable2_KolTur
        '
        Me.MasterTable2_KolTur.ColumnName = "KolTur"
        Me.MasterTable2_KolTur.DataType = GetType(Double)
        '
        'MasterTable2_KolTurArtis
        '
        Me.MasterTable2_KolTurArtis.ColumnName = "KolTurArtis"
        Me.MasterTable2_KolTurArtis.DataType = GetType(Double)
        '
        'MasterTable2_RenkID
        '
        Me.MasterTable2_RenkID.ColumnName = "RenkID"
        Me.MasterTable2_RenkID.DataType = GetType(Integer)
        '
        'MasterTable2_CizgiSayisi
        '
        Me.MasterTable2_CizgiSayisi.ColumnName = "CizgiSayisi"
        Me.MasterTable2_CizgiSayisi.DataType = GetType(Integer)
        '
        'MasterTable2_IntParam1
        '
        Me.MasterTable2_IntParam1.ColumnName = "IntParam1"
        Me.MasterTable2_IntParam1.DataType = GetType(Integer)
        '
        'MasterTable2_RenkID2
        '
        Me.MasterTable2_RenkID2.ColumnName = "RenkID2"
        Me.MasterTable2_RenkID2.DataType = GetType(Integer)
        '
        'MasterTable2_CizgiSayisi2
        '
        Me.MasterTable2_CizgiSayisi2.ColumnName = "CizgiSayisi2"
        Me.MasterTable2_CizgiSayisi2.DataType = GetType(Integer)
        '
        'MasterTable2_bVar
        '
        Me.MasterTable2_bVar.ColumnName = "bVar"
        Me.MasterTable2_bVar.DataType = GetType(Integer)
        '
        'MasterTable2_IntParam2
        '
        Me.MasterTable2_IntParam2.ColumnName = "IntParam2"
        Me.MasterTable2_IntParam2.DataType = GetType(Integer)
        '
        'MasterTable2_IntParam3
        '
        Me.MasterTable2_IntParam3.ColumnName = "IntParam3"
        Me.MasterTable2_IntParam3.DataType = GetType(Integer)
        '
        'MasterTable2_CharParam1
        '
        Me.MasterTable2_CharParam1.ColumnName = "CharParam1"
        '
        'MasterTable_KategoriParamID
        '
        Me.MasterTable_KategoriParamID.AllowDBNull = False
        Me.MasterTable_KategoriParamID.AutoIncrement = True
        Me.MasterTable_KategoriParamID.ColumnName = "KategoriParamID"
        Me.MasterTable_KategoriParamID.DataType = GetType(Integer)
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
        'MasterTable_KategoriID
        '
        Me.MasterTable_KategoriID.ColumnName = "KategoriID"
        Me.MasterTable_KategoriID.DataType = GetType(Integer)
        '
        'MasterTable_ParamType
        '
        Me.MasterTable_ParamType.ColumnName = "ParamType"
        '
        'MasterTable_Secmeli
        '
        Me.MasterTable_Secmeli.ColumnName = "Secmeli"
        Me.MasterTable_Secmeli.DataType = GetType(Integer)
        '
        'MasterTable_HammaddeID
        '
        Me.MasterTable_HammaddeID.ColumnName = "HammaddeID"
        Me.MasterTable_HammaddeID.DataType = GetType(Integer)
        '
        'MasterTable_Tur
        '
        Me.MasterTable_Tur.ColumnName = "Tur"
        Me.MasterTable_Tur.DataType = GetType(Double)
        '
        'MasterTable_TurArtis
        '
        Me.MasterTable_TurArtis.ColumnName = "TurArtis"
        Me.MasterTable_TurArtis.DataType = GetType(Double)
        '
        'MasterTable_BelTur
        '
        Me.MasterTable_BelTur.ColumnName = "BelTur"
        Me.MasterTable_BelTur.DataType = GetType(Double)
        '
        'MasterTable_BelTurArtis
        '
        Me.MasterTable_BelTurArtis.ColumnName = "BelTurArtis"
        Me.MasterTable_BelTurArtis.DataType = GetType(Double)
        '
        'MasterTable_KolTur
        '
        Me.MasterTable_KolTur.ColumnName = "KolTur"
        Me.MasterTable_KolTur.DataType = GetType(Double)
        '
        'MasterTable_KolTurArtis
        '
        Me.MasterTable_KolTurArtis.ColumnName = "KolTurArtis"
        Me.MasterTable_KolTurArtis.DataType = GetType(Double)
        '
        'MasterTable_IpGramaj
        '
        Me.MasterTable_IpGramaj.ColumnName = "IpGramaj"
        Me.MasterTable_IpGramaj.DataType = GetType(Double)
        '
        'MasterTable_IpGramajArtis
        '
        Me.MasterTable_IpGramajArtis.ColumnName = "IpGramajArtis"
        Me.MasterTable_IpGramajArtis.DataType = GetType(Double)
        '
        'MasterTable_IntParam1
        '
        Me.MasterTable_IntParam1.ColumnName = "IntParam1"
        Me.MasterTable_IntParam1.DataType = GetType(Integer)
        '
        'MasterTable_IntParam2
        '
        Me.MasterTable_IntParam2.ColumnName = "IntParam2"
        Me.MasterTable_IntParam2.DataType = GetType(Integer)
        '
        'MasterTable_IntParam3
        '
        Me.MasterTable_IntParam3.ColumnName = "IntParam3"
        Me.MasterTable_IntParam3.DataType = GetType(Integer)
        '
        'cnt054_GarniDikis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Caption = "Garni Dikiş"
        Me.Code = "054"
        Me.Controls.Add(Me.TextEdit2)
        Me.Name = "cnt054_GarniDikis"
        Me.Size = New System.Drawing.Size(167, 162)
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
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCizgiRenkKafa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeoTable2 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbIplik As NeoDAC.NeoTable
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbCizgiRenkKafa As NeoDAC.NeoTable
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbRenk As NeoDAC.NeoTable
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
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents RadioGroup2 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents tbCizgiRenkKafa_CizgiRKafaID As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_Deleted As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_Tip As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_Aciklama As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_CizgiSayisi As System.Data.DataColumn
    Friend WithEvents tbCizgiRenkKafa_RKafa As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikID As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikKod As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikIsmi As System.Data.DataColumn
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
    Friend WithEvents NeoTable2_nID As DataColumn
    Friend WithEvents NeoTable2_Deleted As DataColumn
    Friend WithEvents NeoTable2_CreatedBy As DataColumn
    Friend WithEvents NeoTable2_CreatedDate As DataColumn
    Friend WithEvents NeoTable2_ModifiedBy As DataColumn
    Friend WithEvents NeoTable2_ModifiedDate As DataColumn
    Friend WithEvents NeoTable2_KategoriParamID As DataColumn
    Friend WithEvents NeoTable2_GarniDikis As DataColumn
    Friend WithEvents MasterTable2_SipDetayParamID As DataColumn
    Friend WithEvents MasterTable2_Deleted As DataColumn
    Friend WithEvents MasterTable2_CreatedBy As DataColumn
    Friend WithEvents MasterTable2_CreatedDate As DataColumn
    Friend WithEvents MasterTable2_ModifiedBy As DataColumn
    Friend WithEvents MasterTable2_ModifiedDate As DataColumn
    Friend WithEvents MasterTable2_SipDetayID As DataColumn
    Friend WithEvents MasterTable2_ParamType As DataColumn
    Friend WithEvents MasterTable2_KategoriParamID As DataColumn
    Friend WithEvents MasterTable2_HammaddeID As DataColumn
    Friend WithEvents MasterTable2_Tur As DataColumn
    Friend WithEvents MasterTable2_TurArtis As DataColumn
    Friend WithEvents MasterTable2_BelTur As DataColumn
    Friend WithEvents MasterTable2_BelTurArtis As DataColumn
    Friend WithEvents MasterTable2_KolTur As DataColumn
    Friend WithEvents MasterTable2_KolTurArtis As DataColumn
    Friend WithEvents MasterTable2_RenkID As DataColumn
    Friend WithEvents MasterTable2_CizgiSayisi As DataColumn
    Friend WithEvents MasterTable2_IntParam1 As DataColumn
    Friend WithEvents MasterTable2_RenkID2 As DataColumn
    Friend WithEvents MasterTable2_CizgiSayisi2 As DataColumn
    Friend WithEvents MasterTable2_bVar As DataColumn
    Friend WithEvents MasterTable2_IntParam2 As DataColumn
    Friend WithEvents MasterTable2_IntParam3 As DataColumn
    Friend WithEvents MasterTable2_CharParam1 As DataColumn
    Friend WithEvents MasterTable_KategoriParamID As DataColumn
    Friend WithEvents MasterTable_Deleted As DataColumn
    Friend WithEvents MasterTable_CreatedBy As DataColumn
    Friend WithEvents MasterTable_CreatedDate As DataColumn
    Friend WithEvents MasterTable_ModifiedBy As DataColumn
    Friend WithEvents MasterTable_ModifiedDate As DataColumn
    Friend WithEvents MasterTable_KategoriID As DataColumn
    Friend WithEvents MasterTable_ParamType As DataColumn
    Friend WithEvents MasterTable_Secmeli As DataColumn
    Friend WithEvents MasterTable_HammaddeID As DataColumn
    Friend WithEvents MasterTable_Tur As DataColumn
    Friend WithEvents MasterTable_TurArtis As DataColumn
    Friend WithEvents MasterTable_BelTur As DataColumn
    Friend WithEvents MasterTable_BelTurArtis As DataColumn
    Friend WithEvents MasterTable_KolTur As DataColumn
    Friend WithEvents MasterTable_KolTurArtis As DataColumn
    Friend WithEvents MasterTable_IpGramaj As DataColumn
    Friend WithEvents MasterTable_IpGramajArtis As DataColumn
    Friend WithEvents MasterTable_IntParam1 As DataColumn
    Friend WithEvents MasterTable_IntParam2 As DataColumn
    Friend WithEvents MasterTable_IntParam3 As DataColumn
End Class
