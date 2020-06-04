Public Class ViewExpiry
    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub
    Public Sub searchstock(tb As String)
        Try
            Dim query As String
            ExpiryDG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM profilemedicine INNER JOIN expiry ON expiry.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID WHERE QuantityE <> 0" _
                                  & "  And MedicineName  Like '" & tb & "%' GROUP BY MedicineCode DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With ExpiryDG
                    .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader("DOE"), reader.GetString("QuantityE"))
                End With
            End While
            reader.Close()
            ExpiryDG.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In ExpiryDG.Rows

                d = d + r.Cells(9).Value
                txtremaining.Text = d.ToString
            Next
            dbDisconnect()
        Catch

        End Try
    End Sub
    Public Sub searchstock1(tb As String, D2 As Date)

        Dim query As String
        expireddg.Rows.Clear()
        dbConnect()
        Dim i As Integer = 0
        query =
                "SELECT * FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " WHERE DateE = '" & D2 & "' AND QuantitySO <> 0 And (MedicineName Like '" & tb & "%') GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
        While reader.Read()
            i = i + 1
            With expireddg
                .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DateE")).ToShortDateString(), reader("QuantitySO"))
            End With
        End While
        reader.Close()
        expireddg.ClearSelection()
        Dim d As Decimal = 0
        For Each r As DataGridViewRow In expireddg.Rows

            d = d + r.Cells(9).Value
            txt1.Text = d.ToString
        Next
        dbDisconnect()

    End Sub
    Public Sub searchstock2(tb As String, D2 As String)

        Dim query As String
        expireddg.Rows.Clear()
        dbConnect()
        Dim i As Integer = 0
        query =
                "SELECT * FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " WHERE DateE = '" & D2 & "' AND QuantitySO <> 0 And (MedicineName Like '" & tb & "%') GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
        While reader.Read()
            i = i + 1
            With expireddg
                .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DateE")).ToShortDateString(), reader("QuantitySO"))
            End With
        End While
        reader.Close()
        expireddg.ClearSelection()
        Dim d As Decimal = 0
        For Each r As DataGridViewRow In expireddg.Rows

            d = d + r.Cells(9).Value
            txt1.Text = d.ToString
        Next
        dbDisconnect()

    End Sub
    Public Sub searchstock3(tb As String, D2 As String)

        Dim query As String
        expireddg.Rows.Clear()
        dbConnect()
        Dim i As Integer = 0
        query =
                "SELECT * FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " WHERE DateE = '" & D2 & "' AND QuantitySO <> 0 And (MedicineName Like '" & tb & "%') GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
        While reader.Read()
            i = i + 1
            With expireddg
                .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DateE")).ToShortDateString(), reader("QuantitySO"))
            End With
        End While
        reader.Close()
        expireddg.ClearSelection()
        Dim d As Decimal = 0
        For Each r As DataGridViewRow In expireddg.Rows

            d = d + r.Cells(9).Value
            txt1.Text = d.ToString
        Next
        dbDisconnect()

    End Sub
    Private Sub ViewExpiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
        ComboBox1.SelectedIndex = 0
        loadDataDisplay1()
    End Sub

    Sub loadDataDisplay()
        Try

            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM expiry,profilemedicine WHERE profilemedicine.MedicineID=expiry.MedicineID AND QuantityE <> 0"
            ExecuteQuery(sql)

            ExpiryDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With ExpiryDG
                    .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DOE")).ToShortDateString(), reader("QuantityE"))
                End With
            End While
            reader.Close()
            ExpiryDG.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In ExpiryDG.Rows

                d = d + r.Cells(9).Value
                txtremaining.Text = d.ToString
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
            sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.DateE = '" & Format(CDate(DateTimePicker3.Value).Date, "yyyy-M-d") & "' AND Reason='Expired' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            expireddg.Rows.Clear()
            While reader.Read()
                i = i + 1
                With expireddg
                    .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DateE")).ToShortDateString(), reader("QuantitySO"))
                End With
            End While
            reader.Close()
            expireddg.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In expireddg.Rows

                d = d + r.Cells(9).Value
                txt1.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Sub loadDataDisplay2()
        Try

            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.MonthE = '" & DateTimePicker3.Value.Month.ToString & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            expireddg.Rows.Clear()
            While reader.Read()
                i = i + 1
                With expireddg
                    .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DateE")).ToShortDateString(), reader("QuantitySO"))
                End With
            End While
            reader.Close()
            expireddg.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In expireddg.Rows

                d = d + r.Cells(9).Value
                txt1.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Sub loadDataDisplay3()
        Try

            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.YearE = '" & DateTimePicker3.Value.Year.ToString & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            expireddg.Rows.Clear()
            While reader.Read()
                i = i + 1
                With expireddg
                    .Rows.Add(reader(0), i, reader.GetString("MedicineName"), reader.GetString("MedicineCode"), reader.GetString("MEdicineUnit") + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), Date.Parse(reader("DateE")).ToShortDateString(), reader("QuantitySO"))
                End With
            End While
            reader.Close()
            expireddg.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In expireddg.Rows

                d = d + r.Cells(9).Value
                txt1.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExpiryDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub



    Private Sub txtsearch_TextChanged_2(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchstock(txtsearch.Text)
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "DAY" Then

            loadDataDisplay1()

        ElseIf ComboBox1.SelectedItem = "MONTH" Then
            DateTimePicker3.Format = DateTimePickerFormat.Custom
            DateTimePicker3.CustomFormat = "MMMM"
            DateTimePicker3.ShowUpDown = True
            loadDataDisplay2()
        ElseIf ComboBox1.SelectedItem = "YEAR" Then
            DateTimePicker3.Format = DateTimePickerFormat.Custom
            DateTimePicker3.CustomFormat = "yyyy"
            DateTimePicker3.ShowUpDown = True
            loadDataDisplay3()
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        If ComboBox1.SelectedItem = "DAY" Then

            loadDataDisplay1()

        ElseIf ComboBox1.SelectedItem = "MONTH" Then
            loadDataDisplay2()
        ElseIf ComboBox1.SelectedItem = "YEAR" Then
            loadDataDisplay3()
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim frm As New Expiry
            Dim rpt As New NearExpiration
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Company")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Expiration")
                .Columns.Add("Quantity")
                .Columns.Add("Date")
            End With

            For Each r As DataGridViewRow In ExpiryDG.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(6).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value, r.Cells(9).Value, txtremaining.Text)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()
        Catch
        End Try

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try
            Dim frm As New frmExpired
            Dim rpt As New Expired
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Expiration")
                .Columns.Add("Quantity")
                .Columns.Add("Company")
                .Columns.Add("Date")
            End With

            For Each r As DataGridViewRow In expireddg.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value, r.Cells(9).Value, txt1.Text, DateTimePicker3.Value)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        If ComboBox1.SelectedItem = "DAY" Then

            searchstock1(GunaTextBox1.Text, Format(CDate(DateTimePicker3.Value).Date, "yyyy-M-d"))

        ElseIf ComboBox1.SelectedItem = "MONTH" Then
            searchstock2(GunaTextBox1.Text, DateTimePicker3.Value.Month.ToString)
        ElseIf ComboBox1.SelectedItem = "YEAR" Then
            searchstock3(GunaTextBox1.Text, DateTimePicker3.Value.Year.ToString)
        End If
    End Sub

    Private Sub expireddg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles expireddg.CellContentClick

    End Sub

    Private Sub expireddg_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles expireddg.CellPainting
        Try
            'If there is no search string, no rows, or nothing in this cell, then get out. 
            If GunaTextBox1.Text = String.Empty And GunaTextBox1.Text = "" Then Return
            If (e.Value Is Nothing) Then Return
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

            e.Handled = True
            e.PaintBackground(e.CellBounds, True)

            'Get the value of the text in the cell, and the search term. Work with everything in lowercase for more accurate highlighting
            Dim str_SearchTerm As String = GunaTextBox1.Text.Trim.ToLower
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

    Private Sub ExpiryDG_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles ExpiryDG.CellContentClick

    End Sub

    Private Sub ExpiryDG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles ExpiryDG.CellPainting
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
End Class