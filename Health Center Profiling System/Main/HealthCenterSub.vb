Public Class HealthCenterSub
    Private Sub HealthCenterSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        SearchQ.Show()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Issuance.Show()
    End Sub
    Sub loadDataDisplay1()
        Try


            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "SELECT *,(SELECT UnitName from unit WHERE unit.UnitID=profilemedicine.UnitID) as UnitName from profilemedicine WHERE Notification = 'NotRead' AND AlertNo ='Yes'"
            ExecuteQuery(sql)

            DMenu.gvStocks.Rows.Clear()
            While reader.Read()
                i = i + 1
                With DMenu.gvStocks
                    If reader.GetString("Quantity") <= reader.GetString("QuantityToAlert") / 100 * reader.GetString("Max") Then 'reader.GetString("Total") * (reader.GetString("QuantityToAlert") / 100) Then
                        .Rows.Add(reader(0), i, reader(2), reader.GetString("MEdicineUnit") + reader.GetString("UnitName"), reader.GetString("Quantity"), "STOCKIN", "MARK AS READ")
                        .Rows(.RowCount - 1).Cells(4).Style.ForeColor = Color.Red
                    End If
                End With
            End While
            reader.Close()
            DMenu.gvStocks.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Sub loadDataDisplay()
        Try


            Dim sql As String
            Dim i As Integer = 0
            dbConnect()
            sql = "Select *,(SELECT MedicineName from profilemedicine WHERE profilemedicine.MedicineID = expiry.MedicineID) as name FROM expiry WHERE DATEDIFF (Now(),DOE) <= 7 AND NotificationE = 'NotRead' AND QuantityE > 0 AND AlertNo ='Yes' ORDER BY DOE DESC "
            ExecuteQuery(sql)

            DMenu.ExpiryDG.Rows.Clear()
            While reader.Read()
                i = i + 1
                With DMenu.ExpiryDG

                    .Rows.Add(reader(1), i, reader("name"), Date.Parse(reader("DOE")).ToShortDateString(), reader("QuantityE"), "MARK AS READ")
                    .Rows(.RowCount - 1).Cells(4).Style.ForeColor = Color.Red
                End With
            End While
            reader.Close()
            DMenu.ExpiryDG.ClearSelection()

            dbDisconnect()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Dashboard_Paint(sender As Object, e As PaintEventArgs) Handles Dashboard.Paint

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If (MessageBox.Show("Are you sure to Logout?", "Logout from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            Try
                dbConnect()
                Dim query As String = "INSERT INTO userlogs SET UserID = (SELECT UserID FROM useraccount WHERE UserFullName= '" & txtuser.Text & "' AND UserStatus<>'DELETED'),Action = 'Logout'"
                ExecuteQuery(query)
                dbDisconnect()
                dbConnect()
                Dim query1 As String = "UPDATE useraccount SET UserFlag = 'OFFLINE' WHERE UserFullName = '" & txtuser.Text & "' AND UserStatus<>'DELETED'"
                ExecuteQuery(query1)
                dbDisconnect()
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()
            End Try
            FormLogin.txtusername.Text = ""
            FormLogin.txtpassword.Text = ""
            FormLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        With DMenu
            .TopLevel = False
            Dashboard.Controls.Add(DMenu)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, yyyy-M-d")
        loadDataDisplay()
        loadDataDisplay1()

    End Sub
End Class