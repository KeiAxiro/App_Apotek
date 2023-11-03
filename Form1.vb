Imports System.Data.SqlClient

Class Form1

    Private Sub Panel_Kanan_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Kanan.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 200, 0), 15)
        Dim Gap As Integer = 50
        Dim Pwidth As Integer = Panel_Kanan.Width
        Dim Pheight As Integer = Panel_Kanan.Height
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Gap), New Point(0, Pheight - Gap))
            e.Graphics.DrawLine(Pen, New Point(Pwidth, Gap), New Point(Pwidth, Pheight - Gap))

        End Using
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextBox_Username.Clear()
        TextBox_Password.Clear()
    End Sub

    Private Sub Panel_InputUsername_Paint(sender As Object, e As PaintEventArgs) Handles Panel_InputUsername.Paint, Panel_InputPassword.Paint
        Dim Pen As New Pen(Color.FromArgb(160, 0, 0, 0), 3)
        Dim PWidth As Integer = Panel_InputUsername.Width
        Dim Pheight As Integer = Panel_InputUsername.Height

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Pheight), New Point(PWidth, Pheight))
        End Using

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Call Login()
    End Sub


    Sub Login()
        Call Koneksi()
        Dim Login As String = "SELECT * FROM Tbl_User WHERE Username = @Username AND Password = @Password"


        Dim Cmd As New SqlCommand(Login, Conn)
        Cmd.Parameters.AddWithValue("@Username", TextBox_Username.Text)
        Cmd.Parameters.AddWithValue("@Password", TextBox_Password.Text)

        Srd = Cmd.ExecuteReader
        If Srd.HasRows Then
            Srd.Read()
            Dim Tipe_User As String = Srd.Item("Tipe_User")
            If Tipe_User = "ADMIN" Then
                Form_Admin.ShowDialog()
            ElseIf Tipe_User = "APOTEKER" Then

            ElseIf Tipe_User = "KASIR" Then
            End If
            Call WriteLog("Login", Srd.Item("Id_User"))
        Else
            MsgBox("Username Atau Password Salah!")
        End If
        Srd.Close()

    End Sub

    Private Sub TextBox_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Password.KeyPress, TextBox_Username.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub


End Class