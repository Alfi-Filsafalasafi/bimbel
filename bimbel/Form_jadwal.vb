Public Class Form_jadwal
    Sub tampil_data()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_jadwal_siswa where id_siswa = '" & Form_siswa.lbl_id.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(i + 1)
            lv_menu.Items(i).SubItems.Add(reader!tanggal)
            lv_menu.Items(i).SubItems.Add(reader!hari)
            lv_menu.Items(i).SubItems.Add(reader!guru)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!mapel)



            i = i + +1

        Loop
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form_siswa.Visible = True
    End Sub

    Private Sub Form_jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_jadwal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
    End Sub
End Class