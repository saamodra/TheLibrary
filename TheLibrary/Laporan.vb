Public Class Laporan
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        LaporanBuku.Show()
    End Sub

    Private Sub LabelMouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter, Label3.MouseEnter, Label5.MouseEnter, Label6.MouseEnter, Label7.MouseEnter, Label9.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label10.MouseEnter, Label8.MouseEnter, Label17.MouseEnter, Label15.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter
        CType(sender, Label).ForeColor = System.Drawing.Color.Coral
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub LabelMouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave, Label3.MouseLeave, Label5.MouseLeave, Label6.MouseLeave, Label7.MouseLeave, Label9.MouseLeave, Label14.MouseLeave, Label13.MouseLeave, Label10.MouseLeave, Label8.MouseLeave, Label17.MouseLeave, Label15.MouseLeave, Label20.MouseLeave, Label19.MouseLeave, Label18.MouseLeave
        CType(sender, Label).ForeColor = System.Drawing.Color.White
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        LaporanAnggota.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Kas.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        KasMasuk.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        KasKeluar.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        LaporanTransaksi.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        LaporanBukuDipinjam.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        GrafikPeminjaman.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        GrafikPengembalian.Show()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        PeminjamanHarian.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        PeminjamanBulanan.Show()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        PeminjamanTahunan.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        PengembalianHarian.Show()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        PengembalianBulanan.Show()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        PengembalianTahunan.Show()
    End Sub
End Class