Module Botones

#Region "Botones"
   

    Public Sub Numeros()

        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        Juego.lblInstrucciones.Text = "Ordena los números del 1 al 25 lo más rápido posible"

        'definimos el numero para todos los botones
        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)
            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num
            count = count + 1
            'asignamos un número
            boton.Text = num

            'definimos el color
            boton.BackColor = Color.Black
        Next

    End Sub

    Public Sub colores()

        Juego.lblInstrucciones.Text = "Haz clic en todos los botones del color ...."



        Dim num As Integer
        Dim numeros(25) As Integer
        Dim count As Integer = 0

        Dim colores(25) As Object
        Dim i As Integer
        Dim x As Integer
        Tiempos.Show()

        'For i = 0 To 24
        '    If (i Mod 2) = 0 Then
        '        colores(i) = Color.White
        '        Tiempos.ListBox1.Items.Add("white")
        '    Else
        '        colores(i) = Color.White
        '        Tiempos.ListBox1.Items.Add("red")
        '    End If

        'Next i

        'For i = 0 To i = 11

        '    colores(i) = Color.Red
        '    'i = i + 1
        'Next i

        'For x = 12 To x = 25

        '    colores(x) = Color.White
        'Next x



        ''cuantos colores?
        ''si pongo 5 de cada además la cuenta me sale redonda, para el count de final de partida
        ''25 = 5x5


        colores(0) = Color.Red
        colores(1) = Color.Red
        colores(2) = Color.Red
        colores(3) = Color.Red
        colores(4) = Color.Red
        colores(5) = Color.Red
        colores(6) = Color.Red
        colores(7) = Color.Red
        colores(8) = Color.Red
        colores(9) = Color.Red
        colores(10) = Color.Red
        colores(11) = Color.Red
        colores(12) = Color.White
        colores(13) = Color.White
        colores(14) = Color.White
        colores(15) = Color.White
        colores(16) = Color.White
        colores(17) = Color.White
        colores(18) = Color.White
        colores(19) = Color.White
        colores(20) = Color.White
        colores(21) = Color.White
        colores(22) = Color.White
        colores(23) = Color.White
        colores(24) = Color.White

        Juego.Button1.BackColor = colores((Int(25 * Rnd() + 1) - 1))

        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)

            'asignamos un número
            boton.Text = ""

            Do
                num = Int(25 * Rnd() + 1)
            Loop Until Array.IndexOf(numeros, num) = -1
            numeros(count) = num
            'definimos el color
            boton.BackColor = colores((num - 1))

            count = count + 1
        Next

    End Sub

    Public Sub colores2()

        Dim num As Integer
        Dim count As Integer

        Dim colores(25) As Object
        colores(0) = Color.White
        colores(1) = Color.Red



        For Each control In Juego.TableLayoutPanel1.Controls
            Dim boton = TryCast(control, Button)

            'asignamos un número
            boton.Text = ""


            num = Int(25 * Rnd() + 1)


            'definimos el color
            boton.BackColor = colores((Int(2 * Rnd() + 1) - 1))

        Next

    End Sub
#End Region


    Public Sub fin()

        'paramos el tiempo

        Juego.Timer1.Stop()

        'mostramos el mensaje
        MsgBox("Felicitaciones", MsgBoxStyle.OkOnly, "Fin del juego")

        'suena la música
        Tiempos.Show()

        'añadimos el tiempo a la tabla de tiempos
        If Juego.NumerosMnu.Checked = True Then
            Tiempos.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Numeros    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g"))
        ElseIf Juego.ColoresMnu.Checked = True Then
            Tiempos.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Colores    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g"))
        ElseIf Juego.SimbolosMnu.Checked = True Then
            Tiempos.ListBox1.Items.Add(CStr(Juego.lblTime.Text) + "    Símbolos    " + CStr(Juego.errores) + "     " + Date.Now.ToString("g"))

        End If
        



    End Sub

End Module
