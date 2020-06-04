Imports MySql.Data.MySqlClient

Public Class AddStock
    Dim isExpiry As String = ""
    Private Sub GunaLabel8_Click(sender As Object, e As EventArgs) Handles GunaLabel8.Click

    End Sub

    Private Sub GunaLabel10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub
    Sub loadreceived()
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM receivedfrom ORDER BY ReceiveName"
            ExecuteQuery(query)
            If reader.HasRows Then
                cboreceived.Items.Clear()

                While reader.Read
                    cboreceived.Items.Add(reader.GetString(1))
                End While
            End If
            dbDisconnect()
        Catch
        End Try
    End Sub
    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = Stockin.medid
        txtcode.Text = Stockin.medcode
        txtname.Text = Stockin.medname
        txtunit.Text = Stockin.medunit + " " + Stockin.medunit2
        txtbrand.Text = Stockin.medbrand
        txtcompany.Text = Stockin.medcompany
        txttype.Text = Stockin.medtype
        txtdescription.Text = Stockin.description
        txtmax.Text = Stockin.max
        txtqta.Text = Stockin.QTA
        txtalert.Text = Stockin.alert
        txtdate.Text = HealthCenterMain.dtServer.ToShortDateString()
        txtmonth.Text = HealthCenterMain.dtServer.Month.ToString
        txtyear.Text = HealthCenterMain.dtServer.Year.ToString
        txtstockinby.Text = FormLogin.user

        DOE.Format = DateTimePickerFormat.Custom
        DOE.CustomFormat = "yyyy-M-d"
        DOE.MinDate = HealthCenterMain.dtServer.AddDays(1)

        loadreceived()

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtfullname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged

    End Sub

    Private Sub GunaGroupBox9_Click(sender As Object, e As EventArgs) Handles GunaGroupBox9.Click

    End Sub

    Private Sub GunaGroupBox10_Click(sender As Object, e As EventArgs) Handles GunaGroupBox10.Click

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            If Trim(txtquantity.Text) = "" Or Val(txtquantity.Text) = 0 Then
                MsgBox("Quantity must not be null.", vbExclamation, "Warning!")
                txtquantity.Focus()

            ElseIf txtquantity.Value > txtmax.Text Then

                MsgBox("Max Quantity of Stockin is Exceeded.", vbExclamation, "Warning!")
                txtquantity.Focus()
            ElseIf cboreceived.SelectedIndex < 0 Then

                MsgBox("Field Received is required", vbExclamation, "Warning!")
                txtquantity.Focus()
            Else




                save()
            End If
        Catch
        End Try
    End Sub
    Sub save()
        Dim a As String = txtalert.Text
        Dim received As String = cboreceived.Text
        Dim rf As String = Trim(cboreceived.Text)
        Dim medicineid As Integer = txtid.Text
        Dim dos As String = txtdate.Text
        Dim sib As String = txtstockinby.Text
        Dim medcode As String = txtcode.Text
        Dim quantity As Integer = 0
        Dim totalquantity As Integer = 0
        quantity = txtquantity.Value
        Dim batchq As Integer = 0
        Dim qa As Integer = txtqta.Text
        Dim expiryq As Integer
        isExpiry = DOE.Value.ToShortDateString()
        Try

            dbConnect()


            Dim query4 = "SELECT BatchID FROM stockin WHERE MedicineID='" & medicineid & "'"
            ExecuteQuery(query4)
            If (reader.Read = True) Then
                batchq = reader.GetString("BatchID") + 1
            Else
                batchq = 1
            End If

            dbDisconnect()
            dbConnect()


            Dim query9 = "SELECT * FROM expiry WHERE MedicineID='" & txtid.Text & "' AND DOE='" & isExpiry & "'"
            ExecuteQuery(query9)
            If (reader.Read = True) Then

                expiryq = reader.GetString("QuantityE")
                dbDisconnect()
                dbConnect()
                Dim query12 = "UPDATE expiry set QuantityE='" & quantity + expiryq & "', GrandTotal='" & quantity + expiryq & "',NotificationE='NotRead' WHERE MedicineID='" & txtid.Text & "' AND DOE='" & isExpiry & "'"
                ExecuteQuery(query12)
                dbDisconnect()
            Else
                dbConnect()
                Dim query11 = "INSERT INTO expiry SET MedicineID='" & medicineid & "',DOE='" & isExpiry & "',QuantityE='" & quantity & "',GrandTotal='" & quantity & "',NotificationE='NotRead', AlertNo='" & a & "'"
                ExecuteQuery(query11)
                dbDisconnect()
            End If
            dbDisconnect()
            dbConnect()


            Dim query10 = "SELECT * FROM stockdesc WHERE MedicineID='" & txtid.Text & "' AND DOSD='" & txtdate.Text & "'"
            ExecuteQuery(query10)
            If (reader.Read = True) Then

                expiryq = reader.GetString("TotalSD")
                dbDisconnect()
                dbConnect()
                Dim query11 = "UPDATE stockdesc set TotalSD='" & quantity + expiryq & "'"
                ExecuteQuery(query11)
                dbDisconnect()
            Else
                dbConnect()
                Dim query11 = "INSERT INTO stockdesc SET MedicineID='" & medicineid & "',DOSD ='" & txtdate.Text & "',TotalSD='" & quantity & "'"
                ExecuteQuery(query11)
                dbDisconnect()
            End If
            dbDisconnect()
            dbConnect()

            Dim query = "INSERT INTO stockin SET MedicineID='" & medicineid & "', " _
                        & " DOS = '" & dos & "', StockinBy = '" & sib & "', " _
                        & " QuantityS = '" & quantity & "', DOE ='" & isExpiry & "',BatchID ='" & batchq & "',QA ='" & qa & "',MonthS='" & txtmonth.Text & "',YearS='" & txtyear.Text & "',ReceivedFromID = (SELECT ReceivedFromID FROM receivedfrom WHERE ReceiveName = '" & rf & "')"
            ExecuteQuery(query)
            MsgBox("Stocks successfully added!", vbInformation, "Saved")
            dbDisconnect()

            dbConnect()
            Dim query2 = "Select Quantity from profilemedicine WHERE MedicineID='" & medicineid & "' "
            ExecuteQuery(query2)
            While reader.Read()
                totalquantity = reader.GetString("Quantity")

            End While


            reader.Close()
            dbDisconnect()
            Dim grandtotal As Integer = txtquantity.Value + totalquantity
            dbConnect()
            Dim query3 = "UPDATE profilemedicine SET Total='" & grandtotal & "', Quantity='" & grandtotal & "' WHERE MedicineID='" & medicineid & "' "
            ExecuteQuery(query3)
            dbDisconnect()

            Me.Close()
            SearchQ.loadDataDisplay()
            Stockin.Show()
            Stockin.loadDataDisplay()
            HealthCenterMain.loadDataDisplay()
            HealthCenterMain.loadDataDisplay1()

            ViewStocks.loadDataDisplay()
            StockHistory.loadDataDisplay()

            Statistics.viewdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()


        End Try

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        AddLotNumber.Show()
    End Sub

    Private Sub DOE_ValueChanged(sender As Object, e As EventArgs) Handles DOE.ValueChanged

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ReceivedFrom.Show()
    End Sub

    Private Sub txtquantity_ValueChanged(sender As Object, e As EventArgs) Handles txtquantity.ValueChanged

    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaPanel4_Paint_1(sender As Object, e As PaintEventArgs) Handles GunaPanel4.Paint

    End Sub
End Class