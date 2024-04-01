Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()

        Me.Show()
    End Sub
End Class
