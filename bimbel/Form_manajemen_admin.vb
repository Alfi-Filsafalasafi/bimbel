Public Class Form_manajemen_admin
    Dim aksi As String
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from admin", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_admin)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!email)

            i = i + +1
        Loop
    End Sub

    Sub bersihteks()
        txt_email.Text = ""
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_password.Text = ""
    End Sub

    Sub aksesteks(akses As Boolean)
        txt_email.Enabled = akses
        ck_sandi.Enabled = akses
        txt_nama.Enabled = akses
        txt_password.Enabled = akses
    End Sub

    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_admin.Visible = True
    End Sub

    Private Sub Form_manajemen_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_manajemen_admin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ck_sandi_CheckedChanged(sender As Object, e As EventArgs) Handles ck_sandi.CheckedChanged
        If ck_sandi.CheckState = CheckState.Checked Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False
        End If
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
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from admin where id_admin ='" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_email.Text = reader!email
            txt_nama.Text = reader!nama
            txt_password.Text = reader!password
            txt_id.Text = reader!id_admin
        Loop

        btn_batal.Enabled = True
        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_email.Text = "" Or txt_nama.Text = "" Or txt_password.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into admin values('" & txt_nama.Text & "' ,'" & txt_email.Text &
                                                       "','" & txt_password.Text & "')", koneksi)
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
                Dim ubah As New SqlClient.SqlCommand("update admin set nama='" & txt_nama.Text & "', email ='" & txt_email.Text &
                                                     "', password ='" & txt_password.Text & "' where id_admin ='" & txt_id.Text & "'", koneksi)
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
        message = MsgBox("apakah anda yakin menghapus '" & txt_nama.Text & "' dari daftar admin ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("Delete from admin where id_admin ='" & txt_id.Text & "'", koneksi)
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
End Class