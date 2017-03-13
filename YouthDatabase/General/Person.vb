Imports System.Text.RegularExpressions
Imports System.Globalization
Imports ntbjc
Imports System.Configuration.ConfigurationManager
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO

Public Class Person
    Private isSeacrh As Boolean = False
    Private _UserID As Integer
    Private _Constr As String
    Private _CaseID As Integer
    Private _PersonID As Integer = -1

#Region "PersonDetailTab"

#Region "Regular Expression"
    Private Function isIdcard(ByVal idcard As String) As Boolean
        Dim idcardPattern As String = "\d{1}-\d{4}-\d{5}-\d{2}-\d{1}|\d{13}"

        Dim reIdCard As New Regex(idcardPattern)

        If Not String.IsNullOrEmpty(idcard) Then
            Return reIdCard.IsMatch(idcard)
        Else
            Return False
        End If

    End Function

#End Region

#Region "Radio Button"
    Private Sub cbSameRA_CheckedChanged(sender As Object, e As EventArgs) Handles cbSameRA.CheckedChanged
        If cbSameRA.Checked Then
            tbCAHno.Text = tbRAHno.Text
            tbCAMoo.Text = tbRAMoo.Text
            tbCASoi.Text = tbRASoi.Text
            tbCARoad.Text = tbRARoad.Text
            tbCATumbon.Text = tbRATumbon.Text
            tbCAAumphor.Text = tbRAAumphor.Text
            tbCAProvince.Text = tbRAProvince.Text
            mtbCAZipcode.Text = mtbRAZipcode.Text
            tbCAPhone.Text = tbRAPhone.Text
            tbCAHno.Enabled = False
            tbCAMoo.Enabled = False
            tbCASoi.Enabled = False
            tbCARoad.Enabled = False
            tbCATumbon.Enabled = False
            tbCAAumphor.Enabled = False
            tbCAProvince.Enabled = False
            mtbCAZipcode.Enabled = False
            tbCAPhone.Enabled = False
        Else
            tbCAHno.Enabled = True
            tbCAMoo.Enabled = True
            tbCASoi.Enabled = True
            tbCARoad.Enabled = True
            tbCATumbon.Enabled = True
            tbCAAumphor.Enabled = True
            tbCAProvince.Enabled = True
            mtbCAZipcode.Enabled = True
            tbCAPhone.Enabled = True
        End If
    End Sub

#End Region

