Public Class SearchQ
    Private Sub SearchQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
        ViewData()
    End Sub

    Private Sub ViewStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Public ans
    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName ,
                    (SELECT  COALESCE(SUM(QuantityS),0) from stockin WHERE stockin.MedicineID=profilemedicine.MedicineID) as stockintotal,(SELECT  COALESCE(SUM(QuantitySO),0) from stockout WHERE stockout.MedicineID=profilemedicine.MedicineID) as stockouttotal
                    FROM profilemedicine GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            ViewStock.Rows.Clear()
            While reader.Read()
                i = i + 1
                With ViewStock



                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockintotal"), reader.GetString("stockouttotal"), reader.GetString("stockintotal") - reader.GetString("stockouttotal"))

                End With
            End While
            reader.Close()
            ViewStock.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub searchstock(tb As String)
        Try
            Dim query As String
            ViewStock.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT *,(SELECT  COALESCE(SUM(QuantityS),0) from stockin WHERE stockin.MedicineID=profilemedicine.MedicineID) as stockintotal,(SELECT  COALESCE(SUM(QuantitySO),0) from stockout WHERE stockout.MedicineID=profilemedicine.MedicineID) as stockouttotal FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                    & " OR QuantityToAlert Like '" & tb & "%' OR Max LIKE '" & tb & "%' OR Quantity LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' GROUP BY MedicineCode DESC"

            ExecuteQuery(query)
            While reader.Read()

                i = i + 1
                With ViewStock

                    .Rows.Add(reader(0), i, reader(2), reader(1), reader("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockintotal"), reader.GetString("stockouttotal"), reader.GetString("stockintotal") - reader.GetString("stockouttotal"))
                End With
            End While
            reader.Close()
            ViewStock.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub

    Private Sub txtsearchstockout_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox(ans)
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)
        searchstock(txtsearchstockout.Text)
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ViewStock_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub ViewStock_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
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

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub searchstock1(tb As String)
        Try
            Dim query As String
            ProfileDG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN lotnumber ON lotnumber.LotNumberID=profilemedicine.LotNumberID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%'  " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                    & " OR QuantityToAlert Like '" & tb & "%' OR Max LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' GROUP BY MedicineCode DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With ProfileDG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader("MEdicineUnit") + "" + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("LotNumber"), reader(9), reader(10), "View Description", "Edit")
                End With
            End While
            reader.Close()
            ProfileDG.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub
    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs)
        searchstock1(txtsearch.Text)
    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Sub ViewData()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName,(SELECT LotNumber from lotnumber WHERE lotnumber.LotNumberID=profilemedicine.LotNumberID) as LotNumberName FROM profilemedicine GROUP BY MedicineID DESC"
            ExecuteQuery(sql)

            ProfileDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With ProfileDG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("LotNumberName"), reader(9), reader(10), "View Description")
                End With
            End While
            reader.Close()
            ProfileDG.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ProfileDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ProfileDG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        Try
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
        Catch
        End Try
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click_1(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()

    End Sub

    Private Sub GunaPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub ViewStock_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles ViewStock.CellContentClick

    End Sub

    Private Sub txtsearchstockout_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearchstockout.TextChanged
        searchstock(txtsearchstockout.Text)
    End Sub

    Private Sub txtsearch_TextChanged_2(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchstock1(txtsearch.Text)
    End Sub

    Private Sub GunaPanel2_Paint_1(sender As Object, e As PaintEventArgs) Handles GunaPanel2.Paint

    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel4.Paint

    End Sub
End Class