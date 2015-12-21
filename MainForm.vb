'
' Created by SharpDevelop.
' User: lopeze
' Date: 21/12/2015
' Time: 15:59
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data.DataTable
Imports System.data
Imports System.Data.Sql

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		alimentCbxServer()
	End Sub
	
	Sub BtnQuitClick(sender As Object, e As EventArgs)
		Me.Close()		
	End Sub
	
	
	'---------------------------------------------------------------------
	'
	' Alimentation de la combobox des instances SQL Server disponibles
	'---------------------------------------------------------------------
	Sub alimentCbxServer ()
		
		Dim dt As Data.DataTable
		dt = SqlDataSourceEnumerator.Instance.GetDataSources		
		For Each dr As Data.DataRow  In dt.Rows
		     cbxServer.Items.Add(String.Concat(dr("ServerName"), "\", dr("InstanceName")))
		Next
	End sub
	
End Class
