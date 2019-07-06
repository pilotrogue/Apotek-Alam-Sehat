Imports System.Data.OleDb
Public Class f_login

    Private Sub fillComboBoxUsername()
        str = "SELECT `USERNAME` FROM `Tabel Pegawai`"
        Dim dataAdapter As New OleDbDataAdapter(str, conn)
        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "Tabel Supplier")

        ComboBox1.DataSource = dataSet.Tables(0)
        ComboBox1.ValueMember = "USERNAME"

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub clear()
        TextBox2.Clear()
    End Sub
    Private Sub LOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Me.Hide()
        str = "Select COUNT(*) from `Tabel Pegawai` WHERE username='" & ComboBox1.SelectedValue.ToString & "' and password = '" & TextBox2.Text & "'"
        cmd = New OleDbCommand(str, conn)
        Dim rowsFound As Integer = CInt(cmd.ExecuteScalar.ToString)
        Try
            If rowsFound = 1 Then
                str = "SELECT role FROM `Tabel Pegawai` WHERE username = '" & ComboBox1.SelectedValue.ToString & "'"
                cmd = New OleDbCommand(str, conn)

                rolePegawai = cmd.ExecuteScalar.ToString.ToLower

                If rolePegawai = "kasir" Then
                    FUser_Kasir.Show()
                    Me.Hide()

                ElseIf rolePegawai = "akuntan" Then
                    FUser_Akuntan.Show()
                    Me.Hide()

                ElseIf rolePegawai = "pemilik" Then
                    FUser_Pemilik.Show()
                    Me.Hide()

                ElseIf rolePegawai = "ka gudang" Then
                    FUser_KAGudang.Show()
                    Me.Hide()

                Else
                    MsgBox("Role tidak terdefinisi!")
                    Me.Show()
                End If
            Else
                MsgBox("Password Anda salah")
                Me.Show()
            End If
        Catch ex As Exception
            MsgBox("Login Gagal")
            Me.Show()
        End Try

        TextBox2.Clear()
    End Sub
    Private Sub KELUAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        MsgBox("Apakah anda yakin ingin keluar?")

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Application.Exit()
    End Sub

    Private Sub FORM_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init.koneksi()
        rolePegawai = ""
        fillComboBoxUsername()
    End Sub
End Class