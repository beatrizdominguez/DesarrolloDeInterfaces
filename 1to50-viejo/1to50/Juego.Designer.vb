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
        Me.MonocromoCMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimbolosMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiemposMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn15 = New System.Windows.Forms.Button()
        Me.btn14 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn16 = New System.Windows.Forms.Button()
        Me.btn17 = New System.Windows.Forms.Button()
        Me.btn18 = New System.Windows.Forms.Button()
        Me.btn19 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn25 = New System.Windows.Forms.Button()
        Me.btn24 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnInicio.Location = New System.Drawing.Point(130, 107)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(155, 37)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Empezar"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(349, 107)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 20)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00:00:00"
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.Location = New System.Drawing.Point(12, 50)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(308, 20)
        Me.lblInstrucciones.TabIndex = 2
        Me.lblInstrucciones.Text = "Ordena los números lo más rápido posible."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModalidadMnu, Me.TiemposMnu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(442, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModalidadMnu
        '
        Me.ModalidadMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumerosMnu, Me.ColoresMnu, Me.SimbolosMnu})
        Me.ModalidadMnu.Name = "ModalidadMnu"
        Me.ModalidadMnu.Size = New System.Drawing.Size(87, 20)
        Me.ModalidadMnu.Text = "Modalidades"
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
        Me.ColoresMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MulticolorCMnu, Me.AzulCMnu, Me.VerdeCMnu, Me.MonocromoCMnu})
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
        'MonocromoCMnu
        '
        Me.MonocromoCMnu.Name = "MonocromoCMnu"
        Me.MonocromoCMnu.Size = New System.Drawing.Size(160, 22)
        Me.MonocromoCMnu.Text = "Monocromático"
        '
        'SimbolosMnu
        '
        Me.SimbolosMnu.Name = "SimbolosMnu"
        Me.SimbolosMnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SimbolosMnu.Size = New System.Drawing.Size(166, 22)
        Me.SimbolosMnu.Text = "Símbolos"
        '
        'TiemposMnu
        '
        Me.TiemposMnu.Name = "TiemposMnu"
        Me.TiemposMnu.Size = New System.Drawing.Size(65, 20)
        Me.TiemposMnu.Text = "Tiempos"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61856!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61856!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61856!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52577!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61856!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn9, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn10, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn15, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn14, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn13, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn12, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn16, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn17, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn18, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn19, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn20, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn25, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn24, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn23, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn22, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn21, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 177)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 322)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btn1
        '
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn1.Enabled = False
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(3, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(85, 58)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "?"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn2.Enabled = False
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(94, 3)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(85, 58)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "?"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn3.Enabled = False
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(185, 3)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(85, 58)
        Me.btn3.TabIndex = 1
        Me.btn3.Text = "?"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn4.Enabled = False
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(276, 3)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(71, 58)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "?"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn5.Enabled = False
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(353, 3)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(86, 58)
        Me.btn5.TabIndex = 1
        Me.btn5.Text = "?"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn6.Enabled = False
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(3, 67)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(85, 58)
        Me.btn6.TabIndex = 2
        Me.btn6.Text = "?"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn7.Enabled = False
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(94, 67)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(85, 58)
        Me.btn7.TabIndex = 2
        Me.btn7.Text = "?"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn8.Enabled = False
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(185, 67)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(85, 58)
        Me.btn8.TabIndex = 2
        Me.btn8.Text = "?"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn9.Enabled = False
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(276, 67)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(71, 58)
        Me.btn9.TabIndex = 2
        Me.btn9.Text = "?"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn10.Enabled = False
        Me.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10.ForeColor = System.Drawing.Color.White
        Me.btn10.Location = New System.Drawing.Point(353, 67)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(86, 58)
        Me.btn10.TabIndex = 2
        Me.btn10.Text = "?"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn15
        '
        Me.btn15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn15.Enabled = False
        Me.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn15.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn15.ForeColor = System.Drawing.Color.White
        Me.btn15.Location = New System.Drawing.Point(353, 131)
        Me.btn15.Name = "btn15"
        Me.btn15.Size = New System.Drawing.Size(86, 58)
        Me.btn15.TabIndex = 2
        Me.btn15.Text = "?"
        Me.btn15.UseVisualStyleBackColor = True
        '
        'btn14
        '
        Me.btn14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn14.Enabled = False
        Me.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn14.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn14.ForeColor = System.Drawing.Color.White
        Me.btn14.Location = New System.Drawing.Point(276, 131)
        Me.btn14.Name = "btn14"
        Me.btn14.Size = New System.Drawing.Size(71, 58)
        Me.btn14.TabIndex = 2
        Me.btn14.Text = "?"
        Me.btn14.UseVisualStyleBackColor = True
        '
        'btn13
        '
        Me.btn13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn13.Enabled = False
        Me.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn13.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn13.ForeColor = System.Drawing.Color.White
        Me.btn13.Location = New System.Drawing.Point(185, 131)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(85, 58)
        Me.btn13.TabIndex = 2
        Me.btn13.Text = "?"
        Me.btn13.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn12.Enabled = False
        Me.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn12.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn12.ForeColor = System.Drawing.Color.White
        Me.btn12.Location = New System.Drawing.Point(94, 131)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(85, 58)
        Me.btn12.TabIndex = 2
        Me.btn12.Text = "?"
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn11
        '
        Me.btn11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn11.Enabled = False
        Me.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn11.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn11.ForeColor = System.Drawing.Color.White
        Me.btn11.Location = New System.Drawing.Point(3, 131)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(85, 58)
        Me.btn11.TabIndex = 2
        Me.btn11.Text = "?"
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn16
        '
        Me.btn16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn16.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn16.ForeColor = System.Drawing.Color.White
        Me.btn16.Location = New System.Drawing.Point(3, 195)
        Me.btn16.Name = "btn16"
        Me.btn16.Size = New System.Drawing.Size(85, 58)
        Me.btn16.TabIndex = 2
        Me.btn16.Text = "?"
        Me.btn16.UseVisualStyleBackColor = True
        '
        'btn17
        '
        Me.btn17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn17.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn17.ForeColor = System.Drawing.Color.White
        Me.btn17.Location = New System.Drawing.Point(94, 195)
        Me.btn17.Name = "btn17"
        Me.btn17.Size = New System.Drawing.Size(85, 58)
        Me.btn17.TabIndex = 2
        Me.btn17.Text = "?"
        Me.btn17.UseVisualStyleBackColor = True
        '
        'btn18
        '
        Me.btn18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn18.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn18.ForeColor = System.Drawing.Color.White
        Me.btn18.Location = New System.Drawing.Point(185, 195)
        Me.btn18.Name = "btn18"
        Me.btn18.Size = New System.Drawing.Size(85, 58)
        Me.btn18.TabIndex = 2
        Me.btn18.Text = "?"
        Me.btn18.UseVisualStyleBackColor = True
        '
        'btn19
        '
        Me.btn19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn19.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn19.ForeColor = System.Drawing.Color.White
        Me.btn19.Location = New System.Drawing.Point(276, 195)
        Me.btn19.Name = "btn19"
        Me.btn19.Size = New System.Drawing.Size(71, 58)
        Me.btn19.TabIndex = 2
        Me.btn19.Text = "?"
        Me.btn19.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn20.ForeColor = System.Drawing.Color.White
        Me.btn20.Location = New System.Drawing.Point(353, 195)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(86, 58)
        Me.btn20.TabIndex = 2
        Me.btn20.Text = "?"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn25
        '
        Me.btn25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn25.Enabled = False
        Me.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn25.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn25.ForeColor = System.Drawing.Color.White
        Me.btn25.Location = New System.Drawing.Point(353, 259)
        Me.btn25.Name = "btn25"
        Me.btn25.Size = New System.Drawing.Size(86, 60)
        Me.btn25.TabIndex = 2
        Me.btn25.Text = "?"
        Me.btn25.UseVisualStyleBackColor = True
        '
        'btn24
        '
        Me.btn24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn24.Enabled = False
        Me.btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn24.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn24.ForeColor = System.Drawing.Color.White
        Me.btn24.Location = New System.Drawing.Point(276, 259)
        Me.btn24.Name = "btn24"
        Me.btn24.Size = New System.Drawing.Size(71, 60)
        Me.btn24.TabIndex = 2
        Me.btn24.Text = "?"
        Me.btn24.UseVisualStyleBackColor = True
        '
        'btn23
        '
        Me.btn23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn23.Enabled = False
        Me.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn23.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn23.ForeColor = System.Drawing.Color.White
        Me.btn23.Location = New System.Drawing.Point(185, 259)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(85, 60)
        Me.btn23.TabIndex = 2
        Me.btn23.Text = "?"
        Me.btn23.UseVisualStyleBackColor = True
        '
        'btn22
        '
        Me.btn22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn22.Enabled = False
        Me.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn22.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn22.ForeColor = System.Drawing.Color.White
        Me.btn22.Location = New System.Drawing.Point(94, 259)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(85, 60)
        Me.btn22.TabIndex = 2
        Me.btn22.Text = "?"
        Me.btn22.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn21.Enabled = False
        Me.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn21.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn21.ForeColor = System.Drawing.Color.White
        Me.btn21.Location = New System.Drawing.Point(3, 259)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(85, 60)
        Me.btn21.TabIndex = 2
        Me.btn21.Text = "?"
        Me.btn21.UseVisualStyleBackColor = True
        '
        'lblErrores
        '
        Me.lblErrores.AutoSize = True
        Me.lblErrores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.Location = New System.Drawing.Point(359, 141)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(78, 20)
        Me.lblErrores.TabIndex = 5
        Me.lblErrores.Text = "Errores: 0"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(442, 499)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Juego"
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lblErrores As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btn15 As System.Windows.Forms.Button
    Friend WithEvents btn14 As System.Windows.Forms.Button
    Friend WithEvents btn13 As System.Windows.Forms.Button
    Friend WithEvents btn12 As System.Windows.Forms.Button
    Friend WithEvents btn11 As System.Windows.Forms.Button
    Friend WithEvents btn16 As System.Windows.Forms.Button
    Friend WithEvents btn17 As System.Windows.Forms.Button
    Friend WithEvents btn18 As System.Windows.Forms.Button
    Friend WithEvents btn19 As System.Windows.Forms.Button
    Friend WithEvents btn20 As System.Windows.Forms.Button
    Friend WithEvents btn25 As System.Windows.Forms.Button
    Friend WithEvents btn24 As System.Windows.Forms.Button
    Friend WithEvents btn23 As System.Windows.Forms.Button
    Friend WithEvents btn22 As System.Windows.Forms.Button
    Friend WithEvents btn21 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MulticolorCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AzulCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerdeCMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonocromoCMnu As System.Windows.Forms.ToolStripMenuItem

End Class
