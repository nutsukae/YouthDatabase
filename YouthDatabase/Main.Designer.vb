<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewPerson = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTreatment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsult = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ConsultMenu, Me.ProbationMenu, Me.ReportMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewPerson, Me.mnuNewCase, Me.ToolStripSeparator5, Me.mnuExit})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(61, 20)
        Me.FileMenu.Text = "โปรแกรม"
        '
        'mnuNewPerson
        '
        Me.mnuNewPerson.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuNewPerson.Name = "mnuNewPerson"
        Me.mnuNewPerson.Size = New System.Drawing.Size(152, 22)
        Me.mnuNewPerson.Text = "เพิ่มข้อมูลเด็ก"
        '
        'mnuNewCase
        '
        Me.mnuNewCase.Name = "mnuNewCase"
        Me.mnuNewCase.Size = New System.Drawing.Size(152, 22)
        Me.mnuNewCase.Text = "เพิ่มข้อมูลคดี"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "ออกจากโปรแกรม"
        '
        'ConsultMenu
        '
        Me.ConsultMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddActivity, Me.mnuTreatment, Me.mnuConsult})
        Me.ConsultMenu.Name = "ConsultMenu"
        Me.ConsultMenu.Size = New System.Drawing.Size(95, 20)
        Me.ConsultMenu.Text = "ศูนย์ให้คำปรึกษา"
        '
        'mnuAddActivity
        '
        Me.mnuAddActivity.Name = "mnuAddActivity"
        Me.mnuAddActivity.Size = New System.Drawing.Size(197, 22)
        Me.mnuAddActivity.Text = "ส่งต่อบำบัดฟื้นฟู"
        '
        'mnuTreatment
        '
        Me.mnuTreatment.Name = "mnuTreatment"
        Me.mnuTreatment.Size = New System.Drawing.Size(197, 22)
        Me.mnuTreatment.Text = "ส่งต่อทางจิตสังคมและจิตเวช"
        '
        'mnuConsult
        '
        Me.mnuConsult.Name = "mnuConsult"
        Me.mnuConsult.Size = New System.Drawing.Size(197, 22)
        Me.mnuConsult.Text = "สรุปผลการให้คำปรึกษา"
        '
        'ProbationMenu
        '
        Me.ProbationMenu.Name = "ProbationMenu"
        Me.ProbationMenu.Size = New System.Drawing.Size(84, 20)
        Me.ProbationMenu.Text = "ศูนย์รายงานตัว"
        '
        'ReportMenu
        '
        Me.ReportMenu.Name = "ReportMenu"
        Me.ReportMenu.Size = New System.Drawing.Size(52, 20)
        Me.ReportMenu.Text = "รายงาน"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.Text = "ศาลเยาวชนและครอบครัวจังหวัดนนทบุรี"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuNewCase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewPerson As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultMenu As ToolStripMenuItem
    Friend WithEvents ProbationMenu As ToolStripMenuItem
    Friend WithEvents ReportMenu As ToolStripMenuItem
    Friend WithEvents mnuAddActivity As ToolStripMenuItem
    Friend WithEvents mnuConsult As ToolStripMenuItem
    Friend WithEvents mnuTreatment As ToolStripMenuItem
End Class
