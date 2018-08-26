<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashFlowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeringkatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrafikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahunanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HarianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulananToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahunanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAdmin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAnggota = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLaporan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPengembalian = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPeminjaman = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBuku = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Waktu = New System.Windows.Forms.Timer(Me.components)
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1099, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.BukuToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AnggotaToolStripMenuItem.Text = "Anggota"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem, Me.PengembalianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PeminjamanToolStripMenuItem.Text = "Peminjaman"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem1, Me.KasToolStripMenuItem, Me.PeringkatToolStripMenuItem, Me.GrafikToolStripMenuItem, Me.PeminjamanToolStripMenuItem2, Me.PengembalianToolStripMenuItem2})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'TransaksiToolStripMenuItem1
        '
        Me.TransaksiToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnggotaToolStripMenuItem1, Me.BukuToolStripMenuItem1})
        Me.TransaksiToolStripMenuItem1.Name = "TransaksiToolStripMenuItem1"
        Me.TransaksiToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.TransaksiToolStripMenuItem1.Text = "Master"
        '
        'AnggotaToolStripMenuItem1
        '
        Me.AnggotaToolStripMenuItem1.Name = "AnggotaToolStripMenuItem1"
        Me.AnggotaToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AnggotaToolStripMenuItem1.Text = "Anggota"
        '
        'BukuToolStripMenuItem1
        '
        Me.BukuToolStripMenuItem1.Name = "BukuToolStripMenuItem1"
        Me.BukuToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.BukuToolStripMenuItem1.Text = "Buku"
        '
        'KasToolStripMenuItem
        '
        Me.KasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashFlowToolStripMenuItem, Me.KasMasukToolStripMenuItem, Me.KasKeluarToolStripMenuItem})
        Me.KasToolStripMenuItem.Name = "KasToolStripMenuItem"
        Me.KasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.KasToolStripMenuItem.Text = "Kas"
        '
        'CashFlowToolStripMenuItem
        '
        Me.CashFlowToolStripMenuItem.Name = "CashFlowToolStripMenuItem"
        Me.CashFlowToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CashFlowToolStripMenuItem.Text = "Cash Flow"
        '
        'KasMasukToolStripMenuItem
        '
        Me.KasMasukToolStripMenuItem.Name = "KasMasukToolStripMenuItem"
        Me.KasMasukToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.KasMasukToolStripMenuItem.Text = "Kas Masuk"
        '
        'KasKeluarToolStripMenuItem
        '
        Me.KasKeluarToolStripMenuItem.Name = "KasKeluarToolStripMenuItem"
        Me.KasKeluarToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.KasKeluarToolStripMenuItem.Text = "Kas Keluar"
        '
        'PeringkatToolStripMenuItem
        '
        Me.PeringkatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem2, Me.BukuToolStripMenuItem2})
        Me.PeringkatToolStripMenuItem.Name = "PeringkatToolStripMenuItem"
        Me.PeringkatToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PeringkatToolStripMenuItem.Text = "Peringkat"
        '
        'TransaksiToolStripMenuItem2
        '
        Me.TransaksiToolStripMenuItem2.Name = "TransaksiToolStripMenuItem2"
        Me.TransaksiToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
        Me.TransaksiToolStripMenuItem2.Text = "Transaksi"
        '
        'BukuToolStripMenuItem2
        '
        Me.BukuToolStripMenuItem2.Name = "BukuToolStripMenuItem2"
        Me.BukuToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
        Me.BukuToolStripMenuItem2.Text = "Buku"
        '
        'GrafikToolStripMenuItem
        '
        Me.GrafikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem1, Me.PengembalianToolStripMenuItem1})
        Me.GrafikToolStripMenuItem.Name = "GrafikToolStripMenuItem"
        Me.GrafikToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GrafikToolStripMenuItem.Text = "Grafik"
        '
        'PeminjamanToolStripMenuItem1
        '
        Me.PeminjamanToolStripMenuItem1.Name = "PeminjamanToolStripMenuItem1"
        Me.PeminjamanToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.PeminjamanToolStripMenuItem1.Text = "Peminjaman"
        '
        'PengembalianToolStripMenuItem1
        '
        Me.PengembalianToolStripMenuItem1.Name = "PengembalianToolStripMenuItem1"
        Me.PengembalianToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.PengembalianToolStripMenuItem1.Text = "Pengembalian"
        '
        'PeminjamanToolStripMenuItem2
        '
        Me.PeminjamanToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HarianToolStripMenuItem, Me.BulananToolStripMenuItem, Me.TahunanToolStripMenuItem})
        Me.PeminjamanToolStripMenuItem2.Name = "PeminjamanToolStripMenuItem2"
        Me.PeminjamanToolStripMenuItem2.Size = New System.Drawing.Size(150, 22)
        Me.PeminjamanToolStripMenuItem2.Text = "Peminjaman"
        '
        'HarianToolStripMenuItem
        '
        Me.HarianToolStripMenuItem.Name = "HarianToolStripMenuItem"
        Me.HarianToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.HarianToolStripMenuItem.Text = "Harian"
        '
        'BulananToolStripMenuItem
        '
        Me.BulananToolStripMenuItem.Name = "BulananToolStripMenuItem"
        Me.BulananToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.BulananToolStripMenuItem.Text = "Bulanan"
        '
        'TahunanToolStripMenuItem
        '
        Me.TahunanToolStripMenuItem.Name = "TahunanToolStripMenuItem"
        Me.TahunanToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.TahunanToolStripMenuItem.Text = "Tahunan"
        '
        'PengembalianToolStripMenuItem2
        '
        Me.PengembalianToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HarianToolStripMenuItem1, Me.BulananToolStripMenuItem1, Me.TahunanToolStripMenuItem1})
        Me.PengembalianToolStripMenuItem2.Name = "PengembalianToolStripMenuItem2"
        Me.PengembalianToolStripMenuItem2.Size = New System.Drawing.Size(150, 22)
        Me.PengembalianToolStripMenuItem2.Text = "Pengembalian"
        '
        'HarianToolStripMenuItem1
        '
        Me.HarianToolStripMenuItem1.Name = "HarianToolStripMenuItem1"
        Me.HarianToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.HarianToolStripMenuItem1.Text = "Harian"
        '
        'BulananToolStripMenuItem1
        '
        Me.BulananToolStripMenuItem1.Name = "BulananToolStripMenuItem1"
        Me.BulananToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.BulananToolStripMenuItem1.Text = "Bulanan"
        '
        'TahunanToolStripMenuItem1
        '
        Me.TahunanToolStripMenuItem1.Name = "TahunanToolStripMenuItem1"
        Me.TahunanToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.TahunanToolStripMenuItem1.Text = "Tahunan"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.StatusStrip1)
        Me.BunifuCards1.Controls.Add(Me.btnAdmin)
        Me.BunifuCards1.Controls.Add(Me.btnAnggota)
        Me.BunifuCards1.Controls.Add(Me.btnLaporan)
        Me.BunifuCards1.Controls.Add(Me.btnPengembalian)
        Me.BunifuCards1.Controls.Add(Me.btnPeminjaman)
        Me.BunifuCards1.Controls.Add(Me.btnBuku)
        Me.BunifuCards1.Controls.Add(Me.PictureBox1)
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 24)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1099, 540)
        Me.BunifuCards1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1099, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(475, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(475, 18)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "© 2018 Shinigami Team"
        Me.ToolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdmin
        '
        Me.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdmin.BackColor = System.Drawing.Color.Gold
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmin.BorderRadius = 0
        Me.btnAdmin.ButtonText = " Admin"
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.DisabledColor = System.Drawing.Color.Goldenrod
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdmin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdmin.Iconimage = CType(resources.GetObject("btnAdmin.Iconimage"), System.Drawing.Image)
        Me.btnAdmin.Iconimage_right = Nothing
        Me.btnAdmin.Iconimage_right_Selected = Nothing
        Me.btnAdmin.Iconimage_Selected = Nothing
        Me.btnAdmin.IconMarginLeft = 0
        Me.btnAdmin.IconMarginRight = 0
        Me.btnAdmin.IconRightVisible = True
        Me.btnAdmin.IconRightZoom = 0R
        Me.btnAdmin.IconVisible = True
        Me.btnAdmin.IconZoom = 50.0R
        Me.btnAdmin.IsTab = False
        Me.btnAdmin.Location = New System.Drawing.Point(14, 14)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Normalcolor = System.Drawing.Color.Gold
        Me.btnAdmin.OnHovercolor = System.Drawing.Color.Orange
        Me.btnAdmin.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnAdmin.selected = False
        Me.btnAdmin.Size = New System.Drawing.Size(110, 48)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = " Admin"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.Textcolor = System.Drawing.Color.Black
        Me.btnAdmin.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAnggota
        '
        Me.btnAnggota.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAnggota.BackColor = System.Drawing.Color.Gold
        Me.btnAnggota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnggota.BorderRadius = 0
        Me.btnAnggota.ButtonText = " Anggota"
        Me.btnAnggota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnggota.DisabledColor = System.Drawing.Color.Goldenrod
        Me.btnAnggota.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnggota.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAnggota.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAnggota.Iconimage = CType(resources.GetObject("btnAnggota.Iconimage"), System.Drawing.Image)
        Me.btnAnggota.Iconimage_right = Nothing
        Me.btnAnggota.Iconimage_right_Selected = Nothing
        Me.btnAnggota.Iconimage_Selected = Nothing
        Me.btnAnggota.IconMarginLeft = 0
        Me.btnAnggota.IconMarginRight = 0
        Me.btnAnggota.IconRightVisible = True
        Me.btnAnggota.IconRightZoom = 0R
        Me.btnAnggota.IconVisible = True
        Me.btnAnggota.IconZoom = 50.0R
        Me.btnAnggota.IsTab = False
        Me.btnAnggota.Location = New System.Drawing.Point(130, 14)
        Me.btnAnggota.Name = "btnAnggota"
        Me.btnAnggota.Normalcolor = System.Drawing.Color.Gold
        Me.btnAnggota.OnHovercolor = System.Drawing.Color.Orange
        Me.btnAnggota.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnAnggota.selected = False
        Me.btnAnggota.Size = New System.Drawing.Size(110, 48)
        Me.btnAnggota.TabIndex = 1
        Me.btnAnggota.Text = " Anggota"
        Me.btnAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAnggota.Textcolor = System.Drawing.Color.Black
        Me.btnAnggota.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLaporan
        '
        Me.btnLaporan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLaporan.BackColor = System.Drawing.Color.Gold
        Me.btnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLaporan.BorderRadius = 0
        Me.btnLaporan.ButtonText = " Laporan"
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.DisabledColor = System.Drawing.Color.Goldenrod
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLaporan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLaporan.Iconimage = CType(resources.GetObject("btnLaporan.Iconimage"), System.Drawing.Image)
        Me.btnLaporan.Iconimage_right = Nothing
        Me.btnLaporan.Iconimage_right_Selected = Nothing
        Me.btnLaporan.Iconimage_Selected = Nothing
        Me.btnLaporan.IconMarginLeft = 0
        Me.btnLaporan.IconMarginRight = 0
        Me.btnLaporan.IconRightVisible = True
        Me.btnLaporan.IconRightZoom = 0R
        Me.btnLaporan.IconVisible = True
        Me.btnLaporan.IconZoom = 50.0R
        Me.btnLaporan.IsTab = False
        Me.btnLaporan.Location = New System.Drawing.Point(663, 14)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Normalcolor = System.Drawing.Color.Gold
        Me.btnLaporan.OnHovercolor = System.Drawing.Color.Orange
        Me.btnLaporan.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnLaporan.selected = False
        Me.btnLaporan.Size = New System.Drawing.Size(114, 48)
        Me.btnLaporan.TabIndex = 1
        Me.btnLaporan.Text = " Laporan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Textcolor = System.Drawing.Color.Black
        Me.btnLaporan.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPengembalian
        '
        Me.btnPengembalian.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPengembalian.BackColor = System.Drawing.Color.Gold
        Me.btnPengembalian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPengembalian.BorderRadius = 0
        Me.btnPengembalian.ButtonText = " Pengembalian"
        Me.btnPengembalian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPengembalian.DisabledColor = System.Drawing.Color.Goldenrod
        Me.btnPengembalian.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengembalian.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPengembalian.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPengembalian.Iconimage = CType(resources.GetObject("btnPengembalian.Iconimage"), System.Drawing.Image)
        Me.btnPengembalian.Iconimage_right = Nothing
        Me.btnPengembalian.Iconimage_right_Selected = Nothing
        Me.btnPengembalian.Iconimage_Selected = Nothing
        Me.btnPengembalian.IconMarginLeft = 0
        Me.btnPengembalian.IconMarginRight = 0
        Me.btnPengembalian.IconRightVisible = True
        Me.btnPengembalian.IconRightZoom = 0R
        Me.btnPengembalian.IconVisible = True
        Me.btnPengembalian.IconZoom = 50.0R
        Me.btnPengembalian.IsTab = False
        Me.btnPengembalian.Location = New System.Drawing.Point(504, 14)
        Me.btnPengembalian.Name = "btnPengembalian"
        Me.btnPengembalian.Normalcolor = System.Drawing.Color.Gold
        Me.btnPengembalian.OnHovercolor = System.Drawing.Color.Orange
        Me.btnPengembalian.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnPengembalian.selected = False
        Me.btnPengembalian.Size = New System.Drawing.Size(153, 48)
        Me.btnPengembalian.TabIndex = 1
        Me.btnPengembalian.Text = " Pengembalian"
        Me.btnPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPengembalian.Textcolor = System.Drawing.Color.Black
        Me.btnPengembalian.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPeminjaman.BackColor = System.Drawing.Color.Gold
        Me.btnPeminjaman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPeminjaman.BorderRadius = 0
        Me.btnPeminjaman.ButtonText = " Peminjaman"
        Me.btnPeminjaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPeminjaman.DisabledColor = System.Drawing.Color.Goldenrod
        Me.btnPeminjaman.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeminjaman.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPeminjaman.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPeminjaman.Iconimage = CType(resources.GetObject("btnPeminjaman.Iconimage"), System.Drawing.Image)
        Me.btnPeminjaman.Iconimage_right = Nothing
        Me.btnPeminjaman.Iconimage_right_Selected = Nothing
        Me.btnPeminjaman.Iconimage_Selected = Nothing
        Me.btnPeminjaman.IconMarginLeft = 0
        Me.btnPeminjaman.IconMarginRight = 0
        Me.btnPeminjaman.IconRightVisible = True
        Me.btnPeminjaman.IconRightZoom = 0R
        Me.btnPeminjaman.IconVisible = True
        Me.btnPeminjaman.IconZoom = 50.0R
        Me.btnPeminjaman.IsTab = False
        Me.btnPeminjaman.Location = New System.Drawing.Point(362, 14)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Normalcolor = System.Drawing.Color.Gold
        Me.btnPeminjaman.OnHovercolor = System.Drawing.Color.Orange
        Me.btnPeminjaman.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnPeminjaman.selected = False
        Me.btnPeminjaman.Size = New System.Drawing.Size(136, 48)
        Me.btnPeminjaman.TabIndex = 1
        Me.btnPeminjaman.Text = " Peminjaman"
        Me.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPeminjaman.Textcolor = System.Drawing.Color.Black
        Me.btnPeminjaman.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBuku
        '
        Me.btnBuku.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBuku.BackColor = System.Drawing.Color.Gold
        Me.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuku.BorderRadius = 0
        Me.btnBuku.ButtonText = " Buku"
        Me.btnBuku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuku.DisabledColor = System.Drawing.Color.Goldenrod
        Me.btnBuku.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuku.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBuku.Iconimage = CType(resources.GetObject("btnBuku.Iconimage"), System.Drawing.Image)
        Me.btnBuku.Iconimage_right = Nothing
        Me.btnBuku.Iconimage_right_Selected = Nothing
        Me.btnBuku.Iconimage_Selected = Nothing
        Me.btnBuku.IconMarginLeft = 0
        Me.btnBuku.IconMarginRight = 0
        Me.btnBuku.IconRightVisible = True
        Me.btnBuku.IconRightZoom = 0R
        Me.btnBuku.IconVisible = True
        Me.btnBuku.IconZoom = 50.0R
        Me.btnBuku.IsTab = False
        Me.btnBuku.Location = New System.Drawing.Point(246, 14)
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Normalcolor = System.Drawing.Color.Gold
        Me.btnBuku.OnHovercolor = System.Drawing.Color.Orange
        Me.btnBuku.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnBuku.selected = False
        Me.btnBuku.Size = New System.Drawing.Size(110, 48)
        Me.btnBuku.TabIndex = 1
        Me.btnBuku.Text = " Buku"
        Me.btnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuku.Textcolor = System.Drawing.Color.Black
        Me.btnBuku.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1125, 528)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Waktu
        '
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(0, 0)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(0, 0)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 0
        Me.MetroButton2.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 564)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(803, 603)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Library"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnBuku As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAdmin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAnggota As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Waktu As Timer
    Friend WithEvents btnLaporan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPengembalian As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPeminjaman As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TransaksiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Private WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents AnggotaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeringkatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GrafikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TahunanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HarianToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BulananToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TahunanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CashFlowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
End Class
