Imports ntbjc
Imports System.Configuration.ConfigurationManager
Imports System.Globalization

Public Class AdviceCenter
    Private _UserID As Integer
    Private _Constr As String
    Private _YouthID As Integer
    Private _CaseID As Integer
    Private _UserTypeId As Integer
    Private _AdvID As Integer = -1

    Public Sub New()
        InitializeComponent()
        Me._UserID = GlobalVar.UserID
        Me._UserTypeId = GlobalVar.UserTypeId
        'Me._UserID = 1
        Me._Constr = ConnectionStrings("Connection").ToString
    End Sub
    Private Sub AdviceCenter_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMainAssociateJudge()
        LoaSupportAssociateJudge()
    End Sub

#Region "button"
    Private Sub btAddYouth_Click(sender As Object, e As EventArgs) Handles btAddYouth.Click
        Using frm = New actper_search_youth()
            Dim result = frm.ShowDialog()

            If result = DialogResult.OK Then
                _YouthID = frm.YouthID
                _CaseID = frm.CaseID

                'Get Youth Detail
                Dim _Youth = New Youth(_Constr)
                _Youth.GetYouth(_YouthID)
                tbFullname.Text = String.Format("{0} {1}", _Youth.Firstname, _Youth.Lastname)
                tbIDCard.Text = _Youth.IDCard

                'Get Case Detail
                Dim _Case = New ntbjc.Lawsuit(_Constr)
                Dim ds As New DataSet
                ds = _Case.GetDetailByID(_CaseID)

                If Not ds Is Nothing Then
                    For Each row As DataRow In ds.Tables(0).Rows
                        tbBlackNo.Text = row("blackno").ToString
                        tbCaseTitle.Text = row("title").ToString
                    Next
                End If

                LoadActivity(_YouthID, _CaseID)
                GetDetailByID(_YouthID, _CaseID)
                'btSubmit.Enabled = True
            End If
        End Using
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        If DialogResult.Cancel = MessageBox.Show("กรุณาตรวจสอบความถูกต้องของข้อมูลก่อนบันทึกครับ", "ยีนยันบันทึกข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Exit Sub
        End If

        Dim AdvBlackNo = tbAdvBlackNo.Text
        Dim AdvRedNo = tbAdvRedNo.Text
        Dim MainAssociateJudge = cbMainAssociateJudge.SelectedValue.ToString
        Dim SupportAssociateJudge = cbSupportAssociateJudge.SelectedValue.ToString
        Dim Reason = tbReason.Text
        Dim Behaviour = tbBehaviour.Text
        Dim Thinking = tbThinking.Text
        Dim Emotion = tbEmotion.Text
        Dim Family = tbFamily.Text
        Dim Social = tbSocial.Text
        Dim Summary = tbSummary.Text

        Dim _Adv = New AdvCenter(_Constr)
        If _AdvID = -1 Then
            'insert
            If _Adv.Insert(_YouthID, _CaseID, AdvBlackNo, AdvRedNo, MainAssociateJudge, SupportAssociateJudge, Reason, Behaviour, Thinking, Emotion, Family, Social, Summary, _UserID) Then
                MessageBox.Show("เพิ่มข้อมูลคำปรึกษาเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลคำปรึกษาได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            'update
            If _Adv.Update(_AdvID, _YouthID, _CaseID, AdvBlackNo, AdvRedNo, MainAssociateJudge, SupportAssociateJudge, Reason, Behaviour, Thinking, Emotion, Family, Social, Summary, _UserID) Then
                MessageBox.Show("แก้ไขคำปรึกษาเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถแก้ไขคำปรึกษาได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        Reset()
    End Sub
#End Region

#Region "Function"
    Private Sub GetDetailByID(ByVal YouthID As Integer, ByVal CaseID As Integer)
        Dim _Adv = New AdvCenter(_Constr)
        Dim ds = New DataSet
        ds = _Adv.GetDetailByID(YouthID, CaseID)

        If Not ds Is Nothing Then
            If ds.Tables(0).Rows.Count < 1 Then
                Exit Sub
            End If

            _AdvID = CInt(ds.Tables(0).Rows(0)("id").ToString)
            tbAdvBlackNo.Text = ds.Tables(0).Rows(0)("blackno").ToString
            tbAdvRedNo.Text = ds.Tables(0).Rows(0)("redno").ToString
            cbMainAssociateJudge.SelectedValue = CInt(ds.Tables(0).Rows(0)("MainAssociateJudgeID").ToString)
            cbSupportAssociateJudge.SelectedValue = CInt(ds.Tables(0).Rows(0)("SupportAssociateJudgeID").ToString)
            tbReason.Text = ds.Tables(0).Rows(0)("Reason").ToString
            tbBehaviour.Text = ds.Tables(0).Rows(0)("Behaviour").ToString
            tbThinking.Text = ds.Tables(0).Rows(0)("Thinking").ToString
            tbEmotion.Text = ds.Tables(0).Rows(0)("Emotion").ToString
            tbFamily.Text = ds.Tables(0).Rows(0)("Family").ToString
            tbSocial.Text = ds.Tables(0).Rows(0)("Social").ToString
            tbSummary.Text = ds.Tables(0).Rows(0)("Summary").ToString
        End If

    End Sub

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

    Private Sub LoaSupportAssociateJudge()
        Dim _asso = New AssociateJudge(_Constr)
        Dim ds = New DataSet()
        ds = _asso.List()

        If Not ds Is Nothing Then
            cbSupportAssociateJudge.DataSource = ds.Tables(0)
            cbSupportAssociateJudge.DisplayMember = "fullname"
            cbSupportAssociateJudge.ValueMember = "ID"
        End If
    End Sub

    Private Sub LoadActivity(ByVal YouthID As Integer, ByVal CaseID As Integer)
        Dim advCenter = New AdvCenter(_Constr)
        Dim ds = New DataSet
        ds = advCenter.ListActivity(YouthID, CaseID, _UserTypeId)

        If Not ds Is Nothing Then
            Dim ci = CultureInfo.CreateSpecificCulture("th-TH")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each row0 As DataRow In ds.Tables(0).Rows
                    Dim actName = row0("actname").ToString
                    Dim location = row0("location").ToString
                    Dim actDate = CDate(row0("actDate")).ToString("dd MMMM yyyy", ci)
                    Dim deptName = row0("deptname").ToString

                    dgvAct0.Rows.Add(dgvAct0.Rows.Count + 1, actName, location, actDate, deptName)
                Next
            End If

            If ds.Tables(1).Rows.Count > 0 Then
                For Each row1 As DataRow In ds.Tables(1).Rows
                    Dim location = row1("location").ToString
                    Dim actDate = CDate(row1("actDate")).ToString("dd MMMM yyyy", ci)
                    Dim deptName = row1("name").ToString
                    dgvAct1.Rows.Add(dgvAct1.Rows.Count + 1, location, actDate, deptName)
                Next
            End If
        End If
    End Sub

    Private Sub Reset()
        _AdvID = -1
        tbFullname.Text = ""
        tbIDCard.Text = ""
        tbBlackNo.Text = ""
        tbCaseTitle.Text = ""
        tbAdvBlackNo.Text = ""
        tbAdvRedNo.Text = ""
        tbReason.Text = ""
        tbBehaviour.Text = ""
        tbThinking.Text = ""
        tbEmotion.Text = ""
        tbFamily.Text = ""
        tbSocial.Text = ""
        tbSummary.Text = ""

        dgvAct0.Rows.Clear()
        dgvAct1.Rows.Clear()
    End Sub
#End Region

End Class