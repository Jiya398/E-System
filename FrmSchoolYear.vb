Imports MySql.Data.MySqlClient
Public Class FrmSchoolYear

    Private Sub FrmSchoolYear_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close() 'kapag clicnick natin ang escape na key babalik siya sa main form
    End Sub


    Private Sub FrmSchoolYear_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtYear.Clear()
    End Sub


    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress 'validation ito dapat number lang ang eenter hindi pwede ang letter
        Select Case Asc(e.KeyChar)
            Case 8, 45, 48 To 57
            Case Else
                e.Handled = True

        End Select
    End Sub


    Private Sub FrmSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadOnGridView()
    End Sub

    Private Sub btnAddYear_Click(sender As Object, e As EventArgs) Handles btnAddYear.Click

        Dim sql As String

        If btnAddYear.Text = "Add" Then
            sql = "INSERT INTO tbluser (Year, Term) VALUES('" & txtYear.Text & "', '" & cbTerm.SelectedItem & "');"
            con.Open()
            If con.State = ConnectionState.Open Then
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                MessageBox.Show("Connection failed!" & vbNewLine & "Contact the System Administrator.")
            End If
            con.Close()
        Else
            sql = "UPDATE tblschoolyear SET school_year='" & txtYear.Text & "', term = '" & cbTerm.SelectedItem & "';"
            con.Open()
            If con.State = ConnectionState.Open Then
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                MessageBox.Show("Connection failed!" & vbNewLine & "Contact the System Administrator.")
            End If
            con.Close()
        End If

        LoadOnGridView()
    End Sub


    Private Sub LoadOnGridView()
        dt = New DataTable
        con.Open()
        If con.State = ConnectionState.Open Then
            cmd = New MySqlCommand("Select * From tblschoolyear;", con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            DataGridView1.DataSource = dt
            DataGridView1.Refresh()

            cmd.Dispose()
            da.Dispose()
        Else
            MessageBox.Show("Connection failed!" & vbNewLine & "Contact the System Administrator.")
        End If
        con.Close()
    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        txtYear.Text = DataGridView1.Item(1, e.RowIndex).Value
        cbTerm.SelectedItem = DataGridView1.Item(3, e.RowIndex).Value
        btnAddYear.Text = "Update"
        txtYear.Tag = DataGridView1.Item(0, e.RowIndex).Value
    End Sub




    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteYear.Click
        Dim sql As String
        sql = "Delete From tbluser Where id = '" & txtYear.Tag & "';"
        con.Open()
        If con.State = ConnectionState.Open Then
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            MessageBox.Show("Connection failed!" & vbNewLine & "Contact the System Administrator.")
        End If
        con.Close()

        LoadOnGridView()
    End Sub



    Private Sub btnRefreshYear_Click(sender As Object, e As EventArgs) Handles btnRefreshYear.Click
        txtYear.Text = ""
        cbTerm.SelectedItem = ""
        txtYear.Tag = ""
        btnAddYear.Text = "Add"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Dispose()
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class