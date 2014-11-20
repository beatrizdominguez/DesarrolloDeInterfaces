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
        activar()

        If NumerosMnu.Checked = True Then

            Numeros()

        ElseIf ColoresMnu.Checked = True Then

            If MulticolorCMnu.Checked = True Then

                colores("multicolor")

            ElseIf AzulCMnu.Checked = True Then

                colores("azul")

            ElseIf VerdeCMnu.Checked = True Then

                colores("verde")

            ElseIf RosaCMnu.Checked = True Then

                colores("rosa")

            ElseIf MonocromoCMnu.Checked = True Then

                colores("monocromo")
                
            End If

        ElseIf SimbolosMnu.Checked = True Then

            If GlobalToolStripMenuItem.Checked = True Then

                simbolos("global")

            ElseIf ManosToolStripMenuItem.Checked = True Then

                simbolos("manos")
            End If

        End If

        Timer1.Stop()
        count = 1
        errores = 0
        lblErrores.Text = "Errores: 0"

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
    Private Sub comprobar(ByVal clickedButton As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click

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

            clickedButton.BackColor = Color.White
            clickedButton.forecolor = Color.White

            count = count + 1

            'si el botón no es correcto, añadimos y mostramos un error
        Else
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If

        'final del juego
        If clickedButton.Text = CStr(25) And count = 26 Then
            fin()
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
        If btn1.Enabled = True Then
            lblTime.Text = Hora.ToString.PadLeft(2, "0") & ":" & Minuto.ToString.PadLeft(2, "0") & ":" & Segundo.ToString.PadLeft(2, "0") & ":" & Milisegundo.ToString.PadLeft(1, "0")
        Else
            lblTime.Text = "00:00:00:00"
        End If
    End Sub

    ''' <summary>
    ''' Cambiamos el juego según la modalidad deseada
    ''' </summary>
    ''' <param name="selectedOption">Modalidad a jugar</param>
    Private Sub version(ByVal selectedOption As System.Object, ByVal e As System.EventArgs) Handles NumerosMnu.Click, ColoresMnu.Click, SimbolosMnu.Click, MulticolorCMnu.Click, AzulCMnu.Click, VerdeCMnu.Click, RosaCMnu.Click, MonocromoCMnu.Click, GlobalToolStripMenuItem.Click, ManosToolStripMenuItem.Click

        'desactivamos los botones
        desactivar()
        'desactivamos las opciones seleccionadas
        menus()

        'modalidad de numeros
        If selectedOption.Text = "Números" Then

            NumerosMnu.Checked = True

            'cargo la partida
            Numeros()

            'modalidad de colores
        ElseIf selectedOption.Text = "Multicolor" Or selectedOption.Text = "Azules" Or selectedOption.Text = "Verdes" Or selectedOption.Text = "Rosas" Or selectedOption.Text = "Monocromático" Then
            ' ElseIf clickedButton.Text = "Colores" Then

            ColoresMnu.Checked = True

            'colres mezcla
            If selectedOption.Text = "Multicolor" Then

                MulticolorCMnu.Checked = True

                colores("multicolor")

                'colres azul
            ElseIf selectedOption.Text = "Azules" Then

                AzulCMnu.Checked = True

                colores("azul")

                'colores verde
            ElseIf selectedOption.Text = "Verdes" Then

                VerdeCMnu.Checked = True

                colores("verde")

                'colores gris
            ElseIf selectedOption.Text = "Rosas" Then

                RosaCMnu.Checked = True

                colores("rosa")

            ElseIf selectedOption.Text = "Monocromático" Then

                MonocromoCMnu.Checked = True

                colores("monocromo")

            End If

            'modalidad simbolos
        ElseIf selectedOption.Text = "Global" Or selectedOption.Text = "Manos" Then

            SimbolosMnu.Checked = True

            If selectedOption.Text = "Global" Then

                GlobalToolStripMenuItem.Checked = True

                simbolos("global")

            ElseIf selectedOption.Text = "Manos" Then

                ManosToolStripMenuItem.Checked = True

                simbolos("manos")
            End If

        End If

    End Sub


    ''
    ''
    ''
    ''
    '' auxiliar salir más rápido
    ''
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        fin()
    End Sub

    ''' <summary>
    ''' Mostramos el cuadro con los tiempos de juego
    ''' </summary>
    Private Sub CuadroTiempos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiemposMnu.Click
        If Me.Width = 459 Then
            Me.Width = 1006
        ElseIf Me.Width = 1006 Then
            Me.Width = 459
        End If

    End Sub

End Class