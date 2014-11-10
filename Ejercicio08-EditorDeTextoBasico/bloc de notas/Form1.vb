Imports System.IO



Public Class Frm1

    Dim nombre As String
    Dim sw As StreamWriter
    Dim sr As StreamReader

    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        txtTexto.Clear()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'GuardarToolStripMenuItem_Click()
        Me.Close()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

        'abrimos el fichero
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            nombre = OpenFileDialog1.FileName

            'abrimos el fichero para grabar
            sr = File.OpenText(OpenFileDialog1.FileName)
            txtTexto.Text = sr.ReadToEnd
            'cerramos el fichero
            sr.Close()
        End If



    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click


        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'abrimos el fichero para grabar
            sw = File.CreateText(SaveFileDialog1.FileName + ".txt")
            'escribimos la informacion del txtFicheros
            sw.Write(txtTexto.Text)
            'vaciar memoria
            sw.Flush()
            'cerrar
            sw.Close()
        End If

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        If Not nombre Is Nothing Then

            'abrimos el fichero para grabar
            sw = File.CreateText(nombre)

            'escribimos la informacion del txtFicheros
            sw.Write(txtTexto.Text)
            'vaciar memoria
            sw.Flush()
            'cerrar
            sw.Close()

        Else


            Me.GuardarComoToolStripMenuItem_Click(sender, e)


        End If




    End Sub

End Class
