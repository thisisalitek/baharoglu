<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategoriReport
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
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.MasterTable_KategoriID = New System.Data.DataColumn()
        Me.MasterTable_Deleted = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_UstKategoriID = New System.Data.DataColumn()
        Me.MasterTable_KategoriKod = New System.Data.DataColumn()
        Me.MasterTable_KategoriIsim = New System.Data.DataColumn()
        Me.MasterTable_StokKodFormat = New System.Data.DataColumn()
        Me.MasterTable_IntCode = New System.Data.DataColumn()
        Me.MasterTable_tempGrup = New System.Data.DataColumn()
        Me.MasterTable_Resim1 = New System.Data.DataColumn()
        Me.MasterTable_Resim2 = New System.Data.DataColumn()
        Me.MasterTable_Resim3 = New System.Data.DataColumn()
        Me.MasterTable_Resim4 = New System.Data.DataColumn()
        Me.MasterTable_Resim5 = New System.Data.DataColumn()
        Me.colKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUstKategoriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKategoriIsim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokKodFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltempGrup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResim1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResim2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResim3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResim4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResim5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(908, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 528)
        Me.barDockControlBottom.Size = New System.Drawing.Size(908, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 461)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(908, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 461)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterTable
        Me.GridControl1.Size = New System.Drawing.Size(902, 259)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKategoriID, Me.colDeleted, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colUstKategoriID, Me.colKategoriKod, Me.colKategoriIsim, Me.colStokKodFormat, Me.colIntCode, Me.coltempGrup, Me.colResim1, Me.colResim2, Me.colResim3, Me.colResim4, Me.colResim5})
        Me.GridView1.OptionsBehavior.Editable = False
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
        Me.panelFormTop.Location = New System.Drawing.Point(0, 128)
        Me.panelFormTop.Size = New System.Drawing.Size(908, 72)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 200)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(908, 287)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(902, 259)
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Security=True;"
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_KategoriID, Me.MasterTable_Deleted, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_UstKategoriID, Me.MasterTable_KategoriKod, Me.MasterTable_KategoriIsim, Me.MasterTable_StokKodFormat, Me.MasterTable_IntCode, Me.MasterTable_tempGrup, Me.MasterTable_Resim1, Me.MasterTable_Resim2, Me.MasterTable_Resim3, Me.MasterTable_Resim4, Me.MasterTable_Resim5})
        Me.MasterTable.Connection = Me.FirmConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"KategoriID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_KategoriID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'panelBottom
        '
        Me.panelBottom.Location = New System.Drawing.Point(0, 487)
        Me.panelBottom.Size = New System.Drawing.Size(908, 41)
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(710, 2)
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Location = New System.Drawing.Point(0, 67)
        Me.panelFormDateFilter.Size = New System.Drawing.Size(908, 61)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM Kategoriler WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY KategoriKod"
        '
        'MasterTable_KategoriID
        '
        Me.MasterTable_KategoriID.AllowDBNull = False
        Me.MasterTable_KategoriID.AutoIncrement = True
        Me.MasterTable_KategoriID.ColumnName = "KategoriID"
        Me.MasterTable_KategoriID.DataType = GetType(Integer)
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
        'MasterTable_UstKategoriID
        '
        Me.MasterTable_UstKategoriID.ColumnName = "UstKategoriID"
        Me.MasterTable_UstKategoriID.DataType = GetType(Integer)
        '
        'MasterTable_KategoriKod
        '
        Me.MasterTable_KategoriKod.ColumnName = "KategoriKod"
        '
        'MasterTable_KategoriIsim
        '
        Me.MasterTable_KategoriIsim.ColumnName = "KategoriIsim"
        '
        'MasterTable_StokKodFormat
        '
        Me.MasterTable_StokKodFormat.ColumnName = "StokKodFormat"
        '
        'MasterTable_IntCode
        '
        Me.MasterTable_IntCode.ColumnName = "IntCode"
        '
        'MasterTable_tempGrup
        '
        Me.MasterTable_tempGrup.ColumnName = "tempGrup"
        '
        'MasterTable_Resim1
        '
        Me.MasterTable_Resim1.ColumnName = "Resim1"
        Me.MasterTable_Resim1.DataType = GetType(Byte())
        '
        'MasterTable_Resim2
        '
        Me.MasterTable_Resim2.ColumnName = "Resim2"
        Me.MasterTable_Resim2.DataType = GetType(Byte())
        '
        'MasterTable_Resim3
        '
        Me.MasterTable_Resim3.ColumnName = "Resim3"
        Me.MasterTable_Resim3.DataType = GetType(Byte())
        '
        'MasterTable_Resim4
        '
        Me.MasterTable_Resim4.ColumnName = "Resim4"
        Me.MasterTable_Resim4.DataType = GetType(Byte())
        '
        'MasterTable_Resim5
        '
        Me.MasterTable_Resim5.ColumnName = "Resim5"
        Me.MasterTable_Resim5.DataType = GetType(Byte())
        '
        'colKategoriID
        '
        Me.colKategoriID.FieldName = "KategoriID"
        Me.colKategoriID.Name = "colKategoriID"
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        '
        'colUstKategoriID
        '
        Me.colUstKategoriID.FieldName = "UstKategoriID"
        Me.colUstKategoriID.Name = "colUstKategoriID"
        '
        'colKategoriKod
        '
        Me.colKategoriKod.FieldName = "KategoriKod"
        Me.colKategoriKod.Name = "colKategoriKod"
        Me.colKategoriKod.Visible = True
        Me.colKategoriKod.VisibleIndex = 0
        Me.colKategoriKod.Width = 176
        '
        'colKategoriIsim
        '
        Me.colKategoriIsim.FieldName = "KategoriIsim"
        Me.colKategoriIsim.Name = "colKategoriIsim"
        Me.colKategoriIsim.Visible = True
        Me.colKategoriIsim.VisibleIndex = 1
        Me.colKategoriIsim.Width = 314
        '
        'colStokKodFormat
        '
        Me.colStokKodFormat.FieldName = "StokKodFormat"
        Me.colStokKodFormat.Name = "colStokKodFormat"
        '
        'colIntCode
        '
        Me.colIntCode.Caption = "Mikro Stok Kodu"
        Me.colIntCode.FieldName = "IntCode"
        Me.colIntCode.Name = "colIntCode"
        Me.colIntCode.Visible = True
        Me.colIntCode.VisibleIndex = 2
        Me.colIntCode.Width = 238
        '
        'coltempGrup
        '
        Me.coltempGrup.FieldName = "tempGrup"
        Me.coltempGrup.Name = "coltempGrup"
        '
        'colResim1
        '
        Me.colResim1.FieldName = "Resim1"
        Me.colResim1.Name = "colResim1"
        '
        'colResim2
        '
        Me.colResim2.FieldName = "Resim2"
        Me.colResim2.Name = "colResim2"
        '
        'colResim3
        '
        Me.colResim3.FieldName = "Resim3"
        Me.colResim3.Name = "colResim3"
        '
        'colResim4
        '
        Me.colResim4.FieldName = "Resim4"
        Me.colResim4.Name = "colResim4"
        '
        'colResim5
        '
        Me.colResim5.FieldName = "Resim5"
        Me.colResim5.Name = "colResim5"
        '
        'frmKategoriReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(908, 557)
        Me.FormCode = "000030"
        Me.Name = "frmKategoriReport"
        Me.Text = "Kategori dokumu"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MasterTable_KategoriID As DataColumn
    Friend WithEvents MasterTable_Deleted As DataColumn
    Friend WithEvents MasterTable_CreatedBy As DataColumn
    Friend WithEvents MasterTable_CreatedDate As DataColumn
    Friend WithEvents MasterTable_ModifiedBy As DataColumn
    Friend WithEvents MasterTable_ModifiedDate As DataColumn
    Friend WithEvents MasterTable_UstKategoriID As DataColumn
    Friend WithEvents MasterTable_KategoriKod As DataColumn
    Friend WithEvents MasterTable_KategoriIsim As DataColumn
    Friend WithEvents MasterTable_StokKodFormat As DataColumn
    Friend WithEvents MasterTable_IntCode As DataColumn
    Friend WithEvents MasterTable_tempGrup As DataColumn
    Friend WithEvents MasterTable_Resim1 As DataColumn
    Friend WithEvents MasterTable_Resim2 As DataColumn
    Friend WithEvents MasterTable_Resim3 As DataColumn
    Friend WithEvents MasterTable_Resim4 As DataColumn
    Friend WithEvents MasterTable_Resim5 As DataColumn
    Friend WithEvents SqlCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As SqlClient.SqlCommand
    Friend WithEvents colKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUstKategoriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKategoriIsim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokKodFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltempGrup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResim1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResim2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResim3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResim4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResim5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
