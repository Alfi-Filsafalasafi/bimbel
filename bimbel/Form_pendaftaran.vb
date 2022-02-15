Public Class Form_pendaftaran

    Dim aksi As String
    Public Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_pendaftaran)
            lv_menu.Items(i).SubItems.Add(reader!siswa)
            lv_menu.Items(i).SubItems.Add(reader!paket)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!tgl_registrasi)
            lv_menu.Items(i).SubItems.Add(reader!pilihan_hari)
            lv_menu.Items(i).SubItems.Add(reader!diskon)
            lv_menu.Items(i).SubItems.Add(reader!total_bayar)


            i = i + +1
        Loop
    End Sub

    Public Sub bersihteks()
        txt_id.Text = ""
        txt_id_kelas.Text = ""
        txt_id_paket.Text = ""
        txt_diskon.Text = ""
        txt_id_siswa.Text = ""
        txt_jenis_angsuran.Text = ""
        txt_kelas.Text = ""
        txt_sesi.Text = ""
        txt_tgl_register.Text = ""
        txt_tipe_bayar.Text = ""
        txt_cari_paket.Text = ""
        txt_cari_siswa.Text = ""

        lbl_paket.Text = ""
        lbl_siswa.Text = ""
        lbl_total.Text = ""

    End Sub

    Public Sub aksesteks(akses As Boolean)
        group_paket.Enabled = akses
        group_siswa.Enabled = akses
        txt_diskon.Enabled = akses
        txt_jenis_angsuran.Enabled = akses
        txt_kelas.Enabled = akses
        txt_sesi.Enabled = akses
        txt_tgl_register.Enabled = akses
        txt_tipe_bayar.Enabled = akses
    End Sub

    Public Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub

    Public Sub tampil_paket()
        lv_paket.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_paket.Items.Add(reader!id_paket)
            lv_paket.Items(i).SubItems.Add(reader!nama)
            lv_paket.Items(i).SubItems.Add(reader!harga)
            lv_paket.Items(i).SubItems.Add(reader!jumlah_pertemuan)
            i = i + +1
        Loop
    End Sub

    Public Sub tampil_siswa()
        lv_siswa.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from siswa where id_daftar='0'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_siswa.Items.Add(reader!id_siswa)
            lv_siswa.Items(i).SubItems.Add(reader!nis)
            lv_siswa.Items(i).SubItems.Add(reader!nama)

            i = i + +1
        Loop
    End Sub

    Public Sub tampil_kelas()
        txt_kelas.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from kelas", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            txt_kelas.Items.Add(reader("nama"))
        Loop
    End Sub

    Public Sub tampil_jenis_angsuran()
        txt_jenis_angsuran.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from jenis_angsuran", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            txt_jenis_angsuran.Items.Add(reader("nama"))
        Loop
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_admin.Visible = True
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form_pendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_pendaftaran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        tampil_jenis_angsuran()
        tampil_kelas()
        tampil_paket()
        tampil_siswa()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub lv_siswa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_siswa.SelectedIndexChanged

    End Sub

    Private Sub lv_siswa_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_siswa.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from siswa where id_siswa ='" & lv_siswa.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_siswa.Text = reader!id_siswa
            lbl_siswa.Text = reader!nama
        Loop

    End Sub

    Private Sub lv_paket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_paket.SelectedIndexChanged

    End Sub

    Private Sub lv_paket_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_paket.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket where id_paket ='" & lv_paket.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_paket.Text = reader!id_paket
            lbl_paket.Text = reader!nama
            txt_harga.Text = reader!harga

        Loop
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        aksesteks(True)
        aksi = "T"
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        aksesteks(True)
        aksi = "U"
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As String
        message = MsgBox("apakah anda yakin menghapus data ini dari daftar pendaftaran ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from pendaftaran where id_pendaftaran ='" & txt_id.Text & "'", koneksi)
            Try
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                tampil_data()
                tampil_jenis_angsuran()
                tampil_kelas()
                tampil_paket()
                tampil_siswa()
                buttonawal()
                bersihteks()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub txt_cari_siswa_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_siswa.TextChanged
        lv_siswa.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from siswa where nama LIKE'%" & txt_cari_siswa.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_siswa.Items.Add(reader!id_siswa)
            lv_siswa.Items(i).SubItems.Add(reader!nis)
            lv_siswa.Items(i).SubItems.Add(reader!nama)



            i = i + +1
        Loop
    End Sub

    Private Sub txt_cari_paket_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_paket.TextChanged
        lv_paket.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket where nama LIKE '%" & txt_cari_paket.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_paket.Items.Add(reader!id_paket)
            lv_paket.Items(i).SubItems.Add(reader!nama)
            lv_paket.Items(i).SubItems.Add(reader!harga)
            lv_paket.Items(i).SubItems.Add(reader!jumlah_pertemuan)

            i = i + +1
        Loop
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where id_pendaftaran ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!id_pendaftaran
            txt_id_kelas.Text = reader!id_kelas
            txt_id_paket.Text = reader!id_paket
            txt_diskon.Text = reader!diskon
            txt_id_siswa.Text = reader!id_siswa
            txt_jenis_angsuran.Text = reader!angsuran
            txt_kelas.Text = reader!kelas
            txt_sesi.Text = reader!pilihan_hari
            txt_tgl_register.Text = reader!tgl_registrasi
            txt_tipe_bayar.Text = reader!tipe_bayar

            lbl_paket.Text = reader!paket
            lbl_siswa.Text = reader!siswa
            lbl_total.Text = reader!total_bayar

        Loop

        btn_batal.Enabled = True
        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        tampil_jenis_angsuran()
        tampil_kelas()
        tampil_paket()
        tampil_siswa()
        bersihteks()
        buttonawal()
        aksesteks(False)
    End Sub

    Private Sub txt_jenis_angsuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_jenis_angsuran.SelectedIndexChanged

    End Sub

    Private Sub txt_jenis_angsuran_TextChanged(sender As Object, e As EventArgs) Handles txt_jenis_angsuran.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from jenis_angsuran where nama = '" & txt_jenis_angsuran.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_jenis_angsuran.Text = reader!id_jenis_angsuran
            End If
        End While
    End Sub

    Private Sub txt_kelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_kelas.SelectedIndexChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from kelas where nama = '" & txt_kelas.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_kelas.Text = reader!id_kelas
            End If
        End While
    End Sub

    Private Sub txt_cari_tgl_ValueChanged(sender As Object, e As EventArgs) Handles txt_cari_tgl.ValueChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where tgl_registrasi = '" & Format(txt_cari_tgl.Value, "yyyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_pendaftaran)
            lv_menu.Items(i).SubItems.Add(reader!siswa)
            lv_menu.Items(i).SubItems.Add(reader!paket)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!tgl_registrasi)
            lv_menu.Items(i).SubItems.Add(reader!tipe_bayar)
            lv_menu.Items(i).SubItems.Add(reader!pilihan_hari)
            lv_menu.Items(i).SubItems.Add(reader!diskon)
            lv_menu.Items(i).SubItems.Add(reader!total_bayar)


            i = i + +1

        Loop
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_diskon.Text = "" Or txt_id_jenis_angsuran.Text = "" Or txt_id_kelas.Text = "" Or txt_id_paket.Text = "" Or txt_id_siswa.Text = "" Or txt_id_jenis_angsuran.Text = "" Or txt_tipe_bayar.Text = "" Or txt_sesi.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Critical)
        Else
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into pendaftaran values ( '" & txt_id_siswa.Text & "', '" & txt_id_paket.Text &
                                                       "', '" & txt_id_kelas.Text & "', '" & txt_id_jenis_angsuran.Text & "', '" & Format(txt_tgl_register.Value, "yyyy-MM-dd") &
                                                       "', '" & txt_tipe_bayar.Text & "', '" & txt_sesi.Text & "', '" & txt_diskon.Text & "', '" & lbl_total.Text & "')", koneksi)
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di daftarkan", MsgBoxStyle.Information)
                    Form_cetak_pendaftaran.Show()
                    Me.Enabled = False
                Catch ex As Exception
                    MsgBox("data gagal di daftarkan karena " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update pendaftaran set id_siswa = '" & txt_id_siswa.Text & "', id_paket = '" & txt_id_paket.Text &
                                                     "', id_kelas = '" & txt_id_kelas.Text & "', id_jenis_angsuran = '" & txt_id_jenis_angsuran.Text &
                                                     "', tgl_registrasi = '" & Format(txt_tgl_register.Value, "yyy-MM-dd") & "', tipe_bayar = '" & txt_tipe_bayar.Text &
                                                     "', pilihan_hari = '" & txt_sesi.Text & "', diskon = '" & txt_diskon.Text &
                                                     "', total_bayar = '" & lbl_total.Text & "' where id_pendaftaran = '" & txt_id.Text & "'", koneksi)
                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                    tampil_jenis_angsuran()
                    tampil_kelas()
                    tampil_paket()
                    tampil_siswa()
                    tampil_data()
                    bersihteks()
                    buttonawal()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di rubah karena" + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub txt_diskon_TextChanged(sender As Object, e As EventArgs) Handles txt_diskon.TextChanged
        lbl_total.Text = Val(txt_harga.Text) - Val(txt_diskon.Text)
    End Sub

    Private Sub txt_diskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_diskon.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_harga_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged
        lbl_total.Text = Val(txt_harga.Text) - Val(txt_diskon.Text)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class