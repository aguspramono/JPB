<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.tmJam = New System.Windows.Forms.Timer(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.lblStatusUserOn = New DevComponents.DotNetBar.LabelItem()
        Me.lblKota = New DevComponents.DotNetBar.LabelItem()
        Me.statusTgljam = New DevComponents.DotNetBar.LabelItem()
        Me.mnuUtama = New DevComponents.DotNetBar.Bar()
        Me.mnuFileUtama = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileUser = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileGantiPassword = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileCustomer = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileKelompok = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileKota = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileProduct = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuInfo = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuFileKeluar = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTransaksiUtama = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTransaksiPembelian = New DevComponents.DotNetBar.ButtonItem()
        Me.btnHarga = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuAkkHargaRata = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTransaksiPenjualan = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPinjaman = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSPSI = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTransaksiPembayaran = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTransaksiFee = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTransaksiInvoice = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanUtama = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanPembayaranTBS = New DevComponents.DotNetBar.ButtonItem()
        Me.btnLaporanPembayaranGrossup = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNPWP = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNPWP50 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNonNPWP = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNonNPWP50 = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanPembayaranFee = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanTBSMasuk = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanInvoice = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanHutangPembantu = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanDaftarCustomer = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanCustomerLimit = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuLaporanCustomerKomplain = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuRekaptbs = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuHutangDagang = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPengaturan = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSettingCustomerSpesial = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDaftarNamaBos = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSettingCustomerGrossUp = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuGrossUpCustomer = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuGrossUpPerhitungan = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuGantiKota = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuHargaBrondolan = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuKelompokPapanSub = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPotonganSub = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPlatSub = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPotonganPlat = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuTambahanPlat = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPengecualianHargaSub = New DevComponents.DotNetBar.ButtonItem()
        Me.btnHarga025 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPengecualianHarga10 = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuAtmp = New DevComponents.DotNetBar.ButtonItem()
        Me.btnMarsada = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPengecualianBBSub = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuHargaHandoko = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuBanyakKelompokSub = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuPPH = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSettingTanggalFee = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSettingSPSI = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuOthersUtama = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuOthersImportDataPembelian = New DevComponents.DotNetBar.ButtonItem()
        Me.txtDatabase = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmJam
        '
        Me.tmJam.Enabled = True
        Me.tmJam.Interval = 1000
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(38, Byte), Integer)))
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.DockedBorderStyle = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.Bar1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.lblStatusUserOn, Me.lblKota, Me.statusTgljam})
        Me.Bar1.Location = New System.Drawing.Point(0, 548)
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1020, 22)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 5
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "User :"
        '
        'lblStatusUserOn
        '
        Me.lblStatusUserOn.Name = "lblStatusUserOn"
        '
        'lblKota
        '
        Me.lblKota.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.lblKota.Name = "lblKota"
        '
        'statusTgljam
        '
        Me.statusTgljam.BeginGroup = True
        Me.statusTgljam.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.statusTgljam.Name = "statusTgljam"
        '
        'mnuUtama
        '
        Me.mnuUtama.AccessibleDescription = "DotNetBar Bar (mnuUtama)"
        Me.mnuUtama.AccessibleName = "DotNetBar Bar"
        Me.mnuUtama.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.mnuUtama.AntiAlias = True
        Me.mnuUtama.Dock = System.Windows.Forms.DockStyle.Top
        Me.mnuUtama.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.mnuUtama.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuFileUtama, Me.mnuTransaksiUtama, Me.mnuLaporanUtama, Me.mnuPengaturan, Me.mnuOthersUtama})
        Me.mnuUtama.Location = New System.Drawing.Point(0, 0)
        Me.mnuUtama.MenuBar = True
        Me.mnuUtama.Name = "mnuUtama"
        Me.mnuUtama.Size = New System.Drawing.Size(1020, 24)
        Me.mnuUtama.Stretch = True
        Me.mnuUtama.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mnuUtama.TabIndex = 7
        Me.mnuUtama.TabStop = False
        Me.mnuUtama.Text = "Bar2"
        '
        'mnuFileUtama
        '
        Me.mnuFileUtama.Name = "mnuFileUtama"
        Me.mnuFileUtama.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuFileUser, Me.mnuFileGantiPassword, Me.mnuFileCustomer, Me.mnuFileKelompok, Me.mnuFileKota, Me.mnuFileProduct, Me.mnuInfo, Me.mnuFileKeluar})
        Me.mnuFileUtama.Text = "&File"
        '
        'mnuFileUser
        '
        Me.mnuFileUser.Name = "mnuFileUser"
        Me.mnuFileUser.Text = "&User"
        Me.mnuFileUser.Visible = False
        '
        'mnuFileGantiPassword
        '
        Me.mnuFileGantiPassword.Name = "mnuFileGantiPassword"
        Me.mnuFileGantiPassword.Text = "&Ganti Password"
        '
        'mnuFileCustomer
        '
        Me.mnuFileCustomer.BeginGroup = True
        Me.mnuFileCustomer.Name = "mnuFileCustomer"
        Me.mnuFileCustomer.Text = "&Customer"
        '
        'mnuFileKelompok
        '
        Me.mnuFileKelompok.Name = "mnuFileKelompok"
        Me.mnuFileKelompok.Text = "Ke&lompok"
        '
        'mnuFileKota
        '
        Me.mnuFileKota.Name = "mnuFileKota"
        Me.mnuFileKota.Text = "&Kota"
        '
        'mnuFileProduct
        '
        Me.mnuFileProduct.Name = "mnuFileProduct"
        Me.mnuFileProduct.Text = "&Product"
        '
        'mnuInfo
        '
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.Text = "Info"
        '
        'mnuFileKeluar
        '
        Me.mnuFileKeluar.BeginGroup = True
        Me.mnuFileKeluar.Name = "mnuFileKeluar"
        Me.mnuFileKeluar.Text = "K&eluar"
        '
        'mnuTransaksiUtama
        '
        Me.mnuTransaksiUtama.Name = "mnuTransaksiUtama"
        Me.mnuTransaksiUtama.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuTransaksiPembelian, Me.btnHarga, Me.mnuAkkHargaRata, Me.mnuTransaksiPenjualan, Me.mnuPinjaman, Me.mnuSPSI, Me.mnuTransaksiPembayaran, Me.mnuTransaksiFee, Me.mnuTransaksiInvoice})
        Me.mnuTransaksiUtama.Text = "&Transaksi"
        '
        'mnuTransaksiPembelian
        '
        Me.mnuTransaksiPembelian.Name = "mnuTransaksiPembelian"
        Me.mnuTransaksiPembelian.Text = "JP&B"
        '
        'btnHarga
        '
        Me.btnHarga.Name = "btnHarga"
        Me.btnHarga.Text = "Update &Harga"
        '
        'mnuAkkHargaRata
        '
        Me.mnuAkkHargaRata.Name = "mnuAkkHargaRata"
        Me.mnuAkkHargaRata.Text = "Akk Harga Rata2"
        '
        'mnuTransaksiPenjualan
        '
        Me.mnuTransaksiPenjualan.BeginGroup = True
        Me.mnuTransaksiPenjualan.Name = "mnuTransaksiPenjualan"
        Me.mnuTransaksiPenjualan.Text = "Pen&jualan"
        Me.mnuTransaksiPenjualan.Visible = False
        '
        'mnuPinjaman
        '
        Me.mnuPinjaman.Name = "mnuPinjaman"
        Me.mnuPinjaman.Text = "Pinjaman"
        '
        'mnuSPSI
        '
        Me.mnuSPSI.Name = "mnuSPSI"
        Me.mnuSPSI.Text = "SPSI"
        '
        'mnuTransaksiPembayaran
        '
        Me.mnuTransaksiPembayaran.BeginGroup = True
        Me.mnuTransaksiPembayaran.Name = "mnuTransaksiPembayaran"
        Me.mnuTransaksiPembayaran.Text = "Buka Pembayaran &TBS"
        '
        'mnuTransaksiFee
        '
        Me.mnuTransaksiFee.Name = "mnuTransaksiFee"
        Me.mnuTransaksiFee.Text = "Buka Pembayaran &Fee"
        '
        'mnuTransaksiInvoice
        '
        Me.mnuTransaksiInvoice.Name = "mnuTransaksiInvoice"
        Me.mnuTransaksiInvoice.Text = "&Invoice"
        Me.mnuTransaksiInvoice.Visible = False
        '
        'mnuLaporanUtama
        '
        Me.mnuLaporanUtama.Name = "mnuLaporanUtama"
        Me.mnuLaporanUtama.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuLaporanPembayaranTBS, Me.btnLaporanPembayaranGrossup, Me.mnuLaporanPembayaranFee, Me.mnuLaporanTBSMasuk, Me.mnuLaporanInvoice, Me.mnuLaporanHutangPembantu, Me.mnuLaporanDaftarCustomer, Me.mnuLaporanCustomerLimit, Me.mnuLaporanCustomerKomplain, Me.mnuRekaptbs, Me.mnuHutangDagang})
        Me.mnuLaporanUtama.Text = "&Laporan"
        '
        'mnuLaporanPembayaranTBS
        '
        Me.mnuLaporanPembayaranTBS.Name = "mnuLaporanPembayaranTBS"
        Me.mnuLaporanPembayaranTBS.Text = "Laporan &Pembayaran TBS"
        '
        'btnLaporanPembayaranGrossup
        '
        Me.btnLaporanPembayaranGrossup.Name = "btnLaporanPembayaranGrossup"
        Me.btnLaporanPembayaranGrossup.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnNPWP, Me.btnNPWP50, Me.btnNonNPWP, Me.btnNonNPWP50})
        Me.btnLaporanPembayaranGrossup.Text = "Laporan Pembayaran TBS Grossup"
        '
        'btnNPWP
        '
        Me.btnNPWP.Name = "btnNPWP"
        Me.btnNPWP.Text = "NPWP 100/99.75"
        '
        'btnNPWP50
        '
        Me.btnNPWP50.Name = "btnNPWP50"
        Me.btnNPWP50.Text = "NPWP 50% 100/99.875"
        '
        'btnNonNPWP
        '
        Me.btnNonNPWP.Name = "btnNonNPWP"
        Me.btnNonNPWP.Text = "Non NPWP 100/99.5"
        '
        'btnNonNPWP50
        '
        Me.btnNonNPWP50.Name = "btnNonNPWP50"
        Me.btnNonNPWP50.Text = "Non NPWP 50% 100/99.75"
        '
        'mnuLaporanPembayaranFee
        '
        Me.mnuLaporanPembayaranFee.Name = "mnuLaporanPembayaranFee"
        Me.mnuLaporanPembayaranFee.Text = "Laporan P&embayaran Fee"
        '
        'mnuLaporanTBSMasuk
        '
        Me.mnuLaporanTBSMasuk.BeginGroup = True
        Me.mnuLaporanTBSMasuk.Name = "mnuLaporanTBSMasuk"
        Me.mnuLaporanTBSMasuk.Text = "Laporan &TBS Masuk"
        '
        'mnuLaporanInvoice
        '
        Me.mnuLaporanInvoice.BeginGroup = True
        Me.mnuLaporanInvoice.Name = "mnuLaporanInvoice"
        Me.mnuLaporanInvoice.Text = "Laporan &Invoice"
        Me.mnuLaporanInvoice.Visible = False
        '
        'mnuLaporanHutangPembantu
        '
        Me.mnuLaporanHutangPembantu.Name = "mnuLaporanHutangPembantu"
        Me.mnuLaporanHutangPembantu.Text = "Laporan Hutang Pembantu"
        '
        'mnuLaporanDaftarCustomer
        '
        Me.mnuLaporanDaftarCustomer.BeginGroup = True
        Me.mnuLaporanDaftarCustomer.Name = "mnuLaporanDaftarCustomer"
        Me.mnuLaporanDaftarCustomer.Text = "Laporan Daftar &Customer"
        Me.mnuLaporanDaftarCustomer.Visible = False
        '
        'mnuLaporanCustomerLimit
        '
        Me.mnuLaporanCustomerLimit.Name = "mnuLaporanCustomerLimit"
        Me.mnuLaporanCustomerLimit.Text = "Laporan Customer &Limit"
        Me.mnuLaporanCustomerLimit.Visible = False
        '
        'mnuLaporanCustomerKomplain
        '
        Me.mnuLaporanCustomerKomplain.Name = "mnuLaporanCustomerKomplain"
        Me.mnuLaporanCustomerKomplain.Text = "Laporan Customer &Komlpain"
        Me.mnuLaporanCustomerKomplain.Visible = False
        '
        'mnuRekaptbs
        '
        Me.mnuRekaptbs.Name = "mnuRekaptbs"
        Me.mnuRekaptbs.Text = "&Laporan Rekap TBS"
        Me.mnuRekaptbs.Visible = False
        '
        'mnuHutangDagang
        '
        Me.mnuHutangDagang.Name = "mnuHutangDagang"
        Me.mnuHutangDagang.Text = "&Laporan Hutang Dagang"
        '
        'mnuPengaturan
        '
        Me.mnuPengaturan.Name = "mnuPengaturan"
        Me.mnuPengaturan.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuSettingCustomerSpesial, Me.mnuDaftarNamaBos, Me.mnuSettingCustomerGrossUp, Me.mnuGantiKota, Me.mnuHargaBrondolan, Me.mnuKelompokPapanSub, Me.mnuPotonganSub, Me.mnuPlatSub, Me.mnuPotonganPlat, Me.mnuTambahanPlat, Me.mnuPengecualianHargaSub, Me.mnuPengecualianBBSub, Me.mnuBanyakKelompokSub, Me.mnuPPH, Me.mnuSettingTanggalFee, Me.mnuSettingSPSI})
        Me.mnuPengaturan.Text = "&Pengaturan"
        '
        'mnuSettingCustomerSpesial
        '
        Me.mnuSettingCustomerSpesial.Name = "mnuSettingCustomerSpesial"
        Me.mnuSettingCustomerSpesial.Text = "Setting Customer Spesial"
        '
        'mnuDaftarNamaBos
        '
        Me.mnuDaftarNamaBos.Name = "mnuDaftarNamaBos"
        Me.mnuDaftarNamaBos.Text = "Setting Daftar Nama Bos"
        Me.mnuDaftarNamaBos.Visible = False
        '
        'mnuSettingCustomerGrossUp
        '
        Me.mnuSettingCustomerGrossUp.Name = "mnuSettingCustomerGrossUp"
        Me.mnuSettingCustomerGrossUp.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuGrossUpCustomer, Me.mnuGrossUpPerhitungan})
        Me.mnuSettingCustomerGrossUp.Text = "Setting Gross Up"
        '
        'mnuGrossUpCustomer
        '
        Me.mnuGrossUpCustomer.Name = "mnuGrossUpCustomer"
        Me.mnuGrossUpCustomer.Text = "Customers"
        '
        'mnuGrossUpPerhitungan
        '
        Me.mnuGrossUpPerhitungan.Name = "mnuGrossUpPerhitungan"
        Me.mnuGrossUpPerhitungan.Text = "Perhitungan"
        '
        'mnuGantiKota
        '
        Me.mnuGantiKota.Name = "mnuGantiKota"
        Me.mnuGantiKota.Text = "Setting Ganti Kota"
        '
        'mnuHargaBrondolan
        '
        Me.mnuHargaBrondolan.Name = "mnuHargaBrondolan"
        Me.mnuHargaBrondolan.Text = "Setting Harga Brondolan"
        '
        'mnuKelompokPapanSub
        '
        Me.mnuKelompokPapanSub.Name = "mnuKelompokPapanSub"
        Me.mnuKelompokPapanSub.Text = "Setting Kelompok Papan"
        '
        'mnuPotonganSub
        '
        Me.mnuPotonganSub.Name = "mnuPotonganSub"
        Me.mnuPotonganSub.Text = "Setting Potongan"
        '
        'mnuPlatSub
        '
        Me.mnuPlatSub.Name = "mnuPlatSub"
        Me.mnuPlatSub.Text = "Setting Plat"
        Me.mnuPlatSub.Visible = False
        '
        'mnuPotonganPlat
        '
        Me.mnuPotonganPlat.Name = "mnuPotonganPlat"
        Me.mnuPotonganPlat.Text = "Setting Potongan Plat"
        '
        'mnuTambahanPlat
        '
        Me.mnuTambahanPlat.Name = "mnuTambahanPlat"
        Me.mnuTambahanPlat.Text = "Setting Tambahan Plat"
        '
        'mnuPengecualianHargaSub
        '
        Me.mnuPengecualianHargaSub.Name = "mnuPengecualianHargaSub"
        Me.mnuPengecualianHargaSub.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnHarga025, Me.btnPengecualianHarga10, Me.mnuAtmp, Me.btnMarsada})
        Me.mnuPengecualianHargaSub.Text = "Setting Pengecualian Harga LIBO"
        '
        'btnHarga025
        '
        Me.btnHarga025.Name = "btnHarga025"
        Me.btnHarga025.Text = "Harga PJML dan Sejenis"
        '
        'btnPengecualianHarga10
        '
        Me.btnPengecualianHarga10.Name = "btnPengecualianHarga10"
        Me.btnPengecualianHarga10.Text = "Harga Hutgaul dan Sejenis"
        '
        'mnuAtmp
        '
        Me.mnuAtmp.Name = "mnuAtmp"
        Me.mnuAtmp.Text = "Harga ATMP dan Sejenis"
        '
        'btnMarsada
        '
        Me.btnMarsada.Name = "btnMarsada"
        Me.btnMarsada.Text = "Harga Pengecualian Marsada"
        '
        'mnuPengecualianBBSub
        '
        Me.mnuPengecualianBBSub.Name = "mnuPengecualianBBSub"
        Me.mnuPengecualianBBSub.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuHargaHandoko})
        Me.mnuPengecualianBBSub.Text = "Setting Pengecualian Harga BB"
        '
        'mnuHargaHandoko
        '
        Me.mnuHargaHandoko.Name = "mnuHargaHandoko"
        Me.mnuHargaHandoko.Text = "Harga Handoko Sejenis"
        '
        'mnuBanyakKelompokSub
        '
        Me.mnuBanyakKelompokSub.Name = "mnuBanyakKelompokSub"
        Me.mnuBanyakKelompokSub.Text = "Setting Plat"
        '
        'mnuPPH
        '
        Me.mnuPPH.Name = "mnuPPH"
        Me.mnuPPH.Text = "Setting PPH"
        '
        'mnuSettingTanggalFee
        '
        Me.mnuSettingTanggalFee.Name = "mnuSettingTanggalFee"
        Me.mnuSettingTanggalFee.Text = "Setting Tanggal Fee"
        Me.mnuSettingTanggalFee.Visible = False
        '
        'mnuSettingSPSI
        '
        Me.mnuSettingSPSI.Name = "mnuSettingSPSI"
        Me.mnuSettingSPSI.Text = "Setting SPSI"
        '
        'mnuOthersUtama
        '
        Me.mnuOthersUtama.Name = "mnuOthersUtama"
        Me.mnuOthersUtama.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuOthersImportDataPembelian})
        Me.mnuOthersUtama.Text = "&Others"
        '
        'mnuOthersImportDataPembelian
        '
        Me.mnuOthersImportDataPembelian.Name = "mnuOthersImportDataPembelian"
        Me.mnuOthersImportDataPembelian.Text = "&Import Data Pembelian"
        '
        'txtDatabase
        '
        Me.txtDatabase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtDatabase.Border.Class = "TextBoxBorder"
        Me.txtDatabase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDatabase.Location = New System.Drawing.Point(920, 524)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(97, 20)
        Me.txtDatabase.TabIndex = 9
        Me.txtDatabase.Visible = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 570)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.mnuUtama)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.Enabled = False
        Me.FlattenMDIBorder = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMainMenu"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmJam As System.Windows.Forms.Timer
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents lblStatusUserOn As DevComponents.DotNetBar.LabelItem
    Friend WithEvents statusTgljam As DevComponents.DotNetBar.LabelItem
    Friend WithEvents mnuUtama As DevComponents.DotNetBar.Bar
    Friend WithEvents mnuFileUtama As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileUser As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileGantiPassword As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTransaksiUtama As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileCustomer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileProduct As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileKeluar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTransaksiPembelian As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTransaksiPenjualan As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTransaksiPembayaran As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanUtama As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanTBSMasuk As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanPembayaranTBS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanPembayaranFee As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanDaftarCustomer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanCustomerLimit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuOthersUtama As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuOthersImportDataPembelian As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHarga As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileKota As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuFileKelompok As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTransaksiFee As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTransaksiInvoice As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblKota As DevComponents.DotNetBar.LabelItem
    Friend WithEvents mnuLaporanInvoice As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents txtDatabase As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents mnuLaporanCustomerKomplain As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRekaptbs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPengaturan As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGantiKota As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDaftarNamaBos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPotonganSub As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPlatSub As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPengecualianHargaSub As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuKelompokPapanSub As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBanyakKelompokSub As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPengecualianBBSub As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHarga025 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPengecualianHarga10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuAkkHargaRata As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPPH As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuAtmp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSettingTanggalFee As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSettingSPSI As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSPSI As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuLaporanHutangPembantu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSettingCustomerSpesial As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPinjaman As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuHutangDagang As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuHargaHandoko As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuHargaBrondolan As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuInfo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuPotonganPlat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuTambahanPlat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnMarsada As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnLaporanPembayaranGrossup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNPWP As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNPWP50 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNonNPWP As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNonNPWP50 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSettingCustomerGrossUp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGrossUpCustomer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGrossUpPerhitungan As DevComponents.DotNetBar.ButtonItem
End Class
