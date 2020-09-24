Imports PIZZA_HIT.Query
Imports PIZZA_HIT.NuevoPedidoProcess
Public Class DashboardEmpleado
    Dim total As Double
    Dim products As List(Of Producto)
    Dim query As Query
    Dim pedido As NuevoPedidoProcess
    Dim cantidadBebidas As Integer
    Dim cantidadPizzas As Integer
    Dim simulacion As SimulacionProcess
    Dim correctSimulation As Boolean
    Private Sub DashboardEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComponents()
    End Sub

    Public Sub initComponents()
        total = 0
        cantidadPizzas = 0
        cantidadBebidas = 0
        query = New Query()
        lblTotal.Text = "Q" & total
        empleadoTb.TabPages.Item(0).Text = "Sucursal"
        empleadoTb.TabPages.Item(1).Text = "Simulacion"
        If LoginProcess.currentUser IsNot Nothing Then
            nombreTxt.Text = LoginProcess.currentUser.NombrePersonal
            nombreSTxt.Text = LoginProcess.currentUser.NombrePersonal
            If LoginProcess.currentUser.Sucursal IsNot Nothing Then
                codigoTxt.Text = LoginProcess.currentUser.Sucursal.Codigo
                direccionSTxt.Text = LoginProcess.currentUser.Sucursal.Direccion
                codigoSTxt.Text = LoginProcess.currentUser.Sucursal.Codigo
                direccionTxt.Text = LoginProcess.currentUser.Sucursal.Direccion
            Else
                codigoTxt.Text = "No info"
                direccionSTxt.Text = "No info"
                codigoSTxt.Text = "No info"
                direccionTxt.Text = "No info"
            End If
        Else
            nombreTxt.Text = "No info"
            direccionTxt.Text = "No info"
            codigoTxt.Text = "No info"
            nombreSTxt.Text = "No info"
            direccionSTxt.Text = "No info"
            codigoSTxt.Text = "No info"
        End If
        products = query.execGetProductos()
        For Each element As Producto In products
            If element IsNot Nothing Then
                productoCb.Items.Add(element.NombreProducto)
            End If
        Next
    End Sub

    Private Sub ordenBtn_Click(sender As Object, e As EventArgs) Handles ordenBtn.Click
        pedido = New NuevoPedidoProcess()
        pedido.nuevoPedido(cantidadPizzas, cantidadBebidas, total, nombreClienteTxt.Text, telefonoClienteTxt.Text)
        limpiarCampos()
    End Sub

    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        agregarEmpleado()
    End Sub

    Private Sub agregarEmpleado()
        Try
            Dim cantidad As Integer
            If cantidadTxt IsNot " " Then
                cantidad = Integer.Parse(cantidadTxt.Text)
            Else
                cantidad = 1
            End If
            If cantidad = 0 Then
                cantidad = 1
            End If
            Dim currentProduct As Producto = getProduct(productoCb.SelectedItem.ToString)
            If currentProduct IsNot Nothing Then
                Dim list As ListViewItem = New ListViewItem(currentProduct.NombreProducto)
                If currentProduct.Tipo.Equals("Pizza") Then
                    cantidadPizzas += 1
                ElseIf currentProduct.Tipo.Equals("Bebida") Then
                    cantidadBebidas += 1
                End If
                list.SubItems.Add(currentProduct.Tipo)
                list.SubItems.Add(cantidad)
                Dim subtotal As Double = getSubtotal(currentProduct.Precio, cantidad)
                total += subtotal
                list.SubItems.Add("Q" & subtotal)
                ordenLv.Items.Add(list)
                lblTotal.Text = "Q" & total
                cantidadTxt.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al agregar el producto", "Error de pedido", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function getProduct(name As String)
        For Each e As Producto In products
            If e.NombreProducto.Equals(name) Then
                Return e
            End If
        Next
        Return Nothing
    End Function

    Private Function getSubtotal(precio As Double, cantidad As Integer)
        Dim subtotal As Double = precio * cantidad
        Return subtotal
    End Function

    Private Sub limpiarBtn_Click(sender As Object, e As EventArgs) Handles limpiarBtn.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        total = 0
        lblTotal.Text = "Q" & total
        cantidadBebidas = 0
        cantidadPizzas = 0
        ordenLv.Items.Clear()
        cantidadTxt.Text = ""
        nombreClienteTxt.Text = ""
        telefonoClienteTxt.Text = ""
    End Sub

    Private Sub cerrarSesionBtn_Click(sender As Object, e As EventArgs) Handles cerrarSesionBtn.Click
        Me.Hide()
        Dim login = New Login()
        login.Show()
    End Sub

    Private Sub cerrarBtn_Click(sender As Object, e As EventArgs) Handles cerrarBtn.Click
        Me.Hide()
        Dim login = New Login()
        login.Show()
    End Sub

    Private Sub simulacionBtn_Click(sender As Object, e As EventArgs) Handles simulacionBtn.Click
        Dim c = Integer.Parse(cantidadSTxt.Text)
        If (c > 0) Then
            simulacion = New SimulacionProcess()
            If simulacion.generateRandomProcess(c, simulacionLv) Then
                MessageBox.Show("Simulacion completada con exito", "Simulacion completada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                correctSimulation = True
            Else
                MessageBox.Show("Ocurrio un error al generar la simulacion", "Error de simulacion", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                correctSimulation = False
            End If
        End If
    End Sub

    Private Sub ordenSBtn_Click(sender As Object, e As EventArgs) Handles ordenSBtn.Click
        If generateOrder() Then
            MessageBox.Show("Orden completada con exito", "Orden completada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al generar la orden", "Error de Orden", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        End If
    End Sub

    Private Function generateOrder()
        Try
            If SimulacionProcess.ventas IsNot Nothing Then
                For Each element As Venta In SimulacionProcess.ventas
                    If element IsNot Nothing Then
                        query.execInsertVenta(element)
                    End If
                Next
            End If
        Catch ex As Exception
            Return False
        End Try
        query = New Query()
        Return True
    End Function
End Class