Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox9.Text = TextBox2.Text
        TextBox10.Text = TextBox3.Text
        TextBox11.Text = TextBox1.Text
        TextBox12.Text = TextBox4.Text
        TextBox13.Text = TextBox5.Text
        TextBox14.Text = TextBox6.Text
        TextBox15.Text = TextBox6.Text
        TextBox16.Text = TextBox8.Text
        TextBox18.Text = TextBox17.Text

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OFGSelectImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OFGSelectImage.FileName)
        End If
    End Sub
End Class
