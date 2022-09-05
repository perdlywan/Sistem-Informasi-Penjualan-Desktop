<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCariBarang
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tblOk = New System.Windows.Forms.Button()
        Me.RdCari1 = New System.Windows.Forms.RadioButton()
        Me.RdCari2 = New System.Windows.Forms.RadioButton()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.tblCari = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1011, 71)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ".:: CARI DATA BARANG ::."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1011, 412)
        Me.DataGridView1.TabIndex = 2
        '
        'tblOk
        '
        Me.tblOk.BackColor = System.Drawing.Color.Lime
        Me.tblOk.FlatAppearance.BorderSize = 0
        Me.tblOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblOk.Location = New System.Drawing.Point(866, 544)
        Me.tblOk.Name = "tblOk"
        Me.tblOk.Size = New System.Drawing.Size(157, 63)
        Me.tblOk.TabIndex = 4
        Me.tblOk.Text = "OK"
        Me.tblOk.UseVisualStyleBackColor = False
        '
        'RdCari1
        '
        Me.RdCari1.AutoSize = True
        Me.RdCari1.Location = New System.Drawing.Point(21, 38)
        Me.RdCari1.Name = "RdCari1"
        Me.RdCari1.Size = New System.Drawing.Size(104, 24)
        Me.RdCari1.TabIndex = 0
        Me.RdCari1.TabStop = True
        Me.RdCari1.Text = "Id Barang"
        Me.RdCari1.UseVisualStyleBackColor = True
        '
        'RdCari2
        '
        Me.RdCari2.AutoSize = True
        Me.RdCari2.Location = New System.Drawing.Point(156, 39)
        Me.RdCari2.Name = "RdCari2"
        Me.RdCari2.Size = New System.Drawing.Size(132, 24)
        Me.RdCari2.TabIndex = 1
        Me.RdCari2.TabStop = True
        Me.RdCari2.Text = "Nama Barang"
        Me.RdCari2.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(294, 37)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(396, 26)
        Me.txtCari.TabIndex = 2
        '
        'tblCari
        '
        Me.tblCari.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblCari.FlatAppearance.BorderSize = 0
        Me.tblCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCari.Image = Global.Sistem_Informasi_Penjualan.My.Resources.Resources.loupe
        Me.tblCari.Location = New System.Drawing.Point(709, 19)
        Me.tblCari.Name = "tblCari"
        Me.tblCari.Size = New System.Drawing.Size(133, 63)
        Me.tblCari.TabIndex = 3
        Me.tblCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblCari.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tblCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.RdCari2)
        Me.GroupBox1.Controls.Add(Me.RdCari1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 525)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 88)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'formCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1035, 625)
        Me.Controls.Add(Me.tblOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formCariBarang"
        Me.Text = "formCariBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tblOk As System.Windows.Forms.Button
    Friend WithEvents RdCari1 As System.Windows.Forms.RadioButton
    Friend WithEvents RdCari2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents tblCari As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
