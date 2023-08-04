<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCourse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnClearCourse = New System.Windows.Forms.Button()
        Me.btnCancelCourse = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1162, 43)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Courses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Code"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(122, 156)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(419, 32)
        Me.txtDescription.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description"
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.Color.White
        Me.btnAddCourse.Location = New System.Drawing.Point(122, 227)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(103, 33)
        Me.btnAddCourse.TabIndex = 5
        Me.btnAddCourse.Text = "Add"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'btnDeleteCourse
        '
        Me.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnDeleteCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCourse.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCourse.Location = New System.Drawing.Point(438, 227)
        Me.btnDeleteCourse.Name = "btnDeleteCourse"
        Me.btnDeleteCourse.Size = New System.Drawing.Size(103, 33)
        Me.btnDeleteCourse.TabIndex = 6
        Me.btnDeleteCourse.Text = "Delete"
        Me.btnDeleteCourse.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(122, 96)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(419, 29)
        Me.txtCode.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(576, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(557, 361)
        Me.DataGridView1.TabIndex = 9
        '
        'btnClearCourse
        '
        Me.btnClearCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnClearCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCourse.ForeColor = System.Drawing.Color.White
        Me.btnClearCourse.Location = New System.Drawing.Point(122, 297)
        Me.btnClearCourse.Name = "btnClearCourse"
        Me.btnClearCourse.Size = New System.Drawing.Size(103, 33)
        Me.btnClearCourse.TabIndex = 10
        Me.btnClearCourse.Text = "Clear"
        Me.btnClearCourse.UseVisualStyleBackColor = False
        '
        'btnCancelCourse
        '
        Me.btnCancelCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCancelCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCourse.ForeColor = System.Drawing.Color.White
        Me.btnCancelCourse.Location = New System.Drawing.Point(438, 297)
        Me.btnCancelCourse.Name = "btnCancelCourse"
        Me.btnCancelCourse.Size = New System.Drawing.Size(103, 33)
        Me.btnCancelCourse.TabIndex = 11
        Me.btnCancelCourse.Text = "Cancel"
        Me.btnCancelCourse.UseVisualStyleBackColor = False
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 527)
        Me.Controls.Add(Me.btnCancelCourse)
        Me.Controls.Add(Me.btnClearCourse)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.btnDeleteCourse)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCourse"
        Me.Text = "frmCourse"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents txtCode As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClearCourse As Button
    Friend WithEvents btnCancelCourse As Button
End Class
