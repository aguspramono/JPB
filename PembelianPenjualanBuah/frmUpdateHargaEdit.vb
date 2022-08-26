Imports System.Data.OleDb
Public Class frmUpdateHargaEdit
    Public ts As TimeSpan
    Public jlhData As Integer
    Public dtHelp2 As Object
    Public tRow As Integer

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        Dim tNo As Object() = {45}
        clsKoneksi.textBoxOnlyNumber(e, tNo)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim query As String
        Dim cmd As OleDbCommand
        If txtHarga.Text = "" Or txtHarga.Text = "-" Then
            txtHarga.Text = "0"
        End If
        If jlhData = 1 Then

            Dim kodeKelompok As String = txtKelompok.Text
            Dim kodeKelompokRep As String = kodeKelompok.Replace("'", "")
            Dim wherePlat As String = ""
            If lblPlat.Text = "" Then
                wherePlat = "and Plat is null"
            Else
                wherePlat = "and Plat='" & lblPlat.Text & "'"
            End If


            

            Dim myQueryC As String = "select*from harga where KodeKelompok='" & kodeKelompokRep & "' and Tgl = #" & dtHelp.Value.Date.ToString("MM/dd/yyyy") & "# and Jam = #" & dtHelp2 & "# and KodeKota='" & clsKoneksi.kotaOn & "' " & wherePlat & ""
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC)
            If tDs.Tables(0).Rows.Count > 0 Then

                query = "UPDATE Harga set Harga=Harga+" & CDbl(txtHarga.Text) & ",Perubahan=Perubahan+" & CDbl(txtHarga.Text) & " WHERE KodeKelompok in (" & txtKelompok2.Text & ") and Tgl=#" & dtHelp.Value.Date.ToString("MM/dd/yyyy") & "# and Jam=#" & dtHelp2 & "# and kodeKota='" & clsKoneksi.kotaOn & "' " & wherePlat & ""
                cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
                cmd.Connection.Close()
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()


                frmUpdateHarga.loadUpdateHarga(tRow, CDbl(txtHarga.Text))

            Else
                Dim myQueryC2 As String = "select top 1 harga from harga where kodekota=@KodeKotaA and KodeKelompok=@KodeKelompokA and Plat=@Plat and ((tgl <=@tglA and Jam<=@jamA) or tgl <@tglA) order by tgl desc,jam desc"
                Dim namaKolomC2 As String() = {"KodeKelompokA", "tglA", "jamA", "KodeKotaA", "Plat"}
                Dim isiKolomC2 As Object() = {txtKelompok.Text, dtHelp.Value, dtHelp2, clsKoneksi.kotaOn, lblPlat.Text}
                Dim hargaT As Double = 0
                Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQueryC2, namaKolomC2, isiKolomC2, 1)
                For i2 As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
                    If tDs2.Tables(0).Rows(i2).Item(0) Is DBNull.Value Then
                    Else
                        hargaT = tDs2.Tables(0).Rows(i2).Item(0)
                    End If
                Next
                Dim myQuery As String = "INSERT INTO harga "
                Dim namaKolom As String() = {"KodeKelompok", "Tgl", "Jam", "Harga", "Perubahan", "KodeKota"}
                Dim isiKolom As Object() = {kodeKelompokRep, dtHelp.Value, dtHelp2, hargaT + CDbl(txtHarga.Text), CDbl(txtHarga.Text), clsKoneksi.kotaOn}
                clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)

                frmUpdateHarga.loadUpdateHarga(tRow, hargaT + CDbl(txtHarga.Text))
            End If

            If txtKelompok2.Text = "'hargaPapan'" Then

                query = "UPDATE Harga set Harga=Harga+" & CDbl(txtHarga.Text) & ",Perubahan=Perubahan+" & CDbl(txtHarga.Text) & " WHERE KodeKelompok in (select kodeKelompok from Papan) and Tgl=#" & dtHelp.Value.Date.ToString("MM/dd/yyyy") & "# and Jam=#" & dtHelp2 & "# and kodeKota='" & clsKoneksi.kotaOn & "'"
                cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
                cmd.Connection.Close()
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

                frmUpdateHarga.loadUpdateHarga(tRow, CDbl(txtHarga.Text))

            End If
        Else
            Dim wherePlat As String = ""
            If lblPlat.Text = "" Then
                wherePlat = "and Plat is null"
            Else
                wherePlat = "and Plat in (" & lblPlat.Text & ")"
            End If

            If txtKelompok2.Text = "'hargaPapan'" Then

                query = "UPDATE Harga set Harga=Harga+" & CDbl(txtHarga.Text) & ",Perubahan=Perubahan+" & CDbl(txtHarga.Text) & " WHERE KodeKelompok in (select kodeKelompok from Papan) and Tgl=#" & dtHelp.Value.Date.ToString("MM/dd/yyyy") & "# and Jam=#" & dtHelp2 & "# and kodeKota='" & clsKoneksi.kotaOn & "'"
                cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
                cmd.Connection.Close()
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            End If

            query = "UPDATE Harga set Harga=Harga+" & CDbl(txtHarga.Text) & ",Perubahan=Perubahan+" & CDbl(txtHarga.Text) & " WHERE KodeKelompok in in (" & txtKelompok2.Text & ") and Tgl=#" & dtHelp.Value.Date.ToString("MM/dd/yyyy") & "# and Jam=#" & dtHelp2 & "# and kodeKota='" & clsKoneksi.kotaOn & "' " & wherePlat & ""
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Close()
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()

            frmUpdateHarga.loadUpdateHarga(tRow, CDbl(txtHarga.Text))
            'frmUpdateHarga.loadMain()

        End If

        For i As Integer = 4 To frmUpdateHarga.dgView.ColumnCount - 1
            frmUpdateHarga.dgView.Rows(0).Cells(i).Value = False
        Next
        frmUpdateHarga.dgView.Rows(0).Cells(2).Value = False

        Me.Close()
    End Sub
End Class