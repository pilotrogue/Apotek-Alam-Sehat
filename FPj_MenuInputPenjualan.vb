Public Class FPj_MenuInputPenjualan

    Private Sub btnInputCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputCustomer.Click
        FPj_InputDataCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInputPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputPenjualan.Click
        FPj_InputDataPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInputPelunasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FPj_InputDataPelunasan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        'F_Penjualan.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnInputPelunasan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputPelunasan.Click
        FPj_InputDataPelunasan.Show()
        Me.Hide()
    End Sub

    Private Sub FPj_MenuInputPenjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class