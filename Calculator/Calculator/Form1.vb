Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        TextBox3.Text = num1 + num2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        TextBox3.Text = num1 - num2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        TextBox3.Text = num1 * num2
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        TextBox3.Text = num1 / num2
    End Sub
End Class
