Imports System.Data.SqlClient

Public Class Form_Admin_LogActivity


    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        Call Show_DataGrid_Log_PerDate()
    End Sub

    Private Sub Panel_Log_ControlAdded(sender As Object, e As EventArgs) Handles Panel_Log.ParentChanged

        Call Show_DataGrid_Log()
    End Sub
    Sub Show_DataGrid_Log()
        Call Koneksi()
        Dim dateValue As Date = DateTimePicker_Log.Value.Date
        Dim GetDateNow As Date = Date.Now

        dateValue = Format(dateValue, "yyyy-MM-dd 00:00:00").ToString
        Dim GetDataLog As String = "SELECT Tbl_Log.*,Nama_User FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User ORDER BY Tbl_Log.Waktu"
        Dim Cmd As New SqlCommand(GetDataLog, Conn)
        Cmd.Parameters.AddWithValue("@DateNow", GetDateNow)
        Cmd.Parameters.AddWithValue("@Waktu", dateValue)
        Sda = New SqlClient.SqlDataAdapter(Cmd)

        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Log")

        DataGridView_Log.DataSource = Ds.Tables("Tbl_Log")
    End Sub

    Sub Show_DataGrid_Log_PerDate()
        Call Koneksi()
        Dim dateValue As Date = DateTimePicker_Log.Value.Date
        Dim GetDateNow As Date = Date.Now

        dateValue = Format(dateValue, "yyyy-MM-dd 00:00:00").ToString
        Dim GetDataLog As String = "SELECT Tbl_Log.*,Nama_User FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User WHERE Tbl_Log.Waktu > @Waktu AND Tbl_Log.Waktu < @DateNow ORDER BY Tbl_Log.Waktu"
        Dim Cmd As New SqlCommand(GetDataLog, Conn)
        Cmd.Parameters.AddWithValue("@DateNow", GetDateNow)
        Cmd.Parameters.AddWithValue("@Waktu", dateValue)
        Sda = New SqlClient.SqlDataAdapter(Cmd)

        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Log")

        DataGridView_Log.DataSource = Ds.Tables("Tbl_Log")
    End Sub

    Private Sub DateTimePicker_Log_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_Log.ValueChanged
        Call Show_DataGrid_Log_PerDate()
    End Sub
End Class