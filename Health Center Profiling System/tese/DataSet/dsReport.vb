Partial Class dsReport
    Partial Public Class TotalDataTable
        Private Sub TotalDataTable_TotalRowChanging(sender As Object, e As TotalRowChangeEvent) Handles Me.TotalRowChanging

        End Sub

    End Class

    Partial Public Class LStockDataTable
        Private Sub LStockDataTable_LStockRowChanging(sender As Object, e As LStockRowChangeEvent) Handles Me.LStockRowChanging

        End Sub

    End Class

    Partial Public Class DailyReleasedDataTable
        Private Sub DailyReleasedDataTable_DailyReleasedRowChanging(sender As Object, e As DailyReleasedRowChangeEvent) Handles Me.DailyReleasedRowChanging

        End Sub

    End Class

    Partial Public Class StockoutHistoryDataTable
        Private Sub StockoutHistoryDataTable_StockoutHistoryRowChanging(sender As Object, e As StockoutHistoryRowChangeEvent) Handles Me.StockoutHistoryRowChanging

        End Sub

    End Class

    Partial Public Class StockinHistoryDataTable
        Private Sub StockinHistoryDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

    End Class

    Partial Public Class MedProfileDataTable
        Private Sub MedProfileDataTable_MedProfileRowChanging(sender As Object, e As MedProfileRowChangeEvent) Handles Me.MedProfileRowChanging

        End Sub

    End Class

    Partial Public Class IssuanceRDataTable
        Private Sub IssuanceRDataTable_IssuanceRRowChanging(sender As Object, e As IssuanceRRowChangeEvent) Handles Me.IssuanceRRowChanging

        End Sub

        Private Sub IssuanceRDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging

        End Sub

    End Class

    Partial Public Class TotalStockinDataTable
        Private Sub TotalStockinDataTable_TotalStockinRowChanging(sender As Object, e As TotalStockinRowChangeEvent) Handles Me.TotalStockinRowChanging

        End Sub

    End Class

    Partial Public Class DailyStockinDataTable
        Private Sub DailyStockinDataTable_DailyStockinRowChanging(sender As Object, e As DailyStockinRowChangeEvent) Handles Me.DailyStockinRowChanging

        End Sub

        Private Sub DailyStockinDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UnitColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
