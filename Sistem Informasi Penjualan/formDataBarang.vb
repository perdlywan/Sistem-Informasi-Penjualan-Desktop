Imports MySql.Data.MySqlClient
Public Class formDataBarang
    Dim hitung As Long
    Dim brs As Byte
    Dim vIdBarang As String
    Dim vNamaBarang As String
    Dim vStok As Integer
    Dim vHarga As Single
    Dim vSatuan As String
    Private Sub formDataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
        DataGridView1.Focus()
    End Sub

    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        Me.Dispose()
    End Sub

    Sub TampilData()
        StrCn = "Database='" & VDatabase & _
        "';Data Source='" & VServer & _
        "';User Id='" & VUser & _
        "';Password='" & VPass & "'"

        cn = New MySqlConnection(StrCn)
        cn.Open()

        StrSQL = "SELECT * FROM barang"
        dAdapter = New MySqlDataAdapter(StrSQL, cn)
        dSet = New DataSet
        dSet.Clear()
        dAdapter.Fill(dSet, "barang")
        DataGridView1.DataSource = (dSet.Tables("barang"))        With DataGridView1
            .Columns(0).HeaderText = "ID Barang"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Stok"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "Harga"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Satuan"
            .Columns(4).Width = 100
        End With

    End Sub

    Sub TombolHeader(ByVal Aktif As Boolean)
        tblTambah.Enabled = Aktif
        tblKoreksi.Enabled = Aktif
        tblHapus.Enabled = Aktif
        tblKeluar.Enabled = Aktif
    End Sub

    Sub TextSimpan(ByVal aktif As Boolean)
        txtIdBarang.Enabled = aktif
        txtHarga.Enabled = aktif
        txtNamaBarang.Enabled = aktif
        txtStok.Enabled = aktif
        txtSatuan.Enabled = aktif

        tblSimpan.Enabled = aktif
        tblBatal.Enabled = aktif
    End Sub
    Private Sub tblTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblTambah.Click
        Status = True
        TombolHeader(False)
        TextSimpan(True)
        DataGridView1.Enabled = False
        txtIdBarang.Focus()
    End Sub

    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        If Status = True Then
            StrSQL = "INSERT INTO barang VALUES(@id_barang, @nama_barang, @stok, @harga, @satuan)"
        Else
            StrSQL = "UPDATE barang SET nama_barang=@nama_barang, stok=@stok, harga=@harga, satuan=@satuan WHERE id_barang=@id_barang"
        End If

        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text

        Dim ParameterIdBarang As MySqlParameter = New MySqlParameter("@id_barang", MySqlDbType.VarChar, 10)
        ParameterIdBarang.Value = txtIdBarang.Text

        Dim ParameterNamaBarang As MySqlParameter = New MySqlParameter("@nama_barang", MySqlDbType.VarChar, 50)
        ParameterNamaBarang.Value = txtNamaBarang.Text

        Dim ParameterStok As MySqlParameter = New MySqlParameter("@stok", MySqlDbType.VarChar, 100)
        ParameterStok.Value = txtStok.Text

        Dim ParameterHarga As MySqlParameter = New MySqlParameter("@harga", MySqlDbType.VarChar, 100)
        ParameterHarga.Value = txtHarga.Text

        Dim ParameterSatuan As MySqlParameter = New MySqlParameter("@satuan", MySqlDbType.Enum)
        ParameterSatuan.Value = txtSatuan.Text

        With MyCommand.Parameters
            .Add(ParameterIdBarang)
            .Add(ParameterNamaBarang)
            .Add(ParameterStok)
            .Add(ParameterHarga)
            .Add(ParameterSatuan)
        End With
        RdData = MyCommand.ExecuteReader
        TextSimpan(False)
        TombolHeader(True)
        Kosong()
        DataGridView1.Enabled = True
        TampilData()

    End Sub

    Sub Kosong()
        txtIdBarang.Text = ""
        txtNamaBarang.Text = ""
        txtStok.Text = ""
        txtHarga.Text = ""
        txtSatuan.Text = ""
    End Sub

    Private Sub tblKoreksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKoreksi.Click
        Status = False
        brs = Me.DataGridView1.CurrentRow.Index
        vIdBarang = Me.DataGridView1.Item(0, brs).Value
        StrSQL = "SELECT * FROM barang WHERE id_barang='" &
       Trim(vIdBarang) & "'"

        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text
        RdData = MyCommand.ExecuteReader
        While RdData.Read
            vNamaBarang = RdData.Item("nama_barang")
            vStok = RdData.Item("stok")
            vHarga = RdData.Item("harga")
            vSatuan = RdData.Item("satuan")
        End While
        RdData.Close()
        RdData = Nothing

        txtIdBarang.Text = vIdBarang
        txtNamaBarang.Text = vNamaBarang
        txtStok.Text = vStok
        txtHarga.Text = vHarga
        txtSatuan.Text = vSatuan

        TombolHeader(False)
        TextSimpan(True)
        txtIdBarang.Enabled = False
        DataGridView1.Enabled = False
    End Sub

    Private Sub tblHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblHapus.Click
        Dim Pesan As Integer

        brs = Me.DataGridView1.CurrentRow.Index
        vIdBarang = Me.DataGridView1.Item(0, brs).Value

        Pesan = MessageBox.Show("Apakah Data Barang " & vIdBarang & " akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo)
        If Pesan = vbYes Then
            StrSQL = "DELETE FROM barang WHERE id_barang='" &
           Trim(vIdBarang) & "'"
            Dim MyCommand As New MySqlCommand(StrSQL, cn)
            MyCommand.ExecuteNonQuery()
            TampilData()
        End If
    End Sub

    Private Sub tblBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblBatal.Click
        Kosong()
        TombolHeader(True)
        TextSimpan(False)
    End Sub

    
End Class