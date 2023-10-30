<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_KelolaUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel_KelolaUser = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Panel_KelolaUser
        '
        Me.Panel_KelolaUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_KelolaUser.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KelolaUser.Name = "Panel_KelolaUser"
        Me.Panel_KelolaUser.Size = New System.Drawing.Size(784, 411)
        Me.Panel_KelolaUser.TabIndex = 0
        '
        'Form_Admin_KelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.Panel_KelolaUser)
        Me.Name = "Form_Admin_KelolaUser"
        Me.Text = "Form_Admin_KelolaUser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_KelolaUser As Panel
End Class
