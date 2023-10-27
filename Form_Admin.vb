Public Class Form_Admin
    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Sub Border_Radius()

    End Sub

    Private Sub Form_Admin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call LogOut()
    End Sub
    Sub LogOut()
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Call LogOut()
    End Sub
    Private Sub ChangeChildPanel(ByVal panel As Panel, ByVal newChild As Panel, v As Integer)

        ' Sembunyikan panel anak saat ini
        panel.Controls.Remove(panel)

        ' Tampilkan panel anak baru
        panel.Controls.Add(newChild)

        ' Set focus ke panel anak baru
        newChild.Focus()

    End Sub
End Class