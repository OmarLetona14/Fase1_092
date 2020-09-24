Imports PIZZA_HIT_201701012.Connector
Imports MySql.Data.MySqlClient
Public Class Query
    Public Function execLoginQuery(user As String, pass As String)
        Dim usuario As Personal
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
        Dim empleado As Personal
        Dim sucursal As Sucursal
        Dim empleados = New List(Of Personal)
        Dim query As String = "select * from Personal as p left join Sucursal as s on p.idSucursal = s.idSucursal;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                sucursal = New Sucursal()
                empleado = New Personal()
                empleado.IdPersonal = reader.GetInt64(0)
                empleado.NombrePersonal = reader.GetString(1)
                empleado.Correo = reader.GetString(2)
                empleado.Contrasenia = reader.GetString(3)
                empleado.Tipo = reader.GetString(4)
                If Not reader.IsDBNull(6) Then
                    sucursal.IdSucursal = reader.GetInt64(6)
                    sucursal.Codigo = reader.GetString(7)
                    sucursal.Direccion = reader.GetString(8)
                    empleado.Sucursal = sucursal
                Else
                    empleado.Sucursal = Nothing
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
        Dim query As String = "select * from Sucursal;"
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

    Public Function execInsertEmpleado(e As Personal)
        Dim query As String
        If e.Sucursal IsNot Nothing Then
            query = "Insert into Personal values (null, '" & e.NombrePersonal & "', '" & e.Correo & "' , '" & e.Contrasenia & "' , '" & e.Tipo & "'," & e.Sucursal.IdSucursal & ");"
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

    Public Function execUpdateEmpleado(e As Personal)
        Dim query As String
        If e.Sucursal IsNot Nothing Then
            query = "update Personal set nombrePersonal = '" & e.NombrePersonal & "', correo = '" & e.Correo & "' , contrasenia = '" & e.Contrasenia & "' , tipo = '" & e.Tipo & "', idSucursal = " & e.Sucursal.IdSucursal & " where idPersonal =" & e.IdPersonal & ";"
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

    Public Function execDeletePersonal(e As Personal)
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
End Class
