Imports System.Data.OleDb
Imports System.IO
Public Class frmSettingDatabase
    Function getFileName(tNamaFile As String) As String
        Dim fileNameStart As Integer = tNamaFile.LastIndexOf("\") + 1
        Dim fileNameStop As Integer = tNamaFile.Length - fileNameStart
        Dim fileName As String = tNamaFile.Substring(fileNameStart, fileNameStop)
        Return fileName
    End Function

    Sub tampilDatabase()
        Dim FILE_NAME As String = Application.StartupPath + "\setting.txt"
        If File.Exists(FILE_NAME) = True Then
            Dim content2 As String() = clsKoneksi.ReadFile(FILE_NAME)
            txtPath.Text = content2(0)
            frmMainMenu.txtDatabase.Text = content2(0)
        Else
        End If
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim dialog As New OpenFileDialog()
        dialog.Multiselect = False
        dialog.Title = "Browse Database"
        dialog.Filter = "Database Files(*.mdb)|*.mdb"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPath.Text = dialog.FileName
            lblDbBaru.Text = getFileName(dialog.FileName)
        End If
    End Sub

    Private Sub btnKoneksi_Click(sender As Object, e As EventArgs) Handles btnKoneksi.Click
        If lblDbBaru.Text = "" And File.Exists(txtPath.Text) Then
            MessageBox.Show("Database sudah terkoneksi", "warning")
        ElseIf lblNamaDatabase.Text <> lblDbBaru.Text Then
            MessageBox.Show("Database yang anda pilih salah", "Warning")
        Else
            Dim FILE_NAME As String = Application.StartupPath & "\setting.txt"
            Dim objWriter As New StreamWriter(FILE_NAME)
            '192.168.0.110
            objWriter.WriteLine(txtPath.Text)
            objWriter.Close()
            tampilDatabase()
            frmMainMenu.database()
            Console.WriteLine(frmMainMenu.txtDatabase.Text)
            clsKoneksi.createNewConnection()
            MsgBox("Koneksi Berhasil")
            Me.Close()
        End If
    End Sub

    Private Sub frmSettingDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilDatabase()
    End Sub
End Class