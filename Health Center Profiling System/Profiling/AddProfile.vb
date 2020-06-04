Imports MySql.Data.MySqlClient
Public Class AddProfile
    Dim catDescID As New List(Of String)
    Dim descValue As New List(Of String)
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim suggestions As New AutoCompleteStringCollection()
    Dim alert As String = "No"
    Public LetterOnly As String = " ñabcdefghijklmnopqrstuvwxyzÑABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public LetterWSpecial As String = " ÑñabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-,./"
    Public NumberOnly As String = "1234567890"
    Public NumberWComma As String = "1234567890,."
    Public NumberWSlash As String = "1234567890/-"
    Public NumberWDot As String = "1234567890."
    Public Alpha As String = " ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-,./_"
    Public AlphaNumber As String = " ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public NumberWDash As String = "1234567890-"
    Private Sub AddProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadbrand()
        loadcompany()
        loadunit()
        loadtype()
        loadlot()
        loadID()
    End Sub

    Public Function LoadCategoryDescription(ByVal categoryName As String) As System.Data.DataTable
        Dim result As New DataTable
        result = Nothing

        Try
            Dim query As String = "SELECT * FROM subtype INNER JOIN type ON type.TypeID=subtype.TypeID WHERE TypeID=(SELECT TypeID FROM type WHERE TypeName = '" & categoryName & "') ORDER BY TypeName"
            result = RetrieveDataTable(query)
        Catch __unusedException1__ As Exception
            Throw
        End Try

        Return result
    End Function
    Dim catID As String
    Private Sub LoadSubCategory()
        cbounit.Items.Clear()
        dbConnect()
        Dim query As String = "SELECT TypeID FROM type WHERE TypeName ='" & cbotype .Text & "' LIMIT 1"
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                catID = reader.GetString("TypeID")
            End While
        End If
        dbDisconnect()

        dbConnect()
        query = "SELECT UnitName FROM unit WHERE TypeID ='" & catID & "'"
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                cbounit.Items.Add(reader.GetString("UnitName"))
            End While
        End If
        dbDisconnect()
    End Sub
    Sub loadID()
        Try
            dbConnect()
            Dim query As String = "SELECT MedicineCode from profilemedicine ORDER BY MedicineCode DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtcode.Text = "MED" & Val(Mid(reader.GetString(0), 4, 8)) + 1
                End While
            Else
                txtcode.Text = "MED20001"
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Public Sub AllowedOnly(s As String, tb As TextBox)
        Try
            Dim theText As String = tb.Text
            Dim Letter As String
            Dim SelectionIndex As Integer = tb.SelectionStart
            Dim Change As Integer = 0
            For x As Integer = 0 To tb.Text.Length - 1
                Letter = tb.Text.Substring(x, 1)
                If s.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                End If
            Next
            tb.Text = theText
            tb.Select(SelectionIndex - Change, 0)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        If Trim(txtname.Text) = "" Or Trim(txtcode.Text) = "" Or Trim(txtunit.Text) = "" Or Trim(txtAlertNum.Text) = "" Then
            MessageBox.Show("Medicine Unit, Brand, Company, Type and Lot Number are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cbounit.SelectedIndex < 0 And cbolotnumber.SelectedIndex < 0 And cbobrand.SelectedIndex < 0 And cbocompany.SelectedIndex < 0 And cbotype.SelectedIndex < 0 Then
            MessageBox.Show("Medicine Unit, Brand, Company, Type and Lot Number are required.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            save()
            ViewProfile.ViewData()
        End If
    End Sub
    Public Function IsTextBoxEmpty(ParamArray obj() As TextBox)
        Dim bool As Boolean = False
        Dim i As Integer
        For i = 0 To obj.Length - 1
            If obj(i).Text.Length = 0 Then
                bool = True
                Exit For
            End If
        Next
        Return bool
    End Function
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
        Dim query As String = "SELECT * FROM company ORDER BY CompanyID Desc"
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
    Sub loadcompany2selected()

        cbocompany.Items.Add(AddCompany.company)
        cbocompany.Sorted = True
        cbocompany.SelectedIndex = cbocompany.FindString(AddCompany.company)
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
    Sub loadsubtype()
        dbConnect()
        Dim query As String = "SELECT * FROM subtype ORDER BY SubTypeName WHERE TypeID(SELECT   
]8)"
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
        Dim alertyesno As String = alert
        Dim Alertnum As String = Trim(txtAlertNum.Text)




        Try
            dbConnect()


            Dim query = "INSERT INTO profilemedicine SET MedicineCode='" & code & "', " _
                        & " MedicineName = '" & name & "' , MedicineUnit = '" & unit & "', " _
                        & " Description = '" & description & "', QuantityToAlert ='" & Alertnum & "', AlertNo = '" & alert & "', Max = '" & max & "', Quantity = 0, NotificatioN ='NotRead', SearchEngine='" & name + "-" + brand + "-" + type + "-" + unit + "-" + unit2 & "'," _
                        & " BrandID = (SELECT BrandID FROM brand WHERE BrandName = '" & brand & "')," _
                        & " CompanyID = (SELECT CompanyID FROM company WHERE CompanyName = '" & company & "')," _
                        & " TypeID = (SELECT TypeID FROM type WHERE TypeName = '" & type & "')," _
                         & " LotNumberID = (SELECT LotNumberID FROM lotnumber WHERE LotNumber = '" & lotnumber & "')," _
                        & " UnitID = (SELECT UnitID FROM unit WHERE UnitName = '" & unit2 & "')"
            ExecuteQuery(query)
            MsgBox("Medicine successfully Registered!", vbInformation, "Saved")


            Me.Close()



            ViewProfile.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbDisconnect()
            clearText()

        End Try

    End Sub
    Sub clearText()
        txtAlertNum.Text = ""
        txtcode.Text = ""
        txtdescription.Text = ""
        txtMax.Text = ""
        txtname.Text = ""
        txtunit.Text = ""
        cbobrand.Text = ""
        cbocompany.Text = ""
        cbotype.Text = ""
        cbounit.Text = ""
        cbolotnumber.Text = ""
    End Sub

    Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        If rbYes.Checked = True Then
            txtAlertNum.Enabled = True
            alert = "Yes"
        Else
            txtAlertNum.Enabled = False
        End If
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        If rbNo.Checked = True Then
            txtAlertNum.Enabled = False
            alert = "No"
        Else
            txtAlertNum.Enabled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AddBrand.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AddUnit.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        AddCompany.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ViewType.Show()
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        AddLotNumber.Show()
    End Sub
    'Public Sub CheckforDoubleDot(tb As TextBox)
    '    Try
    '        Dim cntr As Integer = 0
    '        Dim theText As String = tb.Text
    '        Dim Letter As String
    '        Dim SelectionIndex As Integer = tb.SelectionStart
    '        Dim Change As Integer
    '        For x As Integer = 0 To tb.Text.Length - 1
    '            Letter = tb.Text.Substring(x, 1)
    '            If Letter = "." Then
    '                cntr = cntr + 1
    '            End If
    '            If cntr > 1 Then
    '                theText = ChangeSecondDot(tb.Text, x)
    '                Change = 1
    '            End If
    '        Next
    '        tb.Text = theText
    '        tb.Select(SelectionIndex - Change, 0)
    '        If tb.Text.Length = 1 Then
    '            If cntr = 1 Then
    '                tb.Text = "0."
    '                tb.Select(2, 0)
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub txtunit_TextChanged(sender As Object, e As EventArgs)

        'CheckforDoubleDot(txtunit)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtunit.TextChanged
        AllowedOnly(NumberWDot, txtunit)
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub

    Private Sub cbotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotype.SelectedIndexChanged

    End Sub

    Private Sub cbotype_TextChanged(sender As Object, e As EventArgs) Handles cbotype.TextChanged

        LoadSubCategory()
    End Sub

End Class