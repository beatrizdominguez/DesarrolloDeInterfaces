Module Funciones

#Region "Botones"

    Public Sub Numeros()

        Juego.lblInstrucciones.Text = "Ordena los números del 1 al 25 lo más rápido posible"

        Randomize()

        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        Dim myFont As System.Drawing.Font
        myFont = New System.Drawing.Font("Cooper Black", 18, FontStyle.Bold)


        'definimos el numero para todos los botones
        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            'formato del oboton
            'boton.FlatStyle = FlatStyle.Flat
            'boton.Dock = DockStyle.Fill
            boton.BackColor = Color.White
            boton.ForeColor = Color.Purple
            'burlyWood + LightStaleGray

            boton.Font = myFont


            '            boton.Enabled = True
            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num
            count = count + 1
            'asignamos un número
            boton.Text = num

        Next

        Juego.Button1.Visible = False

    End Sub

    Public Sub colores(ByVal paleta As String)

        Juego.lblInstrucciones.Text = "Haz clic en todos los botones de color ...."

        Randomize()

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

        Dim coloresRosa() As Object = {Color.Pink, Color.Pink, Color.Pink, Color.Pink, Color.Pink,
                                Color.HotPink, Color.HotPink, Color.HotPink, Color.HotPink, Color.HotPink,
                              Color.Fuchsia, Color.Fuchsia, Color.Fuchsia, Color.Fuchsia, Color.Fuchsia,
                                Color.LavenderBlush, Color.LavenderBlush, Color.LavenderBlush, Color.LavenderBlush, Color.LavenderBlush,
                                Color.DeepPink, Color.DeepPink, Color.DeepPink, Color.DeepPink, Color.DeepPink}

        Dim coloresGris() As Object = {Color.White, Color.White, Color.White, Color.White, Color.White,
                                 Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
                               Color.Silver, Color.Silver, Color.Silver, Color.Silver, Color.Silver,
                                 Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray,
                                 Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige}



        Juego.Button1.Visible = True
        Juego.Button1.Text = ""


        If paleta = "multicolor" Then
            Juego.Button1.BackColor = colores((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "azul" Then
            Juego.Button1.BackColor = coloresAzul((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "verde" Then
            Juego.Button1.BackColor = coloresVerde((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "rosa" Then
            Juego.Button1.BackColor = coloresRosa((Int(25 * Rnd() + 1) - 1))
        ElseIf paleta = "monocromo" Then
            Juego.Button1.BackColor = coloresGris((Int(25 * Rnd() + 1) - 1))
        End If


        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)

            'asignamos un número
            boton.Text = ""
            'boton.Enabled = True

            'numero aleatorio no repetido
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
            ElseIf paleta = "rosa" Then
                boton.BackColor = coloresRosa((num - 1))
            ElseIf paleta = "monocromo" Then
                boton.BackColor = coloresGris((num - 1))
            End If

            count = count + 1
        Next

    End Sub

    Public Sub simbolos(ByVal grupo As String)
        ' Public Sub simbolos(String simbolo)

        Juego.lblInstrucciones.Text = "Haz clic en todos los botones con el símbolo ...."

        Randomize()

        'definimos el tipo de letra
        Dim myFont1, myFont2 As System.Drawing.Font
        myFont1 = New System.Drawing.Font("Webdings", 18, FontStyle.Bold)
        myFont2 = New System.Drawing.Font("Wingdings", 18, FontStyle.Bold)


        Dim iconos() As String = {"-", "-", "-", "-", "-",
                                  "q", "q", "q", "q", "q",
                                  "·", "·", "·", "·", "·",
                                  "_", "_", "_", "_", "_",
                                  "Y", "Y", "Y", "Y", "Y"}

        Dim iconosManos() As String = {"I", "I", "I", "I", "I",
                                 "A", "A", "A", "A", "A",
                                 "D", "D", "D", "D", "D",
                                 "B", "B", "B", "B", "B",
                                 "G", "G", "G", "G", "G"}


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
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num
            count = count + 1
            'definimos el siimbolo
            If grupo = "global" Then
                boton.Font = myFont1
                boton.Text = iconos((num - 1))
            ElseIf grupo = "manos" Then
                boton.Font = myFont2
                boton.Text = iconosManos((num - 1))
            End If


            'definimos el color
            boton.BackColor = Color.Black
            boton.ForeColor = Color.White

        Next




        Juego.Button1.Visible = True


        If grupo = "global" Then
            Juego.Button1.Text = iconos((Int(25 * Rnd() + 1) - 1))

        ElseIf grupo = "manos" Then
            Juego.Button1.Text = iconosManos((Int(25 * Rnd() + 1) - 1))
        End If

    End Sub
#End Region

    ''' <summary>
    ''' El juego ha acadabo
    ''' </summary>
    Public Sub fin()

        'paramos el tiempo
        Juego.Timer1.Stop()

        'mostramos el formulario de final de partida
        FinPartida.Show()

        'desactivamos los botones
        desactivar()

    End Sub

#Region "Tabla de tiempos"

    ''' <summary>
    ''' Funcion que devuelve el nombre de la modalidad de color a la que se está jugando
    ''' </summary>
    ''' <returns>Nombre de la modalidad de color</returns>
    Public Function modalidadColor() As String

        Dim modalidad As String = ""

        If Juego.MulticolorCMnu.Checked = True Then

            modalidad = "Multicolor"

        ElseIf Juego.AzulCMnu.Checked = True Then

            modalidad = "Azules"

        ElseIf Juego.VerdeCMnu.Checked = True Then

            modalidad = "Verdes"

        ElseIf Juego.RosaCMnu.Checked = True Then

            modalidad = "Rosas"

        ElseIf Juego.MonocromoCMnu.Checked = True Then

            modalidad = "Monocromo"

        End If

        Return modalidad
    End Function

    ''' <summary>
    ''' xxxxx el nombre del jugador.
    ''' </summary>
    ''' <returns>nombre</returns>
    Public Function nombreJugador() As String

        Dim nombre As String

        If FinPartida.TxtNombre.Text <> "" Then
            nombre = FinPartida.TxtNombre.Text
        Else
            nombre = "anónimo"
        End If

        Return nombre
    End Function

    ''' <summary>
    ''' Añade la información de la partida a la tabla de tiempos
    ''' </summary>
    Public Sub añadirPartida()

        'añadimos el tiempo a la tabla de tiempos
        If Juego.NumerosMnu.Checked = True Then

            Juego.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Numeros    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g") + "     " + nombreJugador())

        ElseIf Juego.ColoresMnu.Checked = True Then

            Dim color As String = modalidadColor()

            Juego.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Colores    " + color + "             " + CStr(Juego.errores) + "     " + Date.Now.ToString("g") + "     " + nombreJugador())

        ElseIf Juego.SimbolosMnu.Checked = True Then

            Juego.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Símbolos    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g") + "     " + nombreJugador())

        End If

    End Sub

#End Region

    'llamamos según el tiempo a esta función, y va cambiadno el color de las etiquetas, para marear
    Public Sub cambioColores()

    End Sub

    'click de los menus todos a cero
    Public Sub menus()

        For Each MyMenu As ToolStripMenuItem In Juego.MenuStrip1.Items

            For Each MyMenuItem As ToolStripMenuItem In MyMenu.DropDownItems
                MyMenuItem.Checked = False

                For Each MyMenuItemSub As ToolStripMenuItem In MyMenuItem.DropDownItems
                    MyMenuItemSub.Checked = False
                Next
            Next
        Next

    End Sub

    Public Sub desactivar()

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            boton.Enabled = False
        Next
    End Sub

    Public Sub activar()

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            boton.Enabled = True
        Next
    End Sub


End Module
