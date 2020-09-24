<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearProducto
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
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.cancelarBtn = New System.Windows.Forms.Button()
        Me.precioProductoTxt = New System.Windows.Forms.TextBox()
        Me.tipoProductoCb = New System.Windows.Forms.ComboBox()
        Me.nombreProductoTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'agregarBtn
        '
        Me.agregarBtn.Location = New System.Drawing.Point(193, 200)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(106, 30)
        Me.agregarBtn.TabIndex = 15
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = True
        '
        'cancelarBtn
        '
        Me.cancelarBtn.Location = New System.Drawing.Point(317, 200)
        Me.cancelarBtn.Name = "cancelarBtn"
        Me.cancelarBtn.Size = New System.Drawing.Size(106, 30)
        Me.cancelarBtn.TabIndex = 14
        Me.cancelarBtn.Text = "Cancelar"
        Me.cancelarBtn.UseVisualStyleBackColor = True
        '
        'precioProductoTxt
        '
        Me.precioProductoTxt.Location = New System.Drawing.Point(178, 136)
        Me.precioProductoTxt.Name = "precioProductoTxt"
        Me.precioProductoTxt.Size = New System.Drawing.Size(245, 22)
        Me.precioProductoTxt.TabIndex = 13
        '
        'tipoProductoCb
        '
        Me.tipoProductoCb.FormattingEnabled = True
        Me.tipoProductoCb.Items.AddRange(New Object() {"Bebida", "Pizza"})
        Me.tipoProductoCb.Location = New System.Drawing.Point(178, 73)
        Me.tipoProductoCb.Name = "tipoProductoCb"
        Me.tipoProductoCb.Size = New System.Drawing.Size(245, 24)
        Me.tipoProductoCb.TabIndex = 12
        '
        'nombreProductoTxt
        '
        Me.nombreProductoTxt.Location = New System.Drawing.Point(178, 23)
        Me.nombreProductoTxt.Name = "nombreProductoTxt"
        Me.nombreProductoTxt.Size = New System.Drawing.Size(245, 22)
        Me.nombreProductoTxt.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Precio: Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo de producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre del producto"
        '
        'CrearProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 275)
        Me.Controls.Add(Me.agregarBtn)
        Me.Controls.Add(Me.cancelarBtn)
        Me.Controls.Add(Me.precioProductoTxt)
        Me.Controls.Add(Me.tipoProductoCb)
        Me.Controls.Add(Me.nombreProductoTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents agregarBtn As Button
    Friend WithEvents cancelarBtn As Button
    Friend WithEvents precioProductoTxt As TextBox
    Friend WithEvents tipoProductoCb As ComboBox
    Friend WithEvents nombreProductoTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
