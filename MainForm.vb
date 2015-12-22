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
		'getDatabaseList()
	End Sub
	

	'---------------------------------------------------------------------
	' EVENT : Connexion au serveur SQL sélectionné 
	'---------------------------------------------------------------------	
	Sub BtnConnectClick(sender As Object, e As EventArgs)
		txtLogSQL.Text = "Connexion en cours ..."
		getDatabaseList()		
	End Sub
		
		
	'------------------------------------------------------
	' EVENT : choix de la base de données
	'------------------------------------------------------	
	Sub CbxDatabaseSelectedIndexChanged(sender As Object, e As EventArgs)
		txtScript.Enabled = True
		btnScriptPath.Enabled = true
	End Sub
	
	
	'------------------------------------------------------
	' EVENT : demande exécution du fichier de script sélectionné
	'------------------------------------------------------
	Sub BtnExecClick(sender As Object, e As EventArgs)
		execSqlScript()
	End Sub
	
	'------------------------------------------------------
	' EVENT : séléction du fichier de script à exécuter
	'------------------------------------------------------
	Sub BtnScriptPathClick(sender As Object, e As EventArgs)
		getSqlFile()
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
			msg = "La liste des SQL servers est à jour."
			
		Catch e As Exception
			msg = "Aucun SQL server n'a pas été trouvé." & vbCrLf
			msg = msg & e.Message
			
		Finally
			txtLogSQL.Clear()
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
		cnxString = "integrated security=SSPI;data source=" & sqlServerName & ";" & "persist security info=False;initial catalog="
		
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
		cbxDatabase.Enabled = true

		Catch e As Exception
			msg = e.Message
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
				txtLogSQL.text = e.message
			Finally
		End Try
	End Sub
	
	
	'------------------------------------------------------------
	' Exécution du script sql sélectionné
	'------------------------------------------------------------
	' TODO 
	Sub execSqlScript()
		'If (UserClickedOK = True) Then
        'Open the selected file to read.
       ' Dim fileStream As System.IO.Stream = sqlFileDialog.File.OpenRead
'
        'Using reader As New System.IO.StreamReader(fileStream)
         '        sqlTxt = sqlTxt & reader.ReadLine
        'End Using
        ' fileStream.Close()
        txtLogSQL.Text = "Exécution du script sélectionné"
	End Sub
	
	

	
End Class
