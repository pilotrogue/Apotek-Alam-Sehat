Imports System.Data.OleDb
Public Class FPj_InputDataCustomer

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        FUser_Kasir.Show()
        Me.Hide()
    End Sub
    Private Sub fillIDCustomer()
        str = "SELECT TOP 1 `ID Costumer` FROM `Tabel Customer` ORDER BY `ID Costumer` DESC"
        cmd = New OleDbCommand(str, conn)
        Dim newIDStr = cmd.ExecuteScalar().ToString()
        Dim newIDInt = CInt(Mid(newIDStr, 3))

        newIDInt = newIDInt + 1

        If newIDInt <= 9 Then
            newIDStr = "C-00" + newIDInt.ToString
        ElseIf newIDInt <= 99 Then
            newIDStr = "C-0" + newIDInt.ToString
        Else
            newIDStr = "C-" + newIDInt.ToString
        End If

        TxtIDCustomer.Text = newIDStr
    End Sub


    Private Sub BtnTambah_Click(sender As System.Object, e As System.EventArgs) Handles BtnTambah.Click
        Dim idCustomerStr = TxtIDCustomer.Text.ToString
        Dim namaCustomerStr = TxtNamaCustomer.Text.ToString
        Dim kontakCustomerStr = TxtKontakCustomer.Text.ToString
        Dim alamatCustomerStr = TxtAlamatCustomer.Text.ToString

        str = "INSERT INTO `Tabel Customer` (`ID Costumer`, `Nama Customer`, `Alamat`, `Kontak/No Telp`)" & _
            "VALUES (@idCustomer, @namaCustomer, @alamatCustomer, @kontakCustomer)"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New OleDbCommand(str, conn)
        cmd.Parameters.AddWithValue("@idCustomer", idCustomerStr)
        cmd.Parameters.AddWithValue("@namaCustomer", namaCustomerStr)
        cmd.Parameters.AddWithValue("@alamatCustomer", alamatCustomerStr)
        cmd.Parameters.AddWithValue("@kontakCustomer", kontakCustomerStr)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Customer dengan nama " + namaCustomerStr + " berhasil ditambahkan!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FPj_InputDataCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        fillIDCustomer()
    End Sub
End Class