Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Buku
    Sub TampilGrid()
        DA = New OleDbDataAdapter("select * from tbl_buku", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_buku")
        DataGridView1.DataSource = (DS.Tables("tbl_buku"))
        DataGridView1.Enabled = True
        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID Buku"
            .Columns(1).HeaderCell.Value = "Buku"
            .Columns(2).HeaderCell.Value = "Pengerang"
            .Columns(3).HeaderCell.Value = "Penerbit"
            .Columns(4).HeaderCell.Value = "Tahun"
            .Columns(5).HeaderCell.Value = "Stok"
            .Columns(5).HeaderCell.Value = "Rak"
        End With
    End Sub
    Sub id()
        CMD = New OleDbCommand("select * from tbl_buku order by id_buku desc", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            TextBox1.Text = "BK" + "0001"
        Else
            TextBox1.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_buku").ToString, 4, 3)) + 1
            If Len(TextBox1.Text) = 1 Then
                TextBox1.Text = "BK000" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 2 Then
                TextBox1.Text = "BK00" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 3 Then
                TextBox1.Text = "BK0" & TextBox1.Text & ""
            End If
        End If
    End Sub
    Sub KosongkanData()
        id()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
    Private Sub Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call id()
        Call TampilGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Dim simpan As String = "insert into tbl_buku values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
            SqlSimpan(simpan)
            TampilGrid()
            KosongkanData()
            TextBox2.Focus()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub isiTextBox()
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            TextBox1.Text = DataGridView1.Item(0, i).Value
            TextBox2.Text = DataGridView1.Item(1, i).Value
            TextBox3.Text = DataGridView1.Item(2, i).Value
            TextBox4.Text = DataGridView1.Item(3, i).Value
            TextBox5.Text = DataGridView1.Item(4, i).Value
            TextBox6.Text = DataGridView1.Item(5, i).Value
            TextBox7.Text = DataGridView1.Item(6, i).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        isiTextBox()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim edit As String = "update tbl_buku set [judul]='" & TextBox2.Text & "', [pengarang]='" & TextBox3.Text & "', [penerbit]='" & TextBox4.Text & "', [tahun]='" & TextBox5.Text & "', [stok]='" & TextBox6.Text & "', [rak]='" & TextBox7.Text & "' where [id_buku]='" & TextBox1.Text & "'"
        SqlUpdate(edit)
        Call TampilGrid()
        Call KosongkanData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus!")
        Else
            If MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = vbYes Then
                Dim hapus As String = "delete from tbl_buku  where id_buku='" & TextBox1.Text & "'"
                SqlDelete(hapus)
                TampilGrid()
                KosongkanData()
            End If
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call KosongkanData()
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Regex.IsMatch(e.KeyChar, "^[0-9.]*$") And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class