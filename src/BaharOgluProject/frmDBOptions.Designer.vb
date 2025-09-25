<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBOptions
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtServer = New DevExpress.XtraEditors.TextEdit()
        Me.txtDBUser = New DevExpress.XtraEditors.TextEdit()
        Me.txtDBPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtDatabase = New DevExpress.XtraEditors.TextEdit()
        Me.txtMikro_Database = New DevExpress.XtraEditors.TextEdit()
        Me.chkNTAuth = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdTestProbarDB = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdTestMikroDB = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtMikro_Server = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.chkMikro_NTAuth = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMikro_DBUser = New DevExpress.XtraEditors.TextEdit()
        Me.txtMikro_DBPassword = New DevExpress.XtraEditors.TextEdit()
        Me.cmdCreateDB = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDBUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDBPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMikro_Database.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNTAuth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtMikro_Server.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMikro_NTAuth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMikro_DBUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMikro_DBPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(450, 177)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 32)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Kaydet"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Server"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "DB veri tabanı"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(7, 134)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Mikro veri tabanı"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "DB User"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 98)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "DB Password"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(541, 177)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 32)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Vazgeç"
        '
        'txtServer
        '
        Me.txtServer.EnterMoveNextControl = True
        Me.txtServer.Location = New System.Drawing.Point(103, 22)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(148, 20)
        Me.txtServer.TabIndex = 0
        '
        'txtDBUser
        '
        Me.txtDBUser.EnterMoveNextControl = True
        Me.txtDBUser.Location = New System.Drawing.Point(103, 69)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(148, 20)
        Me.txtDBUser.TabIndex = 2
        '
        'txtDBPassword
        '
        Me.txtDBPassword.EnterMoveNextControl = True
        Me.txtDBPassword.Location = New System.Drawing.Point(103, 95)
        Me.txtDBPassword.Name = "txtDBPassword"
        Me.txtDBPassword.Size = New System.Drawing.Size(148, 20)
        Me.txtDBPassword.TabIndex = 3
        '
        'txtDatabase
        '
        Me.txtDatabase.EnterMoveNextControl = True
        Me.txtDatabase.Location = New System.Drawing.Point(103, 131)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(148, 20)
        Me.txtDatabase.TabIndex = 4
        '
        'txtMikro_Database
        '
        Me.txtMikro_Database.EnterMoveNextControl = True
        Me.txtMikro_Database.Location = New System.Drawing.Point(98, 127)
        Me.txtMikro_Database.Name = "txtMikro_Database"
        Me.txtMikro_Database.Size = New System.Drawing.Size(148, 20)
        Me.txtMikro_Database.TabIndex = 5
        '
        'chkNTAuth
        '
        Me.chkNTAuth.EnterMoveNextControl = True
        Me.chkNTAuth.Location = New System.Drawing.Point(101, 48)
        Me.chkNTAuth.Name = "chkNTAuth"
        Me.chkNTAuth.Properties.Caption = "NT Yetkilendirme"
        Me.chkNTAuth.Size = New System.Drawing.Size(119, 19)
        Me.chkNTAuth.TabIndex = 1
        '
        'cmdTestProbarDB
        '
        Me.cmdTestProbarDB.Location = New System.Drawing.Point(253, 130)
        Me.cmdTestProbarDB.Name = "cmdTestProbarDB"
        Me.cmdTestProbarDB.Size = New System.Drawing.Size(46, 22)
        Me.cmdTestProbarDB.TabIndex = 8
        Me.cmdTestProbarDB.Text = "> Test"
        '
        'cmdTestMikroDB
        '
        Me.cmdTestMikroDB.Location = New System.Drawing.Point(252, 125)
        Me.cmdTestMikroDB.Name = "cmdTestMikroDB"
        Me.cmdTestMikroDB.Size = New System.Drawing.Size(46, 22)
        Me.cmdTestMikroDB.TabIndex = 9
        Me.cmdTestMikroDB.Text = "> Test"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtServer)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.cmdTestProbarDB)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.chkNTAuth)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtDBUser)
        Me.GroupControl1.Controls.Add(Me.txtDatabase)
        Me.GroupControl1.Controls.Add(Me.txtDBPassword)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 7)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(306, 164)
        Me.GroupControl1.TabIndex = 10
        Me.GroupControl1.Text = "DB SQL Bağlantı"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtMikro_Server)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.chkMikro_NTAuth)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.txtMikro_DBUser)
        Me.GroupControl2.Controls.Add(Me.txtMikro_DBPassword)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.txtMikro_Database)
        Me.GroupControl2.Controls.Add(Me.cmdTestMikroDB)
        Me.GroupControl2.Location = New System.Drawing.Point(314, 7)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(312, 164)
        Me.GroupControl2.TabIndex = 11
        Me.GroupControl2.Text = "Mikro SQL Bağlantı"
        '
        'txtMikro_Server
        '
        Me.txtMikro_Server.EnterMoveNextControl = True
        Me.txtMikro_Server.Location = New System.Drawing.Point(98, 22)
        Me.txtMikro_Server.Name = "txtMikro_Server"
        Me.txtMikro_Server.Size = New System.Drawing.Size(148, 20)
        Me.txtMikro_Server.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(7, 25)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Server"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(7, 72)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "DB User"
        '
        'chkMikro_NTAuth
        '
        Me.chkMikro_NTAuth.EnterMoveNextControl = True
        Me.chkMikro_NTAuth.Location = New System.Drawing.Point(96, 48)
        Me.chkMikro_NTAuth.Name = "chkMikro_NTAuth"
        Me.chkMikro_NTAuth.Properties.Caption = "NT Yetkilendirme"
        Me.chkMikro_NTAuth.Size = New System.Drawing.Size(119, 19)
        Me.chkMikro_NTAuth.TabIndex = 11
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(7, 98)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "DB Password"
        '
        'txtMikro_DBUser
        '
        Me.txtMikro_DBUser.EnterMoveNextControl = True
        Me.txtMikro_DBUser.Location = New System.Drawing.Point(98, 69)
        Me.txtMikro_DBUser.Name = "txtMikro_DBUser"
        Me.txtMikro_DBUser.Size = New System.Drawing.Size(148, 20)
        Me.txtMikro_DBUser.TabIndex = 13
        '
        'txtMikro_DBPassword
        '
        Me.txtMikro_DBPassword.EnterMoveNextControl = True
        Me.txtMikro_DBPassword.Location = New System.Drawing.Point(98, 95)
        Me.txtMikro_DBPassword.Name = "txtMikro_DBPassword"
        Me.txtMikro_DBPassword.Size = New System.Drawing.Size(148, 20)
        Me.txtMikro_DBPassword.TabIndex = 14
        '
        'cmdCreateDB
        '
        Me.cmdCreateDB.Location = New System.Drawing.Point(14, 177)
        Me.cmdCreateDB.Name = "cmdCreateDB"
        Me.cmdCreateDB.Size = New System.Drawing.Size(151, 32)
        Me.cmdCreateDB.TabIndex = 12
        Me.cmdCreateDB.Text = "Veri Tabanı Oluştur"
        Me.cmdCreateDB.ToolTip = "Veri tabanını oluşturur. Hazırda bir veritabanı varsa onu silmez."
        '
        'frmDBOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 217)
        Me.Controls.Add(Me.cmdCreateDB)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.KeyPreview = True
        Me.Name = "frmDBOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veri Tabanı Ayarları"
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDBUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDBPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMikro_Database.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNTAuth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtMikro_Server.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMikro_NTAuth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMikro_DBUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMikro_DBPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDBUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDBPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDatabase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMikro_Database As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkNTAuth As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdTestProbarDB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTestMikroDB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMikro_Server As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMikro_NTAuth As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMikro_DBUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMikro_DBPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdCreateDB As DevExpress.XtraEditors.SimpleButton
End Class
