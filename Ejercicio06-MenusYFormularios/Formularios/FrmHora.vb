Public Class FrmHora

    
    Private Sub BtnHora_Click(sender As Object, e As EventArgs) Handles BtnHora.Click
        LblHora.Text = Date.Now.ToString("T")
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            LblHora.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            LblHora.Font = FontDialog1.Font
        End If
    End Sub
End Class