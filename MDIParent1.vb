Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogIn.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmLogIn.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click
        frmMaintenance.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmMaintenance.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub ManageSchoolYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSchoolYearToolStripMenuItem.Click
8
    End Sub

    Private Sub ManageCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCourseToolStripMenuItem.Click
        frmCourse.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmCourse.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub ManageSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSectionToolStripMenuItem.Click
        frmSection.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmSection.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub ManageSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSubjectToolStripMenuItem.Click
        frmSubject.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmSubject.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentToolStripMenuItem.Click
        frmEnrolledStudent.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmEnrolledStudent.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        frmStudent.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmStudent.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub TeachersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeachersToolStripMenuItem.Click
        frmTeacher.MdiParent = Me 'me ang ilalagay for the addressing at kapag clinick yung frmlogin nasa loob siya magrurun
        frmTeacher.Show() 'kapag clinick ko yun lilitaw ang frmlogin
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
