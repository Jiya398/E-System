Imports MySql.Data.MySqlClient

Public Class frmCourse

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadOnGridView()
    End Sub



    Private Sub frmCourse_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub



    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim sql As String

        If btnAddCourse.Text = "Add" Then
            sql = "INSERT INTO tblcourse (course_code, description) VALUES('" & txtCode.Text & "', '" & txtDescription.Text & "');"

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
            sql = "UPDATE tblcourse SET course_code = '" & txtCode.Text & "', description = '" & txtDescription.Text & "' WHERE ID ;"
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
            cmd = New MySqlCommand("Select * From tblcourse;", con)
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
        txtCode.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtDescription.Text = DataGridView1.Item(2, e.RowIndex).Value
        btnAddCourse.Text = "Update"
        txtCode.Tag = DataGridView1.Item(0, e.RowIndex).Value
    End Sub




    Private Sub btnCancelCourse_Click(sender As Object, e As EventArgs) Handles btnCancelCourse.Click
        Me.Dispose()
    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        Dim sql As String
        sql = "Delete From tbluser Where id = '" & txtCode.Tag & "';"
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

    Private Sub btnClearCourse_Click(sender As Object, e As EventArgs) Handles btnClearCourse.Click

        txtCode.Text = ""
        txtDescription.Text = " "
        txtCode.Tag = ""
        btnAddCourse.Text = "Add"

    End Sub
End Class