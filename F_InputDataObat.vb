Imports System.Data.OleDb
Public Class F_InputDataObat

    Private Sub fillIDObat()
        str = "SELECT TOP 1 `IDObat` FROM `Tabel Obat` ORDER BY `IDObat` DESC"
        cmd = New OleDbCommand(str, conn)
        Dim newIDStr = cmd.ExecuteScalar().ToString()
        Dim newIDInt = CInt(Mid(newIDStr, 3))

        newIDInt = newIDInt + 1

        If newIDInt <= 9 Then
            newIDStr = "O-00" + newIDInt.ToString
        ElseIf newIDInt <= 99 Then
            newIDStr = "O-0" + newIDInt.ToString
        Else
            newIDStr = "O-" + newIDInt.ToString
        End If

        TxtIDObat.Text = newIDStr
    End Sub

    Private Sub F_InputDataObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        fillIDObat()
    End Sub

    Private Sub clear()
        Me.TxtIDObat.Clear()
        Me.TxtNamaObat.Clear()
        Me.TxtSatuanObat.Clear()
        Me.TxtHargaBeliObat.Clear()
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FUser_KAGudang.Show()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Dim idObatStr = TxtIDObat.Text.ToString
        Dim namaObatStr = TxtNamaObat.Text.ToString
        Dim satuanObatStr = TxtSatuanObat.Text.ToString
        Dim stokStr = TxtStokObat.Text.ToString
        Dim hargaBeliStr = TxtHargaBeliObat.Text.ToString
        Dim hargaJualStr = TxtHargaJual.Text.ToString


        str = "INSERT INTO `Tabel Obat` (`IDObat`, `Nama_Obat`, `Satuan`, `Stok`, `Harga Beli`, `Harga Jual`)" & _
            "VALUES (@idObat, @namaObat, @satuan, @stok, @hargaBeli, @hargaJual)"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New OleDbCommand(str, conn)
        cmd.Parameters.AddWithValue("@idObat", idObatStr)
        cmd.Parameters.AddWithValue("@namaObat", namaObatStr)
        cmd.Parameters.AddWithValue("@satuan", satuanObatStr)
        cmd.Parameters.AddWithValue("@stok", stokStr)
        cmd.Parameters.AddWithValue("@hargaBeli", hargaBeliStr)
        cmd.Parameters.AddWithValue("@hargaJual", TxtHargaJual)

        'Dim newRow As DataRow = DB_PembelianDataSet.Tables("T_Obat").NewRow()
        Try
            cmd.ExecuteNonQuery()

            'newRow("ID_Obat") = idObatStr
            'newRow("Nama_Obat") = namaObatStr
            'newRow("Harga Beli") = hargaBeliStr
            'newRow("Satuan") = satuanObatStr
            'DB_PembelianDataSet.Tables("T_Obat").Rows.Add(newRow)
            clear()
            MsgBox("Obat dengan nama: " + namaObatStr + " telah berhasilkan didaftarkan")
        Catch ex As Exception
            MsgBox("Coba dicek lagi!")
        End Try

    End Sub
End Class