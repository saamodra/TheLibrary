Public Class Pengaturan
    Private Sub Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        TextBox1.Text = My.Settings.Durasi
        TextBox2.Text = My.Settings.Denda
        TextBox3.Text = My.Settings.Nama_Perpustakaan
        TextBox4.Text = My.Settings.Alamat
        TextBox5.Text = My.Settings.Telp
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Denda = TextBox2.Text
        My.Settings.Durasi = TextBox1.Text
        My.Settings.Nama_Perpustakaan = TextBox3.Text
        My.Settings.Alamat = TextBox4.Text
        My.Settings.Telp = TextBox5.Text
        My.Settings.Save()
        MsgBox("Pengaturan Berhasil Disimpan !", vbInformation)
    End Sub

End Class