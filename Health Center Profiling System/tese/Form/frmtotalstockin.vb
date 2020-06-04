Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmtotalstockin

    Private Sub frmtotalstockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As ReportDocument
        rptdoc = New TotalStockin
    End Sub
End Class