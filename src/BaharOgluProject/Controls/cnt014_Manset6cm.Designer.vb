﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cnt014_Manset6cm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnt014_Manset6cm))
        Me.NeoTable1 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable1_nID = New System.Data.DataColumn()
        Me.NeoTable1_Deleted = New System.Data.DataColumn()
        Me.NeoTable1_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable1_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable1_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable1_Iplik = New System.Data.DataColumn()
        Me.NeoTable1_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable1_GramajArtis = New System.Data.DataColumn()
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
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.NeoTable3 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable3_nID = New System.Data.DataColumn()
        Me.NeoTable3_Deleted = New System.Data.DataColumn()
        Me.NeoTable3_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable3_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable3_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable3_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable3_Manset6cmID = New System.Data.DataColumn()
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
        Me.NeoTable2_bGarni1 = New System.Data.DataColumn()
        Me.NeoTable2_Garni1_RenkID = New System.Data.DataColumn()
        Me.NeoTable2_Garni1_CizgiRKafaLakosID = New System.Data.DataColumn()
        Me.NeoTable2_Garni1_CizgiSayisi = New System.Data.DataColumn()
        Me.NeoTable2_bGarni2 = New System.Data.DataColumn()
        Me.NeoTable2_Garni2_RenkID = New System.Data.DataColumn()
        Me.NeoTable2_Garni2_CizgiRKafaLakosID = New System.Data.DataColumn()
        Me.NeoTable2_Garni2_CizgiSayisi = New System.Data.DataColumn()
        Me.NeoTable2_Iplik = New System.Data.DataColumn()
        Me.NeoTable2_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable2_GramajArtis = New System.Data.DataColumn()
        Me.NeoTable2_Garni1_Iplik = New System.Data.DataColumn()
        Me.NeoTable2_Garni1_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable2_Garni1_GramajArtis = New System.Data.DataColumn()
        Me.NeoTable2_Garni2_Iplik = New System.Data.DataColumn()
        Me.NeoTable2_Garni2_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable2_Garni2_GramajArtis = New System.Data.DataColumn()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit8 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.chkGarni2 = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGarni1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.tbGarni1Cizgiler = New NeoDAC.NeoTable(Me.components)
        Me.tbGarni1Cizgiler_nID = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_Deleted = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_CreatedBy = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_CreatedDate = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_ModifiedBy = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_ModifiedDate = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_Manset6cmID = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_CizgiNo = New System.Data.DataColumn()
        Me.tbGarni1Cizgiler_RenkID = New System.Data.DataColumn()
        Me.SqlCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand30 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand29 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand31 = New System.Data.SqlClient.SqlCommand()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit9 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit5 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.tbGarni2Cizgiler = New NeoDAC.NeoTable(Me.components)
        Me.tbGarni2Cizgiler_nID = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_Deleted = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_CreatedBy = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_CreatedDate = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_ModifiedBy = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_ModifiedDate = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_Manset6cmID = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_CizgiNo = New System.Data.DataColumn()
        Me.tbGarni2Cizgiler_RenkID = New System.Data.DataColumn()
        Me.SqlCommand36 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand34 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand33 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand35 = New System.Data.SqlClient.SqlCommand()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit10 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit6 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit7 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.tbCizgiRenkKafaLakos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTurArtis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGarni2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGarni1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGarni1Cizgiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGarni2Cizgiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.Location = New System.Drawing.Point(2, 2)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCaption.Size = New System.Drawing.Size(183, 22)
        Me.lblCaption.Text = "6cm Manşet"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(284, 188)
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        Me.XtraTabControl1.Controls.SetChildIndex(Me.XtraTabPage4, 0)
        Me.XtraTabControl1.Controls.SetChildIndex(Me.XtraTabPage3, 0)
        Me.XtraTabControl1.Controls.SetChildIndex(Me.XtraTabPage2, 0)
        Me.XtraTabControl1.Controls.SetChildIndex(Me.XtraTabPage1, 0)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtTur)
        Me.XtraTabPage1.Controls.Add(Me.txtTurArtis)
        Me.XtraTabPage1.Controls.Add(Me.LookUpEdit1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage1.Size = New System.Drawing.Size(278, 160)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage2.Size = New System.Drawing.Size(278, 160)
        Me.XtraTabPage2.Text = "Manset"
        '
        'panelCaption
        '
        Me.panelCaption.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.panelCaption.Size = New System.Drawing.Size(284, 26)
        '
        'chkSecmeli
        '
        Me.chkSecmeli.Location = New System.Drawing.Point(224, 2)
        Me.chkSecmeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'chkVar
        '
        Me.chkVar.Location = New System.Drawing.Point(185, 2)
        Me.chkVar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'NeoTable1
        '
        Me.NeoTable1.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable1_nID, Me.NeoTable1_Deleted, Me.NeoTable1_CreatedBy, Me.NeoTable1_CreatedDate, Me.NeoTable1_ModifiedBy, Me.NeoTable1_ModifiedDate, Me.NeoTable1_KategoriParamID, Me.NeoTable1_Iplik, Me.NeoTable1_IpGramaj, Me.NeoTable1_GramajArtis})
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
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KategoriParam_014_Manset6cm SET Deleted = nID  , ModifiedBy = @ModifiedBy " &
    ", ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         KategoriParam_014_Manset6cm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.NeoTable3
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 87)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(278, 73)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'NeoTable3
        '
        Me.NeoTable3.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable3_nID, Me.NeoTable3_Deleted, Me.NeoTable3_CreatedBy, Me.NeoTable3_CreatedDate, Me.NeoTable3_ModifiedBy, Me.NeoTable3_ModifiedDate, Me.NeoTable3_Manset6cmID, Me.NeoTable3_CizgiNo, Me.NeoTable3_RenkID})
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
        'NeoTable3_Manset6cmID
        '
        Me.NeoTable3_Manset6cmID.ColumnName = "Manset6cmID"
        Me.NeoTable3_Manset6cmID.DataType = GetType(Integer)
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
        Me.SqlCommand28.CommandText = "UPDATE SipDetayParam_014_Manset6cm_Cizgiler SET Deleted = nID  , ModifiedBy = @Mo" &
    "difiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand26
        '
        Me.SqlCommand26.CommandText = resources.GetString("SqlCommand26.CommandText")
        Me.SqlCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT * FROM SipDetayParam_014_Manset6cm_Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.colRenkID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colRenkID.FieldName = "RenkID"
        Me.colRenkID.Name = "colRenkID"
        Me.colRenkID.Visible = True
        Me.colRenkID.VisibleIndex = 1
        Me.colRenkID.Width = 131
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
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Aciklama", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RKafa", "RKafa", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "Cizgi Sayisi", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.tbCizgiRenkKafaLakos
        Me.RepositoryItemLookUpEdit2.DisplayMember = "RKafa"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "RKafa"
        '
        'NeoTable2
        '
        Me.NeoTable2.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable2_nID, Me.NeoTable2_Deleted, Me.NeoTable2_CreatedBy, Me.NeoTable2_CreatedDate, Me.NeoTable2_ModifiedBy, Me.NeoTable2_ModifiedDate, Me.NeoTable2_SipDetayParamID, Me.NeoTable2_SourceID, Me.NeoTable2_KategoriParamID, Me.NeoTable2_RenkID, Me.NeoTable2_CizgiRKafaLakosID, Me.NeoTable2_CizgiSayisi, Me.NeoTable2_bGarni1, Me.NeoTable2_Garni1_RenkID, Me.NeoTable2_Garni1_CizgiRKafaLakosID, Me.NeoTable2_Garni1_CizgiSayisi, Me.NeoTable2_bGarni2, Me.NeoTable2_Garni2_RenkID, Me.NeoTable2_Garni2_CizgiRKafaLakosID, Me.NeoTable2_Garni2_CizgiSayisi, Me.NeoTable2_Iplik, Me.NeoTable2_IpGramaj, Me.NeoTable2_GramajArtis, Me.NeoTable2_Garni1_Iplik, Me.NeoTable2_Garni1_IpGramaj, Me.NeoTable2_Garni1_GramajArtis, Me.NeoTable2_Garni2_Iplik, Me.NeoTable2_Garni2_IpGramaj, Me.NeoTable2_Garni2_GramajArtis})
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
        'NeoTable2_bGarni1
        '
        Me.NeoTable2_bGarni1.ColumnName = "bGarni1"
        Me.NeoTable2_bGarni1.DataType = GetType(Integer)
        '
        'NeoTable2_Garni1_RenkID
        '
        Me.NeoTable2_Garni1_RenkID.ColumnName = "Garni1_RenkID"
        Me.NeoTable2_Garni1_RenkID.DataType = GetType(Integer)
        '
        'NeoTable2_Garni1_CizgiRKafaLakosID
        '
        Me.NeoTable2_Garni1_CizgiRKafaLakosID.ColumnName = "Garni1_CizgiRKafaLakosID"
        Me.NeoTable2_Garni1_CizgiRKafaLakosID.DataType = GetType(Integer)
        '
        'NeoTable2_Garni1_CizgiSayisi
        '
        Me.NeoTable2_Garni1_CizgiSayisi.ColumnName = "Garni1_CizgiSayisi"
        Me.NeoTable2_Garni1_CizgiSayisi.DataType = GetType(Integer)
        '
        'NeoTable2_bGarni2
        '
        Me.NeoTable2_bGarni2.ColumnName = "bGarni2"
        Me.NeoTable2_bGarni2.DataType = GetType(Integer)
        '
        'NeoTable2_Garni2_RenkID
        '
        Me.NeoTable2_Garni2_RenkID.ColumnName = "Garni2_RenkID"
        Me.NeoTable2_Garni2_RenkID.DataType = GetType(Integer)
        '
        'NeoTable2_Garni2_CizgiRKafaLakosID
        '
        Me.NeoTable2_Garni2_CizgiRKafaLakosID.ColumnName = "Garni2_CizgiRKafaLakosID"
        Me.NeoTable2_Garni2_CizgiRKafaLakosID.DataType = GetType(Integer)
        '
        'NeoTable2_Garni2_CizgiSayisi
        '
        Me.NeoTable2_Garni2_CizgiSayisi.ColumnName = "Garni2_CizgiSayisi"
        Me.NeoTable2_Garni2_CizgiSayisi.DataType = GetType(Integer)
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
        'NeoTable2_GramajArtis
        '
        Me.NeoTable2_GramajArtis.ColumnName = "GramajArtis"
        Me.NeoTable2_GramajArtis.DataType = GetType(Double)
        '
        'NeoTable2_Garni1_Iplik
        '
        Me.NeoTable2_Garni1_Iplik.ColumnName = "Garni1_Iplik"
        Me.NeoTable2_Garni1_Iplik.DataType = GetType(Integer)
        '
        'NeoTable2_Garni1_IpGramaj
        '
        Me.NeoTable2_Garni1_IpGramaj.ColumnName = "Garni1_IpGramaj"
        Me.NeoTable2_Garni1_IpGramaj.DataType = GetType(Double)
        '
        'NeoTable2_Garni1_GramajArtis
        '
        Me.NeoTable2_Garni1_GramajArtis.ColumnName = "Garni1_GramajArtis"
        Me.NeoTable2_Garni1_GramajArtis.DataType = GetType(Double)
        '
        'NeoTable2_Garni2_Iplik
        '
        Me.NeoTable2_Garni2_Iplik.ColumnName = "Garni2_Iplik"
        Me.NeoTable2_Garni2_Iplik.DataType = GetType(Integer)
        '
        'NeoTable2_Garni2_IpGramaj
        '
        Me.NeoTable2_Garni2_IpGramaj.ColumnName = "Garni2_IpGramaj"
        Me.NeoTable2_Garni2_IpGramaj.DataType = GetType(Double)
        '
        'NeoTable2_Garni2_GramajArtis
        '
        Me.NeoTable2_Garni2_GramajArtis.ColumnName = "Garni2_GramajArtis"
        Me.NeoTable2_Garni2_GramajArtis.DataType = GetType(Double)
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = "UPDATE SipDetayParam_014_Manset6cm SET Deleted = nID  , ModifiedBy = @ModifiedBy " &
    ", ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = resources.GetString("SqlCommand18.CommandText")
        Me.SqlCommand18.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_014_Manset6cm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = resources.GetString("SqlCommand19.CommandText")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.TextEdit1)
        Me.PanelControl2.Controls.Add(Me.TextEdit3)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit8)
        Me.PanelControl2.Controls.Add(Me.LabelControl12)
        Me.PanelControl2.Controls.Add(Me.LabelControl13)
        Me.PanelControl2.Controls.Add(Me.chkGarni2)
        Me.PanelControl2.Controls.Add(Me.chkGarni1)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit3)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit2)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(278, 87)
        Me.PanelControl2.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(37, 47)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl11.TabIndex = 13
        Me.LabelControl11.Text = "Tur"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "IpGramaj", True))
        Me.TextEdit1.Location = New System.Drawing.Point(160, 61)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit1.TabIndex = 9
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "GramajArtis", True))
        Me.TextEdit3.Location = New System.Drawing.Point(218, 61)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit3.TabIndex = 12
        '
        'LookUpEdit8
        '
        Me.LookUpEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Iplik", True))
        Me.LookUpEdit8.Location = New System.Drawing.Point(37, 61)
        Me.LookUpEdit8.Name = "LookUpEdit8"
        Me.LookUpEdit8.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit8.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit8.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit8.Properties.DataSource = Me.tbIplik
        Me.LookUpEdit8.Properties.DisplayMember = "IplikKod"
        Me.LookUpEdit8.Properties.NullText = ""
        Me.LookUpEdit8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit8.Properties.ValueMember = "IplikID"
        Me.LookUpEdit8.Size = New System.Drawing.Size(118, 20)
        Me.LookUpEdit8.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(160, 47)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "İp Grm."
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(228, 47)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl13.TabIndex = 11
        Me.LabelControl13.Text = "Artış"
        '
        'chkGarni2
        '
        Me.chkGarni2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "bGarni2", True))
        Me.chkGarni2.Location = New System.Drawing.Point(205, 28)
        Me.chkGarni2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkGarni2.Name = "chkGarni2"
        Me.chkGarni2.Properties.Appearance.Options.UseTextOptions = True
        Me.chkGarni2.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkGarni2.Properties.AutoWidth = True
        Me.chkGarni2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.chkGarni2.Properties.Caption = "Garni2"
        Me.chkGarni2.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkGarni2.Properties.ValueChecked = 1
        Me.chkGarni2.Properties.ValueUnchecked = 0
        Me.chkGarni2.Size = New System.Drawing.Size(55, 21)
        Me.chkGarni2.TabIndex = 6
        '
        'chkGarni1
        '
        Me.chkGarni1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "bGarni1", True))
        Me.chkGarni1.Location = New System.Drawing.Point(205, 6)
        Me.chkGarni1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkGarni1.Name = "chkGarni1"
        Me.chkGarni1.Properties.Appearance.Options.UseTextOptions = True
        Me.chkGarni1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkGarni1.Properties.AutoWidth = True
        Me.chkGarni1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.chkGarni1.Properties.Caption = "Garni1"
        Me.chkGarni1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkGarni1.Properties.ValueChecked = 1
        Me.chkGarni1.Properties.ValueUnchecked = 0
        Me.chkGarni1.Size = New System.Drawing.Size(55, 21)
        Me.chkGarni1.TabIndex = 5
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "CizgiRKafaLakosID", True))
        Me.LookUpEdit3.EnterMoveNextControl = True
        Me.LookUpEdit3.Location = New System.Drawing.Point(37, 26)
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
        Me.LookUpEdit2.Location = New System.Drawing.Point(37, 3)
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
        Me.LabelControl7.Location = New System.Drawing.Point(8, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "Renk"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 29)
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
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Tur"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl1)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(204, 130)
        Me.XtraTabPage3.Text = "Garni 1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.tbGarni1Cizgiler
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 87)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(204, 43)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'tbGarni1Cizgiler
        '
        Me.tbGarni1Cizgiler.Columns.AddRange(New System.Data.DataColumn() {Me.tbGarni1Cizgiler_nID, Me.tbGarni1Cizgiler_Deleted, Me.tbGarni1Cizgiler_CreatedBy, Me.tbGarni1Cizgiler_CreatedDate, Me.tbGarni1Cizgiler_ModifiedBy, Me.tbGarni1Cizgiler_ModifiedDate, Me.tbGarni1Cizgiler_Manset6cmID, Me.tbGarni1Cizgiler_CizgiNo, Me.tbGarni1Cizgiler_RenkID})
        Me.tbGarni1Cizgiler.Connection = Me.SqlConn
        Me.tbGarni1Cizgiler.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.tbGarni1Cizgiler.CurrentRow = Nothing
        Me.tbGarni1Cizgiler.DataSourceLink = Nothing
        Me.tbGarni1Cizgiler.DeleteCommand = Me.SqlCommand32
        Me.tbGarni1Cizgiler.Filter = ""
        Me.tbGarni1Cizgiler.InsertCommand = Me.SqlCommand30
        Me.tbGarni1Cizgiler.LiveSave = False
        Me.tbGarni1Cizgiler.MaxRecords = CType(0, Long)
        Me.tbGarni1Cizgiler.Name = "tbGarni1Cizgiler"
        Me.tbGarni1Cizgiler.ParentRelation_ChildColumns = Nothing
        Me.tbGarni1Cizgiler.ParentRelation_ParentColumns = Nothing
        Me.tbGarni1Cizgiler.ParentRelation_Table = Nothing
        Me.tbGarni1Cizgiler.Position = CType(-1, Long)
        Me.tbGarni1Cizgiler.PrimaryKey = New System.Data.DataColumn() {Me.tbGarni1Cizgiler_nID}
        Me.tbGarni1Cizgiler.Quoted = False
        Me.tbGarni1Cizgiler.SelectCommand = Me.SqlCommand29
        Me.tbGarni1Cizgiler.TableName = "NeoTable4"
        Me.tbGarni1Cizgiler.Transaction = Nothing
        Me.tbGarni1Cizgiler.UpdateCommand = Me.SqlCommand31
        '
        'tbGarni1Cizgiler_nID
        '
        Me.tbGarni1Cizgiler_nID.AllowDBNull = False
        Me.tbGarni1Cizgiler_nID.AutoIncrement = True
        Me.tbGarni1Cizgiler_nID.ColumnName = "nID"
        Me.tbGarni1Cizgiler_nID.DataType = GetType(Integer)
        '
        'tbGarni1Cizgiler_Deleted
        '
        Me.tbGarni1Cizgiler_Deleted.ColumnName = "Deleted"
        Me.tbGarni1Cizgiler_Deleted.DataType = GetType(Integer)
        '
        'tbGarni1Cizgiler_CreatedBy
        '
        Me.tbGarni1Cizgiler_CreatedBy.ColumnName = "CreatedBy"
        Me.tbGarni1Cizgiler_CreatedBy.DataType = GetType(Integer)
        '
        'tbGarni1Cizgiler_CreatedDate
        '
        Me.tbGarni1Cizgiler_CreatedDate.ColumnName = "CreatedDate"
        Me.tbGarni1Cizgiler_CreatedDate.DataType = GetType(Date)
        '
        'tbGarni1Cizgiler_ModifiedBy
        '
        Me.tbGarni1Cizgiler_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbGarni1Cizgiler_ModifiedBy.DataType = GetType(Integer)
        '
        'tbGarni1Cizgiler_ModifiedDate
        '
        Me.tbGarni1Cizgiler_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbGarni1Cizgiler_ModifiedDate.DataType = GetType(Date)
        '
        'tbGarni1Cizgiler_Manset6cmID
        '
        Me.tbGarni1Cizgiler_Manset6cmID.ColumnName = "Manset6cmID"
        Me.tbGarni1Cizgiler_Manset6cmID.DataType = GetType(Integer)
        '
        'tbGarni1Cizgiler_CizgiNo
        '
        Me.tbGarni1Cizgiler_CizgiNo.ColumnName = "CizgiNo"
        Me.tbGarni1Cizgiler_CizgiNo.DataType = GetType(Integer)
        '
        'tbGarni1Cizgiler_RenkID
        '
        Me.tbGarni1Cizgiler_RenkID.ColumnName = "RenkID"
        Me.tbGarni1Cizgiler_RenkID.DataType = GetType(Integer)
        '
        'SqlCommand32
        '
        Me.SqlCommand32.CommandText = "UPDATE SipDetayParam_014_Manset6cm_Garni1Cizgiler SET Deleted = nID  , ModifiedBy" &
    " = @ModifiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand30
        '
        Me.SqlCommand30.CommandText = resources.GetString("SqlCommand30.CommandText")
        Me.SqlCommand30.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand29
        '
        Me.SqlCommand29.CommandText = "SELECT * FROM SipDetayParam_014_Manset6cm_Garni1Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand31
        '
        Me.SqlCommand31.CommandText = resources.GetString("SqlCommand31.CommandText")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "nID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "#"
        Me.GridColumn8.FieldName = "CizgiNo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 32
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Renk"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.GridColumn9.FieldName = "RenkID"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 131
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.tbRenk
        Me.RepositoryItemLookUpEdit3.DisplayMember = "RenkKod"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit3.ValueMember = "RenkID"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Aciklama", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RKafa", "RKafa", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "Cizgi Sayisi", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.tbCizgiRenkKafaLakos
        Me.RepositoryItemLookUpEdit4.DisplayMember = "RKafa"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit4.ValueMember = "RKafa"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.TextEdit4)
        Me.PanelControl1.Controls.Add(Me.TextEdit5)
        Me.PanelControl1.Controls.Add(Me.LookUpEdit9)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.LookUpEdit4)
        Me.PanelControl1.Controls.Add(Me.LookUpEdit5)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(204, 87)
        Me.PanelControl1.TabIndex = 7
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(37, 47)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl14.TabIndex = 19
        Me.LabelControl14.Text = "Tur"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni1_IpGramaj", True))
        Me.TextEdit4.Location = New System.Drawing.Point(160, 61)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit4.TabIndex = 15
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni1_GramajArtis", True))
        Me.TextEdit5.Location = New System.Drawing.Point(218, 61)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit5.TabIndex = 18
        '
        'LookUpEdit9
        '
        Me.LookUpEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni1_Iplik", True))
        Me.LookUpEdit9.Location = New System.Drawing.Point(37, 61)
        Me.LookUpEdit9.Name = "LookUpEdit9"
        Me.LookUpEdit9.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit9.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit9.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit9.Properties.DataSource = Me.tbIplik
        Me.LookUpEdit9.Properties.DisplayMember = "IplikKod"
        Me.LookUpEdit9.Properties.NullText = ""
        Me.LookUpEdit9.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit9.Properties.ValueMember = "IplikID"
        Me.LookUpEdit9.Size = New System.Drawing.Size(118, 20)
        Me.LookUpEdit9.TabIndex = 14
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(160, 47)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl15.TabIndex = 16
        Me.LabelControl15.Text = "İp Grm."
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(228, 47)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl16.TabIndex = 17
        Me.LabelControl16.Text = "Artış"
        '
        'LookUpEdit4
        '
        Me.LookUpEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni1_CizgiRKafaLakosID", True))
        Me.LookUpEdit4.EnterMoveNextControl = True
        Me.LookUpEdit4.Location = New System.Drawing.Point(37, 26)
        Me.LookUpEdit4.Name = "LookUpEdit4"
        Me.LookUpEdit4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit4.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Çizgiler", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "#", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiRKafaLakosID", "Cizgi RKafa Lakos ID", 121, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit4.Properties.DataSource = Me.tbCizgiRenkKafaLakos
        Me.LookUpEdit4.Properties.DisplayMember = "Aciklama"
        Me.LookUpEdit4.Properties.NullText = ""
        Me.LookUpEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit4.Properties.ValueMember = "CizgiRKafaLakosID"
        Me.LookUpEdit4.Size = New System.Drawing.Size(166, 20)
        Me.LookUpEdit4.TabIndex = 4
        '
        'LookUpEdit5
        '
        Me.LookUpEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni1_RenkID", True))
        Me.LookUpEdit5.EnterMoveNextControl = True
        Me.LookUpEdit5.Location = New System.Drawing.Point(37, 3)
        Me.LookUpEdit5.Name = "LookUpEdit5"
        Me.LookUpEdit5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit5.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit5.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit5.Properties.DataSource = Me.tbRenk
        Me.LookUpEdit5.Properties.DisplayMember = "RenkKod"
        Me.LookUpEdit5.Properties.NullText = ""
        Me.LookUpEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit5.Properties.ValueMember = "RenkID"
        Me.LookUpEdit5.Size = New System.Drawing.Size(167, 20)
        Me.LookUpEdit5.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Renk"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(10, 29)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "Çizgi"
        '
        'tbGarni2Cizgiler
        '
        Me.tbGarni2Cizgiler.Columns.AddRange(New System.Data.DataColumn() {Me.tbGarni2Cizgiler_nID, Me.tbGarni2Cizgiler_Deleted, Me.tbGarni2Cizgiler_CreatedBy, Me.tbGarni2Cizgiler_CreatedDate, Me.tbGarni2Cizgiler_ModifiedBy, Me.tbGarni2Cizgiler_ModifiedDate, Me.tbGarni2Cizgiler_Manset6cmID, Me.tbGarni2Cizgiler_CizgiNo, Me.tbGarni2Cizgiler_RenkID})
        Me.tbGarni2Cizgiler.Connection = Me.SqlConn
        Me.tbGarni2Cizgiler.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.tbGarni2Cizgiler.CurrentRow = Nothing
        Me.tbGarni2Cizgiler.DataSourceLink = Nothing
        Me.tbGarni2Cizgiler.DeleteCommand = Me.SqlCommand36
        Me.tbGarni2Cizgiler.Filter = ""
        Me.tbGarni2Cizgiler.InsertCommand = Me.SqlCommand34
        Me.tbGarni2Cizgiler.LiveSave = False
        Me.tbGarni2Cizgiler.MaxRecords = CType(0, Long)
        Me.tbGarni2Cizgiler.Name = "tbGarni2Cizgiler"
        Me.tbGarni2Cizgiler.ParentRelation_ChildColumns = Nothing
        Me.tbGarni2Cizgiler.ParentRelation_ParentColumns = Nothing
        Me.tbGarni2Cizgiler.ParentRelation_Table = Nothing
        Me.tbGarni2Cizgiler.Position = CType(-1, Long)
        Me.tbGarni2Cizgiler.PrimaryKey = New System.Data.DataColumn() {Me.tbGarni2Cizgiler_nID}
        Me.tbGarni2Cizgiler.Quoted = False
        Me.tbGarni2Cizgiler.SelectCommand = Me.SqlCommand33
        Me.tbGarni2Cizgiler.TableName = "NeoTable4"
        Me.tbGarni2Cizgiler.Transaction = Nothing
        Me.tbGarni2Cizgiler.UpdateCommand = Me.SqlCommand35
        '
        'tbGarni2Cizgiler_nID
        '
        Me.tbGarni2Cizgiler_nID.AllowDBNull = False
        Me.tbGarni2Cizgiler_nID.AutoIncrement = True
        Me.tbGarni2Cizgiler_nID.ColumnName = "nID"
        Me.tbGarni2Cizgiler_nID.DataType = GetType(Integer)
        '
        'tbGarni2Cizgiler_Deleted
        '
        Me.tbGarni2Cizgiler_Deleted.ColumnName = "Deleted"
        Me.tbGarni2Cizgiler_Deleted.DataType = GetType(Integer)
        '
        'tbGarni2Cizgiler_CreatedBy
        '
        Me.tbGarni2Cizgiler_CreatedBy.ColumnName = "CreatedBy"
        Me.tbGarni2Cizgiler_CreatedBy.DataType = GetType(Integer)
        '
        'tbGarni2Cizgiler_CreatedDate
        '
        Me.tbGarni2Cizgiler_CreatedDate.ColumnName = "CreatedDate"
        Me.tbGarni2Cizgiler_CreatedDate.DataType = GetType(Date)
        '
        'tbGarni2Cizgiler_ModifiedBy
        '
        Me.tbGarni2Cizgiler_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbGarni2Cizgiler_ModifiedBy.DataType = GetType(Integer)
        '
        'tbGarni2Cizgiler_ModifiedDate
        '
        Me.tbGarni2Cizgiler_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbGarni2Cizgiler_ModifiedDate.DataType = GetType(Date)
        '
        'tbGarni2Cizgiler_Manset6cmID
        '
        Me.tbGarni2Cizgiler_Manset6cmID.ColumnName = "Manset6cmID"
        Me.tbGarni2Cizgiler_Manset6cmID.DataType = GetType(Integer)
        '
        'tbGarni2Cizgiler_CizgiNo
        '
        Me.tbGarni2Cizgiler_CizgiNo.ColumnName = "CizgiNo"
        Me.tbGarni2Cizgiler_CizgiNo.DataType = GetType(Integer)
        '
        'tbGarni2Cizgiler_RenkID
        '
        Me.tbGarni2Cizgiler_RenkID.ColumnName = "RenkID"
        Me.tbGarni2Cizgiler_RenkID.DataType = GetType(Integer)
        '
        'SqlCommand36
        '
        Me.SqlCommand36.CommandText = "UPDATE SipDetayParam_014_Manset6cm_Garni2Cizgiler SET Deleted = nID  , ModifiedBy" &
    " = @ModifiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand34
        '
        Me.SqlCommand34.CommandText = resources.GetString("SqlCommand34.CommandText")
        Me.SqlCommand34.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand33
        '
        Me.SqlCommand33.CommandText = "SELECT * FROM SipDetayParam_014_Manset6cm_Garni2Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand35
        '
        Me.SqlCommand35.CommandText = resources.GetString("SqlCommand35.CommandText")
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridControl3)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl3)
        Me.XtraTabPage4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(204, 130)
        Me.XtraTabPage4.Text = "Garni2"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.tbGarni2Cizgiler
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 87)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit5})
        Me.GridControl3.Size = New System.Drawing.Size(204, 43)
        Me.GridControl3.TabIndex = 8
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "nID"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "KategoriParamID"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "KategoriID"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "#"
        Me.GridColumn13.FieldName = "CizgiNo"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 32
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Renk"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.GridColumn14.FieldName = "RenkID"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 131
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.tbRenk
        Me.RepositoryItemLookUpEdit5.DisplayMember = "RenkKod"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit5.ValueMember = "RenkID"
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Aciklama", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RKafa", "RKafa", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "Cizgi Sayisi", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.tbCizgiRenkKafaLakos
        Me.RepositoryItemLookUpEdit6.DisplayMember = "RKafa"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit6.ValueMember = "RKafa"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl17)
        Me.PanelControl3.Controls.Add(Me.TextEdit6)
        Me.PanelControl3.Controls.Add(Me.TextEdit7)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit10)
        Me.PanelControl3.Controls.Add(Me.LabelControl18)
        Me.PanelControl3.Controls.Add(Me.LabelControl19)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit6)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit7)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(204, 87)
        Me.PanelControl3.TabIndex = 9
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(37, 47)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl17.TabIndex = 25
        Me.LabelControl17.Text = "Tur"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni2_IpGramaj", True))
        Me.TextEdit6.Location = New System.Drawing.Point(160, 61)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit6.TabIndex = 21
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni2_GramajArtis", True))
        Me.TextEdit7.Location = New System.Drawing.Point(218, 61)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit7.TabIndex = 24
        '
        'LookUpEdit10
        '
        Me.LookUpEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni2_Iplik", True))
        Me.LookUpEdit10.Location = New System.Drawing.Point(37, 61)
        Me.LookUpEdit10.Name = "LookUpEdit10"
        Me.LookUpEdit10.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit10.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit10.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit10.Properties.DataSource = Me.tbIplik
        Me.LookUpEdit10.Properties.DisplayMember = "IplikKod"
        Me.LookUpEdit10.Properties.NullText = ""
        Me.LookUpEdit10.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit10.Properties.ValueMember = "IplikID"
        Me.LookUpEdit10.Size = New System.Drawing.Size(118, 20)
        Me.LookUpEdit10.TabIndex = 20
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(160, 47)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl18.TabIndex = 22
        Me.LabelControl18.Text = "İp Grm."
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(228, 47)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl19.TabIndex = 23
        Me.LabelControl19.Text = "Artış"
        '
        'LookUpEdit6
        '
        Me.LookUpEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni2_CizgiRKafaLakosID", True))
        Me.LookUpEdit6.EnterMoveNextControl = True
        Me.LookUpEdit6.Location = New System.Drawing.Point(37, 26)
        Me.LookUpEdit6.Name = "LookUpEdit6"
        Me.LookUpEdit6.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit6.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit6.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Çizgiler", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiSayisi", "#", 62, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CizgiRKafaLakosID", "Cizgi RKafa Lakos ID", 121, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit6.Properties.DataSource = Me.tbCizgiRenkKafaLakos
        Me.LookUpEdit6.Properties.DisplayMember = "Aciklama"
        Me.LookUpEdit6.Properties.NullText = ""
        Me.LookUpEdit6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit6.Properties.ValueMember = "CizgiRKafaLakosID"
        Me.LookUpEdit6.Size = New System.Drawing.Size(166, 20)
        Me.LookUpEdit6.TabIndex = 4
        '
        'LookUpEdit7
        '
        Me.LookUpEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Garni2_RenkID", True))
        Me.LookUpEdit7.EnterMoveNextControl = True
        Me.LookUpEdit7.Location = New System.Drawing.Point(37, 3)
        Me.LookUpEdit7.Name = "LookUpEdit7"
        Me.LookUpEdit7.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit7.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit7.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit7.Properties.DataSource = Me.tbRenk
        Me.LookUpEdit7.Properties.DisplayMember = "RenkKod"
        Me.LookUpEdit7.Properties.NullText = ""
        Me.LookUpEdit7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit7.Properties.ValueMember = "RenkID"
        Me.LookUpEdit7.Size = New System.Drawing.Size(167, 20)
        Me.LookUpEdit7.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(8, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl9.TabIndex = 3
        Me.LabelControl9.Text = "Renk"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(10, 29)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl10.TabIndex = 2
        Me.LabelControl10.Text = "Çizgi"
        '
        'cnt014_Manset6cm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Caption = "6cm Manşet"
        Me.Code = "014"
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cnt014_Manset6cm"
        Me.Size = New System.Drawing.Size(292, 222)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCaption.ResumeLayout(False)
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCizgiRenkKafaLakos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTurArtis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGarni2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGarni1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGarni1Cizgiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGarni2Cizgiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colRenkID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NeoTable3 As NeoDAC.NeoTable
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
    Friend WithEvents NeoTable1_nID As System.Data.DataColumn
    Friend WithEvents NeoTable1_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable1_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable1_KategoriParamID As System.Data.DataColumn
    Friend WithEvents NeoTable1_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable1_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable1_GramajArtis As System.Data.DataColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkGarni1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGarni2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tbGarni1Cizgiler As NeoDAC.NeoTable
    Friend WithEvents SqlCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbGarni2Cizgiler As NeoDAC.NeoTable
    Friend WithEvents SqlCommand36 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand34 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand33 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand35 As System.Data.SqlClient.SqlCommand
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LookUpEdit6 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit9 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit10 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbGarni1Cizgiler_nID As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_Deleted As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_Manset6cmID As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_CizgiNo As System.Data.DataColumn
    Friend WithEvents tbGarni1Cizgiler_RenkID As System.Data.DataColumn
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
    Friend WithEvents NeoTable2_bGarni1 As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni1_RenkID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni1_CizgiRKafaLakosID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni1_CizgiSayisi As System.Data.DataColumn
    Friend WithEvents NeoTable2_bGarni2 As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni2_RenkID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni2_CizgiRKafaLakosID As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni2_CizgiSayisi As System.Data.DataColumn
    Friend WithEvents NeoTable2_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable2_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable2_GramajArtis As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni1_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni1_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni1_GramajArtis As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni2_Iplik As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni2_IpGramaj As System.Data.DataColumn
    Friend WithEvents NeoTable2_Garni2_GramajArtis As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_nID As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_Deleted As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_Manset6cmID As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_CizgiNo As System.Data.DataColumn
    Friend WithEvents tbGarni2Cizgiler_RenkID As System.Data.DataColumn
    Friend WithEvents NeoTable3_nID As System.Data.DataColumn
    Friend WithEvents NeoTable3_Deleted As System.Data.DataColumn
    Friend WithEvents NeoTable3_CreatedBy As System.Data.DataColumn
    Friend WithEvents NeoTable3_CreatedDate As System.Data.DataColumn
    Friend WithEvents NeoTable3_ModifiedBy As System.Data.DataColumn
    Friend WithEvents NeoTable3_ModifiedDate As System.Data.DataColumn
    Friend WithEvents NeoTable3_Manset6cmID As System.Data.DataColumn
    Friend WithEvents NeoTable3_CizgiNo As System.Data.DataColumn
    Friend WithEvents NeoTable3_RenkID As System.Data.DataColumn

End Class
