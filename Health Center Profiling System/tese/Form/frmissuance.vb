Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmissuance
    Private Sub frmissuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As ReportDocument
        rptdoc = New IssuanceReport
    End Sub
End Class