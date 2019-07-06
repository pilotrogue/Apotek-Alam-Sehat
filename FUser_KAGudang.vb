Public Class FUser_KAGudang

    Private Sub BtnInputObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputObat.Click
        F_InputDataObat.Show()
        Me.Hide()
    End Sub
    Private Sub BtnInputSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputSupplier.Click
        FPm_InputDataSupplier.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLaporanStokBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporanStokBarang.Click
        FPj_LaporanStokBarang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        f_login.Show()
        Me.Hide()
    End Sub

    
    Private Sub BtnUpdateDataSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateDataSupplier.Click
        F_UpdateDataSupplier.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUpdateDataObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateDataObat.Click
        F_UpdateDataObat.Show()
        Me.Hide()
    End Sub
End Class