Public Class frmUpdateHargaPlatData
    Public dtHelp As Object
    Sub loadData()
        Dim tDs1 As DataSet
        Dim myQuery1 As String = "select harga.kodeKelompok,harga.Plat,harga.harga,harga.perubahan from harga  where harga.plat Is Not Null and harga.kodeKelompok in(" & txtKodeKelompok.Text & ") and datevalue(Harga.tgl)=#" & Format(dtpTanggal.Value.Date, "MM/dd/yyyy") & "# and timevalue(harga.jam) =#" & dtpJam.Value.ToString("HH:mm:ss") & "#"
        DgvData.Rows.Clear()
        tDs1 = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(3) As Object
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            DgvData.Rows.Add(isiView1)
        Next
    End Sub


    Private Sub frmUpdateHargaPlatData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub ckPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilihSemua.CheckedChanged
        If ckPilihSemua.Checked = True Then
            For i As Integer = 0 To DgvData.Rows.Count() - 1
                DgvData.Rows(i).Cells(4).Value = True
            Next
        Else
            For i As Integer = 0 To DgvData.Rows.Count() - 1
                DgvData.Rows(i).Cells(4).Value = False
            Next
        End If
    End Sub

    Private Sub mnuEditHarga_Click(sender As Object, e As EventArgs) Handles mnuEditHarga.Click
        Dim kodeKelompok As String = String.Empty
        Dim kodeKelompok2 As String = String.Empty
        Dim nomorPlat As String = String.Empty
        Dim nomorPlat2 As String = String.Empty

        For Each row As DataGridViewRow In DgvData.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb").Value)
            If isSelected = True Then
                kodeKelompok &= row.Cells("kodeKelompok").Value.ToString() & ","
                nomorPlat &= row.Cells("nomorPlat").Value.ToString() & ","

                kodeKelompok2 = kodeKelompok2 & "'" & row.Cells("kodeKelompok").Value.ToString() & "',"
                nomorPlat2 = nomorPlat2 & "'" & row.Cells("nomorPlat").Value.ToString() & "',"
            End If
        Next

        If kodeKelompok = "" Or nomorPlat = "" Then
            MsgBox("Pilih Data", vbCritical)
            Return
        End If

        kodeKelompok = kodeKelompok.Remove(kodeKelompok.Length - 1, 1)
        kodeKelompok2 = kodeKelompok2.Remove(kodeKelompok2.Length - 1, 1)
        nomorPlat = nomorPlat.Remove(nomorPlat.Length - 1, 1)
        nomorPlat2 = nomorPlat2.Remove(nomorPlat2.Length - 1, 1)

        frmUpdateHargaEdit.lblTgl.Text = dtpTanggal.Value
        frmUpdateHargaEdit.dtHelp.Value = dtpTanggal.Value
        frmUpdateHargaEdit.lblJam.Text = dtHelp
        frmUpdateHargaEdit.dtHelp2 = dtHelp
        frmUpdateHargaEdit.txtHarga.Text = "0"
        frmUpdateHargaEdit.txtKelompok.Text = kodeKelompok
        frmUpdateHargaEdit.txtKelompok2.Text = kodeKelompok2
        frmUpdateHargaEdit.lblPlat.Text = nomorPlat2
        frmUpdateHargaEdit.ShowDialog(Me)
    End Sub

    Private Sub DgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvData.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.DgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.DgvData.CurrentCell = Me.DgvData.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikKanan.Show(Me.DgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik data", vbExclamation)
        End Try
    End Sub

End Class