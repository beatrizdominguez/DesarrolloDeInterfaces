<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tiempos
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
        Me.lstTiempos = New System.Windows.Forms.ListBox()
        Me.lblTiempos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstTiempos
        '
        Me.lstTiempos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTiempos.FormattingEnabled = True
        Me.lstTiempos.ItemHeight = 16
        Me.lstTiempos.Location = New System.Drawing.Point(35, 80)
        Me.lstTiempos.Name = "lstTiempos"
        Me.lstTiempos.Size = New System.Drawing.Size(396, 244)
        Me.lstTiempos.Sorted = True
        Me.lstTiempos.TabIndex = 0
        '
        'lblTiempos
        '
        Me.lblTiempos.AutoSize = True
        Me.lblTiempos.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempos.ForeColor = System.Drawing.Color.White
        Me.lblTiempos.Location = New System.Drawing.Point(32, 21)
        Me.lblTiempos.Name = "lblTiempos"
        Me.lblTiempos.Size = New System.Drawing.Size(399, 13)
        Me.lblTiempos.TabIndex = 1
        Me.lblTiempos.Text = "Tiempo:     Modalidad:     Errores:    Fecha:   Jugador:"
        '
        'tiempos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(461, 358)
        Me.Controls.Add(Me.lblTiempos)
        Me.Controls.Add(Me.lstTiempos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "tiempos"
        Me.Text = "tiempos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTiempos As System.Windows.Forms.ListBox
    Friend WithEvents lblTiempos As System.Windows.Forms.Label
End Class
