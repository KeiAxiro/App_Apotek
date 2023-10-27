Public Class Form_Admin
    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub Form_Admin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call LogOut()
    End Sub
    Sub LogOut()
        Form1.Show()
        Me.Dispose()
    End Sub
End Class