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
        Me.components = New System.ComponentModel.Container()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(78, 182)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(110, 35)
        Me.cmd1.TabIndex = 0
        Me.cmd1.Text = "Comenzar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(75, 65)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(107, 20)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Ciclo Superior" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(248, 199)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(16, 18)
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 297)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cmd1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl2 As System.Windows.Forms.Label

End Class
