<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_paket_bimbel = New System.Windows.Forms.Button()
        Me.btn_manajemen_kelas = New System.Windows.Forms.Button()
        Me.btn_manajemen_siswa = New System.Windows.Forms.Button()
        Me.btn_manajemen_guru = New System.Windows.Forms.Button()
        Me.btn_manajemen_admin = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_anggota_bimbel = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_angsuran = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_admin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 120)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(894, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(429, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Admin of Bimbel SMK Nasional"
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.Location = New System.Drawing.Point(386, 43)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(195, 36)
        Me.lbl_admin.TabIndex = 3
        Me.lbl_admin.Text = "Nama Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang ,"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.bimbel.My.Resources.Resources.user2
        Me.PictureBox1.Location = New System.Drawing.Point(44, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 120)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1354, 100)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_log_out)
        Me.TabPage1.Controls.Add(Me.btn_paket_bimbel)
        Me.TabPage1.Controls.Add(Me.btn_manajemen_kelas)
        Me.TabPage1.Controls.Add(Me.btn_manajemen_siswa)
        Me.TabPage1.Controls.Add(Me.btn_manajemen_guru)
        Me.TabPage1.Controls.Add(Me.btn_manajemen_admin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1346, 71)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Master Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_log_out
        '
        Me.btn_log_out.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_log_out.Location = New System.Drawing.Point(776, 3)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(110, 65)
        Me.btn_log_out.TabIndex = 5
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.UseVisualStyleBackColor = True
        '
        'btn_paket_bimbel
        '
        Me.btn_paket_bimbel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_paket_bimbel.Location = New System.Drawing.Point(639, 3)
        Me.btn_paket_bimbel.Name = "btn_paket_bimbel"
        Me.btn_paket_bimbel.Size = New System.Drawing.Size(137, 65)
        Me.btn_paket_bimbel.TabIndex = 4
        Me.btn_paket_bimbel.Text = "Paket Bimbel"
        Me.btn_paket_bimbel.UseVisualStyleBackColor = True
        '
        'btn_manajemen_kelas
        '
        Me.btn_manajemen_kelas.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_manajemen_kelas.Location = New System.Drawing.Point(480, 3)
        Me.btn_manajemen_kelas.Name = "btn_manajemen_kelas"
        Me.btn_manajemen_kelas.Size = New System.Drawing.Size(159, 65)
        Me.btn_manajemen_kelas.TabIndex = 3
        Me.btn_manajemen_kelas.Text = "Manajemen Kelas"
        Me.btn_manajemen_kelas.UseVisualStyleBackColor = True
        '
        'btn_manajemen_siswa
        '
        Me.btn_manajemen_siswa.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_manajemen_siswa.Location = New System.Drawing.Point(321, 3)
        Me.btn_manajemen_siswa.Name = "btn_manajemen_siswa"
        Me.btn_manajemen_siswa.Size = New System.Drawing.Size(159, 65)
        Me.btn_manajemen_siswa.TabIndex = 2
        Me.btn_manajemen_siswa.Text = "Manajemen Siswa"
        Me.btn_manajemen_siswa.UseVisualStyleBackColor = True
        '
        'btn_manajemen_guru
        '
        Me.btn_manajemen_guru.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_manajemen_guru.Location = New System.Drawing.Point(162, 3)
        Me.btn_manajemen_guru.Name = "btn_manajemen_guru"
        Me.btn_manajemen_guru.Size = New System.Drawing.Size(159, 65)
        Me.btn_manajemen_guru.TabIndex = 1
        Me.btn_manajemen_guru.Text = "Manajemen Guru"
        Me.btn_manajemen_guru.UseVisualStyleBackColor = True
        '
        'btn_manajemen_admin
        '
        Me.btn_manajemen_admin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_manajemen_admin.Location = New System.Drawing.Point(3, 3)
        Me.btn_manajemen_admin.Name = "btn_manajemen_admin"
        Me.btn_manajemen_admin.Size = New System.Drawing.Size(159, 65)
        Me.btn_manajemen_admin.TabIndex = 0
        Me.btn_manajemen_admin.Text = "Manajemen Admin"
        Me.btn_manajemen_admin.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(414, 313)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(270, 168)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Atur Jadwal"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btn_anggota_bimbel
        '
        Me.btn_anggota_bimbel.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_anggota_bimbel.ForeColor = System.Drawing.Color.White
        Me.btn_anggota_bimbel.Location = New System.Drawing.Point(715, 313)
        Me.btn_anggota_bimbel.Name = "btn_anggota_bimbel"
        Me.btn_anggota_bimbel.Size = New System.Drawing.Size(270, 168)
        Me.btn_anggota_bimbel.TabIndex = 3
        Me.btn_anggota_bimbel.Text = "Anggota Bimbel"
        Me.btn_anggota_bimbel.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(715, 501)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(270, 168)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Info Aplikasi"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btn_angsuran
        '
        Me.btn_angsuran.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_angsuran.ForeColor = System.Drawing.Color.White
        Me.btn_angsuran.Location = New System.Drawing.Point(414, 501)
        Me.btn_angsuran.Name = "btn_angsuran"
        Me.btn_angsuran.Size = New System.Drawing.Size(270, 168)
        Me.btn_angsuran.TabIndex = 4
        Me.btn_angsuran.Text = "Angsuran"
        Me.btn_angsuran.UseVisualStyleBackColor = False
        '
        'form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.btn_angsuran)
        Me.Controls.Add(Me.btn_anggota_bimbel)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form_admin"
        Me.Text = "BIMBEL SMK Nasional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_admin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_log_out As Button
    Friend WithEvents btn_paket_bimbel As Button
    Friend WithEvents btn_manajemen_kelas As Button
    Friend WithEvents btn_manajemen_siswa As Button
    Friend WithEvents btn_manajemen_guru As Button
    Friend WithEvents btn_manajemen_admin As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btn_anggota_bimbel As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btn_angsuran As Button
End Class
