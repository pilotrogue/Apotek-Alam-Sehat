Imports System.Data.OleDb
Public Class F_PembelianHarian

    Private Sub F_PembelianHarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT [Tabel Pembelian].[ID PEMBELIAN], [Tabel Pembelian].[TANGGAL PEMBELIAN], [Tabel Supplier].[NAMA SUPPLIER], [Tabel Pembelian].KETERANGAN, [Tabel Pembelian].[UANG DIBAYAR] AS LUNAS, [Tabel Pembelian].[UTANG DAGANG] AS UTANG FROM [Tabel Supplier] INNER JOIN [Tabel Pembelian] ON [Tabel Supplier].[ID SUPPLIER]=[Tabel Pembelian].[ID SUPPLIER];"

            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfLunas = dataTable.Compute("SUM(LUNAS)", "")
            Dim sumOfUtang = dataTable.Compute("SUM(UTANG)", "")

            Dim sumRow As DataRow = dataTable.NewRow()
            sumRow("LUNAS") = sumOfLunas
            sumRow("UTANG") = sumOfUtang

            dataTable.Rows.Add(sumRow)

            DGV.DataSource = dataTable
            DGV.Columns("ID PEMBELIAN").Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

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
End Class