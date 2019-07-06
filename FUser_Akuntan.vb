Public Class FUser_Akuntan

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        f_login.Show()
        Me.Hide()
    End Sub

    
    Private Sub BtnInputJurnal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputJurnal.Click
        F_InputJurnal.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBukuBesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesar.Click
        FPj_BukuBesar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLaporanLabaRugi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporanLabaRugi.Click
        F_LaporanLabaRugi.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonLaporanNeraca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLaporanNeraca.Click
        F_LaporanNeraca.Show()
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

    Private Sub BtnJurnalPenerimaanKas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalPenerimaanKas.Click
        FPj_JurnalPenerimaanKas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJurnalPengeluaranKas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalPengeluaranKas.Click
        FPm_JurnalPengeluaranKas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJurnalUmum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJurnalUmum.Click
        F_JurnalUmum.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLaporanPiutangDagang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporanPiutangDagang.Click
        FPj_LaporanPiutangDagang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLaporanUtangDagang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporanUtangDagang.Click
        FPm_LaporanUtangDagang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLaporanUntungRugi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporanUntungRugi.Click
        'laporan untung rugi belum ada
        'Me.Hide()
    End Sub
End Class