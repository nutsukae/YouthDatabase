Imports System.Data.SqlClient

Public Class R2P
    Private _Constr As String

    Public ID As Integer = 0
    'Public ProbationID As Integer = 0
    Public EstDate As Date = Now
    Public ActDate As Date = Now
    Public AssociateJudgeID As Integer = 0
    Public Remark As String = ""
    Public IsUreaAnalysis As Integer = 0

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Sub GetDetailByID(ByVal ID As Integer)
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()
        Dim reader As SqlDataReader

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_R2P_GetDetailByID"
            command.Parameters.Add("@R2PID", SqlDbType.Int).Value = ID

            reader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    ID = CInt(reader("id"))
                    EstDate = reader("EstDate").ToString
                    ActDate = reader("ActDate").ToString
                    AssociateJudgeID = CInt(reader("AstJudgeID"))
                    Remark = reader("Remark").ToString
                    IsUreaAnalysis = CInt(reader("ISUA"))
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            reader = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Sub

    Public Function Insert(ByVal ProbationID As Integer, ByVal EstimateDate As String, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_R2P_Insert"
            command.Parameters.Add("@ProbationID", SqlDbType.Int).Value = ProbationID
            command.Parameters.Add("@EstDate", SqlDbType.Int).Value = EstimateDate
            command.Parameters.Add("@lmu", SqlDbType.Int).Value = LMU

            Return CBool(command.ExecuteNonQuery())
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function Update(ByVal ID As Integer, ByVal ActualDate As String, ByVal AssociateJudgeID As Integer, ByVal Remark As String, ByVal IsUreaAnalysis As Integer, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_R2P_Update"
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            command.Parameters.Add("@ActDate", SqlDbType.Date).Value = CDate(ActualDate)
            command.Parameters.Add("@AstJudgeID", SqlDbType.Int).Value = AssociateJudgeID
            command.Parameters.Add("@Remark", SqlDbType.NVarChar, 4000).Value = Remark
            command.Parameters.Add("@isua", SqlDbType.Int).Value = IsUreaAnalysis
            command.Parameters.Add("@lmu", SqlDbType.Int).Value = LMU

            Return CBool(command.ExecuteNonQuery())
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function ListByProbationID(ByVal ProbationID As Integer)
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_R2P_ListByProbationID"
            command.Parameters.Add("@ProbationID", SqlDbType.Int).Value = ProbationID

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
