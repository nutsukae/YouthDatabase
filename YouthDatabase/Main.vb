Imports System.Windows.Forms

Public Class Main

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        SetLoginState()
    End Sub

    Private Sub SetLoginState()
        ConsultMenu.Visible = False
        ProbationMenu.Visible = False
        ReportMenu.Visible = False

        Dim frm As New login()
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub mnuNewPerson_Click(sender As Object, e As EventArgs) Handles mnuNewPerson.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If

        Dim frm = New Person
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub mnuNewCase_Click(sender As Object, e As EventArgs) Handles mnuNewCase.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If

        Dim frm = New Lawsuit
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub mnuAddActivity_Click(sender As Object, e As EventArgs) Handles mnuAddActivity.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If

        Dim frm = New Act_Info
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub mnuConsult_Click(sender As Object, e As EventArgs) Handles mnuConsult.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If

        Dim frm = New AdviceCenter
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub mnuTreatment_Click(sender As Object, e As EventArgs) Handles mnuTreatment.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If

        Dim frm = New Treatment_Info
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
