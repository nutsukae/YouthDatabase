Imports ntbjc
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Public Class login

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CheckDBConnnection() Then
            Me.MdiParent.MainMenuStrip.Items("ConsultMenu").Visible = False
            Me.MdiParent.MainMenuStrip.Items("ProbationMenu").Visible = False
            Me.MdiParent.MainMenuStrip.Items("ReportMenu").Visible = False

            GlobalVar.UserID = Nothing
            GlobalVar.UserName = Nothing

            lbError.Visible = False
            btSubmit.Enabled = True
        Else
            lbError.Visible = True
            btSubmit.Enabled = False
        End If

    End Sub

    Private Function CheckDBConnnection() As Boolean
        Dim connection As SqlConnection = New SqlConnection(ConnectionStrings("Connection").ToString)
        Try
            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()
            GlobalVar.ConnectionString = ConnectionStrings("Connection").ToString

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        CheckUser()
    End Sub

    Private Sub SetMenu(ByVal UserType As Integer)
        '1   Administrator
        '2   Consultant Officer
        '3   Probation Officer (Processing)
        '4   Probation Officer (Processed)
        '5   Judge
        Select Case UserType
            Case 1
                Me.MdiParent.MainMenuStrip.Items("ConsultMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ProbationMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ReportMenu").Visible = True
            Case 2
                Me.MdiParent.MainMenuStrip.Items("ConsultMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ProbationMenu").Visible = False
                Me.MdiParent.MainMenuStrip.Items("ReportMenu").Visible = True
            Case 3
                Me.MdiParent.MainMenuStrip.Items("ConsultMenu").Visible = False
                Me.MdiParent.MainMenuStrip.Items("ProbationMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ReportMenu").Visible = True
            Case 4
                Me.MdiParent.MainMenuStrip.Items("ConsultMenu").Visible = False
                Me.MdiParent.MainMenuStrip.Items("ProbationMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ReportMenu").Visible = True
            Case 5
                Me.MdiParent.MainMenuStrip.Items("ConsultMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ProbationMenu").Visible = True
                Me.MdiParent.MainMenuStrip.Items("ReportMenu").Visible = True
        End Select

        Me.Dispose()
    End Sub

    Private Sub tbUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUsername.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            tbPassword.Focus()
        End If
    End Sub

    Private Sub tbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            CheckUser()
        End If
    End Sub

    Private Sub CheckUser()
        Dim Username As String = tbUsername.Text
        Dim Password As String = tbPassword.Text

        If Username <> "" And Password <> "" Then
            Dim Usr As Users = New Users(Username, Password, GlobalVar.ConnectionString)
            If Usr.ID = -1 Then
                MessageBox.Show("Username หรือ Password ไม่ถูกต้องครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbUsername.Focus()
                Exit Sub
            End If

            GlobalVar.UserID = Usr.ID
            GlobalVar.UserTypeId = Usr.Type
            SetMenu(Usr.Type)
        Else
            MessageBox.Show("กรุณากรอก Username และ Password ด้วยครับ", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsername.Focus()
            Exit Sub
        End If
    End Sub
End Class