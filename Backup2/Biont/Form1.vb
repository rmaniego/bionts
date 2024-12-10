Public Class Form1

    Dim ct1 As Integer = 1
    Dim ct2 As Integer = 0
    Dim ct3 As Integer = 1
    Dim ct4 As Integer = 0
    Dim ct5 As Integer = 1
    Dim ct6 As Integer = 0
    Dim ct7 As Integer = 1
    Dim ct8 As Integer = 0
    Dim ct9 As Integer = 1
    Dim ct10 As Integer = 0
    Dim ct11 As Integer = 1
    Dim ct12 As Integer = 0
    Dim ct13 As Integer = 1
    Dim ct14 As Integer = 0
    Dim valpop As Integer = 1
    Dim vallyf As Integer = 2
    Dim valsur As Integer = 96
    Dim subsur As Integer = 0
    Dim valeat As Integer = 0
    Dim valharm As Integer = 0
    Dim valdes As Integer = 0
    Dim valfoo As String = "Chemoautotrophic"
    Dim ctrA As Integer = 1
    Dim biont As String = "Cell"
    Dim ctrLvl As Integer = 1
    Dim ctrStage As Integer = 1
    Dim ctrtut As Integer = 1

    Private Sub tymh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tymh.Tick
        homes.Visible = True
        title.Visible = True
        play.Visible = True
        tymbrush.Enabled = True
        stats.Visible = True
        stattit.Visible = False
        statpop.Visible = False
        statsur.Visible = False
        statdes.Visible = False
        statfoo.Visible = False
        tymstat.Enabled = False
        gamestat.Enabled = False
        tymki.Enabled = False

        If ct1 = 1 And ct2 = 0 Then
            title.Top += 3
            If title.Top >= 55 Then
                ct1 = 0
                ct2 = 1
            End If
        ElseIf ct1 = 0 And ct2 = 1 Then
            title.Top -= 2
            If title.Top <= 45 Then
                ct1 = 1
                ct2 = 0
            End If
        End If

        If ct3 = 1 And ct4 = 0 Then
            title.Left += 2
            If title.Left >= 35 Then
                ct3 = 0
                ct4 = 1
            End If
        ElseIf ct3 = 0 And ct4 = 1 Then
            title.Left -= 1
            If title.Left <= 26 Then
                ct3 = 1
                ct4 = 0
            End If
        End If

        If ct5 = 1 And ct6 = 0 Then
            play.Top += 2
            If play.Top >= 147 Then
                ct5 = 0
                ct6 = 1
            End If
        ElseIf ct5 = 0 And ct6 = 1 Then
            play.Top -= 3
            If play.Top <= 142 Then
                ct5 = 1
                ct6 = 0
            End If
        End If

        If ct7 = 1 And ct8 = 0 Then
            play.Left += 1
            If play.Left >= 16 Then
                ct7 = 0
                ct8 = 1
            End If
        ElseIf ct7 = 0 And ct8 = 1 Then
            play.Left -= 2
            If play.Left <= 9 Then
                ct7 = 1
                ct8 = 0
            End If
        End If

        If ct9 = 1 And ct10 = 0 Then
            stats.Top += 2
            If stats.Top >= 154 Then
                ct9 = 0
                ct10 = 1
            End If
        ElseIf ct9 = 0 And ct10 = 1 Then
            stats.Top -= 1
            If stats.Top <= 148 Then
                ct9 = 1
                ct10 = 0
            End If
        End If

        If ct11 = 1 And ct12 = 0 Then
            stats.Left += 2
            If stats.Left >= 154 Then
                ct11 = 0
                ct12 = 1
            End If
        ElseIf ct11 = 0 And ct12 = 1 Then
            stats.Left -= 3
            If stats.Left <= 150 Then
                ct11 = 1
                ct12 = 0
            End If
        End If

    End Sub

    Private Sub play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play.Click
        tymh.Enabled = False
        tymki.Enabled = False
        gamestat.Enabled = True
        tymbrush.Enabled = True
        tymstat.Enabled = False
        'true
        playask.Visible = True
        playname.Visible = True
        playgo.Visible = True
        'false
        homes.Visible = False
        title.Visible = False
        play.Visible = False
        stats.Visible = False
        stattit.Visible = False
        statpop.Visible = False
        statsur.Visible = False
        statdes.Visible = False
        statfoo.Visible = False
    End Sub

    Private Sub stats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stats.Click
        tymh.Enabled = False
        tymstat.Enabled = True
        tymbrush.Enabled = True
        gamestat.Enabled = False
        tymki.Enabled = False
        'true
        statback.Visible = True
        stattit.Visible = True
        statpop.Visible = True
        statsur.Visible = True
        statdes.Visible = True
        statfoo.Visible = True
        'false
        homes.Visible = False
        title.Visible = False
        play.Visible = False
        stats.Visible = False
    End Sub

    Private Sub tymstat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tymstat.Tick
        'Statistics Screen Animation
        If ct3 = 1 And ct4 = 0 Then
            stattit.Left += 2
            If stattit.Left >= 45 Then
                ct3 = 0
                ct4 = 1
            End If
        ElseIf ct3 = 0 And ct4 = 1 Then
            stattit.Left -= 2
            If stattit.Left <= 35 Then
                ct3 = 1
                ct4 = 0
            End If
        End If

        If ct5 = 1 And ct6 = 0 Then
            statpop.Text = "Population: " & valpop - Rnd(2) & " " & biont & "s"
            ct5 = 0
            ct6 = 1
        ElseIf ct5 = 0 And ct6 = 1 Then
            statpop.Text = "Population: " & valpop - Rnd(2) & " " & biont & "s"
            ct5 = 1
            ct6 = 0
        End If

        If ct7 = 1 And ct8 = 0 Then
            statsur.Text = "Survival rate: " & valsur - Rnd(2) & "%"
            ct7 = 0
            ct8 = 1
        ElseIf ct7 = 0 And ct8 = 1 Then
            statsur.Text = "Survival rate: " & valsur + Rnd(2) & "%"
            ct7 = 1
            ct8 = 0
        End If

        statdes.Text = "Descent: " & ct1 'sample

        statfoo.Text = "Foodie: " & valfoo
    End Sub

    Private Sub statback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statback.Click
        tymh.Enabled = True
        tymstat.Enabled = False
        tymbrush.Enabled = True
        gamestat.Enabled = False
        'true
        homes.Visible = True
        title.Visible = True
        play.Visible = True
        stats.Visible = True
        'false
        statback.Visible = False
        stattit.Visible = False
        statpop.Visible = False
        statsur.Visible = False
        statdes.Visible = False
        statfoo.Visible = False
    End Sub

    Private Sub statback_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statback.MouseHover
        tymki.Enabled = True
    End Sub
    Private Sub statback_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statback.MouseLeave
        tymki.Enabled = False
        statback.Left = 12
    End Sub

    Private Sub gamestat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamestat.Tick

        'data production area while the game is played

        If ctrA = 1 Then
            ctrA = 2
        ElseIf ctrA = 2 Then
            ctrA = 3
            valsur = 100 - ((valeat + valharm) / 100)
        ElseIf ctrA = 3 Then
            ctrA = 4
            subsur = valsur / 100
        ElseIf ctrA = 4 Then
            ctrA = 5
        ElseIf ctrA = 5 Then
            ctrA = 1
            valpop = (valpop * vallyf) - ((valpop * vallyf) - ((valpop * vallyf) * subsur))
        End If

        'valdes is stage
        'valfoo is degree of food type consumption
    End Sub

    Private Sub tymki_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tymki.Tick
        If ct1 = 1 And ct2 = 0 Then
            statback.Left -= 5
            ct1 = 0
            ct2 = 1
        ElseIf ct1 = 0 And ct2 = 1 Then
            statback.Left += 5
            ct1 = 1
            ct2 = 0
        End If
    End Sub

    Private Sub tymbrush_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tymbrush.Tick

        'brush effects here
        b1.Top += 2
        b1.Left -= 1
        b2.Top += 1
        b2.Left -= 3
        b3.Top -= 3
        b3.Left += 2
        b4.Top -= 3
        b4.Left -= 1
        b5.Top -= 2
        b5.Left -= 2

        If b1.Top = 0 Or b1.Left = 0 Or b1.Top = 240 Or b1.Left = 320 Then
            b1.Top = 0
            b1.Left = Rnd(200) + 100
        End If
        If b2.Top = 0 Or b2.Left = 0 Or b2.Top = 240 Or b2.Left = 320 Then
            b2.Top = Rnd(120) + 100
            b2.Left = 320
        End If
        If b3.Top = 0 Or b3.Left = 0 Or b3.Top = 240 Or b3.Left = 320 Then
            b3.Top = 240
            b3.Left = Rnd(250) + 100
        End If
        If b4.Top = 0 Or b4.Left = 0 Or b4.Top = 240 Or b4.Left = 320 Then
            b4.Top = 240
            b4.Left = Rnd(250) + 100
        End If
        If b5.Top = 0 Or b5.Left = 0 Or b5.Top = 240 Or b5.Left = 320 Then
            b5.Top = Rnd(120) + 100
            b5.Left = 320
        End If

        'game here

    End Sub

    Private Sub playgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playgo.Click
        biont = playname.Text
        gamereal.Enabled = True
        playask.Visible = False
        playname.Visible = False
        playgo.Visible = False
        homes.Visible = False
        statback.Visible = False
        stattit.Visible = False
        statpop.Visible = False
        statsur.Visible = False
        statdes.Visible = False
        statfoo.Visible = False
    End Sub

    Private Sub gamereal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamereal.Tick

        tutexit.Visible = False
        balloon2.Visible = True
        tuttxt.Visible = True
        tutnxt.Visible = True
        playask.Visible = False
        playname.Visible = False
        playgo.Visible = False
        homes.Visible = False
        title.Visible = False
        play.Visible = False
        stats.Visible = False
        statback.Visible = False
        stattit.Visible = False
        statpop.Visible = False
        statsur.Visible = False
        statdes.Visible = False
        statfoo.Visible = False

        If ctrtut <= 1 Then
            tutend.Visible = True
            tuttxt.Text = "Hey! Let's learn some" & vbNewLine & "basics here."
            tutexit.Visible = True
            tutprev.Visible = False
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = False
        ElseIf ctrtut = 2 Then
            tutend.Visible = True
            tuttxt.Text = "Click end to terminate" & vbNewLine & "tutorial."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = True
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = False
        ElseIf ctrtut = 3 Then
            tutend.Visible = True
            tuttxt.Text = "This is you. A tiny yet hungry" & vbNewLine & "cell."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = True
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = False
            eat111.Visible = False
            eat211.Visible = False
            eat311.Visible = False
            eat411.Visible = False
            player.Visible = True
        ElseIf ctrtut = 4 Then
            tutend.Visible = True
            tuttxt.Text = "There are nutrients needed" & vbNewLine & "for growth."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = False
        ElseIf ctrtut = 5 Then
            tutend.Visible = True
            tuttxt.Text = "This is a basic food" & vbNewLine & "pellet."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = True
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = False
            eat111.Visible = True
            eat211.Visible = False
            eat311.Visible = False
            eat411.Visible = False
            player.Visible = False
        ElseIf ctrtut = 6 Then
            tutend.Visible = True
            tuttxt.Text = "Another is air to" & vbNewLine & "breath."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = True
            pnt5.Visible = False
            pnt6.Visible = False
            eat111.Visible = False
            eat211.Visible = True
            eat311.Visible = False
            eat411.Visible = False
            player.Visible = False
        ElseIf ctrtut = 7 Then
            tutend.Visible = True
            tuttxt.Text = "This is another food" & vbNewLine & "pellet."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = True
            pnt6.Visible = False
            eat111.Visible = False
            eat211.Visible = False
            eat311.Visible = True
            eat411.Visible = False
            player.Visible = False
        ElseIf ctrtut = 8 Then
            tutend.Visible = True
            tuttxt.Text = "While this is sunlight" & vbNewLine & "particle."
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = True
            eat111.Visible = False
            eat211.Visible = False
            eat311.Visible = False
            eat411.Visible = True
            player.Visible = False
        ElseIf ctrtut = 9 Then
            tutend.Visible = True
            tuttxt.Text = "Are you are ready" & vbNewLine & "to play?"
            tutexit.Visible = True
            tutprev.Visible = True
            pnt1.Visible = False
            pnt2.Visible = False
            pnt3.Visible = False
            pnt4.Visible = False
            pnt5.Visible = False
            pnt6.Visible = False
        End If
    End Sub

    Private Sub tutnxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutnxt.Click
        ctrtut += 1
    End Sub

    Private Sub tutprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutprev.Click
        ctrtut -= 1
    End Sub

    Private Sub tutnxt_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutnxt.MouseHover
        tutnxt.Left += 5
    End Sub

    Private Sub tutprev_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutprev.MouseHover
        tutnxt.Left -= 5
    End Sub
    Private Sub tutnxt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutnxt.MouseLeave
        tutnxt.Left -= 5
    End Sub

    Private Sub tutprev_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutprev.MouseLeave
        tutnxt.Left += 5
    End Sub
    Private Sub playgo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playgo.MouseHover
        playgo.Left -= 5
    End Sub
    Private Sub playgo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playgo.MouseLeave
        playgo.Left -= 5
    End Sub

End Class
