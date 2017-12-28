Public Class Form1
    'union
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String = TextBox1.Text
        Dim aa() As String = a.Split(",")
        Dim aaa() As String = TextBox2.Text.Split(",")
        Dim outputString(1) As String
        Dim count As Integer = 0
        For Each bb In aa
            Dim found As Boolean = False
            If outputString.Length <> vbNull Then
                For Each arr In outputString
                    If arr = bb Then
                        found = True

                    End If
                Next
                If found = False Then
                    outputString(count) = bb
                    ReDim Preserve outputString(count + 1)
                    count = count + 1
                End If
            End If
           
        Next


        For Each bb In aaa
            Dim found As Boolean = False
            If outputString.Length <> vbNull Then
                For Each arr In outputString
                    If arr = bb Then
                        found = True

                    End If
                Next
                If found = False Then
                    outputString(count) = bb
                    ReDim Preserve outputString(count + 1)
                    count = count + 1
                End If
            End If


        Next

        Dim theOut As String = ""
        Array.Sort(outputString)
        Dim i As Integer = 0
        For Each arr In outputString
            If i <> 0 Then
                If theOut <> "" Then
                    theOut = theOut + " , " + arr
                Else
                    theOut = arr
                End If

            End If


            i = i + 1
        Next
        output.Text = "{ " + theOut + " } "
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    'intersect
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As String = TextBox4.Text
        Dim aa() As String = a.Split(",")
        Dim aaa() As String = TextBox3.Text.Split(",")
        Dim outputString(1) As String
        Dim count As Integer = 0
        For Each bb In aa
            Dim found As Boolean = False
            bb = bb.Trim()
            For Each arr In aaa
                arr = arr.Trim()
                If arr = bb Then
                    found = True

                End If
            Next
            If found = True Then
                Dim found2 = False
                ReDim Preserve outputString(count + 1)
                For Each arr In outputString

                    If arr = bb Then
                        found = True
                    End If
                Next
                If found2 = False Then
                    outputString(count) = bb

                    count = count + 1
                End If
            End If


        Next


     

        Dim theOut As String = ""
        Array.Sort(outputString)
        Dim i As Integer = 0
        For Each arr In outputString
            If i <> 0 Then
                If theOut <> "" Then
                    theOut = theOut + " , " + arr
                Else
                    theOut = arr
                End If

            End If
            

            i = i + 1
        Next
        Label18.Text = "{ " + theOut + " } "
    End Sub
    'complement
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As String = TextBox6.Text
        Dim aa() As String = a.Split(",")
        Dim aaa() As String = TextBox5.Text.Split(",")

        Dim outputString(1) As String
        Dim count As Integer = 0
        For Each bb In aa
            Dim found As Boolean = False
            bb = bb.Trim()
            For Each arr In aaa
                arr = arr.Trim()
                If arr = bb Then
                    found = True
                End If
            Next
            If found = False Then
                Dim found2 = False
                ReDim Preserve outputString(count + 1)
                For Each arr In outputString

                    If arr = bb Then
                        found = True
                    End If
                Next
                If found2 = False Then
                    outputString(count) = bb

                    count = count + 1
                End If
            End If


        Next




        Dim theOut As String = ""
        Array.Sort(outputString)
        Dim i As Integer = 0
        For Each arr In outputString
            If i <> 0 Then
                If theOut <> "" Then
                    theOut = theOut + " , " + arr
                Else
                    theOut = arr
                End If

            End If


            i = i + 1
        Next
        Label23.Text = "{ " + theOut + " } "
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If ComboBox1.SelectedIndex = 5 Then
            TextBox14.Text = TextBox14.Text + "U"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            TextBox14.Text = TextBox14.Text + "∩"
        ElseIf ComboBox1.SelectedIndex = 7 Then
            TextBox14.Text = TextBox14.Text + " ͨ "
        ElseIf ComboBox1.SelectedIndex = 8 Then
            TextBox14.Text = TextBox14.Text + "-"
        Else
            TextBox14.Text = TextBox14.Text + ComboBox1.Text
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox14.Text.Length <> 0 Then
            TextBox14.Text = TextBox14.Text.Substring(0, TextBox14.Text.Length - 1)
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim v123s() As String = v123.Text.Split(",")

        Dim v1s() As String = v1.Text.Split(",")
        Dim v2s() As String = v2.Text.Split(",")
        Dim v3s() As String = v3.Text.Split(",")
        Dim v12s() As String = v12.Text.Split(",")
        Dim v13s() As String = v13.Text.Split(",")
        Dim v23s() As String = v23.Text.Split(",")


        Array.Sort(v1s)
        Array.Sort(v2s)
        Array.Sort(v3s)
        Array.Sort(v12s)
        Array.Sort(v13s)
        Array.Sort(v23s)
        Array.Sort(v123s)

        'a
        Dim v1sOutput() As String = (v1s.Union(v12s)).ToArray
        v1sOutput = (v1sOutput.Union(v123s)).ToArray
        v1sOutput = (v1sOutput.Union(v13s)).ToArray

        Array.Sort(v1sOutput)
        Dim theOut1 As String = ""
        Dim i As Integer = 0
        For Each arr In v1sOutput

            If theOut1 <> "" Then
                theOut1 = theOut1 + " , " + arr
            Else
                theOut1 = arr
            End If


            i = i + 1
        Next

        Label36.Text = "Set A = { " + theOut1 + " } "

        'b
        Dim v2sOutput() As String = (v2s.Union(v12s)).ToArray
        v2sOutput = (v2sOutput.Union(v123s)).ToArray
        v2sOutput = (v2sOutput.Union(v23s)).ToArray

        Array.Sort(v2sOutput)
        Dim theOut2 As String = ""
        i = 0
        For Each arr In v2sOutput

            If theOut2 <> "" Then
                theOut2 = theOut2 + " , " + arr
            Else
                theOut2 = arr
            End If


            i = i + 1
        Next

        Label34.Text = "Set B = { " + theOut2 + " } "
        'b
        Dim v3sOutput() As String = (v3s.Union(v13s)).ToArray

        v3sOutput = (v3sOutput.Union(v23s)).ToArray
        v3sOutput = (v3sOutput.Union(v123s)).ToArray
        Array.Sort(v2sOutput)
        Dim theOut3 As String = ""
        i = 0
        For Each arr In v3sOutput

            If theOut3 <> "" Then
                theOut3 = theOut3 + " , " + arr
            Else
                theOut3 = arr
            End If


            i = i + 1
        Next

        Label35.Text = "Set C = { " + theOut3 + " } "

        'u
        'b
        Dim vUsOutput() As String = (v1sOutput.Union(v2sOutput)).ToArray
        vUsOutput = (vUsOutput.Union(v3sOutput)).ToArray

        Array.Sort(v2sOutput)
        Dim theOutU As String = ""
        i = 0
        For Each arr In vUsOutput

            If theOut3 <> "" Then
                theOutU = theOutU + " , " + arr
            Else
                theOutU = arr
            End If


            i = i + 1
        Next

        Label37.Text = "Let U = { " + theOutU + " } "


        'the equation
        Dim ii As Integer = 1
        Dim equation() As String = TextBox14.Text.Split("(")
        'disregard the index 0
        Do While equation.Length <> ii

            Dim a As String = equation(equation.Length - ii)
            a = a.Remove(a.IndexOf(")"))
            MsgBox(a)
            ii = ii + 1
        Loop


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim v123s() As String = v123.Text.Split(",")

        Dim v1s() As String = v1.Text.Split(",")
        Dim v2s() As String = v2.Text.Split(",")
        Dim v3s() As String = v3.Text.Split(",")
        Dim v12s() As String = v12.Text.Split(",")
        Dim v13s() As String = v13.Text.Split(",")
        Dim v23s() As String = v23.Text.Split(",")


        Array.Sort(v1s)
        Array.Sort(v2s)
        Array.Sort(v3s)
        Array.Sort(v12s)
        Array.Sort(v13s)
        Array.Sort(v23s)
        Array.Sort(v123s)

        'a
        Dim v1sOutput() As String = (v1s.Union(v12s)).ToArray
        v1sOutput = (v1sOutput.Union(v123s)).ToArray
        v1sOutput = (v1sOutput.Union(v13s)).ToArray

        Array.Sort(v1sOutput)
        Dim theOut1 As String = ""
        Dim i As Integer = 0
        For Each arr In v1sOutput

            If theOut1 <> "" Then
                theOut1 = theOut1 + " , " + arr
            Else
                theOut1 = arr
            End If


            i = i + 1
        Next

        Label36.Text = "Set A = { " + theOut1 + " } "

        'b
        Dim v2sOutput() As String = (v2s.Union(v12s)).ToArray
        v2sOutput = (v2sOutput.Union(v123s)).ToArray
        v2sOutput = (v2sOutput.Union(v23s)).ToArray

        Array.Sort(v2sOutput)
        Dim theOut2 As String = ""
        i = 0
        For Each arr In v2sOutput

            If theOut2 <> "" Then
                theOut2 = theOut2 + " , " + arr
            Else
                theOut2 = arr
            End If


            i = i + 1
        Next

        Label34.Text = "Set B = { " + theOut2 + " } "
        'b
        Dim v3sOutput() As String = (v3s.Union(v13s)).ToArray

        v3sOutput = (v3sOutput.Union(v23s)).ToArray
        v3sOutput = (v3sOutput.Union(v123s)).ToArray
        Array.Sort(v2sOutput)
        Dim theOut3 As String = ""
        i = 0
        For Each arr In v3sOutput

            If theOut3 <> "" Then
                theOut3 = theOut3 + " , " + arr
            Else
                theOut3 = arr
            End If


            i = i + 1
        Next

        Label35.Text = "Set C = { " + theOut3 + " } "

        'u
        'b
        Dim vUsOutput() As String = (v1sOutput.Union(v2sOutput)).ToArray
        vUsOutput = (vUsOutput.Union(v3sOutput)).ToArray

        Array.Sort(v2sOutput)
        Dim theOutU As String = ""
        i = 0
        For Each arr In vUsOutput

            If theOutU <> "" Then
                theOutU = theOutU + " , " + arr
            Else
                theOutU = arr
            End If


            i = i + 1
        Next

        Label37.Text = "Let U = { " + theOutU + " } "

        o1.Text = "= { " + v1.Text + " } "
        o2.Text = "= { " + v2.Text + " } "
        o3.Text = "= { " + v3.Text + " } "
        o12.Text = "= { " + v12.Text + " } "
        o13.Text = "= { " + v13.Text + " } "
        o23.Text = "= { " + v23.Text + " } "
        o123.Text = "= { " + v23.Text + " } "

    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
     
    End Sub

    Dim firstinputDFA As String = ""

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress

        If TextBox7.Text.Length = 5 Then


            e.KeyChar = ""
        Else

            If e.KeyChar.ToString = "1" Or e.KeyChar.ToString = "0" Then

                If TextBox7.Text.Length = 0 Then
                    PictureBox1.Visible = False
                    If e.KeyChar.ToString = "1" Then
                        Label69.Text = "Not Accepted"
                        PictureBox2.Visible = False
                        PictureBox5.Visible = True
                        firstinputDFA = "1"
                    Else
                        firstinputDFA = "0"
                        Label69.Text = "Not Accepted"
                        PictureBox2.Visible = True
                        PictureBox5.Visible = False

                    End If
                End If
                If TextBox7.Text.Length = 1 Then
                    If firstinputDFA = "1" Then

                    Else
                        Label69.Text = "Not Accepted"
                        PictureBox2.Visible = False
                        If e.KeyChar.ToString = "1" Then
                            PictureBox3.Visible = True
                        Else
                            PictureBox3.Visible = True
                        End If
                    End If



                End If
                If TextBox7.Text.Length = 2 Then
                    If firstinputDFA = "1" Then

                    Else
                        Label69.Text = "String Accepted"
                        PictureBox3.Visible = False
                        If e.KeyChar.ToString = "1" Then
                            PictureBox4.Visible = True
                        Else
                            PictureBox4.Visible = True
                        End If
                    End If

                End If
                If TextBox7.Text.Length = 3 Then
                    If firstinputDFA = "1" Then

                    Else
                        PictureBox4.Visible = False
                        If e.KeyChar.ToString = "1" Then
                            PictureBox4.Visible = True
                        Else
                            PictureBox4.Visible = True
                        End If
                    End If

                End If

                Else
                    e.KeyChar = ""
                End If
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox7.Text = ""
        firstinputDFA = ""
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        Label69.Text = "Not Accepted"
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
      

            If e.KeyChar.ToString = "1" Or e.KeyChar.ToString = "0" Then

                If PictureBox10.Visible = True Then
                    dfa21(e)
                ElseIf PictureBox9.Visible = True Then
                    dfa22(e)
                ElseIf PictureBox8.Visible = True Then
                    dfa23(e)
                End If


            Else
                e.KeyChar = ""
            End If

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub
    Sub dfa21(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        PictureBox1.Visible = False
        If e.KeyChar.ToString = "1" Then
            Label69.Text = "Not Accepted"
            PictureBox10.Visible = True


        Else
            Label69.Text = "Not Accepted"
            PictureBox9.Visible = True
            PictureBox10.Visible = False

        End If
    End Sub
    Sub dfa22(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Label69.Text = "Not Accepted"
        PictureBox2.Visible = False
        If e.KeyChar.ToString = "1" Then
            PictureBox10.Visible = True
            PictureBox9.Visible = False
        Else
            PictureBox9.Visible = False

            PictureBox8.Visible = True
        End If

    End Sub
    Sub dfa23(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Label69.Text = "String Accepted"
        PictureBox3.Visible = False
        If e.KeyChar.ToString = "1" Then
            PictureBox10.Visible = True
            PictureBox8.Visible = False
        Else

            PictureBox8.Visible = True
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox8.Text = ""

        PictureBox10.Visible = True
        PictureBox9.Visible = False
        PictureBox8.Visible = False

        Label70.Text = "Not Accepted"

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
      If TextBox9.Text <> "" And TextBox10.Text <> "" And TextBox11.Text <> "" Then
            Dim a As String = TextBox9.Text.ToCharArray
            Dim b As String = TextBox10.Text.ToCharArray
            Dim c As String = TextBox11.Text.ToCharArray



        
            Dim output As String = " = { "
            output = output + a
            output = output + " , "
            output = output + b
            output = output + " , "
            Dim k As Integer = 1
            For ii = 0 To 10
                output = output + b

                For j = 1 To k
                    output = output + c
                Next
                output = output + " , "

                k = k + 1

            Next
            Dim aaaa() As Char = (a.Union(c.Union(b))).ToArray
            Array.Sort(aaaa)
            Dim theOut As String = ""
            Dim i As Integer = 0
            For Each arr In aaaa

                If theOut <> "" Then
                    theOut = theOut + " , " + arr.ToString
                Else
                    theOut = arr.ToString
                End If


                i = i + 1
            Next
            Label95.Text = "∑ = { " + theOut + " } "
            output = output + " , ... } "
            RichTextBox1.Text = output
        Else

            MsgBox("You need to input 3 elements of any character.", MsgBoxStyle.Critical, "")

        End If

    End Sub
    Sub regexAll(ByVal i As Integer, ByVal x As Integer)

    End Sub

    Private Sub TabPage6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged, TextBox11.TextChanged, TextBox10.TextChanged

    End Sub
    Dim thenfachar() As Char
    Dim countNfa As Integer = 0
    Dim nfaoutput As String = ""
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If nfaVerify() And TextBox23.Text <> "" Then
            countNfa = 0
            nfaoutput = ""
            Dim a As String = TextBox23.Text
            thenfachar = a.ToCharArray

            nfa1()
            Label97.Text = "The output is :  = " + nfaoutput
            If nfaoutput.Length > 2 Then
                Dim aa() As Char = nfaoutput.ToCharArray
                Dim aaa() As Char = TextBox23.Text.ToCharArray
                If aa(0).ToString = "0" And aa(1).ToString = "0" And aaa(0).ToString = "0" And aaa(1).ToString = "0" Then
                    Label106.Text = "Right NFA"
                ElseIf aaa(0).ToString = "0" And aaa(1).ToString = "0" Then
                    Label106.Text = "Wrong NFA"
                Else
                    Label106.Text = "Maybe the NFA is correct try to input a string that start in 00 "
                End If
            Else
                Label106.Text = "Maybe the NFA is correct try to input a string that start in 00 "
            End If
        Else
            MsgBox("Please The input")
        End If
    End Sub
    Sub nfa1()

        If countNfa <> thenfachar.Length Then



            If thenfachar(countNfa).ToString = "1" Then
                nfaoutput = thenfachar(countNfa).ToString + nfaoutput

                countNfa = countNfa + 1
                If TextBox12.Text = "q0" Then
                    nfa1()
                ElseIf TextBox12.Text = "q1" Then
                    nfa2("go")
                ElseIf TextBox12.Text = "q2" Then
                    nfa3("go")
                ElseIf TextBox12.Text = "q3" Then
                    nfa4("go")
                End If
            Else
                nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                countNfa = countNfa + 1
                If TextBox13.Text = "q0" Then
                    nfa1()
                ElseIf TextBox13.Text = "q1" Then
                    nfa2("go")
                ElseIf TextBox13.Text = "q2" Then
                    nfa3("go")
                ElseIf TextBox13.Text = "q3" Then
                    nfa4("go")
                End If

            End If
        End If
    End Sub
    Sub nfa2(ByVal a As String)

        If countNfa <> thenfachar.Length Then
            If thenfachar(countNfa).ToString = "1" Then
                If a = "go" Then
                    nfaoutput = nfaoutput + thenfachar(countNfa).ToString
                Else
                    nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                End If

                countNfa = countNfa + 1
                If TextBox22.Text = "q0" Then
                    nfa1()
                ElseIf TextBox22.Text = "q1" Then
                    nfa2("back")
                ElseIf TextBox22.Text = "q2" Then
                    nfa3("go")
                ElseIf TextBox22.Text = "q3" Then
                    nfa4("go")
                End If
            Else
                If a = "go" Then
                    nfaoutput = nfaoutput + thenfachar(countNfa).ToString
                Else
                    nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                End If
                countNfa = countNfa + 1
                If TextBox19.Text = "q0" Then
                    nfa1()
                ElseIf TextBox19.Text = "q1" Then
                    nfa2("back")
                ElseIf TextBox19.Text = "q2" Then
                    nfa3("go")
                ElseIf TextBox19.Text = "q3" Then
                    nfa4("go")
                End If

            End If
        End If
    End Sub
    Sub nfa3(ByVal a As String)

        If countNfa <> thenfachar.Length Then


            If thenfachar(countNfa).ToString = "1" Then
                If a = "go" Then
                    nfaoutput = nfaoutput + thenfachar(countNfa).ToString
                Else
                    nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                End If

                countNfa = countNfa + 1
                If TextBox20.Text = "q0" Then
                    nfa1()
                ElseIf TextBox20.Text = "q1" Then
                    nfa2("back")
                ElseIf TextBox20.Text = "q2" Then
                    nfa3("back")
                ElseIf TextBox20.Text = "q3" Then
                    nfa4("go")
                End If
            Else
                If a = "go" Then
                    nfaoutput = nfaoutput + thenfachar(countNfa).ToString
                Else
                    nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                End If
                countNfa = countNfa + 1
                If TextBox21.Text = "q0" Then
                    nfa1()
                ElseIf TextBox21.Text = "q1" Then
                    nfa2("back")
                ElseIf TextBox21.Text = "q2" Then
                    nfa3("back")
                ElseIf TextBox21.Text = "q3" Then
                    nfa4("go")
                End If

            End If
        End If
    End Sub
    Sub nfa4(ByVal a As String)

        If countNfa <> thenfachar.Length Then


            If thenfachar(countNfa).ToString = "1" Then
                If a = "go" Then
                    nfaoutput = nfaoutput + thenfachar(countNfa).ToString
                Else
                    nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                End If

                countNfa = countNfa + 1
                If TextBox17.Text = "q0" Then
                    nfa1()
                ElseIf TextBox17.Text = "q1" Then
                    nfa2("back")
                ElseIf TextBox17.Text = "q2" Then
                    nfa3("back")
                ElseIf TextBox17.Text = "q3" Then
                    nfa4("go")
                End If
            Else
                If a = "go" Then
                    nfaoutput = nfaoutput + thenfachar(countNfa).ToString
                Else
                    nfaoutput = thenfachar(countNfa).ToString + nfaoutput
                End If
                countNfa = countNfa + 1
                If TextBox18.Text = "q0" Then
                    nfa1()
                ElseIf TextBox18.Text = "q1" Then
                    nfa2("back")
                ElseIf TextBox18.Text = "q2" Then
                    nfa3("back")
                ElseIf TextBox18.Text = "q3" Then
                    nfa4("go")
                End If

            End If
        End If
    End Sub
    Function nfaVerify() As Boolean

        Dim a(8) As Boolean
        If TextBox12.Text = "q0" Or TextBox12.Text = "q1" Or TextBox12.Text = "q2" Or TextBox12.Text = "q3" Then
            a(0) = True
        Else
            a(0) = False
        End If
        If TextBox13.Text = "q0" Or TextBox13.Text = "q1" Or TextBox13.Text = "q2" Or TextBox13.Text = "q3" Then
            a(1) = True
        Else
            a(1) = False
        End If
        If TextBox22.Text = "q0" Or TextBox22.Text = "q1" Or TextBox22.Text = "q2" Or TextBox22.Text = "q3" Then
            a(2) = True
        Else
            a(2) = False
        End If
        If TextBox19.Text = "q0" Or TextBox19.Text = "q1" Or TextBox19.Text = "q2" Or TextBox19.Text = "q3" Then
            a(3) = True
        Else
            a(3) = False
        End If
        If TextBox20.Text = "q0" Or TextBox20.Text = "q1" Or TextBox20.Text = "q2" Or TextBox20.Text = "q3" Then
            a(4) = True
        Else
            a(4) = False
        End If
        If TextBox21.Text = "q0" Or TextBox21.Text = "q1" Or TextBox21.Text = "q2" Or TextBox21.Text = "q3" Then
            a(5) = True
        Else
            a(5) = False
        End If
        If TextBox17.Text = "q0" Or TextBox17.Text = "q1" Or TextBox17.Text = "q2" Or TextBox17.Text = "q3" Then
            a(6) = True
        Else
            a(6) = False

        End If
        If TextBox18.Text = "q0" Or TextBox18.Text = "q1" Or TextBox18.Text = "q2" Or TextBox18.Text = "q3" Then
            a(7) = True
        Else
            a(7) = False

        End If
        Dim b As Boolean
        If a(0) And a(1) And a(2) And a(3) And a(4) And a(5) And a(6) And a(7) Then
            b = True
        Else
            b = False
        End If
        Return b




    End Function

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TabControl1.SelectTab(4)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabControl2.SelectTab(1)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl2.SelectTab(2)
    End Sub
End Class
