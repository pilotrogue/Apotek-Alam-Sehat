Imports System.Data.OleDb
Public Class F_JurnalUmum

    Private Sub F_JurnalUmum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        Try
            Dim selectQuery = "SELECT `Tabel Trans Jurnal`.`ID TRANSAKSI`, `Tabel Trans Jurnal`.`TANGGAL TRANSAKSI`, `Tabel Trans Jurnal`.`KETERANGAN TRANSAKSI`, `Tabel Trans Jurnal`.DEBIT, `Tabel Trans Jurnal`.KREDIT FROM `Tabel Akun` INNER JOIN `Tabel Trans Jurnal` ON `Tabel Akun`.`No Akun`=`Tabel Trans Jurnal`.`NO AKUN` WHERE (((`Tabel Trans Jurnal`.`ID JURNAL`)=5)) ORDER BY `Tabel Trans Jurnal`.`Tanggal Transaksi`"

            Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "JURNAL_UMUM")

            DGV.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MsgBox("Query error!")
        End Try
    End Sub


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
End Class