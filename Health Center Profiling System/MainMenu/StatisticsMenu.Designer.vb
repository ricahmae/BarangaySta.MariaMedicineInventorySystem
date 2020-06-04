<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticsMenu))
        Me.settings = New Guna.UI.WinForms.GunaPanel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'settings
        '
        Me.settings.BackColor = System.Drawing.Color.White
        Me.settings.Controls.Add(Me.TextBox2)
        Me.settings.Controls.Add(Me.Button2)
        Me.settings.Controls.Add(Me.Button3)
        Me.settings.Controls.Add(Me.Button1)
        Me.settings.Controls.Add(Me.TextBox1)
        Me.settings.Controls.Add(Me.btnUser)
        Me.settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings.Location = New System.Drawing.Point(0, 0)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(1371, 746)
        Me.settings.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(837, 454)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(269, 78)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Text = "You can view a medicine name vs stock-out number graph."
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(893, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 179)
        Me.Button2.TabIndex = 39
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(823, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(283, 66)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "TOTAL MEDICINE STOCK-OUT PER DATE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(513, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 179)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(456, 454)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 78)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "You can view a medicine name vs  stockin number graph."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Black
        Me.btnUser.Location = New System.Drawing.Point(456, 382)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(274, 66)
        Me.btnUser.TabIndex = 34
        Me.btnUser.Text = "TOTAL MEDICINE STOCK-IN PER DATE"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'StatisticsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 746)
        Me.Controls.Add(Me.settings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StatisticsMenu"
        Me.Text = "StatisticsMenu"
        Me.settings.ResumeLayout(False)
        Me.settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents settings As Guna.UI.WinForms.GunaPanel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnUser As Button
End Class
