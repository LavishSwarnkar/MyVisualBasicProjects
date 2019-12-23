Public Class Form3
    Dim L, M, N As String
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        L = "Thanks for Using The Software ,"
        M = "This Software is Made By :-"
        N = "Lavish Swarnkar"
        TextBox1.Text = TextBox17.Text
        TextBox2.Text = TextBox18.Text
        TextBox3.Text = TextBox19.Text
        TextBox4.Text = TextBox20.Text
        Label2.Text = L
        Label3.Text = M
        Label4.Text = N
    End Sub
End Class