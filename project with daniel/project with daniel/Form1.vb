Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim f2 As New form2
        f2.showdialog
        Label2.text = f2.tierscount.value
        Me.Show()
    End Sub
End Class
