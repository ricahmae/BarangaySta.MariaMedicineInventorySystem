Public Class EditBrand
    Public brand As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub EditBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfullname.Text = ViewBrand.brandname
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            brand = Trim(txtfullname.Text)

            If Trim(txtfullname.Text) = "" Then
                MessageBox.Show("No Brand Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query = "UPDATE brand SET BrandName='" & txtfullname.Text & "' WHERE BrandID ='" & ViewBrand.brandid & "' "
                ExecuteQuery(query)
                MsgBox("Medicine Brand Name Updated!", vbInformation, "Saved")
                dbDisconnect()



            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            Me.Close()

            ViewBrand.ViewData()
            ViewBrand.Show()
        End Try

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class