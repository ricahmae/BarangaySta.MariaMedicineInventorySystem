Public Class AddSubType
    Public subt As String
    Public subtn As String
    Private Sub AddSubType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttypeid.Text = ViewType.tid
    End Sub

    Private Sub btnsaveacount_Click(sender As Object, e As EventArgs) Handles btnsaveacount.Click
        Try
            txttypeid.Text = ViewType.tid
            subt = txttypeid.Text
            subtn = ViewType.tid
            dbConnect()


            Dim query = " SELECT UnitName FROM unit WHERE UnitName = '" & txttype.Text & "' AND TypeID='" & subtn & "'"
            ExecuteQuery(query)
            If reader.Read = True Then
                MsgBox("SubType Name Already Exist!", vbInformation)
                dbDisconnect()
                txttype.Text = ""
            ElseIf Trim(txttype.Text) = "" Then
                MessageBox.Show("No SubType Name.", "Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                dbConnect()


                Dim query1 = "INSERT INTO unit SET UnitName='" & txttype.Text & "', TypeID ='" & subtn & "'"
                ExecuteQuery(query1)
                MsgBox("Medicine SubType Name Registered!", vbInformation, "Saved")
                dbDisconnect()

                Me.Close()

                ViewType.ViewData()
                AddProfile.loadtype()

                'AddProfile.cbotype.Sorted = True
                'AddProfile.cbotype.SelectedIndex = AddProfile.cbotype.FindString(Type)
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()

        End Try
    End Sub
End Class