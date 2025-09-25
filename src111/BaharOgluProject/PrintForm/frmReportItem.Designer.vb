<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportItem))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReportName = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.panelTop = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdSQL = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdDesign = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboReportType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSQL = New DevExpress.XtraEditors.MemoEdit()
        Me.panelSQL = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtParameters = New DevExpress.XtraEditors.MemoEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrintedSQL = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.txtReportName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSQL.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtParameters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtPrintedSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Rapor Ismi"
        '
        'txtReportName
        '
        Me.txtReportName.EnterMoveNextControl = True
        Me.txtReportName.Location = New System.Drawing.Point(2, 17)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(372, 20)
        Me.txtReportName.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(5, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(79, 29)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Kaydet"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(90, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(79, 29)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Vazgec"
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.PanelControl2)
        Me.panelTop.Controls.Add(Me.PanelControl1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(523, 98)
        Me.panelTop.TabIndex = 4
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cmdSQL)
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.cmdDesign)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 47)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(519, 49)
        Me.PanelControl2.TabIndex = 1
        '
        'cmdSQL
        '
        Me.cmdSQL.Image = Global.ProbarSiparis.My.Resources.Resources.EditForm
        Me.cmdSQL.Location = New System.Drawing.Point(90, 6)
        Me.cmdSQL.Name = "cmdSQL"
        Me.cmdSQL.Size = New System.Drawing.Size(54, 29)
        Me.cmdSQL.TabIndex = 4
        Me.cmdSQL.Text = "SQL"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.cmdSave)
        Me.PanelControl3.Controls.Add(Me.cmdCancel)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl3.Location = New System.Drawing.Point(340, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(177, 45)
        Me.PanelControl3.TabIndex = 0
        '
        'cmdDesign
        '
        Me.cmdDesign.Image = Global.ProbarSiparis.My.Resources.Resources.EditForm
        Me.cmdDesign.Location = New System.Drawing.Point(5, 6)
        Me.cmdDesign.Name = "cmdDesign"
        Me.cmdDesign.Size = New System.Drawing.Size(79, 29)
        Me.cmdDesign.TabIndex = 3
        Me.cmdDesign.Text = "Tasarla"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboReportType)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtReportName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(519, 45)
        Me.PanelControl1.TabIndex = 2
        '
        'cboReportType
        '
        Me.cboReportType.EnterMoveNextControl = True
        Me.cboReportType.Location = New System.Drawing.Point(380, 17)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboReportType.Properties.ReadOnly = True
        Me.cboReportType.Size = New System.Drawing.Size(100, 20)
        Me.cboReportType.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(380, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Turu"
        '
        'txtSQL
        '
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQL.Location = New System.Drawing.Point(0, 0)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSQL.Properties.Appearance.Options.UseFont = True
        Me.txtSQL.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSQL.Properties.WordWrap = False
        Me.txtSQL.Size = New System.Drawing.Size(515, 186)
        Me.txtSQL.TabIndex = 5
        '
        'panelSQL
        '
        Me.panelSQL.Controls.Add(Me.GroupControl2)
        Me.panelSQL.Controls.Add(Me.GroupControl1)
        Me.panelSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSQL.Location = New System.Drawing.Point(0, 98)
        Me.panelSQL.Name = "panelSQL"
        Me.panelSQL.Size = New System.Drawing.Size(523, 398)
        Me.panelSQL.TabIndex = 6
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SplitContainer1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 85)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(519, 311)
        Me.GroupControl2.TabIndex = 8
        Me.GroupControl2.Text = "SQL Sorgu"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtParameters)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(519, 83)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Parametreler"
        '
        'txtParameters
        '
        Me.txtParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParameters.Location = New System.Drawing.Point(2, 20)
        Me.txtParameters.Name = "txtParameters"
        Me.txtParameters.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtParameters.Properties.Appearance.Options.UseFont = True
        Me.txtParameters.Properties.ReadOnly = True
        Me.txtParameters.Properties.WordWrap = False
        Me.txtParameters.Size = New System.Drawing.Size(515, 61)
        Me.txtParameters.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 20)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSQL)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPrintedSQL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(515, 289)
        Me.SplitContainer1.SplitterDistance = 186
        Me.SplitContainer1.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl3.Size = New System.Drawing.Size(515, 17)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Yazdırıldıktan sonra çalışacak sorgu"
        '
        'txtPrintedSQL
        '
        Me.txtPrintedSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrintedSQL.Location = New System.Drawing.Point(0, 17)
        Me.txtPrintedSQL.Name = "txtPrintedSQL"
        Me.txtPrintedSQL.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPrintedSQL.Properties.Appearance.Options.UseFont = True
        Me.txtPrintedSQL.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPrintedSQL.Properties.WordWrap = False
        Me.txtPrintedSQL.Size = New System.Drawing.Size(515, 82)
        Me.txtPrintedSQL.TabIndex = 6
        '
        'frmReportItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 496)
        Me.Controls.Add(Me.panelSQL)
        Me.Controls.Add(Me.panelTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rapor Tanımı"
        CType(Me.txtReportName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSQL.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtParameters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtPrintedSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReportName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdDesign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdSQL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSQL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents panelSQL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtParameters As DevExpress.XtraEditors.MemoEdit

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboReportType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtPrintedSQL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
