Public Class F_Laporan

    Private Sub BtnLaporanTagihanUtang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporanTagihanUtang.Click
        F_LaporanTagihanUtang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenjualan.Click
        Me.Hide()
        F_LaporanStokAkhir.Show()
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        F_Pembelian.Show()
        Me.Hide()
    End Sub
End Class