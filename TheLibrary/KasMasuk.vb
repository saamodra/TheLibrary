Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class KasMasuk
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    Private pages As Dictionary(Of Integer, pageDetails)
    Dim tgl_mulai As DateTime = DateTime.Today
    Sub TampilGrid()
        Dim Str As String = "select * from [tbl_kas] where [tanggal] between #" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Year & "# and #" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Year & "# and [pengeluaran] = '0'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read()
            Dim row As String()
            Dim i As Integer = 0

            row = New String() {dr.Item("id").ToString(), Format(dr.Item("tanggal"), "dd/MM/yyyy"), FormatCurrency(dr.Item("pemasukan")), dr.Item("keterangan").ToString(), dr.Item("operator").ToString()}
            DataGridView1.ColumnCount = 5
            DataGridView1.Columns(0).Name = "ID"
            DataGridView1.Columns(1).Name = "Tanggal"
            DataGridView1.Columns(2).Name = "Pemasukan"
            DataGridView1.Columns(3).Name = "Keterangan"
            DataGridView1.Columns(4).Name = "Operator"
            DataGridView1.Columns(0).Width = 140
            DataGridView1.Columns(1).Width = 80
            DataGridView1.Columns(2).Width = 130
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(4).Width = 80
            DataGridView1.Columns(4).Resizable = DataGridViewTriState.False
            DataGridView1.Columns(0).Resizable = DataGridViewTriState.False
            DataGridView1.Columns(1).Resizable = DataGridViewTriState.False
            DataGridView1.Rows.Add(row)
        Loop
        cmd.Dispose()
        dr.Close()
    End Sub
    Sub cultureInfo()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("id-ID")
    End Sub
    Sub Total()
        Dim Str As String = "SELECT SUM(pemasukan) FROM tbl_kas WHERE [tanggal] between #" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Year & "# and #" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Year & "#"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        RD = cmd.ExecuteReader()
        RD.Read()
        If IsDBNull(RD.Item(0)) Then
            Label5.Text = "Rp. 0"
        Else
            Label5.Text = FormatCurrency(RD.Item(0))
        End If
    End Sub
    Private Sub KasMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = tgl_mulai.AddDays(-5)
        DateTimePicker2.Value = Format(DateAdd(DateInterval.Month, 1, DateTimePicker1.Value))
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        cultureInfo()
        TampilGrid()

        Total()
    End Sub
    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim textsize As Size = TextRenderer.MeasureText(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture), DataGridView1.DefaultCellStyle.Font)
        If e.RowIndex < DataGridView1.Rows.Count Then
            Using b As SolidBrush = New SolidBrush(DataGridView1.RowHeadersDefaultCellStyle.ForeColor)
                e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture),
                DataGridView1.DefaultCellStyle.Font,
                b,
                e.RowBounds.Location.X + DataGridView1.RowHeadersWidth - textsize.Width,
                e.RowBounds.Location.Y + DataGridView1.Rows(e.RowIndex).Height - textsize.Height)
            End Using
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged
        TampilGrid()
        Total()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), 50)
        Dim sf As New StringFormat(StringFormatFlags.LineLimit)
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        sf.Trimming = StringTrimming.EllipsisCharacter
        e.Graphics.DrawString("Laporan Kas Masuk", New Font("Arial", 20), Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)
            e.Graphics.DrawString("No.", DataGridView1.Font, Brushes.Black, cell, sf)

            startY += DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows
                cell = New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.Rows(r).Height)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(r + 1, DataGridView1.Font, Brushes.Black, cell, sf)
                startY += DataGridView1.Rows(r).Height
            Next
            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(DataGridView1.Columns(c).HeaderCell.Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                startX += DataGridView1.Columns(c).Width
            Next

            startY = rect.Bottom + DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows
                startX = 50 + DataGridView1.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(DataGridView1(c, r).Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                    startX += DataGridView1.Columns(c).Width
                Next
                startY += DataGridView1.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If
            e.Graphics.DrawString("Total Kas Masuk = " & Label5.Text, New Font("Arial", 13), Brushes.Black, 500, startY + 20)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40 + Label1.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = DataGridView1.RowHeadersWidth

        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            If columnSum + DataGridView1.Columns(c).Width < maxWidth Then
                columnSum += DataGridView1.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = DataGridView1.RowHeadersWidth + DataGridView1.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = DataGridView1.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = DataGridView1.ColumnHeadersHeight

        For r As Integer = 0 To DataGridView1.Rows.Count - 2
            If rowSum + DataGridView1.Rows(r).Height < maxHeight Then
                rowSum += DataGridView1.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows(r).Height
                rowCounter = 1
            End If
            If r = DataGridView1.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class