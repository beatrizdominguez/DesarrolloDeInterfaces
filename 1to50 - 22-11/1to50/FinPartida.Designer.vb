<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinPartida
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
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lblFelicidades = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnContinuar
        '
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(199, 198)
        Me.btnContinuar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(137, 32)
        Me.btnContinuar.TabIndex = 0
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'lblFelicidades
        '
        Me.lblFelicidades.AutoSize = True
        Me.lblFelicidades.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFelicidades.Location = New System.Drawing.Point(131, 44)
        Me.lblFelicidades.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFelicidades.Name = "lblFelicidades"
        Me.lblFelicidades.Size = New System.Drawing.Size(268, 29)
        Me.lblFelicidades.TabIndex = 1
        Me.lblFelicidades.Text = "¡¡FELICIDADES!!"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(119, 147)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(280, 26)
        Me.TxtNombre.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(16, 117)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(248, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Introduce aquí tu nombre"
        '
        'FinPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(503, 242)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblFelicidades)
        Me.Controls.Add(Me.btnContinuar)
        Me.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FinPartida"
        Me.Text = "FinPartida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents lblFelicidades As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
End Class
