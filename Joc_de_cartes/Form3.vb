Public Class Form3

    Dim intPic As Integer

    Dim contador As Integer

    Dim pickedImg As New List(Of Integer)

    Private timeLeft As Integer

    Dim valor_tag_1 As Integer

    Dim valor_tag_2 As Integer

    Dim carta_clicada As Boolean

    Dim parelles_encertades As Integer

    Dim primeracarta As PictureBox

    Dim segonacarta As PictureBox

    Dim puntuacio As Integer

    Dim puntuacio_text As String

    Dim puntuacio_global_text As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

        ProgressBar1.Visible = False
        ProgressBar1.Value = 450

        PictureBox0.Image = revers.Image
        PictureBox1.Image = revers.Image
        PictureBox2.Image = revers.Image
        PictureBox3.Image = revers.Image
        PictureBox4.Image = revers.Image
        PictureBox5.Image = revers.Image
        PictureBox6.Image = revers.Image
        PictureBox7.Image = revers.Image
        PictureBox8.Image = revers.Image
        PictureBox9.Image = revers.Image
        PictureBox10.Image = revers.Image
        PictureBox11.Image = revers.Image
        PictureBox12.Image = revers.Image
        PictureBox13.Image = revers.Image
        PictureBox14.Image = revers.Image
        PictureBox15.Image = revers.Image

        PictureBox0.Enabled = False
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False
        PictureBox10.Enabled = False
        PictureBox11.Enabled = False
        PictureBox12.Enabled = False
        PictureBox13.Enabled = False
        PictureBox14.Enabled = False
        PictureBox15.Enabled = False


    End Sub

    Private Sub SortirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button1.Enabled = False

        timeLeft = 2

        Timer1_Tick()

        For Each ctlControl In Me.Controls

            If TypeName(ctlControl) = "PictureBox" Then

                chooseImg()

                ctlControl.image = ImageList_lv2.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

        Next ctlControl
    End Sub

    Sub chooseImg()

        Dim rand As New Random

        intPic = rand.Next(0, 16)

        If pickedImg.Contains(intPic) Then

            While (pickedImg.Contains(intPic))

                intPic = rand.Next(0, 16)

            End While

            pickedImg.Add(intPic)

        Else

            pickedImg.Add(intPic)

        End If

    End Sub

    Private Sub Timer1_Tick() Handles Timer1.Tick

        Timer1.Enabled = True

        If timeLeft > 0 Then

            timeLeft -= 1

        Else

            Timer1.Stop()

            PictureBox0.Enabled = True
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True

            PictureBox0.Image = revers.Image
            PictureBox1.Image = revers.Image
            PictureBox2.Image = revers.Image
            PictureBox3.Image = revers.Image
            PictureBox4.Image = revers.Image
            PictureBox5.Image = revers.Image
            PictureBox6.Image = revers.Image
            PictureBox7.Image = revers.Image
            PictureBox8.Image = revers.Image
            PictureBox9.Image = revers.Image
            PictureBox10.Image = revers.Image
            PictureBox11.Image = revers.Image
            PictureBox12.Image = revers.Image
            PictureBox13.Image = revers.Image
            PictureBox14.Image = revers.Image
            PictureBox15.Image = revers.Image

            ProgressBar1.Visible = True

            puntuacio = 45

            Timer3_Tick()

        End If

    End Sub

    Private Sub Timer2_Tick() Handles Timer2.Tick

        Timer2.Enabled = True

        If timeLeft > 0 Then

            timeLeft -= 1

            PictureBox0.Enabled = False
            PictureBox1.Enabled = False
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox8.Enabled = False
            PictureBox9.Enabled = False
            PictureBox10.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False

        Else

            Timer2.Stop()

            carta_clicada = False

            primeracarta.Image = revers.Image

            segonacarta.Image = revers.Image

            PictureBox0.Enabled = True
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True

        End If

    End Sub

    Private Sub Timer3_Tick() Handles Timer3.Tick

        Timer3.Enabled = True

        puntuacio -= 1

        ProgressBar1.Value -= 10

        If ProgressBar1.Value = 0 Then

            Timer3.Stop()

            MessageBox.Show("Has perdut...")

            End

        End If

    End Sub

    Private Sub Carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox0.Click, PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox4.Click, PictureBox9.Click, PictureBox15.Click, PictureBox14.Click, PictureBox13.Click, PictureBox12.Click, PictureBox11.Click, PictureBox10.Click, PictureBox5.Click

        Dim aquesta As PictureBox = DirectCast(sender, PictureBox)

        If sender Is aquesta Then

            If sender.Tag = 100 Then

                aquesta.Enabled = False

            Else

                If carta_clicada = False Then

                    primeracarta = aquesta

                    aquesta.Enabled = False

                    valor_tag_1 = sender.Tag

                    sender.Image = ImageList_lv2.Images.Item(sender.Tag)

                    carta_clicada = True

                Else

                    segonacarta = aquesta

                    valor_tag_2 = sender.Tag

                    sender.Image = ImageList_lv2.Images.Item(sender.Tag)

                    If ((valor_tag_1 = 0 And valor_tag_2 = 8) Or (valor_tag_1 = 1 And valor_tag_2 = 9) Or (valor_tag_1 = 2 And valor_tag_2 = 10) Or (valor_tag_1 = 3 And valor_tag_2 = 11) Or (valor_tag_1 = 4 And valor_tag_2 = 12) Or (valor_tag_1 = 5 And valor_tag_2 = 13) Or (valor_tag_1 = 6 And valor_tag_2 = 14) Or (valor_tag_1 = 7 And valor_tag_2 = 15) Or (valor_tag_1 = 8 And valor_tag_2 = 0) Or (valor_tag_1 = 9 And valor_tag_2 = 1) Or (valor_tag_1 = 10 And valor_tag_2 = 2) Or (valor_tag_1 = 11 And valor_tag_2 = 3) Or (valor_tag_1 = 12 And valor_tag_2 = 4) Or (valor_tag_1 = 13 And valor_tag_2 = 5) Or (valor_tag_1 = 14 And valor_tag_2 = 6) Or (valor_tag_1 = 15 And valor_tag_2 = 7)) Then

                        parelles_encertades += 1

                        primeracarta.Tag = 100

                        segonacarta.Tag = 100

                        If parelles_encertades = 8 Then

                            Timer3.Stop()

                            puntuacio_text = puntuacio

                            puntuacio_global = puntuacio_global + puntuacio

                            puntuacio_global_text = puntuacio_global

                            MessageBox.Show("HAS GUANYAT EL SEGON NIVELL!" + vbCrLf + vbCrLf + "Has aconseguit " + puntuacio_text + " punts!" + vbCrLf + vbCrLf + "La teva puntuació total es de " + puntuacio_global_text + " punts!")

                            Me.Hide()

                            Form4.Show()

                        End If

                        carta_clicada = False

                    Else

                        timeLeft = 1

                        Timer2_Tick()

                    End If

                End If

            End If

        End If

    End Sub

End Class