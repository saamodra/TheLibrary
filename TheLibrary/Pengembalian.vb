Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Pengembalian
    Dim listitem As ListViewItem
    Dim i, j, denda, terlambat As Integer
    Dim tgl_now = DateTime.Now
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Sub clearanggota()
        txtID.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTlp.Text = ""
        TextBox1.Text = ""
        txtTanggungan.Text = ""
        TextBox1.ReadOnly = False
        ListView1.Items.Clear()
    End Sub
    Sub baru()
        clearanggota()
        DataGridView1.Rows.Clear()
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VAnggota2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clearanggota()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Str As String
        Str = "Select * from tbl_anggota"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            If TextBox1.Text = dr.Item("id_anggota").ToString() Then
                Konfirmasi2.Show()
                Konfirmasi2.Label1.Text = "ID Anggota"
                Konfirmasi2.Label2.Text = "Nama"
                Konfirmasi2.Label5.Text = dr.Item("id_anggota").ToString()
                Konfirmasi2.Label6.Text = dr.Item("nama").ToString()
            End If
        Loop
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim Str As String
        Str = "Select * from tbl_transaksi where id_anggota = '" & txtID.Text & "' and status = 'Pinjam'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            If TextBox2.Text = dr.Item("id_buku").ToString() Then
                KonfirmasiBuku2.Show()
                KonfirmasiBuku2.Label1.Text = "ID Buku"
                KonfirmasiBuku2.Label2.Text = "Judul"
                KonfirmasiBuku2.Label5.Text = dr.Item("id_buku").ToString()
                KonfirmasiBuku2.Label6.Text = dr.Item("judul").ToString()
            End If
        Loop
    End Sub

    Sub TampilGrid()
        Dim Str As String = "Select * from tbl_transaksi where status = 'Pinjam'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        Do While dr.Read()
            If tgl_now > dr.Item("tgl_kembali") Then
                denda = DateDiff(DateInterval.Day, dr.Item("tgl_kembali"), Today()) * 500
                terlambat = DateDiff(DateInterval.Day, dr.Item("tgl_kembali"), Today())
            Else
                denda = 0
                terlambat = 0
            End If
            Dim lv As ListViewItem = ListView1.Items.Add(dr.Item("id_transaksi").ToString())
            lv.SubItems.Add(dr.Item("id_anggota").ToString())
            lv.SubItems.Add(dr.Item("nama").ToString())
            lv.SubItems.Add(dr.Item("id_buku").ToString())
            lv.SubItems.Add(dr.Item("judul").ToString())
            lv.SubItems.Add("3 Hari")
            lv.SubItems.Add(Format(dr.Item("tgl_pinjam"), "dd/MM/yyyy"))
            lv.SubItems.Add(Format(dr.Item("tgl_kembali"), "dd/MM/yyyy"))
            lv.SubItems.Add(terlambat & " Hari")
            lv.SubItems.Add(denda)
            lv.SubItems.Add(dr.Item("status").ToString())
        Loop
        cmd.Dispose()
        dr.Close()
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        TextBox3.Text = 0
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VBuku2.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        DataGridView1.ColumnHeadersVisible = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.RowCount > 0 Then
            Dim cmd2, cmd3 As OleDbCommand
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                CMD = New OleDbCommand("UPDATE [tbl_transaksi] SET [status] = 'Kembali', [dikembalikan_tgl] = '" & DateString & "' WHERE [id_anggota] = '" & txtID.Text & "' and [id_buku] = @1", conn)
                With CMD
                    .Parameters.AddWithValue("@1", DataGridView1.Item(0, i).Value)
                    .ExecuteNonQuery()
                End With
                cmd2 = New OleDbCommand("UPDATE [tbl_buku] SET [stok] = (stok+1) where [id_buku] = '" & DataGridView1.Item(0, i).Value & "'", conn)
                cmd2.ExecuteNonQuery()
            Next
            If TextBox3.Text = 0 Then
            Else
                Dim id As String = Format(Now, "ddMMyyyyhhmmss")
                cmd3 = New OleDbCommand("INSERT INTO tbl_kas VALUES ('IN-" & id & "','" & DateString & "','" & TextBox3.Text & "','0','Denda Buku (" & txtID.Text & ")','" & Form1.ToolStripStatusLabel4.Text & "')", conn)
                cmd3.ExecuteNonQuery()
            End If
            MsgBox("Transaksi Berhasil Disimpan", MsgBoxStyle.Information, "Berhasil")
            If MessageBox.Show("Cetak?", "Cetak Struk", MessageBoxButtons.YesNo) = vbYes Then
                PrintDocument1.Print()
            End If
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        Else
                MsgBox("Pilih buku yang akan dikembalikan terlebih dahulu!")
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        baru()
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = ListView1.SelectedItems(0)
            TextBox2.Text = lvi.SubItems(0).Text
        Else
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim tinggi As Integer
        Dim point1 As Point
        Dim point2 As Point
        Dim bayar, kembali As Integer
        e.Graphics.DrawString(My.Settings.Nama_Perpustakaan, New Drawing.Font("Arial", 9), Brushes.Black, 10, 25)
        e.Graphics.DrawString(My.Settings.Alamat, New Drawing.Font("Arial", 9), Brushes.Black, 10, 25 + 15)
        e.Graphics.DrawString(My.Settings.Telp, New Drawing.Font("Arial", 9), Brushes.Black, 10, 25 + 30)
        e.Graphics.DrawString("----------------------------------------------------------------", New Drawing.Font("Arial", 10), Brushes.Black, 10, 25 + 50)
        e.Graphics.DrawString("Pengembalian Buku", New Drawing.Font("Arial", 10), Brushes.Black, 10, 25 + 70)
        e.Graphics.DrawString(Format(DateTime.Today(), "dd/MM/yyyy"), New Drawing.Font("Arial", 10), Brushes.Black, 240, 25 + 70)
        e.Graphics.DrawString("Nama : ", New Drawing.Font("Arial", 8), Brushes.Black, 10, 45 + 70)
        e.Graphics.DrawString(txtNama.Text, New Drawing.Font("Arial", 8), Brushes.Black, 60, 45 + 70)
        point1 = New Point(10, 77 + 70)
        point2 = New Point(310, 77 + 70)
        e.Graphics.DrawLine(Pens.Black, point1, point2)
        tinggi = 80
        e.Graphics.DrawString("Judul", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 70)
        e.Graphics.DrawString("Terlambat", New Drawing.Font("Arial", 8), Brushes.Black, 180, tinggi + 70)
        e.Graphics.DrawString("Denda", New Drawing.Font("Arial", 8), Brushes.Black, 260, tinggi + 70)
        point1 = New Point(10, tinggi + 15 + 70)
        point2 = New Point(310, tinggi + 15 + 70)
        e.Graphics.DrawLine(Pens.Black, point1, point2)
        tinggi = 110

        For baris As Integer = 0 To DataGridView1.RowCount - 1

            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 70)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(4).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 180, tinggi + 70)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(5).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 260, tinggi + 70)

            tinggi = tinggi + 15
        Next
        point1 = New Point(10, tinggi + 15 + 70)
        point2 = New Point(310, tinggi + 15 + 70)
        e.Graphics.DrawLine(Pens.Black, point1, point2)
        If TextBox4.Text = "" Then
            bayar = 0
        Else
            bayar = TextBox4.Text
        End If

        If TextBox5.Text = "" Then
            kembali = 0
        Else
            kembali = TextBox5.Text
        End If
        e.Graphics.DrawString("Total Denda", New Drawing.Font("Arial", 8), Brushes.Black, 160, tinggi + 30 + 70)
        e.Graphics.DrawString("= Rp. " & TextBox3.Text, New Drawing.Font("Arial", 8), Brushes.Black, 230, tinggi + 30 + 70)
        e.Graphics.DrawString("Bayar", New Drawing.Font("Arial", 8), Brushes.Black, 160, tinggi + 45 + 70)
        e.Graphics.DrawString("= Rp. " & bayar, New Drawing.Font("Arial", 8), Brushes.Black, 230, tinggi + 45 + 70)
        e.Graphics.DrawString("Kembali", New Drawing.Font("Arial", 8), Brushes.Black, 160, tinggi + 60 + 70)
        e.Graphics.DrawString("= Rp. " & kembali, New Drawing.Font("Arial", 8), Brushes.Black, 230, tinggi + 60 + 70)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        DataGridView1.Rows.Clear()
        TextBox3.Text = 0
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        If DataGridView1.RowCount > 1 Then
            Dim Denda As Integer = 0
            For index As Integer = 0 To DataGridView1.RowCount - 1
                Denda += Convert.ToInt32(DataGridView1.Rows(index).Cells(5).Value)
            Next
            TextBox3.Text = Denda
        Else
            TextBox3.Text = DataGridView1.Rows(0).Cells(5).Value
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim denda, bayar As Integer
            denda = CInt(TextBox3.Text)
            bayar = CInt(TextBox4.Text)
            If bayar < denda Then
                MsgBox("Transaksi Gagal", MsgBoxStyle.Critical, "Gagal")
            Else
                TextBox5.Text = TextBox4.Text - TextBox3.Text
                Dim result1 As DialogResult = MessageBox.Show("Simpan Transaksi?", "Transaksi", MessageBoxButtons.YesNo)
                If result1 = DialogResult.Yes Then
                    Button4.PerformClick()
                Else
                End If
                'If MessageBox.Show("Simpan Transaksi?", "Transaksi", MessageBoxButtons.YesNo) = vbYes Then

                'End If
            End If
        End If
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        mRow = 0
        newpage = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
    End Sub

End Class