Public Class EditUnit
    Public u As String
    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            u = txtfullname.Text

            If Trim(txtfullname.Text) = "" Then
                MessageBox.Show("No Unit Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query = "UPDATE unit SET UnitName='" & u & "' WHERE UnitID ='" & ViewUnit.uid & "'"
                ExecuteQuery(query)
                MsgBox("Medicine Unit Name Updated!", vbInformation, "Saved")
                dbDisconnect()



            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
            Me.Close()

            ViewUnit.ViewData()
            ViewUnit.Show()
        End Try

    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub EditUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfullname.Text = ViewUnit.uname
    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class