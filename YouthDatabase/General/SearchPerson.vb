Imports ntbjc
Imports System.Configuration.ConfigurationManager

Public Class SearchPerson
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _YouthID As Integer

    Property YouthID As Integer
        Get
            YouthID = _YouthID
        End Get
        Set(value As Integer)
            _YouthID = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
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
        'MessageBox.Show(dgvCase.Rows(e.RowIndex).Cells("ID").Value.ToString)
        _YouthID = CInt(dgvYouth.Rows(e.RowIndex).Cells("ID").Value)
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class