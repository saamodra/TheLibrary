Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String
    Public Username As String = ""
    Public Str As String

    Public Sub Koneksi()
        lokasidata = "provider=Microsoft.ACE.OLEDB.12.0;data source=db_perpus.accdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub SqlSimpan(ByVal sQl As String)
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call Koneksi()
        Try
            objcmd.Connection = conn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sQl
            objcmd.ExecuteNonQuery()
            objcmd.Dispose()
            MsgBox("Data Berhasil disimpan", MsgBoxStyle.Information, "Berhasil")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal")
        End Try
    End Sub
    Sub SqlUpdate(ByVal sQl As String)
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call Koneksi()
        Try
            objcmd.Connection = conn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sQl
            objcmd.ExecuteNonQuery()
            objcmd.Dispose()
            MsgBox("Data Berhasil diupdate", MsgBoxStyle.Information, "Berhasil")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal")
        End Try
    End Sub
    Sub SqlDelete(ByVal sQl As String)
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call Koneksi()
        Try
            objcmd.Connection = conn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sQl
            objcmd.ExecuteNonQuery()
            objcmd.Dispose()
            MsgBox("Data Berhasil dihapus", MsgBoxStyle.Information, "Berhasil")
        Catch ex As Exception
            MsgBox("Gagal Menghapus data", MsgBoxStyle.Critical, "Gagal")
        End Try
    End Sub
End Module