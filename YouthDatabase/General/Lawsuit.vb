Imports System.Configuration.ConfigurationManager
Imports ntbjc

Public Class Lawsuit
    Private _conStr As String = ConnectionStrings("Connection").ConnectionString
    Private _UserId As Integer
    Private _CaseID As Integer = -1
    Private isSeacrh As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
    End Sub

    Private Sub Lawsuit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me._UserId = GlobalVar.UserID
        'Me._UserId = 1
        Me._conStr = ConnectionStrings("Connection").ToString
        btInsertTort.Enabled = False
        btRemoveTort.Enabled = False

        LoadCaseType()
        LoadLocation()
    End Sub

#Region "Button"
    Private Sub btAdd_Click(sender As Object, e As EventArgs)
        Using frm = New YouthDatabase.Tort()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                Dim TortID = frm.TortID
                'MessageBox.Show(TortID.ToString)
                InsertTort(TortID)
            End If
        End Using
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        'Check isUpdate Flag
        'isUpdate = False : Insert New Lawsuit -> insert tort
        'isUpdate = True : Update exist lawsuit -> update tort

        If DialogResult.Cancel = MessageBox.Show("กรุณาตรวจสอบความถูกต้องของข้อมูลก่อนบันทึกครับ", "ยีนยันบันทึกข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Exit Sub
        End If

        Dim CaseTypeID As Integer = 0
        Dim result = cbCaseType.SelectedValue
        Dim row As DataRowView = DirectCast(cbCaseType.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            CaseTypeID = CInt(row(0).ToString)
        End If

        If CaseTypeID = 4 Or CaseTypeID = 5 Then
            If String.IsNullOrEmpty(tbBlackNo.Text) Or String.IsNullOrEmpty(tbRedNo.Text) Then
                MessageBox.Show("เยาวชนต้องคดีอาญา กรุณาใส่หมายดำและหมายเลขแดงให้ครบด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbBlackNo.Focus()
                Exit Sub
            End If

            If rbProgess.Checked Then
                MessageBox.Show("เนื่องจากคดีสิ้นสุดแล้วกรุณาเลือกมาตราที่พิพากษาด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rbOther.Focus()
                Exit Sub
            End If
        End If

        Dim caseno As String = tbCaseNo.Text
        Dim Title As String = tbCaseTitle.Text

        If String.IsNullOrEmpty(Title) Then
            MessageBox.Show("กรุณาป้องชื่อคดีด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbCaseTitle.Focus()
            Exit Sub
        End If

        Dim VictimName As String = tbVictimName.Text
        Dim VictimAddress = tbVictimAddress.Text
        Dim VictimPhone = mtbMobile.Text
        Dim LawsuitDate As Date = CDate(dtpLawsuit.Text)
        Dim AdviceDate As Date = CDate(dtpAdvice.Text)
        Dim InspectDate As Date = CDate(dtpInspect.Text)

        'If StartDate = EndDate Or StartDate > EndDate Then
        '    MessageBox.Show("วันที่เริ่มต้นต้องก่อนวันที่สิ้นสุดเท่านั้นครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    dtpLawsuit.Focus()
        '    Exit Sub
        'End If

        Dim LocationID = 0
        result = cbLocation.SelectedValue
        row = DirectCast(cbLocation.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            LocationID = CInt(row(0).ToString)
        End If

        Dim BlackNo As String = tbBlackNo.Text
        Dim Section As Integer = 0
        If rbProgess.Checked Then
            Section = 1
        ElseIf rb90.Checked Then
            Section = 2
        ElseIf rb132.Checked Then
            Section = 3
        ElseIf rbOther.Checked Then
            Section = 4
        End If

        Dim RedNo As String = tbRedNo.Text
        Dim PlanDate As Date = CDate(dtpPlan.Text)
        Dim ExPlanDate As Date = CDate(dtpExPlan.Text)
        Dim ExDate As Date = CDate(dtpEx.Text)

        Dim LMU As Integer = _UserId

        If Not isSeacrh Then
            'Insert Part
            Dim Lawsuit As New ntbjc.Lawsuit(_conStr)
            Dim LawsuitID As Integer = Lawsuit.insert(CaseTypeID, caseno, Title, VictimName, VictimAddress, VictimPhone, LawsuitDate, AdviceDate, InspectDate, LocationID, BlackNo, Section, RedNo, PlanDate, ExPlanDate, ExDate, LMU)

            If LawsuitID <> -1 Then
                MessageBox.Show("เพิ่มข้อมูลคดีเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                'Insert Lawsuit Incomplete
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลคดีได้ครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            'Update Case Information
            'Remove Exist Tort
            'Insert New Tort
            Dim _Lawsuit = New ntbjc.Lawsuit(_conStr)
            If _Lawsuit.Update(_CaseID, CaseTypeID, caseno, Title, VictimName, VictimAddress, VictimPhone, LawsuitDate, AdviceDate, InspectDate, LocationID, BlackNo, Section, RedNo, PlanDate, ExPlanDate, ExDate, LMU) Then
                MessageBox.Show("เปลี่ยนแปลงข้อมูลคดีเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่เปลี่ยนแปลงข้อมูลคดีได้ครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        Reset()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Using frm = New SearchCase()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                _CaseID = frm.CaseID
                isSeacrh = True
                'MessageBox.Show(_CaseID.ToString)
                GetDetail(_CaseID)

                btInsertTort.Enabled = True
                btRemoveTort.Enabled = True
            End If
        End Using
    End Sub

    Private Sub btInsertTort_Click(sender As Object, e As EventArgs) Handles btInsertTort.Click
        If _CaseID = -1 Then
            MessageBox.Show("กรุณาเลือกค้นหาคดีที่ต้องการเพิ่มมูลฐานความผิดก่อนครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using frm = New YouthDatabase.Tort()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                Dim TortID = frm.TortID
                'MessageBox.Show(TortID.ToString)
                InsertTort(TortID)
            End If
        End Using
    End Sub

    Private Sub btRemoveTort_Click(sender As Object, e As EventArgs) Handles btRemoveTort.Click
        If _CaseID = -1 Then
            MessageBox.Show("กรุณาเลือกค้นหาคดีที่ต้องการลบมูลฐานความผิดก่อนครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Get Tort ID
        'Re-Arrange Tort
        Dim index = dgvTort.CurrentCell.RowIndex
        Dim TortID = CInt(dgvTort.Rows(index).Cells("ID").Value)
        Dim _Lawsuit = New ntbjc.Lawsuit(_conStr)

        'MessageBox.Show(TortID.ToString)

        If _Lawsuit.RemoveTortByID(_CaseID, TortID) Then
            dgvTort.Rows.RemoveAt(index)
            For i = 0 To dgvTort.RowCount - 1
                dgvTort.Rows(i).Cells("no").Value = i + 1
            Next
        End If
    End Sub
#End Region

#Region "Function"
    Private Sub GetDetail(ByVal CaseID As Integer)
        Dim _Case = New ntbjc.Lawsuit(_conStr)
        Dim ds = New DataSet
        ds = _Case.GetDetailByID(CaseID)

        If Not ds Is Nothing Then
            Dim CaseTypeID = CInt(ds.Tables(0).Rows(0)("CaseTypeID").ToString)
            Dim CaseNo = ds.Tables(0).Rows(0)("CaseNo").ToString
            Dim Title = ds.Tables(0).Rows(0)("Title").ToString
            Dim VictimName = ds.Tables(0).Rows(0)("Victim_name").ToString
            Dim VictimAddress = ds.Tables(0).Rows(0)("Victim_address").ToString
            Dim VictimPhone = ds.Tables(0).Rows(0)("Victim_phone").ToString
            Dim LawsuitDate = ds.Tables(0).Rows(0)("LawsuitDate").ToString
            Dim AdviceDate = ds.Tables(0).Rows(0)("AdviceDate").ToString
            Dim InspectDate = ds.Tables(0).Rows(0)("InspectDate").ToString
            Dim LocationID = CInt(ds.Tables(0).Rows(0)("LocationID").ToString)
            Dim BlackNo = ds.Tables(0).Rows(0)("BlackNo").ToString
            Dim Section = CInt(ds.Tables(0).Rows(0)("Section").ToString)
            Dim RedNo = ds.Tables(0).Rows(0)("RedNo").ToString
            Dim PlanDate = ds.Tables(0).Rows(0)("PlanDate").ToString
            Dim ExPlanDate = ds.Tables(0).Rows(0)("ExPlanDate").ToString
            Dim ExDate = ds.Tables(0).Rows(0)("ExDate").ToString

            cbLocation.SelectedValue = LocationID
            cbCaseType.SelectedValue = CaseTypeID

            tbCaseNo.Text = CaseNo
            tbCaseTitle.Text = Title
            tbVictimName.Text = VictimName
            tbVictimAddress.Text = VictimAddress
            mtbMobile.Text = VictimPhone
            dtpLawsuit.Value = CDate(LawsuitDate)
            dtpAdvice.Value = CDate(AdviceDate)
            dtpInspect.Value = CDate(InspectDate)

            tbBlackNo.Text = BlackNo
            tbRedNo.Text = RedNo

            Select Case Section
                Case 1
                    rbProgess.Checked = True
                Case 2
                    rb90.Checked = True
                Case 3
                    rb132.Checked = True
                Case 4
                    rbOther.Checked = True
            End Select

            dtpPlan.Value = CDate(PlanDate)
            dtpExPlan.Value = CDate(ExPlanDate)
            dtpEx.Value = CDate(ExDate)

        End If

        Dim dsTort As New DataSet
        dsTort = _Case.ListTort(CaseID)

        If Not dsTort Is Nothing Then

            dgvTort.Rows.Clear()
            For Each row In dsTort.Tables(0).Rows
                Dim id = CInt(row("tortid"))
                Dim name = row("name").ToString
                dgvTort.Rows.Add(id, dgvTort.Rows.Count + 1, name)
            Next
        End If

        Dim dsYouth As New DataSet
        dsYouth = _Case.ListYouth(CaseID)
        If Not dsYouth Is Nothing Then
            dgvYouth.Rows.Clear()
            For Each row In dsYouth.Tables(0).Rows
                'Dim id = CInt(row("tortid"))
                Dim fullname = row("fullname").ToString
                Dim idcard = row("idcard").ToString
                dgvYouth.Rows.Add(dgvYouth.Rows.Count + 1, fullname, idcard)
            Next
        End If

    End Sub

    Private Sub LoadCaseType()
        Dim _CaseType = New CaseType(_conStr)
        Dim ds = New DataSet()
        ds = _CaseType.List

        If Not ds Is Nothing Then
            cbCaseType.DataSource = ds.Tables(0)
            cbCaseType.DisplayMember = "name"
            cbCaseType.ValueMember = "ID"
        End If
    End Sub

    Private Sub LoadLocation()
        Dim _location = New Location(_conStr)
        Dim ds = New DataSet()
        ds = _location.List

        If Not ds Is Nothing Then
            ds.Tables(0).Rows(0).Delete()
            cbLocation.DataSource = ds.Tables(0)
            cbLocation.DisplayMember = "name"
            cbLocation.ValueMember = "ID"
        End If
    End Sub

    Private Sub InsertTort(ByVal TortID As Integer)
        Dim _Tort As New ntbjc.Tort(_conStr)
        Dim _Lawsuit = New ntbjc.Lawsuit(_conStr)
        Dim name = _Tort.GetName(TortID)

        'Insert Tort to DataGridView
        Me.dgvTort.Rows.Add(TortID, dgvTort.Rows.Count + 1, name)

        'Insert Tort to Database
        _Lawsuit.BindTort(_CaseID, TortID)
    End Sub

    Private Sub Reset()
        'tbSearchCase.Text = ""
        'rbSurrender.Checked = True
        tbCaseNo.Text = ""
        dtpLawsuit.Text = Now
        dtpAdvice.Text = Now
        dtpInspect.Text = Now
        dtpPlan.Text = Now
        dtpExPlan.Text = Now
        dtpEx.Text = Now
        dgvTort.Rows.Clear()
        dgvYouth.Rows.Clear()
        tbBlackNo.Text = ""
        tbRedNo.Text = ""
        rb132.Checked = True
        isSeacrh = False
        Me._CaseID = -1
        tbCaseTitle.Text = ""
        tbVictimName.Text = ""
        tbVictimAddress.Text = ""
        mtbMobile.Text = ""

        btInsertTort.Enabled = False
        btRemoveTort.Enabled = False
    End Sub

#End Region

    Private Sub cbCaseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCaseType.SelectedIndexChanged
        Dim CaseTypeID As Integer = 0
        Dim result = cbCaseType.SelectedValue
        Dim row As DataRowView = DirectCast(cbCaseType.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            CaseTypeID = CInt(row(0).ToString)
        End If

        Select Case CaseTypeID
            Case 1
                tbCaseNo.Text = "มต. "
            Case 2
                tbCaseNo.Text = "ตจ. "
            Case 3
                tbCaseNo.Text = "ผ."
            Case 4
                tbCaseNo.Text = "อ."
            Case 5
                tbCaseNo.Text = "อย."
        End Select

    End Sub

End Class