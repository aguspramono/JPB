Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Sub login()
        If frmMainMenu.txtDatabase.Text = "" Then
            MessageBox.Show("Database belum disetting", "warning")
            Return
        Else

        End If

        If txtUsername.Text = "" Then
            MessageBox.Show("Harap isi UserName", "warning")
            txtUsername.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Harap isi Password", "warning")
            txtPassword.Focus()
            Exit Sub
        End If

        If clsKoneksi.loginAccount(1, txtUsername.Text, clsKoneksi.Encrypt(txtPassword.Text)) Then
            frmMainMenu.Show()
            frmMainMenu.Enabled = True
            frmMainMenu.lblStatusUserOn.Text = txtUsername.Text

            If txtUsername.Text = "admin" Then
                frmMainMenu.mnuFileUser.Visible = True
                frmMainMenu.mnuLaporanUtama.Visible = True
            Else
                frmMainMenu.mnuFileUser.Visible = False
                frmMainMenu.mnuLaporanUtama.Visible = False
            End If
            Me.Close()
            frmGantiKota.ShowDialog()
        Else
            MessageBox.Show("Username atau Password Salah.", "warning")
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub lblSetting_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSetting.LinkClicked
        frmSettingDatabase.ShowDialog(Me)
    End Sub

End Class