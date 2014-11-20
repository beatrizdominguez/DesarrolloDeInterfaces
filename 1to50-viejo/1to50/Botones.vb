Module Botones

#Region "Botones"
   

    Public Sub Numeros()

        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        Dim myFont As System.Drawing.Font
        myFont = New System.Drawing.Font("Cooper Black", 18, FontStyle.Bold)


        Juego.lblInstrucciones.Text = "Ordena los números del 1 al 25 lo más rápido posible"

        'definimos el numero para todos los botones
        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            boton.Enabled = True
            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num
            count = count + 1
            'asignamos un número
            boton.Text = num

            'definimos el color
            boton.BackColor = Color.Black
            boton.ForeColor = Color.White
            ' Dim f As Font = New Font(f, 18.0F, FontStyle.Bold)
            boton.Font = myFont
        Next

        '  Juego.Button1.Visible = False

    End Sub

    Public Sub colores(ByVal paleta As String)

        Juego.lblInstrucciones.Text = "Haz clic en todos los botones de color ...."



        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        Dim colores() As Object = {color.Red, color.Red, color.Red, color.Red, color.Red,
                                   color.White, color.White, color.White, color.White, color.White,
                                 color.GreenYellow, color.GreenYellow, color.GreenYellow, color.GreenYellow, color.GreenYellow,
                                   color.Orange, color.Orange, color.Orange, color.Orange, color.Orange,
                                   color.Turquoise, color.Turquoise, color.Turquoise, color.Turquoise, color.Turquoise}

        Dim coloresAzul() As Object = {Color.Aqua, Color.Aqua, Color.Aqua, Color.Aqua, Color.Aqua,
                                  Color.LightSkyBlue, Color.LightSkyBlue, Color.LightSkyBlue, Color.LightSkyBlue, Color.LightSkyBlue,
                                Color.LightSteelBlue, Color.LightSteelBlue, Color.LightSteelBlue, Color.LightSteelBlue, Color.LightSteelBlue,
                                  Color.DarkSlateBlue, Color.DarkSlateBlue, Color.DarkSlateBlue, Color.DarkSlateBlue, Color.DarkSlateBlue,
                                  Color.Turquoise, Color.Turquoise, Color.Turquoise, Color.Turquoise, Color.Turquoise}

        Dim coloresVerde() As Object = {Color.White, Color.White, Color.White, Color.White, Color.White,
                                 Color.GreenYellow, Color.GreenYellow, Color.GreenYellow, Color.GreenYellow, Color.GreenYellow,
                               Color.MediumSeaGreen, Color.MediumSeaGreen, Color.MediumSeaGreen, Color.MediumSeaGreen, Color.MediumSeaGreen,
                                 Color.MediumSpringGreen, Color.MediumSpringGreen, Color.MediumSpringGreen, Color.MediumSpringGreen, Color.MediumSpringGreen,
                                 Color.Lime, Color.Lime, Color.Lime, Color.Lime, Color.Lime}

        Dim coloresGris() As Object = {Color.White, Color.White, Color.White, Color.White, Color.White,
                                 Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
                               Color.Silver, Color.Silver, Color.Silver, Color.Silver, Color.Silver,
                                 Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray,
                                 Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige}

        'Tiempos.Show()



        Juego.Button1.Visible = True
        Juego.Button1.Text = ""


        If paleta = "multicolor" Then
            Juego.Button1.BackColor = colores((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "azul" Then
            Juego.Button1.BackColor = coloresAzul((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "verde" Then
            Juego.Button1.BackColor = coloresVerde((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "monocromo" Then
            Juego.Button1.BackColor = coloresGris((Int(25 * Rnd() + 1) - 1))
        End If

        '  Juego.Button1.BackColor = coloresAzul((Int(25 * Rnd() + 1) - 1))

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)

            'asignamos un número
            boton.Text = ""
            boton.Enabled = True

            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num


            'definimos el color
            If paleta = "multicolor" Then
                boton.BackColor = colores((num - 1))
            ElseIf paleta = "azul" Then
                boton.BackColor = coloresAzul((num - 1))
            ElseIf paleta = "verde" Then
                boton.BackColor = coloresVerde((num - 1))
            ElseIf paleta = "monocromo" Then
                boton.BackColor = coloresGris((num - 1))
            End If



            count = count + 1
        Next

    End Sub

    Public Sub simbolos()

        Juego.lblInstrucciones.Text = "Haz clic en todos los botones con el símbolo ...."

        Dim myFont As System.Drawing.Font
        myFont = New System.Drawing.Font("Webdings", 18, FontStyle.Bold)

        Dim iconos() As String = {"-", "-", "-", "-", "-",
                                  "q", "q", "q", "q", "q",
                                  "·", "·", "·", "·", "·",
                                  "_", "_", "_", "_", "_",
                                  "Y", "Y", "Y", "Y", "Y"}



        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        'Juego.btnInicio.Font = myFont
        ''set all buttons font

        'definimos el numero para todos los botones
        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
           
            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(Numeros, num) = -1
            numeros(count) = num
            count = count + 1
            'definimos el siimbolo
            boton.Text = iconos((num - 1))



            'definimos el color
            boton.BackColor = Color.Black
            boton.ForeColor = Color.White
            boton.Enabled = True

            boton.Font = myFont
        Next




        Juego.Button1.Visible = True
        Juego.Button1.Text = iconos((Int(25 * Rnd() + 1) - 1))

    End Sub
#End Region

    ''' <summary>
    ''' El juego ha acadabo
    ''' </summary>
    Public Sub fin()

        'paramos el tiempo

        Juego.Timer1.Stop()

        'mostramos el mensaje
        MsgBox("Felicitaciones", MsgBoxStyle.OkOnly, "Fin del juego")

        'suena la música

        '  My.Computer.Audio.Play("C:\Users\Beatriz\Desktop\aplausos.mp3", AudioPlayMode.Background)

        '   My.Computer.Audio.Play(My.Resources.Waterfall, AudioPlayMode.BackgroundLoop)

        Tiempos.Show()

        'añadimos el tiempo a la tabla de tiempos
        If Juego.NumerosMnu.Checked = True Then
            Tiempos.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Numeros    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g"))

        ElseIf Juego.ColoresMnu.Checked = True Then

            Dim color As String = modalidadColor()

            Tiempos.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Colores    " + color + "             " + CStr(Juego.errores) + "     " + Date.Now.ToString("g"))

        ElseIf Juego.SimbolosMnu.Checked = True Then
            Tiempos.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Símbolos    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g"))

        End If

    End Sub

    ''' <summary>
    ''' Funcion que devuelve el nombre de la modalidad de color a la que se está jugando
    ''' </summary>
    ''' <returns>Nombre de la modalidad de color</returns>
    Public Function modalidadColor() As String

        Dim modalidad As String

        If Juego.MulticolorCMnu.Checked = True Then

            modalidad = "Multicolor"

        ElseIf Juego.AzulCMnu.Checked = True Then

            modalidad = "Azules"

        ElseIf Juego.VerdeCMnu.Checked = True Then

            modalidad = "Verdes"

        ElseIf Juego.MonocromoCMnu.Checked = True Then

            modalidad = "Monocromo"

        End If

        Return modalidad
    End Function

End Module
