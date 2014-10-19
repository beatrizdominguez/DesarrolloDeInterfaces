Module funciones

    Public Function bnt01(ByVal a As Double)

        Return a
    End Function

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
