Public Class FormFecha

    Private Sub BtnFecha_Click(sender As Object, e As EventArgs) Handles BtnFecha.Click
        LblFecha.Text = Date.Today.ToString("D")
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            LblFecha.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            LblFecha.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub CtmFecha_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CtmFecha.Opening

    End Sub

  
End Class