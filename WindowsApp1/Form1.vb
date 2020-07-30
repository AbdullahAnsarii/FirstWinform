Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppData.Intro' table. You can move, or remove it, as needed.
        Me.IntroTableAdapter.Fill(Me.AppData.Intro)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Registration Succesfull....", "Abdullah Company")
    End Sub
End Class
