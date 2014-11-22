Imports System.IO
Public Class tiempos

    'cargar archivos cuando se abra
    'grabar archivos cuando se cierre



    ''comprobar que si no la abrimos en ningun momento, si se carga lo que hay nuevo o no

    'Public Sub cargarTiempos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'cargamos el listbox desde un archivo

    '    ' sr = File.OpenText("C:/datos/historialPartidas.txt")

    '    FileOpen(1, "C:/datos/historialPartidas.txt", OpenMode.Input)

    '    Do While Not EOF(1)

    '        ListBox1.Items.Add(LineInput(1))
    '    Loop

    '    FileClose(1)

    '    'Dim W As StreamReader
    '    'Dim i As Integer
    '    'W = New StreamReader("C:/datos/historialPartidas.txt")

    '    'For i = 0 To File.ReadAllLines("C:/datos/historialPartidas.txt").Length
    '    '    ListBox1.Items.Add(W.ReadLine)
    '    '    ' ListBox1.Items.Add(LineInput(1))
    '    'Next
    '    'W.Close()


    'End Sub



    Public Sub cargarTiempos(ByVal sender As Object, ByVal e As System.EventArgs)

        'cargamos el listbox desde un archivo

        ' sr = File.OpenText("C:/datos/historialPartidas.txt")

        FileOpen(1, My.Resources.historialPartidas, OpenMode.Input)
        ' FileOpen(1, "C:/datos/historialPartidas.txt", OpenMode.Input)

        Do While Not EOF(1)

            ListBox1.Items.Add(LineInput(1))
        Loop

        FileClose(1)

        'Dim W As StreamReader
        'Dim i As Integer
        'W = New StreamReader("C:/datos/historialPartidas.txt")

        'For i = 0 To File.ReadAllLines("C:/datos/historialPartidas.txt").Length
        '    ListBox1.Items.Add(W.ReadLine)
        '    ' ListBox1.Items.Add(LineInput(1))
        'Next
        'W.Close()


    End Sub



    Public Sub guardarTiempos(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ''guardamos el texto del list box en un archivo
        'FileOpen(2, "C:/datos/historialPartidas.txt", OpenMode.Output)
        'Dim i As Long

        'For i = 0 To ListBox1.Items.Count - 1 Step 1

        '    WriteLine(2, ListBox1.Items.Item(i))
        '    '  WriteLine(2, ListBox1.GetItemText(i).ToString)

        'Next

        'FileClose(2)
        'así no salen "" cada vez que se carga

        Dim W As StreamWriter
        Dim i As Integer
        ' W = New StreamWriter("C:/datos/historialPartidas.txt")
        W = New StreamWriter(My.Resources.historialPartidas)

        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()


    End Sub

    
    Private Sub ListBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.TextChanged

        FileOpen(1, "C:/datos/historialPartidas.txt", OpenMode.Input)

        Do While Not EOF(1)

            ListBox1.Items.Add(LineInput(1))
        Loop

        FileClose(1)

    End Sub
End Class