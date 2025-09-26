<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSiparisiAc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DurumunuDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜretimHazırlıkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetUretimde = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetOrgude = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetBoyaHazirlik = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetBoyada = New System.Windows.Forms.ToolStripMenuItem()
        Me.KesimHazirlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetKesimde = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜtüdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetDepoda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetKilis = New System.Windows.Forms.ToolStripMenuItem()
        Me.FasondaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YakaÖrgüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetBitti = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSetBos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FasonFisiniAcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSiparisYaz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.KayitBilgisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoyaHazirlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckedListBoxControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(603, 401)
        Me.SplitContainer1.SplitterDistance = 264
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1ToolStripMenuItem
        '
        Me.Button1ToolStripMenuItem.Name = "Button1ToolStripMenuItem"
        Me.Button1ToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.Button1ToolStripMenuItem.Text = "Button1"
        '
        'Button2ToolStripMenuItem
        '
        Me.Button2ToolStripMenuItem.Name = "Button2ToolStripMenuItem"
        Me.Button2ToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.Button2ToolStripMenuItem.Text = "Button2"
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.CheckedListBoxControl1.Appearance.Options.UseBackColor = True
        Me.CheckedListBoxControl1.CheckOnClick = True
        Me.CheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("HAZIRLIK", "Hazırlık"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("URETIMDE", "Üretimde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("ORGUDE", "Örgüde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("BOYA-HAZIRLIK", "Boya Hazırlık"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("BOYADA", "Boyada"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("KESIM-HAZIRLIK", "Kesim Hazirlik"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("KESIMDE", "Kesimde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("UTUDE", "Ütüde"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("DEPODA", "Depoda"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("KILIS", "Kilis' te"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("FASONDA", "Fasonda"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("YAKA-ORGU", "Yaka Örgü"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("BITTI", "Bitti"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("", "{Boş}")})
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(0, 0)
        Me.CheckedListBoxControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckedListBoxControl1.MultiColumn = True
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(335, 401)
        Me.CheckedListBoxControl1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSiparisiAc, Me.ToolStripMenuItem1, Me.DurumunuDeğiştirToolStripMenuItem, Me.ToolStripMenuItem4, Me.FasonFisiniAcToolStripMenuItem, Me.ToolStripMenuItem3, Me.mnuSiparisYaz, Me.ToolStripMenuItem5, Me.KayitBilgisiToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 158)
        '
        'mnuSiparisiAc
        '
        Me.mnuSiparisiAc.Name = "mnuSiparisiAc"
        Me.mnuSiparisiAc.Size = New System.Drawing.Size(184, 26)
        Me.mnuSiparisiAc.Text = "Sipariş Fişini Aç"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 6)
        '
        'DurumunuDeğiştirToolStripMenuItem
        '
        Me.DurumunuDeğiştirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜretimHazırlıkToolStripMenuItem, Me.mnuSetUretimde, Me.mnuSetOrgude, Me.mnuSetBoyaHazirlik, Me.mnuSetBoyada, Me.KesimHazirlikToolStripMenuItem, Me.mnuSetKesimde, Me.ÜtüdeToolStripMenuItem, Me.mnuSetDepoda, Me.mnuSetKilis, Me.FasondaToolStripMenuItem, Me.YakaÖrgüToolStripMenuItem, Me.mnuSetBitti, Me.ToolStripMenuItem2, Me.mnuSetBos, Me.BoyaHazirlikToolStripMenuItem})
        Me.DurumunuDeğiştirToolStripMenuItem.Name = "DurumunuDeğiştirToolStripMenuItem"
        Me.DurumunuDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.DurumunuDeğiştirToolStripMenuItem.Text = "Durumunu Değiştir"
        '
        'ÜretimHazırlıkToolStripMenuItem
        '
        Me.ÜretimHazırlıkToolStripMenuItem.Name = "ÜretimHazırlıkToolStripMenuItem"
        Me.ÜretimHazırlıkToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÜretimHazırlıkToolStripMenuItem.Text = "Hazırlık"
        '
        'mnuSetUretimde
        '
        Me.mnuSetUretimde.Name = "mnuSetUretimde"
        Me.mnuSetUretimde.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetUretimde.Text = "Üretimde"
        '
        'mnuSetOrgude
        '
        Me.mnuSetOrgude.Name = "mnuSetOrgude"
        Me.mnuSetOrgude.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetOrgude.Text = "Örgüde"
        '
        'mnuSetBoyaHazirlik
        '
        Me.mnuSetBoyaHazirlik.Name = "mnuSetBoyaHazirlik"
        Me.mnuSetBoyaHazirlik.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetBoyaHazirlik.Text = "Boya Hazırlık"
        '
        'mnuSetBoyada
        '
        Me.mnuSetBoyada.Name = "mnuSetBoyada"
        Me.mnuSetBoyada.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetBoyada.Text = "Boyada"
        '
        'KesimHazirlikToolStripMenuItem
        '
        Me.KesimHazirlikToolStripMenuItem.Name = "KesimHazirlikToolStripMenuItem"
        Me.KesimHazirlikToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KesimHazirlikToolStripMenuItem.Text = "Kesim Hazirlik"
        '
        'mnuSetKesimde
        '
        Me.mnuSetKesimde.Name = "mnuSetKesimde"
        Me.mnuSetKesimde.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetKesimde.Text = "Kesimde"
        '
        'ÜtüdeToolStripMenuItem
        '
        Me.ÜtüdeToolStripMenuItem.Name = "ÜtüdeToolStripMenuItem"
        Me.ÜtüdeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÜtüdeToolStripMenuItem.Text = "Ütüde"
        '
        'mnuSetDepoda
        '
        Me.mnuSetDepoda.Name = "mnuSetDepoda"
        Me.mnuSetDepoda.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetDepoda.Text = "Depoda"
        '
        'mnuSetKilis
        '
        Me.mnuSetKilis.Name = "mnuSetKilis"
        Me.mnuSetKilis.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetKilis.Text = "Kilis'te"
        '
        'FasondaToolStripMenuItem
        '
        Me.FasondaToolStripMenuItem.Name = "FasondaToolStripMenuItem"
        Me.FasondaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FasondaToolStripMenuItem.Text = "Fasonda"
        '
        'YakaÖrgüToolStripMenuItem
        '
        Me.YakaÖrgüToolStripMenuItem.Name = "YakaÖrgüToolStripMenuItem"
        Me.YakaÖrgüToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YakaÖrgüToolStripMenuItem.Text = "Yaka Örgü"
        '
        'mnuSetBitti
        '
        Me.mnuSetBitti.Name = "mnuSetBitti"
        Me.mnuSetBitti.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetBitti.Text = "Bitti"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'mnuSetBos
        '
        Me.mnuSetBos.Name = "mnuSetBos"
        Me.mnuSetBos.Size = New System.Drawing.Size(180, 22)
        Me.mnuSetBos.Text = "Boş"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 6)
        '
        'FasonFisiniAcToolStripMenuItem
        '
        Me.FasonFisiniAcToolStripMenuItem.Name = "FasonFisiniAcToolStripMenuItem"
        Me.FasonFisiniAcToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.FasonFisiniAcToolStripMenuItem.Text = "Fason fisini ac"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 6)
        '
        'mnuSiparisYaz
        '
        Me.mnuSiparisYaz.Image = Global.ProbarSiparis.My.Resources.Resources.print_16
        Me.mnuSiparisYaz.Name = "mnuSiparisYaz"
        Me.mnuSiparisYaz.Size = New System.Drawing.Size(184, 26)
        Me.mnuSiparisYaz.Text = "Yazdır"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 6)
        '
        'KayitBilgisiToolStripMenuItem
        '
        Me.KayitBilgisiToolStripMenuItem.Image = Global.ProbarSiparis.My.Resources.Resources.user_16
        Me.KayitBilgisiToolStripMenuItem.Name = "KayitBilgisiToolStripMenuItem"
        Me.KayitBilgisiToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.KayitBilgisiToolStripMenuItem.Text = "Kayit bilgisi"
        '
        'BoyaHazirlikToolStripMenuItem
        '
        Me.BoyaHazirlikToolStripMenuItem.Name = "BoyaHazirlikToolStripMenuItem"
        Me.BoyaHazirlikToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BoyaHazirlikToolStripMenuItem.Text = "Boya Hazirlik"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 401)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnuSiparisiAc As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents DurumunuDeğiştirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜretimHazırlıkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSetUretimde As ToolStripMenuItem
    Friend WithEvents mnuSetOrgude As ToolStripMenuItem
    Friend WithEvents mnuSetBoyaHazirlik As ToolStripMenuItem
    Friend WithEvents mnuSetBoyada As ToolStripMenuItem
    Friend WithEvents KesimHazirlikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSetKesimde As ToolStripMenuItem
    Friend WithEvents ÜtüdeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSetDepoda As ToolStripMenuItem
    Friend WithEvents mnuSetKilis As ToolStripMenuItem
    Friend WithEvents FasondaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YakaÖrgüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSetBitti As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuSetBos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents FasonFisiniAcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents mnuSiparisYaz As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents KayitBilgisiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoyaHazirlikToolStripMenuItem As ToolStripMenuItem
End Class
