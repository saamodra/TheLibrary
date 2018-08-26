Imports System.Data.OleDb
Public Class VAnggota
    Dim itemcoll(100) As String
    Sub TampilGrid()
        Str = "select * from tbl_anggota"
        Dim cmd As New OleDb.OleDbCommand(Str, conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add("")
            For i As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Text = (i + 1).ToString & "."
            Next
            lv.SubItems.Add(dr.Item("id_anggota").ToString())
            lv.SubItems.Add(dr.Item("nama").ToString())
            lv.SubItems.Add(dr.Item("alamat").ToString())
            lv.SubItems.Add(dr.Item("telepon").ToString())
        Loop
        CMD.Dispose()
        dr.Close()
    End Sub
    Private Sub VAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Peminjaman.Show()
            Peminjaman.TextBox1.Text = lvi.SubItems(1).Text
            Peminjaman.TextBox1.ReadOnly = True
            Me.Close()
        Else
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim Str As String
            Str = "select * from tbl_anggota where id_anggota like '%" & TextBox1.Text & "%' or nama like '%" & TextBox1.Text & "%' or alamat like '%" & TextBox1.Text & "%'"
            Dim cmd As New OleDb.OleDbCommand(Str, conn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            ListView1.Items.Clear()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add("")
                For i As Integer = 0 To ListView1.Items.Count - 1
                    ListView1.Items(i).Text = (i + 1).ToString & "."
                Next
                lv.SubItems.Add(dr.Item("id_anggota").ToString())
                lv.SubItems.Add(dr.Item("nama").ToString())
                lv.SubItems.Add(dr.Item("alamat").ToString())
                lv.SubItems.Add(dr.Item("telepon").ToString())
            Loop
            cmd.Dispose()
            dr.Close()
        End If
    End Sub
End Class