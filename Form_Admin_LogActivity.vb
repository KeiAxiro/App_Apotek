Public Class Form_Admin_LogActivity


    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click

        Call Show_DataGrid_Log()
    End Sub
    Private Sub Panel_Log_ControlAdded(sender As Object, e As EventArgs) Handles Panel_Log.ParentChanged

        Call Show_DataGrid_Log()
    End Sub
    Sub Show_DataGrid_Log()
        Call Koneksi()
        Dim GetDataLog As String = "SELECT Tbl_Log.*,Nama_User FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User"
        Sda = New SqlClient.SqlDataAdapter(GetDataLog, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Log")

        DataGridView_Log.DataSource = Ds.Tables("Tbl_Log")
    End Sub

    Private Sub Form_Admin_LogActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class