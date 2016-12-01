Imports ntbjc
Imports System.Configuration.ConfigurationManager
Public Class Treatment_Info
    Private _UserID As Integer
    Private _Constr As String
    Private _ActId As Integer = -1
    Private _YouthID As Integer
    Private _CaseID As Integer
    Private _UserTypeID As Integer

    Public Sub New()
        InitializeComponent()
        Me._UserID = GlobalVar.UserID
        Me._UserTypeID = GlobalVar.UserTypeId
        'Me._UserID = 1
        Me._Constr = ConnectionStrings("Connection").ToString
    End Sub
    Private Sub Treatment_Info_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindDepartment()
        BindActType()

        btSubmit.Enabled = False
    End Sub
#Region "button"
    Private Sub btAddYouth_Click(sender As Object, e As EventArgs) Handles btAddYouth.Click
        Using frm = New actper_search_youth()
            Dim result = frm.ShowDialog()

            If result = DialogResult.OK Then
                _YouthID = frm.YouthID
                _CaseID = frm.CaseID

                Dim _Youth = New Youth(_Constr)
                _Youth.GetYouth(_YouthID)

                tbFullname.Text = String.Format("{0} {1}", _Youth.Firstname, _Youth.Lastname)

                btSubmit.Enabled = True
            End If
        End Using
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        If DialogResult.Cancel = MessageBox.Show("กรุณาตรวจสอบความถูกต้องของข้อมูลก่อนบันทึกครับ", "ยีนยันบันทึกข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Exit Sub
        End If

        Dim ActName As String = tbName.Text
        Dim Location As String = tbLocation.Text

        Dim DeptId = 0
        Dim result = cbDepartment.SelectedValue
        Dim row As DataRowView = DirectCast(cbDepartment.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            DeptId = CInt(row(0).ToString)
        End If

        Dim ActTypeId = 0
        result = cbActType.SelectedValue
        row = DirectCast(cbDepartment.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            ActTypeId = CInt(row(0).ToString)
        End If

        Dim ActDate As Date = CDate(dtpActDate.Text)

        Dim _Act = New Activity(_Constr)
        If _ActId = -1 Then
            'Insert with return Act ID 
            'After that insert act_person
            Dim ActID As Integer = _Act.Insert2(Name, ActTypeId, Location, DeptId, ActDate, _UserID)

            If ActID <> -1 Then
                If _Act.AddYouth(ActID, _YouthID, _CaseID, _UserTypeID, 0, _UserID) Then
                    MessageBox.Show("เพิ่มข้อมูลกิจกรรมเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Reset()
                    Exit Sub
                Else
                    MessageBox.Show("ไม่สามารถผูกเยาวชนกับกิจกรรมได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("ไม่สามารถเพิ่มกิจกรรมได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If _Act.Update(_ActId, ActTypeId, Name, Location, DeptId, ActDate, _UserID) Then
                MessageBox.Show("แก้ไขกิจกรรมเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถแก้ไขกิจกรรมได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        Reset()
    End Sub

    Private Sub btSearchActivity_Click(sender As Object, e As EventArgs) Handles btSearchActivity.Click
        Using frm = New SearchActivity()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                _ActId = frm.ActivityId
                'MessageBox.Show(_ActId.ToString)

                Dim _act = New Activity(_Constr)
                Dim dsInfo = New DataSet
                dsInfo = _act.GetInfoById2(_ActId)

                If Not dsInfo Is Nothing Then
                    'DisabledButton(False)

                    Dim acttypeid As Integer

                    acttypeid = CInt(dsInfo.Tables(0).Rows(0)("activitytypeid").ToString)

                    If acttypeid = 1 Then
                        MessageBox.Show("กิจกรรมดังกล่าวไม่ใช่กิจกรรมส่งต่อครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    cbActType.SelectedValue = acttypeid
                    tbName.Text = dsInfo.Tables(0).Rows(0)("name").ToString
                    tbLocation.Text = dsInfo.Tables(0).Rows(0)("location").ToString
                    dtpActDate.Text = dsInfo.Tables(0).Rows(0)("actdate").ToString
                    cbDepartment.SelectedValue = CInt(dsInfo.Tables(0).Rows(0)("deptid").ToString)
                    tbFullname.Text = dsInfo.Tables(0).Rows(0)("fullname").ToString
                End If
            End If
        End Using
    End Sub
#End Region

#Region "Function"
    Private Sub BindDepartment()
        Dim _dept = New Dept(_Constr)
        Dim ds = New DataSet()
        ds = _dept.List()

        If Not ds Is Nothing Then
            ds.Tables(0).Rows(0).Delete()
            ds.Tables(0).Rows(1).Delete()
            ds.Tables(0).Rows(2).Delete()
            cbDepartment.DataSource = ds.Tables(0)
            cbDepartment.DisplayMember = "name"
            cbDepartment.ValueMember = "ID"
        End If
    End Sub

    Private Sub BindActType()
        Dim _act = New Activity(_Constr)
        Dim ds = New DataSet()
        ds = _act.GetActivityType

        If Not ds Is Nothing Then
            ds.Tables(0).Rows(0).Delete()
            cbActType.DataSource = ds.Tables(0)
            cbActType.DisplayMember = "name"
            cbActType.ValueMember = "ID"
        End If
    End Sub

    Private Sub Reset()
        tbFullname.Text = ""
        tbName.Text = ""
        tbLocation.Text = ""
        dtpActDate.Text = Now
        btSubmit.Enabled = False
        btAddYouth.Enabled = True
    End Sub
#End Region

End Class