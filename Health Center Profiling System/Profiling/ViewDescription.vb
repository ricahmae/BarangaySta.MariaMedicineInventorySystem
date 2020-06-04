Public Class ViewDescription
    Private Sub ViewDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdescription.Text = ViewProfile.desc
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub
End Class