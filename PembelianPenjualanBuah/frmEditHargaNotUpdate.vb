Public Class frmEditHargaNotUpdate
    Public dtHelp2 As Object
    Public tRow As Integer

    Sub bersih()
        txtKelompok.Clear()
        txtHarga.Clear()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim kondisiWhere As String
        Dim selisih As Double = 0
        Dim harga As Double = 0
        Dim hargaLama As Double = 0

        harga = IIf(txtHarga.Text = "", 0, txtHarga.Text)
        hargaLama = IIf(lblHargaLama.Text = "", 0, lblHargaLama.Text)

        selisih = harga - hargaLama

        Dim myQuery As String = "UPDATE Harga " & _
                            "SET  " & _
                            "Harga = @PerubahanAA, Perubahan=Perubahan+@PerubahanBB "
        kondisiWhere = "WHERE KodeKelompok in (" & txtKelompok.Text & ") and Tgl = @tglAA and Jam=@jamAA and KodeKota=@KodeKotaAA"
        Dim namaKolom As String() = {""}
        Dim isiKolom As Object() = {""}
        Dim namaKolom2 As String() = {"PerubahanAA", "PerubahanBB", "tglAA", "jamAA", "KodeKotaAA"}
        Dim isiKolom2 As Object() = {CDbl(txtHarga.Text), CDbl(selisih), dtpTanggal.Value, dtHelp2, clsKoneksi.kotaOn}
        clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 2)


        'frmUpdateHarga.loadMain()

        frmUpdateHarga.loadUpdateHargaNotperubahan(tRow, CDbl(txtHarga.Text))
        bersih()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
        Me.Close()
    End Sub
End Class