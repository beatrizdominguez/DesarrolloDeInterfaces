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
        Me.LblRes = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.BtnRes = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblRes
        '
        Me.LblRes.AutoSize = True
        Me.LblRes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRes.Location = New System.Drawing.Point(17, 87)
        Me.LblRes.Name = "LblRes"
        Me.LblRes.Size = New System.Drawing.Size(0, 19)
        Me.LblRes.TabIndex = 0
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(15, 21)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(180, 20)
        Me.TxtNum.TabIndex = 1
        Me.TxtNum.Text = "Introduce un número"
        '
        'BtnRes
        '
        Me.BtnRes.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnRes.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRes.Location = New System.Drawing.Point(224, 21)
        Me.BtnRes.Name = "BtnRes"
        Me.BtnRes.Size = New System.Drawing.Size(110, 39)
        Me.BtnRes.TabIndex = 2
        Me.BtnRes.Text = "Calcular"
        Me.BtnRes.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(227, 76)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(107, 30)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Borrar"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 149)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnRes)
        Me.Controls.Add(Me.TxtNum)
        Me.Controls.Add(Me.LblRes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblRes As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents BtnRes As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button

End Class
