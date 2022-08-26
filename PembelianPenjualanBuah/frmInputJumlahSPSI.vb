Public Class frmInputJumlahSPSI
    Public modeEdit As Boolean = False
    Public idEdit As Integer

    Sub bersih()
        txtNoAcc.Clear()
        txtNoBukti.Clear()
        txtNama.Clear()
        txtSPSI.Clear()
        txtKeterangan.Clear()
        txtNilai.Clear()
        modeEdit = False
    End Sub

    Private Sub frmInputJumlahSPSI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub
    Private Sub frmInputJumlahSPSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modeEdit = False Then
            dtpTanggal.Value = Date.Now
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtNoAcc.Text = "" Or txtNoBukti.Text = "" Or txtNama.Text = "" Or txtSPSI.Text = "" Or txtKeterangan.Text = "" Or txtNilai.Text = "" Then
            MsgBox("Masih ada data yang belum di isi", vbCritical)
            Return
        End If

        If modeEdit = False Then
            Dim myQuery1 As String = "INSERT INTO SpsiPenjumlahan "
            Dim namaKolom1 As String() = {"Tanggal", "NoAcc", "NoBukti", "Nama", "SPSI", "Keterangan", "Nilai"}
            Dim isiKolom1 As Object() = {dtpTanggal.Value.Date, txtNoAcc.Text, txtNoBukti.Text, txtNama.Text, txtSPSI.Text, txtKeterangan.Text, CDbl(txtNilai.Text)}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            frmSPSI.loadData()
            MsgBox("Berhasil Disimpan", vbInformation)
            bersih()
        Else

            Dim myQuery1 As String = "UPDATE SpsiPenjumlahan Set "
            Dim namaKolom1 As String() = {"Tanggal", "NoAcc", "NoBukti", "Nama", "SPSI", "Keterangan", "Nilai"}
            Dim isiKolom1 As Object() = {dtpTanggal.Value.Date, txtNoAcc.Text, txtNoBukti.Text, txtNama.Text, txtSPSI.Text, txtKeterangan.Text, CDbl(txtNilai.Text)}

            Dim kondisiWhere As String = " where idSpsiPenjumlahan =@idSpsiPenjumlahan"
            Dim namaKolom2 As String() = {"idSpsiPenjumlahan"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            frmSPSI.loadData()
            MsgBox("Berhasil Diubah", vbInformation)
            bersih()
            Me.Close()

        End If
    End Sub

    Private Sub btnCariNama_Click(sender As Object, e As EventArgs) Handles btnCariNama.Click
        'frmInputNamaSPSI.ShowDialog()
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        clsKoneksi.OnlyNumber(e, txtNilai)
    End Sub

End Class