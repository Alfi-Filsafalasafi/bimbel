Public Class form_login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_welcome.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub form_login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txt_email.Text = ""
        txt_password.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If txt_hak_akses.Text = "admin" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from admin where email = '" & txt_email.Text & "' and password = '" & txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            reader.Read()
            Try
                form_admin.lbl_admin.Text = reader!nama
                form_admin.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Email dan Password salah", MsgBoxStyle.Critical)
            End Try
        End If
        If txt_hak_akses.Text = "siswa" Then
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from siswa where email = '" & txt_email.Text & "' and password = '" & txt_password.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            reader.Read()
            Try
                Form_siswa.lbl_admin.Text = reader!nama
                Form_siswa.lbl_id.Text = reader!id_siswa
                Form_siswa.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("email dan password salah ", MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class