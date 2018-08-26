Imports System.Data.OleDb
Public Class VBuku2
    Sub TampilGrid()
        Dim Str As String = "select * from tbl_transaksi where id_anggota = '" & Pengembalian.txtID.Text & "' and status = 'Pinjam'"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr.Item("id_buku").ToString())
            lv.SubItems.Add(dr.Item("judul").ToString())
        Loop
        cmd.Dispose()
        dr.Close()
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub VBuku2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        ListView1.FullRowSelect = True
        TampilGrid()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = ListView1.SelectedItems(0)
            Pengembalian.TextBox2.Text = lvi.SubItems(0).Text
            Me.Close()
        Else
        End If
    End Sub
End Class