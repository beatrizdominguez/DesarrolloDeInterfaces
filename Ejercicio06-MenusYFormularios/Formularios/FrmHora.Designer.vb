<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHora
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
        Me.BtnHora = New System.Windows.Forms.Button()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.CtmHora = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.CtmHora.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnHora
        '
        Me.BtnHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHora.Location = New System.Drawing.Point(70, 51)
        Me.BtnHora.Name = "BtnHora"
        Me.BtnHora.Size = New System.Drawing.Size(120, 59)
        Me.BtnHora.TabIndex = 0
        Me.BtnHora.Text = "Mostrar hora"
        Me.BtnHora.UseVisualStyleBackColor = True
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.ContextMenuStrip = Me.CtmHora
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(42, 159)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(38, 16)
        Me.LblHora.TabIndex = 1
        Me.LblHora.Text = "Hora"
        '
        'CtmHora
        '
        Me.CtmHora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FuenteToolStripMenuItem})
        Me.CtmHora.Name = "CtmHora"
        Me.CtmHora.Size = New System.Drawing.Size(111, 48)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'FrmHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.BtnHora)
        Me.Name = "FrmHora"
        Me.Text = "Formulario hora"
        Me.CtmHora.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHora As System.Windows.Forms.Button
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents CtmHora As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
