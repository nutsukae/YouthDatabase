<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Act_Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Act_Info))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvYouthList = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shirt_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shoe_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mtbSearchID = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvYouthList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 723)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.dgvYouthList)
        Me.GroupBox2.Controls.Add(Me.mtbSearchID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 572)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายชื่อเยาวชนที่เข้าร่วมกิจกรรม"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(234, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 29)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "เพิ่มเยาวชน"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(894, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ลบรายการ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvYouthList
        '
        Me.dgvYouthList.AllowUserToAddRows = False
        Me.dgvYouthList.AllowUserToDeleteRows = False
        Me.dgvYouthList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvYouthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvYouthList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvYouthList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYouthList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.No, Me.IDCard, Me.fullname, Me.sex, Me.age, Me.shirt_size, Me.shoe_size, Me.status})
        Me.dgvYouthList.Location = New System.Drawing.Point(35, 66)
        Me.dgvYouthList.Name = "dgvYouthList"
        Me.dgvYouthList.ReadOnly = True
        Me.dgvYouthList.Size = New System.Drawing.Size(842, 491)
        Me.dgvYouthList.TabIndex = 6
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 46
        '
        'No
        '
        Me.No.DataPropertyName = "no"
        Me.No.HeaderText = "ลำดับที่"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 65
        '
        'IDCard
        '
        Me.IDCard.DataPropertyName = "idcard"
        Me.IDCard.HeaderText = "เลขบัตรประชาชน"
        Me.IDCard.Name = "IDCard"
        Me.IDCard.ReadOnly = True
        Me.IDCard.Width = 116
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 90
        '
        'sex
        '
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "เพศ"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Width = 54
        '
        'age
        '
        Me.age.DataPropertyName = "age"
        Me.age.HeaderText = "อายุ"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.Width = 53
        '
        'shirt_size
        '
        Me.shirt_size.DataPropertyName = "shirt_size"
        Me.shirt_size.HeaderText = "ขนาดเสื้อ"
        Me.shirt_size.Name = "shirt_size"
        Me.shirt_size.ReadOnly = True
        Me.shirt_size.Width = 76
        '
        'shoe_size
        '
        Me.shoe_size.DataPropertyName = "shoe_size"
        Me.shoe_size.HeaderText = "ขนาดรองเท้า"
        Me.shoe_size.Name = "shoe_size"
        Me.shoe_size.ReadOnly = True
        Me.shoe_size.Width = 94
        '
        'status
        '
        Me.status.HeaderText = "เข้าร่วม"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 49
        '
        'mtbSearchID
        '
        Me.mtbSearchID.Location = New System.Drawing.Point(108, 31)
        Me.mtbSearchID.Mask = "0-0000-00000-00-0"
        Me.mtbSearchID.Name = "mtbSearchID"
        Me.mtbSearchID.Size = New System.Drawing.Size(120, 23)
        Me.mtbSearchID.TabIndex = 4
        Me.mtbSearchID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "เพิ่มเยาวชน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลทั่วไป"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(860, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 29)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "บันทึกกิจกรรม"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(942, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 36)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "dd MMM yyyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(481, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 23)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "วันที่"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(334, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "หน่วยงาน"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(334, 23)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "สถานที่"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(84, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(852, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อกิจกรรม"
        '
        'Act_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Act_Info"
        Me.Text = "ข้อมูลกิจกรรม"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvYouthList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mtbSearchID As MaskedTextBox
    Friend WithEvents dgvYouthList As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents IDCard As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents sex As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents shirt_size As DataGridViewTextBoxColumn
    Friend WithEvents shoe_size As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewCheckBoxColumn
End Class
