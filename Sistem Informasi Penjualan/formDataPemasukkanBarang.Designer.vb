<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataPemasukkanBarang
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
        Me.tblSimpan = New System.Windows.Forms.ToolStripButton()
        Me.tblBatal = New System.Windows.Forms.ToolStripButton()
        Me.tblKeluar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNamaPemasok = New System.Windows.Forms.ComboBox()
        Me.txtAdmin = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdPasok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdBarang = New System.Windows.Forms.ComboBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tblTambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tblSimpan, Me.tblBatal, Me.tblKeluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1214, 32)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tblSimpan
        '
        Me.tblSimpan.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.save_file
        Me.tblSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(92, 29)
        Me.tblSimpan.Text = "Simpan"
        '
        'tblBatal
        '
        Me.tblBatal.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.warning
        Me.tblBatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tblBatal.Name = "tblBatal"
        Me.tblBatal.Size = New System.Drawing.Size(70, 29)
        Me.tblBatal.Text = "Batal"
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1175, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ".:: DATA PASOKAN BARANG ::."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtNamaPemasok)
        Me.GroupBox1.Controls.Add(Me.txtAdmin)
        Me.GroupBox1.Controls.Add(Me.txtTanggal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIdPasok)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1175, 256)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.add_to_cart
        Me.PictureBox1.Location = New System.Drawing.Point(925, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'txtNamaPemasok
        '
        Me.txtNamaPemasok.FormattingEnabled = True
        Me.txtNamaPemasok.Location = New System.Drawing.Point(508, 166)
        Me.txtNamaPemasok.Name = "txtNamaPemasok"
        Me.txtNamaPemasok.Size = New System.Drawing.Size(378, 28)
        Me.txtNamaPemasok.TabIndex = 21
        '
        'txtAdmin
        '
        Me.txtAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmin.Location = New System.Drawing.Point(508, 66)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(378, 30)
        Me.txtAdmin.TabIndex = 20
        '
        'txtTanggal
        '
        Me.txtTanggal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTanggal.Location = New System.Drawing.Point(22, 161)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(378, 30)
        Me.txtTanggal.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(503, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 27)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "NAMA PEMASOK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TANGGAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(503, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ADMIN"
        '
        'txtIdPasok
        '
        Me.txtIdPasok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPasok.Location = New System.Drawing.Point(22, 66)
        Me.txtIdPasok.Name = "txtIdPasok"
        Me.txtIdPasok.Size = New System.Drawing.Size(378, 30)
        Me.txtIdPasok.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ID PASOK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ID BARANG"
        '
        'txtIdBarang
        '
        Me.txtIdBarang.FormattingEnabled = True
        Me.txtIdBarang.Location = New System.Drawing.Point(23, 440)
        Me.txtIdBarang.Name = "txtIdBarang"
        Me.txtIdBarang.Size = New System.Drawing.Size(208, 28)
        Me.txtIdBarang.TabIndex = 22
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(264, 440)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(274, 30)
        Me.txtNamaBarang.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(259, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 27)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "NAMA BARANG"
        '
        'txtSatuan
        '
        Me.txtSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.Location = New System.Drawing.Point(570, 440)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(176, 30)
        Me.txtSatuan.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(565, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 27)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "SATUAN"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(786, 440)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(195, 30)
        Me.txtStok.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(781, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 27)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "STOK"
        '
        'tblTambah
        '
        Me.tblTambah.BackColor = System.Drawing.Color.Orange
        Me.tblTambah.FlatAppearance.BorderSize = 0
        Me.tblTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblTambah.Location = New System.Drawing.Point(1019, 440)
        Me.tblTambah.Name = "tblTambah"
        Me.tblTambah.Size = New System.Drawing.Size(179, 30)
        Me.tblTambah.TabIndex = 29
        Me.tblTambah.Text = "TAMBAH"
        Me.tblTambah.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 490)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1175, 447)
        Me.DataGridView1.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Satuan"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Stok"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 188
        '
        'formDataPemasukkanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1214, 966)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tblTambah)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdBarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximumSize = New System.Drawing.Size(1236, 1022)
        Me.Name = "formDataPemasukkanBarang"
        Me.Text = "formDataPemasukkanBarang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tblSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblBatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblKeluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdPasok As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPemasok As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdBarang As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tblTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
