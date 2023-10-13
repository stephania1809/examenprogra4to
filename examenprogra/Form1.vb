Imports System.Windows

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "itso" And TextBox2.Text = "123" Then
            Form2.Show()
        ElseIf MsgBox("Ingresa bien tus datos y no seas perezoso") Then
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()

    End Sub
End Class
