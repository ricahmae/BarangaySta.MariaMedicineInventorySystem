
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class Expiry
    Private Sub Expiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As ReportDocument
        rptdoc = New NearExpiration
    End Sub
End Class