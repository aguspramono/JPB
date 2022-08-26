Imports System.Data.OleDb
Public Class frmInputSettingSPSIJumlahSPSI

    Public modeEdit As Boolean = False
    Public noAccount As String
    Public kodeJumlah As Double
    Public idEdit As Double

    Sub hitungTotal()
        Dim tTotal As Double = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            tTotal += dgvData.Rows(i).Cells(7).Value
        Next
        txtSPSI.Text = tTotal
        lblSPSI.Text = tTotal
        lblSPSI2.Text = FormatNumber(tTotal)
    End Sub

    Sub bersih()
        dgvData.Rows.Clear()
        modeEdit = False
        noAccount = ""
        lblSPSI.Text = 0
        txtCustomer.Clear()
        txtSPSI.Text = 0
        btnCari.Enabled = True
    End Sub

    Private Sub dgvData_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvData.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan.Show(dgvData, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click_1(sender As Object, e As EventArgs) Handles mnuTambah.Click

        frmCariJumlahSpsi.noBukti = "''"

        If dgvData.Rows.Count > 0 Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If i = 0 Then
                    frmCariJumlahSpsi.noBukti = "'" & dgvData.Rows(i).Cells(3).Value & "'"
                Else
                    frmCariJumlahSpsi.noBukti = frmCariJumlahSpsi.noBukti & ",'" & dgvData.Rows(i).Cells(3).Value & "'"
                End If
            Next
        End If
        frmCariJumlahSpsi.ShowDialog()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If dgvData.Rows.Count > 0 Then
            If dgvData.SelectedRows.Item(0).Index >= 0 Then
                dgvData.Rows.Remove(dgvData.SelectedRows.Item(0))
                hitungTotal()
            End If
        End If
    End Sub


    Private Sub btnCari_Click_1(sender As Object, e As EventArgs) Handles btnCari.Click
        frmCustomerCari.pilihan = "SPSIJumlah"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub frmInputSettingSPSIJumlahSPSI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub

    Private Sub frmInputSettingSPSIJumlahSPSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckUtama.Checked = True
        If modeEdit = True Then
            btnCari.Enabled = False
        End If
    End Sub

    Private Sub btnOk_Click_1(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If txtSPSI.Text = "" Or txtSPSI.Text = 0 Then
            MsgBox("Total spsi tidak boleh 0 atau kosong")
            Return
        End If

        If txtCustomer.Text = "" Then
            MsgBox("Customer belum dipilih")
            Return
        End If


        If modeEdit = False Then

            Dim spsiUtama As String = "N"

            If ckUtama.Checked = True Then

                Dim myQuery8 As String = "Update SPSIPenjumlahanPerAccount SET Utama='N' where NoAccount='" & noAccount & "'"
                Dim cmd As New OleDbCommand(myQuery8, clsKoneksi.getConnection(1))
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()

                spsiUtama = "Y"
            End If

            'cek kode
            Dim kodeJumlah As Double = 0
            Dim myQuery As String = "select IIF(max(kodePenjumlahanSpsi)>0,max(kodePenjumlahanSpsi),0) as kodePenjumlahan from SPSIPenjumlahanPerAccount"
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
                If isiView(0) > 0 Then
                    kodeJumlah = isiView(0) + 1
                Else
                    kodeJumlah = 1
                End If
            Next

            Dim myQuery1 As String = "INSERT INTO SPSIPenjumlahanPerAccount "
            Dim namaKolom As String() = {"kodePenjumlahanSpsi", "NoAccount", "SPSI", "Utama", "SPSI2"}
            Dim isiKolom As Object() = {CDbl(kodeJumlah), noAccount, CDbl(lblSPSI.Text), spsiUtama, CDbl(txtSPSI.Text)}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom, isiKolom)

            Dim myQuery3 As String = "INSERT INTO detailSPSIPenjumlahanPerAccount "
            Dim namaKolom3 As String() = {"kodePenjumlahanSpsi", "Tanggal", "NoAcc", "NoBukti", "Nama", "SPSI", "Keterangan", "Nilai"}

            Dim isiKolom3(8) As Object
            ReDim isiKolom3((namaKolom3.Length * dgvData.Rows.Count) - 1)
            Dim cntT As Integer = 0
            If dgvData.Rows.Count = 1 Then
                For i = 0 To dgvData.Rows.Count - 1
                    Dim edate As String = dgvData.Rows(i).Cells(1).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = kodeJumlah
                    isiKolom3(cntT + 1) = expenddt
                    isiKolom3(cntT + 2) = dgvData.Rows(i).Cells(2).Value
                    isiKolom3(cntT + 3) = dgvData.Rows(i).Cells(3).Value
                    isiKolom3(cntT + 4) = dgvData.Rows(i).Cells(4).Value
                    isiKolom3(cntT + 5) = dgvData.Rows(i).Cells(5).Value
                    isiKolom3(cntT + 6) = dgvData.Rows(i).Cells(6).Value
                    isiKolom3(cntT + 7) = CDbl(dgvData.Rows(i).Cells(7).Value)
                    cntT += 8
                Next
                clsKoneksi.insertCommand(1, myQuery3, namaKolom3, isiKolom3)

            Else

                For i = 0 To dgvData.Rows.Count - 1
                    Dim edate As String = dgvData.Rows(i).Cells(1).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = CDbl(kodeJumlah)
                    isiKolom3(cntT + 1) = "'" & expenddt & "'"
                    isiKolom3(cntT + 2) = "'" & dgvData.Rows(i).Cells(2).Value & "'"
                    isiKolom3(cntT + 3) = "'" & dgvData.Rows(i).Cells(3).Value & "'"
                    isiKolom3(cntT + 4) = "'" & dgvData.Rows(i).Cells(4).Value & "'"
                    isiKolom3(cntT + 5) = "'" & dgvData.Rows(i).Cells(5).Value & "'"
                    isiKolom3(cntT + 6) = "'" & dgvData.Rows(i).Cells(6).Value & "'"
                    If decimalSeparator = "," Then
                        isiKolom3(cntT + 7) = CDbl(dgvData.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom3(cntT + 7) = CDbl(dgvData.Rows(i).Cells(7).Value)
                    End If
                    cntT += 8

                Next
                clsKoneksi.insertCommand2(1, myQuery3, namaKolom3, isiKolom3)

            End If

            frmSettingSPSI.loadDataJumlahAccount()
            MsgBox("Berhasil disimpan", vbInformation)
            bersih()


        Else


            Dim spsiUtama As String = "N"

            If ckUtama.Checked = True Then

                Dim myQuery8 As String = "Update SPSIPenjumlahanPerAccount SET Utama='N' where NoAccount='" & noAccount & "'"
                Dim cmd As New OleDbCommand(myQuery8, clsKoneksi.getConnection(1))
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()

                spsiUtama = "Y"
            End If


            Dim myQuery As String = "Update SPSIPenjumlahanPerAccount SET "
            Dim namaKolom As String() = {"SPSI", "Utama", "SPSI2"}
            Dim isiKolom As Object() = {CDbl(lblSPSI.Text), spsiUtama, CDbl(txtSPSI.Text)}
            Dim kondisiWhere As String = " where idSpsiPenjumlahanPerAccount=@idSpsiPenjumlahanPerAccount"
            Dim namaKolom2 As String() = {"idSpsiPenjumlahanPerAccount"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)


            Dim myQuery4 As String = "delete from detailSPSIPenjumlahanPerAccount where kodePenjumlahanSpsi=@kodePenjumlahanSpsi"
            Dim namaKolom4 As String() = {"kodePenjumlahanSpsi"}
            Dim isiKolom4 As Object() = {kodeJumlah}
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom4, isiKolom4, 1)


            Dim myQuery3 As String = "INSERT INTO detailSPSIPenjumlahanPerAccount "
            Dim namaKolom3 As String() = {"kodePenjumlahanSpsi", "Tanggal", "NoAcc", "NoBukti", "Nama", "SPSI", "Keterangan", "Nilai"}

            Dim isiKolom3(8) As Object
            ReDim isiKolom3((namaKolom3.Length * dgvData.Rows.Count) - 1)
            Dim cntT As Integer = 0
            If dgvData.Rows.Count = 1 Then
                For i = 0 To dgvData.Rows.Count - 1
                    Dim edate As String = dgvData.Rows(i).Cells(1).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = kodeJumlah
                    isiKolom3(cntT + 1) = expenddt
                    isiKolom3(cntT + 2) = dgvData.Rows(i).Cells(2).Value
                    isiKolom3(cntT + 3) = dgvData.Rows(i).Cells(3).Value
                    isiKolom3(cntT + 4) = dgvData.Rows(i).Cells(4).Value
                    isiKolom3(cntT + 5) = dgvData.Rows(i).Cells(5).Value
                    isiKolom3(cntT + 6) = dgvData.Rows(i).Cells(6).Value
                    isiKolom3(cntT + 7) = CDbl(dgvData.Rows(i).Cells(7).Value)
                    cntT += 8
                Next
                clsKoneksi.insertCommand(1, myQuery3, namaKolom3, isiKolom3)

            Else

                For i = 0 To dgvData.Rows.Count - 1
                    Dim edate As String = dgvData.Rows(i).Cells(1).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)

                    isiKolom3(cntT + 0) = CDbl(kodeJumlah)
                    isiKolom3(cntT + 1) = "'" & expenddt & "'"
                    isiKolom3(cntT + 2) = "'" & dgvData.Rows(i).Cells(2).Value & "'"
                    isiKolom3(cntT + 3) = "'" & dgvData.Rows(i).Cells(3).Value & "'"
                    isiKolom3(cntT + 4) = "'" & dgvData.Rows(i).Cells(4).Value & "'"
                    isiKolom3(cntT + 5) = "'" & dgvData.Rows(i).Cells(5).Value & "'"
                    isiKolom3(cntT + 6) = "'" & dgvData.Rows(i).Cells(6).Value & "'"
                    If decimalSeparator = "," Then
                        isiKolom3(cntT + 7) = CDbl(dgvData.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom3(cntT + 7) = CDbl(dgvData.Rows(i).Cells(7).Value)
                    End If
                    cntT += 8

                Next
                clsKoneksi.insertCommand2(1, myQuery3, namaKolom3, isiKolom3)
            End If

            frmSettingSPSI.loadDataJumlahAccount()
            MsgBox("Berhasil diubah", vbInformation)
            bersih()
            Me.Close()

        End If
    End Sub

    Private Sub ckmanual_CheckedChanged(sender As Object, e As EventArgs) Handles ckmanual.CheckedChanged
        If ckmanual.Checked = True Then
            txtSPSI.Enabled = True
        Else
            txtSPSI.Enabled = False
        End If
    End Sub

    Private Sub txtSPSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSPSI.KeyPress
        clsKoneksi.OnlyNumber(e, txtSPSI)
    End Sub
End Class