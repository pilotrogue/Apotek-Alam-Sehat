Public Class F_MenuInputPenjualan

    Private Sub btnInputCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputCustomer.Click
        F_InputDataCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInputPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputPenjualan.Click
        F_InputDataPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInputPelunasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_InputDataPelunasan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        F_Pembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInputPelunasan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputPelunasan.Click
        F_InputDataPelunasan.Show()
        Me.Hide()
    End Sub
End Class