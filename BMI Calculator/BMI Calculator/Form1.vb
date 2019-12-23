Public Class Form1

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F.Click
        A.Hide()
        D.Hide()
        B.Hide()
        C.Hide()
        TextBox5.Hide()
        F.Hide()
        G.Hide()
        I.Text = TextBox5.Text()
        Label8.Show()
        I.Show()
        Label10.Show()
        K.Show()
        L.Show()
        M.Show()
        N.Show()
        Next2.Show()
        Cancel2.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G.Click
        Me.Close()

    End Sub


    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N.Click

    End Sub

    Private Sub Next2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next2.Click
        Label8.Hide()
        
        Label10.Hide()


        I.Hide()

        K.Hide()
        L.Hide()
        M.Hide()
        N.Hide()
        Next2.Hide()
        Cancel2.Hide()
        O.Show()
        P.Show()
        Q.Show()
        R.Show()
        S.Show()
        T.Show()

        V.Show()

        X.Show()


        AA.Show()
        BB.Show()
        CC.Show()
        DD.Show()

        JJ.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Button4.Hide()

        Button3.Hide()
        KK.Hide()
        LL.Hide()
        MM.Hide()
        NN.Hide()
        OO.Hide()
        Button1.Hide()
        Button2.Hide()
        Label8.Hide()
        II.Hide()
        Label10.Hide()
        I.Hide()

        K.Hide()
        L.Hide()
        M.Hide()
        N.Hide()
        Next2.Hide()
        Cancel2.Hide()
        O.Hide()
        P.Hide()
        Q.Hide()
        R.Hide()
        S.Hide()
        T.Hide()
        U.Hide()
        V.Hide()
        W.Hide()
        X.Hide()
        Y.Hide()
        Z.Hide()
        AA.Hide()
        BB.Hide()
        CC.Hide()
        DD.Hide()
        EE.Hide()
        FF.Hide()
        GG.Hide()
        HH.Hide()
        II.Hide()
        JJ.Hide()
    End Sub

    Private Sub X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AA.CheckedChanged
        Button1.Hide()
        Button2.Hide()
        II.Show()
        U.Show()
        EE.Show()
        W.Hide()
        FF.Hide()
        Y.Hide()
        Z.Hide()
        GG.Hide()
        HH.Hide()
        II.Show()
    End Sub

    Private Sub BB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BB.CheckedChanged

        Button2.Hide()
        II.Hide()
        Button1.Show()
        W.Show()
        FF.Show()
        U.Hide()
        EE.Hide()
        
        Y.Hide()
        Z.Hide()
        GG.Hide()
        HH.Hide()
    End Sub

    Private Sub CC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CC.CheckedChanged

        II.Hide()
        Button1.Hide()
        Button2.Show()
        U.Hide()
        EE.Hide()
        W.Hide()
        FF.Hide()
        Y.Show()
        Z.Show()
        GG.Show()
        HH.Show()

    End Sub

    Private Sub JJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JJ.Click
        Me.Close()
    End Sub

    Private Sub Cancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel2.Click
        Me.Close()

    End Sub

    Private Sub II_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles II.Click
        Button4.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Button3.Show()
        Button1.Hide()
        Button2.Hide()
        II.Hide()
        KK.Show()
        LL.Show()
        MM.Show()
        NN.Show()
        OO.Show()
        O.Hide()
        P.Hide()
        Q.Hide()
        R.Hide()
        S.Hide()
        T.Hide()
        U.Hide()
        V.Hide()
        W.Hide()
        X.Hide()
        Y.Hide()
        Z.Hide()
        AA.Hide()
        BB.Hide()
        CC.Hide()
        DD.Hide()
        EE.Hide()
        FF.Hide()
        GG.Hide()
        HH.Hide()
        II.Hide()
        JJ.Hide()
        Dim kg, mn, bmi As Decimal
        kg = S.Text
        mn = U.Text
        bmi = (kg) / (mn ^ 2)
        LL.Text = bmi
        If 19.2 < bmi And bmi < 25.2 Then
            NN.Text = "Fit!"
            Label1.Text = "Nothing to say ! Stay as you are."
        ElseIf 10.2 < bmi And bmi < 19.2 Then
            NN.Text = "Under-Weight!"
            Label1.Text = "1.Try increasing your Weight"
            Label2.Text = "2.Eat Healthy Foods."
            Label3.Text = "3.Reduce doing Heavy Exercises "
        ElseIf 25.2 < bmi And bmi < 30.2 Then
            NN.Text = "Over-Weight"
            Label1.Text = "1.Try decreasing your Weight"
            Label2.Text = "2.Eat Less ,Drink more."
            Label3.Text = "3.Try doing Heavy Exercises "
        ElseIf 100.2 > bmi And bmi > 30.2 Then
            NN.Text = "Obese (Very Fat)"
            Label1.Text = "1.Try decreasing your Weight"
            Label2.Text = "2.Eat Less ,Drink more."
            Label3.Text = "3.Try doing Heavy Exercises "
        Else : NN.Text = "Error! try again by pressing 'Back' Button"

        End If
        
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button4.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Button3.Show()
        Button1.Hide()
        Button2.Hide()
        II.Hide()
        KK.Show()
        LL.Show()
        MM.Show()
        NN.Show()
        OO.Show()
        O.Hide()
        P.Hide()
        Q.Hide()
        R.Hide()
        S.Hide()
        T.Hide()
        U.Hide()
        V.Hide()
        W.Hide()
        X.Hide()
        Y.Hide()
        Z.Hide()
        AA.Hide()
        BB.Hide()
        CC.Hide()
        DD.Hide()
        EE.Hide()
        FF.Hide()
        GG.Hide()
        HH.Hide()
        II.Hide()
        JJ.Hide()
        Dim kg, cm, comb, bmi As Single
        kg = S.Text
        cm = W.Text
        comb = cm * 0.001
        bmi = (kg) / (comb ^ 2)
        LL.Text = bmi
        If 19.2 < bmi And bmi < 25.2 Then
            NN.Text = "Fit!"
            Label1.Text = "Nothing to say ! Stay as you are."
        ElseIf 10.2 < bmi And bmi < 19.2 Then
            NN.Text = "Under-Weight!"
            Label1.Text = "1.Try increasing your Weight"
            Label2.Text = "2.Eat Healthy Foods."
            Label3.Text = "3.Reduce doing Heavy Exercises "
        ElseIf 25.2 < bmi And bmi < 30.2 Then
            NN.Text = "Over-Weight"
            Label1.Text = "1.Try decreasing your Weight"
            Label2.Text = "2.Eat Less ,Drink more."
            Label3.Text = "3.Try doing Heavy Exercises "
        ElseIf 100.2 > bmi And bmi > 30.2 Then
            NN.Text = "Obese (Very Fat)"
            Label1.Text = "1.Try decreasing your Weight"
            Label2.Text = "2.Eat Less ,Drink more."
            Label3.Text = "3.Try doing Heavy Exercises "
        Else : NN.Text = "Error! try again by pressing 'Back' Button"

        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button4.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Button3.Show()
        Button1.Hide()
        Button2.Hide()
        II.Hide()
        KK.Show()
        LL.Show()
        MM.Show()
        NN.Show()
        OO.Show()

        O.Hide()
        P.Hide()
        Q.Hide()
        R.Hide()
        S.Hide()
        T.Hide()
        U.Hide()
        V.Hide()
        W.Hide()
        X.Hide()
        Y.Hide()
        Z.Hide()
        AA.Hide()
        BB.Hide()
        CC.Hide()
        DD.Hide()
        EE.Hide()
        FF.Hide()
        GG.Hide()
        HH.Hide()
        II.Hide()
        JJ.Hide()
        Dim kg, feet, inch, combs, combi, bmi As Single
        kg = S.Text
        feet = Y.Text
        inch = Z.Text
        combs = feet + (inch * 0.083)
        combi = combs * 0.3048
        bmi = (kg) / (combi ^ 2)
        LL.Text = bmi
        If 19.2 < bmi And bmi < 25.2 Then
            NN.Text = "Fit!"
            Label1.Text = "Nothing to say ! Stay as you are."
        ElseIf 10.2 < bmi And bmi < 19.2 Then
            NN.Text = "Under-Weight!"
            Label1.Text = "1.Try increasing your Weight"
            Label2.Text = "2.Eat Healthy Foods."
            Label3.Text = "3.Reduce doing Heavy Exercises "
        ElseIf 25.2 < bmi And bmi < 30.2 Then
            NN.Text = "Over-Weight"
            Label1.Text = "1.Try decreasing your Weight"
            Label2.Text = "2.Eat Less ,Drink more."
            Label3.Text = "3.Try doing Heavy Exercises "
        ElseIf 100.2 > bmi And bmi > 30.2 Then
            NN.Text = "Obese (Very Fat)"
            Label1.Text = "1.Try decreasing your Weight"
            Label2.Text = "2.Eat Less ,Drink more."
            Label3.Text = "3.Try doing Heavy Exercises "
        Else : NN.Text = "Error! try again by pressing 'Back' Button"

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim msg As String

        msg = MsgBox("Thanks for using the software. Click OK to close.", 0, "Happy Ending")
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button1.Hide()
        Button2.Hide()
        II.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Button3.Hide()
        Button1.Hide()
        Button2.Hide()
        II.Hide()
        KK.Hide()
        LL.Hide()
        MM.Hide()
        NN.Hide()
        OO.Hide()

        O.Show()
        P.Show()
        Q.Show()
        R.Show()
        S.Show()
        T.Show()
        U.Hide()
        V.Show()
        W.Hide()
        X.Show()
        Y.Hide()
        Z.Hide()
        AA.Show()
        BB.Show()
        CC.Show()
        DD.Show()
        EE.Hide()
        FF.Hide()
        GG.Hide()
        HH.Hide()
        II.Show()
        JJ.Show()
    End Sub
End Class
