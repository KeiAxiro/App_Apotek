Public Class Form_Admin
    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        Call Kondisi_Awal()
    End Sub
    Private Sub Form_Admin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Form1.Hide()
        Call Kondisi_Awal()
    End Sub

    Sub Kondisi_Awal()
        Call ChangeChildPanel(Panel_Kanan, Form_Admin_LogActivity.Panel_Log)
    End Sub

    Private Sub Form_Admin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call LogOut()
    End Sub
    Sub LogOut()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Call LogOut()
    End Sub
    Public Sub ChangeChildPanel(ByVal panel As Panel, ByVal newChild As Panel)

        ' Sembunyikan panel anak saat ini
        panel.Controls.Clear()
        ' Tampilkan panel anak 
        panel.Controls.Add(newChild)
        newChild.BringToFront()
        ' Set focus ke panel anak baru
        newChild.Focus()

    End Sub

    Private Sub Button_KelolaUser_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser.Click
        ChangeChildPanel(Panel_Kanan, Form_Admin_KelolaUser.Panel_KelolaUser)
    End Sub


End Class