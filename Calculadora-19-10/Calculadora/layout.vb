Module layout

    Public Sub kidsLayout()

        'mostrar botones
        Calculadora.GrbNinos.Show()
        Calculadora.GrbAbuelos.Hide()
        Calculadora.GrbCint.Hide()
        'boton 00
        Calculadora.Btn00.Hide()

        Calculadora.GrbTxtA.Hide()
        Calculadora.GrbTxt.Show()

        Calculadora.TxtArriba.Height = 50

        'panel oculto de la derecha
        Calculadora.Panel1.Show()
        Calculadora.BtnMas.Text = "->"

        'formato del formulario
        Calculadora.Width = 425
        Calculadora.Height = 430
        'el tamaño del formulario no puede alterarse
        Calculadora.FormBorderStyle = FormBorderStyle.FixedSingle

        'Calculadora.BackColor = Color.LightSlateGray


        'botones
        Calculadora.Btn1.BackColor = Color.Teal

        Calculadora.Btn2.BackColor = Color.DeepSkyBlue
        Calculadora.Btn3.BackColor = Color.Teal
        Calculadora.Btn4.BackColor = Color.DeepSkyBlue
        Calculadora.Btn5.BackColor = Color.Teal
        Calculadora.Btn6.BackColor = Color.DeepSkyBlue
        Calculadora.Btn7.BackColor = Color.Teal
        Calculadora.Btn8.BackColor = Color.DeepSkyBlue
        Calculadora.Btn9.BackColor = Color.Teal
        Calculadora.Btn0.BackColor = Color.Teal
        Calculadora.BtnComa.BackColor = Color.LightGray
        Calculadora.BtnSum.BackColor = Color.Red
        Calculadora.BtnRes.BackColor = Color.Red
        Calculadora.BtnMult.BackColor = Color.Red
        Calculadora.BtnDiv.BackColor = Color.Red
        'Calculadora.BtnSum.BackColor = Color.MediumSpringGreen
        'igual en vez de teal
        ' Calculadora.BtnSum.BackColor = Color.LightSeaGreen
        'Calculadora.BtnRes.BackColor = Color.SpringGreen
        'Calculadora.BtnMult.BackColor = Color.SpringGreen
        ''Calculadora.BtnRes.BackColor = Color.GreenYellow
        ''Calculadora.BtnMult.BackColor = Color.LawnGreen
        'Calculadora.BtnDiv.BackColor = Color.MediumSpringGreen
        ''   Calculadora.BtnDiv.BackColor = Color.MediumSpringGreen
        Calculadora.BtnIg.BackColor = Color.MediumSpringGreen
        Calculadora.BtnC.BackColor = Color.HotPink



    End Sub

    Public Sub oldLayout()

        'mostrar botones
        Calculadora.GrbNinos.Hide()
        Calculadora.GrbAbuelos.Show()
        Calculadora.GrbCint.Hide()
        'boton 00
        Calculadora.Btn00.Hide()

        Calculadora.GrbTxtA.Show()
        Calculadora.GrbTxt.Hide()

        Calculadora.TxtArriba.Height = 150
        Calculadora.Panel1.Hide()

        'formato del formulario
        Calculadora.Width = 800
        Calculadora.Height = 680
        'el tamaño del formulario no puede alterarse
        Calculadora.FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub

    Public Sub businessLayout()

        'mostrar botones
        Calculadora.GrbNinos.Show()
        Calculadora.GrbAbuelos.Hide()
        Calculadora.GrbCint.Show()
        'boton 00
        Calculadora.Btn00.Show()

        Calculadora.GrbTxtA.Hide()
        Calculadora.GrbTxt.Show()

        Calculadora.TxtArriba.Height = 50

        'panel oculto de la derecha
        Calculadora.Panel1.Hide()
        'Calculadora.BtnMas.Text = "Mas"

        'formato del formulario
        Calculadora.Width = 520
        Calculadora.Height = 430
        'el tamaño del formulario no puede alterarse
        Calculadora.FormBorderStyle = FormBorderStyle.FixedSingle

        'Calculadora.BackColor = Color.Teal

        ''botones
        'Calculadora.Btn1.BackColor = Color.LightGray
        'Calculadora.Btn2.BackColor = Color.LightGray
        'Calculadora.Btn3.BackColor = Color.LightGray
        'Calculadora.Btn4.BackColor = Color.LightGray
        'Calculadora.Btn5.BackColor = Color.LightGray
        'Calculadora.Btn6.BackColor = Color.LightGray
        'Calculadora.Btn7.BackColor = Color.LightGray
        'Calculadora.Btn8.BackColor = Color.LightGray
        'Calculadora.Btn9.BackColor = Color.LightGray
        'Calculadora.Btn0.BackColor = Color.LightGray
        Calculadora.BtnComa.BackColor = Color.LightGray
        Calculadora.BtnSum.BackColor = Color.LightGray
        Calculadora.BtnRes.BackColor = Color.LightGray
        Calculadora.BtnMult.BackColor = Color.LightGray
        Calculadora.BtnDiv.BackColor = Color.LightGray
        Calculadora.BtnIg.BackColor = Color.LightGray
        Calculadora.BtnC.BackColor = Color.LightGray

        'teal color
        Calculadora.Btn1.BackColor = Color.Teal
        Calculadora.Btn2.BackColor = Color.Teal
        Calculadora.Btn3.BackColor = Color.Teal
        Calculadora.Btn4.BackColor = Color.Teal
        Calculadora.Btn5.BackColor = Color.Teal
        Calculadora.Btn6.BackColor = Color.Teal
        Calculadora.Btn7.BackColor = Color.Teal
        Calculadora.Btn8.BackColor = Color.Teal
        Calculadora.Btn9.BackColor = Color.Teal
        Calculadora.Btn0.BackColor = Color.Teal
        'Calculadora.BtnComa.BackColor = Color.Teal
        'Calculadora.BtnSum.BackColor = Color.Teal
        'Calculadora.BtnRes.BackColor = Color.Teal
        'Calculadora.BtnMult.BackColor = Color.Teal
        'Calculadora.BtnDiv.BackColor = Color.Teal
        'Calculadora.BtnIg.BackColor = Color.Teal
        'Calculadora.BtnC.BackColor = Color.Teal

    End Sub
End Module
