<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategoriItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUstKod = New DevExpress.XtraEditors.TextEdit()
        Me.txtKategoriKod = New DevExpress.XtraEditors.TextEdit()
        Me.txtKategoriIsim = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIntCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStokKodFormati = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtUstKod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKategoriKod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKategoriIsim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokKodFormati.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(435, 157)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 34)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Kaydet"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(528, 157)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(87, 34)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "VazgeÃ§"
        '
        'txtUstKod
        '
        Me.txtUstKod.EnterMoveNextControl = True
        Me.txtUstKod.Location = New System.Drawing.Point(101, 12)
        Me.txtUstKod.Name = "txtUstKod"
        Me.txtUstKod.Properties.ReadOnly = True
        Me.txtUstKod.Size = New System.Drawing.Size(83, 20)
        Me.txtUstKod.TabIndex = 0
        '
        'txtKategoriKod
        '
        Me.txtKategoriKod.EnterMoveNextControl = True
        Me.txtKategoriKod.Location = New System.Drawing.Point(101, 38)
        Me.txtKategoriKod.Name = "txtKategoriKod"
        Me.txtKategoriKod.Size = New System.Drawing.Size(166, 20)
        Me.txtKategoriKod.TabIndex = 1
        '
        'txtKategoriIsim
        '
        Me.txtKategoriIsim.EnterMoveNextControl = True
        Me.txtKategoriIsim.Location = New System.Drawing.Point(101, 64)
        Me.txtKategoriIsim.Name = "txtKategoriIsim"
        Me.txtKategoriIsim.Properties.MaxLength = 100
        Me.txtKategoriIsim.Size = New System.Drawing.Size(514, 20)
        Me.txtKategoriIsim.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Ust Kategori"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Kategori Kod"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(3, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Kategori Ismi"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 118)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Entegrasyon Kodu"
        '
        'txtIntCode
        '
        Me.txtIntCode.EnterMoveNextControl = True
        Me.txtIntCode.Location = New System.Drawing.Point(101, 115)
        Me.txtIntCode.Name = "txtIntCode"
        Me.txtIntCode.Size = New System.Drawing.Size(166, 20)
        Me.txtIntCode.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 93)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Stok Kod Formati"
        '
        'txtStokKodFormati
        '
        Me.txtStokKodFormati.EnterMoveNextControl = True
        Me.txtStokKodFormati.Location = New System.Drawing.Point(101, 90)
        Me.txtStokKodFormati.Name = "txtStokKodFormati"
        Me.txtStokKodFormati.Size = New System.Drawing.Size(166, 20)
        Me.txtStokKodFormati.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(273, 114)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(49, 22)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "..."
        '
        'frmKategoriItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(636, 203)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtStokKodFormati)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtIntCode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtKategoriIsim)
        Me.Controls.Add(Me.txtKategoriKod)
        Me.Controls.Add(Me.txtUstKod)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKategoriItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategori"
        CType(Me.txtUstKod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKategoriKod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKategoriIsim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokKodFormati.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUstKod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKategoriKod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKategoriIsim As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIntCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStokKodFormati As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
