<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportMenu
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
        Me.reports = New Guna.UI.WinForms.GunaPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'reports
        '
        Me.reports.BackColor = System.Drawing.Color.White
        Me.reports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reports.Location = New System.Drawing.Point(0, 0)
        Me.reports.Name = "reports"
        Me.reports.Size = New System.Drawing.Size(1389, 793)
        Me.reports.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 793)
        Me.Controls.Add(Me.reports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportMenu"
        Me.Text = "ReportMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reports As Guna.UI.WinForms.GunaPanel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
