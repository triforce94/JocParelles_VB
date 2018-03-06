Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        PictureBox0.Image = ImageList_back.Images(0)
        PictureBox1.Image = ImageList_back.Images(1)
        PictureBox2.Image = ImageList_back.Images(2)
        PictureBox3.Image = ImageList_back.Images(3)

    End Sub

    Private Sub PictureBox0_Click(sender As Object, e As EventArgs) Handles PictureBox0.Click
        revers.Image = ImageList_back.Images(0)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        revers.Image = ImageList_back.Images(1)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        revers.Image = ImageList_back.Images(2)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        revers.Image = ImageList_back.Images(3)
        Me.Hide()
        Form2.Show()
    End Sub
End Class
