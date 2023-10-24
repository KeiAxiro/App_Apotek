Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module_Db_Connection
    Sub Koneksi()
        Dim MyDB As String = "Data Source=desktop-ig5qtru\sqlexpress;User ID=keidjaru;Password=kei;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
        Dim conn As New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub
End Module
