Public Class Juego

    Dim count As Integer = 1
    Public errores As Integer = 0

    'Declaracion de variables para controlar el tiempo
    Dim Hora As Integer = 0
    Dim Minuto As Integer = 0
    Dim Segundo As Integer = 0
    Dim Milisegundo As Integer = 0

    ''' <summary>
    ''' Cargamos una nueva partida y comenzamos a contar el tiempo
    ''' </summary>
    ''' <param name="sender">Boton para empezar a jugar</param>
    Private Sub InicioJuego(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click

        'activmos todos los botones del panel
        For Each control In TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
        Next



        If NumerosMnu.Checked = True Then

            Numeros()
        ElseIf ColoresMnu.Checked = True Then

            If MulticolorCMnu.Checked = True Then

                colores("multicolor")

            ElseIf AzulCMnu.Checked = True Then

                colores("azul")

            ElseIf VerdeCMnu.Checked = True Then

                colores("verde")

            ElseIf MonocromoCMnu.Checked = True Then

                colores("monocromo")
                'Else

                '    colores2("multicolor")

            End If

        ElseIf SimbolosMnu.Checked = True Then

            simbolos()
        End If

        Timer1.Stop()
        count = 1
        errores = 0

        'reseteamos el tiempo
        Hora = 0
        Minuto = 0
        Segundo = 0
        Milisegundo = 0
        Timer1.Enabled = True



    End Sub

#Region "Comrpobar"

    ''' <summary>
    ''' Según la modalidad de juego se comprogará que el botón clicado sea el correcto
    ''' </summary>
    ''' <param name="clickedButton">Botón del panel sobre el que se ha hecho clic</param>
    Private Sub comprobar(ByVal clickedButton As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn10.Click, btn25.Click, btn24.Click, btn23.Click, btn22.Click, btn21.Click, btn20.Click, btn19.Click, btn18.Click, btn17.Click, btn16.Click, btn15.Click, btn14.Click, btn13.Click, btn12.Click, btn11.Click

        ''''''''''''''
        ''juego números
        ''''''''''''''
        If NumerosMnu.Checked = True Then
            comprobarNumeros(clickedButton)

            ''''''''''''''
            ''juego colores
            ''''''''''''''
        ElseIf ColoresMnu.Checked = True Then
            comprobarColores(clickedButton)

            ''''''''''''''
            ''juego símbolos
            ''''''''''''''
        ElseIf SimbolosMnu.Checked = True Then
            comprobarSimbolo(clickedButton)


        End If
    End Sub

    ''' <summary>
    ''' En la modalidad de juego de números comprobamos que lo haga en el orden correcto
    ''' </summary>
    ''' <param name="clickedButton">Botón sobre el que se hace clic</param>
    Private Sub comprobarNumeros(ByVal clickedButton As System.Object)

        ' si es el siguiente botón que se debía presionar se marca, sino se cuenta un error
        If clickedButton.Text = count Then
            '   If Button2.Text = count Then
            clickedButton.BackColor = Color.White

            count = count + 1
            'si el botón no es correcto, añadimos y mostramos un error
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

    End Sub

    ''' <summary>
    ''' En la modalidad de juego por números, se comprueba que se haga clic en el color correcto
    ''' </summary>
    ''' <param name="clickedButton">Botón sobre el que se hace clic</param>
    ''' <remarks></remarks>
    Private Sub comprobarColores(ByVal clickedButton As System.Object)

        'el botón es correcto
        If clickedButton.BackColor = Button1.BackColor Then

            'marcamos el botón
            clickedButton.Text = "x"
            count = count + 1
            'no pude hacer clic sobre el mismo botón
            clickedButton.Enabled = False

            'el botón no es correcto, añadimos y mostramos un error
        Else
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If

        'determinar el final del juego
        If count = 6 Then
            fin()
        End If

    End Sub

    ''' <summary>
    ''' En la modalidad de juebo con símbolos, se comprueba que se haga clic sobre el símbolo correcto
    ''' </summary>
    ''' <param name="clickedButton">Botón sobre el que se hace clic</param>
    Private Sub comprobarSimbolo(ByVal clickedButton As System.Object)


        'el botón es correcto
        If clickedButton.Text = Button1.Text Then

            clickedButton.ForeColor = Color.Black
            count = count + 1
            'no pude hacer clic sobre el mismo botón
            clickedButton.Enabled = False

            'si el botón no es correcto, añadimos y mostramos un error
        Else
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If
        ''hay que tener en cuenta que son números impares

        'determinar el final del juego
        If count = 6 Then
            fin()
        End If

    End Sub
#End Region

    ''' <summary>
    ''' Control del tiempo y mostrar por pantalla
    ''' </summary>
    Private Sub Tiempo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'controlar el tiempo
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

        'mostramos el tiempo por ptantalla
        lblTime.Text = Hora.ToString.PadLeft(2, "0") & ":" & Minuto.ToString.PadLeft(2, "0") & ":" & Segundo.ToString.PadLeft(2, "0") & ":" & Milisegundo.ToString.PadLeft(1, "0")

    End Sub

    ''' <summary>
    ''' Cambiamos el juego según la modalidad deseada
    ''' </summary>
    ''' <param name="selectedOption">Modalidad a jugar</param>
    Private Sub version(ByVal selectedOption As System.Object, ByVal e As System.EventArgs) Handles NumerosMnu.Click, ColoresMnu.Click, SimbolosMnu.Click, MulticolorCMnu.Click, AzulCMnu.Click, VerdeCMnu.Click, MonocromoCMnu.Click

        ''''''''
        ''''''''
        ''''''''
        ''''''''
        ''''''''
        ''''''''
        ''''''''
        ''tenemos que desactivar los botones porque sino se puede jugar sin haber iniciado el tiempo btnInicio.click
        ''''''''
        ''''''''
        ''''''''
        ''''''''

        ''desactivamos todos los botones del panel
        'For Each control In TableLayoutPanel1.Controls
        '    Dim boton = TryCast(control, Button)
        '    boton.Enabled = False
        'Next

        'modalidad de numeros
        If selectedOption.Text = "Números" Then

            NumerosMnu.Checked = True
            ColoresMnu.Checked = False
            SimbolosMnu.Checked = False

            'cargo la partida
            Numeros()


            'modalidad de colores
        ElseIf selectedOption.Text = "Multicolor" Or selectedOption.Text = "Azules" Or selectedOption.Text = "Verdes" Or selectedOption.Text = "Monocromático" Then
            ' ElseIf clickedButton.Text = "Colores" Then

            NumerosMnu.Checked = False
            ColoresMnu.Checked = True
            SimbolosMnu.Checked = False

            'colres mezcla
            If selectedOption.Text = "Multicolor" Then

                MulticolorCMnu.Checked = True
                AzulCMnu.Checked = False
                VerdeCMnu.Checked = False
                MonocromoCMnu.Checked = False

                colores("multicolor")

                'colres azul
            ElseIf selectedOption.Text = "Azules" Then

                MulticolorCMnu.Checked = False
                AzulCMnu.Checked = True
                VerdeCMnu.Checked = False
                MonocromoCMnu.Checked = False

                colores("azul")

                'colores verde
            ElseIf selectedOption.Text = "Verdes" Then

                MulticolorCMnu.Checked = False
                AzulCMnu.Checked = False
                VerdeCMnu.Checked = True
                MonocromoCMnu.Checked = False

                colores("verde")

                'colores gris
            ElseIf selectedOption.Text = "Monocromático" Then

                MulticolorCMnu.Checked = False
                AzulCMnu.Checked = False
                VerdeCMnu.Checked = False
                MonocromoCMnu.Checked = True

                colores("monocromo")

            End If

            'modalidad simbolos
        ElseIf selectedOption.Text = "Símbolos" Then
            NumerosMnu.Checked = False
            ColoresMnu.Checked = False
            SimbolosMnu.Checked = True
        End If

    End Sub


    ''
    ''
    ''
    ''
    ''' auxiliar salir más rápido
    ''
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        fin()
    End Sub

    ''' <summary>
    ''' Mostramos el cuadro con los tiempos de juego
    ''' </summary>
    Private Sub CuadroTiempos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiemposMnu.Click
        Tiempos.Show()
    End Sub
End Class
