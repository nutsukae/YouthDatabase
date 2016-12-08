Imports ntbjc
Imports System.Configuration.ConfigurationManager
Imports System.Globalization
Public Class Rep2Pb
    Private _UserID As Integer
    Private _Constr As String
    Private _YouthID As Integer = -1
    Private _CaseID As Integer = -1
    Private _ProbationID As Integer = -1
    Private _R2PID As Integer = -1

    Public Sub New()
        InitializeComponent()
        Me._UserID = GlobalVar.UserID
        'Me._UserID = 1
        Me._Constr = ConnectionStrings("Connection").ToString
    End Sub

    Private Sub Rep2Pb_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMainAssociateJudge()
    End Sub

#Region "Button"
    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Using frm = New pb_search_youth()
            Dim result = frm.ShowDialog()

            If result = DialogResult.OK Then
                _YouthID = frm.YouthID
                _CaseID = frm.CaseID

                'Get Probation ID and Information
                Dim Prob As New Probation(_Constr)
                _ProbationID = Prob.GetID(_YouthID, _CaseID)
                LoadReport(_ProbationID)

            End If
        End Using
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        Dim ActDate = dtpActDate.Text
        Dim AstJudgeID = cbMainAssociateJudge.SelectedValue.ToString
        Dim Remark = tbRemark.Text
        Dim ISUA = IIf(cbISUA.Checked, 1, 0)

        Dim _R2P As New R2P(_Constr)

        If cbHasNextTime.Checked Then
            'Insert Part
            Dim Interval = CInt(cbNextDays.Text.Replace(" วัน", ""))
            Dim NextDays = Now.AddDays(Interval)
            ' MessageBox.Show(NextDays)

            If _R2P.Update(_R2PID, ActDate, AstJudgeID, Remark, ISUA, _UserID) Then
                If _R2P.Insert(_ProbationID, NextDays, _UserID) Then
                    MessageBox.Show("บันทึกรายละเอียดการรายงานตัวและเพิ่มวันนัดเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadReport(_ProbationID)
                    Reset()
                    Exit Sub
                Else
                    MessageBox.Show("ไม่สามารถเพิ่มวันนัดได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("ไม่สามารถบันทึกรายละเอียดการรายงานตัวได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            'Update Part
            If _R2P.Update(_R2PID, ActDate, AstJudgeID, Remark, ISUA, _UserID) Then
                MessageBox.Show("บันทึกรายละเอียดการรายงานตัวเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadReport(_ProbationID)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถบันทึกรายละเอียดการรายงานตัวได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
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

    Private Sub LoadReport(ByVal ProbationID As Integer)
        Dim R2P As New R2P(_Constr)
        Dim ds As New DataSet
        ds = R2P.ListByProbationID(ProbationID)

        dgvReport.Rows.Clear()

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim ci = CultureInfo.CreateSpecificCulture("th-TH")
                Dim id = row("id").ToString
                Dim EstDate = CDate(row("EstDate")).ToString("dd MMMM yyyy", ci)
                Dim ActDate = CDate(row("ActDate")).ToString("dd MMMM yyyy", ci)
                dgvReport.Rows.Add(id, dgvReport.Rows.Count + 1, EstDate, ActDate)
            Next
        End If
    End Sub

    Private Sub Reset()
        dgvReport.Rows.Clear()

        tbEstDate.Text = ""
        dtpActDate.Text = Now
        tbRemark.Text = ""
        cbISUA.Checked = False
        cbHasNextTime.Checked = False
        cbNextDays.Enabled = False
        _YouthID = -1
        _CaseID = -1
        _ProbationID = -1
        _R2PID = -1
    End Sub
#End Region

    Private Sub dgvReport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellDoubleClick
        Try
            _R2PID = CInt(dgvReport.Rows(e.RowIndex).Cells("id").Value)
            Dim ci = CultureInfo.CreateSpecificCulture("th-TH")

            Dim _R2P As New R2P(_Constr)
            _R2P.GetDetailByID(_R2PID)

            tbEstDate.Text = CDate(_R2P.EstDate).ToString("dd MMMM yyyy", ci)
            dtpActDate.Text = _R2P.ActDate
            cbMainAssociateJudge.SelectedValue = _R2P.AssociateJudgeID
            tbRemark.Text = _R2P.Remark
            cbISUA.Checked = CBool(_R2P.IsUreaAnalysis)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbHasNextTime_CheckedChanged(sender As Object, e As EventArgs) Handles cbHasNextTime.CheckedChanged
        If cbHasNextTime.Checked Then
            cbNextDays.Enabled = True
        Else
            cbNextDays.Enabled = False
        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        Reset()
    End Sub
End Class