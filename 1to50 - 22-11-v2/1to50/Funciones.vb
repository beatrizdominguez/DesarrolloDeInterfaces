Module Funciones

#Region "Botones"

    Public Sub Numeros()

        Juego.lblInstrucciones.Text = "Ordena los números del 1 al 25 lo más rápido posible."

        Randomize()

        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        Dim myFont As System.Drawing.Font
        myFont = New System.Drawing.Font("OCR A Extended", 18, FontStyle.Bold)


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

        Dim myFont As System.Drawing.Font
        myFont = New System.Drawing.Font("OCR A Extended", 18, FontStyle.Bold)

        'creamos y cargamos el vector con los colores
        Dim colores() As Object
        colores = cargarVectorColores(paleta, colores)

        'boton1
        Juego.Button1.Visible = True
        Juego.Button1.Text = ""
        Juego.Button1.BackColor = colores((Int(25 * Rnd() + 1) - 1))

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)

            'numero aleatorio no repetido
            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num

            'definimos el color
            boton.BackColor = colores((num - 1))
            boton.Font = myFont
            count = count + 1
            'no texto
            boton.Text = ""
        Next

    End Sub

    Public Sub simbolos(ByVal grupo As String)
        ' Public Sub simbolos(String simbolo)

        Juego.lblInstrucciones.Text = "Haz clic en todos los botones con símbolo ...."

        Randomize()

        'definimos el tipo de letra
        Dim myFont1, myFont2 As System.Drawing.Font
        myFont1 = New System.Drawing.Font("Webdings", 18, FontStyle.Bold)
        myFont2 = New System.Drawing.Font("Wingdings", 18, FontStyle.Bold)


        'definimos y cargamos un vector con los iconos
        Dim iconos() As String
        iconos = cargarVectorSimbolos(grupo, iconos)

        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0


        'definimos el numero para todos los botones
        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)

            'numero al zar
            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num
            count = count + 1

            'tipo de letra
            If grupo = "global" Then
                boton.Font = myFont1
            Else
                boton.Font = myFont2
            End If
            'icono
            boton.Text = iconos((num - 1))


            'definimos el color
            boton.BackColor = Color.White
            boton.ForeColor = Color.DarkOrchid

        Next

        'boton1
        ''
        Juego.Button1.Visible = True
        Juego.Button1.BackColor = Color.White
        'tipo de letra
        If grupo = "global" Then
            Juego.Button1.Font = myFont1
        Else
            Juego.Button1.Font = myFont2
        End If
        'simbolo
        Juego.Button1.Text = iconos((Int(25 * Rnd() + 1) - 1))


    End Sub

