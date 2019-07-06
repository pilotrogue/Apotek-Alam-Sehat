Public Class FPm_BukuBesar

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        If rolePegawai = "pemilik" Then
            Me.Hide()
            FUser_Pemilik.Show()
        End If

        If rolePegawai = "akuntan" Then
            Me.Hide()
            FUser_Akuntan.Show()
        End If
    End Sub

    Private Sub btnBukuBesarKas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBukuBesarKas.Click
        Me.Hide()
        FPm_BukuBesarKas.Show()
    End Sub

    Private Sub btnBukuBesarPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBukuBesarPembelian.Click
        Me.Hide()
        FPm_BukuBesarPembelian.Show()
    End Sub

    Private Sub BtnBukuBesarDiskon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesarDiskon.Click
        Me.Hide()
        FPm_BukuBesarDiskon.Show()
    End Sub

    Private Sub BtnBukuBesarPembantuUtang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesarPembantuUtang.Click
        Me.Hide()
        FPm_BukuBesarPembantuUtang.Show()
    End Sub

    Private Sub BtnBukuBesarUtang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBukuBesarUtang.Click
        Me.Hide()
        FPm_BukuBesarUtang.Show()
    End Sub

    Private Sub FPm_BukuBesar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class