Imports ntbjc
Imports System.Configuration.ConfigurationManager
Imports System.Globalization
Public Class ProbationCenter
    Private _UserID As Integer
    Private _Constr As String
    Private _YouthID As Integer
    Private _CaseID As Integer
    Private _UserTypeId As Integer
    Private _AdvID As Integer = -1

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

                LoadActivity(_YouthID, _CaseID)
                'GetDetailByID(_YouthID, _CaseID)
                'btSubmit.Enabled = True
            End If
        End Using
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
#End Region

End Class