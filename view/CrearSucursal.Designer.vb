<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearSucursal
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
        Me.direccionRtx = New System.Windows.Forms.RichTextBox()
        Me.codigoTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'agregarBtn
        '
        Me.agregarBtn.Location = New System.Drawing.Point(255, 227)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(95, 35)
        Me.agregarBtn.TabIndex = 11
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = True
        '
        'cancelarBtn
        '
        Me.cancelarBtn.Location = New System.Drawing.Point(366, 227)
        Me.cancelarBtn.Name = "cancelarBtn"
        Me.cancelarBtn.Size = New System.Drawing.Size(95, 35)
        Me.cancelarBtn.TabIndex = 10
        Me.cancelarBtn.Text = "Cancelar"
        Me.cancelarBtn.UseVisualStyleBackColor = True
        '
        'direccionRtx
        '
        Me.direccionRtx.Location = New System.Drawing.Point(22, 87)
        Me.direccionRtx.Name = "direccionRtx"
        Me.direccionRtx.Size = New System.Drawing.Size(439, 96)
        Me.direccionRtx.TabIndex = 9
        Me.direccionRtx.Text = ""
        '
        'codigoTxt
        '
        Me.codigoTxt.Location = New System.Drawing.Point(202, 15)
        Me.codigoTxt.Name = "codigoTxt"
        Me.codigoTxt.Size = New System.Drawing.Size(259, 22)
        Me.codigoTxt.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Direccion de la sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo de la sucursal"
        '
        'CrearSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 276)
        Me.Controls.Add(Me.agregarBtn)
        Me.Controls.Add(Me.cancelarBtn)
        Me.Controls.Add(Me.direccionRtx)
        Me.Controls.Add(Me.codigoTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearSucursal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents agregarBtn As Button
    Friend WithEvents cancelarBtn As Button
    Friend WithEvents direccionRtx As RichTextBox
    Friend WithEvents codigoTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
