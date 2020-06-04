Public Class AddCompany
    Public company As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            company = txtcompany.Text
            dbConnect()


            Dim query = " SELECT CompanyName FROM company WHERE CompanyName = '" & txtcompany.Text & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("Company Name Already Exist!", vbInformation)
                dbDisconnect()
                txtcompany.Text = ""
            ElseIf Trim(txtcompany.Text) = "" Then
                MessageBox.Show("No Company Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO company SET CompanyName='" & company & "'"
                ExecuteQuery(query1)
                MsgBox("Medicine Company Name Registered!", vbInformation, "Saved")
                dbDisconnect()
                Me.Close()
                ViewCompany.ViewData()
                AddProfile.loadcompany()

                AddProfile.cbocompany.Sorted = True
                AddProfile.cbocompany.SelectedIndex = AddProfile.cbocompany.FindString(company)

            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()

        End Try
    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class