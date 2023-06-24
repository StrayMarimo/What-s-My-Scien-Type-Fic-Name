Public Class animalsE
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
        'hide letters
        A.Hide()
        B.Hide()
        C.Hide()
        D.Hide()
        Ee.Hide()
        F.Hide()
        G.Hide()
        H.Hide()
        I.Hide()
        J.Hide()
        K.Hide()
        L.Hide()
        M.Hide()
        N.Hide()
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
        'hide scinames
        arabiancamel.Hide()
        buffalo.Hide()
        blackrat.Hide()
        bluewhale.Hide()
        cougar.Hide()
        cat.Hide()
        cobra.Hide()
        camel.Hide()
        cheetah.Hide()
        chimpanzee.Hide()
        crocodile.Hide()
        chameleon.Hide()
        dog.Hide()
        deer.Hide()
        dolphin.Hide()
        elephant.Hide()
        elk.Hide()
        frog.Hide()
        fox.Hide()
        giraffe.Hide()
        panda.Hide()
        goat.Hide()
        housefly.Hide()
        hippopotamus.Hide()
        horse.Hide()
        houselizard.Hide()
        hyena.Hide()
        iguana.Hide()
        jaguar.Hide()
        kangaroo.Hide()
        lion.Hide()
        lizard.Hide()
        leopard.Hide()
        mouse.Hide()
        ostrich.Hide()
        peacock.Hide()
        pigeon.Hide()
        polarbear.Hide()
        porcupine.Hide()
        panther.Hide()
        rabbit.Hide()
        rhinoceros.Hide()
        scorpion.Hide()
        seahorse.Hide()
        snakesea.Hide()
        squirrel.Hide()
        sparrow.Hide()
        tarantula.Hide()
        tasmaniandevil.Hide()
        tiger.Hide()
        wolf.Hide()
        wildcat.Hide()
        zebra.Hide()


    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        'hide letters of previous scinames
        A.Hide()
        B.Hide()
        C.Hide()
        D.Hide()
        Ee.Hide()
        F.Hide()
        G.Hide()
        H.Hide()
        I.Hide()
        J.Hide()
        K.Hide()
        L.Hide()
        M.Hide()
        N.Hide()
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

        go.Enabled = False
        Timer1.Enabled = True
        Dim rn As New Random
        ctr = rn.Next(1, 53) 'randomize scinames
        wait.Enabled = True
        'scinames back to start position
        cat.Location = New Point(191, 191)
        cobra.Location = New Point(191, 191)
        camel.Location = New Point(191, 191)
        cheetah.Location = New Point(191, 191)
        chimpanzee.Location = New Point(191, 191)
        crocodile.Location = New Point(191, 191)
        chameleon.Location = New Point(191, 191)
        dog.Location = New Point(191, 191)
        deer.Location = New Point(191, 191)
        elephant.Location = New Point(191, 191)
        dolphin.Location = New Point(191, 191)
        frog.Location = New Point(191, 191)
        fox.Location = New Point(191, 191)
        giraffe.Location = New Point(191, 191)
        panda.Location = New Point(191, 191)
        goat.Location = New Point(191, 191)
        housefly.Location = New Point(191, 191)
        hippopotamus.Location = New Point(191, 191)
        horse.Location = New Point(191, 191)
        kangaroo.Location = New Point(191, 191)
        lion.Location = New Point(191, 191)
        lizard.Location = New Point(191, 191)
        mouse.Location = New Point(191, 191)
        panther.Location = New Point(191, 191)
        rabbit.Location = New Point(191, 191)
        squirrel.Location = New Point(191, 191)
        tiger.Location = New Point(191, 191)
        zebra.Location = New Point(191, 191)
        buffalo.Location = New Point(191, 191)
        bluewhale.Location = New Point(191, 191)
        cougar.Location = New Point(191, 191)
        elk.Location = New Point(191, 191)
        wolf.Location = New Point(191, 191)
        jaguar.Location = New Point(191, 191)
        iguana.Location = New Point(191, 191)
        leopard.Location = New Point(191, 191)
        ostrich.Location = New Point(191, 191)
        polarbear.Location = New Point(191, 191)
        sparrow.Location = New Point(191, 191)
        tarantula.Location = New Point(191, 191)
        tasmaniandevil.Location = New Point(191, 191)
        wildcat.Location = New Point(191, 191)
        peacock.Location = New Point(191, 191)
        pigeon.Location = New Point(191, 191)
        arabiancamel.Location = New Point(191, 191)
        houselizard.Location = New Point(191, 191)
        snakesea.Location = New Point(191, 191)
        hyena.Location = New Point(191, 191)
        porcupine.Location = New Point(191, 191)
        rhinoceros.Location = New Point(191, 191)
        seahorse.Location = New Point(191, 191)
        blackrat.Location = New Point(191, 191)
        scorpion.Location = New Point(191, 191)
    End Sub

    Private Sub wait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wait.Tick
        'number assignment, show sciname, show clues
        Select Case ctr
            Case 1
                cat.Show()
                A.Show()
                C.Show()
                T.Show()
                number = 1
                wait.Enabled = False
                animation.Enabled = True
            Case 2
                cobra.Show()
                A.Show()
                B.Show()
                C.Show()
                O.Show()
                R.Show()
                number = 2
                wait.Enabled = False
                animation.Enabled = True
            Case 3
                camel.Show()
                A.Show()
                C.Show()
                Ee.Show()
                L.Show()
                M.Show()
                number = 3
                wait.Enabled = False
                animation.Enabled = True
            Case 4
                cheetah.Show()
                A.Show()
                C.Show()
                Ee.Show()
                H.Show()
                T.Show()
                number = 4
                wait.Enabled = False
                animation.Enabled = True
            Case 5
                chimpanzee.Show()
                A.Show()
                C.Show()
                Ee.Show()
                H.Show()
                I.Show()
                M.Show()
                N.Show()
                P.Show()
                Z.Show()
                number = 5
                wait.Enabled = False
                animation.Enabled = True
            Case 6
                crocodile.Show()
                C.Show()
                D.Show()
                Ee.Show()
                I.Show()
                L.Show()
                O.Show()
                R.Show()
                number = 6
                wait.Enabled = False
                animation.Enabled = True
            Case 7
                chameleon.Show()
                A.Show()
                C.Show()
                Ee.Show()
                H.Show()
                L.Show()
                M.Show()
                N.Show()
                O.Show()
                number = 7
                wait.Enabled = False
                animation.Enabled = True
            Case 8
                dog.Show()
                D.Show()
                G.Show()
                O.Show()
                number = 8
                wait.Enabled = False
                animation.Enabled = True
            Case 9
                deer.Show()
                D.Show()
                Ee.Show()
                R.Show()
                number = 9
                wait.Enabled = False
                animation.Enabled = True
            Case 10
                elephant.Show()
                A.Show()
                Ee.Show()
                H.Show()
                L.Show()
                N.Show()
                P.Show()
                T.Show()
                number = 10
                wait.Enabled = False
                animation.Enabled = True
            Case 11
                dolphin.Show()
                D.Show()
                H.Show()
                I.Show()
                L.Show()
                N.Show()
                O.Show()
                P.Show()
                number = 11
                wait.Enabled = False
                animation.Enabled = True
            Case 12
                frog.Show()
                F.Show()
                G.Show()
                O.Show()
                R.Show()
                number = 12
                wait.Enabled = False
                animation.Enabled = True
            Case 13
                fox.Show()
                F.Show()
                O.Show()
                X.Show()
                number = 13
                wait.Enabled = False
                animation.Enabled = True
            Case 14
                giraffe.Show()
                A.Show()
                Ee.Show()
                F.Show()
                G.Show()
                I.Show()
                R.Show()
                number = 14
                wait.Enabled = False
                animation.Enabled = True
            Case 15
                panda.Show()
                A.Show()
                D.Show()
                N.Show()
                P.Show()
                number = 15
                wait.Enabled = False
                animation.Enabled = True
            Case 16
                goat.Show()
                A.Show()
                G.Show()
                O.Show()
                T.Show()
                number = 16
                wait.Enabled = False
                animation.Enabled = True
            Case 17
                housefly.Show()
                Ee.Show()
                F.Show()
                H.Show()
                L.Show()
                O.Show()
                S.Show()
                U.Show()
                Y.Show()
                number = 17
                wait.Enabled = False
                animation.Enabled = True
            Case 18
                hippopotamus.Show()
                A.Show()
                H.Show()
                I.Show()
                M.Show()
                O.Show()
                P.Show()
                S.Show()
                T.Show()
                U.Show()
                number = 18
                wait.Enabled = False
                animation.Enabled = True
            Case 19
                horse.Show()
                number = 19
                wait.Enabled = False
                animation.Enabled = True
                Ee.Show()
                H.Show()
                O.Show()
                R.Show()
                S.Show()
            Case 20
                kangaroo.Show()
                A.Show()
                G.Show()
                K.Show()
                N.Show()
                O.Show()
                R.Show()
                number = 20
                wait.Enabled = False
                animation.Enabled = True
            Case 21
                lion.Show()
                I.Show()
                L.Show()
                O.Show()
                N.Show()
                number = 21
                wait.Enabled = False
                animation.Enabled = True
            Case 22
                lizard.Show()
                A.Show()
                D.Show()
                I.Show()
                L.Show()
                R.Show()
                Z.Show()
                number = 22
                wait.Enabled = False
                animation.Enabled = True
            Case 23
                mouse.Show()
                Ee.Show()
                M.Show()
                O.Show()
                S.Show()
                U.Show()
                number = 23
                wait.Enabled = False
                animation.Enabled = True
            Case 24
                panther.Show()
                A.Show()
                Ee.Show()
                H.Show()
                N.Show()
                P.Show()
                R.Show()
                T.Show()
                number = 24
                wait.Enabled = False
                animation.Enabled = True
            Case 25
                rabbit.Show()
                A.Show()
                B.Show()
                I.Show()
                R.Show()
                T.Show()
                number = 25
                wait.Enabled = False
                animation.Enabled = True
            Case 26
                squirrel.Show()
                Ee.Show()
                I.Show()
                L.Show()
                Q.Show()
                R.Show()
                S.Show()
                number = 26
                wait.Enabled = False
                animation.Enabled = True
            Case 27
                tiger.Show()
                Ee.Show()
                G.Show()
                I.Show()
                R.Show()
                T.Show()
                number = 27
                wait.Enabled = False
                animation.Enabled = True
            Case 28
                zebra.Show()
                A.Show()
                B.Show()
                Ee.Show()
                R.Show()
                Z.Show()
                number = 28
                wait.Enabled = False
                animation.Enabled = True
            Case 29
                buffalo.Show()
                A.Show()
                B.Show()
                F.Show()
                L.Show()
                O.Show()
                U.Show()
                number = 29
                wait.Enabled = False
                animation.Enabled = True
            Case 30
                bluewhale.Show()
                A.Show()
                B.Show()
                Ee.Show()
                H.Show()
                L.Show()
                U.Show()
                W.Show()
                number = 30
                wait.Enabled = False
                animation.Enabled = True
            Case 31
                cougar.Show()
                A.Show()
                C.Show()
                G.Show()
                O.Show()
                R.Show()
                U.Show()
                number = 31
                wait.Enabled = False
                animation.Enabled = True
            Case 32
                elk.Show()
                Ee.Show()
                K.Show()
                L.Show()
                number = 32
                wait.Enabled = False
                animation.Enabled = True
            Case 33
                wolf.Show()
                F.Show()
                L.Show()
                O.Show()
                W.Show()
                number = 33
                wait.Enabled = False
                animation.Enabled = True
            Case 34
                jaguar.Show()
                A.Show()
                G.Show()
                J.Show()
                R.Show()
                U.Show()
                number = 34
                wait.Enabled = False
                animation.Enabled = True
            Case 35
                iguana.Show()
                A.Show()
                G.Show()
                I.Show()
                N.Show()
                U.Show()
                number = 35
                wait.Enabled = False
                animation.Enabled = True
            Case 36
                leopard.Show()
                A.Show()
                D.Show()
                Ee.Show()
                L.Show()
                O.Show()
                P.Show()
                R.Show()
                number = 36
                wait.Enabled = False
                animation.Enabled = True
            Case 37
                ostrich.Show()
                C.Show()
                H.Show()
                I.Show()
                O.Show()
                R.Show()
                S.Show()
                T.Show()
                number = 37
                wait.Enabled = False
                animation.Enabled = True
            Case 38
                polarbear.Show()
                A.Show()
                B.Show()
                Ee.Show()
                L.Show()
                O.Show()
                P.Show()
                R.Show()
                number = 38
                wait.Enabled = False
                animation.Enabled = True
            Case 39
                sparrow.Show()
                A.Show()
                O.Show()
                P.Show()
                R.Show()
                S.Show()
                W.Show()
                number = 39
                wait.Enabled = False
                animation.Enabled = True
            Case 40
                tarantula.Show()
                A.Show()
                L.Show()
                N.Show()
                R.Show()
                T.Show()
                U.Show()
                number = 40
                wait.Enabled = False
                animation.Enabled = True
            Case 41
                tasmaniandevil.Show()
                A.Show()
                D.Show()
                Ee.Show()
                I.Show()
                L.Show()
                M.Show()
                N.Show()
                S.Show()
                T.Show()
                V.Show()
                number = 41
                wait.Enabled = False
                animation.Enabled = True
            Case 42
                wildcat.Show()
                A.Show()
                C.Show()
                D.Show()
                I.Show()
                L.Show()
                T.Show()
                W.Show()
                number = 42
                wait.Enabled = False
                animation.Enabled = True
            Case 43
                peacock.Show()
                A.Show()
                C.Show()
                Ee.Show()
                K.Show()
                O.Show()
                P.Show()
                number = 43
                wait.Enabled = False
                animation.Enabled = True
            Case 44
                pigeon.Show()
                Ee.Show()
                G.Show()
                I.Show()
                N.Show()
                O.Show()
                P.Show()
                number = 44
                wait.Enabled = False
                animation.Enabled = True
            Case 45
                arabiancamel.Show()
                A.Show()
                B.Show()
                C.Show()
                Ee.Show()
                I.Show()
                L.Show()
                M.Show()
                N.Show()
                R.Show()
                number = 45
                wait.Enabled = False
                animation.Enabled = True
            Case 46
                houselizard.Show()
                A.Show()
                D.Show()
                Ee.Show()
                H.Show()
                I.Show()
                L.Show()
                O.Show()
                R.Show()
                S.Show()
                U.Show()
                Z.Show()
                number = 46
                wait.Enabled = False
                animation.Enabled = True
            Case 47
                blackrat.Show()
                A.Show()
                B.Show()
                C.Show()
                K.Show()
                L.Show()
                R.Show()
                T.Show()
                number = 47
                wait.Enabled = False
                animation.Enabled = True
            Case 48
                snakesea.Show()
                A.Show()
                Ee.Show()
                K.Show()
                N.Show()
                S.Show()
                number = 48
                wait.Enabled = False
                animation.Enabled = True
            Case 49
                hyena.Show()
                A.Show()
                Ee.Show()
                H.Show()
                N.Show()
                Y.Show()
                number = 49
                wait.Enabled = False
                animation.Enabled = True
            Case 50
                porcupine.Show()
                C.Show()
                Ee.Show()
                I.Show()
                N.Show()
                P.Show()
                O.Show()
                R.Show()
                U.Show()
                number = 50
                wait.Enabled = False
                animation.Enabled = True
            Case 51
                rhinoceros.Show()
                C.Show()
                Ee.Show()
                H.Show()
                I.Show()
                N.Show()
                O.Show()
                R.Show()
                S.Show()
                number = 51
                wait.Enabled = False
                animation.Enabled = True
            Case 52
                scorpion.Show()
                C.Show()
                I.Show()
                N.Show()
                O.Show()
                P.Show()
                R.Show()
                S.Show()
                number = 52
                wait.Enabled = False
                animation.Enabled = True
            Case 53
                seahorse.Show()
                A.Show()
                Ee.Show()
                H.Show()
                O.Show()
                R.Show()
                S.Show()
                number = 53
                wait.Enabled = False
                animation.Enabled = True


        End Select
    End Sub

    Private Sub animation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animation.Tick
        'move scinames down, hide scinames if time's up
        If number = 1 Then

            cat.Location = New Point(cat.Location.X, cat.Location.Y + 1)
            If cat.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cat.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 2 Then

            cobra.Location = New Point(cobra.Location.X, cobra.Location.Y + 1)
            If cobra.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cobra.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: COBRA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 3 Then

            camel.Location = New Point(camel.Location.X, camel.Location.Y + 1)
            If camel.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                camel.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CAMEL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 4 Then

            cheetah.Location = New Point(cheetah.Location.X, cheetah.Location.Y + 1)
            If cheetah.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cheetah.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CHEETAH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 5 Then

            chimpanzee.Location = New Point(chimpanzee.Location.X, chimpanzee.Location.Y + 1)
            If chimpanzee.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                chimpanzee.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CHIMPANZEE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 6 Then

            crocodile.Location = New Point(crocodile.Location.X, crocodile.Location.Y + 1)
            If crocodile.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                crocodile.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CROCODILE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 7 Then

            chameleon.Location = New Point(chameleon.Location.X, chameleon.Location.Y + 1)
            If chameleon.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                chameleon.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: CHAMELEON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 8 Then

            dog.Location = New Point(dog.Location.X, dog.Location.Y + 1)
            If dog.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                dog.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: DOG. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 9 Then

            deer.Location = New Point(deer.Location.X, deer.Location.Y + 1)
            If deer.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                deer.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: DEER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 10 Then

            elephant.Location = New Point(elephant.Location.X, elephant.Location.Y + 1)
            If elephant.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                elephant.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: ELEPHANT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If

            End If
        End If
        If number = 11 Then

            dolphin.Location = New Point(dolphin.Location.X, dolphin.Location.Y + 1)
            If dolphin.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                dolphin.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: DOLPHIN. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 12 Then

            frog.Location = New Point(frog.Location.X, frog.Location.Y + 1)
            If frog.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                frog.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: FROG. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 13 Then

            fox.Location = New Point(fox.Location.X, fox.Location.Y + 1)
            If fox.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                fox.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time.  The correct answer is: FOX. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 14 Then

            giraffe.Location = New Point(giraffe.Location.X, giraffe.Location.Y + 1)
            If giraffe.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                giraffe.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: GIRAFFE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 15 Then

            panda.Location = New Point(panda.Location.X, panda.Location.Y + 1)
            If panda.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                panda.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PANDA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 16 Then

            goat.Location = New Point(goat.Location.X, goat.Location.Y + 1)
            If goat.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                goat.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: GOAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 17 Then

            housefly.Location = New Point(housefly.Location.X, housefly.Location.Y + 1)
            If housefly.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                housefly.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: HOUSE FLY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 18 Then

            hippopotamus.Location = New Point(hippopotamus.Location.X, hippopotamus.Location.Y + 1)
            If hippopotamus.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                hippopotamus.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time.  The correct answer is: HIPPOPOTAMUS. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 19 Then

            horse.Location = New Point(horse.Location.X, horse.Location.Y + 1)
            If horse.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                horse.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: HORSE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 20 Then

            kangaroo.Location = New Point(kangaroo.Location.X, kangaroo.Location.Y + 1)
            If kangaroo.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                kangaroo.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: KANGAROO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 21 Then

            lion.Location = New Point(lion.Location.X, lion.Location.Y + 1)
            If lion.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                lion.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: LION. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 22 Then

            lizard.Location = New Point(lizard.Location.X, lizard.Location.Y + 1)
            If lizard.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                lizard.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time.  The correct answer is: LIZARD. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 23 Then

            mouse.Location = New Point(mouse.Location.X, mouse.Location.Y + 1)
            If mouse.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                mouse.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: MOUSE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 24 Then

            panther.Location = New Point(panther.Location.X, panther.Location.Y + 1)
            If panther.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                panther.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PANTHER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 25 Then

            rabbit.Location = New Point(rabbit.Location.X, rabbit.Location.Y + 1)
            If rabbit.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                rabbit.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: RABBIT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 26 Then

            squirrel.Location = New Point(squirrel.Location.X, squirrel.Location.Y + 1)
            If squirrel.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                squirrel.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SQUIRREL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 27 Then

            tiger.Location = New Point(tiger.Location.X, tiger.Location.Y + 1)
            If tiger.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tiger.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TIGER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 28 Then

            zebra.Location = New Point(zebra.Location.X, zebra.Location.Y + 1)
            If zebra.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                zebra.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: ZEBRA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 29 Then

            buffalo.Location = New Point(buffalo.Location.X, buffalo.Location.Y + 1)
            If buffalo.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                buffalo.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: BUFFALO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 30 Then

            bluewhale.Location = New Point(bluewhale.Location.X, bluewhale.Location.Y + 1)
            If bluewhale.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                bluewhale.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: BLUE WHALE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 31 Then

            cougar.Location = New Point(cougar.Location.X, cougar.Location.Y + 1)
            If cougar.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                cougar.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: COUGAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 32 Then

            elk.Location = New Point(elk.Location.X, elk.Location.Y + 1)
            If elk.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                elk.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: ELK. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 33 Then

            wolf.Location = New Point(wolf.Location.X, wolf.Location.Y + 1)
            If wolf.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                wolf.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: WOLF. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 34 Then

            jaguar.Location = New Point(jaguar.Location.X, jaguar.Location.Y + 1)
            If jaguar.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                jaguar.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: JAGUAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 35 Then

            iguana.Location = New Point(iguana.Location.X, iguana.Location.Y + 1)
            If iguana.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                iguana.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: IGUANA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 36 Then

            leopard.Location = New Point(leopard.Location.X, leopard.Location.Y + 1)
            If leopard.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                leopard.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: LEOPARD. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 37 Then

            ostrich.Location = New Point(ostrich.Location.X, ostrich.Location.Y + 1)
            If ostrich.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                ostrich.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: OSTRICH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 38 Then

            polarbear.Location = New Point(polarbear.Location.X, polarbear.Location.Y + 1)
            If polarbear.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                polarbear.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: POLAR BEAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 39 Then

            sparrow.Location = New Point(sparrow.Location.X, sparrow.Location.Y + 1)
            If sparrow.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                sparrow.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SPARROW . Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 40 Then

            tarantula.Location = New Point(tarantula.Location.X, tarantula.Location.Y + 1)
            If tarantula.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tarantula.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TARANTULA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 41 Then

            tasmaniandevil.Location = New Point(tasmaniandevil.Location.X, tasmaniandevil.Location.Y + 1)
            If tasmaniandevil.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                tasmaniandevil.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: TASMANIAN DEVIL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 42 Then

            wildcat.Location = New Point(wildcat.Location.X, wildcat.Location.Y + 1)
            If wildcat.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                wildcat.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: WILD CAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 43 Then

            peacock.Location = New Point(peacock.Location.X, peacock.Location.Y + 1)
            If peacock.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                peacock.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PEACOCK. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 44 Then

            pigeon.Location = New Point(pigeon.Location.X, pigeon.Location.Y + 1)
            If pigeon.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                pigeon.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PIGEON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 45 Then

            arabiancamel.Location = New Point(arabiancamel.Location.X, arabiancamel.Location.Y + 1)
            If arabiancamel.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                arabiancamel.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: ARABIAN CAMEL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 46 Then

            houselizard.Location = New Point(houselizard.Location.X, houselizard.Location.Y + 1)
            If houselizard.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                houselizard.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: HOUSE LIZARD. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 47 Then

            blackrat.Location = New Point(blackrat.Location.X, blackrat.Location.Y + 1)
            If blackrat.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                blackrat.Hide()
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

            snakesea.Location = New Point(snakesea.Location.X, snakesea.Location.Y + 1)
            If snakesea.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                snakesea.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SEA SNAKE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 49 Then

            hyena.Location = New Point(hyena.Location.X, hyena.Location.Y + 1)
            If hyena.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                hyena.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: HYENA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 50 Then

            porcupine.Location = New Point(porcupine.Location.X, porcupine.Location.Y + 1)
            If porcupine.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                porcupine.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: PORCUPINE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 51 Then

            rhinoceros.Location = New Point(rhinoceros.Location.X, rhinoceros.Location.Y + 1)
            If rhinoceros.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                rhinoceros.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: RHINOCEROS. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 52 Then

            scorpion.Location = New Point(scorpion.Location.X, scorpion.Location.Y + 1)
            If scorpion.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                scorpion.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SCORPION. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 53 Then

            seahorse.Location = New Point(seahorse.Location.X, seahorse.Location.Y + 1)
            If seahorse.Location.Y = 520 Then
                Timer1.Enabled = False
                animation.Enabled = False
                seahorse.Hide()
                Dim r = MessageBox.Show("Oooops. you ran out of time. The correct answer is: SEA HORSE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
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
            If Answer = "CAT" And cat.Location.Y < 520 Then
                Score = Score + 10
                cat.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cat.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 2 Then
            If Answer = "COBRA" And cobra.Location.Y < 520 Then
                Score = Score + 10
                cobra.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cobra.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: COBRA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 3 Then
            If Answer = "CAMEL" And camel.Location.Y < 520 Then
                Score = Score + 10
                camel.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                camel.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CAMEL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 4 Then
            If Answer = "CHEETAH" And cheetah.Location.Y < 520 Then
                Score = Score + 10
                cheetah.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cheetah.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CHEETAH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 5 Then
            If Answer = "CHIMPANZEE" And chimpanzee.Location.Y < 520 Then
                Score = Score + 10
                chimpanzee.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                chimpanzee.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CHIMPANZEE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 6 Then
            If Answer = "CROCODILE" And crocodile.Location.Y < 520 Then
                Score = Score + 10
                crocodile.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                crocodile.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CROCODILE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 7 Then
            If Answer = "CHAMELEON" And chameleon.Location.Y < 520 Then
                Score = Score + 10
                chameleon.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                chameleon.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: CHAMELEON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 8 Then
            If Answer = "DOG" And dog.Location.Y < 520 Then
                Score = Score + 10
                dog.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                dog.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: DOG. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 9 Then
            If Answer = "DEER" And deer.Location.Y < 520 Then
                Score = Score + 10
                deer.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                deer.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: DEER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 10 Then
            If Answer = "ELEPHANT" And elephant.Location.Y < 520 Then
                Score = Score + 10
                elephant.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                elephant.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: ELEPHANT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 11 Then
            If Answer = "DOLPHIN" And dolphin.Location.Y < 520 Then
                Score = Score + 10
                dolphin.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                dolphin.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: DOLPHIN. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 12 Then
            If Answer = "FROG" And frog.Location.Y < 520 Then
                Score = Score + 10
                frog.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                frog.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: FROG. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 13 Then
            If Answer = "FOX" And fox.Location.Y < 520 Then
                Score = Score + 10
                fox.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                fox.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: FOX. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 14 Then
            If Answer = "GIRAFFE" And giraffe.Location.Y < 520 Then
                Score = Score + 10
                giraffe.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                giraffe.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: GIRAFFE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 15 Then
            If Answer = "PANDA" And panda.Location.Y < 520 Then
                Score = Score + 10
                panda.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                panda.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PANDA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 16 Then
            If Answer = "GOAT" And goat.Location.Y < 520 Then
                Score = Score + 10
                goat.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                goat.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: GOAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 17 Then
            If Answer = "HOUSE FLY" And housefly.Location.Y < 520 Then
                Score = Score + 10
                housefly.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                housefly.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: HOUSE FLY. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 18 Then
            If Answer = "HIPPOPOTAMUS" And hippopotamus.Location.Y < 520 Then
                Score = Score + 10
                hippopotamus.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                hippopotamus.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: HIPPOPOTAMUS . Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 19 Then
            If Answer = "HORSE" And horse.Location.Y < 520 Then
                Score = Score + 10
                horse.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                horse.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: HORSE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 20 Then
            If Answer = "KANGAROO" And kangaroo.Location.Y < 520 Then
                Score = Score + 10
                kangaroo.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                kangaroo.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: KANGAROO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 21 Then
            If Answer = "LION" And lion.Location.Y < 520 Then
                Score = Score + 10
                lion.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                lion.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LION. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 22 Then
            If Answer = "LIZARD" And lizard.Location.Y < 520 Then
                Score = Score + 10
                lizard.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                lizard.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LIZARD. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 23 Then
            If Answer = "MOUSE" And mouse.Location.Y < 520 Then
                Score = Score + 10
                mouse.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                mouse.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: MOUSE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 24 Then
            If Answer = "PANTHER" And panther.Location.Y < 520 Then
                Score = Score + 10
                panther.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                panther.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PANTHER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 25 Then
            If Answer = "RABBIT" And rabbit.Location.Y < 520 Then
                Score = Score + 10
                rabbit.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                rabbit.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: RABBIT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 26 Then
            If Answer = "SQUIRREL" And squirrel.Location.Y < 520 Then
                Score = Score + 10
                squirrel.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                squirrel.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SQUIRREL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 27 Then
            If Answer = "TIGER" And tiger.Location.Y < 520 Then
                Score = Score + 10
                tiger.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tiger.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TIGER. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 28 Then
            If Answer = "ZEBRA" And zebra.Location.Y < 520 Then
                Score = Score + 10
                zebra.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                zebra.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: ZEBRA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If

        If number = 29 Then
            If Answer = "BUFFALO" And buffalo.Location.Y < 520 Then
                Score = Score + 10
                buffalo.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                buffalo.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BUFFALO. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 30 Then
            If Answer = "BLUE WHALE" And bluewhale.Location.Y < 520 Then
                Score = Score + 10
                bluewhale.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                bluewhale.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BLUE WHALE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 31 Then
            If Answer = "COUGAR" And cougar.Location.Y < 520 Then
                Score = Score + 10
                cougar.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                cougar.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: COUGAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 32 Then
            If Answer = "ELK" And elk.Location.Y < 520 Then
                Score = Score + 10
                elk.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                elk.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: ELK. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 33 Then
            If Answer = "WOLF" And wolf.Location.Y < 520 Then
                Score = Score + 10
                wolf.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                wolf.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: WOLF. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 34 Then
            If Answer = "JAGUAR" And jaguar.Location.Y < 520 Then
                Score = Score + 10
                jaguar.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                jaguar.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: JAGUAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 35 Then
            If Answer = "IGUANA" And iguana.Location.Y < 520 Then
                Score = Score + 10
                iguana.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                iguana.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: IGUANA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 36 Then
            If Answer = "LEOPARD" And leopard.Location.Y < 520 Then
                Score = Score + 10
                leopard.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                leopard.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: LEOPARD. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 37 Then
            If Answer = "OSTRICH" And ostrich.Location.Y < 520 Then
                Score = Score + 10
                ostrich.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                ostrich.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: OSTRICH. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 38 Then
            If Answer = "POLAR BEAR" And polarbear.Location.Y < 520 Then
                Score = Score + 10
                polarbear.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                polarbear.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: POLAR BEAR. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 39 Then
            If Answer = "SPARROW" And sparrow.Location.Y < 520 Then
                Score = Score + 10
                sparrow.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                sparrow.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SPARROW. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 40 Then
            If Answer = "TARANTULA" And tarantula.Location.Y < 520 Then
                Score = Score + 10
                tarantula.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tarantula.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TARANTULA . Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 41 Then
            If Answer = "TASMANIAN DEVIL" And tasmaniandevil.Location.Y < 520 Then
                Score = Score + 10
                tasmaniandevil.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                tasmaniandevil.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: TASMANIAN DEVIL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 42 Then
            If Answer = "WILD CAT" And wildcat.Location.Y < 520 Then
                Score = Score + 10
                wildcat.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                wildcat.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: WILD CAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 43 Then
            If Answer = "PEACOCK" And peacock.Location.Y < 520 Then
                Score = Score + 10
                peacock.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                peacock.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PEACOCK. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 44 Then
            If Answer = "PIGEON" And pigeon.Location.Y < 520 Then
                Score = Score + 10
                pigeon.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                pigeon.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PIGEON. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 45 Then
            If Answer = "ARABIAN CAMEL" And arabiancamel.Location.Y < 520 Then
                Score = Score + 10
                arabiancamel.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                arabiancamel.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: ARABIAN CAMEL. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 46 Then
            If Answer = "HOUSE LIZARD" And houselizard.Location.Y < 520 Then
                Score = Score + 10
                houselizard.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                houselizard.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: HOUSE LIZARD. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 47 Then
            If Answer = "BLACK RAT" And blackrat.Location.Y < 520 Then
                Score = Score + 10
                blackrat.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                blackrat.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: BLACK RAT. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 48 Then
            If Answer = "SEA SNAKE" And snakesea.Location.Y < 520 Then
                Score = Score + 10
                snakesea.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                snakesea.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SEA SNAKE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 49 Then
            If Answer = "HYENA" And hyena.Location.Y < 520 Then
                Score = Score + 10
                hyena.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                hyena.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: HYENA. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 50 Then
            If Answer = "PORCUPINE" And porcupine.Location.Y < 520 Then
                Score = Score + 10
                porcupine.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                porcupine.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: PORCUPINE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 51 Then
            If Answer = "RHINOCEROS" And rhinoceros.Location.Y < 520 Then
                Score = Score + 10
                rhinoceros.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                rhinoceros.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: RHINOCEROS. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 52 Then
            If Answer = "SCORPION" And scorpion.Location.Y < 520 Then
                Score = Score + 10
                scorpion.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                scorpion.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SCORPION. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
                If r = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
                If r = MsgBoxResult.No Then
                    Application.Exit()
                End If
            End If
        End If
        If number = 53 Then
            If Answer = "SEA HORSE" And seahorse.Location.Y < 520 Then
                Score = Score + 10
                seahorse.Hide()
                TextBox2.Clear()
                TextBox1.Text = Score
            Else
                seahorse.Hide()
                Timer1.Enabled = False
                Dim r = MessageBox.Show("Oooops. you are incorrect. The correct answer is: SEA HORSE. Your score is: " & Score & ". Do you want to retry?", "Game over", MessageBoxButtons.YesNo)
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