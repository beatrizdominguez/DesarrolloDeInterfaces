''' <summary>
''' Calculadora
''' by: Beatriz Domínguez
''' </summary>
''' <remarks>DAM 2014- Desarrollo de interfaces</remarks>
''' 


Public Class Calculadora



    'string que guarda las operaciones que hemos ido realizando
    Dim StringA As String
    'variable double que guarda el nuevo numero que introducimos
    Dim a As Double = 0
    'variable double que almacena el resulatado de las operaciones ya realizadas
    Dim res As Double = 0 'definimos que haya sólo 5 decimales

    'vaiable que define que tipo de operación hay que realizar
    Dim op As Integer
    '1=sumar     '3=multiplicar
    '2=restar    '4=dividir
    '5=potencia    '6=raiz

    'variables para controlar los decimales
    Dim coma As Boolean = False
    Dim dec As Integer = 1

    'variable string auxiliar para borrar uno de los carácteres
    Dim txtBorrar As String
    'vector que devulve los valores de a y dec del método
    Dim numeros(2) As Double

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA1.Click, Btn1.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 1, numeros)
        a = numeros(0)
        dec = numeros(1)

    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA2.Click, Btn2.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 2, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA3.Click, Btn3.Click

        'prueba a ver si guarda
        'añadimos el número y lo mostramos por pantalla

        numero(a, coma, dec, 3, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA4.Click, Btn4.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 4, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA5.Click, Btn5.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 5, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA6.Click, Btn6.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 6, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA7.Click, Btn7.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 7, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA8.Click, Btn8.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 8, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA9.Click, Btn9.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 9, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnA0.Click, Btn0.Click

        'añadimos el número y lo mostramos por pantalla
        numero(a, coma, dec, 0, numeros)
        a = numeros(0)
        dec = numeros(1)
    End Sub

    Private Sub BtnIg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAIg.Click, BtnIg.Click

        'realiza una u otra operación según el botón al que se le haya hecho clic
        If op = 1 Then
            addLst(a, 1)
            res = res + a
        ElseIf op = 2 Then
            addLst(a, 2)
            res = res - a
        ElseIf op = 3 Then
            addLst(a, 3)
            res = FormatNumber(res * a, 5)
        ElseIf op = 4 Then
            addLst(a, 4)
            res = FormatNumber(res / a, 5)
        ElseIf op = 5 Then
            res = FormatNumber(res ^ a, 5)
        ElseIf op = 6 Then
            ' res = res(raiz(a))
            res = FormatNumber(res ^ (1 / a), 5)

        End If


        'mostrar el resultado de la operación en la parte escondida (niños)
        addRes(res)

        'convertimos el número a string para mostrarlo
        StringA = StringA + CStr(a) + "=" + CStr(res) + "; "

        'mostramos la información por pantalla
        If op <> 5 And op <> 6 Then
            mostrarArriba(StringA)
        Else
            mostrarArriba(TxtArriba.Text + CStr(a))
        End If

        'mostramos el resultado final
        TxtAbajo.Text = res
        TxtAbajoA.Text = res

        'inicializamos la operación a 0 para empezar de nuevo
        op = 0
        a = 0
        coma = False

    End Sub

    'borramos todos los datos que tenemos, inicializamos las variables a 0 o vacío
    Private Sub BtnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAC.Click, BtnC.Click

        a = 0
        'b = 0
        res = 0
        TxtArriba.Text = ""
        TxtArribaA.Text = ""
        TxtAbajo.Text = vbEmpty
        TxtAbajoA.Text = vbEmpty
        LstOp.Items.Clear()
        op = 0
        coma = False
        dec = 1
        StringA = ""

    End Sub


    Private Sub BtnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnASum.Click, BtnSum.Click

        'realizamos la operación anterior
        res = operaciones(a, res, op)

        'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
        If StringA = "" Then

            StringA = CStr(a) + " + "
        Else
            StringA = StringA + CStr(a) + " + "
        End If

        'añadimos el número y la operación a la lista
        addLst(a, op)

        'mostramos por pantalla la información
        mostrarArriba(StringA)

        'indicamos que la operación es una suma
        op = 1

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

    End Sub

    Private Sub BtnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnARes.Click, BtnRes.Click

        'realizamos la operación anterior
        res = operaciones(a, res, op)

        'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
        If StringA = "" Then
            StringA = CStr(a) + " - "
        Else
            StringA = StringA + CStr(a) + " - "
        End If

        'añadimos el número y la operación a la lista
        addLst(a, op)

        'mostramos por pantalla la información
        mostrarArriba(StringA)

        'indicamos que la operación es una resta
        op = 2

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

    End Sub

    Private Sub BtnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAMult.Click, BtnMult.Click

        'realizamos la operación anterior
        res = operaciones(a, res, op)

        'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
        If StringA = "" Then

            StringA = CStr(a) + " X "
        Else
            StringA = StringA + CStr(a) + " X "
        End If

        'vaciamos la lista y escribimos el total y luego hacemos la multiplicación
        LstOp.Items.Clear()
        addLst(res, 0)

        'mostramos por pantalla la información
        mostrarArriba(StringA)

        'indicamos que la operación es una multiplicación
        op = 3

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

    End Sub

    Private Sub BtnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnADiv.Click, BtnDiv.Click

        'realizamos la operación anterior
        res = operaciones(a, res, op)

        'convertimos el número a string y lo añadimos a las peraciones anteriores para mostrarlo
        If StringA = "" Then
            StringA = CStr(a) + " ÷ "
        Else
            StringA = StringA + CStr(a) + " ÷ "
        End If

        'vaciamos la lista y escribimos el total y luego hacemos la divixión
        LstOp.Items.Clear()
        addLst(res, 0)

        'mostramos por pantalla la información
        mostrarArriba(StringA)

        'indicamos que la operación es una división
        op = 4

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

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
            Me.Width = 800
            BtnMas.Text = "<-"
        Else
            Me.Width = 425
            BtnMas.Text = "->"
        End If

    End Sub

    Private Sub BtnSigno_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSigno.Click
        'signo = True
        a = -a
        'TxtAbajo.Text = a
        'TxtAbajoA.Text = a
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
        res = FormatNumber(res + res * (a / 100), 5)
        TxtAbajo.Text = CStr(res)

    End Sub

    Private Sub BtnElevado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnElevado.Click

        res = a
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
        Else
            'a = a + 0 / 10 ^ dec
            dec = dec + 2
        End If
        TxtAbajo.Text = a

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

        res = a
        TxtArriba.Text = CStr(a) + "√"
        ' TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 6

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
    End Sub

End Class
