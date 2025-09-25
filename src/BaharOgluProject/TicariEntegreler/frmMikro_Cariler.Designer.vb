<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMikro_Cariler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMikro_Cariler))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.colcari_kod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcari_unvan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcari_Guid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBakiye = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRiskBakiye = New System.Windows.Forms.TextBox()
        Me.coladr_sokak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_cadde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_ilce = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_il = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_ulke = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_posta_kodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_tel_ulke_kodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_tel_bolge_kodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_tel_no1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_tel_no2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladr_tel_faxno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefon1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefon2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcari_unvan11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcari_unvan2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterTable_cari_Guid = New System.Data.DataColumn()
        Me.MasterTable_cari_kod = New System.Data.DataColumn()
        Me.MasterTable_CariUnvan = New System.Data.DataColumn()
        Me.MasterTable_cari_unvan1 = New System.Data.DataColumn()
        Me.MasterTable_cari_unvan2 = New System.Data.DataColumn()
        Me.MasterTable_adr_cadde = New System.Data.DataColumn()
        Me.MasterTable_adr_sokak = New System.Data.DataColumn()
        Me.MasterTable_adr_posta_kodu = New System.Data.DataColumn()
        Me.MasterTable_adr_ilce = New System.Data.DataColumn()
        Me.MasterTable_adr_il = New System.Data.DataColumn()
        Me.MasterTable_adr_ulke = New System.Data.DataColumn()
        Me.MasterTable_adr_tel_ulke_kodu = New System.Data.DataColumn()
        Me.MasterTable_adr_tel_bolge_kodu = New System.Data.DataColumn()
        Me.MasterTable_adr_tel_no1 = New System.Data.DataColumn()
        Me.MasterTable_adr_tel_no2 = New System.Data.DataColumn()
        Me.MasterTable_adr_tel_faxno = New System.Data.DataColumn()
        Me.MasterTable_Telefon1 = New System.Data.DataColumn()
        Me.MasterTable_Telefon2 = New System.Data.DataColumn()
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.barDockControlTop.Size = New System.Drawing.Size(645, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 439)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(645, 67)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 439)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterTable
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Size = New System.Drawing.Size(639, 288)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcari_kod, Me.colcari_unvan1, Me.colcari_Guid, Me.coladr_sokak, Me.coladr_cadde, Me.coladr_ilce, Me.coladr_il, Me.coladr_ulke, Me.coladr_posta_kodu, Me.coladr_tel_ulke_kodu, Me.coladr_tel_bolge_kodu, Me.coladr_tel_no1, Me.coladr_tel_no2, Me.coladr_tel_faxno, Me.colTelefon1, Me.colTelefon2, Me.colcari_unvan11, Me.colcari_unvan2})
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
        Me.panelFormTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelFormTop.Size = New System.Drawing.Size(645, 21)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 149)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(645, 316)
        '
        'BaseTab1
        '
        Me.BaseTab1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseTab1.Size = New System.Drawing.Size(639, 288)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_cari_Guid, Me.MasterTable_cari_kod, Me.MasterTable_CariUnvan, Me.MasterTable_cari_unvan1, Me.MasterTable_cari_unvan2, Me.MasterTable_adr_cadde, Me.MasterTable_adr_sokak, Me.MasterTable_adr_posta_kodu, Me.MasterTable_adr_ilce, Me.MasterTable_adr_il, Me.MasterTable_adr_ulke, Me.MasterTable_adr_tel_ulke_kodu, Me.MasterTable_adr_tel_bolge_kodu, Me.MasterTable_adr_tel_no1, Me.MasterTable_adr_tel_no2, Me.MasterTable_adr_tel_faxno, Me.MasterTable_Telefon1, Me.MasterTable_Telefon2})
        Me.MasterTable.Connection = Me.TicariConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cari_Guid"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_cari_Guid}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'panelBottom
        '
        Me.panelBottom.Controls.Add(Me.LabelControl5)
        Me.panelBottom.Controls.Add(Me.txtRiskBakiye)
        Me.panelBottom.Controls.Add(Me.LabelControl1)
        Me.panelBottom.Controls.Add(Me.txtBakiye)
        Me.panelBottom.Controls.SetChildIndex(Me.txtBakiye, 0)
        Me.panelBottom.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.panelBottom.Controls.SetChildIndex(Me.PanelControl3, 0)
        Me.panelBottom.Controls.SetChildIndex(Me.txtRiskBakiye, 0)
        Me.panelBottom.Controls.SetChildIndex(Me.LabelControl5, 0)
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Location = New System.Drawing.Point(0, 67)
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
        'TicariConn
        '
        Me.TicariConn.ConnectionString = "Data Source=(local)\Sql2017;Initial Catalog=MikroDB_V16_TEST;Integrated Security=" &
    "True;"
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        '
        'colcari_kod
        '
        Me.colcari_kod.Caption = "Cari Kod"
        Me.colcari_kod.FieldName = "cari_kod"
        Me.colcari_kod.Name = "colcari_kod"
        Me.colcari_kod.Visible = True
        Me.colcari_kod.VisibleIndex = 0
        Me.colcari_kod.Width = 141
        '
        'colcari_unvan1
        '
        Me.colcari_unvan1.Caption = "Cari Ünvan"
        Me.colcari_unvan1.FieldName = "CariUnvan"
        Me.colcari_unvan1.Name = "colcari_unvan1"
        Me.colcari_unvan1.Visible = True
        Me.colcari_unvan1.VisibleIndex = 1
        Me.colcari_unvan1.Width = 286
        '
        'colcari_Guid
        '
        Me.colcari_Guid.FieldName = "cari_Guid"
        Me.colcari_Guid.Name = "colcari_Guid"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(4, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Bakiye"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtBakiye
        '
        Me.txtBakiye.Location = New System.Drawing.Point(44, 12)
        Me.txtBakiye.Name = "txtBakiye"
        Me.txtBakiye.Size = New System.Drawing.Size(90, 21)
        Me.txtBakiye.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(156, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Risk"
        '
        'txtRiskBakiye
        '
        Me.txtRiskBakiye.Location = New System.Drawing.Point(181, 14)
        Me.txtRiskBakiye.Name = "txtRiskBakiye"
        Me.txtRiskBakiye.Size = New System.Drawing.Size(90, 21)
        Me.txtRiskBakiye.TabIndex = 6
        '
        'coladr_sokak
        '
        Me.coladr_sokak.Caption = "Sokak"
        Me.coladr_sokak.FieldName = "adr_sokak"
        Me.coladr_sokak.Name = "coladr_sokak"
        Me.coladr_sokak.Visible = True
        Me.coladr_sokak.VisibleIndex = 2
        '
        'coladr_cadde
        '
        Me.coladr_cadde.Caption = "Cadde"
        Me.coladr_cadde.FieldName = "adr_cadde"
        Me.coladr_cadde.Name = "coladr_cadde"
        Me.coladr_cadde.Visible = True
        Me.coladr_cadde.VisibleIndex = 3
        '
        'coladr_ilce
        '
        Me.coladr_ilce.Caption = "Ilce"
        Me.coladr_ilce.FieldName = "adr_ilce"
        Me.coladr_ilce.Name = "coladr_ilce"
        Me.coladr_ilce.Visible = True
        Me.coladr_ilce.VisibleIndex = 4
        '
        'coladr_il
        '
        Me.coladr_il.Caption = "Il"
        Me.coladr_il.FieldName = "adr_il"
        Me.coladr_il.Name = "coladr_il"
        Me.coladr_il.Visible = True
        Me.coladr_il.VisibleIndex = 5
        '
        'coladr_ulke
        '
        Me.coladr_ulke.Caption = "Ulke"
        Me.coladr_ulke.FieldName = "adr_ulke"
        Me.coladr_ulke.Name = "coladr_ulke"
        Me.coladr_ulke.Visible = True
        Me.coladr_ulke.VisibleIndex = 6
        '
        'coladr_posta_kodu
        '
        Me.coladr_posta_kodu.Caption = "Posta kodu"
        Me.coladr_posta_kodu.FieldName = "adr_posta_kodu"
        Me.coladr_posta_kodu.Name = "coladr_posta_kodu"
        '
        'coladr_tel_ulke_kodu
        '
        Me.coladr_tel_ulke_kodu.Caption = "Tel ulke kodu"
        Me.coladr_tel_ulke_kodu.FieldName = "adr_tel_ulke_kodu"
        Me.coladr_tel_ulke_kodu.Name = "coladr_tel_ulke_kodu"
        '
        'coladr_tel_bolge_kodu
        '
        Me.coladr_tel_bolge_kodu.Caption = "Tel bolge kodu"
        Me.coladr_tel_bolge_kodu.FieldName = "adr_tel_bolge_kodu"
        Me.coladr_tel_bolge_kodu.Name = "coladr_tel_bolge_kodu"
        '
        'coladr_tel_no1
        '
        Me.coladr_tel_no1.Caption = "Telno1"
        Me.coladr_tel_no1.FieldName = "adr_tel_no1"
        Me.coladr_tel_no1.Name = "coladr_tel_no1"
        '
        'coladr_tel_no2
        '
        Me.coladr_tel_no2.Caption = "Telno2"
        Me.coladr_tel_no2.FieldName = "adr_tel_no2"
        Me.coladr_tel_no2.Name = "coladr_tel_no2"
        '
        'coladr_tel_faxno
        '
        Me.coladr_tel_faxno.Caption = "Faxno"
        Me.coladr_tel_faxno.FieldName = "adr_tel_faxno"
        Me.coladr_tel_faxno.Name = "coladr_tel_faxno"
        '
        'colTelefon1
        '
        Me.colTelefon1.FieldName = "Telefon1"
        Me.colTelefon1.Name = "colTelefon1"
        Me.colTelefon1.Visible = True
        Me.colTelefon1.VisibleIndex = 7
        '
        'colTelefon2
        '
        Me.colTelefon2.FieldName = "Telefon2"
        Me.colTelefon2.Name = "colTelefon2"
        Me.colTelefon2.Visible = True
        Me.colTelefon2.VisibleIndex = 8
        '
        'colcari_unvan11
        '
        Me.colcari_unvan11.FieldName = "cari_unvan1"
        Me.colcari_unvan11.Name = "colcari_unvan11"
        '
        'colcari_unvan2
        '
        Me.colcari_unvan2.FieldName = "cari_unvan2"
        Me.colcari_unvan2.Name = "colcari_unvan2"
        '
        'MasterTable_cari_Guid
        '
        Me.MasterTable_cari_Guid.AllowDBNull = False
        Me.MasterTable_cari_Guid.ColumnName = "cari_Guid"
        Me.MasterTable_cari_Guid.DataType = GetType(System.Guid)
        '
        'MasterTable_cari_kod
        '
        Me.MasterTable_cari_kod.ColumnName = "cari_kod"
        '
        'MasterTable_CariUnvan
        '
        Me.MasterTable_CariUnvan.ColumnName = "CariUnvan"
        '
        'MasterTable_cari_unvan1
        '
        Me.MasterTable_cari_unvan1.ColumnName = "cari_unvan1"
        '
        'MasterTable_cari_unvan2
        '
        Me.MasterTable_cari_unvan2.ColumnName = "cari_unvan2"
        '
        'MasterTable_adr_cadde
        '
        Me.MasterTable_adr_cadde.ColumnName = "adr_cadde"
        '
        'MasterTable_adr_sokak
        '
        Me.MasterTable_adr_sokak.ColumnName = "adr_sokak"
        '
        'MasterTable_adr_posta_kodu
        '
        Me.MasterTable_adr_posta_kodu.ColumnName = "adr_posta_kodu"
        '
        'MasterTable_adr_ilce
        '
        Me.MasterTable_adr_ilce.ColumnName = "adr_ilce"
        '
        'MasterTable_adr_il
        '
        Me.MasterTable_adr_il.ColumnName = "adr_il"
        '
        'MasterTable_adr_ulke
        '
        Me.MasterTable_adr_ulke.ColumnName = "adr_ulke"
        '
        'MasterTable_adr_tel_ulke_kodu
        '
        Me.MasterTable_adr_tel_ulke_kodu.ColumnName = "adr_tel_ulke_kodu"
        '
        'MasterTable_adr_tel_bolge_kodu
        '
        Me.MasterTable_adr_tel_bolge_kodu.ColumnName = "adr_tel_bolge_kodu"
        '
        'MasterTable_adr_tel_no1
        '
        Me.MasterTable_adr_tel_no1.ColumnName = "adr_tel_no1"
        '
        'MasterTable_adr_tel_no2
        '
        Me.MasterTable_adr_tel_no2.ColumnName = "adr_tel_no2"
        '
        'MasterTable_adr_tel_faxno
        '
        Me.MasterTable_adr_tel_faxno.ColumnName = "adr_tel_faxno"
        '
        'MasterTable_Telefon1
        '
        Me.MasterTable_Telefon1.ColumnName = "Telefon1"
        '
        'MasterTable_Telefon2
        '
        Me.MasterTable_Telefon2.ColumnName = "Telefon2"
        '
        'frmMikro_Cariler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(645, 535)
        Me.FormCode = "E00001"
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMikro_Cariler"
        Me.Text = "Mikro Cari Kartlar"
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
        Me.panelBottom.PerformLayout()
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
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colcari_kod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcari_unvan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcari_Guid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRiskBakiye As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBakiye As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents coladr_sokak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_cadde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_ilce As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_il As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_ulke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_posta_kodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_tel_ulke_kodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_tel_bolge_kodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_tel_no1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_tel_no2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladr_tel_faxno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcari_unvan11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcari_unvan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterTable_cari_Guid As DataColumn
    Friend WithEvents MasterTable_cari_kod As DataColumn
    Friend WithEvents MasterTable_CariUnvan As DataColumn
    Friend WithEvents MasterTable_cari_unvan1 As DataColumn
    Friend WithEvents MasterTable_cari_unvan2 As DataColumn
    Friend WithEvents MasterTable_adr_cadde As DataColumn
    Friend WithEvents MasterTable_adr_sokak As DataColumn
    Friend WithEvents MasterTable_adr_posta_kodu As DataColumn
    Friend WithEvents MasterTable_adr_ilce As DataColumn
    Friend WithEvents MasterTable_adr_il As DataColumn
    Friend WithEvents MasterTable_adr_ulke As DataColumn
    Friend WithEvents MasterTable_adr_tel_ulke_kodu As DataColumn
    Friend WithEvents MasterTable_adr_tel_bolge_kodu As DataColumn
    Friend WithEvents MasterTable_adr_tel_no1 As DataColumn
    Friend WithEvents MasterTable_adr_tel_no2 As DataColumn
    Friend WithEvents MasterTable_adr_tel_faxno As DataColumn
    Friend WithEvents MasterTable_Telefon1 As DataColumn
    Friend WithEvents MasterTable_Telefon2 As DataColumn
End Class
