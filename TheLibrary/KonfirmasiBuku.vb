Imports System.Data.OleDb
Public Class KonfirmasiBuku
    Private Sub KonfirmasiBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String
        Str = "select * from tbl_buku where id_buku = '" & Label5.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        Dim tgl_pinjam As DateTime = DateTime.Today
        Dim tgl_kembali As DateTime = tgl_pinjam.AddDays(3)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.Item("stok") = 0 Then
            MsgBox("Stok buku habis!", MsgBoxStyle.Critical, "Stok Habis")
        Else
            Dim row As String()
            row = New String() {dr.Item("id_buku").ToString(), dr.Item("judul").ToString(), "3 Hari", tgl_pinjam.ToString("dd/MM/yyyy").ToString(), tgl_kembali.ToString("dd/MM/yyyy")}
            Peminjaman.Show()
            Peminjaman.DataGridView1.ColumnCount = 5
            Peminjaman.DataGridView1.Columns(0).Name = "ID Buku"
            Peminjaman.DataGridView1.Columns(1).Name = "Judul"
            Peminjaman.DataGridView1.Columns(2).Name = "Durasi"
            Peminjaman.DataGridView1.Columns(3).Name = "Tgl Pinjam"
            Peminjaman.DataGridView1.Columns(4).Name = "Tgl Kembali"
            Peminjaman.DataGridView1.Columns(0).Width = 80
            Peminjaman.DataGridView1.Columns(1).Width = 400
            Peminjaman.DataGridView1.Rows.Add(row)
            Me.Close()
        End If
    End Sub
End Class