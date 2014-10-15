Module Module1

    'variable que nos va a servir a la hora de ordenar los elementos
    Dim aux As String

    'ordenamos la lista de números que se nos pasa por parámetro
    Public Sub ordenarNumeros(ByVal lst As ListBox)

        'recorremos todos los elementos y los recolocamos si es preciso
        For i = 0 To lst.Items.Count - 2
            For j = i + 1 To lst.Items.Count - 1

                If Val(lst.Items.Item(i)) > Val(lst.Items.Item(j)) Then

                    aux = lst.Items.Item(i)
                    lst.Items.Item(i) = lst.Items.Item(j)
                    lst.Items.Item(j) = aux

                End If
            Next
        Next

    End Sub


    'ordenamos la lista de números en orden inverso (de mayor a menos)
    Public Sub ordenarNumInv(ByVal lst As ListBox)

        'recorremos todos los elementos y los recolocamos si es preciso
        For i = 0 To lst.Items.Count - 2
            For j = i + 1 To lst.Items.Count - 1

                If Val(lst.Items.Item(i)) < Val(lst.Items.Item(j)) Then

                    aux = lst.Items.Item(i)
                    lst.Items.Item(i) = lst.Items.Item(j)
                    lst.Items.Item(j) = aux

                End If
            Next
        Next

    End Sub

    Public Sub ordenarPalInv(ByVal lst As ListBox)

        'recorremos todos los elementos y los recolocamos si es preciso
        For i = 0 To lst.Items.Count - 2
            For j = i + 1 To lst.Items.Count - 1

                If lst.Items.Item(i) < lst.Items.Item(j) Then

                    aux = lst.Items.Item(i)
                    lst.Items.Item(i) = lst.Items.Item(j)
                    lst.Items.Item(j) = aux

                End If
            Next
        Next
    End Sub

    Public Sub borrar(ByVal lst As ListBox)

        'comprobamos que haya elementos
        If lst.Items.Count > 0 Then

            'borramos el último elemento
            lst.Items.RemoveAt(lst.Items.Count - 1)
        End If

    End Sub

    'funcion que calcula la media y nos la devuelve
    Public Function media(ByVal lista As ListBox) As Integer

        'variable para almacenar el resultado de la media
        Dim med As Double

        'recorremos la lista y contamos los numeros
        For i = 0 To lista.Items.Count() - 1

            'Sumamos los valores de la lista y los dividimos por el numero de valores que haya
            med = med + Val(lista.Items.Item(i)) / lista.Items.Count()
        Next

        'devolvemos el valor de la media
        Return med

    End Function


End Module
