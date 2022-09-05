Imports MySql.Data.MySqlClient
Public Class formDataPemasok
    Dim brs As Byte
    Dim vNamaPemasok As String
    Dim vNoTelepon As String
    Dim vAlamat As String
    Dim vKota As String
    Dim vKodePos As String
    Dim vEmail As String
    Private Sub formDataPemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        StrSQL = "SELECT * FROM pemasok"
        dAdapter = New MySqlDataAdapter(StrSQL, cn)
        dSet = New DataSet
        dSet.Clear()
        dAdapter.Fill(dSet, "pemasok")
        DataGridView1.DataSource = (dSet.Tables("pemasok"))        With DataGridView1
            .Columns(0).HeaderText = "Nama Pemasok"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "No Telepon"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Alamat"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Kota"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Kode Pos"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Email"
            .Columns(5).Width = 150
        End With
    End Sub

    Sub TombolHeader(ByVal Aktif As Boolean)
        tblTambah.Enabled = Aktif
        tblKoreksi.Enabled = Aktif
        tblHapus.Enabled = Aktif
        tblKeluar.Enabled = Aktif
    End Sub

    Sub TextSimpan(ByVal aktif As Boolean)
        txtNamaPemasok.Enabled = aktif
        txtEmail.Enabled = aktif
        txtNoTelepon.Enabled = aktif
        txtAlamat.Enabled = aktif
        txtKota.Enabled = aktif
        txtKodePos.Enabled = aktif

        tblSimpan.Enabled = aktif
        tblBatal.Enabled = aktif
    End Sub

    Private Sub tblTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblTambah.Click
        Status = True
        TombolHeader(False)
        TextSimpan(True)
        DataGridView1.Enabled = False
        txtNamaPemasok.Focus()
    End Sub

    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        If Status = True Then
            StrSQL = "INSERT INTO pemasok VALUES(@nama_pemasok, @no_telepon, @alamat, @kota, @kode_pos, @email)"
        Else
            StrSQL = "UPDATE pemasok SET no_telepon=@no_telepon, alamat=@alamat, kota=@kota, kode_pos=@kode_pos, email=@email WHERE nama_pemasok=@nama_pemasok"
        End If

        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text

        Dim ParameterNamaPemasok As MySqlParameter = New MySqlParameter("@nama_pemasok", MySqlDbType.VarChar, 50)
        ParameterNamaPemasok.Value = txtNamaPemasok.Text

        Dim ParameterNoTelepon As MySqlParameter = New MySqlParameter("@no_telepon", MySqlDbType.VarChar, 13)
        ParameterNoTelepon.Value = txtNoTelepon.Text

        Dim ParameterAlamat As MySqlParameter = New MySqlParameter("@alamat", MySqlDbType.VarChar, 100)
        ParameterAlamat.Value = txtAlamat.Text

        Dim ParameterKota As MySqlParameter = New MySqlParameter("@kota", MySqlDbType.VarChar, 100)
        ParameterKota.Value = txtKota.Text

        Dim ParameterKodePos As MySqlParameter = New MySqlParameter("@kode_pos", MySqlDbType.VarChar, 5)
        ParameterKodePos.Value = txtKodePos.Text

        Dim ParameterEmail As MySqlParameter = New MySqlParameter("@email", MySqlDbType.VarChar, 30)
        ParameterEmail.Value = txtEmail.Text

        With MyCommand.Parameters
            .Add(ParameterNamaPemasok)
            .Add(ParameterNoTelepon)
            .Add(ParameterAlamat)
            .Add(ParameterKota)
            .Add(ParameterKodePos)
            .Add(ParameterEmail)
        End With
        RdData = MyCommand.ExecuteReader
        TextSimpan(False)
        TombolHeader(True)
        Kosong()
        DataGridView1.Enabled = True
        TampilData()

    End Sub

    Sub Kosong()
        txtNamaPemasok.Text = ""
        txtNoTelepon.Text = ""
        txtAlamat.Text = ""
        txtKota.Text = ""
        txtKodePos.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub tblKoreksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKoreksi.Click
        Status = False
        brs = Me.DataGridView1.CurrentRow.Index
        vNamaPemasok = Me.DataGridView1.Item(0, brs).Value
        StrSQL = "SELECT * FROM pemasok WHERE nama_pemasok='" &
       Trim(vNamaPemasok) & "'"

        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text
        RdData = MyCommand.ExecuteReader
        While RdData.Read
            vNoTelepon = RdData.Item("no_telepon")
            vAlamat = RdData.Item("alamat")
            vKota = RdData.Item("kota")
            vKodePos = RdData.Item("kode_pos")
            vEmail = RdData.Item("email")
        End While
        RdData.Close()
        RdData = Nothing

        txtNamaPemasok.Text = vNamaPemasok
        txtNoTelepon.Text = vNoTelepon
        txtAlamat.Text = vAlamat
        txtKota.Text = vKota
        txtKodePos.Text = vKodePos
        txtEmail.Text = vEmail

        TombolHeader(False)
        TextSimpan(True)
        DataGridView1.Enabled = False
        txtNamaPemasok.Enabled = False
    End Sub

    Private Sub tblHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblHapus.Click
        Dim Pesan As Integer

        brs = Me.DataGridView1.CurrentRow.Index
        vNamaPemasok = Me.DataGridView1.Item(0, brs).Value

        Pesan = MessageBox.Show("Apakah Data Pemasok " & vNamaPemasok & " akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo)
        If Pesan = vbYes Then
            StrSQL = "DELETE FROM pemasok WHERE nama_pemasok='" &
           Trim(vNamaPemasok) & "'"
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