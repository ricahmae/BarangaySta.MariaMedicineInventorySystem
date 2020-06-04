Public Class EditType
    Public t As String
    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            t = txtfullname.Text

            If Trim(txtfullname.Text) = "" Then
                MessageBox.Show("No Type Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query = "UPDATE type SET TypeName='" & t & "'  WHERE TypeID ='" & ViewType.tid & "'"
                ExecuteQuery(query)
                MsgBox("Medicine Type Name Updated!", vbInformation, "Saved")
                dbDisconnect()



            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
            Me.Close()

            ViewType.ViewData()
            ViewType.Show()
        End Try

    End Sub

    Private Sub EditType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfullname.Text = ViewType.tname
    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class