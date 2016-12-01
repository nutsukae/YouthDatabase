Imports ntbjc
Imports System.Configuration.ConfigurationManager
Public Class pb_search_youth
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _YouthID As Integer
    Private _CaseID As Integer

    Property YouthID As Integer
        Get
            YouthID = _YouthID
        End Get
        Set(value As Integer)
            _YouthID = value
        End Set
    End Property

    Property CaseID As Integer
        Get
            CaseID = _CaseID
        End Get
        Set(value As Integer)
            _CaseID = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Search()
    End Sub

    Private Sub Search()
        dgvYouth.Rows.Clear()

        Dim firstname = tbFirstname.Text
        Dim lastname = tbLastname.Text
        Dim idcard = tbIdcard.Text
        Dim CaseNo = tbCaseNo.Text
        Dim BlackNo = tbBlackNo.Text

        Dim CaseTypeID As Integer = 0
        Dim result = cbCaseType.SelectedValue
        Dim _row As DataRowView = DirectCast(cbCaseType.SelectedItem, DataRowView)
        If _row IsNot Nothing Then
            CaseTypeID = CInt(_row(0).ToString)
        End If

        Dim _youth = New Youth(_Constr)
        Dim ds = New DataSet

        ds = _youth.ListCaseForProbation(firstname, lastname, idcard, CaseNo, BlackNo, CaseTypeID)

        If Not ds Is Nothing Then
            For Each row As DataRow In ds.Tables(0).Rows
                Dim id = CInt(row("youth_id"))
                Dim fullname = row("fullname").ToString
                Dim _idcard = row("idcard").ToString
                Dim case_id = CInt(row("case_id"))
                Dim _caseno = row("caseno").ToString
                Dim _blackno = row("blackno").ToString
                Dim _casename = row("name").ToString
                dgvYouth.Rows.Add(id, dgvYouth.Rows.Count + 1, fullname, _idcard, case_id, _caseno, _blackno, _casename)
            Next
        End If
    End Sub

    Private Sub pb_search_youth_Load(sender As Object, e As EventArgs) Handles Me.Load
        Search()
    End Sub

    Private Sub dgvYouth_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYouth.CellDoubleClick
        _CaseID = CInt(dgvYouth.Rows(e.RowIndex).Cells("case_id").Value)
        _YouthID = CInt(dgvYouth.Rows(e.RowIndex).Cells("id").Value)
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class