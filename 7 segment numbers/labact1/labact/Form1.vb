Public Class Form1

    Private A As Integer
    Private B As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If A = 0 Then
            Button1.BackColor = Color.Red   '0
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White
            A = 1



        ElseIf A = 1 Then
            Button1.BackColor = Color.White   '1
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
            A = 2

        ElseIf A = 2 Then
            Button1.BackColor = Color.Red   '2
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Red
            A = 3

        ElseIf A = 3 Then
            Button1.BackColor = Color.Red   '3
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Red
            A = 4

        ElseIf A = 4 Then
            Button1.BackColor = Color.White   '4
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            A = 5

        ElseIf A = 5 Then
            Button1.BackColor = Color.Red   '5
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            A = 6

        ElseIf A = 6 Then
            Button1.BackColor = Color.Red   '6
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            A = 7

        ElseIf A = 7 Then
            Button1.BackColor = Color.Red   '7
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
            A = 8

        ElseIf A = 8 Then
            Button1.BackColor = Color.Red   '8
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            A = 9

        ElseIf A = 9 Then
            Button1.BackColor = Color.Red   '9
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            A = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = 0
        B = -1


        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 1000


    End Sub
End Class
