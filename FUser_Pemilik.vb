Public Class FUser_Pemilik

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        f_login.Show()
        Me.Hide()
    End Sub
    
    Private Sub BtnLabaRugi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLabaRugi.Click
        F_LaporanLabaRugi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnNeraca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNeraca.Click
        F_LaporanNeraca.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPerubahanModal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Perubahan Modal
        'Me.Hide()
    End Sub

    Private Sub BtnBukuBesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesar.Click
        FPj_BukuBesar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJurnalPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalPembelian.Click
        FPm_JurnalPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJurnalPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalPenjualan.Click
        FPj_JurnalPenjuala.Show()
        Me.Hide()
    End Sub

    Private Sub JurnalPenerimaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurnalPenerimaan.Click
        FPj_JurnalPenerimaanKas.Show()
        Me.Hide()
    End Sub

    Private Sub JurnalPengeluaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurnalPengeluaran.Click
        FPm_JurnalPengeluaranKas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJurnalUmum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalUmum.Click
        F_JurnalUmum.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInputDataKaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputDataKaryawan.Click
        F_InputDataKaryawan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPiutangDagang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPiutangDagang.Click
        FPj_LaporanPiutangDagang.Show()
        Me.Hide()

    End Sub

    Private Sub BtnInputUtangDagang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputUtangDagang.Click
        FPm_LaporanUtangDagang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUpdateKaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateKaryawan.Click
        F_UpdateDataKaryawan.Show()
        Me.Hide()
    End Sub
End Class