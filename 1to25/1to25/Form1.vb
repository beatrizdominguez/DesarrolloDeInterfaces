Public Class Frm

    Dim cont As Integer = 1
    Dim errores As Integer

    'Declaracion de variables
    Private Hora As Integer = 0
    Private Minuto As Integer = 0
    Private Segundo As Integer = 0
    Private Milisegundo As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' lblTime.Text = Timer1.Interval
        Milisegundo += 1
        If Milisegundo = 9 Then
            Milisegundo = 0
            Segundo += 1
            If Segundo = 59 Then
                Segundo = 0
                Minuto += 1
                If Minuto = 59 Then
                    Minuto += 1
                    Hora += 1
                End If
            End If
        End If
        MostrarTiempo()

    End Sub
    Sub MostrarTiempo()


        lblTime.Text = Hora.ToString.PadLeft(2, "0") & ":" & Minuto.ToString.PadLeft(2, "0") & ":" & Segundo.ToString.PadLeft(2, "0") & ":" & Milisegundo.ToString.PadLeft(1, "0") & ":"
        'lblTime.Text.Refresh()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If cont = 1 Then
            cont = cont + 1
            btn1.BackColor = Color.White
        Else
            'mensaje de error, se para la partida
            Label1.Text = "error1"
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If cont = 2 Then
            cont = cont + 1
            btn2.BackColor = Color.White
        Else
            'mensaje de error, se para la partida
            Label1.Text = "error2"
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If cont = 3 Then
            btn3.BackColor = Color.White
            cont = cont + 1
        Else
            'mensaje de error, se para la partida
            Label1.Text = "error3"
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If cont = 4 Then

            Label1.Text = "FIN"
            ' cont = cont + 1
            btn4.BackColor = Color.White
            ' Stop the timer
            Timer1.Enabled = False
        Else
            'mensaje de error, se para la partida
            Label1.Text = "error4"
            errores = errores + 1
            lblErrores.Text = "Errores: " + CStr(errores)
        End If
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        cont = 1
        errores = 0
        lblErrores.Text = "Errores: " + CStr(errores)
        Label1.Text = "0"
        'inicializamos el timer
        Label2.Text = ""
        'llamar al metodo que coloca los botones en un sitio aleatorio
        empezar()
        'start the timer
        'poner a 0 el timer
        'Timer1.beginInit()
        Timer1.Enabled = True


    End Sub

End Class
