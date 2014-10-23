Module _1ayout

    Public Sub kidsLayout()

        'mostrar en que menú contextual te encuentras
        Calculadora.KidsToolStripMenuItem.BackColor = Color.Orange
        Calculadora.EmpresaToolStripMenuItem.BackColor = Color.Empty
        Calculadora.OldToolStripMenuItem.BackColor = Color.Empty

        'definimos el formulario
        Calculadora.BackColor = Color.White

        'mostrar grupos de botones
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
        Calculadora.Height = 435
        'el tamaño del formulario no puede alterarse
        Calculadora.FormBorderStyle = FormBorderStyle.FixedSingle

        'estilo de los botones
        Calculadora.Btn1.FlatStyle = FlatStyle.Flat
        Calculadora.Btn2.FlatStyle = FlatStyle.Flat
        Calculadora.Btn3.FlatStyle = FlatStyle.Flat
        Calculadora.Btn4.FlatStyle = FlatStyle.Flat
        Calculadora.Btn5.FlatStyle = FlatStyle.Flat
        Calculadora.Btn6.FlatStyle = FlatStyle.Flat
        Calculadora.Btn7.FlatStyle = FlatStyle.Flat
        Calculadora.Btn8.FlatStyle = FlatStyle.Flat
        Calculadora.Btn8.FlatStyle = FlatStyle.Flat
        Calculadora.Btn9.FlatStyle = FlatStyle.Flat
        Calculadora.Btn0.FlatStyle = FlatStyle.Flat
        Calculadora.BtnComa.FlatStyle = FlatStyle.Flat
        Calculadora.BtnSum.FlatStyle = FlatStyle.Flat
        Calculadora.BtnRes.FlatStyle = FlatStyle.Flat
        Calculadora.BtnMult.FlatStyle = FlatStyle.Flat
        Calculadora.BtnDiv.FlatStyle = FlatStyle.Flat
        Calculadora.BtnIg.FlatStyle = FlatStyle.Flat
        Calculadora.BtnC.FlatStyle = FlatStyle.Flat
        Calculadora.BtnBorrar.FlatStyle = FlatStyle.Flat

    End Sub


    Public Sub businessLayout()

        'mostrar en que menú contextual te encuentras
        Calculadora.KidsToolStripMenuItem.BackColor = Color.Empty
        Calculadora.EmpresaToolStripMenuItem.BackColor = Color.Gray
        Calculadora.OldToolStripMenuItem.BackColor = Color.Empty

        'definimos el formulario
        Calculadora.BackColor = Color.DarkGray
        ' Calculadora.BackgroundImage = ""
        Calculadora.GrbCint.Location = New Point(295, 145)

        'mostrar grupos de botones
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

        'formato del formulario
        Calculadora.Width = 520
        Calculadora.Height = 435
        'el tamaño del formulario no puede alterarse
        Calculadora.FormBorderStyle = FormBorderStyle.FixedSingle

        'estilo de los botones
        Calculadora.Btn1.FlatStyle = FlatStyle.System
        Calculadora.Btn2.FlatStyle = FlatStyle.System
        Calculadora.Btn3.FlatStyle = FlatStyle.System
        Calculadora.Btn4.FlatStyle = FlatStyle.System
        Calculadora.Btn5.FlatStyle = FlatStyle.System
        Calculadora.Btn6.FlatStyle = FlatStyle.System
        Calculadora.Btn7.FlatStyle = FlatStyle.System
        Calculadora.Btn8.FlatStyle = FlatStyle.System
        Calculadora.Btn8.FlatStyle = FlatStyle.System
        Calculadora.Btn9.FlatStyle = FlatStyle.System
        Calculadora.Btn0.FlatStyle = FlatStyle.System
        Calculadora.BtnComa.FlatStyle = FlatStyle.System
        Calculadora.BtnSum.FlatStyle = FlatStyle.System
        Calculadora.BtnRes.FlatStyle = FlatStyle.System
        Calculadora.BtnMult.FlatStyle = FlatStyle.System
        Calculadora.BtnDiv.FlatStyle = FlatStyle.System
        Calculadora.BtnIg.FlatStyle = FlatStyle.System
        Calculadora.BtnC.FlatStyle = FlatStyle.System
        Calculadora.Btn00.FlatStyle = FlatStyle.System
        Calculadora.BtnBorrar.FlatStyle = FlatStyle.System


    End Sub


    Public Sub oldLayout()

        'mostrar en que menú contextual te encuentras
        Calculadora.KidsToolStripMenuItem.BackColor = Color.Empty
        Calculadora.EmpresaToolStripMenuItem.BackColor = Color.Empty
        Calculadora.OldToolStripMenuItem.BackColor = Color.Red

        'definimos el formulario
        Calculadora.BackColor = Color.Empty
        Calculadora.GrbTxtA.Location = New Point(15, 28)
        Calculadora.GrbAbuelos.Location = New Point(3, 260)

        'mostrar grupos de botones
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
        Calculadora.Width = 620
        Calculadora.Height = 790
        'el tamaño del formulario no puede alterarse
        Calculadora.FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub
End Module
