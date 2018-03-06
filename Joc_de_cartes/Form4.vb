Public Class Form4

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
        ProgressBar1.Value = 600

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
        PictureBox16.Image = revers.Image
        PictureBox17.Image = revers.Image
        PictureBox18.Image = revers.Image
        PictureBox19.Image = revers.Image
        PictureBox20.Image = revers.Image
        PictureBox21.Image = revers.Image
        PictureBox22.Image = revers.Image
        PictureBox23.Image = revers.Image

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
        PictureBox16.Enabled = False
        PictureBox17.Enabled = False
        PictureBox18.Enabled = False
        PictureBox19.Enabled = False
        PictureBox20.Enabled = False
        PictureBox21.Enabled = False
        PictureBox22.Enabled = False
        PictureBox23.Enabled = False


    End Sub

    Private Sub SortirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Button1.Visible = False
        Button1.Enabled = False

        timeLeft = 2

        Timer1_Tick()

        For Each ctlControl In Me.Controls

            If TypeName(ctlControl) = "PictureBox" Then

                chooseImg()

                ctlControl.image = ImageList_lv3.Images.Item(intPic)

                ctlControl.Tag = intPic

            End If

        Next ctlControl

    End Sub

    Sub chooseImg()

        Dim rand As New Random

        intPic = rand.Next(0, 24)

        If pickedImg.Contains(intPic) Then

            While (pickedImg.Contains(intPic))

                intPic = rand.Next(0, 24)

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
            PictureBox16.Enabled = True
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True


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
            PictureBox16.Image = revers.Image
            PictureBox17.Image = revers.Image
            PictureBox18.Image = revers.Image
            PictureBox19.Image = revers.Image
            PictureBox20.Image = revers.Image
            PictureBox21.Image = revers.Image
            PictureBox22.Image = revers.Image
            PictureBox23.Image = revers.Image

            ProgressBar1.Visible = True

            puntuacio = 60

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
            PictureBox16.Enabled = False
            PictureBox17.Enabled = False
            PictureBox18.Enabled = False
            PictureBox19.Enabled = False
            PictureBox20.Enabled = False
            PictureBox21.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False

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
            PictureBox16.Enabled = True
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True

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

    Private Sub Carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox0.Click, PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox4.Click, PictureBox9.Click, PictureBox15.Click, PictureBox14.Click, PictureBox13.Click, PictureBox12.Click, PictureBox11.Click, PictureBox10.Click, PictureBox5.Click, PictureBox23.Click, PictureBox22.Click, PictureBox17.Click, PictureBox21.Click, PictureBox16.Click, PictureBox20.Click, PictureBox19.Click, PictureBox18.Click

        Dim aquesta As PictureBox = DirectCast(sender, PictureBox)

        If sender Is aquesta Then

            If sender.Tag = 100 Then

                aquesta.Enabled = False

            Else

                If carta_clicada = False Then

                    primeracarta = aquesta

                    If sender Is PictureBox22 Then

                        EasterEggToolStripMenuItem.Visible = True

                        EasterEggToolStripMenuItem.Enabled = True

                    Else

                        EasterEggToolStripMenuItem.Visible = False

                        EasterEggToolStripMenuItem.Enabled = False

                    End If

                    aquesta.Enabled = False

                    valor_tag_1 = sender.Tag

                    sender.Image = ImageList_lv3.Images.Item(sender.Tag)

                    carta_clicada = True

                Else

                    EasterEggToolStripMenuItem.Visible = False

                    EasterEggToolStripMenuItem.Enabled = False

                    segonacarta = aquesta

                    valor_tag_2 = sender.Tag

                    sender.Image = ImageList_lv3.Images.Item(sender.Tag)

                    If ((valor_tag_1 = 0 And valor_tag_2 = 12) Or (valor_tag_1 = 1 And valor_tag_2 = 13) Or (valor_tag_1 = 2 And valor_tag_2 = 14) Or (valor_tag_1 = 3 And valor_tag_2 = 15) Or (valor_tag_1 = 4 And valor_tag_2 = 16) Or (valor_tag_1 = 5 And valor_tag_2 = 17) Or (valor_tag_1 = 6 And valor_tag_2 = 18) Or (valor_tag_1 = 7 And valor_tag_2 = 19) Or (valor_tag_1 = 8 And valor_tag_2 = 20) Or (valor_tag_1 = 9 And valor_tag_2 = 21) Or (valor_tag_1 = 10 And valor_tag_2 = 22) Or (valor_tag_1 = 11 And valor_tag_2 = 23) Or (valor_tag_1 = 23 And valor_tag_2 = 11) Or (valor_tag_1 = 22 And valor_tag_2 = 10) Or (valor_tag_1 = 21 And valor_tag_2 = 9) Or (valor_tag_1 = 20 And valor_tag_2 = 8) Or (valor_tag_1 = 19 And valor_tag_2 = 7) Or (valor_tag_1 = 18 And valor_tag_2 = 6) Or (valor_tag_1 = 17 And valor_tag_2 = 5) Or (valor_tag_1 = 16 And valor_tag_2 = 4) Or (valor_tag_1 = 15 And valor_tag_2 = 3) Or (valor_tag_1 = 14 And valor_tag_2 = 2) Or (valor_tag_1 = 13 And valor_tag_2 = 1) Or (valor_tag_1 = 12 And valor_tag_2 = 0)) Then

                        parelles_encertades += 1

                        primeracarta.Tag = 100

                        segonacarta.Tag = 100

                        If parelles_encertades = 12 Then

                            Timer3.Stop()

                            puntuacio_text = puntuacio

                            puntuacio_global = puntuacio_global + puntuacio

                            puntuacio_global_text = puntuacio_global

                            MessageBox.Show("HAS GUANYAT EL JOC!" + vbCrLf + vbCrLf + "Has aconseguit " + puntuacio_text + " punts!" + vbCrLf + vbCrLf + "El teu resultat final es de " + puntuacio_global_text + " punts!")

                            End

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

    Private Sub EasterEggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasterEggToolStripMenuItem.Click

        Form_stop.Show()

    End Sub
End Class