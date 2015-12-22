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
		Me.tabCtl = New System.Windows.Forms.TabControl()
		Me.tabPgSQL = New System.Windows.Forms.TabPage()
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
		Me.btnQuit = New System.Windows.Forms.Button()
		Me.tabCtl.SuspendLayout
		Me.tabPgSQL.SuspendLayout
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
		'btnConnect
		'
		Me.btnConnect.Enabled = false
		Me.btnConnect.Location = New System.Drawing.Point(321, 46)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(84, 26)
		Me.btnConnect.TabIndex = 48
		Me.btnConnect.Text = "Connecter"
		Me.btnConnect.UseVisualStyleBackColor = true
		AddHandler Me.btnConnect.Click, AddressOf Me.BtnConnectClick
		'
		'btnExec
		'
		Me.btnExec.Enabled = false
		Me.btnExec.Location = New System.Drawing.Point(321, 226)
		Me.btnExec.Name = "btnExec"
		Me.btnExec.Size = New System.Drawing.Size(84, 28)
		Me.btnExec.TabIndex = 47
		Me.btnExec.Text = "Exécuter"
		Me.btnExec.UseVisualStyleBackColor = true
		AddHandler Me.btnExec.Click, AddressOf Me.BtnExecClick
		'
		'btnScriptPath
		'
		Me.btnScriptPath.Enabled = false
		Me.btnScriptPath.Location = New System.Drawing.Point(93, 200)
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
		Me.txtScript.Location = New System.Drawing.Point(133, 200)
		Me.txtScript.Name = "txtScript"
		Me.txtScript.Size = New System.Drawing.Size(272, 20)
		Me.txtScript.TabIndex = 45
		'AddHandler Me.txtScript.TextChanged, AddressOf Me.TxtScript.TextChanged
		'
		'lblScript
		'
		Me.lblScript.Location = New System.Drawing.Point(27, 205)
		Me.lblScript.Name = "lblScript"
		Me.lblScript.Size = New System.Drawing.Size(100, 23)
		Me.lblScript.TabIndex = 44
		Me.lblScript.Text = "Script SQL : "
		'
		'cbxDatabase
		'
		Me.cbxDatabase.Enabled = false
		Me.cbxDatabase.FormattingEnabled = true
		Me.cbxDatabase.Location = New System.Drawing.Point(133, 103)
		Me.cbxDatabase.Name = "cbxDatabase"
		Me.cbxDatabase.Size = New System.Drawing.Size(272, 21)
		Me.cbxDatabase.TabIndex = 43
		AddHandler Me.cbxDatabase.SelectedIndexChanged, AddressOf Me.CbxDatabaseSelectedIndexChanged
		'
		'txtPass
		'
		Me.txtPass.Enabled = false
		Me.txtPass.Location = New System.Drawing.Point(133, 166)
		Me.txtPass.Name = "txtPass"
		Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(176)
		Me.txtPass.Size = New System.Drawing.Size(272, 20)
		Me.txtPass.TabIndex = 42
		'
		'txtUser
		'
		Me.txtUser.Enabled = false
		Me.txtUser.Location = New System.Drawing.Point(133, 134)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(272, 20)
		Me.txtUser.TabIndex = 41
		'
		'lblPasswd
		'
		Me.lblPasswd.Location = New System.Drawing.Point(27, 166)
		Me.lblPasswd.Name = "lblPasswd"
		Me.lblPasswd.Size = New System.Drawing.Size(100, 23)
		Me.lblPasswd.TabIndex = 40
		Me.lblPasswd.Text = "Mot de passe : "
		'
		'lblUser
		'
		Me.lblUser.Location = New System.Drawing.Point(27, 137)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(100, 26)
		Me.lblUser.TabIndex = 39
		Me.lblUser.Text = "Utilisateur : "
		'
		'lblDatabase
		'
		Me.lblDatabase.Location = New System.Drawing.Point(27, 106)
		Me.lblDatabase.Name = "lblDatabase"
		Me.lblDatabase.Size = New System.Drawing.Size(100, 23)
		Me.lblDatabase.TabIndex = 38
		Me.lblDatabase.Text = "Base de données : "
		'
		'txtLogSQL
		'
		Me.txtLogSQL.AcceptsReturn = true
		Me.txtLogSQL.Location = New System.Drawing.Point(27, 279)
		Me.txtLogSQL.Multiline = true
		Me.txtLogSQL.Name = "txtLogSQL"
		Me.txtLogSQL.ReadOnly = true
		Me.txtLogSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtLogSQL.Size = New System.Drawing.Size(378, 93)
		Me.txtLogSQL.TabIndex = 28
		'
		'cbxServer
		'
		Me.cbxServer.FormattingEnabled = true
		Me.cbxServer.Location = New System.Drawing.Point(133, 19)
		Me.cbxServer.Name = "cbxServer"
		Me.cbxServer.Size = New System.Drawing.Size(272, 21)
		Me.cbxServer.TabIndex = 19
		AddHandler Me.cbxServer.SelectedIndexChanged, AddressOf Me.CbxServerSelectedIndexChanged
		'
		'lblServer
		'
		Me.lblServer.Location = New System.Drawing.Point(27, 17)
		Me.lblServer.Name = "lblServer"
		Me.lblServer.Size = New System.Drawing.Size(63, 23)
		Me.lblServer.TabIndex = 15
		Me.lblServer.Text = "Serveur : "
		'
		'tabPgWeb
		'
		Me.tabPgWeb.Location = New System.Drawing.Point(4, 22)
		Me.tabPgWeb.Name = "tabPgWeb"
		Me.tabPgWeb.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPgWeb.Size = New System.Drawing.Size(439, 390)
		Me.tabPgWeb.TabIndex = 1
		Me.tabPgWeb.Text = "Web"
		Me.tabPgWeb.UseVisualStyleBackColor = true
		'
		'btnQuit
		'
		Me.btnQuit.Location = New System.Drawing.Point(371, 434)
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
		Me.ResumeLayout(false)
	End Sub
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
