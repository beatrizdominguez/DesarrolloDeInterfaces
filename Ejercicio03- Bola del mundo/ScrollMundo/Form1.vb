Public Class Form1

    Private Sub hsb_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsb.Scroll

        picMundo.Width = hsb.Value

    End Sub

    Private Sub vsb_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsb.Scroll

        picMundo.Height = vsb.Value
    End Sub
End Class
