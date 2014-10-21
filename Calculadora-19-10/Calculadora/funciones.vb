Module funciones


    Public Sub numero2(ByVal a As Double, ByVal coma As Boolean, ByVal dec As Integer, ByVal num As Integer, ByVal numeros As Array)
        ' Dim numeros(2) As Double


        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + num
        Else
            a = a + num / 10 ^ dec
            dec = dec + num
        End If

        Calculadora.TxtAbajoA.Text = a
        Calculadora.TxtAbajo.Text = a

        numeros(0) = a
        numeros(1) = dec

    End Sub
  

    'Public Sub kids()
    '    'GrbNinos.Show()
    '    ' GrbAbuelos.Hide()
    '    Form1.Width = 500
    'End Sub

    Public Function factorial(ByVal a As Double)
        Calculadora.TxtArriba.Text = CStr(a) + "!"

        Dim i As Integer
        For i = 1 To a - 1
            a = a * i


        Next i

        Return a
    End Function

    'Public Function elevado(ByVal a As Double, ByVal b As Double)
    '    Calculadora.TxtArriba.Text = CStr(a) + "^" + CStr(b)


    '    Return a ^ b
    'End Function
    'Public Sub nuevoNumero()
    '    'iniciamos a en 0 para guardar el nuevo número a introducir
    '    Calculadora.a = 0
    '    Calculadora.v()
    '    coma = False
    '    dec = 1

    '    Calculadora.
    '    Calculadora.Lbl3.Text = res



    'End Sub


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
                res = res * a
            ElseIf op = 4 Then
                res = res / a

            End If
        End If
        Return res
        '?devuelve los 2??
    End Function

End Module
