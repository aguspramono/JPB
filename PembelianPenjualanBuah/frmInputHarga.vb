Imports DevComponents.DotNetBar.Controls
Imports System.Data.OleDb
Public Class frmInputHarga

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        loadCari()
    End Sub

    Sub loadCari()
        Dim isiView13 As Double = 0
        Dim isiView14 As Double = 0
        Dim isiView15 As Double = 0
        Dim myQuery As String = "SELECT p.NoTicket as NoTicketS,p.Tgl1,p.Jam1,p.Vehicle,p.NoAccount as NoAccountS,IIf(ISNULL(c.KodeKelompok), '', c.KodeKelompok) as KodeKelompokS,p.DO,p.Product,p.Berat1Brutto,p.Berat2Tarra,p.ADJ,p.JumlahJanjang,p.BJR,p.Netto,p.HargaAkhir,IIf(ISNULL(p.potongan), '0', p.potongan) as potongan,p.Total,p.KodeKota,'B',p.manualedit,p.Keterangan,p.PotonganPlat FROM Pembelian p Left Outer Join Customer c on p.noaccount=c.noaccount "
        Dim myQuery2 As String = " SELECT p.NoTicket as NoTicketS,p.Tgl1,p.Jam1,p.Vehicle,p.NoAccount as NoAccountS,IIf(ISNULL(c.KodeKelompok), '', c.KodeKelompok) as KodeKelompokS,p.DO,p.Product,0,0,0,0,0,0,0,0,0,p.KodeKota,'J','','','' FROM Penjualan p  Left Outer Join Customer c on p.noaccount=c.noaccount "

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
        Dim isiView(21) As Object

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
            dgView.Rows(i).Cells(14).Style.Format = "N2"
            dgView.Rows(i).Cells(16).Style.Format = "N2"

            If isiView(21) = "1" Then
                dgView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            End If

        Next
        lblbanyakData.Text = dgView.Rows.Count
    End Sub

    Private Sub dgView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgView.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgView.CurrentCell = Me.dgView.Rows(e.RowIndex).Cells(1)
                If dgView.Rows(e.RowIndex).Cells(21).Value = "1" Then
                    Me.mnuBatalkanPotonganPlat.Visible = True
                    Me.mnuPotonganPlat.Visible = False
                Else
                    Me.mnuBatalkanPotonganPlat.Visible = False
                    Me.mnuPotonganPlat.Visible = True
                End If
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

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click
        frmInputHargaDetail.dtTglAwal.Value = Now
        frmInputHargaDetail.dtTanggalAkhir.Value = Now
        frmInputHargaDetail.dtTglGrade.Value = Now
        frmInputHargaDetail.cboGrade.SelectedIndex = 1
        frmInputHargaDetail.ShowDialog()
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            loadCari()
        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        If dgView.SelectedRows.Count > 0 Then
            If dgView.Rows(dgView.SelectedRows(0).Index).Cells(5).Value = "" Then
                MsgBox("Kode Kelompok masih kosong")
                Return
            End If

            Dim myQuery As String = "SELECT NoTicket,Tgl2,Jam1,Vehicle,NoAccount,DO,Product,Berat1Brutto,Berat2Tarra,ADJ,JumlahJanjang,BJR,Netto,HargaAkhir,HargaAsli,Fee,potongan,SPSI,Total,Keterangan FROM Pembelian "
            Dim namaKolom As String() = {"Cari"}
            Dim isiKolom As Object() = {dgView.Rows(dgView.SelectedRows(0).Index).Cells(0).Value}
            myQuery = myQuery & " Where NoTicket=@Cari"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)

            If tDs.Tables(0).Rows.Count < 1 Then
                MsgBox("Data ini termasuk data penjualan dan tidak bisa di edit")
                Return
            End If
            frmInputHargaEditDetail.rowT = dgView.SelectedRows(0).Index
            frmInputHargaEditDetail.statPot = False
            frmInputHargaEditDetail.loadCari(dgView.Rows(dgView.SelectedRows(0).Index).Cells(0).Value)
            frmInputHargaEditDetail.lblKodeKelompok.Text = dgView.Rows(dgView.SelectedRows(0).Index).Cells(5).Value
            frmInputHargaEditDetail.txtKodeKelompok.Text = dgView.Rows(dgView.SelectedRows(0).Index).Cells(5).Value
            frmInputHargaEditDetail.ShowDialog(Me)
        Else
            MessageBox.Show("Tidak ada data Terpilih.", "Warning")
        End If
    End Sub


    Private Sub dgView_SelectionChanged(sender As Object, e As EventArgs) Handles dgView.SelectionChanged

        lblJumlahTotal.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                Where row.Cells(16).Selected = True _
                Select Convert.ToDouble(row.Cells(16).Value)).Sum.ToString), "N2")
        lblTotalJanjang.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                Where row.Cells(11).Selected = True And IsNumeric(row.Cells(11).Value) _
                Select Convert.ToDouble(row.Cells(11).Value)).Sum.ToString), "N2")
        lblJumlahNetto.Text = Format(CDbl((From row As DataGridViewRow In dgView.Rows.Cast(Of DataGridViewRow)() _
                Where row.Cells(13).Selected = True _
                Select Convert.ToDouble(row.Cells(13).Value)).Sum.ToString), "N2")

    End Sub

    Private Sub btnPotongan_Click(sender As Object, e As EventArgs) Handles btnPotongan.Click
        frmInputHargaPotongan.ShowDialog()
    End Sub

    Private Sub btnPJML_Click(sender As Object, e As EventArgs)
        frmPJMLdanSejenis.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If dgView.RowCount > 0 Then
            dgView.ClearSelection()
            dgView.CurrentCell = dgView.Rows(0).Cells(0)
            dgView.Rows(0).Selected = True
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If btnCopy.Text = "Batal" Then
            dgView.ClearSelection()
        End If
        For i As Integer = 0 To dgView.Rows.Count - 1
            If dgView.Rows(i).Cells(16).Style.Format = "N2" Then
                dgView.Rows(i).Cells(16).Style.Format = ""
                dgView.Rows(i).Cells(14).Style.Format = ""
                dgView.SelectAll()
                dgView.Focus()
                btnCopy.Text = "Batal"
            Else
                dgView.Rows(i).Cells(14).Style.Format = "N2"
                dgView.Rows(i).Cells(16).Style.Format = "N2"
                btnCopy.Text = "Format Angka"
            End If
        Next
    End Sub

    Private Sub MnuPindahkanKePenjualan_Click(sender As Object, e As EventArgs) Handles MnuPindahkanKePenjualan.Click

        If MsgBox("Sebelum memindahkan data, harap pastikan data sudah benar. Yakin ingin memindahkan data?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As OleDbCommand
            Dim myQuery As String

            myQuery = "SELECT NoTicket FROM Penjualan "
            Dim namaKolom As String() = {"Cari"}
            Dim isiKolom As Object() = {dgView.Rows(dgView.SelectedRows(0).Index).Cells(0).Value}
            myQuery = myQuery & " Where NoTicket=@Cari"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)

            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah masuk ke dalam data penjualan")
                Return
            End If


            myQuery = "INSERT INTO Penjualan(NoTicket,Tgl1,Tgl2,Jam1,Jam2,Vehicle,NoAccount,DO,Keterangan,Revisi,UserRevisi,KodeProduct,Product,Berat1Brutto,Berat2Tarra,ADJ,ADJNumber,JumlahJanjang,BJR,Netto,HargaAsli,Fee,SPSI,HargaAkhir,Total,KodeKota,Kota,PrintNo,UserPrint,PrintNoFee,UserPrintFee) SELECT NoTicket,Tgl1,Tgl2,Jam1,Jam2,Vehicle,NoAccount,DO,Keterangan,Revisi,UserRevisi,KodeProduct,Product,Berat1Brutto,Berat2Tarra,ADJ,ADJNumber,JumlahJanjang,BJR,0 As Netto,HargaAsli,Fee,SPSI,HargaAkhir,Total,KodeKota,Kota,PrintNo,UserPrint,PrintNoFee,UserPrintFee FROM Pembelian where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            myQuery = "DELETE FROM Pembelian where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            myQuery = "DELETE FROM Pembelian2 where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            loadCari()
            MsgBox("Sukses")
        End If
    End Sub

    Private Sub mnuPotonganPlat_Click(sender As Object, e As EventArgs) Handles mnuPotonganPlat.Click
        If MsgBox("Yakin ingin membuat tagihan untuk no ticket ini dikenakan potongan plat?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As OleDbCommand
            Dim myQuery As String
            'Pembelian 1
            myQuery = "Update Pembelian set PotonganPlat='1' where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            'Pembelian 2
            myQuery = "Update Pembelian2 set PotonganPlat='1' where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            loadCari()
            MsgBox("Sukses")
        End If
    End Sub

    Private Sub mnuBatalkanPotonganPlat_Click(sender As Object, e As EventArgs) Handles mnuBatalkanPotonganPlat.Click
        If MsgBox("Yakin ingin menghapus potongan plat?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As OleDbCommand
            Dim myQuery As String
            'Pembelian 1
            myQuery = "Update Pembelian set PotonganPlat='' where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            'Pembelian 2
            myQuery = "Update Pembelian2 set PotonganPlat='' where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            loadCari()
            MsgBox("Sukses")
        End If
    End Sub

    Private Sub mnuPindahPembelian_Click(sender As Object, e As EventArgs) Handles mnuPindahPembelian.Click
        Dim myQuery As String
        Dim cmd As OleDbCommand
        If MsgBox("Sebelum memindahkan data, harap pastikan data sudah benar. Yakin ingin memindahkan data?", vbQuestion + vbYesNo) = vbYes Then

            myQuery = "SELECT NoTicket FROM Pembelian "
            Dim namaKolom As String() = {"Cari"}
            Dim isiKolom As Object() = {dgView.Rows(dgView.SelectedRows(0).Index).Cells(0).Value}
            myQuery = myQuery & " Where NoTicket=@Cari"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)

            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah masuk ke dalam data Pembelian")
                Return
            End If

            myQuery = "INSERT INTO Pembelian(NoTicket,Tgl1,Tgl2,Jam1,Jam2,Vehicle,NoAccount,DO,Keterangan,Revisi,UserRevisi,KodeProduct,Product,Berat1Brutto,Berat2Tarra,ADJ,ADJNumber,JumlahJanjang,BJR,Netto,HargaAsli,Fee,SPSI,HargaAkhir,Total,KodeKota,Kota,PrintNo,UserPrint,PrintNoFee,UserPrintFee) SELECT NoTicket,Tgl1,Tgl2,Jam1,Jam2,Vehicle,NoAccount,DO,Keterangan,Revisi,UserRevisi,KodeProduct,Product,Berat1Brutto,Berat2Tarra,ADJ,ADJNumber,JumlahJanjang,BJR,Netto,HargaAsli,Fee,SPSI,HargaAkhir,Total,KodeKota,Kota,PrintNo,UserPrint,PrintNoFee,UserPrintFee FROM Penjualan where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            myQuery = "INSERT INTO Pembelian2(NoTicket,Tgl1,Tgl2,Jam1,Jam2,Vehicle,NoAccount,DO,Keterangan,Revisi,UserRevisi,KodeProduct,Product,Berat1Brutto,Berat2Tarra,ADJ,ADJNumber,JumlahJanjang,BJR,Netto,HargaAsli,Fee,SPSI,HargaAkhir,Total,KodeKota,Kota,PrintNo,UserPrint,PrintNoFee,UserPrintFee) SELECT NoTicket,Tgl1,Tgl2,Jam1,Jam2,Vehicle,NoAccount,DO,Keterangan,Revisi,UserRevisi,KodeProduct,Product,Berat1Brutto,Berat2Tarra,ADJ,ADJNumber,JumlahJanjang,BJR,Netto,HargaAsli,Fee,SPSI,HargaAkhir,Total,KodeKota,Kota,PrintNo,UserPrint,PrintNoFee,UserPrintFee FROM Penjualan where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            myQuery = "DELETE FROM Penjualan where NoTicket='" & dgView.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            loadCari()
            MsgBox("Sukses")
        End If
        
    End Sub

    Private Sub frmInputHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class