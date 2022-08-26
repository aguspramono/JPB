Imports System.Data.OleDb
Public Class frmPembayaranBPTBertahap

    Public noPembayaran As String = ""
    Public noAcc As String = ""

    Sub tampilData()
        Dim nettoBayar As Double = 0
        Dim nettoDibayarSeluruh As Double = 0
        Dim query As String = ""
        query = "select * from pembayaranBertahap where KodePembayaran='" & noPembayaran & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, query)
        Dim isiView(7) As Object
        dgvData.Rows.Clear()
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

        'query = "select iiF(IsNull(sum(netto)),0,sum(netto)) as nettoA from PembayaranDetail where KodePembayaran='" & noPembayaran & "' and statusBayar='Y'"
        'Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, query)
        'Dim isiView1(0) As Object
        ''isiView(0) = ""
        'For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
        '    For j As Integer = 0 To isiView1.Length - 1
        '        If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
        '            isiView1(j) = ""
        '        Else
        '            isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
        '        End If
        '    Next
        '    nettoDibayarSeluruh = isiView1(0)
        'Next

        For i As Integer = 0 To dgvData.RowCount - 1
            nettoBayar += Val(dgvData.Rows(i).Cells(4).Value)
        Next

        txtNetto.Text = FormatNumber(nettoBayar)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmInputPembayaranBTPBertahap.noPembayaran = noPembayaran
        frmInputPembayaranBTPBertahap.noAcc = noAcc
        frmInputPembayaranBTPBertahap.nettoDibayar = txtNetto.Text
        frmInputPembayaranBTPBertahap.txtSisaBayar.Text = FormatNumber(txtSisa.Text)
        frmInputPembayaranBTPBertahap.ShowDialog()
    End Sub

    Private Sub frmPembayaranBPTBertahap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As OleDbCommand
            Dim query As String = ""

            query = "Update Pemba yaran set Dibayar=Dibayar-" & CDbl(dgvData.SelectedCells(5).Value) & ",Sisa=Sisa+" & CDbl(dgvData.SelectedCells(5).Value) & " where KodePembayaran='" & dgvData.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            query = "delete from PembayaranBertahap where KodePembayaranBertahap='" & dgvData.SelectedCells(1).Value & "'"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            query = "select * from PembayaranBertahap where KodePembayaran='" & dgvData.SelectedCells(0).Value & "'"
            Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, query)
            If tDs1.Tables(0).Rows.Count > 0 Then
                query = "Update PembayaranDetail set StatusBayar='B',Keterangan='Bayar Bertahap' where KodePembayaran='" & dgvData.SelectedCells(0).Value & "'"
            Else
                query = "Update PembayaranDetail set StatusBayar='',Keterangan='' where KodePembayaran='" & dgvData.SelectedCells(0).Value & "'"
            End If

            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            tampilData()
            frmPembayaranBPTDetail.hitungBayarSisa()
            frmPembayaran.loadDetail()
            MsgBox("Data berhasil dihapus")

        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim i As Integer = dgvData.CurrentRow.Index
        frmInputPembayaranBTPBertahap.edit = True
        frmInputPembayaranBTPBertahap.lblPembayaranBertahaplama.Text = dgvData.Item(1, i).Value
        frmInputPembayaranBTPBertahap.txtKodePembayaranBertahap.Text = dgvData.Item(1, i).Value
        frmInputPembayaranBTPBertahap.idParam = dgvData.Item(7, i).Value
        frmInputPembayaranBTPBertahap.dtpTanggal.Value = dgvData.Item(3, i).Value
        frmInputPembayaranBTPBertahap.txtNettoDibayar.Text = dgvData.Item(4, i).Value
        frmInputPembayaranBTPBertahap.nettoPertahapDibayar = dgvData.Item(4, i).Value
        frmInputPembayaranBTPBertahap.txtJumlahBayar.Text = dgvData.Item(5, i).Value
        frmInputPembayaranBTPBertahap.jumlahBayar = dgvData.Item(5, i).Value
        frmInputPembayaranBTPBertahap.txtKeterangan.Text = dgvData.Item(6, i).Value
        frmInputPembayaranBTPBertahap.noPembayaran = noPembayaran
        frmInputPembayaranBTPBertahap.nettoDibayar = txtNetto.Text
        frmInputPembayaranBTPBertahap.txtSisaBayar.Text = FormatNumber(txtSisa.Text)
        frmInputPembayaranBTPBertahap.dibayar = txtDibayar.Text
        frmInputPembayaranBTPBertahap.noAcc = noAcc
        frmInputPembayaranBTPBertahap.ShowDialog()
    End Sub
End Class