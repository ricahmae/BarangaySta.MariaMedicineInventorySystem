Imports MySql.Data.MySqlClient
Public Class ViewStocks
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub
    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT  COALESCE(SUM(QuantityS),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName From profilemedicine,stockin WHERE stockin.MedicineID=profilemedicine.MedicineID  GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            ViewStock.Rows.Clear()
            While reader.Read()
                i = i + 1
                With ViewStock
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader("stockouttotal"))
                End With
            End While
            reader.Close()
            ViewStock.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In ViewStock.Rows

                d = d + r.Cells(8).Value
                txtremaining.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub ViewStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
        displaydate(dtpFrom.Value)
        displaydate3(DTSO.Value)
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "yyyy-M-d"
        dtpFrom.MaxDate = HealthCenterMain.dtServer
        DTSO.Format = DateTimePickerFormat.Custom
        DTSO.CustomFormat = "yyyy-M-d"
        DTSO.MaxDate = HealthCenterMain.dtServer

    End Sub
    Public Sub searchstock(tb As String)
        Try
            Dim query As String
            ViewStock.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' OR Quantity LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' GROUP BY MedicineCode DESC"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With ViewStock
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader(13))
                End With
            End While
            reader.Close()
            ViewStock.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub
    Private Sub txtsearchstockout_TextChanged(sender As Object, e As EventArgs)
        searchstock(txtsearchstockout.Text)
    End Sub

    Private Sub ViewStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New IR
            Dim rpt As New CrystalReport3
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("MName")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Quantity")

            End With

            For Each r As DataGridViewRow In ViewStock.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub
    '    Sub printReceipt()
    '        Try
    '            dbConnect()
    '            Dim query As String
    '            Dim cmd As MySqlCommand
    '            Dim adp As New MySqlDataAdapter
    '            Dim dt As New DataSet

    '            query = "SELECT transactions.transac_ID, transac_Date, transac_Cash, transac_Change, cust_name, transac_Subtotal, transac_Discount," _
    '& " transac_DiscPerc, transac_DiscPeso, transac_netPrice, (SELECT user_Name FROM user WHERE user.user_ID = transactions.user_ID) AS user_ID," _
    '& " tp_ID, tp_Name, tp_Desc, tp_Qty,tp_Price,tp_Subtotal" _
    '& " FROM transactions,transactions_products" _
    '& " WHERE transactions.transac_ID = transactions_products.transac_ID AND transactions.transac_ID = '" & transacid & "'"
    '            cmd = New MySqlCommand(query, conn)
    '            adp.SelectCommand = cmd
    '            adp.Fill(dt, "Receipt")

    '            Dim report As New ViewStocksCR
    '            report.SetDataSource(dt)
    '            ViewStocksReport.CrystalReportViewer1.ReportSource = report
    '            frmReport.CrystalReportViewer1.Refresh()
    '            cmd.Dispose()
    '            adp.Dispose()
    '            dt.Dispose()
    '            conn.Close()

    '            ' report.PrintToPrinter(1, False, 0, 0)
    '            frmReport.ShowDialog()

    '        Catch ex As Exception
    '            MsgBox("An Error occured: ", ex.Message)
    '        Finally
    '            disposeConnection()

    '        End Try
    'End Sub
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    'Public Sub searchdate(tb As Date)
    '    Try
    '        Dim query As String
    '        GunaDataGridView1.Rows.Clear()
    '        dbConnect()
    '        Dim i As Integer = 0
    '        query = "SELECT * from profilemedicine INNER JOIN " _
    '                            & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
    '                            & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
    '                             & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID INNER JOIN stockin ON stockin.MedicineID= profilemedicine.MedicineID" _
    '                             & "WHERE DATE(DOS) >= '2019-12-3' GROUP BY DOS DESC"

    '        ExecuteQuery(query)
    '        While reader.Read()
    '            i = i + 1
    '            With GunaDataGridView1
    '                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader(12))

    '            End With
    '        End While

    '        reader.Close()
    '        GunaDataGridView1.ClearSelection()

    '        dbDisconnect()
    '    Catch

    '    End Try
    'End Sub
    Public Sub displaydate(TB As Date)
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT  COALESCE(SUM(QuantityS),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName From profilemedicine,stockin WHERE stockin.MedicineID=profilemedicine.MedicineID AND DOS = '" & TB.ToString("yyyy-M-d") & "'  GROUP BY MedicineCode DESC "
            ExecuteQuery(sql)

            fygv.Rows.Clear()
            While reader.Read()
                i = i + 1
                With fygv

                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))


                End With
            End While
            reader.Close()
            fygv.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In fygv.Rows

                d = d + r.Cells(8).Value
                txtstockintotal.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub displaydateso(TB As Date)
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID INNER JOIN stockoutdesc ON stockoutdesc.MedicineID=profilemedicine.MedicineID WHERE DOSO = '" & TB.ToString("yyyy-M-d") & "'  GROUP BY MedicineCode DESC "
            ExecuteQuery(sql)

            fygv.Rows.Clear()
            While reader.Read()
                i = i + 1
                With fygv

                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("TotalSO"))


                End With
            End While
            reader.Close()
            fygv.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In fygv.Rows

                d = d + r.Cells(8).Value
                txtstockintotal.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub searchso(t As String, TB As Date)

        Dim sql As String
        Dim i As Integer = 0
        dbConnect()
        sql = "SELECT *,(SELECT  COALESCE(SUM(QuantityS),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName From profilemedicine,stockin WHERE stockin.MedicineID=profilemedicine.MedicineID AND DOS = '" & TB.ToString("yyyy-M-d") & "' AND MedicineName Like '" & t & "%' GROUP BY MedicineCode DESC "
        ExecuteQuery(sql)

        fygv.Rows.Clear()
        While reader.Read()
            i = i + 1
            With fygv

                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))


            End With
        End While
        reader.Close()
        fygv.ClearSelection()
        Dim d As Decimal = 0
        For Each r As DataGridViewRow In fygv.Rows

            d = d + r.Cells(8).Value
            txtstockintotal.Text = d.ToString
        Next
        dbDisconnect()


    End Sub
    Public Sub searchso1(t As String, TB As Date)

        Dim sql As String
        Dim i As Integer = 0
        dbConnect()
        sql = "SELECT * FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID INNER JOIN stockoutdesc ON stockoutdesc.MedicineID=profilemedicine.MedicineID WHERE DOSO = '" & TB.ToString("yyyy-M-d") & "' AND MedicineName Like '" & t & "%'  GROUP BY DOSO DESC "
        ExecuteQuery(sql)

        fygv.Rows.Clear()
        While reader.Read()
            i = i + 1
            With fygv

                .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("TotalSO"))


            End With
        End While
        reader.Close()
        fygv.ClearSelection()
        Dim d As Decimal = 0
        For Each r As DataGridViewRow In fygv.Rows

            d = d + r.Cells(8).Value
            txtstockintotal.Text = d.ToString
        Next
        dbDisconnect()


    End Sub
    Public Sub displaydate3(TB As Date)
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT  COALESCE(SUM(QuantitySO),0)) as stockouttotal, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,
                    (SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName From profilemedicine,stockout WHERE stockout.MedicineID=profilemedicine.MedicineID AND stockout.QuantitySO <> 0 AND stockout.DOS = '" & TB.ToString("yyyy-M-d") & "'  GROUP BY MedicineCode DESC"
            ExecuteQuery(sql)

            SOGV.Rows.Clear()
            While reader.Read()
                i = i + 1
                With SOGV

                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader.GetString("stockouttotal"))


                End With
            End While
            reader.Close()
            SOGV.ClearSelection()
            Dim d As Decimal = 0
            For Each r As DataGridViewRow In SOGV.Rows

                d = d + r.Cells(8).Value
                TOTALSTOCKOUT.Text = d.ToString
            Next
            dbDisconnect()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub displaydate2()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine GROUP BY MedicineID DESC"
            ExecuteQuery(sql)

            fygv.Rows.Clear()
            While reader.Read()
                i = i + 1
                With fygv
                    .Rows.Add(reader(0), i, reader(2), reader(1), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader(13))
                End With
            End While
            reader.Close()
            fygv.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpFrom_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        displaydate(dtpFrom.Value)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTSO.ValueChanged
        displaydate3(DTSO.Value)
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub GunaButton1_Click_1(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim frm As New IR
            Dim rpt As New CrystalReport3
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("MName")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Quantity")
                .Columns.Add("Company")
            End With

            For Each r As DataGridViewRow In ViewStock.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value, txtremaining.Text)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Try
            Dim frm As New frmtotalstockin
            Dim rpt As New TotalStockin
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("MName")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Total Stock-in")

            End With

            For Each r As DataGridViewRow In fygv.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value)
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
            Dim frm As New frmtotalstockout
            Dim rpt As New TotalStockout
            Dim dt As New DataTable

            With dt
                .Columns.Add("Code")
                .Columns.Add("MName")
                .Columns.Add("Brand")
                .Columns.Add("Type")
                .Columns.Add("Unit")
                .Columns.Add("Total Stock-out")

            End With

            For Each r As DataGridViewRow In SOGV.Rows
                dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value)
            Next
            rpt.SetDataSource(dt)
            frm.CrystalReportViewer1.ReportSource = rpt

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub txtsearchstockout_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearchstockout.TextChanged
        searchstock(txtsearchstockout.Text)
    End Sub

    Private Sub GunaTextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        searchso(GunaTextBox1.Text, dtpFrom.Value)
    End Sub

    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox2.TextChanged
        searchso1(GunaTextBox2.Text, DTSO.Value)
    End Sub

    Private Sub ViewStock_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles ViewStock.CellContentClick

    End Sub

    Private Sub ViewStock_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles ViewStock.CellPainting
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

    Private Sub fygv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles fygv.CellContentClick

    End Sub

    Private Sub fygv_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles fygv.CellPainting
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

    Private Sub SOGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SOGV.CellContentClick

    End Sub

    Private Sub SOGV_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles SOGV.CellPainting
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
End Class