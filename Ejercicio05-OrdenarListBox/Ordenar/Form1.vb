Public Class Form1

    'al hacer clic introducimos el valor
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        'dependiendo de que sea un valor numérico o no lo añade a una u otra lista
        If IsNumeric(TxtIntro.Text) = True Then

            LstNum.Items.Add(TxtIntro.Text)
        Else
            LstPal.Items.Add(TxtIntro.Text)
        End If

        'limpiamos el cuadro de texto para volver a escribir
        TxtIntro.Text = ""

    End Sub

    'al hacer clic en el botón "ordenar" ordenamos los valores ya introducidos
    Private Sub BtnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnO.Click

        'ordenamos una u otra lista según lo que esté marcado que se quiere ordenar
        If ChkNum.Checked = True And ChkPal.Checked = False Then

            ordenarNumeros(LstNum)

        ElseIf ChkNum.Checked = False And ChkPal.Checked = True Then

            LstPal.Sorted = True

        Else 'si no elegimos una de las dos listas salta un error
            TxtIntro.Text = "ERROR"
        End If

    End Sub


    'ordenamos la lista en orden inverso (de mayor a menor)
    Private Sub BtnOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOI.Click

        'ordenamos una u otra lista según lo que esté marcado que se quiere ordenar
        If ChkNum.Checked = True And ChkPal.Checked = False Then

            ordenarNumInv(LstNum)

        ElseIf ChkNum.Checked = False And ChkPal.Checked = True Then

            ordenarPalInv(LstPal)

        Else 'si no elegimos una de las dos listas salta un error
            TxtIntro.Text = "ERROR"
        End If

    End Sub

    'borramos el último elemento que hay en la lista selccionada
    Private Sub BtnBr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBr.Click

        'borramos de una u otra lista según lo que esté marcado
        If ChkNum.Checked = True And ChkPal.Checked = False Then

            borrar(LstNum)

        ElseIf ChkNum.Checked = False And ChkPal.Checked = True Then

            borrar(LstPal)

        Else 'si no elegimos una de las dos listas salta un error
            TxtIntro.Text = "ERROR"
        End If

    End Sub


    'calculamos la media de todos los valores numéricos
    Private Sub BtnMedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedia.Click

        'llamamos al método para calcular la media y la mostramos
        LblMedia.Text = "Media: " + CStr(media(LstNum))
    End Sub

End Class
