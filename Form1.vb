Imports System.Drawing.Imaging

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub Kondisi_Awal()

        TextBox_Username.Focus()
    End Sub

    Private Sub Panel_Kanan_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Kanan.Paint
        Dim Pen As New Pen(Color.Green, 15)
        Dim Gap As Integer = 50
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(Panel_Kanan.Width, Gap), New Point(Panel_Kanan.Width, Panel_Kanan.Height - Gap))
            e.Graphics.DrawLine(Pen, New Point(0, Gap), New Point(0, Panel_Kanan.Height - Gap))
        End Using
    End Sub

    Private Sub InputText_Paint(sender As Object, e As PaintEventArgs) Handles Panel_InputUsername.Paint, Panel_InputPassword.Paint
        Dim Pen As New Pen(Color.FromArgb(160, 0, 0, 0), 2)

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Panel_InputUsername.Height), New Point(Panel_InputUsername.Width, Panel_InputUsername.Height))
        End Using
    End Sub


End Class
