Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 5 Then
            Label1.Text = "INITILIZING SYSTEM"
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "LOADING ALL COMPONENTS"
        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "INTEGRATING DATABASE"
        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "PLEASE WAIT"
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "WELCOME TO COFFEE MECHANICS "
            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Form2.ShowDialog()
                Me.Close()
            End If




        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pc1.Click







    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint



    End Sub
End Class