Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label9.Hide()
        Label10.Hide()
        Button11.Hide()
        Button9.Hide()
        Button8.Hide()
        Button2.Hide()
        Button7.Hide()
        LB1.Hide()
        ListBox1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()

        Pic1.Hide()
        Pic1.Hide()
        GroupBox2.Hide()
        Label3.Hide()
        Label4.Hide()
        GroupBox1.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pic1.Hide()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        GroupBox2.Show()
        GroupBox1.Show()
        Me.Height = 565
        Me.Width = 731
        Button1.Hide()
        Label3.Show()
        Label4.Show()
        Pic2.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub



    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB1.TextChanged

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Button9.Show()
        Pic1.Hide()
        Pic2.Hide()
        If RadioButton1.Checked Then
            LB1.Show()

        End If
        Button7.Show()
        If RadioButton2.Checked Then
            ListBox1.Show()

        End If
        If RadioButton4.Checked Then
            LB4.Show()

        End If
        If RadioButton5.Checked Then
            LB5.Show()

        End If
        If RadioButton3.Checked Then
            LB3.Show()

        End If

        GroupBox1.Text = "Output"
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LB1.Hide()
        ListBox1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()

        Timer1.Start()
        Pic1.Show()
        Pic2.Show()
        GroupBox1.Text = "Loading..."


        Dim sum, n, k As Integer
        k = TB1.Text
        While n <> 10
            n += 1
            sum = k * n
            LB1.Items.Add(k & "X" & n & "=" & sum)
        End While





    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub E_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button2.Show()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button2.Hide()
        Button3.Show()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Button2.Hide()
        Button3.Hide()
        Button4.Show()
        Button5.Hide()
        Button6.Hide()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Show()
        Button6.Hide()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LB1.Hide()
        ListBox1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()

        Timer1.Start()
        Pic1.Show()
        Pic2.Show()
        GroupBox1.Text = "Loading..."
        Dim k As Integer
        k = TB1.Text
        ListBox1.Items.Add(k & "X" & "11" & "=" & k * 11)
        ListBox1.Items.Add(k & "X" & "12" & "=" & k * 12)
        ListBox1.Items.Add(k & "X" & "13" & "=" & k * 13)
        ListBox1.Items.Add(k & "X" & "14" & "=" & k * 14)
        ListBox1.Items.Add(k & "X" & "15" & "=" & k * 15)
        ListBox1.Items.Add(k & "X" & "16" & "=" & k * 16)
        ListBox1.Items.Add(k & "X" & "17" & "=" & k * 17)
        ListBox1.Items.Add(k & "X" & "18" & "=" & k * 18)
        ListBox1.Items.Add(k & "X" & "19" & "=" & k * 19)
        ListBox1.Items.Add(k & "X" & "20" & "=" & k * 20)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LB1.Hide()
        ListBox1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()

        Timer1.Start()
        Pic1.Show()
        Pic2.Show()
        GroupBox1.Text = "Loading..."
        Dim k As Integer
        k = TB1.Text
        LB3.Items.Add(k & "X" & "21" & "=" & k * 21)
        LB3.Items.Add(k & "X" & "22" & "=" & k * 22)
        LB3.Items.Add(k & "X" & "23" & "=" & k * 23)
        LB3.Items.Add(k & "X" & "24" & "=" & k * 24)
        LB3.Items.Add(k & "X" & "25" & "=" & k * 25)
        LB3.Items.Add(k & "X" & "26" & "=" & k * 26)
        LB3.Items.Add(k & "X" & "27" & "=" & k * 27)
        LB3.Items.Add(k & "X" & "28" & "=" & k * 28)
        LB3.Items.Add(k & "X" & "29" & "=" & k * 29)
        LB3.Items.Add(k & "X" & "30" & "=" & k * 30)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        LB1.Hide()
        ListBox1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()

        Timer1.Start()
        Pic1.Show()
        Pic2.Show()
        GroupBox1.Text = "Loading..."
        Dim k As Integer
        k = TB1.Text
        LB4.Items.Add(k & "X" & "31" & "=" & k * 31)
        LB4.Items.Add(k & "X" & "32" & "=" & k * 32)
        LB4.Items.Add(k & "X" & "33" & "=" & k * 33)
        LB4.Items.Add(k & "X" & "34" & "=" & k * 34)
        LB4.Items.Add(k & "X" & "35" & "=" & k * 35)
        LB4.Items.Add(k & "X" & "36" & "=" & k * 36)
        LB4.Items.Add(k & "X" & "37" & "=" & k * 37)
        LB4.Items.Add(k & "X" & "38" & "=" & k * 38)
        LB4.Items.Add(k & "X" & "39" & "=" & k * 39)
        LB4.Items.Add(k & "X" & "40" & "=" & k * 40)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer1.Stop()
        LB1.Hide()
        ListBox1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()

        Timer1.Start()
        Pic1.Show()
        Pic2.Show()
        GroupBox1.Text = "Loading..."
        Dim k As Integer
        k = TB1.Text
        LB5.Items.Add(k & "X" & "41" & "=" & k * 41)
        LB5.Items.Add(k & "X" & "42" & "=" & k * 42)
        LB5.Items.Add(k & "X" & "43" & "=" & k * 43)
        LB5.Items.Add(k & "X" & "44" & "=" & k * 44)
        LB5.Items.Add(k & "X" & "45" & "=" & k * 45)
        LB5.Items.Add(k & "X" & "46" & "=" & k * 46)
        LB5.Items.Add(k & "X" & "47" & "=" & k * 47)
        LB5.Items.Add(k & "X" & "48" & "=" & k * 48)
        LB5.Items.Add(k & "X" & "49" & "=" & k * 49)
        LB5.Items.Add(k & "X" & "50" & "=" & k * 50)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        ListBox1.Hide()
        LB1.Hide()
        LB3.Hide()
        LB4.Hide()
        LB5.Hide()
        GroupBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        LB1.Items.Clear()
        TB1.Text = ""
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        Button7.Hide()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button11.Show()
        Me.Width = 502
        Me.Height = 162
        Label9.Show()
        Label10.Show()
        GroupBox1.Hide()
        GroupBox2.Hide()
        Label3.Hide()
        Label4.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class
