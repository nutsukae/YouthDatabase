Imports System.Data.SqlClient

Public Class Tort
    Private _Constr As String

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Function GetName(ByVal TortID As Integer) As String
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Tort_GetName"
            command.Parameters.Add("@TortID", SqlDbType.Int).Value = TortID

            Return command.ExecuteScalar().ToString
        Catch ex As Exception
            Return Nothing
        Finally
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function GetTortLv1() As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Tort_GetLevel1"

            Dim ds As New DataSet

            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function GetTortChild(ByVal ParentId As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_tort_GetChild"
            command.Parameters.Add("@parentID", SqlDbType.Int).Value = ParentId

            Dim ds As New DataSet

            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function


End Class
