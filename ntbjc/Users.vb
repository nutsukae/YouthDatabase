Imports System.Data.SqlClient

Public Class Users
    Private _Username As String
    Private _Password As String
    Private _Constr As String
    Public ID As Integer
    Public Type As Integer

    Public Sub New(ByVal Username As String, ByVal Password As String, ByVal ConnectionString As String)
        Me._Username = Username
        Me._Password = Password
        Me._Constr = ConnectionString

        CheckUserLogin()
    End Sub

    Private Sub CheckUserLogin()
        Dim Connection As SqlConnection = New SqlConnection(_Constr)
        Dim Command As SqlCommand = New SqlCommand()
        Dim Reader As SqlDataReader

        If Connection.State = ConnectionState.Open Then Connection.Close()
        Connection.Open()

        Try
            Command.Connection = Connection
            Command.CommandType = CommandType.StoredProcedure
            Command.CommandText = "sp_User_Chklogin"
            Command.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = _Username
            Command.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = _Password

            Reader = Command.ExecuteReader

            If Reader.HasRows Then
                Reader.Read()
                ID = CInt(Reader("id"))
                Type = CInt(Reader("usertype"))
            Else
                ID = -1
                Type = -1
            End If

        Catch ex As Exception

        Finally
            Connection.Close()
            Reader = Nothing
            Command = Nothing
            Connection = Nothing
        End Try


    End Sub
End Class
