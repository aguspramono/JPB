Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLaporanTBSMasuk

    Private Sub btnLaporanT_Click(sender As Object, e As EventArgs) Handles btnLaporanT.Click
        If cbPilih.SelectedIndex = 0 Then
            Dim objReport As New LaporanTbsMasukTahunan
            Dim myQuery As String = "select*from Pembelian "
            Dim namaKolom As String() = {"Cari"}
            Dim isiKolom As Object() = {cboTTahun.SelectedItem.ToString}
            myQuery = myQuery & "where year(tgl2)=@cari"
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "'"
            objReport.Database.Tables("Pembelian").SetDataSource(clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1).Tables(0))
            myQuery = "select*from customer"
            objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
            myQuery = "select*from kelompok"
            objReport.Database.Tables("Kelompok").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
            If clsKoneksi.kotaOn = "1" Then
                objReport.SetParameterValue("Judul", "Laporan TBS Masuk Libo Tahun(" & cboTTahun.SelectedItem.ToString & ")")
            Else
                objReport.SetParameterValue("Judul", "Laporan TBS Masuk BinaBaru Tahun(" & cboTTahun.SelectedItem.ToString & ")")
            End If
            objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)


            frmLaporanView.rptView.ShowGroupTreeButton = False
            frmLaporanView.rptView.ReportSource = objReport
            frmLaporanView.rptView.Refresh()
            frmLaporanView.StartPosition = FormStartPosition.CenterScreen
            frmLaporanView.WindowState = FormWindowState.Maximized
            frmLaporanView.Show()
        Else
            Dim objReport As New LaporanTbsMasukTahunanPerNama
            Dim myQuery As String = "select*from Pembelian "
            Dim namaKolom As String() = {"Cari"}
            Dim isiKolom As Object() = {cboTTahun.SelectedItem.ToString}
            myQuery = myQuery & "where year(tgl2)=@cari"
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "'"
            objReport.Database.Tables("Pembelian").SetDataSource(clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1).Tables(0))
            myQuery = "select*from customer"
            objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
            myQuery = "select*from kelompok"
            objReport.Database.Tables("Kelompok").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
            If clsKoneksi.kotaOn = "1" Then
                objReport.SetParameterValue("Judul", "Laporan TBS Masuk Libo Tahun(" & cboTTahun.SelectedItem.ToString & ")")
            Else
                objReport.SetParameterValue("Judul", "Laporan TBS Masuk BinaBaru Tahun(" & cboTTahun.SelectedItem.ToString & ")")
            End If
            objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)


            frmLaporanView.rptView.ShowGroupTreeButton = False
            frmLaporanView.rptView.ReportSource = objReport
            frmLaporanView.rptView.Refresh()
            frmLaporanView.StartPosition = FormStartPosition.CenterScreen
            frmLaporanView.WindowState = FormWindowState.Maximized
            frmLaporanView.Show()
        End If


        
    End Sub

    Private Sub frmLaporanTBSMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTTahun.Items.Clear()
        cboTTahun.Items.Add(Year(Now))
        cboBTahun.Items.Clear()
        cboBTahun.Items.Add(Year(Now))
        For i = 1 To 3
            cboTTahun.Items.Add(Year(Now) - i)
            cboBTahun.Items.Add(Year(Now) - i)
        Next
        cboTTahun.SelectedIndex = 0
        cboBTahun.SelectedIndex = 0
        cbPilih.SelectedIndex = 0
        cboBBulan.SelectedIndex = (Month(Now) - 1)
        cboHViewBy.SelectedIndex = 0
    End Sub

    Private Sub btnLaporanB_Click(sender As Object, e As EventArgs) Handles btnLaporanB.Click
        Dim objReport As New laporanTBSMasukBulanan
        Dim myQuery As String = "select*from Pembelian "
        Dim namaKolom As String() = {"cari", "cari2"}
        Dim isiKolom As Object() = {cboBTahun.SelectedItem.ToString, cboBBulan.SelectedItem.ToString}
        myQuery = myQuery & "where year(tgl2)=@cari and month(tgl2)=@cari2"
        myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by tgl2"
        objReport.Database.Tables("Pembelian").SetDataSource(clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1).Tables(0))
        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan TBS Masuk Libo " & MonthName(cboBBulan.SelectedIndex + 1, True) & " " & cboTTahun.SelectedItem.ToString)
        Else
            objReport.SetParameterValue("Judul", "Laporan TBS Masuk BinaBaru " & MonthName(cboBBulan.SelectedIndex + 1, True) & " " & cboTTahun.SelectedItem.ToString)
        End If
        objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)


        frmLaporanView.rptView.ShowGroupTreeButton = False
        frmLaporanView.rptView.ReportSource = objReport
        frmLaporanView.rptView.Refresh()
        frmLaporanView.StartPosition = FormStartPosition.CenterScreen
        frmLaporanView.WindowState = FormWindowState.Maximized
        frmLaporanView.Show()
    End Sub

    Private Sub btnLaporanH_Click(sender As Object, e As EventArgs) Handles btnLaporanH.Click
        Dim objReport As New LaporanTbsMasukHarian
        Dim myQuery As String = "select*from Pembelian "
        Dim namaKolom As String() = {"cari", "cari2"}
        Dim isiKolom As Object() = {dtHTglAwal.Value.Date, dtHTglAkhir.Value.Date}
        myQuery = myQuery & "where tgl2>=@cari and tgl2<=@cari2"
        If cboHViewBy.SelectedIndex = 0 Then
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by noticket"
        Else
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by noaccount"
        End If
        objReport.Database.Tables("Pembelian").SetDataSource(clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1).Tables(0))
        myQuery = "select*from customer where kodekota='" & clsKoneksi.kotaOn & "'"
        objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1,myQuery).Tables(0))
        Dim strTgl As String = ""
        If dtHTglAwal.Value.Date = dtHTglAkhir.Value.Date Then
            strTgl = dtHTglAwal.Value.Date
        Else
            strTgl = dtHTglAwal.Value.Date & " ~ " & dtHTglAkhir.Value.Date
        End If
        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan TBS Masuk Libo Tgl " & strTgl)
        Else
            objReport.SetParameterValue("Judul", "Laporan TBS Masuk BinaBaru Tgl " & strTgl)
        End If
        objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)

        'objReport.PrintToPrinter(1, False, 0, 0)
        frmLaporanView.rptView.ShowGroupTreeButton = False
        frmLaporanView.rptView.ReportSource = objReport
        frmLaporanView.rptView.Refresh()
        frmLaporanView.StartPosition = FormStartPosition.CenterScreen
        frmLaporanView.WindowState = FormWindowState.Maximized
        frmLaporanView.Show()
    End Sub
End Class



