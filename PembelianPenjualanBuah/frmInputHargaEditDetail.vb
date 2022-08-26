Public Class frmInputHargaEditDetail
    Public rowT As Integer
    Public statPot As Boolean

    Sub loadCari(s As String)
        Dim table As String = "Pembelian"
        If statPot = True Then
            table = "Pembelian2"
        End If

        Dim myQuery As String = "SELECT NoTicket,Tgl2,Jam1,Vehicle,NoAccount,DO,Product,Berat1Brutto,Berat2Tarra,ADJ,JumlahJanjang,BJR,Netto,HargaAkhir,HargaAsli,Fee,potongan,SPSI,Total,Keterangan FROM " & table & " "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {s}
        myQuery = myQuery & " Where NoTicket=@Cari"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)

        If tDs.Tables(0).Rows.Count < 1 Then
            MsgBox("Data ini termasuk data penjualan dan tidak bisa di edit")
            Return
        End If

        txtNoticket.Text = tDs.Tables(0).Rows(0).Item("NoTicket").ToString
        dtTgl.Value = tDs.Tables(0).Rows(0).Item("Tgl2").ToString
        txtJam.Text = tDs.Tables(0).Rows(0).Item("Jam1").ToString
        txtVech.Text = tDs.Tables(0).Rows(0).Item("Vehicle").ToString
        txtNoAcc.Text = tDs.Tables(0).Rows(0).Item("NoAccount").ToString
        txtDO.Text = tDs.Tables(0).Rows(0).Item("DO").ToString
        txtProduct.Text = tDs.Tables(0).Rows(0).Item("Product").ToString
        txtWG1.Text = tDs.Tables(0).Rows(0).Item("Berat1Brutto").ToString
        txtWG2.Text = tDs.Tables(0).Rows(0).Item("Berat2Tarra").ToString
        txtADJ.Text = tDs.Tables(0).Rows(0).Item("ADJ").ToString
        txtJlhJJG.Text = tDs.Tables(0).Rows(0).Item("JumlahJanjang").ToString
        txtBJR.Text = tDs.Tables(0).Rows(0).Item("BJR").ToString
        txtNet.Text = tDs.Tables(0).Rows(0).Item("Netto").ToString
        txtHargaAkhir.Text = tDs.Tables(0).Rows(0).Item("HargaAkhir").ToString
        txtHargaAwal.Text = tDs.Tables(0).Rows(0).Item("HargaAsli").ToString
        txtFee.Text = tDs.Tables(0).Rows(0).Item("Fee").ToString
        txtSPSI.Text = tDs.Tables(0).Rows(0).Item("SPSI").ToString
        txtTotal.Text = Format(CDbl(tDs.Tables(0).Rows(0).Item("Total").ToString), "N")
        txtKet.Text = tDs.Tables(0).Rows(0).Item("Keterangan").ToString
        txtPotongan.Text = tDs.Tables(0).Rows(0).Item("potongan").ToString


        Dim myQuery2 As String = "SELECT fee,spsi FROM Customer "
        Dim namaKolom2 As String() = {"Cari"}
        Dim isiKolom2 As Object() = {txtNoAcc.Text}
        myQuery2 = myQuery2 & " Where Noaccount=@Cari"
        Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
        txtFee.Text = tDs2.Tables(0).Rows(0).Item("Fee").ToString
        txtSPSI.Text = tDs2.Tables(0).Rows(0).Item("SPSI").ToString
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        '14..15

        Dim myQuery As String
        Dim myQuery2 As String
        Dim namaKolom As String()
        Dim isiKolom As Object()
        Dim kondisiWhere As String
        Dim namaKolom2 As String()
        Dim isiKolom2 As Object()
        Dim namaKolom3 As String()
        Dim isiKolom3 As Object()
        Dim totalHarga As Double = 0
        Dim totalHarga2 As Double = 0
        Dim potongan2 As Double = 0

        If txtKet.Text = "" Then
            MsgBox("Jika edit, wajib isi keterangan", vbCritical)
            Return
        End If

        myQuery = "SELECT potongan FROM pembelian2 "
        namaKolom = {"Cari"}
        isiKolom = {txtNoticket.Text}
        myQuery = myQuery & " Where NoTicket=@Cari"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)

        potongan2 = tDs.Tables(0).Rows(0).Item("potongan").ToString

        myQuery = "Update Pembelian SET "
        myQuery2 = "Update Pembelian2 SET "

        If statPot = True Then
            namaKolom = {"NoAccount", "Keterangan", "Product", "Berat1Brutto", "Berat2Tarra", "Netto", "HargaAkhir", "potongan", "HargaAsli", "fee", "SPSI", "ManualEdit", "total"}
            isiKolom = {txtNoAcc.Text, txtKet.Text, txtProduct.Text, CDbl(txtWG1.Text), CDbl(txtWG2.Text), CDbl(txtNet.Text), CDbl(txtHargaAkhir.Text), CDbl(txtPotongan.Text), CDbl(txtHargaAwal.Text), CDbl(txtFee.Text), CDbl(txtSPSI.Text), "1", (CDbl(txtHargaAkhir.Text) - CDbl(txtPotongan.Text)) * CDbl(txtNet.Text)}
        Else
            namaKolom = {"NoAccount", "Keterangan", "Product", "Berat1Brutto", "Berat2Tarra", "Netto", "HargaAkhir", "HargaAsli", "fee", "SPSI", "ManualEdit", "total"}
            isiKolom = {txtNoAcc.Text, txtKet.Text, txtProduct.Text, CDbl(txtWG1.Text), CDbl(txtWG2.Text), CDbl(txtNet.Text), CDbl(txtHargaAkhir.Text), CDbl(txtHargaAwal.Text), CDbl(txtFee.Text), CDbl(txtSPSI.Text), "1", CDbl(txtHargaAkhir.Text) * CDbl(txtNet.Text)}
            If CDbl(potongan2) > 0 Then
                namaKolom3 = {"NoAccount", "Keterangan", "Product", "Berat1Brutto", "Berat2Tarra", "Netto", "HargaAkhir", "potongan", "HargaAsli", "fee", "SPSI", "ManualEdit", "total"}
                isiKolom3 = {txtNoAcc.Text, txtKet.Text, txtProduct.Text, CDbl(txtWG1.Text), CDbl(txtWG2.Text), CDbl(txtNet.Text), CDbl(txtHargaAkhir.Text), CDbl(potongan2), CDbl(txtHargaAwal.Text), CDbl(txtFee.Text), CDbl(txtSPSI.Text), "1", (CDbl(txtHargaAkhir.Text) - CDbl(potongan2)) * CDbl(txtNet.Text)}
            End If
        End If

        kondisiWhere = " where NoTicket =@NoTicket"
        namaKolom2 = {"NoTicket"}
        isiKolom2 = {txtNoticket.Text}

        If statPot = True Then
            clsKoneksi.updateCommand(1, myQuery2, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
        Else
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            clsKoneksi.updateCommand(1, myQuery2, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            If CDbl(potongan2) > 0 Then
                clsKoneksi.updateCommand(1, myQuery2, namaKolom3, isiKolom3, kondisiWhere, namaKolom2, isiKolom2, 1)
            End If
        End If



        'myQuery = "Update Pembelian2 SET "
        'namaKolom = {"NoAccount", "Keterangan", "Product", "Berat1Brutto", "Berat2Tarra", "Netto", "HargaAkhir", "potongan", "HargaAsli", "fee", "SPSI", "ManualEdit", "total"}
        'isiKolom = {txtNoAcc.Text, txtKet.Text, txtProduct.Text, CDbl(txtWG1.Text), CDbl(txtWG2.Text), CDbl(txtNet.Text), CDbl(txtHargaAkhir.Text), CDbl(txtPotongan.Text), CDbl(txtHargaAwal.Text), CDbl(txtFee.Text), CDbl(txtSPSI.Text), "1", CDbl(txtTotal.Text)}
        'kondisiWhere = " where NoTicket =@NoTicket"
        'namaKolom2 = {"NoTicket"}
        'isiKolom2 = {txtNoticket.Text}


        If statPot = True Then
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(14).Value = CDbl(txtHargaAkhir.Text)
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(15).Value = CDbl(txtPotongan.Text)
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(16).Value = CDbl(txtTotal.Text)
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(13).Value = CDbl(txtNet.Text)
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(4).Value = txtNoAcc.Text
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(7).Value = txtProduct.Text
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(8).Value = CDbl(txtWG1.Text)
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(9).Value = CDbl(txtWG1.Text)
            frmInputHargaPotongan.dgView.Rows(rowT).Cells(19).Value = True
            'frmInputHargaPotongan.dgView.Rows(rowT).Cells(20).Value = txtKet.Text
        Else
            frmInputHarga.dgView.Rows(rowT).Cells(14).Value = CDbl(txtHargaAkhir.Text)
            frmInputHarga.dgView.Rows(rowT).Cells(15).Value = CDbl(txtPotongan.Text)
            frmInputHarga.dgView.Rows(rowT).Cells(16).Value = CDbl(txtTotal.Text)
            frmInputHarga.dgView.Rows(rowT).Cells(13).Value = CDbl(txtNet.Text)
            frmInputHarga.dgView.Rows(rowT).Cells(4).Value = txtNoAcc.Text
            frmInputHarga.dgView.Rows(rowT).Cells(7).Value = txtProduct.Text
            frmInputHarga.dgView.Rows(rowT).Cells(8).Value = CDbl(txtWG1.Text)
            frmInputHarga.dgView.Rows(rowT).Cells(9).Value = CDbl(txtWG1.Text)
            frmInputHarga.dgView.Rows(rowT).Cells(19).Value = True
            frmInputHarga.dgView.Rows(rowT).Cells(20).Value = txtKet.Text
        End If


        'frmInputHarga.loadCari()
        Me.Close()
    End Sub

    Private Sub txtHargaAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaAkhir.KeyPress
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub

    Private Sub txtHargaAkhir_TextChanged(sender As Object, e As EventArgs) Handles txtHargaAkhir.TextChanged
        Try
            If txtHargaAkhir.Text = "" Then
                txtTotal.Text = CDbl(0) * CDbl(txtNet.Text)
                txtHargaAwal.Text = CDbl(0) - CDbl(txtFee.Text) - CDbl(txtSPSI.Text)
            Else
                txtTotal.Text = CDbl(txtHargaAkhir.Text) * CDbl(txtNet.Text)
                txtHargaAwal.Text = CDbl(txtHargaAkhir.Text) - CDbl(txtFee.Text) - CDbl(txtSPSI.Text)
                txtTotal.Text = Format(CDbl(txtTotal.Text), "N")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCariPotongan_Click(sender As Object, e As EventArgs)
        frmCariPotongan.txtCari.Text = lblKodeKelompok.Text
        frmCariPotongan.ShowDialog()
    End Sub

    Private Sub frmInputHargaEditDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        txtPotongan.Text = "0"
        txtWG1.Enabled = False
        txtWG2.Enabled = False
        txtNet.Enabled = False
    End Sub


    Private Sub txtNet_TextChanged(sender As Object, e As EventArgs) Handles txtNet.TextChanged
        Try
            If txtNet.Text = "" Then
                txtTotal.Text = CDbl(0) * CDbl(txtHargaAkhir.Text)
            Else
                txtTotal.Text = CDbl(txtHargaAkhir.Text) * CDbl(txtNet.Text)
                txtTotal.Text = Format(CDbl(txtTotal.Text), "N")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditNetto_Click(sender As Object, e As EventArgs) Handles btnEditNetto.Click
        frmPasswordEditNetto.ShowDialog()
    End Sub

    Private Sub txtNoAcc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoAcc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNoAcc.Text = "" Then
                MsgBox("No Account tidak boleh kosong", vbCritical)
                Return
            End If

            Dim myQuery As String = ""
            myQuery = "select h.harga,c.NoAccount,c.Nama,c.KodeKelompok from customer c inner join harga h on(h.kodeKelompok=c.kodeKelompok) where c.NoAccount='" & txtNoAcc.Text & "' and h.Tgl=#" & dtTgl.Value.ToString("MM/dd/yyyy") & "#"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)

            If tDs.Tables(0).Rows.Count < 1 Then
                MsgBox("No Account tidak ditemukan")
                Return
            End If


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
                txtProduct.Text = isiView(2)
                txtKodeKelompok.Text = isiView(3)
                txtHargaAkhir.Text = isiView(0)
            Next
        End If
    End Sub

    Private Sub frmInputHargaEditDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If statPot = True Then
            txtPotongan.Enabled = True
            txtHargaAkhir.Enabled = False
            txtHargaAwal.Enabled = False
        Else
            txtPotongan.Enabled = False
            txtHargaAkhir.Enabled = True
            txtHargaAwal.Enabled = False
        End If
    End Sub

    Private Sub txtPotongan_TextChanged(sender As Object, e As EventArgs) Handles txtPotongan.TextChanged
        Try
            If txtPotongan.Text = "" Then
            Else
                txtTotal.Text = (CDbl(txtHargaAkhir.Text) - CDbl(txtPotongan.Text)) * CDbl(txtNet.Text)
                txtHargaAwal.Text = CDbl(txtHargaAkhir.Text) - CDbl(txtFee.Text) - CDbl(txtSPSI.Text)
                txtTotal.Text = Format(CDbl(txtTotal.Text), "N")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class