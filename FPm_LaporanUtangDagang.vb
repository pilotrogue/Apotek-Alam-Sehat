Imports System.Data.OleDb
Public Class FPm_LaporanUtangDagang

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

    Private Sub FPm_LaporanTagihanUtang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT [Tabel Supplier].[ID SUPPLIER], [Tabel Supplier].[NAMA SUPPLIER], [Tabel Pembelian].[ID PEMBELIAN], [Tabel Pembelian].[TANGGAL PEMBELIAN], [Tabel Pembelian].[TANGGAL JT], [Tabel Pembelian].[UTANG DAGANG] FROM [Tabel Supplier] INNER JOIN [Tabel Pembelian] ON [Tabel Supplier].[ID SUPPLIER]=[Tabel Pembelian].[ID SUPPLIER] WHERE ((([Tabel Pembelian].[UTANG DAGANG])>0)) ORDER BY [Tabel Supplier].[Nama Supplier];"
            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfUtang = dataTable.Compute("SUM(`UTANG DAGANG`)", "")

            Dim sumRow As DataRow = dataTable.NewRow()
            sumRow("UTANG DAGANG") = sumOfUtang

            dataTable.Rows.Add(sumRow)

            DGV.DataSource = dataTable
            DGV.Columns("ID SUPPLIER").Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class