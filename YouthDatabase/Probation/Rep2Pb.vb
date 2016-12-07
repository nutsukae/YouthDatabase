Imports ntbjc
Imports System.Configuration.ConfigurationManager
Imports System.Globalization
Public Class Rep2Pb
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

    Private Sub Rep2Pb_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMainAssociateJudge()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Using frm = New pb_search_youth()
            Dim result = frm.ShowDialog()

            If result = DialogResult.OK Then
                _YouthID = frm.YouthID
                _CaseID = frm.CaseID

                'Get Probation ID and Information
                Dim Prob As New Probation(_Constr)
                _ProbationID = Prob.GetID(_YouthID, _CaseID)

                Dim R2P As New R2P(_Constr)
                Dim ds As New DataSet
                ds = R2P.ListByProbationID(_ProbationID)

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each row In ds.Tables(0).Rows
                        Dim ci = CultureInfo.CreateSpecificCulture("th-TH")
                        Dim id = row("id").ToString
                        Dim EstDate = CDate(row("EstDate")).ToString("dd MMMM yyyy", ci)
                        Dim ActDate = CDate(row("ActDate")).ToString("dd MMMM yyyy", ci)
                        dgvReport.Rows.Add(id, dgvReport.Rows.Count + 1, EstDate, ActDate)
                    Next
                End If

            End If
        End Using
    End Sub

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
#End Region

    Private Sub dgvReport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellDoubleClick
        Try
            Dim R2PID = CInt(dgvReport.Rows(e.RowIndex).Cells("id").Value)
            Dim ci = CultureInfo.CreateSpecificCulture("th-TH")

            Dim _R2P As New R2P(_Constr)
            _R2P.GetDetailByID(R2PID)

            tbEstDate.Text = CDate(_R2P.EstDate).ToString("dd MMMM yyyy", ci)
            dtpActDate.Text = _R2P.ActDate
            cbMainAssociateJudge.SelectedValue = _R2P.AssociateJudgeID
            tbRemark.Text = _R2P.Remark
            cbISUA.Checked = CBool(_R2P.IsUreaAnalysis)
        Catch ex As Exception

        End Try

    End Sub


End Class