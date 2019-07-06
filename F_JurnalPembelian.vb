Public Class F_JurnalPembelian

    Private Sub BtnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampilkan.Click
        F_HasilJurnalPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        F_Jurnal.Show()
    End Sub
End Class