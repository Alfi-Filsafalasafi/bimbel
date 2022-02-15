Public Class Form_cetak_pendaftaran
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form_cetak_pendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_cetak_pendaftaran_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_pendaftaran.tampil_jenis_angsuran()
        Form_pendaftaran.tampil_kelas()
        Form_pendaftaran.tampil_paket()
        Form_pendaftaran.tampil_siswa()
        Form_pendaftaran.tampil_data()
        Form_pendaftaran.bersihteks()
        Form_pendaftaran.buttonawal()
        Form_pendaftaran.aksesteks(False)
        Form_pendaftaran.Enabled = True
    End Sub

    Private Sub Form_cetak_pendaftaran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where id_siswa = '" & Form_pendaftaran.txt_id_siswa.Text & "' and id_paket = '" & Form_pendaftaran.txt_id_paket.Text &
                                                     "' and id_kelas = '" & Form_pendaftaran.txt_id_kelas.Text & "' and id_jenis_angsuran = '" & Form_pendaftaran.txt_id_jenis_angsuran.Text &
                                                     "' and tgl_registrasi = '" & Format(Form_pendaftaran.txt_tgl_register.Value, "yyy-MM-dd") & "' and tipe_bayar = '" & Form_pendaftaran.txt_tipe_bayar.Text &
                                                     "' and pilihan_hari = '" & Form_pendaftaran.txt_sesi.Text & "' and diskon = '" & Form_pendaftaran.txt_diskon.Text &
                                                     "' and total_bayar = '" & Form_pendaftaran.lbl_total.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_id.Text = reader!id_pendaftaran
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        konek_db()
        Dim report As report_pendaftaran = New report_pendaftaran
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where id_pendaftaran =" & lbl_id.Text & "", koneksi)
        Dim reader As SqlClient.SqlDataReader
        Dim data As New DataTable
        reader = tampil.ExecuteReader
        data.Load(reader)
        report.SetDataSource(data)
        Form_v_cetak_pendaftaran.report_pendaftaran.ReportSource = report
        Form_v_cetak_pendaftaran.Show()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Close()
    End Sub
End Class