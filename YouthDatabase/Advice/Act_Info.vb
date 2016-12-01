Imports ntbjc
Imports System.Configuration.ConfigurationManager

Public Class Act_Info
    Private _UserID As Integer
    Private _UserTypeId As Integer
    Private _Constr As String
    Private _ActId As Integer = -1
    Private _YouthID As Integer
    Private _CaseID As Integer

    Public Sub New()
        InitializeComponent()
        Me._UserID = GlobalVar.UserID
        Me._UserTypeId = GlobalVar.UserTypeId
        'Me._UserID = 1
        Me._Constr = ConnectionStrings("Connection").ToString

    End Sub

    Private Sub Act_Info_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindDepartment()
        DisabledButton(True)
    End Sub

#Region "Function"
    Private Sub ListActivityPersonDetail(ByVal ActivityID As Integer)
        Dim _Act = New Activity(_Constr)
        Dim ds = New DataSet

        ds = _Act.ListYouth(_ActId, _UserTypeId)

        If Not ds Is Nothing Then
            dgvYouthList.Rows.Clear()

            For Each row As DataRow In ds.Tables(0).Rows
                Dim ap_id = CInt(row("id"))
                Dim idcard = row("idcard").ToString
                Dim fullname = row("fullname").ToString
                'Dim caseno = row("caseno").ToString 
                Dim blackno = row("blackno").ToString
                Dim title = row("title").ToString
                Dim mobile = row("mobile").ToString
                Dim address = row("address").ToString
                Dim sex = row("sex").ToString
                Dim religion = row("religion").ToString
                Dim shirt_size = row("shirt_size").ToString
                Dim shoe_size = row("shoe_size").ToString
                Dim status = CInt(row("status"))
                dgvYouthList.Rows.Add(ap_id, dgvYouthList.Rows.Count + 1, idcard, fullname, blackno, title, mobile, address, sex, religion, shirt_size, shoe_size, status)
            Next

        End If

    End Sub

    Private Sub BindDepartment()
        Dim _dept = New Dept(_Constr)
        Dim ds = New DataSet()
        ds = _dept.List()

        If Not ds Is Nothing Then
            cbDepartment.DataSource = ds.Tables(0)
            cbDepartment.DisplayMember = "name"
            cbDepartment.ValueMember = "ID"
        End If
    End Sub

    Private Sub DisabledButton(ByVal flag As Boolean)
        If flag Then
            btAddYouth.Enabled = False
            btUpdateAll.Enabled = False
            btRemoveYouth.Enabled = False
        Else
            btAddYouth.Enabled = True
            btUpdateAll.Enabled = True
            btRemoveYouth.Enabled = True
        End If
    End Sub

    Private Sub Reset()
        tbLocation.Text = ""
        tbName.Text = ""
        dtpActDate.Text = Now
        _actid = -1
    End Sub
#End Region

#Region "Button"
    Private Sub btAddYouth_Click(sender As Object, e As EventArgs) Handles btAddYouth.Click
        If _ActId = -1 Then
            MessageBox.Show("กรุณาเลือกค้นหากิจกรรมที่ต้องการเพิ่มเยาวชนก่อนครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using frm = New actper_search_youth()
            Dim result = frm.ShowDialog()

            If result = DialogResult.OK Then
                _YouthID = frm.YouthID
                _CaseID = frm.CaseID

                Dim _Act = New Activity(_Constr)

                If _Act.AddYouth(_ActId, _YouthID, _CaseID, _UserTypeId, 0, _UserID) Then
                    'MessageBox.Show("เพิ่มเยาวชนเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Exit Sub
                    ListActivityPersonDetail(_ActId)
                Else
                    MessageBox.Show("ไม่สามารถเพิ่มเยาวชนได้ครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            End If
        End Using
    End Sub

    Private Sub btRemoveYouth_Click(sender As Object, e As EventArgs) Handles btRemoveYouth.Click
        If _ActId = -1 Then
            MessageBox.Show("กรุณาเลือกค้นหากิจกรรมที่ต้องการลบเยาวชนก่อนครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DialogResult.OK = MessageBox.Show("ต้องการลบเยาวชนออกจากกิจกรรมนี้ใช่หรือไม่", "ยืนยันลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Dim index = dgvYouthList.CurrentCell.RowIndex
            Dim ActivitiPersonID = CInt(dgvYouthList.Rows(index).Cells("ID").Value)

            Dim _act = New Activity(_Constr)

            If _act.RemoveYouth(ActivitiPersonID) Then
                dgvYouthList.Rows.RemoveAt(index)

                ListActivityPersonDetail(_ActId)
            Else
                MessageBox.Show("ไม่สามารถลบเยาวชนออกจากกิจกรรมนี้ได้ครับ", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btSaveActivity_Click(sender As Object, e As EventArgs) Handles btSaveActivity.Click
        If DialogResult.Cancel = MessageBox.Show("กรุณาตรวจสอบความถูกต้องของข้อมูลก่อนบันทึกครับ", "ยีนยันบันทึกข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Exit Sub
        End If

        Dim Name = tbName.Text
        Dim Location = tbLocation.Text

        If String.IsNullOrEmpty(Name) Then
            MessageBox.Show("กรุณาใส่ชื่อกิจกรรมด้วยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbName.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Location) Then
            MessageBox.Show("กรุณาใส่สถานที่ด้วยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbLocation.Focus()
            Exit Sub
        End If

        Dim DeptId = 0

        Dim result = cbDepartment.SelectedValue
        Dim row As DataRowView = DirectCast(cbDepartment.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            DeptId = CInt(row(0).ToString)
        End If

        Dim ActDate As Date = CDate(dtpActDate.Text)

        Dim _Act = New Activity(_Constr)
        If _actid = -1 Then
            If _Act.Insert(Name, 1, Location, DeptId, ActDate, _UserID) Then
                MessageBox.Show("เพิ่มข้อมูลกิจกรรมเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถเพิ่มกิจกรรมได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If _Act.Update(_ActId, 1, Name, Location, DeptId, ActDate, _UserID) Then
                MessageBox.Show("แก้ไขกิจกรรมเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Exit Sub
            Else
                MessageBox.Show("ไม่สามารถแก้ไขกิจกรรมได้ครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Using frm = New SearchActivity()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                _ActId = frm.ActivityId
                'MessageBox.Show(_ActId.ToString)

                Dim _act = New Activity(_Constr)
                Dim dsInfo = New DataSet
                dsInfo = _act.GetInfoById(_ActId)

                If Not dsInfo Is Nothing Then
                    DisabledButton(False)

                    tbName.Text = dsInfo.Tables(0).Rows(0)("name").ToString
                    tbLocation.Text = dsInfo.Tables(0).Rows(0)("location").ToString
                    dtpActDate.Text = dsInfo.Tables(0).Rows(0)("actdate").ToString
                    cbDepartment.SelectedValue = CInt(dsInfo.Tables(0).Rows(0)("deptid").ToString)

                    ListActivityPersonDetail(_ActId)
                End If
            End If
        End Using
    End Sub

    Private Sub btUpdateAll_Click(sender As Object, e As EventArgs) Handles btUpdateAll.Click
        Dim _act = New Activity(_Constr)
        For Each row As DataGridViewRow In dgvYouthList.Rows
            Dim ActPerID = CInt(row.Cells("id").Value)
            Dim status = CInt(row.Cells("status").Value)
            _act.UpdateYouth(ActPerID, status, _UserID)
        Next

        MessageBox.Show("อัพเดทข้อมูลเรียบร้อยครับ", "แจ้งผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

End Class