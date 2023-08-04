Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogIn.MdiParent = Me
        frmLogIn.Show()
    End Sub



    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click
        frmMaintenance.MdiParent = Me
        frmMaintenance.Show()
    End Sub



    Private Sub ManageSchoolYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSchoolYearToolStripMenuItem.Click
        FrmSchoolYear.MdiParent = Me
        FrmSchoolYear.Show()
    End Sub



    Private Sub ManageCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCourseToolStripMenuItem.Click
        frmCourse.MdiParent = Me
        frmCourse.Show()
    End Sub



    Private Sub ManageSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSectionToolStripMenuItem.Click
        frmSection.MdiParent = Me
        frmSection.Show()
    End Sub



    Private Sub ManageSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSubjectToolStripMenuItem.Click
        frmSubject.MdiParent = Me
        frmSubject.Show()
    End Sub



    Private Sub EnrollmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentToolStripMenuItem.Click
        frmEnrolledStudent.MdiParent = Me
        frmEnrolledStudent.Show()
    End Sub



    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        frmStudent.MdiParent = Me
        frmStudent.Show()
    End Sub



    Private Sub TeachersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeachersToolStripMenuItem.Click
        frmTeacher.MdiParent = Me
        frmTeacher.Show()
    End Sub


End Class
