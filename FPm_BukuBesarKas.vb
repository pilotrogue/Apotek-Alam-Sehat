Imports System.Data.OleDb
Public Class FPm_BukuBesarKas

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FPm_BukuBesar.Show()
    End Sub

    Private Sub FPm_BukuBesarKas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Dim selectQuery = "SELECT TbJurnal.*, T_Kasir.Nama_Kasir, T_Supplier.Nama_Supp FROM T_Supplier INNER JOIN (T_Kasir INNER JOIN TbJurnal ON T_Kasir.ID_Kasir = TbJurnal.IDKasir) ON T_Supplier.ID_Supp = TbJurnal.IDSupplier"
        Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "KAS")

        DGV.DataSource = dataSet.Tables(0)
    End Sub
End Class