Public Class InventoryMenu
    Private Sub GunaTileButton6_Click(sender As Object, e As EventArgs)
        Stockin.Show()
    End Sub

    Private Sub GunaTileButton5_Click(sender As Object, e As EventArgs)
        AddStock.Show()
    End Sub

    Private Sub GunaTileButton7_Click(sender As Object, e As EventArgs)
        AddStockout.Show()
    End Sub

    Private Sub GunaTileButton12_Click(sender As Object, e As EventArgs)
        ViewExpiry.Show()
    End Sub

    Private Sub GunaTileButton11_Click(sender As Object, e As EventArgs)
        StockHistory.Show()

    End Sub

    Private Sub settings_Paint(sender As Object, e As PaintEventArgs) Handles settings.Paint

    End Sub

    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs)
        ViewStocks.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Stockin.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Stockin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StockHistory.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StockHistory.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ViewStocks.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ViewStocks.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ViewExpiry.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ViewExpiry.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        Issuance.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Issuance.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Issuance.Show()
    End Sub
End Class