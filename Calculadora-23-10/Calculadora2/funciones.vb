Module funciones


    ''' <summary>
    ''' calcula el número
    ''' </summary>
    ''' <param name="a">número</param>
    ''' <param name="coma">boolean para saber si hay o no decimales</param>
    ''' <param name="dec">contador de decimales</param>
    ''' <param name="num">número que añadimos</param>
    ''' <param name="numeros">array para retornar las variables</param>
    ''' <remarks></remarks>
    ''' 
    Public Sub numero(ByVal a As Double, ByVal coma As Boolean, ByVal dec As Integer, ByVal num As Integer, ByVal numeros As Array)

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + num
        Else
            a = a + num / 10 ^ dec
            dec = dec + 1
        End If

        'lo mostramos por pantalla
        Calculadora.TxtAbajoA.Text = a
        Calculadora.TxtAbajo.Text = a

        'guardamos las variables en el vector
        numeros(0) = a
        numeros(1) = dec

    End Sub
    ''' <summary>
    ''' calculamos el factorial de un número (n* n-1 * n-2 * ... * 1)
    ''' </summary>
    ''' <param name="a">numero del que calculamos el factorial</param>
    ''' <returns>a, resultado de la operación</returns>
    ''' <remarks></remarks>
    Public Function factorial(ByVal a As Double)

        Calculadora.TxtArriba.Text = CStr(a) + "!"

        'hacemos un bucle hasta llegar a 1
        Dim i As Integer
        For i = 1 To a - 1
            a = a * i
        Next i

        Return a
    End Function

    ''' <summary>
    ''' realizamos la operación necesaria
    ''' </summary>
    ''' <param name="a">nuevo número con el que operar</param>
    ''' <param name="res">número con el que operar resultado de las operaciones anteriores</param>
    ''' <param name="op">tipo de operación a realizar</param>
    ''' <returns>res, resultado de la operacion</returns>
    ''' <remarks></remarks>
    Public Function operaciones(ByVal a As Double, ByVal res As Double, ByVal op As Integer) As Double

        If res = 0 Then
            res = a
        Else
            'realizamos la operaión y calculamos el resultado hasta ahora, según la última operación realizada
            If op = 1 Then
                res = res + a
            ElseIf op = 2 Then
                res = res - a
            ElseIf op = 3 Then
                res = FormatNumber(res * a, 5)
            ElseIf op = 4 Then
                res = FormatNumber(res / a, 5)
                ' ElseIf op = 5 Then
                '    res = res ^ a
            End If
        End If

        'retornamos el resultado
        Return res

    End Function

    ''' <summary>
    ''' mostramos las operaciones realizadas por pantalla
    ''' </summary>
    ''' <param name="stringA">conjunto de operaciones realizadas</param>
    ''' <remarks></remarks>
    Public Sub mostrarArriba(ByVal stringA As String)

        'mostramos la operación
        Calculadora.TxtArriba.Text = stringA
        Calculadora.TxtArribaA.Text = stringA

        'reiniciamos la parte de abajo mostrando 0
        Calculadora.TxtAbajo.Text = vbEmpty
        Calculadora.TxtAbajoA.Text = vbEmpty
    End Sub

    ''' <summary>
    ''' añadimos la operación a la lista en la vista de los niños
    ''' </summary>
    ''' <param name="a">número a añadir</param>
    ''' <param name="op">tipo de operación a añadir</param>
    ''' <remarks></remarks>
    Public Sub addLst(ByVal a As Double, ByVal op As Integer)

        'añadimos el número con el signo correspondiente
        If Calculadora.LstOp.Items.Count = 0 Then
            Calculadora.LstOp.Items.Add(a)
        Else
            If op = 1 Then
                Calculadora.LstOp.Items.Add(CStr(a) + "+")
            ElseIf op = 2 Then
                Calculadora.LstOp.Items.Add(CStr(a) + "-")
            ElseIf op = 3 Then
                Calculadora.LstOp.Items.Add("x" + CStr(a))
            ElseIf op = 4 Then
                Calculadora.LstOp.Items.Add(CStr(a) + "÷")
            Else
                Calculadora.LstOp.Items.Add(CStr(a))
            End If
        End If
    End Sub

    ''' <summary>
    ''' añadimos el resultado a la lista en la vista de los niños
    ''' </summary>
    ''' <param name="res"></param>
    ''' <remarks></remarks>
    Public Sub addRes(ByVal res As Double)

        'añadimos el resultado
        Calculadora.LstOp.Items.Add("---------------------")
        Calculadora.LstOp.Items.Add(res)

    End Sub

    ''' <summary>
    ''' borramos el último número introducido
    ''' </summary>
    ''' <param name="a">número a modificar</param>
    ''' <param name="dec">contador de decimales</param>
    ''' <param name="coma">boolean para saber si hay o no decimales</param>
    ''' <param name="numeros">array para retornar las variables</param>
    ''' <remarks></remarks>
    Public Sub borrar(ByVal a As Double, ByVal dec As Integer, ByVal coma As Boolean, ByVal numeros As Array)
        Dim txtBorrar As String

        'convertimos el número a string
        txtBorrar = CStr(a)

        If (txtBorrar.Length > 1) Then

            'borramos el último carácter
            txtBorrar = txtBorrar.Remove(txtBorrar.Length - 1, 1)

        ElseIf (txtBorrar.Length = 1) Then
            txtBorrar = "0"
        End If

        'si hemos borrado decimales indicar la posición
        If dec > 1 Then
            dec = dec - 1
        End If

        'indicar si ya no hay decimales
        If dec = 1 Then
            coma = False

        End If

        'convertimos el nuevo número a double de nuevo
        a = CDbl(txtBorrar)

        'lo guardamos en el array
        numeros(0) = a
        numeros(1) = dec

    End Sub

End Module
