Imports System.Data.SqlClient
Public Class Probation
    Private _Constr As String

    Public ID As Integer = 0
    Public YouthID As Integer = 0
    Public CaseID As Integer = 0
    Public BlackNo As String = ""
    Public RedNo As String = ""
    Public Reference As String = ""
    Public CommandText As String = ""
    Public AssociateJudgeID As Integer = 0
    Public StartDate As Date = Now
    Public EndDate As Date = Now
    Public SummaryText As String = ""
    Public IsTransfer As Integer = 0
    Public TransferDate As Date = Now

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Sub GetDetail(ByVal ProbationID As Integer)
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()
        Dim reader As SqlDataReader

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Probation_GetDetailByID"
            command.Parameters.Add("@ProbationID", SqlDbType.Int).Value = ProbationID

            reader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    ID = CInt(reader("id"))
                    YouthID = CInt(reader("person_id"))
                    CaseID = CInt(reader("case_id"))
                    BlackNo = reader("blackno").ToString
                    RedNo = reader("redno").ToString
                    Reference = reader("ProbationRef").ToString
                    CommandText = reader("ProbationCommandText").ToString
                    AssociateJudgeID = CInt(reader("AssociateJudgeID"))
                    StartDate = reader("StartProbationDate").ToString
                    EndDate = reader("EndProbationDate").ToString
                    SummaryText = reader("SummaryText").ToString
                    IsTransfer = CInt(reader("IsTransfer"))
                    TransferDate = reader("TransferDate").ToString
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

    Public Function GetID(ByVal YouthID As Integer, ByVal CaseID As Integer) As Integer
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()
        Dim reader As SqlDataReader

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Probation_GetID"
            command.Parameters.Add("@YouthID", SqlDbType.Int).Value = YouthID
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID

            reader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                Return CInt(reader("id"))
            Else
                Return -1
            End If

        Catch ex As Exception
            Return -1
        Finally
            conn.Close()
            reader = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function Insert(ByVal YouthID As Integer, ByVal CaseID As Integer, ByVal BlackNo As String, ByVal RedNo As String, ByVal ProbationRef As String,
                           ByVal ProbationCommandText As String, ByVal AssociateJudgeID As Integer, ByVal StartProbationDate As String, ByVal EndProbationDate As String,
                           ByVal SummaryText As String, ByVal isTransfer As Integer, ByVal TransferDate As String, ByVal LMU As Integer) As Integer
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Probation_Insert"
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = YouthID
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID
            command.Parameters.Add("@BlackNo", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@RedNo", SqlDbType.NVarChar, 20).Value = RedNo
            command.Parameters.Add("@ProbationRef", SqlDbType.NVarChar, 20).Value = ProbationRef
            command.Parameters.Add("@ProbationCommandText", SqlDbType.NVarChar, 4000).Value = ProbationCommandText
            command.Parameters.Add("@AssociateJudgeID", SqlDbType.Int).Value = AssociateJudgeID
            command.Parameters.Add("@StartProbationDate", SqlDbType.Date).Value = CDate(StartProbationDate)
            command.Parameters.Add("@EndProbationDate", SqlDbType.Date).Value = CDate(EndProbationDate)
            command.Parameters.Add("@SummaryText", SqlDbType.NVarChar, 4000).Value = SummaryText
            command.Parameters.Add("@IsTransfer", SqlDbType.Int).Value = isTransfer
            command.Parameters.Add("@TransferDate", SqlDbType.Date).Value = CDate(TransferDate)
            command.Parameters.Add("@lmu", SqlDbType.Int).Value = LMU
            command.Parameters.Add("@ID", SqlDbType.Int)
            command.Parameters("@ID").Direction = ParameterDirection.Output

            command.ExecuteNonQuery()

            Dim val As String = command.Parameters("@ID").Value.ToString

            Return CInt(val)
        Catch ex As Exception
            Return -1
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try

    End Function

    Public Function Update(ByVal ProbationID As Integer, ByVal BlackNo As String, ByVal RedNo As String, ByVal ProbationRef As String,
                           ByVal ProbationCommandText As String, ByVal AssociateJudgeID As Integer, ByVal StartProbationDate As String, ByVal EndProbationDate As String,
                           ByVal SummaryText As String, ByVal isTransfer As Integer, ByVal TransferDate As String, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Probation_Update"
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ProbationID
            command.Parameters.Add("@BlackNo", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@RedNo", SqlDbType.NVarChar, 20).Value = RedNo
            command.Parameters.Add("@ProbationRef", SqlDbType.NVarChar, 20).Value = ProbationRef
            command.Parameters.Add("@ProbationCommandText", SqlDbType.NVarChar, 4000).Value = ProbationCommandText
            command.Parameters.Add("@AssociateJudgeID", SqlDbType.Int).Value = AssociateJudgeID
            command.Parameters.Add("@StartProbationDate", SqlDbType.Date).Value = CDate(StartProbationDate)
            command.Parameters.Add("@EndProbationDate", SqlDbType.Date).Value = CDate(EndProbationDate)
            command.Parameters.Add("@SummaryText", SqlDbType.NVarChar, 4000).Value = SummaryText
            command.Parameters.Add("@IsTransfer", SqlDbType.Int).Value = isTransfer
            command.Parameters.Add("@TransferDate", SqlDbType.Date).Value = CDate(TransferDate)
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

End Class
