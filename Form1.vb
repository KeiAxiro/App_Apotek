Class Form1
    Private Sub Panel_Kanan_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Kanan.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 200, 0), 15)
        Dim Gap As Integer = 50
        Dim Pwidth As Integer = Panel_Kanan.Width
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Gap), New Point(0, Panel_Kanan.Height - Gap))
            e.Graphics.DrawLine(Pen, New Point(Pwidth, Gap), New Point(Pwidth, Panel_Kanan.Height - Gap))

        End Using
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextBox_Username.Clear()
        TextBox_Password.Clear()
    End Sub

    Private Sub Panel_InputUsername_Paint(sender As Object, e As PaintEventArgs) Handles Panel_InputUsername.Paint, Panel_InputPassword.Paint

    End Sub

End Class