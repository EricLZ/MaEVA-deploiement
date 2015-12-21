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
		Me.pictTitle = New System.Windows.Forms.PictureBox()
		Me.lblServer = New System.Windows.Forms.Label()
		Me.lblDatabase = New System.Windows.Forms.Label()
		Me.lblUser = New System.Windows.Forms.Label()
		Me.lblPasswd = New System.Windows.Forms.Label()
		Me.cbxServer = New System.Windows.Forms.ComboBox()
		Me.txtUser = New System.Windows.Forms.TextBox()
		Me.txtPass = New System.Windows.Forms.TextBox()
		Me.cbxDatabase = New System.Windows.Forms.ComboBox()
		Me.lblScript = New System.Windows.Forms.Label()
		Me.txtScript = New System.Windows.Forms.TextBox()
		Me.btnScriptPath = New System.Windows.Forms.Button()
		Me.btnQuit = New System.Windows.Forms.Button()
		Me.btnExec = New System.Windows.Forms.Button()
		CType(Me.pictTitle,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictTitle
		'
		Me.pictTitle.ErrorImage = Nothing
		Me.pictTitle.Image = CType(resources.GetObject("pictTitle.Image"),System.Drawing.Image)
		Me.pictTitle.InitialImage = Nothing
		Me.pictTitle.Location = New System.Drawing.Point(1, 2)
		Me.pictTitle.Name = "pictTitle"
		Me.pictTitle.Size = New System.Drawing.Size(477, 84)
		Me.pictTitle.TabIndex = 0
		Me.pictTitle.TabStop = false
		'
		'lblServer
		'
		Me.lblServer.Location = New System.Drawing.Point(55, 137)
		Me.lblServer.Name = "lblServer"
		Me.lblServer.Size = New System.Drawing.Size(63, 23)
		Me.lblServer.TabIndex = 1
		Me.lblServer.Text = "Serveur : "
		'
		'lblDatabase
		'
		Me.lblDatabase.Location = New System.Drawing.Point(55, 255)
		Me.lblDatabase.Name = "lblDatabase"
		Me.lblDatabase.Size = New System.Drawing.Size(100, 23)
		Me.lblDatabase.TabIndex = 2
		Me.lblDatabase.Text = "Base de données : "
		'
		'lblUser
		'
		Me.lblUser.Location = New System.Drawing.Point(55, 172)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(100, 23)
		Me.lblUser.TabIndex = 3
		Me.lblUser.Text = "Utilisateur : "
		'
		'lblPasswd
		'
		Me.lblPasswd.Location = New System.Drawing.Point(55, 204)
		Me.lblPasswd.Name = "lblPasswd"
		Me.lblPasswd.Size = New System.Drawing.Size(100, 23)
		Me.lblPasswd.TabIndex = 4
		Me.lblPasswd.Text = "Mot de passe : "
		'
		'cbxServer
		'
		Me.cbxServer.FormattingEnabled = true
		Me.cbxServer.Location = New System.Drawing.Point(161, 137)
		Me.cbxServer.Name = "cbxServer"
		Me.cbxServer.Size = New System.Drawing.Size(256, 21)
		Me.cbxServer.TabIndex = 5
		'
		'txtUser
		'
		Me.txtUser.Location = New System.Drawing.Point(161, 172)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(256, 20)
		Me.txtUser.TabIndex = 6
		'
		'txtPass
		'
		Me.txtPass.Location = New System.Drawing.Point(161, 204)
		Me.txtPass.Name = "txtPass"
		Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(176)
		Me.txtPass.Size = New System.Drawing.Size(256, 20)
		Me.txtPass.TabIndex = 7
		'
		'cbxDatabase
		'
		Me.cbxDatabase.FormattingEnabled = true
		Me.cbxDatabase.Location = New System.Drawing.Point(161, 252)
		Me.cbxDatabase.Name = "cbxDatabase"
		Me.cbxDatabase.Size = New System.Drawing.Size(256, 21)
		Me.cbxDatabase.TabIndex = 8
		'
		'lblScript
		'
		Me.lblScript.Location = New System.Drawing.Point(55, 288)
		Me.lblScript.Name = "lblScript"
		Me.lblScript.Size = New System.Drawing.Size(100, 23)
		Me.lblScript.TabIndex = 9
		Me.lblScript.Text = "Script SQL : "
		'
		'txtScript
		'
		Me.txtScript.Location = New System.Drawing.Point(161, 285)
		Me.txtScript.Name = "txtScript"
		Me.txtScript.PasswordChar = Global.Microsoft.VisualBasic.ChrW(176)
		Me.txtScript.Size = New System.Drawing.Size(256, 20)
		Me.txtScript.TabIndex = 10
		'
		'btnScriptPath
		'
		Me.btnScriptPath.Location = New System.Drawing.Point(424, 285)
		Me.btnScriptPath.Name = "btnScriptPath"
		Me.btnScriptPath.Size = New System.Drawing.Size(34, 23)
		Me.btnScriptPath.TabIndex = 11
		Me.btnScriptPath.Text = "..."
		Me.btnScriptPath.UseVisualStyleBackColor = true
		'
		'btnQuit
		'
		Me.btnQuit.Location = New System.Drawing.Point(374, 346)
		Me.btnQuit.Name = "btnQuit"
		Me.btnQuit.Size = New System.Drawing.Size(84, 33)
		Me.btnQuit.TabIndex = 12
		Me.btnQuit.Text = "Quitter"
		Me.btnQuit.UseVisualStyleBackColor = true
		AddHandler Me.btnQuit.Click, AddressOf Me.BtnQuitClick
		'
		'btnExec
		'
		Me.btnExec.Location = New System.Drawing.Point(266, 346)
		Me.btnExec.Name = "btnExec"
		Me.btnExec.Size = New System.Drawing.Size(84, 33)
		Me.btnExec.TabIndex = 13
		Me.btnExec.Text = "Exécuter"
		Me.btnExec.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(478, 402)
		Me.Controls.Add(Me.btnExec)
		Me.Controls.Add(Me.btnQuit)
		Me.Controls.Add(Me.btnScriptPath)
		Me.Controls.Add(Me.txtScript)
		Me.Controls.Add(Me.lblScript)
		Me.Controls.Add(Me.cbxDatabase)
		Me.Controls.Add(Me.txtPass)
		Me.Controls.Add(Me.txtUser)
		Me.Controls.Add(Me.cbxServer)
		Me.Controls.Add(Me.lblPasswd)
		Me.Controls.Add(Me.lblUser)
		Me.Controls.Add(Me.lblDatabase)
		Me.Controls.Add(Me.lblServer)
		Me.Controls.Add(Me.pictTitle)
		Me.Name = "MainForm"
		Me.Text = "MaEVA - Déploiement SQL"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.pictTitle,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
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
	Private pictTitle As System.Windows.Forms.PictureBox
End Class
