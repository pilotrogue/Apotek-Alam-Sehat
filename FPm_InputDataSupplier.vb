Imports System.Data.OleDb
Public Class FPm_InputDataSupplier

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FUser_KAGudang.Show()
    End Sub

    Private Sub autoIncrementIDSupplier()
        str = "SELECT TOP 1 `ID SUPPLIER` FROM `TABEL SUPPLIER` ORDER BY `ID SUPPLIER` DESC"
        cmd = New OleDbCommand(str, conn)
        Dim newIDStr = cmd.ExecuteScalar().ToString()
        Dim newIDInt = CInt(Mid(newIDStr, 3))
        newIDInt = newIDInt + 1

        If newIDInt <= 9 Then
            newIDStr = "S-00" + newIDInt.ToString
        ElseIf newIDInt <= 99 Then
            newIDStr = "S-0" + newIDInt.ToString
        Else
            newIDStr = "S-" + newIDInt.ToString
        End If

        TxtIDSupplier.Text = newIDStr
    End Sub

    Sub clear()
        TxtIDSupplier.Clear()
        TxtNamaSupplier.Clear()
        TxtAlamatSupplier.Clear()
        TxtKontakSupplier.Clear()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Dim idSupplierStr = TxtIDSupplier.Text
        Dim namaSupplierStr = TxtNamaSupplier.Text
        Dim alamatSupplierStr = TxtAlamatSupplier.Text
        Dim kontakSupplierStr = TxtKontakSupplier.Text

        str = "INSERT INTO `Tabel Supplier` (`ID SUPPLIER`, `NAMA SUPPLIER`, `ALAMAT SUPPLIER`, `KONTAK SUPPLIER`)" & _
              "VALUES(@idSupp, @namaSupp, @alamatSupp, @kontakSupp)"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDbCommand(str, conn)
        cmd.Parameters.AddWithValue("@idSupp", idSupplierStr)
        cmd.Parameters.AddWithValue("@namaSupp", namaSupplierStr)
        cmd.Parameters.AddWithValue("@alamatSupp", alamatSupplierStr)
        cmd.Parameters.AddWithValue("@kontakSupp", TxtKontakSupplier)

        Try
            cmd.ExecuteNonQuery()
            clear()
            MsgBox("Supplier dengan nama: " + namaSupplierStr + " telah berhasil didaftarkan")
        Catch ex As Exception
            MsgBox("Coba cek lagi!")
        End Try
    End Sub

    Private Sub F_InputDataSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        autoIncrementIDSupplier()
    End Sub
End Class