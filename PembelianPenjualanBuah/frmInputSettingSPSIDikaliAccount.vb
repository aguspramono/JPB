Public Class frmInputSettingSPSIDikaliAccount
    Public modeEdit As Boolean = False
    Public IDEdit As Integer

    Sub bersih()
        txtKelompok.Clear()
        txtSPSI.Clear()
        btnCariKelompok.Enabled = True
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "SPSIKaliAccount"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If txtKelompok.Text = "" Or txtSPSI.Text = "" Then
            MsgBox("Masih ada data yang belum di isi", vbCritical)
            Return
        End If

        If modeEdit = False Then

            Dim myQuery As String = "select KodeKelompok from SPSIKaliAccount where"
            Dim namaKolom As String() = {"ID"}
            Dim isiKolom As Object() = {txtKelompok.Text}
            myQuery = myQuery & " KodeKelompok=@ID"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Kode Kelompok ini sudah ada", vbCritical)
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO SPSIKaliAccount "
            Dim namaKolom1 As String() = {"KodeKelompok", "SPSI"}
            Dim isiKolom1 As Object() = {txtKelompok.Text, CDbl(txtSPSI.Text)}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            MsgBox("Berhasil Disimpan", vbInformation)
            frmSettingSPSI.loadDataKaliAccount()
            bersih()

        Else

            Dim myQuery1 As String = "UPDATE SPSIKaliAccount Set "
            Dim namaKolom1 As String() = {"SPSI"}
            Dim isiKolom1 As Object() = {CDbl(txtSPSI.Text)}

            Dim kondisiWhere As String = " where idSPSIKaliAccount =@idSPSIKaliAccount"
            Dim namaKolom2 As String() = {"idSPSIKaliAccount"}
            Dim isiKolom2 As Object() = {IDEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)

            MsgBox("Berhasil Diubah", vbInformation)
            frmSettingSPSI.loadDataKaliAccount()
            bersih()
            Me.Close()

        End If

    End Sub

    Private Sub frmInputSettingSPSIDikaliAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub

    Private Sub txtSPSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSPSI.KeyPress
        clsKoneksi.OnlyNumber(e, txtSPSI)
    End Sub
End Class