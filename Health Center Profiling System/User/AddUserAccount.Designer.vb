<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUserAccount))
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtfullname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox7 = New Guna.UI.WinForms.GunaGroupBox()
        Me.cboquestion = New Guna.UI.WinForms.GunaComboBox()
        Me.cboanswer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txtconfirmpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.cbousertype = New Guna.UI.WinForms.GunaComboBox()
        Me.btncancelaccount = New Guna.UI.WinForms.GunaButton()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1072, 75)
        Me.GunaPanel4.TabIndex = 1
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1003, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(60, 50)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 96
        Me.GunaPictureBox1.TabStop = False
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
        Me.txtfullname.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtfullname.Location = New System.Drawing.Point(86, 163)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.Size = New System.Drawing.Size(409, 43)
        Me.txtfullname.TabIndex = 3
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(47, 130)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(134, 30)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "FULLNAME"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(47, 224)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(140, 30)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "USERNAME"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(42, 315)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(145, 30)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "PASSWORD"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(42, 496)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(123, 30)
        Me.GunaLabel5.TabIndex = 12
        Me.GunaLabel5.Text = "USERTYPE"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(42, 410)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(267, 30)
        Me.GunaLabel6.TabIndex = 8
        Me.GunaLabel6.Text = "CONFIRM PASSWORD"
        '
        'GunaGroupBox7
        '
        Me.GunaGroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox7.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox7.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox7.Controls.Add(Me.cboquestion)
        Me.GunaGroupBox7.Controls.Add(Me.cboanswer)
        Me.GunaGroupBox7.Controls.Add(Me.Label4)
        Me.GunaGroupBox7.Controls.Add(Me.Label9)
        Me.GunaGroupBox7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox7.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox7.LineTop = 40
        Me.GunaGroupBox7.Location = New System.Drawing.Point(556, 148)
        Me.GunaGroupBox7.Name = "GunaGroupBox7"
        Me.GunaGroupBox7.Size = New System.Drawing.Size(446, 422)
        Me.GunaGroupBox7.TabIndex = 13
        Me.GunaGroupBox7.Text = "SECURITY QUESTION"
        Me.GunaGroupBox7.TextLocation = New System.Drawing.Point(10, 8)
        '
        'cboquestion
        '
        Me.cboquestion.BackColor = System.Drawing.Color.Transparent
        Me.cboquestion.BaseColor = System.Drawing.Color.White
        Me.cboquestion.BorderColor = System.Drawing.Color.Black
        Me.cboquestion.BorderSize = 1
        Me.cboquestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboquestion.FocusedColor = System.Drawing.Color.Empty
        Me.cboquestion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboquestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboquestion.FormattingEnabled = True
        Me.cboquestion.Items.AddRange(New Object() {"Admin", "Healthcare Practitioner"})
        Me.cboquestion.Location = New System.Drawing.Point(42, 149)
        Me.cboquestion.Name = "cboquestion"
        Me.cboquestion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboquestion.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboquestion.Size = New System.Drawing.Size(359, 31)
        Me.cboquestion.TabIndex = 13
        '
        'cboanswer
        '
        Me.cboanswer.Location = New System.Drawing.Point(42, 251)
        Me.cboanswer.Multiline = True
        Me.cboanswer.Name = "cboanswer"
        Me.cboanswer.Size = New System.Drawing.Size(359, 107)
        Me.cboanswer.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(17, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Your Security Answer:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(18, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(327, 30)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Choose Security Question:"
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
        Me.txtusername.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.DarkGray
        Me.txtusername.Location = New System.Drawing.Point(86, 257)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Size = New System.Drawing.Size(409, 43)
        Me.txtusername.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.BaseColor = System.Drawing.Color.White
        Me.txtpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtpassword.BorderSize = 0
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpassword.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtpassword.Location = New System.Drawing.Point(86, 348)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(409, 43)
        Me.txtpassword.TabIndex = 3
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.BaseColor = System.Drawing.Color.White
        Me.txtconfirmpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtconfirmpassword.BorderSize = 0
        Me.txtconfirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtconfirmpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtconfirmpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtconfirmpassword.Location = New System.Drawing.Point(86, 443)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpassword.Size = New System.Drawing.Size(409, 43)
        Me.txtconfirmpassword.TabIndex = 3
        '
        'cbousertype
        '
        Me.cbousertype.BackColor = System.Drawing.Color.Transparent
        Me.cbousertype.BaseColor = System.Drawing.Color.White
        Me.cbousertype.BorderColor = System.Drawing.Color.Transparent
        Me.cbousertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbousertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbousertype.FocusedColor = System.Drawing.Color.Empty
        Me.cbousertype.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbousertype.ForeColor = System.Drawing.Color.Black
        Me.cbousertype.FormattingEnabled = True
        Me.cbousertype.Items.AddRange(New Object() {"Admin", "Healthcare Practitioner"})
        Me.cbousertype.Location = New System.Drawing.Point(81, 529)
        Me.cbousertype.Name = "cbousertype"
        Me.cbousertype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbousertype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbousertype.Size = New System.Drawing.Size(409, 41)
        Me.cbousertype.TabIndex = 0
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
        Me.btncancelaccount.Location = New System.Drawing.Point(793, 599)
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
        Me.btnsaveacount.Location = New System.Drawing.Point(546, 599)
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
        'AddUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 728)
        Me.Controls.Add(Me.cbousertype)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.btncancelaccount)
        Me.Controls.Add(Me.btnsaveacount)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaGroupBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUserAccount"
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox7.ResumeLayout(False)
        Me.GunaGroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtfullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox7 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtconfirmpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cbousertype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cboanswer As TextBox
    Friend WithEvents btncancelaccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents cboquestion As Guna.UI.WinForms.GunaComboBox
End Class
