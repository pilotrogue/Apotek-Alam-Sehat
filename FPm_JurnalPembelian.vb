﻿Imports System.Data.OleDb
Public Class FPm_JurnalPembelian

    Public Property tglAwalPass As String
    Public Property tglAkhirPass As String

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

    Private Sub FPm_HasilJurnalPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            'Buat manggil tabelnya, tapi querynya belom bener
            'MsgBox(tglAwalPass + " " + tglAkhirPass)
            Dim selectQuery = "SELECT `Tabel Trans Jurnal`.`ID TRANSAKSI`, `Tabel Trans Jurnal`.`TANGGAL TRANSAKSI`, `Tabel Trans Jurnal`.`KETERANGAN TRANSAKSI`, `Tabel Trans Jurnal`.DEBIT, `Tabel Trans Jurnal`.KREDIT FROM `Tabel Akun` INNER JOIN `Tabel Trans Jurnal` ON `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` WHERE (((`Tabel Trans Jurnal`.`ID JURNAL`)=1)) ORDER BY `Tabel Trans Jurnal`.`Tanggal Transaksi`"
            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            Dim sumOfDebit = dataTable.Compute("SUM(Debit)", "")
            Dim sumOfKredit = dataTable.Compute("SUM(Kredit)", "")

            Dim sumRow As DataRow = DataTable.NewRow()
            sumRow("Debit") = sumOfDebit
            sumRow("Kredit") = sumOfKredit

            DataTable.Rows.Add(sumRow)
            DGV.DataSource = dataTable
            'jumlahDebitTextBox.Text = sumOfDebit.ToString
            'jumlahKreditTextBox.Text = sumOfKredit.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class