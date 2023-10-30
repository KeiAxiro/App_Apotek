<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox_LogoFarmasi = New System.Windows.Forms.PictureBox()
        Me.Label_NamaApp = New System.Windows.Forms.Label()
        Me.Panel_Kanan = New System.Windows.Forms.Panel()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label_Silahkan = New System.Windows.Forms.Label()
        Me.Panel_InputPassword = New System.Windows.Forms.Panel()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_InputUsername = New System.Windows.Forms.Panel()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.PictureBox_LogoAtas = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox_LogoFarmasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Kanan.SuspendLayout()
        Me.Panel_InputPassword.SuspendLayout()
        Me.Panel_InputUsername.SuspendLayout()
        CType(Me.PictureBox_LogoAtas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox_LogoFarmasi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_NamaApp)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_Kanan)
        Me.SplitContainer1.Size = New System.Drawing.Size(780, 407)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 1
        '
        'PictureBox_LogoFarmasi
        '
        Me.PictureBox_LogoFarmasi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_LogoFarmasi.BackgroundImage = Global.App_Apotek.My.Resources.Resources.apotek_portait
        Me.PictureBox_LogoFarmasi.Image = Global.App_Apotek.My.Resources.Resources.apotek_portait
        Me.PictureBox_LogoFarmasi.Location = New System.Drawing.Point(27, 189)
        Me.PictureBox_LogoFarmasi.Name = "PictureBox_LogoFarmasi"
        Me.PictureBox_LogoFarmasi.Size = New System.Drawing.Size(138, 167)
        Me.PictureBox_LogoFarmasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_LogoFarmasi.TabIndex = 2
        Me.PictureBox_LogoFarmasi.TabStop = False
        '
        'Label_NamaApp
        '
        Me.Label_NamaApp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_NamaApp.AutoSize = True
        Me.Label_NamaApp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label_NamaApp.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NamaApp.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label_NamaApp.Location = New System.Drawing.Point(38, 50)
        Me.Label_NamaApp.Name = "Label_NamaApp"
        Me.Label_NamaApp.Size = New System.Drawing.Size(127, 78)
        Me.Label_NamaApp.TabIndex = 3
        Me.Label_NamaApp.Text = "APLIKASI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "APOTEK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XYZ"
        Me.Label_NamaApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Kanan
        '
        Me.Panel_Kanan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Kanan.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Kanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_Kanan.Controls.Add(Me.Button_Reset)
        Me.Panel_Kanan.Controls.Add(Me.Button_Login)
        Me.Panel_Kanan.Controls.Add(Me.Label_Silahkan)
        Me.Panel_Kanan.Controls.Add(Me.Panel_InputPassword)
        Me.Panel_Kanan.Controls.Add(Me.Panel_InputUsername)
        Me.Panel_Kanan.Controls.Add(Me.PictureBox_LogoAtas)
        Me.Panel_Kanan.Location = New System.Drawing.Point(66, 13)
        Me.Panel_Kanan.Name = "Panel_Kanan"
        Me.Panel_Kanan.Size = New System.Drawing.Size(450, 380)
        Me.Panel_Kanan.TabIndex = 1
        '
        'Button_Reset
        '
        Me.Button_Reset.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reset.Location = New System.Drawing.Point(273, 312)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(102, 32)
        Me.Button_Reset.TabIndex = 4
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'Button_Login
        '
        Me.Button_Login.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.Location = New System.Drawing.Point(75, 312)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(102, 32)
        Me.Button_Login.TabIndex = 3
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Label_Silahkan
        '
        Me.Label_Silahkan.AutoSize = True
        Me.Label_Silahkan.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Silahkan.Location = New System.Drawing.Point(126, 107)
        Me.Label_Silahkan.Name = "Label_Silahkan"
        Me.Label_Silahkan.Size = New System.Drawing.Size(207, 25)
        Me.Label_Silahkan.TabIndex = 4
        Me.Label_Silahkan.Text = "Silahkan Login Dahulu!"
        '
        'Panel_InputPassword
        '
        Me.Panel_InputPassword.Controls.Add(Me.TextBox_Password)
        Me.Panel_InputPassword.Controls.Add(Me.Label4)
        Me.Panel_InputPassword.Location = New System.Drawing.Point(75, 228)
        Me.Panel_InputPassword.Name = "Panel_InputPassword"
        Me.Panel_InputPassword.Size = New System.Drawing.Size(300, 58)
        Me.Panel_InputPassword.TabIndex = 2
        '
        'TextBox_Password
        '
        Me.TextBox_Password.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Password.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(0, 32)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(300, 23)
        Me.TextBox_Password.TabIndex = 2
        Me.TextBox_Password.Text = "kei"
        Me.TextBox_Password.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Panel_InputUsername
        '
        Me.Panel_InputUsername.Controls.Add(Me.TextBox_Username)
        Me.Panel_InputUsername.Controls.Add(Me.Label_Username)
        Me.Panel_InputUsername.Location = New System.Drawing.Point(75, 164)
        Me.Panel_InputUsername.Name = "Panel_InputUsername"
        Me.Panel_InputUsername.Size = New System.Drawing.Size(300, 58)
        Me.Panel_InputUsername.TabIndex = 1
        '
        'TextBox_Username
        '
        Me.TextBox_Username.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Username.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(0, 32)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(300, 23)
        Me.TextBox_Username.TabIndex = 1
        Me.TextBox_Username.Text = "kei"
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.Location = New System.Drawing.Point(0, 0)
        Me.Label_Username.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(105, 23)
        Me.Label_Username.TabIndex = 2
        Me.Label_Username.Text = "Username" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox_LogoAtas
        '
        Me.PictureBox_LogoAtas.Image = Global.App_Apotek.My.Resources.Resources.Logo_Pharmacie_780x560_removebg_preview
        Me.PictureBox_LogoAtas.Location = New System.Drawing.Point(187, 9)
        Me.PictureBox_LogoAtas.Name = "PictureBox_LogoAtas"
        Me.PictureBox_LogoAtas.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox_LogoAtas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_LogoAtas.TabIndex = 7
        Me.PictureBox_LogoAtas.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 407)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Login Apotek"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox_LogoFarmasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Kanan.ResumeLayout(False)
        Me.Panel_Kanan.PerformLayout()
        Me.Panel_InputPassword.ResumeLayout(False)
        Me.Panel_InputPassword.PerformLayout()
        Me.Panel_InputUsername.ResumeLayout(False)
        Me.Panel_InputUsername.PerformLayout()
        CType(Me.PictureBox_LogoAtas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox_LogoFarmasi As PictureBox
    Friend WithEvents Label_NamaApp As Label
    Friend WithEvents Panel_Kanan As Panel
    Friend WithEvents Button_Reset As Button
    Friend WithEvents Button_Login As Button
    Friend WithEvents Label_Silahkan As Label
    Friend WithEvents Panel_InputPassword As Panel
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_InputUsername As Panel
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Label_Username As Label
    Friend WithEvents PictureBox_LogoAtas As PictureBox

End Class
