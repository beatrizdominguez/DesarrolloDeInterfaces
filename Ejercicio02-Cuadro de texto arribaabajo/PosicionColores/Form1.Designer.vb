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
        Me.gbxColor = New System.Windows.Forms.GroupBox()
        Me.optAmarillo = New System.Windows.Forms.RadioButton()
        Me.optAzul = New System.Windows.Forms.RadioButton()
        Me.optVerde = New System.Windows.Forms.RadioButton()
        Me.optRojo = New System.Windows.Forms.RadioButton()
        Me.gbxPosicion = New System.Windows.Forms.GroupBox()
        Me.optBajo = New System.Windows.Forms.RadioButton()
        Me.optAlto = New System.Windows.Forms.RadioButton()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.gbxColor.SuspendLayout()
        Me.gbxPosicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxColor
        '
        Me.gbxColor.Controls.Add(Me.optAmarillo)
        Me.gbxColor.Controls.Add(Me.optAzul)
        Me.gbxColor.Controls.Add(Me.optVerde)
        Me.gbxColor.Controls.Add(Me.optRojo)
        Me.gbxColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxColor.Location = New System.Drawing.Point(22, 38)
        Me.gbxColor.Name = "gbxColor"
        Me.gbxColor.Size = New System.Drawing.Size(164, 169)
        Me.gbxColor.TabIndex = 0
        Me.gbxColor.TabStop = False
        Me.gbxColor.Text = "Colores"
        '
        'optAmarillo
        '
        Me.optAmarillo.AutoSize = True
        Me.optAmarillo.Location = New System.Drawing.Point(14, 105)
        Me.optAmarillo.Name = "optAmarillo"
        Me.optAmarillo.Size = New System.Drawing.Size(75, 20)
        Me.optAmarillo.TabIndex = 3
        Me.optAmarillo.TabStop = True
        Me.optAmarillo.Text = "Amarillo"
        Me.optAmarillo.UseVisualStyleBackColor = True
        '
        'optAzul
        '
        Me.optAzul.AutoSize = True
        Me.optAzul.Location = New System.Drawing.Point(14, 79)
        Me.optAzul.Name = "optAzul"
        Me.optAzul.Size = New System.Drawing.Size(51, 20)
        Me.optAzul.TabIndex = 2
        Me.optAzul.TabStop = True
        Me.optAzul.Text = "Azul"
        Me.optAzul.UseVisualStyleBackColor = True
        '
        'optVerde
        '
        Me.optVerde.AutoSize = True
        Me.optVerde.Location = New System.Drawing.Point(14, 53)
        Me.optVerde.Name = "optVerde"
        Me.optVerde.Size = New System.Drawing.Size(63, 20)
        Me.optVerde.TabIndex = 1
        Me.optVerde.TabStop = True
        Me.optVerde.Text = "Verde"
        Me.optVerde.UseVisualStyleBackColor = True
        '
        'optRojo
        '
        Me.optRojo.AutoSize = True
        Me.optRojo.Location = New System.Drawing.Point(14, 27)
        Me.optRojo.Name = "optRojo"
        Me.optRojo.Size = New System.Drawing.Size(55, 20)
        Me.optRojo.TabIndex = 0
        Me.optRojo.TabStop = True
        Me.optRojo.Text = "Rojo"
        Me.optRojo.UseVisualStyleBackColor = True
        '
        'gbxPosicion
        '
        Me.gbxPosicion.Controls.Add(Me.optBajo)
        Me.gbxPosicion.Controls.Add(Me.optAlto)
        Me.gbxPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPosicion.Location = New System.Drawing.Point(32, 213)
        Me.gbxPosicion.Name = "gbxPosicion"
        Me.gbxPosicion.Size = New System.Drawing.Size(125, 207)
        Me.gbxPosicion.TabIndex = 1
        Me.gbxPosicion.TabStop = False
        Me.gbxPosicion.Text = "Posicion"
        '
        'optBajo
        '
        Me.optBajo.AutoSize = True
        Me.optBajo.Location = New System.Drawing.Point(6, 56)
        Me.optBajo.Name = "optBajo"
        Me.optBajo.Size = New System.Drawing.Size(54, 20)
        Me.optBajo.TabIndex = 1
        Me.optBajo.TabStop = True
        Me.optBajo.Text = "Bajo"
        Me.optBajo.UseVisualStyleBackColor = True
        '
        'optAlto
        '
        Me.optAlto.AutoSize = True
        Me.optAlto.Location = New System.Drawing.Point(6, 30)
        Me.optAlto.Name = "optAlto"
        Me.optAlto.Size = New System.Drawing.Size(49, 20)
        Me.optAlto.TabIndex = 0
        Me.optAlto.TabStop = True
        Me.optAlto.Text = "Alto"
        Me.optAlto.UseVisualStyleBackColor = True
        '
        'txtBarra
        '
        Me.txtBarra.Location = New System.Drawing.Point(216, -1)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(231, 20)
        Me.txtBarra.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 518)
        Me.Controls.Add(Me.txtBarra)
        Me.Controls.Add(Me.gbxPosicion)
        Me.Controls.Add(Me.gbxColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxColor.ResumeLayout(False)
        Me.gbxColor.PerformLayout()
        Me.gbxPosicion.ResumeLayout(False)
        Me.gbxPosicion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxColor As System.Windows.Forms.GroupBox
    Friend WithEvents gbxPosicion As System.Windows.Forms.GroupBox
    Friend WithEvents optAmarillo As System.Windows.Forms.RadioButton
    Friend WithEvents optAzul As System.Windows.Forms.RadioButton
    Friend WithEvents optVerde As System.Windows.Forms.RadioButton
    Friend WithEvents optRojo As System.Windows.Forms.RadioButton
    Friend WithEvents optBajo As System.Windows.Forms.RadioButton
    Friend WithEvents optAlto As System.Windows.Forms.RadioButton
    Friend WithEvents txtBarra As System.Windows.Forms.TextBox

End Class
