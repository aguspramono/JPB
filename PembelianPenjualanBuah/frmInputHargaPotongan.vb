Imports DevComponents.DotNetBar.Controls
Imports System.Data.OleDb
Public Class frmInputHargaPotongan

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        loadCari()
    End Sub

    Sub loadCari()
        Dim myQuery As String = "SELECT p.NoTicket as NoTicketS,p.Tgl2,p.Jam1,p.Vehicle,p.NoAccount as NoAccountS,IIf(ISNULL(c.KodeKelompok), '', c.KodeKelompok) as KodeKelompokS,p.DO,p.Product,p.Berat1Brutto,p.Berat2Tarra,p.ADJ,p.JumlahJanjang,p.BJR,p.Netto,p.HargaAkhir,IIf(ISNULL(p.potongan), '0', p.potongan) as potongan,p.Total,p.KodeKota,'B',p.manualedit FROM Pembelian2 p Left Outer Join Customer c on p.noaccount=c.noaccount "
        Dim myQuery2 As String = " SELECT p.NoTicket as NoTicketS,p.Tgl2,p.Jam1,p.Vehicle,p.NoAccount as NoAccountS,IIf(ISNULL(c.KodeKelompok), '', c.KodeKelompok) as KodeKelompokS,p.DO,p.Product,0,0,0,0,0,0,0,0,0,p.KodeKota,'J','' FROM Penjualan p  Left Outer Join Customer c on p.noaccount=c.noaccount "

        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}
        Dim intT As Integer = cboCari.SelectedIndex
        myQuery = myQuery & " Where (p.Tgl2>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and p.Tgl2<=#" & dtTanggalAkhir.Value.ToString("MM/dd/yyyy") & "#)"
        myQuery2 = myQuery2 & " Where (p.Tgl2>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and p.Tgl2<=#" & dtTanggalAkhir.Value.ToString("MM/dd/yyyy") & "#)"

        Select Case intT
            Case 0
                myQuery = myQuery & " and p.NoTicket"
                myQuery2 = myQuery2 & " and p.NoTicket"
            Case 1
                myQuery = myQuery & " and p.Vehicle"
                myQuery2 = myQuery2 & " and p.Vehicle"
            Case 2
                myQuery = myQuery & " and p.NoAccount"
                myQuery2 = myQuery2 & " and p.NoAccount"
            Case 3
                myQuery = myQuery & " and IIf(ISNULL(c.KodeKelompok), '', c.KodeKelompok) "
                myQuery2 = myQuery2 & " and IIf(ISNULL(c.KodeKelompok), '', c.KodeKelompok) "
            Case 4
                myQuery = myQuery & " and p.DO"
                myQuery2 = myQuery2 & " and p.DO"
            Case 5
                myQuery = myQuery & " and p.Product"
                myQuery2 = myQuery2 & " and p.Product"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and p.kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery2 = myQuery2 & " LIKE '%' + @Cari + '%' and p.kodekota='" & clsKoneksi.kotaOn & "'"

        If cboOrder.SelectedIndex = 0 Then
            myQuery = myQuery & "  Union ALL " & myQuery2 & " order by NoTicketS"
        ElseIf cboOrder.SelectedIndex = 1 Then
            myQuery = myQuery & "  Union ALL " & myQuery2 & " order by KodeKelompokS,NoAccountS,NoTicketS"
        Else
            myQuery = myQuery & "  Union ALL " & myQuery2 & " order by NoAccountS"
        End If
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(19) As Object

        'isiView(0) = "" 
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
                If j = 19 Then
                    If isiView(j) = "1" Then
                        isiView(j) = True
                    Else
                        isiView(j) = False
                    End If
                End If
            Next
            isiView(16) = isiView(13) * (isiView(14) - isiView(15))
            dgView.Rows.Add(isiView)

            If isiView(15) > 0 Then
                dgView.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next

    End Sub

    Private Sub dgView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgView.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgView.CurrentCell = Me.dgView.Rows(e.RowIndex).Cells(1)
                Me.klikKanan.Show(Me.dgView, e.Location)
                Me.klikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                dgView.SelectedRows.Item(0).Cells(12).Selected = True
                dgView.BeginEdit(True)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmInputHarga_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cboCari.SelectedIndex = 0
        cboOrder.SelectedIndex = 0
        dtTglAwal.Value = clsKoneksi.tglAwalBulan(Now)
        dtTanggalAkhir.Value = clsKoneksi.tglAkhirBulan(Now)
    End Sub


    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs)
        frmInputHargaDetail.dtTglAwal.Value = Now
        frmInputHargaDetail.dtTanggalAkhir.Value = Now
        frmInputHargaDetail.dtTglGrade.Value = Now
        frmInputHargaDetail.cboGrade.SelectedIndex = 1
        frmInputHargaDetail.ShowDialog()
    End Sub


    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        If dgView.SelectedRows.Count > 0 Then
            If dgView.Rows(dgView.SelectedRows(0).Index).Cells(5).Value = "" Then
                MsgBox("Kode Kelompok masih kosong")
                Return
            End If
            frmInputHargaEditDetail.statPot = True
            frmInputHargaEditDetail.rowT = dgView.SelectedRows(0).Index
            frmInputHargaEditDetail.loadCari(dgView.Rows(dgView.SelectedRows(0).Index).Cells(0).Value)
            frmInputHargaEditDetail.lblKodeKelompok.Text = dgView.Rows(dgView.SelectedRows(0).Index).Cells(5).Value
            frmInputHargaEditDetail.ShowDialog(Me)
        Else
            MessageBox.Show("Tidak ada data Terpilih.", "Warning")
        End If
    End Sub

    Private Sub dgView_SelectionChanged(sender As Object, e As EventArgs) Handles dgView.SelectionChanged
        lblJumlahTotal.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                    Where row.Cells(16).Selected = True _
                    Select Convert.ToDouble(row.Cells(16).Value)).Sum.ToString), "###,###")
        lblTotalJanjang.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                    Where row.Cells(11).Selected = True And IsNumeric(row.Cells(11).Value) _
                    Select Convert.ToDouble(row.Cells(11).Value)).Sum.ToString), "###,###")

        lblJumlahNetto.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                    Where row.Cells(13).Selected = True _
                    Select Convert.ToDouble(row.Cells(13).Value)).Sum.ToString), "###,###")
    End Sub

    Private Sub btnPotongan_Click(sender As Object, e As EventArgs) Handles btnPotongan.Click
        frmInputPotonganAtmp.dtpDari.Value = dtTglAwal.Value.Date
        frmInputPotonganAtmp.dtpSampai.Value = dtTanggalAkhir.Value.Date
        frmInputPotonganAtmp.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If clsKoneksi.kotaOn = "1" Then
            frmInputHargaPengecualian.ShowDialog()
        ElseIf clsKoneksi.kotaOn = "2" Then
            frmPengecualianbb.ShowDialog()
        End If
    End Sub

    Private Sub btnPJML_Click(sender As Object, e As EventArgs) Handles btnPJML.Click
        frmPJMLdanSejenis.ShowDialog()
    End Sub

    Private Sub btnAtmp_Click(sender As Object, e As EventArgs) Handles btnAtmp.Click
        frmInputPotonganAtmp.ShowDialog()
    End Sub


    Private Sub mnuSingleEdit_Click(sender As Object, e As EventArgs) Handles mnuSingleEdit.Click
        Dim cmd As OleDbCommand
        Dim myQuery As String

        myQuery = "update pembelian2 as p inner join pembelian as p2 on (p2.NoTicket=p.NoTicket) set p.HargaAkhir=p2.HargaAkhir where "
        myQuery = myQuery & " p.NoTicket='" & dgView.SelectedCells(0).Value & "'"
        cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        loadCari()

        MessageBox.Show("Harga berhasil diperbaharui", "Warning")
    End Sub

    Private Sub mnuMultipleEdit_Click(sender As Object, e As EventArgs) Handles mnuMultipleEdit.Click
        frmMultipleEditPotongan.ShowDialog()
    End Sub
End Class