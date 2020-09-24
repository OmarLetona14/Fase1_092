Imports PIZZA_HIT_201701012.Query
Public Class NuevoPedidoProcess

    Dim query As Query
    Dim nuevaVenta As Venta

    Public listOfVentas As List(Of Venta)
    Public Sub nuevoPedido(cantidadPizza As Integer, cantidadBebida As Integer, total As Integer,
                                nombreCliente As String, telefonoCliente As String)
        query = New Query()
        nuevaVenta = New Venta()
        nuevaVenta.CantidadBebida = cantidadBebida
        nuevaVenta.CantidadPizza = cantidadPizza
        nuevaVenta.Total = total
        nuevaVenta.NombreCliente = nombreCliente
        nuevaVenta.TelefonoCliente = telefonoCliente
        nuevaVenta.Personal = LoginProcess.currentUser
        nuevaVenta.Personal.IdPersonal = LoginProcess.currentUser.IdPersonal
        If query.execInsertVenta(nuevaVenta) Then
            MessageBox.Show("Pedido procesado correctamente", "Pedido", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al procesar el pedido", "Error de pedido", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        End If
    End Sub
End Class
