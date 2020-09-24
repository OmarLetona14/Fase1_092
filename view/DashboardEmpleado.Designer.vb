<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardEmpleado
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
        Me.empleadoTb = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ordenBtn = New System.Windows.Forms.Button()
        Me.limpiarBtn = New System.Windows.Forms.Button()
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.cantidadTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.productoCb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ordenLv = New System.Windows.Forms.ListView()
        Me.nombreProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipoProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cantidadProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subtotalProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.telefonoClienteTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nombreClienteTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cerrarSesionBtn = New System.Windows.Forms.Button()
        Me.nombreTxt = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.direccionTxt = New System.Windows.Forms.Label()
        Me.codigoTxt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ordenSBtn = New System.Windows.Forms.Button()
        Me.simulacionLv = New System.Windows.Forms.ListView()
        Me.NombreCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumeroBebidas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumeroPizzas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TelefonoCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcompra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.simulacionBtn = New System.Windows.Forms.Button()
        Me.cantidadSTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cerrarBtn = New System.Windows.Forms.Button()
        Me.nombreSTxt = New System.Windows.Forms.Label()
        Me.direccionSTxt = New System.Windows.Forms.Label()
        Me.codigoSTxt = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.empleadoTb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'empleadoTb
        '
        Me.empleadoTb.Controls.Add(Me.TabPage1)
        Me.empleadoTb.Controls.Add(Me.TabPage2)
        Me.empleadoTb.Location = New System.Drawing.Point(12, 12)
        Me.empleadoTb.Name = "empleadoTb"
        Me.empleadoTb.SelectedIndex = 0
        Me.empleadoTb.Size = New System.Drawing.Size(985, 510)
        Me.empleadoTb.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTotal)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ordenBtn)
        Me.TabPage1.Controls.Add(Me.limpiarBtn)
        Me.TabPage1.Controls.Add(Me.agregarBtn)
        Me.TabPage1.Controls.Add(Me.cantidadTxt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.productoCb)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ordenLv)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(977, 481)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(538, 442)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 17)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(462, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total"
        '
        'ordenBtn
        '
        Me.ordenBtn.Location = New System.Drawing.Point(11, 417)
        Me.ordenBtn.Name = "ordenBtn"
        Me.ordenBtn.Size = New System.Drawing.Size(218, 42)
        Me.ordenBtn.TabIndex = 9
        Me.ordenBtn.Text = "Realizar orden"
        Me.ordenBtn.UseVisualStyleBackColor = True
        '
        'limpiarBtn
        '
        Me.limpiarBtn.Location = New System.Drawing.Point(128, 343)
        Me.limpiarBtn.Name = "limpiarBtn"
        Me.limpiarBtn.Size = New System.Drawing.Size(100, 41)
        Me.limpiarBtn.TabIndex = 8
        Me.limpiarBtn.Text = "Limpiar"
        Me.limpiarBtn.UseVisualStyleBackColor = True
        '
        'agregarBtn
        '
        Me.agregarBtn.Location = New System.Drawing.Point(7, 343)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(102, 41)
        Me.agregarBtn.TabIndex = 7
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = True
        '
        'cantidadTxt
        '
        Me.cantidadTxt.Location = New System.Drawing.Point(7, 304)
        Me.cantidadTxt.Name = "cantidadTxt"
        Me.cantidadTxt.Size = New System.Drawing.Size(222, 22)
        Me.cantidadTxt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad"
        '
        'productoCb
        '
        Me.productoCb.FormattingEnabled = True
        Me.productoCb.Location = New System.Drawing.Point(7, 248)
        Me.productoCb.Name = "productoCb"
        Me.productoCb.Size = New System.Drawing.Size(222, 24)
        Me.productoCb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Producto"
        '
        'ordenLv
        '
        Me.ordenLv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nombreProducto, Me.tipoProducto, Me.cantidadProducto, Me.subtotalProducto})
        Me.ordenLv.GridLines = True
        Me.ordenLv.HideSelection = False
        Me.ordenLv.Location = New System.Drawing.Point(258, 227)
        Me.ordenLv.Name = "ordenLv"
        Me.ordenLv.Size = New System.Drawing.Size(691, 206)
        Me.ordenLv.TabIndex = 2
        Me.ordenLv.UseCompatibleStateImageBehavior = False
        Me.ordenLv.View = System.Windows.Forms.View.Details
        '
        'nombreProducto
        '
        Me.nombreProducto.Text = "Producto"
        Me.nombreProducto.Width = 125
        '
        'tipoProducto
        '
        Me.tipoProducto.Text = "Tipo"
        Me.tipoProducto.Width = 125
        '
        'cantidadProducto
        '
        Me.cantidadProducto.Text = "Cantidad"
        Me.cantidadProducto.Width = 125
        '
        'subtotalProducto
        '
        Me.subtotalProducto.Text = "Subtotal"
        Me.subtotalProducto.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.telefonoClienteTxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.nombreClienteTxt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(942, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'telefonoClienteTxt
        '
        Me.telefonoClienteTxt.Location = New System.Drawing.Point(534, 53)
        Me.telefonoClienteTxt.Name = "telefonoClienteTxt"
        Me.telefonoClienteTxt.Size = New System.Drawing.Size(379, 22)
        Me.telefonoClienteTxt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(531, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Telefono del cliente"
        '
        'nombreClienteTxt
        '
        Me.nombreClienteTxt.Location = New System.Drawing.Point(16, 53)
        Me.nombreClienteTxt.Name = "nombreClienteTxt"
        Me.nombreClienteTxt.Size = New System.Drawing.Size(400, 22)
        Me.nombreClienteTxt.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre del cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cerrarSesionBtn)
        Me.GroupBox1.Controls.Add(Me.nombreTxt)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.direccionTxt)
        Me.GroupBox1.Controls.Add(Me.codigoTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la sucursal"
        '
        'cerrarSesionBtn
        '
        Me.cerrarSesionBtn.Location = New System.Drawing.Point(784, 21)
        Me.cerrarSesionBtn.Name = "cerrarSesionBtn"
        Me.cerrarSesionBtn.Size = New System.Drawing.Size(144, 34)
        Me.cerrarSesionBtn.TabIndex = 6
        Me.cerrarSesionBtn.Text = "Cerrar sesion"
        Me.cerrarSesionBtn.UseVisualStyleBackColor = True
        '
        'nombreTxt
        '
        Me.nombreTxt.AutoSize = True
        Me.nombreTxt.Location = New System.Drawing.Point(607, 18)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(59, 17)
        Me.nombreTxt.TabIndex = 5
        Me.nombreTxt.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(454, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nombre del empleado"
        '
        'direccionTxt
        '
        Me.direccionTxt.AutoSize = True
        Me.direccionTxt.Location = New System.Drawing.Point(178, 67)
        Me.direccionTxt.Name = "direccionTxt"
        Me.direccionTxt.Size = New System.Drawing.Size(59, 17)
        Me.direccionTxt.TabIndex = 3
        Me.direccionTxt.Text = "Label10"
        '
        'codigoTxt
        '
        Me.codigoTxt.AutoSize = True
        Me.codigoTxt.Location = New System.Drawing.Point(175, 31)
        Me.codigoTxt.Name = "codigoTxt"
        Me.codigoTxt.Size = New System.Drawing.Size(51, 17)
        Me.codigoTxt.TabIndex = 2
        Me.codigoTxt.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Direccion de la sucursal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Codigo de la sucursal"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ordenSBtn)
        Me.TabPage2.Controls.Add(Me.simulacionLv)
        Me.TabPage2.Controls.Add(Me.simulacionBtn)
        Me.TabPage2.Controls.Add(Me.cantidadSTxt)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(977, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ordenSBtn
        '
        Me.ordenSBtn.Location = New System.Drawing.Point(400, 442)
        Me.ordenSBtn.Name = "ordenSBtn"
        Me.ordenSBtn.Size = New System.Drawing.Size(218, 32)
        Me.ordenSBtn.TabIndex = 5
        Me.ordenSBtn.Text = "Realizar orden"
        Me.ordenSBtn.UseVisualStyleBackColor = True
        '
        'simulacionLv
        '
        Me.simulacionLv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NombreCliente, Me.NumeroBebidas, Me.NumeroPizzas, Me.TelefonoCliente, Me.totalcompra})
        Me.simulacionLv.FullRowSelect = True
        Me.simulacionLv.GridLines = True
        Me.simulacionLv.HideSelection = False
        Me.simulacionLv.Location = New System.Drawing.Point(7, 166)
        Me.simulacionLv.MultiSelect = False
        Me.simulacionLv.Name = "simulacionLv"
        Me.simulacionLv.Size = New System.Drawing.Size(964, 270)
        Me.simulacionLv.TabIndex = 4
        Me.simulacionLv.UseCompatibleStateImageBehavior = False
        Me.simulacionLv.View = System.Windows.Forms.View.Details
        '
        'NombreCliente
        '
        Me.NombreCliente.Text = "Nombre del cliente"
        Me.NombreCliente.Width = 150
        '
        'NumeroBebidas
        '
        Me.NumeroBebidas.Text = "Numero de bebidas"
        Me.NumeroBebidas.Width = 150
        '
        'NumeroPizzas
        '
        Me.NumeroPizzas.Text = "Numero de pizzas"
        Me.NumeroPizzas.Width = 150
        '
        'TelefonoCliente
        '
        Me.TelefonoCliente.Text = "Telefono del cliente"
        Me.TelefonoCliente.Width = 150
        '
        'totalcompra
        '
        Me.totalcompra.Text = "Total"
        Me.totalcompra.Width = 150
        '
        'simulacionBtn
        '
        Me.simulacionBtn.Location = New System.Drawing.Point(400, 127)
        Me.simulacionBtn.Name = "simulacionBtn"
        Me.simulacionBtn.Size = New System.Drawing.Size(190, 28)
        Me.simulacionBtn.TabIndex = 3
        Me.simulacionBtn.Text = "Empezar simulacion"
        Me.simulacionBtn.UseVisualStyleBackColor = True
        '
        'cantidadSTxt
        '
        Me.cantidadSTxt.Location = New System.Drawing.Point(218, 133)
        Me.cantidadSTxt.Name = "cantidadSTxt"
        Me.cantidadSTxt.Size = New System.Drawing.Size(148, 22)
        Me.cantidadSTxt.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cantidad de ordenes a producir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cerrarBtn)
        Me.GroupBox3.Controls.Add(Me.nombreSTxt)
        Me.GroupBox3.Controls.Add(Me.direccionSTxt)
        Me.GroupBox3.Controls.Add(Me.codigoSTxt)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(967, 110)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la sucursal"
        '
        'cerrarBtn
        '
        Me.cerrarBtn.Location = New System.Drawing.Point(818, 21)
        Me.cerrarBtn.Name = "cerrarBtn"
        Me.cerrarBtn.Size = New System.Drawing.Size(130, 26)
        Me.cerrarBtn.TabIndex = 8
        Me.cerrarBtn.Text = "Cerrar sesion"
        Me.cerrarBtn.UseVisualStyleBackColor = True
        '
        'nombreSTxt
        '
        Me.nombreSTxt.AutoSize = True
        Me.nombreSTxt.Location = New System.Drawing.Point(669, 66)
        Me.nombreSTxt.Name = "nombreSTxt"
        Me.nombreSTxt.Size = New System.Drawing.Size(84, 17)
        Me.nombreSTxt.TabIndex = 7
        Me.nombreSTxt.Text = "nombreSTxt"
        '
        'direccionSTxt
        '
        Me.direccionSTxt.AutoSize = True
        Me.direccionSTxt.Location = New System.Drawing.Point(181, 66)
        Me.direccionSTxt.Name = "direccionSTxt"
        Me.direccionSTxt.Size = New System.Drawing.Size(59, 17)
        Me.direccionSTxt.TabIndex = 6
        Me.direccionSTxt.Text = "Label14"
        '
        'codigoSTxt
        '
        Me.codigoSTxt.AutoSize = True
        Me.codigoSTxt.Location = New System.Drawing.Point(172, 30)
        Me.codigoSTxt.Name = "codigoSTxt"
        Me.codigoSTxt.Size = New System.Drawing.Size(59, 17)
        Me.codigoSTxt.TabIndex = 5
        Me.codigoSTxt.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(514, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Nombre del usuario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Direccion de la sucursal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Codigo de la sucursal"
        '
        'DashboardEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 530)
        Me.Controls.Add(Me.empleadoTb)
        Me.Name = "DashboardEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardEmpleado"
        Me.empleadoTb.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents empleadoTb As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ordenBtn As Button
    Friend WithEvents limpiarBtn As Button
    Friend WithEvents agregarBtn As Button
    Friend WithEvents cantidadTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents productoCb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ordenLv As ListView
    Friend WithEvents nombreProducto As ColumnHeader
    Friend WithEvents tipoProducto As ColumnHeader
    Friend WithEvents cantidadProducto As ColumnHeader
    Friend WithEvents subtotalProducto As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents telefonoClienteTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nombreClienteTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cerrarSesionBtn As Button
    Friend WithEvents nombreTxt As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents direccionTxt As Label
    Friend WithEvents codigoTxt As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ordenSBtn As Button
    Friend WithEvents simulacionLv As ListView
    Friend WithEvents NombreCliente As ColumnHeader
    Friend WithEvents NumeroBebidas As ColumnHeader
    Friend WithEvents NumeroPizzas As ColumnHeader
    Friend WithEvents TelefonoCliente As ColumnHeader
    Friend WithEvents totalcompra As ColumnHeader
    Friend WithEvents simulacionBtn As Button
    Friend WithEvents cantidadSTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cerrarBtn As Button
    Friend WithEvents nombreSTxt As Label
    Friend WithEvents direccionSTxt As Label
    Friend WithEvents codigoSTxt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
