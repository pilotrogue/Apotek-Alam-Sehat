Imports System.Data.OleDb
Public Class FPj_InputDataPenjualan

    Private Sub fillDGV()
        Try
            str = "SELECT * FROM `Tabel Detail Penjualan`"
            Dim dataAdapter As New OleDbDataAdapter(str, conn)
            Dim dataSet As New DataSet

            dataAdapter.Fill(dataSet, "Tabel Penjualan")
            DGV_Subform.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        FUser_Kasir.Show()
        Me.Hide()
    End Sub

    Private Sub FPj_InputDataPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        fillDGV()
    End Sub
End Class