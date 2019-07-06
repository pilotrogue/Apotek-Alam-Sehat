Imports System.Data.OleDb
Public Class FPj_BukuBesar

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

    Private Sub FPj_BukuBesar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Dim selectQuery = "SELECT `Tabel Trans Jurnal`.`ID TRANSAKSI`, `Tabel Trans Jurnal`.`TANGGAL TRANSAKSI`, `Tabel Akun`.`Nama Akun`, SUM(`Tabel Trans Jurnal`.DEBIT) AS Jumlah_Debit, SUM(`Tabel Trans Jurnal`.KREDIT) AS Jumlah_Kredit FROM `Tabel Akun` INNER JOIN `Tabel Trans Jurnal` ON `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` GROUP BY `Tabel Trans Jurnal`.`ID TRANSAKSI`,`Tabel Akun`.`No Akun`, `Tabel Akun`.`Nama Akun`,`Tabel Trans Jurnal`.`Tanggal Transaksi` ORDER BY `Tabel Akun`.`No Akun`"
        'Dim selectQuery = "SELECT `Tabel Akun`.`Nama Akun`, `Tabel Trans Jurnal`.`ID TRANSAKSI`, `Tabel Trans Jurnal`.`TANGGAL TRANSAKSI`, SUM(`Tabel Trans Jurnal`.DEBIT) AS Jumlah_Debit, SUM(`Tabel Trans Jurnal`.KREDIT) AS Jumlah_Kredit FROM `Tabel Akun` INNER JOIN `Tabel Trans Jurnal` ON `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` GROUP BY `Tabel Akun`.`No Akun`, `Tabel Trans Jurnal`.`ID TRANSAKSI`"
        Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
        Dim dataTable As New DataTable
        Try
            dataAdapter.Fill(dataTable)

            Dim j As Integer
            Dim currCellValue As String
            Dim nextCellValue As String

            'currCellValue = dataTable.Rows(1)(0)
            'nextCellValue = dataTable.Rows(0)(0)

            'MsgBox(currCellValue + ", " + nextCellValue)

            'For i As Integer = 1 To dataTable.Rows.Count
            '    Try
            '        j = i - 1
            '        'MsgBox("i = " + i.ToString + ", j = " + j.ToString)
            '        currCellValue = dataTable.Rows(j)(0).ToString
            '        nextCellValue = dataTable.Rows(i)(0).ToString
            '        If String.Compare(currCellValue, nextCellValue) <> 0 Then
            '            Dim subTotalRow As DataRow = dataTable.NewRow
            '            dataTable.Rows.InsertAt(subTotalRow, i)
            '            i = i + 1
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.ToString)
            '    End Try

            'Next

            Dim i = 1

            '2 = Sub total
            '3 = Debit
            '4 = Kredit

            While i < dataTable.Rows.Count
                Try
                    j = i - 1
                    'MsgBox("i = " + i.ToString + ", j = " + j.ToString)
                    currCellValue = dataTable.Rows(j)("Nama Akun").ToString
                    nextCellValue = dataTable.Rows(i)("Nama Akun").ToString
                    If String.Compare(currCellValue, nextCellValue) <> 0 Then
                        Dim subTotalRow As DataRow = dataTable.NewRow
                        subTotalRow("Nama Akun") = "Sub Total"
                        subTotalRow("Jumlah_Debit") = dataTable.Compute("Sum(Jumlah_Debit)", "`Nama Akun` = '" & currCellValue & "'").ToString
                        subTotalRow("Jumlah_Kredit") = dataTable.Compute("Sum(Jumlah_Kredit)", "`Nama Akun` = '" & currCellValue & "'").ToString

                        dataTable.Rows.InsertAt(subTotalRow, i)
                        i = i + 1
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                    i = i + 1
            End While

            Dim lastTotalRow As DataRow = dataTable.NewRow
            lastTotalRow("Nama Akun") = "Sub Total"
            lastTotalRow("Jumlah_Debit") = dataTable.Compute("Sum(Jumlah_Debit)", "`Nama Akun` = '" & dataTable.Rows(dataTable.Rows.Count - 2)("Nama Akun").ToString & "'").ToString
            lastTotalRow("Jumlah_Kredit") = dataTable.Compute("Sum(Jumlah_Kredit)", "`Nama Akun` = '" & dataTable.Rows(dataTable.Rows.Count - 2)("Nama Akun").ToString & "'").ToString

            dataTable.Rows.InsertAt(lastTotalRow, i)
            DGV.DataSource = dataTable
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    End Sub
End Class