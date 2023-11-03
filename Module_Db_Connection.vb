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
        'MyDB = "Data Source=DESKTOP-34EMTUJ;User ID=keidjaru;Password=kei;initial catalog=Db_Apotek;Connect Timeout=30;Encrypt=False;"

        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Try
                Conn.Open()
            Catch ex As Exception
                Conn.Close()
                MsgBox(ex)
            End Try
        End If
    End Sub

    Sub WriteLog(Aktivitas As String, Id_User As Integer)
        Call Koneksi()
        Dim InsertLog As String = "INSERT INTO Tbl_Log(Waktu,Aktivitas,Id_User) VALUES(@DateNow,@Aktivitas,@Id_User)"
        Dim Cmd As New SqlCommand(InsertLog, Conn)
        Cmd.Parameters.AddWithValue("@DateNow", DateTime.Now)
        Cmd.Parameters.AddWithValue("@Aktivitas", Aktivitas)
        Cmd.Parameters.AddWithValue("@Id_User", Id_User)
        Cmd.ExecuteNonQuery()

    End Sub

End Module
