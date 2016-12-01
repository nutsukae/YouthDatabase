Imports ntbjc
Imports System.Configuration.ConfigurationManager

Public Class actper_search_youth
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

    Private Sub actper_search_youth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Search()
    End Sub

    Private Sub Search()
        'Clear Datagriview
        dgvYouth.Rows.Clear()

        Dim firstname = tbFirstname.Text
        Dim lastname = tbLastname.Text
        Dim idcard = tbIdcard.Text

        Dim _youth = New Youth(_Constr)
        Dim ds = New DataSet

        ds = _youth.SearchYouth(firstname, lastname, idcard)

        If Not ds Is Nothing Then
            For Each row As DataRow In ds.Tables(0).Rows
                Dim id = CInt(row("id"))
                Dim fullname = row("fullname").ToString
                Dim _idcard = row("idcard").ToString
                dgvYouth.Rows.Add(id, dgvYouth.Rows.Count + 1, fullname, _idcard)
            Next
        End If
    End Sub

    Private Sub dgvYouth_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYouth.CellDoubleClick
        _YouthID = CInt(dgvYouth.Rows(e.RowIndex).Cells("ID").Value)

        dgvCase.Rows.Clear()

        Dim _youth = New Youth(_Constr)
        Dim ds = New DataSet

        ds = _youth.ListCase(_YouthID)

        If Not ds Is Nothing Then
            For Each row As DataRow In ds.Tables(0).Rows
                Dim id = CInt(row("id"))
                Dim caseno = row("caseno").ToString
                Dim blackno = row("blackno").ToString
                dgvCase.Rows.Add(id, dgvCase.Rows.Count + 1, caseno, blackno)
            Next
        End If

    End Sub

    Private Sub dgvCase_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCase.CellContentClick
        _CaseID = CInt(dgvCase.Rows(e.RowIndex).Cells("c_id").Value)
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click

    End Sub
End Class