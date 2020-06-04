Public Class EditLotNumber
    Public lotn As String
    Private Sub EditLotNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbrand.Text = ViewLotNumber.lname
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            lotn = txtbrand.Text

            If Trim(txtbrand.Text) = "" Then
                MessageBox.Show("No Company Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query = "UPDATE lotnumber SET LotNumber='" & lotn & "'  WHERE LotNumberID ='" & ViewLotNumber.lid & "'"
                ExecuteQuery(query)
                MsgBox("Medicine Lot Number Updated!", vbInformation, "Saved")
                dbDisconnect()



            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
            Me.Close()

            ViewLotNumber.ViewData()
            ViewLotNumber.Show()
        End Try

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class