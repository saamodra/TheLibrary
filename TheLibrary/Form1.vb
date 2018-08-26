Public Class Form1
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False
        BunifuCards1.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        Waktu.Enabled = True
    End Sub
    Private Sub Waktu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Waktu.Tick
        ToolStripStatusLabel2.Text = DateString & "   " & TimeString
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Login" Then
            FormLogin.Show()
        ElseIf LoginToolStripMenuItem.Text = "Logout" Then
            LoginToolStripMenuItem.Text = "Login"
            Terkunci()
        End If
    End Sub


    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Admin.Show()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        Anggota.Show()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Buku.Show()
    End Sub


    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Admin.Show()
    End Sub

    Private Sub btnAnggota_Click(sender As Object, e As EventArgs) Handles btnAnggota.Click
        Anggota.Show()
    End Sub

    Private Sub btnBuku_Click(sender As Object, e As EventArgs) Handles btnBuku.Click
        Buku.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Waktu.Tick

    End Sub

    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        Peminjaman.Show()
    End Sub


    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        Pengembalian.ShowDialog()
    End Sub

    Private Sub CashFlowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Kas.Show()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Laporan.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        Peminjaman.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        Pengembalian.Show()
    End Sub

    Private Sub AnggotaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem1.Click
        LaporanAnggota.Show()
    End Sub

    Private Sub BukuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem1.Click
        LaporanBuku.Show()
    End Sub

    Private Sub CashFlowToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CashFlowToolStripMenuItem.Click
        Kas.Show()
    End Sub

    Private Sub KasMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasMasukToolStripMenuItem.Click
        KasMasuk.Show()
    End Sub

    Private Sub KasKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasKeluarToolStripMenuItem.Click
        KasKeluar.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem1.Click
        GrafikPeminjaman.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem1.Click
        GrafikPengembalian.Show()
    End Sub

    Private Sub HarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HarianToolStripMenuItem.Click
        PeminjamanHarian.Show()
    End Sub

    Private Sub BulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulananToolStripMenuItem.Click
        PeminjamanBulanan.Show()
    End Sub

    Private Sub TahunanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TahunanToolStripMenuItem.Click
        PeminjamanTahunan.Show()
    End Sub

    Private Sub HarianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HarianToolStripMenuItem1.Click
        PengembalianHarian.Show()
    End Sub

    Private Sub BulananToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BulananToolStripMenuItem1.Click
        PengembalianBulanan.Show()
    End Sub

    Private Sub TahunanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TahunanToolStripMenuItem1.Click
        PengembalianTahunan.Show()
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanToolStripMenuItem.Click
        Pengaturan.Show()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class
