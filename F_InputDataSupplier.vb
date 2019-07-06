Imports System.Data.OleDb
Public Class F_InputDataSupplier

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        F_Input_Pembelian.Show()
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

        str = "INSERT INTO T_Supplier (ID_Supp, Nama_Supp, Alamat, Kontak_No_HP)" & _
              "VALUES(@idSupp, @namaSupp, @alamatSupp, @kontakSupp)"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("@idSupp", idSupplierStr)
            cmd.Parameters.AddWithValue("@namaSupp", namaSupplierStr)
            cmd.Parameters.AddWithValue("@alamatSupp", alamatSupplierStr)
            cmd.Parameters.AddWithValue("@kontakSupp", TxtKontakSupplier)

            cmd.ExecuteNonQuery()
            clear()
        Catch ex As Exception
            MsgBox("Coba cek lagi!")
        End Try
    End Sub

    Private Sub F_InputDataSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
    End Sub
End Class