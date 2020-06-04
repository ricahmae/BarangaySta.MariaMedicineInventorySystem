<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProfile))
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtcode = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtdescription = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.btncancelaccount = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.cbounit = New Guna.UI.WinForms.GunaComboBox()
        Me.txtMax = New System.Windows.Forms.NumericUpDown()
        Me.txtAlertNum = New System.Windows.Forms.NumericUpDown()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.cbobrand = New Guna.UI.WinForms.GunaComboBox()
        Me.cbocompany = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.cbotype = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cbolotnumber = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtunit = New System.Windows.Forms.TextBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.txtMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlertNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1070, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(80, 74)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 107
        Me.GunaPictureBox1.TabStop = False
        '
        'txtcode
        '
        Me.txtcode.BaseColor = System.Drawing.Color.White
        Me.txtcode.BorderColor = System.Drawing.Color.Silver
        Me.txtcode.BorderSize = 0
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.Enabled = False
        Me.txtcode.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcode.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtcode.ForeColor = System.Drawing.Color.DarkGray
        Me.txtcode.Location = New System.Drawing.Point(99, 156)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.Size = New System.Drawing.Size(409, 43)
        Me.txtcode.TabIndex = 3
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(94, 301)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(191, 30)
        Me.GunaLabel7.TabIndex = 125
        Me.GunaLabel7.Text = "MEDICINE TYPE"
        '
        'txtname
        '
        Me.txtname.BaseColor = System.Drawing.Color.White
        Me.txtname.BorderColor = System.Drawing.Color.Silver
        Me.txtname.BorderSize = 0
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtname.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtname.Location = New System.Drawing.Point(99, 245)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Size = New System.Drawing.Size(409, 43)
        Me.txtname.TabIndex = 3
        '
        'txtdescription
        '
        Me.txtdescription.BaseColor = System.Drawing.Color.White
        Me.txtdescription.BorderColor = System.Drawing.Color.Silver
        Me.txtdescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescription.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdescription.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescription.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdescription.Location = New System.Drawing.Point(619, 249)
        Me.txtdescription.MultiLine = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescription.Size = New System.Drawing.Size(429, 124)
        Me.txtdescription.TabIndex = 120
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(618, 212)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(167, 30)
        Me.GunaLabel11.TabIndex = 119
        Me.GunaLabel11.Text = "DESCRIPTION"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(89, 583)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(344, 30)
        Me.GunaLabel6.TabIndex = 118
        Me.GunaLabel6.Text = "MEDICINE COMPANY NAME"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(89, 486)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(297, 30)
        Me.GunaLabel3.TabIndex = 115
        Me.GunaLabel3.Text = "MEDICINE BRAND NAME"
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1150, 74)
        Me.GunaPanel4.TabIndex = 107
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
        Me.btncancelaccount.Location = New System.Drawing.Point(863, 722)
        Me.btncancelaccount.Name = "btncancelaccount"
        Me.btncancelaccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncancelaccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelaccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelaccount.OnHoverImage = Nothing
        Me.btncancelaccount.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelaccount.Size = New System.Drawing.Size(209, 86)
        Me.btncancelaccount.TabIndex = 114
        Me.btncancelaccount.Text = "CANCEL"
        Me.btncancelaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(89, 385)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(188, 30)
        Me.GunaLabel5.TabIndex = 112
        Me.GunaLabel5.Text = "MEDICINE UNIT"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(89, 212)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(197, 30)
        Me.GunaLabel2.TabIndex = 111
        Me.GunaLabel2.Text = "GENERIC NAME"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(90, 123)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(209, 30)
        Me.GunaLabel1.TabIndex = 109
        Me.GunaLabel1.Text = "MEDICINE CODE"
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
        Me.btnsaveacount.Location = New System.Drawing.Point(616, 722)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(228, 86)
        Me.btnsaveacount.TabIndex = 113
        Me.btnsaveacount.Text = "SAVE"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbounit
        '
        Me.cbounit.BackColor = System.Drawing.Color.Transparent
        Me.cbounit.BaseColor = System.Drawing.Color.White
        Me.cbounit.BorderColor = System.Drawing.Color.Transparent
        Me.cbounit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbounit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbounit.FocusedColor = System.Drawing.Color.Empty
        Me.cbounit.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbounit.ForeColor = System.Drawing.Color.Black
        Me.cbounit.FormattingEnabled = True
        Me.cbounit.Items.AddRange(New Object() {""})
        Me.cbounit.Location = New System.Drawing.Point(300, 418)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbounit.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbounit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbounit.Size = New System.Drawing.Size(208, 39)
        Me.cbounit.TabIndex = 127
        '
        'txtMax
        '
        Me.txtMax.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(619, 425)
        Me.txtMax.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(409, 36)
        Me.txtMax.TabIndex = 301
        Me.txtMax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtAlertNum
        '
        Me.txtAlertNum.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlertNum.Location = New System.Drawing.Point(621, 634)
        Me.txtAlertNum.Name = "txtAlertNum"
        Me.txtAlertNum.Size = New System.Drawing.Size(411, 36)
        Me.txtAlertNum.TabIndex = 304
        Me.txtAlertNum.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Checked = True
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(705, 546)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(66, 33)
        Me.rbNo.TabIndex = 303
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.Location = New System.Drawing.Point(623, 546)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(76, 33)
        Me.rbYes.TabIndex = 302
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'cbobrand
        '
        Me.cbobrand.BackColor = System.Drawing.Color.Transparent
        Me.cbobrand.BaseColor = System.Drawing.Color.White
        Me.cbobrand.BorderColor = System.Drawing.Color.Transparent
        Me.cbobrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbobrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobrand.FocusedColor = System.Drawing.Color.Empty
        Me.cbobrand.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobrand.ForeColor = System.Drawing.Color.Black
        Me.cbobrand.FormattingEnabled = True
        Me.cbobrand.Items.AddRange(New Object() {""})
        Me.cbobrand.Location = New System.Drawing.Point(99, 526)
        Me.cbobrand.Name = "cbobrand"
        Me.cbobrand.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbobrand.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbobrand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbobrand.Size = New System.Drawing.Size(409, 39)
        Me.cbobrand.TabIndex = 308
        '
        'cbocompany
        '
        Me.cbocompany.BackColor = System.Drawing.Color.Transparent
        Me.cbocompany.BaseColor = System.Drawing.Color.White
        Me.cbocompany.BorderColor = System.Drawing.Color.Transparent
        Me.cbocompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbocompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocompany.FocusedColor = System.Drawing.Color.Empty
        Me.cbocompany.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocompany.ForeColor = System.Drawing.Color.Black
        Me.cbocompany.FormattingEnabled = True
        Me.cbocompany.Items.AddRange(New Object() {""})
        Me.cbocompany.Location = New System.Drawing.Point(99, 627)
        Me.cbocompany.Name = "cbocompany"
        Me.cbocompany.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbocompany.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbocompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbocompany.Size = New System.Drawing.Size(409, 39)
        Me.cbocompany.TabIndex = 309
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(618, 385)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(253, 30)
        Me.GunaLabel4.TabIndex = 310
        Me.GunaLabel4.Text = "MAXIMUM STOCK-IN"
        '
        'cbotype
        '
        Me.cbotype.BackColor = System.Drawing.Color.Transparent
        Me.cbotype.BaseColor = System.Drawing.Color.White
        Me.cbotype.BorderColor = System.Drawing.Color.Transparent
        Me.cbotype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.FocusedColor = System.Drawing.Color.Empty
        Me.cbotype.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype.ForeColor = System.Drawing.Color.Black
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(99, 334)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbotype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbotype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbotype.Size = New System.Drawing.Size(409, 39)
        Me.cbotype.TabIndex = 311
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(618, 496)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(273, 30)
        Me.GunaLabel8.TabIndex = 312
        Me.GunaLabel8.Text = "ENABLE NOTIFICATION"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(618, 601)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(504, 30)
        Me.GunaLabel9.TabIndex = 313
        Me.GunaLabel9.Text = "IF YES, QUANTITY TO ALERT(IN PERCENTILE)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(523, 409)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 314
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(523, 519)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 315
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(523, 614)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 316
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(523, 321)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 317
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1067, 158)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 320
        Me.PictureBox5.TabStop = False
        '
        'cbolotnumber
        '
        Me.cbolotnumber.BackColor = System.Drawing.Color.Transparent
        Me.cbolotnumber.BaseColor = System.Drawing.Color.White
        Me.cbolotnumber.BorderColor = System.Drawing.Color.Transparent
        Me.cbolotnumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbolotnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolotnumber.FocusedColor = System.Drawing.Color.Empty
        Me.cbolotnumber.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolotnumber.ForeColor = System.Drawing.Color.Black
        Me.cbolotnumber.FormattingEnabled = True
        Me.cbolotnumber.Items.AddRange(New Object() {""})
        Me.cbolotnumber.Location = New System.Drawing.Point(623, 156)
        Me.cbolotnumber.Name = "cbolotnumber"
        Me.cbolotnumber.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbolotnumber.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbolotnumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbolotnumber.Size = New System.Drawing.Size(429, 39)
        Me.cbolotnumber.TabIndex = 319
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(618, 123)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(157, 30)
        Me.GunaLabel10.TabIndex = 318
        Me.GunaLabel10.Text = "BIN NUMBER"
        '
        'txtunit
        '
        Me.txtunit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtunit.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Location = New System.Drawing.Point(99, 420)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(195, 37)
        Me.txtunit.TabIndex = 321
        '
        'AddProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 854)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.cbotype)
        Me.Controls.Add(Me.cbolotnumber)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.cbocompany)
        Me.Controls.Add(Me.cbobrand)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtAlertNum)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.rbYes)
        Me.Controls.Add(Me.cbounit)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.btncancelaccount)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.btnsaveacount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProfile"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.txtMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlertNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtcode As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtdescription As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btncancelaccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents cbounit As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtMax As NumericUpDown
    Friend WithEvents txtAlertNum As NumericUpDown
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents cbobrand As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbocompany As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbotype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents cbolotnumber As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtunit As TextBox
End Class
