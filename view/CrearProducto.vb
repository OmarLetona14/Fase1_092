Imports PIZZA_HIT_201701012.Query
Public Class CrearProducto

    Dim nombreProducto As String
    Dim precioProducto As Double
    Dim tipo As String
    Dim query As Query
    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        If Not DashboardAdministrador.edit Then
            If agregarProducto() Then
                MessageBox.Show("Registro exitoso", "Registro exitoso", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
                Me.Hide()
                Dim d = New DashboardAdministrador()
                d.Show()
            Else
                MessageBox.Show("Ocurrio un error al ingresar el registro", "Error de registro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
            End If
        Else
            If editarProducto() Then
                MessageBox.Show("Se editaron correctamente los datos", "Registro exitoso", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
                Me.Hide()
                Dim d = New DashboardAdministrador()
                d.Show()
            Else
                MessageBox.Show("Ocurrio un error al editar el registro", "Error de registro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function editarProducto()
        query = New Query()
        nombreProducto = nombreProductoTxt.Text
        Try
            precioProducto = Double.Parse(precioProductoTxt.Text)
        Catch ex As Exception
            Return False
        End Try
        tipo = tipoProductoCb.SelectedItem.ToString
        Dim p = New Producto()
        p.NombreProducto = nombreProducto
        p.Precio = precioProducto
        p.Tipo = tipo
        p.IdProducto = DashboardAdministrador.currentProducto.IdProducto
        Try
            query.execUpdateProducto(p)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Function agregarProducto()
        query = New Query()
        nombreProducto = nombreProductoTxt.Text
        Try
            precioProducto = Double.Parse(precioProductoTxt.Text)
        Catch ex As Exception
            Return False
        End Try
        tipo = tipoProductoCb.SelectedItem.ToString()
        Dim p = New Producto()
        p.NombreProducto = nombreProducto
        p.Precio = precioProducto
        p.Tipo = tipo
        Try
            query.execInsertProducto(p)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub cancelarBtn_Click(sender As Object, e As EventArgs) Handles cancelarBtn.Click
        Me.Hide()
        Dim dash = New DashboardAdministrador()
        dash.Show()
    End Sub

    Private Sub CrearProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DashboardAdministrador.edit Then
            agregarBtn.Text = "Editar"
            If DashboardAdministrador.currentProducto IsNot Nothing Then
                nombreProductoTxt.Text = DashboardAdministrador.currentProducto.NombreProducto
                precioProductoTxt.Text = DashboardAdministrador.currentProducto.Precio.ToString()
                tipoProductoCb.SelectedItem = DashboardAdministrador.currentProducto.Tipo.ToString()
            End If
        Else
            agregarBtn.Text = "Agregar"
        End If
    End Sub
End Class