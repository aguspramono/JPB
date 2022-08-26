Public Class frmtest

    Private Sub frmtest_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        Dim btn As Button = CType(sender, Button)
        TextBox1.Text = btn.Text
    End Sub
End Class