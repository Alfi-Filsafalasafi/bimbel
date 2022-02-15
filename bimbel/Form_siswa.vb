Public Class Form_siswa
    Private Sub btn_log_out_Click(sender As Object, e As EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("Apakah anda yakin akan keluar ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            Me.Close()
            form_welcome.Visible = True
        End If
    End Sub

    Private Sub btn_angsuran_Click(sender As Object, e As EventArgs) Handles btn_angsuran.Click
        Me.Visible = False
        Form_angsuran_siswa.Show()
    End Sub

    Private Sub btn_lihat_jadwal_Click(sender As Object, e As EventArgs) Handles btn_lihat_jadwal.Click
        Me.Visible = False
        Form_jadwal.Show()
    End Sub
End Class