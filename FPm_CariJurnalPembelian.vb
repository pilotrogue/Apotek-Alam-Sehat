Imports System.Data.OleDb
Public Class FPm_CariJurnalPembelian

    Private Sub BtnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampilkan.Click
        Dim tglAwalStr = tglAwalDTP.Value.ToString("MM/dd/yyyy")
        Dim tglAkhirStr = tglAkhirDTP.Value.ToString("MM/dd/yyyy")

        'MsgBox(tglAwalStr + " " + tglAkhirStr)

        Dim hasilJurnalPembelianForm As New FPm_JurnalPembelian
        hasilJurnalPembelianForm.tglAwalPass = tglAwalStr
        hasilJurnalPembelianForm.tglAkhirPass = tglAkhirStr
        hasilJurnalPembelianForm.Show()
        'F_HasilJurnalPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FPm_JurnalPembelian.Show()
    End Sub

    Private Sub FPm_CariJurnalPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tglAwalDTP.Value = Date.Now
        tglAkhirDTP.Value = Date.Now
    End Sub
End Class