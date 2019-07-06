Public Class FUser_Kasir

    Private Sub BtnPemblian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPemblian.Click
        FPm_InputDataPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenjualan.Click
        FPj_InputDataPenjualan.Show()
        Me.Hide()
    End Sub
    
    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        f_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FPj_InputDataCustomer.Show()
        Me.Hide()
    End Sub

    'Private Sub BtnPelunasanPiutang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Form input pelunasan piutang belum dimasukkin
    '    Me.Hide()
    'End Sub

    'Private Sub BtnPembayaranUtang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Form input pembayaran utang belom dimasukkin
    '    Me.Hide()
    'End Sub

    Private Sub BtnUpdateDataCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateDataCustomer.Click
        FPj_UpdateDataCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPembelianHarian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPembelianHarian.Click
        F_PembelianHarian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPenjualanHarian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenjualanHarian.Click
        F_PenjualanHarian.Show()
        Me.Hide()
    End Sub
End Class