<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarYReemplazar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarYReemplazar))
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.LblReplace = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.TxtReplace = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnReplace = New System.Windows.Forms.Button()
        Me.BtnReplaceAll = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblBuscar
        '
        Me.LblBuscar.AutoSize = True
        Me.LblBuscar.Location = New System.Drawing.Point(32, 20)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.LblBuscar.TabIndex = 0
        Me.LblBuscar.Text = "Buscar:"
        '
        'LblReplace
        '
        Me.LblReplace.AutoSize = True
        Me.LblReplace.Location = New System.Drawing.Point(23, 49)
        Me.LblReplace.Name = "LblReplace"
        Me.LblReplace.Size = New System.Drawing.Size(66, 26)
        Me.LblReplace.TabIndex = 0
        Me.LblReplace.Text = " Reemplazar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " por:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(95, 17)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(233, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'TxtReplace
        '
        Me.TxtReplace.Location = New System.Drawing.Point(95, 55)
        Me.TxtReplace.Name = "TxtReplace"
        Me.TxtReplace.Size = New System.Drawing.Size(233, 20)
        Me.TxtReplace.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(367, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(117, 20)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar siguiente"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnReplace
        '
        Me.BtnReplace.Location = New System.Drawing.Point(367, 45)
        Me.BtnReplace.Name = "BtnReplace"
        Me.BtnReplace.Size = New System.Drawing.Size(117, 20)
        Me.BtnReplace.TabIndex = 4
        Me.BtnReplace.Text = "Reemplazar"
        Me.BtnReplace.UseVisualStyleBackColor = True
        '
        'BtnReplaceAll
        '
        Me.BtnReplaceAll.Location = New System.Drawing.Point(367, 86)
        Me.BtnReplaceAll.Name = "BtnReplaceAll"
        Me.BtnReplaceAll.Size = New System.Drawing.Size(117, 20)
        Me.BtnReplaceAll.TabIndex = 5
        Me.BtnReplaceAll.Text = "Reemplazar todo"
        Me.BtnReplaceAll.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(367, 124)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(117, 20)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "stPos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Leng"
        '
        'BuscarYReemplazar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 177)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnReplaceAll)
        Me.Controls.Add(Me.BtnReplace)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtReplace)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LblReplace)
        Me.Controls.Add(Me.LblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarYReemplazar"
        Me.Text = "Buscar y reemplazar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblBuscar As System.Windows.Forms.Label
    Friend WithEvents LblReplace As System.Windows.Forms.Label
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents TxtReplace As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnReplace As System.Windows.Forms.Button
    Friend WithEvents BtnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
