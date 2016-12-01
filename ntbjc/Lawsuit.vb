Imports System.Data.SqlClient

Public Class Lawsuit
    Private _ConStr As String = ""
    Private _Id As Integer = 0

    Public id As Integer = 0
    Public CaseTypeID As Integer = 0
    Public CaseNo As String = ""
    Public StartDate As Date = Now
    Public EndDate As Date = Now
    Public LocationID As Integer = 0
    Public BlackNo As String = ""
    Public Section As Integer = 0
    Public RedNo As String = ""

    Public Sub New(ByVal ConnectionString As String)
        Me._ConStr = ConnectionString
    End Sub

    Public Sub New(ByVal ID As Integer, ByVal ConnectionString As String)
        Me._Id = ID
        Me._ConStr = ConnectionString
    End Sub

    Public Function insert(ByVal CaseTypeID As Integer, ByVal CaseNo As String, ByVal Title As String, ByVal VictimName As String, ByVal VictimAddress As String, ByVal VictimPhone As String,
                           ByVal LawsuitDate As String, ByVal AdviceDate As String, ByVal InspectDate As String,
                           ByVal LocationID As Integer, ByVal BlackNo As String, ByVal Section As Integer, ByVal RedNo As String,
                           ByVal PlanDate As String, ByVal ExPlanDate As String, ByVal ExDate As String, ByVal LMU As Integer) As Integer
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Lawsuit_Insert"
            command.Parameters.Add("@CaseTypeID", SqlDbType.Int).Value = CaseTypeID
            command.Parameters.Add("@CaseNo", SqlDbType.NVarChar, 20).Value = CaseNo
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = Title
            command.Parameters.Add("@Victim_name", SqlDbType.NVarChar, 100).Value = VictimName
            command.Parameters.Add("@Victim_address", SqlDbType.NVarChar, 200).Value = VictimAddress
            command.Parameters.Add("@Victim_phone", SqlDbType.NVarChar, 13).Value = VictimPhone
            command.Parameters.Add("@LawsuitDate", SqlDbType.Date).Value = CDate(LawsuitDate)
            command.Parameters.Add("@AdviceDate", SqlDbType.Date).Value = CDate(AdviceDate)
            command.Parameters.Add("@InspectDate", SqlDbType.Date).Value = CDate(InspectDate)
            command.Parameters.Add("@locationID", SqlDbType.Int).Value = LocationID
            command.Parameters.Add("@blackNo", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@section", SqlDbType.Int).Value = Section
            command.Parameters.Add("@redNo", SqlDbType.NVarChar, 20).Value = RedNo
            command.Parameters.Add("@LMU", SqlDbType.Int).Value = LMU
            command.Parameters.Add("@PlanDate", SqlDbType.Date).Value = CDate(PlanDate)
            command.Parameters.Add("@ExPlanDate", SqlDbType.Date).Value = CDate(ExPlanDate)
            command.Parameters.Add("@ExDate", SqlDbType.Date).Value = CDate(ExDate)
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

    Public Function BindTort(ByVal LawsuitID As Integer, ByVal TortID As Integer) As Boolean
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_LawsuitTort_Insert"
            command.Parameters.Add("@LawSuitID", SqlDbType.Int).Value = LawsuitID
            command.Parameters.Add("@TortID", SqlDbType.Int).Value = TortID

            command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function BindTort(ByVal TortID As Integer) As Boolean
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_LawsuitTort_Insert"
            command.Parameters.Add("@LawSuitID", SqlDbType.Int).Value = _Id
            command.Parameters.Add("@TortID", SqlDbType.Int).Value = TortID

            command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function ListTort(ByVal CaseID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_LawsuitTort_ListByCaseID"
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID

            Dim ds = New DataSet()
            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            conn.Close()
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function ListYouth(ByVal CaseID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Lawsuit_ListYouthByCaseID"
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseID

            Dim ds = New DataSet()
            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            conn.Close()
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function RemoveTort(ByVal LawsuitID As Integer) As Boolean
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_LawsuitTort_Delete"
            command.Parameters.Add("@LawSuitID", SqlDbType.Int).Value = LawsuitID

            command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function RemoveTortByID(ByVal LawsuitID As Integer, ByVal TortID As Integer) As Boolean
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Lawsuit_DeleteByTortID"
            command.Parameters.Add("@LawSuitID", SqlDbType.Int).Value = LawsuitID
            command.Parameters.Add("@TortID", SqlDbType.Int).Value = TortID

            command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function Search(ByVal CaseTypeID As Integer, ByVal CaseNo As String) As DataSet
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Lawsuit_Search"
            command.Parameters.Add("@CaseTypeID", SqlDbType.Int).Value = CaseTypeID
            command.Parameters.Add("@CaseNo", SqlDbType.NVarChar, 20).Value = CaseNo

            Dim ds = New DataSet()
            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            conn.Close()
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function GetDetailByID(ByVal CaseID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Lawsuit_GetDetailByID"
            command.Parameters.Add("@ID", SqlDbType.Int).Value = CaseID

            Dim ds = New DataSet()
            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            conn.Close()
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function Update(ByVal CaseID As Integer, ByVal CaseTypeID As Integer, ByVal CaseNo As String, ByVal Title As String, ByVal VictimName As String, ByVal VictimAddress As String, ByVal VictimPhone As String,
                           ByVal LawsuitDate As String, ByVal AdviceDate As String, ByVal InspectDate As String,
                           ByVal LocationID As Integer, ByVal BlackNo As String, ByVal Section As Integer, ByVal RedNo As String,
                           ByVal PlanDate As String, ByVal ExPlanDate As String, ByVal ExDate As String, ByVal LMU As Integer) As Boolean
        Dim conn As New SqlConnection(Me._ConStr)
        Dim command As New SqlCommand

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Lawsuit_Update"
            command.Parameters.Add("@ID", SqlDbType.Int).Value = CaseID
            command.Parameters.Add("@CaseTypeID", SqlDbType.Int).Value = CaseTypeID
            command.Parameters.Add("@CaseNo", SqlDbType.NVarChar, 20).Value = CaseNo
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = Title
            command.Parameters.Add("@Victim_name", SqlDbType.NVarChar, 100).Value = VictimName
            command.Parameters.Add("@Victim_address", SqlDbType.NVarChar, 200).Value = VictimAddress
            command.Parameters.Add("@Victim_phone", SqlDbType.NVarChar, 13).Value = VictimPhone
            command.Parameters.Add("@LawsuitDate", SqlDbType.Date).Value = CDate(LawsuitDate)
            command.Parameters.Add("@AdviceDate", SqlDbType.Date).Value = CDate(AdviceDate)
            command.Parameters.Add("@InspectDate", SqlDbType.Date).Value = CDate(InspectDate)
            command.Parameters.Add("@locationID", SqlDbType.Int).Value = LocationID
            command.Parameters.Add("@blackNo", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@section", SqlDbType.Int).Value = Section
            command.Parameters.Add("@redNo", SqlDbType.NVarChar, 20).Value = RedNo
            command.Parameters.Add("@LMU", SqlDbType.Int).Value = LMU
            command.Parameters.Add("@PlanDate", SqlDbType.Date).Value = CDate(PlanDate)
            command.Parameters.Add("@ExPlanDate", SqlDbType.Date).Value = CDate(ExPlanDate)
            command.Parameters.Add("@ExDate", SqlDbType.Date).Value = CDate(ExDate)

            command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

End Class
