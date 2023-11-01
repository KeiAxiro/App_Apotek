Public Class Form_Admin_KelolaUser
    Private Sub Form_Admin_KelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer1.SplitterDistance = Panel_KelolaUser_Container.Width / 2
    End Sub

    Private Sub SplitContainer1_SplitterPaint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 200, 0), 90)
        Dim LocationSplitter As Integer = SplitContainer1.SplitterDistance
        Dim SplitterSize = SplitContainer1.Size
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(LocationSplitter, 20), New Point(LocationSplitter, SplitterSize.Width))
        End Using
    End Sub
End Class