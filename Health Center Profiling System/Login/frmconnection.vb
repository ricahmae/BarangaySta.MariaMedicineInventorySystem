Imports System.Windows.Forms
Public Class frmconnection
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim str As String = "Server=" & txtHost.Text & ";Database=" & txtDb.Text & ";User=" & txtUserName.Text _
                                             & ";Password=" & txtPw.Text & ";"
        If TestConnection(str) = True Then
            If MessageBox.Show("A new connection has been successfully established. Do you want to save the connection?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Settings.DatabaseName = txtDb.Text
                My.Settings.ServerIP = txtHost.Text

                My.Settings.Username = txtUserName.Text
                My.Settings.Password = txtPw.Text
                My.Settings.Save()
                txtDb.Clear()
                txtHost.Clear()

                txtPw.Clear()
                txtUserName.Clear()
            End If
        Else
            MessageBox.Show("Connection failed. Please review connection fields.",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub
End Class