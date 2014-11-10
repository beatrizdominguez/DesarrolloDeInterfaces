Public Class Ejercicio01

    Private Sub cmdSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuma.Click
        'Cambia el símbolo a + al hacer click sobre el botón suma
        Me.lblSim.Text = "+"
        'Suma los dos valores introducidos y los muestra en la etiqueta final
        Me.lbl1.Text = Val(txt1.Text) + Val(Txt2.Text)

    End Sub

    Private Sub cmdResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResta.Click
        'Cambia el símbolo a - al hacer click sobre el botón resta
        Me.lblSim.Text = "-"
        'Resta los dos valores introducidos y los muestra en la etiqueta final
        Me.lbl1.Text = Val(txt1.Text) - Val(Txt2.Text)
    End Sub

    Private Sub cmdMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiplicar.Click
        'Cambia el símbolo a * al hacer click sobre el botón multiplicación
        Me.lblSim.Text = "*"
        'Multiplica los dos valores introducidos y los muestra en la etiqueta final
        Me.lbl1.Text = Val(txt1.Text) * Val(Txt2.Text)

    End Sub

    Private Sub cmdDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDividir.Click

        'Cambia el símbolo a / al hacer click sobre el botón división
        Me.lblSim.Text = "/"
        'Divide los dos valores introducidos y los muestra en la etiqueta final
        Me.lbl1.Text = Val(txt1.Text) / Val(Txt2.Text)

    End Sub

   
End Class
