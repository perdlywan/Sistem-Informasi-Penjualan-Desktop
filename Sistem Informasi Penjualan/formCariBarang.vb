Imports MySql.Data.MySqlClient
Public Class formCariBarang
    Dim vCari As String
    Private Sub formCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RdCari1.Checked = False
        RdCari2.Checked = False
        txtCari.Text = ""
        TampilData()
    End Sub

    Sub TampilData()
        If RdCari1.Checked = True Then
            vCari = "WHERE id_barang like '%" & txtCari.Text & "%'"
        ElseIf RdCari2.Checked = True Then
            vCari = "WHERE nama_barang like '%" & txtCari.Text & "%'"
        Else
            vCari = ""
        End If        StrSQL = "SELECT * FROM barang " & vCari
        dAdapter = New MySqlDataAdapter(StrSQL, cn)
        dSet = New DataSet
        dSet.Clear()
        dAdapter.Fill(dSet, "barang")
        DataGridView1.DataSource = (dSet.Tables("barang"))

        With DataGridView1
            .Columns(0).Width = 100
            .Columns(1).Width = 230
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 100
        End With
    End Sub

    Sub TampilKeTransaksi()
        Dim vid As String
        Brs = DataGridView1.CurrentRow.Index
        vid = DataGridView1.Item(0, Brs).Value
        StrSQL = "SELECT * FROM barang WHERE id_barang='" & vid & "'"
        Dim MyCommand As New MySqlCommand(StrSQL, cn)
        MyCommand.CommandType = CommandType.Text
        RdData = MyCommand.ExecuteReader
        RdData.Read()
        With formTransaksi
            .DataGridView1.CurrentRow.Cells(0).Value = vid
            .DataGridView1.CurrentRow.Cells(1).Value = RdData.Item("nama_barang")
            .DataGridView1.CurrentRow.Cells(2).Value = RdData.Item("harga")
        End With
        RdData.Close()
        RdData = Nothing
        Me.Hide()
    End Sub

    Private Sub tblCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblCari.Click
        TampilData()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TampilKeTransaksi()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TampilKeTransaksi()
        End If
    End Sub

    
    Private Sub tblOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblOk.Click
        TampilKeTransaksi()
    End Sub
End Class