Public Class Form_manajemen_guru

    Dim aksi As String
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_guru", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_guru)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!jenis_kelamin)
            lv_menu.Items(i).SubItems.Add(reader!no_telp)
            lv_menu.Items(i).SubItems.Add(reader!lulusan)
            lv_menu.Items(i).SubItems.Add(reader!mapel)

            i = i + +1
        Loop
    End Sub

    Sub bersihteks()
        txt_cari_mapel.Text = ""
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_jenis_kelamin.Text = ""
        txt_lulusan.Text = ""
        txt_mapel.Text = ""
        txt_no_hp.Text = ""

    End Sub

    Sub aksesteks(akses As Boolean)
        txt_jenis_kelamin.Enabled = akses
        txt_lulusan.Enabled = akses

        txt_nama.Enabled = akses
        txt_no_hp.Enabled = akses
        panel_mapel.Enabled = akses
    End Sub

    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub

    Sub tampil_mapel()
        lv_mapel.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from mapel", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_mapel.Items.Add(reader!id_mapel)
            lv_mapel.Items(i).SubItems.Add(reader!nama)

            i = i + +1
        Loop
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        form_admin.Visible = True
        Me.Close()
    End Sub

    Private Sub Form_manajemen_guru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_manajemen_guru_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        tampil_mapel()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        tampil_data()
        tampil_mapel()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_guru where id_guru ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_mapel.Text = reader!id_mapel
            txt_nama.Text = reader!nama
            txt_jenis_kelamin.Text = reader!jenis_kelamin
            txt_id.Text = reader!id_guru
            txt_lulusan.Text = reader!lulusan
            txt_mapel.Text = reader!mapel
            txt_no_hp.Text = reader!no_telp
        Loop

        btn_batal.Enabled = True
        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
    End Sub

    Private Sub lv_mapel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_mapel.SelectedIndexChanged

    End Sub

    Private Sub lv_mapel_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_mapel.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from mapel where id_mapel ='" & lv_mapel.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_mapel.Text = reader!id_mapel

            txt_mapel.Text = reader!nama

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
        message = MsgBox("apakah anda yakin menghapus '" & txt_nama.Text & "' dari daftar guru ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from guru where id_guru ='" & txt_id.Text & "'", koneksi)
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
        If txt_id_mapel.Text = "" Or txt_nama.Text = "" Or txt_jenis_kelamin.Text = "" Or txt_lulusan.Text = "" Or txt_no_hp.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into guru values('" & txt_id_mapel.Text & "', '" & txt_nama.Text & "' ,'" & txt_jenis_kelamin.Text &
                                                       "','" & txt_no_hp.Text & "', '" & txt_lulusan.Text & "')", koneksi)
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)

                    tampil_data()
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di simpan karena" + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If

            If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update guru Set nama='" & txt_nama.Text & "', id_mapel ='" & txt_id_mapel.Text &
                                                     "', jenis_kelamin ='" & txt_jenis_kelamin.Text & "', lulusan ='" & txt_lulusan.Text &
                                                     "', no_telp = '" & txt_no_hp.Text & "' where id_guru ='" & txt_id.Text & "'", koneksi)
                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)

                    tampil_data()
                    buttonawal()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di ubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub txt_no_hp_TextChanged(sender As Object, e As EventArgs) Handles txt_no_hp.TextChanged

    End Sub

    Private Sub txt_no_hp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_no_hp.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9,+]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_guru where nama LIKE'%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_guru)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!jenis_kelamin)
            lv_menu.Items(i).SubItems.Add(reader!no_telp)
            lv_menu.Items(i).SubItems.Add(reader!lulusan)
            lv_menu.Items(i).SubItems.Add(reader!mapel)

            i = i + +1
        Loop
    End Sub

    Private Sub txt_cari_mapel_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_mapel.TextChanged
        lv_mapel.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from mapel where nama LIKE '%" & txt_cari_mapel.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_mapel.Items.Add(reader!id_mapel)
            lv_mapel.Items(i).SubItems.Add(reader!nama)

            i = i + +1
        Loop
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        txt_cari.Text = ""
    End Sub
End Class