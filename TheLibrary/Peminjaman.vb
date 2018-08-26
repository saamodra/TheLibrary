Imports System.Data.OleDb
Public Class Peminjaman
    Sub otomatis()
        Dim oto As String = Format(Now, "yyMMddhhmmss")
        TextBox3.Text = oto
    End Sub
    Sub baru()
        otomatis()
        TextBox1.Text = ""
        txtID.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTlp.Text = ""
        txtTanggungan.Text = ""
        DataGridView1.Columns.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VAnggota.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Str As String
        Str = "select * from tbl_anggota"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            If TextBox1.Text = dr.Item("id_anggota").ToString() Then
                Konfirmasi.Show()
                Konfirmasi.Label1.Text = "ID Anggota"
                Konfirmasi.Label2.Text = "Nama"
                Konfirmasi.Label5.Text = dr.Item("id_anggota").ToString()
                Konfirmasi.Label6.Text = dr.Item("nama").ToString()
            End If
        Loop
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim Str As String
        Str = "select * from tbl_buku"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            If TextBox2.Text = dr.Item("id_buku").ToString() Then
                KonfirmasiBuku.Show()
                KonfirmasiBuku.Label1.Text = "ID Buku"
                KonfirmasiBuku.Label2.Text = "Judul"
                KonfirmasiBuku.Label5.Text = dr.Item("id_buku").ToString()
                KonfirmasiBuku.Label6.Text = dr.Item("judul").ToString()
            End If
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VBuku.Show()
    End Sub

    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        otomatis()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtID.Text = "" Then
            MsgBox("Mohon Pilih Anggota terlebih dahulu!")
        ElseIf DataGridView1.RowCount = 0 Then
            MsgBox("Pilih buku yang akan dipinjam!")
        Else
            Dim cmd2, cmd3 As OleDbCommand
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                CMD = New OleDbCommand("INSERT INTO tbl_transaksi ([id_transaksi], [id_buku], [judul], [id_anggota], [nama], [tgl_pinjam], [tgl_kembali], [status]) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)", conn)
                With CMD
                    .Parameters.AddWithValue("@1", TextBox3.Text)
                    .Parameters.AddWithValue("@2", DataGridView1.Item(0, i).Value)
                    .Parameters.AddWithValue("@3", DataGridView1.Item(1, i).Value)
                    .Parameters.AddWithValue("@4", txtID.Text)
                    .Parameters.AddWithValue("@5", txtNama.Text)
                    .Parameters.AddWithValue("@6", DataGridView1.Item(3, i).Value)
                    .Parameters.AddWithValue("@7", DataGridView1.Item(4, i).Value)
                    .Parameters.AddWithValue("@8", "Pinjam")
                    .ExecuteNonQuery()
                End With
                cmd2 = New OleDbCommand("UPDATE [tbl_buku] SET [stok] = (stok-1) where [id_buku] = '" & DataGridView1.Item(0, i).Value & "'", conn)
                cmd2.ExecuteNonQuery()
            Next
            cmd3 = New OleDbCommand("UPDATE [tbl_anggota] SET [rating_pinjam] = (rating_pinjam+1), [rating_buku] = (rating_pinjam+" & DataGridView1.RowCount & ") WHERE [id_anggota] = '" & txtID.Text & "'", conn)
            cmd3.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Berhasil")
            If MsgBox("Cetak Struk?", MsgBoxStyle.YesNo, "Cetak") = MsgBoxResult.Yes Then
                Button4.PerformClick()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        baru()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        txtID.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTlp.Text = ""
        txtTanggungan.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim tinggi As Integer
        Dim point1 As Point
        Dim point2 As Point
        e.Graphics.DrawString(My.Settings.Nama_Perpustakaan, New Drawing.Font("Arial", 9), Brushes.Black, 10, 25)
        e.Graphics.DrawString(My.Settings.Alamat, New Drawing.Font("Arial", 9), Brushes.Black, 10, 25 + 15)
        e.Graphics.DrawString(My.Settings.Telp, New Drawing.Font("Arial", 9), Brushes.Black, 10, 25 + 30)
        e.Graphics.DrawString("----------------------------------------------------------------", New Drawing.Font("Arial", 10), Brushes.Black, 10, 25 + 50)
        e.Graphics.DrawString("Peminjaman Buku", New Drawing.Font("Arial", 10), Brushes.Black, 10, 25 + 70)
        e.Graphics.DrawString(Format(DateTime.Today(), "dd/MM/yyyy"), New Drawing.Font("Arial", 10), Brushes.Black, 240, 25 + 70)
        e.Graphics.DrawString("Nama : ", New Drawing.Font("Arial", 8), Brushes.Black, 10, 45 + 70)
        e.Graphics.DrawString(txtNama.Text, New Drawing.Font("Arial", 8), Brushes.Black, 60, 45 + 70)
        point1 = New Point(10, 77 + 70)
        point2 = New Point(310, 77 + 70)
        e.Graphics.DrawLine(Pens.Black, point1, point2)
        tinggi = 80
        e.Graphics.DrawString("Judul", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 70)
        e.Graphics.DrawString("Tgl. Kembali", New Drawing.Font("Arial", 8), Brushes.Black, 230, tinggi + 70)
        point1 = New Point(10, tinggi + 15 + 70)
        point2 = New Point(310, tinggi + 15 + 70)
        e.Graphics.DrawLine(Pens.Black, point1, point2)
        tinggi = 110

        For baris As Integer = 0 To DataGridView1.RowCount - 1

            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 70)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(4).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 230, tinggi + 70)

            tinggi = tinggi + 15
        Next
        point1 = New Point(10, tinggi + 15 + 70)
        point2 = New Point(310, tinggi + 15 + 70)
        e.Graphics.DrawLine(Pens.Black, point1, point2)

    End Sub

End Class