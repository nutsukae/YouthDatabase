<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchActivity
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
        Me.dgvActList = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.act_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvActList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvActList
        '
        Me.dgvActList.AllowUserToAddRows = False
        Me.dgvActList.AllowUserToDeleteRows = False
        Me.dgvActList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvActList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvActList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.No, Me.act_name, Me.dept_name, Me.location, Me.actdate})
        Me.dgvActList.Location = New System.Drawing.Point(3, 3)
        Me.dgvActList.Name = "dgvActList"
        Me.dgvActList.ReadOnly = True
        Me.dgvActList.Size = New System.Drawing.Size(573, 250)
        Me.dgvActList.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 46
        '
        'No
        '
        Me.No.HeaderText = "ลำดับที่"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 65
        '
        'act_name
        '
        Me.act_name.HeaderText = "ชื่อกิจกรรม"
        Me.act_name.Name = "act_name"
        Me.act_name.ReadOnly = True
        Me.act_name.Width = 86
        '
        'dept_name
        '
        Me.dept_name.HeaderText = "หน่วยงานผู้รับผิดชอบ"
        Me.dept_name.Name = "dept_name"
        Me.dept_name.ReadOnly = True
        '
        'location
        '
        Me.location.HeaderText = "สถานที่จัดงาน"
        Me.location.Name = "location"
        Me.location.ReadOnly = True
        Me.location.Width = 79
        '
        'actdate
        '
        Me.actdate.HeaderText = "วันที่จัดกิจกรรม"
        Me.actdate.Name = "actdate"
        Me.actdate.ReadOnly = True
        Me.actdate.Width = 107
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dgvActList)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 256)
        Me.Panel1.TabIndex = 1
        '
        'SearchActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SearchActivity"
        Me.Text = "ค้นหากิจกรรม"
        CType(Me.dgvActList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvActList As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents act_name As DataGridViewTextBoxColumn
    Friend WithEvents dept_name As DataGridViewTextBoxColumn
    Friend Shadows WithEvents location As DataGridViewTextBoxColumn
    Friend WithEvents actdate As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
