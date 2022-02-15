Public Class Form_paket_bimbel
    Dim aksi As String
    Sub bersihteks()
        txt_jml_temu.Text = ""
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_harga.Text = ""
    End Sub

    Sub aksesteks(akses As Boolean)
        txt_harga.Enabled = akses
        txt_jml_temu.Enabled = akses
        txt_nama.Enabled = akses

    End Sub

    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_paket)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!harga)
            lv_menu.Items(i).SubItems.Add(reader!jumlah_pertemuan)

            i = i + +1
        Loop
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_admin.Visible = True
    End Sub

    Private Sub txt_harga_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged

    End Sub

    Private Sub txt_harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_harga.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_jml_temu_TextChanged(sender As Object, e As EventArgs) Handles txt_jml_temu.TextChanged

    End Sub

    Private Sub txt_jml_temu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jml_temu.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub Form_paket_bimbel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_paket_bimbel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        bersihteks()
        buttonawal()
        aksesteks(False)
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket where nama LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_paket)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!harga)
            lv_menu.Items(i).SubItems.Add(reader!jumlah_pertemuan)

            i = i + +1
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

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_harga.Text = "" Or txt_nama.Text = "" Or txt_jml_temu.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into paket values('" & txt_nama.Text & "' ,'" & txt_harga.Text &
                                                       "', '" & txt_jml_temu.Text & "')", koneksi)
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
                Dim ubah As New SqlClient.SqlCommand("update paket Set nama='" & txt_nama.Text & "', harga ='" & txt_harga.Text &
                                                     "', jumlah_pertemuan = '" & txt_jml_temu.Text & "' where id_paket ='" & txt_id.Text & "'", koneksi)
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

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As String
        message = MsgBox("apakah anda yakin menghapus '" & txt_nama.Text & "' dari daftar paket bimbel ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from paket where id_paket ='" & txt_id.Text & "'", koneksi)
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

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        aksesteks(False)
        bersihteks()
        buttonawal()
        tampil_data()
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket where id_paket ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_harga.Text = reader!harga
            txt_nama.Text = reader!nama
            txt_jml_temu.Text = reader!jumlah_pertemuan
            txt_id.Text = reader!id_paket
        Loop

        btn_batal.Enabled = True
        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
    End Sub
End Class