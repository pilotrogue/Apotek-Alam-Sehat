Imports System.Data.OleDb
Public Class FPj_UpdateDataCustomer

    Private idCustomerStr As String
    Private namaCustomerStr As String
    Private alamatCustomerStr As String
    Private kontakCustomerStr As String

    Private Sub fillIdCustomerComboBox()
        str = "SELECT `ID COSTUMER` FROM `TABEL CUSTOMER`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet)
        idCustomerComboBox.DataSource = dataSet.Tables(0)
        idCustomerComboBox.ValueMember = "ID COSTUMER"
    End Sub

    Private Sub fillDataGrid()
        'Ini buat ngisi table
        Dim selectQuery = "SELECT * FROM `Tabel Customer`"
        Dim dataAdapter As New OleDbDataAdapter(selectQuery, conn)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "Tabel Customer")

        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub

    Private Sub FPj_UpdateDataCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()

        'Ini buat ngisi combobox ID
        fillIdCustomerComboBox()

        'Ini buat ngisi tabel nama
        fillDataGrid()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        idCustomerStr = idCustomerComboBox.SelectedValue.ToString
        namaCustomerStr = TxtNamaCustomer.ToString
        alamatCustomerStr = TxtAlamatCustomer.ToString
        kontakCustomerStr = TxtKontakCustomer.ToString

        'init.koneksi()
        'Dim selectQuery = "UPDATE `Tabel Customer` SET `alamat` = '" & alamatCustomerStr & "', `kontak/no telp` = '" & kontakCustomerStr & "' WHERE `id costumer` = '" & idCustomerStr & "'"
        'cmd = New OleDbCommand(selectQuery, conn)
        'dr = cmd.ExecuteReader()
        'MsgBox("Customer dengan ID " + idCustomerStr + " telah berhasil diubah")
        'MsgBox(selectQuery)

        'str = "INSERT INTO `Tabel Customer` (`ID Costumer`, `Nama Customer`, `Alamat`, `Kontak/No Telp`)" & _
        '    "VALUES (@idCustomer, @namaCustomer, @alamatCustomer, @kontakCustomer)"


        Try
            Dim updateQuery As String = "UPDATE [Tabel Customer] SET [ALAMAT] = @alamatCustomer , [KONTAK] = @kontakCustomer" & _
            " WHERE [ID COSTUMER] = @idCustomer"

            cmd = New OleDbCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@idCustomer", idCustomerStr)
            cmd.Parameters.AddWithValue("@alamatCustomer", alamatCustomerStr)
            cmd.Parameters.AddWithValue("@kontakCustomer", kontakCustomerStr)

            'Dim dataReader As OleDbDataReader
            'dataReader = cmd.ExecuteReader()

            Dim rowsAffected = cmd.ExecuteNonQuery()
            MsgBox("Rows Affected = " + rowsAffected.ToString)
            'MsgBox("Customer dengan ID " + idCustomerStr + " telah berhasil diubah")

            'Untuk me-refresh datagrid
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            fillDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        FUser_Kasir.Show()
        Me.Hide()
    End Sub

    Private Sub idCustomerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idCustomerComboBox.SelectedIndexChanged
        idCustomerStr = idCustomerComboBox.SelectedValue.ToString
        Try
            str = "SELECT `NAMA CUSTOMER` FROM `TABEL CUSTOMER` WHERE `ID COSTUMER` = '" & idCustomerStr & "'"
            cmd = New OleDbCommand(str, conn)
            TxtNamaCustomer.Text = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            'MsgBox(ex.ToString)
            TxtNamaCustomer.Text = ""
        End Try

        Try
            str = "SELECT `ALAMAT` FROM `TABEL CUSTOMER` WHERE `ID COSTUMER` = '" & idCustomerStr & "'"
            cmd = New OleDbCommand(str, conn)
            TxtAlamatCustomer.Text = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            'MsgBox(ex.ToString)
            TxtAlamatCustomer.Text = ""
        End Try

        Try
            str = "SELECT `KONTAK` FROM `TABEL CUSTOMER` WHERE `ID COSTUMER` = '" & idCustomerStr & "'"
            cmd = New OleDbCommand(str, conn)
            TxtKontakCustomer.Text = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            'MsgBox(ex.ToString)
            TxtKontakCustomer.Text = ""
        End Try
    End Sub
End Class