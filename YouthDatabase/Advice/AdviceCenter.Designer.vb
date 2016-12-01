<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdviceCenter
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.tbSummary = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvAct1 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvAct0 = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbSocial = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbReason = New System.Windows.Forms.TextBox()
        Me.tbFamily = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEmotion = New System.Windows.Forms.TextBox()
        Me.tbBehaviour = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbThinking = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbIDCard = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbFullname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAddYouth = New System.Windows.Forms.Button()
        Me.tbAdvRedNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbAdvBlackNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbSupportAssociateJudge = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMainAssociateJudge = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCaseTitle = New System.Windows.Forms.TextBox()
        Me.tbBlackNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.act_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deptment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAct0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1268, 746)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btReset)
        Me.GroupBox2.Controls.Add(Me.btSubmit)
        Me.GroupBox2.Controls.Add(Me.tbSummary)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.dgvAct1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.dgvAct0)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tbSocial)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbReason)
        Me.GroupBox2.Controls.Add(Me.tbFamily)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbEmotion)
        Me.GroupBox2.Controls.Add(Me.tbBehaviour)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbThinking)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1256, 620)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "สรุปผลการประเมิน"
        '
        'btReset
        '
        Me.btReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReset.Location = New System.Drawing.Point(684, 521)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(100, 29)
        Me.btReset.TabIndex = 29
        Me.btReset.Text = "เริ่มใหม่"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btSubmit
        '
        Me.btSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSubmit.Location = New System.Drawing.Point(538, 521)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(100, 29)
        Me.btSubmit.TabIndex = 28
        Me.btSubmit.Text = "บันทึกข้อมูล"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'tbSummary
        '
        Me.tbSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSummary.Location = New System.Drawing.Point(20, 431)
        Me.tbSummary.Multiline = True
        Me.tbSummary.Name = "tbSummary"
        Me.tbSummary.Size = New System.Drawing.Size(1229, 84)
        Me.tbSummary.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 411)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(490, 17)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "ความเห็นเกี่ยวกับการคุ้มครองสวัสดิภาพและการแก้ไขบำบัด ฟื้นฟูเด็ก เยาวชนและครอบครั" &
    "ว"
        '
        'dgvAct1
        '
        Me.dgvAct1.AllowUserToAddRows = False
        Me.dgvAct1.AllowUserToDeleteRows = False
        Me.dgvAct1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAct1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAct1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAct1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAct1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvAct1.Location = New System.Drawing.Point(684, 81)
        Me.dgvAct1.Name = "dgvAct1"
        Me.dgvAct1.ReadOnly = True
        Me.dgvAct1.Size = New System.Drawing.Size(565, 167)
        Me.dgvAct1.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(681, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(176, 17)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "การส่งต่อทางจิตสังคมและจิตเวช"
        '
        'dgvAct0
        '
        Me.dgvAct0.AllowUserToAddRows = False
        Me.dgvAct0.AllowUserToDeleteRows = False
        Me.dgvAct0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAct0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAct0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAct0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.ActivityName, Me.location, Me.act_date, Me.deptment})
        Me.dgvAct0.Location = New System.Drawing.Point(20, 81)
        Me.dgvAct0.Name = "dgvAct0"
        Me.dgvAct0.ReadOnly = True
        Me.dgvAct0.Size = New System.Drawing.Size(658, 167)
        Me.dgvAct0.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "การแก้ไขบำบัดฟื้นฟู"
        '
        'tbSocial
        '
        Me.tbSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSocial.Location = New System.Drawing.Point(182, 370)
        Me.tbSocial.Name = "tbSocial"
        Me.tbSocial.Size = New System.Drawing.Size(1067, 23)
        Me.tbSocial.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ปัญหาด้านสังคม"
        '
        'tbReason
        '
        Me.tbReason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbReason.Location = New System.Drawing.Point(182, 22)
        Me.tbReason.Name = "tbReason"
        Me.tbReason.Size = New System.Drawing.Size(1067, 23)
        Me.tbReason.TabIndex = 21
        '
        'tbFamily
        '
        Me.tbFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFamily.Location = New System.Drawing.Point(182, 341)
        Me.tbFamily.Name = "tbFamily"
        Me.tbFamily.Size = New System.Drawing.Size(1067, 23)
        Me.tbFamily.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "สาเหตุของการกระทำผิดหลัก"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ปัญหาด้านครอบครัว"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ปัญหาด้านพฤติกรรม"
        '
        'tbEmotion
        '
        Me.tbEmotion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEmotion.Location = New System.Drawing.Point(182, 312)
        Me.tbEmotion.Name = "tbEmotion"
        Me.tbEmotion.Size = New System.Drawing.Size(1067, 23)
        Me.tbEmotion.TabIndex = 15
        '
        'tbBehaviour
        '
        Me.tbBehaviour.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBehaviour.Location = New System.Drawing.Point(182, 254)
        Me.tbBehaviour.Name = "tbBehaviour"
        Me.tbBehaviour.Size = New System.Drawing.Size(1067, 23)
        Me.tbBehaviour.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ปัญหาด้านอารมณ์"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ปัญหาด้านความคิด"
        '
        'tbThinking
        '
        Me.tbThinking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbThinking.Location = New System.Drawing.Point(182, 283)
        Me.tbThinking.Name = "tbThinking"
        Me.tbThinking.Size = New System.Drawing.Size(1067, 23)
        Me.tbThinking.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tbIDCard)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.tbFullname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btAddYouth)
        Me.GroupBox1.Controls.Add(Me.tbAdvRedNo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.tbAdvBlackNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbSupportAssociateJudge)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbMainAssociateJudge)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbCaseTitle)
        Me.GroupBox1.Controls.Add(Me.tbBlackNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1256, 118)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลทั่วไป"
        '
        'tbIDCard
        '
        Me.tbIDCard.Location = New System.Drawing.Point(430, 22)
        Me.tbIDCard.Name = "tbIDCard"
        Me.tbIDCard.ReadOnly = True
        Me.tbIDCard.Size = New System.Drawing.Size(177, 23)
        Me.tbIDCard.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(315, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 17)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "เลขที่บัตรประชาขน"
        '
        'tbFullname
        '
        Me.tbFullname.Location = New System.Drawing.Point(147, 22)
        Me.tbFullname.Name = "tbFullname"
        Me.tbFullname.ReadOnly = True
        Me.tbFullname.Size = New System.Drawing.Size(162, 23)
        Me.tbFullname.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ชื่อ-นามสกุลเยาวชน"
        '
        'btAddYouth
        '
        Me.btAddYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddYouth.Location = New System.Drawing.Point(613, 19)
        Me.btAddYouth.Name = "btAddYouth"
        Me.btAddYouth.Size = New System.Drawing.Size(100, 29)
        Me.btAddYouth.TabIndex = 16
        Me.btAddYouth.Text = "ค้นหาเยาวชน"
        Me.btAddYouth.UseVisualStyleBackColor = True
        '
        'tbAdvRedNo
        '
        Me.tbAdvRedNo.Location = New System.Drawing.Point(390, 86)
        Me.tbAdvRedNo.Name = "tbAdvRedNo"
        Me.tbAdvRedNo.Size = New System.Drawing.Size(100, 23)
        Me.tbAdvRedNo.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(258, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "เลขคดีแดงให้คำปรึกษา"
        '
        'tbAdvBlackNo
        '
        Me.tbAdvBlackNo.Location = New System.Drawing.Point(147, 86)
        Me.tbAdvBlackNo.Name = "tbAdvBlackNo"
        Me.tbAdvBlackNo.Size = New System.Drawing.Size(100, 23)
        Me.tbAdvBlackNo.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "เลขคดีดำให้คำปรึกษา"
        '
        'cbSupportAssociateJudge
        '
        Me.cbSupportAssociateJudge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSupportAssociateJudge.FormattingEnabled = True
        Me.cbSupportAssociateJudge.Location = New System.Drawing.Point(1050, 86)
        Me.cbSupportAssociateJudge.Name = "cbSupportAssociateJudge"
        Me.cbSupportAssociateJudge.Size = New System.Drawing.Size(200, 24)
        Me.cbSupportAssociateJudge.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(941, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ผู้ให้คำปรึกษารอง"
        '
        'cbMainAssociateJudge
        '
        Me.cbMainAssociateJudge.FormattingEnabled = True
        Me.cbMainAssociateJudge.Location = New System.Drawing.Point(613, 86)
        Me.cbMainAssociateJudge.Name = "cbMainAssociateJudge"
        Me.cbMainAssociateJudge.Size = New System.Drawing.Size(322, 24)
        Me.cbMainAssociateJudge.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ผู้ให้คำปรึกษาหลัก"
        '
        'tbCaseTitle
        '
        Me.tbCaseTitle.Location = New System.Drawing.Point(430, 54)
        Me.tbCaseTitle.Name = "tbCaseTitle"
        Me.tbCaseTitle.ReadOnly = True
        Me.tbCaseTitle.Size = New System.Drawing.Size(819, 23)
        Me.tbCaseTitle.TabIndex = 5
        '
        'tbBlackNo
        '
        Me.tbBlackNo.Location = New System.Drawing.Point(147, 54)
        Me.tbBlackNo.Name = "tbBlackNo"
        Me.tbBlackNo.ReadOnly = True
        Me.tbBlackNo.Size = New System.Drawing.Size(162, 23)
        Me.tbBlackNo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เรื่อง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "คดีดำ"
        '
        'No
        '
        Me.No.HeaderText = "ลำดับที่"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 70
        '
        'ActivityName
        '
        Me.ActivityName.HeaderText = "กิจกรรม"
        Me.ActivityName.Name = "ActivityName"
        Me.ActivityName.ReadOnly = True
        Me.ActivityName.Width = 78
        '
        'location
        '
        Me.location.HeaderText = "สถานที่"
        Me.location.Name = "location"
        Me.location.ReadOnly = True
        Me.location.Width = 71
        '
        'act_date
        '
        Me.act_date.HeaderText = "วันที่จัดกิจกรรม"
        Me.act_date.Name = "act_date"
        Me.act_date.ReadOnly = True
        Me.act_date.Width = 117
        '
        'deptment
        '
        Me.deptment.HeaderText = "หน่วยงาน"
        Me.deptment.Name = "deptment"
        Me.deptment.ReadOnly = True
        Me.deptment.Width = 86
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ลำดับที่"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "สถานที่"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 71
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "วันที่เข้าร่วม"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "ผู้รับผิดชอบ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'AdviceCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdviceCenter"
        Me.Text = "รายงานการให้คำปรึกษา"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAct0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbBlackNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCaseTitle As TextBox
    Friend WithEvents cbSupportAssociateJudge As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbMainAssociateJudge As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbThinking As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbBehaviour As TextBox
    Friend WithEvents tbEmotion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSocial As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbFamily As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbReason As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbAdvRedNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbAdvBlackNo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvAct1 As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvAct0 As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tbSummary As TextBox
    Friend WithEvents btAddYouth As Button
    Friend WithEvents tbIDCard As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbFullname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btReset As Button
    Friend WithEvents btSubmit As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents ActivityName As DataGridViewTextBoxColumn
    Friend Shadows WithEvents location As DataGridViewTextBoxColumn
    Friend WithEvents act_date As DataGridViewTextBoxColumn
    Friend WithEvents deptment As DataGridViewTextBoxColumn
End Class
