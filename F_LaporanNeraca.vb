Imports System.Data.OleDb
Public Class F_LaporanNeraca

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

    Private Sub F_LaporanNeraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        'Dim Params As New List(Of OleDbParameter)
        'Dim dataTable As New DataTable


        'cmd = New OleDbCommand(str, conn)

        'For Each p As OleDbParameter In Params
        '    cmd.Parameters.Add(p)
        'Next

        'Params.Clear()

        Try

            'str = "SELECT ta.`No Akun`, ta.`Nama Akun`, SUM(ttj.`DEBIT`) AS SumOfDebit, SUM(ttj.`KREDIT`) AS SumOfKredit, IIF(SUM(ttj.`DEBIT`) > SUM(ttj.`KREDIT`), SUM(ttj.`DEBIT`) - SUM(ttj.`KREDIT`), 0) AS D, IIF(SUM(ttj.`DEBIT`) < SUM(ttj.`KREDIT`), SUM(ttj.`KREDIT`) - SUM(ttj.`DEBIT`), 0) AS K, tga.`No_Gol`, tga.`Nama_Gol`, tsga.`Nama Sub Gol Akun` FROM `Tabel Akun` ta, `Tabel Trans Jurnal` ttj, `Tabel Sub Gol Akun` tsga, `Tabel Gol Akun` tga WHERE ta.`No Sub Gol Akun` = tsga.`No Sub Gol Akun` AND ttj.`No Akun` = ta.`No Akun` AND tsga.`No Gol` = tga.`No_Gol` GROUP BY ttj.`No Akun`, ttj.`Nama Akun` ORDER BY tsga.`Nama Sub Gol Akun`, ta.`No Akun`"
            str = "SELECT `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun`, IIf(SUM(`Tabel Trans Jurnal`.DEBIT)>SUM(`Tabel Trans Jurnal`.KREDIT),SUM(`Tabel Trans Jurnal`.DEBIT)-SUM(`Tabel Trans Jurnal`.KREDIT),0) AS Debit, IIf(SUM(`Tabel Trans Jurnal`.DEBIT)<SUM(`Tabel Trans Jurnal`.KREDIT),SUM(`Tabel Trans Jurnal`.KREDIT)-SUM(`Tabel Trans Jurnal`.DEBIT),0) AS Kredit FROM `Tabel Gol Akun`, `Tabel Sub Gol Akun`, `Tabel Akun`, `Tabel Trans Jurnal` WHERE `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` AND `Tabel Sub Gol Akun`.`No Sub Gol Akun`=`Tabel Akun`.`No Sub Gol Akun` AND `Tabel Gol Akun`.No_Gol=`Tabel Sub Gol Akun`.`No Gol` GROUP BY `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun` ORDER BY  `Tabel Gol Akun`.`Nama_Gol`;"
            'SELECT `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, Sum(`Tabel Trans Jurnal`.DEBIT) AS SumOfDEBIT, Sum(`Tabel Trans Jurnal`.KREDIT) AS SumOfKREDIT, IIf(`Tabel Trans Jurnal`.DEBIT>`Tabel Trans Jurnal`.KREDIT,`Tabel Trans Jurnal`.DEBIT-`Tabel Trans Jurnal`.KREDIT,0) AS D, IIf(`Tabel Trans Jurnal`.DEBIT<`Tabel Trans Jurnal`.KREDIT,`Tabel Trans Jurnal`.KREDIT-`Tabel Trans Jurnal`.DEBIT,0) AS K, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun`
            'FROM `Tabel Gol Akun` INNER JOIN (`Tabel Sub Gol Akun` INNER JOIN (`Tabel Akun` INNER JOIN `Tabel Trans Jurnal` ON `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN`) ON `Tabel Sub Gol Akun`.`No Sub Gol Akun`=`Tabel Akun`.`No Sub Gol Akun`) ON `Tabel Gol Akun`.No_Gol=`Tabel Sub Gol Akun`.`No Gol`
            'GROUP BY `Tabel Sub Gol Akun`.`Nama Sub Gol Akun`, `Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`, `Tabel Sub Gol Akun`.`No Sub Gol Akun`, IIf(`Tabel Trans Jurnal`.DEBIT>`Tabel Trans Jurnal`.KREDIT,`Tabel Trans Jurnal`.DEBIT-`Tabel Trans Jurnal`.KREDIT,0), IIf(`Tabel Trans Jurnal`.DEBIT<`Tabel Trans Jurnal`.KREDIT,`Tabel Trans Jurnal`.KREDIT-`Tabel Trans Jurnal`.DEBIT,0), `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.No_Gol, `Tabel Gol Akun`.Nama_Gol, `Tabel Sub Gol Akun`.`Nama Sub Gol Akun`;

            Dim dataAdapter As New OleDbDataAdapter(str, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfDebit = dataTable.Compute("SUM(Debit)", "")
            Dim sumOfKredit = dataTable.Compute("SUM(Kredit)", "")

            Dim sumRow As DataRow = dataTable.NewRow()
            sumRow("Debit") = sumOfDebit
            sumRow("Kredit") = sumOfKredit

            dataTable.Rows.Add(sumRow)

            DGV.DataSource = dataTable
            DGV.Columns(2).Visible = False
            DGV.Columns(3).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub
End Class