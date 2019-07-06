Imports System.Data.OleDb
Public Class FPm_InputDataPembelian

    Private noPembelianStr
    Private noBuktiStr
    Private tanggalPembelianStr
    Private tanggalPelunasanStr
    Private keteranganStr
    Private jenisPembelianStr
    Private idKaryawanStr
    Private idSupplierStr
    Private totalPembelianStr
    Private uangDibayarStr
    Private utangDagangStr

    Private Sub checkLunas()
        Dim totalHutangInt = CInt(TxtTotalHutang.Text)
        If totalHutangInt = 0 Then
            Label15.Text = "LUNAS"
        Else
            Label15.Text = "BELUM LUNAS"
        End If
    End Sub

    Private Sub autoIncrementIDPembelian()
        str = "SELECT TOP 1 `ID PEMBELIAN` FROM `TABEL PEMBELIAN` ORDER BY `ID PEMBELIAN` DESC"
        cmd = New OleDbCommand(str, conn)
        Dim newIDStr = cmd.ExecuteScalar().ToString()
        Dim newIDInt = CInt(Mid(newIDStr, 3))
        newIDInt = newIDInt + 1

        If newIDInt <= 9 Then
            newIDStr = "B-00" + newIDInt.ToString
        ElseIf newIDInt <= 99 Then
            newIDStr = "B-0" + newIDInt.ToString
        ElseIf newIDInt <= 999 Then
            newIDStr = "B-" + newIDInt.ToString
        End If

        TxtNoPembelian.Text = newIDStr
    End Sub

    Private Sub fillTotalUtang()
        noPembelianStr = TxtNoPembelian.Text.ToString
        str = "SELECT COUNT(*) FROM `Tabel Detail Pembelian`" & _
            "WHERE `ID PEMBELIAN` = '" & noPembelianStr & "'"

        cmd = New OleDbCommand(str, conn)
        Dim rowReturned As Integer = CInt(cmd.ExecuteScalar().ToString)

        If rowReturned <> 0 Then
            str = "SELECT SUM(`HARGA BELI` * `JUMLAH`) FROM `tabel detail pembelian` WHERE `ID PEMBELIAN` = '" & noPembelianStr & "' GROUP BY `ID PEMBELIAN`"
            cmd = New OleDbCommand(str, conn)
            totalPembelianStr = cmd.ExecuteScalar().ToString
        ElseIf rowReturned = 0 Then
            totalPembelianStr = "0"
        End If

        TxtTotalPembelian.Text = totalPembelianStr
        Dim totalPembelianInt = CInt(totalPembelianStr)

        uangDibayarStr = TxtUangDibayar.Text
        Dim uangDibayarInt = totalPembelianInt - CInt(uangDibayarStr)

        TxtTotalHutang.Text = uangDibayarInt.ToString
    End Sub

    Private Sub fillDGVWhere()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        Dim selectQuery = "SELECT `ID Pembelian`, `ID OBAT`, `HARGA BELI`,`JUMLAH`,`TGL EXPIRED` FROM `Tabel Detail Pembelian`" & _
            " WHERE `ID PEMBELIAN` = '" & TxtNoPembelian.Text.ToString & "'"
        Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "Tabel Detail Pembelian")

        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub

    Private Sub fillDGV()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()

        Dim selectQuery = "SELECT `ID Pembelian`, `ID OBAT`, `HARGA BELI`,`JUMLAH`,`TGL EXPIRED` FROM `Tabel Detail Pembelian`"
        Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Detail Pembelian")
        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub

    Sub fillComboBoxSupplier()
        str = "SELECT `ID SUPPLIER`, `NAMA SUPPLIER` FROM `Tabel Supplier`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Supplier")

        idSupplierComboBox.DataSource = dataSet.Tables(0)
        idSupplierComboBox.ValueMember = "ID SUPPLIER"
        idSupplierComboBox.DisplayMember = "NAMA SUPPLIER"

        idSupplierComboBox.SelectedIndex = 0

        'MsgBox(idSupplierComboBox.SelectedValue.ToString)
    End Sub

    Sub fillComboBoxKaryawan()
        str = "SELECT `ID PEGAWAI`, `NAMA PEGAWAI` FROM `Tabel Pegawai`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Supplier")

        idKaryawanComboBox.DataSource = dataSet.Tables(0)
        idKaryawanComboBox.ValueMember = "ID PEGAWAI"
        idKaryawanComboBox.DisplayMember = "NAMA PEGAWAI"

        idKaryawanComboBox.SelectedIndex = 0
    End Sub

    Sub clear()
        Me.TxtNoPembelian.Clear()
        Me.TxtNoBukti.Clear()
        Me.TxtKeterangan.Clear()
        Me.TxtJenisPembelian.Clear()
        Me.TxtTotalPembelian.Clear()
        Me.TxtUangDibayar.Clear()
        Me.TxtTotalHutang.Clear()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        noPembelianStr = TxtNoPembelian.Text
        noBuktiStr = TxtNoBukti.Text
        tanggalPembelianStr = tanggalPembelianDateTimePicker.Value.ToString("MM/dd/yyyy")
        tanggalPelunasanStr = TxtTglJatuhTempo.Value.ToString("MM/dd/yyyy")
        keteranganStr = TxtKeterangan.Text
        jenisPembelianStr = TxtJenisPembelian.Text
        idKaryawanStr = idKaryawanComboBox.SelectedValue.ToString
        idSupplierStr = idSupplierComboBox.SelectedValue.ToString
        totalPembelianStr = TxtTotalPembelian.Text.ToString
        uangDibayarStr = TxtUangDibayar.Text.ToString
        utangDagangStr = TxtTotalHutang.Text.ToString

        str = "SELECT COUNT(*) FROM `Tabel Pembelian`" & _
            "WHERE `ID PEMBELIAN` = '" & noPembelianStr & "'"

        cmd = New OleDbCommand(str, conn)
        Dim rowReturned As Integer = CInt(cmd.ExecuteScalar().ToString)

        If rowReturned = 0 Then
            'Buat input ke dalam tabel pembelian
            str = "INSERT INTO `Tabel Pembelian`(`ID PEMBELIAN`, `NO BUKTI`, `TANGGAL PEMBELIAN`, `ID SUPPLIER`, `KETERANGAN`, `ID KASIR`, `TANGGAL JT`, `UANG DIBAYAR`, `UTANG DAGANG`)" & _
            "VALUES(@idPembelian, @noBukti, @tglPembelian, @idSupplier, @keterangan, @idKasir, @tanggalJt, @uangDibayar, @utangDagang)"

            cmd = New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("@idPembelian", noPembelianStr)
            cmd.Parameters.AddWithValue("@noBukti", noBuktiStr)
            cmd.Parameters.AddWithValue("@tglPembelian", tanggalPembelianStr)
            cmd.Parameters.AddWithValue("@idSupplier", idSupplierStr)
            cmd.Parameters.AddWithValue("@keterangan", keteranganStr)
            cmd.Parameters.AddWithValue("@idKasir", idKaryawanStr)
            cmd.Parameters.AddWithValue("@tanggalJt", tanggalPelunasanStr)
            cmd.Parameters.AddWithValue("@uangDibayar", uangDibayarStr)
            cmd.Parameters.AddWithValue("@utangDagang", utangDagangStr)

            cmd.ExecuteNonQuery()
        Else
            MsgBox("ID Pembelian suda terpakai")
        End If

        Dim dataAdapter As New OleDbDataAdapter

        

        'cmd.Parameters.Add("@idPembelian", OleDbType.VarChar)
        'cmd.Parameters.Add("@idObat", OleDbType.VarChar)
        'cmd.Parameters.Add("@hargaBeli", OleDbType.Currency)
        'cmd.Parameters.Add("@jumlah", OleDbType.Numeric)
        'cmd.Parameters.Add("@tglExpired", OleDbType.Date)

        'MsgBox(DataGridView1.Rows(0).Cells(4).Value)

        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    cmd = New OleDbCommand(str, conn)
        '    cmd.Parameters(0).Value = DataGridView1.Rows(i).Cells(0).Value
        '    cmd.Parameters(1).Value = DataGridView1.Rows(i).Cells(1).Value
        '    cmd.Parameters(2).Value = DataGridView1.Rows(i).Cells(2).Value
        '    cmd.Parameters(3).Value = DataGridView1.Rows(i).Cells(3).Value
        '    cmd.Parameters(4).Value = DataGridView1.Rows(i).Cells(4).Value

        '    cmd.ExecuteNonQuery()
        'Next

        'buat input ke tabel detail pembelian

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            str = "INSERT INTO `TABEL DETAIL PEMBELIAN`(`ID PEMBELIAN`, `ID OBAT`, `HARGA BELI`, `JUMLAH`, `TGL EXPIRED`)" & _
                "VALUES(@idPembelian, @idObat, @hargaBeli, @jumlah, @tglExpired)"
            cmd = New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("@idPembelian", DataGridView1.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@idObat", DataGridView1.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("@hargaBeli", DataGridView1.Rows(i).Cells(2).Value)
            cmd.Parameters.AddWithValue("@jumlah", DataGridView1.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("@tglExpired", DataGridView1.Rows(i).Cells(4).Value)
            'cmd.Parameters(0).Value = DataGridView1.Rows(i).Cells(0).Value
            'cmd.Parameters(1).Value = DataGridView1.Rows(i).Cells(1).Value
            'cmd.Parameters(2).Value = DataGridView1.Rows(i).Cells(2).Value
            'cmd.Parameters(3).Value = DataGridView1.Rows(i).Cells(3).Value
            'cmd.Parameters(4).Value = DataGridView1.Rows(i).Cells(4).Value

            cmd.ExecuteNonQuery()
        Next

    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FUser_Kasir.Show()
    End Sub

    Private Sub FPm_InputDataPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        clear()

        Me.tanggalPembelianDateTimePicker.Value = DateTime.Now
        Me.TxtTglJatuhTempo.Value = Me.tanggalPembelianDateTimePicker.Value

        'autoIncrementIDPembelian()
        'fillDGVWhere()
        If TxtTotalPembelian.TextLength <= 0 Then
            TxtTotalPembelian.Text = "0"
        End If

        If TxtUangDibayar.TextLength <= 0 Then
            TxtUangDibayar.Text = "0"
        End If

        If TxtTotalHutang.TextLength <= 0 Then
            TxtTotalHutang.Text = "0"
        End If
        fillDGV()
        fillComboBoxSupplier()
        fillComboBoxKaryawan()
    End Sub

    Private Sub TxtNoPembelian_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNoPembelian.Leave
        If TxtTotalPembelian.TextLength <= 0 Then
            TxtTotalPembelian.Text = "0"
        End If

        If TxtUangDibayar.TextLength <= 0 Then
            TxtUangDibayar.Text = "0"
        End If

        If TxtTotalHutang.TextLength <= 0 Then
            TxtTotalHutang.Text = "0"
        End If
        fillDGVWhere()
        fillTotalUtang()
    End Sub

    Private Sub TxtUangDibayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUangDibayar.TextChanged
        If TxtTotalPembelian.TextLength <= 0 Then
            TxtTotalPembelian.Text = "0"
        End If

        If TxtUangDibayar.TextLength <= 0 Then
            TxtUangDibayar.Text = "0"
        End If

        If TxtTotalHutang.TextLength <= 0 Then
            TxtTotalHutang.Text = "0"
        End If
        fillTotalUtang()
        checkLunas()
    End Sub
End Class