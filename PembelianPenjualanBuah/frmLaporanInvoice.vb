Public Class frmLaporanInvoice

    Private Sub btnLaporanH_Click(sender As Object, e As EventArgs) Handles btnLaporanH.Click
        Dim objReport As New laporanInvoice
        Dim myQuery As String = "select*from Invoice "
        Dim namaKolom As String() = {"cari", "cari2"}
        Dim isiKolom As Object() = {dtHTglAwal.Value.Date, dtHTglAkhir.Value.Date}
        myQuery = myQuery & "where tgl>=@cari and tgl<=@cari2"
        Dim tInt As Integer = cboTipe.SelectedIndex
        Select Case tInt
            Case 0
                'myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' "
            Case 1 'tipe 1 tbs
                myQuery = myQuery & " and tipe='1' "
            Case 2 'tipe 2 fee
                myQuery = myQuery & " and tipe='2' "
            Case 3 'tipe 0 kode pembayaran belum isi
                myQuery = myQuery & " and tipe='0' "
        End Select
        If chkSisa.Checked Then
            myQuery = myQuery & " and Sisa>0 "
        End If
        If cboOrder.SelectedIndex = 0 Then
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by NoInvoice"
        Else
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by noaccount"
        End If
        objReport.Database.Tables("Invoice").SetDataSource(clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1).Tables(0))
        Dim strTgl As String = ""
        If dtHTglAwal.Value.Date = dtHTglAkhir.Value.Date Then
            strTgl = dtHTglAwal.Value.Date
        Else
            strTgl = dtHTglAwal.Value.Date & " ~ " & dtHTglAkhir.Value.Date
        End If
        Dim strTipe As String = ""
        Select Case tInt
            Case 0
            Case 1 'tipe 1 tbs
                strTipe = "TBS"
            Case 2 'tipe 2 fee
                strTipe = "Fee"
            Case 3 'tipe 0 kode pembayaran belum isi
                strTipe = "Kode Pembayaran Belum ada"
        End Select
        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan Libo Invoice " & strTipe & " Tgl " & strTgl)
        Else
            objReport.SetParameterValue("Judul", "Laporan BinaBaru Invoice " & strTipe & " Tgl " & strTgl)
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

    Private Sub frmLaporanInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipe.SelectedIndex = 0
        cboOrder.SelectedIndex = 0
    End Sub

    Private Sub btnInvoiceDetail_Click(sender As Object, e As EventArgs) Handles btnInvoiceDetail.Click
        Dim objReport As New LaporanInvoiceDetail
        Dim myQuery As String = "select*from Invoice "
        Dim namaKolom As String() = {"cari", "cari2"}
        Dim isiKolom As Object() = {dtHTglAwal.Value.Date, dtHTglAkhir.Value.Date}
        myQuery = myQuery & "where tgl>=@cari and tgl<=@cari2"
        Dim tInt As Integer = cboTipe.SelectedIndex
        Select Case tInt
            Case 0
                'myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' "
            Case 1 'tipe 1 tbs
                myQuery = myQuery & " and tipe='1' "
            Case 2 'tipe 2 fee
                myQuery = myQuery & " and tipe='2' "
            Case 3 'tipe 0 kode pembayaran belum isi
                myQuery = myQuery & " and tipe='0' "
        End Select
        If chkSisa.Checked Then
            myQuery = myQuery & " and Sisa>0 "
        End If
        If cboOrder.SelectedIndex = 0 Then
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by NoInvoice"
        Else
            myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by noaccount"
        End If
        objReport.Database.Tables("Invoice").SetDataSource(clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1).Tables(0))
        myQuery = myQuery.Replace("order by NoInvoice", "")
        myQuery = myQuery.Replace("order by noaccount", "")
        myQuery = myQuery.Replace("select*from Invoice", "select noinvoice from Invoice")
        myQuery = " select*from InvoiceDetail Where KodeKota='" & clsKoneksi.kotaOn & "' and noinvoice in(" & myQuery & ") order by tgl"
        objReport.Database.Tables("InvoiceDetail").SetDataSource(clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1).Tables(0))
        Dim strTgl As String = ""
        If dtHTglAwal.Value.Date = dtHTglAkhir.Value.Date Then
            strTgl = dtHTglAwal.Value.Date
        Else
            strTgl = dtHTglAwal.Value.Date & " ~ " & dtHTglAkhir.Value.Date
        End If
        Dim strTipe As String = ""
        Select Case tInt
            Case 0
            Case 1 'tipe 1 tbs
                strTipe = "TBS"
            Case 2 'tipe 2 fee
                strTipe = "Fee"
            Case 3 'tipe 0 kode pembayaran belum isi
                strTipe = "Kode Pembayaran Belum ada"
        End Select
        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan Libo Invoice Detail " & strTipe & " Tgl " & strTgl)
        Else
            objReport.SetParameterValue("Judul", "Laporan BinaBaru Invoice Detail " & strTipe & " Tgl " & strTgl)
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