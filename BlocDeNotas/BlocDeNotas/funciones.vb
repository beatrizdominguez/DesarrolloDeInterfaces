Module funciones
   
    '''''''''''''''''''''''''
    'Formulario Bloc.vb
    '''''''''''''''''''''''''

    ''' <summary>
    ''' Habilita opciones del menú.
    ''' </summary>
    Public Sub habilitar()

        FrmIni.DeshacerMnu.Enabled = True
        FrmIni.CortarMnu.Enabled = True
        FrmIni.CopiarMnu.Enabled = True
        FrmIni.EliminarMnu.Enabled = True
        FrmIni.BuscarMnu.Enabled = True
        FrmIni.BuscarSMnu.Enabled = True

    End Sub

    ''' <summary>
    ''' Deshabilita opciones del menú.
    ''' </summary>
    Public Sub deshabilitar()

        FrmIni.DeshacerMnu.Enabled = False
        FrmIni.CortarMnu.Enabled = False
        FrmIni.CopiarMnu.Enabled = False
        FrmIni.EliminarMnu.Enabled = False
        FrmIni.BuscarMnu.Enabled = False
        FrmIni.BuscarSMnu.Enabled = False

    End Sub

End Module
