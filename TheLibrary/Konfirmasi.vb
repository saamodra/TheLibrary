Imports System.Data.OleDb
Public Class Konfirmasi
    Private Sub Konfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str, Str2 As String
        Str = "select * from tbl_anggota where id_anggota = '" & Label5.Text & "'"
        Str2 = "select count(*) from tbl_transaksi where id_anggota = '" & Label5.Text & "' and status = 'Pinjam'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim cmd2 As New OleDb.OleDbCommand(Str2, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        RD = cmd2.ExecuteReader()
        dr.Read()
        RD.Read()
        Peminjaman.Show()
        Peminjaman.txtID.Text = dr.Item("id_anggota").ToString()
        Peminjaman.txtNama.Text = dr.Item("nama").ToString()
        Peminjaman.txtAlamat.Text = dr.Item("alamat").ToString()
        Peminjaman.txtTlp.Text = dr.Item("telepon").ToString()
        Peminjaman.TextBox1.Text = dr.Item("id_anggota").ToString()
        Peminjaman.txtTanggungan.Text = RD.Item(0) & " Buku"
        Peminjaman.TextBox1.ReadOnly = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class