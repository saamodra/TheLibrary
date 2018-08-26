Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class GrafikPengembalian
    Dim i As Integer
    Dim tgl_mulai As DateTime
    Dim tgl_akhir As DateTime
    Private Sub GrafikPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        dateharian2.Value = DateTime.Today
        DateTimePicker1.Value = DateTime.Today
        datetahunan2.Value = DateTime.Today
        grafik_harian()
        grafik_bulanan()
        grafik_tahunan()
    End Sub
    Sub grafik_harian()
        Str = "select [dikembalikan_tgl], count(id_transaksi) from tbl_transaksi where [dikembalikan_tgl] between #" & Format(DateTime.Today.AddDays(-5), "MM/dd/yyyy") & "# and #" & Format(dateharian2.Value, "MM/dd/yyyy") & "# group by dikembalikan_tgl"
        CMD = New OleDbCommand(Str, conn)
        RD = CMD.ExecuteReader
        Chart1.Series.Clear()
        Chart1.Series.Add("Jumlah Transaksi")
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        While RD.Read
            Chart1.Series("Jumlah Transaksi").Points.AddXY(RD(0), RD(1))
        End While
        Chart1.Series(0).IsValueShownAsLabel = True
    End Sub
    Sub grafik_bulanan()
        Str = "select format(dikembalikan_tgl, 'mm/yyyy'), count(format(dikembalikan_tgl, 'mm/yyyy')) from tbl_transaksi where format(dikembalikan_tgl, 'mm/yyyy') between '" & Format(DateTime.Today.AddMonths(-7), "MM/yyyy") & "' and '" & Format(DateTimePicker1.Value, "MM/yyyy") & "' group by format(dikembalikan_tgl, 'mm/yyyy') order by CVDate(format(dikembalikan_tgl, 'mm/yyyy')) ASC"
        CMD = New OleDbCommand(Str, conn)
        RD = CMD.ExecuteReader
        Chart2.Series.Clear()
        Chart2.Series.Add("Jumlah Transaksi")
        Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        While RD.Read
            Chart2.Series("Jumlah Transaksi").Points.AddXY(RD(0), RD(1))
        End While
        Chart2.Series(0).IsValueShownAsLabel = True
    End Sub
    Sub grafik_tahunan()
        Str = "select format(dikembalikan_tgl, 'yyyy'), count(format(dikembalikan_tgl, 'yyyy')) from tbl_transaksi where format(dikembalikan_tgl, 'yyyy') between '" & Format(DateTime.Today.AddYears(-5), "yyyy") & "' and '" & Format(datetahunan2.Value, "yyyy") & "' group by format(dikembalikan_tgl, 'yyyy')"
        CMD = New OleDbCommand(Str, conn)
        RD = CMD.ExecuteReader
        Chart3.Series.Clear()
        Chart3.Series.Add("Jumlah Transaksi")
        Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        While RD.Read
            Chart3.Series("Jumlah Transaksi").Points.AddXY(RD(0), RD(1))
        End While
        Chart3.Series(0).IsValueShownAsLabel = True
    End Sub


    Private Sub dateharian2_ValueChanged(sender As Object, e As EventArgs) Handles dateharian2.ValueChanged
        grafik_harian()
    End Sub


    Private Sub datebulanan2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        grafik_bulanan()
    End Sub


    Private Sub datetahunan2_ValueChanged(sender As Object, e As EventArgs) Handles datetahunan2.ValueChanged
        grafik_tahunan()
    End Sub
End Class