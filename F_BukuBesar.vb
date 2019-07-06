Public Class F_BukuBesar

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        F_Pembelian.Show()
    End Sub

    Private Sub btnBukuBesarKas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBukuBesarKas.Click
        Me.Hide()
        F_BukuBesarKas.Show()
    End Sub

    Private Sub btnBukuBesarPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBukuBesarPembelian.Click
        Me.Hide()
        F_BukuBesarPembelian.Show()
    End Sub

    Private Sub BtnBukuBesarDiskon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesarDiskon.Click
        Me.Hide()
        F_BukuBesarDiskon.Show()
    End Sub

    Private Sub BtnBukuBesarPembantuUtang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesarPembantuUtang.Click
        Me.Hide()
        F_BukuBesarPembantuUtang.Show()
    End Sub

    Private Sub BtnBukuBesarUtang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesarUtang.Click
        Me.Hide()
        F_BukuBesarUtang.Show()
    End Sub
End Class