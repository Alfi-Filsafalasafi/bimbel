Public Class Form_cetak_siswa
    Private Sub Form_cetak_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_cetak_siswa_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Form_cetak_siswa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_manajemen_siswa.tampil_data()
        Form_manajemen_siswa.buttonawal()
        Form_manajemen_siswa.bersihteks()
        Form_manajemen_siswa.aksesteks(False)
    End Sub
End Class