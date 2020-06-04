Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text
Public Class FormLogin
    Dim flag As Boolean = True
    Public user As String
    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim usr As String = txtusername.Text
        Dim pwd As String = txtpassword.Text

        If Trim(usr) = "" Or Trim(pwd) = "" Then
            MsgBox("Please fill out all fields!", vbExclamation, "Warning!")
        Else
            Try
                Dim flag As Integer = 0
                dbConnect()
                Dim query As String = "SELECT * FROM useraccount WHERE Username = @username AND Password = @password"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@username", usr)
                command.Parameters.AddWithValue("@password", pwd)

                reader = command.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    If reader.Item("UserType") = "Admin" Then
                        If reader.Item("UserFlag") = "ONLINE" Then
                            MsgBox("Log out the account from another PC first then log in. Or you can ask the admin to reset your account to re log in.", vbInformation, "This user is currently online!")

                            Exit Sub
                        ElseIf reader.Item("UserFlag") = "OFFLINE" Then
                            user = reader.GetString("UserFullName")


                            flag = 1
                            HealthCenterMain.Show()

                            Me.Hide()
                        End If



                        dbDisconnect()
                    ElseIf reader.Item("UserType") = "Healthcare Practitioner" Then
                        If reader.Item("UserFlag") = "ONLINE" Then
                            MsgBox("Log out the account from another PC first then log in. Or you can ask the admin to reset your account to re log in.", vbInformation, "This user is currently online!")

                            Exit Sub
                        ElseIf reader.Item("UserFlag") = "OFFLINE" Then
                            user = reader.GetString("UserFullName")


                            flag = 1
                            HealthCenterSub.Show()

                            Me.Hide()
                        End If



                        dbDisconnect()
                    End If
                Else
                    MsgBox("User is not registered", vbExclamation, "Access Denied!")

                End If



                If flag = 1 Then
                    'logs/tracks the user time in and out
                    dbConnect()
                    Dim query1 As String = "INSERT INTO userlogs SET UserID = (SELECT UserID FROM useraccount WHERE Username= '" & usr & "' AND UserStatus<>'DELETED'),Action = 'Login'"
                    ExecuteQuery(query1)
                    dbDisconnect()
                    'if the user is online, this will mark the user as is on DB
                    dbConnect()
                    Dim query3 As String = "UPDATE useraccount SET UserFlag = 'ONLINE' WHERE Username = '" & usr & "' AND UserStatus<>'DELETED'"
                    ExecuteQuery(query3)
                    dbDisconnect()
                ElseIf flag = 2 Then
                    'logs/tracks the user time in and out
                    dbConnect()
                    Dim query1 As String = "INSERT INTO userlogs SET UserID = (SELECT UserID FROM useraccount WHERE Username= '" & usr & "' AND UserStatus<>'DELETED'),Action = 'Login'"
                    ExecuteQuery(query1)
                    dbDisconnect()
                    'if the user is online, this will mark the user as is on DB
                    dbConnect()
                    Dim query4 As String = "UPDATE useraccount SET UserFlag = 'ONLINE' WHERE Username = '" & usr & "' AND UserStatus<>'DELETED'"
                    ExecuteQuery(query4)
                    dbDisconnect()
                End If

            Catch

            End Try

        End If

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub

    Private Sub linkForget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForget.LinkClicked
        ForgotPassword.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim obj As New frmconnection
        obj.ShowDialog()
    End Sub
End Class
