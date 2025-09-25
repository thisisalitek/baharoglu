<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportSelect))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.conMenuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.conMenuSetDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.conMenuNewReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.conMenuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.conMenuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.conMenuExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TEXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MHTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextFormatRTFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.conMenuDesignExportImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.conMenuDesingExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.conMenuDesingImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSetDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuNewReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExportReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportHTML = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportTEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportCSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportMHT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportRTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDesignExportImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDesingExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDesingImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog()
        Me.dlgDesingExport = New System.Windows.Forms.SaveFileDialog()
        Me.dlgDesingImport = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(444, 273)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.conMenuPrint, Me.ToolStripMenuItem4, Me.conMenuSetDefault, Me.ToolStripMenuItem6, Me.conMenuNewReport, Me.conMenuEdit, Me.conMenuDelete, Me.ToolStripMenuItem5, Me.conMenuExport, Me.ToolStripMenuItem7, Me.conMenuDesignExportImport})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 182)
        '
        'conMenuPrint
        '
        Me.conMenuPrint.Name = "conMenuPrint"
        Me.conMenuPrint.Size = New System.Drawing.Size(217, 22)
        Me.conMenuPrint.Text = "Yazdır"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(214, 6)
        '
        'conMenuSetDefault
        '
        Me.conMenuSetDefault.Name = "conMenuSetDefault"
        Me.conMenuSetDefault.Size = New System.Drawing.Size(217, 22)
        Me.conMenuSetDefault.Text = "* Varsayılan Olarak İşaretle"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(214, 6)
        '
        'conMenuNewReport
        '
        Me.conMenuNewReport.Name = "conMenuNewReport"
        Me.conMenuNewReport.Size = New System.Drawing.Size(217, 22)
        Me.conMenuNewReport.Text = "Yeni"
        '
        'conMenuEdit
        '
        Me.conMenuEdit.Name = "conMenuEdit"
        Me.conMenuEdit.Size = New System.Drawing.Size(217, 22)
        Me.conMenuEdit.Text = "Düzenle"
        '
        'conMenuDelete
        '
        Me.conMenuDelete.Name = "conMenuDelete"
        Me.conMenuDelete.Size = New System.Drawing.Size(217, 22)
        Me.conMenuDelete.Text = "Sil"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(214, 6)
        '
        'conMenuExport
        '
        Me.conMenuExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.HTMLToolStripMenuItem, Me.PDFToolStripMenuItem, Me.TEXTToolStripMenuItem, Me.CSVToolStripMenuItem, Me.ImageToolStripMenuItem, Me.MHTToolStripMenuItem, Me.RichTextFormatRTFToolStripMenuItem})
        Me.conMenuExport.Name = "conMenuExport"
        Me.conMenuExport.Size = New System.Drawing.Size(217, 22)
        Me.conMenuExport.Text = "Export"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'HTMLToolStripMenuItem
        '
        Me.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem"
        Me.HTMLToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.HTMLToolStripMenuItem.Text = "HTML"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'TEXTToolStripMenuItem
        '
        Me.TEXTToolStripMenuItem.Name = "TEXTToolStripMenuItem"
        Me.TEXTToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TEXTToolStripMenuItem.Text = "TEXT"
        '
        'CSVToolStripMenuItem
        '
        Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CSVToolStripMenuItem.Text = "CSV"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'MHTToolStripMenuItem
        '
        Me.MHTToolStripMenuItem.Name = "MHTToolStripMenuItem"
        Me.MHTToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MHTToolStripMenuItem.Text = "MHT"
        '
        'RichTextFormatRTFToolStripMenuItem
        '
        Me.RichTextFormatRTFToolStripMenuItem.Name = "RichTextFormatRTFToolStripMenuItem"
        Me.RichTextFormatRTFToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RichTextFormatRTFToolStripMenuItem.Text = "Rich Text Format (RTF)"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(214, 6)
        '
        'conMenuDesignExportImport
        '
        Me.conMenuDesignExportImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.conMenuDesingExport, Me.conMenuDesingImport})
        Me.conMenuDesignExportImport.Name = "conMenuDesignExportImport"
        Me.conMenuDesignExportImport.Size = New System.Drawing.Size(217, 22)
        Me.conMenuDesignExportImport.Text = "Tasarım Export/Import"
        '
        'conMenuDesingExport
        '
        Me.conMenuDesingExport.Name = "conMenuDesingExport"
        Me.conMenuDesingExport.Size = New System.Drawing.Size(171, 22)
        Me.conMenuDesingExport.Text = "Tasarımı Dışarı Ver"
        '
        'conMenuDesingImport
        '
        Me.conMenuDesingImport.Name = "conMenuDesingImport"
        Me.conMenuDesingImport.Size = New System.Drawing.Size(171, 22)
        Me.conMenuDesingImport.Text = "Tasarımı İçeri Al"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "V"
        Me.GridColumn2.FieldName = "sDefault"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 35
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Rapor Ismi"
        Me.GridColumn1.FieldName = "ReportName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 311
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "bDefault"
        Me.GridColumn3.FieldName = "bDefault"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tip"
        Me.GridColumn4.FieldName = "sReportType"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 52
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(444, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrint, Me.ToolStripMenuItem1, Me.mnuSetDefault, Me.ToolStripMenuItem8, Me.mnuNewReport, Me.mnuEditReport, Me.mnuDeleteReport, Me.ToolStripMenuItem2, Me.mnuExportReport, Me.ToolStripMenuItem9, Me.mnuDesignExportImport, Me.ToolStripMenuItem3, Me.mnuClose})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(212, 22)
        Me.mnuPrint.Text = "Yazdır"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuSetDefault
        '
        Me.mnuSetDefault.Name = "mnuSetDefault"
        Me.mnuSetDefault.Size = New System.Drawing.Size(212, 22)
        Me.mnuSetDefault.Text = "* Varsayılan Olarak İşaretle"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(209, 6)
        '
        'mnuNewReport
        '
        Me.mnuNewReport.Name = "mnuNewReport"
        Me.mnuNewReport.Size = New System.Drawing.Size(212, 22)
        Me.mnuNewReport.Text = "Yeni"
        '
        'mnuEditReport
        '
        Me.mnuEditReport.Name = "mnuEditReport"
        Me.mnuEditReport.Size = New System.Drawing.Size(212, 22)
        Me.mnuEditReport.Text = "Düzenle"
        '
        'mnuDeleteReport
        '
        Me.mnuDeleteReport.Name = "mnuDeleteReport"
        Me.mnuDeleteReport.Size = New System.Drawing.Size(212, 22)
        Me.mnuDeleteReport.Text = "Sil"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuExportReport
        '
        Me.mnuExportReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportExcel, Me.mnuExportHTML, Me.mnuExportPDF, Me.mnuExportTEXT, Me.mnuExportCSV, Me.mnuExportImage, Me.mnuExportMHT, Me.mnuExportRTF})
        Me.mnuExportReport.Name = "mnuExportReport"
        Me.mnuExportReport.Size = New System.Drawing.Size(212, 22)
        Me.mnuExportReport.Text = "Export"
        '
        'mnuExportExcel
        '
        Me.mnuExportExcel.Name = "mnuExportExcel"
        Me.mnuExportExcel.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportExcel.Text = "Excel"
        '
        'mnuExportHTML
        '
        Me.mnuExportHTML.Name = "mnuExportHTML"
        Me.mnuExportHTML.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportHTML.Text = "HTML"
        '
        'mnuExportPDF
        '
        Me.mnuExportPDF.Name = "mnuExportPDF"
        Me.mnuExportPDF.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportPDF.Text = "PDF"
        '
        'mnuExportTEXT
        '
        Me.mnuExportTEXT.Name = "mnuExportTEXT"
        Me.mnuExportTEXT.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportTEXT.Text = "TEXT"
        '
        'mnuExportCSV
        '
        Me.mnuExportCSV.Name = "mnuExportCSV"
        Me.mnuExportCSV.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportCSV.Text = "CSV"
        '
        'mnuExportImage
        '
        Me.mnuExportImage.Name = "mnuExportImage"
        Me.mnuExportImage.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportImage.Text = "Image"
        '
        'mnuExportMHT
        '
        Me.mnuExportMHT.Name = "mnuExportMHT"
        Me.mnuExportMHT.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportMHT.Text = "MHT"
        '
        'mnuExportRTF
        '
        Me.mnuExportRTF.Name = "mnuExportRTF"
        Me.mnuExportRTF.Size = New System.Drawing.Size(194, 22)
        Me.mnuExportRTF.Text = "Rich Text Format (RTF)"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(209, 6)
        '
        'mnuDesignExportImport
        '
        Me.mnuDesignExportImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDesingExport, Me.mnuDesingImport})
        Me.mnuDesignExportImport.Name = "mnuDesignExportImport"
        Me.mnuDesignExportImport.Size = New System.Drawing.Size(212, 22)
        Me.mnuDesignExportImport.Text = "Tasarım Export/Import"
        '
        'mnuDesingExport
        '
        Me.mnuDesingExport.Name = "mnuDesingExport"
        Me.mnuDesingExport.Size = New System.Drawing.Size(165, 22)
        Me.mnuDesingExport.Text = "Tasarımı Dışarı Al"
        '
        'mnuDesingImport
        '
        Me.mnuDesingImport.Name = "mnuDesingImport"
        Me.mnuDesingImport.Size = New System.Drawing.Size(165, 22)
        Me.mnuDesingImport.Text = "Tasarımı İçeri Al"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(209, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(212, 22)
        Me.mnuClose.Text = "Çıkış"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 297)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(444, 41)
        Me.PanelControl1.TabIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.cmdClose)
        Me.PanelControl2.Controls.Add(Me.cmdPrint)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(257, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(183, 32)
        Me.PanelControl2.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(93, 3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(82, 32)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "Kapat"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(5, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(82, 32)
        Me.cmdPrint.TabIndex = 0
        Me.cmdPrint.Text = "Yazdır (F2)"
        '
        'dlgDesingExport
        '
        Me.dlgDesingExport.DefaultExt = "xml"
        Me.dlgDesingExport.Filter = "Xml Dosyaları (*.xml)|*.xml|Tüm Dosyalar (*.*)|*.*"
        Me.dlgDesingExport.FilterIndex = 0
        '
        'dlgDesingImport
        '
        Me.dlgDesingImport.DefaultExt = "xml"
        Me.dlgDesingImport.Filter = "Xml Dosyaları (*.xml)|*.xml|Tüm Dosyalar (*.*)|*.*"
        Me.dlgDesingImport.FilterIndex = 0
        '
        'frmReportSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 338)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReportSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapor Seç"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuNewReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeleteReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExportReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents conMenuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents conMenuNewReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents conMenuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents conMenuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents conMenuExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgExport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents mnuExportExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportTEXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportCSV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportMHT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportRTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TEXTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MHTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextFormatRTFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents conMenuSetDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents conMenuDesignExportImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents conMenuDesingExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents conMenuDesingImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDesignExportImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDesingExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDesingImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgDesingExport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgDesingImport As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
