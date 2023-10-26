Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module_Db_Connection
    Public MyDB As String
    Public Conn As SqlConnection
    Public Srd As SqlDataReader
    Public Sda As SqlDataAdapter
    Public Ds As DataSet

    Sub Koneksi()
        MyDB = "Data Source=desktop-ig5qtru\sqlexpress;User ID=keidjaru;Password=kei;initial catalog=Db_Apotek;Connect Timeout=30;Encrypt=False;"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Try
                Conn.Open()
            Catch ex As Exception
                'MsgBox(ex)
            End Try
        End If
    End Sub
End Module
