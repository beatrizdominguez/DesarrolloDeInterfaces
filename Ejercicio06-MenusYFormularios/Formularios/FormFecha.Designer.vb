<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFecha
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
        Me.BtnFecha = New System.Windows.Forms.Button()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.CtmFecha = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.CtmFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFecha
        '
        Me.BtnFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFecha.Location = New System.Drawing.Point(62, 32)
        Me.BtnFecha.Name = "BtnFecha"
        Me.BtnFecha.Size = New System.Drawing.Size(184, 72)
        Me.BtnFecha.TabIndex = 0
        Me.BtnFecha.Text = "Mostrar fecha"
        Me.BtnFecha.UseVisualStyleBackColor = True
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.ContextMenuStrip = Me.CtmFecha
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(30, 176)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(46, 16)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'CtmFecha
        '
        Me.CtmFecha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FuenteToolStripMenuItem})
        Me.CtmFecha.Name = "CtmFecha"
        Me.CtmFecha.Size = New System.Drawing.Size(111, 48)
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
        'FormFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.BtnFecha)
        Me.Name = "FormFecha"
        Me.Text = "FormFecha"
        Me.CtmFecha.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnFecha As System.Windows.Forms.Button
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents CtmFecha As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
