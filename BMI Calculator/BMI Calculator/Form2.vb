Public Class B

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Label1.Text = Form1.TextBox5.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim height, weight, bmi As Single
        height = TextBox1.Text
        weight = TextBox2.Text
        bmi = (weight) / (height ^ 2)
        TextBox3.Text = bmi

    End Sub
End Class