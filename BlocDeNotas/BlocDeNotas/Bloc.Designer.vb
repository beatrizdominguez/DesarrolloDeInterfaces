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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIni))
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FntDialog1 = New System.Windows.Forms.FontDialog()
        Me.Mnu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReemplazarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYFechaMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AparienciaMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorFondoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorTextoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.RTBText = New System.Windows.Forms.RichTextBox()
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
        Me.Mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoMnu, Me.EditarMnu, Me.HerramientasMnu, Me.AyudaMnu})
        Me.Mnu.Location = New System.Drawing.Point(0, 0)
        Me.Mnu.Name = "Mnu"
        Me.Mnu.Size = New System.Drawing.Size(391, 24)
        Me.Mnu.TabIndex = 2
        Me.Mnu.Text = "MenuStrip1"
        '
        'ArchivoMnu
        '
        Me.ArchivoMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoMnu, Me.AbrirMnu, Me.toolStripSeparator1, Me.GuardarMnu, Me.GuardarCMnu, Me.toolStripSeparator2, Me.SalirMnu})
        Me.ArchivoMnu.Name = "ArchivoMnu"
        Me.ArchivoMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ArchivoMnu.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoMnu.Text = "&Archivo"
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
        'EditarMnu
        '
        Me.EditarMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerMnu, Me.RehacerMnu, Me.toolStripSeparator3, Me.CortarMnu, Me.CopiarMnu, Me.PegarMnu, Me.EliminarMnu, Me.toolStripSeparator4, Me.BuscarMnu, Me.BuscarSMnu, Me.ReemplazarMnu, Me.ToolStripSeparator5, Me.SeleccMnu, Me.HoraYFechaMnu})
        Me.EditarMnu.Name = "EditarMnu"
        Me.EditarMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditarMnu.Size = New System.Drawing.Size(49, 20)
        Me.EditarMnu.Text = "&Editar"
        '
        'DeshacerMnu
        '
        Me.DeshacerMnu.Enabled = False
        Me.DeshacerMnu.Name = "DeshacerMnu"
        Me.DeshacerMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerMnu.Size = New System.Drawing.Size(202, 22)
        Me.DeshacerMnu.Text = "&Deshacer"
        '
        'RehacerMnu
        '
        Me.RehacerMnu.Name = "RehacerMnu"
        Me.RehacerMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerMnu.Size = New System.Drawing.Size(202, 22)
        Me.RehacerMnu.Text = "&Rehacer"
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
        'EliminarMnu
        '
        Me.EliminarMnu.Enabled = False
        Me.EliminarMnu.Name = "EliminarMnu"
        Me.EliminarMnu.Size = New System.Drawing.Size(202, 22)
        Me.EliminarMnu.Text = "Eliminar"
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
        Me.BuscarSMnu.Enabled = False
        Me.BuscarSMnu.Name = "BuscarSMnu"
        Me.BuscarSMnu.Size = New System.Drawing.Size(202, 22)
        Me.BuscarSMnu.Text = "Buscar siguiente"
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
        'HerramientasMnu
        '
        Me.HerramientasMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteMnu, Me.ColorMnu, Me.AparienciaMnu})
        Me.HerramientasMnu.Name = "HerramientasMnu"
        Me.HerramientasMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HerramientasMnu.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasMnu.Text = "&Herramientas"
        '
        'FuenteMnu
        '
        Me.FuenteMnu.Name = "FuenteMnu"
        Me.FuenteMnu.Size = New System.Drawing.Size(152, 22)
        Me.FuenteMnu.Text = "Fuente..."
        '
        'ColorMnu
        '
        Me.ColorMnu.Name = "ColorMnu"
        Me.ColorMnu.Size = New System.Drawing.Size(152, 22)
        Me.ColorMnu.Text = "Color..."
        '
        'AparienciaMnu
        '
        Me.AparienciaMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorFondoMnu, Me.ColorTextoMnu})
        Me.AparienciaMnu.Name = "AparienciaMnu"
        Me.AparienciaMnu.Size = New System.Drawing.Size(152, 22)
        Me.AparienciaMnu.Text = "Personalizar..."
        '
        'ColorFondoMnu
        '
        Me.ColorFondoMnu.Name = "ColorFondoMnu"
        Me.ColorFondoMnu.Size = New System.Drawing.Size(152, 22)
        Me.ColorFondoMnu.Text = "Color fondo"
        '
        'ColorTextoMnu
        '
        Me.ColorTextoMnu.Name = "ColorTextoMnu"
        Me.ColorTextoMnu.Size = New System.Drawing.Size(152, 22)
        Me.ColorTextoMnu.Text = "Color texto"
        '
        'AyudaMnu
        '
        Me.AyudaMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaMnu})
        Me.AyudaMnu.Name = "AyudaMnu"
        Me.AyudaMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.AyudaMnu.Size = New System.Drawing.Size(53, 20)
        Me.AyudaMnu.Text = "Ay&uda"
        '
        'AcercaMnu
        '
        Me.AcercaMnu.Name = "AcercaMnu"
        Me.AcercaMnu.Size = New System.Drawing.Size(152, 22)
        Me.AcercaMnu.Text = "&Acerca de..."
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
        Me.txtCont.Text = "Líneas:  0      Palabras:    0      Caractéres:    0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RTBText
        '
        Me.RTBText.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.RTBText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTBText.Location = New System.Drawing.Point(0, 24)
        Me.RTBText.Name = "RTBText"
        Me.RTBText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RTBText.Size = New System.Drawing.Size(391, 292)
        Me.RTBText.TabIndex = 7
        Me.RTBText.Text = ""
        '
        'FrmIni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(391, 336)
        Me.Controls.Add(Me.RTBText)
        Me.Controls.Add(Me.txtCont)
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
    Friend WithEvents ArchivoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeleccMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReemplazarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HoraYFechaMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents ColorMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents RTBText As System.Windows.Forms.RichTextBox
    Friend WithEvents EliminarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AparienciaMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorFondoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorTextoMnu As System.Windows.Forms.ToolStripMenuItem

End Class
