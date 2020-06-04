Public Class AddUnit
    Public unit As String
    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            unit = txtUnit.Text
            dbConnect()


            Dim query = " SELECT UnitName FROM unit WHERE UnitName = '" & txtUnit.Text & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("Unit Name Already Exist!", vbInformation)
                dbDisconnect()
                txtUnit.Text = ""
            ElseIf Trim(txtUnit.Text) = "" Then
                MessageBox.Show("No Unit Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO unit SET UnitName='" & unit & "'"
                ExecuteQuery(query1)
                MsgBox("Medicine Unit Name Registered!", vbInformation, "Saved")
                dbDisconnect()
                Me.Close()
                ViewUnit.ViewData()

                AddProfile.loadunit()

                AddProfile.cbounit.Sorted = True
                AddProfile.cbounit.SelectedIndex = AddProfile.cbounit.FindString(unit)

            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()


        End Try
    End Sub

    Private Sub txtfullname_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged

    End Sub

    Private Sub AddUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub
End Class