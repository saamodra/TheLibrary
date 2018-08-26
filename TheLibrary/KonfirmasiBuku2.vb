Imports System.Data.OleDb
Public Class KonfirmasiBuku2
    Dim listitem As ListViewItem
    Dim i, j, denda, terlambat As Integer
    Dim tgl_now = DateTime.Now
    Sub kembali()
        Dim Str As String = "select * from tbl_transaksi where id_buku = '" & Label5.Text & "' and id_anggota = '" & Pengembalian.txtID.Text & "' and status = 'Pinjam'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            If tgl_now > dr.Item("tgl_kembali") Then
                denda = DateDiff(DateInterval.Day, dr.Item("tgl_kembali"), Today()) * 500
                terlambat = DateDiff(DateInterval.Day, dr.Item("tgl_kembali"), Today())
            Else
                denda = 0
                terlambat = 0
            End If
            Dim row As String()
            row = New String() {dr.Item("id_buku").ToString(), dr.Item("judul").ToString(), Format(dr.Item("tgl_pinjam"), "dd/MM/yyyy"), Format(DateTime.Today(), "dd/MM/yyyy"), terlambat & " Hari", denda}
            Pengembalian.Show()
            Pengembalian.DataGridView1.ColumnCount = 6
            Pengembalian.DataGridView1.Columns(0).Name = "ID Buku"
            Pengembalian.DataGridView1.Columns(1).Name = "Judul"
            Pengembalian.DataGridView1.Columns(2).Name = "Tgl Pinjam"
            Pengembalian.DataGridView1.Columns(3).Name = "Tgl Kembali"
            Pengembalian.DataGridView1.Columns(4).Name = "Terlambat"
            Pengembalian.DataGridView1.Columns(5).Name = "Denda"
            Pengembalian.DataGridView1.Rows.Add(row)
            Me.Close()
        Loop
        cmd.Dispose()
        dr.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kembali()
        For Each listItem As ListViewItem In Pengembalian.ListView1.Items
            If listItem.Text = Label5.Text Then
                Pengembalian.ListView1.Items.Remove(listItem)
            End If
        Next
        Pengembalian.Show()
        Me.Close()
    End Sub

    Private Sub KonfirmasiBuku2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class