<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMikro_StokKartlari
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBakiye = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRiskBakiye = New System.Windows.Forms.TextBox()
        Me.colsto_Guid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsto_kod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsto_isim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsto_kisa_ismi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsto_yabanci_isim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsto_birim1_ad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterTable_sto_Guid = New System.Data.DataColumn()
        Me.MasterTable_sto_kod = New System.Data.DataColumn()
        Me.MasterTable_sto_isim = New System.Data.DataColumn()
        Me.MasterTable_sto_kisa_ismi = New System.Data.DataColumn()
        Me.MasterTable_sto_yabanci_isim = New System.Data.DataColumn()
        Me.MasterTable_sto_birim1_ad = New System.Data.DataColumn()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(645, 67)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 439)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(645, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 439)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterTable
        Me.GridControl1.Size = New System.Drawing.Size(639, 288)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsto_Guid, Me.colsto_kod, Me.colsto_isim, Me.colsto_kisa_ismi, Me.colsto_yabanci_isim, Me.colsto_birim1_ad})
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
        Me.panelFormTop.Size = New System.Drawing.Size(645, 21)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 149)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(645, 316)
        '
        'BaseTab1
        '
        Me.BaseTab1.Size = New System.Drawing.Size(639, 288)
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_sto_Guid, Me.MasterTable_sto_kod, Me.MasterTable_sto_isim, Me.MasterTable_sto_kisa_ismi, Me.MasterTable_sto_yabanci_isim, Me.MasterTable_sto_birim1_ad})
        Me.MasterTable.Connection = Me.TicariConn
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"sto_kod"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_sto_kod}
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
        Me.SqlCommand1.CommandText = "SELECT sto_Guid,sto_kod,sto_isim,sto_kisa_ismi,sto_yabanci_isim,sto_birim1_ad FRO" &
    "M STOKLAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(4, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Bakiye"
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
        'colsto_Guid
        '
        Me.colsto_Guid.FieldName = "sto_Guid"
        Me.colsto_Guid.Name = "colsto_Guid"
        '
        'colsto_kod
        '
        Me.colsto_kod.Caption = "Stok Kod"
        Me.colsto_kod.FieldName = "sto_kod"
        Me.colsto_kod.Name = "colsto_kod"
        Me.colsto_kod.Visible = True
        Me.colsto_kod.VisibleIndex = 0
        '
        'colsto_isim
        '
        Me.colsto_isim.Caption = "Stok Ismi"
        Me.colsto_isim.FieldName = "sto_isim"
        Me.colsto_isim.Name = "colsto_isim"
        Me.colsto_isim.Visible = True
        Me.colsto_isim.VisibleIndex = 1
        Me.colsto_isim.Width = 184
        '
        'colsto_kisa_ismi
        '
        Me.colsto_kisa_ismi.Caption = "Kisa Ismi"
        Me.colsto_kisa_ismi.FieldName = "sto_kisa_ismi"
        Me.colsto_kisa_ismi.Name = "colsto_kisa_ismi"
        Me.colsto_kisa_ismi.Visible = True
        Me.colsto_kisa_ismi.VisibleIndex = 2
        Me.colsto_kisa_ismi.Width = 185
        '
        'colsto_yabanci_isim
        '
        Me.colsto_yabanci_isim.Caption = "Yabanci Isim"
        Me.colsto_yabanci_isim.FieldName = "sto_yabanci_isim"
        Me.colsto_yabanci_isim.Name = "colsto_yabanci_isim"
        Me.colsto_yabanci_isim.Visible = True
        Me.colsto_yabanci_isim.VisibleIndex = 3
        Me.colsto_yabanci_isim.Width = 257
        '
        'colsto_birim1_ad
        '
        Me.colsto_birim1_ad.Caption = "Birim"
        Me.colsto_birim1_ad.FieldName = "sto_birim1_ad"
        Me.colsto_birim1_ad.Name = "colsto_birim1_ad"
        Me.colsto_birim1_ad.Visible = True
        Me.colsto_birim1_ad.VisibleIndex = 4
        '
        'MasterTable_sto_Guid
        '
        Me.MasterTable_sto_Guid.ColumnName = "sto_Guid"
        Me.MasterTable_sto_Guid.DataType = GetType(System.Guid)
        '
        'MasterTable_sto_kod
        '
        Me.MasterTable_sto_kod.AllowDBNull = False
        Me.MasterTable_sto_kod.ColumnName = "sto_kod"
        '
        'MasterTable_sto_isim
        '
        Me.MasterTable_sto_isim.ColumnName = "sto_isim"
        '
        'MasterTable_sto_kisa_ismi
        '
        Me.MasterTable_sto_kisa_ismi.ColumnName = "sto_kisa_ismi"
        '
        'MasterTable_sto_yabanci_isim
        '
        Me.MasterTable_sto_yabanci_isim.ColumnName = "sto_yabanci_isim"
        '
        'MasterTable_sto_birim1_ad
        '
        Me.MasterTable_sto_birim1_ad.ColumnName = "sto_birim1_ad"
        '
        'frmMikro_StokKartlari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(645, 535)
        Me.FormCode = "E00001"
        Me.Name = "frmMikro_StokKartlari"
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
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRiskBakiye As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBakiye As System.Windows.Forms.TextBox
    Friend WithEvents colsto_Guid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsto_kod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsto_isim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsto_kisa_ismi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsto_yabanci_isim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsto_birim1_ad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterTable_sto_Guid As DataColumn
    Friend WithEvents MasterTable_sto_kod As DataColumn
    Friend WithEvents MasterTable_sto_isim As DataColumn
    Friend WithEvents MasterTable_sto_kisa_ismi As DataColumn
    Friend WithEvents MasterTable_sto_yabanci_isim As DataColumn
    Friend WithEvents MasterTable_sto_birim1_ad As DataColumn
End Class
