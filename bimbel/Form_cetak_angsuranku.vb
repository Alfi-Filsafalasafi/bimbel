Public Class Form_cetak_angsuranku
    Private Sub Form_cetak_angsuranku_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_cetak_angsuranku_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'konek_db()
        'Dim report As report_angsuran = New report_angsuran
        'Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran where id_history =1", koneksi)
        'Dim reader As SqlClient.SqlDataReader
        'Dim data As New DataTable
        'reader = tampil.ExecuteReader
        'data.Load(reader)
        'report.SetDataSource(data)
        'report_angsuran.ReportSource = report
    End Sub

    Private Sub Form_cetak_angsuranku_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_tambah_angsuran.bersihteks()
        Form_tambah_angsuran.tampil_data()
    End Sub
End Class