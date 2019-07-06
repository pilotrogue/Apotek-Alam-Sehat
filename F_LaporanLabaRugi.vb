Imports System.Data.OleDb
Public Class F_LaporanLabaRugi

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        If rolePegawai = "akuntan" Then
            FUser_Akuntan.Show()
            Me.Hide()
        End If

        If rolePegawai = "pemilik" Then
            FUser_Pemilik.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub F_LaporanLabaRugi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT a.`No_Gol`, a.`Nama Sub Gol Akun`, a.`No Akun`, a.`NAMA AKUN`, a.Debit, a.Kredit, IIF(a.Debit>a.Kredit, (-1)* a.Debit, a.Kredit) AS SALDO FROM (SELECT `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, IIf(SUM(`Tabel Trans Jurnal`.DEBIT)>SUM(`Tabel Trans Jurnal`.KREDIT),SUM(`Tabel Trans Jurnal`.DEBIT)-SUM(`Tabel Trans Jurnal`.KREDIT),0) AS Debit, IIf(SUM(`Tabel Trans Jurnal`.DEBIT)<SUM(`Tabel Trans Jurnal`.KREDIT),SUM(`Tabel Trans Jurnal`.KREDIT)-SUM(`Tabel Trans Jurnal`.DEBIT),0) AS Kredit, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun` FROM `Tabel Gol Akun`, `Tabel Sub Gol Akun`, `Tabel Akun`, `Tabel Trans Jurnal` WHERE `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` AND `Tabel Sub Gol Akun`.`No Sub Gol Akun`=`Tabel Akun`.`No Sub Gol Akun` AND `Tabel Gol Akun`.No_Gol=`Tabel Sub Gol Akun`.`No Gol` GROUP BY `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun` ORDER BY  `Tabel Akun`.`No Akun`) AS a WHERE a.No_Gol = 4 OR a.No_Gol = 5 ORDER BY a.`No_Gol`"
            'Dim selectQuery = "SELECT Q_NSD.[Nama Sub Gol Akun], Q_NSD.[Nama Akun], Q_NSD.D, Q_NSD.K, IF(Q_NSD.D > Q_NSD.K, (-1(Q_NSD.D) , Q_NSD.K) AS SALDO, Q_NSD.No_Gol FROM(Q_NSD) WHERE (((Q_NSD.No_Gol)=4 Or (Q_NSD.No_Gol)=5));"
            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfDebit As Integer = CInt(dataTable.Compute("SUM(Debit)", "").ToString)
            Dim sumOfKredit As Integer = CInt(dataTable.Compute("SUM(Kredit)", "").ToString)
            Dim sumOfSaldo As Integer = CInt(dataTable.Compute("SUM(Saldo)", "").ToString)
            Dim sumOfSaldoPendapatan = dataTable.Compute("SUM(Saldo)", "[No_Gol] = 4")
            Dim sumOfSaldoBeban = dataTable.Compute("SUM(Saldo)", "[No_Gol] = 5")

            Dim sumRow As DataRow = dataTable.NewRow()
            sumRow("Debit") = sumOfDebit
            sumRow("Kredit") = sumOfKredit
            sumRow("Saldo") = sumOfSaldo

            dataTable.Rows.Add(sumRow)

            'jumlahPendapatanTextBox.Text = sumOfSaldoPendapatan.ToString
            'jumlahBebanTextBox.Text = sumOfSaldoBeban.ToString

            'If sumOfSaldoPendapatan > sumOfSaldoBeban Then
            '    untungRugiLabel.Text = "Untung"
            'Else
            '    untungRugiLabel.Text = "Rugi"
            'End If

            'Dim newDataRows As DataRow = dataTable.NewRow()
            'newDataRows("Debit") = sumOfDebit.ToString
            'newDataRows("Kredit") = sumOfKredit.ToString
            'newDataRows("Saldo") = sumOfSaldo.ToString

            'dataTable.Rows.Add(newDataRows)
            'dataTable.Rows.Add(sumOfDebit, sumOfKredit)

            DGV.DataSource = dataTable
            DGV.Columns("No Akun").Visible = False
            DGV.Columns("No_Gol").Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    End Sub
End Class