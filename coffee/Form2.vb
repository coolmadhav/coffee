Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = uname.Text
        password = pass.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            Form6.Show()


        Else
            MessageBox.Show(" USERNAME AND PASSWORD IS INCORRECT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.ShowDialog()

    End Sub
End Class