Imports System.Data.SqlClient
Imports Microsoft.Azure.Management.Sql.Models

Public Class Form_Admin_KelolaUser

    Sub Kondisi_Awal()
        Call Kondisi_Input(False)
        Call Show_Grid_User()

        Button_KelolaUser_Tambah.Enabled = True
        Button_KelolaUser_Edit.Enabled = False
        Button_KelolaUser_Hapus.Enabled = False

    End Sub
    Sub Kondisi_Input(kondisi)
        ComboBox_KelolaUser_TipeUser.Enabled = kondisi
        TextBox_KelolaUser_NamaUser.Enabled = kondisi
        TextBox_KelolaUser_Telepon.Enabled = kondisi
        TextBox_KelolaUser_Alamat.Enabled = kondisi
        TextBox_KelolaUser_Username.Enabled = kondisi
        TextBox_KelolaUser_Password.Enabled = kondisi
    End Sub
    Sub Clear_Input()
        ComboBox_KelolaUser_TipeUser.Text = ""
        TextBox_KelolaUser_NamaUser.Clear()
        TextBox_KelolaUser_Telepon.Clear()
        TextBox_KelolaUser_Alamat.Clear()
        TextBox_KelolaUser_Username.Clear()
        TextBox_KelolaUser_Password.Clear()
    End Sub
    Private Sub Button_KelolaUser_Tambah_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser_Tambah.Click
        If Button_KelolaUser_Tambah.Text.ToLower = "tambah" Then
            Button_KelolaUser_Tambah.Text = "Simpan"
            Button_KelolaUser_Hapus.Text = "Cancel"
        ElseIf Button_KelolaUser_Tambah.Text.ToLower = "simpan" Then
            Button_KelolaUser_Tambah.Text = "Tambah"
            Button_KelolaUser_Hapus.Text = "Hapus"
        End If
    End Sub

    ' Load
    Private Sub Panel_KelolaUser_Container_ControlAdded(sender As Object, e As ControlEventArgs) Handles Panel_KelolaUser_Container.ControlAdded
        Call Kondisi_Awal()
    End Sub

    'Ijo IJo
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
        Dim GetDataUser As String = "SELECT * FROM Tbl_User"
        Sda = New SqlClient.SqlDataAdapter(GetDataUser, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_User")

        DataGridView_KelolaUSer.DataSource = Ds.Tables("Tbl_User")

    End Sub


    Private Sub DataGridView_KelolaUSer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_KelolaUSer.CellClick
        If e.RowIndex >= 0 Then
            Call Koneksi()

            Dim SelectedRow As DataGridViewRow = DataGridView_KelolaUSer.Rows(e.RowIndex)
            Dim ValueCell As String = SelectedRow.Cells(0).Value.ToString

            Dim GetDataUserFromId As String = "SELECT * FROM Tbl_User Where Id_User = @Id_User"
            Dim Cmd As New SqlCommand(GetDataUserFromId, Conn)
            Cmd.Parameters.AddWithValue("@Id_User", ValueCell)
            Srd = Cmd.ExecuteReader
            Srd.Read()
            If Srd.HasRows Then
                ComboBox_KelolaUser_TipeUser.Text = Srd.Item("Tipe_User")
                TextBox_KelolaUser_NamaUser.Text = Srd.Item("Nama_User")
                TextBox_KelolaUser_Telepon.Text = Srd.Item("Telepon")
                TextBox_KelolaUser_Alamat.Text = Srd.Item("Alamat")
                TextBox_KelolaUser_Username.Text = Srd.Item("Username")
                TextBox_KelolaUser_Password.Text = Srd.Item("Password")
            Else
                Call Button_KelolaUser_Tambah_Click(sender, e)
                Srd.Close()
            End If
        End If
    End Sub

End Class