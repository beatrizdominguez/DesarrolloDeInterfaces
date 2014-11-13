''' <summary>
''' Editor de texto. Formulario de busqueda y reemplazo
''' </summary>
''' <Autor>
''' Beatriz Domínguez
''' </Autor>

Public Class BuscarYReemplazar

    'variables para la busqueda
    Dim lastIndex As Integer
    Dim strSearchTerm As Integer
    Dim index As Integer
    Dim strLastSearch As Integer

    ''' <summary>
    ''' cierra el formulario
    ''' </summary>
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' busca en el texto la siguiente instnacia de una cadena
    ''' </summary>
    Private Sub BuscarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click


        'Buscamos la primera ocurrencia de una cadena y las siguiente hasta alcanzar el fin del documento
        lastIndex = FrmIni.RTBText.Text.LastIndexOf(TxtBuscar.Text) 'Indica la posicion de la ultima ocurrencia de una cadena

        If lastIndex = 0 Then 'Si la ultima ocurrencia en 0 quiere decir que esta al comienzo del documento
            strSearchTerm = 0 'Establecemos a 0

        ElseIf lastIndex = -1 Then 'Si no existe la ultima ocurrencia

            If FrmIni.RTBText.Text = "" Then 'Si el txtContenido está vacio
                MsgBox("No se encontró '" & TxtBuscar.Text & "'.", 48, "Atención")
            Else
                If FrmIni.RTBText.Find(TxtBuscar.Text, 0, FrmIni.RTBText.Text.Length, RichTextBoxFinds.None) = -1 Then 'Si no está vacio buscamos de nuevo
                    MsgBox("No se encontró '" & TxtBuscar.Text & "'.", 48, "Atención")
                Else
                    strSearchTerm = FrmIni.RTBText.Find(TxtBuscar.Text, 0, FrmIni.RTBText.Text.Length, RichTextBoxFinds.None) 'Si se encuentra establecemos strSearchTerm con el índice de inicio de la ocurrencia.
                End If
            End If
        Else
            strSearchTerm = FrmIni.RTBText.Find(TxtBuscar.Text, index, lastIndex, RichTextBoxFinds.None) 'Si nada de lo anterior de cumple establecemos strSearchTerm al índice de la ocurrencia
        End If

        If strSearchTerm = -1 Then
            strLastSearch = FrmIni.RTBText.Text.LastIndexOf(TxtBuscar.Text) 'Si se encuentra pero es la útlima, repetimos el bucle
            FrmIni.Focus()
            FrmIni.RTBText.SelectionStart = strLastSearch
            FrmIni.RTBText.SelectionLength = TxtBuscar.Text.Length
            index = 0
        Else 'Si se encuentra y no es la última, establecer index a partir de la declaración Find para evitar la aparición anterior
            FrmIni.Focus()
            FrmIni.RTBText.SelectionStart = strSearchTerm
            FrmIni.RTBText.SelectionLength = TxtBuscar.Text.Length
            index = strSearchTerm + 1
        End If

        ' End If
    End Sub

    ''' <summary>
    ''' Reemplaza la primera instancia de una cadena por otra cadena dada
    ''' </summary>
    Private Sub BtnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReplace.Click


        'si no encuentra la cadena a reemplazar muestra un mensaje por pantalla
        If FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text) = -1 Then
            MessageBox.Show("No se ha encontrado el texto a reemplazar", "Reemplazar", MessageBoxButtons.OK)

        Else
            'reemplaza la primera instancia de la cadena
            FrmIni.RTBText.Text = Replace(FrmIni.RTBText.Text, TxtBuscar.Text, TxtReplace.Text, , 1)
            FrmIni.Focus()

        End If
    End Sub

    ''' <summary>
    ''' reemplaza todas las instancias de una cadena por otra dada
    ''' </summary>
    Private Sub BtnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReplaceAll.Click

        'si no encuentra la cadena a reemplazar muestra un mensaje por pantalla
        If FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text) = -1 Then
            MessageBox.Show("No se ha encontrado el texto a reemplazar", "Reemplazar", MessageBoxButtons.OK)

        Else

            'reemplaza las cadenas
            FrmIni.RTBText.Text = Replace(FrmIni.RTBText.Text, TxtBuscar.Text, TxtReplace.Text)
            FrmIni.Focus()
        End If

    End Sub

End Class