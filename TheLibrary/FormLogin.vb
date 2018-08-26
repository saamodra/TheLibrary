Imports System.Data.OleDb
Public Class FormLogin
    Dim CMD As New OleDbCommand
    Dim RD As OleDbDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data login belum lengkap", vbCritical)
            Exit Sub
        Else
            CMD = New OleDbCommand("select * from tbl_user where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Login Berhasil !", vbInformation)
                Me.Hide()
                If RD("level") = "User" Then
                    Call OpenUser()
                Else
                    Call Open()
                End If
            Else
                MsgBox("Kode Admin atau Password salah", vbCritical)
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If TextBox1.Text = "" Or TextBox2.Text = "" Then
                    MsgBox("Data login belum lengkap", vbCritical)
                    Exit Sub
                Else
                    CMD = New OleDbCommand("select * from tbl_user where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    If RD.HasRows Then
                        MsgBox("Login Berhasil !", vbInformation)
                        Me.Hide()
                        If RD("level") = "User" Then
                            Call OpenUser()
                        Else
                            Call Open()
                        End If
                    Else
                        MsgBox("Kode Admin atau Password salah", vbCritical)
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub Open()
        Form1.Show()
        Form1.LoginToolStripMenuItem.Text = "Logout"
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.PengaturanToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
        Form1.ToolStripStatusLabel1.Text = "Username : "
        Form1.ToolStripStatusLabel4.Text = RD("username")
        Form1.BunifuCards1.Show()
    End Sub
    Sub OpenUser()
        Form1.Show()
        Form1.LoginToolStripMenuItem.Text = "Logout"
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.AnggotaToolStripMenuItem.Enabled = False
        Form1.PengaturanToolStripMenuItem.Enabled = True
        Form1.AdminToolStripMenuItem.Enabled = False
        Laporan.Label3.Enabled = False
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
        Form1.ToolStripStatusLabel1.Text = "Username : "
        Form1.ToolStripStatusLabel4.Text = RD("username")
        Form1.BunifuCards1.Show()
        Form1.btnAdmin.Enabled = False
        Form1.btnAnggota.Enabled = False
        Form1.AnggotaToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.Focus()
        TextBox1.MaxLength = 6
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class