Public Class frmSettingTanggalFee
    Dim btnPilih As String
    Sub activeButton()
        btnBaru.Enabled = False
        btnEdit.Enabled = False
        btnOk.Enabled = True
        btnBatal.Enabled = True
        btnCariKelompok.Enabled = True
        dtpTanggalDari.Enabled = True
        dtpTanggalSampai.Enabled = True
        txtFee.Enabled = True
    End Sub

    Sub nonactiveButton()
        btnBaru.Enabled = True
        btnEdit.Enabled = True
        btnOk.Enabled = False
        btnBatal.Enabled = False
        btnCariKelompok.Enabled = False
        dtpTanggalDari.Enabled = False
        dtpTanggalSampai.Enabled = False
        txtFee.Enabled = False
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "TanggalFee"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        btnPilih = "Baru"
        activeButton()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        nonactiveButton()
    End Sub

    Private Sub frmSettingTanggalFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggalDari.Value = Date.Now
        dtpTanggalSampai.Value = Date.Now
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If btnPilih = "Baru" Then

            Dim arrivaldate As DateTime = dtpTanggalDari.Value
            Dim departuredate As DateTime = dtpTanggalSampai.Value
            Dim DaysStayed As Int32 = departuredate.Subtract(arrivaldate).Days
            Dim jumlahData As Integer = DaysStayed + 1
            Dim tanggalMulai As DateTime = dtpTanggalDari.Value

            Dim myQuery2 As String = "INSERT INTO FeeTanggal "
            Dim namaKolom2 As String() = {"KodeKelompok", "Tanggal", "Fee"}

            Dim isiKolom2(3) As Object
            ReDim isiKolom2((namaKolom2.Length * jumlahData) - 1)

            Dim cntT As Integer = 0
            Dim i As Integer
            If jumlahData = 1 Then

                For i = 0 To jumlahData - 1
                    isiKolom2(cntT + 0) = txtKelompok.Text
                    isiKolom2(cntT + 1) = Format(dtpTanggalDari.Value.Date, "MM/dd/yyyy")
                    isiKolom2(cntT + 2) = CDbl(txtFee.Text)
                    cntT += 3
                Next
                clsKoneksi.insertCommand(1, myQuery2, namaKolom2, isiKolom2)
                i = 0

            Else
                For i = 0 To jumlahData - 1
                    Dim tanggalSelanjutnya As DateTime = tanggalMulai.AddDays(i)
                    isiKolom2(cntT + 0) = "'" & txtKelompok.Text & "'"
                    isiKolom2(cntT + 1) = "'" & tanggalSelanjutnya.Date.Month & "/" & tanggalSelanjutnya.Date.Day & "/" & tanggalSelanjutnya.Date.Year & "'"
                    isiKolom2(cntT + 2) = "'" & CDbl(txtFee.Text) & "'"
                    cntT += 3
                Next
                clsKoneksi.insertCommand2(1, myQuery2, namaKolom2, isiKolom2)
                i = 0
            End If

        Else



        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnPilih = "Edit"
        activeButton()
    End Sub
End Class