Public Class StockHistory
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM profilemedicine INNER JOIN stockin ON stockin.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID"
            ExecuteQuery(sql)

            HistoryDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With HistoryDG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("QuantityS"), Date.Parse(reader("DOE")).ToShortDateString(), reader.GetString("DOS"), reader.GetString("StockinBy"))
                End With
            End While
            reader.Close()
            HistoryDG.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In HistoryDG.Rows

                d = d + r.Cells(8).Value
                txtstockintotal.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Sub loadDataDisplay1()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID"
            ExecuteQuery(sql)

            History2DG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With History2DG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("QuantitySO"), Date.Parse(reader("DOS")).ToShortDateString(), reader.GetString("StockoutBy"))
                End With
            End While
            reader.Close()
            History2DG.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In History2DG.Rows

                d = d + r.Cells(8).Value
                txtstockouttotal.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
        loadDataDisplay1()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub HistoryDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub STOCKOUT_Click(sender As Object, e As EventArgs) Handles STOCKOUT.Click

    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub searchstockouthistory(tb As String)
        Try
            Dim query As String
            History2DG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM stockout INNER JOIN profilemedicine.MedicineID= stockin.MedicineID" _
                                & " INNER JOIN brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                    & " OR QuantitySO Like '" & tb & "%' OR ExpiryDate LIKE '" & tb & "%' OR StockoutBy Like '" & tb & "%' " _
                                  & "OR DOS LIKE '" & tb & "%' GROUP BY MedicineID DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With History2DG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("QuantitySO"), Date.Parse(reader("ExpiryDate")).ToShortDateString(), Date.Parse(reader("DOS")).ToShortDateString(), reader.GetString("StockoutBy"))
                End With
            End While
            reader.Close()
            History2DG.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub

    Public Sub searchstock(tb As String)

        Dim query As String
            HistoryDG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
        query = "SELECT * FROM profilemedicine INNER JOIN stockin on stockin.MedicineID=profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN lotnumber ON lotnumber.LotNumberID=profilemedicine.LotNumberID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                    & " OR QuantityToAlert Like '" & tb & "%' OR Max LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With HistoryDG
                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("QuantityS"), Date.Parse(reader("DOE")).ToShortDateString(), Date.Parse(reader("DOS")).ToShortDateString(), reader.GetString("StockinBy"))
            End With
            End While
            reader.Close()
            HistoryDG.ClearSelection()

            dbDisconnect()

    End Sub
    Public Sub searchstock4(tb As String)
        Try
            Dim query As String
            History2DG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM profilemedicine INNER JOIN stockout on stockout.MedicineID=profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN lotnumber ON lotnumber.LotNumberID=profilemedicine.LotNumberID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                    & " OR QuantityToAlert Like '" & tb & "%' OR Max LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' GROUP BY MedicineCode DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With History2DG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("QuantitySO"), Date.Parse(reader("DateE")).ToShortDateString(), Date.Parse(reader("DOS")).ToShortDateString(), reader.GetString("StockoutBy"))
                End With
            End While
            reader.Close()
            History2DG.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub
    Public Sub searchstock1(tb As String)
        Try
            Dim query As String
            HistoryDG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                   & " OR QuantitySO Like '" & tb & "%' OR ExpiryDate LIKE '" & tb & "%' OR StockoutBy Like '" & tb & "%' " _
                                 & "OR DOS LIKE '" & tb & "%' GROUP BY StockoutID DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With HistoryDG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("QuantityS"), reader.GetString("DOE"), reader.GetString("DOS"), reader.GetString("StockinBy"))
                End With
            End While
            reader.Close()
            HistoryDG.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub
    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchstock(txtsearch.Text)
    End Sub

    Private Sub HistoryDG_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


 

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearchstockout.TextChanged
        searchstock4(txtsearchstockout.Text)
    End Sub

    Private Sub History2DG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub History2DG_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles History2DG.CellContentClick

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim frm As New frmstockinhistory
            Dim rpt As New StockinH
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Stockin Date")
                .Columns.Add("BY")
                .Columns.Add("Quantity")
                .Columns.Add("Expiration")

            End With

            For Each r As DataGridViewRow In HistoryDG.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(6).Value, r.Cells(4).Value, r.Cells(10).Value, r.Cells(11).Value, r.Cells(8).Value, txtstockintotal)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try
            Dim frm As New frmstockinhistory
            Dim rpt As New StockinH
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Stockin Date")
                .Columns.Add("BY")
                .Columns.Add("Quantity")
                .Columns.Add("Expiration")

            End With

            For Each r As DataGridViewRow In HistoryDG.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(6).Value, r.Cells(4).Value, r.Cells(10).Value, r.Cells(11).Value, r.Cells(8).Value, txtstockouttotal.Text)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub HistoryDG_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles HistoryDG.CellContentClick

    End Sub

    Private Sub HistoryDG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles HistoryDG.CellPainting
        'If there is no search string, no rows, or nothing in this cell, then get out. 
        If txtsearch.Text = String.Empty And txtsearch.Text = "" Then Return
        If (e.Value Is Nothing) Then Return
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        e.Handled = True
        e.PaintBackground(e.CellBounds, True)

        'Get the value of the text in the cell, and the search term. Work with everything in lowercase for more accurate highlighting
        Dim str_SearchTerm As String = txtsearch.Text.Trim.ToLower
        Dim str_CellText As String = DirectCast(e.FormattedValue, String).ToLower

        'Create a list of the character ranges that need to be highlighted. We need to know the start index and the length
        Dim HLRanges As New List(Of CharacterRange)
        Dim SearchIndex As Integer = str_CellText.IndexOf(str_SearchTerm)
        Do Until SearchIndex = -1
            HLRanges.Add(New CharacterRange(SearchIndex, str_SearchTerm.Length))
            SearchIndex = str_CellText.IndexOf(str_SearchTerm, SearchIndex + str_SearchTerm.Length)
        Loop

        ' We also work with the original cell text which is has not been converted to lowercase, else the sizes are incorrect
        str_CellText = DirectCast(e.FormattedValue, String)

        ' Choose your colours. A different colour is used on the currently selected rows
        Dim HLColour As SolidBrush
        If ((e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.None) Then
            HLColour = New SolidBrush(Color.SeaGreen)
        Else
            HLColour = New SolidBrush(Color.BurlyWood)
        End If

        'Loop through all of the found instances and draw the highlight box
        For Each HLRange In HLRanges

            ' Create the rectangle. It should start just underneath the top of the cell, and go to just above the bottom
            Dim HLRectangle As New Rectangle()
            HLRectangle.Y = e.CellBounds.Y + 1
            HLRectangle.Height = e.CellBounds.Height - 5

            ' Determine the size of the text before the area to highlight, and the size of the text to highlight. 
            ' We need to know the size of the text before so that we know where to start the highlight rectangle
            Dim TextBeforeHL As String = str_CellText.Substring(0, HLRange.First)
            Dim TextToHL As String = str_CellText.Substring(HLRange.First, HLRange.Length)
            Dim SizeOfTextBeforeHL As Size = TextRenderer.MeasureText(e.Graphics, TextBeforeHL, e.CellStyle.Font, e.CellBounds.Size)
            Dim SizeOfTextToHL As Size = TextRenderer.MeasureText(e.Graphics, TextToHL, e.CellStyle.Font, e.CellBounds.Size)

            'Set the width of the rectangle, a little wider to make the highlight clearer
            If SizeOfTextBeforeHL.Width > 5 Then
                HLRectangle.X = e.CellBounds.X + SizeOfTextBeforeHL.Width - 6
                HLRectangle.Width = SizeOfTextToHL.Width - 6
            Else
                HLRectangle.X = e.CellBounds.X + 2
                HLRectangle.Width = SizeOfTextToHL.Width - 6
            End If

            'Paint the highlight area
            e.Graphics.FillRectangle(HLColour, HLRectangle)
        Next

        'Paint the rest of the cell as usual
        e.PaintContent(e.CellBounds)
    End Sub

    Private Sub History2DG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles History2DG.CellPainting
        'If there is no search string, no rows, or nothing in this cell, then get out. 
        If txtsearchstockout.Text = String.Empty And txtsearchstockout.Text = "" Then Return
        If (e.Value Is Nothing) Then Return
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        e.Handled = True
        e.PaintBackground(e.CellBounds, True)

        'Get the value of the text in the cell, and the search term. Work with everything in lowercase for more accurate highlighting
        Dim str_SearchTerm As String = txtsearchstockout.Text.Trim.ToLower
        Dim str_CellText As String = DirectCast(e.FormattedValue, String).ToLower

        'Create a list of the character ranges that need to be highlighted. We need to know the start index and the length
        Dim HLRanges As New List(Of CharacterRange)
        Dim SearchIndex As Integer = str_CellText.IndexOf(str_SearchTerm)
        Do Until SearchIndex = -1
            HLRanges.Add(New CharacterRange(SearchIndex, str_SearchTerm.Length))
            SearchIndex = str_CellText.IndexOf(str_SearchTerm, SearchIndex + str_SearchTerm.Length)
        Loop

        ' We also work with the original cell text which is has not been converted to lowercase, else the sizes are incorrect
        str_CellText = DirectCast(e.FormattedValue, String)

        ' Choose your colours. A different colour is used on the currently selected rows
        Dim HLColour As SolidBrush
        If ((e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.None) Then
            HLColour = New SolidBrush(Color.SeaGreen)
        Else
            HLColour = New SolidBrush(Color.BurlyWood)
        End If

        'Loop through all of the found instances and draw the highlight box
        For Each HLRange In HLRanges

            ' Create the rectangle. It should start just underneath the top of the cell, and go to just above the bottom
            Dim HLRectangle As New Rectangle()
            HLRectangle.Y = e.CellBounds.Y + 1
            HLRectangle.Height = e.CellBounds.Height - 5

            ' Determine the size of the text before the area to highlight, and the size of the text to highlight. 
            ' We need to know the size of the text before so that we know where to start the highlight rectangle
            Dim TextBeforeHL As String = str_CellText.Substring(0, HLRange.First)
            Dim TextToHL As String = str_CellText.Substring(HLRange.First, HLRange.Length)
            Dim SizeOfTextBeforeHL As Size = TextRenderer.MeasureText(e.Graphics, TextBeforeHL, e.CellStyle.Font, e.CellBounds.Size)
            Dim SizeOfTextToHL As Size = TextRenderer.MeasureText(e.Graphics, TextToHL, e.CellStyle.Font, e.CellBounds.Size)

            'Set the width of the rectangle, a little wider to make the highlight clearer
            If SizeOfTextBeforeHL.Width > 5 Then
                HLRectangle.X = e.CellBounds.X + SizeOfTextBeforeHL.Width - 6
                HLRectangle.Width = SizeOfTextToHL.Width - 6
            Else
                HLRectangle.X = e.CellBounds.X + 2
                HLRectangle.Width = SizeOfTextToHL.Width - 6
            End If

            'Paint the highlight area
            e.Graphics.FillRectangle(HLColour, HLRectangle)
        Next

        'Paint the rest of the cell as usual
        e.PaintContent(e.CellBounds)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class