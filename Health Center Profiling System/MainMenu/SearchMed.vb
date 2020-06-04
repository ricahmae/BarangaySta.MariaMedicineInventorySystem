Public Class SearchMed

    Public searchflag = False
    Public medid As Integer
    Public medcode As String
    Public medname As String
    Public medunit As String
    Public medunit2 As String
    Public medcompany As String
    Public medtype As String
    Public medbrand As String
    Public lotnumber As String
    Public description As String
    Public QTA As Integer
    Public max As Integer
    Public alert As String
    Public desc As String
    Public quantity As Integer
    Public Sub LoadProducts()
        Try
            Dim query As String
            profilelv.Items.Clear()
            query = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE Quantity != 0 GROUP BY MedicineID"
            dbConnect()
            ExecuteQuery(query)
            Dim i As Integer
            If reader.HasRows Then
                While reader.Read

                    profilelv.Items.Add(i + 1)
                    profilelv.Items(i).SubItems.Add(reader.GetString("MedicineCode"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("MedicineName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("BrandName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("TypeName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("UnitName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("CompanyName"))

                    i += 1
                End While
            End If
            dbDisconnect()
            If searchflag = True Then
                For x = profilelv.Items.Count - 1 To 0 Step -1
                    dbConnect()
                    query = "SELECT * FROM profilemedicine WHERE MedicineCode='" & profilelv.Items.Item(x).SubItems(1).Text & "'"
                    ExecuteQuery(query)
                    If Not reader.HasRows Then
                        profilelv.Items.RemoveAt(x)
                    End If
                    dbDisconnect()
                Next
                For x = 0 To profilelv.Items.Count - 1
                    profilelv.Items.Item(x).SubItems(0).Text = Val(x + 1)
                Next
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error on populating products listview: '" & ex.Message & "'", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.[Error])
        End Try

    End Sub
    Private Sub SearchMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub
    Dim selectedmed As New List(Of String)

    'Sub loadDataDisplay()
    '    Try
    '        Dim sql As String
    '        Dim i As Integer = 0
    '        dbConnect()
    '        sql = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE Quantity > 0 GROUP BY MedicineID DESC"
    '        ExecuteQuery(sql)

    '        ViewStock.Rows.Clear()
    '        While reader.Read()
    '            i = i + 1
    '            With ViewStock
    '                .Rows.Add(reader(0), i, reader(1), reader(2), reader(3) + " " + reader("UnitName"), reader("BrandName"), reader("CompanyName"), reader("TypeName"), reader(12))
    '            End With
    '        End While
    '        reader.Close()
    '        ViewStock.ClearSelection()

    '        dbDisconnect()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            searchflag = False
            If profilelv.SelectedIndices.Count > 0 Then
                Issuance.search1 = profilelv.Items(profilelv.SelectedIndices(0)).SubItems(1).Text
                profilelv.SelectedIndices.Clear()
                Me.Close()

            End If
        Catch
        End Try
    End Sub

    Private Sub ViewStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub txtsearchstockout_TextChanged(sender As Object, e As EventArgs) Handles txtsearchstockout.TextChanged
        searchstock(txtsearchstockout.Text)
    End Sub
    Public Sub searchstock(tb As String)
        Try
            Dim query As String

            profilelv.Items.Clear()
            dbConnect()
            Dim i As Integer = 0
            query = "SELECT * FROM profilemedicine INNER JOIN " _
                                & " brand ON brand.BrandID = profilemedicine.BrandID INNER JOIN company ON " _
                                & " company.CompanyID = profilemedicine.CompanyID INNER JOIN type ON " _
                                 & " type.TypeID=profilemedicine.TypeID INNER JOIN unit ON unit.UnitID=profilemedicine.UnitID" _
                                  & " And MedicineName Like '" & tb & "%' OR BrandName LIKE '" & tb & "%' " _
                                   & " OR MedicineCode Like '" & tb & "%' OR UnitName LIKE '" & tb & "%' " _
                                    & " OR MEdicineUnit Like '" & tb & "%' OR TypeName LIKE '" & tb & "%' " _
                                  & "OR CompanyName LIKE '" & tb & "%' WHERE Quantity != 0 GROUP BY MedicineID"

            dbConnect()
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    profilelv.Items.Add(i + 1)
                    profilelv.Items(i).SubItems.Add(reader.GetString("MedicineCode"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("MedicineName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("BrandName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("TypeName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("UnitName"))
                    profilelv.Items(i).SubItems.Add(reader.GetString("CompanyName"))
                    i += 1
                End While
            End If
            dbDisconnect()
        Catch

        End Try
    End Sub

    Private Sub profilelv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles profilelv.SelectedIndexChanged

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Me.Close()
    End Sub
End Class