Imports System.Data.OleDb
Public Class LaporanAnggota
    Sub TampilGrid()
        Dim Str As String = "SELECT a.id_anggota, a.nama, a.jenis_kelamin, a.alamat, a.telepon, a.rating_pinjam, COUNT(t.id_buku) as rating_buku, MAX(t.tgl_pinjam) as terakhir_pinjam, MAX(t.dikembalikan_tgl) as terakhir_kembali
FROM tbl_transaksi t RIGHT JOIN tbl_anggota a
ON t.id_anggota = a.id_anggota
GROUP BY a.id_anggota, a.nama, a.jenis_kelamin, a.alamat, a.telepon, a.rating_pinjam"
        Dim Str2 As String = "select tbl_transaksi.id_anggota, Max(tbl_transaksi.tgl_pinjam), Max(tbl_transaksi.dikembalikan_tgl) FROM tbl_transaksi GROUP BY [id_anggota]"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim cmd2 As New OleDb.OleDbCommand(Str2, conn)
        Dim dr, dr2 As OleDbDataReader
        dr = cmd.ExecuteReader()
        dr2 = cmd2.ExecuteReader()
        ListView1.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add("")
            For i As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Text = (i + 1).ToString & "."
            Next
            lv.SubItems.Add(dr.Item("id_anggota").ToString())
            lv.SubItems.Add(dr.Item("nama").ToString())
            lv.SubItems.Add(dr.Item("jenis_kelamin").ToString())
            lv.SubItems.Add(dr.Item("alamat").ToString())
            lv.SubItems.Add(dr.Item("telepon").ToString())
            lv.SubItems.Add(dr.Item("rating_pinjam") & " Kali Pinjam")
            lv.SubItems.Add(dr.Item("rating_buku") & " Buku")
            If Not dr.IsDBNull(7) Then
                lv.SubItems.Add(Format(dr.Item(7), "dd/MM/yyyy"))
            End If
            If Not dr.IsDBNull(8) Then
                lv.SubItems.Add(Format(dr.Item(8), "dd/MM/yyyy"))
            End If
        Loop
        cmd.Dispose()
        dr.Close()
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub LaporanAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        ListView1.FullRowSelect = True
        TampilGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilGrid()
    End Sub


End Class