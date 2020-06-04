Public Class AddType
    Public type As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            type = txttype.Text
            dbConnect()


            Dim query = " SELECT TypeName FROM type WHERE TypeName = '" & txttype.Text & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("Type Name Already Exist!", vbInformation)
                dbDisconnect()
                txttype.Text = ""
            ElseIf Trim(txttype.Text) = "" Then
                MessageBox.Show("No Type Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO type SET TypeName='" & type & "'"
                ExecuteQuery(query1)
                MsgBox("Medicine Type Name Registered!", vbInformation, "Saved")
                dbDisconnect()

                Me.Close()

                ViewType.ViewData()
                AddProfile.loadtype()

                AddProfile.cbotype.Sorted = True
                AddProfile.cbotype.SelectedIndex = AddProfile.cbotype.FindString(type)
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

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub
End Class