<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pb_search_youth
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
        Me.cbCaseType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbBlackNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCaseNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvYouth = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.case_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caseno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blackno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbIdcard = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbLastname = New System.Windows.Forms.TextBox()
        Me.tbFirstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvYouth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cbCaseType)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbBlackNo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbCaseNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvYouth)
        Me.Panel1.Controls.Add(Me.btSearch)
        Me.Panel1.Controls.Add(Me.tbIdcard)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbLastname)
        Me.Panel1.Controls.Add(Me.tbFirstname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 568)
        Me.Panel1.TabIndex = 2
        '
        'cbCaseType
        '
        Me.cbCaseType.FormattingEnabled = True
        Me.cbCaseType.Location = New System.Drawing.Point(824, 57)
        Me.cbCaseType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbCaseType.Name = "cbCaseType"
        Me.cbCaseType.Size = New System.Drawing.Size(200, 33)
        Me.cbCaseType.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(720, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ประเภทคดี"
        '
        'tbBlackNo
        '
        Me.tbBlackNo.Location = New System.Drawing.Point(476, 57)
        Me.tbBlackNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBlackNo.Name = "tbBlackNo"
        Me.tbBlackNo.Size = New System.Drawing.Size(178, 30)
        Me.tbBlackNo.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "หมายเลขคดีดำ"
        '
        'tbCaseNo
        '
        Me.tbCaseNo.Location = New System.Drawing.Point(135, 57)
        Me.tbCaseNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCaseNo.Name = "tbCaseNo"
        Me.tbCaseNo.Size = New System.Drawing.Size(178, 30)
        Me.tbCaseNo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "หมายเลขคดี"
        '
        'dgvYouth
        '
        Me.dgvYouth.AllowUserToAddRows = False
        Me.dgvYouth.AllowUserToDeleteRows = False
        Me.dgvYouth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvYouth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvYouth.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvYouth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYouth.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.no, Me.fullname, Me.idcard, Me.case_id, Me.caseno, Me.blackno, Me.name})
        Me.dgvYouth.Location = New System.Drawing.Point(14, 112)
        Me.dgvYouth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvYouth.Name = "dgvYouth"
        Me.dgvYouth.ReadOnly = True
        Me.dgvYouth.Size = New System.Drawing.Size(1137, 435)
        Me.dgvYouth.TabIndex = 13
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
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.no.DataPropertyName = "no"
        Me.no.HeaderText = "ลำดับที่"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 99
        '
        'fullname
        '
        Me.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 135
        '
        'idcard
        '
        Me.idcard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.idcard.DataPropertyName = "idcard"
        Me.idcard.HeaderText = "รหัสบัตรประชาชน"
        Me.idcard.Name = "idcard"
        Me.idcard.ReadOnly = True
        Me.idcard.Width = 178
        '
        'case_id
        '
        Me.case_id.DataPropertyName = "case_id"
        Me.case_id.HeaderText = "caseid"
        Me.case_id.Name = "case_id"
        Me.case_id.ReadOnly = True
        Me.case_id.Visible = False
        Me.case_id.Width = 74
        '
        'caseno
        '
        Me.caseno.DataPropertyName = "caseno"
        Me.caseno.HeaderText = "เลขคดี"
        Me.caseno.Name = "caseno"
        Me.caseno.ReadOnly = True
        Me.caseno.Width = 94
        '
        'blackno
        '
        Me.blackno.DataPropertyName = "blackno"
        Me.blackno.HeaderText = "เลขคดีดำ"
        Me.blackno.Name = "blackno"
        Me.blackno.ReadOnly = True
        Me.blackno.Width = 113
        '
        'name
        '
        Me.name.DataPropertyName = "name"
        Me.name.HeaderText = "ประเภทคดี"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        Me.name.Width = 126
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(1038, 12)
        Me.btSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(112, 35)
        Me.btSearch.TabIndex = 12
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'tbIdcard
        '
        Me.tbIdcard.Location = New System.Drawing.Point(824, 12)
        Me.tbIdcard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbIdcard.Name = "tbIdcard"
        Me.tbIdcard.Size = New System.Drawing.Size(200, 30)
        Me.tbIdcard.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(673, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "เลขบัตรประชาชน"
        '
        'tbLastname
        '
        Me.tbLastname.Location = New System.Drawing.Point(476, 12)
        Me.tbLastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLastname.Name = "tbLastname"
        Me.tbLastname.Size = New System.Drawing.Size(178, 30)
        Me.tbLastname.TabIndex = 8
        '
        'tbFirstname
        '
        Me.tbFirstname.Location = New System.Drawing.Point(138, 12)
        Me.tbFirstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.Size = New System.Drawing.Size(178, 30)
        Me.tbFirstname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(396, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อ"
        '
        'pb_search_youth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 711)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        'Me.name = "pb_search_youth"
        Me.Text = "ค้นหาเยาวชน"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvYouth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvYouth As DataGridView
    Friend WithEvents btSearch As Button
    Friend WithEvents tbIdcard As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBlackNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCaseNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCaseType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents idcard As DataGridViewTextBoxColumn
    Friend WithEvents case_id As DataGridViewTextBoxColumn
    Friend WithEvents caseno As DataGridViewTextBoxColumn
    Friend WithEvents blackno As DataGridViewTextBoxColumn
    Friend Shadows WithEvents name As DataGridViewTextBoxColumn
End Class
