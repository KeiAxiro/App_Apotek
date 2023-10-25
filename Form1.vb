Imports System.Drawing.Imaging

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim Pen As New Pen(Color.Green, 15)
        Dim Gap As Integer = 50
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(Panel1.Width, Gap), New Point(Panel1.Width, Panel1.Height - Gap))
            e.Graphics.DrawLine(Pen, New Point(0, Gap), New Point(0, Panel1.Height - Gap))
        End Using
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint, Panel3.Paint
        Dim Pen As New Pen(Color.FromArgb(160, 0, 0, 0), 2)

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Panel2.Height), New Point(Panel2.Width, Panel2.Height))
        End Using
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

End Class
