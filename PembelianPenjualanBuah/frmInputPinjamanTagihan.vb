Public Class frmInputPinjamanTagihan

    Public edit As Boolean = False
    Public kodePinjaman As String = ""
    Public idEdit As Double

    Sub bersih()
        txtJumlah.Clear()
        edit = False
        ckDefault.Checked = False
        kodePinjaman = ""
    End Sub

    Private Sub frmInputPinjamanTagihan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub

    Private Sub frmInputPinjamanTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim status As String = "N"
        Dim jumlahTertagih As Double = 0
        Dim jumlahTotalTertagih As Double = 0

        If CDbl(txtJumlah.Text) > CDbl(frmPinjamanTagihan.txtSisaPinjaman.Text) Then
            MsgBox("Jumlah tidak boleh melebihi sisa pinjaman", vbCritical)
            Return
        End If

        If txtJumlah.Text = "" Or txtJumlah.Text = 0 Then
            MsgBox("Jumlah tidak boleh kosong atau 0", vbCritical)
            Return
        End If

        If edit = False Then

            If ckDefault.Checked = True Then
                status = "Y"
                Dim myQuery2 As String = "UPDATE PinjamanTagihan Set "
                Dim namaKolom2 As String() = {"Status"}
                Dim isiKolom2 As Object() = {"N"}

                Dim kondisiWhere As String = " where KodePinjaman =@KodePinjaman"
                Dim namaKolom3 As String() = {"KodePinjaman"}
                Dim isiKolom3 As Object() = {kodePinjaman}
                clsKoneksi.updateCommand(1, myQuery2, namaKolom2, isiKolom2, kondisiWhere, namaKolom3, isiKolom3, 1)
            End If

            Dim myQuery1 As String = "INSERT INTO PinjamanTagihan "
            Dim namaKolom1 As String() = {"KodePinjaman", "TanggalPinjamanTagihan", "JumlahPinjamanTagihan", "Keterangan", "Status"}
            Dim isiKolom1 As Object() = {kodePinjaman, dtpTanggal.Value.Date, CDbl(txtJumlah.Text), "Belum Lunas", status}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)


            Dim myQuery As String = "select IIF(IsNull(SUM(JumlahPinjamanTagihan)), 0, SUM(JumlahPinjamanTagihan)) from PinjamanTagihan"
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
                jumlahTertagih = isiView(0)
            Next


            Dim myQuery4 As String = "UPDATE Pinjaman Set "
            Dim namaKolom4 As String() = {"CetakTagihan"}
            Dim isiKolom4 As Object() = {CDbl(jumlahTertagih)}

            Dim kondisiWhere1 As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom5 As String() = {"KodePinjaman"}
            Dim isiKolom5 As Object() = {kodePinjaman}
            clsKoneksi.updateCommand(1, myQuery4, namaKolom4, isiKolom4, kondisiWhere1, namaKolom5, isiKolom5, 1)

            frmPinjamanTagihan.tampilData()

            For i As Integer = 0 To frmPinjamanTagihan.dgvData.Rows.Count - 1
                jumlahTotalTertagih += frmPinjamanTagihan.dgvData.Rows(i).Cells(2).Value
            Next

            frmPinjamanTagihan.txtTotalTagihan.Text = FormatNumber(jumlahTotalTertagih)

            frmPinjamanTagihan.txtSisaPinjaman.Text = FormatNumber(CDbl(frmPinjamanTagihan.txtJumlahPinjaman.Text) - CDbl(frmPinjamanTagihan.txtTotalTagihan.Text))

            Dim myQuery7 As String = "UPDATE Pinjaman Set "
            Dim namaKolom7 As String() = {"SisaPinjaman"}
            Dim isiKolom7 As Object() = {CDbl(frmPinjamanTagihan.txtSisaPinjaman.Text)}

            Dim kondisiWhere3 As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom8 As String() = {"KodePinjaman"}
            Dim isiKolom8 As Object() = {kodePinjaman}
            clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere3, namaKolom8, isiKolom8, 1)

            frmPinjaman.tampilData()

            MsgBox("Data berhasil disimpan")
            bersih()


        Else
            If ckDefault.Checked = True Then
                status = "Y"
                Dim myQuery2 As String = "UPDATE PinjamanTagihan Set "
                Dim namaKolom3 As String() = {"Status"}
                Dim isiKolom3 As Object() = {"N"}

                Dim kondisiWhere1 As String = " where KodePinjaman =@KodePinjaman"
                Dim namaKolom4 As String() = {"KodePinjaman"}
                Dim isiKolom4 As Object() = {kodePinjaman}
                clsKoneksi.updateCommand(1, myQuery2, namaKolom3, isiKolom3, kondisiWhere1, namaKolom4, isiKolom4, 1)
            End If

            Dim myQuery1 As String = "UPDATE PinjamanTagihan Set "
            Dim namaKolom1 As String() = {"TanggalPinjamanTagihan", "JumlahPinjamanTagihan", "Status"}
            Dim isiKolom1 As Object() = {dtpTanggal.Value.Date, CDbl(txtJumlah.Text), status}

            Dim kondisiWhere As String = " where IDPinjamanTagihan =@IDPinjamanTagihan"
            Dim namaKolom2 As String() = {"IDPinjamanTagihan"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)


            Dim myQuery As String = "select IIF(IsNull(SUM(JumlahPinjamanTagihan)), 0, SUM(JumlahPinjamanTagihan)) from PinjamanTagihan"
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
                jumlahTertagih = isiView(0)
            Next


            Dim myQuery5 As String = "UPDATE Pinjaman Set "
            Dim namaKolom5 As String() = {"CetakTagihan"}
            Dim isiKolom5 As Object() = {CDbl(jumlahTertagih)}

            Dim kondisiWhere2 As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom6 As String() = {"KodePinjaman"}
            Dim isiKolom6 As Object() = {kodePinjaman}
            clsKoneksi.updateCommand(1, myQuery5, namaKolom5, isiKolom5, kondisiWhere2, namaKolom6, isiKolom6, 1)

            frmPinjamanTagihan.tampilData()

            For i As Integer = 0 To frmPinjamanTagihan.dgvData.Rows.Count - 1
                jumlahTotalTertagih += frmPinjamanTagihan.dgvData.Rows(i).Cells(2).Value
            Next

            frmPinjamanTagihan.txtTotalTagihan.Text = FormatNumber(jumlahTotalTertagih)

            frmPinjamanTagihan.txtSisaPinjaman.Text = FormatNumber(CDbl(frmPinjamanTagihan.txtJumlahPinjaman.Text) - CDbl(frmPinjamanTagihan.txtTotalTagihan.Text))

            Dim myQuery7 As String = "UPDATE Pinjaman Set "
            Dim namaKolom7 As String() = {"SisaPinjaman"}
            Dim isiKolom7 As Object() = {CDbl(frmPinjamanTagihan.txtSisaPinjaman.Text)}

            Dim kondisiWhere3 As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom8 As String() = {"KodePinjaman"}
            Dim isiKolom8 As Object() = {kodePinjaman}
            clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere3, namaKolom8, isiKolom8, 1)

            frmPinjaman.tampilData()

            MsgBox("Data berhasil diupdate")

            bersih()
            Me.Close()

        End If



    End Sub
End Class