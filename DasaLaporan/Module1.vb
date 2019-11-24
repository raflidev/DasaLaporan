Imports System.Data.Odbc
Module Module1
    'name space = ruang kerja database

    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader

    Public Sub koneksi()

        conn = New OdbcConnection("dsn=dasa")
        conn.Open()

    End Sub

End Module

