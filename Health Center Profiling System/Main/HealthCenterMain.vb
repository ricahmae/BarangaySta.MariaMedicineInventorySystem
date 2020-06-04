Imports MySql.Data.MySqlClient

Public Class HealthCenterMain
    Private Connection As New MySqlConnection
    Public Shared dtServer As Date = DateTime.Now

    Private Sub GunaLinePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel1.Paint

    End Sub

    Private Sub HealthCenterMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaPanel1, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnrecords, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnuseraccounts, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnsettings, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnillnessentry, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnstatistics, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        txtuser.Text = FormLogin.user

        loadDataDisplay1()
        loadDataDisplay()
        With DMenu
            .TopLevel = False
            Dashboard.Controls.Add(DMenu)
            .BringToFront()
            .Show()
        End With
        tsTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, yyyy-M-d")

        loadexpiry()
    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel2.Paint

    End Sub

    Private Sub btnuseraccounts_Click(sender As Object, e As EventArgs) Handles btnuseraccounts.Click
        With Account
            .TopLevel = False
            Dashboard.Controls.Add(Account)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnrecords_Click(sender As Object, e As EventArgs) Handles btnrecords.Click
        With ProfileMenu
            .TopLevel = False
            Dashboard.Controls.Add(ProfileMenu)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs)
        ViewUsers.Show()
        Me.Hide()
    End Sub

    Private Sub btnstatistics_Click(sender As Object, e As EventArgs) Handles btnstatistics.Click
        With StatisticsMenu
            .TopLevel = False
            Dashboard.Controls.Add(StatisticsMenu)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnprofiles_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        With SettingMenu
            .TopLevel = False
            Dashboard.Controls.Add(SettingMenu)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnillnessentry_Click(sender As Object, e As EventArgs) Handles btnillnessentry.Click
        With InventoryMenu
            .TopLevel = False
            Dashboard.Controls.Add(InventoryMenu)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaTileButton3_Click(sender As Object, e As EventArgs)
        AccountLogs.Show()
    End Sub

    Private Sub GunaTileButton6_Click(sender As Object, e As EventArgs)
        Stockin.Show()

    End Sub

    Private Sub GunaTileButton5_Click(sender As Object, e As EventArgs)
        AddStock.Show()
    End Sub

    Private Sub GunaTileButton4_Click(sender As Object, e As EventArgs)
        AddStockout.Show()
    End Sub

    Private Sub GunaTileButton12_Click(sender As Object, e As EventArgs)
        ViewStocks.Show()
    End Sub

    Private Sub GunaTileButton11_Click(sender As Object, e As EventArgs)
        StockHistory.Show()
    End Sub

    Private Sub GunaTileButton6_Click_1(sender As Object, e As EventArgs)
        ViewStocks.Show()
    End Sub

    Private Sub GunaTileButton5_Click_1(sender As Object, e As EventArgs)
        AddStock.Show()
    End Sub

    Private Sub GunaTileButton7_Click(sender As Object, e As EventArgs)
        AddStockout.Show()
    End Sub

    Private Sub GunaTileButton12_Click_1(sender As Object, e As EventArgs)
        Stockin.Show()
    End Sub

    Private Sub GunaTileButton11_Click_1(sender As Object, e As EventArgs)
        StockHistory.Show()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs)
        With ReportMenu
            .TopLevel = False
            Dashboard.Controls.Add(ReportMenu)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Dashboard.Paint

    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click

    End Sub
    Sub loadexpiry()

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

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Dashboard.Show()
    End Sub

    Private Sub UserDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click

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


    Private Sub gvStocks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        With DMenu
            .TopLevel = False
            Dashboard.Controls.Add(DMenu)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ToolStripStatusLabel12_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel12.Click

    End Sub

    Private Sub ssMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ssMain.ItemClicked

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, yyyy-M-d")
        loadDataDisplay()
        loadDataDisplay1()
        loadexpiry()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        'With SearchQ
        '    .TopLevel = False
        '    Dashboard.Controls.Add(SearchQ)
        '    .BringToFront()
        '    .Show()
        'End With
        SearchQ.Show()
    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub
End Class