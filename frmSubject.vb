Public Class frmSubject
    Private Sub btnBackSubject_Click(sender As Object, e As EventArgs) Handles btnBackSubject.Click
        Me.Close()
    End Sub

    Private Sub btnBackSubject_KeyDown(sender As Object, e As KeyEventArgs) Handles btnBackSubject.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
    'openCon()
    'Try
    'cmd.Connection = con
    'cmd.CommandText = "INSERT INTO tblsubject (`subid`, `subj_code`, `subj_description`, `unit`, `year_level`, `ay`) 
    'VALUES('" & txtSubId.Text & "', '" & txtCode.Text & "', '" & txtDescription.Text & "', '" & txtUnit.Text & "', '" &
    'cmbYearLvl.SelectedItem & "', '" & cmbAY.SelectedItem & "')"
    'cmd.ExecuteNonQuery()
    ' MsgBox("New Subject Added")
    'con.Close()
    'txtSubId.Clear()
    'txtCode.Clear()
    'txtDescription.Clear()
    'txtUnit.Clear()
    'cmbYearLvl.Text = ""
    'cmbAY.Text = ""

    'Catch ex As Exception
    'MsgBox(ex.ToString)
    'End Try
    'End Sub


End Class