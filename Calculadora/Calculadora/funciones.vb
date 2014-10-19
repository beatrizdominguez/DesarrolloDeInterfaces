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
End Module