#Region "Vectores"
    ''' <summary>
    ''' Cargamos un array según un criterio, paleta
    ''' </summary>
    ''' <param name="paleta">Gama de colores</param>
    ''' <param name="colores">Vector de objetos </param>
    ''' <returns>colores (array lleno)</returns>
    Public Function cargarVectorColores(ByVal paleta As String, ByVal colores() As Object) As Object()

        If paleta = "multicolor" Then

            colores = {Color.Red, Color.Red, Color.Red, Color.Red, Color.Red,
                                  Color.White, Color.White, Color.White, Color.White, Color.White,
                                Color.GreenYellow, Color.GreenYellow, Color.GreenYellow, Color.GreenYellow, Color.GreenYellow,
                                  Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange,
                                  Color.Turquoise, Color.Turquoise, Color.Turquoise, Color.Turquoise, Color.Turquoise}

        ElseIf paleta = "azul" Then

            colores = {Color.Aqua, Color.Aqua, Color.Aqua, Color.Aqua, Color.Aqua,
                                      Color.LightSkyBlue, Color.LightSkyBlue, Color.LightSkyBlue, Color.LightSkyBlue, Color.LightSkyBlue,
                                    Color.LightSteelBlue, Color.LightSteelBlue, Color.LightSteelBlue, Color.LightSteelBlue, Color.LightSteelBlue,
                                      Color.DarkSlateBlue, Color.DarkSlateBlue, Color.DarkSlateBlue, Color.DarkSlateBlue, Color.DarkSlateBlue,
                                      Color.Turquoise, Color.Turquoise, Color.Turquoise, Color.Turquoise, Color.Turquoise}

        ElseIf paleta = "verde" Then

            colores = {Color.White, Color.White, Color.White, Color.White, Color.White,
                                Color.GreenYellow, Color.GreenYellow, Color.GreenYellow, Color.GreenYellow, Color.GreenYellow,
                              Color.MediumSeaGreen, Color.MediumSeaGreen, Color.MediumSeaGreen, Color.MediumSeaGreen, Color.MediumSeaGreen,
                                Color.MediumSpringGreen, Color.MediumSpringGreen, Color.MediumSpringGreen, Color.MediumSpringGreen, Color.MediumSpringGreen,
                                Color.Lime, Color.Lime, Color.Lime, Color.Lime, Color.Lime}

        ElseIf paleta = "rosa" Then

            colores = {Color.Pink, Color.Pink, Color.Pink, Color.Pink, Color.Pink,
                               Color.HotPink, Color.HotPink, Color.HotPink, Color.HotPink, Color.HotPink,
                             Color.Fuchsia, Color.Fuchsia, Color.Fuchsia, Color.Fuchsia, Color.Fuchsia,
                               Color.LavenderBlush, Color.LavenderBlush, Color.LavenderBlush, Color.LavenderBlush, Color.LavenderBlush,
                               Color.DeepPink, Color.DeepPink, Color.DeepPink, Color.DeepPink, Color.DeepPink}


        ElseIf paleta = "monocromo" Then

            colores = {Color.White, Color.White, Color.White, Color.White, Color.White,
                                     Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
                                   Color.Silver, Color.Silver, Color.Silver, Color.Silver, Color.Silver,
                                     Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray,
                                     Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige}

        End If

        Return colores
    End Function

    ''' <summary>
    ''' Cargamos un array con diferentes signos según el grupo
    ''' </summary>
    ''' <param name="grupo">Grupo de símbolos que se van a utilizar</param>
    ''' <param name="iconos">Array lleno con los símbolos</param>
    ''' <returns>iconos (array lleno)</returns>
    ''' <remarks></remarks>
    Public Function cargarVectorSimbolos(ByVal grupo As String, ByVal iconos() As String) As String()

        If grupo = "global" Then
            iconos = {"-", "-", "-", "-", "-",
                                "q", "q", "q", "q", "q",
                                "·", "·", "·", "·", "·",
                                "_", "_", "_", "_", "_",
                                "Y", "Y", "Y", "Y", "Y"}

        ElseIf grupo = "manos" Then

            iconos = {"I", "I", "I", "I", "I",
                               "A", "A", "A", "A", "A",
                               "D", "D", "D", "D", "D",
                               "B", "B", "B", "B", "B",
                               "G", "G", "G", "G", "G"}

        ElseIf grupo = "circulos" Then

            iconos = {"S", "S", "S", "S", "S",
                               "R", "R", "R", "R", "R",
                               "T", "T", "T", "T", "T",
                               "Y", "Y", "Y", "Y", "Y",
                               "]", "]", "]", "]", "]"}
        ElseIf grupo = "cara" Then
            iconos = {"J", "J", "J", "J", "J",
                               "K", "K", "K", "K", "K",
                               "L", "L", "L", "L", "L",
                               "¡", "¡", "¡", "¡", "¡",
                               "M", "M", "M", "M", "M"}

        ElseIf grupo = "zodiaco" Then
            iconos = {"^", "^", "^", "^", "^",
                            "a", "a", "a", "a", "a",
                            "f", "f", "f", "f", "f",
                            "h", "h", "h", "h", "h",
                            "i", "i", "i", "i", "i"}

        End If

        Return iconos
    End Function

#End Region

#End Region

    ''' <summary>
    ''' El juego ha acadabo
    ''' </summary>
    Public Sub fin()

        'paramos los sonidos de la partida ej:reloj
        Juego.stopAudio()

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

            ' modalidad = "Multicolor"
            modalidad = "Multi"

        ElseIf Juego.AzulCMnu.Checked = True Then

            ' modalidad = "Azules"
            modalidad = "Azul  "

        ElseIf Juego.VerdeCMnu.Checked = True Then

            ' modalidad = "Verdes"
            modalidad = "Verde "

        ElseIf Juego.RosaCMnu.Checked = True Then

            'modalidad = "Rosas"
            modalidad = "Rosa "

        ElseIf Juego.MonocromoCMnu.Checked = True Then

            modalidad = "Mono"
            'modalidad = "Monocromo"

        End If

        Return modalidad
    End Function

    Public Function modalidadSimbolo() As String

        Dim modalidad As String = ""

        If Juego.GlobalSMnu.Checked = True Then

            ' modalidad = "Multicolor"
            modalidad = "GL  "

        ElseIf Juego.ManosSMnu.Checked = True Then

            ' modalidad = "Azules"
            modalidad = "Man "

        ElseIf Juego.CirculosSMnu.Checked = True Then

            ' modalidad = "Verdes"
            modalidad = "Cir "

        ElseIf Juego.SmileSMnu.Checked = True Then

            modalidad = "Sm  "
            'modalidad = "Monocromo"

        ElseIf Juego.ZodiacoSMnu.Checked = True Then

            modalidad = "Zod "
            'modalidad = "Monocromo"

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
            nombre = "anonimo"
        End If

        Return nombre
    End Function

    ''' <summary>
    ''' Añade la información de la partida a la tabla de tiempos
    ''' </summary>
    Public Sub añadirPartida()

        'cargamos el listbox
        cargarTiempos()

        Dim espacios As String = Space(5)

        'añadimos el tiempo a la tabla de tiempos
        If Juego.NumerosMnu.Checked = True Then

            '   Juego.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + cinco + "Numeros    " + CStr(Juego.errores) + cinco + Date.Now.ToString("g") + cinco + nombreJugador())
            tiempos.lstTiempos.Items.Add(CStr(Juego.lblTime.Text) + espacios + "Numeros   " + espacios + espacios + CStr(Juego.errores) + espacios + Date.Now.ToString("g") + espacios + nombreJugador())

        ElseIf Juego.ColoresMnu.Checked = True Then

            Dim color As String = modalidadColor()

            ' Juego.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + cinco + "Colores/ " + color + cinco + CStr(Juego.errores) + cinco + Date.Now.ToString("g") + cinco + nombreJugador())
            tiempos.lstTiempos.Items.Add(CStr(Juego.lblTime.Text) + espacios + "Colores/ " + color + espacios + CStr(Juego.errores) + espacios + Date.Now.ToString("g") + espacios + nombreJugador())


        ElseIf Juego.SimbolosMnu.Checked = True Then

            Dim tipo As String = modalidadSimbolo()

            ' Juego.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + cinco + "Símbolos/ " + tipo + cinco + CStr(Juego.errores) + cinco + Date.Now.ToString("g") + cinco + nombreJugador())

            tiempos.lstTiempos.Items.Add(CStr(Juego.lblTime.Text) + espacios + "Simbolos/ " + tipo + espacios + CStr(Juego.errores) + espacios + Date.Now.ToString("g") + espacios + nombreJugador())

        End If

        'guardamos el historial de partidas
        guardarTiempos()

    End Sub


    Public Sub cargarTiempos()

        ''no haya datos en el listbox
        tiempos.lstTiempos.Items.Clear()

        ' FileOpen(1, My.Resources.historialPartidas.ToString, OpenMode.Input
        ' FileOpen(1, My.Resources.historialPartidas, OpenMode.Input)
        FileOpen(1, "C:/datos/historialPartidas.txt", OpenMode.Input)


        Do While Not EOF(1)

            tiempos.lstTiempos.Items.Add(LineInput(1))
        Loop

        FileClose(1)

    End Sub

    Public Sub guardarTiempos()

        'imprimir todo el contnido del listbox en el archivo
        Dim W As System.IO.StreamWriter
        Dim i As Integer

        ' W = New System.IO.StreamWriter("C:/datos/historialPartidas.txt")
        W = New System.IO.StreamWriter(My.Resources.historialPartidas.ToString)

        For i = 0 To tiempos.lstTiempos.Items.Count - 1
            W.WriteLine(tiempos.lstTiempos.Items.Item(i))
        Next
        W.Close()

    End Sub

#End Region

    ''' <summary>
    ''' Desmarcamos todos los menus y submenus
    ''' </summary>
    Public Sub menus()

        'MyMenu= pestañas principales
        For Each MyMenu As ToolStripMenuItem In Juego.MenuStrip1.Items

            'MyMenyItem= submenu ej: Símbolos
            For Each MyMenuItem As ToolStripMenuItem In MyMenu.DropDownItems
                MyMenuItem.Checked = False

                'MyMenuItemSub= submeny del anterior ej: Multicolor
                For Each MyMenuItemSub As ToolStripMenuItem In MyMenuItem.DropDownItems
                    MyMenuItemSub.Checked = False
                Next
            Next
        Next

    End Sub

#Region "ON/OFF"

    ''' <summary>
    ''' Desactivamos todos los botones del panel para que no se pueda hacer clic sobre ellos
    ''' </summary>
    Public Sub desactivar()

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            boton.Enabled = False
        Next
    End Sub

    ''' <summary>
    ''' Activamos todos los botones del panel para jugar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub activar()

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            boton.Enabled = True
        Next
    End Sub

#End Region

End Module