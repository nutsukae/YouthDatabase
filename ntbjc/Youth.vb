Imports System.Data.SqlClient

Public Class Youth
    Public ID As Integer = 0
    Public Firstname As String = ""
    Public Lastname As String = ""
    Public IDCard As String = ""
    Public DateofBirth As Date = Now
    Public Sex As Integer = 0
    Public Race As String = ""
    Public Nationality As String = ""
    Public ReligionID As Integer = 0
    Public ShirtSize As String = ""
    Public ShoeSize As String = ""
    Public RAHno As String = ""
    Public RAMoo As String = ""
    Public RASoi As String = ""
    Public RARoad As String = ""
    Public RATumbon As String = ""
    Public RAAumphor As String = ""
    Public RAProvince As String = ""
    Public RAZipcode As String = ""
    Public RAPhone As String = ""
    Public CAHno As String = ""
    Public CAMoo As String = ""
    Public CASoi As String = ""
    Public CARoad As String = ""
    Public CATumbon As String = ""
    Public CAAumphor As String = ""
    Public CAProvince As String = ""
    Public CAZipcode As String = ""
    Public CAPhone As String = ""
    Public Mobile As String = ""
    Public MarriageStatus As Integer = 0
    Public MarriageOpt As String = ""
    Public FatherName As String = ""
    Public FatherMobile As String = ""
    Public MotherName As String = ""
    Public MotherMobile As String = ""
    Public FamilyStatus As Integer = 0
    Public StayStatus As Integer = 0
    Public StayOpt1 As String = ""
    Public StayOpt2 As String = ""
    Public EducatedStatus As Integer = 0
    Public EducatedOpt As String = ""
    Public StudyStatus As Integer = 0
    Public StudyOpt As String = ""
    Public OccupationStatus As Integer = 0
    Public OccupationOpt As String = ""
    Public InterestStatus As Integer = 0
    Public InterestOpt As String = ""

    Private _Constr As String

    Public Sub New(ByVal ConnectionString As String)
        Me._Constr = ConnectionString
    End Sub

    Public Function CheckDuplicate(ByVal IDCard As String) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_ChkDupIDCard"
            command.Parameters.Add("@idcard", SqlDbType.NVarChar, 50).Value = IDCard

            Return CBool(command.ExecuteScalar())
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try

    End Function

    Public Sub GetYouth(ByVal YouthID As Integer)
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()
        Dim reader As SqlDataReader

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_GetInfoByID"
            command.Parameters.Add("@id", SqlDbType.Int).Value = YouthID

            reader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    ID = CInt(reader("ID"))
                    Firstname = CStr(reader("firstname"))
                    Lastname = reader("lastname").ToString
                    IDCard = reader("idcard").ToString
                    DateofBirth = reader("dob").ToString
                    Sex = CInt(reader("sex"))
                    Race = reader("race").ToString
                    Nationality = reader("nationality").ToString
                    ReligionID = CInt(reader("religionid"))
                    ShirtSize = reader("shirt_size").ToString
                    ShoeSize = reader("shoe_size").ToString
                    RAHno = reader("ra_hno").ToString
                    RAMoo = reader("ra_moo").ToString
                    RASoi = reader("ra_soi").ToString
                    RARoad = reader("ra_road").ToString
                    RATumbon = reader("ra_tumbon").ToString
                    RAAumphor = reader("ra_aumphor").ToString
                    RAProvince = reader("ra_province").ToString
                    RAZipcode = reader("ra_zipcode").ToString
                    RAPhone = reader("ra_phone").ToString
                    CAHno = reader("ca_hno").ToString
                    CAMoo = reader("ca_moo").ToString
                    CASoi = reader("ca_soi").ToString
                    CARoad = reader("ca_road").ToString
                    CATumbon = reader("ca_tumbon").ToString
                    CAAumphor = reader("ca_aumphor").ToString
                    CAProvince = reader("ca_province").ToString
                    CAZipcode = reader("ca_zipcode").ToString
                    CAPhone = reader("ca_phone").ToString
                    Mobile = reader("mobile").ToString
                    MarriageStatus = CInt(reader("marriage_status"))
                    MarriageOpt = reader("marriage_opt").ToString
                    FatherName = reader("father_name").ToString
                    FatherMobile = reader("father_mobile").ToString
                    MotherName = reader("mother_name").ToString
                    MotherMobile = reader("mother_mobile").ToString
                    FamilyStatus = CInt(reader("family_status"))
                    StayStatus = CInt(reader("stay_status"))
                    StayOpt1 = reader("stay_opt1").ToString
                    StayOpt2 = reader("stay_opt2").ToString
                    EducatedStatus = CInt(reader("educated_status"))
                    EducatedOpt = reader("educated_opt").ToString
                    StudyStatus = CInt(reader("study_status"))
                    StudyOpt = reader("study_opt").ToString
                    OccupationStatus = CInt(reader("occupation_status"))
                    OccupationOpt = reader("occupation_opt").ToString
                    InterestStatus = CInt(reader("interest_status"))
                    InterestOpt = reader("interest_opt").ToString
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

    Public Sub GetYouth(ByVal SearchIDCard As String)
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()
        Dim reader As SqlDataReader

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_GetInfoByIDCard"
            command.Parameters.Add("@idcard", SqlDbType.NVarChar, 50).Value = SearchIDCard

            reader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    ID = CInt(reader("ID"))
                    Firstname = CStr(reader("firstname"))
                    Lastname = reader("lastname").ToString
                    IDCard = reader("idcard").ToString
                    DateofBirth = reader("dob").ToString
                    Sex = CInt(reader("sex"))
                    Race = reader("race").ToString
                    Nationality = reader("nationality").ToString
                    ReligionID = CInt(reader("religionid"))
                    ShirtSize = reader("shirt_size").ToString
                    ShoeSize = reader("shoe_size").ToString
                    RAHno = reader("ra_hno").ToString
                    RAMoo = reader("ra_moo").ToString
                    RASoi = reader("ra_soi").ToString
                    RARoad = reader("ra_road").ToString
                    RATumbon = reader("ra_tumbon").ToString
                    RAAumphor = reader("ra_aumphor").ToString
                    RAProvince = reader("ra_province").ToString
                    RAZipcode = reader("ra_zipcode").ToString
                    RAPhone = reader("ra_phone").ToString
                    CAHno = reader("ca_hno").ToString
                    CAMoo = reader("ca_moo").ToString
                    CASoi = reader("ca_soi").ToString
                    CARoad = reader("ca_road").ToString
                    CATumbon = reader("ca_tumbon").ToString
                    CAAumphor = reader("ca_aumphor").ToString
                    CAProvince = reader("ca_province").ToString
                    CAZipcode = reader("ca_zipcode").ToString
                    CAPhone = reader("ca_phone").ToString
                    Mobile = reader("mobile").ToString
                    MarriageStatus = CInt(reader("marriage_status"))
                    MarriageOpt = reader("marriage_opt").ToString
                    FatherName = reader("father_name").ToString
                    FatherMobile = reader("father_mobile").ToString
                    MotherName = reader("mother_name").ToString
                    MotherMobile = reader("mother_mobile").ToString
                    FamilyStatus = CInt(reader("family_status"))
                    StayStatus = CInt(reader("stay_status"))
                    StayOpt1 = reader("stay_opt1").ToString
                    StayOpt2 = reader("stay_opt2").ToString
                    EducatedStatus = CInt(reader("educated_status"))
                    EducatedOpt = reader("educated_opt").ToString
                    StudyStatus = CInt(reader("study_status"))
                    StudyOpt = reader("study_opt").ToString
                    OccupationStatus = CInt(reader("occupation_status"))
                    OccupationOpt = reader("occupation_opt").ToString
                    InterestStatus = CInt(reader("interest_status"))
                    InterestOpt = reader("interest_opt").ToString
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

    Public Function GetYouth2(ByVal SearchIDCard As String) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_GetInfoByIDCard2"
            command.Parameters.Add("@IDCard", SqlDbType.VarChar, 13).Value = SearchIDCard

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

    Public Function Insert(ByVal Firstname As String, ByVal Lastname As String, ByVal IDCard As String, ByVal DateofBirth As String,
                            ByVal Race As String, ByVal Nationality As String, ByVal ReligionID As Integer, ByVal Sex As Integer, ByVal ShirtSize As String, ByVal ShoeSize As String,
                            ByVal RAHno As String, ByVal RAMoo As String, ByVal RASoi As String, ByVal RARoad As String, ByVal RATumbon As String, ByVal RAAumphor As String, ByVal RAProvince As String, ByVal RAZipcode As String, ByVal RAPhone As String,
                            ByVal CAHno As String, ByVal CAMoo As String, ByVal CASoi As String, ByVal CARoad As String, ByVal CATumbon As String, ByVal CAAumphor As String, ByVal CAProvince As String, ByVal CAZipcode As String, ByVal CAPhone As String,
                            ByVal Mobile As String, ByVal MarriageStatus As Integer, ByVal MarriageOpt As String, ByVal FatherName As String, ByVal FatherMobile As String, ByVal MotherName As String, ByVal MotherMobile As String,
                            ByVal FamilyStatus As Integer, ByVal StayStatus As Integer, ByVal StayOpt1 As String, ByVal StayOpt2 As String,
                            ByVal EducatedStatus As Integer, ByVal EducatedOpt As String, ByVal StudyStatus As Integer, ByVal StudyOpt As String, ByVal OccupationStatus As Integer, ByVal OccupationOpt As String,
                            ByVal InterestStatus As Integer, ByVal InterestOpt As String, ByVal LMU As Integer) As Boolean

        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_Insert"
            command.Parameters.Add("@firstname", SqlDbType.NVarChar, 50).Value = Firstname
            command.Parameters.Add("@lastname", SqlDbType.NVarChar, 50).Value = Lastname
            command.Parameters.Add("@idcard", SqlDbType.NVarChar, 50).Value = IDCard
            command.Parameters.Add("@dob", SqlDbType.Date).Value = CDate(DateofBirth)
            command.Parameters.Add("@age_y", SqlDbType.Int).Value = CInt(DateDiff(DateInterval.Year, CDate(DateofBirth), Now))
            command.Parameters.Add("@age_m", SqlDbType.Int).Value = CInt(DateDiff(DateInterval.Month, CDate(DateofBirth), Now))
            command.Parameters.Add("@sex", SqlDbType.Int).Value = Sex
            command.Parameters.Add("@race", SqlDbType.NVarChar, 20).Value = Race
            command.Parameters.Add("@nationality", SqlDbType.NVarChar, 20).Value = Nationality
            command.Parameters.Add("@regionid", SqlDbType.Int).Value = ReligionID
            command.Parameters.Add("@shirt_size", SqlDbType.VarChar, 10).Value = ShirtSize
            command.Parameters.Add("@shoe_size", SqlDbType.VarChar, 10).Value = ShoeSize
            command.Parameters.Add("@ra_hno", SqlDbType.NVarChar, 50).Value = RAHno
            command.Parameters.Add("@ra_moo", SqlDbType.NVarChar, 50).Value = RAMoo
            command.Parameters.Add("@ra_soi", SqlDbType.NVarChar, 100).Value = RASoi
            command.Parameters.Add("@ra_road", SqlDbType.NVarChar, 100).Value = RARoad
            command.Parameters.Add("@ra_tumbon", SqlDbType.NVarChar, 100).Value = RATumbon
            command.Parameters.Add("@ra_aumphor", SqlDbType.NVarChar, 100).Value = RAAumphor
            command.Parameters.Add("@ra_province", SqlDbType.NVarChar, 50).Value = RAProvince
            command.Parameters.Add("@ra_zipcode", SqlDbType.VarChar, 5).Value = RAZipcode
            command.Parameters.Add("@ra_phone", SqlDbType.VarChar, 50).Value = RAPhone
            command.Parameters.Add("@ca_hno", SqlDbType.NVarChar, 50).Value = CAHno
            command.Parameters.Add("@ca_moo", SqlDbType.NVarChar, 50).Value = CAMoo
            command.Parameters.Add("@ca_soi", SqlDbType.NVarChar, 100).Value = CASoi
            command.Parameters.Add("@ca_road", SqlDbType.NVarChar, 100).Value = CARoad
            command.Parameters.Add("@ca_tumbon", SqlDbType.NVarChar, 100).Value = CATumbon
            command.Parameters.Add("@ca_aumphor", SqlDbType.NVarChar, 100).Value = CAAumphor
            command.Parameters.Add("@ca_province", SqlDbType.NVarChar, 50).Value = CAProvince
            command.Parameters.Add("@ca_zipcode", SqlDbType.VarChar, 5).Value = CAZipcode
            command.Parameters.Add("@ca_phone", SqlDbType.VarChar, 50).Value = CAPhone
            command.Parameters.Add("@mobile", SqlDbType.VarChar, 20).Value = Mobile
            command.Parameters.Add("@marriage_status", SqlDbType.Int).Value = MarriageStatus
            command.Parameters.Add("@marriage_opt", SqlDbType.NVarChar, 50).Value = MarriageOpt
            command.Parameters.Add("@father_name", SqlDbType.NVarChar, 50).Value = FatherName
            command.Parameters.Add("@father_mobile", SqlDbType.VarChar, 20).Value = FatherMobile
            command.Parameters.Add("@mother_name", SqlDbType.NVarChar, 50).Value = MotherName
            command.Parameters.Add("@mother_mobile", SqlDbType.VarChar, 20).Value = MotherMobile
            command.Parameters.Add("@family_status", SqlDbType.Int).Value = FamilyStatus
            command.Parameters.Add("@stay_status", SqlDbType.Int).Value = StayStatus
            command.Parameters.Add("@stay_opt1", SqlDbType.NVarChar, 50).Value = StayOpt1
            command.Parameters.Add("@stay_opt2", SqlDbType.NVarChar, 50).Value = StayOpt2
            command.Parameters.Add("@educated_status", SqlDbType.Int).Value = EducatedStatus
            command.Parameters.Add("@educated_opt", SqlDbType.NVarChar, 50).Value = EducatedOpt
            command.Parameters.Add("@study_status", SqlDbType.Int).Value = StudyStatus
            command.Parameters.Add("@study_opt", SqlDbType.NVarChar, 50).Value = StudyOpt
            command.Parameters.Add("@occupation_status", SqlDbType.Int).Value = OccupationStatus
            command.Parameters.Add("@occupation_opt", SqlDbType.NVarChar, 50).Value = OccupationOpt
            command.Parameters.Add("@interest_status", SqlDbType.Int).Value = InterestStatus
            command.Parameters.Add("@interest_opt", SqlDbType.NVarChar, 50).Value = InterestOpt
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

    Public Function InsertCase(ByVal PersonID As Integer, ByVal CaseId As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_PersonCase_Insert"
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseId

            Return CBool(command.ExecuteNonQuery())
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function Update(ByVal ID As Integer, ByVal Firstname As String, ByVal Lastname As String, ByVal IDCard As String, ByVal DateofBirth As String,
                            ByVal Sex As Integer, ByVal Race As String, ByVal Nationality As String, ByVal ReligionId As Integer, ByVal ShirtSize As String, ByVal ShoeSize As String,
                            ByVal RAHno As String, ByVal RAMoo As String, ByVal RASoi As String, ByVal RARoad As String, ByVal RATumbon As String, ByVal RAAumphor As String, ByVal RAProvince As String, ByVal RAZipcode As String, ByVal RAPhone As String,
                            ByVal CAHno As String, ByVal CAMoo As String, ByVal CASoi As String, ByVal CARoad As String, ByVal CATumbon As String, ByVal CAAumphor As String, ByVal CAProvince As String, ByVal CAZipcode As String, ByVal CAPhone As String,
                            ByVal Mobile As String, ByVal MarriageStatus As Integer, ByVal MarriageOpt As String, ByVal FatherName As String, ByVal FatherMobile As String, ByVal MotherName As String, ByVal MotherMobile As String,
                            ByVal FamilyStatus As Integer, ByVal StayStatus As Integer, ByVal StayOpt1 As String, ByVal StayOpt2 As String,
                            ByVal EducatedStatus As Integer, ByVal EducatedOpt As String, ByVal StudyStatus As Integer, ByVal StudyOpt As String, ByVal OccupationStatus As Integer, ByVal OccupationOpt As String, ByVal InterestStatus As Integer, ByVal InterestOpt As String, ByVal LMU As Integer) As Boolean

        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_Update"
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID
            command.Parameters.Add("@firstname", SqlDbType.NVarChar, 50).Value = Firstname
            command.Parameters.Add("@lastname", SqlDbType.NVarChar, 50).Value = Lastname
            command.Parameters.Add("@idcard", SqlDbType.NVarChar, 50).Value = IDCard
            command.Parameters.Add("@dob", SqlDbType.Date).Value = CDate(DateofBirth)
            command.Parameters.Add("@age_y", SqlDbType.Int).Value = CInt(DateDiff(DateInterval.Year, CDate(DateofBirth), Now))
            command.Parameters.Add("@age_m", SqlDbType.Int).Value = CInt(DateDiff(DateInterval.Month, CDate(DateofBirth), Now))
            command.Parameters.Add("@sex", SqlDbType.Int).Value = Sex
            command.Parameters.Add("@race", SqlDbType.NVarChar, 20).Value = Race
            command.Parameters.Add("@nationality", SqlDbType.NVarChar, 20).Value = Nationality
            command.Parameters.Add("@religionid", SqlDbType.Int).Value = ReligionId
            command.Parameters.Add("@shirt_size", SqlDbType.VarChar, 10).Value = ShirtSize
            command.Parameters.Add("@shoe_size", SqlDbType.VarChar, 10).Value = ShoeSize
            command.Parameters.Add("@ra_hno", SqlDbType.NVarChar, 50).Value = RAHno
            command.Parameters.Add("@ra_moo", SqlDbType.NVarChar, 50).Value = RAMoo
            command.Parameters.Add("@ra_soi", SqlDbType.NVarChar, 100).Value = RASoi
            command.Parameters.Add("@ra_road", SqlDbType.NVarChar, 100).Value = RARoad
            command.Parameters.Add("@ra_tumbon", SqlDbType.NVarChar, 100).Value = RATumbon
            command.Parameters.Add("@ra_aumphor", SqlDbType.NVarChar, 100).Value = RAAumphor
            command.Parameters.Add("@ra_province", SqlDbType.NVarChar, 50).Value = RAProvince
            command.Parameters.Add("@ra_zipcode", SqlDbType.VarChar, 5).Value = RAZipcode
            command.Parameters.Add("@ra_phone", SqlDbType.VarChar, 50).Value = RAPhone
            command.Parameters.Add("@ca_hno", SqlDbType.NVarChar, 50).Value = CAHno
            command.Parameters.Add("@ca_moo", SqlDbType.NVarChar, 50).Value = CAMoo
            command.Parameters.Add("@ca_soi", SqlDbType.NVarChar, 100).Value = CASoi
            command.Parameters.Add("@ca_road", SqlDbType.NVarChar, 100).Value = CARoad
            command.Parameters.Add("@ca_tumbon", SqlDbType.NVarChar, 100).Value = CATumbon
            command.Parameters.Add("@ca_aumphor", SqlDbType.NVarChar, 100).Value = CAAumphor
            command.Parameters.Add("@ca_province", SqlDbType.NVarChar, 50).Value = CAProvince
            command.Parameters.Add("@ca_zipcode", SqlDbType.VarChar, 5).Value = CAZipcode
            command.Parameters.Add("@ca_phone", SqlDbType.VarChar, 50).Value = CAPhone
            command.Parameters.Add("@mobile", SqlDbType.VarChar, 20).Value = Mobile
            command.Parameters.Add("@marriage_status", SqlDbType.Int).Value = MarriageStatus
            command.Parameters.Add("@marriage_opt", SqlDbType.NVarChar, 50).Value = MarriageOpt
            command.Parameters.Add("@father_name", SqlDbType.NVarChar, 50).Value = FatherName
            command.Parameters.Add("@father_mobile", SqlDbType.VarChar, 20).Value = FatherMobile
            command.Parameters.Add("@mother_name", SqlDbType.NVarChar, 50).Value = MotherName
            command.Parameters.Add("@mother_mobile", SqlDbType.VarChar, 20).Value = MotherMobile
            command.Parameters.Add("@family_status", SqlDbType.Int).Value = FamilyStatus
            command.Parameters.Add("@stay_status", SqlDbType.Int).Value = StayStatus
            command.Parameters.Add("@stay_opt1", SqlDbType.NVarChar, 50).Value = StayOpt1
            command.Parameters.Add("@stay_opt2", SqlDbType.NVarChar, 50).Value = StayOpt2
            command.Parameters.Add("@educated_status", SqlDbType.Int).Value = EducatedStatus
            command.Parameters.Add("@educated_opt", SqlDbType.NVarChar, 50).Value = EducatedOpt
            command.Parameters.Add("@study_status", SqlDbType.Int).Value = StudyStatus
            command.Parameters.Add("@study_opt", SqlDbType.NVarChar, 50).Value = StudyOpt
            command.Parameters.Add("@occupation_status", SqlDbType.Int).Value = OccupationStatus
            command.Parameters.Add("@occupation_opt", SqlDbType.NVarChar, 50).Value = OccupationOpt
            command.Parameters.Add("@interest_status", SqlDbType.Int).Value = InterestStatus
            command.Parameters.Add("@interest_opt", SqlDbType.NVarChar, 50).Value = InterestOpt
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

    Public Function ListCase(ByVal PersonID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_PersonCase_List"
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID

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

    Public Function ListCaseForProbation(ByVal Firstname As String, ByVal Lastname As String, ByVal IDCard As String, ByVal CaseNo As String, ByVal BlackNo As String, ByVal CaseTypeID As Integer) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_ListforProbation"
            command.Parameters.Add("@firstname", SqlDbType.NVarChar, 50).Value = Firstname
            command.Parameters.Add("@lastname", SqlDbType.NVarChar, 50).Value = Lastname
            command.Parameters.Add("@idcard", SqlDbType.NVarChar, 13).Value = IDCard
            command.Parameters.Add("@caseno", SqlDbType.NVarChar, 20).Value = CaseNo
            command.Parameters.Add("@blackno", SqlDbType.NVarChar, 20).Value = BlackNo
            command.Parameters.Add("@casetypeid", SqlDbType.Int).Value = CaseTypeID

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

    Public Function RemoveCases(ByVal PersonID As Integer, ByVal CaseId As Integer) As Boolean
        Dim conn As SqlConnection = New SqlConnection(_Constr)
        Dim command As SqlCommand = New SqlCommand()

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_PersonCase_Delete"
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID
            command.Parameters.Add("@CaseID", SqlDbType.Int).Value = CaseId

            Return CBool(command.ExecuteNonQuery())
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            command = Nothing
            conn = Nothing
        End Try
    End Function

    Public Function SearchYouth(ByVal firstname As String, ByVal lastname As String, ByVal idcard As String) As DataSet
        Dim conn As New SqlConnection(Me._Constr)
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Person_SearchPerson"
            command.Parameters.Add("@firstname", SqlDbType.NVarChar, 50).Value = firstname
            command.Parameters.Add("@lastname", SqlDbType.NVarChar, 50).Value = lastname
            command.Parameters.Add("@idcard", SqlDbType.VarChar, 13).Value = idcard

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
End Class
