Imports System.Data.OleDb
Public Class DataTransaksi
    Dim listitem As ListViewItem
    Dim i, j, denda, terlambat As Integer
    Dim tgl_now = DateTime.Now
    Sub TampilGrid()
        Dim Str As String = "select * from tbl_transaksi where status = 'Pinjam'"
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
            Dim lv As ListViewItem = ListView1.Items.Add("")
            For i As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Text = (i + 1).ToString & "."
            Next
            lv.SubItems.Add(dr.Item("id_transaksi").ToString())
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
    Private Sub DataTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        ListView1.FullRowSelect = True
        TampilGrid()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim Str As String
            If TextBox1.Text = "" Then
                Str = "Select * from tbl_transaksi where status = 'Pinjam'"
            Else
                Str = "select * from tbl_transaksi where id_anggota like '%" & TextBox1.Text & "%' or id_transaksi like '%" & TextBox1.Text & "%' or judul like '%" & TextBox1.Text & "%' or nama like '%" & TextBox1.Text & "%' or id_buku like '%" & TextBox1.Text & "%'"
            End If
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
                Dim lv As ListViewItem = ListView1.Items.Add("")
                For i As Integer = 0 To ListView1.Items.Count - 1
                    ListView1.Items(i).Text = (i + 1).ToString & "."
                Next
                lv.SubItems.Add(dr.Item("id_transaksi").ToString())
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
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            cmd.Dispose()
            dr.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class