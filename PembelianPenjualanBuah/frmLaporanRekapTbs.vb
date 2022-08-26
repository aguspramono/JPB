Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmLaporanRekapTbs

    Sub BulanTahun()
        cmbTahun.Items.Clear()
        cmbBulan.Items.Clear()
        For i As Integer = 0 To 3
            cmbTahun.Items.Add(Year(Now) - i)
        Next i

        For j As Integer = 1 To 12
            cmbBulan.Items.Add(j)
        Next
        cmbBulan.Text = Month(Now)
        cmbTahun.Text = Year(Now)
    End Sub

    Private Sub frmLaporanRekapTbs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BulanTahun()
        cbPilih.SelectedIndex = 0
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim kondisi As String = ""
        Dim objReport As New LaporanRekapTbs
        Dim AccessCommand As New System.Data.OleDb.OleDbCommand("Dummy", clsKoneksi.getConnection(1))
        AccessCommand.Connection.Close()
        AccessCommand.Connection.Open()

        AccessCommand.CommandText = "select * from Pembelian where kodekota='" & clsKoneksi.kotaOn & "' and (month(tgl1)='" & cmbBulan.Text & "' or month(tgl2)='" & cmbBulan.Text & "') and (year(tgl1)='" & cmbTahun.Text & "' or year(tgl2)='" & cmbTahun.Text & "') Order by tgl2 asc"
        Dim ds3 As New DataSet()
        Dim da3 As New OleDbDataAdapter(AccessCommand)
        Dim dtT3 As New DataTable
        da3.Fill(dtT3)
        ds3.Tables.Add(dtT3)
        objReport.Database.Tables("Pembelian").SetDataSource(ds3.Tables(0))


        If cbPilih.SelectedIndex = 0 Then
            kondisi = " where nama like '%" & txtCustomer.Text & "%'"
        ElseIf cbPilih.SelectedIndex = 1 Then
            kondisi = " where kodeKelompok like '%" & txtCustomer.Text & "%'"
        End If

        AccessCommand.CommandText = "select * from Customer " & kondisi & ""
        Dim ds2 As New DataSet()
        Dim da2 As New OleDbDataAdapter(AccessCommand)
        Dim dtT2 As New DataTable
        da2.Fill(dtT2)
        ds2.Tables.Add(dtT2)
        objReport.Database.Tables("Customer").SetDataSource(ds2.Tables(0))

        If (clsKoneksi.kotaOn = "1") Then
            objReport.SetParameterValue("kota", "LIBO")
        ElseIf (clsKoneksi.kotaOn = "2") Then
            objReport.SetParameterValue("kota", "BINA BARU")
        End If


        objReport.SetParameterValue("bulan", cmbBulan.Text)
        objReport.SetParameterValue("tahun", cmbTahun.Text)

        frmLaporanView.rptView.ShowGroupTreeButton = False
        frmLaporanView.rptView.ReportSource = objReport
        frmLaporanView.rptView.Refresh()
        frmLaporanView.StartPosition = FormStartPosition.CenterScreen
        frmLaporanView.WindowState = FormWindowState.Maximized
        frmLaporanView.Show()

    End Sub
End Class