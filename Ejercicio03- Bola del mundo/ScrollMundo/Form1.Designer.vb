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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.hsb = New System.Windows.Forms.HScrollBar()
        Me.vsb = New System.Windows.Forms.VScrollBar()
        Me.picMundo = New System.Windows.Forms.PictureBox()
        CType(Me.picMundo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hsb
        '
        Me.hsb.Location = New System.Drawing.Point(42, 5)
        Me.hsb.Maximum = 500
        Me.hsb.Minimum = 100
        Me.hsb.Name = "hsb"
        Me.hsb.Size = New System.Drawing.Size(503, 27)
        Me.hsb.TabIndex = 0
        Me.hsb.Value = 100
        '
        'vsb
        '
        Me.vsb.Location = New System.Drawing.Point(9, 5)
        Me.vsb.Maximum = 500
        Me.vsb.Minimum = 100
        Me.vsb.Name = "vsb"
        Me.vsb.Size = New System.Drawing.Size(28, 402)
        Me.vsb.TabIndex = 1
        Me.vsb.Value = 100
        '
        'picMundo
        '
        Me.picMundo.Image = CType(resources.GetObject("picMundo.Image"), System.Drawing.Image)
        Me.picMundo.InitialImage = Nothing
        Me.picMundo.Location = New System.Drawing.Point(66, 50)
        Me.picMundo.Name = "picMundo"
        Me.picMundo.Size = New System.Drawing.Size(217, 205)
        Me.picMundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMundo.TabIndex = 2
        Me.picMundo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 416)
        Me.Controls.Add(Me.picMundo)
        Me.Controls.Add(Me.vsb)
        Me.Controls.Add(Me.hsb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMundo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hsb As System.Windows.Forms.HScrollBar
    Friend WithEvents vsb As System.Windows.Forms.VScrollBar
    Friend WithEvents picMundo As System.Windows.Forms.PictureBox

End Class
