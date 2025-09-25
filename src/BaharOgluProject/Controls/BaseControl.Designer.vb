<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseControl))
        Me.lblCaption = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SqlConn = New NeoDAC.NeoConnection(Me.components)
        Me.MasterTable = New NeoDAC.NeoTable(Me.components)
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
        Me.MasterSqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.MasterSqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.MasterSqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.MasterSqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.panelCaption = New DevExpress.XtraEditors.PanelControl()
        Me.chkVar = New DevExpress.XtraEditors.CheckEdit()
        Me.MasterTable2 = New NeoDAC.NeoTable(Me.components)
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
        Me.Master2SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Master2SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Master2SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Master2SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.chkSecmeli = New DevExpress.XtraEditors.CheckEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCaption.SuspendLayout()
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCaption.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCaption.Location = New System.Drawing.Point(2, 2)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(126, 22)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Caption"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(22, 45)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(213, 78)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(207, 50)
        Me.XtraTabPage1.Text = "Ayar"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(207, 50)
        Me.XtraTabPage2.Text = "Uygulama"
        '
        'SqlConn
        '
        Me.SqlConn.ConnectionString = "Server=(local);Database=ProbarSiparisDB2025;User ID=sa;Password=;Trusted_Connecti" &
    "on=True;"
        Me.SqlConn.Name = "SqlConn"
        Me.SqlConn.UserInfo_AuthCodeFieldName = "AuthCode"
        Me.SqlConn.UserInfo_CanDeleteAuthCode = ""
        Me.SqlConn.UserInfo_CanReadAuthCode = ""
        Me.SqlConn.UserInfo_CanWriteAuthCode = ""
        Me.SqlConn.UserInfo_CreatedDateFieldName = "CreatedDate"
        Me.SqlConn.UserInfo_CreatedUserFieldName = "CreatedBy"
        Me.SqlConn.UserInfo_ModifiedDateFieldName = "ModifiedDate"
        Me.SqlConn.UserInfo_ModifiedUserFieldName = "ModifiedBy"
        Me.SqlConn.UserInfo_NewRecordAuthCode = ""
        Me.SqlConn.UserInfo_UserID = Nothing
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KategoriParamID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_KategoriID, Me.MasterTable_ParamType, Me.MasterTable_Secmeli, Me.MasterTable_HammaddeID, Me.MasterTable_Tur, Me.MasterTable_TurArtis, Me.MasterTable_BelTur, Me.MasterTable_BelTurArtis, Me.MasterTable_KolTur, Me.MasterTable_KolTurArtis, Me.MasterTable_IpGramaj, Me.MasterTable_IpGramajArtis, Me.MasterTable_IntParam1, Me.MasterTable_IntParam2, Me.MasterTable_IntParam3})
        Me.MasterTable.Connection = Me.SqlConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriParamID"}, True)})
        Me.MasterTable.CurrentRow = Nothing
        Me.MasterTable.DataSourceLink = Nothing
        Me.MasterTable.DeleteCommand = Me.MasterSqlCommand4
        Me.MasterTable.Filter = ""
        Me.MasterTable.InsertCommand = Me.MasterSqlCommand2
        Me.MasterTable.LiveSave = False
        Me.MasterTable.MaxRecords = CType(0, Long)
        Me.MasterTable.Name = "MasterTable"
        Me.MasterTable.ParentRelation_ChildColumns = Nothing
        Me.MasterTable.ParentRelation_ParentColumns = Nothing
        Me.MasterTable.ParentRelation_Table = Nothing
        Me.MasterTable.Position = CType(-1, Long)
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KategoriParamID}
        Me.MasterTable.Quoted = False
        Me.MasterTable.SelectCommand = Me.MasterSqlCommand1
        Me.MasterTable.TableName = "NeoTable1"
        Me.MasterTable.Transaction = Nothing
        Me.MasterTable.UpdateCommand = Me.MasterSqlCommand3
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
        'MasterSqlCommand4
        '
        Me.MasterSqlCommand4.CommandText = "UPDATE KategoriParam SET Deleted = KategoriParamID  , ModifiedBy = @ModifiedBy , " &
    "ModifiedDate = GETDATE()   WHERE KategoriParamID = @KategoriParamID"
        '
        'MasterSqlCommand2
        '
        Me.MasterSqlCommand2.CommandText = resources.GetString("MasterSqlCommand2.CommandText")
        Me.MasterSqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KategoriParamID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'MasterSqlCommand1
        '
        Me.MasterSqlCommand1.CommandText = "SELECT * FROM KategoriParam" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'MasterSqlCommand3
        '
        Me.MasterSqlCommand3.CommandText = resources.GetString("MasterSqlCommand3.CommandText")
        '
        'panelCaption
        '
        Me.panelCaption.Controls.Add(Me.lblCaption)
        Me.panelCaption.Controls.Add(Me.chkVar)
        Me.panelCaption.Controls.Add(Me.chkSecmeli)
        Me.panelCaption.Location = New System.Drawing.Point(26, 16)
        Me.panelCaption.Name = "panelCaption"
        Me.panelCaption.Size = New System.Drawing.Size(227, 26)
        Me.panelCaption.TabIndex = 5
        '
        'chkVar
        '
        Me.chkVar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterTable2, "bVar", True))
        Me.chkVar.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkVar.Location = New System.Drawing.Point(128, 2)
        Me.chkVar.Name = "chkVar"
        Me.chkVar.Properties.Caption = "Var"
        Me.chkVar.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkVar.Properties.ValueChecked = 1
        Me.chkVar.Properties.ValueUnchecked = 0
        Me.chkVar.Size = New System.Drawing.Size(39, 19)
        Me.chkVar.TabIndex = 5
        '
        'MasterTable2
        '
        Me.MasterTable2.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable2_SipDetayParamID, Me.MasterTable2_Deleted, Me.MasterTable2_CreatedBy, Me.MasterTable2_CreatedDate, Me.MasterTable2_ModifiedBy, Me.MasterTable2_ModifiedDate, Me.MasterTable2_SipDetayID, Me.MasterTable2_ParamType, Me.MasterTable2_KategoriParamID, Me.MasterTable2_HammaddeID, Me.MasterTable2_Tur, Me.MasterTable2_TurArtis, Me.MasterTable2_BelTur, Me.MasterTable2_BelTurArtis, Me.MasterTable2_KolTur, Me.MasterTable2_KolTurArtis, Me.MasterTable2_RenkID, Me.MasterTable2_CizgiSayisi, Me.MasterTable2_IntParam1, Me.MasterTable2_RenkID2, Me.MasterTable2_CizgiSayisi2, Me.MasterTable2_bVar, Me.MasterTable2_IntParam2, Me.MasterTable2_IntParam3, Me.MasterTable2_CharParam1})
        Me.MasterTable2.Connection = Me.SqlConn
        Me.MasterTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"SipDetayParamID"}, True)})
        Me.MasterTable2.CurrentRow = Nothing
        Me.MasterTable2.DataSourceLink = Nothing
        Me.MasterTable2.DeleteCommand = Me.Master2SqlCommand4
        Me.MasterTable2.Filter = ""
        Me.MasterTable2.InsertCommand = Me.Master2SqlCommand2
        Me.MasterTable2.LiveSave = False
        Me.MasterTable2.MaxRecords = CType(0, Long)
        Me.MasterTable2.Name = "MasterTable2"
        Me.MasterTable2.ParentRelation_ChildColumns = Nothing
        Me.MasterTable2.ParentRelation_ParentColumns = Nothing
        Me.MasterTable2.ParentRelation_Table = Nothing
        Me.MasterTable2.Position = CType(-1, Long)
        Me.MasterTable2.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable2_SipDetayParamID}
        Me.MasterTable2.Quoted = False
        Me.MasterTable2.SelectCommand = Me.Master2SqlCommand1
        Me.MasterTable2.TableName = "NeoTable1"
        Me.MasterTable2.Transaction = Nothing
        Me.MasterTable2.UpdateCommand = Me.Master2SqlCommand3
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
        'Master2SqlCommand4
        '
        Me.Master2SqlCommand4.CommandText = "UPDATE SipDetayParam SET Deleted = SipDetayParamID  , ModifiedBy = @ModifiedBy , " &
    "ModifiedDate = GETDATE()   WHERE SipDetayParamID = @SipDetayParamID"
        '
        'Master2SqlCommand2
        '
        Me.Master2SqlCommand2.CommandText = resources.GetString("Master2SqlCommand2.CommandText")
        Me.Master2SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_SipDetayParamID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'Master2SqlCommand1
        '
        Me.Master2SqlCommand1.CommandText = "SELECT * FROM SipDetayParam" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'Master2SqlCommand3
        '
        Me.Master2SqlCommand3.CommandText = resources.GetString("Master2SqlCommand3.CommandText")
        '
        'chkSecmeli
        '
        Me.chkSecmeli.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterTable, "Secmeli", True))
        Me.chkSecmeli.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkSecmeli.Location = New System.Drawing.Point(167, 2)
        Me.chkSecmeli.Name = "chkSecmeli"
        Me.chkSecmeli.Properties.Caption = "Seçmeli"
        Me.chkSecmeli.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkSecmeli.Properties.ValueChecked = 1
        Me.chkSecmeli.Properties.ValueUnchecked = 0
        Me.chkSecmeli.Size = New System.Drawing.Size(58, 19)
        Me.chkSecmeli.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LabelControl1
        '
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.LabelControl1.Location = New System.Drawing.Point(254, 120)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "_l"
        '
        'BaseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.panelCaption)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "BaseControl"
        Me.Size = New System.Drawing.Size(277, 137)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCaption.ResumeLayout(False)
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblCaption As DevExpress.XtraEditors.LabelControl
    Public WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents SqlConn As NeoDAC.NeoConnection
    Public WithEvents MasterTable As NeoDAC.NeoTable
    Public WithEvents MasterSqlCommand4 As System.Data.SqlClient.SqlCommand
    Public WithEvents MasterSqlCommand2 As System.Data.SqlClient.SqlCommand
    Public WithEvents MasterSqlCommand1 As System.Data.SqlClient.SqlCommand
    Public WithEvents MasterSqlCommand3 As System.Data.SqlClient.SqlCommand
    Public WithEvents panelCaption As DevExpress.XtraEditors.PanelControl
    Public WithEvents chkSecmeli As DevExpress.XtraEditors.CheckEdit
    Public WithEvents MasterTable2 As NeoDAC.NeoTable
    Public WithEvents Master2SqlCommand4 As System.Data.SqlClient.SqlCommand
    Public WithEvents Master2SqlCommand2 As System.Data.SqlClient.SqlCommand
    Public WithEvents Master2SqlCommand1 As System.Data.SqlClient.SqlCommand
    Public WithEvents Master2SqlCommand3 As System.Data.SqlClient.SqlCommand
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents chkVar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
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
End Class
