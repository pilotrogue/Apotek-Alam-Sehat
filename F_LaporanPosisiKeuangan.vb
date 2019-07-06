Imports System.Data.OleDb
Public Class F_LaporanPosisiKeuangan

    Private Sub F_LaporanPosisiKeuangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            'Buat manggil tabelnya, tapi querynya belom bener
            'MsgBox(tglAwalPass + " " + tglAkhirPass)
            Dim selectQuery = "SELECT `Q_Neraca_Saldo`.No_Gol, `Q_Neraca_Saldo`.Nama_Gol, `Q_Neraca_Saldo`.`No Akun`, `Q_Neraca_Saldo`.`Nama Akun`, `Q_Neraca_Saldo`.Debit, `Q_Neraca_Saldo`.Kredit, IIF(`Q_Neraca_Saldo`.Debit>`Q_Neraca_Saldo`.Kredit,`Q_Neraca_Saldo`.Debit,(-1)*`Q_Neraca_Saldo`.Kredit) AS SALDO FROM (SELECT `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, IIf(SUM(`Tabel Trans Jurnal`.DEBIT)>SUM(`Tabel Trans Jurnal`.KREDIT),SUM(`Tabel Trans Jurnal`.DEBIT)-SUM(`Tabel Trans Jurnal`.KREDIT),0) AS Debit, IIf(SUM(`Tabel Trans Jurnal`.DEBIT)<SUM(`Tabel Trans Jurnal`.KREDIT),SUM(`Tabel Trans Jurnal`.KREDIT)-SUM(`Tabel Trans Jurnal`.DEBIT),0) AS Kredit, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun` FROM `Tabel Gol Akun`, `Tabel Sub Gol Akun`, `Tabel Akun`, `Tabel Trans Jurnal` WHERE `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` AND `Tabel Sub Gol Akun`.`No Sub Gol Akun`=`Tabel Akun`.`No Sub Gol Akun` AND `Tabel Gol Akun`.No_Gol=`Tabel Sub Gol Akun`.`No Gol` GROUP BY `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun` ORDER BY  `Tabel Akun`.`No Akun`) As Q_Neraca_Saldo WHERE (((`Q_Neraca_Saldo`.No_Gol)=1 Or (`Q_Neraca_Saldo`.No_Gol)=2 Or (`Q_Neraca_Saldo`.No_Gol)=3)) ORDER BY `Q_Neraca_Saldo`.No_Gol;"
            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfDebit = dataTable.Compute("SUM(Debit)", "")
            Dim sumOfKredit = dataTable.Compute("SUM(Kredit)", "")
            Dim sumOfSaldo = dataTable.Compute("SUM(Saldo)", "")

            Dim sumRow As DataRow = dataTable.NewRow()
            sumRow("Debit") = sumOfDebit
            sumRow("Kredit") = sumOfKredit
            sumRow("Saldo") = sumOfSaldo

            dataTable.Rows.Add(sumRow)
            DGV.DataSource = dataTable
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class