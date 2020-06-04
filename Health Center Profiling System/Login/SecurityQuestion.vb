Public Class SecurityQuestion
    Dim username As String = ForgotPassword.txtpassword.Text
    Dim count As Integer = 0
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim answer As New TextBox
        Try
            dbConnect()
            Dim query As String = "SELECT SecurityAnswer FROM useraccount WHERE Username = '" & username & "' "
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    answer.Text = reader.GetString(0)
                End While
                If answer.Text = txtanswer.Text Then
                    Me.Hide()
                    NewPassword.Show()
                Else
                    MsgBox("Wrong Answer")
                End If
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub SecurityQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub loadQuestion()
        Try
            dbConnect()

            Dim query As String = "SELECT Question FROM fpassword, useraccount WHERE Username = '" & username & "' "
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtquestion.Text = reader.GetString(0)
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtanswer.TextChanged

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub
End Class