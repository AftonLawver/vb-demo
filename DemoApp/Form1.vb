Public Class Form1
    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Afton"
        stLastName = "Lawver"

        MessageBox.Show("Hello " & stFirstName & " " & stLastName)

    End Sub
End Class
