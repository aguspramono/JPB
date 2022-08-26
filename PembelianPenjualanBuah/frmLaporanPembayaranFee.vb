Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLaporanPembayaranFee

    Sub loadkodeKelompok()
        Dim tDs As DataSet
        Dim tDs1 As DataSet
        Dim myQuery As String = "select kodeKelompok from Fee Group By kodeKelompok Order By KodeKelompok"
        dgvKelompok.Rows.Clear()
        tDs = clsKoneksi.selectCommand(1, myQuery)
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
            dgvKelompok.Rows.Add(isiView)
        Next

        Dim intT As Integer = cbFeeStatus.SelectedIndex
        Dim whereStr As String = ""

        Select Case intT
            Case 0
                whereStr = "where StatusFee='Y' "
            Case 1
                whereStr = "where StatusFee='N' "
        End Select

        Dim myQuery1 As String = "select kodeKelompok,Fee from Fee " & whereStr & " Order By KodeKelompok"
        dgvFee.Rows.Clear()
        tDs1 = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvFee.Rows.Add(isiView1)
        Next
    End Sub


    Sub tampilDataFee()
        Dim bos As String
        If ckAtasan.Checked = True Then
            bos = "c.Grade<>'A' and c.bosTemp<>'Y' and "
        Else
            bos = ""
        End If
        Dim myQuery As String = "SELECT p.Tgl2, c.Nama, p.NoTicket, p.NoAccount, p.Netto, c.fee, p.Total, p.PrintNoFee, p.UserPrintFee FROM Pembelian2 AS p LEFT JOIN Customer AS c ON p.noaccount = c.noaccount "
        'Dim namaKolom As String() = {"Cari", "Cari2", "Cari3"}
        'Dim isiKolom As Object() = {txtCari.Text, dtTglAwal.Value.Date, dtTanggalAkhir.Value.Date}
        Dim intT As Integer = cboCari.SelectedIndex
        myQuery = myQuery & " Where " & bos & " (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.noticket not in(select noticket from PembayaranFeeDetail) "

        Select Case intT
            Case 0
                myQuery = myQuery & " and p.NoTicket"
            Case 1
                myQuery = myQuery & " and p.NoAccount"
            Case 2
                myQuery = myQuery & " and p.DO"
        End Select
        myQuery = myQuery & " LIKE '%" & txtCari.Text & "%' "
        myQuery = myQuery & " and (p.fee>0 or c.fee>0) and p.NoAccount Not in(select noAccount from pengecualianbb) and p.kodekota='" & clsKoneksi.kotaOn & "' order by int(p.noAccount)"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        'Console.WriteLine(myQuery)
        dgView.Rows.Clear()
        Dim isiView(9) As Object

        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            isiView(0) = True
            For j As Integer = 0 To isiView.Length - 2
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j + 1) = ""
                Else
                    If j + 1 = 7 Then
                        isiView(j + 1) = isiView(5) * isiView(6)
                    Else
                        isiView(j + 1) = tDs.Tables(0).Rows(i).Item(j)
                    End If
                End If
            Next
            dgView.Rows.Add(isiView)
            If dgView.Rows(i).Cells(8).Value > 0 Then
                dgView.Rows(dgView.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next

        loadkodeKelompok()
    End Sub

    Private Sub frmLaporanPembayaranFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCari.SelectedIndex = 0
        cbFeeStatus.SelectedIndex = 0
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        tampilDataFee()
    End Sub

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        loadkodeKelompok()
        Dim objReport As Object = ""
        If clsKoneksi.kotaOn = "2" Then
            objReport = New LaporanPembayaranFee
        Else
            objReport = New LaporanFeeLibo
        End If

        Dim myQuery As String = "SELECT p.* FROM Pembelian2 p left join Customer c on p.noaccount=c.noaccount "
        Dim noTicketT As String = String.Empty
        For Each row As DataGridViewRow In dgView.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CkPilih").Value)
            If isSelected = True Then
                noTicketT &= "'" & row.Cells("NoTicket").Value.ToString() & "'" & ","
            End If
        Next
        If noTicketT = "" Then
            MessageBox.Show("Belum ada data dipilih", "warning")
            Exit Sub
        End If
        noTicketT = noTicketT.Remove(noTicketT.Length - 1, 1)
        myQuery = myQuery & " Where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.noticket in(" & noTicketT & ")"
        Dim intT As Integer = cboCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & " and p.NoTicket"
            Case 1
                myQuery = myQuery & " and p.NoAccount"
            Case 2
                myQuery = myQuery & " and p.DO"
        End Select
        myQuery = myQuery & " LIKE '%" & txtCari.Text & "%' "
        myQuery = myQuery & " and p.kodekota='" & clsKoneksi.kotaOn & "'"
        If clsKoneksi.kotaOn = "2" Then
            objReport.Database.Tables("Pembelian").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
        Else
            objReport.Database.Tables("Pembelian2").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))
        End If

        myQuery = "select*from customer"
        myQuery = myQuery & " where kodekota='" & clsKoneksi.kotaOn & "'"
        objReport.Database.Tables("Customer").SetDataSource(clsKoneksi.selectCommand(1, myQuery).Tables(0))

        If clsKoneksi.kotaOn = "2" Then
            Dim fee1T As Integer = 0
            Dim fee2T As Integer = 0
            Dim fee3T As Integer = 0
            Dim fee4T As Integer = 0
            Dim tmasuk As Integer = 0
            Dim query As String = ""
            query = "select kodeKelompok,Fee1,Fee2,Fee3,Fee4,Fee5 from("
            For i As Integer = 0 To dgvKelompok.Rows.Count - 1
                For j As Integer = 0 To dgvFee.Rows.Count - 1
                    If dgvKelompok.Rows(i).Cells(0).Value = dgvFee.Rows(j).Cells(0).Value Then
                        Select Case tmasuk
                            Case 0
                                fee1T = dgvFee.Rows(j).Cells(1).Value
                            Case 1
                                fee2T = dgvFee.Rows(j).Cells(1).Value
                            Case 2
                                fee3T = dgvFee.Rows(j).Cells(1).Value
                            Case 3
                                fee4T = dgvFee.Rows(j).Cells(1).Value
                        End Select
                        tmasuk += 1
                    Else
                        tmasuk = 0
                    End If
                Next

                If i = 0 Then
                    query &= "select kodeKelompok, " & fee1T & " as Fee1," & fee2T & " as Fee2," & fee3T & " as Fee3," & fee4T & " as Fee4,0 as Fee5  from fee where kodeKelompok='" & dgvKelompok.Rows(i).Cells(0).Value & "' group by kodeKelompok"
                Else
                    query &= " union all select kodeKelompok, " & fee1T & " as Fee1," & fee2T & " as Fee2," & fee3T & " as Fee3," & fee4T & " as Fee4,0 as Fee5 from fee where kodeKelompok='" & dgvKelompok.Rows(i).Cells(0).Value & "' group by KodeKelompok"
                End If
                fee1T = 0
                fee2T = 0
                fee3T = 0
                fee4T = 0
            Next
            query &= ")"

            objReport.Database.Tables("PembayaranFee").SetDataSource(clsKoneksi.selectCommand(1, query).Tables(0))
        End If

        If clsKoneksi.kotaOn = "1" Then
            objReport.SetParameterValue("Judul", "Laporan Pembayaran Fee Libo")
        Else
            objReport.SetParameterValue("Judul", "Laporan Pembayaran Fee BinaBaru")
        End If
        'objReport.SetParameterValue("diPrintOleh", "Print by : " & frmMainMenu.lblStatusUserOn.Text)

        Dim myQuery3 As String = "Update pembelian SET PrintNoFee=PrintNoFee+1,UserprintFee='" & frmMainMenu.lblStatusUserOn.Text & "'"
        Dim namaKolom3 As String() = {"Cari", "Cari2", "Cari3"}
        Dim isiKolom3 As Object() = {txtCari.Text, dtTglAwal.Value.Date, dtTanggalAkhir.Value.Date}
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


        Dim myQuery4 As String = "Update pembelian2 SET PrintNoFee=PrintNoFee+1,UserprintFee='" & frmMainMenu.lblStatusUserOn.Text & "'"
        Dim namaKolom4 As String() = {"Cari", "Cari2", "Cari3"}
        Dim isiKolom4 As Object() = {txtCari.Text, dtTglAwal.Value.Date, dtTanggalAkhir.Value.Date}
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
        lblTotalNetto.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                 Where row.Selected = True _
                 Select Convert.ToInt64(row.Cells(5).Value)).Sum.ToString), "###,###")
        lblTotalHarga.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                 Where row.Selected = True _
                 Select Convert.ToInt64(row.Cells(7).Value)).Sum.ToString), "###,###")

        If lblTotalNetto.Text = "0" Or lblTotalNetto.Text = "" Then
            lblTotalNetto.Text = 0
        End If

        If lblTotalHarga.Text = "0" Or lblTotalHarga.Text = "" Then
            lblTotalHarga.Text = 0
        End If

        lblsemua.Text = Format(CDbl(lblTotalHarga.Text) / CDbl(lblTotalNetto.Text), "###,###")
    End Sub

    Private Sub mnuPulihkan_Click(sender As Object, e As EventArgs) Handles mnuPulihkan.Click
        Dim noTicketT As String = String.Empty
        Dim noAccount As String = String.Empty
        For Each row As DataGridViewRow In dgView.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CkPilih").Value)
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

        'update pembelian data
        Dim myQuery3 As String = "Update pembelian SET PrintNoFee=0,UserPrintFee=''"
        myQuery3 = myQuery3 & " where KodeKota='" & clsKoneksi.kotaOn & "' and NoTicket in(" & noTicketT & ")"
        clsKoneksi.selectCommand(1, myQuery3)

        'update pembelian data2
        Dim myQuery4 As String = "Update pembelian2 SET PrintNoFee=0,UserPrintFee=''"
        myQuery4 = myQuery4 & " where KodeKota='" & clsKoneksi.kotaOn & "' and NoTicket in(" & noTicketT & ")"
        clsKoneksi.selectCommand(1, myQuery4)

        tampilDataFee()
    End Sub

End Class