<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearEmpleado
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
        Me.cancelarBtn = New System.Windows.Forms.Button()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.sucursalCb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.contraseniaTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.correoTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cancelarBtn
        '
        Me.cancelarBtn.Location = New System.Drawing.Point(221, 344)
        Me.cancelarBtn.Name = "cancelarBtn"
        Me.cancelarBtn.Size = New System.Drawing.Size(107, 29)
        Me.cancelarBtn.TabIndex = 23
        Me.cancelarBtn.Text = "Cancelar"
        Me.cancelarBtn.UseVisualStyleBackColor = True
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"Administrador", "Empleado"})
        Me.cbRol.Location = New System.Drawing.Point(45, 284)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(283, 24)
        Me.cbRol.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Rol"
        '
        'agregarBtn
        '
        Me.agregarBtn.Location = New System.Drawing.Point(102, 344)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(107, 29)
        Me.agregarBtn.TabIndex = 20
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = True
        '
        'sucursalCb
        '
        Me.sucursalCb.FormattingEnabled = True
        Me.sucursalCb.Location = New System.Drawing.Point(45, 224)
        Me.sucursalCb.Name = "sucursalCb"
        Me.sucursalCb.Size = New System.Drawing.Size(283, 24)
        Me.sucursalCb.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Sucursal"
        '
        'contraseniaTxt
        '
        Me.contraseniaTxt.Location = New System.Drawing.Point(45, 155)
        Me.contraseniaTxt.Name = "contraseniaTxt"
        Me.contraseniaTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseniaTxt.Size = New System.Drawing.Size(283, 22)
        Me.contraseniaTxt.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contrasenia"
        '
        'correoTxt
        '
        Me.correoTxt.Location = New System.Drawing.Point(45, 86)
        Me.correoTxt.Name = "correoTxt"
        Me.correoTxt.Size = New System.Drawing.Size(283, 22)
        Me.correoTxt.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Correo"
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(45, 28)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(283, 22)
        Me.nombreTxt.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre del empleado"
        '
        'CrearEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 403)
        Me.Controls.Add(Me.cancelarBtn)
        Me.Controls.Add(Me.cbRol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.agregarBtn)
        Me.Controls.Add(Me.sucursalCb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.contraseniaTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.correoTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearEmpleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelarBtn As Button
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents agregarBtn As Button
    Friend WithEvents sucursalCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents contraseniaTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents correoTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Label1 As Label
End Class
