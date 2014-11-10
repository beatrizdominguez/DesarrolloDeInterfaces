<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio01
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cmdSuma = New System.Windows.Forms.Button()
        Me.cmdResta = New System.Windows.Forms.Button()
        Me.cmdMultiplicar = New System.Windows.Forms.Button()
        Me.cmdDividir = New System.Windows.Forms.Button()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.lblSim = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(33, 85)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(68, 44)
        Me.txt1.TabIndex = 0
        '
        'Txt2
        '
        Me.Txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.ForeColor = System.Drawing.Color.Black
        Me.Txt2.Location = New System.Drawing.Point(176, 85)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(76, 44)
        Me.Txt2.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(315, 92)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(53, 37)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "00"
        '
        'cmdSuma
        '
        Me.cmdSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuma.ForeColor = System.Drawing.Color.Black
        Me.cmdSuma.Location = New System.Drawing.Point(33, 176)
        Me.cmdSuma.Name = "cmdSuma"
        Me.cmdSuma.Size = New System.Drawing.Size(54, 34)
        Me.cmdSuma.TabIndex = 3
        Me.cmdSuma.Text = "+"
        Me.cmdSuma.UseVisualStyleBackColor = True
        '
        'cmdResta
        '
        Me.cmdResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResta.Location = New System.Drawing.Point(112, 176)
        Me.cmdResta.Name = "cmdResta"
        Me.cmdResta.Size = New System.Drawing.Size(58, 33)
        Me.cmdResta.TabIndex = 4
        Me.cmdResta.Text = "-"
        Me.cmdResta.UseVisualStyleBackColor = True
        '
        'cmdMultiplicar
        '
        Me.cmdMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMultiplicar.Location = New System.Drawing.Point(196, 174)
        Me.cmdMultiplicar.Name = "cmdMultiplicar"
        Me.cmdMultiplicar.Size = New System.Drawing.Size(56, 33)
        Me.cmdMultiplicar.TabIndex = 5
        Me.cmdMultiplicar.Text = "*"
        Me.cmdMultiplicar.UseVisualStyleBackColor = True
        '
        'cmdDividir
        '
        Me.cmdDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDividir.Location = New System.Drawing.Point(279, 175)
        Me.cmdDividir.Name = "cmdDividir"
        Me.cmdDividir.Size = New System.Drawing.Size(69, 32)
        Me.cmdDividir.TabIndex = 6
        Me.cmdDividir.Text = "/"
        Me.cmdDividir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(275, 101)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(21, 24)
        Me.lblIgual.TabIndex = 7
        Me.lblIgual.Text = "="
        '
        'lblSim
        '
        Me.lblSim.AutoSize = True
        Me.lblSim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSim.Location = New System.Drawing.Point(127, 101)
        Me.lblSim.Name = "lblSim"
        Me.lblSim.Size = New System.Drawing.Size(21, 24)
        Me.lblSim.TabIndex = 8
        Me.lblSim.Text = "+"
        '
        'Ejercicio01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 262)
        Me.Controls.Add(Me.lblSim)
        Me.Controls.Add(Me.lblIgual)
        Me.Controls.Add(Me.cmdDividir)
        Me.Controls.Add(Me.cmdMultiplicar)
        Me.Controls.Add(Me.cmdResta)
        Me.Controls.Add(Me.cmdSuma)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Ejercicio01"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cmdSuma As System.Windows.Forms.Button
    Friend WithEvents cmdResta As System.Windows.Forms.Button
    Friend WithEvents cmdMultiplicar As System.Windows.Forms.Button
    Friend WithEvents cmdDividir As System.Windows.Forms.Button
    Friend WithEvents lblIgual As System.Windows.Forms.Label
    Friend WithEvents lblSim As System.Windows.Forms.Label

End Class
