Public Class F_Input_Pembelian

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        F_Pembelian.Show()
    End Sub

    Private Sub BtnInputSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputSupplier.Click
        Me.Hide()
        F_InputDataSupplier.Show()
    End Sub

    Private Sub BtnInputPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputPembelian.Click
        Me.Hide()
        F_InputDataPembelian.Show()
    End Sub

    Private Sub BtnInputPelunasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputPelunasan.Click
        Me.Hide()
        F_BuktiPengeluaranKas.Show()
    End Sub
End Class