<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIni))
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FntDialog1 = New System.Windows.Forms.FontDialog()
        Me.Mnu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReemplazarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYFechaMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.RTBText = New System.Windows.Forms.RichTextBox()
        Me.EliminarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFDialog
        '
        Me.OFDialog.FileName = "OpenFileDialog1"
        Me.OFDialog.Filter = "Documento de texto (*.txt)|*.txt| Todos los archivos(*.*)|*.*"
        '
        'SFDialog
        '
        Me.SFDialog.Filter = "Documento de texto (*.txt)|*.txt| Todos los archivos(*.*)|*.*"
        '
        'Mnu
        '
        Me.Mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.Mnu.Location = New System.Drawing.Point(0, 0)
        Me.Mnu.Name = "Mnu"
        Me.Mnu.Size = New System.Drawing.Size(391, 24)
        Me.Mnu.TabIndex = 2
        Me.Mnu.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoMnu, Me.AbrirMnu, Me.toolStripSeparator1, Me.GuardarMnu, Me.GuardarCMnu, Me.toolStripSeparator2, Me.SalirMnu})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoMnu
        '
        Me.NuevoMnu.Image = CType(resources.GetObject("NuevoMnu.Image"), System.Drawing.Image)
        Me.NuevoMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoMnu.Name = "NuevoMnu"
        Me.NuevoMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoMnu.Size = New System.Drawing.Size(156, 22)
        Me.NuevoMnu.Text = "&Nuevo"
        '
        'AbrirMnu
        '
        Me.AbrirMnu.Image = CType(resources.GetObject("AbrirMnu.Image"), System.Drawing.Image)
        Me.AbrirMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirMnu.Name = "AbrirMnu"
        Me.AbrirMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirMnu.Size = New System.Drawing.Size(156, 22)
        Me.AbrirMnu.Text = "&Abrir"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'GuardarMnu
        '
        Me.GuardarMnu.Image = CType(resources.GetObject("GuardarMnu.Image"), System.Drawing.Image)
        Me.GuardarMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarMnu.Name = "GuardarMnu"
        Me.GuardarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarMnu.Size = New System.Drawing.Size(156, 22)
        Me.GuardarMnu.Text = "&Guardar"
        '
        'GuardarCMnu
        '
        Me.GuardarCMnu.Name = "GuardarCMnu"
        Me.GuardarCMnu.Size = New System.Drawing.Size(156, 22)
        Me.GuardarCMnu.Text = "G&uardar como"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'SalirMnu
        '
        Me.SalirMnu.Name = "SalirMnu"
        Me.SalirMnu.Size = New System.Drawing.Size(156, 22)
        Me.SalirMnu.Text = "&Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerMnu, Me.RehacerToolStripMenuItem, Me.toolStripSeparator3, Me.CortarMnu, Me.CopiarMnu, Me.PegarMnu, Me.EliminarMnu, Me.toolStripSeparator4, Me.BuscarMnu, Me.BuscarSMnu, Me.ReemplazarMnu, Me.ToolStripSeparator5, Me.SeleccMnu, Me.HoraYFechaMnu})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'DeshacerMnu
        '
        Me.DeshacerMnu.Enabled = False
        Me.DeshacerMnu.Name = "DeshacerMnu"
        Me.DeshacerMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerMnu.Size = New System.Drawing.Size(202, 22)
        Me.DeshacerMnu.Text = "&Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.RehacerToolStripMenuItem.Text = "&Rehacer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(199, 6)
        '
        'CortarMnu
        '
        Me.CortarMnu.Enabled = False
        Me.CortarMnu.Image = CType(resources.GetObject("CortarMnu.Image"), System.Drawing.Image)
        Me.CortarMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarMnu.Name = "CortarMnu"
        Me.CortarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarMnu.Size = New System.Drawing.Size(202, 22)
        Me.CortarMnu.Text = "Cor&tar"
        '
        'CopiarMnu
        '
        Me.CopiarMnu.Enabled = False
        Me.CopiarMnu.Image = CType(resources.GetObject("CopiarMnu.Image"), System.Drawing.Image)
        Me.CopiarMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarMnu.Name = "CopiarMnu"
        Me.CopiarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarMnu.Size = New System.Drawing.Size(202, 22)
        Me.CopiarMnu.Text = "&Copiar"
        '
        'PegarMnu
        '
        Me.PegarMnu.Image = CType(resources.GetObject("PegarMnu.Image"), System.Drawing.Image)
        Me.PegarMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarMnu.Name = "PegarMnu"
        Me.PegarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarMnu.Size = New System.Drawing.Size(202, 22)
        Me.PegarMnu.Text = "&Pegar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(199, 6)
        '
        'BuscarMnu
        '
        Me.BuscarMnu.Enabled = False
        Me.BuscarMnu.Name = "BuscarMnu"
        Me.BuscarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarMnu.Size = New System.Drawing.Size(202, 22)
        Me.BuscarMnu.Text = "Buscar..."
        '
        'BuscarSMnu
        '
        Me.BuscarSMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.BuscarSMnu.Enabled = False
        Me.BuscarSMnu.Name = "BuscarSMnu"
        Me.BuscarSMnu.Size = New System.Drawing.Size(202, 22)
        Me.BuscarSMnu.Text = "Buscar siguiente"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem2.Text = " "
        '
        'ReemplazarMnu
        '
        Me.ReemplazarMnu.Name = "ReemplazarMnu"
        Me.ReemplazarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReemplazarMnu.Size = New System.Drawing.Size(202, 22)
        Me.ReemplazarMnu.Text = "Reemplazar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(199, 6)
        '
        'SeleccMnu
        '
        Me.SeleccMnu.Name = "SeleccMnu"
        Me.SeleccMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SeleccMnu.Size = New System.Drawing.Size(202, 22)
        Me.SeleccMnu.Text = "&Seleccionar todo"
        '
        'HoraYFechaMnu
        '
        Me.HoraYFechaMnu.Name = "HoraYFechaMnu"
        Me.HoraYFechaMnu.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.HoraYFechaMnu.Size = New System.Drawing.Size(202, 22)
        Me.HoraYFechaMnu.Text = "Hora y fecha"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteMnu, Me.ColorMnu})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'FuenteMnu
        '
        Me.FuenteMnu.Name = "FuenteMnu"
        Me.FuenteMnu.Size = New System.Drawing.Size(119, 22)
        Me.FuenteMnu.Text = "Fuente..."
        '
        'ColorMnu
        '
        Me.ColorMnu.Name = "ColorMnu"
        Me.ColorMnu.Size = New System.Drawing.Size(119, 22)
        Me.ColorMnu.Text = "Color..."
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaMnu})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaMnu
        '
        Me.AcercaMnu.Name = "AcercaMnu"
        Me.AcercaMnu.Size = New System.Drawing.Size(135, 22)
        Me.AcercaMnu.Text = "&Acerca de..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "pal"
        '
        'txtCont
        '
        Me.txtCont.BackColor = System.Drawing.SystemColors.Control
        Me.txtCont.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtCont.Location = New System.Drawing.Point(0, 316)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.ReadOnly = True
        Me.txtCont.Size = New System.Drawing.Size(391, 20)
        Me.txtCont.TabIndex = 4
        Me.txtCont.Text = "Líneas:  0      Caractéres:    0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RTBText
        '
        Me.RTBText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTBText.Location = New System.Drawing.Point(0, 24)
        Me.RTBText.Name = "RTBText"
        Me.RTBText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RTBText.Size = New System.Drawing.Size(391, 292)
        Me.RTBText.TabIndex = 7
        Me.RTBText.Text = ""
        '
        'EliminarMnu
        '
        Me.EliminarMnu.Enabled = False
        Me.EliminarMnu.Name = "EliminarMnu"
        Me.EliminarMnu.Size = New System.Drawing.Size(202, 22)
        Me.EliminarMnu.Text = "Eliminar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'FrmIni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(391, 336)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RTBText)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mnu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIni"
        Me.Text = "Bloc de notas"
        Me.Mnu.ResumeLayout(False)
        Me.Mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FntDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeleccMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReemplazarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HoraYFechaMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents ColorMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents RTBText As System.Windows.Forms.RichTextBox
    Friend WithEvents EliminarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
