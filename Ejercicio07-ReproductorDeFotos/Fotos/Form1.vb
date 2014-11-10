Public Class Form1



    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        Me.Width += CInt(Me.Width * e.Delta / 1000)
        'PictureBox1.Width += CInt(PictureBox1.Width * e.Delta / 1000)
        Me.Height += CInt(Me.Height * e.Delta / 1000)
    End Sub
End Class
