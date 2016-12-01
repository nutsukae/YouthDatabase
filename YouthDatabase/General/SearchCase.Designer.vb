<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchCase
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
        Me.dgvCase = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LawsuitDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdviceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InspectDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExPlanDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbSurrender = New System.Windows.Forms.RadioButton()
        Me.rbCriminal = New System.Windows.Forms.RadioButton()
        Me.rbTransfer = New System.Windows.Forms.RadioButton()
        Me.rbArrest = New System.Windows.Forms.RadioButton()
        Me.tbCaseNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvCase)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 356)
        Me.Panel1.TabIndex = 0
        '
        'dgvCase
        '
        Me.dgvCase.AllowUserToAddRows = False
        Me.dgvCase.AllowUserToDeleteRows = False
        Me.dgvCase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.no, Me.CaseNo, Me.LawsuitDate, Me.AdviceDate, Me.InspectDate, Me.PlanDate, Me.ExPlanDate, Me.ExDate})
        Me.dgvCase.Location = New System.Drawing.Point(9, 48)
        Me.dgvCase.Name = "dgvCase"
        Me.dgvCase.ReadOnly = True
        Me.dgvCase.Size = New System.Drawing.Size(775, 299)
        Me.dgvCase.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "Column1"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 73
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        Me.no.HeaderText = "ลำดับที่"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 60
        '
        'CaseNo
        '
        Me.CaseNo.DataPropertyName = "CaseNo"
        Me.CaseNo.HeaderText = "เลขที่คดี"
        Me.CaseNo.Name = "CaseNo"
        Me.CaseNo.ReadOnly = True
        Me.CaseNo.Width = 65
        '
        'LawsuitDate
        '
        Me.LawsuitDate.DataPropertyName = "LawsuitDate"
        Me.LawsuitDate.HeaderText = "วันรับฟ้อง"
        Me.LawsuitDate.Name = "LawsuitDate"
        Me.LawsuitDate.ReadOnly = True
        Me.LawsuitDate.Width = 72
        '
        'AdviceDate
        '
        Me.AdviceDate.DataPropertyName = "AdviceDate"
        Me.AdviceDate.HeaderText = "วันเข้าศูนย์"
        Me.AdviceDate.Name = "AdviceDate"
        Me.AdviceDate.ReadOnly = True
        Me.AdviceDate.Width = 78
        '
        'InspectDate
        '
        Me.InspectDate.DataPropertyName = "InspectDate"
        Me.InspectDate.HeaderText = "วันสอบคำให้การ"
        Me.InspectDate.Name = "InspectDate"
        Me.InspectDate.ReadOnly = True
        Me.InspectDate.Width = 83
        '
        'PlanDate
        '
        Me.PlanDate.DataPropertyName = "PlanDate"
        Me.PlanDate.HeaderText = "วันส่งทำแผน"
        Me.PlanDate.Name = "PlanDate"
        Me.PlanDate.ReadOnly = True
        Me.PlanDate.Width = 85
        '
        'ExPlanDate
        '
        Me.ExPlanDate.DataPropertyName = "ExPlanDate"
        Me.ExPlanDate.HeaderText = "วันนัดพิจารณาแผน"
        Me.ExPlanDate.Name = "ExPlanDate"
        Me.ExPlanDate.ReadOnly = True
        Me.ExPlanDate.Width = 113
        '
        'ExDate
        '
        Me.ExDate.DataPropertyName = "ExDate"
        Me.ExDate.HeaderText = "วัดนัดพิจารณาผล"
        Me.ExDate.Name = "ExDate"
        Me.ExDate.ReadOnly = True
        Me.ExDate.Width = 91
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.rb5)
        Me.Panel6.Controls.Add(Me.btSearch)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.rbSurrender)
        Me.Panel6.Controls.Add(Me.rbCriminal)
        Me.Panel6.Controls.Add(Me.rbTransfer)
        Me.Panel6.Controls.Add(Me.rbArrest)
        Me.Panel6.Controls.Add(Me.tbCaseNo)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(9, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(768, 39)
        Me.Panel6.TabIndex = 1
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(504, 5)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 28)
        Me.btSearch.TabIndex = 13
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประเภทคดี"
        '
        'rbSurrender
        '
        Me.rbSurrender.AutoSize = True
        Me.rbSurrender.Checked = True
        Me.rbSurrender.Location = New System.Drawing.Point(99, 9)
        Me.rbSurrender.Name = "rbSurrender"
        Me.rbSurrender.Size = New System.Drawing.Size(46, 21)
        Me.rbSurrender.TabIndex = 1
        Me.rbSurrender.TabStop = True
        Me.rbSurrender.Text = "มต."
        Me.rbSurrender.UseVisualStyleBackColor = True
        '
        'rbCriminal
        '
        Me.rbCriminal.AutoSize = True
        Me.rbCriminal.Location = New System.Drawing.Point(246, 9)
        Me.rbCriminal.Name = "rbCriminal"
        Me.rbCriminal.Size = New System.Drawing.Size(37, 21)
        Me.rbCriminal.TabIndex = 12
        Me.rbCriminal.TabStop = True
        Me.rbCriminal.Text = "อ."
        Me.rbCriminal.UseVisualStyleBackColor = True
        '
        'rbTransfer
        '
        Me.rbTransfer.AutoSize = True
        Me.rbTransfer.Location = New System.Drawing.Point(202, 9)
        Me.rbTransfer.Name = "rbTransfer"
        Me.rbTransfer.Size = New System.Drawing.Size(38, 21)
        Me.rbTransfer.TabIndex = 3
        Me.rbTransfer.TabStop = True
        Me.rbTransfer.Text = "ผ."
        Me.rbTransfer.UseVisualStyleBackColor = True
        '
        'rbArrest
        '
        Me.rbArrest.AutoSize = True
        Me.rbArrest.Location = New System.Drawing.Point(151, 9)
        Me.rbArrest.Name = "rbArrest"
        Me.rbArrest.Size = New System.Drawing.Size(45, 21)
        Me.rbArrest.TabIndex = 2
        Me.rbArrest.TabStop = True
        Me.rbArrest.Text = "ตจ."
        Me.rbArrest.UseVisualStyleBackColor = True
        '
        'tbCaseNo
        '
        Me.tbCaseNo.Location = New System.Drawing.Point(398, 8)
        Me.tbCaseNo.Name = "tbCaseNo"
        Me.tbCaseNo.Size = New System.Drawing.Size(100, 23)
        Me.tbCaseNo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "เลขที่คดี"
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Location = New System.Drawing.Point(289, 9)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(44, 21)
        Me.rb5.TabIndex = 14
        Me.rb5.TabStop = True
        Me.rb5.Text = "อย."
        Me.rb5.UseVisualStyleBackColor = True
        '
        'SearchCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SearchCase"
        Me.Text = "ค้นหาคดี"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvCase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvCase As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rbSurrender As RadioButton
    Friend WithEvents rbCriminal As RadioButton
    Friend WithEvents rbTransfer As RadioButton
    Friend WithEvents rbArrest As RadioButton
    Friend WithEvents tbCaseNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents CaseNo As DataGridViewTextBoxColumn
    Friend WithEvents LawsuitDate As DataGridViewTextBoxColumn
    Friend WithEvents AdviceDate As DataGridViewTextBoxColumn
    Friend WithEvents InspectDate As DataGridViewTextBoxColumn
    Friend WithEvents PlanDate As DataGridViewTextBoxColumn
    Friend WithEvents ExPlanDate As DataGridViewTextBoxColumn
    Friend WithEvents ExDate As DataGridViewTextBoxColumn
    Friend WithEvents rb5 As RadioButton
End Class
