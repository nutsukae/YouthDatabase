<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptTime
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
        Me.rptRep1 = New System.Windows.Forms.RadioButton()
        Me.rptRep2 = New System.Windows.Forms.RadioButton()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStopDate = New System.Windows.Forms.DateTimePicker()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btPrint)
        Me.Panel1.Controls.Add(Me.dtpStopDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpStartDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rptRep2)
        Me.Panel1.Controls.Add(Me.rptRep1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 520)
        Me.Panel1.TabIndex = 0
        '
        'rptRep1
        '
        Me.rptRep1.AutoSize = True
        Me.rptRep1.Checked = True
        Me.rptRep1.Location = New System.Drawing.Point(31, 79)
        Me.rptRep1.Name = "rptRep1"
        Me.rptRep1.Size = New System.Drawing.Size(357, 29)
        Me.rptRep1.TabIndex = 0
        Me.rptRep1.TabStop = True
        Me.rptRep1.Text = "รายงานนัดสอบคำให้การของศูนย์ให้คำปรึกษา"
        Me.rptRep1.UseVisualStyleBackColor = True
        '
        'rptRep2
        '
        Me.rptRep2.AutoSize = True
        Me.rptRep2.Location = New System.Drawing.Point(31, 118)
        Me.rptRep2.Name = "rptRep2"
        Me.rptRep2.Size = New System.Drawing.Size(331, 29)
        Me.rptRep2.TabIndex = 1
        Me.rptRep2.TabStop = True
        Me.rptRep2.Text = "รายชื่อเด็กและเยาวชนที่กระทำความผิดซ้ำ"
        Me.rptRep2.UseVisualStyleBackColor = True
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(114, 33)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(181, 30)
        Me.dtpStartDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ตั้งแต่วันที่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ถึง"
        '
        'dtpStopDate
        '
        Me.dtpStopDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStopDate.Location = New System.Drawing.Point(340, 33)
        Me.dtpStopDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStopDate.Name = "dtpStopDate"
        Me.dtpStopDate.Size = New System.Drawing.Size(181, 30)
        Me.dtpStopDate.TabIndex = 6
        '
        'btPrint
        '
        Me.btPrint.Location = New System.Drawing.Point(559, 33)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(123, 41)
        Me.btPrint.TabIndex = 7
        Me.btPrint.Text = "พิมพ์รายงาน"
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'rptTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "rptTime"
        Me.Text = "รายงานแบบกำหนดช่วงเวลา"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rptRep1 As RadioButton
    Friend WithEvents rptRep2 As RadioButton
    Friend WithEvents btPrint As Button
    Friend WithEvents dtpStopDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
