Public Class Form_tambah_angsuran
    Dim aksi As String

    Sub cetak()
        konek_db()
        Dim report As report_angsuran = New report_angsuran
        Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran where id_pendaftaran = '" & txt_id_pendaftaran.Text & "' and cicilan_ke = '" & txt_cicilan_ke.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        Dim data As New DataTable
        reader = tampil.ExecuteReader
        data.Load(reader)
        report.SetDataSource(data)
        Form_cetak_angsuranku.report_angsuran.ReportSource = report
        Form_cetak_angsuranku.Show()
    End Sub
    Public Sub bersihteks()
        txt_cari_siswa.Text = ""
        txt_nominal_cicilan.Text = ""
        txt_cicilan_ke.Text = ""
        txt_id.Text = ""
        txt_nama_siswa.Text = ""
        txt_banyak_cicilan.Text = ""
        txt_id_pendaftaran.Text = ""
        txt_sisa_byk.Text = ""
        txt_banyak_cicilan.Text = ""
        lbl_his_nama.Text = "-"
        txt_jumlah.Text = ""
        lv_menu.Items.Clear()

    End Sub


    Public Sub tampil_data()
        lv_menu.Items.Clear()

    End Sub

    Sub model()
        If lbl_his_nama.Text = "-" Then
            lv_menu.Items.Clear()
        Else
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_history_angsuran where siswa = '" & lbl_his_nama.Text & "'", koneksi)
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
                lv_menu.Items(i).SubItems.Add(reader!tgl_bayar)

                i = i + +1
            Loop
        End If

        konek_db()

        Dim sisa As New SqlClient.SqlCommand("select count(siswa) as jumlah from v_history_angsuran where siswa = '" & lbl_his_nama.Text & "'", koneksi)
        Dim reader_ As SqlClient.SqlDataReader
        reader_ = sisa.ExecuteReader
        Do While reader_.Read
            txt_jumlah.Text = reader_!jumlah

            txt_sisa_byk.Text = Val(txt_banyak_cicilan.Text) - Val(txt_jumlah.Text)
            txt_cicilan_ke.Text = Val(txt_jumlah.Text) + 1
        Loop
    End Sub
    Sub tampil_siswa()
        lv_siswa.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_siswa.Items.Add(reader!id_pendaftaran)
            lv_siswa.Items(i).SubItems.Add(reader!siswa)
            lv_siswa.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_siswa.Items(i).SubItems.Add(reader!banyaknya_cicilan)
            i = i + +1
        Loop
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form_angsuran.tampil_data()
        Form_angsuran.Visible = True
    End Sub

    Private Sub Form_tambah_angsuran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_tambah_angsuran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
        tampil_siswa()
        bersihteks()


    End Sub

    Private Sub txt_cari_siswa_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_siswa.TextChanged
        lv_siswa.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where siswa LIKE'%" & txt_cari_siswa.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_siswa.Items.Add(reader!id_pendaftaran)
            lv_siswa.Items(i).SubItems.Add(reader!siswa)
            lv_siswa.Items(i).SubItems.Add(reader!besar_cicilan)
            lv_siswa.Items(i).SubItems.Add(reader!banyaknya_cicilan)
            i = i + +1


        Loop
    End Sub

    Private Sub lv_siswa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_siswa.SelectedIndexChanged

    End Sub

    Private Sub lv_siswa_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_siswa.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_pendaftaran where id_pendaftaran ='" & lv_siswa.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_pendaftaran.Text = reader!id_pendaftaran
            txt_nama_siswa.Text = reader!siswa
            lbl_his_nama.Text = reader!siswa
            txt_banyak_cicilan.Text = reader!banyaknya_cicilan
            txt_besar_cicilan.Text = reader!besar_cicilan

            txt_nominal_cicilan.Text = reader!besar_cicilan / reader!banyaknya_cicilan
            model()

            If txt_cicilan_ke.Text > txt_banyak_cicilan.Text Then
                MsgBox("anggota ini angsuransinya telah lunas", MsgBoxStyle.Information)
                bersihteks()
            End If
        Loop
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        bersihteks()
    End Sub

    Private Sub lbl_his_nama_Click(sender As Object, e As EventArgs) Handles lbl_his_nama.Click

    End Sub

    Private Sub lbl_his_nama_TextChanged(sender As Object, e As EventArgs) Handles lbl_his_nama.TextChanged

    End Sub

    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged

    End Sub

    Private Sub btn_bayar_Click(sender As Object, e As EventArgs) Handles btn_bayar.Click
        If txt_cicilan_ke.Text = "" Then
            MsgBox("pilih data terlebih dahulu", MsgBoxStyle.Critical)
        Else

            Dim message As String
            message = MsgBox("apakah anda yakin akan membayar angsuran siswa ='" & lbl_his_nama.Text & "',", MsgBoxStyle.YesNo)
            If message = DialogResult.Yes Then
                If txt_banyak_cicilan.Text = txt_cicilan_ke.Text Then
                    konek_db()
                    Dim update As New SqlClient.SqlCommand("update history_angsuran set sudah_lunas = 'Sekarang lunas' where id_pendaftaran = '" & txt_id_pendaftaran.Text & "'", koneksi)
                    Dim tambahku As New SqlClient.SqlCommand("insert into history_angsuran values ( '" & txt_id_pendaftaran.Text & "', '" & txt_cicilan_ke.Text &
                                                           "', '" & txt_nominal_cicilan.Text & "', '" & Val(txt_besar_cicilan.Text) - Val(txt_cicilan_ke.Text) * Val(txt_nominal_cicilan.Text) &
                                                           "', '" & Val(txt_banyak_cicilan.Text) - Val(txt_cicilan_ke.Text) & "', 'sudah lunas', '" & Format(Date.Now, "yyyy-MM-dd") & "') ", koneksi)
                    Try
                        update.ExecuteNonQuery()
                        tambahku.ExecuteNonQuery()
                        MsgBox("berhasil membayar", MsgBoxStyle.Information)
                        cetak()
                    Catch ex As Exception
                        MsgBox("_gagal di bayar karena " + ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If
                If txt_banyak_cicilan.Text > txt_cicilan_ke.Text Then
                    konek_db()
                    Dim tambah As New SqlClient.SqlCommand("insert into history_angsuran values ( '" & txt_id_pendaftaran.Text & "', '" & txt_cicilan_ke.Text &
                                                           "', '" & txt_nominal_cicilan.Text & "', '" & Val(txt_besar_cicilan.Text) - Val(txt_cicilan_ke.Text) * Val(txt_nominal_cicilan.Text) &
                                                           "', '" & Val(txt_banyak_cicilan.Text) - Val(txt_cicilan_ke.Text) & "', 'belum lunas', '" & Format(Date.Now, "yyyy-MM-dd") & "') ", koneksi)
                    Try
                        tambah.ExecuteNonQuery()
                        MsgBox("berhasil membayar", MsgBoxStyle.Information)
                        cetak()
                    Catch ex As Exception
                        MsgBox("gagal di bayar karena " + ex.Message, MsgBoxStyle.Critical)
                    End Try


                End If


            End If
        End If

    End Sub
End Class