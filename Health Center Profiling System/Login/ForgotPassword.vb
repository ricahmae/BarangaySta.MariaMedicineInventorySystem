Public Class ForgotPassword
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim count As Integer = 0

        Try
            dbConnect()
            Dim query As String = "SELECT * FROM useraccount WHERE Username = '" & txtpassword.Text & "'"
            ExecuteQuery(query)
            While reader.Read
                count = count + 1
            End While

            dbDisconnect()

        Catch ex As Exception
            MsgBox("Something went wrong: " & ex.Message, vbCritical)
        Finally
            disposeConnection()
            If count = 1 Then
                SecurityQuestion.Show()
                SecurityQuestion.loadQuestion()
                Me.Hide()
            Else
                MsgBox("This username isn't registered.")
            End If
        End Try

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel4.Paint

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub
End Class