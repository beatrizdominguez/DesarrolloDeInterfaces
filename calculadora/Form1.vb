
Public Class Form1

    Dim StringA As String
    'Dim mostrar2 As String
    Dim stringB As String
    Dim a As Double = 0
    'Dim b As Integer = 11
    Dim res As Double = 0
    'Dim op As String = ""
    Dim op As Integer
    '1=sumar
    '2=restar
    '3=multiplicar
    '4=dividir
    Dim coma As Boolean = False

    ''me faltan las comas, que pueda introducir decimales
    ''''''coja mas de un decimal
    ''''''hacerlo al revés, de string a int


    'cuando me salga, que se muestre la operación entera


    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 1
        Else
            a = a + 1 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 2
        Else
            a = a + 2 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 3
        Else
            a = a + 3 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 4
        Else
            a = a + 4 / 10
        End If

        TxtAbajo.Text = a
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 5
        Else
            a = a + 5 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 6
        Else
            a = a + 6 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 7
        Else
            a = a + 7 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 8
        Else
            a = a + 8 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10 + 9
        Else
            a = a + 9 / 10
        End If
        TxtAbajo.Text = a
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click

        'añadimos el número y lo mostramos por pantalla
        If coma = False Then
            a = a * 10
        Else
            a = a + 0 / 10
        End If
        TxtAbajo.Text = a
    End Sub

   
    
    Private Sub BtnIg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIg.Click
        
        ' LblA.Text = a
        ' Lbl2.Text = res

        'realiza una u otra operación según el botón al que se le haya hecho clic
        If op = 1 Then
            res = res + a
        ElseIf op = 2 Then
            res = res - a
        ElseIf op = 3 Then
            res = res * a
        ElseIf op = 4 Then
            res = res / a
        End If


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

    End Sub

    'borramos todos los datos que tenemos, inicializamos las variables a 0 o vacío
    Private Sub BtnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnC.Click

        a = 0
        res = 0
        TxtArriba.Text = ""
        TxtAbajo.Text = vbEmpty
        coma = False
        StringA = ""
        stringB = ""

    End Sub

    Private Sub BtnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSum.Click

        'LblA.Text = a
        'Lbl2.Text = res


        'realizamos la operaión y calculamos el resultado hasta ahora, según la última operación realizada
        If op = 1 Then
            res = res + a
        ElseIf op = 2 Then
            res = res - a
        ElseIf op = 3 Then
            res = res * a
        ElseIf op = 4 Then
            res = res / a
        Else
            res = res + a
        End If


        'convertimos el número a string para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " + "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " + "
        End If

        'mostramos la operacion
        TxtArriba.Text = StringA

        'reiniciamos la parte de abajo mostrando un 0
        TxtAbajo.Text = "0"

        'indicamos que la operación es una suma
        op = 1

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False

    End Sub

    Private Sub BtnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRes.Click
        ' LblA.Text = a



        'realizamos la operaión y calculamos el resultado hasta ahora, según la última operación realizada
        If op = 1 Then
            res = res + a
        ElseIf op = 2 Then
            res = res - a
        ElseIf op = 3 Then
            res = res * a
        ElseIf op = 4 Then
            res = res / a
        Else
            res = res - a
        End If


        'convertimos el número a char para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " - "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " - "
        End If



        TxtArriba.Text = StringA
        TxtAbajo.Text = "0"

        'indicamos que la operación es una suma
        op = 2

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False

    End Sub

    Private Sub BtnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMult.Click
        LblA.Text = a


        'realizamos la operaión y calculamos el resultado hasta ahora, según la última operación realizada
        If op = 1 Then
            res = res + a
        ElseIf op = 2 Then
            res = res - a
        ElseIf op = 3 Then
            res = res * a
        ElseIf op = 4 Then
            res = res / a
        Else
            res = res * a
        End If

        'convertimos el número a char para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " x "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " x "
        End If



        TxtArriba.Text = StringA
        TxtAbajo.Text = "0"
        
        'indicamos que la operación es una suma
        op = 3

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False
    End Sub

    Private Sub BtnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDiv.Click
        LblA.Text = a


        'realizamos la operaión y calculamos el resultado hasta ahora, según la última operación realizada
        If op = 1 Then
            res = res + a
        ElseIf op = 2 Then
            res = res - a
        ElseIf op = 3 Then
            res = res * a
        ElseIf op = 4 Then
            res = res / a
        Else
            res = res / a
        End If

        'convertimos el número a char para mostrarlo
        If StringA = "" Then
            StringA = CStr(a)
            StringA = StringA + " : "
        Else
            stringB = CStr(a)
            StringA = StringA + stringB + " : "
        End If



        TxtArriba.Text = StringA
        TxtAbajo.Text = "0"
       
        'indicamos que la operación es una suma
        op = 4

        'iniciamos a en 0 para guardar el nuevo número a introducir
        a = 0
        coma = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'dividimos por 10 y aproximamos según sea mayor o menor de 5

        'no coja decimales, CASST
        If (a Mod 10 >= 5) Then

            a = a / 10 - 1
        Else
            a = a / 10
        End If
        TxtAbajo.Text = a

    End Sub

    Private Sub BtnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComa.Click
        coma = True
    End Sub
End Class