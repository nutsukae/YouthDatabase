Public Class rptTime
    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click

        Dim StartDate As Date = CDate(dtpStartDate.Text)
        Dim StopDate As Date = CDate(dtpStopDate.Text)

        If rptRep1.Checked Then
            Using frm = New Rep1(StartDate, StopDate)
                frm.Show()
            End Using
        ElseIf rptRep2.Checked Then
            Using frm = New Rep2(StartDate, StopDate)
                frm.Show()
            End Using
        End If
    End Sub
End Class