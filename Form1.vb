Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim Pen As New Pen(Color.Green, 20)
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(Panel1.Width, 0), New Point(Panel1.Width, Panel1.Height))
        End Using
    End Sub
End Class
