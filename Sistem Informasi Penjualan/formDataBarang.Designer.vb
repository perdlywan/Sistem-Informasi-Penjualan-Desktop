<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtSatuan = New System.Windows.Forms.ComboBox()
        Me.txtIdBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tblTambah = New System.Windows.Forms.ToolStripButton()
        Me.tblKoreksi = New System.Windows.Forms.ToolStripButton()
        Me.tblHapus = New System.Windows.Forms.ToolStripButton()
        Me.tblKeluar = New System.Windows.Forms.ToolStripButton()
        Me.tblBatal = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1522, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ".:: DATA BARANG ::."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamaBarang)
        Me.GroupBox1.Controls.Add(Me.txtSatuan)
        Me.GroupBox1.Controls.Add(Me.txtIdBarang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 602)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(35, 196)
        Me.txtNamaBarang.Multiline = True
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(378, 42)
        Me.txtNamaBarang.TabIndex = 3
        '
        'txtSatuan
        '
        Me.txtSatuan.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.FormattingEnabled = True
        Me.txtSatuan.Items.AddRange(New Object() {"Pcs", "Box", "Slop"})
        Me.txtSatuan.Location = New System.Drawing.Point(35, 511)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(378, 32)
        Me.txtSatuan.TabIndex = 9
        '
        'txtIdBarang
        '
        Me.txtIdBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdBarang.Location = New System.Drawing.Point(35, 92)
        Me.txtIdBarang.Multiline = True
        Me.txtIdBarang.Name = "txtIdBarang"
        Me.txtIdBarang.Size = New System.Drawing.Size(378, 42)
        Me.txtIdBarang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID BARANG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 41)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SATUAN"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(35, 405)
        Me.txtHarga.Multiline = True
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(378, 42)
        Me.txtHarga.TabIndex = 7
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(35, 299)
        Me.txtStok.Multiline = True
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(378, 42)
        Me.txtStok.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 41)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "HARGA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "STOK"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(495, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1039, 671)
        Me.DataGridView1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tblTambah, Me.tblKoreksi, Me.tblHapus, Me.tblKeluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1545, 32)
        Me.ToolStrip1.TabIndex = 3
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
        'tblBatal
        '
        Me.tblBatal.BackColor = System.Drawing.Color.Red
        Me.tblBatal.FlatAppearance.BorderSize = 0
        Me.tblBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblBatal.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.warning
        Me.tblBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBatal.Location = New System.Drawing.Point(248, 799)
        Me.tblBatal.Name = "tblBatal"
        Me.tblBatal.Size = New System.Drawing.Size(211, 48)
        Me.tblBatal.TabIndex = 6
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
        Me.tblSimpan.Location = New System.Drawing.Point(12, 799)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(211, 48)
        Me.tblSimpan.TabIndex = 5
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'formDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1545, 868)
        Me.Controls.Add(Me.tblBatal)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1567, 924)
        Me.Name = "formDataBarang"
        Me.Text = "formDataBarang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tblTambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblKoreksi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblHapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblKeluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblBatal As System.Windows.Forms.Button
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
End Class
