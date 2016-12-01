Imports System.Data.SqlClient
Public Class AdvCenter
    Private _Constr As String

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Function GetDetailByID(ByVal YouthID As Integer, ByVal CaseID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AdviceCenter_GetDetailByID"
            command.Parameters.Add("@YouthID", SqlDbType.Int).Value = YouthID
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID
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

    Public Function Insert(ByVal YouthID As Integer, ByVal CaseID As Integer, ByVal BlackNo As String, ByVal RedNo As String, ByVal MainAssociateJudge As Integer,
                           ByVal SupportAssociateJudge As Integer, ByVal Reason As String, ByVal Behaviour As String, ByVal Thinking As String, ByVal Emotion As String,
                           ByVal Family As String, ByVal Social As String, ByVal Summary As String, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AdviceCenter_Insert"
            command.Parameters.Add("@YouthID", SqlDbType.Int).Value = YouthID
            command.Parameters.Add("@caseID", SqlDbType.Int).Value = CaseID
            command.Parameters.Add("@blackno", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@redno", SqlDbType.NVarChar, 20).Value = RedNo
            command.Parameters.Add("@MainAssociateJudgeID", SqlDbType.Int).Value = MainAssociateJudge
            command.Parameters.Add("@SupportAssociateJudgeID", SqlDbType.Int).Value = SupportAssociateJudge
            command.Parameters.Add("@Reason", SqlDbType.NVarChar, -1).Value = Reason
            command.Parameters.Add("@Behaviour", SqlDbType.NVarChar, -1).Value = Behaviour
            command.Parameters.Add("@Thinking", SqlDbType.NVarChar, -1).Value = Thinking
            command.Parameters.Add("@Emotion", SqlDbType.NVarChar, -1).Value = Emotion
            command.Parameters.Add("@Family", SqlDbType.NVarChar, -1).Value = Family
            command.Parameters.Add("@Social", SqlDbType.NVarChar, -1).Value = Social
            command.Parameters.Add("@Summary", SqlDbType.NVarChar, -1).Value = Summary
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

    Public Function ListActivity(ByVal YouthId As Integer, ByVal CaseID As Integer, ByVal UserTypeID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AdviceCenter_ListActivity"
            command.Parameters.Add("@YouthID", SqlDbType.Int).Value = YouthId
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID
            command.Parameters.Add("@UserTypeID", SqlDbType.Int).Value = UserTypeID
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

    Public Function Update(ByVal AdviceCenterID As Integer, ByVal YouthID As Integer, ByVal CaseID As Integer, ByVal BlackNo As String, ByVal RedNo As String, ByVal MainAssociateJudge As Integer,
                           ByVal SupportAssociateJudge As Integer, ByVal Reason As String, ByVal Behaviour As String, ByVal Thinking As String, ByVal Emotion As String,
                           ByVal Family As String, ByVal Social As String, ByVal Summary As String, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AdviceCenter_Update"
            command.Parameters.Add("@AdvID", SqlDbType.Int).Value = AdviceCenterID
            command.Parameters.Add("@YouthID", SqlDbType.Int).Value = YouthID
            command.Parameters.Add("@caseID", SqlDbType.Int).Value = CaseID
            command.Parameters.Add("@blackno", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@redno", SqlDbType.NVarChar, 20).Value = RedNo
            command.Parameters.Add("@MainAssociateJudgeID", SqlDbType.Int).Value = MainAssociateJudge
            command.Parameters.Add("@SupportAssociateJudgeID", SqlDbType.Int).Value = SupportAssociateJudge
            command.Parameters.Add("@Reason", SqlDbType.NVarChar, -1).Value = Reason
            command.Parameters.Add("@Behaviour", SqlDbType.NVarChar, -1).Value = Behaviour
            command.Parameters.Add("@Thinking", SqlDbType.NVarChar, -1).Value = Thinking
            command.Parameters.Add("@Emotion", SqlDbType.NVarChar, -1).Value = Emotion
            command.Parameters.Add("@Family", SqlDbType.NVarChar, -1).Value = Family
            command.Parameters.Add("@Social", SqlDbType.NVarChar, -1).Value = Social
            command.Parameters.Add("@Summary", SqlDbType.NVarChar, -1).Value = Summary
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
