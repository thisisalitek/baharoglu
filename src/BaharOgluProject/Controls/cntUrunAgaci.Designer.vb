<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntUrunAgaci
    Inherits System.Windows.Forms.UserControl



    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cntUrunAgaci))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.YenileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AltKodEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RootKategoriEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuzelt = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuKategoriOzellikKopyala = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKategoriOzellikYapistir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panelKategoriArama = New System.Windows.Forms.Panel()
        Me.txtKategoriArama = New DevExpress.XtraEditors.TextEdit()
        Me.cmdKategoriBul = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAktifKategori = New DevExpress.XtraEditors.TextEdit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.panelKategoriArama.SuspendLayout()
        CType(Me.txtKategoriArama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAktifKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 41)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(446, 450)
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YenileToolStripMenuItem, Me.ToolStripMenuItem2, Me.AltKodEkleToolStripMenuItem, Me.ToolStripMenuItem4, Me.RootKategoriEkleToolStripMenuItem, Me.mnuDuzelt, Me.SilToolStripMenuItem, Me.ToolStripMenuItem1, Me.mnuKategoriOzellikKopyala, Me.mnuKategoriOzellikYapistir})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 176)
        '
        'YenileToolStripMenuItem
        '
        Me.YenileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.YenileToolStripMenuItem.Name = "YenileToolStripMenuItem"
        Me.YenileToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.YenileToolStripMenuItem.Text = "Yenile"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(167, 6)
        '
        'AltKodEkleToolStripMenuItem
        '
        Me.AltKodEkleToolStripMenuItem.Name = "AltKodEkleToolStripMenuItem"
        Me.AltKodEkleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AltKodEkleToolStripMenuItem.Text = "Alt Kod Ekle"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(167, 6)
        '
        'RootKategoriEkleToolStripMenuItem
        '
        Me.RootKategoriEkleToolStripMenuItem.Name = "RootKategoriEkleToolStripMenuItem"
        Me.RootKategoriEkleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RootKategoriEkleToolStripMenuItem.Text = "Root Kategori Ekle"
        '
        'mnuDuzelt
        '
        Me.mnuDuzelt.Name = "mnuDuzelt"
        Me.mnuDuzelt.Size = New System.Drawing.Size(170, 22)
        Me.mnuDuzelt.Text = "Düzelt"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 6)
        '
        'mnuKategoriOzellikKopyala
        '
        Me.mnuKategoriOzellikKopyala.Name = "mnuKategoriOzellikKopyala"
        Me.mnuKategoriOzellikKopyala.Size = New System.Drawing.Size(170, 22)
        Me.mnuKategoriOzellikKopyala.Text = "Özellikleri Kopyala"
        '
        'mnuKategoriOzellikYapistir
        '
        Me.mnuKategoriOzellikYapistir.Enabled = False
        Me.mnuKategoriOzellikYapistir.Name = "mnuKategoriOzellikYapistir"
        Me.mnuKategoriOzellikYapistir.Size = New System.Drawing.Size(170, 22)
        Me.mnuKategoriOzellikYapistir.Text = "Özellikleri Yapıştır"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.png")
        Me.ImageList1.Images.SetKeyName(1, "blog_post.png")
        Me.ImageList1.Images.SetKeyName(2, "folder_add.png")
        '
        'panelKategoriArama
        '
        Me.panelKategoriArama.Controls.Add(Me.txtKategoriArama)
        Me.panelKategoriArama.Controls.Add(Me.cmdKategoriBul)
        Me.panelKategoriArama.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelKategoriArama.Location = New System.Drawing.Point(0, 0)
        Me.panelKategoriArama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelKategoriArama.Name = "panelKategoriArama"
        Me.panelKategoriArama.Size = New System.Drawing.Size(446, 21)
        Me.panelKategoriArama.TabIndex = 7
        '
        'txtKategoriArama
        '
        Me.txtKategoriArama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKategoriArama.Location = New System.Drawing.Point(0, 0)
        Me.txtKategoriArama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKategoriArama.Name = "txtKategoriArama"
        Me.txtKategoriArama.Size = New System.Drawing.Size(404, 20)
        Me.txtKategoriArama.TabIndex = 0
        '
        'cmdKategoriBul
        '
        Me.cmdKategoriBul.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdKategoriBul.Location = New System.Drawing.Point(404, 0)
        Me.cmdKategoriBul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdKategoriBul.Name = "cmdKategoriBul"
        Me.cmdKategoriBul.Size = New System.Drawing.Size(42, 21)
        Me.cmdKategoriBul.TabIndex = 1
        Me.cmdKategoriBul.Text = "Bul"
        '
        'txtAktifKategori
        '
        Me.txtAktifKategori.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAktifKategori.Location = New System.Drawing.Point(0, 21)
        Me.txtAktifKategori.Name = "txtAktifKategori"
        Me.txtAktifKategori.Properties.ReadOnly = True
        Me.txtAktifKategori.Size = New System.Drawing.Size(446, 20)
        Me.txtAktifKategori.TabIndex = 8
        '
        'cntUrunAgaci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.txtAktifKategori)
        Me.Controls.Add(Me.panelKategoriArama)
        Me.Name = "cntUrunAgaci"
        Me.Size = New System.Drawing.Size(446, 491)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.panelKategoriArama.ResumeLayout(False)
        CType(Me.txtKategoriArama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAktifKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents panelKategoriArama As Panel
    Friend WithEvents txtKategoriArama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdKategoriBul As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAktifKategori As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents YenileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AltKodEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents RootKategoriEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDuzelt As ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuKategoriOzellikKopyala As ToolStripMenuItem
    Friend WithEvents mnuKategoriOzellikYapistir As ToolStripMenuItem
End Class
