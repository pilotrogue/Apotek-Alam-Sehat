Imports System.Data.OleDb
Public Class F_InputDataKaryawan
    Private Sub clear()
        Me.TxtIDKaryawan.Clear()
        Me.TxtNamaKaryawan.Clear()
        Me.TxtKontakKaryawan.Clear()
        Me.TxtUsernameKaryawan.Clear()
        Me.TxtPasswordKaryawan.Clear()
    End Sub

    Private Sub fillRoleComboBox()
        roleComboBox.Items.Add("Kasir")
        roleComboBox.Items.Add("Akuntan")
        roleComboBox.Items.Add("KA Gudang")
        roleComboBox.SelectedIndex = 0
    End Sub

    Private Sub autoIncrementIDPegawai()
        str = "SELECT TOP 1 `ID PEGAWAI` FROM `TABEL PEGAWAI` ORDER BY `ID PEGAWAI` DESC"
        cmd = New OleDbCommand(str, conn)
        Dim newIDStr = cmd.ExecuteScalar().ToString()
        Dim newIDInt = CInt(Mid(newIDStr, 2))
        newIDInt = newIDInt + 1

        If newIDInt <= 9 Then
            newIDStr = "P0" + newIDInt.ToString
        Else
            newIDStr = "P" + newIDInt.ToString
        End If

        TxtIDKaryawan.Text = newIDStr
    End Sub

    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        Me.Hide()
        FUser_Pemilik.Show()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Dim idKaryawanStr = TxtIDKaryawan.Text
        Dim namaKaryawanStr = TxtNamaKaryawan.Text
        Dim kontakKaryawanStr = TxtKontakKaryawan.Text
        Dim unameKaryawanStr = TxtUsernameKaryawan.Text
        Dim passwordKaryawanStr = TxtPasswordKaryawan.Text
        Dim roleKaryawanStr = roleComboBox.SelectedItem.ToString
        'Dim queryInsert As String = "INSERT INTO T_Kasir (ID_Kasir, Nama_Kasir, No_Telp, uname, password)VALUES ('" & idKaryawanStr & "', '" & namaKaryawanStr & "' , '" & kontakKaryawanStr & "' , '" & unameKaryawanStr & "' , '" & passwordKaryawanStr & "' );"

        'cmd = New OleDbCommand(queryInsert, conn)
        'cmd.ExecuteNonQuery()
        'dr = cmd.ExecuteReaders
        'If dr.Read Then
        '    MsgBox("Data Berhasil Ditambahkan")
        'Else
        '    MsgBox("Cek lagi ya")
        'End If
        'Dim query As String = String.Empty
        'query = "INSERT INTO T_Kasir (ID_Kasir, Nama_Kasir, No_Telp, Uname, [Password])" & _
        '        "VALUES (?, ?, ?, ?, ?)"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Try
            str = "SELECT COUNT(`USERNAME`) FROM `Tabel Pegawai` WHERE `USERNAME` = '" & unameKaryawanStr & "'"
            cmd = New OleDbCommand(str, conn)
            Dim duplicateFound = cmd.ExecuteScalar()

            'Buat nyari ada username yang sama atau nggak. Kalo ada yang sama, input gagal
            If duplicateFound > 0 Then
                MsgBox("Username telah dipakai!")
            ElseIf duplicateFound = 0 Then
                Try
                    str = "INSERT INTO `Tabel Pegawai` ([ID PEGAWAI], [NAMA PEGAWAI], [NO TELP], [USERNAME], [PASSWORD], [ROLE])" & _
                    "VALUES (@idKasir, @namaKasir, @noTelp, @uname, @passw, @role)"

                    cmd = New OleDbCommand(str, conn)
                    cmd.Parameters.AddWithValue("@idKasir", idKaryawanStr)
                    cmd.Parameters.AddWithValue("@namaKasir", namaKaryawanStr)
                    cmd.Parameters.AddWithValue("@noTelp", kontakKaryawanStr)
                    cmd.Parameters.AddWithValue("@uname", unameKaryawanStr)
                    cmd.Parameters.AddWithValue("@passw", passwordKaryawanStr)
                    cmd.Parameters.AddWithValue("@role", roleKaryawanStr)

                    cmd.ExecuteNonQuery()
                    clear()

                    MsgBox("Karyawan dengan nama: " + namaKaryawanStr + ", dan role: " + roleKaryawanStr + " telah berhasil didaftarkan!")
                Catch ex As Exception
                    MsgBox("ID telah dipakai!")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Query error!")
        End Try

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear()
    End Sub

    Private Sub F_InputDataKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()

        'buat ngisi combobox-nya
        fillRoleComboBox()

        'supaya id pegawainya auto increment
        autoIncrementIDPegawai()
        'MsgBox(TxtIDKaryawan.Text)
    End Sub
End Class
