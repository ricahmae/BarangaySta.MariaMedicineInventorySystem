Imports MySql.Data.MySqlClient
Public Class AddUserAccount
    Dim userID As String
    Dim querry As String
    Dim suggestions As New AutoCompleteStringCollection()

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)
        If Trim(txtusername.Text) = "" Or Trim(txtfullname.Text) = "" Or Trim(txtconfirmpassword.Text) = "" Or Trim(txtpassword.Text) = "" Or Trim(cbousertype.Text) = "" Or Trim(cboanswer.Text) = "" Or Trim(cboquestion.Text) = "" Then
            MsgBox("Please fill out all fields", vbExclamation, "Warning!")
            Return
        End If
        save()
    End Sub

    Private Sub AddUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadQuestions()
    End Sub


    'Sub loadID()
    '    Try
    '        dbConnect()
    '        Dim query As String = "SELECT UserID from useraccount ORDER BY UserID DESC LIMIT 1"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                txtuserid.Text = "USER" & Val(Mid(reader.GetString(0), 4, 6)) + 1
    '            End While
    '        Else
    '            txtuserid.Text = "USR1001"
    '        End If
    '        dbDisconnect()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        disposeConnection()
    '    End Try
    'End Sub
    Public Sub save()

        Dim fullname As String = Trim(txtfullname.Text)
        Dim username As String = Trim(txtusername.Text)
        Dim confirmpassword As String = Trim(txtconfirmpassword.Text)
        Dim answer As String = Trim(cboanswer.Text)
        Dim usertype As String = Trim(cbousertype.Text)
        Dim Q As String = Trim(cboquestion.Text)
        If txtpassword.Text = txtconfirmpassword.Text Then
            dbConnect()
            Dim query = "INSERT INTO useraccount SET UserFullName = '" & fullname & "', Username= '" & username & "', Password = '" & confirmpassword & "', UserType='" & usertype & "', UserFlag= 'OFFLINE', UserStatus='ACTIVE', SecurityAnswer= '" & answer & "', ForgotPasswordID= (SELECT ForgotPasswordID from fpassword WHERE Question ='" & Q & "')"
            ExecuteQuery(query)
            MsgBox("User successfully Registered!", vbInformation, "Saved")
            dbDisconnect()
            clearText()
            ViewUsers.Show()
            ViewUsers.loadDataDisplay()

            Me.Close()
        Else
            MsgBox("Password must be identical!", vbExclamation, "Notice!")
            txtpassword.Focus()
            txtpassword.Text = ""
            txtconfirmpassword.Text = ""
        End If

    End Sub
    Sub loadQuestions()

        dbConnect()
        Dim query As String = "SELECT Question FROM fpassword WHERE Question  LIKE '%" & cboquestion.Text & "%' ORDER BY Question DESC"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboquestion.Items.Clear()
            While reader.Read
                cboquestion.Items.Add(reader.GetString("Question"))
            End While
        End If
        dbDisconnect()



    End Sub
    Sub clearText()
        txtfullname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtconfirmpassword.Text = ""
        cboquestion.Text = ""
        cboquestion.Text = ""
        cbousertype.Text = ""
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
        ViewUsers.Show()

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        save()

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub cboquestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboquestion.SelectedIndexChanged

    End Sub
End Class