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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbFullname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEstDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpActDate = New System.Windows.Forms.DateTimePicker()
        Me.cbMainAssociateJudge = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbRemark = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbNextDays = New System.Windows.Forms.ComboBox()
        Me.cbISUA = New System.Windows.Forms.CheckBox()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
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
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 537)
        Me.Panel1.TabIndex = 0
        '
        'btSearch
        '
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearch.Location = New System.Drawing.Point(734, 16)
        Me.btSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(150, 41)
        Me.btSearch.TabIndex = 18
        Me.btSearch.Text = "ค้นหาเยาวชน"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'tbFullname
        '
        Me.tbFullname.Enabled = False
        Me.tbFullname.Location = New System.Drawing.Point(202, 19)
        Me.tbFullname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbFullname.Name = "tbFullname"
        Me.tbFullname.ReadOnly = True
        Me.tbFullname.Size = New System.Drawing.Size(499, 30)
        Me.tbFullname.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ชื่อ-นามสกุลเยาวชน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Location = New System.Drawing.Point(18, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1336, 454)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "บันทึกผลการรายงานตัว"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.estdate, Me.actdate})
        Me.dgvReport.Location = New System.Drawing.Point(17, 29)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReport.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvReport.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReport.RowTemplate.Height = 28
        Me.dgvReport.Size = New System.Drawing.Size(849, 406)
        Me.dgvReport.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "ครั้งที่"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 80
        '
        'estdate
        '
        Me.estdate.HeaderText = "วันที่นัด"
        Me.estdate.Name = "estdate"
        Me.estdate.ReadOnly = True
        Me.estdate.Width = 76
        '
        'actdate
        '
        Me.actdate.HeaderText = "วันที่มารายงานตัว"
        Me.actdate.Name = "actdate"
        Me.actdate.ReadOnly = True
        Me.actdate.Width = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(943, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "วันที่นัด"
        '
        'tbEstDate
        '
        Me.tbEstDate.Location = New System.Drawing.Point(1031, 34)
        Me.tbEstDate.Name = "tbEstDate"
        Me.tbEstDate.ReadOnly = True
        Me.tbEstDate.Size = New System.Drawing.Size(181, 30)
        Me.tbEstDate.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(875, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "วันที่มารายงานตัว"
        '
        'dtpActDate
        '
        Me.dtpActDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpActDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActDate.Location = New System.Drawing.Point(1031, 75)
        Me.dtpActDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpActDate.Name = "dtpActDate"
        Me.dtpActDate.Size = New System.Drawing.Size(181, 30)
        Me.dtpActDate.TabIndex = 37
        '
        'cbMainAssociateJudge
        '
        Me.cbMainAssociateJudge.FormattingEnabled = True
        Me.cbMainAssociateJudge.Location = New System.Drawing.Point(1031, 115)
        Me.cbMainAssociateJudge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbMainAssociateJudge.Name = "cbMainAssociateJudge"
        Me.cbMainAssociateJudge.Size = New System.Drawing.Size(298, 33)
        Me.cbMainAssociateJudge.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(897, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "ผู้รับรายงานตัว"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(934, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "บันทึกผล"
        '
        'tbRemark
        '
        Me.tbRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRemark.Location = New System.Drawing.Point(1031, 157)
        Me.tbRemark.Multiline = True
        Me.tbRemark.Name = "tbRemark"
        Me.tbRemark.Size = New System.Drawing.Size(298, 64)
        Me.tbRemark.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(909, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "นัดครั้งถัดไป"
        '
        'cbNextDays
        '
        Me.cbNextDays.FormattingEnabled = True
        Me.cbNextDays.Items.AddRange(New Object() {"30 วัน", "60 วัน", "90 วัน", "180 วัน"})
        Me.cbNextDays.Location = New System.Drawing.Point(1031, 268)
        Me.cbNextDays.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbNextDays.Name = "cbNextDays"
        Me.cbNextDays.Size = New System.Drawing.Size(110, 33)
        Me.cbNextDays.TabIndex = 43
        '
        'cbISUA
        '
        Me.cbISUA.AutoSize = True
        Me.cbISUA.Location = New System.Drawing.Point(1031, 231)
        Me.cbISUA.Name = "cbISUA"
        Me.cbISUA.Size = New System.Drawing.Size(165, 29)
        Me.cbISUA.TabIndex = 44
        Me.cbISUA.Text = "มีการตรวจปัสสาวะ"
        Me.cbISUA.UseVisualStyleBackColor = True
        '
        'btSubmit
        '
        Me.btSubmit.Location = New System.Drawing.Point(975, 350)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(102, 34)
        Me.btSubmit.TabIndex = 45
        Me.btSubmit.Text = "บันทึก"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(1094, 350)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(102, 34)
        Me.btReset.TabIndex = 46
        Me.btReset.Text = "ยกเลิก"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'Rep2Pb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Rep2Pb"
        Me.Text = "บันทึกการรายงานตัว"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents estdate As DataGridViewTextBoxColumn
    Friend WithEvents actdate As DataGridViewTextBoxColumn
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
End Class
