Public Class FinPartida

    ''' <summary>
    ''' Cerramos el forulario para continuar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub continuar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Me.Close()

    End Sub

    Private Sub FinPartida_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        'Dim ruta As String
        'ruta = My.Application.Info.DirectoryPath

        'Dim s As System.Media.SoundPlayer
        's = New System.Media.SoundPlayer(ruta + "\aplausos.mp3")
        's.Play()

        ''reproducimos la música de victoria
        '  My.Computer.Audio.Play("C:\aplausos.wav", AudioPlayMode.Background)

    End Sub

    ''' <summary>
    ''' Cuando se cierra el formulario se introduce la información de la partida a la tabla de tiempos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CerrarDormulario(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'añadimos el tiempo de partida
        añadirPartida()
    End Sub

    ''continuar haciendo enter




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



End Class