<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tambah_angsuran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tambah_angsuran))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.group_siswa = New System.Windows.Forms.GroupBox()
        Me.lv_siswa = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_id_pendaftaran = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_cari_siswa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_nominal_cicilan = New System.Windows.Forms.TextBox()
        Me.btn_bayar = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_cicilan_ke = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lv_menu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_banyak_cicilan = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_nama_siswa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_sisa_byk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_his_nama = New System.Windows.Forms.Label()
        Me.txt_besar_cicilan = New System.Windows.Forms.TextBox()
        Me.group_siswa.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Nominal Cicilan"
        '
        'group_siswa
        '
        Me.group_siswa.Controls.Add(Me.lv_siswa)
        Me.group_siswa.Controls.Add(Me.txt_id_pendaftaran)
        Me.group_siswa.Controls.Add(Me.Panel8)
        Me.group_siswa.Controls.Add(Me.Label8)
        Me.group_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_siswa.Location = New System.Drawing.Point(14, 19)
        Me.group_siswa.Name = "group_siswa"
        Me.group_siswa.Size = New System.Drawing.Size(455, 218)
        Me.group_siswa.TabIndex = 21
        Me.group_siswa.TabStop = False
        Me.group_siswa.Text = "Pilihan Siswa"
        '
        'lv_siswa
        '
        Me.lv_siswa.BackColor = System.Drawing.Color.RoyalBlue
        Me.lv_siswa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader7})
        Me.lv_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_siswa.ForeColor = System.Drawing.Color.White
        Me.lv_siswa.FullRowSelect = True
        Me.lv_siswa.GridLines = True
        Me.lv_siswa.HideSelection = False
        Me.lv_siswa.Location = New System.Drawing.Point(20, 76)
        Me.lv_siswa.Name = "lv_siswa"
        Me.lv_siswa.Size = New System.Drawing.Size(419, 120)
        Me.lv_siswa.TabIndex = 28
        Me.lv_siswa.UseCompatibleStateImageBehavior = False
        Me.lv_siswa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ID"
        Me.ColumnHeader9.Width = 57
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nama Siswa"
        Me.ColumnHeader10.Width = 154
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Besar Cicilan"
        Me.ColumnHeader11.Width = 94
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Byk Cicilan"
        Me.ColumnHeader7.Width = 84
        '
        'txt_id_pendaftaran
        '
        Me.txt_id_pendaftaran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_pendaftaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_pendaftaran.Location = New System.Drawing.Point(19, 20)
        Me.txt_id_pendaftaran.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id_pendaftaran.Multiline = True
        Me.txt_id_pendaftaran.Name = "txt_id_pendaftaran"
        Me.txt_id_pendaftaran.Size = New System.Drawing.Size(38, 22)
        Me.txt_id_pendaftaran.TabIndex = 25
        Me.txt_id_pendaftaran.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.txt_cari_siswa)
        Me.Panel8.Location = New System.Drawing.Point(108, 34)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(300, 30)
        Me.Panel8.TabIndex = 26
        '
        'txt_cari_siswa
        '
        Me.txt_cari_siswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cari_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari_siswa.Location = New System.Drawing.Point(6, 4)
        Me.txt_cari_siswa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cari_siswa.Multiline = True
        Me.txt_cari_siswa.Name = "txt_cari_siswa"
        Me.txt_cari_siswa.Size = New System.Drawing.Size(288, 20)
        Me.txt_cari_siswa.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Cari Siswa"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txt_nominal_cicilan)
        Me.Panel5.Location = New System.Drawing.Point(155, 443)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(284, 35)
        Me.Panel5.TabIndex = 19
        '
        'txt_nominal_cicilan
        '
        Me.txt_nominal_cicilan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nominal_cicilan.Enabled = False
        Me.txt_nominal_cicilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nominal_cicilan.Location = New System.Drawing.Point(6, 6)
        Me.txt_nominal_cicilan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nominal_cicilan.Multiline = True
        Me.txt_nominal_cicilan.Name = "txt_nominal_cicilan"
        Me.txt_nominal_cicilan.Size = New System.Drawing.Size(272, 22)
        Me.txt_nominal_cicilan.TabIndex = 5
        '
        'btn_bayar
        '
        Me.btn_bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bayar.Location = New System.Drawing.Point(15, 527)
        Me.btn_bayar.Name = "btn_bayar"
        Me.btn_bayar.Size = New System.Drawing.Size(267, 58)
        Me.btn_bayar.TabIndex = 9
        Me.btn_bayar.Text = "Bayar"
        Me.btn_bayar.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Location = New System.Drawing.Point(305, 527)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(131, 58)
        Me.btn_batal.TabIndex = 13
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Nama Siswa"
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(13, 108)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(38, 22)
        Me.txt_id.TabIndex = 30
        Me.txt_id.Visible = False
        '
        'txt_cicilan_ke
        '
        Me.txt_cicilan_ke.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cicilan_ke.Enabled = False
        Me.txt_cicilan_ke.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cicilan_ke.Location = New System.Drawing.Point(6, 6)
        Me.txt_cicilan_ke.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cicilan_ke.Multiline = True
        Me.txt_cicilan_ke.Name = "txt_cicilan_ke"
        Me.txt_cicilan_ke.Size = New System.Drawing.Size(272, 22)
        Me.txt_cicilan_ke.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Angsuran"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 100)
        Me.Panel1.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(517, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "History Angsuran Siswa"
        '
        'lv_menu
        '
        Me.lv_menu.BackColor = System.Drawing.Color.RoyalBlue
        Me.lv_menu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.lv_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_menu.ForeColor = System.Drawing.Color.White
        Me.lv_menu.FullRowSelect = True
        Me.lv_menu.GridLines = True
        Me.lv_menu.HideSelection = False
        Me.lv_menu.Location = New System.Drawing.Point(521, 166)
        Me.lv_menu.Name = "lv_menu"
        Me.lv_menu.Size = New System.Drawing.Size(823, 186)
        Me.lv_menu.TabIndex = 34
        Me.lv_menu.UseCompatibleStateImageBehavior = False
        Me.lv_menu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Siswa"
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cicilan Ke"
        Me.ColumnHeader3.Width = 111
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cicilan"
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sisa Cicilan"
        Me.ColumnHeader5.Width = 111
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sisa byk ccln"
        Me.ColumnHeader6.Width = 97
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "tanggal bayar"
        Me.ColumnHeader8.Width = 108
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.GroupBox1.Controls.Add(Me.txt_banyak_cicilan)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.group_siswa)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.btn_bayar)
        Me.GroupBox1.Controls.Add(Me.btn_batal)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 608)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'txt_jumlah
        '
        Me.txt_jumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jumlah.Location = New System.Drawing.Point(305, -7)
        Me.txt_jumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_jumlah.Multiline = True
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(38, 22)
        Me.txt_jumlah.TabIndex = 30
        Me.txt_jumlah.Visible = False
        '
        'txt_banyak_cicilan
        '
        Me.txt_banyak_cicilan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_banyak_cicilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_banyak_cicilan.Location = New System.Drawing.Point(224, -7)
        Me.txt_banyak_cicilan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_banyak_cicilan.Multiline = True
        Me.txt_banyak_cicilan.Name = "txt_banyak_cicilan"
        Me.txt_banyak_cicilan.Size = New System.Drawing.Size(38, 22)
        Me.txt_banyak_cicilan.TabIndex = 29
        Me.txt_banyak_cicilan.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_nama_siswa)
        Me.Panel2.Location = New System.Drawing.Point(154, 259)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 35)
        Me.Panel2.TabIndex = 24
        '
        'txt_nama_siswa
        '
        Me.txt_nama_siswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nama_siswa.Enabled = False
        Me.txt_nama_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_siswa.Location = New System.Drawing.Point(6, 6)
        Me.txt_nama_siswa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nama_siswa.Multiline = True
        Me.txt_nama_siswa.Name = "txt_nama_siswa"
        Me.txt_nama_siswa.Size = New System.Drawing.Size(272, 22)
        Me.txt_nama_siswa.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Sisa Banyaknya Cicilan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cicilan Ke"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_sisa_byk)
        Me.Panel3.Location = New System.Drawing.Point(210, 309)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(229, 35)
        Me.Panel3.TabIndex = 22
        '
        'txt_sisa_byk
        '
        Me.txt_sisa_byk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sisa_byk.Enabled = False
        Me.txt_sisa_byk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sisa_byk.Location = New System.Drawing.Point(4, 6)
        Me.txt_sisa_byk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_sisa_byk.Multiline = True
        Me.txt_sisa_byk.Name = "txt_sisa_byk"
        Me.txt_sisa_byk.Size = New System.Drawing.Size(208, 22)
        Me.txt_sisa_byk.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DP"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_cicilan_ke)
        Me.Panel4.Location = New System.Drawing.Point(155, 392)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(284, 35)
        Me.Panel4.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(701, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "="
        '
        'lbl_his_nama
        '
        Me.lbl_his_nama.AutoSize = True
        Me.lbl_his_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_his_nama.Location = New System.Drawing.Point(725, 124)
        Me.lbl_his_nama.Name = "lbl_his_nama"
        Me.lbl_his_nama.Size = New System.Drawing.Size(15, 20)
        Me.lbl_his_nama.TabIndex = 39
        Me.lbl_his_nama.Text = "-"
        '
        'txt_besar_cicilan
        '
        Me.txt_besar_cicilan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_besar_cicilan.Enabled = False
        Me.txt_besar_cicilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_besar_cicilan.Location = New System.Drawing.Point(548, 381)
        Me.txt_besar_cicilan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_besar_cicilan.Multiline = True
        Me.txt_besar_cicilan.Name = "txt_besar_cicilan"
        Me.txt_besar_cicilan.Size = New System.Drawing.Size(272, 22)
        Me.txt_besar_cicilan.TabIndex = 1
        Me.txt_besar_cicilan.Visible = False
        '
        'Form_tambah_angsuran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_besar_cicilan)
        Me.Controls.Add(Me.lbl_his_nama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lv_menu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_tambah_angsuran"
        Me.Text = "Bimbel SMK Nasional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.group_siswa.ResumeLayout(False)
        Me.group_siswa.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents group_siswa As GroupBox
    Friend WithEvents lv_siswa As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txt_id_pendaftaran As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_cari_siswa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_nominal_cicilan As TextBox
    Friend WithEvents btn_bayar As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_cicilan_ke As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lv_menu As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_nama_siswa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_sisa_byk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_his_nama As Label
    Friend WithEvents txt_banyak_cicilan As TextBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents txt_besar_cicilan As TextBox
End Class
