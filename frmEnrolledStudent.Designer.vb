<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrolledStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.btnSaveEnrolled = New System.Windows.Forms.Button()
        Me.btnBackEnrolled = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTeacher = New System.Windows.Forms.TextBox()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Enrolled Students"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AY"
        '
        'txtAY
        '
        Me.txtAY.Location = New System.Drawing.Point(32, 91)
        Me.txtAY.Name = "txtAY"
        Me.txtAY.Size = New System.Drawing.Size(175, 20)
        Me.txtAY.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LRN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(568, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Year Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Student ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Course"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(568, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(568, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Term"
        '
        'txtLRN
        '
        Me.txtLRN.Location = New System.Drawing.Point(225, 91)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(220, 20)
        Me.txtLRN.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(32, 227)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(413, 20)
        Me.txtName.TabIndex = 14
        '
        'txtStudent
        '
        Me.txtStudent.Location = New System.Drawing.Point(32, 157)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(413, 20)
        Me.txtStudent.TabIndex = 15
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(32, 300)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(413, 20)
        Me.txtCourse.TabIndex = 17
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbYear.Location = New System.Drawing.Point(571, 89)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(359, 21)
        Me.cmbYear.TabIndex = 18
        '
        'cmbSection
        '
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"BSIT 1A", "BSIT 2A", "BSIT 2B", "BSIT 3A", "BSIT 3B", "BSIT 4A", "BSSW 1A", "BSSW 2A", "BSSW 3A", "BSSW 4A", "BEED 1A", "BEED 2A", "BEED 3A", "BEED 4A", "BSBA 1A", "BSBA 2A", "BSBA 3A", "BSBA 4A"})
        Me.cmbSection.Location = New System.Drawing.Point(571, 155)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(359, 21)
        Me.cmbSection.TabIndex = 19
        '
        'btnSaveEnrolled
        '
        Me.btnSaveEnrolled.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSaveEnrolled.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEnrolled.ForeColor = System.Drawing.Color.White
        Me.btnSaveEnrolled.Location = New System.Drawing.Point(855, 338)
        Me.btnSaveEnrolled.Name = "btnSaveEnrolled"
        Me.btnSaveEnrolled.Size = New System.Drawing.Size(75, 28)
        Me.btnSaveEnrolled.TabIndex = 21
        Me.btnSaveEnrolled.Text = "Save"
        Me.btnSaveEnrolled.UseVisualStyleBackColor = False
        '
        'btnBackEnrolled
        '
        Me.btnBackEnrolled.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnBackEnrolled.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackEnrolled.ForeColor = System.Drawing.Color.White
        Me.btnBackEnrolled.Location = New System.Drawing.Point(756, 338)
        Me.btnBackEnrolled.Name = "btnBackEnrolled"
        Me.btnBackEnrolled.Size = New System.Drawing.Size(84, 28)
        Me.btnBackEnrolled.TabIndex = 22
        Me.btnBackEnrolled.Text = "Back"
        Me.btnBackEnrolled.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(568, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Teacher"
        '
        'txtTeacher
        '
        Me.txtTeacher.Location = New System.Drawing.Point(571, 300)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.Size = New System.Drawing.Size(359, 20)
        Me.txtTeacher.TabIndex = 24
        '
        'cmbTerm
        '
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.cmbTerm.Location = New System.Drawing.Point(571, 226)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(359, 21)
        Me.cmbTerm.TabIndex = 25
        '
        'frmEnrolledStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 409)
        Me.Controls.Add(Me.cmbTerm)
        Me.Controls.Add(Me.txtTeacher)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBackEnrolled)
        Me.Controls.Add(Me.btnSaveEnrolled)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEnrolledStudent"
        Me.Text = "frmEnrolledStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAY As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents btnSaveEnrolled As Button
    Friend WithEvents btnBackEnrolled As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTeacher As TextBox
    Friend WithEvents cmbTerm As ComboBox
End Class
