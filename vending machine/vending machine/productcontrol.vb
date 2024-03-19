Public Class productcontrol
    Public Property productID As String
    Public Property productprice As Decimal
    Public Property productpicture As Image
    Public Property productcount As Integer

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idLabel.Text = productID
        pricelabel.text = productprice.ToString("c2")
        PictureBox1.Image = productpicture
    End Sub
    Sub buy()
        If productcount = productcount - 1 Then
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
