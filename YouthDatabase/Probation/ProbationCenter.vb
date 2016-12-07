Imports ntbjc
Imports System.Configuration.ConfigurationManager
Imports System.Globalization
Public Class ProbationCenter
    Private _UserID As Integer
    Private _Constr As String
    Private _YouthID As Integer = -1
    Private _CaseID As Integer = -1
    Private _ProbationID As Integer = -1

    Public Sub New()
        InitializeComponent()
        'Me._UserID = GlobalVar.UserID
        Me._UserID = 1
        Me._Constr = ConnectionStrings("Connection").ToString
    End Sub

    Private Sub ProbationCenter_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMainAssociateJudge()
    End Sub

#Region "button"
    Private Sub btAddYouth_Click(sender As Object, e As EventArgs) Handles btAddYouth.Click
        Using frm = New pb_search_youth()
            Dim result = frm.ShowDialog()

            If result = DialogResult.OK Then
                _YouthID = frm.YouthID
                _CaseID = frm.CaseID

                'Get Probation ID and Information
                Dim Prob As New Probation(_Constr)
                _ProbationID = Prob.GetID(_YouthID, _CaseID)
                Prob.GetDetail(_ProbationID)

                'Get Youth Detail
                Dim _Youth = New Youth(_Constr)
                _Youth.GetYouth(_YouthID)
                tbFullname.Text = String.Format("{0} {1}", _Youth.Firstname, _Youth.Lastname)
                tbAddress.Text = String.Format("{0} หมู่ที่ {1} ซอย{2} ถนน{3} ตำบล{4} อำเภอ{5} จังหวัด{6} {7}", _Youth.CAHno, _Youth.CAMoo, _Youth.CASoi, _Youth.CARoad, _Youth.CATumbon, _Youth.CAAumphor, _Youth.CAProvince, _Youth.CAZipcode)
                tbIDCard.Text = _Youth.IDCard
                mtbCAPhone.Text = _Youth.Mobile

                tbFathername.Text = _Youth.FatherName
                mtbFatherPhone.Text = _Youth.FatherMobile

                tbMotherName.Text = _Youth.MotherName
                mtbMotherPhone.Text = _Youth.MotherMobile

                ''Get Case Detail
                Dim _Case = New ntbjc.Lawsuit(_Constr)
                Dim ds As New DataSet
                ds = _Case.GetDetailByID(_CaseID)

                If Not ds Is Nothing Then
                    For Each row As DataRow In ds.Tables(0).Rows
                        tbBlackNo.Text = row("blackno").ToString
                        tbRedNo.Text = row("redno").ToString
                        tbCaseTitle.Text = row("title").ToString
                    Next
                End If

                tbCommandText.Text = Prob.CommandText
                cbMainAssociateJudge.SelectedValue = Prob.AssociateJudgeID
                tbRef.Text = Prob.Reference
                dtpStartDate.Text = Prob.StartDate
                dtpEndDate.Text = Prob.EndDate
                tbSummaryText.Text = Prob.SummaryText
                cbTransfer.Checked = CBool(Prob.IsTransfer)
                dtpTransferDate.Text = Prob.TransferDate

                'LoadActivity(_YouthID, _CaseID)
                'GetDetailByID(_YouthID, _CaseID)
                'btSubmit.Enabled = True
            End If
        End Using
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        Dim BlackNo = ""
        Dim RedNo = ""
        Dim CommandText = tbCommandText.Text
        Dim AssociateJudgeID = cbMainAssociateJudge.SelectedValue.ToString
        Dim pbRef = tbRef.Text
        Dim StartDate As Date = CDate(dtpStartDate.Text)
        Dim EndDate As Date = CDate(dtpEndDate.Text)
        Dim SummaryText = tbSummaryText.Text
        Dim isTransfer = IIf(cbTransfer.Checked, 1, 0)
        Dim TransferDate As Date = IIf(cbTransfer.Checked, CDate(dtpTransferDate.Text), Now)

        Dim Prob As New Probation(_Constr)

        If _ProbationID = -1 Then
            'Insert Part
            Dim ProbationID = Prob.Insert(_YouthID, _CaseID, BlackNo, RedNo, pbRef, CommandText, AssociateJudgeID, StartDate, EndDate, SummaryText, isTransfer, TransferDate, _UserID)

            If ProbationID <> -1 Then
                Dim R2P As New R2P(_Constr)

                If R2P.Insert(ProbationID, StartDate, _UserID) Then
                    MessageBox.Show("เพิ่มข้อมูลการรายงานตัวเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Reset()
                    Exit Sub
                Else
                    MessageBox.Show("ไม่สามารถเพิ่มข้อมูลการรายงานตัวได้ เนื่องจากไม่สามารถเพิ่มวันนัดได้", "พบปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลการรายงานตัวได้", "พบปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            'Update Part
            If Prob.Update(_ProbationID, BlackNo, RedNo, pbRef, CommandText, AssociateJudgeID, StartDate, EndDate, SummaryText, isTransfer, TransferDate, _UserID) Then
                MessageBox.Show("แก้ไขข้อมูลการรายงานตัวเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลการรายงานตัวได้", "พบปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        Reset()
    End Sub
#End Region

#Region "Function"
    Private Sub LoadMainAssociateJudge()
        Dim _asso = New AssociateJudge(_Constr)
        Dim ds = New DataSet()
        ds = _asso.List()

        If Not ds Is Nothing Then
            cbMainAssociateJudge.DataSource = ds.Tables(0)
            cbMainAssociateJudge.DisplayMember = "fullname"
            cbMainAssociateJudge.ValueMember = "ID"
        End If
    End Sub

    Private Sub Reset()
        tbFullname.Text = ""
        tbIDCard.Text = ""
        tbAddress.Text = ""
        mtbCAPhone.Text = ""
        tbFathername.Text = ""
        mtbFatherPhone.Text = ""
        tbMotherName.Text = ""
        mtbMotherPhone.Text = ""
        tbBlackNo.Text = ""
        tbRedNo.Text = ""
        tbCaseTitle.Text = ""

        tbCommandText.Text = ""
        tbRef.Text = ""
        dtpStartDate.Text = Now
        dtpEndDate.Text = Now
        tbSummaryText.Text = ""
        cbTransfer.Checked = False
        dtpStartDate.Text = Now

        dgvReport.Rows.Clear()
        dgvAct0.Rows.Clear()
        dgvAct1.Rows.Clear()
    End Sub
#End Region

End Class