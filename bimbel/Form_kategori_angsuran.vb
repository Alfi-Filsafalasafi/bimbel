Public Class Form_kategori_angsuran
    Dim aksi As String
    Sub bersihteks()
        txt_banyak_cicilan.Text = ""
        txt_besar_cicilan.Text = ""
        txt_cari_paket.Text = ""
        txt_dp.Text = ""
        txt_id_paket.Text = ""
        txt_nama_paket.Text = ""
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_harga.Text = ""
        txt_keterangan.Text = ""
    End Sub

    Sub aksesteks(akses As Boolean)

        txt_banyak_cicilan.Enabled = akses
        txt_besar_cicilan.Enabled = akses
        group_paket.Enabled = akses
        txt_dp.Enabled = akses
        txt_keterangan.Enabled = akses
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
        Dim tampil As New SqlClient.SqlCommand("select * from v_jenis_angsuran", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_jenis_angsuran)
            lv_menu.Items(i).SubItems.Add(reader!paket)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!keterangan)
            lv_menu.Items(i).SubItems.Add(reader!dp)
            lv_menu.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!banyaknya_cicilan)

            i = i + +1
        Loop
    End Sub
    Sub tampil_paket()
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form_angsuran.Visible = True
    End Sub

    Private Sub lv_paket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_paket.SelectedIndexChanged

    End Sub

    Private Sub txt_cari_mapel_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_paket.TextChanged
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

    Private Sub Form_kategori_angsuran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lv_paket_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_paket.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from paket where id_paket ='" & lv_paket.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_harga.Text = reader!harga
            txt_nama_paket.Text = reader!nama

            txt_id_paket.Text = reader!id_paket
        Loop


    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_jenis_angsuran where id_jenis_angsuran ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_harga.Text = reader!harga
            txt_nama.Text = reader!nama
            txt_id.Text = reader!id_jenis_angsuran
            txt_id_paket.Text = reader!id_paket
            txt_dp.Text = reader!dp
            txt_besar_cicilan.Text = reader!besar_cicilan
            txt_banyak_cicilan.Text = reader!banyaknya_cicilan
            txt_nama_paket.Text = reader!paket
            txt_keterangan.text = reader!keterangan
        Loop

        btn_batal.Enabled = True
        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
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
        aksesteks(False)
        bersihteks()
        buttonawal()
        tampil_data()
        tampil_paket()
    End Sub

    Private Sub Form_kategori_angsuran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        aksesteks(False)
        bersihteks()
        buttonawal()
        tampil_data()
        tampil_paket()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As String
        message = MsgBox("apakah anda yakin menghapus '" & txt_nama.Text & "' dari daftar kategori angsuran ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from jenis_angsuran where id_jenis_angsuran ='" & txt_id.Text & "'", koneksi)
            Try
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                tampil_data()
                buttonawal()
                bersihteks()
                tampil_paket()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_keterangan.Text = "" Or txt_harga.Text = "" Or txt_nama.Text = "" Or txt_harga.Text = "" Or txt_banyak_cicilan.Text = "" Or txt_besar_cicilan.Text = "" Or txt_dp.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into jenis_angsuran values('" & txt_id_paket.Text & "', '" & txt_nama.Text & "' ,'" & txt_keterangan.Text &
                                                       "', '" & txt_dp.Text & "', '" & txt_besar_cicilan.Text &
                                                       "', '" & txt_banyak_cicilan.Text & "')", koneksi)
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
                Dim ubah As New SqlClient.SqlCommand("update jenis_angsuran Set id_paket = '" & txt_id_paket.Text & "', nama='" & txt_nama.Text & "', keterangan ='" & txt_keterangan.Text &
                                                     "', dp = '" & txt_dp.Text & "', besar_cicilan = '" & txt_besar_cicilan.Text &
                                                     "', banyaknya_cicilan = '" & txt_banyak_cicilan.Text & "' where id_paket ='" & txt_id.Text & "'", koneksi)
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

    Private Sub txt_dp_TextChanged(sender As Object, e As EventArgs) Handles txt_dp.TextChanged
        txt_besar_cicilan.Text = Val(txt_harga.Text) - Val(txt_dp.Text)
    End Sub

    Private Sub txt_dp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dp.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_banyak_cicilan_TextChanged(sender As Object, e As EventArgs) Handles txt_banyak_cicilan.TextChanged

    End Sub

    Private Sub txt_banyak_cicilan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_banyak_cicilan.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_harga_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged
        txt_besar_cicilan.Text = Val(txt_harga.Text) - Val(txt_dp.Text)
    End Sub
End Class