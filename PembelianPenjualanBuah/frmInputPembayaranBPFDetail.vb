Imports System.Data.OleDb
Public Class frmInputPembayaranBPFDetail
    Public kodePembayaran As String
    Public edit As Boolean = False
    Public idEdit As Double
    Public kodePembauayaranDetail As String = ""
    Public totalAwal As Double = 0

    Sub hitungTotal()
        Dim tTotal As Double = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            tTotal += dgvData.Rows(i).Cells(8).Value
        Next
        txtTotal.Text = FormatNumber(tTotal, 2)
        txtJumlah.Text = tTotal
    End Sub

    Sub bersih()
        dgvData.Rows.Clear()
        txtTotal.Text = 0
        txtJumlah.Text = 0
        idEdit = 0
        kodePembauayaranDetail = ""
        totalAwal = 0
    End Sub


    Private Sub frmInputPembayaranBPFDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub
    Private Sub frmInputPembayaranBPFDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
    End Sub

    Private Sub dgvData_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvData.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan.Show(dgvData, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmInputPembayaranBPFDetailCari.noTicket = "''"

        If dgvData.Rows.Count > 0 Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If i = 0 Then
                    frmInputPembayaranBPFDetailCari.noTicket = "'" & dgvData.Rows(i).Cells(1).Value & "'"
                Else
                    frmInputPembayaranBPFDetailCari.noTicket = frmInputPembayaranBPFDetailCari.noTicket & ",'" & dgvData.Rows(i).Cells(1).Value & "'"
                End If
            Next
        End If

        frmInputPembayaranBPFDetailCari.buktiPembayaranCari = kodePembayaran
        frmInputPembayaranBPFDetailCari.ShowDialog()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If dgvData.Rows.Count > 0 Then
            If dgvData.SelectedRows.Item(0).Index >= 0 Then
                dgvData.Rows.Remove(dgvData.SelectedRows.Item(0))
                hitungTotal()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim noTicket As String = ""
        Dim sisaBayar As Double = 0
        Dim maxID As Double = 0
        Dim kodeBPF As String = ""

        If dgvData.Rows.Count < 1 Then
            MsgBox("harap pilih data terlebih dahulu", vbCritical)
            Return
        End If

        If txtJumlah.Text = "" Or txtJumlah.Text = "0" Then
            MsgBox("Jumlah Tidak Boleh Kosong atau 0", vbCritical)
            Return
        End If

        If CDbl(txtJumlah.Text) <> CDbl(txtTotal.Text) Then
            MsgBox("Jumlah Tidak Sama Dengan Total")
            Return
        End If

        If dgvData.Rows.Count > 0 Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If i = 0 Then
                    noTicket = "'" & dgvData.Rows(i).Cells(1).Value & "'"
                Else
                    noTicket = noTicket & ",'" & dgvData.Rows(i).Cells(1).Value & "'"
                End If
            Next
        End If

        If edit = False Then

            If CDbl(txtJumlah.Text) < CDbl(txtTotal.Text) Then
                sisaBayar = CDbl(txtTotal.Text) - CDbl(txtJumlah.Text)
            End If

            'cek max id
            Dim myQuery As String = "select iif(IsNull(count(IDPembayaranBPF)),0,count(IDPembayaranBPF)) from PembayaranBPF where KodePembayaran='" & kodePembayaran & "'"
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
                maxID = isiView(0) + 1
            Next

            kodeBPF = kodePembayaran & maxID

            Dim myQuery1 As String = "INSERT INTO PembayaranBPF "
            Dim namaKolom As String() = {"KodePembayaranBPF", "KodePembayaran", "NoTicket", "Jumlah", "Dibayar", "Sisa"}
            Dim isiKolom As Object() = {kodeBPF, kodePembayaran, noTicket, CDbl(txtTotal.Text), CDbl(txtJumlah.Text), CDbl(sisaBayar)}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom, isiKolom)

            Dim myQuery2 As String = "INSERT INTO PembayaranBPFDetail "
            Dim namaKolom1 As String() = {"KodePembayaranBPF", "KodePembayaran", "Tanggal", "Jumlah"}
            Dim isiKolom1 As Object() = {kodeBPF, kodePembayaran, dtpTanggal.Value.Date, CDbl(txtJumlah.Text)}
            clsKoneksi.insertCommand(1, myQuery2, namaKolom1, isiKolom1)

            Dim myQuery4 As String = "Update PembayaranFee SET Dibayar=Dibayar+" & CDbl(txtJumlah.Text) & ",Sisa=Total-(Dibayar+" & CDbl(txtJumlah.Text) & ") where KodePembayaran='" & kodePembayaran & "'"
            Dim cmd As New OleDbCommand(myQuery4, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            Dim myQuery5 As String = "Update PembayaranFeeDetail SET Keterangan='Dalam Pembayaran',StatusBayar='DP' where NoTicket in(" & noTicket & ")"
            Dim cmd1 As New OleDbCommand(myQuery5, clsKoneksi.getConnection(1))
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()

            If CDbl(txtJumlah.Text) = CDbl(txtTotal.Text) Then
                Dim myQuery6 As String = "Update PembayaranFeeDetail SET Keterangan='Lunas',StatusBayar='Y' where NoTicket in(" & noTicket & ")"
                Dim cmd2 As New OleDbCommand(myQuery6, clsKoneksi.getConnection(1))
                cmd2.Connection.Open()
                cmd2.ExecuteNonQuery()
                cmd2.Connection.Close()
            End If
            frmPembayaranBPF.hitungBayarSisa()
            frmPembayaranBPFDetail.tampilData()
            frmPembayaranBPF.tampilData()

            If frmPembayaranFee.txtNoPembayaran.Text <> "" Then
                frmPembayaranFee.loadDetail()
            End If

            bersih()
            MsgBox("Berhasil disimpan")
            Me.Close()

        Else

            Dim sisaPengurangan As Double = 0
            Dim dibayar As Double = 0
            Dim sisa As Double = 0
            Dim dibayarSekarang As Double = 0
            Dim sisaSekarang As Double = 0
            Dim myQuery As String = ""

            'cek totalDibayar
            myQuery = "select iif(IsNull(Dibayar),0,Dibayar),iif(IsNull(Sisa),0,Sisa) from PembayaranFee where KodePembayaran='" & kodePembayaran & "'"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
            Dim isiView(1) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView.Length - 1
                    If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView(j) = ""
                    Else
                        isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dibayar = isiView(0)
                sisa = isiView(1)
            Next

            'cek No Ticket
            Dim noTicketAwal As String = ""
            myQuery = "select NoTicket FROM PembayaranBPF where KodePembayaranBPF='" & kodePembauayaranDetail & "'"
            Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, myQuery)
            Dim isiView1(0) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView1.Length - 1
                    If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView1(j) = ""
                    Else
                        isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                    End If
                Next
                noTicketAwal = isiView1(0)
            Next

            If CDbl(txtJumlah.Text) > totalAwal Then
                sisaPengurangan = CDbl(txtJumlah.Text) - CDbl(totalAwal)
                dibayarSekarang = CDbl(dibayar) + CDbl(sisaPengurangan)
                sisaSekarang = CDbl(sisa) - CDbl(sisaPengurangan)
            Else
                sisaPengurangan = CDbl(totalAwal) - CDbl(txtJumlah.Text)
                dibayarSekarang = CDbl(dibayar) - CDbl(sisaPengurangan)
                sisaSekarang = CDbl(sisa) + CDbl(sisaPengurangan)
            End If

            myQuery = "Update PembayaranFeeDetail SET Keterangan='',StatusBayar='' where KodePembayaran='" & kodePembayaran & "' and NoTicket in(" & noTicketAwal & ")"
            Dim cmd2 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

            myQuery = "Update PembayaranBPF SET "
            Dim namaKolom1 As String() = {"NoTicket", "Jumlah", "Dibayar"}
            Dim isiKolom1 As Object() = {noTicket, CDbl(txtJumlah.Text), CDbl(txtJumlah.Text)}
            Dim kondisiWhere1 As String = " where KodePembayaranBPF=@KodePembayaranBPF"
            Dim namaKolom3 As String() = {"KodePembayaranBPF"}
            Dim isiKolom3 As Object() = {kodePembauayaranDetail}
            clsKoneksi.updateCommand(1, myQuery, namaKolom1, isiKolom1, kondisiWhere1, namaKolom3, isiKolom3, 1)

            myQuery = "Update PembayaranBPFDetail SET "
            Dim namaKolom As String() = {"Tanggal", "Jumlah"}
            Dim isiKolom As Object() = {dtpTanggal.Value.Date, CDbl(txtJumlah.Text)}
            Dim kondisiWhere As String = " where IDPembayaranBPFDetail=@IDPembayaranBPFDetail"
            Dim namaKolom2 As String() = {"IDPembayaranBPFDetail"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)

            myQuery = "Update PembayaranFee SET Dibayar=" & CDbl(dibayarSekarang) & ",Sisa=" & CDbl(sisaSekarang) & " where KodePembayaran='" & kodePembayaran & "'"
            Dim cmd1 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()

            myQuery = "Update PembayaranFeeDetail SET Keterangan='Lunas',StatusBayar='Y' where NoTicket in(" & noTicket & ")"
            Dim cmd3 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            frmPembayaranBPF.hitungBayarSisa()
            frmPembayaranBPFDetail.tampilData()
            frmPembayaranBPF.tampilData()

            If frmPembayaranFee.txtNoPembayaran.Text <> "" Then
                frmPembayaranFee.loadDetail()
            End If

            bersih()
            MsgBox("Berhasil Diubah")
            Me.Close()

        End If

    End Sub
End Class