Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nextpage.Click
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        Me.Show()
    End Sub
End Class
