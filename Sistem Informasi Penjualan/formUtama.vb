Public Class formUtama

    Private Sub formUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dddd, d MMMM yyyy")
        Label5.Text = Date.Now.ToString("H:mm:ss tt")
    End Sub

    Private Sub btnDataMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataMaster.Click
        indicatorDataMaster.Visible = True
        indicatorTransaksi.Visible = False
        indicatorLaporan.Visible = False
        indicatorAdmin.Visible = False
        indicatorLogout.Visible = False

        panelDataMaster.Visible = True
        panelTransaksi.Visible = False
        panelLaporan.Visible = False
        panelAdmin.Visible = False
        panelLogout.visible = False
    End Sub

    Private Sub btnTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksi.Click
        indicatorDataMaster.Visible = False
        indicatorTransaksi.Visible = True
        indicatorLaporan.Visible = False
        indicatorAdmin.Visible = False
        indicatorLogout.Visible = False

        panelDataMaster.Visible = False
        panelTransaksi.Visible = True
        panelLaporan.Visible = False
        panelAdmin.Visible = False
        panelLogout.visible = False
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        indicatorDataMaster.Visible = False
        indicatorTransaksi.Visible = False
        indicatorLaporan.Visible = True
        indicatorAdmin.Visible = False
        indicatorLogout.Visible = False

        panelDataMaster.Visible = False
        panelTransaksi.Visible = False
        panelLaporan.Visible = True
        panelAdmin.Visible = False
        panelLogout.visible = False
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        indicatorDataMaster.Visible = False
        indicatorTransaksi.Visible = False
        indicatorLaporan.Visible = False
        indicatorAdmin.Visible = True
        indicatorLogout.Visible = False


        panelDataMaster.Visible = False
        panelTransaksi.Visible = False
        panelLaporan.Visible = False
        panelAdmin.Visible = True
        panelLogout.visible = False
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        indicatorDataMaster.Visible = False
        indicatorTransaksi.Visible = False
        indicatorLaporan.Visible = False
        indicatorAdmin.Visible = False
        indicatorLogout.Visible = True

        panelDataMaster.Visible = False
        panelTransaksi.Visible = False
        panelLaporan.Visible = False
        panelAdmin.Visible = False
        panelLogout.visible = True
    End Sub

    Private Sub btnDataBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataBarang.Click
        formDataBarang.Show()
    End Sub

    Private Sub btnDataPemasok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataPemasok.Click
        formDataPemasok.Show()
    End Sub

    Private Sub btnManajemenAkunAdministrator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManajemenAkunAdministrator.Click
        formManajemenAkunAdministrator.show()
    End Sub

    Private Sub btnDataPemasukkanBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataPemasukkanBarang.Click
        formDataPemasukkanBarang.show()
    End Sub

    Private Sub btnTransaksiPembelianBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksiPembelianBarang.Click
        formTransaksi.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
        formLogin.Show()
        formLogin.txtUsername.Text = ""
        formLogin.txtPassword.Text = ""
    End Sub

    Private Sub btnLaporanStokBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporanStokBarang.Click
        AxCrystalReport1.ReportFileName = "LaporanStokBarang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btnLaporanPemasukkanBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporanPemasukkanBarang.Click
        AxCrystalReport1.ReportFileName = "LaporanPemasukkanBarang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btnLaporanTransaksiPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporanTransaksiPembelian.Click
        AxCrystalReport1.ReportFileName = "LaporanTransaksiPembelian.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class