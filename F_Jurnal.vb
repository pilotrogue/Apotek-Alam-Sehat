Public Class F_Jurnal

    Private Sub BtnJurnalPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalPembelian.Click
        F_JurnalPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJurnalPengeluaranKas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalPengeluaranKas.Click
        F_JurnalPengeluaranKas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        F_Pembelian.Show()
    End Sub
End Class