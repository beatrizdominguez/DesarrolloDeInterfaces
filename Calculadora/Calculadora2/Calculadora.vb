''' <summary>
''' Calculadora
''' by: Beatriz Domínguez
''' </summary>
''' <remarks>DAM 2014- Desarrollo de interfaces</remarks>
''' 


Public Class Calculadora



    'string que guarda las operaciones que hemos ido realizando
    Dim cadena As String
    'variable double que guarda el nuevo numero que introducimos
    Dim a As Double = 0
    'variable double que almacena el resulatado de las operaciones ya realizadas
    Dim resultado As Double = 0 'definimos que haya sólo 5 decimales
    'variable auxiliar para mostrar y√x
    Dim aux As Double = 0

    'vaiable que define que tipo de operación hay que realizar
    Dim op As Integer
    '1=sumar     '3=multiplicar
    '2=restar    '4=dividir
    '5=potencia    '6=raiz

    'variables para controlar los decimales
    Dim coma As Boolean = False
    Dim dec As Integer = 1

    'vector que devulve los valores de a y dec del método
    Dim numeros(2) As Double
    'boolean que indica si es una nueva operación (se ha hecho clic en =)
    Dim nuevaOp As Boolean = True

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA1.Click, Btn1.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 1, numeros)
        a = numeros(0)
        dec = numeros(1)


    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA2.Click, Btn2.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 2, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA3.Click, Btn3.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'prueba a ver si guarda
        'añadimos el número y lo mostramos por pantalla

        numero(a, coma, dec, 3, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA4.Click, Btn4.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 4, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA5.Click, Btn5.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 5, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA6.Click, Btn6.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 6, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA7.Click, Btn7.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 7, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA8.Click, Btn8.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 8, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA9.Click, Btn9.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 9, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA0.Click, Btn0.Click
        If nuevaOp = True Then
            TxtArriba.Clear()
            cadena = ""
        End If
        nuevaOp = False
        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 0, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub BtnIg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAIg.Click, BtnIg.Click

        'realiza una u otra operación según el botón al que se le haya hecho clic
        If op = 1 Then
            addLst(a, 1)
            resultado = resultado + a
        ElseIf op = 2 Then
            addLst(a, 2)
            resultado = resultado - a
        ElseIf op = 3 Then
            addLst(a, 3)
            resultado = FormatNumber(resultado * a, 5)
        ElseIf op = 4 Then
            addLst(a, 4)
            resultado = FormatNumber(resultado / a, 5)
        ElseIf op = 5 Then
            resultado = FormatNumber(resultado ^ a, 5)
        ElseIf op = 6 Then
            resultado = FormatNumber(resultado ^ (1 / a), 5)
        Else
            resultado = a

        End If


        'mostrar el resultado de la operación en la parte escondida (niños)
        addRes(resultado)

        'convertimos el número a string para mostrarlo
        'StringA = StringA + CStr(a) + "=" + CStr(res) + "; "


        'mostramos la información por pantalla
        If op <> 5 And op <> 6 Then
            cadena = cadena + CStr(a)
            mostrarArriba(cadena)
        ElseIf op = 5 Then
            mostrarArriba(TxtArriba.Text + CStr(a))
        ElseIf op = 6 Then
            cadena = CStr(a) + "√" + CStr(aux)
            mostrarArriba(cadena)
        End If

        'mostramos el resultado final
        TxtAbajo.Text = resultado
        TxtAbajoA.Text = resultado

        'añadimos al historial
        addHistory(cadena, resultado)

        'inicializamos la operación a 0 para empezar de nuevo
        op = 0
        a = 0
        aux = 0
        'res = 0
        coma = False
        nuevaOp = True


    End Sub

    'borramos todos los datos que tenemos, inicializamos las variables a 0 o vacío
    Private Sub BtnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAC.Click, BtnC.Click

        a = 0
        resultado = 0
        aux = 0
        TxtArriba.Text = ""
        TxtArribaA.Text = ""
        TxtAbajo.Text = vbEmpty
        TxtAbajoA.Text = vbEmpty
        LstOp.Items.Clear()
        op = 0
        coma = False
        dec = 1
        cadena = ""

    End Sub


    Private Sub BtnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnASum.Click, BtnSum.Click

        ''''''?????
        'concatenar con el =, nueva op
        If nuevaOp = True Then
            resultado = resultado
            cadena = CStr(resultado) + " + "
            addLst(resultado, op)
        Else
            'realizamos la operación anterior
            resultado = operaciones(a, resultado, op)

            'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
            If cadena = "" Then

                cadena = CStr(a) + " + "
            Else
                cadena = cadena + CStr(a) + " + "
            End If
            'añadimos el número y la operación a la lista
            addLst(a, op)
        End If


        'mostramos por pantalla la información
        mostrarArriba(cadena)

        'indicamos que la operación es una suma
        op = 1

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
        nuevaOp = False

    End Sub

    Private Sub BtnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnARes.Click, BtnRes.Click


        If nuevaOp = True Then
            resultado = resultado
            cadena = CStr(resultado) + " - "
            'añadimos el número a la lista
            addLst(resultado, op)
        Else
            'realizamos la operación anterior
            resultado = operaciones(a, resultado, op)

            'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
            If cadena = "" Then

                cadena = CStr(a) + " - "
            Else
                cadena = cadena + CStr(a) + " - "
            End If
            'añadimos el número y la operación a la lista
            addLst(a, op)
        End If


        'mostramos por pantalla la información
        mostrarArriba(cadena)

        'indicamos que la operación es una resta
        op = 2

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
        nuevaOp = False

    End Sub

    Private Sub BtnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAMult.Click, BtnMult.Click


        If nuevaOp = True Then
            resultado = resultado
            cadena = CStr(resultado) + " x "
            'añadimos el número a la lista
            addLst(resultado, op)
        Else
            'realizamos la operación anterior
            resultado = operaciones(a, resultado, op)

            'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
            If cadena = "" Then

                cadena = CStr(a) + " x "
            Else
                cadena = cadena + CStr(a) + " x "
            End If
            'añadimos el número y la operación a la lista
            addLst(a, op)
        End If

        'mostramos por pantalla la información
        mostrarArriba(cadena)

        'indicamos que la operación es una multiplicación
        op = 3

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
        nuevaOp = False

    End Sub

    Private Sub BtnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnADiv.Click, BtnDiv.Click


        If nuevaOp = True Then
            resultado = resultado
            cadena = CStr(resultado) + " ÷ "
            'añadimos el número a la lista
            addLst(resultado, op)
        Else
            'realizamos la operación anterior
            resultado = operaciones(a, resultado, op)

            'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
            If cadena = "" Then

                cadena = CStr(a) + " ÷ "
            Else
                cadena = cadena + CStr(a) + " ÷ "
            End If
            'añadimos el número y la operación a la lista
            addLst(a, op)
        End If

        'mostramos por pantalla la información
        mostrarArriba(cadena)

        'indicamos que la operación es una división
        op = 4

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
        nuevaOp = False

    End Sub

    'borramos el último dígito del número introducido
    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click, BtnABorrar.Click

        'llamamos al método para borrar el último número introducido
        borrar(a, dec, coma, numeros)

        'guardamos los datos que hemos obtenido del método 'borrar'
        a = numeros(0)
        dec = numeros(1)

        'mostramos el número
        TxtAbajo.Text = a
        TxtAbajoA.Text = a

    End Sub

    'indicar si hay coma y mostrarla
    Private Sub BtnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAComa.Click, BtnComa.Click
        coma = True
        TxtAbajo.Text = CStr(a) + ","

    End Sub

    Private Sub NiñosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KidsToolStripMenuItem.Click

        'interfaz de usuario para la calculadora dirigida a niños
        kidsLayout()

    End Sub
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click

        'interfaz de usuario para la calculadora dirigida a empresarios
        businessLayout()

    End Sub

    Private Sub AuelosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OldToolStripMenuItem.Click

        'interfaz de usuario para la calculadora dirigida a personas mayores
        oldLayout()

    End Sub

    'cambiamos el tamaño del formulario para ver el listBox con las operaciones en vertical
    Private Sub ButnMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMas.Click

        If BtnMas.Text = "->" Then
            Me.Width = 700
            BtnMas.Text = "<-"
        Else
            Me.Width = 425
            BtnMas.Text = "->"
        End If

    End Sub

    Private Sub BtnSigno_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSigno.Click
        'camiamos el signo de a
        a = -a
        TxtAbajo.Text = a
    End Sub

    Private Sub BtnRand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRand.Click
        'cambiar a un número double de 0 a 1
        TxtAbajo.Text = (1 * Rnd())

    End Sub

    Private Sub BtnFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFac.Click
        'calculamos el factorial del número
        TxtAbajo.Text = factorial(a)
    End Sub


    Private Sub BtnCuadrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCuadrado.Click

        TxtArriba.Text = CStr(a) + "²"
        TxtAbajo.Text = CStr(FormatNumber(a ^ 2, 5))
    End Sub

    Private Sub BtnCubo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCubo.Click

        TxtArriba.Text = CStr(a) + "³"
        TxtAbajo.Text = CStr(FormatNumber(a ^ 3, 5))
    End Sub

    Private Sub BtnPorc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPorc.Click
        'Dim aux As Double
        TxtArriba.Text = TxtArriba.Text + CStr(a) + "%"
        resultado = FormatNumber(resultado + resultado * (a / 100), 5)
        TxtAbajo.Text = CStr(resultado)

    End Sub

    Private Sub BtnElevado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnElevado.Click

        resultado = a
        TxtArriba.Text = CStr(a) + "^"
        ' TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 5

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

    End Sub

    Private Sub Butn00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn00.Click

        'añadimos dos ceros al número y lo mostramos por pantalla
        If coma = False Then
            a = a * 100
            TxtAbajo.Text = a
        Else
            If dec = 1 Then
                TxtAbajo.Text = CStr(a) + ",00"
            Else
                TxtAbajo.Text = CStr(a) + "00"
            End If
            dec = dec + 2

        End If

    End Sub

    Private Sub BtnRaiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRaiz.Click

        TxtArriba.Text = "√" + CStr(a)
        TxtAbajo.Text = CStr(FormatNumber(Math.Sqrt(a), 5))

    End Sub

    Private Sub BtnExponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExponente.Click
        TxtArriba.Text = "10^" + CStr(a)
        TxtAbajo.Text = CStr(10 ^ a)
    End Sub

    Private Sub BtnRaizCub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRaizCub.Click
        TxtArriba.Text = "³√" + CStr(a)
        TxtAbajo.Text = CStr(FormatNumber(a ^ (1 / 3), 5))
    End Sub

    Private Sub BtnRaiz2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRaiz2.Click

        resultado = a
        aux = a
        TxtArriba.Text = "y√" + CStr(a)
        ' TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 6

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
    End Sub

    Private Sub BtnPts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPts.Click
        a = FormatNumber(a * 166.386, 3)
        TxtArribaA.Text = "Pesetas"
        TxtAbajoA.Text = a
    End Sub

    Private Sub BtnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnE.Click
        a = FormatNumber(a / 166.386, 3)

        TxtArribaA.Text = "€"
        TxtAbajoA.Text = a
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        History.Show()
    End Sub
End Class
