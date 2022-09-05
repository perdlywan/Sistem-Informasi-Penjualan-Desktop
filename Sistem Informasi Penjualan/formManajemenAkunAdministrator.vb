Imports MySql.Data.MySqlClient
Public Class formManajemenAkunAdministrator
    Dim brs As Byte
    Dim vUsername As String
    Dim vPassword As String
    Dim vNama As String
    Dim vJenisKelamin As String
    Dim vNoTelp As String
    Dim vAlamat As String
    Dim vEmail As String
   
    Private Sub formManajemenAkunAdministrator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        StrSQL = "SELECT * FROM admin"
        dAdapter = New MySqlDataAdapter(StrSQL, cn)
        dSet = New DataSet
        dSet.Clear()
        dAdapter.Fill(dSet, "admin")
        DataGridView1.DataSource = (dSet.Tables("admin"))        With DataGridView1
            .Columns(0).HeaderText = "Username"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Password"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Nama"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Jenis Kelamin"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "No Telepon"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "Alamat"
            .Columns(5).Width = 150
            .Columns(6).HeaderText = "Email"
            .Columns(6).Width = 150
        End With
    End Sub

    Sub TombolHeader(ByVal Aktif As Boolean)
        tblTambah.Enabled = Aktif
        tblKoreksi.Enabled = Aktif
        tblHapus.Enabled = Aktif
        tblKeluar.Enabled = Aktif
    End Sub


    Sub TextSimpan(ByVal aktif As Boolean)
        txtUsername.Enabled = aktif
        txtPassword.Enabled = aktif
        txtNama.Enabled = aktif
        txtJenisKelamin.Enabled = aktif
        txtNoTelepon.Enabled = aktif
        txtAlamat.Enabled = aktif
        txtEmail.Enabled = aktif

        tblSimpan.Enabled = aktif
        tblBatal.Enabled = aktif
    End Sub

    Private Sub tblTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblTambah.Click
        Status = True
        TombolHeader(False)
        TextSimpan(True)
        DataGridView1.Enabled = False
        txtUsername.Focus()
    End Sub

    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        If Status = True Then
            StrSQL = "INSERT INTO admin VALUES(@username, @password, @nama, @jenis_kelamin, @no_telp, @alamat, @email)"
        Else
            StrSQL = "UPDATE admin SET password=@password, nama=@nama, jenis_kelamin=@jenis_kelamin, no_telp=@no_telp, alamat=@alamat, email=@email WHERE username=@username"
        End If

        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text

        Dim ParameterUsername As MySqlParameter = New MySqlParameter("@username", MySqlDbType.VarChar, 10)
        ParameterUsername.Value = txtUsername.Text

        Dim ParameterPassword As MySqlParameter = New MySqlParameter("@password", MySqlDbType.VarChar, 20)
        ParameterPassword.Value = txtPassword.Text

        Dim ParameterNama As MySqlParameter = New MySqlParameter("@nama", MySqlDbType.VarChar, 50)
        ParameterNama.Value = txtNama.Text

        Dim ParameterJenisKelamin As MySqlParameter = New MySqlParameter("@jenis_kelamin", MySqlDbType.VarChar, 50)
        ParameterJenisKelamin.Value = txtJenisKelamin.Text

        Dim ParameterNoTelepon As MySqlParameter = New MySqlParameter("@no_telp", MySqlDbType.VarChar, 15)
        ParameterNoTelepon.Value = txtNoTelepon.Text

        Dim ParameterAlamat As MySqlParameter = New MySqlParameter("@alamat", MySqlDbType.VarChar, 100)
        ParameterAlamat.Value = txtAlamat.Text

        Dim ParameterEmail As MySqlParameter = New MySqlParameter("@email", MySqlDbType.VarChar, 50)
        ParameterEmail.Value = txtEmail.Text

        With MyCommand.Parameters
            .Add(ParameterUsername)
            .Add(ParameterPassword)
            .Add(ParameterNama)
            .Add(ParameterJenisKelamin)
            .Add(ParameterNoTelepon)
            .Add(ParameterAlamat)
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
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtNama.Text = ""
        txtJenisKelamin.Text = ""
        txtNoTelepon.Text = ""
        txtAlamat.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub tblKoreksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKoreksi.Click
        Status = False
        brs = Me.DataGridView1.CurrentRow.Index
        vUsername = Me.DataGridView1.Item(0, brs).Value
        StrSQL = "SELECT * FROM admin WHERE username='" &
       Trim(vUsername) & "'"

        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text
        RdData = MyCommand.ExecuteReader
        While RdData.Read
            vPassword = RdData.Item("password")
            vNama = RdData.Item("nama")
            vJenisKelamin = RdData.Item("jenis_kelamin")
            vNoTelp = RdData.Item("no_telp")
            vAlamat = RdData.Item("alamat")
            vEmail = RdData.Item("email")
        End While
        RdData.Close()
        RdData = Nothing

        txtUsername.Text = vUsername
        txtPassword.Text = vPassword
        txtNama.Text = vNama
        txtJenisKelamin.Text = vJenisKelamin
        txtNoTelepon.Text = vNoTelp
        txtAlamat.Text = vAlamat
        txtEmail.Text = vEmail

        TombolHeader(False)
        TextSimpan(True)
        DataGridView1.Enabled = False
        txtUsername.Enabled = False
    End Sub

    Private Sub tblHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblHapus.Click
        Dim Pesan As Integer

        brs = Me.DataGridView1.CurrentRow.Index
        vUsername = Me.DataGridView1.Item(0, brs).Value

        Pesan = MessageBox.Show("Apakah Data Admin " & vUsername & " akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo)
        If Pesan = vbYes Then
            StrSQL = "DELETE FROM admin WHERE username='" &
           Trim(vUsername) & "'"
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