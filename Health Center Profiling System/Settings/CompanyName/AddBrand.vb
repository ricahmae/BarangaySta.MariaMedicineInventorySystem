Public Class AddBrand
    Public brand As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub AddBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub check()
        Try
            dbConnect()


            Dim query = " SELECT BrandName FROM brand WHERE BrandName = '" & txtbrand.Text & "'"
            ExecuteQuery(query)
            MsgBox("BrandName Already Exit!", vbInformation, "Saved")

            txtbrand.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbDisconnect()

        End Try
    End Sub
    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try

            brand = txtbrand.Text
            dbConnect()


            Dim query = " SELECT BrandName FROM brand WHERE BrandName = '" & txtbrand.Text & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("BrandName Already Exist!", vbInformation, "Saved")
                dbDisconnect()
                txtbrand.Text = ""

            ElseIf Trim(txtbrand.Text) = "" Then
                MessageBox.Show("No Brand Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO brand SET BrandName='" & brand & "'"
                ExecuteQuery(query1)
                MsgBox("Medicine Brand Name Registered!", vbInformation, "Saved")
                dbDisconnect()
                Me.Close()
                AddProfile.loadbrand()

                AddProfile.cbobrand.Sorted = True
                AddProfile.cbobrand.SelectedIndex = AddProfile.cbobrand.FindString(brand)
                ViewBrand.ViewData()

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