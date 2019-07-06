Imports System.Data.OleDb
Public Class F_InputJurnal

    Private tglTransaksiStr As String
    Private keteranganTransaksiStr As String
    Private idJurnalStr As String
    Private noAkunStr As String
    Private debitStr As String
    Private kreditStr As String
    Private idPegawaiStr As String

    Private Sub autoIncrementIdTrans()
        str = "SELECT TOP 1 `ID TRANSAKSI` FROM `TABEL TRANS JURNAL` ORDER BY `ID TRANSAKSI` DESC"
        cmd = New OleDbCommand(str, conn)
        Dim newIDStr = cmd.ExecuteScalar().ToString()
        Dim newIDInt = CInt(newIDStr) + 1
        idTransaksiTextBox.Text = newIDInt.ToString
    End Sub

    Private Sub fillIdJurnalComboBox()
        str = "SELECT `ID JURNAL`, `NAMA JURNAL` FROM `TABEL JENIS JURNAL`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Jenis Jurnal")

        idJurnalComboBox.DataSource = dataSet.Tables(0)
        idJurnalComboBox.ValueMember = "ID JURNAL"
        idJurnalComboBox.DisplayMember = "NAMA JURNAL"

        idJurnalComboBox.SelectedIndex = 0
    End Sub

    Private Sub fillNoAkunComboBox()
        str = "SELECT `NO AKUN`, `NAMA AKUN` FROM `TABEL AKUN`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Akun")

        noAkunComboBox.DataSource = dataSet.Tables(0)
        noAkunComboBox.ValueMember = "NO AKUN"
        noAkunComboBox.DisplayMember = "NAMA AKUN"

        noAkunComboBox.SelectedIndex = 0
    End Sub

    Private Sub fillIdPegawaiComboBox()
        str = "SELECT `ID PEGAWAI`, `NAMA PEGAWAI` FROM `TABEL PEGAWAI`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Akun")

        idPegawaiComboBox.DataSource = dataSet.Tables(0)
        idPegawaiComboBox.ValueMember = "ID PEGAWAI"
        idPegawaiComboBox.DisplayMember = "NAMA PEGAWAI"

        idPegawaiComboBox.SelectedIndex = 0
    End Sub

    Private Sub F_InputJurnal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()

        autoIncrementIdTrans()
        fillIdJurnalComboBox()
        fillNoAkunComboBox()
        fillIdPegawaiComboBox()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        tglTransaksiStr = tanggalTransaksiDateTimePicker.Value.ToString("MM/dd/yyyy")
        keteranganTransaksiStr = keteranganTransaksiTextBox.Text.ToString
        idJurnalStr = idJurnalComboBox.SelectedValue.ToString
        noAkunStr = noAkunComboBox.SelectedValue.ToString
        debitStr = debitTextBox.Text
        kreditStr = kreditTextBox.Text
        idPegawaiStr = idPegawaiComboBox.SelectedValue.ToString

        str = "INSERT INTO `Tabel Trans Jurnal`(`TANGGAL TRANSAKSI`, `KETERANGAN TRANSAKSI`, `ID JURNAL`, `NO AKUN`, `DEBIT`, `KREDIT`, `ID PEGAWAI`)" & _
            "VALUES(@tglTransaksi, @keteranganTransaksi, @idJurnal, @noAkun, @debit, @kredit, @idPegawai)"

        cmd = New OleDbCommand(str, conn)
        cmd.Parameters.AddWithValue("@tglTransaksi", tglTransaksiStr)
        cmd.Parameters.AddWithValue("@keteranganTransaksi", keteranganTransaksiStr)
        cmd.Parameters.AddWithValue("@idJurnal", idJurnalStr)
        cmd.Parameters.AddWithValue("@noAkun", noAkunStr)
        cmd.Parameters.AddWithValue("@debit", debitStr)
        cmd.Parameters.AddWithValue("@kredit", kreditStr)
        cmd.Parameters.AddWithValue("@idPegawai", idPegawaiStr)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Transaksi dengan keterangan: """ + keteranganTransaksiStr + """ telah berhasil dimasukkan")
        Catch ex As Exception
            MsgBox("Coba dicek lagi")
        End Try

    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FUser_Akuntan.Show()
    End Sub
End Class