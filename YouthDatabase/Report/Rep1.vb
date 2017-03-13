Imports System.Configuration.ConfigurationManager
'Imports System.Globalization
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Data.SqlClient
Imports ntbjc
Public Class Rep1
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _StartDate As String = ""
    Private _StopDate As String = ""

    Public Sub New()
        InitializeComponent()
        Me._Constr = ConnectionStrings("Connection").ToString
    End Sub

    Public Sub New(ByVal StartDate As String, ByVal StopDate As String)
        InitializeComponent()
        Me._Constr = ConnectionStrings("Connection").ToString
        _StartDate = StartDate
        _StopDate = StopDate
        List(_StartDate, _StopDate)
    End Sub
    Private Sub copyAlltoClipboard()
        'dgvYouthList.SelectAll()
        dgvYouthList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dgvYouthList.SelectAll()
        Dim dataObj = dgvYouthList.GetClipboardContent()
        If dataObj IsNot Nothing Then
            Clipboard.SetDataObject(dataObj)
        End If

    End Sub

    Private Sub ReleasedObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occurred while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub List(ByVal StartDate As String, ByVal StopDate As String)

        Dim ds = New DataSet
        Dim conn = New SqlConnection(_Constr)
        Dim command As New SqlCommand()
        Dim adapter As New SqlDataAdapter(command)

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            command.Connection = conn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Rep2"
            command.Parameters.Add("@START", SqlDbType.Date).Value = CDate(StartDate)
            command.Parameters.Add("@STOP", SqlDbType.Date).Value = CDate(StopDate)
            adapter.Fill(ds)
        Catch ex As Exception
            adapter = Nothing
            command = Nothing
            conn = Nothing
        End Try

        If Not ds Is Nothing Then
            dgvYouthList.Rows.Clear()

            For Each row As DataRow In ds.Tables(0).Rows
                Dim fullname = row("fullname").ToString
                Dim idcard = row("idcard").ToString
                Dim caseno = row("caseno").ToString
                Dim blackno = row("blackno").ToString
                Dim redno = row("redno").ToString
                Dim title = row("title").ToString
                Dim AstName = row("astname").ToString
                dgvYouthList.Rows.Add(dgvYouthList.Rows.Count + 1, fullname, idcard, caseno, blackno, redno, title, AstName)
            Next
        End If

        Dim sfd = New SaveFileDialog()
        sfd.Filter = "Excel Documents (*.xls)|*.xls"
        sfd.FileName = "รายงานนัดสอบคำให้การของศูนย์ให้คำปรึกษา.xls"

        If sfd.ShowDialog = DialogResult.OK Then
            copyAlltoClipboard()

            Dim misValue = System.Reflection.Missing.Value
            Dim xlExcel = New Excel.Application

            xlExcel.DisplayAlerts = False
            Dim xlWorkbook As Excel.Workbook = xlExcel.Workbooks.Add(misValue)
            Dim xlWorksheet As Excel.Worksheet = TryCast(xlWorkbook.Worksheets.Item(1), Excel.Worksheet)

            Dim CR As Excel.Range = TryCast(xlWorksheet.Cells(1, 1), Excel.Range)
            CR.Select()
            xlWorksheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)

            Dim DelRng As Excel.Range = xlWorksheet.Range("A:A").Cells
            DelRng.Delete(Type.Missing)
            xlWorksheet.Range("A1").Select()

            xlWorkbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue)
            xlExcel.DisplayAlerts = True
            xlWorkbook.Close(True, misValue, misValue)
            xlExcel.Quit()


            ReleasedObject(xlWorksheet)
            ReleasedObject(xlWorkbook)
            ReleasedObject(xlExcel)

            Clipboard.Clear()
            dgvYouthList.ClearSelection()

            If File.Exists(sfd.FileName) Then
                System.Diagnostics.Process.Start(sfd.FileName)
            End If
        End If


    End Sub
End Class