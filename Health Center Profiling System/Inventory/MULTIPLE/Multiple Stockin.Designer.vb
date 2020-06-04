<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multiple_Stockin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Multiple_Stockin))
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MEDLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnproceed = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtdate = New Guna.UI.WinForms.GunaTextBox()
        Me.txtstockinby = New Guna.UI.WinForms.GunaTextBox()
        Me.txtid = New Guna.UI.WinForms.GunaTextBox()
        Me.btnadd = New Guna.UI.WinForms.GunaButton()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtalert = New Guna.UI.WinForms.GunaTextBox()
        Me.txtqta = New Guna.UI.WinForms.GunaTextBox()
        Me.txtmax = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.txtdescription = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.txttype = New Guna.UI.WinForms.GunaTextBox()
        Me.txtcompany = New Guna.UI.WinForms.GunaTextBox()
        Me.txtbrand = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtunit = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcode = New Guna.UI.WinForms.GunaTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboreceived = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.DOE = New System.Windows.Forms.DateTimePicker()
        Me.txtquantity = New System.Windows.Forms.NumericUpDown()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox2.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 6
        Me.ColumnHeader6.Text = "QUANTITY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 137
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MEDICINE BRAND"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MEDICINE NAME"
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MEDICINE CODE"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item ID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'MEDLV
        '
        Me.MEDLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader6})
        Me.MEDLV.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEDLV.FullRowSelect = True
        Me.MEDLV.GridLines = True
        Me.MEDLV.Location = New System.Drawing.Point(493, 249)
        Me.MEDLV.Name = "MEDLV"
        Me.MEDLV.Size = New System.Drawing.Size(1039, 478)
        Me.MEDLV.TabIndex = 315
        Me.MEDLV.UseCompatibleStateImageBehavior = False
        Me.MEDLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MEDICINE UNIT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 7
        Me.ColumnHeader8.Text = "FROM"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.DisplayIndex = 8
        Me.ColumnHeader9.Text = "EXP DATE"
        Me.ColumnHeader9.Width = 100
        '
        'btnproceed
        '
        Me.btnproceed.AnimationHoverSpeed = 0.07!
        Me.btnproceed.AnimationSpeed = 0.03!
        Me.btnproceed.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnproceed.BorderColor = System.Drawing.Color.Black
        Me.btnproceed.FocusedColor = System.Drawing.Color.Empty
        Me.btnproceed.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnproceed.ForeColor = System.Drawing.Color.White
        Me.btnproceed.Image = Nothing
        Me.btnproceed.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnproceed.Location = New System.Drawing.Point(698, 35)
        Me.btnproceed.Name = "btnproceed"
        Me.btnproceed.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnproceed.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnproceed.OnHoverForeColor = System.Drawing.Color.White
        Me.btnproceed.OnHoverImage = Nothing
        Me.btnproceed.OnPressedColor = System.Drawing.Color.Black
        Me.btnproceed.Size = New System.Drawing.Size(161, 68)
        Me.btnproceed.TabIndex = 312
        Me.btnproceed.Text = "PROCEED"
        Me.btnproceed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaButton3.Location = New System.Drawing.Point(865, 34)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(166, 68)
        Me.GunaButton3.TabIndex = 311
        Me.GunaButton3.Text = "CANCEL"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnproceed)
        Me.GroupBox2.Controls.Add(Me.GunaButton3)
        Me.GroupBox2.Controls.Add(Me.GunaLabel3)
        Me.GroupBox2.Controls.Add(Me.GunaLabel1)
        Me.GroupBox2.Controls.Add(Me.txtdate)
        Me.GroupBox2.Controls.Add(Me.txtstockinby)
        Me.GroupBox2.Location = New System.Drawing.Point(483, 733)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1049, 140)
        Me.GroupBox2.TabIndex = 314
        Me.GroupBox2.TabStop = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(40, 26)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(236, 30)
        Me.GunaLabel3.TabIndex = 332
        Me.GunaLabel3.Text = " DATE OF STOCK-IN"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(339, 26)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(160, 30)
        Me.GunaLabel1.TabIndex = 333
        Me.GunaLabel1.Text = "STOCK-IN BY"
        '
        'txtdate
        '
        Me.txtdate.BaseColor = System.Drawing.Color.White
        Me.txtdate.BorderColor = System.Drawing.Color.DimGray
        Me.txtdate.BorderSize = 1
        Me.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdate.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdate.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdate.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.DarkGray
        Me.txtdate.Location = New System.Drawing.Point(45, 59)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdate.Size = New System.Drawing.Size(282, 43)
        Me.txtdate.TabIndex = 336
        '
        'txtstockinby
        '
        Me.txtstockinby.BaseColor = System.Drawing.Color.White
        Me.txtstockinby.BorderColor = System.Drawing.Color.DimGray
        Me.txtstockinby.BorderSize = 1
        Me.txtstockinby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstockinby.FocusedBaseColor = System.Drawing.Color.White
        Me.txtstockinby.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstockinby.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtstockinby.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtstockinby.ForeColor = System.Drawing.Color.DarkGray
        Me.txtstockinby.Location = New System.Drawing.Point(344, 59)
        Me.txtstockinby.Name = "txtstockinby"
        Me.txtstockinby.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstockinby.Size = New System.Drawing.Size(287, 43)
        Me.txtstockinby.TabIndex = 337
        '
        'txtid
        '
        Me.txtid.BaseColor = System.Drawing.Color.White
        Me.txtid.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtid.BorderSize = 0
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtid.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtid.ForeColor = System.Drawing.Color.DarkGray
        Me.txtid.Location = New System.Drawing.Point(155, -19)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.Size = New System.Drawing.Size(303, 43)
        Me.txtid.TabIndex = 314
        Me.txtid.Visible = False
        '
        'btnadd
        '
        Me.btnadd.AnimationHoverSpeed = 0.07!
        Me.btnadd.AnimationSpeed = 0.03!
        Me.btnadd.BaseColor = System.Drawing.Color.Teal
        Me.btnadd.BorderColor = System.Drawing.Color.Black
        Me.btnadd.FocusedColor = System.Drawing.Color.Empty
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = Nothing
        Me.btnadd.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnadd.Location = New System.Drawing.Point(690, 111)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnadd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnadd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnadd.OnHoverImage = Nothing
        Me.btnadd.OnPressedColor = System.Drawing.Color.Black
        Me.btnadd.Size = New System.Drawing.Size(137, 56)
        Me.btnadd.TabIndex = 313
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsaveacount
        '
        Me.btnsaveacount.AnimationHoverSpeed = 0.07!
        Me.btnsaveacount.AnimationSpeed = 0.03!
        Me.btnsaveacount.BaseColor = System.Drawing.Color.Teal
        Me.btnsaveacount.BorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.FocusedColor = System.Drawing.Color.Empty
        Me.btnsaveacount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsaveacount.ForeColor = System.Drawing.Color.White
        Me.btnsaveacount.Image = Nothing
        Me.btnsaveacount.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnsaveacount.Location = New System.Drawing.Point(849, 111)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(137, 56)
        Me.btnsaveacount.TabIndex = 312
        Me.btnsaveacount.Text = "CANCEL"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1601, 48)
        Me.GunaPanel4.TabIndex = 312
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1540, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(61, 48)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtalert)
        Me.GroupBox1.Controls.Add(Me.txtqta)
        Me.GroupBox1.Controls.Add(Me.txtmax)
        Me.GroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GroupBox1.Controls.Add(Me.GunaLabel13)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.GunaLabel15)
        Me.GroupBox1.Controls.Add(Me.GunaLabel14)
        Me.GroupBox1.Controls.Add(Me.txttype)
        Me.GroupBox1.Controls.Add(Me.txtcompany)
        Me.GroupBox1.Controls.Add(Me.txtbrand)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GroupBox1.Controls.Add(Me.txtunit)
        Me.GroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 819)
        Me.GroupBox1.TabIndex = 313
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEDICINE INFORMATION"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 43)
        Me.Button2.TabIndex = 344
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtalert
        '
        Me.txtalert.BaseColor = System.Drawing.Color.White
        Me.txtalert.BorderColor = System.Drawing.Color.DimGray
        Me.txtalert.BorderSize = 1
        Me.txtalert.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtalert.Enabled = False
        Me.txtalert.FocusedBaseColor = System.Drawing.Color.White
        Me.txtalert.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtalert.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtalert.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalert.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtalert.Location = New System.Drawing.Point(34, 676)
        Me.txtalert.Name = "txtalert"
        Me.txtalert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtalert.Size = New System.Drawing.Size(386, 43)
        Me.txtalert.TabIndex = 343
        '
        'txtqta
        '
        Me.txtqta.BaseColor = System.Drawing.Color.White
        Me.txtqta.BorderColor = System.Drawing.Color.DimGray
        Me.txtqta.BorderSize = 1
        Me.txtqta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqta.Enabled = False
        Me.txtqta.FocusedBaseColor = System.Drawing.Color.White
        Me.txtqta.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqta.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtqta.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqta.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtqta.Location = New System.Drawing.Point(37, 754)
        Me.txtqta.Name = "txtqta"
        Me.txtqta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqta.Size = New System.Drawing.Size(383, 43)
        Me.txtqta.TabIndex = 342
        '
        'txtmax
        '
        Me.txtmax.BaseColor = System.Drawing.Color.White
        Me.txtmax.BorderColor = System.Drawing.Color.DimGray
        Me.txtmax.BorderSize = 1
        Me.txtmax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmax.Enabled = False
        Me.txtmax.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmax.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmax.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtmax.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmax.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtmax.Location = New System.Drawing.Point(35, 954)
        Me.txtmax.Name = "txtmax"
        Me.txtmax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmax.Size = New System.Drawing.Size(340, 43)
        Me.txtmax.TabIndex = 341
        Me.txtmax.Visible = False
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(30, 722)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(322, 30)
        Me.GunaLabel9.TabIndex = 340
        Me.GunaLabel9.Text = "IF YES, QUANTITY TO ALERT"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.Location = New System.Drawing.Point(32, 643)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(80, 30)
        Me.GunaLabel13.TabIndex = 339
        Me.GunaLabel13.Text = "ALERT"
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
        Me.txtdescription.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtdescription.Location = New System.Drawing.Point(35, 540)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescription.Size = New System.Drawing.Size(385, 100)
        Me.txtdescription.TabIndex = 337
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.Location = New System.Drawing.Point(32, 507)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(167, 30)
        Me.GunaLabel15.TabIndex = 336
        Me.GunaLabel15.Text = "DESCRIPTION"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.Location = New System.Drawing.Point(33, 921)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(253, 30)
        Me.GunaLabel14.TabIndex = 338
        Me.GunaLabel14.Text = "MAXIMUM STOCK-IN"
        Me.GunaLabel14.Visible = False
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
        Me.txttype.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txttype.Location = New System.Drawing.Point(35, 461)
        Me.txttype.Name = "txttype"
        Me.txttype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttype.Size = New System.Drawing.Size(398, 43)
        Me.txttype.TabIndex = 335
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
        Me.txtcompany.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompany.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtcompany.Location = New System.Drawing.Point(37, 382)
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcompany.Size = New System.Drawing.Size(398, 43)
        Me.txtcompany.TabIndex = 334
        Me.txtcompany.Text = "  "
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
        Me.txtbrand.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtbrand.Location = New System.Drawing.Point(37, 299)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbrand.Size = New System.Drawing.Size(398, 43)
        Me.txtbrand.TabIndex = 333
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(30, 27)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(209, 30)
        Me.GunaLabel2.TabIndex = 326
        Me.GunaLabel2.Text = "MEDICINE CODE"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(30, 106)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(197, 30)
        Me.GunaLabel4.TabIndex = 327
        Me.GunaLabel4.Text = "GENERIC NAME"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(32, 185)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(188, 30)
        Me.GunaLabel5.TabIndex = 328
        Me.GunaLabel5.Text = "MEDICINE UNIT"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(32, 266)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(297, 30)
        Me.GunaLabel6.TabIndex = 329
        Me.GunaLabel6.Text = "MEDICINE BRAND NAME"
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
        Me.txtunit.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtunit.Location = New System.Drawing.Point(37, 217)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtunit.Size = New System.Drawing.Size(398, 43)
        Me.txtunit.TabIndex = 332
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(30, 345)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(344, 30)
        Me.GunaLabel7.TabIndex = 330
        Me.GunaLabel7.Text = "MEDICINE COMPANY NAME"
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
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtname.Location = New System.Drawing.Point(37, 139)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Size = New System.Drawing.Size(398, 43)
        Me.txtname.TabIndex = 324
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(29, 428)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(191, 30)
        Me.GunaLabel8.TabIndex = 331
        Me.GunaLabel8.Text = "MEDICINE TYPE"
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
        Me.txtcode.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtcode.Location = New System.Drawing.Point(37, 60)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.Size = New System.Drawing.Size(292, 43)
        Me.txtcode.TabIndex = 325
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(470, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 306
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(479, 45)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 332
        Me.PictureBox5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboreceived)
        Me.GroupBox3.Controls.Add(Me.GunaLabel16)
        Me.GroupBox3.Controls.Add(Me.btnsaveacount)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.DOE)
        Me.GroupBox3.Controls.Add(Me.txtquantity)
        Me.GroupBox3.Controls.Add(Me.GunaLabel12)
        Me.GroupBox3.Controls.Add(Me.GunaLabel11)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(483, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1049, 182)
        Me.GroupBox3.TabIndex = 339
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "STOCK-IN INFORMATION"
        '
        'cboreceived
        '
        Me.cboreceived.BackColor = System.Drawing.Color.Transparent
        Me.cboreceived.BaseColor = System.Drawing.Color.White
        Me.cboreceived.BorderColor = System.Drawing.Color.DimGray
        Me.cboreceived.BorderSize = 1
        Me.cboreceived.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboreceived.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboreceived.FocusedColor = System.Drawing.Color.Empty
        Me.cboreceived.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboreceived.ForeColor = System.Drawing.Color.Black
        Me.cboreceived.FormattingEnabled = True
        Me.cboreceived.Location = New System.Drawing.Point(48, 56)
        Me.cboreceived.Name = "cboreceived"
        Me.cboreceived.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboreceived.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboreceived.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboreceived.Size = New System.Drawing.Size(409, 39)
        Me.cboreceived.TabIndex = 341
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.Location = New System.Drawing.Point(19, 27)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(206, 30)
        Me.GunaLabel16.TabIndex = 340
        Me.GunaLabel16.Text = "RECEIVED FROM"
        '
        'DOE
        '
        Me.DOE.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOE.Location = New System.Drawing.Point(577, 60)
        Me.DOE.Name = "DOE"
        Me.DOE.Size = New System.Drawing.Size(409, 36)
        Me.DOE.TabIndex = 339
        '
        'txtquantity
        '
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquantity.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(48, 131)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(409, 36)
        Me.txtquantity.TabIndex = 338
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.Location = New System.Drawing.Point(548, 27)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(215, 30)
        Me.GunaLabel12.TabIndex = 335
        Me.GunaLabel12.Text = "EXPIRATION DATE"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(19, 98)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(285, 30)
        Me.GunaLabel11.TabIndex = 334
        Me.GunaLabel11.Text = "QUANTITY TO STOCK-IN"
        '
        'Multiple_Stockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1601, 879)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MEDLV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Multiple_Stockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple_Stockin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtquantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents MEDLV As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnproceed As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnadd As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtdate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtstockinby As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboreceived As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DOE As DateTimePicker
    Friend WithEvents txtquantity As NumericUpDown
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txttype As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtcompany As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtbrand As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtunit As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcode As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents txtalert As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtqta As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmax As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtdescription As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
End Class
