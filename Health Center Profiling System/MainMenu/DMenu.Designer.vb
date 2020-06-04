<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMenu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.ExpiryDG = New Guna.UI.WinForms.GunaDataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.txtmonth = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.gvStocks = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Dashboard = New Guna.UI.WinForms.GunaPanel()
        Me.txtex = New Guna.UI.WinForms.GunaTextBox()
        Me.txtyear = New Guna.UI.WinForms.GunaTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtdate = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.ExpiryDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.gvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dashboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(46, 52)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(619, 60)
        Me.TextBox2.TabIndex = 33
        Me.TextBox2.Text = "LIST OF MEDICINE THAT ARE NEAR TO  THEIR EXPIRATION DATE"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.ExpiryDG)
        Me.GunaGroupBox1.Controls.Add(Me.txtmonth)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Maroon
        Me.GunaGroupBox1.LineTop = 40
        Me.GunaGroupBox1.Location = New System.Drawing.Point(46, 84)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(633, 613)
        Me.GunaGroupBox1.TabIndex = 3
        Me.GunaGroupBox1.Text = "EXPIRING MEDICINE"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'ExpiryDG
        '
        Me.ExpiryDG.AllowUserToAddRows = False
        Me.ExpiryDG.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ExpiryDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ExpiryDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ExpiryDG.BackgroundColor = System.Drawing.Color.White
        Me.ExpiryDG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExpiryDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ExpiryDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExpiryDG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ExpiryDG.ColumnHeadersHeight = 40
        Me.ExpiryDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.DataGridViewLinkColumn1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ExpiryDG.DefaultCellStyle = DataGridViewCellStyle3
        Me.ExpiryDG.EnableHeadersVisualStyles = False
        Me.ExpiryDG.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExpiryDG.Location = New System.Drawing.Point(1, 46)
        Me.ExpiryDG.Name = "ExpiryDG"
        Me.ExpiryDG.RowHeadersVisible = False
        Me.ExpiryDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ExpiryDG.RowTemplate.Height = 24
        Me.ExpiryDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ExpiryDG.Size = New System.Drawing.Size(632, 517)
        Me.ExpiryDG.TabIndex = 1
        Me.ExpiryDG.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid
        Me.ExpiryDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ExpiryDG.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ExpiryDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ExpiryDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ExpiryDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ExpiryDG.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ExpiryDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExpiryDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ExpiryDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ExpiryDG.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.ExpiryDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ExpiryDG.ThemeStyle.HeaderStyle.Height = 40
        Me.ExpiryDG.ThemeStyle.ReadOnly = False
        Me.ExpiryDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver
        Me.ExpiryDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ExpiryDG.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ExpiryDG.ThemeStyle.RowsStyle.Height = 24
        Me.ExpiryDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.ExpiryDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "NO."
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Medicine Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Expiration Date"
        Me.Column3.Name = "Column3"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Quantity"
        Me.Column7.Name = "Column7"
        '
        'DataGridViewLinkColumn1
        '
        Me.DataGridViewLinkColumn1.HeaderText = ""
        Me.DataGridViewLinkColumn1.Name = "DataGridViewLinkColumn1"
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
        Me.txtmonth.Location = New System.Drawing.Point(0, 555)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmonth.Size = New System.Drawing.Size(409, 43)
        Me.txtmonth.TabIndex = 346
        Me.txtmonth.Visible = False
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.gvStocks)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.LightSeaGreen
        Me.GunaGroupBox2.LineTop = 40
        Me.GunaGroupBox2.Location = New System.Drawing.Point(685, 84)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(679, 563)
        Me.GunaGroupBox2.TabIndex = 4
        Me.GunaGroupBox2.Text = "LOW COUNT MEDICINE"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'gvStocks
        '
        Me.gvStocks.AllowUserToAddRows = False
        Me.gvStocks.AllowUserToDeleteRows = False
        Me.gvStocks.AllowUserToResizeColumns = False
        Me.gvStocks.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvStocks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvStocks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvStocks.BackgroundColor = System.Drawing.Color.White
        Me.gvStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gvStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvStocks.ColumnHeadersHeight = 40
        Me.gvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column5, Me.Column9, Me.Column4, Me.Column6})
        Me.gvStocks.EnableHeadersVisualStyles = False
        Me.gvStocks.GridColor = System.Drawing.Color.Black
        Me.gvStocks.Location = New System.Drawing.Point(3, 46)
        Me.gvStocks.Name = "gvStocks"
        Me.gvStocks.ReadOnly = True
        Me.gvStocks.RowHeadersVisible = False
        Me.gvStocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvStocks.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.gvStocks.RowTemplate.Height = 30
        Me.gvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvStocks.Size = New System.Drawing.Size(676, 514)
        Me.gvStocks.TabIndex = 305
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Unit"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column9
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column9.HeaderText = "Stocks"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
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
        Me.btnUser.Location = New System.Drawing.Point(1138, 688)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(226, 71)
        Me.btnUser.TabIndex = 29
        Me.btnUser.Text = "STOCK-IN OR STOCK-OUT"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.Dashboard.BackColor = System.Drawing.Color.White
        Me.Dashboard.Controls.Add(Me.txtex)
        Me.Dashboard.Controls.Add(Me.txtyear)
        Me.Dashboard.Controls.Add(Me.Button2)
        Me.Dashboard.Controls.Add(Me.txtdate)
        Me.Dashboard.Controls.Add(Me.TextBox1)
        Me.Dashboard.Controls.Add(Me.Button1)
        Me.Dashboard.Controls.Add(Me.btnUser)
        Me.Dashboard.Controls.Add(Me.GunaGroupBox2)
        Me.Dashboard.Controls.Add(Me.GunaGroupBox1)
        Me.Dashboard.Controls.Add(Me.TextBox2)
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dashboard.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(1389, 793)
        Me.Dashboard.TabIndex = 4
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
        Me.txtex.Location = New System.Drawing.Point(157, 716)
        Me.txtex.Name = "txtex"
        Me.txtex.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtex.Size = New System.Drawing.Size(409, 43)
        Me.txtex.TabIndex = 339
        Me.txtex.Visible = False
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
        Me.txtyear.Location = New System.Drawing.Point(68, 738)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtyear.Size = New System.Drawing.Size(409, 43)
        Me.txtyear.TabIndex = 347
        Me.txtyear.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(661, 688)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 71)
        Me.Button2.TabIndex = 120
        Me.Button2.Text = "DAILY STOCK-IN"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.txtdate.Location = New System.Drawing.Point(76, 688)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdate.Size = New System.Drawing.Size(409, 43)
        Me.txtdate.TabIndex = 119
        Me.txtdate.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(688, 51)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(619, 26)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "LIST OF MEDICINE THAT ARE LOW IN STOCKS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(906, 688)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 71)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "DAILY RELEASED"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 793)
        Me.Controls.Add(Me.Dashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DMenu"
        Me.Text = "DMenu"
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.ExpiryDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        CType(Me.gvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dashboard.ResumeLayout(False)
        Me.Dashboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents ExpiryDG As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents gvStocks As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewLinkColumn
    Friend WithEvents Column6 As DataGridViewLinkColumn
    Friend WithEvents btnUser As Button
    Friend WithEvents Dashboard As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewLinkColumn1 As DataGridViewLinkColumn
    Friend WithEvents txtdate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtmonth As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtyear As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtex As Guna.UI.WinForms.GunaTextBox
End Class
