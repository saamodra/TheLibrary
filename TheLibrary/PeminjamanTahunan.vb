Imports System.Data.OleDb
Public Class PeminjamanTahunan
    Private Sub PeminjamanTahunan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilGrid()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub TampilGrid()
        Dim Str As String = "select * from [tbl_transaksi] where format(tgl_pinjam, 'yyyy') = '" & Format(DateTimePicker1.Value, "yyyy") & "'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read()
            Dim row As String()
            Dim i As Integer = 0
            row = New String() {dr.Item("id_transaksi").ToString(), dr.Item("id_anggota").ToString(), dr.Item("nama").ToString(), dr.Item("id_buku").ToString(), dr.Item("judul").ToString(), Format(dr.Item("tgl_kembali"), "dd/MM/yyyy")}
            DataGridView1.ColumnCount = 6
            DataGridView1.Columns(0).Name = "ID Transaksi"
            DataGridView1.Columns(1).Name = "ID Anggota"
            DataGridView1.Columns(2).Name = "Nama"
            DataGridView1.Columns(3).Name = "ID Buku"
            DataGridView1.Columns(4).Name = "Judul"
            DataGridView1.Columns(5).Name = "Terakhir Kembali"
            DataGridView1.Columns(0).Width = 120
            DataGridView1.Columns(1).Width = 110
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(5).Width = 120
            DataGridView1.Rows.Add(row)
        Loop
        cmd.Dispose()
        dr.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TampilGrid()
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
End Class