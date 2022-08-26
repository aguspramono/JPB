Public Class frmInputPinjaman
    Public edit As Boolean = False
    Public noAccount As String = ""
    Public jumlahPinjaman As Double = 0
    Public sisaPinjaman As Double = 0
    Public idEdit As String = ""

    Sub bersih()
        edit = False
        noAccount = ""
        idEdit = ""
        txtCustomer.Clear()
        txtJumlah.Clear()
        txtKeterangan.Clear()
        jumlahPinjaman = 0
        sisaPinjaman = 0
    End Sub

    Private Sub frmInputPinjaman_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub

    Private Sub frmInputPinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kodePinjaman As String = ""
        Dim tahun As String = Format(Date.Now, "yy")
        Dim bulan As String = Format(Date.Now, "MM")

        If txtCustomer.Text = "" Then
            MsgBox("Customer belum dipilih")
            Return
        End If

        If txtJumlah.Text = "" Or txtJumlah.Text = 0 Then
            MsgBox("Jumlah belum diisi atau jumlah tidak boleh kurang dari 0")
            Return
        End If

        If edit = False Then
            Dim myQuery As String = "select IIF(IsNull(Max(IDPinjaman)), 0, max(IDPinjaman)) from Pinjaman"
            myQuery = myQuery
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
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
                kodePinjaman = isiView(0)
            Next

            kodePinjaman = "PC" & bulan & tahun & kodePinjaman

            Dim myQuery1 As String = "INSERT INTO Pinjaman "
            Dim namaKolom1 As String() = {"KodePinjaman", "NoAccount", "TanggalPinjaman", "JumlahPinjaman", "SisaPinjaman", "Keterangan"}
            Dim isiKolom1 As Object() = {kodePinjaman, noAccount, dtpTanggal.Value.Date, CDbl(txtJumlah.Text), CDbl(txtJumlah.Text), txtKeterangan.Text}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)

            MsgBox("Data berhasil disimpan")
            frmPinjaman.tampilData()
        Else

            Dim tambahKurangPinjaman As Double = 0

            If jumlahPinjaman >= CDbl(txtJumlah.Text) Then
                tambahKurangPinjaman = jumlahPinjaman - CDbl(txtJumlah.Text)
                sisaPinjaman = sisaPinjaman - tambahKurangPinjaman
            Else
                tambahKurangPinjaman = CDbl(txtJumlah.Text) - jumlahPinjaman
                sisaPinjaman = sisaPinjaman + tambahKurangPinjaman
            End If


            Dim myQuery1 As String = "UPDATE Pinjaman Set "
            Dim namaKolom1 As String() = {"TanggalPinjaman", "JumlahPinjaman", "SisaPinjaman", "Keterangan"}
            Dim isiKolom1 As Object() = {dtpTanggal.Value.Date, CDbl(txtJumlah.Text), CDbl(sisaPinjaman), txtKeterangan.Text}

            Dim kondisiWhere As String = " where kodePinjaman =@kodePinjaman"
            Dim namaKolom2 As String() = {"kodePinjaman"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            MsgBox("Data Berhasil Diubah")
            frmPinjaman.tampilData()
            Me.Close()

        End If

        bersih()

    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        clsKoneksi.OnlyNumber(e, txtJumlah)
    End Sub

    Private Sub btnCariCustomer_Click(sender As Object, e As EventArgs) Handles btnCariCustomer.Click
        frmCustomerCari.pilihan = "Pinjaman"
        frmCustomerCari.ShowDialog()
    End Sub
End Class