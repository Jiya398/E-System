Public Class frmSection


    Private Sub btnSaveSection_Click(sender As Object, e As EventArgs) Handles btnAddSection.Click
        con.Open()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tblsection (`year_level`, `section`, `courses`, `teacher`) VALUES('" & cmbLevel.SelectedItem & "', '" & cmbSection.SelectedItem & "', '" &
        cmbCourses.SelectedItem & "', '" & cmbTeacher.SelectedItem & "')"
            cmd.ExecuteNonQuery()
            MsgBox("New Section has been added!")
            con.Close()
            cmbLevel.Text = ""
            cmbSection.Text = ""
            cmbCourses.Text = ""
            cmbTeacher.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmSection_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class