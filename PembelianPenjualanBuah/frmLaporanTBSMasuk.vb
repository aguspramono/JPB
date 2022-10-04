Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLaporanTBSMasuk

    Private Sub btnLaporanT_Click(sender As Object, e As EventArgs) Handles btnLaporanT.Click
        If cbPilih.SelectedIndex = 0 Then
            Dim objReport As Object
            If ckHarga.Checked = True Then

                objReport = New LaporanTbsMasukPernama2New

                Dim myQuery As String = "SELECT p.* FROM ((pembelian2 AS p LEFT JOIN customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN pengecualianbb AS pb ON p.NoAccount = pb.noAccount) LEFT JOIN pjmlsejenis AS pj ON p.NoAccount = pj.NoAccount"
                myQuery = myQuery & " Where year(p.Tgl2)='" & cboTTahun.SelectedItem.ToString & "'"
                myQuery = myQuery & " and p.kodekota='" & clsKoneksi.kotaOn & "' order by p.noticket "
                objReport.Database.Tables("Pembelian2").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "select*from customer"
                myQuery = myQuery
                objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select pb.* from pengecualianbb pb "
                myQuery = myQuery
                objReport.Database.Tables("pengecualianbb").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select pj.* from Pjmlsejenis pj "
                myQuery = myQuery
                objReport.Database.Tables("Pjmlsejenis").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select * from pengecualian "
                myQuery = myQuery
                objReport.Database.Tables("Pengecualian").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select * from PengecualianMarsada "
                myQuery = myQuery
                objReport.Database.Tables("PengecualianMarsada").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select * from potonganplat "
                myQuery = myQuery
                objReport.Database.Tables("PotonganPlat").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                If ckSPSI.Checked = True Then
                    myQuery = "Select * from SPSIKaliAccount "
                    myQuery = myQuery
                    objReport.Database.Tables("SPSIKaliAccount").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                    myQuery = "Select * from SPSIPenjumlahanPerAccount where Utama='Y' "
                    myQuery = myQuery
                    objReport.Database.Tables("SPSIPenjumlahanPerAccount").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                    myQuery = "Select * from Pinjaman "
                    myQuery = myQuery
                    objReport.Database.Tables("Pinjaman").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                    myQuery = "Select * from PinjamanTagihan where Status='Y' "
                    myQuery = myQuery
                    objReport.Database.Tables("PinjamanTagihan").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                End If

                

                myQuery = "Select * from grossup where tipeGrossup=0"
                myQuery = myQuery
                objReport.Database.Tables("grossup").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
                objReport.SetParameterValue("jenislaporangrossup", "0")

            Else

                objReport = New LaporanTbsMasukTahunan
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
                

            End If

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


            Dim objReport As Object
            If ckHarga.Checked = False Then

                objReport = New LaporanTbsMasukTahunanPerNama
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
            Else

                objReport = New LaporanTbsMasukPernama2New

                Dim myQuery As String = "SELECT p.* FROM ((pembelian2 AS p LEFT JOIN customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN pengecualianbb AS pb ON p.NoAccount = pb.noAccount) LEFT JOIN pjmlsejenis AS pj ON p.NoAccount = pj.NoAccount"
                myQuery = myQuery & " Where year(p.Tgl2)='" & cboTTahun.SelectedItem.ToString & "'"
                myQuery = myQuery & " and p.kodekota='" & clsKoneksi.kotaOn & "' order by p.noticket "
                objReport.Database.Tables("Pembelian2").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "select*from customer"
                myQuery = myQuery
                objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select pb.* from pengecualianbb pb "
                myQuery = myQuery
                objReport.Database.Tables("pengecualianbb").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select pj.* from Pjmlsejenis pj "
                myQuery = myQuery
                objReport.Database.Tables("Pjmlsejenis").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select * from pengecualian "
                myQuery = myQuery
                objReport.Database.Tables("Pengecualian").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select * from PengecualianMarsada "
                myQuery = myQuery
                objReport.Database.Tables("PengecualianMarsada").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                myQuery = "Select * from potonganplat "
                myQuery = myQuery
                objReport.Database.Tables("PotonganPlat").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                If ckSPSI.Checked = True Then
                    myQuery = "Select * from SPSIKaliAccount "
                    myQuery = myQuery
                    objReport.Database.Tables("SPSIKaliAccount").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                    myQuery = "Select * from SPSIPenjumlahanPerAccount where Utama='Y' "
                    myQuery = myQuery
                    objReport.Database.Tables("SPSIPenjumlahanPerAccount").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                    myQuery = "Select * from Pinjaman "
                    myQuery = myQuery
                    objReport.Database.Tables("Pinjaman").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                    myQuery = "Select * from PinjamanTagihan where Status='Y' "
                    myQuery = myQuery
                    objReport.Database.Tables("PinjamanTagihan").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

                End If

                myQuery = "Select * from grossup where tipeGrossup=0"
                myQuery = myQuery
                objReport.Database.Tables("grossup").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
                objReport.SetParameterValue("jenislaporangrossup", "0")


            End If

            If clsKoneksi.kotaOn = "1" Then
                objReport.SetParameterValue("Judul", "Laporan TBS Masuk Libo Tahun(" & cboTTahun.SelectedItem.ToString & ")")
            Else
                objReport.SetParameterValue("Judul", "Laporan TBS Masuk BinaBaru Tahun(" & cboTTahun.SelectedItem.ToString & ")")
            End If
            objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)
            objReport.SetParameterValue("jenislaporangrossup", "0")

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

    Private Sub btnProses2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckHarga_CheckedChanged(sender As Object, e As EventArgs) Handles ckHarga.CheckedChanged
        If ckHarga.Checked = True Then
            ckSPSI.Visible = True
        Else
            ckSPSI.Visible = False
        End If
    End Sub
End Class



