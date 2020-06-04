Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmDailyReleased
    Private Sub frmDailyReleased_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As ReportDocument
        rptdoc = New Released
    End Sub
End Class