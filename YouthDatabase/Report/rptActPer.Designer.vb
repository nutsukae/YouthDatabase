<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptActPer
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
        Me.dgvYouthList = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgvYouthList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvYouthList
        '
        Me.dgvYouthList.AllowUserToAddRows = False
        Me.dgvYouthList.AllowUserToDeleteRows = False
        Me.dgvYouthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvYouthList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvYouthList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYouthList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.No, Me.ref, Me.idcard, Me.fullname, Me.blakcno, Me.Case_Title, Me.phone, Me.Address, Me.sex, Me.religion, Me.shirt_size, Me.shoe_size, Me.status, Me.remark})
        Me.dgvYouthList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvYouthList.Location = New System.Drawing.Point(7, 5)
        Me.dgvYouthList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvYouthList.Name = "dgvYouthList"
        Me.dgvYouthList.ReadOnly = True
        Me.dgvYouthList.Size = New System.Drawing.Size(605, 100)
        Me.dgvYouthList.TabIndex = 7
        Me.dgvYouthList.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 62
        '
        'No
        '
        Me.No.DataPropertyName = "no"
        Me.No.HeaderText = "ลำดับที่"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 88
        '
        'ref
        '
        Me.ref.DataPropertyName = "ref"
        Me.ref.HeaderText = "หน่วยงาน"
        Me.ref.Name = "ref"
        Me.ref.ReadOnly = True
        Me.ref.Width = 101
        '
        'idcard
        '
        Me.idcard.HeaderText = "บัตรประชาชน"
        Me.idcard.Name = "idcard"
        Me.idcard.ReadOnly = True
        Me.idcard.Width = 127
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 118
        '
        'blakcno
        '
        Me.blakcno.DataPropertyName = "blackno"
        Me.blakcno.HeaderText = "เลขคดีดำ"
        Me.blakcno.Name = "blakcno"
        Me.blakcno.ReadOnly = True
        Me.blakcno.Width = 102
        '
        'Case_Title
        '
        Me.Case_Title.HeaderText = "ชื่อคดี"
        Me.Case_Title.Name = "Case_Title"
        Me.Case_Title.ReadOnly = True
        Me.Case_Title.Width = 80
        '
        'phone
        '
        Me.phone.HeaderText = "เบอร์โทร"
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Width = 99
        '
        'Address
        '
        Me.Address.HeaderText = "ที่อยู่"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 71
        '
        'sex
        '
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "เพศ"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Width = 70
        '
        'religion
        '
        Me.religion.HeaderText = "ศาสนา"
        Me.religion.Name = "religion"
        Me.religion.ReadOnly = True
        Me.religion.Width = 85
        '
        'shirt_size
        '
        Me.shirt_size.DataPropertyName = "shirt_size"
        Me.shirt_size.HeaderText = "ขนาดเสื้อ"
        Me.shirt_size.Name = "shirt_size"
        Me.shirt_size.ReadOnly = True
        Me.shirt_size.Width = 101
        '
        'shoe_size
        '
        Me.shoe_size.DataPropertyName = "shoe_size"
        Me.shoe_size.HeaderText = "ขนาดรองเท้า"
        Me.shoe_size.Name = "shoe_size"
        Me.shoe_size.ReadOnly = True
        Me.shoe_size.Width = 124
        '
        'status
        '
        Me.status.HeaderText = "เข้าร่วม"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 91
        '
        'remark
        '
        Me.remark.HeaderText = "หมายเหตุ"
        Me.remark.Name = "remark"
        Me.remark.ReadOnly = True
        Me.remark.Width = 103
        '
        'rptActPer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 129)
        Me.Controls.Add(Me.dgvYouthList)
        Me.Name = "rptActPer"
        Me.Text = "รายงานรายละเอียดกิจกรรม"
        CType(Me.dgvYouthList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvYouthList As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents ref As DataGridViewTextBoxColumn
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
