﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actper_search_youth
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
        Me.dgvYouth = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbIdcard = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbLastname = New System.Windows.Forms.TextBox()
        Me.tbFirstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCase = New System.Windows.Forms.DataGridView()
        Me.c_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caseno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blackno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvYouth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvYouth)
        Me.Panel1.Controls.Add(Me.btSearch)
        Me.Panel1.Controls.Add(Me.tbIdcard)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbLastname)
        Me.Panel1.Controls.Add(Me.tbFirstname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 369)
        Me.Panel1.TabIndex = 1
        '
        'dgvYouth
        '
        Me.dgvYouth.AllowUserToAddRows = False
        Me.dgvYouth.AllowUserToDeleteRows = False
        Me.dgvYouth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvYouth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYouth.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.no, Me.fullname, Me.idcard})
        Me.dgvYouth.Location = New System.Drawing.Point(9, 37)
        Me.dgvYouth.Name = "dgvYouth"
        Me.dgvYouth.ReadOnly = True
        Me.dgvYouth.Size = New System.Drawing.Size(660, 319)
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
        Me.no.Width = 65
        '
        'fullname
        '
        Me.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "ชื่อ-นามสกุล"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Width = 90
        '
        'idcard
        '
        Me.idcard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.idcard.DataPropertyName = "idcard"
        Me.idcard.HeaderText = "รหัสบัตรประชาชน"
        Me.idcard.Name = "idcard"
        Me.idcard.ReadOnly = True
        Me.idcard.Width = 120
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(577, 8)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 23)
        Me.btSearch.TabIndex = 12
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'tbIdcard
        '
        Me.tbIdcard.Location = New System.Drawing.Point(451, 8)
        Me.tbIdcard.Name = "tbIdcard"
        Me.tbIdcard.Size = New System.Drawing.Size(120, 23)
        Me.tbIdcard.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "เลขบัตรประชาชน"
        '
        'tbLastname
        '
        Me.tbLastname.Location = New System.Drawing.Point(217, 8)
        Me.tbLastname.Name = "tbLastname"
        Me.tbLastname.Size = New System.Drawing.Size(120, 23)
        Me.tbLastname.TabIndex = 8
        '
        'tbFirstname
        '
        Me.tbFirstname.Location = New System.Drawing.Point(40, 8)
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.Size = New System.Drawing.Size(120, 23)
        Me.tbFirstname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCase)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 379)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 177)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลคดีที่เกี่ยวข้องกับเยาวชน"
        '
        'dgvCase
        '
        Me.dgvCase.AllowUserToAddRows = False
        Me.dgvCase.AllowUserToDeleteRows = False
        Me.dgvCase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id, Me.c_no, Me.caseno, Me.blackno})
        Me.dgvCase.Location = New System.Drawing.Point(9, 21)
        Me.dgvCase.Name = "dgvCase"
        Me.dgvCase.ReadOnly = True
        Me.dgvCase.Size = New System.Drawing.Size(660, 150)
        Me.dgvCase.TabIndex = 0
        '
        'c_id
        '
        Me.c_id.HeaderText = "ID"
        Me.c_id.Name = "c_id"
        Me.c_id.ReadOnly = True
        Me.c_id.Visible = False
        '
        'c_no
        '
        Me.c_no.HeaderText = "ลำดับที่"
        Me.c_no.Name = "c_no"
        Me.c_no.ReadOnly = True
        Me.c_no.Width = 70
        '
        'caseno
        '
        Me.caseno.HeaderText = "เลขคดี"
        Me.caseno.Name = "caseno"
        Me.caseno.ReadOnly = True
        Me.caseno.Width = 68
        '
        'blackno
        '
        Me.blackno.HeaderText = "เลขคดีดำ"
        Me.blackno.Name = "blackno"
        Me.blackno.ReadOnly = True
        Me.blackno.Width = 82
        '
        'actper_search_youth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "actper_search_youth"
        Me.Text = "ค้นหาเยาวชน"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvYouth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCase, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCase As DataGridView
    Friend WithEvents c_id As DataGridViewTextBoxColumn
    Friend WithEvents c_no As DataGridViewTextBoxColumn
    Friend WithEvents caseno As DataGridViewTextBoxColumn
    Friend WithEvents blackno As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents idcard As DataGridViewTextBoxColumn
End Class
