Imports System.Data.OleDb
Module init

    Public str As String
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public rolePegawai As String

    Public Sub koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Kampus\Aplikasi Apotik\ApotekCobaCoba1.7\DB Apotek.accdb"
        'str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Aplikasi Apotik\MyProject\ApotekCobaCoba1.6\DB_Apotek.accdb"
        'str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Kampus\Lain-lain\ApotekCobaCoba1.6\DB_Apotek.accdb"
        'Nanti datasource diganti sesuai keperluan

        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
                'MsgBox("Koneksi berhasil")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

End Module