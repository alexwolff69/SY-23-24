Public Class Form1
    Dim WithEvents cs As New coinslot

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickles()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdimes()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarters()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub dollars_Click(sender As Object, e As EventArgs) Handles dollars.Click
        cs.insertdollars()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarcoin.Visible = True
        End If
        dollarcoin.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case IDtextbox.Text
            Case Productcontrol1.productID
                cs.buy(Productcontrol1)
            Case 2

            Case Else
        End Select
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        productPictureBox.Image = p
    End Sub

    Private Sub l_TextChanged(sender As Object, e As EventArgs) Handles IDtextbox.TextChanged

    End Sub
End Class
