Public Class Juego

    Dim count As Integer = 1
    Public errores As Integer = 0

    'Declaracion de variables
    Dim Hora As Integer = 0
    Dim Minuto As Integer = 0
    Dim Segundo As Integer = 0
    Dim Milisegundo As Integer = 0

    Private Sub InicioJuego(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click

        If NumerosMnu.Checked = True Then
            Numeros()
        ElseIf ColoresMnu.Checked = True Then
            colores()
            'colores2()
        End If


        count = 1
        errores = 0

        'reseteamos el tiempo
        Hora = 0
        Minuto = 0
        Segundo = 0
        Milisegundo = 0
        Timer1.Enabled = True



    End Sub

    Private Sub comprobarNumeros(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn10.Click, btn25.Click, btn24.Click, btn23.Click, btn22.Click, btn21.Click, btn20.Click, btn19.Click, btn18.Click, btn17.Click, btn16.Click, btn15.Click, btn14.Click, btn13.Click, btn12.Click, btn11.Click

        'definomos el boton en el que se ha hecho clic
        Dim clickedButton As Button = sender

        ''''''''''''''
        ''juego números
        ''''''''''''''
        If NumerosMnu.Checked = True Then


            'si es el siguiente botón que se debía presionar se marca, sino se cuenta un error
            If clickedButton.Text = count Then
                '   If Button2.Text = count Then
                clickedButton.BackColor = Color.White

                count = count + 1
            Else
                errores = errores + 1
                lblErrores.Text = "Errores: " + CStr(errores)
            End If


            'final del juego
            If clickedButton.Text = CStr(25) And count = 26 Then
                fin()
                ' lblErrores.Text = "FIN: " + CStr(errores)
                ' Timer1.Stop()
                'cudro de díalogo, felicitaciones, sonido, gif
            End If

            ''''''''''''''
            ''juego colores
            ''''''''''''''
        ElseIf ColoresMnu.Checked = True Then

            If clickedButton.BackColor = Button1.BackColor Then

                'clickedButton.BackColor = Color.Gray
                clickedButton.ForeColor = Color.Black
                clickedButton.Text = "x"
                count = count + 1

            Else
                errores = errores + 1
                lblErrores.Text = "Errores: " + CStr(errores)
            End If
            ''hay que tener en cuenta que son números impares
            If Button1.BackColor = Color.White Then
                If count = 14 Then
                    fin()
                End If
            Else
                If count = 13 Then
                    fin()
                End If

            End If

            End If
    End Sub


    Private Sub comprobarColor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn10.Click, btn25.Click, btn24.Click, btn23.Click, btn22.Click, btn21.Click, btn20.Click, btn19.Click, btn18.Click, btn17.Click, btn16.Click, btn15.Click, btn14.Click, btn13.Click, btn12.Click, btn11.Click

        'definomos el boton en el que se ha hecho clic
        Dim clickedButton As Button = sender

       
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick



        ' lblTime.Text = Timer1.Interval
        Milisegundo += 1
        If Milisegundo = 9 Then
            Milisegundo = 0
            Segundo += 1
            If Segundo = 59 Then
                Segundo = 0
                Minuto += 1
                If Minuto = 59 Then
                    Minuto += 1
                    Hora += 1
                End If
            End If
        End If
        lblTime.Text = Hora.ToString.PadLeft(2, "0") & ":" & Minuto.ToString.PadLeft(2, "0") & ":" & Segundo.ToString.PadLeft(2, "0") & ":" & Milisegundo.ToString.PadLeft(1, "0")

    End Sub


    Private Sub version(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumerosMnu.Click, ColoresMnu.Click, SimbolosMnu.Click

        'definomos el boton en el que se ha hecho clic
        Dim clickedButton As ToolStripMenuItem = sender


        If clickedButton.Text = "Números" Then
            NumerosMnu.Checked = True
            ColoresMnu.Checked = False
            SimbolosMnu.Checked = False

            'cargo la partida
            Numeros()
        ElseIf clickedButton.Text = "Colores" Then
            NumerosMnu.Checked = False
            ColoresMnu.Checked = True
            SimbolosMnu.Checked = False

            'cargo la partida
            colores()
        ElseIf clickedButton.Text = "Símbolos" Then
            NumerosMnu.Checked = False
            ColoresMnu.Checked = False
            SimbolosMnu.Checked = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        fin()
    End Sub

    Private Sub TiemposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiemposToolStripMenuItem.Click
        Tiempos.Show()
    End Sub
End Class
