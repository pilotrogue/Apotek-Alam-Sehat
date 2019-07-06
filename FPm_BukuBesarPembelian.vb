Imports System.Data.OleDb
Public Class FPm_BukuBesarPembelian
    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FPm_BukuBesar.Show()
    End Sub

    Private Sub FPm_BukuBesarPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Dim selectQuery = "SELECT TbJurnal.*, T_Supplier.Nama_Supp, T_Kasir.Nama_Kasir FROM T_Kasir INNER JOIN (T_Supplier INNER JOIN TbJurnal ON T_Supplier.ID_Supp = TbJurnal.IDSupplier) ON T_Kasir.ID_Kasir = TbJurnal.IDKasir"
        Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "PEMBELIAN")

        DGV.DataSource = dataSet.Tables(0)
    End Sub
End Class