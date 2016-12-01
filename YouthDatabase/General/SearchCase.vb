Imports System.Configuration.ConfigurationManager
Imports ntbjc
Public Class SearchCase
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _CaseID As Integer
    Property CaseID As Integer
        Get
            Return _CaseID
        End Get
        Set(value As Integer)
            _CaseID = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim CaseTypeID As Integer = 0
        If rbArrest.Checked Then
            CaseTypeID = CaseType.Status.Arrest
        ElseIf rbSurrender.Checked Then
            CaseTypeID = CaseType.Status.Surrender
        ElseIf rbTransfer.Checked Then
            CaseTypeID = CaseType.Status.Transfer
        ElseIf rbCriminal.Checked Then
            CaseTypeID = CaseType.Status.Criminal
        ElseIf rb5.Checked Then
            CaseTypeID = 5
        End If

        Dim CaseNo = tbCaseNo.Text

        Dim ds = New DataSet
        Dim dt = New DataTable
        Dim _Case = New ntbjc.Lawsuit(_Constr)
        ds = _Case.Search(CaseTypeID, CaseNo)
        'dgvCase.DataSource = ds.Tables(0)

        If Not ds Is Nothing Then
            dgvCase.AutoGenerateColumns = False
            dt.Columns.Add("ID")
            dt.Columns.Add("no")
            dt.Columns.Add("CaseNo")
            dt.Columns.Add("LawsuitDate")
            dt.Columns.Add("AdviceDate")
            dt.Columns.Add("InspectDate")
            dt.Columns.Add("PlanDate")
            dt.Columns.Add("ExPlanDate")
            dt.Columns.Add("ExDate")

            For Each row As DataRow In ds.Tables(0).Rows
                Dim dr = dt.NewRow()
                dr(0) = row("id").ToString
                dr(1) = row("no").ToString
                dr(2) = row("caseno").ToString
                dr(3) = row("LawsuitDate").ToString
                dr(4) = row("AdviceDate").ToString
                dr(5) = row("InspectDate").ToString
                dr(6) = row("PlanDate").ToString
                dr(7) = row("ExPlanDate").ToString
                dr(8) = row("ExDate").ToString
                dt.Rows.Add(dr)
            Next

            dgvCase.DataSource = dt
        End If


    End Sub

    Private Sub dgvCase_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCase.CellDoubleClick
        'MessageBox.Show(dgvCase.Rows(e.RowIndex).Cells("ID").Value.ToString)
        CaseID = CInt(dgvCase.Rows(e.RowIndex).Cells("ID").Value)
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class