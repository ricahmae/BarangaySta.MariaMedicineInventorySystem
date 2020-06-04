Public Class EditReceived
    Public receivedf As String
    Private Sub EditReceived_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtreceived.Text = ViewReceived.rname
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            receivedf = txtreceived.Text

            If Trim(txtreceived.Text) = "" Then
                MessageBox.Show("No Received From.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query = "UPDATE receivedfrom SET ReceiveName='" & receivedf & "'  WHERE ReceivedFromID ='" & ViewReceived.rid & "'"
                ExecuteQuery(query)
                MsgBox("Medicine Received From Updated!", vbInformation, "Saved")
                dbDisconnect()



            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
            Me.Close()

            ViewReceived.ViewData()
            ViewReceived.Show()
        End Try

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class