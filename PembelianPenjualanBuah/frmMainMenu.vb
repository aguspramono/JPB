Imports System.IO
Public Class frmMainMenu

    Sub database()
        Dim FILE_NAME As String = Application.StartupPath + "\setting.txt"
        If File.Exists(FILE_NAME) = True Then
            Dim content2 As String() = clsKoneksi.ReadFile(FILE_NAME)
            txtDatabase.Text = content2(0)
        Else
            MessageBox.Show("File setting.txt tidak ditemukan, program akan membuat file setting.txt baru secara otomatis")
        End If
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Main Menu(V " & Application.ProductVersion & ")"
        database()
    End Sub

    Private Sub tmJam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmJam.Tick
        statusTgljam.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss")
    End Sub

    Private Sub mnuFileKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileKeluar.Click
        End
    End Sub

    Private Sub mnuFileCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileCustomer.Click
        frmCustomer.MdiParent = Me
        frmCustomer.Show()
        frmCustomer.Focus()
    End Sub

    Private Sub mnuFileProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileProduct.Click
        frmProduct.MdiParent = Me
        frmProduct.Show()
        frmProduct.Focus()
    End Sub

    Private Sub mnuFileUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileUser.Click
        frmUser.MdiParent = Me
        frmUser.Show()
        frmUser.Focus()
    End Sub

    Private Sub mnuFileGantiPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileGantiPassword.Click
        frmGantiPassword.MdiParent = Me
        frmGantiPassword.Show()
        frmGantiPassword.Focus()
    End Sub

    Private Sub mnuTransaksiPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTransaksiPembelian.Click
        frmInputHarga.MdiParent = Me
        frmInputHarga.Show()
        frmInputHarga.Focus()
    End Sub

    Private Sub mnuTransaksiPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTransaksiPenjualan.Click
        frmPenjualan.MdiParent = Me
        frmPenjualan.Show()
        frmPenjualan.Focus()
    End Sub

    Private Sub mnuTransaksiPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTransaksiPembayaran.Click
        frmPembayaran.MdiParent = Me
        frmPembayaran.Show()
        frmPembayaran.Focus()
    End Sub

    Private Sub mnuLaporanTBSMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLaporanTBSMasuk.Click
        frmLaporanTBSMasuk.MdiParent = Me
        frmLaporanTBSMasuk.Show()
        frmLaporanTBSMasuk.Focus()
    End Sub

    Private Sub mnuLaporanPembayaranTBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLaporanPembayaranTBS.Click
        frmLaporanPembayaran.Text = "Laporan Pembayaran"
        frmLaporanPembayaran.dgView.Rows.Clear()
        frmLaporanPembayaran.jenislaporanpembayaran = 0
        frmLaporanPembayaran.cmbGross.Enabled = True
        frmLaporanPembayaran.MdiParent = Me
        frmLaporanPembayaran.Show()
        frmLaporanPembayaran.Focus()
    End Sub

    Private Sub mnuLaporanPembayaranFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLaporanPembayaranFee.Click
        frmLaporanPembayaranFee.MdiParent = Me
        frmLaporanPembayaranFee.Show()
        frmLaporanPembayaranFee.Focus()
    End Sub

    Private Sub mnuOthersImportDataPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOthersImportDataPembelian.Click
        frmImportDataPembelian.MdiParent = Me
        frmImportDataPembelian.Show()
        frmImportDataPembelian.Focus()
    End Sub

    Private Sub frmMainMenu_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Hide()
        clsKoneksi.loadData()
        clsKoneksi.createNewConnection()
        frmLogin.ShowDialog()
        statusTgljam.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss")
    End Sub

    Private Sub btnHarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHarga.Click
        frmUpdateHarga.MdiParent = Me
        frmUpdateHarga.Show()
        frmUpdateHarga.Focus()
    End Sub

    Private Sub mnuFileKota_Click(sender As Object, e As EventArgs) Handles mnuFileKota.Click
        frmKota.MdiParent = Me
        frmKota.Show()
        frmKota.Focus()
    End Sub

    Private Sub mnuFileKelompok_Click(sender As Object, e As EventArgs) Handles mnuFileKelompok.Click
        frmKelompok.MdiParent = Me
        frmKelompok.Show()
        frmKelompok.Focus()
    End Sub

    Private Sub mnuTransaksiFee_Click(sender As Object, e As EventArgs) Handles mnuTransaksiFee.Click
        frmPembayaranFee.MdiParent = Me
        frmPembayaranFee.Show()
        frmPembayaranFee.Focus()
    End Sub

    Private Sub mnuTransaksiInvoice_Click(sender As Object, e As EventArgs) Handles mnuTransaksiInvoice.Click
        frmInvoice.MdiParent = Me
        frmInvoice.Show()
        frmInvoice.Focus()
    End Sub

    Private Sub mnuOthersGantiKota_Click(sender As Object, e As EventArgs)
        frmGantiKota.ShowDialog()
    End Sub

    Private Sub mnuLaporanInvoice_Click(sender As Object, e As EventArgs) Handles mnuLaporanInvoice.Click
        frmLaporanInvoice.MdiParent = Me
        frmLaporanInvoice.Show()
        frmLaporanInvoice.Focus()
    End Sub

    Private Sub mnuRekaptbs_Click(sender As Object, e As EventArgs) Handles mnuRekaptbs.Click
        frmLaporanRekapTbs.MdiParent = Me
        frmLaporanRekapTbs.Show()
        frmLaporanRekapTbs.Focus()
    End Sub

    Private Sub mnuBos_Click(sender As Object, e As EventArgs)
        frmSettingNamaBos.MdiParent = Me
        frmSettingNamaBos.Show()
        frmSettingNamaBos.Focus()
    End Sub

    Private Sub mnuPotongan_Click(sender As Object, e As EventArgs)
        frmPotongan.MdiParent = Me
        frmPotongan.Show()
        frmPotongan.Focus()
    End Sub

    Private Sub mnPlat_Click(sender As Object, e As EventArgs)
        frmPlat.MdiParent = Me
        frmPlat.Show()
        frmPlat.Focus()
    End Sub

    Private Sub mnuPengecualianHarga_Click(sender As Object, e As EventArgs)
        frmPengecualianHarga.MdiParent = Me
        frmPengecualianHarga.Show()
        frmPengecualianHarga.Focus()
    End Sub

    Private Sub mnuKelompokPapan_Click(sender As Object, e As EventArgs)
        frmKelompokPapan.MdiParent = Me
        frmKelompokPapan.Show()
        frmKelompokPapan.Focus()
    End Sub

    Private Sub mnuAnakPlat_Click(sender As Object, e As EventArgs)
        frmCustomerBerdasarkanPlat.MdiParent = Me
        frmCustomerBerdasarkanPlat.Show()
        frmCustomerBerdasarkanPlat.Focus()
    End Sub

    Private Sub mnuAnakTBS_Click(sender As Object, e As EventArgs)
        frmCustomerBerdasarkanTBS.MdiParent = Me
        frmCustomerBerdasarkanTBS.Show()
        frmCustomerBerdasarkanTBS.Focus()
    End Sub

    Private Sub mnuBBpengecualian_Click(sender As Object, e As EventArgs)
        frmBBPengecualian.MdiParent = Me
        frmBBPengecualian.Show()
        frmBBPengecualian.Focus()
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs)
        frmCustomerBerdasarkanTBS.MdiParent = Me
        frmCustomerBerdasarkanTBS.Show()
        frmCustomerBerdasarkanTBS.Focus()
    End Sub

    Private Sub mnuKelompokPapanSub_Click(sender As Object, e As EventArgs) Handles mnuKelompokPapanSub.Click
        frmKelompokPapan.MdiParent = Me
        frmKelompokPapan.Show()
        frmKelompokPapan.Focus()
    End Sub

    Private Sub mnuPlatSub_Click(sender As Object, e As EventArgs) Handles mnuPlatSub.Click
        frmPlat.MdiParent = Me
        frmPlat.Show()
        frmPlat.Focus()
    End Sub

    Private Sub mnuPotonganSub_Click(sender As Object, e As EventArgs) Handles mnuPotonganSub.Click
        frmPotongan.MdiParent = Me
        frmPotongan.Show()
        frmPotongan.Focus()
    End Sub

    Private Sub mnuDaftarNamaBos_Click(sender As Object, e As EventArgs) Handles mnuDaftarNamaBos.Click
        frmSettingNamaBos.MdiParent = Me
        frmSettingNamaBos.Show()
        frmSettingNamaBos.Focus()
    End Sub

    Private Sub mnuGantiKota_Click(sender As Object, e As EventArgs) Handles mnuGantiKota.Click
        frmGantiKota.ShowDialog()
    End Sub

    Private Sub btnPengecualianHarga10_Click(sender As Object, e As EventArgs) Handles btnPengecualianHarga10.Click
        frmPengecualianHarga.MdiParent = Me
        frmPengecualianHarga.Show()
        frmPengecualianHarga.Focus()
    End Sub

    Private Sub btnHarga025_Click(sender As Object, e As EventArgs) Handles btnHarga025.Click
        frmPjmldanSejenisnya.MdiParent = Me
        frmPjmldanSejenisnya.Show()
        frmPjmldanSejenisnya.Focus()
    End Sub

    Private Sub mnuAkkHargaRata_Click(sender As Object, e As EventArgs) Handles mnuAkkHargaRata.Click
        FrmAkkHargaRata2.MdiParent = Me
        FrmAkkHargaRata2.Show()
        FrmAkkHargaRata2.Focus()
    End Sub

    Private Sub mnuBanyakKelompokSub_Click(sender As Object, e As EventArgs) Handles mnuBanyakKelompokSub.Click
        frmCustomerBerdasarkanPlat.MdiParent = Me
        frmCustomerBerdasarkanPlat.Show()
        frmCustomerBerdasarkanPlat.Focus()
    End Sub

    Private Sub mnuPPH_Click(sender As Object, e As EventArgs) Handles mnuPPH.Click
        frmPPH.MdiParent = Me
        frmPPH.Show()
        frmPPH.Focus()
    End Sub

    Private Sub mnuAtmp_Click(sender As Object, e As EventArgs) Handles mnuAtmp.Click
        frmAtmpdanSejenisnya.MdiParent = Me
        frmAtmpdanSejenisnya.Show()
        frmAtmpdanSejenisnya.Focus()
    End Sub

    Private Sub mnuSettingTanggalFee_Click(sender As Object, e As EventArgs) Handles mnuSettingTanggalFee.Click
        frmSettingTanggalFee.MdiParent = Me
        frmSettingTanggalFee.Show()
        frmSettingTanggalFee.Focus()
    End Sub

    Private Sub mnuSettingSPSI_Click(sender As Object, e As EventArgs) Handles mnuSettingSPSI.Click
        frmSettingSPSI.MdiParent = Me
        frmSettingSPSI.Show()
        frmSettingSPSI.Focus()
    End Sub

    Private Sub mnuSPSI_Click(sender As Object, e As EventArgs) Handles mnuSPSI.Click
        frmSPSI.MdiParent = Me
        frmSPSI.Show()
        frmSPSI.Focus()
    End Sub

    Private Sub mnuLaporanHutangPembantu_Click(sender As Object, e As EventArgs) Handles mnuLaporanHutangPembantu.Click
        frmLaporanHutangPembantu.MdiParent = Me
        frmLaporanHutangPembantu.Show()
        frmLaporanHutangPembantu.Focus()
    End Sub

    Private Sub mnuSettingCustomerSpesial_Click(sender As Object, e As EventArgs) Handles mnuSettingCustomerSpesial.Click
        frmSpesialCustomer.MdiParent = Me
        frmSpesialCustomer.Show()
        frmSpesialCustomer.Focus()
    End Sub

    Private Sub mnuPinjaman_Click(sender As Object, e As EventArgs) Handles mnuPinjaman.Click
        frmPinjaman.MdiParent = Me
        frmPinjaman.Show()
        frmPinjaman.Focus()
    End Sub

    Private Sub mnuHutangDagang_Click(sender As Object, e As EventArgs) Handles mnuHutangDagang.Click
        frmLaporanHutangDagang.MdiParent = Me
        frmLaporanHutangDagang.Show()
        frmLaporanHutangDagang.Focus()
    End Sub

    Private Sub mnuHargaHandoko_Click(sender As Object, e As EventArgs) Handles mnuHargaHandoko.Click
        frmBBPengecualian.MdiParent = Me
        frmBBPengecualian.Show()
        frmBBPengecualian.Focus()
    End Sub

    Private Sub mnuHargaBrondolan_Click(sender As Object, e As EventArgs) Handles mnuHargaBrondolan.Click
        frmInputHargaBrondolan.MdiParent = Me
        frmInputHargaBrondolan.Show()
        frmInputHargaBrondolan.Focus()
    End Sub

    Private Sub mnuInfo_Click(sender As Object, e As EventArgs) Handles mnuInfo.Click
        frmChangeLog.ShowDialog()
    End Sub

    Private Sub mnuPotonganPlat_Click(sender As Object, e As EventArgs) Handles mnuPotonganPlat.Click
        frmPotonganPlat.MdiParent = Me
        frmPotonganPlat.Show()
        frmPotonganPlat.Focus()
    End Sub

    Private Sub mnuTambahanPlat_Click(sender As Object, e As EventArgs) Handles mnuTambahanPlat.Click
        frmTambahanHargaPlat.MdiParent = Me
        frmTambahanHargaPlat.Show()
        frmTambahanHargaPlat.Focus()
    End Sub

    Private Sub btnMarsada_Click(sender As Object, e As EventArgs) Handles btnMarsada.Click
        frmSettingMarsada.MdiParent = Me
        frmSettingMarsada.Show()
        frmSettingMarsada.Focus()
    End Sub

    Private Sub mnuGrossUpCustomer_Click(sender As Object, e As EventArgs) Handles mnuGrossUpCustomer.Click
        frmSettingCustomerGrossUp.MdiParent = Me
        frmSettingCustomerGrossUp.Show()
        frmSettingCustomerGrossUp.Focus()
    End Sub

    Private Sub mnuGrossUpPerhitungan_Click(sender As Object, e As EventArgs) Handles mnuGrossUpPerhitungan.Click
        frmSettingPerhitunganGrossup.MdiParent = Me
        frmSettingPerhitunganGrossup.Show()
        frmSettingPerhitunganGrossup.Focus()
    End Sub

    Private Sub btnNPWP_Click(sender As Object, e As EventArgs) Handles btnNPWP.Click
        frmLaporanPembayaran.Text = "Laporan Pembayaran Gross Up - " & btnNPWP.Text
        frmLaporanPembayaran.dgView.Rows.Clear()
        frmLaporanPembayaran.jenislaporanpembayaran = 1
        frmLaporanPembayaran.cmbGross.Enabled = False
        frmLaporanPembayaran.MdiParent = Me
        frmLaporanPembayaran.Show()
        frmLaporanPembayaran.Focus()
    End Sub

    Private Sub btnNPWP50_Click(sender As Object, e As EventArgs) Handles btnNPWP50.Click
        frmLaporanPembayaran.Text = "Laporan Pembayaran Gross Up - " & btnNPWP50.Text
        frmLaporanPembayaran.dgView.Rows.Clear()
        frmLaporanPembayaran.jenislaporanpembayaran = 2
        frmLaporanPembayaran.cmbGross.Enabled = False
        frmLaporanPembayaran.MdiParent = Me
        frmLaporanPembayaran.Show()
        frmLaporanPembayaran.Focus()
    End Sub

    Private Sub btnNonNPWP_Click(sender As Object, e As EventArgs) Handles btnNonNPWP.Click
        frmLaporanPembayaran.Text = "Laporan Pembayaran Gross Up - " & btnNonNPWP.Text
        frmLaporanPembayaran.dgView.Rows.Clear()
        frmLaporanPembayaran.jenislaporanpembayaran = 3
        frmLaporanPembayaran.cmbGross.Enabled = False
        frmLaporanPembayaran.MdiParent = Me
        frmLaporanPembayaran.Show()
        frmLaporanPembayaran.Focus()
    End Sub

    Private Sub btnNonNPWP50_Click(sender As Object, e As EventArgs) Handles btnNonNPWP50.Click
        frmLaporanPembayaran.Text = "Laporan Pembayaran Gross Up - " & btnNonNPWP50.Text
        frmLaporanPembayaran.dgView.Rows.Clear()
        frmLaporanPembayaran.jenislaporanpembayaran = 4
        frmLaporanPembayaran.cmbGross.Enabled = False
        frmLaporanPembayaran.MdiParent = Me
        frmLaporanPembayaran.Show()
        frmLaporanPembayaran.Focus()
    End Sub
End Class