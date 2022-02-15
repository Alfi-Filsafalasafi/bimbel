Public Class Form_atur_jadwal

    Dim aksi, sesi As String
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_jadwal order by kelas ASC", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_jadwal)
            lv_menu.Items(i).SubItems.Add(reader!tanggal)
            lv_menu.Items(i).SubItems.Add(reader!hari)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!mapel)

            i = i + +1
        Loop
    End Sub

    Sub bersihteks()
        txt_cari_guru.Text = ""
        txt_cari_kelas.Text = ""
        txt_cari_tgl.Text = Date.Now
        txt_hari.Text = ""
        txt_id_mapel.Text = ""
        txt_tgl.Text = Date.Now

        lbl_guru.Text = "-"
        lbl_kelas.Text = "-"
        lbl_mapel.Text = "-"

    End Sub

    Sub aksesteks(akses As Boolean)
        group_guru.Enabled = akses
        group_kelas.Enabled = akses
        txt_hari.Enabled = akses
        txt_tgl.Enabled = akses
    End Sub

    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub

    Sub tampil_kelas()
        lv_kelas.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from kelas", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_kelas.Items.Add(reader!id_kelas)
            lv_kelas.Items(i).SubItems.Add(reader!nama)
            lv_kelas.Items(i).SubItems.Add(reader!maksimal_kelas)

            i = i + +1
        Loop
    End Sub

    Sub tampil_guru()
        lv_guru.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_guru ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_guru.Items.Add(reader!id_guru)
            lv_guru.Items(i).SubItems.Add(reader!nama)
            lv_guru.Items(i).SubItems.Add(reader!mapel)

            i = i + +1
        Loop
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_admin.Visible = True
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lbl_mapel.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_atur_jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_cari_guru_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_guru.TextChanged
        lv_guru.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_guru where nama LIKE'%" & txt_cari_guru.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_guru.Items.Add(reader!id_guru)
            lv_guru.Items(i).SubItems.Add(reader!nama)
            lv_guru.Items(i).SubItems.Add(reader!mapel)

            i = i + +1
        Loop
    End Sub

    Private Sub txt_cari_kelas_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_kelas.TextChanged
        lv_kelas.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from kelas where nama LIKE '%" & txt_cari_kelas.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_kelas.Items.Add(reader!id_kelas)
            lv_kelas.Items(i).SubItems.Add(reader!nama)
            lv_kelas.Items(i).SubItems.Add(reader!maksimal_kelas)

            i = i + +1
        Loop
    End Sub

    Private Sub Form_atur_jadwal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        tampil_kelas()
        tampil_guru()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub lv_guru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_guru.SelectedIndexChanged

    End Sub

    Private Sub lv_guru_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_guru.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_guru where id_guru ='" & lv_guru.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_mapel.Text = reader!id_mapel
            lbl_guru.Text = reader!nama
            lbl_mapel.Text = reader!mapel
            txt_id_guru.Text = reader!id_guru
        Loop


    End Sub

    Private Sub lv_kelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_kelas.SelectedIndexChanged

    End Sub

    Private Sub lv_kelas_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_kelas.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from kelas where id_kelas ='" & lv_kelas.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_kelas.Text = reader!nama
            txt_id_kelas.Text = reader!id_kelas
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

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        tampil_data()
        tampil_kelas()
        tampil_guru()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As String
        message = MsgBox("apakah anda yakin menghapus data ini dari daftar jadwal ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from jadwal where id_jadwal ='" & txt_id.Text & "'", koneksi)
            Try
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                tampil_data()
                buttonawal()
                bersihteks()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_hari.Text = "" Or lbl_guru.Text = "-" Or lbl_kelas.Text = "-" Or lbl_mapel.Text = "-" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into jadwal values('" & txt_id_guru.Text & "' ,'" & txt_id_kelas.Text &
                                                       "', '" & txt_id_mapel.Text & "' , '" & Format(txt_tgl.Value, "yyyy-MM-dd") & "', '" & txt_hari.Text & "', '" & txt_sesi.Text & "')", koneksi)
                Try
                tambah.ExecuteNonQuery()
                MsgBox("data berhasil di tambah", MsgBoxStyle.Information)

                    tampil_data()
                    tampil_guru()
                    tampil_kelas()
                    buttonawal()
                bersihteks()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di simpan karena" + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

        If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update jadwal Set id_guru='" & txt_id_guru.Text & "', id_kelas ='" & txt_id_kelas.Text &
                                                     "', id_mapel = '" & txt_id_mapel.Text & "', tanggal = '" & Format(txt_tgl.Value, "yyyy-MM-dd") &
                                                     "', hari = '" & txt_hari.Text & "' where id_jadwal ='" & txt_id.Text & "'", koneksi)
                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)

                    tampil_data()
                    tampil_guru()
                    tampil_kelas()
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di ubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub cb_login_sebagai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_hari.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_jadwal where id_jadwal ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!id_jadwal
            txt_id_guru.Text = reader!id_guru
            txt_id_kelas.Text = reader!id_kelas
            txt_id_mapel.Text = reader!id_mapel
            txt_hari.Text = reader!hari
            txt_tgl.Text = reader!tanggal
            lbl_guru.Text = reader!nama
            lbl_kelas.Text = reader!kelas
            lbl_mapel.Text = reader!mapel

        Loop

        btn_batal.Enabled = True
        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
    End Sub

    Private Sub cb_login_sebagai_TextChanged(sender As Object, e As EventArgs) Handles txt_hari.TextChanged
        If txt_hari.Text = "Senin" Or txt_hari.Text = "Selasa" Or txt_hari.Text = "Rabu" Then
            txt_sesi.Text = "1"
        Else
            txt_sesi.Text = "2"
        End If
    End Sub
End Class