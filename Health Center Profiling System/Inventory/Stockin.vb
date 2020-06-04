Public Class Stockin
    Public medid As Integer
    Public medcode As String
    Public medname As String
    Public medunit As String
    Public medunit2 As String
    Public medcompany As String
    Public medtype As String
    Public medbrand As String
    Public description As String
    Public QTA As Integer
    Public max As Integer
    Public alert As String
    Public sum As Integer
    Public remaining As Integer
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub

    Private Sub Stockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()

    End Sub

    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName ,
                    (SELECT  COALESCE(SUM(QuantityS),0) from stockin WHERE stockin.MedicineID=profilemedicine.MedicineID) as stockintotal,(SELECT  COALESCE(SUM(QuantitySO),0) from stockout WHERE stockout.MedicineID=profilemedicine.MedicineID) as stockouttotal
                    FROM profilemedicine GROUP BY MedicineID DESC"
            ExecuteQuery(sql)

            StockinDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With StockinDG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader(10), reader(12), reader.GetString("stockintotal") - reader.GetString("stockouttotal"), "STOCK-IN", "STOCK-OUT")
                End With
            End While
            reader.Close()
            StockinDG.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UserDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockinDG.CellContentClick
        Try
            If e.ColumnIndex = 11 Then

                Dim id As Integer
                id = (StockinDG.SelectedRows(0).Cells(0).Value)

                Dim sql As String
                Dim i As Integer = 0
                dbConnect()
                sql = "SELECT *,(SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE MedicineID = " & id & " LIMIT 1"
                ExecuteQuery(sql)


                While reader.Read()
                    medid = reader(0)
                    medcode = reader(1)
                    medname = reader(2)
                    medunit = reader(3)
                    medunit2 = reader.GetString("UnitName")
                    medbrand = reader.GetString("BrandName")
                    medtype = reader.GetString("TypeName")
                    medcompany = reader.GetString("CompanyName")
                    description = reader(9)
                    QTA = reader(10)
                    max = reader(12)
                    alert = reader(11)

                End While
                reader.Close()

                dbDisconnect()
                AddStock.Show()

            ElseIf e.ColumnIndex = 12 Then
                If StockinDG.SelectedRows(0).Cells(10).Value = 0 Then
                    MsgBox("Please Stockin First!", vbInformation)
                Else
                    Dim id As Integer
                    id = (StockinDG.SelectedRows(0).Cells(0).Value)

                    Dim sql As String
                    Dim i As Integer = 0
                    dbConnect()
                    sql = "SELECT *,(SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE MedicineID = " & id & " LIMIT 1"
                    ExecuteQuery(sql)


                    While reader.Read()
                        medid = reader(0)
                        medcode = reader(1)
                        medname = reader(2)
                        medunit = reader(3)
                        medunit2 = reader.GetString("UnitName")
                        medbrand = reader.GetString("BrandName")
                        medtype = reader.GetString("TypeName")
                        medcompany = reader.GetString("CompanyName")
                        description = reader(8)

                    End While
                    reader.Close()
                    Dim sql2 As String = "SELECT Quantity FROM profilemedicine WHERE MedicineID = " & id & " LIMIT 1"
                    ExecuteQuery(sql2)
                    While reader.Read()

                        sum = reader.GetString("Quantity")
                    End While


                    reader.Close()
                    dbDisconnect()




                    AddStockout.Show()

                End If
            End If
        Catch
        End Try

    End Sub
    Public Sub searchstock(tb As String)
        Try
            Dim query As String
            StockinDG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT *, (SELECT  COALESCE(SUM(QuantityS),0) from stockin WHERE stockin.MedicineID=profilemedicine.MedicineID) as stockintotal,(SELECT  COALESCE(SUM(QuantitySO),0) from stockout WHERE stockout.MedicineID=profilemedicine.MedicineID) as stockouttotal FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                    & " OR QuantityToAlert Like '" & tb & "%' OR Max LIKE '" & tb & "%' OR Quantity LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' GROUP BY MedicineCode DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With StockinDG
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader(10), reader(12), reader.GetString("stockintotal") - reader.GetString("stockouttotal"), "STOCK-IN", "STOCK-OUT")
                End With
            End While
            reader.Close()
            StockinDG.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub
    Private Sub GunaPictureBox1_Click_1(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub StockinDG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles StockinDG.CellPainting
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

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchstock(txtsearch.Text)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)
        Multiple_Stockin.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class