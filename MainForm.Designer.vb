'
' Created by SharpDevelop.
' User: lopeze
' Date: 21/12/2015
' Time: 15:59
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.tabCtl = New System.Windows.Forms.TabControl()
		Me.tabPgSQL = New System.Windows.Forms.TabPage()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.btnConnect = New System.Windows.Forms.Button()
		Me.btnExec = New System.Windows.Forms.Button()
		Me.btnScriptPath = New System.Windows.Forms.Button()
		Me.txtScript = New System.Windows.Forms.TextBox()
		Me.lblScript = New System.Windows.Forms.Label()
		Me.cbxDatabase = New System.Windows.Forms.ComboBox()
		Me.txtPass = New System.Windows.Forms.TextBox()
		Me.txtUser = New System.Windows.Forms.TextBox()
		Me.lblPasswd = New System.Windows.Forms.Label()
		Me.lblUser = New System.Windows.Forms.Label()
		Me.lblDatabase = New System.Windows.Forms.Label()
		Me.txtLogSQL = New System.Windows.Forms.TextBox()
		Me.cbxServer = New System.Windows.Forms.ComboBox()
		Me.lblServer = New System.Windows.Forms.Label()
		Me.tabPgWeb = New System.Windows.Forms.TabPage()
		Me.btnUnzip = New System.Windows.Forms.Button()
		Me.txtLogZip = New System.Windows.Forms.TextBox()
		Me.btnDest = New System.Windows.Forms.Button()
		Me.btnZip = New System.Windows.Forms.Button()
		Me.txtDest = New System.Windows.Forms.TextBox()
		Me.txtZip = New System.Windows.Forms.TextBox()
		Me.lblDest = New System.Windows.Forms.Label()
		Me.lblZip = New System.Windows.Forms.Label()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.btnQuit = New System.Windows.Forms.Button()
		Me.tabCtl.SuspendLayout
		Me.tabPgSQL.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPgWeb.SuspendLayout
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'tabCtl
		'
		Me.tabCtl.Controls.Add(Me.tabPgSQL)
		Me.tabCtl.Controls.Add(Me.tabPgWeb)
		Me.tabCtl.Location = New System.Drawing.Point(12, 12)
		Me.tabCtl.Name = "tabCtl"
		Me.tabCtl.SelectedIndex = 0
		Me.tabCtl.Size = New System.Drawing.Size(447, 416)
		Me.tabCtl.TabIndex = 0
		'
		'tabPgSQL
		'
		Me.tabPgSQL.Controls.Add(Me.pictureBox1)
		Me.tabPgSQL.Controls.Add(Me.btnConnect)
		Me.tabPgSQL.Controls.Add(Me.btnExec)
		Me.tabPgSQL.Controls.Add(Me.btnScriptPath)
		Me.tabPgSQL.Controls.Add(Me.txtScript)
		Me.tabPgSQL.Controls.Add(Me.lblScript)
		Me.tabPgSQL.Controls.Add(Me.cbxDatabase)
		Me.tabPgSQL.Controls.Add(Me.txtPass)
		Me.tabPgSQL.Controls.Add(Me.txtUser)
		Me.tabPgSQL.Controls.Add(Me.lblPasswd)
		Me.tabPgSQL.Controls.Add(Me.lblUser)
		Me.tabPgSQL.Controls.Add(Me.lblDatabase)
		Me.tabPgSQL.Controls.Add(Me.txtLogSQL)
		Me.tabPgSQL.Controls.Add(Me.cbxServer)
		Me.tabPgSQL.Controls.Add(Me.lblServer)
		Me.tabPgSQL.Location = New System.Drawing.Point(4, 22)
		Me.tabPgSQL.Name = "tabPgSQL"
		Me.tabPgSQL.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPgSQL.Size = New System.Drawing.Size(439, 390)
		Me.tabPgSQL.TabIndex = 0
		Me.tabPgSQL.Text = "Scripts SQL"
		Me.tabPgSQL.UseVisualStyleBackColor = true
		'
		'pictureBox1
		'
		Me.pictureBox1.ErrorImage = Nothing
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.InitialImage = Nothing
		Me.pictureBox1.Location = New System.Drawing.Point(7, 1)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(430, 80)
		Me.pictureBox1.TabIndex = 49
		Me.pictureBox1.TabStop = false
		'
		'btnConnect
		'
		Me.btnConnect.Enabled = false
		Me.btnConnect.Location = New System.Drawing.Point(341, 100)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(73, 26)
		Me.btnConnect.TabIndex = 48
		Me.btnConnect.Text = "Connecter"
		Me.btnConnect.UseVisualStyleBackColor = true
		AddHandler Me.btnConnect.Click, AddressOf Me.BtnConnectClick
		'
		'btnExec
		'
		Me.btnExec.Enabled = false
		Me.btnExec.Location = New System.Drawing.Point(341, 233)
		Me.btnExec.Name = "btnExec"
		Me.btnExec.Size = New System.Drawing.Size(73, 26)
		Me.btnExec.TabIndex = 47
		Me.btnExec.Text = "Exécuter"
		Me.btnExec.UseVisualStyleBackColor = true
		AddHandler Me.btnExec.Click, AddressOf Me.BtnExecClick
		'
		'btnScriptPath
		'
		Me.btnScriptPath.Enabled = false
		Me.btnScriptPath.Location = New System.Drawing.Point(93, 237)
		Me.btnScriptPath.Name = "btnScriptPath"
		Me.btnScriptPath.Size = New System.Drawing.Size(34, 23)
		Me.btnScriptPath.TabIndex = 46
		Me.btnScriptPath.Text = "..."
		Me.btnScriptPath.UseVisualStyleBackColor = true
		AddHandler Me.btnScriptPath.Click, AddressOf Me.BtnScriptPathClick
		'
		'txtScript
		'
		Me.txtScript.Enabled = false
		Me.txtScript.Location = New System.Drawing.Point(133, 237)
		Me.txtScript.Name = "txtScript"
		Me.txtScript.Size = New System.Drawing.Size(202, 20)
		Me.txtScript.TabIndex = 45
		AddHandler Me.txtScript.TextChanged, AddressOf Me.TxtScriptTextChanged
		'
		'lblScript
		'
		Me.lblScript.Location = New System.Drawing.Point(27, 242)
		Me.lblScript.Name = "lblScript"
		Me.lblScript.Size = New System.Drawing.Size(100, 23)
		Me.lblScript.TabIndex = 44
		Me.lblScript.Text = "Script SQL : "
		'
		'cbxDatabase
		'
		Me.cbxDatabase.Enabled = false
		Me.cbxDatabase.FormattingEnabled = true
		Me.cbxDatabase.Location = New System.Drawing.Point(133, 140)
		Me.cbxDatabase.Name = "cbxDatabase"
		Me.cbxDatabase.Size = New System.Drawing.Size(202, 21)
		Me.cbxDatabase.TabIndex = 43
		AddHandler Me.cbxDatabase.SelectedIndexChanged, AddressOf Me.CbxDatabaseSelectedIndexChanged
		'
		'txtPass
		'
		Me.txtPass.Enabled = false
		Me.txtPass.Location = New System.Drawing.Point(133, 203)
		Me.txtPass.Name = "txtPass"
		Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
		Me.txtPass.Size = New System.Drawing.Size(202, 20)
		Me.txtPass.TabIndex = 42
		'
		'txtUser
		'
		Me.txtUser.Enabled = false
		Me.txtUser.Location = New System.Drawing.Point(133, 171)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(202, 20)
		Me.txtUser.TabIndex = 41
		'
		'lblPasswd
		'
		Me.lblPasswd.Location = New System.Drawing.Point(27, 203)
		Me.lblPasswd.Name = "lblPasswd"
		Me.lblPasswd.Size = New System.Drawing.Size(100, 23)
		Me.lblPasswd.TabIndex = 40
		Me.lblPasswd.Text = "Mot de passe : "
		'
		'lblUser
		'
		Me.lblUser.Location = New System.Drawing.Point(27, 174)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(100, 26)
		Me.lblUser.TabIndex = 39
		Me.lblUser.Text = "Utilisateur : "
		'
		'lblDatabase
		'
		Me.lblDatabase.Location = New System.Drawing.Point(27, 143)
		Me.lblDatabase.Name = "lblDatabase"
		Me.lblDatabase.Size = New System.Drawing.Size(100, 23)
		Me.lblDatabase.TabIndex = 38
		Me.lblDatabase.Text = "Base de données : "
		'
		'txtLogSQL
		'
		Me.txtLogSQL.AcceptsReturn = true
		Me.txtLogSQL.Location = New System.Drawing.Point(27, 268)
		Me.txtLogSQL.Multiline = true
		Me.txtLogSQL.Name = "txtLogSQL"
		Me.txtLogSQL.ReadOnly = true
		Me.txtLogSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtLogSQL.Size = New System.Drawing.Size(387, 95)
		Me.txtLogSQL.TabIndex = 28
		'
		'cbxServer
		'
		Me.cbxServer.FormattingEnabled = true
		Me.cbxServer.Location = New System.Drawing.Point(133, 104)
		Me.cbxServer.Name = "cbxServer"
		Me.cbxServer.Size = New System.Drawing.Size(202, 21)
		Me.cbxServer.TabIndex = 19
		AddHandler Me.cbxServer.SelectedIndexChanged, AddressOf Me.CbxServerSelectedIndexChanged
		'
		'lblServer
		'
		Me.lblServer.Location = New System.Drawing.Point(27, 104)
		Me.lblServer.Name = "lblServer"
		Me.lblServer.Size = New System.Drawing.Size(63, 23)
		Me.lblServer.TabIndex = 15
		Me.lblServer.Text = "Serveur : "
		'
		'tabPgWeb
		'
		Me.tabPgWeb.Controls.Add(Me.btnUnzip)
		Me.tabPgWeb.Controls.Add(Me.txtLogZip)
		Me.tabPgWeb.Controls.Add(Me.btnDest)
		Me.tabPgWeb.Controls.Add(Me.btnZip)
		Me.tabPgWeb.Controls.Add(Me.txtDest)
		Me.tabPgWeb.Controls.Add(Me.txtZip)
		Me.tabPgWeb.Controls.Add(Me.lblDest)
		Me.tabPgWeb.Controls.Add(Me.lblZip)
		Me.tabPgWeb.Controls.Add(Me.pictureBox2)
		Me.tabPgWeb.Location = New System.Drawing.Point(4, 22)
		Me.tabPgWeb.Name = "tabPgWeb"
		Me.tabPgWeb.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPgWeb.Size = New System.Drawing.Size(439, 390)
		Me.tabPgWeb.TabIndex = 1
		Me.tabPgWeb.Text = "Web"
		Me.tabPgWeb.UseVisualStyleBackColor = true
		'
		'btnUnzip
		'
		Me.btnUnzip.Location = New System.Drawing.Point(271, 223)
		Me.btnUnzip.Name = "btnUnzip"
		Me.btnUnzip.Size = New System.Drawing.Size(73, 26)
		Me.btnUnzip.TabIndex = 58
		Me.btnUnzip.Text = "Exécuter"
		Me.btnUnzip.UseVisualStyleBackColor = true
		AddHandler Me.btnUnzip.Click, AddressOf Me.BtnUnzipClick
		'
		'txtLogZip
		'
		Me.txtLogZip.AcceptsReturn = true
		Me.txtLogZip.Location = New System.Drawing.Point(27, 268)
		Me.txtLogZip.Multiline = true
		Me.txtLogZip.Name = "txtLogZip"
		Me.txtLogZip.ReadOnly = true
		Me.txtLogZip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtLogZip.Size = New System.Drawing.Size(387, 95)
		Me.txtLogZip.TabIndex = 57
		'
		'btnDest
		'
		Me.btnDest.Location = New System.Drawing.Point(351, 182)
		Me.btnDest.Name = "btnDest"
		Me.btnDest.Size = New System.Drawing.Size(48, 23)
		Me.btnDest.TabIndex = 56
		Me.btnDest.Text = "..."
		Me.btnDest.UseVisualStyleBackColor = true
		AddHandler Me.btnDest.Click, AddressOf Me.BtnDestClick
		'
		'btnZip
		'
		Me.btnZip.Location = New System.Drawing.Point(350, 140)
		Me.btnZip.Name = "btnZip"
		Me.btnZip.Size = New System.Drawing.Size(48, 23)
		Me.btnZip.TabIndex = 55
		Me.btnZip.Text = "..."
		Me.btnZip.UseVisualStyleBackColor = true
		AddHandler Me.btnZip.Click, AddressOf Me.BtnZipClick
		'
		'txtDest
		'
		Me.txtDest.Location = New System.Drawing.Point(119, 185)
		Me.txtDest.Name = "txtDest"
		Me.txtDest.Size = New System.Drawing.Size(225, 20)
		Me.txtDest.TabIndex = 54
		'
		'txtZip
		'
		Me.txtZip.Location = New System.Drawing.Point(119, 143)
		Me.txtZip.Name = "txtZip"
		Me.txtZip.Size = New System.Drawing.Size(225, 20)
		Me.txtZip.TabIndex = 53
		'
		'lblDest
		'
		Me.lblDest.Location = New System.Drawing.Point(41, 188)
		Me.lblDest.Name = "lblDest"
		Me.lblDest.Size = New System.Drawing.Size(72, 18)
		Me.lblDest.TabIndex = 52
		Me.lblDest.Text = "Destination : "
		'
		'lblZip
		'
		Me.lblZip.Location = New System.Drawing.Point(41, 146)
		Me.lblZip.Name = "lblZip"
		Me.lblZip.Size = New System.Drawing.Size(54, 17)
		Me.lblZip.TabIndex = 51
		Me.lblZip.Text = "Archive : "
		'
		'pictureBox2
		'
		Me.pictureBox2.ErrorImage = Nothing
		Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
		Me.pictureBox2.InitialImage = Nothing
		Me.pictureBox2.Location = New System.Drawing.Point(-1, 7)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(430, 80)
		Me.pictureBox2.TabIndex = 50
		Me.pictureBox2.TabStop = false
		'
		'btnQuit
		'
		Me.btnQuit.Location = New System.Drawing.Point(337, 434)
		Me.btnQuit.Name = "btnQuit"
		Me.btnQuit.Size = New System.Drawing.Size(84, 33)
		Me.btnQuit.TabIndex = 26
		Me.btnQuit.Text = "Quitter"
		Me.btnQuit.UseVisualStyleBackColor = true
		AddHandler Me.btnQuit.Click, AddressOf Me.BtnQuitClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(468, 473)
		Me.Controls.Add(Me.tabCtl)
		Me.Controls.Add(Me.btnQuit)
		Me.Name = "MainForm"
		Me.Text = "MaEVA - Déploiement SQL"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.tabCtl.ResumeLayout(false)
		Me.tabPgSQL.ResumeLayout(false)
		Me.tabPgSQL.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPgWeb.ResumeLayout(false)
		Me.tabPgWeb.PerformLayout
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private txtLogZip As System.Windows.Forms.TextBox
	Private btnUnzip As System.Windows.Forms.Button
	Private btnZip As System.Windows.Forms.Button
	Private btnDest As System.Windows.Forms.Button
	Private lblZip As System.Windows.Forms.Label
	Private lblDest As System.Windows.Forms.Label
	Private txtZip As System.Windows.Forms.TextBox
	Private txtDest As System.Windows.Forms.TextBox
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private btnConnect As System.Windows.Forms.Button
	Private txtLogSQL As System.Windows.Forms.TextBox
	Private tabPgWeb As System.Windows.Forms.TabPage
	Private tabPgSQL As System.Windows.Forms.TabPage
	Private tabCtl As System.Windows.Forms.TabControl
	Private btnExec As System.Windows.Forms.Button
	Private btnQuit As System.Windows.Forms.Button
	Private btnScriptPath As System.Windows.Forms.Button
	Private txtScript As System.Windows.Forms.TextBox
	Private lblScript As System.Windows.Forms.Label
	Private cbxDatabase As System.Windows.Forms.ComboBox
	Private txtPass As System.Windows.Forms.TextBox
	Private txtUser As System.Windows.Forms.TextBox
	Private cbxServer As System.Windows.Forms.ComboBox
	Private lblPasswd As System.Windows.Forms.Label
	Private lblUser As System.Windows.Forms.Label
	Private lblDatabase As System.Windows.Forms.Label
	Private lblServer As System.Windows.Forms.Label
	
End Class
