<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Panel = New System.Windows.Forms.Panel()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbError = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.btCancel)
        Me.Panel.Controls.Add(Me.btSubmit)
        Me.Panel.Controls.Add(Me.tbPassword)
        Me.Panel.Controls.Add(Me.tbUsername)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel.Location = New System.Drawing.Point(12, 39)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(390, 164)
        Me.Panel.TabIndex = 0
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(198, 104)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 33)
        Me.btCancel.TabIndex = 5
        Me.btCancel.Text = "ยกเลิก"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btSubmit
        '
        Me.btSubmit.Location = New System.Drawing.Point(106, 104)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(75, 33)
        Me.btSubmit.TabIndex = 4
        Me.btSubmit.Text = "ตกลง"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(198, 57)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(150, 26)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(198, 24)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(150, 26)
        Me.tbUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสผ่าน (Password)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสผู้ใช้งาน (Username)"
        '
        'lbError
        '
        Me.lbError.AutoSize = True
        Me.lbError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbError.ForeColor = System.Drawing.Color.Red
        Me.lbError.Location = New System.Drawing.Point(106, 12)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(195, 20)
        Me.lbError.TabIndex = 1
        Me.lbError.Text = "!! Error !! Connection failed"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 215)
        Me.Controls.Add(Me.lbError)
        Me.Controls.Add(Me.Panel)
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents btCancel As Button
    Friend WithEvents btSubmit As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbError As Label
End Class
