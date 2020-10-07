Imports PIZZA_HIT_201701012.Connector
Imports MySql.Data.MySqlClient
Public Class Query
    Public Function execLoginQuery(user As String, pass As String)
        Dim usuario As Personal = Nothing
        Dim query As String = "select * from Personal where nombrePersonal = '" & user & "' AND " &
           " contrasenia = '" & pass & "' ;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                usuario = New Personal()
                usuario.IdPersonal = reader.GetInt64(0)
                usuario.NombrePersonal = reader.GetString(1)
                usuario.Correo = reader.GetString(2)
                usuario.Contrasenia = reader.GetString(3)
                usuario.Tipo = reader.GetString(4)
                If Not reader.IsDBNull(5) Then
                    Dim idSuc As Integer = reader.GetString(5)
                    reader.Close()
                    usuario.Sucursal = execGetSucursal(idSuc)
                End If
                Exit While
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex)
            Return Nothing
        End Try
        Return usuario
    End Function
    Public Function execGetSucursal(idSucursal As String)
        Dim sucursal As Sucursal
        Dim query As String = "select * from Sucursal where idSucursal = " & idSucursal & ";"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            sucursal = New Sucursal()
            While (reader.Read())
                sucursal.IdSucursal = reader.GetInt64(0)
                sucursal.Codigo = reader.GetString(1)
                sucursal.Direccion = reader.GetString(2)
                reader.Close()
                Return sucursal
            End While
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function execGetProductos()
        Dim producto As Producto
        Dim productos = New List(Of Producto)
        Dim query As String = "select * from Producto;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                producto = New Producto()
                producto.IdProducto = reader.GetInt64(0)
                producto.NombreProducto = reader.GetString(1)
                producto.Tipo = reader.GetString(2)
                producto.Precio = reader.GetDouble(3)
                productos.Add(producto)
            End While
            reader.Close()
            Return productos
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function execGetEmpleados()
        Dim empleado As PersonalView
        Dim sucursal As Sucursal
        Dim empleados = New List(Of PersonalView)
        Dim query As String = "select p.idPersonal, p.nombrePersonal, p.correo, p.contrasenia, p.tipo,s.idSucursal, s.codigo, s.direccion from personal as p
        left join sucursal as s on s.idSucursal = p.idSucursal;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                sucursal = New Sucursal()
                empleado = New PersonalView()
                empleado.IdPersonal = reader.GetInt64(0)
                empleado.NombrePersonal = reader.GetString(1)
                empleado.Correo = reader.GetString(2)
                empleado.Contrasenia = reader.GetString(3)
                empleado.Tipo = reader.GetString(4)
                If Not reader.IsDBNull(5) Then
                    empleado.IdSucursal = reader.GetInt64(5)
                    empleado.Codigo = reader.GetString(6)
                    empleado.Direccion = reader.GetString(7)
                Else
                    empleado.IdSucursal = Nothing
                    empleado.Codigo = Nothing
                    empleado.Direccion = Nothing
                End If
                empleados.Add(empleado)
            End While
            reader.Close()
            Return empleados
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function execGetSucursales()
        Dim sucursal As Sucursal
        Dim sucursales = New List(Of Sucursal)
        Dim query As String = "select * from sucursal;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                sucursal = New Sucursal()
                sucursal.IdSucursal = reader.GetInt64(0)
                sucursal.Codigo = reader.GetString(1)
                sucursal.Direccion = reader.GetString(2)
                sucursales.Add(sucursal)
            End While
            reader.Close()
            Return sucursales
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function execGetVentas()
        Dim venta As VentaView
        Dim ventas = New List(Of VentaView)
        Dim query As String = "select v.idVenta, v.cantidadPizza, v.cantidadBebida, v.total, v.nombreCliente, v.telefonoCliente, p.nombrePersonal,
        s.codigo, s.direccion
        from venta as v
        inner join personal as p on p.idPersonal = v.idPersonal
        inner join sucursal as s on s.idSucursal = p.idSucursal;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                venta = New VentaView()
                venta.IdVenta = reader.GetInt64(0)
                venta.CantidadPizza = reader.GetInt64(1)
                venta.CantidadBebida = reader.GetInt64(2)
                venta.Total = reader.GetDouble(3)
                venta.NombreCliente = reader.GetString(4)
                venta.TelefonoCliente = reader.GetString(5)
                venta.NombrePersonal = reader.GetString(6)
                venta.Codigo = reader.GetString(7)
                venta.Direccion = reader.GetString(8)
                ventas.Add(venta)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function execInsertVenta(v As Venta)
        Dim query As String = "Insert into Venta values (null, " & v.CantidadPizza & ", " & v.CantidadBebida & ", " & v.Total & ", '" & v.NombreCliente & "'," & "'" & v.TelefonoCliente & "'," & v.Personal.IdPersonal & ");"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execInsertEmpleado(e As PersonalView)
        Dim query As String
        If e.Codigo IsNot Nothing Then
            query = "Insert into Personal values (null, '" & e.NombrePersonal & "', '" & e.Correo & "' , '" & e.Contrasenia & "' , '" & e.Tipo & "'," & e.IdSucursal & ");"
        Else
            query = "Insert into Personal values (null, '" & e.NombrePersonal & "', '" & e.Correo & "' , '" & e.Contrasenia & "' , '" & e.Tipo & "',null);"
        End If
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execInsertProducto(p As Producto)
        Dim query As String = "Insert into Producto values (null, '" & p.NombreProducto & "', '" & p.Tipo & "' , " & p.Precio & ");"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execInsertSucursal(s As Sucursal)
        Dim query As String = "Insert into Sucursal values (null, '" & s.Codigo & "' , '" & s.Direccion & "' );"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execUpdateEmpleado(e As PersonalView)
        Dim query As String
        If e.Codigo IsNot Nothing Then
            query = "update Personal set nombrePersonal = '" & e.NombrePersonal & "', correo = '" & e.Correo & "' , contrasenia = '" & e.Contrasenia & "' , tipo = '" & e.Tipo & "', idSucursal = " & e.IdSucursal & " where idPersonal =" & e.IdPersonal & ";"
        Else
            query = "update Personal set nombrePersonal = '" & e.NombrePersonal & "', correo = '" & e.Correo & "' , contrasenia = '" & e.Contrasenia & "' , tipo = '" & e.Tipo & "' where idPersonal = " & e.IdPersonal & ";"
        End If
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execUpdateProducto(p As Producto)
        Dim query As String = "update Producto set  nombreProducto = '" & p.NombreProducto & "', tipo = '" & p.Tipo & "' , precio = " & p.Precio & " where idProducto = " & p.IdProducto & ";"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execUpdateSucursal(s As Sucursal)
        Dim query As String = "update Sucursal set codigo = '" & s.Codigo & "' , direccion = '" & s.Direccion & "' where idSucursal = " & s.IdSucursal & "  ;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execDeleteSucursal(s As Sucursal)
        Dim query As String = "delete from Sucursal where idSucursal = " & s.IdSucursal & ";"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execDeleteProducto(p As Producto)
        Dim query As String = "delete from Producto where idProducto= " & p.IdProducto & ";"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function



    Public Function execDeletePersonal(e As PersonalView)
        Dim query As String = "delete from Personal where idPersonal =" & e.IdPersonal & ";"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function execGetVentasSucursal()
        Dim venta As VentasSucursal
        Dim ventas_sucursal = New List(Of VentasSucursal)
        Dim query As String = "select s.codigo, sum(v.total) as total_ventas from venta as v
        inner join personal as p on p.idPersonal = v.idPersonal
        inner join sucursal as s on s.idSucursal = p.idSucursal
        group by s.codigo;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                venta = New VentasSucursal()
                venta.Codigo = reader.GetString(0)
                venta.Total = Math.Round(reader.GetDouble(1))
                ventas_sucursal.Add(venta)
            End While
            reader.Close()
            Return ventas_sucursal
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function


    Public Function execGetVentasEmpleado(idSucursal As String)
        Dim venta As VentaEmpleado
        Dim ventas_empleado = New List(Of VentaEmpleado)
        Dim query As String = "select p.nombrePersonal, sum(v.total) from venta as v
        inner join personal as p on p.idPersonal = v.idPersonal
        inner join sucursal as s on s.idSucursal = p.idSucursal
        where p.idSucursal = " & idSucursal & "
        group by p.nombrePersonal;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                venta = New VentaEmpleado()
                venta.NombrePersonal = reader.GetString(0)
                venta.Total = Math.Round(reader.GetDouble(1))
                ventas_empleado.Add(venta)
            End While
            reader.Close()
            Return ventas_empleado
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function execGetVentasPizza()
        Dim venta As VentaEmpleado
        Dim ventas_empleado = New List(Of VentaEmpleado)
        Dim query As String = "select p.nombrePersonal, sum(v.total) from venta as v
        inner join personal as p on p.idPersonal = v.idPersonal
        inner join sucursal as s on s.idSucursal = p.idSucursal
        where p.idSucursal = 
        group by p.nombrePersonal;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                venta = New VentaEmpleado()
                venta.NombrePersonal = reader.GetString(0)
                venta.Total = Math.Round(reader.GetDouble(1))
                ventas_empleado.Add(venta)
            End While
            reader.Close()
            Return ventas_empleado
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
End Class
