<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tort
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
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTortLv3 = New System.Windows.Forms.ComboBox()
        Me.cbTortLv2 = New System.Windows.Forms.ComboBox()
        Me.cbTortLv1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btSubmit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbTortLv3)
        Me.Panel1.Controls.Add(Me.cbTortLv2)
        Me.Panel1.Controls.Add(Me.cbTortLv1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 163)
        Me.Panel1.TabIndex = 0
        '
        'btSubmit
        '
        Me.btSubmit.Location = New System.Drawing.Point(233, 121)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(75, 33)
        Me.btSubmit.TabIndex = 17
        Me.btSubmit.Text = "ตกลง"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "กรุณาเลือก"
        '
        'cbTortLv3
        '
        Me.cbTortLv3.FormattingEnabled = True
        Me.cbTortLv3.Location = New System.Drawing.Point(108, 82)
        Me.cbTortLv3.Name = "cbTortLv3"
        Me.cbTortLv3.Size = New System.Drawing.Size(400, 24)
        Me.cbTortLv3.TabIndex = 15
        '
        'cbTortLv2
        '
        Me.cbTortLv2.DropDownWidth = 400
        Me.cbTortLv2.FormattingEnabled = True
        Me.cbTortLv2.Location = New System.Drawing.Point(108, 52)
        Me.cbTortLv2.Name = "cbTortLv2"
        Me.cbTortLv2.Size = New System.Drawing.Size(400, 24)
        Me.cbTortLv2.TabIndex = 14
        '
        'cbTortLv1
        '
        Me.cbTortLv1.FormattingEnabled = True
        Me.cbTortLv1.Location = New System.Drawing.Point(108, 22)
        Me.cbTortLv1.Name = "cbTortLv1"
        Me.cbTortLv1.Size = New System.Drawing.Size(200, 24)
        Me.cbTortLv1.TabIndex = 13
        '
        'Tort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 169)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tort"
        Me.Text = "ข้อมูลประเภทความผิด"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTortLv3 As ComboBox
    Friend WithEvents cbTortLv2 As ComboBox
    Friend WithEvents cbTortLv1 As ComboBox
End Class
