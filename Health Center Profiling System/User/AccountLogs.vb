Public Class AccountLogs
    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub


    Private Sub AccountLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
    End Sub

    Private Sub UserDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDG.CellContentClick

    End Sub
    Sub loadDataDisplay()
        Try
            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT * FROM userlogs,useraccount WHERE userlogs.UserID = useraccount.UserID ORDER BY DateTime ASC;"
            ExecuteQuery(sql)

            UserDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With UserDG
                    .Rows.Add(reader(0), reader("UserFullName"), reader(1), reader(3))
                End With
            End While
            reader.Close()
            UserDG.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub
End Class