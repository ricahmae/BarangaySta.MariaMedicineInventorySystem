Public Class DMenu
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
    Dim d As Date = d.ToString
    Private Sub DMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvStocks.ForeColor = Color.Black
        Dim asa As Date = HealthCenterMain.dtServer.Date()
        txtmonth.Text = HealthCenterMain.dtServer.Month.ToString
        txtyear.Text = HealthCenterMain.dtServer.Year.ToString
        Dim batch As Integer = 0
        Dim quantity As Integer = 0
        Dim q As Integer = Stockin.sum
        Dim totalquantity As Integer = 0
        Dim newd As Integer = 0
        Dim expiryq As Integer

        Try


            For i = 0 To ExpiryDG.RowCount - 1

                Dim itemid = (ExpiryDG.Rows(i).Cells(0).Value)
                Dim itemname = (ExpiryDG.Rows(i).Cells(2).Value)
                Dim date1 = (ExpiryDG.Rows(i).Cells(3).Value)
                Dim iqty = (ExpiryDG.Rows(i).Cells(4).Value)

                Dim AN As Integer = DateTime.Compare(date1, asa)

                If AN = 0 Then
                    MsgBox(itemname + " is expired ")
                    dbConnect()
                    Dim query = "INSERT INTO stockout SET MedicineID='" & itemid & "', " _
                            & " DOS = '" & asa & "', StockoutBy = 'System', " _
                            & " QuantitySO = '" & iqty & "',ReceiversName = 'None', Reason= 'Expired',DateE='" & asa & "',MonthE='" & txtmonth.Text & "',YearE='" & txtyear.Text & "',Month='" & txtmonth.Text & "',Year='" & txtyear.Text & "' "
                    ExecuteQuery(query)

                    dbDisconnect()

                    dbConnect()
                    Dim query2 = "SELECT Quantity from profilemedicine WHERE MedicineID='" & itemid & "' "
                    ExecuteQuery(query2)
                    While reader.Read()
                        totalquantity = reader.GetString("Quantity")

                    End While
                    reader.Close()
                    dbDisconnect()

                    Dim grandtotal As Integer = totalquantity - iqty
                    dbConnect()
                    Dim query3 = "UPDATE profilemedicine SET Quantity='" & grandtotal & "' WHERE MedicineID='" & itemid & "' "
                    ExecuteQuery(query3)
                    dbDisconnect()

                    dbConnect()


                    Dim query10 = "SELECT * FROM stockoutdesc WHERE MedicineID='" & itemid & "' AND DOSO='" & asa & "'"
                    ExecuteQuery(query10)
                    If (reader.Read = True) Then

                        expiryq = reader.GetString("TotalSO")
                        dbDisconnect()
                        dbConnect()
                        Dim query11 = "UPDATE stockoutdesc set TotalSO='" & iqty + expiryq & "'"
                        ExecuteQuery(query11)
                        dbDisconnect()
                    Else
                        dbConnect()
                        Dim query11 = "INSERT INTO stockoutdesc SET MedicineID='" & itemid & "',DOSO='" & asa & "',TotalSO='" & iqty & "'"
                        ExecuteQuery(query11)
                        dbDisconnect()
                    End If
                    dbDisconnect()
                    dbConnect()

                    Dim query9 = "SELECT * FROM expiry WHERE MedicineID='" & itemid & "' AND DOE='" & date1 & "'"
                    ExecuteQuery(query9)
                    If (reader.Read = True) Then

                        expiryq = reader.GetString("QuantityE")
                        reader.Close()
                        dbDisconnect()


                        dbConnect()
                        Dim query12 = "UPDATE expiry set QuantityE='" & expiryq - iqty & "', GrandTotal='" & expiryq - iqty & "',NotificationE='NotRead' WHERE MedicineID='" & itemid & "' AND DOE='" & date1 & "'"
                        ExecuteQuery(query12)
                        dbDisconnect()


                    End If
                    dbDisconnect()

                End If


            Next


        Catch ex As Exception

        Finally


        End Try
    End Sub

    Private Sub Dashboard_Paint(sender As Object, e As PaintEventArgs) Handles Dashboard.Paint

    End Sub

    Private Sub gvStocks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStocks.CellContentClick

        If e.ColumnIndex = 5 Then
            Dim id As Integer
            id = (gvStocks.SelectedRows(0).Cells(0).Value)

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
                QTA = reader("QuantityToAlert")
                max = reader("Max")
                alert = reader("AlertNo")

            End While
            reader.Close()

            dbDisconnect()
            Addstockdashboard.Show()


        ElseIf e.ColumnIndex = 6 Then

            Dim id As Integer
                id = (gvStocks.SelectedRows(0).Cells(0).Value)

                Dim sql As String
                Dim i As Integer = 0
                dbConnect()
                sql = "UPDATE profilemedicine SET Notification = 'READ' WHERE MedicineID = " & id & " LIMIT 1"
                ExecuteQuery(sql)
                MessageBox.Show("Notification Read!.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.None)


                dbDisconnect()


            End If
            disposeConnection()

    End Sub

    Private Sub UserDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ExpiryDG.CellContentClick
        Try
            If e.ColumnIndex = 5 Then

                Dim id As Integer
                id = (ExpiryDG.SelectedRows(0).Cells(0).Value)

                Dim sql As String
                Dim i As Integer = 0
                dbConnect()
                sql = "UPDATE expiry SET NotificationE = 'READ' WHERE MedicineID = " & id & " LIMIT 1"
                ExecuteQuery(sql)
                MessageBox.Show("Notification Read!.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)


                dbDisconnect()


            End If
        Catch
        End Try
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Stockin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DailyReleased.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DailyStockin.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class