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
        Me.cbStatus = New System.Windows.Forms.CheckBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1768, 1019)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbStatus)
        Me.GroupBox2.Controls.Add(Me.txtRemark)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btUpdateAll)
        Me.GroupBox2.Controls.Add(Me.btAddYouth)
        Me.GroupBox2.Controls.Add(Me.btRemoveYouth)
        Me.GroupBox2.Controls.Add(Me.dgvYouthList)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 192)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1740, 796)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายชื่อเยาวชนที่เข้าร่วมกิจกรรม"
        '
        'cbStatus
        '
        Me.cbStatus.AutoSize = True
        Me.cbStatus.Location = New System.Drawing.Point(1355, 57)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(88, 29)
        Me.cbStatus.TabIndex = 12
        Me.cbStatus.Text = "เข้าร่วม"
        Me.cbStatus.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(722, 55)
        Me.txtRemark.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(616, 30)
        Me.txtRemark.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(628, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "หมายเหตุ"
        '
        'btUpdateAll
        '
        Me.btUpdateAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateAll.Location = New System.Drawing.Point(1502, 48)
        Me.btUpdateAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btUpdateAll.Name = "btUpdateAll"
        Me.btUpdateAll.Size = New System.Drawing.Size(111, 45)
        Me.btUpdateAll.TabIndex = 9
        Me.btUpdateAll.Text = "แก้ไขรายการ"
        Me.btUpdateAll.UseVisualStyleBackColor = True
        '
        'btAddYouth
        '
        Me.btAddYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddYouth.Location = New System.Drawing.Point(20, 48)
        Me.btAddYouth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btAddYouth.Name = "btAddYouth"
        Me.btAddYouth.Size = New System.Drawing.Size(120, 45)
        Me.btAddYouth.TabIndex = 8
        Me.btAddYouth.Text = "เพิ่มเยาวชน"
        Me.btAddYouth.UseVisualStyleBackColor = True
        '
        'btRemoveYouth
        '
        Me.btRemoveYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRemoveYouth.Location = New System.Drawing.Point(1621, 48)
        Me.btRemoveYouth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btRemoveYouth.Name = "btRemoveYouth"
        Me.btRemoveYouth.Size = New System.Drawing.Size(110, 45)
        Me.btRemoveYouth.TabIndex = 7
        Me.btRemoveYouth.Text = "ลบรายการ"
        Me.btRemoveYouth.UseVisualStyleBackColor = True
        '
        'dgvYouthList
        '
        Me.dgvYouthList.AllowUserToAddRows = False
        Me.dgvYouthList.AllowUserToDeleteRows = False
        Me.dgvYouthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvYouthList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvYouthList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYouthList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.No, Me.idcard, Me.fullname, Me.blakcno, Me.Case_Title, Me.phone, Me.Address, Me.sex, Me.religion, Me.shirt_size, Me.shoe_size, Me.status, Me.remark})
        Me.dgvYouthList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvYouthList.Location = New System.Drawing.Point(20, 102)
        Me.dgvYouthList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvYouthList.Name = "dgvYouthList"
        Me.dgvYouthList.ReadOnly = True
        Me.dgvYouthList.Size = New System.Drawing.Size(1712, 614)
        Me.dgvYouthList.TabIndex = 6
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 67
        '
        'No
        '
        Me.No.DataPropertyName = "no"
        Me.No.HeaderText = "ลำดับที่"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 99
        '
        'idcard
        '
        Me.idcard.HeaderText = "บัตรประชาชน"
        Me.idcard.Name = "idcard"
        Me.idcard.ReadOnly = True
        Me.idcard.Width = 149
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 135
        '
        'blakcno
        '
        Me.blakcno.DataPropertyName = "blackno"
        Me.blakcno.HeaderText = "เลขคดีดำ"
        Me.blakcno.Name = "blakcno"
        Me.blakcno.ReadOnly = True
        Me.blakcno.Width = 113
        '
        'Case_Title
        '
        Me.Case_Title.HeaderText = "ชื่อคดี"
        Me.Case_Title.Name = "Case_Title"
        Me.Case_Title.ReadOnly = True
        Me.Case_Title.Width = 90
        '
        'phone
        '
        Me.phone.HeaderText = "เบอร์โทร"
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Width = 108
        '
        'Address
        '
        Me.Address.HeaderText = "ที่อยู่"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 79
        '
        'sex
        '
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "เพศ"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Width = 76
        '
        'religion
        '
        Me.religion.HeaderText = "ศาสนา"
        Me.religion.Name = "religion"
        Me.religion.ReadOnly = True
        Me.religion.Width = 97
        '
        'shirt_size
        '
        Me.shirt_size.DataPropertyName = "shirt_size"
        Me.shirt_size.HeaderText = "ขนาดเสื้อ"
        Me.shirt_size.Name = "shirt_size"
        Me.shirt_size.ReadOnly = True
        Me.shirt_size.Width = 113
        '
        'shoe_size
        '
        Me.shoe_size.DataPropertyName = "shoe_size"
        Me.shoe_size.HeaderText = "ขนาดรองเท้า"
        Me.shoe_size.Name = "shoe_size"
        Me.shoe_size.ReadOnly = True
        Me.shoe_size.Width = 139
        '
        'status
        '
        Me.status.HeaderText = "เข้าร่วม"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 98
        '
        'remark
        '
        Me.remark.HeaderText = "หมายเหตุ"
        Me.remark.Name = "remark"
        Me.remark.ReadOnly = True
        Me.remark.Width = 117
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
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1740, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลทั่วไป"
        '
        'btSaveActivity
        '
        Me.btSaveActivity.Location = New System.Drawing.Point(1502, 114)
        Me.btSaveActivity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btSaveActivity.Name = "btSaveActivity"
        Me.btSaveActivity.Size = New System.Drawing.Size(229, 45)
        Me.btSaveActivity.TabIndex = 8
        Me.btSaveActivity.Text = "บันทึกกิจกรรม"
        Me.btSaveActivity.UseVisualStyleBackColor = True
        '
        'btSearch
        '
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.Location = New System.Drawing.Point(1677, 22)
        Me.btSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(54, 55)
        Me.btSearch.TabIndex = 5
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'dtpActDate
        '
        Me.dtpActDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpActDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActDate.Location = New System.Drawing.Point(722, 75)
        Me.dtpActDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpActDate.Name = "dtpActDate"
        Me.dtpActDate.Size = New System.Drawing.Size(181, 30)
        Me.dtpActDate.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(664, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "วันที่"
        '
        'cbDepartment
        '
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Location = New System.Drawing.Point(126, 118)
        Me.cbDepartment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(499, 33)
        Me.cbDepartment.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "หน่วยงาน"
        '
        'tbLocation
        '
        Me.tbLocation.Location = New System.Drawing.Point(126, 75)
        Me.tbLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(499, 30)
        Me.tbLocation.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "สถานที่"
        '
        'tbName
        '
        Me.tbName.AcceptsReturn = True
        Me.tbName.Location = New System.Drawing.Point(126, 32)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(1540, 30)
        Me.tbName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อกิจกรรม"
        '
        'Act_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1776, 1038)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Act_Info"
        Me.Text = "ข้อมูลกิจกรรมแก้ไขบำบัดฟื้นฟู"
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
    Friend WithEvents cbStatus As CheckBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label5 As Label
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
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents remark As DataGridViewTextBoxColumn
End Class
