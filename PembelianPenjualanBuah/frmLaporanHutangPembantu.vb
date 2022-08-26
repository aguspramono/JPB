Public Class frmLaporanHutangPembantu
    Public noAccount As String = ""

    Sub noTicket()
        Dim getTanggal As String = ""
        If rdHarian.Checked = True Then
            getTanggal = " and (datevalue(p.Tgl2)>=#" & Format(dtpDari.Value, "MM/dd/yyyy") & "# and datevalue(p.Tgl2)<=#" & Format(dtpSampai.Value, "MM/dd/yyyy") & "#) "
        End If

        If rdBulanan.Checked = True Then
            getTanggal = " and month(p.Tgl2)='" & dtpDari.Value.Month & "' and year(p.Tgl2)='" & dtpDari.Value.Year & "' "
        End If

        If rdTahunan.Checked = True Then
            getTanggal = " and year(p.Tgl2)='" & dtpDari.Value.Year & "' "
        End If

        Dim myQuery As String = "select c.KodeKelompok from (PembayaranFeeDetail as pd inner join pembelian2 as p  on (p.NoTicket=pd.NoTicket)) inner join customer c on(c.NoAccount=p.NoAccount)  "
        myQuery = myQuery & "where p.kodekota='" & clsKoneksi.kotaOn & "' " & getTanggal & "  group by c.KodeKelompok Order By c.KodeKelompok"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData1.Rows.Clear()
        Dim isiView(0) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvData1.Rows.Add(isiView)
        Next
    End Sub

    Sub fee()

        Dim getTanggal As String = ""
        If rdHarian.Checked = True Then
            getTanggal = " and (datevalue(p.Tgl2)>=#" & Format(dtpDari.Value, "MM/dd/yyyy") & "# and datevalue(p.Tgl2)<=#" & Format(dtpSampai.Value, "MM/dd/yyyy") & "#) "
        End If

        If rdBulanan.Checked = True Then
            getTanggal = " and month(p.Tgl2)='" & dtpDari.Value.Month & "' and year(p.Tgl2)='" & dtpDari.Value.Year & "' "
        End If

        If rdTahunan.Checked = True Then
            getTanggal = " and year(p.Tgl2)='" & dtpDari.Value.Year & "' "
        End If

        Dim myQuery As String = "select c.KodeKelompok,pd.Fee,pd.KodePembayaran,pf.Tgl from ((PembayaranFeeDetail as pd inner join pembelian2 as p  on (p.NoTicket=pd.NoTicket)) inner join customer c on(c.NoAccount=p.NoAccount)) inner join PembayaranFee as pf on (pf.KodePembayaran=pd.KodePembayaran) "
        myQuery = myQuery & "where p.kodekota='" & clsKoneksi.kotaOn & "' " & getTanggal & "  group by c.KodeKelompok,pd.Fee,pd.KodePembayaran,pf.Tgl Order By c.KodeKelompok"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData2.Rows.Clear()
        Dim isiView(3) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvData2.Rows.Add(isiView)
        Next
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        'MsgBox("Dalam proses perbaikan")
        'Return
        Dim objReport As New LaporanHutangPembantuNew1

        Dim getTanggal As String = ""
        If rdHarian.Checked = True Then
            getTanggal = " and (datevalue(p.Tgl2)>=#" & Format(dtpDari.Value, "MM/dd/yyyy") & "# and datevalue(p.Tgl2)<=#" & Format(dtpSampai.Value, "MM/dd/yyyy") & "#) "
        End If

        If rdBulanan.Checked = True Then
            getTanggal = " and month(p.Tgl2)='" & dtpDari.Value.Month & "' and year(p.Tgl2)='" & dtpDari.Value.Year & "' "
        End If

        If rdTahunan.Checked = True Then
            getTanggal = " and year(p.Tgl2)='" & dtpDari.Value.Year & "' "
        End If

        Dim getAccount As String = ""
        If noAccount <> "" Then
            getAccount = " and P.NoAccount='" & noAccount & "' "
        End If


        Dim myQuery As String = "select * from Pembelian2 as p where p.KodeKota='" & clsKoneksi.kotaOn & "'" & getTanggal & "" & getAccount & ""
        myQuery = myQuery
        objReport.Database.Tables("Pembelian2").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from PembayaranFeeDetail"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranFee1Detail").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from pengecualianbb"
        myQuery = myQuery
        objReport.Database.Tables("pengecualianbb").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from customer"
        myQuery = myQuery
        objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from PembayaranDetail where KodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranDetail").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from pembayaran"
        myQuery = myQuery
        objReport.Database.Tables("pembayaran").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from PembayaranBertahap"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranBertahap").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from PembayaranFee where KodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        objReport.Database.Tables("PembayaranFee1").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        myQuery = "Select * from PotonganPlat where KodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        objReport.Database.Tables("PotonganPlat").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        noTicket()
        fee()


        Dim query As String = ""
        If dgvData1.Rows.Count > 0 Then
            Dim fee1T As Integer = 0
            Dim fee2T As Integer = 0
            Dim fee3T As Integer = 0
            Dim fee4T As Integer = 0
            Dim kodeFee1 As String = "-"
            Dim kodeFee2 As String = "-"
            Dim kodeFee3 As String = "-"
            Dim kodeFee4 As String = "-"
            Dim Tgl1 As String = "-"
            Dim Tgl2 As String = "-"
            Dim Tgl3 As String = "-"
            Dim Tgl4 As String = "-"
            Dim tmasuk As Integer = 0

            query = "select kodeKelompok,Fee1,KodeFee1,Tgl1,Fee2,KodeFee2,Tgl2,Fee3,KodeFee3,Tgl3,Fee4,KodeFee4,Tgl4,Fee5,KodeFee5,Tgl5 from("
            For i As Integer = 0 To dgvData1.Rows.Count - 1
                For j As Integer = 0 To dgvData2.Rows.Count - 1
                    If dgvData1.Rows(i).Cells(0).Value = dgvData2.Rows(j).Cells(0).Value Then
                        Select Case tmasuk
                            Case 0
                                fee1T = dgvData2.Rows(j).Cells(1).Value
                                kodeFee1 = dgvData2.Rows(j).Cells(2).Value
                                Tgl1 = dgvData2.Rows(j).Cells(3).Value
                            Case 1
                                fee2T = dgvData2.Rows(j).Cells(1).Value
                                kodeFee2 = dgvData2.Rows(j).Cells(2).Value
                                Tgl2 = dgvData2.Rows(j).Cells(3).Value
                            Case 2
                                fee3T = dgvData2.Rows(j).Cells(1).Value
                                kodeFee3 = dgvData2.Rows(j).Cells(2).Value
                                Tgl3 = dgvData2.Rows(j).Cells(3).Value
                            Case 3
                                fee4T = dgvData2.Rows(j).Cells(1).Value
                                kodeFee4 = dgvData2.Rows(j).Cells(2).Value
                                Tgl4 = dgvData2.Rows(j).Cells(3).Value
                        End Select
                        tmasuk += 1
                    Else
                        tmasuk = 0
                    End If
                Next

                If i = 0 Then
                    query &= "select kodeKelompok, " & fee1T & " as Fee1,'" & kodeFee1 & "' as KodeFee1,'" & Tgl1 & "' as Tgl1," & fee2T & " as Fee2,'" & kodeFee2 & "' as KodeFee2,'" & Tgl2 & "' as Tgl2," & fee3T & " as Fee3,'" & kodeFee3 & "' as KodeFee3,'" & Tgl3 & "' as Tgl3," & fee4T & " as Fee4,'" & kodeFee4 & "' as KodeFee4,'" & Tgl4 & "' as Tgl4,0 as Fee5,'' as KodeFee5,'' as Tgl5 from (PembayaranFeeDetail as pd inner join pembelian2 as p  on (p.NoTicket=pd.NoTicket)) inner join customer c on(c.NoAccount=p.NoAccount) where c.kodeKelompok='" & dgvData1.Rows(i).Cells(0).Value & "' and p.kodekota='" & clsKoneksi.kotaOn & "' " & getTanggal & "  group by c.KodeKelompok"
                Else
                    query &= " union all select kodeKelompok, " & fee1T & " as Fee1,'" & kodeFee1 & "' as KodeFee1,'" & Tgl1 & "' as Tgl1," & fee2T & " as Fee2,'" & kodeFee2 & "' as KodeFee2,'" & Tgl2 & "' as Tgl2," & fee3T & " as Fee3,'" & kodeFee3 & "' as KodeFee3,'" & Tgl3 & "' as Tgl3," & fee4T & " as Fee4,'" & kodeFee4 & "' as KodeFee4,'" & Tgl4 & "' as Tgl4,0 as Fee5,'' as KodeFee5,'' as Tgl5 from (PembayaranFeeDetail as pd inner join pembelian2 as p  on (p.NoTicket=pd.NoTicket)) inner join customer c on(c.NoAccount=p.NoAccount) where c.kodeKelompok='" & dgvData1.Rows(i).Cells(0).Value & "' and p.kodekota='" & clsKoneksi.kotaOn & "' " & getTanggal & "  group by c.KodeKelompok"
                End If
                fee1T = 0
                fee2T = 0
                fee3T = 0
                fee4T = 0
                kodeFee1 = "-"
                kodeFee2 = "-"
                kodeFee3 = "-"
                kodeFee4 = "-"
                Tgl1 = "-"
                Tgl2 = "-"
                Tgl3 = "-"
                Tgl4 = "-"
            Next
            query &= ")"
            objReport.Database.Tables("FeePembayaranDetailFee").SetDataSource(clsKoneksi.selectCommand(1, query).Tables(0))

            'Dim tDs As DataSet = clsKoneksi.selectCommand(1, query)
            'dgTest.Rows.Clear()
            'Dim isiView(15) As Object
            ''isiView(0) = ""
            'For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            '    For j As Integer = 0 To isiView.Length - 1
            '        If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
            '            isiView(j) = ""
            '        Else
            '            isiView(j) = tDs.Tables(0).Rows(i).Item(j)
            '        End If
            '    Next
            '    dgTest.Rows.Add(isiView)
            'Next

        End If
        'Return

        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan Hutang Pembantu Libo")
        Else
            objReport.SetParameterValue("Judul", "Laporan Hutang Pembantu BinaBaru")
        End If

        If rdHarian.Checked = True Then
            objReport.SetParameterValue("Waktu", "Tanggal : " & Format(dtpDari.Value, "dd-MMMM-yyyy") & " - " & Format(dtpSampai.Value, "dd-MMMM-yyyy"))
        ElseIf rdBulanan.Checked = True Then
            objReport.SetParameterValue("Waktu", "Bulan : " & Format(dtpDari.Value, "MMMM"))
        ElseIf rdTahunan.Checked = True Then
            objReport.SetParameterValue("Waktu", "Tahun : " & Format(dtpDari.Value, "yyyy"))
        End If

        frmLaporanView.rptView.ShowGroupTreeButton = False
        frmLaporanView.rptView.ReportSource = objReport
        frmLaporanView.rptView.ShowRefreshButton = False
        frmLaporanView.rptView.Refresh()
        frmLaporanView.StartPosition = FormStartPosition.CenterScreen
        frmLaporanView.WindowState = FormWindowState.Maximized
        frmLaporanView.Show()
    End Sub

    Private Sub frmLaporanHutangPembantu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = Date.Now
        dtpSampai.Value = Date.Now
        rdHarian.Checked = True
    End Sub

    Private Sub rdHarian_CheckedChanged(sender As Object, e As EventArgs) Handles rdHarian.CheckedChanged
        If rdHarian.Checked Then
            dtpDari.Enabled = True
            dtpSampai.Enabled = True
            dtpDari.Value = Date.Now
            dtpSampai.Value = Date.Now
        End If
    End Sub

    Private Sub rdBulanan_CheckedChanged(sender As Object, e As EventArgs) Handles rdBulanan.CheckedChanged
        If rdBulanan.Checked = True Then
            dtpSampai.Enabled = False
            dtpDari.Enabled = True
        End If
    End Sub

    Private Sub rdTahunan_CheckedChanged(sender As Object, e As EventArgs) Handles rdTahunan.CheckedChanged
        If rdTahunan.Checked = True Then
            dtpSampai.Enabled = False
            dtpDari.Enabled = True
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        noAccount = ""
        dtpDari.Value = Date.Now
        dtpSampai.Value = Date.Now
        txtCustomer.Clear()
        txtNoBukti.Clear()
        rdHarian.Checked = True
        rdBulanan.Checked = False
        rdTahunan.Checked = False
        dtpDari.Enabled = True
        dtpSampai.Enabled = True
    End Sub

    Private Sub btnCariCustomer_Click(sender As Object, e As EventArgs) Handles btnCariCustomer.Click
        frmCustomerCari.pilihan = "LaporanHutangPembantu"
        frmCustomerCari.ShowDialog()
    End Sub

End Class