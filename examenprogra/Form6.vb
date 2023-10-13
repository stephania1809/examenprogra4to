Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            Exit Sub
        End If

        Dim dividendo As Double
        Dim divisor As Double
        Dim resultado As Double
        If Not Double.TryParse(TextBox1.Text, dividendo) Then
            Exit Sub
        End If

        If Not Double.TryParse(TextBox2.Text, divisor) Then
            Exit Sub
        End If

        resultado = dividendo / divisor
        TextBox3.Text = resultad
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Hide()

    End Sub
End Class