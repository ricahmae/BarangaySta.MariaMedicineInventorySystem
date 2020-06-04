Public Class ReceivedFrom
    Public received As String
    Private Sub ReceivedFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            received = txtreceived.Text
            dbConnect()


            Dim query = " SELECT ReceiveName FROM receivedfrom WHERE ReceiveName = '" & txtreceived.Text & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("Received From Already Exist!", vbInformation)
                dbDisconnect()
                txtreceived.Text = ""
            ElseIf Trim(txtreceived.Text) = "" Then
                MessageBox.Show("No Selected Received From .", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO receivedfrom SET ReceiveName='" & received & "'"
                ExecuteQuery(query1)
                MsgBox("Received From Registered!", vbInformation, "Saved")
                dbDisconnect()


                Me.Close()
                ViewReceived.ViewData()
                AddStock.loadreceived()

                AddStock.cboreceived.Sorted = True
                AddStock.cboreceived.SelectedIndex = AddStock.cboreceived.FindString(received)
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