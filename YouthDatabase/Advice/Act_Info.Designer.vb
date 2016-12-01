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
        Me.btUpdateAll = New System.Windows.Forms.Button()
        Me.btAddYouth = New System.Windows.Forms.Button()
        Me.btRemoveYouth = New System.Windows.Forms.Button()
        Me.dgvYouthList = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blakcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Case_Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.religion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shirt_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shoe_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSaveActivity = New System.Windows.Forms.Button()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.dtpActDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(1179, 744)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btUpdateAll)
        Me.GroupBox2.Controls.Add(Me.btAddYouth)
        Me.GroupBox2.Controls.Add(Me.btRemoveYouth)
        Me.GroupBox2.Controls.Add(Me.dgvYouthList)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1160, 593)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายชื่อเยาวชนที่เข้าร่วมกิจกรรม"
        '
        'btUpdateAll
        '
        Me.btUpdateAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btUpdateAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateAll.Location = New System.Drawing.Point(892, 22)
        Me.btUpdateAll.Name = "btUpdateAll"
        Me.btUpdateAll.Size = New System.Drawing.Size(128, 29)
        Me.btUpdateAll.TabIndex = 9
        Me.btUpdateAll.Text = "แก้ไขรายการทั้งหมด"
        Me.btUpdateAll.UseVisualStyleBackColor = True
        '
        'btAddYouth
        '
        Me.btAddYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddYouth.Location = New System.Drawing.Point(13, 31)
        Me.btAddYouth.Name = "btAddYouth"
        Me.btAddYouth.Size = New System.Drawing.Size(80, 29)
        Me.btAddYouth.TabIndex = 8
        Me.btAddYouth.Text = "เพิ่มเยาวชน"
        Me.btAddYouth.UseVisualStyleBackColor = True
        '
        'btRemoveYouth
        '
        Me.btRemoveYouth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRemoveYouth.Location = New System.Drawing.Point(1026, 22)
        Me.btRemoveYouth.Name = "btRemoveYouth"
        Me.btRemoveYouth.Size = New System.Drawing.Size(128, 29)
        Me.btRemoveYouth.TabIndex = 7
        Me.btRemoveYouth.Text = "ลบรายการ"
        Me.btRemoveYouth.UseVisualStyleBackColor = True
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
        Me.dgvYouthList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.No, Me.idcard, Me.fullname, Me.blakcno, Me.Case_Title, Me.phone, Me.Address, Me.sex, Me.religion, Me.shirt_size, Me.shoe_size, Me.status})
        Me.dgvYouthList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvYouthList.Location = New System.Drawing.Point(13, 66)
        Me.dgvYouthList.Name = "dgvYouthList"
        Me.dgvYouthList.Size = New System.Drawing.Size(1141, 412)
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
        Me.No.Width = 70
        '
        'idcard
        '
        Me.idcard.HeaderText = "บัตรประชาชน"
        Me.idcard.Name = "idcard"
        Me.idcard.Width = 108
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 98
        '
        'blakcno
        '
        Me.blakcno.DataPropertyName = "blackno"
        Me.blakcno.HeaderText = "เลขคดีดำ"
        Me.blakcno.Name = "blakcno"
        Me.blakcno.Width = 82
        '
        'Case_Title
        '
        Me.Case_Title.HeaderText = "ชื่อคดี"
        Me.Case_Title.Name = "Case_Title"
        Me.Case_Title.Width = 64
        '
        'phone
        '
        Me.phone.HeaderText = "เบอร์โทร"
        Me.phone.Name = "phone"
        Me.phone.Width = 80
        '
        'Address
        '
        Me.Address.HeaderText = "ที่อยู่"
        Me.Address.Name = "Address"
        Me.Address.Width = 55
        '
        'sex
        '
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "เพศ"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Width = 54
        '
        'religion
        '
        Me.religion.HeaderText = "ศาสนา"
        Me.religion.Name = "religion"
        Me.religion.Width = 69
        '
        'shirt_size
        '
        Me.shirt_size.DataPropertyName = "shirt_size"
        Me.shirt_size.HeaderText = "ขนาดเสื้อ"
        Me.shirt_size.Name = "shirt_size"
        Me.shirt_size.ReadOnly = True
        Me.shirt_size.Width = 82
        '
        'shoe_size
        '
        Me.shoe_size.DataPropertyName = "shoe_size"
        Me.shoe_size.HeaderText = "ขนาดรองเท้า"
        Me.shoe_size.Name = "shoe_size"
        Me.shoe_size.ReadOnly = True
        Me.shoe_size.Width = 102
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.FalseValue = "0"
        Me.status.HeaderText = "เข้าร่วม"
        Me.status.Name = "status"
        Me.status.TrueValue = "1"
        Me.status.Width = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btSaveActivity)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.dtpActDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbDepartment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbLocation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลทั่วไป"
        '
        'btSaveActivity
        '
        Me.btSaveActivity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSaveActivity.Location = New System.Drawing.Point(1036, 74)
        Me.btSaveActivity.Name = "btSaveActivity"
        Me.btSaveActivity.Size = New System.Drawing.Size(118, 29)
        Me.btSaveActivity.TabIndex = 8
        Me.btSaveActivity.Text = "บันทึกกิจกรรม"
        Me.btSaveActivity.UseVisualStyleBackColor = True
        '
        'btSearch
        '
        Me.btSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.Location = New System.Drawing.Point(1118, 14)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(36, 36)
        Me.btSearch.TabIndex = 5
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'dtpActDate
        '
        Me.dtpActDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpActDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActDate.Location = New System.Drawing.Point(481, 49)
        Me.dtpActDate.Name = "dtpActDate"
        Me.dtpActDate.Size = New System.Drawing.Size(122, 23)
        Me.dtpActDate.TabIndex = 1
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
        'cbDepartment
        '
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Location = New System.Drawing.Point(84, 77)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(334, 24)
        Me.cbDepartment.TabIndex = 4
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
        'tbLocation
        '
        Me.tbLocation.Location = New System.Drawing.Point(84, 49)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(334, 23)
        Me.tbLocation.TabIndex = 3
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
        'tbName
        '
        Me.tbName.AcceptsReturn = True
        Me.tbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.Location = New System.Drawing.Point(84, 21)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(1028, 23)
        Me.tbName.TabIndex = 1
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
        Me.ClientSize = New System.Drawing.Size(1184, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Act_Info"
        Me.Text = "ข้อมูลกิจกรรมแก้ไขบำบัดฟื้นฟู"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvYouthList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpActDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvYouthList As DataGridView
    Friend WithEvents btSaveActivity As Button
    Friend WithEvents btRemoveYouth As Button
    Friend WithEvents btSearch As Button
    Friend WithEvents btAddYouth As Button
    Friend WithEvents btUpdateAll As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents idcard As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents blakcno As DataGridViewTextBoxColumn
    Friend WithEvents Case_Title As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents sex As DataGridViewTextBoxColumn
    Friend WithEvents religion As DataGridViewTextBoxColumn
    Friend WithEvents shirt_size As DataGridViewTextBoxColumn
    Friend WithEvents shoe_size As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewCheckBoxColumn
End Class
