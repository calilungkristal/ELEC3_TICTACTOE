Public Class Form1
    Dim checkXor0 As Boolean = False
    Dim addOneToScore As Integer = 0

    Sub btnEnabledFalse()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Sub checkWinner()
        'For X combinations
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            btn1.BackColor = Color.CadetBlue
            btn2.BackColor = Color.CadetBlue
            btn3.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            btn4.BackColor = Color.CadetBlue
            btn5.BackColor = Color.CadetBlue
            btn6.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            btn7.BackColor = Color.CadetBlue
            btn8.BackColor = Color.CadetBlue
            btn9.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            btn1.BackColor = Color.CadetBlue
            btn4.BackColor = Color.CadetBlue
            btn7.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            btn2.BackColor = Color.CadetBlue
            btn5.BackColor = Color.CadetBlue
            btn8.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            btn3.BackColor = Color.CadetBlue
            btn6.BackColor = Color.CadetBlue
            btn9.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            btn1.BackColor = Color.CadetBlue
            btn5.BackColor = Color.CadetBlue
            btn9.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            btn3.BackColor = Color.CadetBlue
            btn5.BackColor = Color.CadetBlue
            btn7.BackColor = Color.CadetBlue
            MessageBox.Show("The winner is Player X", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayerX.Text)
            lblScorePlayerX.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        'For 0 combinations
        If btn1.Text = "0" And btn2.Text = "0" And btn3.Text = "0" Then
            btn1.BackColor = Color.DarkTurquoise
            btn2.BackColor = Color.DarkTurquoise
            btn3.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn4.Text = "0" And btn5.Text = "0" And btn6.Text = "0" Then
            btn4.BackColor = Color.DarkTurquoise
            btn5.BackColor = Color.DarkTurquoise
            btn6.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn7.Text = "0" And btn8.Text = "0" And btn9.Text = "0" Then
            btn7.BackColor = Color.DarkTurquoise
            btn8.BackColor = Color.DarkTurquoise
            btn9.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn1.Text = "0" And btn4.Text = "0" And btn7.Text = "0" Then
            btn1.BackColor = Color.DarkTurquoise
            btn4.BackColor = Color.DarkTurquoise
            btn7.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn2.Text = "0" And btn5.Text = "0" And btn8.Text = "0" Then
            btn2.BackColor = Color.DarkTurquoise
            btn5.BackColor = Color.DarkTurquoise
            btn8.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn3.Text = "0" And btn6.Text = "0" And btn9.Text = "0" Then
            btn3.BackColor = Color.DarkTurquoise
            btn6.BackColor = Color.DarkTurquoise
            btn9.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn1.Text = "0" And btn5.Text = "0" And btn9.Text = "0" Then
            btn1.BackColor = Color.DarkTurquoise
            btn5.BackColor = Color.DarkTurquoise
            btn9.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If

        If btn3.Text = "0" And btn5.Text = "0" And btn7.Text = "0" Then
            btn3.BackColor = Color.DarkTurquoise
            btn5.BackColor = Color.DarkTurquoise
            btn7.BackColor = Color.DarkTurquoise
            MessageBox.Show("The winner is Player 0", "TIC TAC TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(lblScorePlayer0.Text)
            lblScorePlayer0.Text = Convert.ToString(addOneToScore + 1)
            btnEnabledFalse()
        End If
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click
        Dim b As Button = sender
        If checkXor0 = False Then
            b.Text = "X"
            checkXor0 = True
        Else
            b.Text = "0"
            checkXor0 = False
        End If
        checkWinner()
        b.Enabled = False
    End Sub
End Class
