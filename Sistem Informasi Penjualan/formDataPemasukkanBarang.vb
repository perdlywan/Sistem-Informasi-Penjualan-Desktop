Imports MySql.Data.MySqlClient
Public Class formDataPemasukkanBarang
    Dim hitung As Long

    Private Sub formDataPemasukkanBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StrCn = "Database='" & VDatabase & _
                "';Data Source='" & VServer & _
                "';User Id='" & VUser & _
                "';Password='" & VPass & "'"
        cn = New MySqlConnection(StrCn)
        cn.Open()        AutoIdPasok()        txtAdmin.Text = vAdmin        isiComboNamaPemasok()
        isiComboIdBarang()
    End Sub

    Sub isiComboNamaPemasok()
        StrSQL = "SELECT nama_pemasok FROM pemasok"
        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        RdData = MyCommand.ExecuteReader
        While RdData.Read
            txtNamaPemasok.Items.Add(RdData("nama_pemasok"))
        End While

        RdData.Close()
        RdData = Nothing
    End Sub

    Sub isiComboIdBarang()
        StrSQL = "SELECT id_barang FROM barang"
        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        RdData = MyCommand.ExecuteReader
        While RdData.Read
            txtIdBarang.Items.Add(RdData("id_barang"))
        End While

        RdData.Close()
        RdData = Nothing
    End Sub

    Sub Kosong1()
        txtNamaPemasok.Text = ""
        txtIdBarang.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Sub Kosong()
        txtIdBarang.Text = ""
        txtNamaBarang.Text = ""
        txtSatuan.Text = ""
        txtStok.Text = ""
    End Sub

    Private Sub txtIdBarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdBarang.SelectedIndexChanged
        StrSQL = "SELECT * FROM barang WHERE id_barang='" & txtIdBarang.Text & "'"
        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text
        RdData = MyCommand.ExecuteReader
        RdData.Read()

        If RdData.HasRows Then
            txtNamaBarang.Text = RdData.Item("nama_barang")
            txtSatuan.Text = RdData.Item("satuan")
        End If

        RdData.Close()
        RdData = Nothing
    End Sub

    Private Sub tblTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblTambah.Click
        DataGridView1.Rows.Add(New String() {txtIdBarang.Text, txtNamaBarang.Text, txtSatuan.Text, txtStok.Text})
        Kosong()
    End Sub

    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        Me.Dispose()
    End Sub

    Sub SimpanPasok()
        Try
            Dim simpanPasok As String
            simpanPasok = "INSERT INTO pasok VALUES ('" & txtIdPasok.Text & "', '" & Format(txtTanggal.Value.ToString("yyyy-MM-dd")) & "', '" & txtAdmin.Text & "', '" & txtNamaPemasok.Text & "')"
            Dim cmd As New MySqlCommand(simpanPasok, cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Pemasukkan Barang Berhasil Disimpan")

        Catch ex As Exception
            MessageBox.Show("Data Pemasukkan Barang Gagal Disimpan")
        End Try
    End Sub
    
    Sub SimpanDetailPasok()
        For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
            Dim simpanDetailPasok As String = "INSERT INTO pasok_detail VALUES('" & txtIdPasok.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "')"
            Dim cmd As New MySqlCommand(simpanDetailPasok, cn)
            cmd.ExecuteNonQuery()

            StrSQL = "UPDATE barang SET stok = stok + " & DataGridView1.Item(3,
                      Baris).Value & " WHERE id_barang='" & DataGridView1.Item(0, Baris).Value & "'"
            Dim MyCommand1 As New MySqlCommand(StrSQL, cn)
            MyCommand1.ExecuteNonQuery()
        Next

    End Sub

    Sub AutoIdPasok()
        StrSQL = "SELECT id_pasok FROM pasok ORDER BY id_pasok DESC"
        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        RdData = MyCommand.ExecuteReader
        RdData.Read()
        If RdData.HasRows Then
            hitung = Microsoft.VisualBasic.Right(RdData.GetString(0), 3) + 1
            txtIdPasok.Text = "P" + Microsoft.VisualBasic.Right("000" & hitung, 3)

        Else
            txtIdPasok.Text = "P" + "001"
        End If

        RdData.Close()
        RdData = Nothing
    End Sub
        


    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        SimpanPasok()
        SimpanDetailPasok()
        Kosong1()
        AutoIdPasok()
    End Sub

    Private Sub tblBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblBatal.Click
        Kosong()
        Kosong1()
    End Sub
End Class