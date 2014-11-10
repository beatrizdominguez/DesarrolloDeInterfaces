<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularioFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularioHoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormulariosToolStripMenuItem
        '
        Me.FormulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormularioFechaToolStripMenuItem, Me.FormularioHoraToolStripMenuItem})
        Me.FormulariosToolStripMenuItem.Name = "FormulariosToolStripMenuItem"
        Me.FormulariosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.FormulariosToolStripMenuItem.Text = "Formularios"
        '
        'FormularioFechaToolStripMenuItem
        '
        Me.FormularioFechaToolStripMenuItem.Name = "FormularioFechaToolStripMenuItem"
        Me.FormularioFechaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FormularioFechaToolStripMenuItem.Text = "Formulario fecha"
        '
        'FormularioHoraToolStripMenuItem
        '
        Me.FormularioHoraToolStripMenuItem.Name = "FormularioHoraToolStripMenuItem"
        Me.FormularioHoraToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FormularioHoraToolStripMenuItem.Text = "Formulario hora"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.Text = "Formulario Menú"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormulariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormularioFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormularioHoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
