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
        Me.Label_KelolaUser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_Telepon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel_KelolaUser_TipeUser = New System.Windows.Forms.Panel()
        Me.ComboBox_KelolaUser_TipeUser = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_KelolaUser_Nama = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_NamaUser = New System.Windows.Forms.TextBox()
        Me.Label_Nama = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_Alamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_Username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_KelolaUser_Container = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_CariUser = New System.Windows.Forms.TextBox()
        Me.Label_KelolaUser_Cari = New System.Windows.Forms.Label()
        Me.Button_KelolaUser_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Edit = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Tambah = New System.Windows.Forms.Button()
        Me.DataGridView_KelolaUSer = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel_KelolaUser_TipeUser.SuspendLayout()
        Me.Panel_KelolaUser_Nama.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel_KelolaUser_Container.SuspendLayout()
        CType(Me.DataGridView_KelolaUSer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_KelolaUser
        '
        Me.Label_KelolaUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_KelolaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaUser.Location = New System.Drawing.Point(0, 0)
        Me.Label_KelolaUser.Name = "Label_KelolaUser"
        Me.Label_KelolaUser.Size = New System.Drawing.Size(736, 22)
        Me.Label_KelolaUser.TabIndex = 2
        Me.Label_KelolaUser.Text = "Kelola User"
        Me.Label_KelolaUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 160)
        Me.Panel1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_KelolaUser_TipeUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_KelolaUser_Nama)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 160)
        Me.SplitContainer1.SplitterDistance = 358
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.TextBox_KelolaUser_Telepon)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(0, 106)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(358, 52)
        Me.Panel7.TabIndex = 4
        '
        'TextBox_KelolaUser_Telepon
        '
        Me.TextBox_KelolaUser_Telepon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_Telepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_Telepon.Location = New System.Drawing.Point(4, 22)
        Me.TextBox_KelolaUser_Telepon.Name = "TextBox_KelolaUser_Telepon"
        Me.TextBox_KelolaUser_Telepon.Size = New System.Drawing.Size(351, 26)
        Me.TextBox_KelolaUser_Telepon.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telepon"
        '
        'Panel_KelolaUser_TipeUser
        '
        Me.Panel_KelolaUser_TipeUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_KelolaUser_TipeUser.Controls.Add(Me.ComboBox_KelolaUser_TipeUser)
        Me.Panel_KelolaUser_TipeUser.Controls.Add(Me.Label1)
        Me.Panel_KelolaUser_TipeUser.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KelolaUser_TipeUser.Name = "Panel_KelolaUser_TipeUser"
        Me.Panel_KelolaUser_TipeUser.Size = New System.Drawing.Size(358, 52)
        Me.Panel_KelolaUser_TipeUser.TabIndex = 4
        '
        'ComboBox_KelolaUser_TipeUser
        '
        Me.ComboBox_KelolaUser_TipeUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_KelolaUser_TipeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_KelolaUser_TipeUser.FormattingEnabled = True
        Me.ComboBox_KelolaUser_TipeUser.Location = New System.Drawing.Point(4, 22)
        Me.ComboBox_KelolaUser_TipeUser.Name = "ComboBox_KelolaUser_TipeUser"
        Me.ComboBox_KelolaUser_TipeUser.Size = New System.Drawing.Size(351, 28)
        Me.ComboBox_KelolaUser_TipeUser.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipe User"
        '
        'Panel_KelolaUser_Nama
        '
        Me.Panel_KelolaUser_Nama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_KelolaUser_Nama.Controls.Add(Me.TextBox_KelolaUser_NamaUser)
        Me.Panel_KelolaUser_Nama.Controls.Add(Me.Label_Nama)
        Me.Panel_KelolaUser_Nama.Location = New System.Drawing.Point(0, 53)
        Me.Panel_KelolaUser_Nama.Name = "Panel_KelolaUser_Nama"
        Me.Panel_KelolaUser_Nama.Size = New System.Drawing.Size(358, 52)
        Me.Panel_KelolaUser_Nama.TabIndex = 4
        '
        'TextBox_KelolaUser_NamaUser
        '
        Me.TextBox_KelolaUser_NamaUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_NamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_NamaUser.Location = New System.Drawing.Point(4, 22)
        Me.TextBox_KelolaUser_NamaUser.Name = "TextBox_KelolaUser_NamaUser"
        Me.TextBox_KelolaUser_NamaUser.Size = New System.Drawing.Size(351, 26)
        Me.TextBox_KelolaUser_NamaUser.TabIndex = 6
        '
        'Label_Nama
        '
        Me.Label_Nama.AutoSize = True
        Me.Label_Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nama.Location = New System.Drawing.Point(1, 0)
        Me.Label_Nama.Name = "Label_Nama"
        Me.Label_Nama.Size = New System.Drawing.Size(84, 18)
        Me.Label_Nama.TabIndex = 5
        Me.Label_Nama.Text = "Nama User"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.TextBox_KelolaUser_Password)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(1, 106)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(364, 52)
        Me.Panel5.TabIndex = 4
        '
        'TextBox_KelolaUser_Password
        '
        Me.TextBox_KelolaUser_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_Password.Location = New System.Drawing.Point(4, 22)
        Me.TextBox_KelolaUser_Password.Name = "TextBox_KelolaUser_Password"
        Me.TextBox_KelolaUser_Password.Size = New System.Drawing.Size(357, 26)
        Me.TextBox_KelolaUser_Password.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TextBox_KelolaUser_Alamat)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 52)
        Me.Panel3.TabIndex = 4
        '
        'TextBox_KelolaUser_Alamat
        '
        Me.TextBox_KelolaUser_Alamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_Alamat.Location = New System.Drawing.Point(4, 22)
        Me.TextBox_KelolaUser_Alamat.Name = "TextBox_KelolaUser_Alamat"
        Me.TextBox_KelolaUser_Alamat.Size = New System.Drawing.Size(357, 26)
        Me.TextBox_KelolaUser_Alamat.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alamat"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.TextBox_KelolaUser_Username)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(1, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(364, 52)
        Me.Panel4.TabIndex = 4
        '
        'TextBox_KelolaUser_Username
        '
        Me.TextBox_KelolaUser_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_Username.Location = New System.Drawing.Point(4, 22)
        Me.TextBox_KelolaUser_Username.Name = "TextBox_KelolaUser_Username"
        Me.TextBox_KelolaUser_Username.Size = New System.Drawing.Size(357, 26)
        Me.TextBox_KelolaUser_Username.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Name"
        '
        'Panel_KelolaUser_Container
        '
        Me.Panel_KelolaUser_Container.Controls.Add(Me.DataGridView_KelolaUSer)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.TextBox_KelolaUser_CariUser)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.Label_KelolaUser_Cari)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.Button_KelolaUser_Hapus)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.Button_KelolaUser_Edit)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.Button_KelolaUser_Tambah)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.Panel1)
        Me.Panel_KelolaUser_Container.Controls.Add(Me.Label_KelolaUser)
        Me.Panel_KelolaUser_Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_KelolaUser_Container.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KelolaUser_Container.Name = "Panel_KelolaUser_Container"
        Me.Panel_KelolaUser_Container.Size = New System.Drawing.Size(736, 348)
        Me.Panel_KelolaUser_Container.TabIndex = 0
        '
        'TextBox_KelolaUser_CariUser
        '
        Me.TextBox_KelolaUser_CariUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_CariUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_CariUser.Location = New System.Drawing.Point(425, 197)
        Me.TextBox_KelolaUser_CariUser.Name = "TextBox_KelolaUser_CariUser"
        Me.TextBox_KelolaUser_CariUser.Size = New System.Drawing.Size(299, 29)
        Me.TextBox_KelolaUser_CariUser.TabIndex = 6
        '
        'Label_KelolaUser_Cari
        '
        Me.Label_KelolaUser_Cari.AutoSize = True
        Me.Label_KelolaUser_Cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaUser_Cari.Location = New System.Drawing.Point(344, 200)
        Me.Label_KelolaUser_Cari.Name = "Label_KelolaUser_Cari"
        Me.Label_KelolaUser_Cari.Size = New System.Drawing.Size(75, 20)
        Me.Label_KelolaUser_Cari.TabIndex = 5
        Me.Label_KelolaUser_Cari.Text = "Cari User"
        '
        'Button_KelolaUser_Hapus
        '
        Me.Button_KelolaUser_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Hapus.Location = New System.Drawing.Point(230, 191)
        Me.Button_KelolaUser_Hapus.Name = "Button_KelolaUser_Hapus"
        Me.Button_KelolaUser_Hapus.Size = New System.Drawing.Size(107, 35)
        Me.Button_KelolaUser_Hapus.TabIndex = 4
        Me.Button_KelolaUser_Hapus.Text = "Hapus"
        Me.Button_KelolaUser_Hapus.UseVisualStyleBackColor = True
        '
        'Button_KelolaUser_Edit
        '
        Me.Button_KelolaUser_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Edit.Location = New System.Drawing.Point(117, 191)
        Me.Button_KelolaUser_Edit.Name = "Button_KelolaUser_Edit"
        Me.Button_KelolaUser_Edit.Size = New System.Drawing.Size(107, 35)
        Me.Button_KelolaUser_Edit.TabIndex = 4
        Me.Button_KelolaUser_Edit.Text = "Edit"
        Me.Button_KelolaUser_Edit.UseVisualStyleBackColor = True
        '
        'Button_KelolaUser_Tambah
        '
        Me.Button_KelolaUser_Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Tambah.Location = New System.Drawing.Point(4, 191)
        Me.Button_KelolaUser_Tambah.Name = "Button_KelolaUser_Tambah"
        Me.Button_KelolaUser_Tambah.Size = New System.Drawing.Size(107, 35)
        Me.Button_KelolaUser_Tambah.TabIndex = 4
        Me.Button_KelolaUser_Tambah.Text = "Tambah"
        Me.Button_KelolaUser_Tambah.UseVisualStyleBackColor = True
        '
        'DataGridView_KelolaUSer
        '
        Me.DataGridView_KelolaUSer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_KelolaUSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_KelolaUSer.Location = New System.Drawing.Point(4, 232)
        Me.DataGridView_KelolaUSer.Name = "DataGridView_KelolaUSer"
        Me.DataGridView_KelolaUSer.Size = New System.Drawing.Size(729, 113)
        Me.DataGridView_KelolaUSer.TabIndex = 7
        '
        'Form_Admin_KelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 348)
        Me.Controls.Add(Me.Panel_KelolaUser_Container)
        Me.Name = "Form_Admin_KelolaUser"
        Me.Text = "Form Admin Kelola User"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel_KelolaUser_TipeUser.ResumeLayout(False)
        Me.Panel_KelolaUser_TipeUser.PerformLayout()
        Me.Panel_KelolaUser_Nama.ResumeLayout(False)
        Me.Panel_KelolaUser_Nama.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel_KelolaUser_Container.ResumeLayout(False)
        Me.Panel_KelolaUser_Container.PerformLayout()
        CType(Me.DataGridView_KelolaUSer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_KelolaUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel_KelolaUser_TipeUser As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_KelolaUser_Container As Panel
    Friend WithEvents ComboBox_KelolaUser_TipeUser As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox_KelolaUser_Alamat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox_KelolaUser_Telepon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel_KelolaUser_Nama As Panel
    Friend WithEvents TextBox_KelolaUser_NamaUser As TextBox
    Friend WithEvents Label_Nama As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox_KelolaUser_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox_KelolaUser_Username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_KelolaUser_Tambah As Button
    Friend WithEvents Label_KelolaUser_Cari As Label
    Friend WithEvents Button_KelolaUser_Hapus As Button
    Friend WithEvents Button_KelolaUser_Edit As Button
    Friend WithEvents TextBox_KelolaUser_CariUser As TextBox
    Friend WithEvents DataGridView_KelolaUSer As DataGridView
End Class
