Imports System.Data.OleDb
Public Class FPj_LaporanPiutangDagang

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

    Private Sub FPj_LaporanPiutangDagang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT `Tabel Customer`.`NAMA CUSTOMER`, `Tabel Penjualan`.`ID PENJUALAN`, `Tabel Penjualan`.`TANGGAL PENJUALAN`, `Tabel Penjualan`.`JUMLAH PIUTANG` FROM `Tabel Customer` INNER JOIN `Tabel Penjualan` ON `Tabel Customer`.`ID COSTUMER` = `Tabel Penjualan`.`ID PELANGGAN` WHERE (((`Tabel Penjualan`.`JUMLAH PIUTANG`)>0)) ORDER BY `Tabel Customer`.`NAMA CUSTOMER`"
            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfPiutang = dataTable.Compute("SUM(`Jumlah Piutang`)", "")
            Dim sumRow As DataRow = dataTable.NewRow
            sumRow("Jumlah Piutang") = sumOfPiutang

            dataTable.Rows.Add(sumRow)
            DGV.DataSource = dataTable
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class