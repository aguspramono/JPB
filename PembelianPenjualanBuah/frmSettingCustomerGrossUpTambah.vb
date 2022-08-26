Imports System.Data.OleDb
Public Class frmSettingCustomerGrossUpTambah

    Private Sub frmSettingCustomerGrossUpTambah_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dgvView.Rows.Clear()
    End Sub

    Private Sub frmSettingCustomerGrossUpTambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPilih.SelectedIndex = 0
    End Sub

    Private Sub dgvView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan.Show(dgvView, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmSettingCustomerGrossUpCariCustomer.ShowDialog()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        For Each row As DataGridViewRow In dgvView.SelectedRows
            dgvView.Rows.Remove(row)
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim query As String = ""
        Dim cmd As New OleDbCommand
        Dim tipeGrossup As Double = 0

        If dgvView.Rows.Count < 1 Then
            MsgBox("Belum ada customer dipilih")
            Return
        End If

        If MsgBox("Yakin semua data sudah benar?", vbQuestion + vbYesNo) = vbYes Then
            Dim noAccount As String = ""
            For i As Integer = 0 To dgvView.Rows.Count - 1
                noAccount = noAccount & "'" & dgvView.Rows(i).Cells(0).Value & "',"
            Next
            noAccount = noAccount.TrimEnd(CChar(","))

            Dim intT As Integer = cmbPilih.SelectedIndex
            Select Case intT
                Case 0
                    tipeGrossup = 1
                Case 1
                    tipeGrossup = 2
                Case 2
                    tipeGrossup = 3
                Case 3
                    tipeGrossup = 4
            End Select


            query = "UPDATE Customer SET GrossUp=" & tipeGrossup & " WHERE NoAccount in(" & noAccount & ")"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Close()
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()

            MsgBox("Berhasil Disimpan")
            frmSettingCustomerGrossUp.tampil()
            dgvView.Rows.Clear()
            Me.Close()

        End If


    End Sub
End Class