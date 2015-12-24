'
' Created by SharpDevelop.
' User: lopeze
' Date: 21/12/2015
' Time: 15:59
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.data
Imports System.Data.DataTable
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression



Public Partial Class MainForm
	Public Sub New()
		
		Me.InitializeComponent()

	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		getServerList()
	End Sub
	
	Sub BtnQuitClick(sender As Object, e As EventArgs)
		Me.Close()	
	End Sub
	
	
	'---------------------------------------------------------------------
	' EVENT : Lorsque le serveur SQL est choisi
	'---------------------------------------------------------------------	
	Sub CbxServerSelectedIndexChanged(sender As Object, e As EventArgs)
		txtUser.Enabled = True
		txtPass.Enabled = True
		btnConnect.Enabled = True
		cbxDatabase.Items.Clear()
		txtLogSQL.Text = "Serveur SQL sélectionné."
	End Sub
	

	'---------------------------------------------------------------------
	' EVENT : Demande de récupération de la liste des base de données
	'---------------------------------------------------------------------	
	Sub BtnConnectClick(sender As Object, e As EventArgs)
		If ctrlSaisieServer() then
			txtLogSQL.Text = "Demande de connexion au serveur SQL."
			getDatabaseList()
		Else
			MsgBox ("Le nom du serveur SQL ne figure pas dans la liste proposée.")
		End If
	
	End Sub
		
	'------------------------------------------------------
	' EVENT : Choix de la base de données
	'------------------------------------------------------	
	Sub CbxDatabaseSelectedIndexChanged(sender As Object, e As EventArgs)
		txtScript.Enabled = True
		btnScriptPath.Enabled = True
		txtLogSQL.Text = "Base de données sélectionnée."
	End Sub
	
	'------------------------------------------------------
	' EVENT : Séléction du fichier de script à exécuter
	'------------------------------------------------------
	Sub BtnScriptPathClick(sender As Object, e As EventArgs)
		getSqlFile()
		txtLogSQL.Text = "Script SQL sélectionné."
	End Sub	
	
	'------------------------------------------------------
	' EVENT : Demande exécution du fichier de script sélectionné
	'------------------------------------------------------
	Sub BtnExecClick(sender As Object, e As EventArgs)
		txtLogSQL.Text = "Demande d'exécution du Script SQL."
		If (formCompleted) then 
			execSqlScript()
		Else
			msgbox ("Tous les champs ne sont pas correctement renseignés")
		End If
		
	End Sub
	
	'------------------------------------------------------
	' EVENT : Le nom du script a été sélectionné
	'------------------------------------------------------	
	Sub TxtScriptTextChanged(sender As Object, e As EventArgs)
		btnExec.Enabled = true		
	End Sub	
	
	'------------------------------------------------------
	' EVENT : Séléction de l'archive à décomprésser
	'------------------------------------------------------		
	Sub BtnZipClick(sender As Object, e As EventArgs)
		getZipFile()		
	End Sub	
	
	'------------------------------------------------------
	' EVENT : Séléction du dossier web d'installation
	'------------------------------------------------------	
	Sub BtnDestClick(sender As Object, e As EventArgs)
		getWebPath()		
	End Sub	
	
	
	'------------------------------------------------------
	' EVENT : Demande de décompression de l'archive zip
	'------------------------------------------------------	
	Sub BtnUnzipClick(sender As Object, e As EventArgs)
		unZipMaevaWeb()
	End Sub
	
	'---------------------------------------------------------------------
	' PROC : Création de la liste des instances SQL Server disponibles
	'---------------------------------------------------------------------
	Sub getServerList ()
				
		Dim dt As Data.DataTable
		Dim dr As DataRow
		Dim msg As String
		
		msg = ""
		dt = SqlDataSourceEnumerator.Instance.GetDataSources()
		
		Try	
			For Each dr In dt.Rows
		    	cbxServer.Items.Add(dr.Item(0).ToString & "\" & dr.Item(1).ToString)
			Next
			msg = "La liste des SQL servers a été mise à jour."
			
		Catch e As Exception
			msg = "ERREUR : " & vbCrLf
			msg = msg & e.Message
			
		Finally
			txtLogSQL.Text = msg
			dr = Nothing
			dt =  Nothing
		End Try
		
	End Sub		
	
	'---------------------------------------------------------------------
	' PROC : Connexion au serveur sélectionné et 
	' 		 récupération de la liste des bases de données
	'---------------------------------------------------------------------	
	Sub getDatabaseList ()
		
		Dim sqlServerName As String
		Dim sqlCnx As New SqlClient.SqlConnection
		Dim sqlCmd As New SqlCommand
		Dim cnxString As String
		Dim reader As SqlDataReader
		Dim msg As String
		
		sqlServerName = cbxServer.Text 
		msg = ""
		txtLogSQL.Clear()
		cnxString = "integrated security=SSPI;data source=" & sqlServerName & ";" _
				  & "persist security info=False;initial catalog="
		
		Try
			sqlCmd.CommandText = "SELECT name, database_id, create_date FROM sys.databases ;"
			sqlCmd.CommandType = CommandType.Text
			sqlCmd.Connection = sqlCnx
			sqlCnx.ConnectionString = cnxString
			sqlCnx.Open()
		
			reader = sqlCmd.ExecuteReader()
			
			'Nettoyage de la liste avant remplissage
			cbxDatabase.Items.Clear()
			
			'remplissage de la liste 
			While reader.Read()
				cbxDatabase.Items.Add(reader.GetString(0))
			End While
		
		sqlCnx.Close()
			msg = "La liste des bases de données est disponible."
		cbxDatabase.Enabled = true

		Catch e As Exception
			msg = "ERREUR : " & e.Message
		Finally
			txtLogSQL.Text = msg
		End Try
	End Sub	
	
	
	'--------------------------------------------------------
	' PROC : Récupération du script sql à exécuter
	'---------------------------------------------------------
	Sub getSqlFile()
				Dim sqlFileDialog As New OpenFileDialog()
		try
			sqlFileDialog.Filter = "Scripts SQL (*.sql)|*.sql"
			sqlFileDialog.Multiselect = False
			sqlFileDialog.ShowDialog()
			txtScript.text = sqlFileDialog.FileName
			Catch  e As Exception
				txtLogSQL.text = "ERREUR : " & e.message
			Finally
		End Try
	End Sub
	
	
	'------------------------------------------------------------
	' Vérification de la saisie du nom du server
	'------------------------------------------------------------	
	Function ctrlSaisieServer() As Boolean
		Return true
	End Function
	
	
	'------------------------------------------------------------
	' Vérification de la complétion du formulaire
	'------------------------------------------------------------
	function formCompleted() as boolean
		return true
	End function
	
	'------------------------------------------------------------
	' Exécution du script sql sélectionné
	'------------------------------------------------------------
	Sub execSqlScript()
        Dim sqlServerName As String
        Dim databaseName As String
        Dim userName As String
        Dim userPass As String
		Dim cnxString As String
		Dim sqlString As string
		Dim msg As String
		Dim result As integer
	
		sqlServerName = cbxServer.Text
		databaseName = cbxDatabase.Text
		userName = txtUser.Text
		userPass = txtUser.Text
		msg = ""
		cnxString = "integrated security=SSPI;data source=" _
			& sqlServerName & ";" _
			& "persist security info=False;initial catalog=" & databaseName _
			& ";user=" & txtUser.Text _
			& ";password=" & txtPass.text

		sqlString = System.IO.File.ReadAllText (txtScript.text)
		
		Try 
			Dim sqlCnx As New SqlClient.SqlConnection(cnxString)
			Dim sqlCmd As New SqlCommand (sqlString, sqlCnx)
			sqlCnx.Open()
			result = sqlCmd.ExecuteNonQuery()
			sqlCnx.Close()
			msg = "Le script sélectionné a été exécuté avec succès."
		Catch e As Exception
			msg = "ERREUR : " & vbCrLf & e.Message
		Finally
			txtLogSQL.Text = msg & vbCrLf & "Resultat : " & result
		End Try
		
	End Sub
	
	'--------------------------------------------------------
	' PROC : Récupération des fichiers d'archives zip
	'---------------------------------------------------------
	Sub getZipFile()
		Dim zipFileDialog As New OpenFileDialog()
		try
			zipFileDialog.Filter = "Archives (*.zip)|*.zip"
			zipFileDialog.Multiselect = False
			zipFileDialog.ShowDialog()
			txtZip.text = zipFileDialog.FileName
			Catch  e As Exception
				txtLogSQL.text = "ERREUR : " & e.message
			Finally
		End Try
	End Sub	

	'--------------------------------------------------------
	' PROC : Sélection du répertoire
	'---------------------------------------------------------
	Sub getWebPath()
		Dim pathDialog As New FolderBrowserDialog()

		If pathDialog.ShowDialog() = DialogResult.OK Then
        	txtDest.Text = pathDialog.SelectedPath
		End If
		
	End Sub		
	
	'--------------------------------------------------------
	' PROC : Désarchivage de l'archive web
	'---------------------------------------------------------	
	Sub unZipMaevaWeb()
		
		Dim msg As String
		Dim result As DialogResult
		
		' Si le répertoire existe déjà
		If Directory.Exists(txtDest.Text) Then
			result = MessageBox.Show("Le répertoire de destination existe déjà." & vbCrLf & _
				"Si vous continuez, une sauvegarde en sera faite avant de l'écraser." & vbCrLf & _
				"Souhaitez-vous continuer ?", "Avertissement", MessageBoxButtons.OKCancel)
		End If
		' et que le déploiement doit s'ffectuer dans ce même répertoire
		If result = vbCancel Then
			Exit Sub
		Else
			overWriteDest()
		End If
		
		Try
			ZipFile.ExtractToDirectory (txtZip.Text, txtDest.Text)
			msg = "L'archive a été extraite avec succès"
		Catch e As Exception
			msg = "ERREUR : " & vbCrLf & e.Message 
		End Try
			txtLogZip.Text = msg
	End Sub
	
	'--------------------------------------------------------
	' PROC : Sauvegarde et suppression de l'arborescence 
	'  		 spécifiée dans le textbox  Destination
	'---------------------------------------------------------		
	Sub overWriteDest()
		
		Dim msg = ""
		Dim horodatage As String
		Dim fromPath As String 
		Dim toZip As String
		
		horodatage = DateTime.now.Year.ToString()
		horodatage += DateTime.now.Month.ToString()
		horodatage += DateTime.now.Day.ToString()
		horodatage += DateTime.now.Hour.ToString()
		horodatage += DateTime.now.Month.ToString()
		horodatage += DateTime.now.Second.ToString()
		
		fromPath = txtDest.text
		toZip = txtDest.Text & "_" & horodatage & ".zip"
		
		Try
			ZipFile.CreateFromDirectory(fromPath,toZip)
			Directory.Delete(txtDest.Text, True)
			msg ="Le répertoire précédent à été archivés avec succès avant d'être supprimé."
		Catch e As Exception
			msg = "ERREUR : " & vbCrLf		
		End Try
		
		txtLogZip.Text = msg
		
		
	End Sub
	
	
End Class
