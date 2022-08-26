Public Class frmInputPembayaranNoTicket
    Public edit As Boolean = False
    Public noBuktiTicket As String = ""
    Public noTicket As String = ""
    Public total As Double = 0
    Public dibayar As Double = 0
    Public sisaBayar As Double = 0
    Public jumlahLama As Double = 0
    Public idEdit As Integer

    Sub bersih()
        txtJumlah.Text = ""
        edit = False
        noBuktiTicket = ""
        noTicket = ""
        total = 0
        dibayar = 0
        sisaBayar = 0
        jumlahLama = 0
    End Sub

    Sub tampilDetailPembayaran()
        Dim myQuery As String = "select NoTicket,Tgl,Product,Netto,Harga,Total,Dibayar,SisaBayar,Keterangan,KodeKota FROM PembayaranDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {noBuktiTicket}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        frmPembayaranBPT.dgvData.Rows.Clear()
        Dim isiView(9) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            frmPembayaranBPT.dgvData.Rows.Add(isiView)

            If isiView(8) = "Lunas" Then
                frmPembayaranBPT.dgvData.Rows(frmPembayaranBPT.dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Sub tampilSisaBayar()
        Dim myQuery1 As String = "select IIF(IsNull(SUM(SisaBayar)), 0, SUM(SisaBayar)) as JumlahTotal,IIF(IsNull(SUM(Dibayar)), 0, SUM(Dibayar)) as JumlahBayar from PembayaranDetail where KodePembayaran='" & noBuktiTicket & "' and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery1 = myQuery1
        Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            frmPembayaranBPT.txtSisa.Text = FormatNumber(isiView1(0))
            frmPembayaranBPT.txtDibayar.Text = FormatNumber(isiView1(1))
        Next
    End Sub

    Private Sub frmInputPembayaranNoTicket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub
    Private Sub frmInputPembayaranNoTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim keterangan As String = ""
        If txtJumlah.Text = "" Or txtJumlah.Text = 0 Then
            MsgBox("Jumlah tidak boleh kosong atau 0", vbCritical)
            Return
        End If


        If edit = False Then
            If CDbl(txtJumlah.Text) > CDbl(frmInputPembayaranBPT.txtSisaBayar.Text) Then
                MsgBox("Jumlah melebihi sisa bayar", vbCritical)
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO PembayaranNoTicket "
            Dim namaKolom1 As String() = {"NoTicket", "TanggalBayar", "JumlahBayar"}
            Dim isiKolom1 As Object() = {frmInputPembayaranBPT.txtNoTicket.Text, dtpTanggal.Value.Date, CDbl(txtJumlah.Text)}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)

            frmInputPembayaranBPT.txtDibayar.Text = FormatNumber(CDbl(frmInputPembayaranBPT.txtDibayar.Text) + CDbl(txtJumlah.Text))
            frmInputPembayaranBPT.txtSisaBayar.Text = FormatNumber(CDbl(frmInputPembayaranBPT.txtSisaBayar.Text) - CDbl(txtJumlah.Text))

            If CDbl(frmInputPembayaranBPT.txtSisaBayar.Text) = 0 Then
                keterangan = "Lunas"
            End If

            Dim myQuery7 As String = "UPDATE Pembelian Set "
            Dim myQuery8 As String = "UPDATE Pembelian2 Set "
            Dim namaKolom7 As String() = {"BukaPembayaran"}
            Dim isiKolom7 As Object() = {"Y"}

            Dim kondisiWhere As String = " where NoTicket =@NoTicket"
            Dim namaKolom8 As String() = {"NoTicket"}
            Dim isiKolom8 As Object() = {frmInputPembayaranBPT.txtNoTicket.Text}
            clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere, namaKolom8, isiKolom8, 1)
            clsKoneksi.updateCommand(1, myQuery8, namaKolom7, isiKolom7, kondisiWhere, namaKolom8, isiKolom8, 1)

            Dim myQuery5 As String = "UPDATE PembayaranDetail Set "
            Dim namaKolom5 As String() = {"Dibayar", "SisaBayar", "keterangan"}
            Dim isiKolom5 As Object() = {CDbl(frmInputPembayaranBPT.txtDibayar.Text), CDbl(frmInputPembayaranBPT.txtSisaBayar.Text), keterangan}

            Dim kondisiWhere2 As String = " where NoTicket =@NoTicket"
            Dim namaKolom6 As String() = {"NoTicket"}
            Dim isiKolom6 As Object() = {frmInputPembayaranBPT.txtNoTicket.Text}
            clsKoneksi.updateCommand(1, myQuery5, namaKolom5, isiKolom5, kondisiWhere2, namaKolom6, isiKolom6, 1)


            tampilDetailPembayaran()
            tampilSisaBayar()
            MsgBox("Data Berhasil Disimpan")
            frmInputPembayaranBPT.tampilData()
            bersih()

        Else
            Dim sisaBayarSekarang As Double = 0
            Dim dibayarSekarang As Double = 0
            Dim selisihJumlah As Double = 0
            Dim selisihValidasi As Double = 0
            If sisaBayar = 0 Then

                If CDbl(txtJumlah.Text) > jumlahLama Then
                    MsgBox("Tidak boleh melebihi sisa bayar")
                    Return
                End If


                sisaBayarSekarang = jumlahLama - CDbl(txtJumlah.Text)
                dibayarSekarang = dibayar - sisaBayarSekarang


            Else

                If CDbl(txtJumlah.Text) >= jumlahLama Then
                    selisihJumlah = CDbl(txtJumlah.Text) - jumlahLama

                    'selisihValidasi = selisihJumlah + dibayar
                    If selisihJumlah > sisaBayar Then
                        MsgBox("Tidak boleh melebihi sisa bayar", vbCritical)
                        Return
                    End If

                    dibayarSekarang = dibayar + selisihJumlah
                    sisaBayarSekarang = sisaBayar - selisihJumlah
                Else
                    selisihJumlah = jumlahLama - CDbl(txtJumlah.Text)
                    dibayarSekarang = dibayar - selisihJumlah
                    sisaBayarSekarang = sisaBayar + selisihJumlah
                End If


            End If

            Dim myQuery As String = "UPDATE PembayaranNoTicket Set "
            Dim namaKolom As String() = {"TanggalBayar", "JumlahBayar"}
            Dim isiKolom As Object() = {dtpTanggal.Value.Date, CDbl(txtJumlah.Text)}

            Dim kondisiWhere As String = " where IDPembayaranBPT =@IDPembayaranBPT"
            Dim namaKolom1 As String() = {"IDPembayaranBPT"}
            Dim isiKolom1 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom1, isiKolom1, 1)

            frmInputPembayaranBPT.txtDibayar.Text = FormatNumber(dibayarSekarang)
            frmInputPembayaranBPT.txtSisaBayar.Text = FormatNumber(sisaBayarSekarang)


            If sisaBayarSekarang = 0 Then
                keterangan = "Lunas"
            End If

            Dim myQuery5 As String = "UPDATE PembayaranDetail Set "
            Dim namaKolom5 As String() = {"Dibayar", "SisaBayar", "keterangan"}
            Dim isiKolom5 As Object() = {dibayarSekarang, sisaBayarSekarang, keterangan}

            Dim kondisiWhere2 As String = " where NoTicket =@NoTicket"
            Dim namaKolom6 As String() = {"NoTicket"}
            Dim isiKolom6 As Object() = {noTicket}
            clsKoneksi.updateCommand(1, myQuery5, namaKolom5, isiKolom5, kondisiWhere2, namaKolom6, isiKolom6, 1)

            tampilDetailPembayaran()
            tampilSisaBayar()
            MsgBox("Data Berhasil Disimpan")
            frmInputPembayaranBPT.tampilData()
            bersih()
            Me.Close()

        End If

    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        clsKoneksi.OnlyNumber(e, txtJumlah)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class