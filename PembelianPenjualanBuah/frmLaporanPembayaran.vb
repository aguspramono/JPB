Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLaporanPembayaran

    Public jenislaporanpembayaran As Double = 0

    Private Sub frmLaporanPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCari.SelectedIndex = 0
        cmbPilihanSpesial.SelectedIndex = 0
        cmbGross.SelectedIndex = 0
    End Sub

    Sub loadData()
        Dim bos As String = ""
        Dim pilihanSpesial As String = ""
        Dim tipegrossup As String = ""
        Dim tipegrossupbiasa As String = ""

        Dim intR As Integer = cmbPilihanSpesial.SelectedIndex
        Select Case intR
            Case 0
                pilihanSpesial = ""
            Case 1
                If ckAtasan.Checked = True Then
                    pilihanSpesial = "and c.SpesialCustomer='Y' and "
                Else
                    pilihanSpesial = "c.SpesialCustomer='Y' and "
                End If

            Case 2
                If ckAtasan.Checked = True Then
                    pilihanSpesial = "and  (c.SpesialCustomer<>'Y' or IsNull(c.SpesialCustomer) or c.SpesialCustomer='N') and "
                Else
                    pilihanSpesial = "(c.SpesialCustomer<>'Y' or IsNull(c.SpesialCustomer) or c.SpesialCustomer='N') and "
                End If

        End Select

        If ckAtasan.Checked = True Then
            bos = "c.Grade<>'A' and c.bosTemp<>'Y' and"
        Else
            bos = ""
        End If

        If jenislaporanpembayaran = 0 Then
            Dim intA As Integer = cmbGross.SelectedIndex
            Select Case intA
                Case 0
                    tipegrossup = ""
                Case 1
                    tipegrossup = " and c.GrossUp=0 "
                Case 2
                    tipegrossup = " and c.GrossUp=1 "
                Case 3
                    tipegrossup = " and c.GrossUp=2 "
                Case 4
                    tipegrossup = " and c.GrossUp=3 "
                Case 5
                    tipegrossup = " and c.GrossUp=4 "
            End Select
        Else
            tipegrossup = " and c.GrossUp=" & jenislaporanpembayaran & " "
        End If

        Dim myQuery As String = "SELECT p.Tgl2,p.NoTicket,p.Vehicle,p.NoAccount,c.Nama,p.DO,p.Berat1Brutto,p.Berat2Tarra,p.ADJ,p.Netto,p.JumlahJanjang,p.BJR,p.HargaAkhir-p.potongan,p.Total,p.PrintNo,p.UserPrint,p.BukaPembayaran FROM Pembelian2 p left join Customer c on p.noaccount=c.noaccount "
        'Dim namaKolom As String() = {"Cari", "Cari2", "Cari3"}
        'Dim isiKolom As Object() = {txtCari.Text, dtTglAwal.Value.Date, dtTanggalAkhir.Value.Date}
        myQuery = myQuery & " Where " & bos & " " & pilihanSpesial & " (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) "
        Dim intT As Integer = cboCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & " and p.NoTicket"
            Case 1
                myQuery = myQuery & " and p.NoAccount"
            Case 2
                myQuery = myQuery & " and p.DO"
            Case 3
                myQuery = myQuery & " and c.kodeKelompok"
        End Select

        myQuery = myQuery & " LIKE '%" & txtCari.Text & "%' "
        myQuery = myQuery & " and p.kodekota='" & clsKoneksi.kotaOn & "' " & tipegrossup & " order by c.kodekelompok, len(p.noaccount), p.noaccount,p.noticket"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgView.Rows.Clear()
        Dim isiView(17) As Object

        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            isiView(0) = chkPilihSemua.Checked
            For j As Integer = 0 To isiView.Length - 2
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j + 1) = ""
                Else
                    isiView(j + 1) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgView.Rows.Add(isiView)

            If dgView.Rows(i).Cells(15).Value.ToString() <> "" And dgView.Rows(i).Cells(15).Value.ToString() <> "0" Then
                dgView.Rows(dgView.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If

            If isiView(17) = "Y" Then
                dgView.Rows(dgView.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightPink
            End If
        Next
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If ckkNoPPH.Checked = True And ckSpesial.Checked = True Then
            MsgBox("Ups, laporan tidak dapat menampilkan pembayaran spesial dan pembayaran non pph. Harap pilih salah satu ya.", vbExclamation)
            Return
        End If

        Dim objReport As Object
        If ckkNoPPH.Checked = True Then
            objReport = New LaporanPembayaranTBSPPH2
        ElseIf ckSpesial.Checked = True Then
            objReport = New LaporanPembayaranTBSSpesial2
        Else
            objReport = New LaporanPembayaranTBS2New
        End If

        Dim myQuery As String = "SELECT p.* FROM ((pembelian2 AS p LEFT JOIN customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN pengecualianbb AS pb ON p.NoAccount = pb.noAccount) LEFT JOIN pjmlsejenis AS pj ON p.NoAccount = pj.NoAccount"
        Dim noTicketT As String = String.Empty
        Dim noAccount As String = String.Empty
        For Each row As DataGridViewRow In dgView.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CKpilih").Value)
            If isSelected = True Then
                noTicketT &= "'" & row.Cells("NoTicket").Value.ToString() & "'" & ","
                noAccount &= "'" & row.Cells("NoAccount").Value.ToString() & "'" & ","
            End If
        Next
        If noTicketT = "" Then
            MessageBox.Show("Belum ada data dipilih", "warning")
            Exit Sub
        End If
        noTicketT = noTicketT.Remove(noTicketT.Length - 1, 1)
        noAccount = noAccount.Remove(noAccount.Length - 1, 1)
        myQuery = myQuery & " Where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.noticket in(" & noTicketT & ")"
        Dim intT As Integer = cboCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & " and p.NoTicket"
            Case 1
                myQuery = myQuery & " and p.NoAccount"
            Case 2
                myQuery = myQuery & " and p.DO"
            Case 3
                myQuery = myQuery & " and c.kodeKelompok"
        End Select
        myQuery = myQuery & " LIKE '%" & txtCari.Text & "%' "
        myQuery = myQuery & " and p.kodekota='" & clsKoneksi.kotaOn & "' order by c.kodekelompok, p.noaccount, p.noticket "
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

        myQuery = "Select * from grossup where tipeGrossup=" & jenislaporanpembayaran & ""
        myQuery = myQuery
        objReport.Database.Tables("grossup").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        If ckSpesial.Checked = True Then
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

        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan Pembayaran TBS Libo")
        Else
            objReport.SetParameterValue("Judul", "Laporan Pembayaran TBS BinaBaru")
        End If
        objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)

        objReport.SetParameterValue("jenislaporangrossup", jenislaporanpembayaran)

        Dim myQuery3 As String = "Update pembelian SET Printno=Printno+1,Userprint='" & frmMainMenu.lblStatusUserOn.Text & "'"
        myQuery3 = myQuery3 & " where KodeKota='" & clsKoneksi.kotaOn & "'"
        Select Case intT
            Case 0
                myQuery3 = myQuery3 & " and NoTicket"
            Case 1
                myQuery3 = myQuery3 & " and NoAccount"
            Case 2
                myQuery3 = myQuery3 & " and DO"
        End Select
        myQuery3 = myQuery3 & " LIKE '%" & txtCari.Text & "%' "
        myQuery3 = myQuery3 & " and (Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and noticket in(" & noTicketT & ")"
        clsKoneksi.selectCommand(1, myQuery3)

        'pembelian 2
        Dim myQuery4 As String = "Update pembelian2 SET Printno=Printno+1,Userprint='" & frmMainMenu.lblStatusUserOn.Text & "'"
        myQuery4 = myQuery4 & " where KodeKota='" & clsKoneksi.kotaOn & "'"
        Select Case intT
            Case 0
                myQuery4 = myQuery4 & " and NoTicket"
            Case 1
                myQuery4 = myQuery4 & " and NoAccount"
            Case 2
                myQuery4 = myQuery4 & " and DO"
        End Select
        myQuery4 = myQuery4 & " LIKE '%" & txtCari.Text & "%' "
        myQuery4 = myQuery4 & " and (Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and noticket in(" & noTicketT & ")"
        clsKoneksi.selectCommand(1, myQuery4)

        frmLaporanView.rptView.ShowGroupTreeButton = False
        frmLaporanView.rptView.ReportSource = objReport
        frmLaporanView.rptView.ShowRefreshButton = False
        frmLaporanView.rptView.Refresh()
        frmLaporanView.StartPosition = FormStartPosition.CenterScreen
        frmLaporanView.WindowState = FormWindowState.Maximized
        frmLaporanView.Show()

    End Sub

    Private Sub chkPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles chkPilihSemua.CheckedChanged
        For i As Integer = 0 To dgView.Rows.Count - 1
            dgView.Rows(i).Cells(0).Value = chkPilihSemua.Checked
        Next
    End Sub

    Private Sub dgView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgView.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgView.CurrentCell = Me.dgView.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikKanan.Show(Me.dgView, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik data", vbExclamation)
        End Try
    End Sub

    Private Sub dgView_KeyDown(sender As Object, e As KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Space Then
            If dgView.Rows.Count > 0 Then
                If dgView.SelectedRows.Count > 0 Then
                    For i As Integer = 0 To dgView.SelectedRows.Count - 1
                        dgView.SelectedRows(i).Cells(0).Value = Not dgView.SelectedRows(i).Cells(0).Value
                    Next
                End If
            End If
        End If
    End Sub


    Private Sub dgView_SelectionChanged(sender As Object, e As EventArgs) Handles dgView.SelectionChanged

        lblJumlahNetto.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                   Where row.Selected = True _
                   Select Convert.ToDouble(row.Cells(10).Value)).Sum.ToString), "N2")

        lblTotal.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                           Where row.Selected = True _
                           Select Convert.ToDouble(row.Cells(14).Value)).Sum.ToString), "N2")

        If lblJumlahNetto.Text = "0" Or lblJumlahNetto.Text = "" Then
            lblJumlahNetto.Text = 0
        End If

        If lblTotal.Text = "0" Or lblTotal.Text = "" Then
            lblTotal.Text = 0
        End If
        lblsemua.Text = Format(CDbl(lblTotal.Text) / CDbl(lblJumlahNetto.Text), "N2")
    End Sub

    Private Sub mnuPulihkan_Click(sender As Object, e As EventArgs) Handles mnuPulihkan.Click
        Dim noTicketT As String = String.Empty
        Dim noAccount As String = String.Empty
        For Each row As DataGridViewRow In dgView.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CKpilih").Value)
            If isSelected = True Then
                noTicketT &= "'" & row.Cells("NoTicket").Value.ToString() & "'" & ","
                noAccount &= "'" & row.Cells("NoAccount").Value.ToString() & "'" & ","
            End If
        Next
        If noTicketT = "" Then
            MessageBox.Show("Belum ada data dipilih", "warning")
            Exit Sub
        End If
        noTicketT = noTicketT.Remove(noTicketT.Length - 1, 1)
        noAccount = noAccount.Remove(noAccount.Length - 1, 1)

        Dim myQuery3 As String = "Update pembelian SET Printno=0,Userprint=''"
        myQuery3 = myQuery3 & " where KodeKota='" & clsKoneksi.kotaOn & "' and NoTicket in(" & noTicketT & ")"
        'myQuery3 = myQuery3 & " LIKE '%" & txtCari.Text & "%' "
        'myQuery3 = myQuery3 & " and (Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and noticket in(" & noTicketT & ")"
        clsKoneksi.selectCommand(1, myQuery3)

        'update pembelian data2
        Dim myQuery4 As String = "Update pembelian2 SET Printno=0,Userprint=''"
        myQuery4 = myQuery4 & " where KodeKota='" & clsKoneksi.kotaOn & "' and NoTicket in(" & noTicketT & ")"
        'myQuery3 = myQuery3 & " LIKE '%" & txtCari.Text & "%' "
        'myQuery3 = myQuery3 & " and (Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and noticket in(" & noTicketT & ")"
        clsKoneksi.selectCommand(1, myQuery4)
        loadData()
    End Sub

End Class