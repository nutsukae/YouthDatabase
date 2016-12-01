Imports System.Data.SqlClient

Public Class Activity
    Private _Constr As String

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Function AddYouth(ByVal ActivityID As Integer, ByVal YouthID As Integer, ByVal CaseID As Integer, ByVal Ref As Integer, ByVal Status As Integer, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActivityPerson_Insert"
            command.Parameters.Add("@ActivityId", SqlDbType.Int).Value = ActivityID
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = YouthID
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID
            command.Parameters.Add("@Ref", SqlDbType.Int).Value = Ref
            command.Parameters.Add("@Status", SqlDbType.Int).Value = Status
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

    Public Function RemoveYouth(ByVal ActivityPersonID As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActivityPerson_Delete"
            command.Parameters.Add("@AP_ID", SqlDbType.Int).Value = ActivityPersonID
            'command.Parameters.Add("@PersonID", SqlDbType.Int).Value = YouthID
            'command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID

            Return CBool(command.ExecuteNonQuery())
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function GetActivityType() As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActivityType_List"

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

    Public Function GetInfoById(ByVal ActivityID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Activity_GetInfoByID"
            command.Parameters.Add("@ActId", SqlDbType.Int).Value = ActivityID

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

    Public Function GetInfoById2(ByVal ActivityID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Activity_GetInfoByID2"
            command.Parameters.Add("@ActId", SqlDbType.Int).Value = ActivityID

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

    Public Function Insert(ByVal Name As String, ByVal ActivityTypeId As Integer, ByVal Location As String, ByVal DeptId As Integer, ByVal ActivityDate As String, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Activity_Insert"
            command.Parameters.Add("@name", SqlDbType.NVarChar, 400).Value = Name
            command.Parameters.Add("@acttypeid", SqlDbType.Int).Value = ActivityTypeId
            command.Parameters.Add("@location", SqlDbType.NVarChar, 200).Value = Location
            command.Parameters.Add("@deptid", SqlDbType.Int).Value = DeptId
            command.Parameters.Add("@actdate", SqlDbType.Date).Value = CDate(ActivityDate)
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

    Public Function Insert2(ByVal Name As String, ByVal ActivityTypeId As Integer, ByVal Location As String, ByVal DeptId As Integer, ByVal ActivityDate As String, ByVal LMU As Integer) As Integer
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Activity_Insert_2"
            command.Parameters.Add("@name", SqlDbType.NVarChar, 400).Value = Name
            command.Parameters.Add("@acttypeid", SqlDbType.Int).Value = ActivityTypeId
            command.Parameters.Add("@location", SqlDbType.NVarChar, 200).Value = Location
            command.Parameters.Add("@deptid", SqlDbType.Int).Value = DeptId
            command.Parameters.Add("@actdate", SqlDbType.Date).Value = CDate(ActivityDate)
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

    Public Function List() As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Activity_List"

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

    Public Function ListYouth(ByVal ActivityID As Integer, ByVal UserTypeId As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActivityPerson_ListByActID"
            command.Parameters.Add("@ActId", SqlDbType.Int).Value = ActivityID
            command.Parameters.Add("@Ref", SqlDbType.Int).Value = UserTypeId

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

    Public Function Update(ByVal ID As Integer, ByVal ActivityTypeID As Integer, ByVal Name As String, ByVal Location As String, ByVal DeptId As Integer, ByVal ActivityDate As String, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Activity_Update"
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            command.Parameters.Add("@acttypeid", SqlDbType.Int).Value = ActivityTypeID
            command.Parameters.Add("@name", SqlDbType.NVarChar, 400).Value = Name
            command.Parameters.Add("@location", SqlDbType.NVarChar, 200).Value = Location
            command.Parameters.Add("@deptid", SqlDbType.Int).Value = DeptId
            command.Parameters.Add("@actdate", SqlDbType.Date).Value = CDate(ActivityDate)
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

    Public Function UpdateYouth(ByVal ActivityPersonID As Integer, ByVal Status As Integer, ByVal LMU As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActivityPerson_Update"
            command.Parameters.Add("@ActPerID", SqlDbType.Int).Value = ActivityPersonID
            command.Parameters.Add("@Status", SqlDbType.Int).Value = Status
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
