Public Class EditCompany
    Public comp As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            comp = txtfullname.Text

            If Trim(txtfullname.Text) = "" Then
                MessageBox.Show("No Company Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query = "UPDATE company SET CompanyName='" & comp & "'  WHERE CompanyID ='" & ViewCompany.comid & "'"
                ExecuteQuery(query)
                MsgBox("Medicine Company Name Updated!", vbInformation, "Saved")
                dbDisconnect()



            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
            Me.Close()

            ViewCompany.ViewData()
            ViewCompany.Show()
        End Try

    End Sub


    Private Sub EditCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfullname.Text = ViewCompany.comname2
    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub

    Private Sub txtfullname_TextChanged(sender As Object, e As EventArgs) Handles txtfullname.TextChanged

    End Sub
End Class