<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin_LogActivity
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_Log = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.DateTimePicker_Log = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView_Log = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Log.SuspendLayout()
        CType(Me.DataGridView_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Log
        '
        Me.Panel_Log.AutoSize = True
        Me.Panel_Log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_Log.Controls.Add(Me.Label2)
        Me.Panel_Log.Controls.Add(Me.Button_Load)
        Me.Panel_Log.Controls.Add(Me.DateTimePicker_Log)
        Me.Panel_Log.Controls.Add(Me.DataGridView_Log)
        Me.Panel_Log.Controls.Add(Me.Label1)
        Me.Panel_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Log.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Log.Name = "Panel_Log"
        Me.Panel_Log.Size = New System.Drawing.Size(635, 414)
        Me.Panel_Log.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tampilkan Per"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Load
        '
        Me.Button_Load.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_Load.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button_Load.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Load.Location = New System.Drawing.Point(439, 372)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(86, 28)
        Me.Button_Load.TabIndex = 8
        Me.Button_Load.Text = "Load"
        Me.Button_Load.UseVisualStyleBackColor = False
        '
        'DateTimePicker_Log
        '
        Me.DateTimePicker_Log.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DateTimePicker_Log.Location = New System.Drawing.Point(217, 377)
        Me.DateTimePicker_Log.Name = "DateTimePicker_Log"
        Me.DateTimePicker_Log.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Log.TabIndex = 7
        '
        'DataGridView_Log
        '
        Me.DataGridView_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Log.Location = New System.Drawing.Point(10, 47)
        Me.DataGridView_Log.Name = "DataGridView_Log"
        Me.DataGridView_Log.ReadOnly = True
        Me.DataGridView_Log.Size = New System.Drawing.Size(614, 305)
        Me.DataGridView_Log.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Log Activity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_Admin_LogActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 414)
        Me.Controls.Add(Me.Panel_Log)
        Me.Name = "Form_Admin_LogActivity"
        Me.Text = "Form_Admin_LogActivity"
        Me.Panel_Log.ResumeLayout(False)
        Me.Panel_Log.PerformLayout()
        CType(Me.DataGridView_Log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Log As Panel
    Friend WithEvents Button_Load As Button
    Friend WithEvents DateTimePicker_Log As DateTimePicker
    Friend WithEvents DataGridView_Log As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
