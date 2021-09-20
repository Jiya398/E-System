Public Class frmTeacher
    'Private Sub btnSaveTeacher_Click(sender As Object, e As EventArgs) Handles btnSaveTeacher.Click
    'openCon()
    'Try
    'cmd.Connection = con
    'cmd.CommandText = "INSERT INTO tblteacher (`teacher_id`, `last_name`, `first_name`, `middle_name`, `gender`, `dob`, `address`, `contact`,
    '                       `degree`, `specialization`) VALUES('" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" &
    'txtMiddleName.Text & "', '" & cmbGender.SelectedItem & "', '" & dtpDob.Value.Date & "', '" &
    'txtAddress.Text & "', '" & txtContact.Text & "', '" & txtDegree.Text & "', '" & txtSpecialization.Text & "')"
    ''cmd.ExecuteNonQuery()
    'MsgBox("New Teacher has been added!")
    'con.Close()
    'txtLastName.Clear()
    'txtFirstName.Clear()
    'txtMiddleName.Clear()
    'cmbGender.Text = ""
    'txtAddress.Clear()
    'txtContact.Clear()
    'txtDegree.Clear()
    'txtSpecialization.Clear()

    'Catch ex As Exception
    'MsgBox(ex.ToString)
    'End Try
    'End Sub

    Private Sub btnBackTeacher_Click(sender As Object, e As EventArgs) Handles btnBackTeacher.Click
        Me.Close()
    End Sub

    Private Sub btnBackTeacher_KeyDown(sender As Object, e As KeyEventArgs) Handles btnBackTeacher.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class