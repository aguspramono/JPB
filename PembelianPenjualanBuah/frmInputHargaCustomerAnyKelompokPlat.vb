Imports System.Data.OleDb
Public Class frmInputHargaCustomerAnyKelompokPlat

    Sub kelompokspsi()
        Dim tDs1 As DataSet
        Dim myQuery1 As String
        Dim kondisiWhere As String
        Dim where2 As String = ""

            where2 = "select kodeKelompok from kelompokplat group by kodekelompok"


            kondisiWhere = " where k.KodeKota='" & clsKoneksi.kotaOn & "' and k.grade<>'A' and k.kodeKelompok in (" & where2 & ") "

            myQuery1 = "select k.kodeKelompok,k.fee,k.spsi from kelompok as k " & kondisiWhere & ""
            dgvKelompok.Rows.Clear()
            tDs1 = clsKoneksi.selectCommand(1, myQuery1)
            Dim isiView1(2) As Object
            'isiView(0) = "" 
            For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView1.Length - 1
                    If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView1(j) = ""
                    Else
                        isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dgvKelompok.Rows.Add(isiView1)

                dgvKelompok.Rows(i).Cells(3).Value = True
            Next
    End Sub
    Sub loadHarga()
        Dim grade As String = ""
        Dim tanggal As String
        Dim where2 As String = ""
        Dim jointable As String = ""

            jointable = "kelompokplat kp on(kp.kodeKelompok=h.kodeKelompok)"


            tanggal = "(h.tgl>=#" & Format(dtpAwal.Value.Date, "MM/dd/yyyy") & "# and h.tgl<=#" & Format(dtpAkhir.Value.Date, "MM/dd/yyyy") & "#)"
            Dim tDs1 As DataSet
            Dim myQuery1 As String
            myQuery1 = "select h.tgl,h.jam,h.kodeKelompok,h.harga from harga h INNER JOIN " & jointable & " where " & tanggal & " and h.kodekota='" & clsKoneksi.kotaOn & "' and (h.plat='' or h.plat is null)"
            dgView.Rows.Clear()
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
                dgView.Rows.Add(isiView1)

                dgView.Rows(i).Cells(4).Value = True
            Next

            For intI = dgView.Rows.Count - 1 To 0 Step -1
                For intJ = intI - 1 To 0 Step -1
                    If dgView.Rows(intI).Cells(0).Value = dgView.Rows(intJ).Cells(0).Value And dgView.Rows(intI).Cells(2).Value = dgView.Rows(intJ).Cells(2).Value Then
                        dgView.Rows.RemoveAt(intI)
                        Exit For
                    End If
                Next
            Next

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        loadHarga()
        kelompokspsi()
        ''pembelian1
        ''Update pembelian p left join customer c on c.noAccount=p.noAccount set p.HargaAkhir=@harga
        'Dim query As String = "Update pembelian p inner join kelompokplat k on k.plat=p.vehicle set p.HargaAkhir=@harga where k.kodeKelompok=@kodekelompok and p.tgl2=@tgl2 and (p.tgl2>=@tglawal and p.tgl2<=@tglakhir)"
        'Dim cmd As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        'cmd.Parameters.Add("@harga", OleDbType.Double)
        'cmd.Parameters.Add("@kodeKelompok", OleDbType.VarChar)
        'cmd.Parameters.Add("@tglawal", OleDbType.Date)
        'cmd.Parameters.Add("@tglakhir", OleDbType.Date)
        'cmd.Parameters.Add("@tgl2", OleDbType.Date)
        'cmd.Connection.Close()
        'cmd.Connection.Open()
        'For Each row As DataGridViewRow In dgView.Rows
        '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb10").Value)
        '    If isSelected = True Then
        '        cmd.Parameters(0).Value = row.Cells("harga").Value.ToString()
        '        cmd.Parameters(1).Value = row.Cells("kdKelompok").Value.ToString()
        '        cmd.Parameters(2).Value = dtpAwal.Value.Date
        '        cmd.Parameters(3).Value = dtpAkhir.Value.Date
        '        cmd.Parameters(4).Value = Convert.ToDateTime(row.Cells("tanggal").Value)
        '        cmd.ExecuteNonQuery()

        '    End If
        'Next

        ''pembelian2
        'Dim query1 As String = "Update pembelian2 p inner join kelompokplat k on k.plat=p.vehicle set p.HargaAkhir=@harga where k.kodeKelompok=@kodekelompok and p.tgl2=@tgl2 and (p.tgl2>=@tglawal and p.tgl2<=@tglakhir)"
        'Dim cmd1 As OleDbCommand = New OleDbCommand(query1, clsKoneksi.getConnection(1))
        'cmd1.Parameters.Add("@harga", OleDbType.Double)
        'cmd1.Parameters.Add("@kodeKelompok", OleDbType.VarChar)
        'cmd1.Parameters.Add("@tglawal", OleDbType.Date)
        'cmd1.Parameters.Add("@tglakhir", OleDbType.Date)
        'cmd1.Parameters.Add("@tgl2", OleDbType.Date)
        'cmd1.Connection.Close()
        'cmd1.Connection.Open()
        'For Each row As DataGridViewRow In dgView.Rows
        '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb10").Value)
        '    If isSelected = True Then
        '        cmd1.Parameters(0).Value = row.Cells("harga").Value.ToString()
        '        cmd1.Parameters(1).Value = row.Cells("kdKelompok").Value.ToString()
        '        cmd1.Parameters(2).Value = dtpAwal.Value.Date
        '        cmd1.Parameters(3).Value = dtpAkhir.Value.Date
        '        cmd1.Parameters(4).Value = Convert.ToDateTime(row.Cells("tanggal").Value)
        '        cmd1.ExecuteNonQuery()
        '    End If
        'Next

        ''spsi(pembelian1)
        'Dim query2 As String = "Update pembelian p inner join kelompokplat k on k.plat=p.vehicle set p.FEE=@fee,p.SPSI=@spsi,p.HargaAsli=p.HargaAkhir-@fee-@spsi,p.Total = p.HargaAkhir * p.Netto where k.kodeKelompok=@kdKelompokspsi and (p.tgl2>=@tglawal and p.tgl2<=@tglakhir)"
        'Dim cmd2 As OleDbCommand = New OleDbCommand(query2, clsKoneksi.getConnection(1))
        'cmd2.Parameters.Add("@fee", OleDbType.Double)
        'cmd2.Parameters.Add("@spsi", OleDbType.Double)
        'cmd2.Parameters.Add("@kdKelompokspsi", OleDbType.VarChar)
        'cmd2.Parameters.Add("@tglawal", OleDbType.Date)
        'cmd2.Parameters.Add("@tglakhir", OleDbType.Date)
        'cmd2.Connection.Close()
        'cmd2.Connection.Open()
        'For Each row As DataGridViewRow In dgvKelompok.Rows
        '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb4").Value)
        '    If isSelected = True Then
        '        cmd2.Parameters(0).Value = row.Cells("fee").Value.ToString()
        '        cmd2.Parameters(1).Value = row.Cells("spsi").Value.ToString()
        '        cmd2.Parameters(2).Value = row.Cells("kdKelompokspsi").Value.ToString()
        '        cmd2.Parameters(3).Value = dtpAwal.Value.Date
        '        cmd2.Parameters(4).Value = dtpAkhir.Value.Date
        '        cmd2.ExecuteNonQuery()

        '    End If
        'Next


        ''spsi pembelian2
        'Dim query3 As String = "Update pembelian2 p inner join kelompokplat k on k.plat=p.vehicle set p.FEE=@fee,p.SPSI=@spsi,p.HargaAsli=p.HargaAkhir-@fee-@spsi,p.Total = p.HargaAkhir * p.Netto where k.kodeKelompok=@kdKelompokspsi and (p.tgl2>=@tglawal and p.tgl2<=@tglakhir)"
        'Dim cmd3 As OleDbCommand = New OleDbCommand(query3, clsKoneksi.getConnection(1))
        'cmd3.Parameters.Add("@fee", OleDbType.Double)
        'cmd3.Parameters.Add("@spsi", OleDbType.Double)
        'cmd3.Parameters.Add("@kdKelompokspsi", OleDbType.VarChar)
        'cmd3.Parameters.Add("@tglawal", OleDbType.Date)
        'cmd3.Parameters.Add("@tglakhir", OleDbType.Date)
        'cmd3.Connection.Close()
        'cmd3.Connection.Open()
        'For Each row As DataGridViewRow In dgvKelompok.Rows
        '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb4").Value)
        '    If isSelected = True Then
        '        cmd3.Parameters(0).Value = row.Cells("fee").Value.ToString()
        '        cmd3.Parameters(1).Value = row.Cells("spsi").Value.ToString()
        '        cmd3.Parameters(2).Value = row.Cells("kdKelompokspsi").Value.ToString()
        '        cmd3.Parameters(3).Value = dtpAwal.Value.Date
        '        cmd3.Parameters(4).Value = dtpAkhir.Value.Date
        '        cmd3.ExecuteNonQuery()
        '    End If
        'Next
        'MsgBox("Sukses")
    End Sub

End Class