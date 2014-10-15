Public Class Form1

    Private Sub BtnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRes.Click
        If (TxtNum.Text Mod 2) = 0 Then
            LblRes.Text = "Es un numero par"
            LblRes.ForeColor = Color.Green

        Else

            LblRes.Text = "Es un numero impar"
            LblRes.ForeColor = Color.Red

        End If
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        LblRes.Text = ""
        TxtNum.Text = "Introduce un número"


    End Sub
End Class
