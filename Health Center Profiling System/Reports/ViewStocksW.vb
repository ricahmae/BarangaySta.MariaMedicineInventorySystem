Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ViewStocksW
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim rptdoc As ReportDocument
        rptdoc = New CrystalReport1
        Me.CrystalReportViewer1.ReportSource = rptdoc

    End Sub

    Private Sub ViewStocksW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class