#Region "Function"
    Private Sub Reset()
        isSeacrh = False
        tbFirstname.Text = ""
        tbLastname.Text = ""
        mtbIdcard.Text = ""
        dtpDOB.Text = Now
        rbM.Checked = True
        mtbMobile.Text = ""
        tbShirtSize.Text = ""
        tbShoeSize.Text = ""
        tbRAHno.Text = ""
        tbRAMoo.Text = ""
        tbRASoi.Text = ""
        tbRARoad.Text = ""
        tbRATumbon.Text = ""
        tbRAAumphor.Text = ""
        tbRAProvince.Text = ""
        mtbRAZipcode.Text = ""
        tbRAPhone.Text = ""
        cbSameRA.Checked = False
        tbCAHno.Text = ""
        tbCAMoo.Text = ""
        tbCASoi.Text = ""
        tbCARoad.Text = ""
        tbCATumbon.Text = ""
        tbCAAumphor.Text = ""
        tbCAProvince.Text = ""
        mtbCAZipcode.Text = ""
        tbCAPhone.Text = ""
        rbMar1.Checked = True
        mtbMarOpt.Text = ""
        rbFam1.Checked = True
        tbFathername.Text = ""
        mtbFatherPhone.Text = ""
        tbMotherName.Text = ""
        mtbMotherPhone.Text = ""
        rbStay1.Checked = True
        tbStayOpt1.Text = ""
        mtbStayOpt2.Text = ""
        rbEdu1.Checked = True
        tbEduOpt.Text = ""
        rbStu1.Checked = True
        tbStuOpt.Text = ""
        rbOp1.Checked = True
        tbOpOpt.Text = ""
        _PersonID = -1
        dgvCaseList.Rows.Clear()
    End Sub

    Private Sub GetInfo(ByRef myYouth As Youth)

        _PersonID = myYouth.ID
        tbFirstname.Text = myYouth.Firstname
        tbLastname.Text = myYouth.Lastname
        mtbIdcard.Text = myYouth.IDCard
        dtpDOB.Text = myYouth.DateofBirth

        Select Case myYouth.Sex
            Case 1
                rbM.Checked = True
            Case Else
                rbF.Checked = True
        End Select

        tbRace.Text = myYouth.Race
        tbNationality.Text = myYouth.Nationality
        cbReligion.SelectedValue = myYouth.ReligionID
        mtbMobile.Text = myYouth.Mobile
        tbShirtSize.Text = myYouth.ShirtSize
        tbShoeSize.Text = myYouth.ShoeSize
        tbRAHno.Text = myYouth.RAHno
        tbRAMoo.Text = myYouth.RAMoo
        tbRASoi.Text = myYouth.RASoi
        tbRARoad.Text = myYouth.RARoad
        tbRATumbon.Text = myYouth.RATumbon
        tbRAAumphor.Text = myYouth.RAAumphor
        tbRAProvince.Text = myYouth.RAProvince
        mtbRAZipcode.Text = myYouth.RAZipcode
        tbRAPhone.Text = myYouth.CAPhone
        tbCAHno.Text = myYouth.CAHno
        tbCAMoo.Text = myYouth.CAMoo
        tbCASoi.Text = myYouth.CASoi
        tbCARoad.Text = myYouth.CARoad
        tbCATumbon.Text = myYouth.CATumbon
        tbCAAumphor.Text = myYouth.CAAumphor
        tbCAProvince.Text = myYouth.CAProvince
        mtbCAZipcode.Text = myYouth.CAZipcode
        tbCAPhone.Text = myYouth.CAPhone

        Select Case myYouth.MarriageStatus
            Case 1
                rbMar1.Checked = True
            Case 2
                rbMar2.Checked = True
            Case 3
                rbMar4.Checked = True
                mtbMarOpt.Text = myYouth.MarriageOpt
            Case Else
                rbMar4.Checked = True
        End Select

        Select Case myYouth.FamilyStatus
            Case 1
                rbFam1.Checked = True
            Case 2
                rbFam2.Checked = True
            Case 3
                rbFam3.Checked = True
            Case Else
                rbFam4.Checked = True
        End Select

        tbFathername.Text = myYouth.FatherName
        mtbFatherPhone.Text = myYouth.FatherMobile
        tbMotherName.Text = myYouth.MotherName
        mtbMotherPhone.Text = myYouth.MotherMobile

        Select Case myYouth.StayStatus
            Case 1
                rbStay1.Checked = True
            Case 2
                rbStay2.Checked = True
            Case 3
                rbStay3.Checked = True
            Case Else
                rbStay4.Checked = True
                tbStayOpt1.Text = myYouth.StayOpt1
                mtbStayOpt2.Text = myYouth.StayOpt2
        End Select

        Select Case myYouth.EducatedStatus
            Case 1
                rbEdu2.Checked = True
            Case 2
                rbEdu3.Checked = True
            Case 3
                rbEdu4.Checked = True
            Case 4
                rbEdu5.Checked = True
            Case 5
                rbEdu6.Checked = True
            Case Else
                rbEdu1.Checked = True
        End Select
        tbEduOpt.Text = myYouth.EducatedOpt

        Select Case myYouth.StudyStatus
            Case 2
                rbStu7.Checked = True
            Case 3
                rbStu2.Checked = True
            Case 4
                rbStu3.Checked = True
            Case 5
                rbStu4.Checked = True
            Case 6
                rbStu5.Checked = True
            Case 7
                rbStu6.Checked = True
            Case 8
                rb9.Checked = True
            Case 9
                rbStu1.Checked = True
            Case 10
                rbstu8.Checked = True
        End Select
        tbStuOpt.Text = myYouth.StudyOpt

        Select Case myYouth.OccupationStatus
            Case 1
                rbOp2.Checked = True
            Case 2
                rbOp3.Checked = True
            Case 3
                rbOp4.Checked = True
            Case 4
                rbOp5.Checked = True
            Case 5
                rbOp6.Checked = True
            Case 6
                rbOp7.Checked = True
            Case 7
                rbOp8.Checked = True
            Case 15
                rbOp1.Checked = True
        End Select
        tbOpOpt.Text = myYouth.OccupationOpt

        Select Case myYouth.InterestStatus
            Case 2
                rbIn1.Checked = True
            Case 3
                rbIn2.Checked = True
            Case 4
                rbIn3.Checked = True
            Case 5
                rbIn4.Checked = True
            Case 6
                rbIn5.Checked = True
            Case 7
                rbIn6.Checked = True
            Case 8
                rbIn7.Checked = True
        End Select
        tbInOpt.Text = myYouth.InterestOpt

    End Sub

    Private Sub LoadReligion()
        Dim _religion = New Religion(_Constr)
        Dim ds = New DataSet

        ds = _religion.List

        If ds.Tables(0).Rows.Count > 0 Then
            cbReligion.DataSource = ds.Tables(0)
            cbReligion.DisplayMember = "name"
            cbReligion.ValueMember = "id"
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "Button"
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

        Dim firstname As String = tbFirstname.Text
        Dim lastname As String = tbLastname.Text
        Dim idcard As String = mtbIdcard.Text
        Dim DateofBirth As Date = CDate(dtpDOB.Text)
        Dim SexVal As Integer = 0
        If rbM.Checked Then
            SexVal = Sex.Sex.Male
        Else
            SexVal = Sex.Sex.Female
        End If

        Dim race = tbRace.Text
        Dim Nationality = tbNationality.Text

        Dim result = cbReligion.SelectedValue
        Dim ReligionID = 0

        Dim row As DataRowView = DirectCast(cbReligion.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            ReligionID = CInt(row(0).ToString)
        End If

        Dim ShirtSize As String = tbShirtSize.Text
        Dim ShoeSize As String = tbShoeSize.Text
        Dim RAHno As String = tbRAHno.Text
        Dim RAMoo As String = tbRAMoo.Text
        Dim RASoi As String = tbRASoi.Text
        Dim RARoad As String = tbRARoad.Text
        Dim RATumbon As String = tbRATumbon.Text
        Dim RAAumphor As String = tbRAAumphor.Text
        Dim RAProvince As String = tbRAProvince.Text
        Dim RAZipcode As String = mtbRAZipcode.Text
        Dim RAPhone As String = tbRAPhone.Text
        Dim CAHno As String = tbCAHno.Text
        Dim CAMoo As String = tbCAMoo.Text
        Dim CASoi As String = tbCASoi.Text
        Dim CARoad As String = tbCARoad.Text
        Dim CATumbon As String = tbCATumbon.Text
        Dim CAAumphor As String = tbCAAumphor.Text
        Dim CAProvince As String = tbCAProvince.Text
        Dim CAZipcode As String = mtbCAZipcode.Text
        Dim CAPhone As String = tbCAPhone.Text
        Dim Mobile As String = mtbMobile.Text

        Dim MarriageVal As Integer = 0
        Dim MarriageOpt As String = mtbMarOpt.Text
        If rbMar1.Checked Then
            MarriageVal = Marriage.Status.Single
        ElseIf rbMar2.Checked Then
            MarriageVal = Marriage.Status.Married
        ElseIf rbMar3.Checked Then
            MarriageVal = Marriage.Status.Divorce
        Else
            MarriageVal = Marriage.Status.HaveSon
            If String.IsNullOrEmpty(MarriageOpt) Then
                MessageBox.Show("กรุณาระบุจำนวนบุตรด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtbMarOpt.Focus()
                Exit Sub
            End If
        End If

        Dim FamilyVal As Integer = 0
        If rbFam1.Checked Then
            FamilyVal = Family.status.Parent
        ElseIf rbFam2.Checked Then
            FamilyVal = Family.status.ParentSeperate
        ElseIf rbFam3.Checked Then
            FamilyVal = Family.status.FatherOrMotherPassAway
        Else
            FamilyVal = Family.status.ParentPassAway
        End If
        Dim FatherName As String = tbFathername.Text
        Dim FatherMobile As String = mtbFatherPhone.Text
        Dim MotherName As String = tbMotherName.Text
        Dim MotherMobile As String = mtbMotherPhone.Text

        Dim StayVal As Integer = 0
        Dim StayOpt1 As String = tbStayOpt1.Text
        Dim StayOpt2 As String = mtbStayOpt2.Text
        If rbStay1.Checked Then
            StayVal = Stay.Status.Parent
        ElseIf rbStay2.Checked Then
            StayVal = Stay.Status.Father
        ElseIf rbStay3.Checked Then
            StayVal = Stay.Status.Mother
        Else
            StayVal = Stay.Status.Other
            If String.IsNullOrEmpty(StayOpt1) Then
                MessageBox.Show("กรุณาระบุชื่อผู้ปกครองด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbStayOpt1.Focus()
                Exit Sub
            End If

            If String.IsNullOrEmpty(StayOpt2) Then
                MessageBox.Show("กรุณาระบุเบอร์โทรศัพท์ผู้ปกครองด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtbStayOpt2.Focus()
                Exit Sub
            End If
        End If

        Dim EducatedVal As Integer = 0
        Dim EducatedOpt As String = tbEduOpt.Text
        If rbEdu1.Checked Then
            EducatedVal = Educated.status.NonEducated
        ElseIf rbEdu2.Checked Then
            EducatedVal = Educated.status.PrimarySchool
        ElseIf rbEdu3.Checked Then
            EducatedVal = Educated.status.JuniorHighSchool
        ElseIf rbEdu4.Checked Then
            EducatedVal = Educated.status.SenoirHighSchool
        ElseIf rbEdu5.Checked Then
            EducatedVal = Educated.status.VocationalCertificate
        Else
            EducatedVal = Educated.status.HighVocationalCertificate
        End If
        If String.IsNullOrEmpty(EducatedOpt) And Not rbEdu1.Checked Then
            MessageBox.Show("กรุณาระบุสถานศึกษาด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbEduOpt.Focus()
            Exit Sub
        End If

        Dim StudyVal As Integer = 0
        Dim StudyOpt As String = tbStuOpt.Text
        If rbStu1.Checked Then
            StudyVal = Study.Status.NonStudy
        ElseIf rbStu2.Checked Then
            StudyVal = Study.Status.PrimarySchool
        ElseIf rbStu3.Checked Then
            StudyVal = Study.Status.JuniorHighSchool
        ElseIf rbStu4.Checked Then
            StudyVal = Study.Status.SenoirHighSchool
        ElseIf rbStu5.Checked Then
            StudyVal = Study.Status.VocationalCertificate
        ElseIf rbStu6.Checked Then
            StudyVal = Study.Status.HighVocationalCertificate
        ElseIf rbStu7.Checked Then
            StudyVal = Study.Status.NonFormalEducation
        ElseIf rbstu8.Checked Then
            StudyVal = Study.Status.NonStudyButInterest
        Else
            StudyVal = Study.Status.BachelorDegree
        End If
        If String.IsNullOrEmpty(StudyOpt) And Not rbStu1.Checked Then
            MessageBox.Show("กรุณาระบุสถานศึกษาด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbStuOpt.Focus()
            Exit Sub
        End If

        Dim OccupationVal As Integer = 0
        Dim OccupationOpt As String = tbOpOpt.Text
        If rbOp1.Checked Then
            OccupationVal = Occupation.Status.NonOccupation
        ElseIf rbOp2.Checked Then
            OccupationVal = Occupation.Status.Employee
        ElseIf rbOp3.Checked Then
            OccupationVal = Occupation.Status.Mercenary
        ElseIf rbOp4.Checked Then
            OccupationVal = Occupation.Status.FamilyBusines
        ElseIf rbOp5.Checked Then
            OccupationVal = Occupation.Status.Driver
        ElseIf rbOp6.Checked Then
            OccupationVal = Occupation.Status.Security
        ElseIf rbOp7.Checked Then
            OccupationVal = Occupation.Status.Agriculturist
        ElseIf rbOp8.Checked Then
            OccupationVal = Occupation.Status.MotocycleTaxi
        End If
        If String.IsNullOrEmpty(OccupationOpt) And Not rbOp1.Checked Then
            MessageBox.Show("กรุณาระบุสถานที่ด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbOpOpt.Focus()
            Exit Sub
        End If

        Dim InterestVal As Integer = 0
        Dim InterestOpt = tbInOpt.Text
        If rbIn1.Checked Then
            InterestVal = Interest.Status.ConstructionWorker
        ElseIf rbIn2.checked Then
            InterestVal = Interest.Status.IndustrialWorker
        ElseIf rbin3.Checked Then
            InterestVal = Interest.Status.EngineerWorker
        ElseIf rbIn4.Checked Then
            InterestVal = Interest.Status.ElectricWorker
        ElseIf rbIn5.Checked Then
            InterestVal = Interest.Status.SkillDevelopementCenter
        ElseIf rbIn6.checked Then
            InterestVal = Interest.Status.DepartmentofEmployment
        ElseIf rbin7.checked Then
            InterestVal = Interest.Status.Other
        End If

        Dim LMU As Integer = _UserID

        If Not isSeacrh Then
            'Insert new youth
            Dim youth As Youth = New Youth(_Constr)

            If youth.CheckDuplicate(idcard) Then
                MessageBox.Show("เลขบัตรประชาชนซ้ำครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtbIdcard.Focus()
                Exit Sub
            End If

            If youth.Insert(firstname, lastname, idcard, DateofBirth, race, Nationality, ReligionID, SexVal, ShirtSize, ShoeSize,
                            RAHno, RAMoo, RASoi, RARoad, RATumbon, RAAumphor, RAProvince, RAZipcode, RAPhone,
                            CAHno, CAMoo, CASoi, CARoad, CATumbon, CAAumphor, CAProvince, CAZipcode, CAPhone, Mobile,
                            MarriageVal, MarriageOpt, FatherName, FatherMobile, MotherName, MotherMobile, FamilyVal,
                            StayVal, StayOpt1, StayOpt2, EducatedVal, EducatedOpt, StudyVal, StudyOpt, OccupationVal, OccupationOpt, InterestVal, InterestOpt, LMU) Then
                MessageBox.Show("เพิ่มข้อมูลเยาวชนเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลเยาวชนได้ครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Else
            'Update youth
            Dim Youth = New Youth(_Constr)
            If Youth.Update(_PersonID, firstname, lastname, idcard, DateofBirth, SexVal, race, Nationality, ReligionID, ShirtSize, ShoeSize,
                            RAHno, RAMoo, RASoi, RARoad, RATumbon, RAAumphor, RAProvince, RAZipcode, RAPhone,
                            CAHno, CAMoo, CASoi, CARoad, CATumbon, CAAumphor, CAProvince, CAZipcode, CAPhone, Mobile,
                            MarriageVal, MarriageOpt, FatherName, FatherMobile, MotherName, MotherMobile, FamilyVal,
                            StayVal, StayOpt1, StayOpt2, EducatedVal, EducatedOpt, StudyVal, StudyOpt, OccupationVal, OccupationOpt, InterestVal, InterestOpt, LMU) Then
                MessageBox.Show("แก้ไขข้อมูลเยาวชนเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลเยาวชนได้ครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        Reset()
    End Sub

    Private Sub btSearchYouth_Click(sender As Object, e As EventArgs) Handles btSearchYouth.Click
        Using frm = New SearchPerson()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                _PersonID = frm.YouthID
                isSeacrh = True

                Dim _Youth = New Youth(_Constr)
                _Youth.GetYouth(_PersonID)
                GetInfo(_Youth)
                'MessageBox.Show(_CaseID.ToString)
                'GetDetail(_CaseID)
                ListCaseByPersonID(_PersonID)
            End If
        End Using
    End Sub
#End Region

#End Region

#Region "CaseTab"

#Region "Button"
    Private Sub btRemoveCase_Click(sender As Object, e As EventArgs) Handles btRemoveCase.Click
        'Get Row Index
        'Remove row selected
        'Re-Index No
        If _PersonID = -1 Then
            MessageBox.Show("กรุณาค้นหาเยาวชนก่อนครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tabCtrl.SelectedTab = tabPersonalInfo
            Exit Sub
        End If

        Dim index = dgvCaseList.CurrentCell.RowIndex
        Dim _CaseID = CInt(dgvCaseList.Rows(index).Cells("ID").Value)
        Dim _Youth = New Youth(_Constr)

        If _Youth.RemoveCases(_PersonID, _CaseID) Then
            ListCaseByPersonID(_PersonID)
        End If

    End Sub

    Private Sub btCaseSave_Click(sender As Object, e As EventArgs) Handles btCaseSave.Click
        'Show Dialog confirm "Yes"
        If _PersonID = -1 Then
            MessageBox.Show("กรุณาค้นหาเยาวชนก่อนครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tabCtrl.SelectedTab = tabPersonalInfo

            Exit Sub
        End If

        Using frm = New SearchCase()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                _CaseID = frm.CaseID
                GetCaseInfo(_CaseID)
            End If
        End Using

        Dim _youth = New Youth(_Constr)
        _youth.InsertCase(_PersonID, _CaseID)
    End Sub

#End Region

#Region "Function"
    Private Sub GetCaseInfo(ByVal CaseID As Integer)
        Dim _Case = New ntbjc.Lawsuit(_Constr)
        Dim ds = New DataSet
        ds = _Case.GetDetailByID(_CaseID)

        If Not ds Is Nothing Then
            Dim ci = CultureInfo.CreateSpecificCulture("th-TH")
            Dim CaseNo = ds.Tables(0).Rows(0)("CaseNo").ToString
            Dim Title = ds.Tables(0).Rows(0)("Title").ToString
            Dim BlackNo = ds.Tables(0).Rows(0)("BlackNo").ToString
            Dim RedNo = ds.Tables(0).Rows(0)("RedNo").ToString
            Dim LawsuitDate = CDate(ds.Tables(0).Rows(0)("LawsuitDate")).ToString("dd MMMM yyyy", ci)
            Dim AdviceDate = CDate(ds.Tables(0).Rows(0)("AdviceDate")).ToString("dd MMMM yyyy", ci)
            Dim InspectDate = CDate(ds.Tables(0).Rows(0)("InspectDate")).ToString("dd MMMM yyyy", ci)
            Dim PlanDate = CDate(ds.Tables(0).Rows(0)("PlanDate")).ToString("dd MMMM yyyy", ci)
            Dim ExPlanDate = CDate(ds.Tables(0).Rows(0)("ExPlanDate")).ToString("dd MMMM yyyy", ci)
            Dim ExDate = CDate(ds.Tables(0).Rows(0)("ExDate")).ToString("dd MMMM yyyy", ci)

            dgvCaseList.Rows.Add(_CaseID, dgvCaseList.Rows.Count + 1, CaseNo, Title, BlackNo, RedNo, LawsuitDate, AdviceDate, InspectDate, PlanDate, ExPlanDate, ExDate)
        End If
    End Sub

    Private Sub ListCaseByPersonID(ByVal PersonID As Integer)
        Dim _Youth = New ntbjc.Youth(_Constr)
        Dim ds = New DataSet
        ds = _Youth.ListCase(PersonID)
        If Not ds Is Nothing Then
            dgvCaseList.Rows.Clear()
            For Each row As DataRow In ds.Tables(0).Rows
                Dim ci = CultureInfo.CreateSpecificCulture("th-TH")
                Dim CaseID = row("ID").ToString
                Dim CaseNo = row("CaseNo").ToString
                Dim Title = row("Title").ToString
                Dim BlackNo = row("BlackNo").ToString
                Dim RedNo = row("RedNo").ToString
                Dim LawsuitDate = CDate(row("LawsuitDate")).ToString("dd MMMM yyyy", ci)
                Dim AdviceDate = CDate(row("AdviceDate")).ToString("dd MMMM yyyy", ci)
                Dim InspectDate = CDate(row("InspectDate")).ToString("dd MMMM yyyy", ci)
                Dim PlanDate = CDate(row("PlanDate")).ToString("dd MMMM yyyy", ci)
                Dim ExPlanDate = CDate(row("ExPlanDate")).ToString("dd MMMM yyyy", ci)
                Dim ExDate = CDate(row("ExDate")).ToString("dd MMMM yyyy", ci)

                dgvCaseList.Rows.Add(CaseID, dgvCaseList.Rows.Count + 1, CaseNo, Title, BlackNo, RedNo, LawsuitDate, AdviceDate, InspectDate, PlanDate, ExPlanDate, ExDate)
            Next
        End If

    End Sub

    Private Sub CaseReset()
        dgvCaseList.Rows.Clear()
    End Sub
#End Region

#End Region

    Public Sub New()
        InitializeComponent()
        Me._UserID = GlobalVar.UserID
        'Me._UserID = 1
        Me._Constr = ConnectionStrings("Connection").ToString
        'Me.WindowState = FormWindowState.Maximized

        LoadReligion()
    End Sub

    Private Sub ReleasedObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occurred while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Word Documents (*.doc)|*.doc"
        sfd.FileName = "Youth.doc"

        If sfd.ShowDialog = DialogResult.OK Then
            'Preparing Data
            If _PersonID = -1 Then
                MessageBox.Show("กรุณาค้นหาเด็กก่อนครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btSearchYouth.Focus()
                Exit Sub
            End If

            Dim _youth As New Youth(_Constr)
            _youth.GetYouth(_PersonID)
            Dim ci = CultureInfo.CreateSpecificCulture("th-TH")

            'Preparing word document
            Dim oMissing = System.Reflection.Missing.Value
            Dim oEndofDoc = "\\endofdoc"
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oWord.Visible = True
            oDoc = oWord.Documents.Add(oMissing, oMissing, oMissing, oMissing)

            'Insert Paragraph Youth Name
            Dim oPara1 As Word.Paragraph
            oPara1 = oDoc.Content.Paragraphs.Add(oMissing)
            Dim fn = _youth.Firstname
            Dim ln = _youth.Lastname
            Dim idcard = _youth.IDCard
            Dim idc = String.Format("{0}-{1}-{2}-{3}-{4}", idcard.Substring(0, 1), idcard.Substring(1, 4), idcard.Substring(5, 5), idcard.Substring(10, 2), idcard.Substring(12, 1))
            'Dim dob = _youth.DateofBirth

            Dim dob = CDate(_youth.DateofBirth).ToString("dd MMMM yyyy", ci)
            Dim sex = IIf(_youth.Sex = 1, "ชาย", "หญิง")
            Dim _mobile = _youth.Mobile
            Dim mobile = IIf(_mobile = "", "-", String.Format("{0}-{1}-{2}", _mobile.Substring(0, 3), _mobile.Substring(3, 3), _mobile.Substring(5, 4)))
            Dim nationality = IIf(_youth.Nationality = "", "-", _youth.Nationality)
            Dim racism = IIf(_youth.Race = "", "-", _youth.Race)
            Dim r = ""
            Select Case _youth.ReligionID
                Case 1
                    r = "พุทธ"
                Case 2
                    r = "คริสต์"
                Case 3
                    r = "อิสลาม"
            End Select

            Dim shirt_size = IIf(_youth.ShirtSize = "", "-", _youth.ShirtSize)
            Dim shoe_size = IIf(_youth.ShoeSize = "", "-", _youth.ShoeSize)
            Dim RA_hno = IIf(_youth.RAHno = "", "-", _youth.RAHno)
            Dim RA_moo = IIf(_youth.RAMoo = "", "-", _youth.RAMoo)
            Dim RA_soi = IIf(_youth.RASoi = "", "-", _youth.RASoi)
            Dim RA_road = IIf(_youth.RARoad = "", "-", _youth.RARoad)
            Dim RA_tumbon = IIf(_youth.RATumbon = "", "-", _youth.RATumbon)
            Dim RA_aumphor = IIf(_youth.RAAumphor = "", "-", _youth.RAAumphor)
            Dim RA_province = IIf(_youth.RAProvince = "", "-", _youth.RAProvince)
            Dim RA_zipcode = IIf(_youth.RAZipcode = "", "-", _youth.RAZipcode)
            Dim RA_phone = IIf(_youth.RAPhone = "", "-", _youth.RAPhone)
            Dim CA_hno = IIf(_youth.CAHno = "", "-", _youth.CAHno)
            Dim CA_moo = IIf(_youth.CAMoo = "", "-", _youth.CAMoo)
            Dim CA_soi = IIf(_youth.CASoi = "", "-", _youth.CASoi)
            Dim CA_road = IIf(_youth.CARoad = "", "-", _youth.CARoad)
            Dim CA_tumbon = IIf(_youth.CATumbon = "", "-", _youth.CATumbon)
            Dim CA_aumphor = IIf(_youth.CAAumphor = "", "-", _youth.CAAumphor)
            Dim CA_province = IIf(_youth.CAProvince = "", "-", _youth.CAProvince)
            Dim CA_zipcode = IIf(_youth.CAZipcode = "", "-", _youth.CAZipcode)
            Dim CA_phone = IIf(_youth.CAPhone = "", "-", _youth.CAPhone)
            Dim InfoSection = String.Format("ชื่อ-นามสกุล {1} {2} เลขบัตรประชาชน {3} วัน-เดือน-ปีเกิด {4} เพศ {5}{0}เบอร์มือถือ {6} เชื้อชาติ {7} สัญชาติ {8} ศาสนา {9} ขนาดเสื้อ {10} ขนาดรองเท้า {11}" &
                                            "{0}ที่อยู่ตามบัตรประชาชน" &
                                            "{0}บ้านเลขที่ {12} หมู่ที่ {13} ซอย {14} ถนน {15} แขวง/ตำบล {16}" &
                                            "{0}อำเภอ/เขต {17} จังหวัด {18} รหัสไปรษณีย์ {19} เบอร์โทรศัพท์ที่บ้าน {20}" &
                                            "{0}ที่อยู่ปัจจุบัน" &
                                            "{0}บ้านเลขที่ {21} หมู่ที่ {22} ซอย {23} ถนน {24} แขวง/ตำบล {25}" &
                                            "{0}อำเภอ/เขต {26} จังหวัด {27} รหัสไปรษณีย์ {28} เบอร์โทรศัพท์ที่บ้าน {29}", vbCrLf, fn, ln, idc, dob, sex, mobile, racism, nationality, r, shirt_size, shoe_size, RA_hno, RA_moo, RA_soi, RA_road, RA_tumbon, RA_aumphor, RA_province, RA_zipcode, RA_phone, CA_hno, CA_moo, CA_soi, CA_road, CA_tumbon, CA_aumphor, CA_province, CA_zipcode, CA_phone)



            oPara1.Range.Text = InfoSection
            oPara1.Range.InsertParagraphAfter()

            Me.Close()

            ReleasedObject(oDoc)
            ReleasedObject(oWord)

            If File.Exists(sfd.FileName) Then
                System.Diagnostics.Process.Start(sfd.FileName)
            End If
        End If
    End Sub
End Class