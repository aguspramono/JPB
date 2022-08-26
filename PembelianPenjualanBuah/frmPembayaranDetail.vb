Public Class frmPembayaranDetail
    Public noAccount As String
    Public kodePembayaran As String
    Public noTicketShow As String

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadCari()
    End Sub

    Sub loadCari()

        Dim jumlahditanggung As Double = 0
        Dim angkabagi As Double = 0
        Dim angkakalimarsada As Double = 0
        Dim angkabagimarsada As Double = 0


        If cmbJenisHarga.SelectedIndex = 1 Then
            Dim myQuery2 As String = "Select g.* from customer as c left join grossup as g on(g.tipeGrossup=c.GrossUp) where c.NoAccount='" & noAccount & "'"
            Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQuery2)
            If tDs2.Tables(0).Rows.Count > 0 Then
                jumlahditanggung = IIf(IsDBNull(tDs2.Tables(0).Rows(0).Item("jenisDitanggung")), 0, tDs2.Tables(0).Rows(0).Item("jenisDitanggung"))
                angkabagi = IIf(IsDBNull(tDs2.Tables(0).Rows(0).Item("angkaBagi")), 1, tDs2.Tables(0).Rows(0).Item("angkaBagi"))
            End If

            Dim myQuery3 As String = "select pm.* from PengecualianMarsada as pm where NoAccount='" & noAccount & "'"
            Dim tDs3 As DataSet = clsKoneksi.selectCommand(1, myQuery3)
            If tDs3.Tables(0).Rows.Count > 0 Then
                angkakalimarsada = IIf(IsDBNull(tDs3.Tables(0).Rows(0).Item("nilaiKali")), 1, tDs3.Tables(0).Rows(0).Item("nilaiKali"))
                angkabagimarsada = IIf(IsDBNull(tDs3.Tables(0).Rows(0).Item("nilaiBagi")), 1, tDs3.Tables(0).Rows(0).Item("nilaiBagi"))
            End If

        End If

        Dim myQuery As String = "select distinct p.NoTicket,p.Tgl2,p.KodeProduct,p.Product,p.Netto,p.HargaAkhir-p.potongan-iif(IsNull(pb.harga),0,pb.harga)+(iif(IsNull(pc.harga),0,pc.harga))-(iif(IsNull(pp.PotonganHarga),0,iif(pp.KodeKelompok=c.kodeKelompok and p.PotonganPlat='1',pp.PotonganHarga,0))) as harga " & _
                                "From (((Pembelian2 as p inner join customer as c on c.NoAccount=p.NoAccount ) left join Pengecualianbb as pb on pb.NoAccount=p.NoAccount) left join Pengecualian as pc on pc.KodeKelompok=c.KodeKelompok) left join PotonganPlat as pp on pp.Plat=p.Vehicle" & _
                                " where " & _
                                "p.NoTicket not in (Select pd.NoTicket from PembayaranDetail pd where pd.KodePembayaran<>'" & kodePembayaran & "' and pd.KodeKota='" & clsKoneksi.kotaOn & "')  " & _
                                "and p.NoAccount='" & noAccount & "' " & _
                                "and p.Tgl2>=#" & Format(dtAwal.Value, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtAkhir.Value, "MM/dd/yyyy") & "# " & _
                                "and p.KodeKota='" & clsKoneksi.kotaOn & "' " & _
                                "and p.PrintNo>0 " & _
                                "and p.NoTicket not in (" & noTicketShow & ") " & _
                                "order by p.NoTicket "
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgView.Rows.Clear()
        Dim isiView(6) As Object

        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            isiView(0) = False
            For j As Integer = 1 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j - 1) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j - 1)
                End If
            Next

            If cmbJenisHarga.SelectedIndex = 1 And angkabagi > 1 Then

                isiView(6) = isiView(6) * 100 / angkabagi

            End If

            If cmbJenisHarga.SelectedIndex = 1 And angkabagimarsada > 1 Then

                isiView(6) = isiView(6) * angkakalimarsada / angkabagimarsada

            End If

            dgView.Rows.Add(isiView)
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        For i As Integer = 0 To dgView.Rows.Count - 1
            If dgView.Rows(i).Cells(0).Value = True Then
                'check
                'noticket
                'tgl                      
                'kdproduct
                'product
                'nettp
                'harga
                Dim isiView(11) As Object
                isiView(0) = ""
                isiView(1) = dgView.Rows(i).Cells(1).Value
                isiView(2) = dgView.Rows(i).Cells(2).Value
                isiView(3) = dgView.Rows(i).Cells(3).Value
                isiView(4) = dgView.Rows(i).Cells(4).Value
                isiView(5) = dgView.Rows(i).Cells(5).Value
                isiView(6) = dgView.Rows(i).Cells(6).Value
                isiView(7) = isiView(5) * isiView(6)
                isiView(8) = clsKoneksi.kotaOn
                isiView(9) = ""
                isiView(10) = ""
                frmPembayaran.dgView.Rows.Add(isiView)
            End If
        Next
        frmPembayaran.loadHitungTotal()
        Me.Close()
    End Sub

    Private Sub dgView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellContentClick
        If e.ColumnIndex = 0 Then
            If dgView.Rows.Count > 0 Then
                dgView.Rows(e.RowIndex).Cells(0).Value = Not dgView.Rows(e.RowIndex).Cells(0).Value
            End If
        End If
    End Sub

    Private Sub dgView_KeyUp(sender As Object, e As KeyEventArgs) Handles dgView.KeyUp
        If e.KeyCode = Keys.Space Then
            If dgView.Rows.Count > 0 Then
                dgView.SelectedRows(0).Cells(0).Value = Not dgView.SelectedRows(0).Cells(0).Value
            End If
        End If
    End Sub
    Private Sub frmPembayaranDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgView.Rows.Clear()
        chkPilihSemua.Checked = False
        dtAwal.Value = clsKoneksi.tglAwalBulan(Now)
        dtAkhir.Value = clsKoneksi.tglAkhirBulan(Now)
        cmbJenisHarga.SelectedIndex = 0
    End Sub

    Private Sub chkPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles chkPilihSemua.CheckedChanged
        For i As Integer = 0 To dgView.Rows.Count - 1
            dgView.Rows(i).Cells(0).Value = chkPilihSemua.Checked
        Next
    End Sub
End Class