'Imports MySql.Data.MySqlClient

Public Class frmMaintenance
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtSchoolId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchoolId.KeyPress, txtMaxStudent.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57
            Case Else
                e.Handled = True
        End Select


    End Sub

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'openCon()
        'MsgBox("Connected!")

        'con.Close()
    End Sub


    Private Sub btnSaveSchool_Click(sender As Object, e As EventArgs) Handles btnSaveSchool.Click
        'openCon()
        'Try
        'cmd.Connection = con
        'cmd.CommandText = "INSERT INTO tblschool (`school_id`, `school_name`, `school_address`, `region`, `division`) VALUES('" &
        'txtSchoolId.Text & "', '" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtRegion.Text & "', '" & txtDivision.Text & "')"


        'cmd.ExecuteNonQuery()
        'Box("Success Full Added Record!")

        'con.Close()
        'txtSchoolId.Clear()
        'txtName.Clear()
        'txtAddress.Clear()
        'txtRegion.Clear()
        'txtDivision.Clear()

        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub btnSavee_Click(sender As Object, e As EventArgs) Handles btnSavee.Click
        'openCon()
        'Try
        'cmd.Connection = con
        'cmd.CommandText = "INSERT INTO tblmaxstudent (`max_student`) VALUES('" & txtMaxStudent.Text & "')"
        'cmd.ExecuteNonQuery()
        'MsgBox("Success Full Added Record!")
        'con.Close()
        'txtMaxStudent.Clear()

        ' Catch ex As Exception
        'MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub btnSaveSend_Click(sender As Object, e As EventArgs) Handles btnSaveSend.Click
        'openCon()
        ' Try
        'cmd.Connection = con
        'cmd.CommandText = "INSERT INTO tblmessage (`email`, `password`, `message`) VALUES('" & txtEmail.Text & "', '" & txtPass.Text & "', '" &
        'txtMessage.Text & "')"
        'cmd.ExecuteNonQuery()
        'MsgBox("Send Your Message")
        'con.Close()
        'txtEmail.Clear()
        'txtPass.Clear()
        'txtMessage.Clear()

        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtSchoolId_TextChanged(sender As Object, e As EventArgs) Handles txtSchoolId.TextChanged

    End Sub
End Class








