Imports System.Data.OleDb
Public Class frmPembayaranBPFDetail

    Sub tampilData()
        Dim myQuery As String = "select * FROM PembayaranBPFDetail where KodePembayaran='" & txtPembayaranFee.Text & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(4) As Object
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


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmInputPembayaranBPFDetail.kodePembayaran = txtPembayaranFee.Text
        frmInputPembayaranBPFDetail.ShowDialog()
    End Sub

    Private Sub frmPembayaranBPFDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus pembayaran ini?", vbQuestion + vbYesNo) = vbYes Then
            Dim query As String = ""

            'cek No Ticket
            Dim noTicket As String = ""
            Dim myQuery As String = "select NoTicket FROM PembayaranBPF where KodePembayaranBPF='" & dgvData.SelectedCells(1).Value & "'"
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

            query = "Update PembayaranFeeDetail SET Keterangan='',StatusBayar='' where NoTicket in(" & noTicket & ")"
            Dim cmd As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            query = "Update PembayaranFee SET Dibayar=Dibayar-" & CDbl(dgvData.SelectedCells(4).Value) & ",Sisa=Sisa+" & CDbl(dgvData.SelectedCells(4).Value) & " where KodePembayaran='" & dgvData.SelectedCells(2).Value & "'"
            Dim cmd1 As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()

            query = "delete from PembayaranBPF where KodePembayaranBPF='" & dgvData.SelectedCells(1).Value & "'"
            Dim cmd2 As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

            query = "delete from PembayaranBPFDetail where IDPembayaranBPFDetail=" & dgvData.SelectedCells(0).Value & ""
            Dim cmd3 As New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            frmPembayaranBPF.hitungBayarSisa()
            frmPembayaranBPF.tampilData()
            If frmPembayaranFee.txtNoPembayaran.Text <> "" Then
                frmPembayaranFee.loadDetail()
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
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(3)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        frmInputPembayaranBPFDetail.edit = True

        Dim myQuery As String = ""
        Dim tDs As DataSet
        Dim noTicket As String = ""
        Dim total As Double = 0

        'cek No Ticket
        myQuery = "select NoTicket FROM PembayaranBPF where KodePembayaranBPF='" & dgvData.SelectedCells(1).Value & "'"
        tDs = clsKoneksi.selectCommand(1, myQuery)
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


        Dim cari As String = " where NoTicket in(" & noTicket & ") "
        myQuery = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,KodeFee,Fee,Total,KodeKota FROM PembayaranFeeDetail " & cari & ""
        tDs = clsKoneksi.selectCommand(1, myQuery)
        frmInputPembayaranBPFDetail.dgvData.Rows.Clear()
        Dim isiView1(9) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next

            frmInputPembayaranBPFDetail.dgvData.Rows.Add(isiView1)
            total += isiView1(8)
        Next


        frmInputPembayaranBPFDetail.txtTotal.Text = FormatNumber(CDbl(total))
        frmInputPembayaranBPFDetail.txtJumlah.Text = CDbl(total)
        frmInputPembayaranBPFDetail.totalAwal = CDbl(total)
        frmInputPembayaranBPFDetail.kodePembayaran = txtPembayaranFee.Text
        frmInputPembayaranBPFDetail.kodePembauayaranDetail = dgvData.SelectedCells(1).Value
        frmInputPembayaranBPFDetail.idEdit = dgvData.SelectedCells(0).Value
        frmInputPembayaranBPFDetail.ShowDialog()
    End Sub
End Class