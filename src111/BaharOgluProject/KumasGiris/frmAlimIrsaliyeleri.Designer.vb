<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlimIrsaliyeleri
    Inherits ProbarSiparis.frmBaseReport

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
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
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
        Me.colKumasGirisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIrsaliyeType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboGridIrsaliyeType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colIrsTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIrsEvrakSeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIrsEvrakSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIrsaliyeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBelgeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCariUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAraToplam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenelToplam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferred = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colTransferDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPasif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdAddNewIrsaliye = New DevExpress.XtraEditors.SimpleButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuYeniIrsaliye = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIrsaliyeDuzelt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIrsaliyeSil = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuYeniDevirFisi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMikroyaGonder = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdYeniDevirIrsaliyesi = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdYeniUretimIade = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormTop.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.BaseTab1.SuspendLayout()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormDateFilter.SuspendLayout()

        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGridIrsaliyeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.MasterTable
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGridIrsaliyeType, Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(746, 327)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKumasGirisID, Me.colIrsaliyeType, Me.colIrsTarih, Me.colIrsEvrakSeri, Me.colIrsEvrakSira, Me.colIrsaliyeNo, Me.colBelgeNo, Me.colCariKod, Me.colCariUnvan, Me.colAciklama1, Me.colAciklama2, Me.colAciklama3, Me.colDepo, Me.colDepo2, Me.colAraToplam, Me.colKdvOran, Me.colKdvTutar, Me.colGenelToplam, Me.colDovizTipi, Me.colDovizKuru, Me.colIntCode, Me.colTransferred, Me.colTransferDate, Me.colPasif})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(840, 408, 216, 227)
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'Bar2
        '
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        '
        'panelFormTop
        '
        Me.panelFormTop.Controls.Add(Me.cmdYeniUretimIade)
        Me.panelFormTop.Controls.Add(Me.cmdYeniDevirIrsaliyesi)
        Me.panelFormTop.Controls.Add(Me.cmdAddNewIrsaliye)
        Me.panelFormTop.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.panelFormTop.Size = New System.Drawing.Size(752, 64)
        Me.panelFormTop.Visible = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 216)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(752, 358)
        '
        'BaseTab1
        '
        Me.BaseTab1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BaseTab1.Size = New System.Drawing.Size(746, 327)
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Data Source=.\SqlExpress;Initial Catalog=ProbarSiparisDB;Integrated Security=True" & _
    ";"
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KumasGirisID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_IrsaliyeType, Me.MasterTable_IrsTarih, Me.MasterTable_IrsEvrakSeri, Me.MasterTable_IrsEvrakSira, Me.MasterTable_IrsaliyeNo, Me.MasterTable_BelgeNo, Me.MasterTable_CariKod, Me.MasterTable_CariUnvan, Me.MasterTable_Aciklama1, Me.MasterTable_Aciklama2, Me.MasterTable_Aciklama3, Me.MasterTable_Depo, Me.MasterTable_Depo2, Me.MasterTable_AraToplam, Me.MasterTable_KdvOran, Me.MasterTable_KdvTutar, Me.MasterTable_GenelToplam, Me.MasterTable_DovizTipi, Me.MasterTable_DovizKuru, Me.MasterTable_IntCode, Me.MasterTable_Transferred, Me.MasterTable_TransferDate, Me.MasterTable_Pasif})
        Me.MasterTable.Connection = Me.FirmConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KumasGirisID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KumasGirisID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Visible = True
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
        Me.SqlCommand1.CommandText = "SELECT * FROM KumasGiris WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND IrsTarih BETWEEN @FormDate1 AND " & _
    "@FormDate2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime), New System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime)})
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
        'colKumasGirisID
        '
        Me.colKumasGirisID.FieldName = "KumasGirisID"
        Me.colKumasGirisID.Name = "colKumasGirisID"
        '
        'colIrsaliyeType
        '
        Me.colIrsaliyeType.Caption = "Türü"
        Me.colIrsaliyeType.ColumnEdit = Me.cboGridIrsaliyeType
        Me.colIrsaliyeType.FieldName = "IrsaliyeType"
        Me.colIrsaliyeType.Name = "colIrsaliyeType"
        Me.colIrsaliyeType.Visible = True
        Me.colIrsaliyeType.VisibleIndex = 1
        Me.colIrsaliyeType.Width = 107
        '
        'cboGridIrsaliyeType
        '
        Me.cboGridIrsaliyeType.AutoHeight = False
        Me.cboGridIrsaliyeType.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cboGridIrsaliyeType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridIrsaliyeType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueMember", "ValueMember", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboGridIrsaliyeType.DisplayMember = "DisplayMember"
        Me.cboGridIrsaliyeType.Name = "cboGridIrsaliyeType"
        Me.cboGridIrsaliyeType.NullText = ""
        Me.cboGridIrsaliyeType.ShowHeader = False
        Me.cboGridIrsaliyeType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboGridIrsaliyeType.ValueMember = "ValueMember"
        '
        'colIrsTarih
        '
        Me.colIrsTarih.FieldName = "IrsTarih"
        Me.colIrsTarih.Name = "colIrsTarih"
        Me.colIrsTarih.Visible = True
        Me.colIrsTarih.VisibleIndex = 2
        '
        'colIrsEvrakSeri
        '
        Me.colIrsEvrakSeri.FieldName = "IrsEvrakSeri"
        Me.colIrsEvrakSeri.Name = "colIrsEvrakSeri"
        Me.colIrsEvrakSeri.Visible = True
        Me.colIrsEvrakSeri.VisibleIndex = 3
        '
        'colIrsEvrakSira
        '
        Me.colIrsEvrakSira.FieldName = "IrsEvrakSira"
        Me.colIrsEvrakSira.Name = "colIrsEvrakSira"
        Me.colIrsEvrakSira.Visible = True
        Me.colIrsEvrakSira.VisibleIndex = 4
        '
        'colIrsaliyeNo
        '
        Me.colIrsaliyeNo.FieldName = "IrsaliyeNo"
        Me.colIrsaliyeNo.Name = "colIrsaliyeNo"
        Me.colIrsaliyeNo.Visible = True
        Me.colIrsaliyeNo.VisibleIndex = 5
        '
        'colBelgeNo
        '
        Me.colBelgeNo.FieldName = "BelgeNo"
        Me.colBelgeNo.Name = "colBelgeNo"
        Me.colBelgeNo.Visible = True
        Me.colBelgeNo.VisibleIndex = 6
        '
        'colCariKod
        '
        Me.colCariKod.FieldName = "CariKod"
        Me.colCariKod.Name = "colCariKod"
        Me.colCariKod.Visible = True
        Me.colCariKod.VisibleIndex = 7
        '
        'colCariUnvan
        '
        Me.colCariUnvan.FieldName = "CariUnvan"
        Me.colCariUnvan.Name = "colCariUnvan"
        Me.colCariUnvan.Visible = True
        Me.colCariUnvan.VisibleIndex = 8
        '
        'colAciklama1
        '
        Me.colAciklama1.FieldName = "Aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Visible = True
        Me.colAciklama1.VisibleIndex = 9
        '
        'colAciklama2
        '
        Me.colAciklama2.FieldName = "Aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Visible = True
        Me.colAciklama2.VisibleIndex = 10
        '
        'colAciklama3
        '
        Me.colAciklama3.FieldName = "Aciklama3"
        Me.colAciklama3.Name = "colAciklama3"
        Me.colAciklama3.Visible = True
        Me.colAciklama3.VisibleIndex = 11
        '
        'colDepo
        '
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 12
        '
        'colDepo2
        '
        Me.colDepo2.FieldName = "Depo2"
        Me.colDepo2.Name = "colDepo2"
        Me.colDepo2.Visible = True
        Me.colDepo2.VisibleIndex = 13
        '
        'colAraToplam
        '
        Me.colAraToplam.FieldName = "AraToplam"
        Me.colAraToplam.Name = "colAraToplam"
        Me.colAraToplam.Visible = True
        Me.colAraToplam.VisibleIndex = 14
        '
        'colKdvOran
        '
        Me.colKdvOran.FieldName = "KdvOran"
        Me.colKdvOran.Name = "colKdvOran"
        Me.colKdvOran.Visible = True
        Me.colKdvOran.VisibleIndex = 15
        '
        'colKdvTutar
        '
        Me.colKdvTutar.FieldName = "KdvTutar"
        Me.colKdvTutar.Name = "colKdvTutar"
        Me.colKdvTutar.Visible = True
        Me.colKdvTutar.VisibleIndex = 16
        '
        'colGenelToplam
        '
        Me.colGenelToplam.FieldName = "GenelToplam"
        Me.colGenelToplam.Name = "colGenelToplam"
        Me.colGenelToplam.Visible = True
        Me.colGenelToplam.VisibleIndex = 17
        '
        'colDovizTipi
        '
        Me.colDovizTipi.FieldName = "DovizTipi"
        Me.colDovizTipi.Name = "colDovizTipi"
        Me.colDovizTipi.Visible = True
        Me.colDovizTipi.VisibleIndex = 18
        '
        'colDovizKuru
        '
        Me.colDovizKuru.FieldName = "DovizKuru"
        Me.colDovizKuru.Name = "colDovizKuru"
        Me.colDovizKuru.Visible = True
        Me.colDovizKuru.VisibleIndex = 19
        '
        'colIntCode
        '
        Me.colIntCode.FieldName = "IntCode"
        Me.colIntCode.Name = "colIntCode"
        Me.colIntCode.Visible = True
        Me.colIntCode.VisibleIndex = 20
        '
        'colTransferred
        '
        Me.colTransferred.Caption = "Aktarıldı?"
        Me.colTransferred.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colTransferred.FieldName = "Transferred"
        Me.colTransferred.Name = "colTransferred"
        Me.colTransferred.Visible = True
        Me.colTransferred.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'colTransferDate
        '
        Me.colTransferDate.FieldName = "TransferDate"
        Me.colTransferDate.Name = "colTransferDate"
        '
        'colPasif
        '
        Me.colPasif.FieldName = "Pasif"
        Me.colPasif.Name = "colPasif"
        '
        'cmdAddNewIrsaliye
        '
        Me.cmdAddNewIrsaliye.Location = New System.Drawing.Point(14, 9)
        Me.cmdAddNewIrsaliye.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAddNewIrsaliye.Name = "cmdAddNewIrsaliye"
        Me.cmdAddNewIrsaliye.Size = New System.Drawing.Size(181, 48)
        Me.cmdAddNewIrsaliye.TabIndex = 0
        Me.cmdAddNewIrsaliye.Text = "(+) Yeni Alım Irsaliyesi"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuYeniIrsaliye, Me.mnuIrsaliyeDuzelt, Me.mnuIrsaliyeSil, Me.ToolStripMenuItem1, Me.mnuYeniDevirFisi, Me.ToolStripMenuItem2, Me.mnuMikroyaGonder})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(288, 164)
        '
        'mnuYeniIrsaliye
        '
        Me.mnuYeniIrsaliye.Name = "mnuYeniIrsaliye"
        Me.mnuYeniIrsaliye.Size = New System.Drawing.Size(287, 24)
        Me.mnuYeniIrsaliye.Text = "Yeni Irsaliye"
        '
        'mnuIrsaliyeDuzelt
        '
        Me.mnuIrsaliyeDuzelt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuIrsaliyeDuzelt.Name = "mnuIrsaliyeDuzelt"
        Me.mnuIrsaliyeDuzelt.Size = New System.Drawing.Size(287, 24)
        Me.mnuIrsaliyeDuzelt.Text = "Düzelt"
        '
        'mnuIrsaliyeSil
        '
        Me.mnuIrsaliyeSil.Name = "mnuIrsaliyeSil"
        Me.mnuIrsaliyeSil.Size = New System.Drawing.Size(287, 24)
        Me.mnuIrsaliyeSil.Text = "Sil"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(284, 6)
        '
        'mnuYeniDevirFisi
        '
        Me.mnuYeniDevirFisi.Name = "mnuYeniDevirFisi"
        Me.mnuYeniDevirFisi.Size = New System.Drawing.Size(287, 24)
        Me.mnuYeniDevirFisi.Text = "Yeni Devir"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(284, 6)
        '
        'mnuMikroyaGonder
        '
        Me.mnuMikroyaGonder.Name = "mnuMikroyaGonder"
        Me.mnuMikroyaGonder.Size = New System.Drawing.Size(287, 24)
        Me.mnuMikroyaGonder.Text = "Mikroya Transfer (Seçili olanlar)"
        '
        'cmdYeniDevirIrsaliyesi
        '
        Me.cmdYeniDevirIrsaliyesi.Location = New System.Drawing.Point(468, 9)
        Me.cmdYeniDevirIrsaliyesi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdYeniDevirIrsaliyesi.Name = "cmdYeniDevirIrsaliyesi"
        Me.cmdYeniDevirIrsaliyesi.Size = New System.Drawing.Size(110, 48)
        Me.cmdYeniDevirIrsaliyesi.TabIndex = 1
        Me.cmdYeniDevirIrsaliyesi.Text = "(+) Yeni Devir"
        '
        'cmdYeniUretimIade
        '
        Me.cmdYeniUretimIade.Location = New System.Drawing.Point(241, 9)
        Me.cmdYeniUretimIade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdYeniUretimIade.Name = "cmdYeniUretimIade"
        Me.cmdYeniUretimIade.Size = New System.Drawing.Size(150, 48)
        Me.cmdYeniUretimIade.TabIndex = 2
        Me.cmdYeniUretimIade.Text = "Üretimden İade Geliş"
        '
        'frmAlimIrsaliyeleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(752, 658)
        Me.FormCode = "000022"
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmAlimIrsaliyeleri"
        Me.Text = "İrsaliyeler"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.panelBottom, 0)
        Me.Controls.SetChildIndex(Me.panelFormDateFilter, 0)
        Me.Controls.SetChildIndex(Me.panelFormTop, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormTop.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.BaseTab1.ResumeLayout(False)
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormDateFilter.ResumeLayout(False)
        
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGridIrsaliyeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colKumasGirisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIrsaliyeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIrsTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIrsEvrakSeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIrsEvrakSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIrsaliyeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBelgeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCariUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAraToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenelToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPasif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAddNewIrsaliye As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuYeniIrsaliye As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIrsaliyeDuzelt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIrsaliyeSil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuMikroyaGonder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboGridIrsaliyeType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents mnuYeniDevirFisi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdYeniDevirIrsaliyesi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdYeniUretimIade As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

End Class
