<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Issuance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Issuance))
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txtbname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcode = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtavailable = New System.Windows.Forms.TextBox()
        Me.txtid = New Guna.UI.WinForms.GunaTextBox()
        Me.btnadd = New Guna.UI.WinForms.GunaButton()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txttype = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtunit = New Guna.UI.WinForms.GunaTextBox()
        Me.txtquantity = New System.Windows.Forms.NumericUpDown()
        Me.btnproceed = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.MEDLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.txtex = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtreceiver = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdos = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtyear = New Guna.UI.WinForms.GunaTextBox()
        Me.txtmonth = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.BaseColor = System.Drawing.Color.White
        Me.txtname.BorderColor = System.Drawing.Color.Black
        Me.txtname.BorderSize = 1
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Enabled = False
        Me.txtname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtname.Location = New System.Drawing.Point(112, 240)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Size = New System.Drawing.Size(409, 43)
        Me.txtname.TabIndex = 122
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(83, 207)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(197, 30)
        Me.GunaLabel9.TabIndex = 120
        Me.GunaLabel9.Text = "GENERIC NAME"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(83, 128)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(209, 30)
        Me.GunaLabel8.TabIndex = 119
        Me.GunaLabel8.Text = "MEDICINE CODE"
        '
        'txtbname
        '
        Me.txtbname.BaseColor = System.Drawing.Color.White
        Me.txtbname.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbname.BorderSize = 1
        Me.txtbname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbname.Enabled = False
        Me.txtbname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtbname.Location = New System.Drawing.Point(112, 319)
        Me.txtbname.Name = "txtbname"
        Me.txtbname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbname.Size = New System.Drawing.Size(409, 43)
        Me.txtbname.TabIndex = 302
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(83, 602)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(129, 30)
        Me.GunaLabel1.TabIndex = 301
        Me.GunaLabel1.Text = "QUANTITY"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(83, 286)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(173, 30)
        Me.GunaLabel2.TabIndex = 300
        Me.GunaLabel2.Text = "BRAND NAME"
        '
        'txtcode
        '
        Me.txtcode.BaseColor = System.Drawing.Color.White
        Me.txtcode.BorderColor = System.Drawing.Color.Black
        Me.txtcode.BorderSize = 1
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.Enabled = False
        Me.txtcode.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcode.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcode.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.DarkGray
        Me.txtcode.Location = New System.Drawing.Point(112, 161)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.Size = New System.Drawing.Size(303, 43)
        Me.txtcode.TabIndex = 121
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(83, 523)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(136, 30)
        Me.GunaLabel3.TabIndex = 305
        Me.GunaLabel3.Text = "AVAILABLE"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(421, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 43)
        Me.Button1.TabIndex = 306
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GroupBox1.Controls.Add(Me.txtavailable)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btnsaveacount)
        Me.GroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txttype)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtbname)
        Me.GroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GroupBox1.Controls.Add(Me.txtunit)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.txtquantity)
        Me.GroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 813)
        Me.GroupBox1.TabIndex = 309
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEDICINE INFORMATION"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(112, 82)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(409, 36)
        Me.txtsearch.TabIndex = 317
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(83, 49)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(254, 30)
        Me.GunaLabel7.TabIndex = 316
        Me.GunaLabel7.Text = "QUICK SEARCH HERE"
        '
        'txtavailable
        '
        Me.txtavailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtavailable.Enabled = False
        Me.txtavailable.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavailable.Location = New System.Drawing.Point(112, 556)
        Me.txtavailable.Name = "txtavailable"
        Me.txtavailable.Size = New System.Drawing.Size(409, 36)
        Me.txtavailable.TabIndex = 315
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
        Me.txtid.Location = New System.Drawing.Point(234, -10)
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
        Me.btnadd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnadd.FocusedColor = System.Drawing.Color.Empty
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = Nothing
        Me.btnadd.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnadd.Location = New System.Drawing.Point(138, 699)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnadd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnadd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnadd.OnHoverImage = Nothing
        Me.btnadd.OnPressedColor = System.Drawing.Color.Black
        Me.btnadd.Size = New System.Drawing.Size(166, 78)
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
        Me.btnsaveacount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsaveacount.FocusedColor = System.Drawing.Color.Empty
        Me.btnsaveacount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveacount.ForeColor = System.Drawing.Color.White
        Me.btnsaveacount.Image = Nothing
        Me.btnsaveacount.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnsaveacount.Location = New System.Drawing.Point(310, 699)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(162, 78)
        Me.btnsaveacount.TabIndex = 312
        Me.btnsaveacount.Text = "CANCEL"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(83, 365)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(191, 30)
        Me.GunaLabel6.TabIndex = 311
        Me.GunaLabel6.Text = "MEDICINE TYPE"
        '
        'txttype
        '
        Me.txttype.BaseColor = System.Drawing.Color.White
        Me.txttype.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txttype.BorderSize = 1
        Me.txttype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttype.Enabled = False
        Me.txttype.FocusedBaseColor = System.Drawing.Color.White
        Me.txttype.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttype.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttype.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.ForeColor = System.Drawing.Color.DarkGray
        Me.txttype.Location = New System.Drawing.Point(112, 398)
        Me.txttype.Name = "txttype"
        Me.txttype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttype.Size = New System.Drawing.Size(409, 43)
        Me.txttype.TabIndex = 311
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(83, 444)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(188, 30)
        Me.GunaLabel5.TabIndex = 311
        Me.GunaLabel5.Text = "MEDICINE UNIT"
        '
        'txtunit
        '
        Me.txtunit.BaseColor = System.Drawing.Color.White
        Me.txtunit.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtunit.BorderSize = 1
        Me.txtunit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtunit.Enabled = False
        Me.txtunit.FocusedBaseColor = System.Drawing.Color.White
        Me.txtunit.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtunit.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtunit.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.ForeColor = System.Drawing.Color.DarkGray
        Me.txtunit.Location = New System.Drawing.Point(112, 477)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtunit.Size = New System.Drawing.Size(409, 43)
        Me.txtunit.TabIndex = 311
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(112, 635)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(409, 36)
        Me.txtquantity.TabIndex = 311
        '
        'btnproceed
        '
        Me.btnproceed.AnimationHoverSpeed = 0.07!
        Me.btnproceed.AnimationSpeed = 0.03!
        Me.btnproceed.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnproceed.BorderColor = System.Drawing.Color.Black
        Me.btnproceed.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnproceed.FocusedColor = System.Drawing.Color.Empty
        Me.btnproceed.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproceed.ForeColor = System.Drawing.Color.White
        Me.btnproceed.Image = Nothing
        Me.btnproceed.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnproceed.Location = New System.Drawing.Point(1566, 734)
        Me.btnproceed.Name = "btnproceed"
        Me.btnproceed.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnproceed.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnproceed.OnHoverForeColor = System.Drawing.Color.White
        Me.btnproceed.OnHoverImage = Nothing
        Me.btnproceed.OnPressedColor = System.Drawing.Color.Black
        Me.btnproceed.Size = New System.Drawing.Size(180, 88)
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
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaButton3.Location = New System.Drawing.Point(1762, 734)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(180, 88)
        Me.GunaButton3.TabIndex = 311
        Me.GunaButton3.Text = "CANCEL"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MEDLV
        '
        Me.MEDLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.MEDLV.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEDLV.FullRowSelect = True
        Me.MEDLV.GridLines = True
        Me.MEDLV.Location = New System.Drawing.Point(661, 122)
        Me.MEDLV.Name = "MEDLV"
        Me.MEDLV.Size = New System.Drawing.Size(1307, 550)
        Me.MEDLV.TabIndex = 311
        Me.MEDLV.UseCompatibleStateImageBehavior = False
        Me.MEDLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item ID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MEDICINE CODE"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MEDICINE NAME"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MEDICINE BRAND"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 190
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MEDICINE UNIT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "QUANTITY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "EX"
        Me.ColumnHeader8.Width = 0
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GunaPanel4.Controls.Add(Me.txtex)
        Me.GunaPanel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1942, 67)
        Me.GunaPanel4.TabIndex = 312
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
        Me.txtex.Location = New System.Drawing.Point(840, 12)
        Me.txtex.Name = "txtex"
        Me.txtex.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtex.Size = New System.Drawing.Size(409, 43)
        Me.txtex.TabIndex = 339
        Me.txtex.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1879, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(63, 67)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(80, 107)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(215, 30)
        Me.GunaLabel4.TabIndex = 309
        Me.GunaLabel4.Text = "RECEIVERS NAME"
        '
        'txtreceiver
        '
        Me.txtreceiver.BaseColor = System.Drawing.Color.White
        Me.txtreceiver.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtreceiver.BorderSize = 1
        Me.txtreceiver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreceiver.FocusedBaseColor = System.Drawing.Color.White
        Me.txtreceiver.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtreceiver.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtreceiver.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiver.ForeColor = System.Drawing.Color.DarkGray
        Me.txtreceiver.Location = New System.Drawing.Point(364, 100)
        Me.txtreceiver.Name = "txtreceiver"
        Me.txtreceiver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreceiver.Size = New System.Drawing.Size(409, 43)
        Me.txtreceiver.TabIndex = 310
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdos)
        Me.GroupBox2.Controls.Add(Me.GunaLabel10)
        Me.GroupBox2.Controls.Add(Me.txtreceiver)
        Me.GroupBox2.Controls.Add(Me.GunaLabel4)
        Me.GroupBox2.Location = New System.Drawing.Point(661, 694)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 174)
        Me.GroupBox2.TabIndex = 310
        Me.GroupBox2.TabStop = False
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
        Me.txtdos.Location = New System.Drawing.Point(364, 40)
        Me.txtdos.Name = "txtdos"
        Me.txtdos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdos.Size = New System.Drawing.Size(409, 43)
        Me.txtdos.TabIndex = 311
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(59, 40)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(240, 30)
        Me.GunaLabel10.TabIndex = 312
        Me.GunaLabel10.Text = " DATE OF ISSUANCE"
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
        Me.txtyear.Location = New System.Drawing.Point(1213, 24)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtyear.Size = New System.Drawing.Size(409, 43)
        Me.txtyear.TabIndex = 343
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
        Me.txtmonth.Location = New System.Drawing.Point(666, 9)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmonth.Size = New System.Drawing.Size(409, 43)
        Me.txtmonth.TabIndex = 342
        Me.txtmonth.Visible = False
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.BorderSize = 0
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaTextBox1.Location = New System.Drawing.Point(1022, 27)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(409, 43)
        Me.GunaTextBox1.TabIndex = 341
        Me.GunaTextBox1.Visible = False
        '
        'Issuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 866)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.btnproceed)
        Me.Controls.Add(Me.MEDLV)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Issuance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtquantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtbname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcode As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txttype As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtunit As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtquantity As NumericUpDown
    Friend WithEvents btnadd As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnproceed As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MEDLV As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents txtavailable As TextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtreceiver As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtex As Guna.UI.WinForms.GunaTextBox
    Public WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents txtyear As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmonth As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
End Class
