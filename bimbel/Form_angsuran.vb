Public Class Form_angsuran
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_history)
            lv_menu.Items(i).SubItems.Add(reader!siswa)
            lv_menu.Items(i).SubItems.Add(reader!cicilan_ke)
            lv_menu.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_banyak_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sudah_lunas)
            lv_menu.Items(i).SubItems.Add(reader!tgl_bayar)

            i = i + +1

        Loop
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_admin.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_jenis_angsuran.Click
        Me.Visible = False
        Form_kategori_angsuran.Show()
    End Sub

    Private Sub Form_angsuran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_angsuran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran where siswa LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_history)
            lv_menu.Items(i).SubItems.Add(reader!siswa)
            lv_menu.Items(i).SubItems.Add(reader!cicilan_ke)
            lv_menu.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_banyak_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sudah_lunas)
            lv_menu.Items(i).SubItems.Add(reader!tgl_bayar)

            i = i + +1

        Loop
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Me.Visible = False
        Form_tambah_angsuran.Show()
    End Sub
End Class