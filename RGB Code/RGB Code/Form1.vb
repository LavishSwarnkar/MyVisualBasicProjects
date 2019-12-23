Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rgb1, rgb2, rgb3 As Integer
        rgb1 = TextBox1.Text
        rgb2 = TextBox2.Text
        rgb3 = TextBox3.Text
        Me.BackColor = Color.FromArgb(rgb1, rgb2, rgb3)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Button1.DragDrop

    End Sub
End Class
