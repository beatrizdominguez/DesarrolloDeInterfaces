<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.RTBInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic
        '
        Me.Pic.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pic.Image = Global.WindowsApplication1.My.Resources.Resources.icono
        Me.Pic.Location = New System.Drawing.Point(0, 0)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(111, 123)
        Me.Pic.TabIndex = 1
        Me.Pic.TabStop = False
        '
        'RTBInfo
        '
        Me.RTBInfo.BackColor = System.Drawing.Color.White
        Me.RTBInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.RTBInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBInfo.Location = New System.Drawing.Point(109, 0)
        Me.RTBInfo.Name = "RTBInfo"
        Me.RTBInfo.ReadOnly = True
        Me.RTBInfo.Size = New System.Drawing.Size(341, 123)
        Me.RTBInfo.TabIndex = 2
        Me.RTBInfo.Text = "                      Bloc de notas" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "        Autor: BEATRIZ DOMÍNGUEZ" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "        De" & _
            "sarrollo de interfaces DAM 2015"
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(450, 123)
        Me.Controls.Add(Me.RTBInfo)
        Me.Controls.Add(Me.Pic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info"
        Me.Text = "Información"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents RTBInfo As System.Windows.Forms.RichTextBox
End Class
