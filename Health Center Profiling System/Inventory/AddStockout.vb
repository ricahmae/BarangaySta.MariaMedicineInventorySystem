Public Class AddStockout
    Dim d As Date = d.ToString
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub AddStockout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtid.Text = Stockin.medid


        dbConnect()
        Try
            Dim sql As String = "SELECT min(date(DOE)) as date from expiry WHERE MedicineID ='" & txtid.Text & "' AND QuantityE > 0"
            ExecuteQuery(sql)
            While reader.Read
                d = Date.Parse(reader("date")).ToShortDateString
            End While
            dbDisconnect()
            txtcode.Text = Stockin.medcode
            txtname.Text = Stockin.medname
            txtunit.Text = Stockin.medunit + " " + Stockin.medunit2
            txtbrand.Text = Stockin.medbrand
            txtcompany.Text = Stockin.medcompany
            txttype.Text = Stockin.medtype
            txtdescription.Text = Stockin.description
            txtdos.Text = HealthCenterMain.dtServer.ToShortDateString()
            txtstockoutby.Text = FormLogin.user
            txtcurrent.Text = Stockin.sum
            txtquantity.Maximum = txtcurrent.Text - txtquantity.Value
            txtmonth.Text = HealthCenterMain.dtServer.Month.ToString
            txtyear.Text = HealthCenterMain.dtServer.Year.ToString
            txtex.Text = d
            loadexpiry()
        Catch
        End Try
    End Sub

    Private Sub GunaGroupBox10_Click(sender As Object, e As EventArgs) Handles GunaGroupBox10.Click

    End Sub
    Sub loadexpiry()

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            If txtquantity.Value <= 0 Then
                MessageBox.Show("Invalid Stock-Out Quantity.", "Message",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                save()
                Me.Close()

            End If
        Catch
        End Try
    End Sub
    Sub save()
        Dim batch As Integer = 0
        Dim medicineid As Integer = txtid.Text
        Dim dos As String = txtdos.Text
        Dim sob As String = txtstockoutby.Text
        Dim quantity As Integer = 0
        Dim q As Integer = Stockin.sum
        Dim remaining As Integer = q - txtquantity.Value
        quantity = txtquantity.Value
        Dim receiver As String = txtreceiver.Text
        Dim totalquantity As Integer = 0
        Dim newd As Integer
        Try

            dbConnect()


            Dim query = "INSERT INTO stockout SET MedicineID='" & medicineid & "', " _
                        & " DOS = '" & dos & "', StockoutBy = '" & sob & "', " _
                        & " QuantitySO = '" & quantity & "',ReceiversName = '" & receiver & "',Remaining='" & remaining & "',Reason='" & txtreceiver.Text & "',Month='" & txtmonth.Text & "',Year='" & txtyear.Text & "'"
            ExecuteQuery(query)
            MsgBox("Stock-out Successful !", vbInformation, "Saved")
            dbDisconnect()
            dbConnect()
            Dim query2 = "SELECT Quantity from profilemedicine WHERE MedicineID='" & medicineid & "' "
            ExecuteQuery(query2)
            While reader.Read()
                totalquantity = reader.GetString("Quantity")

            End While
            reader.Close()
            dbDisconnect()
            Dim grandtotal As Integer = totalquantity - txtquantity.Value
            dbConnect()
            Dim query3 = "UPDATE profilemedicine SET Quantity='" & grandtotal & "' WHERE MedicineID='" & medicineid & "' "
            ExecuteQuery(query3)
            dbDisconnect()

            dbConnect()
            Dim expiryq As Integer

            Dim query9 = "SELECT * FROM expiry WHERE MedicineID='" & txtid.Text & "' AND DOE='" & txtex.Text & "'"
            ExecuteQuery(query9)
            If (reader.Read = True) Then

                expiryq = reader.GetString("QuantityE")
                reader.Close()
                dbDisconnect()
                If (expiryq - quantity) < 0 Then
                    dbConnect()
                    Dim query12 = "UPDATE expiry set QuantityE='0', GrandTotal='0',NotificationE='NotRead' WHERE MedicineID='" & txtid.Text & "' AND DOE='" & txtex.Text & "'"
                    ExecuteQuery(query12)
                    dbDisconnect()
                    dbConnect()
                    Dim ans = quantity - expiryq
                    Dim sql As String = "SELECT * from expiry WHERE MedicineID ='" & txtid.Text & "' AND DOE > '" & txtex.Text & "'"
                    ExecuteQuery(sql)
                    While reader.Read
                        d = reader.GetString("DOE")
                    End While

                    dbDisconnect()
                    dbConnect()
                    Dim query19 = "SELECT * FROM expiry WHERE MedicineID='" & txtid.Text & "' AND DOE='" & d & "'"
                    ExecuteQuery(query19)
                    If (reader.Read = True) Then

                        newd = reader.GetString("QuantityE")
                    End If
                    dbDisconnect()

                    dbConnect()
                    Dim query18 = "UPDATE expiry set QuantityE='" & newd - ans & "', GrandTotal='" & newd - ans & "',NotificationE='NotRead' WHERE MedicineID='" & txtid.Text & "' AND DOE='" & d & "'"
                    ExecuteQuery(query18)
                    dbDisconnect()
                    dbConnect()

                Else
                    dbConnect()
                    Dim query12 = "UPDATE expiry set QuantityE='" & expiryq - quantity & "', GrandTotal='" & expiryq - quantity & "',NotificationE='NotRead' WHERE MedicineID='" & txtid.Text & "' AND DOE='" & txtex.Text & "'"
                    ExecuteQuery(query12)
                    dbDisconnect()
                End If

            End If
                dbDisconnect()

            dbConnect()


            Dim query10 = "SELECT * FROM stockoutdesc WHERE MedicineID='" & txtid.Text & "' AND DOSO='" & txtdos.Text & "'"
            ExecuteQuery(query10)
            If (reader.Read = True) Then

                expiryq = reader.GetString("TotalSO")
                dbDisconnect()
                dbConnect()
                Dim query11 = "UPDATE stockoutdesc set TotalSO='" & quantity + expiryq & "'"
                ExecuteQuery(query11)
                dbDisconnect()
            Else
                dbConnect()
                Dim query11 = "INSERT INTO stockoutdesc SET MedicineID='" & medicineid & "',DOSO='" & txtdos.Text & "',TotalSO='" & quantity & "'"
                ExecuteQuery(query11)
                dbDisconnect()
            End If
            dbDisconnect()

            dbConnect()
            Dim sql3 As String = "SELECT * FROM stockin WHERE MedicineID = " & medicineid & " AND BatchID = 1 LIMIT 1"
            ExecuteQuery(sql3)
            If reader.Read = True Then
                remaining = reader.GetString("QuantityS") - txtquantity.Value

                If remaining >= 0 Then
                    dbDisconnect()
                    dbConnect()
                    Dim query5 = "UPDATE stockin SET Remaining='" & remaining & "' WHERE MedicineID='" & medicineid & "' AND BatchID = 1 LIMIT 1"
                    ExecuteQuery(query5)
                    dbDisconnect()
                ElseIf remaining > 0 Then
                    dbDisconnect()
                    dbConnect()
                    Dim query6 = "Select MIN(BatchID) as batch from stockin WHERE Remaining <> 0"
                    ExecuteQuery(query6)
                    While reader.Read()
                        batch = reader.GetString("batch")

                    End While
                    dbDisconnect()
                    dbConnect()
                    Dim query5 = "UPDATE stockin SET Remaining='" & remaining & "' WHERE MedicineID='" & medicineid & "' AND BatchID='" & batch & "'"
                    ExecuteQuery(query5)
                    dbDisconnect()

                End If
            Else

            End If
            dbDisconnect()

            'dbConnect()
            'Dim query9 = "SELECT * FROM expiry WHERE MedicineID='" & medicineid & "' AND DOE='" & txtexp.Text & "'"
            'ExecuteQuery(query9)
            'If (reader.Read = True) Then

            '    expiryq = reader.GetString("QuantityE")
            '    disposeConnection()
            '    dbConnect()
            '    Dim query10 = "UPDATE expiry set QuantityE='" & expiryq - quantity & "'"
            '    ExecuteQuery(query10)
            'End If
            'disposeConnection()
            SearchQ.loadDataDisplay()
            Stockin.Show()
            Stockin.loadDataDisplay()
            HealthCenterMain.loadDataDisplay()
            HealthCenterMain.loadDataDisplay1()
            SearchQ.loadDataDisplay()


            ViewStocks.loadDataDisplay()
            StockHistory.loadDataDisplay()

            Stat1.viewdata()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()


        End Try

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel4.Paint

    End Sub
End Class