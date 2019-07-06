Imports System.Data.OleDb
Public Class FPj_LaporanStokBarang

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FUser_KAGudang.Show()
    End Sub

    Private Sub FPj_LaporanStokBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT * FROM `Tabel Obat`"
            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "HASIL_JURNAL_PENERIMAAN_KAS")

            DGV.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MsgBox("Query error!")
        End Try
    End Sub
End Class