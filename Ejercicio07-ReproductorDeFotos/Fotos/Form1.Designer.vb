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
        Me.Mnu1 = New System.Windows.Forms.MenuStrip()
        Me.FicheroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Mnu1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mnu1
        '
        Me.Mnu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheroToolStripMenuItem})
        Me.Mnu1.Location = New System.Drawing.Point(0, 0)
        Me.Mnu1.Name = "Mnu1"
        Me.Mnu1.Size = New System.Drawing.Size(595, 24)
        Me.Mnu1.TabIndex = 0
        Me.Mnu1.Text = "MenuStrip1"
        '
        'FicheroToolStripMenuItem
        '
        Me.FicheroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.FicheroToolStripMenuItem.Name = "FicheroToolStripMenuItem"
        Me.FicheroToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FicheroToolStripMenuItem.Text = "Fichero"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 408)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 432)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Mnu1)
        Me.MainMenuStrip = Me.Mnu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Mnu1.ResumeLayout(False)
        Me.Mnu1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mnu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FicheroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
