Imports System.Data.OleDb
Public Class F_UpdateDataObat

    Private Sub F_UpdateDataObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        str = "SELECT * FROM `Tabel Obat`"
        cmd = New OleDbCommand(str, conn)

        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataTable As New DataTable

        dataAdapter.Fill(dataTable)

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        FUser_KAGudang.Show()
        Me.Hide()
    End Sub
End Class