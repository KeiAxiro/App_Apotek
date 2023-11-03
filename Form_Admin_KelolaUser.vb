Imports Microsoft.Azure.Management.Sql.Models

Public Class Form_Admin_KelolaUser

    Private Sub Panel_KelolaUser_Container_ControlAdded(sender As Object, e As ControlEventArgs) Handles Panel_KelolaUser_Container.ControlAdded
        Call Show_Grid_User()

    End Sub

    Private Sub SplitContainer1_SplitterPaint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 200, 0), 199)
        Dim LocationSplitter As Integer = SplitContainer1.SplitterDistance
        Dim SplitterSize = SplitContainer1.Size
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(LocationSplitter, 20), New Point(LocationSplitter, SplitterSize.Width))
        End Using
    End Sub

    Private Sub Panel_KelolaUser_All_Paint(sender As Object, e As PaintEventArgs) Handles Panel_KelolaUser_Nama.Paint, Panel_KelolaUser_Telepon.Paint, Panel_KelolaUser_Alamat.Paint, Panel_KelolaUser_Username.Paint, Panel_KelolaUser_Password.Paint
        Dim Pen As New Pen(Color.FromArgb(160, 0, 0, 0), 3)
        Dim PWidth As Integer = Panel_KelolaUser_Nama.Width
        Dim Pheight As Integer = Panel_KelolaUser_Nama.Height
        Dim Gap As Integer = 20

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Pheight), New Point(PWidth, Pheight))
        End Using
    End Sub

    Sub Show_Grid_User()
        Call Koneksi()
        Dim GetDatUser As String = "SELECT * FROM Tbl_User"
        Sda = New SqlClient.SqlDataAdapter(GetDatUser, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_User")

        DataGridView_KelolaUSer.DataSource = Ds.Tables("Tbl_User")

    End Sub



    Private Sub DataGridView_KelolaUSer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_KelolaUSer.CellClick
        If e.RowIndex >= 0 Then

        End If
    End Sub

    Private Sub Form_Admin_KelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class