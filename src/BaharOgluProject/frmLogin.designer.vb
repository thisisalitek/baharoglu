<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.cmdLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtToday = New DevExpress.XtraEditors.DateEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblVer = New DevExpress.XtraEditors.LabelControl()
        Me.chkY = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdConfig = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblProbarDB = New DevExpress.XtraEditors.LabelControl()
        Me.lblTicariDB = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dtToday.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtToday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(460, 217)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(124, 36)
        Me.cmdLogin.TabIndex = 5
        Me.cmdLogin.Text = "Giriş >>>"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(330, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Çalışma Tarihi"
        '
        'dtToday
        '
        Me.dtToday.EditValue = Nothing
        Me.dtToday.EnterMoveNextControl = True
        Me.dtToday.Location = New System.Drawing.Point(440, 59)
        Me.dtToday.Name = "dtToday"
        Me.dtToday.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dtToday.Properties.Appearance.Options.UseBackColor = True
        Me.dtToday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtToday.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtToday.Size = New System.Drawing.Size(144, 20)
        Me.dtToday.TabIndex = 0
        '
        'txtUserName
        '
        Me.txtUserName.EnterMoveNextControl = True
        Me.txtUserName.Location = New System.Drawing.Point(440, 167)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUserName.Properties.Appearance.Options.UseBackColor = True
        Me.txtUserName.Size = New System.Drawing.Size(144, 20)
        Me.txtUserName.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(330, 170)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Kullanıcı Adı"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(384, 192)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 14)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Parola"
        '
        'txtPassword
        '
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(440, 189)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(144, 20)
        Me.txtPassword.TabIndex = 4
        '
        'Timer1
        '
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl7.Location = New System.Drawing.Point(274, 196)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Version:"
        '
        'lblVer
        '
        Me.lblVer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblVer.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblVer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblVer.Location = New System.Drawing.Point(329, 196)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(66, 18)
        Me.lblVer.TabIndex = 16
        Me.lblVer.Text = "0.0.0"
        '
        'chkY
        '
        Me.chkY.Location = New System.Drawing.Point(166, 64)
        Me.chkY.Name = "chkY"
        Me.chkY.Properties.Caption = "Y"
        Me.chkY.Size = New System.Drawing.Size(38, 19)
        Me.chkY.TabIndex = 19
        Me.chkY.Visible = False
        '
        'cmdConfig
        '
        Me.cmdConfig.Image = Global.ProbarSiparis.My.Resources.Resources.btn_databases_bg
        Me.cmdConfig.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdConfig.Location = New System.Drawing.Point(330, 214)
        Me.cmdConfig.Name = "cmdConfig"
        Me.cmdConfig.Size = New System.Drawing.Size(48, 39)
        Me.cmdConfig.TabIndex = 8
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdExit.Location = New System.Drawing.Point(409, 217)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(45, 36)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "X"
        Me.cmdExit.ToolTip = "Güncelllemeler"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(329, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "DB"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(329, 127)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl5.TabIndex = 30
        Me.LabelControl5.Text = "Ticari DB"
        '
        'lblProbarDB
        '
        Me.lblProbarDB.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblProbarDB.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblProbarDB.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblProbarDB.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblProbarDB.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblProbarDB.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblProbarDB.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lblProbarDB.Location = New System.Drawing.Point(440, 85)
        Me.lblProbarDB.Name = "lblProbarDB"
        Me.lblProbarDB.Size = New System.Drawing.Size(144, 36)
        Me.lblProbarDB.TabIndex = 31
        '
        'lblTicariDB
        '
        Me.lblTicariDB.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTicariDB.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTicariDB.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblTicariDB.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblTicariDB.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblTicariDB.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTicariDB.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lblTicariDB.Location = New System.Drawing.Point(440, 125)
        Me.lblTicariDB.Name = "lblTicariDB"
        Me.lblTicariDB.Size = New System.Drawing.Size(144, 36)
        Me.lblTicariDB.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(-5, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 45)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "BAHAROĞLU MRP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.ProbarSiparis.My.Resources.Resources.background_dark_blue_darker
        Me.ClientSize = New System.Drawing.Size(596, 265)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTicariDB)
        Me.Controls.Add(Me.lblProbarDB)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdConfig)
        Me.Controls.Add(Me.chkY)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.dtToday)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piconn 2012"
        CType(Me.dtToday.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtToday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtToday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkY As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdConfig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProbarDB As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTicariDB As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
