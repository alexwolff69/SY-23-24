Public Class Form1
    Dim movespeed As Integer = 15


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Start()
        End Select
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        pickplayer.Left += movespeed
    End Sub
End Class