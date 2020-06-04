<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchMed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchMed))
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtsearchstockout = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsaveacount = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.profilelv = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.GunaPanel4.Size = New System.Drawing.Size(1441, 49)
        Me.GunaPanel4.TabIndex = 87
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1371, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(70, 49)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'txtsearchstockout
        '
        Me.txtsearchstockout.BaseColor = System.Drawing.Color.White
        Me.txtsearchstockout.BorderColor = System.Drawing.Color.Silver
        Me.txtsearchstockout.BorderSize = 0
        Me.txtsearchstockout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearchstockout.FocusedBaseColor = System.Drawing.Color.White
        Me.txtsearchstockout.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchstockout.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsearchstockout.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.txtsearchstockout.ForeColor = System.Drawing.Color.DarkGray
        Me.txtsearchstockout.Location = New System.Drawing.Point(241, 113)
        Me.txtsearchstockout.Name = "txtsearchstockout"
        Me.txtsearchstockout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearchstockout.Size = New System.Drawing.Size(1136, 61)
        Me.txtsearchstockout.TabIndex = 120
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(54, 131)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(170, 30)
        Me.GunaLabel1.TabIndex = 121
        Me.GunaLabel1.Text = "SEARCH HERE"
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
        Me.btnsaveacount.Location = New System.Drawing.Point(1197, 685)
        Me.btnsaveacount.Name = "btnsaveacount"
        Me.btnsaveacount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsaveacount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsaveacount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsaveacount.OnHoverImage = Nothing
        Me.btnsaveacount.OnPressedColor = System.Drawing.Color.Black
        Me.btnsaveacount.Size = New System.Drawing.Size(180, 68)
        Me.btnsaveacount.TabIndex = 122
        Me.btnsaveacount.Text = "CANCEL"
        Me.btnsaveacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaButton1.Location = New System.Drawing.Point(999, 685)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(180, 68)
        Me.GunaButton1.TabIndex = 123
        Me.GunaButton1.Text = "ADD"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'profilelv
        '
        Me.profilelv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.profilelv.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profilelv.FullRowSelect = True
        Me.profilelv.GridLines = True
        Me.profilelv.Location = New System.Drawing.Point(59, 205)
        Me.profilelv.Name = "profilelv"
        Me.profilelv.Size = New System.Drawing.Size(1318, 460)
        Me.profilelv.TabIndex = 124
        Me.profilelv.UseCompatibleStateImageBehavior = False
        Me.profilelv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No."
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Medicine Code"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Medicine Name"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Brand"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Company"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'SearchMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 789)
        Me.Controls.Add(Me.profilelv)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.btnsaveacount)
        Me.Controls.Add(Me.txtsearchstockout)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SearchMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchMed"
        Me.GunaPanel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtsearchstockout As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsaveacount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents profilelv As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
