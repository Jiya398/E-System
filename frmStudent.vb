Public Class frmStudent

    'Dim radioGender As String
    'Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'openCon()
    'MsgBox("Connected!")
    'con.Close()
    'End Sub

    'Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
    'openCon()
    'Try
    'cmd.Connection = con
    'cmd.CommandText = "INSERT INTO tblstudent (`sId`, `idno`, `last_name`, `first_name`, `middle_name`, `gender`, `bday`,`bdplace`,`address`, `guardian`,`guardian_tel`,`last_school_attend	`,`height`,`weight`) 
    'VALUES('" & txtStudentId.Text & "', '" & txtLName.Text & "', '" & txtFName.Text & "', '" & txtMName.Text & "', '" &
    'radioGender & "', '" & dtpDbirth.Text & "', '" & txtPBirth.Text & "', '" & txtAge.Text & "', '" & txtAddress.Text & "', '" &
    'txtguardian.Text & "', '" & txtguardianadd.Text & "', '" & txtguardiantel.Text & "', '" & txtLastSchoolAttend.Text & "', '" & txtHeight.Text & "', '" & txtWeigth.Text & "')"
    ''cmd.ExecuteNonQuery()
    'MsgBox("New Students Added")
    'con.Close()
    'txtStudentId.Clear()
    'txtLName.Clear()
    'txtFName.Clear()
    'txtMName.Clear()
    'rdoMale.Checked = False
    'rdoFemale.Checked = False
    'txtAge.Clear()
    'txtAddress.Clear()
    'txtguardian.Clear()
    'txtguardianadd.Clear()
    'txtguardiantel.Clear()
    'txtLastSchoolAttend.Clear()
    'txtHeight.Clear()
    'txtWeigth.Clear()

    'Catch ex As Exception
    'MsgBox(ex.ToString)
    'End Try


    ' End Sub

    'Private Sub btnGenerateIDNO_Click(sender As Object, e As EventArgs) Handles btnGenerateIDNO.Click
    'filltxtAuto("StudentID", txtStudentId)
    'txtLName.Focus()
    ' End Sub

    'Private Sub rdoMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMale.CheckedChanged
    '  radioGender = "Male"
    ' End Sub

    ' Private Sub rdoFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFemale.CheckedChanged
    '  radioGender = "Female"
    ' End Sub


    Private Sub Button4_KeyDown(sender As Object, e As KeyEventArgs) Handles Button4.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub dtpDbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDbirth.ValueChanged
    'Try
    'Dim age As Integer
    ' age = DateDiff(DateInterval.Year, dtpDbirth.Value, Now())
    ' txtAge.Text = age
    'Catch ex As Exception

    'End Try
    ' End Sub

End Class