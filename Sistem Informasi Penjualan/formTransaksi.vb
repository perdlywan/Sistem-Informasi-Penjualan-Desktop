Imports MySql.Data.MySqlClient
Public Class formTransaksi
    Dim vTotal As Integer
    Dim vKembali As Integer
    Dim hitung As Long


    Private Sub formTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StrCn = "Database='" & VDatabase & _
                "';Data Source='" & VServer & _
                "';User Id='" & VUser & _
                "';Password='" & VPass & "'"
        cn = New MySqlConnection(StrCn)
        cn.Open()

        AutoNomorTransaksi()
        txtAdmin.Text = vAdmin
        txtTotal.Text = 0
        txtBayar.Text = 0
        txtKembalian.Text = 0
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim VTot As Integer

        Select Case DataGridView1.CurrentCell.ColumnIndex
            Case Is = 0
                StrSQL = "Select * From barang Where id_barang='" & _
                DataGridView1.CurrentRow.Cells(0).Value & "'"
                Dim MyCommand As New MySqlCommand(StrSQL, cn)
                MyCommand.CommandType = CommandType.Text
                RdData = MyCommand.ExecuteReader
                If RdData.Read = True Then
                    DataGridView1.CurrentRow.Cells(0).Value = RdData.Item("id_barang")
                    DataGridView1.CurrentRow.Cells(1).Value = RdData.Item("nama_barang")
                    DataGridView1.CurrentRow.Cells(2).Value = RdData.Item("harga")
                Else
                    MsgBox("Data Barang tidak ditemukan")
                    DataGridView1.Focus()
                End If
                RdData.Close()
                RdData = Nothing

            Case Is = 3
                Dim vHarga As Integer
                Dim vBanyak As Integer
                vHarga = DataGridView1.CurrentRow.Cells(2).Value
                vBanyak = DataGridView1.CurrentRow.Cells(3).Value
                VTot = vHarga * vBanyak
                DataGridView1.CurrentRow.Cells(4).Value = FormatNumber(VTot, 0)
                vTotal = vTotal + VTot
                txtTotal.Text = FormatNumber(vTotal, 0)
        End Select
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        Select Case e.KeyCode
            Case Is = Keys.F1
                formCariBarang.ShowDialog()
            Case Is = Keys.End
                txtBayar.Text = ""
                txtBayar.Focus()
        End Select
    End Sub

    Private Sub txtBayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            vKembali = txtBayar.Text - txtTotal.Text
            txtKembalian.Text = FormatNumber(vKembali, 0)
        End If
    End Sub

    Private Sub txtBayar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.Leave
        vKembali = txtBayar.Text - txtTotal.Text
        txtKembalian.Text = FormatNumber(vKembali, 0)
    End Sub

    Sub SimpanTransaksi()

        Try
            StrSQL = "INSERT INTO transaksi VALUES ('" & txtNoTransaksi.Text & "','" & txtAdmin.Text & "', '" & Format(txtTanggal.Value.ToString("yyyy-MM-dd")) & "', '" & txtTotal.Text & "', '" & txtBayar.Text & "', '" & txtKembalian.Text & "')"
            Dim cmd As New MySqlCommand(StrSQL, cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Transaksi Berhasil Disimpan")
        Catch ex As Exception
            MessageBox.Show("Data Transaksi Gagal Disimpan")
        End Try
        

    End Sub

    Sub SimpanTransaksiDetail()
        Dim TotBaris As Integer
        Dim vId As String
        Dim vNama As String
        Dim vHarga As Integer
        Dim vBanyak As Integer
        Dim vJumlah As Integer

        TotBaris = DataGridView1.RowCount - 2
        For Baris = 0 To TotBaris
            vId = DataGridView1.Item(0, Baris).Value
            vNama = DataGridView1.Item(1, Baris).Value
            vHarga = DataGridView1.Item(2, Baris).Value
            vBanyak = DataGridView1.Item(3, Baris).Value
            vJumlah = DataGridView1.Item(4, Baris).Value

            StrSQL = "INSERT INTO transaksi_detail VALUES ('" & txtNoTransaksi.Text & "','" & vId & "', '" & vNama & "', '" & vHarga & "', '" & vBanyak & "', '" & vJumlah & "')"
            Dim MyCommand As New MySqlCommand(StrSQL, cn)
            MyCommand.ExecuteNonQuery()

            StrSQL = "UPDATE barang SET stok = stok - " & DataGridView1.Item(3,
           Baris).Value & " WHERE id_barang='" & DataGridView1.Item(0, Baris).Value & "'"
            Dim MyCommand1 As New MySqlCommand(StrSQL, cn)
            MyCommand1.ExecuteNonQuery()
        Next
    End Sub

    Sub AutoNomorTransaksi()
        StrSQL = "SELECT no_transaksi from transaksi ORDER BY no_transaksi DESC"
        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        RdData = MyCommand.ExecuteReader
        RdData.Read()
        If RdData.HasRows Then
            hitung = Microsoft.VisualBasic.Right(RdData.GetString(0), 3) + 1
            txtNoTransaksi.Text = Microsoft.VisualBasic.Right("000" & hitung, 3)
        Else
            txtNoTransaksi.Text = "001"
        End If


        RdData.Close()
        RdData = Nothing
    End Sub

    Sub Kosong()
        AutoNomorTransaksi()
        txtTotal.Text = 0
        txtBayar.Text = 0
        txtKembalian.Text = 0
        DataGridView1.Rows.Clear()
        vTotal = 0
    End Sub

    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        SimpanTransaksi()
        SimpanTransaksiDetail()
        Kosong()
    End Sub

    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub tblBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblBatal.Click
        Kosong()
    End Sub

    Private Sub tblCetakStruk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblCetakStruk.Click
        If MessageBox.Show("Apakah ingin cetak struk...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            AxCrystalReport1.ReportFileName = "Struk.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    
End Class