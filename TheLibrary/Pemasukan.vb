Imports System.Data.OleDb
Public Class Pemasukan
    Dim id As String = Format(Now, "ddMMyyyyhhmmss")
    Private Sub Pemasukan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "IN-" & id
        Button4.Enabled = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CMD = New OleDbCommand("INSERT INTO tbl_kas VALUES ('" & TextBox1.Text & "','" & DateTimePicker1.Value & "','" & TextBox2.Text & "','0','" & TextBox3.Text & "','" & Form1.ToolStripStatusLabel4.Text & "')", conn)
        CMD.ExecuteNonQuery()
        MsgBox("Pemasukan Berhasil disimpan", MsgBoxStyle.Information, "Success")
        If MsgBox("CETAK ?", MsgBoxStyle.YesNo, "Cetak Struk") = vbYes Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
        Kas.TampilGrid()
        DateTimePicker1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim tinggi As Integer
        e.Graphics.DrawString("NOTA PEMASUKAN KAS", New Drawing.Font("Arial", 10), Brushes.Black, 10, 25)
        e.Graphics.DrawString("================================", New Drawing.Font("Arial", 8), Brushes.Black, 10, 45)
        tinggi = 65
        e.Graphics.DrawString("ID ", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi)
        e.Graphics.DrawString("Tanggal ", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 15)
        e.Graphics.DrawString("Tunai ", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 30)
        e.Graphics.DrawString("Keterangan ", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 45)
        e.Graphics.DrawString(": " & TextBox1.Text, New Drawing.Font("Arial", 8), Brushes.Black, 80, tinggi)
        e.Graphics.DrawString(": " & Format(DateTime.Today(), "dd/MM/yyyy"), New Drawing.Font("Arial", 8), Brushes.Black, 80, tinggi + 15)
        e.Graphics.DrawString(": " & TextBox2.Text, New Drawing.Font("Arial", 8), Brushes.Black, 80, tinggi + 30)
        e.Graphics.DrawString(": " & TextBox3.Text, New Drawing.Font("Arial", 8), Brushes.Black, 80, tinggi + 45)
        e.Graphics.DrawString("================================", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 65)
        e.Graphics.DrawString("Operator ", New Drawing.Font("Arial", 8), Brushes.Black, 10, tinggi + 85)
        e.Graphics.DrawString(": " & Form1.ToolStripStatusLabel1.Text, New Drawing.Font("Arial", 8), Brushes.Black, 80, tinggi + 85)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = "IN-" & id
        Button2.Enabled = True
        DateTimePicker1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class