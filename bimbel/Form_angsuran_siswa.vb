Public Class Form_angsuran_siswa

    Sub sisa()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select count(siswa) as jumlah from v_history_angsuran where id_siswa = '" & Form_siswa.lbl_id.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_jumlah.Text = reader!jumlah
        Loop
    End Sub
    Sub tampil_sisa()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where id_siswa = '" & Form_siswa.lbl_id.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            lbl_besar.Text = reader!besar_cicilan
        Loop
    End Sub
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran where id_siswa = '" & Form_siswa.lbl_id.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(i + 1)
            lv_menu.Items(i).SubItems.Add(reader!cicilan_ke)
            lv_menu.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_banyak_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sudah_lunas)
            lv_menu.Items(i).SubItems.Add(reader!tgl_bayar)
            sisa()
            tampil_sisa()

            lbl_sisa.Text = Val(lbl_besar.Text) - Val(lbl_jumlah.Text) * reader!besar_cicilan

            i = i + +1

        Loop
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form_siswa.Visible = True
    End Sub

    Private Sub Form_angsuran_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_angsuran_siswa_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_tgl.Text = Date.Now
        tampil_data()
    End Sub

    Private Sub txt_tgl_ValueChanged(sender As Object, e As EventArgs) Handles txt_tgl.ValueChanged

    End Sub

    Private Sub txt_tgl_TextChanged(sender As Object, e As EventArgs) Handles txt_tgl.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran where id_siswa = '" & Form_siswa.lbl_id.Text & "' and tgl_bayar = '" & Format(txt_tgl.Value, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(i + 1)
            lv_menu.Items(i).SubItems.Add(reader!cicilan_ke)
            lv_menu.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_besar_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sisa_banyak_cicilan)
            lv_menu.Items(i).SubItems.Add(reader!sudah_lunas)
            lv_menu.Items(i).SubItems.Add(reader!tgl_bayar)


            i = i + +1

        Loop
    End Sub
End Class