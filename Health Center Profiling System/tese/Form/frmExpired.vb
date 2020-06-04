Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmExpired
    Private Sub frmExpired_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As ReportDocument
        rptdoc = New Expired
    End Sub
End Class