Imports MySql.Data.MySqlClient
Public Class Issuance
    Dim suggestions As New AutoCompleteStringCollection()
    Public search1 As String
    Dim selectedItemID As String
    Dim stockID As String
    Dim d As Date = d.ToString
    Private Sub Issuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadQuestions()
        btnproceed.Enabled = True
        txtreceiver.Enabled = True
        txtmonth.Text = HealthCenterMain.dtServer.Month.ToString
        txtyear.Text = HealthCenterMain.dtServer.Year.ToString
        txtdos.Text = HealthCenterMain.dtServer.ToShortDateString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            search1 = ""

            SearchMed.searchflag = True
            SearchMed.ShowDialog()

            Dim isSelected As Boolean = False
            Dim flag As Boolean = False
            Dim query

            If isSelected Then
                MessageBox.Show("Medicine is already selected", "a", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ElseIf search1 <> "" Or isSelected = False Then
                txtcode.Text = search1
                txtquantity.Enabled = True

                query = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE MedicineCode='" & txtcode.Text & "' GROUP BY MedicineCode DESC"
                dbConnect()
                ExecuteQuery(query)

                If flag Then

                ElseIf flag = False Then
                    If reader.HasRows Then
                        While reader.Read
                            txtid.Text = reader(0)
                            txtname.Text = reader(2)
                            txtcode.Text = reader(1)
                            txttype.Text = reader.GetString("TypeName")
                            txtbname.Text = reader.GetString("BrandName")
                            txtunit.Text = reader.GetString("MedicineUnit") + " " + reader.GetString("UnitName")
                            txtavailable.Text = reader.GetString("Quantity")

                            txtquantity.Text = "1"
                            txtquantity.Focus()
                        End While
                    End If
                End If


                For Each items As ListViewItem In MEDLV.Items
                    If items.SubItems(1).Text = txtid.Text Then
                        txtavailable.Text = Integer.Parse(txtavailable.Text) - Integer.Parse(items.SubItems(6).Text)
                        flag = True

                        Exit For
                    Else
                        txtavailable.Text = txtavailable.Text

                    End If
                Next

                flag = False
            End If
            dbDisconnect()
            search1 = ""
        Catch
        End Try
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Sub TransferToListview()
        Try
            Dim flag As Boolean = False
            Dim flagindex As Integer
            Dim query As String
            Dim rqt As Integer = 0
            Dim currentusedqty As Integer = 0

            dbConnect()
            query = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE MedicineCode='" & txtcode.Text & "' GROUP BY MedicineCode DESC"
            ExecuteQuery(query)
            If reader.HasRows Then
                reader.Read()
                rqt = reader.GetString("Quantity")
            End If
            dbDisconnect()

            For x = 0 To MEDLV.Items.Count - 1
                If MEDLV.Items.Item(x).SubItems(1).Text = txtid.Text Then
                    flagindex = x
                    flag = True
                    currentusedqty = Val(MEDLV.Items.Item(x).SubItems(6).Text)
                End If
            Next
            If flag = True Then
                MEDLV.Items(flagindex).SubItems(6).Text = Val(MEDLV.Items(flagindex).SubItems(6).Text) + Val(txtquantity.Text)


            Else
                MEDLV.Items.Add(MEDLV.Items.Count)
                MEDLV.Items(MEDLV.Items.Count - 1).SubItems.Add(txtid.Text)
                MEDLV.Items(MEDLV.Items.Count - 1).SubItems.Add(txtname.Text)
                MEDLV.Items(MEDLV.Items.Count - 1).SubItems.Add(txtbname.Text)
                MEDLV.Items(MEDLV.Items.Count - 1).SubItems.Add(txttype.Text)
                MEDLV.Items(MEDLV.Items.Count - 1).SubItems.Add(txtunit.Text)
                MEDLV.Items(MEDLV.Items.Count - 1).SubItems.Add(txtquantity.Text)


            End If
        Catch
        End Try

    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If Trim(txtquantity.Text) = "" Or Val(txtquantity.Text) = 0 Then
                MsgBox("Quantity must not be null.", vbExclamation, "Warning!")
                txtquantity.Focus()



            ElseIf Val(txtquantity.Text) < 0 Then
                MsgBox("Quantity must be a non-zero value.")

            ElseIf (Val(txtavailable.Text) >= Val(txtquantity.Text)) Then


                TransferToListview()
                txtsearch.Text = ""
                txtcode.Text = ""
                txtname.Text = ""
                txtid.Text = ""
                txtbname.Text = ""
                txttype.Text = ""
                txtunit.Text = ""
                txtavailable.Text = ""
                txtquantity.Value = 0





            ElseIf (Val(txtavailable.Text) < Val(txtquantity.Text)) Then
                MsgBox("Please enter a quantity that is not exceeding the available items.", vbExclamation, "Insufficient product.")
                txtquantity.Value = 0
                txtquantity.Focus()
            End If
        Catch
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles btnproceed.Click
        If MEDLV.Items.Count <= 0 Then
            MsgBox("Please Select Medicine First")
        Else
            save()
        End If
    End Sub
    Sub save()

        Dim medid = txtid.Text
        Dim dateofstockin = DateTime.Now.ToString("yyyy-M-d")
        Dim transactionby = FormLogin.user
        Dim transtatus = ""
        Dim dates = HealthCenterMain.dtServer.ToShortDateString()
        Dim totalquantity As Integer
        Dim quantity As Integer = 0
        Dim newd As Integer
        Try


            For Each items As ListViewItem In MEDLV.Items
                If MEDLV.Items.Count <= 0 Then
                    MsgBox("Please Select Medicine First")
                Else

                    Dim itemid = items.SubItems(1).Text
                    Dim itemname = items.SubItems(2).Text
                    Dim idesc = items.SubItems(3).Text
                    Dim iprice = items.SubItems(4).Text
                    Dim iqty = items.SubItems(6).Text
                    Dim re = Trim(txtreceiver.Text)

                    dbConnect()
                    Dim query = "INSERT INTO stockout SET MedicineID='" & itemid & "', " _
                            & " DOS = '" & dateofstockin & "', StockoutBy = '" & transactionby & "', " _
                            & " QuantitySO = '" & iqty & "',ReceiversName = '" & re & "', Reason= 'Issuance',Month='" & txtmonth.Text & "',Year='" & txtyear.Text & "' "
                    ExecuteQuery(query)

                    dbDisconnect()

                    dbConnect()
                    Dim query2 = "SELECT Quantity from profilemedicine WHERE MedicineID='" & itemid & "' "
                    ExecuteQuery(query2)
                    While reader.Read()
                        totalquantity = reader.GetString("Quantity")

                    End While

                    dbDisconnect()

                    Dim grandtotal As Integer = totalquantity - iqty
                    dbConnect()
                    Dim query3 = "UPDATE profilemedicine SET Quantity='" & grandtotal & "' WHERE MedicineID='" & itemid & "' "
                    ExecuteQuery(query3)
                    dbDisconnect()
                    dbConnect()
                    Dim sql As String = "SELECT min(date(DOE)) as date from expiry WHERE MedicineID ='" & itemid & "' AND QuantityE > 0"
                    ExecuteQuery(sql)
                    While reader.Read
                        d = Date.Parse(reader("date")).ToShortDateString
                    End While
                    txtex.Text = d
                    dbDisconnect()
                    dbConnect()
                    Dim expiryq As Integer

                    Dim query9 = "SELECT * FROM expiry WHERE MedicineID='" & itemid & "' AND DOE='" & txtex.Text & "'"
                    ExecuteQuery(query9)
                    If (reader.Read = True) Then

                        expiryq = reader.GetString("QuantityE")

                        reader.Close()
                        dbDisconnect()
                        If (expiryq - iqty) < 0 Then
                            dbConnect()
                            Dim query12 = "UPDATE expiry set QuantityE='0', GrandTotal='0',NotificationE='NotRead' WHERE MedicineID='" & itemid & "' AND DOE='" & txtex.Text & "'"
                            ExecuteQuery(query12)
                            dbDisconnect()
                            dbConnect()
                            Dim ans = iqty - expiryq
                            sql = "SELECT * from expiry WHERE MedicineID ='" & itemid & "' AND DOE > '" & txtex.Text & "'"
                            ExecuteQuery(sql)
                            While reader.Read
                                d = reader.GetString("DOE")
                            End While

                            dbDisconnect()
                            dbConnect()
                            Dim query19 = "SELECT * FROM expiry WHERE MedicineID='" & itemid & "' AND DOE='" & d & "'"
                            ExecuteQuery(query19)
                            If (reader.Read = True) Then

                                newd = reader.GetString("QuantityE")
                            End If
                            dbDisconnect()

                            dbConnect()
                            Dim query18 = "UPDATE expiry set QuantityE='" & newd - ans & "', GrandTotal='" & newd - ans & "',NotificationE='NotRead' WHERE MedicineID='" & itemid & "' AND DOE='" & d & "'"
                            ExecuteQuery(query18)
                            dbDisconnect()
                            dbConnect()

                        Else
                            dbConnect()
                            Dim query12 = "UPDATE expiry set QuantityE='" & expiryq - iqty & "', GrandTotal='" & expiryq - iqty & "',NotificationE='NotRead' WHERE MedicineID='" & itemid & "' AND DOE='" & txtex.Text & "'"
                            ExecuteQuery(query12)
                            dbDisconnect()
                        End If

                    End If
                    dbDisconnect()

                    dbConnect()
                    Dim query10 = "SELECT * FROM stockoutdesc WHERE MedicineID='" & itemid & "' AND DOSO='" & txtdos.Text & "'"
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
                        Dim query11 = "INSERT INTO stockoutdesc SET MedicineID='" & itemid & "',DOSO='" & txtdos.Text & "',TotalSO='" & iqty & "'"
                        ExecuteQuery(query11)
                        dbDisconnect()
                    End If
                    dbDisconnect()


                End If
            Next


        Catch ex As Exception

        Finally
            MsgBox("Issuance Successful")
            MEDLV.Items.Clear()
            txtreceiver.Text = ""
            disposeConnection()
            txtcode.Text = ""
            txtname.Text = ""
            txtid.Text = ""
            txtbname.Text = ""
            txttype.Text = ""
            txtunit.Text = ""
            txtavailable.Text = ""
            txtquantity.Value = 0
            SearchQ.loadDataDisplay()
            ViewStocks.loadDataDisplay()
            StockHistory.loadDataDisplay()
            Stockin.loadDataDisplay()
            Stat1.viewdata()

            HealthCenterMain.loadDataDisplay()
            HealthCenterMain.loadDataDisplay1()
        End Try
    End Sub
    Sub Payment()
        Try
            Dim medid = txtid.Text
            Dim dateofstockin = DateTime.Now.ToString("yyyy-M-d")
            Dim transactionby = FormLogin.user
            Dim transtatus = ""
            Dim dates = HealthCenterMain.dtServer.ToShortDateString()


            For Each items As ListViewItem In MEDLV.Items
                Dim medno = items.Text
                Dim medcode = items.SubItems(1).Text
                Dim medname = items.SubItems(2).Text
                Dim medbrand = items.SubItems(3).Text
                Dim medunit = items.SubItems(4).Text
                Dim medtype = items.SubItems(5).Text
                Dim medq = items.SubItems(6).Text

                Dim remqty As Integer
                Dim stckID As String
                Dim stckintotalqty, ttlqty As Integer
                Dim cont = True

                dbConnect()
                Dim querry = "SELECT Quantity FROM profilemedicine WHERE MedicineCode='" & medcode & "'"
                ExecuteQuery(querry)
                If reader.HasRows Then
                    reader.Read()

                    ttlqty = reader.GetString("Quantity")
                End If
                dbDisconnect()
                dbConnect()
                Dim querry2 = "SELECT coalesce(sum(QuantityS),0) as re FROM stockin WHERE MedicineCode='" & medcode & "'"
                ExecuteQuery(querry2)
                If reader.HasRows Then
                    reader.Read()

                    stckintotalqty = reader.GetString("re")
                End If
                dbDisconnect()
                If Val(ttlqty) <> Val(stckintotalqty) Then
                    Dim diff = Val(ttlqty) - Val(stckintotalqty)
                    If Val(medq) <= Val(diff) Then
                        Dim newqty As Integer
                        newqty = Val(diff) - Val(medq)
                        newqty = Val(stckintotalqty) + Val(newqty)
                        dbConnect()
                        querry = "UPDATE profilemedicine SET Quantity= '" & newqty & "',Total = '" & ttlqty + medq & "' WHERE MedicineID = '" & medid & "'"
                        ExecuteQuery(querry)
                        dbDisconnect()
                        dbConnect()
                        querry = "INSERT INTO stockout SET MedicineID = '" & medid & "', QuantitySO='" & medq & "', Reason= 'Issuance', stockoutby='" & transactionby & "',DOS='" & dates & "'"
                        ExecuteQuery(querry)
                        dbDisconnect()
                        cont = False
                    Else
                        medq = Val(medq) - Val(diff)
                        cont = True
                    End If
                ElseIf Val(ttlqty) = Val(stckintotalqty) Then
                    cont = True
                End If
                Dim query
                If cont = True Then
                    dbConnect()
                    query = " SELECT MedicineID, Quantity FROM profilemedicine WHERE MedicineID = '" & txtid.Text & "' AND Quantity != 0 GROUP BY MedicineID ORDER BY MedicineID ASC LIMIT 1"
                    ExecuteQuery(query)
                    If reader.HasRows Then
                        While reader.Read
                            remqty = reader.GetString(1)
                            stckID = reader.GetString("MedicineID")
                        End While
                    End If
                    dbDisconnect()

                    medq = Val(medq) - Val(remqty)
                    If medq > 0 Then
                        Do Until medq <= 0
                            dbConnect() ' subtract quantity
                            query = " UPDATE profilemedicine SET Quantity = '0' WHERE MedicineID = '" & txtid.Text & "' AND Quantity != 0  ORDER BY MedicineID ASC LIMIT 1"
                            ExecuteQuery(query)
                            dbDisconnect()
                            dbConnect()
                            query = " SELECT MedicineID, Quantity FROM profilemedicine WHERE MedicineID = '" & txtid.Text & "' AND Quantity != 0 GROUP BY MedicineID ORDER BY MedicineID ASC LIMIT 1"
                            ExecuteQuery(query)
                            If reader.HasRows Then
                                While reader.Read
                                    remqty = reader.GetString(1)
                                    stckID = reader.GetString("MedicineID")
                                End While
                            End If
                            dbDisconnect()
                            medq = medq - Val(remqty)
                        Loop
                    End If
                    If medq = 0 Then
                        dbConnect() ' subtract quantity
                        query = " UPDATE profilemedicine SET Quantity = '0' WHERE MedicineID = '" & txtid.Text & "' AND Quantity != 0  ORDER BY MedicineID ASC LIMIT 1"
                        ExecuteQuery(query)
                        dbDisconnect()
                    End If
                    If medq < 0 Then
                        remqty = medq * -1
                        dbConnect() ' subtract quantity
                        query = " UPDATE profilemedicine SET Quantity = '" & remqty & "' WHERE MedicineID = '" & txtid.Text & "' AND Quantity != 0 ORDER BY MedicineID ASC LIMIT 1"
                        ExecuteQuery(query)
                        dbDisconnect()
                    End If

                    Dim finalqty As Integer = 0
                    dbConnect()
                    query = "SELECT coalesce(sum(QuantityS),0) FROM stockin WHERE MedicineID ='" & txtid.Text & "'"
                    ExecuteQuery(query)
                    If reader.HasRows Then
                        reader.Read()
                        finalqty = reader.GetString(0)
                    End If
                    dbDisconnect()

                    dbConnect()
                    query = "UPDATE profilemedicine SET Quantity = '" & finalqty & "' WHERE MedicineID ='" & txtid.Text & "'"
                    ExecuteQuery(query)
                    dbDisconnect()


                End If


            Next

        Catch
        End Try


    End Sub


    Private Sub MEDLV_Click(sender As Object, e As EventArgs) Handles MEDLV.Click
        selectedItemID = MEDLV.Items(MEDLV.SelectedIndices(0)).SubItems(1).Text

        transferstock()
    End Sub
    Sub transferstock()
        Try
            dbConnect()
            Dim query As String = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE MedicineID='" & selectedItemID & "'  "

            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtid.Text = reader.GetString(0)
                    txtname.Text = reader.GetString(2)
                    txtcode.Text = reader.GetString(1)
                    txttype.Text = reader.GetString("TypeName")
                    txtbname.Text = reader.GetString("BrandName")
                    txtunit.Text = reader.GetString("UnitName")
                    txtavailable.Text = reader.GetString("Quantity")
                End While
            End If

            For Each items As ListViewItem In MEDLV.Items
                If items.SubItems(1).Text = txtid.Text Then
                    txtavailable.Text = Integer.Parse(txtavailable.Text) - Integer.Parse(items.SubItems(6).Text)
                    'flag = True

                    Exit For
                Else
                    txtavailable.Text = txtavailable.Text
                End If
            Next
            dbDisconnect()

        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click

        Me.Close()
    End Sub

    Private Sub txtreceiver_TextChanged(sender As Object, e As EventArgs) Handles txtreceiver.TextChanged

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            txtcode.Text = ""
            txtname.Text = ""
            txtid.Text = ""
            txtbname.Text = ""
            txttype.Text = ""
            txtunit.Text = ""
            txtavailable.Text = ""
            txtquantity.Value = 0
        Catch
        End Try
    End Sub

    Private Sub MEDLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MEDLV.SelectedIndexChanged

    End Sub

    Private Sub MEDLV_DoubleClick(sender As Object, e As EventArgs) Handles MEDLV.DoubleClick
        If MEDLV.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If (MsgBox("You are about to remove selected item(s). Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            Try
                For Each item As ListViewItem In MEDLV.SelectedItems
                    item.Remove()


                Next
                MsgBox("Removed selected item(s).", vbInformation, "Success!")
                'clear()
                For Each items As ListViewItem In MEDLV.Items
                    If items.SubItems(1).Text = txtid.Text Then

                        'flag = True

                        Exit For
                    Else
                        txtavailable.Text = txtavailable.Text
                    End If
                Next
                txtcode.Text = ""
                txtname.Text = ""
                txtid.Text = ""
                txtbname.Text = ""
                txttype.Text = ""
                txtunit.Text = ""
                txtavailable.Text = ""
                txtquantity.Value = 0
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            End Try
            disposeConnection()
        End If

    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged

    End Sub
    Sub loadQuestions()

        dbConnect()
        Dim query As String = "SELECT * FROM profilemedicine WHERE SearchEngine LIKE '%" & txtsearch.Text & "%' AND Quantity <> 0 ORDER BY SearchEngine DESC"
        ExecuteQuery(query)
        If reader.HasRows Then
            suggestions.Clear()
            While reader.Read
                suggestions.Add(reader.GetString("SearchEngine"))
               
            End While
        End If
        dbDisconnect()
        disposeConnection()

        txtsearch.AutoCompleteCustomSource = suggestions
        txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
        txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtsearch_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        'dbConnect()
        'Dim id As String = ""
        'Dim query As String = "SELECT * FROM profilemedicine WHERE SearchEngine = '" & txtsearch.Text & "' ORDER BY SearchEngine DESC"
        'ExecuteQuery(query)
        'If (reader.Read = True) Then

        '    txtcode.Text = reader.GetString("MedicineCode")
        '    txtname.Text = reader.GetString("MedicineName")
        '    id = reader.GetString("MedicineID")

        'End If

        'dbDisconnect()
        'dbConnect()

        'Dim query1 As String = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE MedicineID='" & id & "' GROUP BY MedicineID DESC"
        'ExecuteQuery(query1)
        'If (reader.Read = True) Then
        '    txtunit.Text = reader.GetString("MedicineUnit") + " " + reader.GetString("UnitName")
        '    txttype.Text = reader.GetString("TypeName")
        '    txtbname.Text = reader.GetString("BrandName")

        'End If

        'dbDisconnect()
        Try
            search1 = ""

            SearchMed.searchflag = True

            Dim isSelected As Boolean = False
            Dim flag As Boolean = False
            Dim query

            If isSelected Then
                MessageBox.Show("Medicine is already selected", "a", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ElseIf search1 <> "" Or isSelected = False Then
                txtcode.Text = search1
                txtquantity.Enabled = True

                query = "SELECT *, (SELECT BrandName from brand WHERE brand.BrandID=profilemedicine.BrandID) as BrandName,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName,(SELECT CompanyName from company WHERE company.CompanyID=profilemedicine.CompanyID) as CompanyName,(SELECT TypeName from type WHERE type.TypeID=profilemedicine.TypeID) as TypeName FROM profilemedicine WHERE SearchEngine='" & txtsearch.Text & "' GROUP BY SearchEngine DESC"
                dbConnect()
                ExecuteQuery(query)

                If flag Then

                ElseIf flag = False Then
                    If reader.HasRows Then
                        While reader.Read
                            txtid.Text = reader(0)
                            txtname.Text = reader(2)
                            txtcode.Text = reader(1)
                            txttype.Text = reader.GetString("TypeName")
                            txtbname.Text = reader.GetString("BrandName")
                            txtunit.Text = reader.GetString("UnitName")
                            txtavailable.Text = reader.GetString("Quantity")
                            txtquantity.Text = "1"
                            txtquantity.Focus()
                        End While

                    End If
                End If


                For Each items As ListViewItem In MEDLV.Items
                    If items.SubItems(1).Text = txtid.Text Then
                        txtavailable.Text = Integer.Parse(txtavailable.Text) - Integer.Parse(items.SubItems(6).Text)
                        flag = True

                        Exit For
                    Else
                        txtavailable.Text = txtavailable.Text

                    End If
                Next

                flag = False
            End If
            dbDisconnect()
            search1 = ""
        Catch
        End Try

    End Sub

    Private Sub GunaButton1_Click_1(sender As Object, e As EventArgs)
        If MEDLV.Items.Count <= 0 Then
            MsgBox("Please Select Medicine First")
        Else
            save()
            'Dim frm As New IssuanceReport
            'Dim dt As New DataTable

            'With dt
            '    .Columns.Add("Code")
            '    .Columns.Add("MName")
            '    .Columns.Add("Brand")
            '    .Columns.Add("Type")
            '    .Columns.Add("Unit")
            '    .Columns.Add("Quantity")

            'End With

            'For Each r As DataGridViewRow In ViewStock.Rows
            '    dt.Rows.Add(r.Cells(3).Value, r.Cells(2).Value, r.Cells(5).Value, r.Cells(7).Value, r.Cells(4).Value, r.Cells(8).Value)
            'Next
            'rpt.SetDataSource(dt)
            'frm.CrystalReportViewer1.ReportSource = rpt

            'frm.ShowDialog()

        End If
    End Sub

    Private Sub GunaPictureBox1_Click_1(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub txtex_TextChanged(sender As Object, e As EventArgs) Handles txtex.TextChanged

    End Sub
End Class