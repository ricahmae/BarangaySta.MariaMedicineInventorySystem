Public Class ViewUsers
    Dim userID As String
    Public userid2 As String

    Public fname As String
    Public username As String
    Public usertype As String



    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub

    Private Sub GunaPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        AddUserAccount.Show()
        Me.Hide()
    End Sub

    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM useraccount ORDER BY UserID ASC;"
            ExecuteQuery(sql)

            UserDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With UserDG
                    .Rows.Add(reader(0), i, reader(3), reader(1), reader(4), "Edit", "Delete")
                End With
            End While
            reader.Close()
            UserDG.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UserDG_Click(sender As Object, e As EventArgs) Handles UserDG.Click

    End Sub

    Private Sub ViewUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
    End Sub

    Private Sub UserDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDG.CellContentClick
        If e.ColumnIndex = 5 Then

            Try
                dbConnect()
                Dim query As String = "SELECT * FROM useraccount WHERE UserID = '" & UserDG.SelectedRows(0).Cells(0).Value & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        fname = reader.GetString(6)
                        username = reader.GetString(2)
                        usertype = reader.GetString(1)
                    End While
                End If
                dbDisconnect()
                EditUserAccount.Show()
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()
            End Try

        ElseIf e.ColumnIndex = 6 Then

            Try
                dbConnect()
                If MessageBox.Show("Are you sure you want to delete the account ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM useraccount WHERE UserID = '" & UserDG.SelectedRows(0).Cells(0).Value & "'"
                    ExecuteQuery(query)
                    MsgBox("User Account successfully Removed!", vbInformation, "Deleted")
                    loadDataDisplay()
                Else


                End If


                dbDisconnect()
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()
            End Try
        End If
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Search(txtsearch.Text)
    End Sub
    Sub Search(keyword As String)
        UserDG.Rows.Clear()
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "Select * FROM useraccount WHERE Username LIKE '%" & keyword & "%' OR UserType LIKE '%" & keyword & "%' OR UserFullName LIKE '%" & keyword & "%' ORDER BY Username,UserType,UserFullName DESC"
            ExecuteQuery(query)

            If reader.HasRows Then
                i = i + 1
                While reader.Read
                    With UserDG
                        .Rows.Add(reader("UserID"), i, reader("UserFullName"), reader("Username"),
                                  reader("UserType"), "Edit", "Delete")
                    End With

                End While
                dbDisconnect()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel2.Paint

    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel4.Paint

    End Sub

    Private Sub GunaShadowPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()

    End Sub
End Class