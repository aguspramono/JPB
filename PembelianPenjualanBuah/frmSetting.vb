Imports System.Data.SqlClient
Imports System.IO

Public Class frmSetting

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = clsKoneksi.serverSQL
        cboDatabase.Items.Clear()
        cboDatabase.Items.Add(clsKoneksi.databaseSQL)
        cboDatabase.SelectedIndex = 0
    End Sub

    Private Sub cboDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDatabase.SelectedIndexChanged

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim connectionMainT As SqlConnection
        Dim connetionStringT As String
        Try
            connetionStringT = "Data Source=" & txtServer.Text & ";Initial Catalog=master;User ID=" & clsKoneksi.idSQL & ";Password=" & clsKoneksi.passSQL & ";"
            connectionMainT = New SqlConnection(connetionStringT)

            'SqlCommand cmd = new SqlCommand("Select * From sys.databases Where database_id > 5", con);
            Dim ds As New DataSet()
            Dim cmd As New SqlCommand
            Dim dt As New DataTable()

            connectionMainT.Close()
            connectionMainT.Open()
            cmd.Connection = connectionMainT
            cmd.CommandText = "Select * From sys.databases Where database_id > 6"
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dt.Load(dr)
            ds.Tables.Add(dt)
            connectionMainT.Close()
            cboDatabase.Items.Clear()

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cboDatabase.Items.Add(ds.Tables(0).Rows(i).Item(0))
            Next

        Catch ex As Exception
            Try
                connectionMainT.Close()
            Catch ex2 As Exception
            End Try
            MessageBox.Show("Cek Koneksi", "warning")
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        TextBoxX2.Text = clsKoneksi.Encrypt(TextBoxX1.Text)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        TextBoxX2.Text = clsKoneksi.Decrypt(TextBoxX1.Text)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim objWriter As New StreamWriter(clsKoneksi.FILE_NAME)
        '192.168.1.110
        objWriter.WriteLine(clsKoneksi.Encrypt(txtServer.Text))
        'PembelianPenjualanBuah
        objWriter.WriteLine(clsKoneksi.Encrypt(cboDatabase.Text))
        objWriter.Close()

        clsKoneksi.serverSQL = txtServer.Text
        clsKoneksi.databaseSQL = cboDatabase.Text
        clsKoneksi.createNewConnection()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class