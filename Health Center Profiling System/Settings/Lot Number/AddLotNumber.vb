Public Class AddLotNumber
    Public lot As String
    Private Sub AddLotNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            lot = txtlotnumber.Text
            dbConnect()


            Dim query = " SELECT LotNumber FROM lotnumber WHERE Lotnumber = '" & txtlotnumber.Text & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("Lot Number Already Exist!", vbInformation)
                dbDisconnect()
                txtlotnumber.Text = ""
            ElseIf Trim(txtlotnumber.Text) = "" Then
                MessageBox.Show("No Lot Number.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO lotnumber SET LotNumber='" & lot & "'"
                ExecuteQuery(query1)
                MsgBox("Lot Number Registered!", vbInformation, "Saved")
                dbDisconnect()

                Me.Close()
                AddProfile.loadlot()

                AddProfile.cbolotnumber.Sorted = True
                AddProfile.cbolotnumber.SelectedIndex = AddProfile.cbolotnumber.FindString(lot)
                ViewLotNumber.ViewData()
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()



        End Try

    End Sub

    Private Sub btncancelaccount_Click(sender As Object, e As EventArgs) Handles btncancelaccount.Click
        Me.Close()
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub
End Class