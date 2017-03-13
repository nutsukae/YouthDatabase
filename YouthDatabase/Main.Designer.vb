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
        Me.mnuPBReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPBAddActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPBTreatment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPBSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRptActPer = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuRptTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ConsultMenu, Me.ProbationMenu, Me.ReportMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1878, 35)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewPerson, Me.mnuNewCase, Me.ToolStripSeparator5, Me.mnuExit})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(86, 29)
        Me.FileMenu.Text = "โปรแกรม"
        '
        'mnuNewPerson
        '
        Me.mnuNewPerson.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuNewPerson.Name = "mnuNewPerson"
        Me.mnuNewPerson.Size = New System.Drawing.Size(213, 30)
        Me.mnuNewPerson.Text = "เพิ่มข้อมูลเด็ก"
        '
        'mnuNewCase
        '
        Me.mnuNewCase.Name = "mnuNewCase"
        Me.mnuNewCase.Size = New System.Drawing.Size(213, 30)
        Me.mnuNewCase.Text = "เพิ่มข้อมูลคดี"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(210, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(213, 30)
        Me.mnuExit.Text = "ออกจากโปรแกรม"
        '
        'ConsultMenu
        '
        Me.ConsultMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddActivity, Me.mnuTreatment, Me.mnuConsult})
        Me.ConsultMenu.Name = "ConsultMenu"
        Me.ConsultMenu.Size = New System.Drawing.Size(138, 29)
        Me.ConsultMenu.Text = "ศูนย์ให้คำปรึกษา"
        '
        'mnuAddActivity
        '
        Me.mnuAddActivity.Name = "mnuAddActivity"
        Me.mnuAddActivity.Size = New System.Drawing.Size(284, 30)
        Me.mnuAddActivity.Text = "ส่งต่อบำบัดฟื้นฟู"
        '
        'mnuTreatment
        '
        Me.mnuTreatment.Name = "mnuTreatment"
        Me.mnuTreatment.Size = New System.Drawing.Size(284, 30)
        Me.mnuTreatment.Text = "ส่งต่อทางจิตสังคมและจิตเวช"
        '
        'mnuConsult
        '
        Me.mnuConsult.Name = "mnuConsult"
        Me.mnuConsult.Size = New System.Drawing.Size(284, 30)
        Me.mnuConsult.Text = "สรุปผลการให้คำปรึกษา"
        '
        'ProbationMenu
        '
        Me.ProbationMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPBReport, Me.mnuPBAddActivity, Me.mnuPBTreatment, Me.mnuPBSummary})
        Me.ProbationMenu.Name = "ProbationMenu"
        Me.ProbationMenu.Size = New System.Drawing.Size(123, 29)
        Me.ProbationMenu.Text = "ศูนย์รายงานตัว"
        '
        'mnuPBReport
        '
        Me.mnuPBReport.Name = "mnuPBReport"
        Me.mnuPBReport.Size = New System.Drawing.Size(284, 30)
        Me.mnuPBReport.Text = "รายงานตัว"
        '
        'mnuPBAddActivity
        '
        Me.mnuPBAddActivity.Name = "mnuPBAddActivity"
        Me.mnuPBAddActivity.Size = New System.Drawing.Size(284, 30)
        Me.mnuPBAddActivity.Text = "ส่งต่อบำบัดฟื้นฟู"
        '
        'mnuPBTreatment
        '
        Me.mnuPBTreatment.Name = "mnuPBTreatment"
        Me.mnuPBTreatment.Size = New System.Drawing.Size(284, 30)
        Me.mnuPBTreatment.Text = "ส่งต่อทางจิดสังคมและจิตเวช"
        '
        'mnuPBSummary
        '
        Me.mnuPBSummary.Name = "mnuPBSummary"
        Me.mnuPBSummary.Size = New System.Drawing.Size(284, 30)
        Me.mnuPBSummary.Text = "สรุปผลการรายงายตัว"
        '
        'ReportMenu
        '
        Me.ReportMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRptActPer, Me.mnuRptTime})
        Me.ReportMenu.Name = "ReportMenu"
        Me.ReportMenu.Size = New System.Drawing.Size(75, 29)
        Me.ReportMenu.Text = "รายงาน"
        '
        'mnuRptActPer
        '
        Me.mnuRptActPer.Name = "mnuRptActPer"
        Me.mnuRptActPer.Size = New System.Drawing.Size(284, 30)
        Me.mnuRptActPer.Text = "รายชื่อคนเข้าร่วมกิจกรรม"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 994)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1878, 30)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(60, 25)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mnuRptTime
        '
        Me.mnuRptTime.Name = "mnuRptTime"
        Me.mnuRptTime.Size = New System.Drawing.Size(284, 30)
        Me.mnuRptTime.Text = "รายงานแบบกำหนดช่วงเวลา"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1878, 1024)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents mnuPBAddActivity As ToolStripMenuItem
    Friend WithEvents mnuPBTreatment As ToolStripMenuItem
    Friend WithEvents mnuPBSummary As ToolStripMenuItem
    Friend WithEvents mnuPBReport As ToolStripMenuItem
    Friend WithEvents mnuRptActPer As ToolStripMenuItem
    Friend WithEvents mnuRptTime As ToolStripMenuItem
End Class
