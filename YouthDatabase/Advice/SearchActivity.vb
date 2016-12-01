Imports System.Configuration.ConfigurationManager
Imports System.Globalization
Imports ntbjc
Public Class SearchActivity
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _ActId As Integer
    Property ActivityId As Integer
        Get
            Return _ActId
        End Get
        Set(value As Integer)
            _ActId = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim _Act = New Activity(_Constr)
        Dim ds = _Act.List()

        If Not ds Is Nothing Then
            For Each row As DataRow In ds.Tables(0).Rows
                Dim ci = CultureInfo.CreateSpecificCulture("th-TH")
                Dim id = CInt(row("id").ToString)
                Dim act_name = row("act_name").ToString
                Dim dept_name = row("dept_name").ToString
                Dim location = row("location").ToString
                Dim actdate = CDate(row("actdate").ToString)

                dgvActList.Rows.Add(id, dgvActList.Rows.Count + 1, act_name, dept_name, location, actdate.ToString("dd MMMM yyyy", ci))
            Next
        Else
            MessageBox.Show("ไม่พบกิจกรรมครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvActList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActList.CellDoubleClick
        _ActId = CInt(dgvActList.Rows(e.RowIndex).Cells("ID").Value)
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class