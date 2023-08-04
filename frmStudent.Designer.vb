<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtguardianadd = New System.Windows.Forms.RichTextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtguardiantel = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtguardian = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cboAddSy = New System.Windows.Forms.ComboBox()
        Me.txtLastSchoolAttend = New System.Windows.Forms.RichTextBox()
        Me.txtPBirth = New System.Windows.Forms.RichTextBox()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.dtpDbirth = New System.Windows.Forms.DateTimePicker()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeigth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnGenerateIDNO = New System.Windows.Forms.Button()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tsSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSaveStudent = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Students"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 51)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1032, 505)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnGenerateIDNO)
        Me.TabPage1.Controls.Add(Me.txtStudentId)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1024, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Students"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtguardianadd)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.txtguardiantel)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.txtguardian)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.cboAddSy)
        Me.GroupBox1.Controls.Add(Me.txtLastSchoolAttend)
        Me.GroupBox1.Controls.Add(Me.txtPBirth)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.rdoFemale)
        Me.GroupBox1.Controls.Add(Me.rdoMale)
        Me.GroupBox1.Controls.Add(Me.dtpDbirth)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtWeigth)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(955, 410)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'txtguardianadd
        '
        Me.txtguardianadd.Location = New System.Drawing.Point(589, 249)
        Me.txtguardianadd.Name = "txtguardianadd"
        Me.txtguardianadd.Size = New System.Drawing.Size(344, 81)
        Me.txtguardianadd.TabIndex = 13
        Me.txtguardianadd.Text = ""
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(499, 252)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(73, 16)
        Me.Label61.TabIndex = 34
        Me.Label61.Text = "Address :"
        '
        'txtguardiantel
        '
        Me.txtguardiantel.Location = New System.Drawing.Point(104, 293)
        Me.txtguardiantel.Name = "txtguardiantel"
        Me.txtguardiantel.Size = New System.Drawing.Size(367, 22)
        Me.txtguardiantel.TabIndex = 12
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(19, 293)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(38, 16)
        Me.Label60.TabIndex = 32
        Me.Label60.Text = "Tel :"
        '
        'txtguardian
        '
        Me.txtguardian.Location = New System.Drawing.Point(104, 252)
        Me.txtguardian.Name = "txtguardian"
        Me.txtguardian.Size = New System.Drawing.Size(367, 22)
        Me.txtguardian.TabIndex = 11
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(19, 252)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(78, 16)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "Guardian :"
        '
        'cboAddSy
        '
        Me.cboAddSy.FormattingEnabled = True
        Me.cboAddSy.Items.AddRange(New Object() {"2018-2019", "2019-2020", "2020-2021", "2021-2022", "2022-2023"})
        Me.cboAddSy.Location = New System.Drawing.Point(606, 355)
        Me.cboAddSy.Name = "cboAddSy"
        Me.cboAddSy.Size = New System.Drawing.Size(311, 24)
        Me.cboAddSy.TabIndex = 15
        '
        'txtLastSchoolAttend
        '
        Me.txtLastSchoolAttend.Location = New System.Drawing.Point(104, 355)
        Me.txtLastSchoolAttend.Name = "txtLastSchoolAttend"
        Me.txtLastSchoolAttend.Size = New System.Drawing.Size(367, 52)
        Me.txtLastSchoolAttend.TabIndex = 14
        Me.txtLastSchoolAttend.Text = ""
        '
        'txtPBirth
        '
        Me.txtPBirth.Location = New System.Drawing.Point(545, 124)
        Me.txtPBirth.Name = "txtPBirth"
        Me.txtPBirth.Size = New System.Drawing.Size(388, 37)
        Me.txtPBirth.TabIndex = 5
        Me.txtPBirth.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(22, 124)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(416, 37)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(499, 355)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 16)
        Me.Label29.TabIndex = 23
        Me.Label29.Text = "School Year :"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(19, 336)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(162, 16)
        Me.Label51.TabIndex = 23
        Me.Label51.Text = "Last School Attended :"
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(552, 202)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(77, 20)
        Me.rdoFemale.TabIndex = 8
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(486, 202)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(59, 20)
        Me.rdoMale.TabIndex = 7
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'dtpDbirth
        '
        Me.dtpDbirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpDbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDbirth.Location = New System.Drawing.Point(22, 201)
        Me.dtpDbirth.Name = "dtpDbirth"
        Me.dtpDbirth.Size = New System.Drawing.Size(176, 22)
        Me.dtpDbirth.TabIndex = 6
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(836, 200)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(96, 22)
        Me.txtHeight.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(833, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Height :"
        '
        'txtWeigth
        '
        Me.txtWeigth.Location = New System.Drawing.Point(709, 200)
        Me.txtWeigth.Name = "txtWeigth"
        Me.txtWeigth.Size = New System.Drawing.Size(96, 22)
        Me.txtWeigth.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(706, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Weight :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(483, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Sex :"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(252, 203)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(144, 22)
        Me.txtAge.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(249, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Age :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 16)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Date Of Birth :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(542, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Place Of Birth :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Address :"
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(689, 63)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(243, 22)
        Me.txtMName.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(686, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 18)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Middle Name :"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(400, 63)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(252, 22)
        Me.txtFName.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(400, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "First Name :"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(22, 63)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(328, 22)
        Me.txtLName.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Last Name :"
        '
        'btnGenerateIDNO
        '
        Me.btnGenerateIDNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateIDNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateIDNO.Location = New System.Drawing.Point(662, 6)
        Me.btnGenerateIDNO.Name = "btnGenerateIDNO"
        Me.btnGenerateIDNO.Size = New System.Drawing.Size(114, 26)
        Me.btnGenerateIDNO.TabIndex = 50
        Me.btnGenerateIDNO.Text = "Genarate ID No."
        Me.btnGenerateIDNO.UseVisualStyleBackColor = True
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(138, 6)
        Me.txtStudentId.Multiline = True
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(442, 26)
        Me.txtStudentId.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tsSearch)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1024, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List of Students"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tsSearch
        '
        Me.tsSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSearch.Location = New System.Drawing.Point(557, 407)
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(441, 30)
        Me.tsSearch.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Find Student :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(182, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(48, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 369)
        Me.DataGridView1.TabIndex = 0
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSaveStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStudent.ForeColor = System.Drawing.Color.White
        Me.btnSaveStudent.Location = New System.Drawing.Point(939, 583)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(89, 36)
        Me.btnSaveStudent.TabIndex = 4
        Me.btnSaveStudent.Text = "Save"
        Me.btnSaveStudent.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(830, 583)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 631)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSaveStudent)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStudent"
        Me.Text = "frmStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtguardianadd As RichTextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents txtguardiantel As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txtguardian As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents cboAddSy As ComboBox
    Friend WithEvents txtLastSchoolAttend As RichTextBox
    Friend WithEvents txtPBirth As RichTextBox
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents dtpDbirth As DateTimePicker
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWeigth As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnGenerateIDNO As Button
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tsSearch As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents Button2 As Button
    Public WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSaveStudent As Button
    Friend WithEvents Button4 As Button
End Class
