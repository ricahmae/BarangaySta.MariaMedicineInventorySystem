Public Class NewPassword
    Private Sub NewPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String
        username = ForgotPassword.txtpassword.Text

        Dim query As String = "UPDATE useraccount SET Password = '" & txtconfirm.Text & "' WHERE Username = '" & username & "' "

        Try
            dbConnect()
            If Trim(Me.txtnewpassword.Text) = "" And Trim(Me.txtconfirm.Text) = "" Then
                MsgBox("Fill up your new password!")
                Me.txtnewpassword.Focus()

            ElseIf Trim(Me.txtconfirm.Text) = Trim(Me.txtnewpassword.Text) Then
                ExecuteQuery(query)
                MsgBox("Password succesfully updated", vbInformation, "SAVED")
                txtnewpassword.Text = ""
                txtconfirm.Text = ""
                HealthCenterMain.Show()

                Me.Hide()
                SecurityQuestion.txtanswer.Text = ""
                SecurityQuestion.txtquestion.Text = ""
                ForgotPassword.txtpassword.Text = ""
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub
End Class