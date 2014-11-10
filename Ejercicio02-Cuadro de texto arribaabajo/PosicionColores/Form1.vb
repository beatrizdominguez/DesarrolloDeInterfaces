Public Class Form1


    Private Sub optVerde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVerde.CheckedChanged
        Me.txtBarra.BackColor = Color.Green

    End Sub

    Private Sub optRojo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRojo.CheckedChanged
        Me.txtBarra.BackColor = Color.Red
    End Sub

    Private Sub optAzul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAzul.CheckedChanged
        Me.txtBarra.BackColor = Color.Blue

    End Sub

    Private Sub optAmarillo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAmarillo.CheckedChanged
        Me.txtBarra.BackColor = Color.Yellow

    End Sub

    Private Sub optAlto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlto.CheckedChanged
        Me.txtBarra.Top = 0

    End Sub

    Private Sub optBajo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBajo.CheckedChanged
        Me.txtBarra.Top = Me.Height - 57

    End Sub
End Class
