Public Class frmPembayaranFeeDetail
    Public kodeKelompok As String
    Public kodeFee As String
    Public noTicketFeeShow As String
    Public toogle As Boolean = False

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadCari()
    End Sub

    Sub loadCari()
        Dim cekData As Boolean = True
        Dim kodeFee As String
        Dim myQuery As String = ""
        If txtFee.Text = "" Then
            kodeFee = ""
        Else
            kodeFee = " and F.KodeFee in(" & txtKodeFee.Text & ") "
        End If

        If clsKoneksi.kotaOn = "2" Then
            myQuery = "SELECT  P2.NoTicket, P2.Tgl2, P2.KodeProduct, P2.Product, P2.Netto, F.KodeFee, F.Fee, F.Fee*P2.Netto as Total From" & _
                "((pembelian2 AS P2 INNER JOIN Customer AS C ON P2.NoAccount = C.NoAccount) INNER JOIN Fee as F ON C.KodeKelompok = F.KodeKelompok)  where " & _
                "C.KodeKelompok='" & kodeKelompok & "' " & kodeFee & " and P2.NoTicket Not in(select NoTicket from PembayaranFeeDetail Where NoTicket=P2.NoTicket and KodeFee=F.KodeFee) " & _
                "and P2.Tgl2>=#" & Format(dtAwal.Value.Date, "MM/dd/yyyy") & "# and P2.Tgl2<=#" & Format(dtAkhir.Value.Date, "MM/dd/yyyy") & "# " & _
                "and P2.KodeKota='" & clsKoneksi.kotaOn & "' " & _
                "and (P2.PrintNoFee>0 or P2.NoAccount in(select noAccount from pengecualianbb)) " & _
                "order by F.KodeFee "
        Else
            myQuery = "SELECT  P2.NoTicket, P2.Tgl2, P2.KodeProduct, P2.Product, P2.Netto, '' as KodeFee, C.Fee, C.Fee*P2.Netto as Total From" & _
                    "(pembelian2 AS P2 INNER JOIN Customer AS C ON P2.NoAccount = C.NoAccount) where " & _
                    "C.KodeKelompok='" & kodeKelompok & "' and P2.NoTicket Not in(select NoTicket from PembayaranFeeDetail Where NoTicket=P2.NoTicket) " & _
                    "and P2.Tgl2>=#" & Format(dtAwal.Value.Date, "MM/dd/yyyy") & "# and P2.Tgl2<=#" & Format(dtAkhir.Value.Date, "MM/dd/yyyy") & "# " & _
                     "and P2.KodeKota='" & clsKoneksi.kotaOn & "' " & _
                     "and (P2.PrintNoFee>0 or P2.NoAccount in(select noAccount from pengecualianbb)) "
        End If
        

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgView.Rows.Clear()
        Dim isiView(8) As Object

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

            For k As Integer = 0 To frmPembayaranFee.dgView.Rows.Count - 1
                If frmPembayaranFee.dgView.Rows(k).Cells(1).Value = isiView(1) And frmPembayaranFee.dgView.Rows(k).Cells(6).Value = isiView(6) Then
                    cekData = False
                End If
            Next

            If cekData = True Then
                dgView.Rows.Add(isiView)
            End If

            cekData = True
        Next

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim cekData As Boolean = True
        Dim feeTemp As Double = 1
        For i As Integer = 0 To dgView.Rows.Count - 1
            If dgView.Rows(i).Cells(0).Value = True Then
                'check
                'noticket
                'tgl
                'kdproduct
                'product
                'nettp
                Dim isiView(12) As Object
                isiView(0) = ""
                isiView(1) = dgView.Rows(i).Cells(1).Value
                isiView(2) = dgView.Rows(i).Cells(2).Value
                isiView(3) = dgView.Rows(i).Cells(3).Value
                isiView(4) = dgView.Rows(i).Cells(4).Value
                isiView(5) = dgView.Rows(i).Cells(5).Value
                isiView(6) = dgView.Rows(i).Cells(6).Value
                isiView(7) = CInt(dgView.Rows(i).Cells(7).Value)
                isiView(8) = CDbl(dgView.Rows(i).Cells(8).Value)
                isiView(9) = clsKoneksi.kotaOn
                isiView(10) = ""
                isiView(11) = ""

                For m As Integer = 0 To frmPembayaranFee.dgView.Rows.Count - 1
                    feeTemp = frmPembayaranFee.dgView.Rows(m).Cells(12).Value
                    If frmPembayaranFee.dgView.Rows(m).Cells(6).Value = dgView.Rows(i).Cells(6).Value Then
                        feeTemp = feeTemp
                        Exit For
                    Else
                        feeTemp = feeTemp + 1
                    End If
                Next
                isiView(12) = feeTemp
                frmPembayaranFee.dgView.Rows.Add(isiView)
            End If
        Next
        frmPembayaranFee.loadHitungTotal()
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

    Private Sub frmPembayaranFeeDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        btnTogle.Text = "down"
        toogle = False
        txtFee.Clear()
        txtKodeFee.Clear()
    End Sub
    Private Sub frmPembayaranFeeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelHeader.Height = 33
        dgView.Rows.Clear()
        chkPilihSemua.Checked = False
        dtAwal.Value = clsKoneksi.tglAwalBulan(Now)
        dtAkhir.Value = clsKoneksi.tglAkhirBulan(Now)
    End Sub

    Private Sub chkPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles chkPilihSemua.CheckedChanged
        For i As Integer = 0 To dgView.Rows.Count - 1
            dgView.Rows(i).Cells(0).Value = chkPilihSemua.Checked
        Next
    End Sub

    Private Sub btnTogle_Click(sender As Object, e As EventArgs) Handles btnTogle.Click
        If toogle = False Then
            panelHeader.Height = 57
            toogle = True
            btnTogle.Text = "up"
        Else
            panelHeader.Height = 33
            toogle = False
            btnTogle.Text = "down"
        End If

    End Sub

    Private Sub btnPilihFee_Click(sender As Object, e As EventArgs) Handles btnPilihFee.Click
        frmFeeCari.kodeKelompok = kodeKelompok
        frmFeeCari.ShowDialog()
    End Sub

    Private Sub btnLoad2_Click(sender As Object, e As EventArgs) Handles btnLoad2.Click
        loadCari()
    End Sub
End Class