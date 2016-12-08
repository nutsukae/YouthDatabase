<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep2Pb
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbHasNextTime = New System.Windows.Forms.CheckBox()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.cbISUA = New System.Windows.Forms.CheckBox()
        Me.cbNextDays = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMainAssociateJudge = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpActDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEstDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbFullname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btSearch)
        Me.Panel1.Controls.Add(Me.tbFullname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 349)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbHasNextTime)
        Me.GroupBox1.Controls.Add(Me.btReset)
        Me.GroupBox1.Controls.Add(Me.btSubmit)
        Me.GroupBox1.Controls.Add(Me.cbISUA)
        Me.GroupBox1.Controls.Add(Me.cbNextDays)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbRemark)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMainAssociateJudge)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpActDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbEstDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvReport)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(891, 295)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "บันทึกผลการรายงานตัว"
        '
        'cbHasNextTime
        '
        Me.cbHasNextTime.AutoSize = True
        Me.cbHasNextTime.Location = New System.Drawing.Point(687, 190)
        Me.cbHasNextTime.Name = "cbHasNextTime"
        Me.cbHasNextTime.Size = New System.Drawing.Size(104, 21)
        Me.cbHasNextTime.TabIndex = 47
        Me.cbHasNextTime.Text = "มีนัดครั้งถัดไป"
        Me.cbHasNextTime.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(729, 256)
        Me.btReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(68, 27)
        Me.btReset.TabIndex = 46
        Me.btReset.Text = "ยกเลิก"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btSubmit
        '
        Me.btSubmit.Location = New System.Drawing.Point(650, 256)
        Me.btSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(68, 27)
        Me.btSubmit.TabIndex = 45
        Me.btSubmit.Text = "บันทึก"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'cbISUA
        '
        Me.cbISUA.AutoSize = True
        Me.cbISUA.Location = New System.Drawing.Point(687, 150)
        Me.cbISUA.Margin = New System.Windows.Forms.Padding(2)
        Me.cbISUA.Name = "cbISUA"
        Me.cbISUA.Size = New System.Drawing.Size(126, 21)
        Me.cbISUA.TabIndex = 44
        Me.cbISUA.Text = "มีการตรวจปัสสาวะ"
        Me.cbISUA.UseVisualStyleBackColor = True
        '
        'cbNextDays
        '
        Me.cbNextDays.Enabled = False
        Me.cbNextDays.FormattingEnabled = True
        Me.cbNextDays.Items.AddRange(New Object() {"30 วัน", "60 วัน", "90 วัน", "180 วัน"})
        Me.cbNextDays.Location = New System.Drawing.Point(687, 217)
        Me.cbNextDays.Name = "cbNextDays"
        Me.cbNextDays.Size = New System.Drawing.Size(75, 24)
        Me.cbNextDays.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(604, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "นัดครั้งถัดไป"
        '
        'tbRemark
        '
        Me.tbRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRemark.Location = New System.Drawing.Point(687, 102)
        Me.tbRemark.Margin = New System.Windows.Forms.Padding(2)
        Me.tbRemark.Multiline = True
        Me.tbRemark.Name = "tbRemark"
        Me.tbRemark.Size = New System.Drawing.Size(200, 43)
        Me.tbRemark.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "บันทึกผล"
        '
        'cbMainAssociateJudge
        '
        Me.cbMainAssociateJudge.FormattingEnabled = True
        Me.cbMainAssociateJudge.Location = New System.Drawing.Point(687, 75)
        Me.cbMainAssociateJudge.Name = "cbMainAssociateJudge"
        Me.cbMainAssociateJudge.Size = New System.Drawing.Size(200, 24)
        Me.cbMainAssociateJudge.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(598, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "ผู้รับรายงานตัว"
        '
        'dtpActDate
        '
        Me.dtpActDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpActDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActDate.Location = New System.Drawing.Point(687, 49)
        Me.dtpActDate.Name = "dtpActDate"
        Me.dtpActDate.Size = New System.Drawing.Size(122, 23)
        Me.dtpActDate.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(583, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "วันที่มารายงานตัว"
        '
        'tbEstDate
        '
        Me.tbEstDate.Location = New System.Drawing.Point(687, 22)
        Me.tbEstDate.Margin = New System.Windows.Forms.Padding(2)
        Me.tbEstDate.Name = "tbEstDate"
        Me.tbEstDate.ReadOnly = True
        Me.tbEstDate.Size = New System.Drawing.Size(122, 23)
        Me.tbEstDate.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(629, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "วันที่นัด"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.no, Me.estdate, Me.actdate})
        Me.dgvReport.Location = New System.Drawing.Point(11, 19)
        Me.dgvReport.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvReport.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReport.RowTemplate.Height = 28
        Me.dgvReport.Size = New System.Drawing.Size(566, 264)
        Me.dgvReport.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 63
        '
        'no
        '
        Me.no.HeaderText = "ครั้งที่"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 58
        '
        'estdate
        '
        Me.estdate.HeaderText = "วันที่นัด"
        Me.estdate.Name = "estdate"
        Me.estdate.ReadOnly = True
        Me.estdate.Width = 69
        '
        'actdate
        '
        Me.actdate.HeaderText = "วันที่มารายงานตัว"
        Me.actdate.Name = "actdate"
        Me.actdate.ReadOnly = True
        Me.actdate.Width = 103
        '
        'btSearch
        '
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearch.Location = New System.Drawing.Point(489, 10)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(100, 27)
        Me.btSearch.TabIndex = 18
        Me.btSearch.Text = "ค้นหาเยาวชน"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'tbFullname
        '
        Me.tbFullname.Enabled = False
        Me.tbFullname.Location = New System.Drawing.Point(135, 12)
        Me.tbFullname.Name = "tbFullname"
        Me.tbFullname.ReadOnly = True
        Me.tbFullname.Size = New System.Drawing.Size(334, 23)
        Me.tbFullname.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ชื่อ-นามสกุลเยาวชน"
        '
        'Rep2Pb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 354)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Rep2Pb"
        Me.Text = "บันทึกการรายงานตัว"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btSearch As Button
    Friend WithEvents tbFullname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEstDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpActDate As DateTimePicker
    Friend WithEvents cbMainAssociateJudge As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbRemark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbNextDays As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbISUA As CheckBox
    Friend WithEvents btReset As Button
    Friend WithEvents btSubmit As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents estdate As DataGridViewTextBoxColumn
    Friend WithEvents actdate As DataGridViewTextBoxColumn
    Friend WithEvents cbHasNextTime As CheckBox
End Class
