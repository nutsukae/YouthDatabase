<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep2
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
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blakcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blackno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.redno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.astname = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgvYouthList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.fullname, Me.idcard, Me.blakcno, Me.blackno, Me.redno, Me.title, Me.astname})
        Me.dgvYouthList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvYouthList.Location = New System.Drawing.Point(12, 22)
        Me.dgvYouthList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvYouthList.Name = "dgvYouthList"
        Me.dgvYouthList.ReadOnly = True
        Me.dgvYouthList.Size = New System.Drawing.Size(605, 100)
        Me.dgvYouthList.TabIndex = 9
        Me.dgvYouthList.Visible = False
        '
        'No
        '
        Me.No.DataPropertyName = "no"
        Me.No.HeaderText = "ลำดับที่"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 82
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 109
        '
        'idcard
        '
        Me.idcard.HeaderText = "บัตรประชาชน"
        Me.idcard.Name = "idcard"
        Me.idcard.ReadOnly = True
        Me.idcard.Width = 117
        '
        'blakcno
        '
        Me.blakcno.DataPropertyName = "caseno"
        Me.blakcno.HeaderText = "เลขที่คดี"
        Me.blakcno.Name = "blakcno"
        Me.blakcno.ReadOnly = True
        Me.blakcno.Width = 73
        '
        'blackno
        '
        Me.blackno.HeaderText = "ศป.ดำ"
        Me.blackno.Name = "blackno"
        Me.blackno.ReadOnly = True
        Me.blackno.Width = 78
        '
        'redno
        '
        Me.redno.HeaderText = "ศป.แดง"
        Me.redno.Name = "redno"
        Me.redno.ReadOnly = True
        Me.redno.Width = 86
        '
        'title
        '
        Me.title.HeaderText = "ประเภทความผิด"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 116
        '
        'astname
        '
        Me.astname.HeaderText = "ผู้พิพากษาสมทบผู้ให้คำปรึกษา"
        Me.astname.Name = "astname"
        Me.astname.ReadOnly = True
        Me.astname.Width = 154
        '
        'Rep2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 144)
        Me.Controls.Add(Me.dgvYouthList)
        Me.Name = "Rep2"
        Me.Text = "Rep2"
        CType(Me.dgvYouthList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvYouthList As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents idcard As DataGridViewTextBoxColumn
    Friend WithEvents blakcno As DataGridViewTextBoxColumn
    Friend WithEvents blackno As DataGridViewTextBoxColumn
    Friend WithEvents redno As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents astname As DataGridViewTextBoxColumn
End Class
