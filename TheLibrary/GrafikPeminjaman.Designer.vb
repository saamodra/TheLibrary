<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrafikPeminjaman
    Inherits System.Windows.Forms.Form
    'Inherits MetroFramework.Forms.MetroForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrafikPeminjaman))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dateharian2 = New System.Windows.Forms.DateTimePicker()
        Me.datetahunan2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 71)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(528, 225)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(566, 71)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(528, 225)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Chart1"
        '
        'Chart3
        '
        Me.Chart3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(294, 351)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(528, 225)
        Me.Chart3.TabIndex = 2
        Me.Chart3.Text = "Chart1"
        '
        'dateharian2
        '
        Me.dateharian2.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateharian2.CustomFormat = "dd/MM/yyyy"
        Me.dateharian2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateharian2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateharian2.Location = New System.Drawing.Point(207, 38)
        Me.dateharian2.Name = "dateharian2"
        Me.dateharian2.Size = New System.Drawing.Size(118, 27)
        Me.dateharian2.TabIndex = 8
        '
        'datetahunan2
        '
        Me.datetahunan2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.datetahunan2.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetahunan2.CustomFormat = "yyyy"
        Me.datetahunan2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetahunan2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetahunan2.Location = New System.Drawing.Point(501, 318)
        Me.datetahunan2.Name = "datetahunan2"
        Me.datetahunan2.Size = New System.Drawing.Size(107, 27)
        Me.datetahunan2.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CustomFormat = "MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(763, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 27)
        Me.DateTimePicker1.TabIndex = 9
        '
        'GrafikPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 603)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.datetahunan2)
        Me.Controls.Add(Me.dateharian2)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1122, 642)
        Me.Name = "GrafikPeminjaman"
        Me.Text = "Grafik Peminjaman"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents dateharian2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents datetahunan2 As DateTimePicker
End Class
