﻿Imports System.Data.SqlClient
Public Class AssociateJudge
    Private _Constr As String

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Function List() As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AssociateJudge_List"

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
