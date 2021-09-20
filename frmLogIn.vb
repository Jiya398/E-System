Imports MySql.Data.MySqlClient

Public Class frmLogIn

    'Dim con As New MySqlConnection("server=localhost; username=root; password=; database= finalenroll")

    'Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
    'Dim command As New MySqlCommand("SELECT `username` `password` FROM `tblaccount` WHERE 1 @username AND 'pass' = @password")

    '   command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUserName.Text
    '  command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtUserName.Text

    'Dim adapter As New MySqlDataAdapter(command)
    'Dim table As New DataTable()

    '   adapter.Fill(table)

    'If table.Rows.Count = 0 Then
    '       MessageBox.Show("Invalid UserName Or Password")

    'Else
    '       MessageBox.Show("Loged In")


    'End If
    'End Sub



    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Close()
    End Sub

    'Private Sub txtUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter
    ' clear the txtbox when the textbox get the focus
    'Dim username As String = txtUserName.Text
    'check if the username is empty
    'check if the textbox constains the default value "username"
    'If username.Trim().ToLower() = "username" Or username.Trim() = " " Then
    'clear the textbox
    '       txtUserName.Text = " "
    'End If
    'End Sub

    'Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
    'when textbox get lost of focus 
    'Dim username As String = txtUserName.Text
    'check if the username is empty
    'check if the textbox constains the default value "username"
    'If username.Trim().ToLower() = "username" Or username.Trim() = " " Then
    'set the textbox text
    '       txtUserName.Text = " "
    'End If
    'End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter '
    'when textbox password has focus
    'Dim pass As String = txtUserName.Text
    'If pass.Trim().ToLower() = "password" Or pass.Trim = "" Then
    'clear the textbox text
    '       txtPassword.Text = ""
    'use the system password
    '      txtPassword.UseSystemPasswordChar = True
    'End If
    'End Sub

    'Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
    'when textbox password lost focus
    'Dim pass As String = txtUserName.Text
    ' If pass.Trim().ToLower() = "password" Or pass.Trim = "" Then
    'set the textbox text
    'txtPassword.Text = ""
    'set system password to false
    'txtPassword.UseSystemPasswordChar = False
    'End If
    'End Sub
End Class