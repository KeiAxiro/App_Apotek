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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_KelolaUser_Container = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel_Input_Kiri = New System.Windows.Forms.Panel()
        Me.Panel_Telepon = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_Nama = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_TipeUser = New System.Windows.Forms.Panel()
        Me.ComboBox_KelolaUser_TipeUser = New System.Windows.Forms.ComboBox()
        Me.Label_TipeUser = New System.Windows.Forms.Label()
        Me.Panel_Input_Kanan = New System.Windows.Forms.Panel()
        Me.Panel_Alamat = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label_Alamat = New System.Windows.Forms.Label()
        Me.Panel_Password = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Username = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_KelolaUser_Container.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel_Input_Kiri.SuspendLayout()
        Me.Panel_Telepon.SuspendLayout()
        Me.Panel_Nama.SuspendLayout()
        Me.Panel_TipeUser.SuspendLayout()
        Me.Panel_Input_Kanan.SuspendLayout()
        Me.Panel_Alamat.SuspendLayout()
        Me.Panel_Password.SuspendLayout()
        Me.Panel_Username.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-398, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(784, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_KelolaUser_Container
        '
        Me.Panel_KelolaUser_Container.Controls.Add(Me.SplitContainer1)
        Me.Panel_KelolaUser_Container.Location = New System.Drawing.Point(4, 45)
        Me.Panel_KelolaUser_Container.Name = "Panel_KelolaUser_Container"
        Me.Panel_KelolaUser_Container.Size = New System.Drawing.Size(657, 294)
        Me.Panel_KelolaUser_Container.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_Input_Kiri)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_Input_Kanan)
        Me.SplitContainer1.Size = New System.Drawing.Size(657, 207)
        Me.SplitContainer1.SplitterDistance = 328
        Me.SplitContainer1.TabIndex = 3
        '
        'Panel_Input_Kiri
        '
        Me.Panel_Input_Kiri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Input_Kiri.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Input_Kiri.Controls.Add(Me.Panel_Telepon)
        Me.Panel_Input_Kiri.Controls.Add(Me.Panel_Nama)
        Me.Panel_Input_Kiri.Controls.Add(Me.Panel_TipeUser)
        Me.Panel_Input_Kiri.Location = New System.Drawing.Point(1, 1)
        Me.Panel_Input_Kiri.Name = "Panel_Input_Kiri"
        Me.Panel_Input_Kiri.Size = New System.Drawing.Size(324, 202)
        Me.Panel_Input_Kiri.TabIndex = 1
        '
        'Panel_Telepon
        '
        Me.Panel_Telepon.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Telepon.Controls.Add(Me.TextBox4)
        Me.Panel_Telepon.Controls.Add(Me.Label4)
        Me.Panel_Telepon.Location = New System.Drawing.Point(0, 134)
        Me.Panel_Telepon.Name = "Panel_Telepon"
        Me.Panel_Telepon.Size = New System.Drawing.Size(326, 67)
        Me.Panel_Telepon.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(15, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(299, 26)
        Me.TextBox4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telepon"
        '
        'Panel_Nama
        '
        Me.Panel_Nama.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Nama.Controls.Add(Me.TextBox2)
        Me.Panel_Nama.Controls.Add(Me.Label2)
        Me.Panel_Nama.Location = New System.Drawing.Point(0, 67)
        Me.Panel_Nama.Name = "Panel_Nama"
        Me.Panel_Nama.Size = New System.Drawing.Size(326, 67)
        Me.Panel_Nama.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(15, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(299, 26)
        Me.TextBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Panel_TipeUser
        '
        Me.Panel_TipeUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_TipeUser.Controls.Add(Me.ComboBox_KelolaUser_TipeUser)
        Me.Panel_TipeUser.Controls.Add(Me.Label_TipeUser)
        Me.Panel_TipeUser.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TipeUser.Name = "Panel_TipeUser"
        Me.Panel_TipeUser.Size = New System.Drawing.Size(326, 67)
        Me.Panel_TipeUser.TabIndex = 0
        '
        'ComboBox_KelolaUser_TipeUser
        '
        Me.ComboBox_KelolaUser_TipeUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_KelolaUser_TipeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_KelolaUser_TipeUser.FormattingEnabled = True
        Me.ComboBox_KelolaUser_TipeUser.Location = New System.Drawing.Point(15, 30)
        Me.ComboBox_KelolaUser_TipeUser.Name = "ComboBox_KelolaUser_TipeUser"
        Me.ComboBox_KelolaUser_TipeUser.Size = New System.Drawing.Size(299, 28)
        Me.ComboBox_KelolaUser_TipeUser.TabIndex = 1
        '
        'Label_TipeUser
        '
        Me.Label_TipeUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_TipeUser.AutoSize = True
        Me.Label_TipeUser.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TipeUser.Location = New System.Drawing.Point(12, 4)
        Me.Label_TipeUser.Name = "Label_TipeUser"
        Me.Label_TipeUser.Size = New System.Drawing.Size(71, 18)
        Me.Label_TipeUser.TabIndex = 0
        Me.Label_TipeUser.Text = "Tipe User"
        '
        'Panel_Input_Kanan
        '
        Me.Panel_Input_Kanan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Input_Kanan.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Input_Kanan.Controls.Add(Me.Panel_Alamat)
        Me.Panel_Input_Kanan.Controls.Add(Me.Panel_Password)
        Me.Panel_Input_Kanan.Controls.Add(Me.Panel_Username)
        Me.Panel_Input_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Input_Kanan.Name = "Panel_Input_Kanan"
        Me.Panel_Input_Kanan.Size = New System.Drawing.Size(323, 202)
        Me.Panel_Input_Kanan.TabIndex = 1
        '
        'Panel_Alamat
        '
        Me.Panel_Alamat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Alamat.Controls.Add(Me.Label1)
        Me.Panel_Alamat.Controls.Add(Me.TextBox1)
        Me.Panel_Alamat.Controls.Add(Me.Label_Alamat)
        Me.Panel_Alamat.Location = New System.Drawing.Point(1, 1)
        Me.Panel_Alamat.Name = "Panel_Alamat"
        Me.Panel_Alamat.Size = New System.Drawing.Size(324, 67)
        Me.Panel_Alamat.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label_Alamat
        '
        Me.Label_Alamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Alamat.AutoSize = True
        Me.Label_Alamat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Alamat.Location = New System.Drawing.Point(12, 4)
        Me.Label_Alamat.Name = "Label_Alamat"
        Me.Label_Alamat.Size = New System.Drawing.Size(53, 18)
        Me.Label_Alamat.TabIndex = 0
        Me.Label_Alamat.Text = "Alamat"
        '
        'Panel_Password
        '
        Me.Panel_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Password.Controls.Add(Me.TextBox5)
        Me.Panel_Password.Controls.Add(Me.Label5)
        Me.Panel_Password.Location = New System.Drawing.Point(1, 135)
        Me.Panel_Password.Name = "Panel_Password"
        Me.Panel_Password.Size = New System.Drawing.Size(324, 67)
        Me.Panel_Password.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(15, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(297, 26)
        Me.TextBox5.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Password"
        '
        'Panel_Username
        '
        Me.Panel_Username.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Username.Controls.Add(Me.TextBox3)
        Me.Panel_Username.Controls.Add(Me.Label3)
        Me.Panel_Username.Location = New System.Drawing.Point(1, 68)
        Me.Panel_Username.Name = "Panel_Username"
        Me.Panel_Username.Size = New System.Drawing.Size(324, 67)
        Me.Panel_Username.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(15, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(297, 26)
        Me.TextBox3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Username"
        '
        'Form_Admin_KelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 351)
        Me.Controls.Add(Me.Panel_KelolaUser_Container)
        Me.Name = "Form_Admin_KelolaUser"
        Me.Text = "Form_Admin_KelolaUser"
        Me.Panel_KelolaUser_Container.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel_Input_Kiri.ResumeLayout(False)
        Me.Panel_Telepon.ResumeLayout(False)
        Me.Panel_Telepon.PerformLayout()
        Me.Panel_Nama.ResumeLayout(False)
        Me.Panel_Nama.PerformLayout()
        Me.Panel_TipeUser.ResumeLayout(False)
        Me.Panel_TipeUser.PerformLayout()
        Me.Panel_Input_Kanan.ResumeLayout(False)
        Me.Panel_Alamat.ResumeLayout(False)
        Me.Panel_Alamat.PerformLayout()
        Me.Panel_Password.ResumeLayout(False)
        Me.Panel_Password.PerformLayout()
        Me.Panel_Username.ResumeLayout(False)
        Me.Panel_Username.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_KelolaUser_Container As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel_Input_Kiri As Panel
    Friend WithEvents Panel_Telepon As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_Nama As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_TipeUser As Panel
    Friend WithEvents ComboBox_KelolaUser_TipeUser As ComboBox
    Friend WithEvents Label_TipeUser As Label
    Friend WithEvents Panel_Input_Kanan As Panel
    Friend WithEvents Panel_Alamat As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label_Alamat As Label
    Friend WithEvents Panel_Password As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_Username As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
End Class
