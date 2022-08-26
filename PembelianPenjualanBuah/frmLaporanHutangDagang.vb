Imports CrystalDecisions.CrystalReports.Engine
Public Class frmLaporanHutangDagang

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim objReport As Object
        If ckRekap.Checked = False Then
            objReport = New LaporanBukaPembayaranTBS
        Else
            objReport = New LaporanRekapBukaPembayaranTBS
        End If

        Dim myQuery As String
        Dim whereWaku As String = ""
        Dim whereNoAccount As String = ""
        Dim whereKodeBayar As String = ""
        Dim whereLunas As String = ""

        If ckTahun.Checked = True Then
            whereWaku = "where year(Tgl2)='" & cmbTahun2.Text & "' and NoAccount like '%" & txtCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "' "
        Else
            whereWaku = "where month(Tgl2)='" & cmbbulan2.Text & "' and year(Tgl2)='" & cmbTahun2.Text & "' and NoAccount like '%" & txtCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "' "
        End If

        myQuery = "select*from Pembelian2 " & whereWaku & " order by NoTicket"
        myQuery = myQuery
        objReport.Database.Tables("Pembelian2").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from PembayaranDetail where StatusBayar='Y' order by KodePembayaran"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranDetail").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from PembayaranFeeDetail where StatusBayar='Y'"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranFee1Detail").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from PembayaranFee"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranFee1").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from customer"
        myQuery = myQuery
        objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from Pembayaran"
        myQuery = myQuery
        objReport.Database.Tables("Pembayaran").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from pengecualianbb"
        myQuery = myQuery
        objReport.Database.Tables("pengecualianbb").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "select*from potonganplat"
        myQuery = myQuery
        objReport.Database.Tables("PotonganPlat").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan Hutang Dagang Libo Tahun(" & cmbTahun2.SelectedItem.ToString & ")")
        Else
            objReport.SetParameterValue("Judul", "Laporan Hutang Dagang BinaBaru Tahun(" & cmbTahun2.SelectedItem.ToString & ")")
        End If
        If ckTahun.Checked = True Then
            objReport.SetParameterValue("Waktu", "Tahun " & cmbTahun2.SelectedItem.ToString & "")
        Else
            objReport.SetParameterValue("Waktu", "Bulan " & cmbbulan2.SelectedItem.ToString & "," & cmbTahun2.SelectedItem.ToString & "")
        End If
        frmLaporanView.rptView.ShowGroupTreeButton = False
        frmLaporanView.rptView.ReportSource = objReport
        frmLaporanView.rptView.ShowRefreshButton = False
        frmLaporanView.rptView.Refresh()
        frmLaporanView.StartPosition = FormStartPosition.CenterScreen
        frmLaporanView.WindowState = FormWindowState.Maximized
        frmLaporanView.Show()

    End Sub

    Private Sub frmLaporanHutangDagang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTahun2.Items.Clear()
        cmbTahun2.Items.Add(Year(Now))
        For i = 1 To 15
            cmbTahun2.Items.Add(Year(Now) - i)
        Next
        cmbTahun2.SelectedIndex = 0
        cmbbulan2.SelectedIndex = (Month(Now) - 1)
    End Sub

End Class