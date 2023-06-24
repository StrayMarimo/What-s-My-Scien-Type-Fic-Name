
Public Class plantsD
    Dim waittime As Integer = 500
    Dim speed As Integer = 50
    Dim Score As Integer
    Dim ctr As Integer
    Dim number As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animation.Interval = speed
        wait.Interval = waittime
        wait.Enabled = True
        go.Enabled = True

        'hide scinames
        apple.Hide()
        banana.Hide()
        guava.Hide()
        mango.Hide()
        lemon.Hide()
        potato.Hide()
        ginger.Hide()
        rice.Hide()
        bamboo.Hide()
        cucumber.Hide()
        orange.Hide()
        eggplant.Hide()
        pineapple.Hide()
        starapple.Hide()
        tomato.Hide()
        watermelon.Hide()
        blackpepper.Hide()
        lettuce.Hide()
        radish.Hide()
        spinach.Hide()
        staranise.Hide()
        sweetpotato.Hide()
        blueberry.Hide()
        cabbage.Hide()
        capsicum.Hide()
        cashewnut.Hide()
        cherry.Hide()
        chiku.Hide()
        cinnamon.Hide()
        clove.Hide()
        coriander.Hide()
        cotton.Hide()
        dewberry.Hide()
        fuchsia.Hide()
        durian.Hide()
        garlic.Hide()
        ivy.Hide()
        jackfruit.Hide()
        jasmine.Hide()
        laurel.Hide()
        lilac.Hide()
        malunggay.Hide()
        maple.Hide()
        oak.Hide()
        olive.Hide()
        papaya.Hide()
        pea.Hide()
        peach.Hide()
        peanut.Hide()
        pear.Hide()
        pine.Hide()
        poisonivy.Hide()
        raspberry.Hide()
        rosemary.Hide()
        soyabean.Hide()
        strawberry.Hide()
        sunflower.Hide()
        tamarind.Hide()
        tawatawa.Hide()
        tea.Hide()
        tulip.Hide()
        violet.Hide()
        walnut.Hide()
        wheat.Hide()

    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        'hide letters of previous scinames


        go.Enabled = False
        Timer1.Enabled = True
        Dim rn As New Random
        ctr = rn.Next(1, 28) 'randomize scinames
        wait.Enabled = True
        'scinames back to start position
        apple.Location = New Point(191, 191)
        banana.Location = New Point(191, 191)
        guava.Location = New Point(191, 191)
        mango.Location = New Point(191, 191)
        lemon.Location = New Point(191, 191)
        potato.Location = New Point(191, 191)
        ginger.Location = New Point(191, 191)
        rice.Location = New Point(191, 191)
        bamboo.Location = New Point(191, 191)
        orange.Location = New Point(191, 191)
        cucumber.Location = New Point(191, 191)
        eggplant.Location = New Point(191, 191)
        pineapple.Location = New Point(191, 191)
        starapple.Location = New Point(191, 191)
        tomato.Location = New Point(191, 191)
        watermelon.Location = New Point(191, 191)
        blackpepper.Location = New Point(191, 191)
        lettuce.Location = New Point(191, 191)
        radish.Location = New Point(191, 191)
        spinach.Location = New Point(191, 191)
        staranise.Location = New Point(191, 191)
        sweetpotato.Location = New Point(191, 191)
        blueberry.Location = New Point(191, 191)
        cabbage.Location = New Point(191, 191)
        capsicum.Location = New Point(191, 191)
        cashewnut.Location = New Point(191, 191)
        cherry.Location = New Point(191, 191)
        chiku.Location = New Point(191, 191)
        cinnamon.Location = New Point(191, 191)
        clove.Location = New Point(191, 191)
        coriander.Location = New Point(191, 191)
        cotton.Location = New Point(191, 191)
        dewberry.Location = New Point(191, 191)
        durian.Location = New Point(191, 191)
        fuchsia.Location = New Point(191, 191)
        garlic.Location = New Point(191, 191)
        ivy.Location = New Point(191, 191)
        jackfruit.Location = New Point(191, 191)
        jasmine.Location = New Point(191, 191)
        laurel.Location = New Point(191, 191)
        lilac.Location = New Point(191, 191)
        malunggay.Location = New Point(191, 191)
        maple.Location = New Point(191, 191)
        oak.Location = New Point(191, 191)
        olive.Location = New Point(191, 191)
        papaya.Location = New Point(191, 191)
        pea.Location = New Point(191, 191)
        peach.Location = New Point(191, 191)
        peanut.Location = New Point(191, 191)
        pear.Location = New Point(191, 191)
        pine.Location = New Point(191, 191)
        raspberry.Location = New Point(191, 191)
        rosemary.Location = New Point(191, 191)
        soyabean.Location = New Point(191, 191)
        strawberry.Location = New Point(191, 191)
        sunflower.Location = New Point(191, 191)
        tamarind.Location = New Point(191, 191)
        tawatawa.Location = New Point(191, 191)
        tea.Location = New Point(191, 191)
        tulip.Location = New Point(191, 191)
        violet.Location = New Point(191, 191)
        walnut.Location = New Point(191, 191)
        wheat.Location = New Point(191, 191)
    End Sub

    Private Sub wait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wait.Tick
        'number assignment, show sciname, show clues
        Select Case ctr
            Case 1
                apple.Show()

                number = 1
                wait.Enabled = False
                animation.Enabled = True
            Case 2
                banana.Show()

                number = 2
                wait.Enabled = False
                animation.Enabled = True
            Case 3
                guava.Show()

                number = 3
                wait.Enabled = False
                animation.Enabled = True
            Case 4
                mango.Show()

                number = 4
                wait.Enabled = False
                animation.Enabled = True
            Case 5
                lemon.Show()

                number = 5
                wait.Enabled = False
                animation.Enabled = True
            Case 6
                potato.Show()

                number = 6
                wait.Enabled = False
                animation.Enabled = True
            Case 7
                ginger.Show()

                number = 7
                wait.Enabled = False
                animation.Enabled = True
            Case 8
                rice.Show()

                number = 8
                wait.Enabled = False
                animation.Enabled = True
            Case 9
                bamboo.Show()

                number = 9
                wait.Enabled = False
                animation.Enabled = True
            Case 10
                orange.Show()

                number = 10
                wait.Enabled = False
                animation.Enabled = True
            Case 11
                cucumber.Show()

                number = 11
                wait.Enabled = False
                animation.Enabled = True
            Case 12
                eggplant.Show()

                number = 12
                wait.Enabled = False
                animation.Enabled = True
            Case 13
                pineapple.Show()

                number = 13
                wait.Enabled = False
                animation.Enabled = True
            Case 14
                starapple.Show()

                number = 14
                wait.Enabled = False
                animation.Enabled = True
            Case 15
                tomato.Show()

                number = 15
                wait.Enabled = False
                animation.Enabled = True
            Case 16
                watermelon.Show()

                number = 16
                wait.Enabled = False
                animation.Enabled = True
            Case 17
                blackpepper.Show()

                number = 17
                wait.Enabled = False
                animation.Enabled = True
            Case 18
                lettuce.Show()


                number = 18
                wait.Enabled = False
                animation.Enabled = True
            Case 19
                radish.Show()
                number = 19
                wait.Enabled = False
                animation.Enabled = True

            Case 20
                spinach.Show()

                number = 20
                wait.Enabled = False
                animation.Enabled = True
            Case 21
                staranise.Show()

                number = 21
                wait.Enabled = False
                animation.Enabled = True
            Case 22
                sweetpotato.Show()

                number = 22
                wait.Enabled = False
                animation.Enabled = True
            Case 23
                blueberry.Show()

                number = 23
                wait.Enabled = False
                animation.Enabled = True
            Case 24
                cabbage.Show()

                number = 24
                wait.Enabled = False
                animation.Enabled = True
            Case 25
                capsicum.Show()

                number = 25
                wait.Enabled = False
                animation.Enabled = True
            Case 26
                cashewnut.Show()

                number = 26
                wait.Enabled = False
                animation.Enabled = True
            Case 27
                cherry.Show()

                number = 27
                wait.Enabled = False
                animation.Enabled = True
            Case 28
                chiku.Show()

                number = 28
                wait.Enabled = False
                animation.Enabled = True
            Case 29
                cinnamon.Show()

                number = 29
                wait.Enabled = False
                animation.Enabled = True
            Case 30
                clove.Show()

                number = 30
                wait.Enabled = False
                animation.Enabled = True
            Case 31
                coriander.Show()

                number = 31
                wait.Enabled = False
                animation.Enabled = True
            Case 32
                cotton.Show()

                number = 32
                wait.Enabled = False
                animation.Enabled = True
            Case 33
                dewberry.Show()

                number = 33
                wait.Enabled = False
                animation.Enabled = True
            Case 34
                durian.Show()

                number = 34
                wait.Enabled = False
                animation.Enabled = True
            Case 35
                fuchsia.Show()

                number = 35
                wait.Enabled = False
                animation.Enabled = True
            Case 36
                garlic.Show()

                number = 36
                wait.Enabled = False
                animation.Enabled = True
            Case 37
                ivy.Show()

                number = 37
                wait.Enabled = False
                animation.Enabled = True
            Case 38
                jackfruit.Show()

                number = 38
                wait.Enabled = False
                animation.Enabled = True
            Case 39
                jasmine.Show()

                number = 39
                wait.Enabled = False
                animation.Enabled = True
            Case 40
                laurel.Show()

                number = 40
                wait.Enabled = False
                animation.Enabled = True
            Case 41
                lilac.Show()

                number = 41
                wait.Enabled = False
                animation.Enabled = True
            Case 42
                malunggay.Show()

                number = 42
                wait.Enabled = False
                animation.Enabled = True
            Case 43
                maple.Show()

                number = 43
                wait.Enabled = False
                animation.Enabled = True
            Case 44
                oak.Show()

                number = 44
                wait.Enabled = False
                animation.Enabled = True
            Case 45
                olive.Show()

                number = 45
                wait.Enabled = False
                animation.Enabled = True
            Case 46
                papaya.Show()

                number = 46
                wait.Enabled = False
                animation.Enabled = True
            Case 47
                pea.Show()

                number = 47
                wait.Enabled = False
                animation.Enabled = True
            Case 48
                peach.Show()

                number = 48
                wait.Enabled = False
                animation.Enabled = True
            Case 49
                peanut.Show()

                number = 49
                wait.Enabled = False
                animation.Enabled = True
            Case 50
                pear.Show()

                number = 50
                wait.Enabled = False
                animation.Enabled = True
            Case 51
                pine.Show()

                number = 51
                wait.Enabled = False
                animation.Enabled = True
            Case 52
                poisonivy.Show()

                number = 52
                wait.Enabled = False
                animation.Enabled = True
            Case 53
                raspberry.Show()

                number = 53
                wait.Enabled = False
                animation.Enabled = True
            Case 54
                rosemary.Show()

                number = 54
                wait.Enabled = False
                animation.Enabled = True
            Case 55
                soyabean.Show()

                number = 55
                wait.Enabled = False
                animation.Enabled = True
            Case 56
                strawberry.Show()

                number = 56
                wait.Enabled = False
                animation.Enabled = True
            Case 57
                sunflower.Show()


                number = 57
                wait.Enabled = False
                animation.Enabled = True
            Case 58
                tamarind.Show()

                number = 58
                wait.Enabled = False
                animation.Enabled = True
            Case 59
                tawatawa.Show()

                number = 59
                wait.Enabled = False
                animation.Enabled = True
            Case 60
                tea.Show()

                number = 60
                wait.Enabled = False
                animation.Enabled = True
            Case 61
                tulip.Show()

                number = 61
                wait.Enabled = False
                animation.Enabled = True
            Case 62
                violet.Show()

                number = 62
                wait.Enabled = False
                animation.Enabled = True
            Case 63
                walnut.Show()

                number = 63
                wait.Enabled = False
                animation.Enabled = True
            Case 64
                wheat.Show()

                number = 64
                wait.Enabled = False
                animation.Enabled = True

        End Select
    End Sub

    Private Sub animation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animation.Tick
        'move scinames down, hide scinames if time's up
        If number = 1 Then

            apple.Location = New Point(apple.Location.X, apple.Location.Y + 1)
            If apple.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                apple.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: APPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 2 Then

            banana.Location = New Point(banana.Location.X, banana.Location.Y + 1)
            If banana.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                banana.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: BANANA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 3 Then

            guava.Location = New Point(guava.Location.X, guava.Location.Y + 1)
            If guava.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                guava.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: GUAVA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 4 Then

            mango.Location = New Point(mango.Location.X, mango.Location.Y + 1)
            If mango.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                mango.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: MANGO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 5 Then

            lemon.Location = New Point(lemon.Location.X, lemon.Location.Y + 1)
            If lemon.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                lemon.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: LEMON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 6 Then

            potato.Location = New Point(potato.Location.X, potato.Location.Y + 1)
            If potato.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                potato.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: POTATO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 7 Then

            ginger.Location = New Point(ginger.Location.X, ginger.Location.Y + 1)
            If ginger.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                ginger.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: GINGER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 8 Then

            rice.Location = New Point(rice.Location.X, rice.Location.Y + 1)
            If rice.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                rice.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: RICE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 9 Then

            bamboo.Location = New Point(bamboo.Location.X, bamboo.Location.Y + 1)
            If bamboo.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                bamboo.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: BAMBOO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 10 Then

            orange.Location = New Point(orange.Location.X, orange.Location.Y + 1)
            If orange.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                orange.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: ORANGE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 11 Then

            cucumber.Location = New Point(cucumber.Location.X, cucumber.Location.Y + 1)
            If cucumber.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cucumber.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CUCUMBER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 12 Then

            eggplant.Location = New Point(eggplant.Location.X, eggplant.Location.Y + 1)
            If eggplant.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                eggplant.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: EGGPLANT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 13 Then

            pineapple.Location = New Point(pineapple.Location.X, pineapple.Location.Y + 1)
            If pineapple.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                pineapple.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time.  The correct answer is: PINEAPPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 14 Then

            starapple.Location = New Point(starapple.Location.X, starapple.Location.Y + 1)
            If starapple.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                starapple.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: STAR APPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 15 Then

            tomato.Location = New Point(tomato.Location.X, tomato.Location.Y + 1)
            If tomato.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tomato.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TOMATO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 16 Then

            watermelon.Location = New Point(watermelon.Location.X, watermelon.Location.Y + 1)
            If watermelon.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                watermelon.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: WATERMELON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 17 Then

            blackpepper.Location = New Point(blackpepper.Location.X, blackpepper.Location.Y + 1)
            If blackpepper.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                blackpepper.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: BLACK PEPPER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 18 Then

            lettuce.Location = New Point(lettuce.Location.X, lettuce.Location.Y + 1)
            If lettuce.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                lettuce.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time.  The correct answer is: LETTUCE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 19 Then

            radish.Location = New Point(radish.Location.X, radish.Location.Y + 1)
            If radish.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                radish.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: RADISH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 20 Then

            spinach.Location = New Point(spinach.Location.X, spinach.Location.Y + 1)
            If spinach.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                spinach.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SPINACH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 21 Then

            staranise.Location = New Point(staranise.Location.X, staranise.Location.Y + 1)
            If staranise.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                staranise.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: STAR ANISE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 22 Then

            sweetpotato.Location = New Point(sweetpotato.Location.X, sweetpotato.Location.Y + 1)
            If sweetpotato.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                sweetpotato.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time.  The correct answer is: SWEET POTATO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 23 Then

            blueberry.Location = New Point(blueberry.Location.X, blueberry.Location.Y + 1)
            If blueberry.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                blueberry.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: BLUEBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 24 Then

            cabbage.Location = New Point(cabbage.Location.X, cabbage.Location.Y + 1)
            If cabbage.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cabbage.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CABBAGE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 25 Then

            capsicum.Location = New Point(capsicum.Location.X, capsicum.Location.Y + 1)
            If capsicum.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                capsicum.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CAPSICUM. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 26 Then

            cashewnut.Location = New Point(cashewnut.Location.X, cashewnut.Location.Y + 1)
            If cashewnut.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cashewnut.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CASHEW NUT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 27 Then

            cherry.Location = New Point(cherry.Location.X, cherry.Location.Y + 1)
            If cherry.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cherry.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CHERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 28 Then

            chiku.Location = New Point(chiku.Location.X, chiku.Location.Y + 1)
            If chiku.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                chiku.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CHIKU. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 29 Then

            cinnamon.Location = New Point(cinnamon.Location.X, cinnamon.Location.Y + 1)
            If cinnamon.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cinnamon.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CINNAMON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 30 Then

            clove.Location = New Point(clove.Location.X, clove.Location.Y + 1)
            If clove.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                clove.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CLOVE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 31 Then

            coriander.Location = New Point(coriander.Location.X, coriander.Location.Y + 1)
            If coriander.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                coriander.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CORIANDER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 32 Then

            cotton.Location = New Point(cotton.Location.X, cotton.Location.Y + 1)
            If cotton.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cotton.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: COTTON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 33 Then

            dewberry.Location = New Point(dewberry.Location.X, dewberry.Location.Y + 1)
            If dewberry.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                dewberry.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: DEWBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 34 Then

            durian.Location = New Point(durian.Location.X, durian.Location.Y + 1)
            If durian.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                durian.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: DURIAN. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 35 Then

            fuchsia.Location = New Point(fuchsia.Location.X, fuchsia.Location.Y + 1)
            If fuchsia.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                fuchsia.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: FUCHSIA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 36 Then

            garlic.Location = New Point(garlic.Location.X, garlic.Location.Y + 1)
            If garlic.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                garlic.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: GARLIC. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 37 Then

            ivy.Location = New Point(ivy.Location.X, ivy.Location.Y + 1)
            If ivy.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                ivy.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: IVY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 38 Then

            jackfruit.Location = New Point(jackfruit.Location.X, jackfruit.Location.Y + 1)
            If jackfruit.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                jackfruit.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: JACKFRUIT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 39 Then

            jasmine.Location = New Point(jasmine.Location.X, jasmine.Location.Y + 1)
            If jasmine.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                jasmine.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: JASMINE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 40 Then

            laurel.Location = New Point(laurel.Location.X, laurel.Location.Y + 1)
            If laurel.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                laurel.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: LAUREL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 41 Then

            lilac.Location = New Point(lilac.Location.X, lilac.Location.Y + 1)
            If lilac.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                lilac.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: LILAC. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 42 Then

            malunggay.Location = New Point(malunggay.Location.X, malunggay.Location.Y + 1)
            If malunggay.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                malunggay.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: MALUNGGAY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 43 Then

            maple.Location = New Point(maple.Location.X, maple.Location.Y + 1)
            If maple.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                maple.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: MAPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 44 Then

            oak.Location = New Point(oak.Location.X, oak.Location.Y + 1)
            If oak.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                oak.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: OAK. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 45 Then

            olive.Location = New Point(olive.Location.X, olive.Location.Y + 1)
            If olive.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                olive.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: OLIVE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 46 Then

            papaya.Location = New Point(papaya.Location.X, papaya.Location.Y + 1)
            If papaya.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                papaya.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PAPAYA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 47 Then

            pea.Location = New Point(pea.Location.X, pea.Location.Y + 1)
            If pea.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                pea.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PEA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 48 Then

            peach.Location = New Point(peach.Location.X, peach.Location.Y + 1)
            If peach.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                peach.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PEACH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 49 Then

            peanut.Location = New Point(peanut.Location.X, peanut.Location.Y + 1)
            If peanut.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                peanut.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PEANUT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 50 Then

            pear.Location = New Point(pear.Location.X, pear.Location.Y + 1)
            If pear.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                pear.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PEAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 51 Then

            pine.Location = New Point(pine.Location.X, pine.Location.Y + 1)
            If pine.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                pine.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PINE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 52 Then

            poisonivy.Location = New Point(poisonivy.Location.X, poisonivy.Location.Y + 1)
            If poisonivy.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                poisonivy.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: POISON IVY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 53 Then

            raspberry.Location = New Point(raspberry.Location.X, raspberry.Location.Y + 1)
            If raspberry.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                raspberry.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: RASPBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 54 Then

            rosemary.Location = New Point(rosemary.Location.X, rosemary.Location.Y + 1)
            If rosemary.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                rosemary.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: ROSEMARY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 55 Then

            soyabean.Location = New Point(soyabean.Location.X, soyabean.Location.Y + 1)
            If soyabean.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                soyabean.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SOYA BEAN. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 56 Then

            strawberry.Location = New Point(strawberry.Location.X, strawberry.Location.Y + 1)
            If strawberry.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                strawberry.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: STRAWBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 57 Then

            sunflower.Location = New Point(sunflower.Location.X, sunflower.Location.Y + 1)
            If sunflower.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                sunflower.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SUNFLOWER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 58 Then

            tamarind.Location = New Point(tamarind.Location.X, tamarind.Location.Y + 1)
            If tamarind.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tamarind.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TAMARIND. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 59 Then

            tawatawa.Location = New Point(tawatawa.Location.X, tawatawa.Location.Y + 1)
            If tawatawa.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tawatawa.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TAWA TAWA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 60 Then

            tea.Location = New Point(tea.Location.X, tea.Location.Y + 1)
            If tea.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tea.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TEA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 61 Then

            tulip.Location = New Point(tulip.Location.X, tulip.Location.Y + 1)
            If tulip.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tulip.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TULIP. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 62 Then

            violet.Location = New Point(violet.Location.X, violet.Location.Y + 1)
            If violet.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                violet.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: VIOET. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 63 Then

            walnut.Location = New Point(walnut.Location.X, walnut.Location.Y + 1)
            If walnut.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                walnut.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: WALNUT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 64 Then

            wheat.Location = New Point(wheat.Location.X, wheat.Location.Y + 1)
            If wheat.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                wheat.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: WHEAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
    End Sub


    Private Sub enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim Answer As String
        Answer = TextBox2.Text
        'checking of user's answer
        If number = 1 Then
            If Answer = "APPLE" And apple.Location.Y < 520 Then
                Score = Score + 10
                apple.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                apple.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: APPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 2 Then
            If Answer = "BANANA" And banana.Location.Y < 520 Then
                Score = Score + 10
                banana.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                banana.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BANANA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 3 Then
            If Answer = "GUAVA" And guava.Location.Y < 520 Then
                Score = Score + 10
                guava.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                guava.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: GUAVA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 4 Then
            If Answer = "MANGO" And mango.Location.Y < 520 Then
                Score = Score + 10
                mango.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                mango.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: MANGO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 5 Then
            If Answer = "LEMON" And lemon.Location.Y < 520 Then
                Score = Score + 10
                lemon.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                lemon.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LEMON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 6 Then
            If Answer = "POTATO" And potato.Location.Y < 520 Then
                Score = Score + 10
                potato.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                potato.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: POTATO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 7 Then
            If Answer = "GINGER" And ginger.Location.Y < 520 Then
                Score = Score + 10
                ginger.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                ginger.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: GINGER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 8 Then
            If Answer = "RICE" And rice.Location.Y < 520 Then
                Score = Score + 10
                rice.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                rice.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: RICE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 9 Then
            If Answer = "BAMBOO" And bamboo.Location.Y < 520 Then
                Score = Score + 10
                bamboo.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                bamboo.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BAMBOO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 10 Then
            If Answer = "ORANGE" And orange.Location.Y < 520 Then
                Score = Score + 10
                orange.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                orange.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: ORANGE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 11 Then
            If Answer = "CUCUMBER" And cucumber.Location.Y < 520 Then
                Score = Score + 10
                cucumber.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cucumber.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CUCUMBER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 12 Then
            If Answer = "EGGPLANT" And eggplant.Location.Y < 520 Then
                Score = Score + 10
                eggplant.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                eggplant.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: EGGPLANT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 13 Then
            If Answer = "PINEAPPLE" And pineapple.Location.Y < 520 Then
                Score = Score + 10
                pineapple.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                pineapple.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PINEAPPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 14 Then
            If Answer = "STAR APPLE" And starapple.Location.Y < 520 Then
                Score = Score + 10
                starapple.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                starapple.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: STAR APPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 15 Then
            If Answer = "TOMATO" And tomato.Location.Y < 520 Then
                Score = Score + 10
                tomato.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tomato.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TOMATO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 16 Then
            If Answer = "WATERMELON" And watermelon.Location.Y < 520 Then
                Score = Score + 10
                watermelon.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                watermelon.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: WATERMELON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 17 Then
            If Answer = "BLACK PEPPER" And blackpepper.Location.Y < 520 Then
                Score = Score + 10
                blackpepper.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                blackpepper.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BLACK PEPPER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 18 Then
            If Answer = "LETTUCE" And lettuce.Location.Y < 520 Then
                Score = Score + 10
                lettuce.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                lettuce.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LETTUCE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 19 Then
            If Answer = "RADISH" And radish.Location.Y < 520 Then
                Score = Score + 10
                radish.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                radish.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: RADISH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 20 Then
            If Answer = "SPINACH" And spinach.Location.Y < 520 Then
                Score = Score + 10
                spinach.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                spinach.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SPINACH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 21 Then
            If Answer = "STAR ANISE" And staranise.Location.Y < 520 Then
                Score = Score + 10
                staranise.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                staranise.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: STAR ANISE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 22 Then
            If Answer = "SWEET POTATO" And sweetpotato.Location.Y < 520 Then
                Score = Score + 10
                sweetpotato.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                sweetpotato.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SWEET POTATO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 23 Then
            If Answer = "BLUEBERRY" And blueberry.Location.Y < 520 Then
                Score = Score + 10
                blueberry.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                blueberry.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BLUEBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 24 Then
            If Answer = "CABBAGE" And cabbage.Location.Y < 520 Then
                Score = Score + 10
                cabbage.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cabbage.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CABBAGE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 25 Then
            If Answer = "CAPSICUM" And capsicum.Location.Y < 520 Then
                Score = Score + 10
                capsicum.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                capsicum.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CAPSICUM. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 26 Then
            If Answer = "CASHEW NUT" And cashewnut.Location.Y < 520 Then
                Score = Score + 10
                cashewnut.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cashewnut.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CASHEW NUT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 27 Then
            If Answer = "CHERRY" And cherry.Location.Y < 520 Then
                Score = Score + 10
                cherry.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cherry.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CHERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 28 Then
            If Answer = "CHIKU" And chiku.Location.Y < 520 Then
                Score = Score + 10
                chiku.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                chiku.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CHIKU. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 29 Then
            If Answer = "CINNAMON" And cinnamon.Location.Y < 520 Then
                Score = Score + 10
                cinnamon.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cinnamon.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CINNAMON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 30 Then
            If Answer = "CLOVE" And clove.Location.Y < 520 Then
                Score = Score + 10
                clove.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                clove.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CLOVE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 31 Then
            If Answer = "CORIANDER" And coriander.Location.Y < 520 Then
                Score = Score + 10
                coriander.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                coriander.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CORIANDER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 32 Then
            If Answer = "COTTON" And cotton.Location.Y < 520 Then
                Score = Score + 10
                cotton.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cotton.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: COTTON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 33 Then
            If Answer = "DEWBERRY" And dewberry.Location.Y < 520 Then
                Score = Score + 10
                dewberry.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                dewberry.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: DEWBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 34 Then
            If Answer = "DURIAN" And durian.Location.Y < 520 Then
                Score = Score + 10
                durian.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                durian.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: DURIAN. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 35 Then
            If Answer = "FUCHSIA" And fuchsia.Location.Y < 520 Then
                Score = Score + 10
                fuchsia.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                fuchsia.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: FUCHSIA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 36 Then
            If Answer = "GARLIC" And garlic.Location.Y < 520 Then
                Score = Score + 10
                garlic.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                garlic.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: GARLIC. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 37 Then
            If Answer = "IVY" And ivy.Location.Y < 520 Then
                Score = Score + 10
                ivy.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                ivy.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: IVY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 38 Then
            If Answer = "JACKFRUIT" And jackfruit.Location.Y < 520 Then
                Score = Score + 10
                jackfruit.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                jackfruit.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: JACKFRUIT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 39 Then
            If Answer = "JASMINE" And jasmine.Location.Y < 520 Then
                Score = Score + 10
                jasmine.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                jasmine.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: JASMINE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 40 Then
            If Answer = "LAUREL" And laurel.Location.Y < 520 Then
                Score = Score + 10
                laurel.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                laurel.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LAUREL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 41 Then
            If Answer = "LILAC" And lilac.Location.Y < 520 Then
                Score = Score + 10
                lilac.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                lilac.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LILAC. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 42 Then
            If Answer = "MALUNGGAY" And malunggay.Location.Y < 520 Then
                Score = Score + 10
                malunggay.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                malunggay.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: MALUNGGAY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 43 Then
            If Answer = "MAPLE" And maple.Location.Y < 520 Then
                Score = Score + 10
                maple.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                maple.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: MAPLE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 44 Then
            If Answer = "OAK" And oak.Location.Y < 520 Then
                Score = Score + 10
                oak.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                oak.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: OAK. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 45 Then
            If Answer = "OLIVE" And olive.Location.Y < 520 Then
                Score = Score + 10
                olive.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                olive.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: OLIVE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 46 Then
            If Answer = "PAPAYA" And papaya.Location.Y < 520 Then
                Score = Score + 10
                papaya.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                papaya.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PAPAYA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 47 Then
            If Answer = "PEA" And pea.Location.Y < 520 Then
                Score = Score + 10
                pea.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                pea.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PEA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 48 Then
            If Answer = "PEACH" And peach.Location.Y < 520 Then
                Score = Score + 10
                peach.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                peach.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PEACH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 49 Then
            If Answer = "PEANUT" And peanut.Location.Y < 520 Then
                Score = Score + 10
                peanut.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                peanut.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PEANUT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 50 Then
            If Answer = "PEAR" And pear.Location.Y < 520 Then
                Score = Score + 10
                pear.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                pear.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PEAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 51 Then
            If Answer = "PINE" And pine.Location.Y < 520 Then
                Score = Score + 10
                pine.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                pine.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PINE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 52 Then
            If Answer = "POISON IVY" And poisonivy.Location.Y < 520 Then
                Score = Score + 10
                poisonivy.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                poisonivy.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: POISON IVY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 53 Then
            If Answer = "RASPBERRY" And raspberry.Location.Y < 520 Then
                Score = Score + 10
                raspberry.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                raspberry.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: RASPBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 54 Then
            If Answer = "ROSEMARY" And rosemary.Location.Y < 520 Then
                Score = Score + 10
                rosemary.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                rosemary.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: ROSEMARY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 55 Then
            If Answer = "SOYA BEAN" And soyabean.Location.Y < 520 Then
                Score = Score + 10
                soyabean.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                soyabean.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SOYA BEAN. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 56 Then
            If Answer = "STRAWBERRY" And strawberry.Location.Y < 520 Then
                Score = Score + 10
                strawberry.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                strawberry.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: STRAWBERRY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 57 Then
            If Answer = "SUNFLOWER" And sunflower.Location.Y < 520 Then
                Score = Score + 10
                sunflower.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                sunflower.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SUNFLOWER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 58 Then
            If Answer = "TAMARIND" And tamarind.Location.Y < 520 Then
                Score = Score + 10
                tamarind.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tamarind.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TAMARIND. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 59 Then
            If Answer = "TAWA TAWA" And tawatawa.Location.Y < 520 Then
                Score = Score + 10
                tawatawa.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tawatawa.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TAWA TAWA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 60 Then
            If Answer = "TEA" And tea.Location.Y < 520 Then
                Score = Score + 10
                tea.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tea.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TEA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 61 Then
            If Answer = "TULIP" And tulip.Location.Y < 520 Then
                Score = Score + 10
                tulip.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tulip.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TULIP. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 62 Then
            If Answer = "VIOLET" And violet.Location.Y < 520 Then
                Score = Score + 10
                violet.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                violet.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: VIOLET. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 63 Then
            If Answer = "WALNUT" And walnut.Location.Y < 520 Then
                Score = Score + 10
                walnut.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                walnut.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: WALNUT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 64 Then
            If Answer = "WHEAT" And wheat.Location.Y < 520 Then
                Score = Score + 10
                wheat.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                wheat.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: WHEAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        go.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'shows time of playing from start
        Label6.Text = Val(Label6.Text) + (1 / 10)
    End Sub

End Class