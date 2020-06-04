Public Class EditUserAccount
    Private Sub EditUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfullname.Text = ViewUsers.fname
        txtusername.Text = ViewUsers.username
        cbousertype.Text = ViewUsers.usertype
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub

    Private Sub btnsaveacount_Click_1(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            dbConnect()
            Dim query As String = "UPDATE useraccount SET Username = '" & txtusername.Text & "', " _
                & "  UserFullName = '" & txtfullname.Text & "', " _
                & " UserType = '" & cbousertype.Text & "'  "
            ExecuteQuery(query)
            MsgBox("User successfully Updated!", vbInformation, "Updated")
            Me.Close()
            dbDisconnect()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()

        End Try

        ViewUsers.loadDataDisplay()
    End Sub
End Class