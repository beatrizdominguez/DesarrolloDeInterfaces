Module funciones

    Public Sub comprobar()

        'If btn Then
    End Sub

    Public Sub empezar()
        'posicion de los botones
        Dim rand As Integer
        Dim numeros(4) As Integer
        Dim pos2(4) As Integer
        pos2(0) = 31
        pos2(1) = 101
        pos2(2) = 171
        pos2(3) = 242

        Dim pos3(4) As String
        pos3(0) = "031,162"
        pos3(1) = "101,162"
        pos3(2) = "031,225"
        pos3(3) = "101,225"
        'Dim 1 As String ="(31, 162)"
        ' Dim 2 As String ="(101, 162)"
        'Dim 3 As String ="(171, 162)"
        'Dim 4 As String ="(242, 162)"

        'string con la posicion
        Dim pos As String
        'valor de la x
        Dim x As Integer
        'valor de la y
        Dim y As Integer

        '''''ejemplo borrar
        Dim ej As String
        ej = "123"
        Frm.Label3.Text = ej(0) + ej(1) + ej(2)

        ''
        'BOTON 1
        'calculamos el random
        rand = Int(4 * Rnd() + 1)
        'rand = Int(3 * Rnd())
        'mostramos el random
        Frm.Label2.Text = Frm.Label2.Text + "; " + CStr(rand)
        'guardamos el numero en el array
        numeros(0) = rand
        'sacamos el valor de la posición
        pos = pos3(rand - 1)
        'calculamos el valor de las x
        x = CInt(pos(0) + pos(1) + pos(2))
        'calculamos el valor de las x
        y = CInt(pos(4) + pos(5) + pos(6))
        Frm.Label4.Text = CStr(x) + ", " + CStr(y)
        Frm.btn1.Location = New Point(x, y)
        'Frm.btn1.Location = New Point(pos3(rand))
        Frm.Label5.Text = CStr(numeros(0))


        ''
        'BOTON 2

        'Do
        '    rand = 3 * Rnd()
        'Loop Until rand <> numeros(0)
        'compruebo que esa posición no está ya ocupada
        Do

            rand = Int(4 * Rnd() + 1)
            'rand = Int(3 * Rnd())
            'rand = 3 * Rnd()
        Loop Until Array.IndexOf(numeros, rand)
        'añado la nueva posición a la lista de posiciones ocupadas
        numeros(1) = rand
        Frm.Label2.Text = Frm.Label2.Text + "; " + CStr(rand)
        'sacamos el valor de la posición
        pos = pos3(rand - 1)
        'calculamos el valor de las x
        x = CInt(pos(0) + pos(1) + pos(2))
        'calculamos el valor de las x
        y = CInt(pos(4) + pos(5) + pos(6))
        Frm.Label4.Text = CStr(x) + ", " + CStr(y)
        'coloco el botón
        Frm.btn2.Location = New Point(x, y)
        'Frm.btn2.Location = New Point(pos2(rand), 162)
        'Frm.btn2.Location = New Point(pos3(rand))

        Frm.Label5.Text = Frm.Label5.Text + CStr(numeros(1))


        ''
        'BOTON 3
        'Do
        '    rand = 3 * Rnd()
        'Loop Until rand <> numeros(0) And rand <> numeros(1)
        Do

            rand = Int(4 * Rnd() + 1)
            'rand = Int(3 * Rnd())
        Loop Until Array.IndexOf(numeros, rand)
        numeros(2) = rand
        Frm.Label2.Text = Frm.Label2.Text + "; " + CStr(rand)
        'sacamos el valor de la posición
        pos = pos3(rand - 1)
        'calculamos el valor de las x
        x = CInt(pos(0) + pos(1) + pos(2))
        'calculamos el valor de las x
        y = CInt(pos(4) + pos(5) + pos(6))
        Frm.Label4.Text = CStr(x) + ", " + CStr(y)
        'Frm.btn3.Location = New Point(pos3(rand))
        'Frm.btn3.Location = New Point(pos2(rand), 162)
        Frm.btn3.Location = New Point(x, y)

        Frm.Label5.Text = Frm.Label5.Text + CStr(numeros(2))


        ''
        'BOTON 4
        'Do
        '    rand = 3 * Rnd()
        'Loop Until rand <> numeros(0) And rand <> numeros(1) And rand <> numeros(2)
        Do

            rand = Int(4 * Rnd() + 1)
            'rand = Int(3 * Rnd())
        Loop Until Array.IndexOf(numeros, rand)
        numeros(3) = rand
        Frm.Label2.Text = Frm.Label2.Text + "; " + CStr(rand)
        'sacamos el valor de la posición
        pos = pos3(rand - 1)
        'calculamos el valor de las x
        x = CInt(pos(0) + pos(1) + pos(2))
        'calculamos el valor de las x
        y = CInt(pos(4) + pos(5) + pos(6))
        Frm.Label4.Text = CStr(x) + ", " + CStr(y)
        'Frm.btn4.Location = New Point(pos3(rand))
        'Frm.btn4.Location = New Point(pos2(rand), 162)
        Frm.btn4.Location = New Point(x, y)
        Frm.Label5.Text = Frm.Label5.Text + CStr(numeros(3))



        'aspecto de los botones
        Frm.btn1.BackColor = Color.Orange
        Frm.btn2.BackColor = Color.Orange
        Frm.btn3.BackColor = Color.Orange
        Frm.btn4.BackColor = Color.Orange

    End Sub

    

End Module
