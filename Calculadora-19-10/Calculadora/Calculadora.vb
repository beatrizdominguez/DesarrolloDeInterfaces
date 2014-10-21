
Public Class Calculadora

    Dim StringA As String
    'Dim mostrar2 As String
    Dim stringB As String
    Dim a As Double = 0
    Dim b As Integer

    Dim res As Double = 0
    'Dim op As String = ""
    Dim op As Integer
    '1=sumar     '3=multiplicar
    '2=restar    '4=dividir
    'variables para controlar los decimales
    Dim coma As Boolean = False
    Dim dec As Integer = 1
    Dim txt1 As String


    'conseguir que no imprima el 0 cuando le damos al = y luego seguimos concatenando operaciones



    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click, BtnA1.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 1
        Else
            a = a + 1 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click, BtnA2.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 2
        Else
            a = a + 2 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click, BtnA3.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 3
        Else
            a = a + 3 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click, BtnA4.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 4
        Else
            a = a + 4 / 10 ^ dec
            dec = dec + 1
        End If

        TxtAbajo.Text = a
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click, BtnA5.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 5
        Else
            a = a + 5 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click, BtnA6.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 6
        Else
            a = a + 6 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click, BtnA7.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 7
        Else
            a = a + 7 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click, BtnA8.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 8
        Else
            a = a + 8 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click, BtnA9.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 9
        Else
            a = a + 9 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click, BtnA0.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10
        Else
            'a = a + 0 / 10 ^ dec
            dec = dec + 1
        End If
        TxtAbajo.Text = a
    End Sub



    Private Sub BtnIg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIg.Click, Button13.Click

        LblA.Text = a
        Lbl2.Text = res

        'realiza una u otra operación según el botón al que se le haya hecho clic
        If op = 1 Then
            Lbl1.Text = Lbl1.Text & Environment.NewLine & "+" + CStr(a)
            res = res + a
        ElseIf op = 2 Then
            Lbl1.Text = Lbl1.Text & Environment.NewLine & "-" + CStr(a)
            res = res - a
        ElseIf op = 3 Then
            Lbl1.Text = " " + CStr(res) & Environment.NewLine & "x" + CStr(a)
            res = res * a
        ElseIf op = 4 Then
            Lbl1.Text = " " + CStr(res) & Environment.NewLine & "÷" + CStr(a)
            res = res / a

        End If


        'mostrar el resultado de la operación en la parte escondida
        Lbl1.Text = Lbl1.Text & Environment.NewLine & "------------------" & Environment.NewLine & CStr(res)


        'convertimos el número a string para mostrarlo
        StringA = StringA + CStr(a)
        TxtArriba.Text = StringA
        'mostramos el resultado final
        TxtAbajo.Text = res
        ' a = res

        'inicializamos la operación a 0 para empezar de nuevo
        op = 0
        a = 0
        coma = False
        Lbl3.Text = res

    End Sub

    'borramos todos los datos que tenemos, inicializamos las variables a 0 o vacío
    Private Sub BtnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnC.Click, Button3.Click
        LblA.Text = a
        Lbl2.Text = res


        a = 0
        'b = 0
        res = 0
        TxtArriba.Text = ""
        TxtAbajo.Text = vbEmpty
        Lbl1.Text = vbEmpty
        op = 0
        coma = False
        dec = 1
        StringA = ""
        stringB = ""


    End Sub

    Private Sub BtnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSum.Click, Button15.Click

        LblA.Text = a
        Lbl2.Text = res

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



        'funciona de esta forma más simple
        'StringA = CStr(a)
        'StringA = StringA + " + "
        'convertimos el número a string para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " + "
            Lbl1.Text = Lbl1.Text & Environment.NewLine & "  " + CStr(a)
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " + "
            Lbl1.Text = Lbl1.Text & Environment.NewLine & "+" + CStr(a)
        End If

        ' TxtOp.Text = TxtOp.Text & Environment.NewLine & "+" + CStr(a)


        'mostramos la operacion
        TxtArriba.Text = StringA

        'reiniciamos la parte de abajo mostrando un 0
        ' TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 1

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
        Lbl3.Text = res

    End Sub

    Private Sub BtnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRes.Click, Button14.Click


        LblA.Text = a
        Lbl2.Text = res

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


        'convertimos el número a string para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " - "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " - "
        End If

        Lbl1.Text = Lbl1.Text & Environment.NewLine & "-" + CStr(a)

        'mostramos la operacion
        TxtArriba.Text = StringA

        'reiniciamos la parte de abajo mostrando un 0
        ' TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 2

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1
        Lbl3.Text = res

    End Sub

    Private Sub BtnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMult.Click, Button12.Click


        'LblA.Text = a
        'Lbl2.Text = res


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


        'convertimos el número a string para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " X "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " X "
        End If

        'mostramos la operacion
        TxtArriba.Text = StringA

        'reiniciamos la parte de abajo mostrando un 0
        'TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 3

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

    End Sub

    Private Sub BtnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDiv.Click, Button11.Click



        'LblA.Text = a
        'Lbl2.Text = res


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


        'convertimos el número a string para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " ÷ "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " ÷ "
        End If

        'mostramos la operacion
        TxtArriba.Text = StringA

        'reiniciamos la parte de abajo mostrando un 0
        'TxtAbajo.Text = "0"
        TxtAbajo.Text = vbEmpty

        'indicamos que la operación es una suma
        op = 4

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
        dec = 1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'dividimos por 10 y aproximamos según sea mayor o menor de 5

        txt1 = CStr(a)

        If (txt1.Length > 1) Then

            txt1 = txt1.Remove(txt1.Length - 1, 1)

        ElseIf (txt1.Length = 1) Then

            txt1 = "0"

        End If

        a = CDbl(txt1)

        TxtAbajo.Text = a

    End Sub

    Private Sub BtnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComa.Click, Button2.Click
        coma = True
        ' TxtAbajo.Text = a

    End Sub

    Private Sub NiñosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KidsToolStripMenuItem.Click

        kidsLayout()

    End Sub

    Private Sub AuelosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OldToolStripMenuItem.Click

        oldLayout()



    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMas.Click

        If BtnMas.Text = "Mas" Then
            Me.Width = 800
            BtnMas.Text = "Menos"
        Else
            Me.Width = 425
            BtnMas.Text = "Mas"
        End If

    End Sub
End Class