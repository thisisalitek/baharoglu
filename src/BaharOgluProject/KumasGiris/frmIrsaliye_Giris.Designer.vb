<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIrsaliye_Giris
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIrsaliye_Giris))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTarih = New DevExpress.XtraEditors.DateEdit()
        Me.MasterLink = New NeoDAC.NeoLink(Me.components)
        Me.MasterTable = New NeoDAC.NeoTable(Me.components)
        Me.MasterTable_KumasGirisID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_IrsaliyeType = New System.Data.DataColumn()
        Me.MasterTable_IrsTarih = New System.Data.DataColumn()
        Me.MasterTable_IrsEvrakSeri = New System.Data.DataColumn()
        Me.MasterTable_IrsEvrakSira = New System.Data.DataColumn()
        Me.MasterTable_IrsaliyeNo = New System.Data.DataColumn()
        Me.MasterTable_BelgeNo = New System.Data.DataColumn()
        Me.MasterTable_IsEmriNo = New System.Data.DataColumn()
        Me.MasterTable_CariKod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_Aciklama1 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama2 = New System.Data.DataColumn()
        Me.MasterTable_Aciklama3 = New System.Data.DataColumn()
        Me.MasterTable_Depo = New System.Data.DataColumn()
        Me.MasterTable_Depo2 = New System.Data.DataColumn()
        Me.MasterTable_AraToplam = New System.Data.DataColumn()
        Me.MasterTable_KdvOran = New System.Data.DataColumn()
        Me.MasterTable_KdvTutar = New System.Data.DataColumn()
        Me.MasterTable_GenelToplam = New System.Data.DataColumn()
        Me.MasterTable_DovizTipi = New System.Data.DataColumn()
        Me.MasterTable_DovizKuru = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_Transferred = New System.Data.DataColumn()
        Me.MasterTable_TransferDate = New System.Data.DataColumn()
        Me.MasterTable_Pasif = New System.Data.DataColumn()
        Me.FirmConn = New NeoDAC.NeoConnection(Me.components)
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIrsEvrakSeri = New DevExpress.XtraEditors.TextEdit()
        Me.txtIrsEvrakSira = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepo2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDepo = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCariKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCariUnvan = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblCariKod = New DevExpress.XtraEditors.LabelControl()
        Me.lblCariUnvan = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lblIsEmriNo = New DevExpress.XtraEditors.LabelControl()
        Me.DetailTable = New NeoDAC.NeoTable(Me.components)
        Me.DetailTable_KumasGirisDetayID = New System.Data.DataColumn()
        Me.DetailTable_Deleted = New System.Data.DataColumn()
        Me.DetailTable_CreatedBy = New System.Data.DataColumn()
        Me.DetailTable_CreatedDate = New System.Data.DataColumn()
        Me.DetailTable_ModifiedBy = New System.Data.DataColumn()
        Me.DetailTable_ModifiedDate = New System.Data.DataColumn()
        Me.DetailTable_KumasGirisID = New System.Data.DataColumn()
        Me.DetailTable_StokKod = New System.Data.DataColumn()
        Me.DetailTable_StokIsmi = New System.Data.DataColumn()
        Me.DetailTable_Aciklama = New System.Data.DataColumn()
        Me.DetailTable_Miktar = New System.Data.DataColumn()
        Me.DetailTable_Birim = New System.Data.DataColumn()
        Me.DetailTable_Fiyat = New System.Data.DataColumn()
        Me.DetailTable_Tutar = New System.Data.DataColumn()
        Me.DetailTable_Parti = New System.Data.DataColumn()
        Me.DetailTable_LotNo = New System.Data.DataColumn()
        Me.DetailTable_Field1 = New System.Data.DataColumn()
        Me.DetailTable_Field2 = New System.Data.DataColumn()
        Me.DetailTable_Field3 = New System.Data.DataColumn()
        Me.DetailTable_Field4 = New System.Data.DataColumn()
        Me.DetailTable_Field5 = New System.Data.DataColumn()
        Me.DetailTable_IntCode = New System.Data.DataColumn()
        Me.DetailTable_Transferred = New System.Data.DataColumn()
        Me.DetailTable_TransferDate = New System.Data.DataColumn()
        Me.DetailLink = New NeoDAC.NeoLink(Me.components)
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIsEmriNo = New DevExpress.XtraEditors.TextEdit()
        Me.cboIrsaliyeType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdGiris = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYazici = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.chkAnlikBaski = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMiktar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSatirOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLotNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtParti = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStokIsmi = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtStokKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKumasGirisDetayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnPrintDetay = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colKumasGirisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokIsmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdTopluYazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.tmrMiktarFocus = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtTarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIrsEvrakSeri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIrsEvrakSira.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCariKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCariUnvan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtIsEmriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIrsaliyeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cboYazici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAnlikBaski.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMiktar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLotNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokIsmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrintDetay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tarih"
        '
        'txtTarih
        '
        Me.txtTarih.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IrsTarih", True))
        Me.txtTarih.EditValue = Nothing
        Me.txtTarih.EnterMoveNextControl = True
        Me.txtTarih.Location = New System.Drawing.Point(54, 33)
        Me.txtTarih.Name = "txtTarih"
        Me.txtTarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtTarih.Size = New System.Drawing.Size(145, 20)
        Me.txtTarih.TabIndex = 1
        '
        'MasterLink
        '
        Me.MasterLink.DataSource = Me.MasterTable
        Me.MasterLink.Name = "MasterLink"
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KumasGirisID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_IrsaliyeType, Me.MasterTable_IrsTarih, Me.MasterTable_IrsEvrakSeri, Me.MasterTable_IrsEvrakSira, Me.MasterTable_IrsaliyeNo, Me.MasterTable_BelgeNo, Me.MasterTable_IsEmriNo, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_Aciklama1, Me.MasterTable_Aciklama2, Me.MasterTable_Aciklama3, Me.MasterTable_Depo, Me.MasterTable_Depo2, Me.MasterTable_AraToplam, Me.MasterTable_KdvOran, Me.MasterTable_KdvTutar, Me.MasterTable_GenelToplam, Me.MasterTable_DovizTipi, Me.MasterTable_DovizKuru, Me.MasterTable_IntCode, Me.MasterTable_Transferred, Me.MasterTable_TransferDate, Me.MasterTable_Pasif})
        Me.MasterTable.Connection = Me.FirmConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KumasGirisID"}, True)})
        Me.MasterTable.CurrentRow = Nothing
        Me.MasterTable.DataSourceLink = Me.MasterLink
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.Filter = ""
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.LiveSave = True
        Me.MasterTable.MaxRecords = CType(0, Long)
        Me.MasterTable.Name = "MasterTable"
        Me.MasterTable.ParentRelation_ChildColumns = Nothing
        Me.MasterTable.ParentRelation_ParentColumns = Nothing
        Me.MasterTable.ParentRelation_Table = Nothing
        Me.MasterTable.Position = CType(-1, Long)
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KumasGirisID}
        Me.MasterTable.Quoted = False
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.TableName = "NeoTable1"
        Me.MasterTable.Transaction = Nothing
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'MasterTable_KumasGirisID
        '
        Me.MasterTable_KumasGirisID.AllowDBNull = False
        Me.MasterTable_KumasGirisID.AutoIncrement = True
        Me.MasterTable_KumasGirisID.ColumnName = "KumasGirisID"
        Me.MasterTable_KumasGirisID.DataType = GetType(Integer)
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
        'MasterTable_IrsaliyeType
        '
        Me.MasterTable_IrsaliyeType.ColumnName = "IrsaliyeType"
        Me.MasterTable_IrsaliyeType.DataType = GetType(Integer)
        '
        'MasterTable_IrsTarih
        '
        Me.MasterTable_IrsTarih.ColumnName = "IrsTarih"
        Me.MasterTable_IrsTarih.DataType = GetType(Date)
        '
        'MasterTable_IrsEvrakSeri
        '
        Me.MasterTable_IrsEvrakSeri.ColumnName = "IrsEvrakSeri"
        '
        'MasterTable_IrsEvrakSira
        '
        Me.MasterTable_IrsEvrakSira.ColumnName = "IrsEvrakSira"
        Me.MasterTable_IrsEvrakSira.DataType = GetType(Integer)
        '
        'MasterTable_IrsaliyeNo
        '
        Me.MasterTable_IrsaliyeNo.ColumnName = "IrsaliyeNo"
        '
        'MasterTable_BelgeNo
        '
        Me.MasterTable_BelgeNo.ColumnName = "BelgeNo"
        '
        'MasterTable_IsEmriNo
        '
        Me.MasterTable_IsEmriNo.ColumnName = "IsEmriNo"
        '
        'MasterTable_CariKod
        '
        Me.MasterTable_CariKod.ColumnName = "CariKod"
        '
        'MasterTable_CariUnvan
        '
        Me.MasterTable_CariUnvan.ColumnName = "CariUnvan"
        '
        'MasterTable_Aciklama1
        '
        Me.MasterTable_Aciklama1.ColumnName = "Aciklama1"
        '
        'MasterTable_Aciklama2
        '
        Me.MasterTable_Aciklama2.ColumnName = "Aciklama2"
        '
        'MasterTable_Aciklama3
        '
        Me.MasterTable_Aciklama3.ColumnName = "Aciklama3"
        '
        'MasterTable_Depo
        '
        Me.MasterTable_Depo.ColumnName = "Depo"
        '
        'MasterTable_Depo2
        '
        Me.MasterTable_Depo2.ColumnName = "Depo2"
        '
        'MasterTable_AraToplam
        '
        Me.MasterTable_AraToplam.ColumnName = "AraToplam"
        Me.MasterTable_AraToplam.DataType = GetType(Double)
        '
        'MasterTable_KdvOran
        '
        Me.MasterTable_KdvOran.ColumnName = "KdvOran"
        Me.MasterTable_KdvOran.DataType = GetType(Double)
        '
        'MasterTable_KdvTutar
        '
        Me.MasterTable_KdvTutar.ColumnName = "KdvTutar"
        Me.MasterTable_KdvTutar.DataType = GetType(Double)
        '
        'MasterTable_GenelToplam
        '
        Me.MasterTable_GenelToplam.ColumnName = "GenelToplam"
        Me.MasterTable_GenelToplam.DataType = GetType(Double)
        '
        'MasterTable_DovizTipi
        '
        Me.MasterTable_DovizTipi.ColumnName = "DovizTipi"
        '
        'MasterTable_DovizKuru
        '
        Me.MasterTable_DovizKuru.ColumnName = "DovizKuru"
        Me.MasterTable_DovizKuru.DataType = GetType(Double)
        '
        'MasterTable_IntCode
        '
        Me.MasterTable_IntCode.ColumnName = "IntCode"
        '
        'MasterTable_Transferred
        '
        Me.MasterTable_Transferred.ColumnName = "Transferred"
        Me.MasterTable_Transferred.DataType = GetType(Integer)
        '
        'MasterTable_TransferDate
        '
        Me.MasterTable_TransferDate.ColumnName = "TransferDate"
        Me.MasterTable_TransferDate.DataType = GetType(Date)
        '
        'MasterTable_Pasif
        '
        Me.MasterTable_Pasif.ColumnName = "Pasif"
        Me.MasterTable_Pasif.DataType = GetType(Integer)
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Server=(local)\SQLExpress;Database=ProbarSiparisDB;User ID=sa;Password=;Trusted_C" & _
    "onnection=True;"
        Me.FirmConn.Name = "FirmConn"
        Me.FirmConn.UserInfo_AuthCodeFieldName = "AuthCode"
        Me.FirmConn.UserInfo_CanDeleteAuthCode = ""
        Me.FirmConn.UserInfo_CanReadAuthCode = ""
        Me.FirmConn.UserInfo_CanWriteAuthCode = ""
        Me.FirmConn.UserInfo_CreatedDateFieldName = "CreatedDate"
        Me.FirmConn.UserInfo_CreatedUserFieldName = "CreatedBy"
        Me.FirmConn.UserInfo_ModifiedDateFieldName = "ModifiedDate"
        Me.FirmConn.UserInfo_ModifiedUserFieldName = "ModifiedBy"
        Me.FirmConn.UserInfo_NewRecordAuthCode = ""
        Me.FirmConn.UserInfo_UserID = Nothing
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KumasGiris SET Deleted = KumasGirisID  , ModifiedBy = @ModifiedBy , Modifi" & _
    "edDate = GETDATE()   WHERE KumasGirisID = @KumasGirisID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT * FROM KumasGiris WHERE Deleted = 0 AND 1=0 "
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(233, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Evrak Seri /Sıra"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(364, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "/"
        '
        'txtIrsEvrakSeri
        '
        Me.txtIrsEvrakSeri.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IrsEvrakSeri", True))
        Me.txtIrsEvrakSeri.EnterMoveNextControl = True
        Me.txtIrsEvrakSeri.Location = New System.Drawing.Point(312, 33)
        Me.txtIrsEvrakSeri.Name = "txtIrsEvrakSeri"
        Me.txtIrsEvrakSeri.Size = New System.Drawing.Size(46, 20)
        Me.txtIrsEvrakSeri.TabIndex = 4
        '
        'txtIrsEvrakSira
        '
        Me.txtIrsEvrakSira.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IrsEvrakSira", True))
        Me.txtIrsEvrakSira.EnterMoveNextControl = True
        Me.txtIrsEvrakSira.Location = New System.Drawing.Point(374, 33)
        Me.txtIrsEvrakSira.Name = "txtIrsEvrakSira"
        Me.txtIrsEvrakSira.Size = New System.Drawing.Size(90, 20)
        Me.txtIrsEvrakSira.TabIndex = 5
        '
        'txtDepo2
        '
        Me.txtDepo2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Depo2", True))
        Me.txtDepo2.EnterMoveNextControl = True
        Me.txtDepo2.Location = New System.Drawing.Point(312, 89)
        Me.txtDepo2.Name = "txtDepo2"
        Me.txtDepo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDepo2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDepo2.Size = New System.Drawing.Size(175, 20)
        Me.txtDepo2.TabIndex = 14
        Me.txtDepo2.Visible = False
        '
        'txtDepo
        '
        Me.txtDepo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Depo", True))
        Me.txtDepo.EnterMoveNextControl = True
        Me.txtDepo.Location = New System.Drawing.Point(54, 89)
        Me.txtDepo.Name = "txtDepo"
        Me.txtDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDepo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDepo.Size = New System.Drawing.Size(182, 20)
        Me.txtDepo.TabIndex = 15
        '
        'txtCariKodu
        '
        Me.txtCariKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariKod", True))
        Me.txtCariKodu.EnterMoveNextControl = True
        Me.txtCariKodu.Location = New System.Drawing.Point(54, 59)
        Me.txtCariKodu.Name = "txtCariKodu"
        Me.txtCariKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCariKodu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCariKodu.Size = New System.Drawing.Size(182, 20)
        Me.txtCariKodu.TabIndex = 12
        '
        'txtCariUnvan
        '
        Me.txtCariUnvan.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CariUnvan", True))
        Me.txtCariUnvan.EnterMoveNextControl = True
        Me.txtCariUnvan.Location = New System.Drawing.Point(312, 59)
        Me.txtCariUnvan.Name = "txtCariUnvan"
        Me.txtCariUnvan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCariUnvan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCariUnvan.Size = New System.Drawing.Size(302, 20)
        Me.txtCariUnvan.TabIndex = 13
        '
        'lblCariKod
        '
        Me.lblCariKod.Location = New System.Drawing.Point(8, 62)
        Me.lblCariKod.Name = "lblCariKod"
        Me.lblCariKod.Size = New System.Drawing.Size(40, 13)
        Me.lblCariKod.TabIndex = 16
        Me.lblCariKod.Text = "Cari Kod"
        '
        'lblCariUnvan
        '
        Me.lblCariUnvan.Location = New System.Drawing.Point(275, 62)
        Me.lblCariUnvan.Name = "lblCariUnvan"
        Me.lblCariUnvan.Size = New System.Drawing.Size(31, 13)
        Me.lblCariUnvan.TabIndex = 17
        Me.lblCariUnvan.Text = "Ünvan"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 92)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Depo"
        '
        'lblIsEmriNo
        '
        Me.lblIsEmriNo.Location = New System.Drawing.Point(3, 132)
        Me.lblIsEmriNo.Name = "lblIsEmriNo"
        Me.lblIsEmriNo.Size = New System.Drawing.Size(48, 13)
        Me.lblIsEmriNo.TabIndex = 19
        Me.lblIsEmriNo.Text = "İş Emri No"
        Me.lblIsEmriNo.Visible = False
        '
        'DetailTable
        '
        Me.DetailTable.Columns.AddRange(New System.Data.DataColumn() {Me.DetailTable_KumasGirisDetayID, Me.DetailTable_Deleted, Me.DetailTable_CreatedBy, Me.DetailTable_CreatedDate, Me.DetailTable_ModifiedBy, Me.DetailTable_ModifiedDate, Me.DetailTable_KumasGirisID, Me.DetailTable_StokKod, Me.DetailTable_StokIsmi, Me.DetailTable_Aciklama, Me.DetailTable_Miktar, Me.DetailTable_Birim, Me.DetailTable_Fiyat, Me.DetailTable_Tutar, Me.DetailTable_Parti, Me.DetailTable_LotNo, Me.DetailTable_Field1, Me.DetailTable_Field2, Me.DetailTable_Field3, Me.DetailTable_Field4, Me.DetailTable_Field5, Me.DetailTable_IntCode, Me.DetailTable_Transferred, Me.DetailTable_TransferDate})
        Me.DetailTable.Connection = Me.FirmConn
        Me.DetailTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KumasGirisDetayID"}, True)})
        Me.DetailTable.CurrentRow = Nothing
        Me.DetailTable.DataSourceLink = Me.DetailLink
        Me.DetailTable.DeleteCommand = Me.SqlCommand8
        Me.DetailTable.Filter = ""
        Me.DetailTable.InsertCommand = Me.SqlCommand6
        Me.DetailTable.LiveSave = True
        Me.DetailTable.MaxRecords = CType(0, Long)
        Me.DetailTable.Name = "DetailTable"
        Me.DetailTable.ParentRelation_ChildColumns = New String() {"KumasGirisID"}
        Me.DetailTable.ParentRelation_ParentColumns = New String() {"KumasGirisID"}
        Me.DetailTable.ParentRelation_Table = Me.MasterTable
        Me.DetailTable.Position = CType(-1, Long)
        Me.DetailTable.PrimaryKey = New System.Data.DataColumn() {Me.DetailTable_KumasGirisDetayID}
        Me.DetailTable.Quoted = False
        Me.DetailTable.SelectCommand = Me.SqlCommand5
        Me.DetailTable.TableName = "NeoTable1"
        Me.DetailTable.Transaction = Nothing
        Me.DetailTable.UpdateCommand = Me.SqlCommand7
        '
        'DetailTable_KumasGirisDetayID
        '
        Me.DetailTable_KumasGirisDetayID.AllowDBNull = False
        Me.DetailTable_KumasGirisDetayID.AutoIncrement = True
        Me.DetailTable_KumasGirisDetayID.ColumnName = "KumasGirisDetayID"
        Me.DetailTable_KumasGirisDetayID.DataType = GetType(Integer)
        '
        'DetailTable_Deleted
        '
        Me.DetailTable_Deleted.ColumnName = "Deleted"
        Me.DetailTable_Deleted.DataType = GetType(Integer)
        '
        'DetailTable_CreatedBy
        '
        Me.DetailTable_CreatedBy.ColumnName = "CreatedBy"
        Me.DetailTable_CreatedBy.DataType = GetType(Integer)
        '
        'DetailTable_CreatedDate
        '
        Me.DetailTable_CreatedDate.ColumnName = "CreatedDate"
        Me.DetailTable_CreatedDate.DataType = GetType(Date)
        '
        'DetailTable_ModifiedBy
        '
        Me.DetailTable_ModifiedBy.ColumnName = "ModifiedBy"
        Me.DetailTable_ModifiedBy.DataType = GetType(Integer)
        '
        'DetailTable_ModifiedDate
        '
        Me.DetailTable_ModifiedDate.ColumnName = "ModifiedDate"
        Me.DetailTable_ModifiedDate.DataType = GetType(Date)
        '
        'DetailTable_KumasGirisID
        '
        Me.DetailTable_KumasGirisID.ColumnName = "KumasGirisID"
        Me.DetailTable_KumasGirisID.DataType = GetType(Integer)
        '
        'DetailTable_StokKod
        '
        Me.DetailTable_StokKod.ColumnName = "StokKod"
        '
        'DetailTable_StokIsmi
        '
        Me.DetailTable_StokIsmi.ColumnName = "StokIsmi"
        '
        'DetailTable_Aciklama
        '
        Me.DetailTable_Aciklama.ColumnName = "Aciklama"
        '
        'DetailTable_Miktar
        '
        Me.DetailTable_Miktar.ColumnName = "Miktar"
        Me.DetailTable_Miktar.DataType = GetType(Double)
        '
        'DetailTable_Birim
        '
        Me.DetailTable_Birim.ColumnName = "Birim"
        '
        'DetailTable_Fiyat
        '
        Me.DetailTable_Fiyat.ColumnName = "Fiyat"
        Me.DetailTable_Fiyat.DataType = GetType(Double)
        '
        'DetailTable_Tutar
        '
        Me.DetailTable_Tutar.ColumnName = "Tutar"
        Me.DetailTable_Tutar.DataType = GetType(Double)
        '
        'DetailTable_Parti
        '
        Me.DetailTable_Parti.ColumnName = "Parti"
        '
        'DetailTable_LotNo
        '
        Me.DetailTable_LotNo.ColumnName = "LotNo"
        Me.DetailTable_LotNo.DataType = GetType(Integer)
        '
        'DetailTable_Field1
        '
        Me.DetailTable_Field1.ColumnName = "Field1"
        '
        'DetailTable_Field2
        '
        Me.DetailTable_Field2.ColumnName = "Field2"
        '
        'DetailTable_Field3
        '
        Me.DetailTable_Field3.ColumnName = "Field3"
        '
        'DetailTable_Field4
        '
        Me.DetailTable_Field4.ColumnName = "Field4"
        '
        'DetailTable_Field5
        '
        Me.DetailTable_Field5.ColumnName = "Field5"
        '
        'DetailTable_IntCode
        '
        Me.DetailTable_IntCode.ColumnName = "IntCode"
        '
        'DetailTable_Transferred
        '
        Me.DetailTable_Transferred.ColumnName = "Transferred"
        Me.DetailTable_Transferred.DataType = GetType(Integer)
        '
        'DetailTable_TransferDate
        '
        Me.DetailTable_TransferDate.ColumnName = "TransferDate"
        Me.DetailTable_TransferDate.DataType = GetType(Date)
        '
        'DetailLink
        '
        Me.DetailLink.DataSource = Me.DetailTable
        Me.DetailLink.Name = "DetailLink"
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "UPDATE KumasGirisDetay SET Deleted = KumasGirisDetayID  , ModifiedBy = @ModifiedB" & _
    "y , ModifiedDate = GETDATE()   WHERE KumasGirisDetayID = @KumasGirisDetayID"
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_KumasGirisDetayID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM KumasGirisDetay WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = resources.GetString("SqlCommand7.CommandText")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(630, 227)
        Me.XtraTabControl1.TabIndex = 20
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtIsEmriNo)
        Me.XtraTabPage1.Controls.Add(Me.cboIrsaliyeType)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage1.Controls.Add(Me.cmdGiris)
        Me.XtraTabPage1.Controls.Add(Me.txtTarih)
        Me.XtraTabPage1.Controls.Add(Me.lblIsEmriNo)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.lblCariUnvan)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.lblCariKod)
        Me.XtraTabPage1.Controls.Add(Me.txtIrsEvrakSeri)
        Me.XtraTabPage1.Controls.Add(Me.txtDepo2)
        Me.XtraTabPage1.Controls.Add(Me.txtIrsEvrakSira)
        Me.XtraTabPage1.Controls.Add(Me.txtDepo)
        Me.XtraTabPage1.Controls.Add(Me.txtCariUnvan)
        Me.XtraTabPage1.Controls.Add(Me.txtCariKodu)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(622, 199)
        Me.XtraTabPage1.Text = "Fiş Bilgi"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(281, 92)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Depo"
        '
        'txtIsEmriNo
        '
        Me.txtIsEmriNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IsEmriNo", True))
        Me.txtIsEmriNo.EnterMoveNextControl = True
        Me.txtIsEmriNo.Location = New System.Drawing.Point(54, 129)
        Me.txtIsEmriNo.Name = "txtIsEmriNo"
        Me.txtIsEmriNo.Size = New System.Drawing.Size(90, 20)
        Me.txtIsEmriNo.TabIndex = 24
        '
        'cboIrsaliyeType
        '
        Me.cboIrsaliyeType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "IrsaliyeType", True))
        Me.cboIrsaliyeType.EnterMoveNextControl = True
        Me.cboIrsaliyeType.Location = New System.Drawing.Point(54, 8)
        Me.cboIrsaliyeType.Name = "cboIrsaliyeType"
        Me.cboIrsaliyeType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboIrsaliyeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIrsaliyeType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueMember", "ValueMember", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboIrsaliyeType.Properties.DisplayMember = "DisplayMember"
        Me.cboIrsaliyeType.Properties.NullText = ""
        Me.cboIrsaliyeType.Properties.ShowHeader = False
        Me.cboIrsaliyeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboIrsaliyeType.Properties.ValueMember = "ValueMember"
        Me.cboIrsaliyeType.Size = New System.Drawing.Size(145, 20)
        Me.cboIrsaliyeType.TabIndex = 23
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(8, 11)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl15.TabIndex = 22
        Me.LabelControl15.Text = "Türü"
        '
        'cmdGiris
        '
        Me.cmdGiris.Location = New System.Drawing.Point(507, 142)
        Me.cmdGiris.Name = "cmdGiris"
        Me.cmdGiris.Size = New System.Drawing.Size(87, 31)
        Me.cmdGiris.TabIndex = 20
        Me.cmdGiris.Text = ">>>"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage2.Controls.Add(Me.cboYazici)
        Me.XtraTabPage2.Controls.Add(Me.chkAnlikBaski)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage2.Controls.Add(Me.txtMiktar)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage2.Controls.Add(Me.cmdSatirOk)
        Me.XtraTabPage2.Controls.Add(Me.txtLotNo)
        Me.XtraTabPage2.Controls.Add(Me.txtParti)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.txtStokIsmi)
        Me.XtraTabPage2.Controls.Add(Me.txtStokKodu)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(622, 199)
        Me.XtraTabPage2.Text = "Giriş"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(338, 175)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl14.TabIndex = 27
        Me.LabelControl14.Text = "Yazıcı"
        '
        'cboYazici
        '
        Me.cboYazici.Location = New System.Drawing.Point(381, 171)
        Me.cboYazici.Name = "cboYazici"
        Me.cboYazici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYazici.Size = New System.Drawing.Size(212, 20)
        Me.cboYazici.TabIndex = 26
        '
        'chkAnlikBaski
        '
        Me.chkAnlikBaski.Location = New System.Drawing.Point(207, 173)
        Me.chkAnlikBaski.Name = "chkAnlikBaski"
        Me.chkAnlikBaski.Properties.Caption = "Anında etiket bas"
        Me.chkAnlikBaski.Size = New System.Drawing.Size(125, 18)
        Me.chkAnlikBaski.TabIndex = 25
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailLink, "Field1", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(475, 26)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit4.TabIndex = 6
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(421, 28)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl13.TabIndex = 24
        Me.LabelControl13.Text = "Ek Ozellik1"
        '
        'txtMiktar
        '
        Me.txtMiktar.Location = New System.Drawing.Point(62, 127)
        Me.txtMiktar.Name = "txtMiktar"
        Me.txtMiktar.Size = New System.Drawing.Size(100, 20)
        Me.txtMiktar.TabIndex = 4
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(8, 129)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl12.TabIndex = 22
        Me.LabelControl12.Text = "Miktar"
        '
        'cmdSatirOk
        '
        Me.cmdSatirOk.Location = New System.Drawing.Point(62, 162)
        Me.cmdSatirOk.Name = "cmdSatirOk"
        Me.cmdSatirOk.Size = New System.Drawing.Size(109, 29)
        Me.cmdSatirOk.TabIndex = 5
        Me.cmdSatirOk.Text = "(+) Ekle"
        '
        'txtLotNo
        '
        Me.txtLotNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailLink, "LotNo", True))
        Me.txtLotNo.EnterMoveNextControl = True
        Me.txtLotNo.Location = New System.Drawing.Point(62, 101)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(100, 20)
        Me.txtLotNo.TabIndex = 3
        '
        'txtParti
        '
        Me.txtParti.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailLink, "Parti", True))
        Me.txtParti.EnterMoveNextControl = True
        Me.txtParti.Location = New System.Drawing.Point(62, 75)
        Me.txtParti.Name = "txtParti"
        Me.txtParti.Size = New System.Drawing.Size(100, 20)
        Me.txtParti.TabIndex = 2
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(8, 103)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Lot No"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(8, 75)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl10.TabIndex = 18
        Me.LabelControl10.Text = "Parti"
        '
        'txtStokIsmi
        '
        Me.txtStokIsmi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailLink, "StokIsmi", True))
        Me.txtStokIsmi.EnterMoveNextControl = True
        Me.txtStokIsmi.Location = New System.Drawing.Point(62, 30)
        Me.txtStokIsmi.Name = "txtStokIsmi"
        Me.txtStokIsmi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtStokIsmi.Size = New System.Drawing.Size(207, 20)
        Me.txtStokIsmi.TabIndex = 1
        '
        'txtStokKodu
        '
        Me.txtStokKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailLink, "StokKod", True))
        Me.txtStokKodu.EnterMoveNextControl = True
        Me.txtStokKodu.Location = New System.Drawing.Point(62, 6)
        Me.txtStokKodu.Name = "txtStokKodu"
        Me.txtStokKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtStokKodu.Size = New System.Drawing.Size(156, 20)
        Me.txtStokKodu.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(8, 33)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = "Stok Ismi"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(8, 9)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Stok Kodu"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DetailLink
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 277)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnPrintDetay})
        Me.GridControl1.Size = New System.Drawing.Size(630, 188)
        Me.GridControl1.TabIndex = 21
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKumasGirisDetayID, Me.colKumasGirisID, Me.colStokKod, Me.colStokIsmi, Me.colParti, Me.colLotNo, Me.colAciklama, Me.colMiktar, Me.colFiyat, Me.colTutar, Me.colBirim})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colKumasGirisDetayID
        '
        Me.colKumasGirisDetayID.Caption = "Yaz"
        Me.colKumasGirisDetayID.ColumnEdit = Me.btnPrintDetay
        Me.colKumasGirisDetayID.FieldName = "KumasGirisDetayID"
        Me.colKumasGirisDetayID.Name = "colKumasGirisDetayID"
        Me.colKumasGirisDetayID.Visible = True
        Me.colKumasGirisDetayID.VisibleIndex = 0
        Me.colKumasGirisDetayID.Width = 36
        '
        'btnPrintDetay
        '
        Me.btnPrintDetay.AutoHeight = False
        Me.btnPrintDetay.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.ProbarSiparis.My.Resources.Resources.print_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnPrintDetay.Name = "btnPrintDetay"
        Me.btnPrintDetay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colKumasGirisID
        '
        Me.colKumasGirisID.FieldName = "KumasGirisID"
        Me.colKumasGirisID.Name = "colKumasGirisID"
        Me.colKumasGirisID.OptionsColumn.AllowEdit = False
        '
        'colStokKod
        '
        Me.colStokKod.FieldName = "StokKod"
        Me.colStokKod.Name = "colStokKod"
        Me.colStokKod.OptionsColumn.AllowEdit = False
        Me.colStokKod.Visible = True
        Me.colStokKod.VisibleIndex = 1
        Me.colStokKod.Width = 112
        '
        'colStokIsmi
        '
        Me.colStokIsmi.FieldName = "StokIsmi"
        Me.colStokIsmi.Name = "colStokIsmi"
        Me.colStokIsmi.OptionsColumn.AllowEdit = False
        Me.colStokIsmi.Visible = True
        Me.colStokIsmi.VisibleIndex = 2
        Me.colStokIsmi.Width = 152
        '
        'colParti
        '
        Me.colParti.FieldName = "Parti"
        Me.colParti.Name = "colParti"
        Me.colParti.OptionsColumn.AllowEdit = False
        Me.colParti.Visible = True
        Me.colParti.VisibleIndex = 5
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 6
        '
        'colAciklama
        '
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.OptionsColumn.AllowEdit = False
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 7
        Me.colAciklama.Width = 124
        '
        'colMiktar
        '
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.OptionsColumn.AllowEdit = False
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 3
        '
        'colFiyat
        '
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.OptionsColumn.AllowEdit = False
        '
        'colTutar
        '
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.OptionsColumn.AllowEdit = False
        '
        'colBirim
        '
        Me.colBirim.FieldName = "Birim"
        Me.colBirim.Name = "colBirim"
        Me.colBirim.Visible = True
        Me.colBirim.VisibleIndex = 4
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdTopluYazdir)
        Me.PanelControl1.Controls.Add(Me.cmdCancel)
        Me.PanelControl1.Controls.Add(Me.cmdSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(630, 50)
        Me.PanelControl1.TabIndex = 22
        '
        'cmdTopluYazdir
        '
        Me.cmdTopluYazdir.Image = Global.ProbarSiparis.My.Resources.Resources.PrintDirectLarge
        Me.cmdTopluYazdir.Location = New System.Drawing.Point(331, 5)
        Me.cmdTopluYazdir.Name = "cmdTopluYazdir"
        Me.cmdTopluYazdir.Size = New System.Drawing.Size(127, 39)
        Me.cmdTopluYazdir.TabIndex = 2
        Me.cmdTopluYazdir.Text = "Toplu Yazdir"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.ProbarSiparis.My.Resources.Resources.undo_32x32
        Me.cmdCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdCancel.Location = New System.Drawing.Point(87, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(74, 43)
        Me.cmdCancel.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ProbarSiparis.My.Resources.Resources.save_32x32
        Me.cmdSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdSave.Location = New System.Drawing.Point(7, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(74, 43)
        Me.cmdSave.TabIndex = 0
        '
        'tmrMiktarFocus
        '
        Me.tmrMiktarFocus.Interval = 400
        '
        'frmIrsaliye_Giris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 465)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmIrsaliye_Giris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Irsaliye Giriş"
        CType(Me.txtTarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIrsEvrakSeri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIrsEvrakSira.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCariKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCariUnvan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtIsEmriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIrsaliyeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cboYazici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAnlikBaski.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMiktar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLotNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokIsmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrintDetay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTarih As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIrsEvrakSeri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIrsEvrakSira As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepo2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDepo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCariKodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCariUnvan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblCariKod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCariUnvan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIsEmriNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FirmConn As NeoDAC.NeoConnection
    Friend WithEvents MasterTable As NeoDAC.NeoTable
    Friend WithEvents MasterLink As NeoDAC.NeoLink
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DetailTable As NeoDAC.NeoTable
    Friend WithEvents DetailLink As NeoDAC.NeoLink
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKumasGirisDetayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKumasGirisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokIsmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGiris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLotNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtParti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStokIsmi As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtStokKodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSatirOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMiktar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmrMiktarFocus As System.Windows.Forms.Timer
    Friend WithEvents cmdTopluYazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkAnlikBaski As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYazici As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnPrintDetay As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIrsaliyeType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DetailTable_KumasGirisDetayID As System.Data.DataColumn
    Friend WithEvents DetailTable_Deleted As System.Data.DataColumn
    Friend WithEvents DetailTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents DetailTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents DetailTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents DetailTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents DetailTable_KumasGirisID As System.Data.DataColumn
    Friend WithEvents DetailTable_StokKod As System.Data.DataColumn
    Friend WithEvents DetailTable_StokIsmi As System.Data.DataColumn
    Friend WithEvents DetailTable_Aciklama As System.Data.DataColumn
    Friend WithEvents DetailTable_Miktar As System.Data.DataColumn
    Friend WithEvents DetailTable_Birim As System.Data.DataColumn
    Friend WithEvents DetailTable_Fiyat As System.Data.DataColumn
    Friend WithEvents DetailTable_Tutar As System.Data.DataColumn
    Friend WithEvents DetailTable_Parti As System.Data.DataColumn
    Friend WithEvents DetailTable_LotNo As System.Data.DataColumn
    Friend WithEvents DetailTable_Field1 As System.Data.DataColumn
    Friend WithEvents DetailTable_Field2 As System.Data.DataColumn
    Friend WithEvents DetailTable_Field3 As System.Data.DataColumn
    Friend WithEvents DetailTable_Field4 As System.Data.DataColumn
    Friend WithEvents DetailTable_Field5 As System.Data.DataColumn
    Friend WithEvents DetailTable_IntCode As System.Data.DataColumn
    Friend WithEvents DetailTable_Transferred As System.Data.DataColumn
    Friend WithEvents DetailTable_TransferDate As System.Data.DataColumn
    Friend WithEvents MasterTable_KumasGirisID As System.Data.DataColumn
    Friend WithEvents MasterTable_Deleted As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_CreatedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedBy As System.Data.DataColumn
    Friend WithEvents MasterTable_ModifiedDate As System.Data.DataColumn
    Friend WithEvents MasterTable_IrsaliyeType As System.Data.DataColumn
    Friend WithEvents MasterTable_IrsTarih As System.Data.DataColumn
    Friend WithEvents MasterTable_IrsEvrakSeri As System.Data.DataColumn
    Friend WithEvents MasterTable_IrsEvrakSira As System.Data.DataColumn
    Friend WithEvents MasterTable_IrsaliyeNo As System.Data.DataColumn
    Friend WithEvents MasterTable_BelgeNo As System.Data.DataColumn
    Friend WithEvents MasterTable_IsEmriNo As System.Data.DataColumn
    Friend WithEvents MasterTable_CariKod As System.Data.DataColumn
    Friend WithEvents MasterTable_CariUnvan As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama1 As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama2 As System.Data.DataColumn
    Friend WithEvents MasterTable_Aciklama3 As System.Data.DataColumn
    Friend WithEvents MasterTable_Depo As System.Data.DataColumn
    Friend WithEvents MasterTable_Depo2 As System.Data.DataColumn
    Friend WithEvents MasterTable_AraToplam As System.Data.DataColumn
    Friend WithEvents MasterTable_KdvOran As System.Data.DataColumn
    Friend WithEvents MasterTable_KdvTutar As System.Data.DataColumn
    Friend WithEvents MasterTable_GenelToplam As System.Data.DataColumn
    Friend WithEvents MasterTable_DovizTipi As System.Data.DataColumn
    Friend WithEvents MasterTable_DovizKuru As System.Data.DataColumn
    Friend WithEvents MasterTable_IntCode As System.Data.DataColumn
    Friend WithEvents MasterTable_Transferred As System.Data.DataColumn
    Friend WithEvents MasterTable_TransferDate As System.Data.DataColumn
    Friend WithEvents MasterTable_Pasif As System.Data.DataColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIsEmriNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colBirim As DevExpress.XtraGrid.Columns.GridColumn
End Class
