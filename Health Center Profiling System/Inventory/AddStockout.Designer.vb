<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStockout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStockout))
        Me.btncancelaccount = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.txtquantity = New System.Windows.Forms.NumericUpDown()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtstockoutby = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.txtyear = New Guna.UI.WinForms.GunaTextBox()
        Me.txtmonth = New Guna.UI.WinForms.GunaTextBox()
        Me.txtex = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox10 = New Guna.UI.WinForms.GunaGroupBox()
        Me.txtreceiver = New Guna.UI.WinForms.GunaTextBox()
        Me.txtdos = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtid = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGroupBox9 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcurrent = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcode = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtunit = New Guna.UI.WinForms.GunaTextBox()
        Me.txtdescription = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txttype = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcompany = New Guna.UI.WinForms.GunaTextBox()
        Me.txtbrand = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.txtquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox10.SuspendLayout()
        Me.GunaGroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancelaccount
        '
        Me.btncancelaccount.AnimationHoverSpeed = 0.07!
        Me.btncancelaccount.AnimationSpeed = 0.03!
        Me.btncancelaccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncancelaccount.BorderColor = System.Drawing.Color.Black
        Me.btncancelaccount.FocusedColor = System.Drawing.Color.Empty
        Me.btncancelaccount.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelaccount.ForeColor = System.Drawing.Color.White
        Me.btncancelaccount.Image = Nothing
        Me.btncancelaccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncancelaccount.Location = New System.Drawing.Point(1205, 649)
        Me.btncancelaccount.Name = "btncancelaccount"
        Me.btncancelaccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncancelaccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelaccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelaccount.OnHoverImage = Nothing
        Me.btncancelaccount.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelaccount.Size = New System.Drawing.Size(234, 86)
        Me.btncancelaccount.TabIndex = 119
        Me.btncancelaccount.Text = "CANCEL"
        Me.btncancelaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(92, 239)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(309, 30)
        Me.GunaLabel11.TabIndex = 114
        Me.GunaLabel11.Text = "QUANTITY TO STOCK-OUT"
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(109, 272)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(409, 36)
        Me.txtquantity.TabIndex = 124
        '
        'btnsaveacount
        '
        Me.btnsaveacount.AnimationHoverSpeed = 0.07!
        Me.btnsaveacount.AnimationSpeed = 0.03!
        Me.btnsaveacount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.BorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.FocusedColor = System.Drawing.Color.Empty
        Me.btnsaveacount.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveacount.ForeColor = System.Drawing.Color.White
        Me.btnsaveacount.Image = Nothing
        Me.btnsaveacount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsaveacount.Location = New System.Drawing.Point(946, 649)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(253, 86)
        Me.btnsaveacount.TabIndex = 118
        Me.btnsaveacount.Text = " SAVE"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(92, 160)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(184, 30)
        Me.GunaLabel9.TabIndex = 112
        Me.GunaLabel9.Text = "STOCK-OUT BY"
        '
        'txtstockoutby
        '
        Me.txtstockoutby.BaseColor = System.Drawing.Color.White
        Me.txtstockoutby.BorderColor = System.Drawing.Color.DimGray
        Me.txtstockoutby.BorderSize = 1
        Me.txtstockoutby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstockoutby.Enabled = False
        Me.txtstockoutby.FocusedBaseColor = System.Drawing.Color.White
        Me.txtstockoutby.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstockoutby.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtstockoutby.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstockoutby.ForeColor = System.Drawing.Color.Black
        Me.txtstockoutby.Location = New System.Drawing.Point(109, 193)
        Me.txtstockoutby.Name = "txtstockoutby"
        Me.txtstockoutby.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstockoutby.Size = New System.Drawing.Size(409, 43)
        Me.txtstockoutby.TabIndex = 3
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.txtyear)
        Me.GunaPanel4.Controls.Add(Me.txtmonth)
        Me.GunaPanel4.Controls.Add(Me.txtex)
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1543, 66)
        Me.GunaPanel4.TabIndex = 113
        '
        'txtyear
        '
        Me.txtyear.BaseColor = System.Drawing.Color.White
        Me.txtyear.BorderColor = System.Drawing.Color.DimGray
        Me.txtyear.BorderSize = 1
        Me.txtyear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtyear.FocusedBaseColor = System.Drawing.Color.White
        Me.txtyear.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtyear.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtyear.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtyear.ForeColor = System.Drawing.Color.DarkGray
        Me.txtyear.Location = New System.Drawing.Point(838, 38)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtyear.Size = New System.Drawing.Size(409, 43)
        Me.txtyear.TabIndex = 340
        Me.txtyear.Visible = False
        '
        'txtmonth
        '
        Me.txtmonth.BaseColor = System.Drawing.Color.White
        Me.txtmonth.BorderColor = System.Drawing.Color.DimGray
        Me.txtmonth.BorderSize = 1
        Me.txtmonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmonth.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmonth.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmonth.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtmonth.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtmonth.ForeColor = System.Drawing.Color.DarkGray
        Me.txtmonth.Location = New System.Drawing.Point(291, 23)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmonth.Size = New System.Drawing.Size(409, 43)
        Me.txtmonth.TabIndex = 339
        Me.txtmonth.Visible = False
        '
        'txtex
        '
        Me.txtex.BaseColor = System.Drawing.Color.White
        Me.txtex.BorderColor = System.Drawing.Color.Silver
        Me.txtex.BorderSize = 0
        Me.txtex.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtex.FocusedBaseColor = System.Drawing.Color.White
        Me.txtex.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtex.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtex.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtex.ForeColor = System.Drawing.Color.DarkGray
        Me.txtex.Location = New System.Drawing.Point(647, 41)
        Me.txtex.Name = "txtex"
        Me.txtex.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtex.Size = New System.Drawing.Size(409, 43)
        Me.txtex.TabIndex = 338
        Me.txtex.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1466, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(77, 66)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 132
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(92, 74)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(260, 30)
        Me.GunaLabel8.TabIndex = 110
        Me.GunaLabel8.Text = " DATE OF STOCK-OUT"
        '
        'GunaGroupBox10
        '
        Me.GunaGroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox10.BaseColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox10.BorderColor = System.Drawing.Color.DimGray
        Me.GunaGroupBox10.BorderSize = 1
        Me.GunaGroupBox10.Controls.Add(Me.txtreceiver)
        Me.GunaGroupBox10.Controls.Add(Me.txtquantity)
        Me.GunaGroupBox10.Controls.Add(Me.txtstockoutby)
        Me.GunaGroupBox10.Controls.Add(Me.txtdos)
        Me.GunaGroupBox10.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox10.Controls.Add(Me.GunaLabel11)
        Me.GunaGroupBox10.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox10.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox10.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox10.LineColor = System.Drawing.Color.MediumAquamarine
        Me.GunaGroupBox10.LineTop = 40
        Me.GunaGroupBox10.Location = New System.Drawing.Point(870, 96)
        Me.GunaGroupBox10.Name = "GunaGroupBox10"
        Me.GunaGroupBox10.Size = New System.Drawing.Size(617, 522)
        Me.GunaGroupBox10.TabIndex = 131
        Me.GunaGroupBox10.Text = "STOCK-OUT INFORMATION"
        Me.GunaGroupBox10.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txtreceiver
        '
        Me.txtreceiver.BaseColor = System.Drawing.Color.White
        Me.txtreceiver.BorderColor = System.Drawing.Color.DimGray
        Me.txtreceiver.BorderSize = 1
        Me.txtreceiver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreceiver.FocusedBaseColor = System.Drawing.Color.White
        Me.txtreceiver.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtreceiver.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtreceiver.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiver.ForeColor = System.Drawing.Color.DarkGray
        Me.txtreceiver.Location = New System.Drawing.Point(110, 355)
        Me.txtreceiver.MultiLine = True
        Me.txtreceiver.Name = "txtreceiver"
        Me.txtreceiver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreceiver.Size = New System.Drawing.Size(408, 130)
        Me.txtreceiver.TabIndex = 3
        '
        'txtdos
        '
        Me.txtdos.BaseColor = System.Drawing.Color.White
        Me.txtdos.BorderColor = System.Drawing.Color.DimGray
        Me.txtdos.BorderSize = 1
        Me.txtdos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdos.Enabled = False
        Me.txtdos.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdos.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdos.ForeColor = System.Drawing.Color.Black
        Me.txtdos.Location = New System.Drawing.Point(109, 107)
        Me.txtdos.Name = "txtdos"
        Me.txtdos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdos.Size = New System.Drawing.Size(409, 43)
        Me.txtdos.TabIndex = 3
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(104, 321)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(289, 30)
        Me.GunaLabel10.TabIndex = 116
        Me.GunaLabel10.Text = "REASON TO STOCK-OUT"
        '
        'txtid
        '
        Me.txtid.BaseColor = System.Drawing.Color.White
        Me.txtid.BorderColor = System.Drawing.Color.Silver
        Me.txtid.BorderSize = 0
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.DarkGray
        Me.txtid.Location = New System.Drawing.Point(95, 41)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.Size = New System.Drawing.Size(409, 43)
        Me.txtid.TabIndex = 337
        Me.txtid.Visible = False
        '
        'GunaGroupBox9
        '
        Me.GunaGroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox9.BaseColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox9.BorderColor = System.Drawing.Color.DimGray
        Me.GunaGroupBox9.BorderSize = 1
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox9.Controls.Add(Me.txtcurrent)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox9.Controls.Add(Me.txtcode)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox9.Controls.Add(Me.txtname)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox9.Controls.Add(Me.txtunit)
        Me.GunaGroupBox9.Controls.Add(Me.txtdescription)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel15)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox9.Controls.Add(Me.txttype)
        Me.GunaGroupBox9.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox9.Controls.Add(Me.txtcompany)
        Me.GunaGroupBox9.Controls.Add(Me.txtbrand)
        Me.GunaGroupBox9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox9.LineColor = System.Drawing.Color.SteelBlue
        Me.GunaGroupBox9.LineTop = 40
        Me.GunaGroupBox9.Location = New System.Drawing.Point(60, 96)
        Me.GunaGroupBox9.Name = "GunaGroupBox9"
        Me.GunaGroupBox9.Size = New System.Drawing.Size(791, 630)
        Me.GunaGroupBox9.TabIndex = 130
        Me.GunaGroupBox9.Text = "MEDICINE INFORMATION"
        Me.GunaGroupBox9.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(408, 505)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(218, 30)
        Me.GunaLabel4.TabIndex = 350
        Me.GunaLabel4.Text = "CURRENT STOCKS"
        '
        'txtcurrent
        '
        Me.txtcurrent.BaseColor = System.Drawing.Color.White
        Me.txtcurrent.BorderColor = System.Drawing.Color.DimGray
        Me.txtcurrent.BorderSize = 1
        Me.txtcurrent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurrent.Enabled = False
        Me.txtcurrent.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcurrent.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcurrent.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcurrent.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrent.ForeColor = System.Drawing.Color.Black
        Me.txtcurrent.Location = New System.Drawing.Point(413, 538)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcurrent.Size = New System.Drawing.Size(330, 44)
        Me.txtcurrent.TabIndex = 351
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(48, 73)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(209, 30)
        Me.GunaLabel1.TabIndex = 338
        Me.GunaLabel1.Text = "MEDICINE CODE"
        '
        'txtcode
        '
        Me.txtcode.BaseColor = System.Drawing.Color.White
        Me.txtcode.BorderColor = System.Drawing.Color.DimGray
        Me.txtcode.BorderSize = 1
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.Enabled = False
        Me.txtcode.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcode.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcode.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.Black
        Me.txtcode.Location = New System.Drawing.Point(53, 106)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.Size = New System.Drawing.Size(328, 44)
        Me.txtcode.TabIndex = 337
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(41, 505)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(191, 30)
        Me.GunaLabel7.TabIndex = 343
        Me.GunaLabel7.Text = "MEDICINE TYPE"
        '
        'txtname
        '
        Me.txtname.BaseColor = System.Drawing.Color.White
        Me.txtname.BorderColor = System.Drawing.Color.DimGray
        Me.txtname.BorderSize = 1
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Enabled = False
        Me.txtname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(53, 192)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Size = New System.Drawing.Size(328, 44)
        Me.txtname.TabIndex = 336
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(41, 417)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(344, 30)
        Me.GunaLabel6.TabIndex = 342
        Me.GunaLabel6.Text = "MEDICINE COMPANY NAME"
        '
        'txtunit
        '
        Me.txtunit.BaseColor = System.Drawing.Color.White
        Me.txtunit.BorderColor = System.Drawing.Color.DimGray
        Me.txtunit.BorderSize = 1
        Me.txtunit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtunit.Enabled = False
        Me.txtunit.FocusedBaseColor = System.Drawing.Color.White
        Me.txtunit.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtunit.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtunit.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(53, 271)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtunit.Size = New System.Drawing.Size(328, 44)
        Me.txtunit.TabIndex = 344
        '
        'txtdescription
        '
        Me.txtdescription.BaseColor = System.Drawing.Color.White
        Me.txtdescription.BorderColor = System.Drawing.Color.DimGray
        Me.txtdescription.BorderSize = 1
        Me.txtdescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescription.Enabled = False
        Me.txtdescription.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdescription.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescription.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdescription.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.ForeColor = System.Drawing.Color.Black
        Me.txtdescription.Location = New System.Drawing.Point(413, 106)
        Me.txtdescription.MultiLine = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescription.Size = New System.Drawing.Size(329, 387)
        Me.txtdescription.TabIndex = 349
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(48, 321)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(297, 30)
        Me.GunaLabel3.TabIndex = 341
        Me.GunaLabel3.Text = "MEDICINE BRAND NAME"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.Location = New System.Drawing.Point(408, 74)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(167, 30)
        Me.GunaLabel15.TabIndex = 348
        Me.GunaLabel15.Text = "DESCRIPTION"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(48, 238)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(188, 30)
        Me.GunaLabel5.TabIndex = 340
        Me.GunaLabel5.Text = "MEDICINE UNIT"
        '
        'txttype
        '
        Me.txttype.BaseColor = System.Drawing.Color.White
        Me.txttype.BorderColor = System.Drawing.Color.DimGray
        Me.txttype.BorderSize = 1
        Me.txttype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttype.Enabled = False
        Me.txttype.FocusedBaseColor = System.Drawing.Color.White
        Me.txttype.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttype.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttype.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.ForeColor = System.Drawing.Color.Black
        Me.txttype.Location = New System.Drawing.Point(53, 538)
        Me.txttype.Name = "txttype"
        Me.txttype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttype.Size = New System.Drawing.Size(328, 44)
        Me.txttype.TabIndex = 347
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(50, 152)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(208, 30)
        Me.GunaLabel2.TabIndex = 339
        Me.GunaLabel2.Text = "MEDICINE NAME"
        '
        'txtcompany
        '
        Me.txtcompany.BaseColor = System.Drawing.Color.White
        Me.txtcompany.BorderColor = System.Drawing.Color.DimGray
        Me.txtcompany.BorderSize = 1
        Me.txtcompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcompany.Enabled = False
        Me.txtcompany.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcompany.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcompany.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcompany.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompany.ForeColor = System.Drawing.Color.Black
        Me.txtcompany.Location = New System.Drawing.Point(55, 450)
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcompany.Size = New System.Drawing.Size(328, 44)
        Me.txtcompany.TabIndex = 346
        '
        'txtbrand
        '
        Me.txtbrand.BaseColor = System.Drawing.Color.White
        Me.txtbrand.BorderColor = System.Drawing.Color.DimGray
        Me.txtbrand.BorderSize = 1
        Me.txtbrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbrand.Enabled = False
        Me.txtbrand.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbrand.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbrand.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbrand.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.ForeColor = System.Drawing.Color.Black
        Me.txtbrand.Location = New System.Drawing.Point(53, 355)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbrand.Size = New System.Drawing.Size(328, 44)
        Me.txtbrand.TabIndex = 345
        '
        'AddStockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1543, 777)
        Me.Controls.Add(Me.btncancelaccount)
        Me.Controls.Add(Me.btnsaveacount)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaGroupBox10)
        Me.Controls.Add(Me.GunaGroupBox9)
        Me.Controls.Add(Me.txtid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddStockout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.txtquantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox10.ResumeLayout(False)
        Me.GunaGroupBox10.PerformLayout()
        Me.GunaGroupBox9.ResumeLayout(False)
        Me.GunaGroupBox9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncancelaccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtstockoutby As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox10 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txtdos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGroupBox9 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtreceiver As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcurrent As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcode As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtunit As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtdescription As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txttype As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcompany As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtbrand As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtquantity As NumericUpDown
    Friend WithEvents txtex As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtyear As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmonth As Guna.UI.WinForms.GunaTextBox
End Class
