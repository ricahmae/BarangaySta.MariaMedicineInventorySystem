<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLotNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddLotNumber))
        Me.txtlotnumber = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.btncancelaccount = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtlotnumber
        '
        Me.txtlotnumber.BaseColor = System.Drawing.Color.White
        Me.txtlotnumber.BorderColor = System.Drawing.Color.Silver
        Me.txtlotnumber.BorderSize = 0
        Me.txtlotnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlotnumber.FocusedBaseColor = System.Drawing.Color.White
        Me.txtlotnumber.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlotnumber.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtlotnumber.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotnumber.ForeColor = System.Drawing.Color.DarkGray
        Me.txtlotnumber.Location = New System.Drawing.Point(71, 178)
        Me.txtlotnumber.Name = "txtlotnumber"
        Me.txtlotnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlotnumber.Size = New System.Drawing.Size(409, 47)
        Me.txtlotnumber.TabIndex = 3
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(515, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(60, 74)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 93
        Me.GunaPictureBox1.TabStop = False
        '
        'btnsaveacount
        '
        Me.btnsaveacount.AnimationHoverSpeed = 0.07!
        Me.btnsaveacount.AnimationSpeed = 0.03!
        Me.btnsaveacount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.BorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.FocusedColor = System.Drawing.Color.Empty
        Me.btnsaveacount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsaveacount.ForeColor = System.Drawing.Color.White
        Me.btnsaveacount.Image = Nothing
        Me.btnsaveacount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsaveacount.Location = New System.Drawing.Point(53, 257)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(228, 86)
        Me.btnsaveacount.TabIndex = 96
        Me.btnsaveacount.Text = "SAVE"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncancelaccount
        '
        Me.btncancelaccount.AnimationHoverSpeed = 0.07!
        Me.btncancelaccount.AnimationSpeed = 0.03!
        Me.btncancelaccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncancelaccount.BorderColor = System.Drawing.Color.Black
        Me.btncancelaccount.FocusedColor = System.Drawing.Color.Empty
        Me.btncancelaccount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btncancelaccount.ForeColor = System.Drawing.Color.White
        Me.btncancelaccount.Image = Nothing
        Me.btncancelaccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncancelaccount.Location = New System.Drawing.Point(300, 257)
        Me.btncancelaccount.Name = "btncancelaccount"
        Me.btncancelaccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncancelaccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelaccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelaccount.OnHoverImage = Nothing
        Me.btncancelaccount.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelaccount.Size = New System.Drawing.Size(209, 86)
        Me.btncancelaccount.TabIndex = 97
        Me.btncancelaccount.Text = "CANCEL"
        Me.btncancelaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(66, 132)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(162, 30)
        Me.GunaLabel1.TabIndex = 95
        Me.GunaLabel1.Text = "LOT NUMBER"
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(575, 74)
        Me.GunaPanel4.TabIndex = 93
        '
        'AddLotNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 373)
        Me.Controls.Add(Me.txtlotnumber)
        Me.Controls.Add(Me.btnsaveacount)
        Me.Controls.Add(Me.btncancelaccount)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddLotNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddLotNumber"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtlotnumber As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents btncancelaccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
End Class
