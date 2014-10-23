Module funciones


    ''' <summary>
    ''' calcula el número
    ''' </summary>
    ''' <param name="a">número</param>
    ''' <param name="coma">boolean para saber si hay o no comas</param>
    ''' <param name="dec">contados de decimales</param>
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

    ''devolver las variables??
    'Public Sub inicializar(ByVal a As Double, ByVal coma As Boolean, ByVal dec As Integer, ByVal signo As Boolean)
    '    a = 0
    '    coma = False
    '    dec = 1
    '    signo = False
    'End Sub

    Public Function factorial(ByVal a As Double)
        Calculadora.TxtArriba.Text = CStr(a) + "!"

        Dim i As Integer
        For i = 1 To a - 1
            a = a * i


        Next i

        Return a
    End Function

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
        Return res

    End Function

    Public Sub mostrarArriba(ByVal stringA As String)

        'mostramos la operación
        Calculadora.TxtArriba.Text = stringA
        Calculadora.TxtArribaA.Text = stringA

        'reiniciamos la parte de abajo mostrando 0
        Calculadora.TxtAbajo.Text = vbEmpty
        Calculadora.TxtAbajoA.Text = vbEmpty
    End Sub
    Public Sub addLst(ByVal a As Double, ByVal op As Integer)

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
    Public Sub addRes(ByVal res As Double)
        Calculadora.LstOp.Items.Add("---------------------")
        Calculadora.LstOp.Items.Add(res)

    End Sub
    Public Sub borrar()

    End Sub

End Module
