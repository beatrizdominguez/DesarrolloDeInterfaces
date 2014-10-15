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
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.TxtIntro = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LstNum = New System.Windows.Forms.ListBox()
        Me.LstPal = New System.Windows.Forms.ListBox()
        Me.ChkNum = New System.Windows.Forms.CheckBox()
        Me.ChkPal = New System.Windows.Forms.CheckBox()
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.BtnO = New System.Windows.Forms.Button()
        Me.BtnOI = New System.Windows.Forms.Button()
        Me.BtnBr = New System.Windows.Forms.Button()
        Me.BtnMedia = New System.Windows.Forms.Button()
        Me.LblMedia = New System.Windows.Forms.Label()
        Me.Grb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(12, 29)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(140, 20)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Introduce un valor:"
        '
        'TxtIntro
        '
        Me.TxtIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIntro.Location = New System.Drawing.Point(161, 29)
        Me.TxtIntro.Name = "TxtIntro"
        Me.TxtIntro.Size = New System.Drawing.Size(235, 22)
        Me.TxtIntro.TabIndex = 1
        Me.TxtIntro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(134, 77)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(140, 36)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Añadir"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LstNum
        '
        Me.LstNum.FormattingEnabled = True
        Me.LstNum.Location = New System.Drawing.Point(21, 110)
        Me.LstNum.Name = "LstNum"
        Me.LstNum.Size = New System.Drawing.Size(102, 225)
        Me.LstNum.TabIndex = 3
        '
        'LstPal
        '
        Me.LstPal.FormattingEnabled = True
        Me.LstPal.Location = New System.Drawing.Point(294, 110)
        Me.LstPal.Name = "LstPal"
        Me.LstPal.Size = New System.Drawing.Size(102, 225)
        Me.LstPal.TabIndex = 3
        '
        'ChkNum
        '
        Me.ChkNum.AutoSize = True
        Me.ChkNum.Location = New System.Drawing.Point(21, 22)
        Me.ChkNum.Name = "ChkNum"
        Me.ChkNum.Size = New System.Drawing.Size(68, 17)
        Me.ChkNum.TabIndex = 4
        Me.ChkNum.Text = "Números"
        Me.ChkNum.UseVisualStyleBackColor = True
        '
        'ChkPal
        '
        Me.ChkPal.AutoSize = True
        Me.ChkPal.Location = New System.Drawing.Point(21, 56)
        Me.ChkPal.Name = "ChkPal"
        Me.ChkPal.Size = New System.Drawing.Size(67, 17)
        Me.ChkPal.TabIndex = 4
        Me.ChkPal.Text = "Palabras"
        Me.ChkPal.UseVisualStyleBackColor = True
        '
        'Grb1
        '
        Me.Grb1.Controls.Add(Me.ChkPal)
        Me.Grb1.Controls.Add(Me.ChkNum)
        Me.Grb1.Location = New System.Drawing.Point(140, 133)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(122, 87)
        Me.Grb1.TabIndex = 5
        Me.Grb1.TabStop = False
        Me.Grb1.Text = "Seleccionar lista"
        '
        'BtnO
        '
        Me.BtnO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnO.Location = New System.Drawing.Point(137, 237)
        Me.BtnO.Name = "BtnO"
        Me.BtnO.Size = New System.Drawing.Size(136, 26)
        Me.BtnO.TabIndex = 6
        Me.BtnO.Text = "Ordenar"
        Me.BtnO.UseVisualStyleBackColor = True
        '
        'BtnOI
        '
        Me.BtnOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOI.Location = New System.Drawing.Point(137, 269)
        Me.BtnOI.Name = "BtnOI"
        Me.BtnOI.Size = New System.Drawing.Size(136, 26)
        Me.BtnOI.TabIndex = 6
        Me.BtnOI.Text = "Orden inverso"
        Me.BtnOI.UseVisualStyleBackColor = True
        '
        'BtnBr
        '
        Me.BtnBr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBr.Location = New System.Drawing.Point(137, 301)
        Me.BtnBr.Name = "BtnBr"
        Me.BtnBr.Size = New System.Drawing.Size(136, 26)
        Me.BtnBr.TabIndex = 6
        Me.BtnBr.Text = "Borrar último"
        Me.BtnBr.UseVisualStyleBackColor = True
        '
        'BtnMedia
        '
        Me.BtnMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedia.Location = New System.Drawing.Point(137, 333)
        Me.BtnMedia.Name = "BtnMedia"
        Me.BtnMedia.Size = New System.Drawing.Size(136, 26)
        Me.BtnMedia.TabIndex = 6
        Me.BtnMedia.Text = "Media"
        Me.BtnMedia.UseVisualStyleBackColor = True
        '
        'LblMedia
        '
        Me.LblMedia.AutoSize = True
        Me.LblMedia.Location = New System.Drawing.Point(32, 358)
        Me.LblMedia.Name = "LblMedia"
        Me.LblMedia.Size = New System.Drawing.Size(36, 13)
        Me.LblMedia.TabIndex = 7
        Me.LblMedia.Text = "Media"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 414)
        Me.Controls.Add(Me.LblMedia)
        Me.Controls.Add(Me.BtnMedia)
        Me.Controls.Add(Me.BtnBr)
        Me.Controls.Add(Me.BtnOI)
        Me.Controls.Add(Me.BtnO)
        Me.Controls.Add(Me.Grb1)
        Me.Controls.Add(Me.LstPal)
        Me.Controls.Add(Me.LstNum)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtIntro)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Grb1.ResumeLayout(False)
        Me.Grb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents TxtIntro As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LstNum As System.Windows.Forms.ListBox
    Friend WithEvents LstPal As System.Windows.Forms.ListBox
    Friend WithEvents ChkNum As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPal As System.Windows.Forms.CheckBox
    Friend WithEvents Grb1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnO As System.Windows.Forms.Button
    Friend WithEvents BtnOI As System.Windows.Forms.Button
    Friend WithEvents BtnBr As System.Windows.Forms.Button
    Friend WithEvents BtnMedia As System.Windows.Forms.Button
    Friend WithEvents LblMedia As System.Windows.Forms.Label

End Class
