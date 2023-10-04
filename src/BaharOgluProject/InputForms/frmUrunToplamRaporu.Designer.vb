<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUrunToplamRaporu
    Inherits ProbarSiparis.frmBaseReport

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim KategoriItem1 As ProbarSiparis.kategoriItem = New ProbarSiparis.kategoriItem()
        Me.CntUrunAgaci1 = New ProbarSiparis.cntUrunAgaci()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.chkShowTutar = New DevExpress.XtraEditors.CheckEdit()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.btnDur = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.chkTumAylar = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAdetFarklariGoster = New DevExpress.XtraEditors.CheckEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.chkShowFiyat = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.lblProgress = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.chkShowTutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTumAylar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAdetFarklariGoster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowFiyat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(891, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Size = New System.Drawing.Size(891, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 439)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Location = New System.Drawing.Point(891, 67)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 439)
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(215, 0)
        Me.GridControl1.Size = New System.Drawing.Size(670, 225)
        '
        'GridView1
        '
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
        Me.panelFormTop.Controls.Add(Me.ProgressBarControl1)
        Me.panelFormTop.Controls.Add(Me.lblProgress)
        Me.panelFormTop.Location = New System.Drawing.Point(0, 191)
        Me.panelFormTop.Size = New System.Drawing.Size(891, 21)
        Me.panelFormTop.Visible = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 212)
        Me.XtraTabControl1.SelectedTabPage = Me.BaseTab1
        Me.XtraTabControl1.Size = New System.Drawing.Size(891, 253)
        '
        'BaseTab1
        '
        Me.BaseTab1.Controls.Add(Me.SplitterControl1)
        Me.BaseTab1.Controls.Add(Me.CntUrunAgaci1)
        Me.BaseTab1.Size = New System.Drawing.Size(885, 225)
        Me.BaseTab1.Controls.SetChildIndex(Me.CntUrunAgaci1, 0)
        Me.BaseTab1.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.BaseTab1.Controls.SetChildIndex(Me.GridControl1, 0)
        '
        'FirmConn
        '
        Me.FirmConn.ConnectionString = "Data Source=(local)\SQL2019;Initial Catalog=ProbarSiparisDB2020;Integrated Security=True;"
        '
        'panelBottom
        '
        Me.panelBottom.Size = New System.Drawing.Size(891, 41)
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(693, 2)
        '
        'panelFormDateFilter
        '
        Me.panelFormDateFilter.Controls.Add(Me.PanelControl2)
        Me.panelFormDateFilter.Controls.Add(Me.chkShowFiyat)
        Me.panelFormDateFilter.Controls.Add(Me.RadioGroup1)
        Me.panelFormDateFilter.Controls.Add(Me.chkAdetFarklariGoster)
        Me.panelFormDateFilter.Controls.Add(Me.btnDur)
        Me.panelFormDateFilter.Controls.Add(Me.chkShowTutar)
        Me.panelFormDateFilter.Location = New System.Drawing.Point(0, 67)
        Me.panelFormDateFilter.Size = New System.Drawing.Size(891, 124)
        Me.panelFormDateFilter.Visible = True
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkShowTutar, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.btnDur, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkAdetFarklariGoster, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.RadioGroup1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkShowFiyat, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate1, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.dtFormDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.chkDate2, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.cmdRefreshList, 0)
        Me.panelFormDateFilter.Controls.SetChildIndex(Me.PanelControl2, 0)
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
        Me.TicariConn.ConnectionString = "Data Source=(local)\SQL2012;Initial Catalog=MikroDB_V14_BAHAR2019;Integrated Secu" &
    "rity=True;"
        '
        'CntUrunAgaci1
        '
        Me.CntUrunAgaci1.aktifKategori = KategoriItem1
        Me.CntUrunAgaci1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CntUrunAgaci1.Editable = True
        Me.CntUrunAgaci1.Location = New System.Drawing.Point(0, 0)
        Me.CntUrunAgaci1.Name = "CntUrunAgaci1"
        Me.CntUrunAgaci1.Size = New System.Drawing.Size(210, 225)
        Me.CntUrunAgaci1.TabIndex = 3
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(210, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 225)
        Me.SplitterControl1.TabIndex = 4
        Me.SplitterControl1.TabStop = False
        '
        'chkShowTutar
        '
        Me.chkShowTutar.EditValue = True
        Me.chkShowTutar.Location = New System.Drawing.Point(602, 36)
        Me.chkShowTutar.MenuManager = Me.BarManager1
        Me.chkShowTutar.Name = "chkShowTutar"
        Me.chkShowTutar.Properties.Caption = "Tutar Goster"
        Me.chkShowTutar.Size = New System.Drawing.Size(147, 19)
        Me.chkShowTutar.TabIndex = 13
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarControl1.Location = New System.Drawing.Point(170, 2)
        Me.ProgressBarControl1.MenuManager = Me.BarManager1
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(719, 17)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'btnDur
        '
        Me.btnDur.Image = Global.ProbarSiparis.My.Resources.Resources.Cancel01
        Me.btnDur.Location = New System.Drawing.Point(770, 6)
        Me.btnDur.Name = "btnDur"
        Me.btnDur.Size = New System.Drawing.Size(92, 47)
        Me.btnDur.TabIndex = 15
        Me.btnDur.Text = "Durdur"
        Me.btnDur.Visible = False
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(1, "Ocak"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "Subat"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(3, "Mart"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(4, "Nisan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(5, "Mayis"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(6, "Haziran"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(7, "Temmuz"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(8, "Agustos"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(9, "Eylul"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(10, "Ekim"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(11, "Kasim"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(12, "Aralik")})
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(128, 3)
        Me.CheckedListBoxControl1.MultiColumn = True
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(305, 65)
        Me.CheckedListBoxControl1.TabIndex = 16
        '
        'chkTumAylar
        '
        Me.chkTumAylar.Location = New System.Drawing.Point(129, 71)
        Me.chkTumAylar.MenuManager = Me.BarManager1
        Me.chkTumAylar.Name = "chkTumAylar"
        Me.chkTumAylar.Properties.Caption = "Tum Aylar"
        Me.chkTumAylar.Size = New System.Drawing.Size(99, 19)
        Me.chkTumAylar.TabIndex = 17
        '
        'chkAdetFarklariGoster
        '
        Me.chkAdetFarklariGoster.EditValue = True
        Me.chkAdetFarklariGoster.Location = New System.Drawing.Point(602, 64)
        Me.chkAdetFarklariGoster.MenuManager = Me.BarManager1
        Me.chkAdetFarklariGoster.Name = "chkAdetFarklariGoster"
        Me.chkAdetFarklariGoster.Properties.Caption = "Adet Farklarini Goster"
        Me.chkAdetFarklariGoster.Size = New System.Drawing.Size(147, 19)
        Me.chkAdetFarklariGoster.TabIndex = 18
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(457, 67)
        Me.RadioGroup1.MenuManager = Me.BarManager1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Teslime Göre"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Siparişe Göre")})
        Me.RadioGroup1.Size = New System.Drawing.Size(128, 52)
        Me.RadioGroup1.TabIndex = 19
        '
        'chkShowFiyat
        '
        Me.chkShowFiyat.EditValue = True
        Me.chkShowFiyat.Location = New System.Drawing.Point(602, 9)
        Me.chkShowFiyat.MenuManager = Me.BarManager1
        Me.chkShowFiyat.Name = "chkShowFiyat"
        Me.chkShowFiyat.Properties.Caption = "Fiyat Goster"
        Me.chkShowFiyat.Size = New System.Drawing.Size(147, 19)
        Me.chkShowFiyat.TabIndex = 20
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.SpinEdit2)
        Me.PanelControl2.Controls.Add(Me.SpinEdit1)
        Me.PanelControl2.Controls.Add(Me.CheckedListBoxControl1)
        Me.PanelControl2.Controls.Add(Me.chkTumAylar)
        Me.PanelControl2.Location = New System.Drawing.Point(4, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(438, 97)
        Me.PanelControl2.TabIndex = 21
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "2. Yıl"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "1. Yıl"
        '
        'SpinEdit2
        '
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(39, 27)
        Me.SpinEdit2.MenuManager = Me.BarManager1
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit2.Properties.DisplayFormat.FormatString = "0000"
        Me.SpinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Properties.EditFormat.FormatString = "0000"
        Me.SpinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Properties.IsFloatValue = False
        Me.SpinEdit2.Properties.Mask.EditMask = "0000"
        Me.SpinEdit2.Properties.MaxValue = New Decimal(New Integer() {2099, 0, 0, 0})
        Me.SpinEdit2.Properties.MinValue = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.SpinEdit2.Size = New System.Drawing.Size(83, 20)
        Me.SpinEdit2.TabIndex = 1
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(39, 5)
        Me.SpinEdit1.MenuManager = Me.BarManager1
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "0000"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatString = "0000"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.IsFloatValue = False
        Me.SpinEdit1.Properties.Mask.EditMask = "0000"
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {2099, 0, 0, 0})
        Me.SpinEdit1.Properties.MinValue = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(83, 20)
        Me.SpinEdit1.TabIndex = 0
        '
        'lblProgress
        '
        Me.lblProgress.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblProgress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblProgress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblProgress.Location = New System.Drawing.Point(2, 2)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(168, 17)
        Me.lblProgress.TabIndex = 1
        Me.lblProgress.Text = "0/0"
        '
        'frmUrunToplamRaporu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(891, 535)
        Me.FillOnFormOpening = False
        Me.FormCode = "000032"
        Me.Name = "frmUrunToplamRaporu"
        Me.Text = "Ürün Satış Raporu"
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
        CType(Me.chkShowTutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTumAylar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAdetFarklariGoster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowFiyat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents CntUrunAgaci1 As cntUrunAgaci
    Friend WithEvents chkShowTutar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btnDur As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkTumAylar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkAdetFarklariGoster As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents chkShowFiyat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblProgress As DevExpress.XtraEditors.LabelControl
End Class
