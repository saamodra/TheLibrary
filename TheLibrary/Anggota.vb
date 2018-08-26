Imports System.Data.OleDb
Public Class Anggota
    Dim jenkel As String
    Sub Gender()
        If RadioButton1.Checked = True Then
            jenkel = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            jenkel = RadioButton2.Text
        End If
    End Sub
    Sub TampilGrid()
        DA = New OleDbDataAdapter("select * from tbl_anggota", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_anggota")
        DataGridView1.DataSource = (DS.Tables("tbl_anggota"))
        DataGridView1.Enabled = True
        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID Anggota"
            .Columns(1).HeaderCell.Value = "Nama"
            .Columns(2).HeaderCell.Value = "Jenis Kelamin"
            .Columns(3).HeaderCell.Value = "Alamat"
            .Columns(4).HeaderCell.Value = "Telepon"
        End With
    End Sub
    Sub id()
        CMD = New OleDbCommand("select * from tbl_anggota order by id_anggota desc", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            TextBox1.Text = "AG" + "0001"
        Else
            TextBox1.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_anggota").ToString, 4, 3)) + 1
            If Len(TextBox1.Text) = 1 Then
                TextBox1.Text = "AG000" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 2 Then
                TextBox1.Text = "AG00" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 3 Then
                TextBox1.Text = "AG0" & TextBox1.Text & ""
            End If
        End If
    End Sub
    Sub KosongkanData()
        id()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
    Private Sub Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call id()
        Call TampilGrid()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Gender()
            Dim simpan As String = "insert into tbl_anggota values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & jenkel & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
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
            If DataGridView1.Item(2, i).Value = RadioButton1.Text Then
                RadioButton1.Checked = True
            ElseIf DataGridView1.Item(2, i).Value = RadioButton2.Text Then
                RadioButton2.Checked = True
            End If
            TextBox3.Text = DataGridView1.Item(3, i).Value
            TextBox4.Text = DataGridView1.Item(4, i).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        isiTextBox()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Gender()
        Dim edit As String = "update tbl_anggota set [nama]='" & TextBox2.Text & "', [alamat]='" & TextBox3.Text & "', [jenis_kelamin]='" & jenkel & "', [telepon]='" & TextBox4.Text & "' where [id_anggota]='" & TextBox1.Text & "'"
        SqlUpdate(edit)
        Call TampilGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus!")
        Else
            If MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = vbYes Then
                Dim hapus As String = "delete from tbl_anggota  where id_anggota='" & TextBox1.Text & "'"
                SqlDelete(hapus)
                TampilGrid()
            End If
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Call KosongkanData()
    End Sub


    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class