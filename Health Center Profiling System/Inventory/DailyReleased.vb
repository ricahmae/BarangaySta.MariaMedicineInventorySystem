Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class DailyReleased
    Private Sub DailyReleased_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
        loaddatadisplay2()
        loaddatadisplay3()
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MMMM"
        DateTimePicker2.ShowUpDown = True
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "yyyy"
        DateTimePicker3.ShowUpDown = True
    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub
    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT  COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName From profilemedicine,stockout WHERE stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.DOS = '" & Format(CDate(DateTimePicker1.Value).Date, "yyyy-M-d") & "'  GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            DailyDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With DailyDG



                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
                End With
            End While
            reader.Close()
            DailyDG.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In DailyDG.Rows

                d = d + r.Cells(8).Value
                txtremaining.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT  COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName From profilemedicine,stockout WHERE stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.DOS = '" & Format(CDate(DateTimePicker1.Value).Date, "yyyy-M-d") & "'  GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            DailyDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With DailyDG



                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
                End With
            End While
            reader.Close()
            DailyDG.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In DailyDG.Rows

                d = d + r.Cells(8).Value
                txtremaining.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Sub loaddatadisplay2()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.Month = '" & DateTimePicker2.Value.Month.ToString & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            monthgv.Rows.Clear()
            While reader.Read()
                i = i + 1



                With monthgv
                    'Dim AN As Integer = String.Compare(DATE1, asa)

                    'If AN = 0 Then


                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
                    'End If
                End With


            End While
            reader.Close()
            monthgv.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In monthgv.Rows

                d = d + r.Cells(8).Value
                txtmonth.Text = d.ToString
            Next
            dbDisconnect()
        Catch
        End Try

    End Sub
    Sub loaddatadisplay3()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.Year = '" & DateTimePicker3.Value.Year.ToString & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            yearGV.Rows.Clear()
            While reader.Read()
                i = i + 1



                With yearGV
                    'Dim AN As Integer = String.Compare(DATE1, asa)

                    'If AN = 0 Then


                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
                    'End If
                End With


            End While
            reader.Close()
            yearGV.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In yearGV.Rows

                d = d + r.Cells(8).Value
                txtyear.Text = d.ToString
            Next
            dbDisconnect()
        Catch
        End Try

    End Sub
    Private Sub txtsearchstockout_TextChanged(sender As Object, e As EventArgs) Handles txtsearchstockout.TextChanged
        searchstock(txtsearchstockout.Text, Format(CDate(DateTimePicker1.Value).Date, "yyyy-M-d"))
    End Sub
    Sub searchstock(tb As String, D2 As Date)

        Dim query As String
        DailyDG.Rows.Clear()
        dbConnect()
        Dim i As Integer = 0
        query =
                "SELECT *,(SELECT  COALESCE(SUM(QuantitySO),0)) as stockouttotal FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " WHERE DOS = '" & D2 & "' AND QuantitySO <> 0 And (MedicineName Like '" & tb & "%') GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
        While reader.Read()
            i = i + 1
            With DailyDG
                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
            End With
        End While
        reader.Close()
        DailyDG.ClearSelection()

        dbDisconnect()

    End Sub

    Sub searchstock3(tb As String, D2 As String)

        Dim query As String
        yearGV.Rows.Clear()
        dbConnect()
        Dim i As Integer = 0
        query =
                "SELECT *,(SELECT  COALESCE(SUM(QuantitySO),0)) as stockouttotal FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " WHERE Year = '" & D2 & "' AND QuantitySO <> 0 And (MedicineName Like '" & tb & "%') GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
        While reader.Read()
            i = i + 1
            With yearGV
                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
            End With
        End While
        reader.Close()
        yearGV.ClearSelection()

        dbDisconnect()

    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.Month = '" & DateTimePicker2.Value.Month.ToString & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            monthgv.Rows.Clear()
            While reader.Read()
                i = i + 1



                With monthgv
                    'Dim AN As Integer = String.Compare(DATE1, asa)

                    'If AN = 0 Then


                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
                    'End If
                End With


            End While
            reader.Close()
            monthgv.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In monthgv.Rows

                d = d + r.Cells(8).Value
                txtmonth.Text = d.ToString
            Next
            dbDisconnect()
        Catch
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName 
                    From profilemedicine,stockout where stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.Year = '" & DateTimePicker3.Value.Year.ToString & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            yearGV.Rows.Clear()
            While reader.Read()
                i = i + 1



                With yearGV
                    'Dim AN As Integer = String.Compare(DATE1, asa)

                    'If AN = 0 Then


                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
                    'End If
                End With


            End While
            reader.Close()
            yearGV.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In yearGV.Rows

                d = d + r.Cells(8).Value
                txtyear.Text = d.ToString
            Next
            dbDisconnect()
        Catch
        End Try
    End Sub

    Private Sub yearGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yearGV.CellContentClick

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Dim frm As New frmDailyReleased
            Dim rpt As New Released
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Total Released")
            .Columns.Add("Date")
            .Columns.Add("Company")
        End With

            For Each r As DataGridViewRow In DailyDG.Rows
            dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value, Format(CDate(DateTimePicker1.Value).Date, "yyyy-MMMM-dd"), txtremaining.Text)
        Next
        rpt.SetDataSource(dt)

        frm.CrystalReportViewer1.ReportSource = rpt

        frm.ShowDialog()



    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try
            Dim frm As New frmDailyReleased
            Dim rpt As New Released
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Total Released")
                .Columns.Add("Date")
                .Columns.Add("Company")
            End With

            For Each r As DataGridViewRow In monthgv.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value, DateTimePicker2.Value.Month.ToString, txtmonth.Text)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Try
            Dim frm As New frmDailyReleased
            Dim rpt As New Released
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("Name")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Total Released")
                .Columns.Add("Date")
                .Columns.Add("Company")
            End With

            For Each r As DataGridViewRow In yearGV.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value, DateTimePicker3.Value.Year.ToString, txtyear.Text)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub
    Sub searchstock4(tb As String, D2 As String)

        Dim query As String
        monthgv.Rows.Clear()
        dbConnect()
        Dim i As Integer = 0
        query =
                "SELECT *,(SELECT  COALESCE(SUM(QuantitySO),0)) as stockouttotal FROM profilemedicine INNER JOIN stockout ON stockout.MedicineID= profilemedicine.MedicineID INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " WHERE Month = '" & D2 & "' AND QuantitySO <> 0 And (MedicineName Like '" & tb & "%') GROUP BY MedicineCode DESC"

        ExecuteQuery(query)
        While reader.Read()
            i = i + 1
            With monthgv
                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))
            End With
        End While
        reader.Close()
        monthgv.ClearSelection()

        dbDisconnect()

    End Sub


    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox2.TextChanged
        searchstock3(GunaTextBox2.Text, DateTimePicker3.Value.Year.ToString)
    End Sub

    Private Sub txtm_TextChanged(sender As Object, e As EventArgs) Handles txtm.TextChanged
        searchstock4(txtm.Text, DateTimePicker2.Value.Month.ToString)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DailyDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DailyDG.CellContentClick

    End Sub

    Private Sub DailyDG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DailyDG.CellPainting
        Try
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
        Catch
        End Try
    End Sub

    Private Sub yearGV_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles yearGV.CellPainting
        Try
            'If there is no search string, no rows, or nothing in this cell, then get out. 
            If GunaTextBox2.Text = String.Empty And GunaTextBox2.Text = "" Then Return
            If (e.Value Is Nothing) Then Return
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

            e.Handled = True
            e.PaintBackground(e.CellBounds, True)

            'Get the value of the text in the cell, and the search term. Work with everything in lowercase for more accurate highlighting
            Dim str_SearchTerm As String = GunaTextBox2.Text.Trim.ToLower
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

    Private Sub monthgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles monthgv.CellContentClick

    End Sub

    Private Sub monthgv_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles monthgv.CellPainting
        Try
            'If there is no search string, no rows, or nothing in this cell, then get out. 
            If txtm.Text = String.Empty And txtm.Text = "" Then Return
            If (e.Value Is Nothing) Then Return
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

            e.Handled = True
            e.PaintBackground(e.CellBounds, True)

            'Get the value of the text in the cell, and the search term. Work with everything in lowercase for more accurate highlighting
            Dim str_SearchTerm As String = txtm.Text.Trim.ToLower
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