<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubject
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
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSaveSubject = New System.Windows.Forms.Button()
        Me.btnBackSubject = New System.Windows.Forms.Button()
        Me.cmbYearLvl = New System.Windows.Forms.ComboBox()
        Me.cmbAY = New System.Windows.Forms.ComboBox()
        Me.lblSubId = New System.Windows.Forms.Label()
        Me.txtSubId = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSchoolYear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 44)
        Me.Panel1.TabIndex = 1
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.ForeColor = System.Drawing.Color.White
        Me.lblSchoolYear.Location = New System.Drawing.Point(28, 9)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(124, 24)
        Me.lblSchoolYear.TabIndex = 0
        Me.lblSchoolYear.Text = "Add Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Subject Code"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(132, 173)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(681, 28)
        Me.txtCode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subject Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(174, 225)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(681, 28)
        Me.txtDescription.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(174, 259)
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(681, 28)
        Me.txtUnit.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Academic Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Year Level"
        '
        'btnSaveSubject
        '
        Me.btnSaveSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSaveSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSubject.ForeColor = System.Drawing.Color.White
        Me.btnSaveSubject.Location = New System.Drawing.Point(728, 519)
        Me.btnSaveSubject.Name = "btnSaveSubject"
        Me.btnSaveSubject.Size = New System.Drawing.Size(99, 41)
        Me.btnSaveSubject.TabIndex = 12
        Me.btnSaveSubject.Text = "Save"
        Me.btnSaveSubject.UseVisualStyleBackColor = False
        '
        'btnBackSubject
        '
        Me.btnBackSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnBackSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSubject.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBackSubject.Location = New System.Drawing.Point(565, 519)
        Me.btnBackSubject.Name = "btnBackSubject"
        Me.btnBackSubject.Size = New System.Drawing.Size(99, 41)
        Me.btnBackSubject.TabIndex = 13
        Me.btnBackSubject.Text = "Back"
        Me.btnBackSubject.UseVisualStyleBackColor = False
        '
        'cmbYearLvl
        '
        Me.cmbYearLvl.FormattingEnabled = True
        Me.cmbYearLvl.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbYearLvl.Location = New System.Drawing.Point(146, 374)
        Me.cmbYearLvl.Name = "cmbYearLvl"
        Me.cmbYearLvl.Size = New System.Drawing.Size(681, 21)
        Me.cmbYearLvl.TabIndex = 14
        '
        'cmbAY
        '
        Me.cmbAY.FormattingEnabled = True
        Me.cmbAY.Items.AddRange(New Object() {"2018-2019", "2019-2020", "2020-2021", "2021-2022"})
        Me.cmbAY.Location = New System.Drawing.Point(146, 459)
        Me.cmbAY.Name = "cmbAY"
        Me.cmbAY.Size = New System.Drawing.Size(681, 21)
        Me.cmbAY.TabIndex = 15
        '
        'lblSubId
        '
        Me.lblSubId.AutoSize = True
        Me.lblSubId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubId.Location = New System.Drawing.Point(68, 61)
        Me.lblSubId.Name = "lblSubId"
        Me.lblSubId.Size = New System.Drawing.Size(85, 18)
        Me.lblSubId.TabIndex = 16
        Me.lblSubId.Text = "Subject ID"
        '
        'txtSubId
        '
        Me.txtSubId.Location = New System.Drawing.Point(146, 82)
        Me.txtSubId.Multiline = True
        Me.txtSubId.Name = "txtSubId"
        Me.txtSubId.Size = New System.Drawing.Size(150, 28)
        Me.txtSubId.TabIndex = 17
        '
        'frmSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 585)
        Me.Controls.Add(Me.txtSubId)
        Me.Controls.Add(Me.lblSubId)
        Me.Controls.Add(Me.cmbAY)
        Me.Controls.Add(Me.cmbYearLvl)
        Me.Controls.Add(Me.btnBackSubject)
        Me.Controls.Add(Me.btnSaveSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSubject"
        Me.Text = "frmSubject"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSchoolYear As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSaveSubject As Button
    Friend WithEvents btnBackSubject As Button
    Friend WithEvents cmbYearLvl As ComboBox
    Friend WithEvents cmbAY As ComboBox
    Friend WithEvents lblSubId As Label
    Friend WithEvents txtSubId As TextBox
End Class
