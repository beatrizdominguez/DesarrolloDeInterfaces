<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdRojo = New System.Windows.Forms.Button()
        Me.cmdRestablecer = New System.Windows.Forms.Button()
        Me.cmdAzul = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdRojo
        '
        Me.cmdRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRojo.Location = New System.Drawing.Point(96, 41)
        Me.cmdRojo.Name = "cmdRojo"
        Me.cmdRojo.Size = New System.Drawing.Size(86, 35)
        Me.cmdRojo.TabIndex = 0
        Me.cmdRojo.Text = "Rojo"
        Me.cmdRojo.UseVisualStyleBackColor = True
        '
        'cmdRestablecer
        '
        Me.cmdRestablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestablecer.Location = New System.Drawing.Point(54, 187)
        Me.cmdRestablecer.Name = "cmdRestablecer"
        Me.cmdRestablecer.Size = New System.Drawing.Size(166, 35)
        Me.cmdRestablecer.TabIndex = 1
        Me.cmdRestablecer.Text = "Restablecer"
        Me.cmdRestablecer.UseVisualStyleBackColor = True
        '
        'cmdAzul
        '
        Me.cmdAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAzul.Location = New System.Drawing.Point(96, 114)
        Me.cmdAzul.Name = "cmdAzul"
        Me.cmdAzul.Size = New System.Drawing.Size(86, 35)
        Me.cmdAzul.TabIndex = 2
        Me.cmdAzul.Text = "Azul"
        Me.cmdAzul.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmdAzul)
        Me.Controls.Add(Me.cmdRestablecer)
        Me.Controls.Add(Me.cmdRojo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdRojo As System.Windows.Forms.Button
    Friend WithEvents cmdRestablecer As System.Windows.Forms.Button
    Friend WithEvents cmdAzul As System.Windows.Forms.Button

End Class
