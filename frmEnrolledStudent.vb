Public Class frmEnrolledStudent
    Private Sub btnBackEnrolled_Click(sender As Object, e As EventArgs) Handles btnBackEnrolled.Click
        Me.Close()
    End Sub

    Private Sub btnBackEnrolled_KeyDown(sender As Object, e As KeyEventArgs) Handles btnBackEnrolled.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmEnrolledStudent_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtName.Clear()
    End Sub

    Private Sub frmEnrolledStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Private Sub btnSaveEnrolled_Click(sender As Object, e As EventArgs) Handles btnSaveEnrolled.Click
    'openCon()
    'Try
    'cmd.Connection = con
    'cmd.CommandText = "INSERT INTO tbladdenrolled (`school_year`, `lrn`, `sId`, `full_name`, `course`, `year_level`, `section`,`term`,`teacher`) 
    'VALUES('" & txtAY.Text & "', '" & txtLRN.Text & "', '" & txtStudent.Text & "', '" & txtName.Text & "', '" &
    'txtCourse.Text & "', '" & cmbYear.SelectedItem & "', '" & cmbSection.SelectedItem & "', '" & cmbTerm.SelectedItem & "', '" & txtTeacher.Text & "')"
    'cmd.ExecuteNonQuery()
    'MsgBox("New Enrolled Students Added")
    'con.Close()
    'txtAY.Clear()
    'txtLRN.Clear()
    'txtStudent.Clear()
    ' txtName.Clear()
    'txtCourse.Clear()
    'cmbYear.Text = ""
    'cmbSection.Text = ""
    'cmbSection.Text = ""
    'cmbTerm.Text = ""
    'txtTeacher.Clear()

    'Catch ex As Exception
    ' MsgBox(ex.ToString)
    'End Try

    'End Sub
End Class