Imports System.IO
Public Class Form_manajemen_siswa
    Dim aksi As String
    Public Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from siswa", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_siswa)
            lv_menu.Items(i).SubItems.Add(reader!nis)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!jenis_kelamin)
            lv_menu.Items(i).SubItems.Add(reader!tanggal_lahir)


            i = i + +1
        Loop
    End Sub

    Sub cetak()
        konek_db()
        Dim report As report_siswa = New report_siswa
        Dim tampil As New SqlClient.SqlCommand("select * from siswa where  nama='" & txt_nama.Text & "' and nis ='" & txt_nis.Text &
                                                     "' and jenis_kelamin ='" & txt_jk.Text & "' and alamat ='" & txt_alamat.Text &
                                                     "' and tanggal_lahir = '" & Format(txt_tgl_lhr.Value, "yyyy-MM-dd") & "'and email = '" & txt_email.Text &
                                                     "' and password ='" & txt_password.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        Dim data As New DataTable
        reader = tampil.ExecuteReader
        data.Load(reader)
        report.SetDataSource(data)
        Form_cetak_siswa.report_siswa.ReportSource = report
    End Sub

    Public Sub bersihteks()
        txt_email.Text = ""
        txt_nis.Text = ""
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_jk.Text = ""
        txt_alamat.Text = ""
        txt_password.Text = ""
        txt_photo.Text = ""
        txt_tgl_lhr.Text = Date.Now
        pc_me.Image = Nothing

    End Sub

    Public Sub aksesteks(akses As Boolean)
        txt_alamat.Enabled = akses
        txt_email.Enabled = akses
        txt_nama.Enabled = akses
        txt_jk.Enabled = akses
        txt_nis.Enabled = akses
        txt_password.Enabled = akses
        txt_tgl_lhr.Enabled = akses
        btn_upload.Enabled = akses
    End Sub

    Public Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        form_admin.Visible = True
        Me.Close()
    End Sub

    Private Sub Form_manajemen_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()

        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
    End Sub

    Private Sub Form_manajemen_siswa_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from siswa where nama LIKE'%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_siswa)
            lv_menu.Items(i).SubItems.Add(reader!nis)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!jenis_kelamin)
            lv_menu.Items(i).SubItems.Add(reader!tanggal_lahir)


            i = i + +1
        Loop
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from siswa where id_siswa ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!id_siswa
            txt_jk.Text = reader!jenis_kelamin
            txt_alamat.Text = reader!alamat
            txt_email.Text = reader!email
            txt_nama.Text = reader!nama
            txt_nis.Text = reader!nis
            txt_password.Text = reader!password
            txt_photo.Text = reader!foto.ToString
            Dim img() As Byte
            img = reader!foto
            Dim ms As New MemoryStream(img)
            pc_me.Image = Image.FromStream(ms)


            txt_tgl_lhr.Text = reader!tanggal_lahir

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

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As String
        message = MsgBox("apakah anda yakin menghapus '" & txt_nama.Text & "' dari daftar siswa ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from siswa where id_siswa ='" & txt_id.Text & "'", koneksi)
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
        tampil_data()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        If txt_alamat.Text = "" Or txt_nama.Text = "" Or txt_jk.Text = "" Or txt_email.Text = "" Or txt_nis.Text = "" Or txt_password.Text = "" Or txt_photo.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        Else

            Dim ms As New MemoryStream
            pc_me.Image.Save(ms, pc_me.Image.RawFormat)
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into siswa values('" & txt_nis.Text & "','" & txt_nama.Text & "' ,'" & txt_alamat.Text & "','" & txt_jk.Text &
                                                       "','" & Format(txt_tgl_lhr.Value, "yyyy-MM-dd") & "', @image, '" & txt_email.Text & "', '" & txt_password.Text & "', '0')", koneksi)
                tambah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    cetak()
                    Form_cetak_siswa.Show()


                Catch ex As Exception
                    MsgBox("data gagal di simpan karena" + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If

            If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update siswa Set nama='" & txt_nama.Text & "', nis ='" & txt_nis.Text &
                                                     "', jenis_kelamin ='" & txt_jk.Text & "', alamat ='" & txt_alamat.Text &
                                                     "', tanggal_lahir = '" & Format(txt_tgl_lhr.Value, "yyyy-MM-dd") & "', foto=@image,email = '" & txt_email.Text &
                                                     "', password ='" & txt_password.Text & "' where id_siswa ='" & txt_id.Text & "'", koneksi)
                ubah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                    cetak()
                    Form_cetak_siswa.Show()

                Catch ex As Exception
                    MsgBox("data gagal di ubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txt_nis_TextChanged(sender As Object, e As EventArgs) Handles txt_nis.TextChanged

    End Sub

    Private Sub txt_nis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nis.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub
End Class