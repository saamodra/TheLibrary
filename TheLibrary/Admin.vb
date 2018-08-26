Imports System.Data.OleDb
Public Class Admin
    Sub TampilGrid()
        DA = New OleDbDataAdapter("select * from tbl_user", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_user")
        DataGridView1.DataSource = (DS.Tables("tbl_user"))
        DataGridView1.Enabled = True
        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Username"
            .Columns(1).HeaderCell.Value = "Nama"
            .Columns(2).HeaderCell.Value = "Level"
            .Columns(3).HeaderCell.Value = "Password"
        End With
    End Sub
    Sub ShowLevel()
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("User")
    End Sub
    Sub KosongkanData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call ShowLevel()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Dim simpan As String = "insert into tbl_user values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "')"
            SqlSimpan(simpan)
            TampilGrid()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub isiTextBox()
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            TextBox1.Text = DataGridView1.Item(0, i).Value
            TextBox2.Text = DataGridView1.Item(1, i).Value
            TextBox3.Text = DataGridView1.Item(3, i).Value
            ComboBox1.Text = DataGridView1.Item(2, i).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        isiTextBox()
        btnInput.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim edit As String = "update tbl_user set [nama]='" & TextBox2.Text & "', [level]='" & ComboBox1.Text & "', [password]='" & TextBox3.Text & "' where [username]='" & TextBox1.Text & "'"
        SqlUpdate(edit)
        Call TampilGrid()
        Call KosongkanData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus!")
        Else
            If MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = vbYes Then
                Dim hapus As String = "delete From tbl_user  where username='" & TextBox1.Text & "'"
                SqlDelete(hapus)
                TampilGrid()
                KosongkanData()
            End If
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        btnInput.Enabled = True
        KosongkanData()
    End Sub
End Class