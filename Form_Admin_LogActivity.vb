Public Class Form_Admin_LogActivity


    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        Call Show_DataGrid_Log()
    End Sub
    Private Sub Panel_Log_ControlAdded(sender As Object, e As ControlEventArgs) Handles Panel_Log.ControlAdded
        Call Show_DataGrid_Log()
    End Sub
    Sub Show_DataGrid_Log()
        Call Koneksi()
        Dim GetDataLog As String = "SELECT * FROM Tbl_Log"
        Sda = New SqlClient.SqlDataAdapter(GetDataLog, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Log")

        DataGridView_Log.DataSource = Ds.Tables("Tbl_Log")
    End Sub

End Class