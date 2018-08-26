Imports System.Data.OleDb
Public Class Konfirmasi2
    Sub pinjam()
        Dim Str As String = "select * from tbl_transaksi where id_anggota = '" & Label5.Text & "' and status = 'Pinjam'"
        Dim Str2 As String = "select count(*) from tbl_transaksi where id_anggota = '" & Label5.Text & "' and status = 'Pinjam'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim cmd2 As New OleDb.OleDbCommand(Str2, conn)
        Dim dr, dr2 As OleDbDataReader
        dr = cmd.ExecuteReader()
        dr2 = cmd2.ExecuteReader()
        dr2.Read()
        Do While dr.Read()
            Dim lv As ListViewItem = Pengembalian.ListView1.Items.Add(dr.Item("id_buku").ToString())
            lv.SubItems.Add(dr.Item("judul").ToString())
        Loop
        Pengembalian.txtTanggungan.Text = dr2.Item(0) & " Buku"
        cmd.Dispose()
        dr.Close()
        Pengembalian.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Pengembalian.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub Konfirmasi2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String
        Str = "select * from tbl_anggota where id_anggota = '" & Label5.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        dr.Read()
        Pengembalian.ListView1.Items.Clear()
        Pengembalian.Show()
        Pengembalian.txtID.Text = dr.Item("id_anggota").ToString()
        Pengembalian.txtNama.Text = dr.Item("nama").ToString()
        Pengembalian.txtAlamat.Text = dr.Item("alamat").ToString()
        Pengembalian.txtTlp.Text = dr.Item("telepon").ToString()
        Pengembalian.TextBox1.Text = dr.Item("id_anggota").ToString()
        Pengembalian.TextBox1.ReadOnly = True
        pinjam()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class