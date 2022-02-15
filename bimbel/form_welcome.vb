Public Class form_welcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cb_login_sebagai.Text = "" Then
            MsgBox("pilih data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            Me.Visible = False
            form_login.txt_hak_akses.Text = cb_login_sebagai.Text
            form_login.Show()
        End If

    End Sub
End Class
