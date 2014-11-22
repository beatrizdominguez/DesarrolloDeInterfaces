Public Class FinPartida

    ''' <summary>
    ''' Cerramos el forulario para continuar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub continuar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Me.Close()

    End Sub

    ''' <summary>
    ''' Cuando se cierra el formulario se introduce la información de la partida a la tabla de tiempos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'añadimos el tiempo de partida
        añadirPartida()
    End Sub


    ''' <summary>
    ''' El formulario se cierra si se presiona la tecla 'Enter' estándo sobre el TxtNombre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">Tecla</param>
    ''' <remarks></remarks>
    Private Sub OnKeyDownHandler(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtNombre.KeyDown

        'Si la tecla presionada es 'Enter' cierra el formulario
        If (e.KeyCode = Keys.Enter) Then

            Me.Close()

        End If
    End Sub


    ''' <summary>
    ''' Al abrir el formulario suena una música de vistoria
    ''' </summary>
    Private Sub FinPartida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''parar los sonidos anteriores
        ' My.Computer.Audio.Stop()

        ''''''''''
        ''''''''''
        ''''''''''DESCOMENTAR, TIENE QUE ESTAR, PERO ME ESTA PONIENDO NERVIOSA SONANDO TODO EL RATO
        ''''''''''
        ''''''''''
        ''''''''''
        ''''''''''
        ''''''''''
        '  My.Computer.Audio.Play(My.Resources.aplausos1, AudioPlayMode.Background)

    End Sub


End Class