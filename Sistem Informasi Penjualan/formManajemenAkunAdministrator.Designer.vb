<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formManajemenAkunAdministrator
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tblTambah = New System.Windows.Forms.ToolStripButton()
        Me.tblKoreksi = New System.Windows.Forms.ToolStripButton()
        Me.tblHapus = New System.Windows.Forms.ToolStripButton()
        Me.tblKeluar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tblBatal = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tblTambah, Me.tblKoreksi, Me.tblHapus, Me.tblKeluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1545, 32)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tblTambah
        '
        Me.tblTambah.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.plus
        Me.tblTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tblTambah.Name = "tblTambah"
        Me.tblTambah.Size = New System.Drawing.Size(136, 29)
        Me.tblTambah.Text = "Tambah Data"
        '
        'tblKoreksi
        '
        Me.tblKoreksi.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.refresh
        Me.tblKoreksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tblKoreksi.Name = "tblKoreksi"
        Me.tblKoreksi.Size = New System.Drawing.Size(131, 29)
        Me.tblKoreksi.Text = "Koreksi Data"
        '
        'tblHapus
        '
        Me.tblHapus.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.substract
        Me.tblHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(125, 29)
        Me.tblHapus.Text = "Hapus Data"
        '
        'tblKeluar
        '
        Me.tblKeluar.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.x_button
        Me.tblKeluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tblKeluar.Name = "tblKeluar"
        Me.tblKeluar.Size = New System.Drawing.Size(80, 29)
        Me.tblKeluar.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1522, 82)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ".:: MANAJEMEN AKUN ADMINISTRATOR ::."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNoTelepon)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 776)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtJenisKelamin
        '
        Me.txtJenisKelamin.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisKelamin.FormattingEnabled = True
        Me.txtJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.txtJenisKelamin.Location = New System.Drawing.Point(42, 394)
        Me.txtJenisKelamin.Name = "txtJenisKelamin"
        Me.txtJenisKelamin.Size = New System.Drawing.Size(378, 32)
        Me.txtJenisKelamin.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 660)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 41)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "EMAIL"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(42, 602)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(378, 42)
        Me.txtAlamat.TabIndex = 12
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelepon.Location = New System.Drawing.Point(42, 495)
        Me.txtNoTelepon.Multiline = True
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(378, 42)
        Me.txtNoTelepon.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 558)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 41)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ALAMAT"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(42, 81)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(378, 42)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USERNAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 41)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NO TELEPON"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(42, 288)
        Me.txtNama.Multiline = True
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(378, 42)
        Me.txtNama.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(42, 185)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(378, 42)
        Me.txtPassword.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 41)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NAMA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(494, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1039, 833)
        Me.DataGridView1.TabIndex = 13
        '
        'tblBatal
        '
        Me.tblBatal.BackColor = System.Drawing.Color.Red
        Me.tblBatal.FlatAppearance.BorderSize = 0
        Me.tblBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblBatal.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.warning
        Me.tblBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBatal.Location = New System.Drawing.Point(248, 966)
        Me.tblBatal.Name = "tblBatal"
        Me.tblBatal.Size = New System.Drawing.Size(211, 48)
        Me.tblBatal.TabIndex = 15
        Me.tblBatal.Text = "Batal"
        Me.tblBatal.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.Lime
        Me.tblSimpan.FlatAppearance.BorderSize = 0
        Me.tblSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblSimpan.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.save_file1
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(12, 966)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(211, 48)
        Me.tblSimpan.TabIndex = 14
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(42, 704)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(378, 42)
        Me.txtEmail.TabIndex = 17
        '
        'formManajemenAkunAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1545, 1026)
        Me.Controls.Add(Me.tblBatal)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1567, 1082)
        Me.Name = "formManajemenAkunAdministrator"
        Me.Text = "formManajemenAkunAdministrator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tblTambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblKoreksi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblHapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblKeluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tblBatal As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelepon As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
