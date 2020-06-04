Public Class EditProfile
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = ViewProfile.medid
        txtcode.Text = ViewProfile.medcode
        txtname.Text = ViewProfile.medname
        txtunit.Text = ViewProfile.medunit
        cbolotnumber.SelectedIndex = cbolotnumber.FindString(ViewProfile.lotnumber)
        cbobrand.SelectedIndex = cbobrand.FindString(ViewProfile.medbrand)
        cbocompany.SelectedIndex = cbocompany.FindString(ViewProfile.medcompany)
        cbounit.SelectedIndex = cbounit.FindString(ViewProfile.medunit2)
        cbotype.SelectedIndex = cbotype.FindString(ViewProfile.medtype)
        txtdescription.Text = ViewProfile.description
        txtMax.Text = ViewProfile.max
        txtAlertNum.Text = ViewProfile.QTA
        If ViewProfile.alert = "Yes" Then
            rbYes.Checked = True
        Else
            rbNo.Checked = True
        End If
        loadbrand()
        loadcompany()
        loadunit()
        loadtype()
        loadlot()
        loadlotselected()
        loadbrandselected()
        loadcompanyselected()
        loadunitselected()
        loadtypeselected()
    End Sub
    Sub loadlot()
        dbConnect()
        Dim query As String = "SELECT * FROM lotnumber ORDER BY LotNumber"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbolotnumber.Items.Clear()

            While reader.Read
                cbolotnumber.Items.Add(reader.GetString(1))
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadlotselected()
        dbConnect()
        Dim query As String = "SELECT * FROM lotnumber ORDER BY LotNumber"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbolotnumber.Items.Clear()

            While reader.Read

                Dim lotselected As String = reader.GetString("LotNumber")
                cbolotnumber.Items.Add(reader.GetString(1))
                cbolotnumber.Sorted = True
                cbolotnumber.SelectedIndex = cbolotnumber.FindString(lotselected)
            End While
        End If
        dbDisconnect()
    End Sub

    Sub loadbrand()
        dbConnect()
        Dim query As String = "SELECT * FROM brand ORDER BY BrandName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbobrand.Items.Clear()

            While reader.Read
                cbobrand.Items.Add(reader.GetString(1))
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadbrandselected()
        dbConnect()
        Dim query As String = "SELECT * FROM brand ORDER BY BrandName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbobrand.Items.Clear()

            While reader.Read

                Dim brandnameselected As String = reader.GetString("BrandName")
                cbobrand.Items.Add(reader.GetString(1))
                cbobrand.Sorted = True
                cbobrand.SelectedIndex = cbobrand.FindString(brandnameselected)
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadcompany()
        dbConnect()
        Dim query As String = "SELECT * FROM company ORDER BY CompanyName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbocompany.Items.Clear()

            While reader.Read

                cbocompany.Items.Add(reader.GetString(1))
                cbocompany.Sorted = True

            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadcompanyselected()
        dbConnect()
        Dim query As String = "SELECT * FROM company ORDER BY CompanyName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbocompany.Items.Clear()

            While reader.Read

                Dim comppanyname As String = reader.GetString("CompanyName")
                cbocompany.Items.Add(reader.GetString(1))
                cbocompany.Sorted = True
                cbocompany.SelectedIndex = cbocompany.FindString(comppanyname)
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadtype()
        dbConnect()
        Dim query As String = "SELECT * FROM type ORDER BY TypeName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbotype.Items.Clear()

            While reader.Read
                cbotype.Items.Add(reader.GetString(1))
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadtypeselected()
        dbConnect()
        Dim query As String = "SELECT * FROM type ORDER BY TypeName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbotype.Items.Clear()

            While reader.Read

                Dim typeselected As String = reader.GetString("TypeName")
                cbotype.Items.Add(reader.GetString(1))
                cbotype.Sorted = True
                cbotype.SelectedIndex = cbotype.FindString(typeselected)
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadunit()
        dbConnect()
        Dim query As String = "SELECT * FROM unit ORDER BY UnitName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbounit.Items.Clear()

            While reader.Read
                cbounit.Items.Add(reader.GetString(1))
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadunitselected()
        dbConnect()
        Dim query As String = "SELECT * FROM unit ORDER BY UnitName"
        ExecuteQuery(query)
        If reader.HasRows Then
            cbounit.Items.Clear()

            While reader.Read

                Dim unitselected As String = reader.GetString("UnitName")
                cbounit.Items.Add(reader.GetString(1))
                cbounit.SelectedIndex = cbounit.FindString(unitselected)
            End While
        End If
        dbDisconnect()
    End Sub

    Sub save()
        Dim lotnumber As String = cbolotnumber.Text
        Dim code As String = Trim(txtcode.Text)
        Dim name As String = Trim(txtname.Text)
        Dim unit As String = Trim(txtunit.Text)
        Dim unit2 As String = Trim(cbounit.Text)
        Dim brand As String = Trim(cbobrand.Text)
        Dim company As String = Trim(cbocompany.Text)
        Dim type As String = Trim(cbotype.Text)
        Dim description As String = Trim(txtdescription.Text)
        Dim max As String = Trim(txtMax.Text)
        Dim alertyesno As String = ViewProfile.alert
        Dim Alertnum As String = Trim(txtAlertNum.Text)




        Try
            dbConnect()


            Dim query = "UPDATE profilemedicine SET MedicineCode='" & code & "', " _
                        & " MedicineName = '" & name & "', MedicineUnit = '" & unit & "', " _
                        & " Description = '" & description & "', QuantityToAlert ='" & Alertnum & "', AlertNo = '" & alertyesno & "', Max = '" & max & "'," _
                        & " BrandID = (SELECT BrandID FROM brand WHERE BrandName = '" & brand & "')," _
                        & " CompanyID = (SELECT CompanyID FROM company WHERE CompanyName = '" & company & "')," _
                        & " TypeID = (SELECT TypeID FROM type WHERE TypeName = '" & type & "')," _
                         & " LotNumberID = (SELECT LotNumberID FROM lotnumber WHERE LotNumber = '" & lotnumber & "')," _
                        & " UnitID = (SELECT UnitID FROM unit WHERE UnitName = '" & unit2 & "') WHERE MedicineID ='" & txtid.Text & "'"
            ExecuteQuery(query)
            MsgBox("Medicine successfully updated!", vbInformation, "Updated")
            dbDisconnect()

            Me.Close()
            ViewProfile.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()

        End Try

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        save()
        ViewProfile.ViewData()
    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Me.Close()
    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class