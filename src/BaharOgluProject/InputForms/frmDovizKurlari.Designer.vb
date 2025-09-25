<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDovizKurlari
    Inherits ProbarSiparis.frmBaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDovizKurlari))
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.MasterTable_ID = New System.Data.DataColumn()
        Me.MasterTable_CreatedBy = New System.Data.DataColumn()
        Me.MasterTable_CreatedDate = New System.Data.DataColumn()
        Me.MasterTable_ModifiedBy = New System.Data.DataColumn()
        Me.MasterTable_ModifiedDate = New System.Data.DataColumn()
        Me.MasterTable_CurrDate = New System.Data.DataColumn()
        Me.MasterTable_Curr = New System.Data.DataColumn()
        Me.MasterTable_Rate1 = New System.Data.DataColumn()
        Me.MasterTable_Rate2 = New System.Data.DataColumn()
        Me.MasterTable_Rate3 = New System.Data.DataColumn()
        Me.MasterTable_Rate4 = New System.Data.DataColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit4 = New DevExpress.XtraEditors.SpinEdit()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDownloadDovzKur = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.BaseTab1.SuspendLayout()
        Me.BaseTab2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.basePanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.basePanelControl3.SuspendLayout()
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupDocumentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailLink5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelAuthCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAuthCodes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormDateFilter.SuspendLayout()
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDetailTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        '
        'Bar2
        '
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        '
        'Bar3
        '
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 108)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(893, 319)
        '
        'BaseTab1
        '
        Me.BaseTab1.Tag = True
        '
        'BaseTab2
        '
        Me.BaseTab2.Controls.Add(Me.LabelControl5)
        Me.BaseTab2.Controls.Add(Me.SpinEdit3)
        Me.BaseTab2.Controls.Add(Me.LabelControl6)
        Me.BaseTab2.Controls.Add(Me.SpinEdit4)
        Me.BaseTab2.Controls.Add(Me.LabelControl4)
        Me.BaseTab2.Controls.Add(Me.SpinEdit2)
        Me.BaseTab2.Controls.Add(Me.LabelControl3)
        Me.BaseTab2.Controls.Add(Me.SpinEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl2)
        Me.BaseTab2.Controls.Add(Me.ComboBoxEdit1)
        Me.BaseTab2.Controls.Add(Me.DateEdit1)
        Me.BaseTab2.Controls.Add(Me.LabelControl1)
        Me.BaseTab2.Size = New System.Drawing.Size(887, 291)
        Me.BaseTab2.Tag = True
        Me.BaseTab2.Controls.SetChildIndex(Me.panelAuthCodes, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.DateEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.ComboBoxEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.SpinEdit1, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.SpinEdit2, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.SpinEdit4, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.SpinEdit3, 0)
        Me.BaseTab2.Controls.SetChildIndex(Me.LabelControl5, 0)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MasterLink
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.Size = New System.Drawing.Size(887, 211)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCurrDate, Me.colCurr, Me.colRate1, Me.colRate2, Me.colRate3, Me.colRate4})
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Data Source=.\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Security=True;"
        '
        'MasterConn
        '
        Me.MasterConn.ConnectionString = "Data Source=.\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Security=True;"
        '
        'MasterTable
        '
        Me.MasterTable.Columns.AddRange(New System.Data.DataColumn() {Me.MasterTable_ID, Me.MasterTable_CreatedBy, Me.MasterTable_CreatedDate, Me.MasterTable_ModifiedBy, Me.MasterTable_ModifiedDate, Me.MasterTable_CurrDate, Me.MasterTable_Curr, Me.MasterTable_Rate1, Me.MasterTable_Rate2, Me.MasterTable_Rate3, Me.MasterTable_Rate4})
        Me.MasterTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ID"}, True)})
        Me.MasterTable.DeleteCommand = Me.SqlCommand4
        Me.MasterTable.InsertCommand = Me.SqlCommand2
        Me.MasterTable.PrimaryKey = New System.Data.DataColumn() {Me.MasterTable_ID}
        Me.MasterTable.SelectCommand = Me.SqlCommand1
        Me.MasterTable.UpdateCommand = Me.SqlCommand3
        '
        'BaseTab4
        '
        Me.BaseTab4.Size = New System.Drawing.Size(887, 291)
        Me.BaseTab4.Tag = True
        '
        'txtTopInfo
        '
        Me.txtTopInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTopInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTopInfo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTopInfo.Properties.Appearance.Options.UseFont = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        '
        'lblMainWarning1
        '
        Me.lblMainWarning1.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblMainWarning1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        '
        'panelAuthCodes
        '
        Me.panelAuthCodes.Location = New System.Drawing.Point(0, 265)
        '
        'cboAuthCodes
        '
        Me.cboAuthCodes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cboAuthCodes.Properties.Appearance.Options.UseFont = True
        '
        'lblAuthCodeCaption
        '
        Me.lblAuthCodeCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Controls.Add(Me.btnDownloadDovzKur)
        Me.panelFormDateFilter.Visible = True
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.cmdRefreshList, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.btnDownloadDovzKur, 0)
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
        Me.SqlCommand1.CommandText = "SELECT * FROM DovizKurlari WHERE CurrDate BETWEEN @FormDate1 AND @FormDate2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime), New System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime)})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "DELETE FROM DovizKurlari WHERE ID = @ID"
        '
        'MasterTable_ID
        '
        Me.MasterTable_ID.AllowDBNull = False
        Me.MasterTable_ID.AutoIncrement = True
        Me.MasterTable_ID.ColumnName = "ID"
        Me.MasterTable_ID.DataType = GetType(Integer)
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
        'MasterTable_CurrDate
        '
        Me.MasterTable_CurrDate.ColumnName = "CurrDate"
        Me.MasterTable_CurrDate.DataType = GetType(Date)
        '
        'MasterTable_Curr
        '
        Me.MasterTable_Curr.ColumnName = "Curr"
        '
        'MasterTable_Rate1
        '
        Me.MasterTable_Rate1.ColumnName = "Rate1"
        Me.MasterTable_Rate1.DataType = GetType(Double)
        '
        'MasterTable_Rate2
        '
        Me.MasterTable_Rate2.ColumnName = "Rate2"
        Me.MasterTable_Rate2.DataType = GetType(Double)
        '
        'MasterTable_Rate3
        '
        Me.MasterTable_Rate3.ColumnName = "Rate3"
        Me.MasterTable_Rate3.DataType = GetType(Double)
        '
        'MasterTable_Rate4
        '
        Me.MasterTable_Rate4.ColumnName = "Rate4"
        Me.MasterTable_Rate4.DataType = GetType(Double)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Kur Tarihi"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "CurrDate", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(107, 23)
        Me.DateEdit1.MenuManager = Me.BarManager1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 2
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Curr", True))
        Me.ComboBoxEdit1.EnterMoveNextControl = True
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(307, 23)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"USD", "EUR", "GBP", "RUB"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBoxEdit1.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(243, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Doviz"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Rate1", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.EnterMoveNextControl = True
        Me.SpinEdit1.Location = New System.Drawing.Point(107, 64)
        Me.SpinEdit1.MenuManager = Me.BarManager1
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "#,##0.0000"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatString = "#,##0.0000"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit1.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(29, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Alış"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(243, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Satış"
        '
        'SpinEdit2
        '
        Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Rate2", True))
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.EnterMoveNextControl = True
        Me.SpinEdit2.Location = New System.Drawing.Point(307, 64)
        Me.SpinEdit2.MenuManager = Me.BarManager1
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit2.Properties.DisplayFormat.FormatString = "#,##0.0000"
        Me.SpinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Properties.EditFormat.FormatString = "#,##0.0000"
        Me.SpinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit2.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(243, 103)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Efektif Satış"
        '
        'SpinEdit3
        '
        Me.SpinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Rate4", True))
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit3.EnterMoveNextControl = True
        Me.SpinEdit3.Location = New System.Drawing.Point(307, 100)
        Me.SpinEdit3.MenuManager = Me.BarManager1
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit3.Properties.DisplayFormat.FormatString = "#,##0.0000"
        Me.SpinEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit3.Properties.EditFormat.FormatString = "#,##0.0000"
        Me.SpinEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit3.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit3.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(29, 103)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Efektif Alış"
        '
        'SpinEdit4
        '
        Me.SpinEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MasterLink, "Rate3", True))
        Me.SpinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit4.EnterMoveNextControl = True
        Me.SpinEdit4.Location = New System.Drawing.Point(107, 100)
        Me.SpinEdit4.MenuManager = Me.BarManager1
        Me.SpinEdit4.Name = "SpinEdit4"
        Me.SpinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit4.Properties.DisplayFormat.FormatString = "#,##0.0000"
        Me.SpinEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit4.Properties.EditFormat.FormatString = "#,##0.0000"
        Me.SpinEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit4.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit4.TabIndex = 9
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colCurrDate
        '
        Me.colCurrDate.Caption = "Kur Tarihi"
        Me.colCurrDate.FieldName = "CurrDate"
        Me.colCurrDate.Name = "colCurrDate"
        Me.colCurrDate.Visible = True
        Me.colCurrDate.VisibleIndex = 0
        Me.colCurrDate.Width = 87
        '
        'colCurr
        '
        Me.colCurr.Caption = "Döviz"
        Me.colCurr.FieldName = "Curr"
        Me.colCurr.Name = "colCurr"
        Me.colCurr.Visible = True
        Me.colCurr.VisibleIndex = 1
        '
        'colRate1
        '
        Me.colRate1.Caption = "Alış"
        Me.colRate1.DisplayFormat.FormatString = "#,##0.0000"
        Me.colRate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRate1.FieldName = "Rate1"
        Me.colRate1.Name = "colRate1"
        Me.colRate1.Visible = True
        Me.colRate1.VisibleIndex = 2
        '
        'colRate2
        '
        Me.colRate2.Caption = "Satış"
        Me.colRate2.DisplayFormat.FormatString = "#,##0.0000"
        Me.colRate2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRate2.FieldName = "Rate2"
        Me.colRate2.Name = "colRate2"
        Me.colRate2.Visible = True
        Me.colRate2.VisibleIndex = 3
        '
        'colRate3
        '
        Me.colRate3.Caption = "Efektif Alış"
        Me.colRate3.DisplayFormat.FormatString = "#,##0.0000"
        Me.colRate3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRate3.FieldName = "Rate3"
        Me.colRate3.Name = "colRate3"
        Me.colRate3.Visible = True
        Me.colRate3.VisibleIndex = 4
        '
        'colRate4
        '
        Me.colRate4.Caption = "Efektif Satış"
        Me.colRate4.DisplayFormat.FormatString = "#,##0.0000"
        Me.colRate4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRate4.FieldName = "Rate4"
        Me.colRate4.Name = "colRate4"
        Me.colRate4.Visible = True
        Me.colRate4.VisibleIndex = 5
        '
        'btnDownloadDovzKur
        '
        Me.btnDownloadDovzKur.Location = New System.Drawing.Point(634, 6)
        Me.btnDownloadDovzKur.Name = "btnDownloadDovzKur"
        Me.btnDownloadDovzKur.Size = New System.Drawing.Size(162, 46)
        Me.btnDownloadDovzKur.TabIndex = 14
        Me.btnDownloadDovzKur.Text = "TCMB Doviz Kurlarini indir"
        '
        'frmDovizKurlari
        '
        Me.ClientSize = New System.Drawing.Size(893, 491)
        Me.FormCode = "000031"
        Me.Name = "frmDovizKurlari"
        Me.Text = "Döviz Kurları"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.txtTopInfo, 0)
        Me.Controls.SetChildIndex(Me.panelFormTop, 0)
        Me.Controls.SetChildIndex(Me.panelBottom, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.BaseTab1.ResumeLayout(False)
        Me.BaseTab2.ResumeLayout(False)
        Me.BaseTab2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.basePanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.basePanelControl3.ResumeLayout(False)
        CType(Me.panelFormTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupDocumentView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailLink5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelAuthCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAuthCodes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFormDateFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormDateFilter.ResumeLayout(False)
        CType(Me.chkDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFormDate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDetailTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As SqlClient.SqlCommand
    Friend WithEvents MasterTable_ID As DataColumn
    Friend WithEvents MasterTable_CreatedBy As DataColumn
    Friend WithEvents MasterTable_CreatedDate As DataColumn
    Friend WithEvents MasterTable_ModifiedBy As DataColumn
    Friend WithEvents MasterTable_ModifiedDate As DataColumn
    Friend WithEvents MasterTable_CurrDate As DataColumn
    Friend WithEvents MasterTable_Curr As DataColumn
    Friend WithEvents MasterTable_Rate1 As DataColumn
    Friend WithEvents MasterTable_Rate2 As DataColumn
    Friend WithEvents MasterTable_Rate3 As DataColumn
    Friend WithEvents MasterTable_Rate4 As DataColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDownloadDovzKur As DevExpress.XtraEditors.SimpleButton
End Class
