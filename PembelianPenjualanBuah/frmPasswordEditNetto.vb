Imports System.Net.Mail
Public Class frmPasswordEditNetto

    Private Sub btnOke_Click(sender As Object, e As EventArgs) Handles btnOke.Click
        If txtPassword.Text = "" Then
            MsgBox("password masih kosong", vbCritical)
        Else
            Dim myQuery As String = "select PassNetto,limit from PasswordGenerate where"
            Dim namaKolom As String() = {"PassNetto", "limit"}
            Dim isiKolom As Object() = {clsKoneksi.md5(txtPassword.Text), "1"}
            myQuery = myQuery & " PassNetto=@PassNetto and limit=@limit"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then

                Dim myQuery2 As String = "Update PasswordGenerate SET "
                Dim namaKolom2 As String() = {"limit"}
                Dim isiKolom2 As Object() = {"0"}
                Dim kondisiWhere2 As String = " where PassNetto=@PassNetto"
                Dim namaKolom3 As String() = {"PassNetto"}
                Dim isiKolom3 As Object() = {clsKoneksi.md5(txtPassword.Text)}
                clsKoneksi.updateCommand(1, myQuery2, namaKolom2, isiKolom2, kondisiWhere2, namaKolom3, isiKolom3, 1)

                frmInputHargaEditDetail.txtWG1.Enabled = True
                frmInputHargaEditDetail.txtWG2.Enabled = True
                frmInputHargaEditDetail.txtNet.Enabled = True

                txtPassword.Clear()
                Me.Close()
            Else
                MsgBox("Password salah atau sudah digunakan", vbCritical)
                Return
            End If
        End If
    End Sub

    Private Sub lblGenerate_Click(sender As Object, e As EventArgs) Handles lblGenerate.Click
        Dim Mail As New MailMessage
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        Dim emailTo As String = "ayoungssassa@gmail.com"
        Dim emailBcc As String = "agus.pramono3545@gmail.com"

        Mail.Subject = "Permintaan Password Edit Netto JPB"
        Mail.From = New MailAddress("admin@JPB.com")
        SMTP.Credentials = New System.Net.NetworkCredential("agus.pramono3545@gmail.com", "xtywdsysjnmjvyie") '<-- Password Here
        Mail.To.Add(emailTo) 'I used ByVal here for address
        Mail.Bcc.Add(emailBcc) 'BCC

        Dim myQuery As String = "select max(idPass) as maxID from PasswordGenerate"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView(0) As Object
        Dim maxID As Double = 0

        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            maxID = isiView(0)
        Next

        If Double.IsNaN(maxID) Then
            maxID = 1
        Else
            maxID = maxID + 1
        End If

        Dim tanggal As String = Format(Now, "ddMM")
        Dim hurufRandom As String = clsKoneksi.md5(maxID)
        Dim TigaHuruf As String = hurufRandom.Substring(3, 3)
        Dim detik As String = Format(Now, "ss")
        Dim tanggalSekarang As String = Format(Now, "dd-MM-yyyy hh:mm:ss")

        Dim password As String = tanggal & TigaHuruf & detik

        Dim myQuery2 As String = "Update PasswordGenerate SET "
        Dim namaKolom As String() = {"limit"}
        Dim isiKolom As Object() = {"0"}
        Dim kondisiWhere As String = " where idPass <> @PassID"
        Dim namaKolom2 As String() = {"PassID"}
        Dim isiKolom2 As Object() = {"0"}
        clsKoneksi.updateCommand(1, myQuery2, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)

        Dim myQuery1 As String = "INSERT INTO PasswordGenerate "
        Dim namaKolom1 As String() = {"idPass", "PassNetto", "limit"}
        Dim isiKolom1 As Object() = {maxID, clsKoneksi.md5(maxID & password), "1"}
        clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)

        Mail.IsBodyHtml = True
        Mail.Body = "<html><body>Password Anda : <b>" & maxID & password & "</b><br/> Password di generate pada tanggal : " & tanggalSekarang & "</body></html>"  'Message Here

        SMTP.EnableSsl = True
        SMTP.Port = "587"
        SMTP.Send(Mail)

        MsgBox("Password sukses di GENERATE, silahkan menghubungi Pemilik E-Mail " & emailTo & " atau " & emailBcc & " untuk mendapatkan hak akses")
    End Sub

    Private Sub frmPasswordEditNetto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Focus()
    End Sub
End Class