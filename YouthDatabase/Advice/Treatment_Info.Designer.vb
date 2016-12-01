<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Treatment_Info
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
        Me.btReset = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.btSearchActivity = New System.Windows.Forms.Button()
        Me.cbActType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btAddYouth = New System.Windows.Forms.Button()
        Me.tbFullname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpActDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btReset)
        Me.Panel1.Controls.Add(Me.btSubmit)
        Me.Panel1.Controls.Add(Me.btSearchActivity)
        Me.Panel1.Controls.Add(Me.cbActType)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btAddYouth)
        Me.Panel1.Controls.Add(Me.tbFullname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtpActDate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbDepartment)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbLocation)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 247)
        Me.Panel1.TabIndex = 0
        '
        'btReset
        '
        Me.btReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReset.Location = New System.Drawing.Point(267, 195)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(100, 29)
        Me.btReset.TabIndex = 20
        Me.btReset.Text = "เริ่มใหม่"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btSubmit
        '
        Me.btSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSubmit.Location = New System.Drawing.Point(132, 195)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(100, 29)
        Me.btSubmit.TabIndex = 19
        Me.btSubmit.Text = "ตกลง"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'btSearchActivity
        '
        Me.btSearchActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchActivity.Location = New System.Drawing.Point(674, 41)
        Me.btSearchActivity.Name = "btSearchActivity"
        Me.btSearchActivity.Size = New System.Drawing.Size(100, 29)
        Me.btSearchActivity.TabIndex = 18
        Me.btSearchActivity.Text = "ค้นหากิจกรรม"
        Me.btSearchActivity.UseVisualStyleBackColor = True
        '
        'cbActType
        '
        Me.cbActType.FormattingEnabled = True
        Me.cbActType.Location = New System.Drawing.Point(132, 135)
        Me.cbActType.Name = "cbActType"
        Me.cbActType.Size = New System.Drawing.Size(334, 24)
        Me.cbActType.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ประเภทกิจกรรม"
        '
        'btAddYouth
        '
        Me.btAddYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddYouth.Location = New System.Drawing.Point(494, 10)
        Me.btAddYouth.Name = "btAddYouth"
        Me.btAddYouth.Size = New System.Drawing.Size(100, 29)
        Me.btAddYouth.TabIndex = 15
        Me.btAddYouth.Text = "ค้นหาเยาวชน"
        Me.btAddYouth.UseVisualStyleBackColor = True
        '
        'tbFullname
        '
        Me.tbFullname.Enabled = False
        Me.tbFullname.Location = New System.Drawing.Point(132, 14)
        Me.tbFullname.Name = "tbFullname"
        Me.tbFullname.Size = New System.Drawing.Size(334, 23)
        Me.tbFullname.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ชื่อ-นามสกุลเยาวชน"
        '
        'dtpActDate
        '
        Me.dtpActDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpActDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActDate.Location = New System.Drawing.Point(529, 106)
        Me.dtpActDate.Name = "dtpActDate"
        Me.dtpActDate.Size = New System.Drawing.Size(113, 23)
        Me.dtpActDate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "วันที่"
        '
        'cbDepartment
        '
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Location = New System.Drawing.Point(132, 163)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(334, 24)
        Me.cbDepartment.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "หน่วยงาน"
        '
        'tbLocation
        '
        Me.tbLocation.Location = New System.Drawing.Point(132, 106)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(334, 23)
        Me.tbLocation.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "สถานที่"
        '
        'tbName
        '
        Me.tbName.AcceptsReturn = True
        Me.tbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.Location = New System.Drawing.Point(132, 41)
        Me.tbName.Multiline = True
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(536, 59)
        Me.tbName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ชื่อกิจกรรม"
        '
        'Treatment_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 249)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Treatment_Info"
        Me.Text = "ข้อมูลกิจกรรมส่งต่อทางจิตสังคมและจิตเวช"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbFullname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpActDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btAddYouth As Button
    Friend WithEvents btSearchActivity As Button
    Friend WithEvents cbActType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btSubmit As Button
    Friend WithEvents btReset As Button
End Class
