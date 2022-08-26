Imports System.Data.OleDb
Public Class frmInputPotonganAtmp

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim query As String
        Dim cmd As OleDbCommand
        'Update potongan
        query = "update (Pembelian2 p LEFT JOIN Customer c ON p.NoAccount = c.NoAccount) LEFT JOIN potongan pt ON c.KodeKelompok = pt.KodeKelompok set p.potongan=pt.potongan where "
        query = query & " (p.tgl2>=#" & dtpDari.Value.ToString("MM/dd/yyyy") & "# and p.tgl2<=#" & dtpSampai.Value.ToString("MM/dd/yyyy") & "#) and p.kodeKota='" & clsKoneksi.kotaOn & "' and pt.kodeKota='" & clsKoneksi.kotaOn & "' and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'update pjml
        query = "Update ((Pembelian2 INNER JOIN Pjmlsejenis ON Pembelian2.NoAccount = Pjmlsejenis.NoAccount) INNER JOIN Customer ON Pembelian2.NoAccount = Customer.NoAccount) LEFT JOIN Harga ON Customer.KodeKelompok = Harga.KodeKelompok set Pembelian2.hargaAkhir=ROUND(Harga.Harga*Pjmlsejenis.hargakali/100+Harga.harga,0) WHERE "
        query = query & " (((Pembelian2.Tgl2)>=#" & dtpDari.Value.ToString("MM/dd/yyyy") & "# And (Pembelian2.Tgl2)<=#" & dtpSampai.Value.ToString("MM/dd/yyyy") & "#)) AND ((Harga.Tgl)=[Pembelian2].[Tgl2])"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()


        'Update harga ATMP
        query = "update atmpsejenis a inner join pembelian2 p on (p.noAccount=a.noAccount) set p.hargaAkhir=(p.hargaAsli-a.fee)+ROUND(a.hargaKali/100*p.hargaAsli,0) where "
        query = query & " (p.tgl2>=#" & dtpDari.Value.ToString("MM/dd/yyyy") & "# and p.tgl2<=#" & dtpSampai.Value.ToString("MM/dd/yyyy") & "#) and a.kodeKota='" & clsKoneksi.kotaOn & "'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()


        'Update spsi dan fee data pembelian ke 2
        query = "update ((Pembelian2 AS p LEFT JOIN Customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga AS h ON c.KodeKelompok = h.KodeKelompok) LEFT JOIN Kelompok k ON c.KodeKelompok = k.KodeKelompok set p.FEE=k.Fee,p.SPSI=k.SPSI,p.Total = p.HargaAkhir * p.Netto "
        query = query & "where (p.Tgl2>=#" & Format(dtpDari.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtpSampai.Value.Date, "MM/dd/yyyy") & "#) and p.Tgl2=h.Tgl and p.kodeKota='" & clsKoneksi.kotaOn & "' and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()


        MsgBox("Berhasi Update")
        Me.Close()
    End Sub
End Class