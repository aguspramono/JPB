Imports System.Data.OleDb
Public Class frmSettingCustomerGrossUpEdit

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If MsgBox("Yakin ingin mengubah data ini?", vbQuestion + vbYesNo) = vbYes Then

            Dim query As String = ""
            Dim cmd As New OleDbCommand
            Dim tipeGrossup As Double = 0

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

            query = "UPDATE Customer SET GrossUp=" & tipeGrossup & " WHERE NoAccount='" & txtNoAcc.Text & "'"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Close()
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()

            MsgBox("Berhasil Diubah")
            frmSettingCustomerGrossUp.tampil()
            Me.Close()

        End If
    End Sub
End Class