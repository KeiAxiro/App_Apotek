<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.Button_KelolaLaporan = New System.Windows.Forms.Button()
        Me.Button_KelolaObat = New System.Windows.Forms.Button()
        Me.Button_KelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Kanan = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_Kanan)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 411)
        Me.SplitContainer1.SplitterDistance = 197
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_Logout)
        Me.Panel1.Controls.Add(Me.Button_KelolaLaporan)
        Me.Panel1.Controls.Add(Me.Button_KelolaObat)
        Me.Panel1.Controls.Add(Me.Button_KelolaUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 411)
        Me.Panel1.TabIndex = 1
        '
        'Button_Logout
        '
        Me.Button_Logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Logout.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Logout.Location = New System.Drawing.Point(3, 364)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Size = New System.Drawing.Size(191, 42)
        Me.Button_Logout.TabIndex = 1
        Me.Button_Logout.Text = "Logout"
        Me.Button_Logout.UseVisualStyleBackColor = True
        '
        'Button_KelolaLaporan
        '
        Me.Button_KelolaLaporan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_KelolaLaporan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaLaporan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_KelolaLaporan.Location = New System.Drawing.Point(3, 318)
        Me.Button_KelolaLaporan.Name = "Button_KelolaLaporan"
        Me.Button_KelolaLaporan.Size = New System.Drawing.Size(191, 42)
        Me.Button_KelolaLaporan.TabIndex = 1
        Me.Button_KelolaLaporan.Text = "Kelola Laporan"
        Me.Button_KelolaLaporan.UseVisualStyleBackColor = True
        '
        'Button_KelolaObat
        '
        Me.Button_KelolaObat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KelolaObat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_KelolaObat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaObat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_KelolaObat.Location = New System.Drawing.Point(3, 273)
        Me.Button_KelolaObat.Name = "Button_KelolaObat"
        Me.Button_KelolaObat.Size = New System.Drawing.Size(191, 42)
        Me.Button_KelolaObat.TabIndex = 1
        Me.Button_KelolaObat.Text = "Kelola Obat"
        Me.Button_KelolaObat.UseVisualStyleBackColor = True
        '
        'Button_KelolaUser
        '
        Me.Button_KelolaUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_KelolaUser.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_KelolaUser.Location = New System.Drawing.Point(3, 228)
        Me.Button_KelolaUser.Name = "Button_KelolaUser"
        Me.Button_KelolaUser.Size = New System.Drawing.Size(191, 42)
        Me.Button_KelolaUser.TabIndex = 1
        Me.Button_KelolaUser.Text = "Kelola User"
        Me.Button_KelolaUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.App_Apotek.My.Resources.Resources.Ryo_Yamada
        Me.PictureBox1.Location = New System.Drawing.Point(32, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel_Kanan
        '
        Me.Panel_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Kanan.Name = "Panel_Kanan"
        Me.Panel_Kanan.Size = New System.Drawing.Size(583, 411)
        Me.Panel_Kanan.TabIndex = 0
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Admin"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Button_KelolaLaporan As Button
    Friend WithEvents Button_KelolaObat As Button
    Friend WithEvents Button_KelolaUser As Button
    Friend WithEvents Panel_Kanan As Panel
End Class
