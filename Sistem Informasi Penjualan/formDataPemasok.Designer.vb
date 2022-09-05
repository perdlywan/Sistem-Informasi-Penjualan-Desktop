<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataPemasok
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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtKodePos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtNamaPemasok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tblBatal = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1845, 32)
        Me.ToolStrip1.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(11, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1822, 82)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ".:: DATA PEMASOK ::."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtKodePos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtKota)
        Me.GroupBox1.Controls.Add(Me.txtNamaPemasok)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNoTelepon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 677)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(37, 609)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(378, 42)
        Me.txtEmail.TabIndex = 12
        '
        'txtKodePos
        '
        Me.txtKodePos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePos.Location = New System.Drawing.Point(37, 502)
        Me.txtKodePos.Multiline = True
        Me.txtKodePos.Name = "txtKodePos"
        Me.txtKodePos.Size = New System.Drawing.Size(378, 42)
        Me.txtKodePos.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 565)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 41)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "EMAIL"
        '
        'txtKota
        '
        Me.txtKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(37, 396)
        Me.txtKota.Multiline = True
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(378, 42)
        Me.txtKota.TabIndex = 9
        '
        'txtNamaPemasok
        '
        Me.txtNamaPemasok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPemasok.Location = New System.Drawing.Point(37, 83)
        Me.txtNamaPemasok.Multiline = True
        Me.txtNamaPemasok.Name = "txtNamaPemasok"
        Me.txtNamaPemasok.Size = New System.Drawing.Size(378, 42)
        Me.txtNamaPemasok.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NAMA PEMASOK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 41)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "KODE POS"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(37, 290)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(378, 42)
        Me.txtAlamat.TabIndex = 7
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelepon.Location = New System.Drawing.Point(37, 187)
        Me.txtNoTelepon.Multiline = True
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(378, 42)
        Me.txtNoTelepon.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 41)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "KOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NO TELEPON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ALAMAT"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(494, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1339, 731)
        Me.DataGridView1.TabIndex = 3
        '
        'tblBatal
        '
        Me.tblBatal.BackColor = System.Drawing.Color.Red
        Me.tblBatal.FlatAppearance.BorderSize = 0
        Me.tblBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblBatal.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.warning
        Me.tblBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBatal.Location = New System.Drawing.Point(247, 863)
        Me.tblBatal.Name = "tblBatal"
        Me.tblBatal.Size = New System.Drawing.Size(211, 48)
        Me.tblBatal.TabIndex = 8
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
        Me.tblSimpan.Location = New System.Drawing.Point(11, 863)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(211, 48)
        Me.tblSimpan.TabIndex = 7
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'formDataPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1845, 923)
        Me.Controls.Add(Me.tblBatal)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1867, 979)
        Me.Name = "formDataPemasok"
        Me.Text = "formDataPemasok"
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
    Friend WithEvents txtNamaPemasok As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelepon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtKodePos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents tblBatal As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
