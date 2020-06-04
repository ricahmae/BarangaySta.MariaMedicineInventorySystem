Public Class ViewBrand
    Public brandid As Integer
    Public brandname As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel2.Paint

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub UserDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewBrandDG.CellContentClick
        If e.ColumnIndex = 3 Then


            Dim id As Integer
            id = (ViewBrandDG.SelectedRows(0).Cells(0).Value)

            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM brand WHERE BrandID = " & id & " LIMIT 1"
            ExecuteQuery(sql)


            While reader.Read()
                brandid = reader(0)
                brandname = reader(1)
            End While
            reader.Close()

            dbDisconnect()
            EditBrand.Show()
        End If

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        AddBrand.Show()
    End Sub

    Private Sub GunaShadowPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel4.Paint

    End Sub
    Sub ViewData()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM brand ORDER BY BrandName"
            ExecuteQuery(sql)

            ViewBrandDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With ViewBrandDG
                    .Rows.Add(reader(0), i, reader(1), ("Edit"))
                End With
            End While
            reader.Close()
            ViewBrandDG.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ViewBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewData()
    End Sub

    Private Sub ViewBrandDG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles ViewBrandDG.CellPainting

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

    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchstock(txtsearch.Text)
    End Sub

    Private Sub GunaLabel9_Click(sender As Object, e As EventArgs) Handles GunaLabel9.Click

    End Sub
    Public Sub searchstock(tb As String)
        Try
            Dim query As String
            ViewBrandDG.Rows.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM brand WHERE " _
                                  & " BrandName Like '" & tb & "%'
                                   ORDER BY BrandName"

            ExecuteQuery(query)
            While reader.Read()
                i = i + 1
                With ViewBrandDG
                    .Rows.Add(reader(0), i, reader(1), ("Edit"))
                End With
            End While
            reader.Close()
            ViewBrandDG.ClearSelection()

            dbDisconnect()
        Catch

        End Try
    End Sub
End Class