Imports System.Configuration.ConfigurationManager
'Imports System.Globalization
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports ntbjc
Public Class rptActPer
    Private _Constr As String = ConnectionStrings("Connection").ConnectionString
    Private _ActId As Integer = -1
    Private _UserID As Integer = -1
    Private _UserTypeId As Integer = -1
    Public Sub New()
        InitializeComponent()
        Me._UserID = GlobalVar.UserID
        Me._UserTypeId = GlobalVar.UserTypeId
        Me._Constr = ConnectionStrings("Connection").ToString

        Using frm = New SearchActivity()
            Dim result = frm.ShowDialog()
            If result = DialogResult.OK Then
                _ActId = frm.ActivityId

                ListActivityPersonDetail(_ActId)
            End If
        End Using
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
    Private Sub ListActivityPersonDetail(ByVal ActivityID As Integer)
        Dim _Act = New Activity(_Constr)
        Dim ds = New DataSet

        ds = _Act.ListYouth(_ActId, _UserTypeId)

        If Not ds Is Nothing Then
            dgvYouthList.Rows.Clear()

            For Each row As DataRow In ds.Tables(0).Rows
                Dim ap_id = CInt(row("id"))
                Dim ref = row("ref").ToString
                Dim idcard = row("idcard").ToString
                Dim fullname = row("fullname").ToString
                'Dim caseno = row("caseno").ToString 
                Dim blackno = row("blackno").ToString
                Dim title = row("title").ToString
                Dim mobile = row("mobile").ToString
                Dim address = row("address").ToString
                Dim sex = row("sex").ToString
                Dim religion = row("religion").ToString
                Dim shirt_size = row("shirt_size").ToString
                Dim shoe_size = row("shoe_size").ToString
                Dim status = row("status").ToString
                Dim remark = row("remark").ToString
                dgvYouthList.Rows.Add(ap_id, dgvYouthList.Rows.Count + 1, ref, idcard, fullname, blackno, title, mobile, address, sex, religion, shirt_size, shoe_size, status, remark)
            Next
        End If

        Dim sfd = New SaveFileDialog()
        sfd.Filter = "Excel Documents (*.xls)|*.xls"
        sfd.FileName = "test.xls"

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