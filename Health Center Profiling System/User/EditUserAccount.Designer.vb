<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUserAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUserAccount))
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.cbousertype = New Guna.UI.WinForms.GunaComboBox()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtfullname = New Guna.UI.WinForms.GunaTextBox()
        Me.btncancelaccount = New Guna.UI.WinForms.GunaButton()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(924, 75)
        Me.GunaPanel4.TabIndex = 21
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(841, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(60, 50)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 96
        Me.GunaPictureBox1.TabStop = False
        '
        'cbousertype
        '
        Me.cbousertype.BackColor = System.Drawing.Color.Transparent
        Me.cbousertype.BaseColor = System.Drawing.Color.White
        Me.cbousertype.BorderColor = System.Drawing.Color.Transparent
        Me.cbousertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbousertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbousertype.FocusedColor = System.Drawing.Color.Empty
        Me.cbousertype.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbousertype.ForeColor = System.Drawing.Color.Black
        Me.cbousertype.FormattingEnabled = True
        Me.cbousertype.Items.AddRange(New Object() {"Admin", "Healthcare Practitioner"})
        Me.cbousertype.Location = New System.Drawing.Point(251, 411)
        Me.cbousertype.Name = "cbousertype"
        Me.cbousertype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbousertype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbousertype.Size = New System.Drawing.Size(409, 45)
        Me.cbousertype.TabIndex = 0
        '
        'txtusername
        '
        Me.txtusername.BaseColor = System.Drawing.Color.White
        Me.txtusername.BorderColor = System.Drawing.Color.Silver
        Me.txtusername.BorderSize = 0
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.DarkGray
        Me.txtusername.Location = New System.Drawing.Point(251, 301)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Size = New System.Drawing.Size(409, 47)
        Me.txtusername.TabIndex = 3
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(201, 367)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(123, 30)
        Me.GunaLabel5.TabIndex = 29
        Me.GunaLabel5.Text = "USERTYPE"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(201, 268)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(140, 30)
        Me.GunaLabel2.TabIndex = 27
        Me.GunaLabel2.Text = "USERNAME"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(201, 173)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(134, 30)
        Me.GunaLabel1.TabIndex = 24
        Me.GunaLabel1.Text = "FULLNAME"
        '
        'txtfullname
        '
        Me.txtfullname.BaseColor = System.Drawing.Color.White
        Me.txtfullname.BorderColor = System.Drawing.Color.Silver
        Me.txtfullname.BorderSize = 0
        Me.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfullname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfullname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfullname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtfullname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtfullname.Location = New System.Drawing.Point(251, 206)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.Size = New System.Drawing.Size(409, 52)
        Me.txtfullname.TabIndex = 3
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
        Me.btncancelaccount.ImageSize = New System.Drawing.Size(40, 40)
        Me.btncancelaccount.Location = New System.Drawing.Point(470, 513)
        Me.btncancelaccount.Name = "btncancelaccount"
        Me.btncancelaccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncancelaccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelaccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelaccount.OnHoverImage = Nothing
        Me.btncancelaccount.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelaccount.Size = New System.Drawing.Size(209, 86)
        Me.btncancelaccount.TabIndex = 95
        Me.btncancelaccount.Text = "CANCEL"
        Me.btncancelaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnsaveacount.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnsaveacount.Location = New System.Drawing.Point(223, 513)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(228, 86)
        Me.btnsaveacount.TabIndex = 94
        Me.btnsaveacount.Text = "SAVE"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EditUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 719)
        Me.Controls.Add(Me.cbousertype)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.btncancelaccount)
        Me.Controls.Add(Me.btnsaveacount)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditUserAccount"
        Me.Text = "EditUserAccount"
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents cbousertype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtfullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btncancelaccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
