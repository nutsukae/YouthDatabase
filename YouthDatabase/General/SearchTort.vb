
Imports System.Configuration.ConfigurationManager

Public Class Tort
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _TortID As Integer
    Property TortID As Integer
        Get
            Return _TortID
        End Get
        Set(value As Integer)
            _TortID = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Tort_Load(sender As Object, e As EventArgs) Handles Me.Load
        getComboboxlv1()
    End Sub
    Private Sub cbTortLv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTortLv1.SelectedIndexChanged
        Dim result = cbTortLv1.SelectedValue

        Dim row As DataRowView = DirectCast(cbTortLv1.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            getComboboxLV2(CInt(row(0).ToString))
        End If

    End Sub
    Private Sub cbTortLv2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTortLv2.SelectedIndexChanged
        Dim result = cbTortLv2.SelectedValue

        Dim row As DataRowView = DirectCast(cbTortLv2.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            getComboboxLV3(CInt(row(0).ToString))
        End If
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        Dim result = cbTortLv3.SelectedValue
        Dim row As DataRowView = DirectCast(cbTortLv3.SelectedItem, DataRowView)
        If row IsNot Nothing Then
            Me._TortID = CInt(row(0).ToString)
        Else
            Dim result2 = cbTortLv2.SelectedValue
            Dim row2 As DataRowView = DirectCast(cbTortLv2.SelectedItem, DataRowView)
            If row2 IsNot Nothing Then
                Me._TortID = CInt(row2(0).ToString)
            Else
                Dim result3 = cbTortLv1.SelectedValue
                Dim row3 As DataRowView = DirectCast(cbTortLv1.SelectedItem, DataRowView)
                If row3 IsNot Nothing Then
                    Me._TortID = CInt(row3(0).ToString)
                Else
                    Me._TortID = -1
                End If
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

#Region "Function"
    Private Sub getComboboxlv1()
        Dim mytort As New ntbjc.Tort(_Constr)
        Dim ds As New DataSet
        ds = mytort.GetTortLv1()

        If ds.Tables(0).Rows.Count > 0 Then
            cbTortLv1.DataSource = ds.Tables(0)
            cbTortLv1.DisplayMember = "name"
            cbTortLv1.ValueMember = "id"
        Else
            Exit Sub
        End If
    End Sub
    Private Sub getComboboxLV2(ByVal ParentID As Integer)
        Dim mytort As New ntbjc.Tort(_Constr)
        Dim ds As New DataSet
        ds = mytort.GetTortChild(ParentID)

        If ds.Tables(0).Rows.Count > 0 Then
            cbTortLv2.DataSource = ds.Tables(0)
            cbTortLv2.DisplayMember = "name"
            cbTortLv2.ValueMember = "id"
        Else
            cbTortLv2.DataSource = Nothing
            Exit Sub
        End If
    End Sub
    Private Sub getComboboxLV3(ByVal ParentID As Integer)
        Dim mytort As New ntbjc.Tort(_Constr)
        Dim ds As New DataSet
        ds = mytort.GetTortChild(ParentID)

        If ds.Tables(0).Rows.Count > 0 Then
            cbTortLv3.DataSource = ds.Tables(0)
            cbTortLv3.DisplayMember = "name"
            cbTortLv3.ValueMember = "id"
        Else
            cbTortLv3.DataSource = Nothing
            Exit Sub
        End If
    End Sub
#End Region




End Class