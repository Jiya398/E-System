<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSection
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
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCourses = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.cmbTeacher = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddSection = New System.Windows.Forms.Button()
        Me.btnDeleteSection = New System.Windows.Forms.Button()
        Me.btnCancelSection = New System.Windows.Forms.Button()
        Me.btnRefreshSection = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 44)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Section"
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbLevel.Location = New System.Drawing.Point(50, 93)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(500, 21)
        Me.cmbLevel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Courses"
        '
        'cmbCourses
        '
        Me.cmbCourses.FormattingEnabled = True
        Me.cmbCourses.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Social Works", "Bachelor of Elementary Education major in General Education", "Bachelor of Science in Administration major in Marketing"})
        Me.cmbCourses.Location = New System.Drawing.Point(50, 254)
        Me.cmbCourses.Name = "cmbCourses"
        Me.cmbCourses.Size = New System.Drawing.Size(500, 21)
        Me.cmbCourses.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"BSIT 1A", "BSIT 2A", "BSIT 2B", "BSIT 3A", "BSIT 3B", "BSIT 4A", "BSSW 1A", "BSSW 2A", "BSSW 3A", "BSSW 4A", "BEED 1A", "BEED 2A", "BEED 3A", "BEED 4A", "BSBA 1A", "BSBA 2A", "BSBA 3A", "BSBA 4A"})
        Me.cmbSection.Location = New System.Drawing.Point(50, 175)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(500, 21)
        Me.cmbSection.TabIndex = 5
        '
        'cmbTeacher
        '
        Me.cmbTeacher.FormattingEnabled = True
        Me.cmbTeacher.Items.AddRange(New Object() {"Mr. Adrian Manansala", "Mr. David Luzon", "Ms. Elizabeth Delos", "Ms. Marianlyn Quiz", "Ms. Blenda King", "Mr. Rando Calma"})
        Me.cmbTeacher.Location = New System.Drawing.Point(50, 336)
        Me.cmbTeacher.Name = "cmbTeacher"
        Me.cmbTeacher.Size = New System.Drawing.Size(500, 21)
        Me.cmbTeacher.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Teacher"
        '
        'btnAddSection
        '
        Me.btnAddSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnAddSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSection.ForeColor = System.Drawing.Color.White
        Me.btnAddSection.Location = New System.Drawing.Point(457, 394)
        Me.btnAddSection.Name = "btnAddSection"
        Me.btnAddSection.Size = New System.Drawing.Size(93, 30)
        Me.btnAddSection.TabIndex = 9
        Me.btnAddSection.Text = "Add"
        Me.btnAddSection.UseVisualStyleBackColor = False
        '
        'btnDeleteSection
        '
        Me.btnDeleteSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnDeleteSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSection.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSection.Location = New System.Drawing.Point(294, 394)
        Me.btnDeleteSection.Name = "btnDeleteSection"
        Me.btnDeleteSection.Size = New System.Drawing.Size(93, 30)
        Me.btnDeleteSection.TabIndex = 10
        Me.btnDeleteSection.Text = "Delete"
        Me.btnDeleteSection.UseVisualStyleBackColor = False
        '
        'btnCancelSection
        '
        Me.btnCancelSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCancelSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSection.ForeColor = System.Drawing.Color.White
        Me.btnCancelSection.Location = New System.Drawing.Point(457, 475)
        Me.btnCancelSection.Name = "btnCancelSection"
        Me.btnCancelSection.Size = New System.Drawing.Size(93, 30)
        Me.btnCancelSection.TabIndex = 11
        Me.btnCancelSection.Text = "Cancel"
        Me.btnCancelSection.UseVisualStyleBackColor = False
        '
        'btnRefreshSection
        '
        Me.btnRefreshSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRefreshSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshSection.ForeColor = System.Drawing.Color.White
        Me.btnRefreshSection.Location = New System.Drawing.Point(294, 475)
        Me.btnRefreshSection.Name = "btnRefreshSection"
        Me.btnRefreshSection.Size = New System.Drawing.Size(93, 30)
        Me.btnRefreshSection.TabIndex = 12
        Me.btnRefreshSection.Text = "Refresh"
        Me.btnRefreshSection.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(574, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(497, 487)
        Me.DataGridView1.TabIndex = 13
        '
        'frmSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 569)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRefreshSection)
        Me.Controls.Add(Me.btnCancelSection)
        Me.Controls.Add(Me.btnDeleteSection)
        Me.Controls.Add(Me.btnAddSection)
        Me.Controls.Add(Me.cmbTeacher)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCourses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSection"
        Me.Text = "7"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCourses As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents cmbTeacher As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddSection As Button
    Friend WithEvents btnDeleteSection As Button
    Friend WithEvents btnCancelSection As Button
    Friend WithEvents btnRefreshSection As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
