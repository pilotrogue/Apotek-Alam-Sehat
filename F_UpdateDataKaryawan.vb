Imports System.Data.OleDb
Public Class F_UpdateDataKaryawan

    Private Sub F_UpdateDataKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        str = "SELECT * FROM `Tabel Pegawai`"
        cmd = New OleDbCommand(str, conn)

        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataTable As New DataTable

        dataAdapter.Fill(dataTable)

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        FUser_Pemilik.Show()
        Me.Hide()
    End Sub
End Class