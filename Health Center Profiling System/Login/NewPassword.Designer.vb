<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtconfirm = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btnlogin = New Guna.UI.WinForms.GunaButton()
        Me.txtnewpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.txtconfirm)
        Me.Panel1.Controls.Add(Me.GunaPanel4)
        Me.Panel1.Controls.Add(Me.GunaButton1)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.txtnewpassword)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 444)
        Me.Panel1.TabIndex = 2
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(182, 203)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(267, 30)
        Me.GunaLabel2.TabIndex = 121
        Me.GunaLabel2.Text = "CONFIRM PASSWORD"
        '
        'txtconfirm
        '
        Me.txtconfirm.BackColor = System.Drawing.Color.Transparent
        Me.txtconfirm.BaseColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtconfirm.BorderColor = System.Drawing.Color.Silver
        Me.txtconfirm.BorderSize = 0
        Me.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirm.FocusedBaseColor = System.Drawing.Color.White
        Me.txtconfirm.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtconfirm.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtconfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtconfirm.ForeColor = System.Drawing.Color.Gray
        Me.txtconfirm.Location = New System.Drawing.Point(124, 236)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirm.Radius = 6
        Me.txtconfirm.Size = New System.Drawing.Size(383, 51)
        Me.txtconfirm.TabIndex = 120
        Me.txtconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(601, 54)
        Me.GunaPanel4.TabIndex = 119
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(253, 30)
        Me.GunaLabel1.TabIndex = 120
        Me.GunaLabel1.Text = "FORGOT PASSWORD"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(541, 1)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(60, 50)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 98
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.LightCoral
        Me.GunaButton1.BaseColor = System.Drawing.Color.LightCoral
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(331, 320)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(176, 73)
        Me.GunaButton1.TabIndex = 118
        Me.GunaButton1.Text = "CANCEL"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(182, 119)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(278, 30)
        Me.GunaLabel4.TabIndex = 117
        Me.GunaLabel4.Text = "INPUT NEW PASSWORD"
        '
        'btnlogin
        '
        Me.btnlogin.AnimationHoverSpeed = 0.07!
        Me.btnlogin.AnimationSpeed = 0.03!
        Me.btnlogin.BackColor = System.Drawing.Color.LightCoral
        Me.btnlogin.BaseColor = System.Drawing.Color.LightCoral
        Me.btnlogin.BorderColor = System.Drawing.Color.Black
        Me.btnlogin.BorderSize = 1
        Me.btnlogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Image = Nothing
        Me.btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogin.Location = New System.Drawing.Point(124, 320)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnlogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnlogin.OnHoverImage = Nothing
        Me.btnlogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnlogin.Size = New System.Drawing.Size(185, 73)
        Me.btnlogin.TabIndex = 116
        Me.btnlogin.Text = "SAVE"
        Me.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnewpassword
        '
        Me.txtnewpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtnewpassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtnewpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtnewpassword.BorderSize = 0
        Me.txtnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnewpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnewpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtnewpassword.ForeColor = System.Drawing.Color.Gray
        Me.txtnewpassword.Location = New System.Drawing.Point(124, 152)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassword.Radius = 6
        Me.txtnewpassword.Size = New System.Drawing.Size(383, 48)
        Me.txtnewpassword.TabIndex = 115
        Me.txtnewpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 444)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtconfirm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnlogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtnewpassword As Guna.UI.WinForms.GunaTextBox
End Class
