<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_siswa
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
        Me.btn_lihat_jadwal = New System.Windows.Forms.Button()
        Me.btn_angsuran = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_lihat_jadwal
        '
        Me.btn_lihat_jadwal.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_lihat_jadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lihat_jadwal.ForeColor = System.Drawing.Color.White
        Me.btn_lihat_jadwal.Location = New System.Drawing.Point(715, 367)
        Me.btn_lihat_jadwal.Name = "btn_lihat_jadwal"
        Me.btn_lihat_jadwal.Size = New System.Drawing.Size(270, 187)
        Me.btn_lihat_jadwal.TabIndex = 9
        Me.btn_lihat_jadwal.Text = "Lihat Jadwal"
        Me.btn_lihat_jadwal.UseVisualStyleBackColor = False
        '
        'btn_angsuran
        '
        Me.btn_angsuran.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_angsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_angsuran.ForeColor = System.Drawing.Color.White
        Me.btn_angsuran.Location = New System.Drawing.Point(414, 367)
        Me.btn_angsuran.Name = "btn_angsuran"
        Me.btn_angsuran.Size = New System.Drawing.Size(270, 187)
        Me.btn_angsuran.TabIndex = 8
        Me.btn_angsuran.Text = "Angsuransi Saya"
        Me.btn_angsuran.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_log_out)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1362, 71)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Master Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_log_out
        '
        Me.btn_log_out.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_log_out.Location = New System.Drawing.Point(3, 3)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(110, 65)
        Me.btn_log_out.TabIndex = 5
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(894, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(447, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student of Bimbel SMK Nasional"
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.Location = New System.Drawing.Point(386, 43)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(190, 36)
        Me.lbl_admin.TabIndex = 3
        Me.lbl_admin.Text = "Nama Siswa"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 120)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1370, 100)
        Me.TabControl1.TabIndex = 7
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
        Me.Panel1.Size = New System.Drawing.Size(1370, 120)
        Me.Panel1.TabIndex = 6
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
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(73, 267)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 36)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "-"
        Me.lbl_id.Visible = False
        '
        'Form_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_lihat_jadwal)
        Me.Controls.Add(Me.btn_angsuran)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_siswa"
        Me.Text = "Bimbel SMK Nasional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_lihat_jadwal As Button
    Friend WithEvents btn_angsuran As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_admin As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_log_out As Button
    Friend WithEvents lbl_id As Label
End Class
