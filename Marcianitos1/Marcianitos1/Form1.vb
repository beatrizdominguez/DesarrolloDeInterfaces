Public Class Form1

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click

        If Btn1.Text = "Comenzar" Then
            Btn1.Text = "Parar"
        ElseIf Btn1.Text = "Parar" Then
            Btn1.Text = "Comenzar"

        End If

    End Sub
   
    Private Sub tmtt1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmt1.Tick

        Lbl1.Left -= 10
        LblT.Text = "inicio"

        If Btn1.Text = "Parar" Then
            'If Lbl1.Left + Lbl1.Width > Form1.ScaleWidth Then
            '    direccion = -10
            'End If
            'If Lbl1.Left - direccion < 0 Then
            '    direccion = 10
            'End If
            'Lbl1.Left = Lbl1.Left + direccion

            Lbl1.Left += 10
        End If

    End Sub
End Class
