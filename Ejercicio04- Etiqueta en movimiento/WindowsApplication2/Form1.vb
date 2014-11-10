Public Class Form1

    'inicializamos la variable que va a definir el movimiento
    'aumentar el número para aumentar la velocidad
    Dim y As Integer = 15


    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click

        'Timer1.Enabled = Not Timer1.Enabled

        'cambiamos el texto a mostrar en el botón
        If cmd1.Text = "Comenzar" Then
            cmd1.Text = "Parar"

        Else
            cmd1.Text = "Comenzar"

        End If


    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

       
        'ejecutamos el movimiento sólo si hemos clicado en el botón comenzar (el texto se habrá cambiado a 'parar')
        If cmd1.Text = "Parar" Then

            'definimos que la etiqueta se mueva
            lbl1.Left = lbl1.Left + y
           
            ''muestra la posición de la etiqueta
            Lbl2.Text = lbl1.Location.X
           
            'si llega a alguno de los bordes del formulario cambiamos el signo de la variable para que cambie de sentido
            If lbl1.Left >= Me.ClientSize.Width - lbl1.Width Or lbl1.Left <= 0 Then
                y = -y

                
            End If
        End If

    End Sub

  
End Class
