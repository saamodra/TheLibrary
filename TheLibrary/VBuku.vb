Imports System.Data.OleDb
Public Class VBuku
    Dim itemcoll(100) As String
    Sub TampilGrid()
        Str = "select * from tbl_buku"
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
            lv.SubItems.Add(dr.Item("stok").ToString())
        Loop
        cmd.Dispose()
        dr.Close()
    End Sub
    Private Sub VBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        ListView1.FullRowSelect = True
        TampilGrid()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = Me.ListView1.SelectedItems(0)
            Dim tgl_pinjam As DateTime = DateTime.Today
            Dim tgl_kembali As DateTime = tgl_pinjam.AddDays(My.Settings.Durasi)
            Dim row As String()
            row = New String() {lvi.SubItems(1).Text, lvi.SubItems(2).Text, My.Settings.Durasi & " Hari", tgl_pinjam.ToString("dd/MM/yyyy"), tgl_kembali.ToString("dd/MM/yyyy")}
            Peminjaman.Show()
            Peminjaman.DataGridView1.ColumnCount = 5
            Peminjaman.DataGridView1.Columns(0).Name = "ID Buku"
            Peminjaman.DataGridView1.Columns(1).Name = "Judul"
            Peminjaman.DataGridView1.Columns(2).Name = "Durasi"
            Peminjaman.DataGridView1.Columns(3).Name = "Tgl Pinjam"
            Peminjaman.DataGridView1.Columns(4).Name = "Tgl Kembali"
            Peminjaman.DataGridView1.Columns(0).Width = 80
            Peminjaman.DataGridView1.Columns(1).Width = 400
            If Peminjaman.DataGridView1.RowCount > 2 Then
                MsgBox("Hanya boleh meminjam 2 Buku")
            Else
                Peminjaman.DataGridView1.Rows.Add(row)
            End If
            Me.Close()
        Else
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim Str As String
            Str = "select * from tbl_buku where id_buku like '%" & TextBox1.Text & "%' or judul like '%" & TextBox1.Text & "%' or pengarang like '%" & TextBox1.Text & "%' or penerbit like '%" & TextBox1.Text & "%' or tahun like '%" & TextBox1.Text & "%'"
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
                lv.SubItems.Add(dr.Item("stok").ToString())
            Loop
            cmd.Dispose()
            dr.Close()
        End If
    End Sub
End Class