Public Class BuscarYReemplazar


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
       
        'If FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text) = -1 Then
        '    MessageBox.Show("No se ha encontrado el texto a buscar", "Buscar", MessageBoxButtons.OK)

        'Else
        '    'subrayamos la palabra
        '    'If (Not String.IsNullOrEmpty(FrmIni.TxtText.Text)) Then
        '    If (Not String.IsNullOrEmpty(TxtBuscar.Text)) Then
        '        Label1.Text = FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text.Count)
        '        Label2.Text = TxtBuscar.Text.Length

        '        FrmIni.TxtText.SelectionStart = FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text, FrmIni.TxtText.SelectionStart)
        '        ' FrmIni.TxtText.SelectionStart = FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text)
        '        FrmIni.TxtText.SelectionLength = TxtBuscar.Text.Length

        '        'mostramos la palabra subrayada
        '        FrmIni.TxtText.Focus()


        '        ''definir que empiece a buscar a partir de aqui
        '        FrmIni.TxtText.SelectionStart = FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text) + TxtBuscar.Text.Length

        '    End If

        'End If


        If FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text) = -1 Then
            MessageBox.Show("No se ha encontrado el texto a buscar", "Buscar", MessageBoxButtons.OK)

        Else
            'subrayamos la palabra
            'If (Not String.IsNullOrEmpty(FrmIni.TxtText.Text)) Then
            If (Not String.IsNullOrEmpty(TxtBuscar.Text)) Then
                Label1.Text = FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text.Count)
                Label2.Text = TxtBuscar.Text.Length

                FrmIni.RTBText.SelectionStart = FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text, FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text) + TxtBuscar.Text.Length)
                ' FrmIni.TxtText.SelectionStart = FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text)
                FrmIni.RTBText.SelectionLength = TxtBuscar.Text.Length

                'mostramos la palabra subrayada
                FrmIni.RTBText.Focus()


                ''definir que empiece a buscar a partir de aqui
                ' FrmIni.TxtText.SelectionStart = FrmIni.TxtText.Text.IndexOf(TxtBuscar.Text) + TxtBuscar.Text.Length

            End If

        End If


    End Sub

    Private Sub BtnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReplace.Click

        ''REEMPLAZA TODAS LAS INSTANCIAS QUE ENCUENTRA
        'buscar, subraya y cambia eso

        If FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text) = -1 Then
            MessageBox.Show("No se ha encontrado el texto a reemplazar", "Reemplazar", MessageBoxButtons.OK)

        Else
            FrmIni.RTBText.Text = Replace(FrmIni.RTBText.Text, TxtBuscar.Text, TxtReplace.Text, , 1)

            ''''''''
            'EL FOCO NO SUBRAYE TODO
            FrmIni.Focus()

        End If
    End Sub

    Private Sub BtnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReplaceAll.Click

        If FrmIni.RTBText.Text.IndexOf(TxtBuscar.Text) = -1 Then
            MessageBox.Show("No se ha encontrado el texto a reemplazar", "Reemplazar", MessageBoxButtons.OK)

        Else

            FrmIni.RTBText.Text = Replace(FrmIni.RTBText.Text, TxtBuscar.Text, TxtReplace.Text)
            FrmIni.Focus()
        End If

    End Sub



End Class