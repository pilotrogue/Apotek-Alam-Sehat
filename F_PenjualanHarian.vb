Imports System.Data.OleDb 
Public Class F_PenjualanHarian

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        If rolePegawai = "akuntan" Then
            FUser_Akuntan.Show()
            Me.Hide()
        End If

        If rolePegawai = "kasir" Then
            FUser_Kasir.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub F_PenjualanHarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT [Tabel Penjualan].[ID PENJUALAN], [Tabel Penjualan].[TANGGAL PENJUALAN], [Tabel Customer].[NAMA CUSTOMER], [Tabel Penjualan].KETERANGAN, [Tabel Penjualan].[JUMLAH BAYAR], [Tabel Penjualan].[JUMLAH PIUTANG] FROM [Tabel Customer] INNER JOIN [Tabel Penjualan] ON [Tabel Customer].[ID COSTUMER]=[Tabel Penjualan].[ID PELANGGAN] ORDER BY [Tabel Penjualan].[TANGGAL PENJUALAN];"

            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfBayar = dataTable.Compute("SUM(`JUMLAH BAYAR`)", "")
            Dim sumOfPiutang = dataTable.Compute("SUM(`JUMLAH PIUTANG`)", "")

            Dim sumRow As DataRow = DataTable.NewRow()
            sumRow("JUMLAH BAYAR") = sumOfBayar
            sumRow("JUMLAH PIUTANG") = sumOfPiutang

            DataTable.Rows.Add(sumRow)

            DGV.DataSource = dataTable
            DGV.Columns("ID PENJUALAN").Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class