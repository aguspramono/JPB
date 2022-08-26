Imports System.Data.OleDb
Public Class frmPembayaranBPTDetail

    Sub tampilData()
        Dim myQuery As String = "select * FROM PembayaranBPT where KodePembayaran='" & txtNoBukti.Text & "' and KodeParam=" & txtKodeParam.Text & ""
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        'Console.WriteLine(myQuery)
        dgvData.Rows.Clear()
        Dim isiView(8) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvData.Rows.Add(isiView)
        Next
    End Sub

    Sub hitungBayarSisa()
        Dim myQuery As String = "select Dibayar,Sisa FROM Pembayaran where KodePembayaran='" & txtNoBukti.Text & "' and KodeParam=" & txtKodeParam.Text & ""
        myQuery = myQuery
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
            txtDibayar.Text = FormatNumber(CDbl(isiView(0)))
            txtSisa.Text = FormatNumber(CDbl(isiView(1)))
            frmPembayaranBPTBertahap.txtDibayar.Text = FormatNumber(CDbl(isiView(0)))
            frmPembayaranBPTBertahap.txtSisa.Text = FormatNumber(CDbl(isiView(1)))

            If frmPembayaran.txtNoPembayaran.Text <> "" Then
                If txtNoBukti.Text = frmPembayaran.txtNoPembayaran.Text Then
                    frmPembayaran.txtDibayar.Text = FormatNumber(CDbl(isiView(0)))
                    frmPembayaran.txtSisa.Text = FormatNumber(CDbl(isiView(1)))
                End If
            End If
        Next
    End Sub
    Private Sub btnTambahPembayaran_Click(sender As Object, e As EventArgs) Handles btnTambahPembayaran.Click
        frmInputPembayaranBPTDetail.noPembayaran = txtNoBukti.Text
        frmInputPembayaranBPTDetail.kodeParam = txtKodeParam.Text
        frmInputPembayaranBPTDetail.ShowDialog()
    End Sub

    Private Sub frmPembayaranBPTDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then
            Dim query As String = ""

            'cek No Ticket
            Dim noTicket As String = ""
            Dim myQuery As String = "select NoTicket FROM PembayaranBPT where KodePembayaranBPT='" & dgvData.SelectedCells(1).Value & "' and KodeParam=" & dgvData.SelectedCells(8).Value & ""
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
                noTicket = isiView(0)
            Next

            query = "Update PembayaranDetail SET Keterangan='',StatusBayar='' where NoTicket in(" & noTicket & ")"
            Dim cmd As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            query = "Update Pembayaran SET Dibayar=Dibayar-" & CDbl(dgvData.SelectedCells(6).Value) & ",Sisa=Sisa+" & CDbl(dgvData.SelectedCells(6).Value) & " where KodePembayaran='" & dgvData.SelectedCells(2).Value & "' and KodeParam=" & dgvData.SelectedCells(8).Value & ""
            Dim cmd1 As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()

            query = "delete from PembayaranBPTDetail where KodePembayaranBPT='" & dgvData.SelectedCells(1).Value & "' and KodeParam=" & dgvData.SelectedCells(8).Value & ""
            Dim cmd3 As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            query = "delete from PembayaranBPT where IDPembayaranBPT=" & dgvData.SelectedCells(0).Value & ""
            Dim cmd2 As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

            hitungBayarSisa()
            frmPembayaranBPT.tampilData()
            If frmPembayaran.txtNoPembayaran.Text <> "" Then
                frmPembayaran.loadDetail()
            End If

            tampilData()
            MsgBox("Data Berhasil Dihapus")

        End If
    End Sub

    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(4)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        frmPembayaranBPTDetailEdit.noBPT = dgvData.SelectedCells(1).Value
        frmPembayaranBPTDetailEdit.noTBS = txtNoBukti.Text
        frmPembayaranBPTDetailEdit.noTicket = dgvData.SelectedCells(3).Value
        frmPembayaranBPTDetailEdit.txtTotal.Text = FormatNumber(CDbl(dgvData.SelectedCells(5).Value))
        frmPembayaranBPTDetailEdit.totalLama = CDbl(dgvData.SelectedCells(5).Value)
        frmPembayaranBPTDetailEdit.txtDibayar.Text = FormatNumber(CDbl(dgvData.SelectedCells(6).Value))
        frmPembayaranBPTDetailEdit.dibayarSekarang = CDbl(dgvData.SelectedCells(6).Value)
        frmPembayaranBPTDetailEdit.txtSisa.Text = FormatNumber(CDbl(dgvData.SelectedCells(7).Value))
        frmPembayaranBPTDetailEdit.sisaSekarang = CDbl(dgvData.SelectedCells(7).Value)
        frmPembayaranBPTDetailEdit.KodeParam = txtKodeParam.Text
        frmPembayaranBPTDetailEdit.ShowDialog()
    End Sub

    Private Sub btnPertahap_Click(sender As Object, e As EventArgs) Handles btnPertahap.Click
        frmPembayaranBPTBertahap.noPembayaran = txtNoBukti.Text
        frmPembayaranBPTBertahap.noAcc = txtNoAcc.Text
        frmPembayaranBPTBertahap.txtDibayar.Text = FormatNumber(txtDibayar.Text)
        frmPembayaranBPTBertahap.txtSisa.Text = FormatNumber(txtSisa.Text)
        frmPembayaranBPTBertahap.ShowDialog()
    End Sub
End Class