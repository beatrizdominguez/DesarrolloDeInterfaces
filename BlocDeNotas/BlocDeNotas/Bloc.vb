Imports System.IO


''
''ARREGLAR
''
'BUSCAR SIGUIENTE
'HORA Y FECHA
'FORMULARIO ACERCA DE
'al reemplazar que no se selecicone el texto
'numero caracteres
'numero palabras


Public Class FrmIni

    'nombre del fichero
    Dim fichero As String = ""
    'flojos de entrada y salida
    Dim sw As StreamWriter
    Dim sr As StreamReader
    'boolean para saber si se han producido cambios o no
    Dim cambios As Boolean = False
    Dim palabras As Integer

    Private Sub NuevoMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoMnu.Click

        TxtText.Clear()
        fichero = ""
        deshabilitar()
        cambios = False

    End Sub

    Private Sub AbrirMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirMnu.Click

        'predeterminado asi que sobra
        OFDialog.Filter = "Documento de texto (*.txt)|*.txt| Todos los archivos(*.*)|*.*"

        'abrimos el fichero
        If OFDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            fichero = OFDialog.FileName

            'abrimos el fichero para grabar
            sr = File.OpenText(OFDialog.FileName)
            TxtText.Text = sr.ReadToEnd
            'cerramos el fichero
            sr.Close()
        End If

    End Sub

    Private Sub GuardarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarMnu.Click

        If fichero <> "" Then

            'abrimos el fichero para grabar
            sw = File.CreateText(fichero + ".txt")

            'escribimos la informacion del txtFicheros
            sw.Write(TxtText.Text)

            'vaciar memoria
            sw.Flush()
            'cerrar
            sw.Close()
            
        Else

            Me.GuardarCMnu_Click(sender, e)

        End If

    End Sub


    Private Sub GuardarCMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCMnu.Click

        'predeterminado asi que sobra
        SFDialog.Filter = "Documento de texto (*.txt)|*.txt| Todos los archivos(*.*)|*.*"

        If SFDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'abrimos el fichero para grabar
            sw = File.CreateText(SFDialog.FileName)
            fichero = SFDialog.FileName

            'escribimos la informacion del txtFicheros
            sw.Write(TxtText.Text)
            'vaciar memoria
            sw.Flush()
            'cerrar
            sw.Close()

        End If

        cambios = False

    End Sub

    Private Sub SalirMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirMnu.Click

        Me.Close()

    End Sub

    Private Sub DeshacerMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerMnu.Click
        ' Determine if last operation can be undone in text box.    
        If TxtText.CanUndo = True Then
            ' Undo the last operation.
            TxtText.Undo()
            ' Clear the undo buffer to prevent last action from being redone.
            TxtText.ClearUndo()
        End If
    End Sub

    Private Sub CortarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarMnu.Click
        If TxtText.SelectedText <> "" Then
            TxtText.Cut()
        End If
    End Sub

    Private Sub CopiarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarMnu.Click

        If TxtText.SelectionLength > 0 Then
            TxtText.Copy()
        End If
    End Sub

    Private Sub PegarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarMnu.Click

        'Dim Result As MessageBox.Show("Do you want to paste over current selection?","Pegar", MessageBoxButtons.YesNo)


        ' Determine if there is any text in the Clipboard to paste into the text box. 
        If Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True Then
            ' Determine if any text is selected in the text box. 
            If TxtText.SelectionLength > 0 Then
                ' Ask user if they want to paste over currently selected text. 
                If MessageBox.Show("Do you want to paste over current selection?", _
                    "Cut Example", MessageBoxButtons.YesNo) = DialogResult.No Then
                    ' Move selection to the point after the current selection and paste.
                    TxtText.SelectionStart = TxtText.SelectionStart + _
                        TxtText.SelectionLength
                End If
            End If
            ' Paste current text in Clipboard into text box.
            TxtText.Paste()
        End If

    End Sub

    Private Sub EliminarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarMnu.Click
        If TxtText.SelectedText <> "" Then

        End If
    End Sub

    Private Sub BuscarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarMnu.Click
        BuscarYReemplazar.Show()
    End Sub

    Private Sub ReemplazarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReemplazarMnu.Click
        BuscarYReemplazar.Show()
    End Sub
   
    Private Sub FuenteMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteMnu.Click
        If FntDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            TxtText.Font = FntDialog1.Font

            'If TxtText.SelectedText <> "" Then

            '    TxtText.Text = "modificamos el texto seleccionado"
            '    ' TxtText.SelectedText.font = FntDialog1.Font
            'Else
            '    TxtText.Font = FntDialog1.Font
            'End If


        End If
    End Sub

    Private Sub SeleccMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccMnu.Click

        'si hay texto que seleccionar
        If TxtText.SelectionLength = 0 Then
            ' Seleccionar todo el texto del TextBox
            TxtText.SelectAll()
        End If

    End Sub
    
    Private Sub HoraYFechaMnu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HoraYFechaMnu.Click
        ' TxtText.Text = TxtText.Text + Date.Now.ToString("t") + " " + Date.Today.ToString("d")
        'TxtText.SelectionStart = TxtText.SelectionStart + _TxtText.SelectionLength

        'TxtText.SelectionStart = TxtText.SelectionStart + DateTime.Now.ToString("g")

        'INSERTAR DONDE ESTÉ EL CURSOS
        ' TxtText.SelectionStart = DateTime.Now.ToString("g")
    End Sub

    Private Sub AcercaMnu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaMnu.Click
        Info.Show()

    End Sub

    Private Sub FrmIni_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'variable para el resultado del dialogo de mensaje
        Dim Result As DialogResult

        If cambios = True Then

            'Mostramos el mensaje y guardamos el resultado
            Result = MessageBox.Show("¿Desea guardar los cambios realizados?", "Salir", MessageBoxButtons.YesNoCancel)

            'NO
            If Result = 7 Then
                cambios = False
                'cerramos el formulario
                Me.Close()

                'YES
            ElseIf Result = 6 Then

                'guardamos el archivo
                GuardarCMnu_Click(sender, e)

                'CANCEL
            ElseIf Result = 2 Then

                Dim form As FrmIni
                form.Show()
               
            End If

        End If

    End Sub

    Private Sub TxtText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtText.TextChanged

        'habilitamos o deshabiltamos funciones según si haya o no texto
        If TxtText.Text <> "" Then
            habilitar()
            'definimos que se han producido cambios
            cambios = True


            '' MOSTRAR PALABRAS
            palabras = TxtText.Text.Count
            Label1.Text = palabras


        Else
            deshabilitar()
            cambios = False
        End If

        'número de caracteres
        lblPal.Text = TxtText.TextLength
        lblCar.Text = TxtText.Text.Count

    End Sub

End Class
