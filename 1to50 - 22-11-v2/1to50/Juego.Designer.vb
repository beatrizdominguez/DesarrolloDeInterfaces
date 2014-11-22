<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModalidadMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumerosMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoresMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MulticolorCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AzulCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerdeCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RosaCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonocromoCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimbolosMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlobalSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManosSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculosSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmileSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZodiacoSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiemposMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.White
        Me.btnInicio.FlatAppearance.BorderSize = 3
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnInicio.Location = New System.Drawing.Point(78, 107)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(155, 54)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Nueva partida"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(279, 107)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(118, 17)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00:00:00"
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.BackColor = System.Drawing.Color.Transparent
        Me.lblInstrucciones.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.ForeColor = System.Drawing.Color.White
        Me.lblInstrucciones.Location = New System.Drawing.Point(12, 50)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(538, 17)
        Me.lblInstrucciones.TabIndex = 2
        Me.lblInstrucciones.Text = "Ordena los números del 1 al 25 lo más rápido posible."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModalidadMnu, Me.TiemposMnu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(553, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModalidadMnu
        '
        Me.ModalidadMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumerosMnu, Me.ColoresMnu, Me.SimbolosMnu})
        Me.ModalidadMnu.Name = "ModalidadMnu"
        Me.ModalidadMnu.Size = New System.Drawing.Size(76, 20)
        Me.ModalidadMnu.Text = "Modalidad"
        '
        'NumerosMnu
        '
        Me.NumerosMnu.Checked = True
        Me.NumerosMnu.CheckOnClick = True
        Me.NumerosMnu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NumerosMnu.Name = "NumerosMnu"
        Me.NumerosMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NumerosMnu.Size = New System.Drawing.Size(166, 22)
        Me.NumerosMnu.Text = "Números"
        '
        'ColoresMnu
        '
        Me.ColoresMnu.CheckOnClick = True
        Me.ColoresMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MulticolorCMnu, Me.AzulCMnu, Me.VerdeCMnu, Me.RosaCMnu, Me.MonocromoCMnu})
        Me.ColoresMnu.Name = "ColoresMnu"
        Me.ColoresMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ColoresMnu.Size = New System.Drawing.Size(166, 22)
        Me.ColoresMnu.Text = "Colores"
        '
        'MulticolorCMnu
        '
        Me.MulticolorCMnu.Name = "MulticolorCMnu"
        Me.MulticolorCMnu.Size = New System.Drawing.Size(160, 22)
        Me.MulticolorCMnu.Text = "Multicolor"
        '
        'AzulCMnu
        '
        Me.AzulCMnu.Name = "AzulCMnu"
        Me.AzulCMnu.Size = New System.Drawing.Size(160, 22)
        Me.AzulCMnu.Text = "Azules"
        '
        'VerdeCMnu
        '
        Me.VerdeCMnu.Name = "VerdeCMnu"
        Me.VerdeCMnu.Size = New System.Drawing.Size(160, 22)
        Me.VerdeCMnu.Text = "Verdes"
        '
        'RosaCMnu
        '
        Me.RosaCMnu.Name = "RosaCMnu"
        Me.RosaCMnu.Size = New System.Drawing.Size(160, 22)
        Me.RosaCMnu.Text = "Rosas"
        '
        'MonocromoCMnu
        '
        Me.MonocromoCMnu.Name = "MonocromoCMnu"
        Me.MonocromoCMnu.Size = New System.Drawing.Size(160, 22)
        Me.MonocromoCMnu.Text = "Monocromático"
        '
        'SimbolosMnu
        '
        Me.SimbolosMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GlobalSMnu, Me.ManosSMnu, Me.CirculosSMnu, Me.SmileSMnu, Me.ZodiacoSMnu})
        Me.SimbolosMnu.Name = "SimbolosMnu"
        Me.SimbolosMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SimbolosMnu.Size = New System.Drawing.Size(166, 22)
        Me.SimbolosMnu.Text = "Símbolos"
        '
        'GlobalSMnu
        '
        Me.GlobalSMnu.Name = "GlobalSMnu"
        Me.GlobalSMnu.Size = New System.Drawing.Size(117, 22)
        Me.GlobalSMnu.Text = "Global"
        '
        'ManosSMnu
        '
        Me.ManosSMnu.Name = "ManosSMnu"
        Me.ManosSMnu.Size = New System.Drawing.Size(117, 22)
        Me.ManosSMnu.Text = "Manos"
        '
        'CirculosSMnu
        '
        Me.CirculosSMnu.Name = "CirculosSMnu"
        Me.CirculosSMnu.Size = New System.Drawing.Size(117, 22)
        Me.CirculosSMnu.Text = "Circulos"
        '
        'SmileSMnu
        '
        Me.SmileSMnu.Name = "SmileSMnu"
        Me.SmileSMnu.Size = New System.Drawing.Size(117, 22)
        Me.SmileSMnu.Text = "Smile"
        '
        'ZodiacoSMnu
        '
        Me.ZodiacoSMnu.Name = "ZodiacoSMnu"
        Me.ZodiacoSMnu.Size = New System.Drawing.Size(117, 22)
        Me.ZodiacoSMnu.Text = "Zodiaco"
        '
        'TiemposMnu
        '
        Me.TiemposMnu.Name = "TiemposMnu"
        Me.TiemposMnu.Size = New System.Drawing.Size(65, 20)
        Me.TiemposMnu.Text = "Tiempos"
        '
        'lblErrores
        '
        Me.lblErrores.AutoSize = True
        Me.lblErrores.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.White
        Me.lblErrores.Location = New System.Drawing.Point(279, 135)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(108, 17)
        Me.lblErrores.TabIndex = 5
        Me.lblErrores.Text = "Errores: 0"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Wingdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button1.Location = New System.Drawing.Point(480, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button8, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button10, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button11, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button12, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button13, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button14, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button15, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button16, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button17, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button18, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button19, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button20, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button21, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button22, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button23, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button24, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button25, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button26, 4, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(62, 181)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(391, 283)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.White
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn1.Enabled = False
        Me.btn1.FlatAppearance.BorderSize = 3
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btn1.Location = New System.Drawing.Point(3, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(72, 50)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "?"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button3.Location = New System.Drawing.Point(81, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 50)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "?"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button4.Location = New System.Drawing.Point(159, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 50)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "?"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 3
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button5.Location = New System.Drawing.Point(237, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 50)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "?"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button6.Location = New System.Drawing.Point(315, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 50)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "?"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Enabled = False
        Me.Button7.FlatAppearance.BorderSize = 3
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button7.Location = New System.Drawing.Point(3, 59)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(72, 50)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "?"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.Enabled = False
        Me.Button8.FlatAppearance.BorderSize = 3
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button8.Location = New System.Drawing.Point(81, 59)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(72, 50)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "?"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.Enabled = False
        Me.Button9.FlatAppearance.BorderSize = 3
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button9.Location = New System.Drawing.Point(159, 59)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(72, 50)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "?"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button10.Enabled = False
        Me.Button10.FlatAppearance.BorderSize = 3
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button10.Location = New System.Drawing.Point(237, 59)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(72, 50)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "?"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button11.Enabled = False
        Me.Button11.FlatAppearance.BorderSize = 3
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button11.Location = New System.Drawing.Point(315, 59)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(73, 50)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "?"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button12.Enabled = False
        Me.Button12.FlatAppearance.BorderSize = 3
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button12.Location = New System.Drawing.Point(3, 115)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(72, 50)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "?"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button13.Enabled = False
        Me.Button13.FlatAppearance.BorderSize = 3
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button13.Location = New System.Drawing.Point(81, 115)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(72, 50)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "?"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button14.Enabled = False
        Me.Button14.FlatAppearance.BorderSize = 3
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button14.Location = New System.Drawing.Point(159, 115)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(72, 50)
        Me.Button14.TabIndex = 12
        Me.Button14.Text = "?"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button15.Enabled = False
        Me.Button15.FlatAppearance.BorderSize = 3
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button15.Location = New System.Drawing.Point(237, 115)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(72, 50)
        Me.Button15.TabIndex = 13
        Me.Button15.Text = "?"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button16.Enabled = False
        Me.Button16.FlatAppearance.BorderSize = 3
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button16.Location = New System.Drawing.Point(315, 115)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(73, 50)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "?"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.White
        Me.Button17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button17.Enabled = False
        Me.Button17.FlatAppearance.BorderSize = 3
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button17.Location = New System.Drawing.Point(3, 171)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(72, 50)
        Me.Button17.TabIndex = 15
        Me.Button17.Text = "?"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.White
        Me.Button18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button18.Enabled = False
        Me.Button18.FlatAppearance.BorderSize = 3
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button18.Location = New System.Drawing.Point(81, 171)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(72, 50)
        Me.Button18.TabIndex = 16
        Me.Button18.Text = "?"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.White
        Me.Button19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button19.Enabled = False
        Me.Button19.FlatAppearance.BorderSize = 3
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button19.Location = New System.Drawing.Point(159, 171)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(72, 50)
        Me.Button19.TabIndex = 17
        Me.Button19.Text = "?"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.White
        Me.Button20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button20.Enabled = False
        Me.Button20.FlatAppearance.BorderSize = 3
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button20.Location = New System.Drawing.Point(237, 171)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(72, 50)
        Me.Button20.TabIndex = 18
        Me.Button20.Text = "?"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.White
        Me.Button21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button21.Enabled = False
        Me.Button21.FlatAppearance.BorderSize = 3
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button21.Location = New System.Drawing.Point(315, 171)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(73, 50)
        Me.Button21.TabIndex = 19
        Me.Button21.Text = "?"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.White
        Me.Button22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button22.Enabled = False
        Me.Button22.FlatAppearance.BorderSize = 3
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button22.Location = New System.Drawing.Point(3, 227)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(72, 53)
        Me.Button22.TabIndex = 20
        Me.Button22.Text = "?"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.White
        Me.Button23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button23.Enabled = False
        Me.Button23.FlatAppearance.BorderSize = 3
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button23.Location = New System.Drawing.Point(81, 227)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(72, 53)
        Me.Button23.TabIndex = 21
        Me.Button23.Text = "?"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.White
        Me.Button24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button24.Enabled = False
        Me.Button24.FlatAppearance.BorderSize = 3
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button24.Location = New System.Drawing.Point(159, 227)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(72, 53)
        Me.Button24.TabIndex = 22
        Me.Button24.Text = "?"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.White
        Me.Button25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button25.Enabled = False
        Me.Button25.FlatAppearance.BorderSize = 3
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button25.Location = New System.Drawing.Point(237, 227)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(72, 53)
        Me.Button25.TabIndex = 23
        Me.Button25.Text = "?"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.White
        Me.Button26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button26.Enabled = False
        Me.Button26.FlatAppearance.BorderSize = 3
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Button26.Location = New System.Drawing.Point(315, 227)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(73, 53)
        Me.Button26.TabIndex = 24
        Me.Button26.Text = "?"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(553, 473)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Orange
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1to25"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblInstrucciones As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModalidadMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumerosMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColoresMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimbolosMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiemposMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblErrores As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MulticolorCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AzulCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerdeCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonocromoCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RosaCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents GlobalSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManosSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CirculosSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmileSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZodiacoSMnu As System.Windows.Forms.ToolStripMenuItem

End Class
