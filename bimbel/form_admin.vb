Public Class form_admin
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar ?", MsgBoxStyle.YesNo)

        If message = DialogResult.Yes Then
            Me.Close()
            form_welcome.Visible = True
        End If

    End Sub

    Private Sub btn_manajemen_admin_Click(sender As Object, e As EventArgs) Handles btn_manajemen_admin.Click
        Me.Visible = False
        Form_manajemen_admin.Show()
    End Sub

    Private Sub btn_manajemen_guru_Click(sender As Object, e As EventArgs) Handles btn_manajemen_guru.Click
        Me.Visible = False
        Form_manajemen_guru.Show()
    End Sub

    Private Sub btn_manajemen_siswa_Click(sender As Object, e As EventArgs) Handles btn_manajemen_siswa.Click
        Me.Visible = False
        Form_manajemen_siswa.Show()
    End Sub

    Private Sub btn_manajemen_kelas_Click(sender As Object, e As EventArgs) Handles btn_manajemen_kelas.Click
        Me.Visible = False
        Form_manajemen_kelas.Show()
    End Sub

    Private Sub btn_paket_bimbel_Click(sender As Object, e As EventArgs) Handles btn_paket_bimbel.Click
        Me.Visible = False
        Form_paket_bimbel.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Visible = False
        Form_atur_jadwal.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_anggota_bimbel.Click
        Me.Visible = False
        Form_pendaftaran.Show()
    End Sub

    Private Sub btn_angsuran_Click(sender As Object, e As EventArgs) Handles btn_angsuran.Click
        Me.Visible = False
        Form_angsuran.Show()
    End Sub
End Class