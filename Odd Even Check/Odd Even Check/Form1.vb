﻿Public Class Form1
    Dim num1 As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        num1 = TextBox1.Text
        If num1 Mod 2 = 0 Then
            TextBox2.Text = "The Number is Even"
        Else : TextBox2.Text = "The Number is Odd"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
