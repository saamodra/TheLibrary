Imports System.Data.OleDb
Public Class LaporanBukuDipinjam
    Friend WithEvents prntDoc As New System.Drawing.Printing.PrintDocument
    Friend Print_Image As Image
    Declare Auto Function BitBlt Lib "GDI32.DLL" (
    ByVal hdcDest As IntPtr,
    ByVal nXDest As Integer,
    ByVal nYDest As Integer,
    ByVal nWidth As Integer,
    ByVal nHeight As Integer,
    ByVal hdcSrc As IntPtr,
    ByVal nXSrc As Integer,
    ByVal nYSrc As Integer,
    ByVal dwRop As Int32) As Boolean
    Sub TampilGrid()
        Dim Str As String = "SELECT b.id_buku, b.judul, b.pengarang, b.penerbit, b.tahun, COUNT(t.id_buku) as rating_buku
FROM tbl_buku b LEFT JOIN tbl_transaksi t
ON b.id_buku = t.id_buku
GROUP BY b.id_buku, b.judul, b.pengarang, b.penerbit, b.tahun ORDER BY COUNT(t.id_buku) DESC"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add("")
            For i As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Text = (i + 1).ToString & "."
            Next
            lv.SubItems.Add(dr.Item("id_buku").ToString())
            lv.SubItems.Add(dr.Item("judul").ToString())
            lv.SubItems.Add(dr.Item("pengarang").ToString())
            lv.SubItems.Add(dr.Item("penerbit").ToString())
            lv.SubItems.Add(dr.Item("tahun").ToString())
            lv.SubItems.Add(dr.Item("rating_buku") & " Kali dipinjam")
        Loop
        cmd.Dispose()
        dr.Close()
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub LaporanBukuDipinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        ListView1.FullRowSelect = True
        TampilGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MakeImage()
    End Sub
    Private Sub MakeImage()
        Dim prnDialog As New PrintDialog
        Application.DoEvents()
        Me.Refresh()
        Application.DoEvents()
        'Get a Graphics Object from the form
        Dim FormG As Graphics = ListView1.CreateGraphics
        'Create a bitmap from that graphics
        Dim i As New Bitmap(ListView1.Width, ListView1.Height, FormG)
        'Create a Graphics object in memory from that bitmap
        Dim memG As Graphics = Graphics.FromImage(i)
        'get the IntPtr's of the graphics
        Dim HDC1 As IntPtr = FormG.GetHdc
        Dim HDC2 As IntPtr = memG.GetHdc
        'get the picture
        BitBlt(HDC2, 0, 0, ListView1.ClientRectangle.Width, ListView1.ClientRectangle.Height, HDC1, 0, 0, 13369376)
        'Clone the bitmap so we can dispose this one
        Me.Print_Image = CType(i.Clone(), Image)
        'Clean Up
        FormG.ReleaseHdc(HDC1)
        memG.ReleaseHdc(HDC2)
        FormG.Dispose()
        memG.Dispose()
        i.Dispose()
        prnDialog.Document = prntDoc
        Dim r As DialogResult = prnDialog.ShowDialog
        If r = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Label1.Text, New Drawing.Font("Arial", 15), Brushes.Black, 20, 50)
        e.Graphics.DrawImage(Print_Image, 20, 90)
    End Sub
End Class