Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRojo.Click

        'cambiar el color de fondo a rojo
        Me.BackColor = Color.Red

    End Sub

    Private Sub cmdAzul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAzul.Click

        'cambiar el color de fondo a azul
        Me.BackColor = Color.Blue

    End Sub

    Private Sub cmdRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestablecer.Click

        'restablecer el color de fondo al original
        Me.BackColor = Color.Empty

    End Sub
   
End Class
