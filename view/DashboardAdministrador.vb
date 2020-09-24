Imports PIZZA_HIT_201701012.Query
Public Class DashboardAdministrador

    Dim empleados As List(Of Personal)
    Dim productos As List(Of Producto)
    Dim sucursales As List(Of Sucursal)
    Public Shared currentEmpleado As Personal
    Public Shared currentProducto As Producto
    Public Shared currentSucursal As Sucursal
    Dim query As Query
    Public Shared edit As Boolean = False

    Private Sub initComponents()
        dashboradTb.TabPages.Item(0).Text = "Administrar"
        dashboradTb.TabPages.Item(1).Text = "Reportes"
        lblCorreo.Text = LoginProcess.currentUser.Correo
        lblNombre.Text = LoginProcess.currentUser.NombrePersonal
    End Sub

    Private Sub cerrarSesionBtn_Click(sender As Object, e As EventArgs) Handles cerrarSesionBtn.Click
        Me.Hide()
        Dim login = New Login()
        login.Show()
    End Sub

    Private Sub cbMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMostrar.SelectedIndexChanged
        updateWindow()
    End Sub

    Private Sub updateWindow()
        Dim opcion = cbMostrar.SelectedItem.ToString
        query = New Query()
        Select Case opcion
            Case "Empleados"
                empleados = New List(Of Personal)
                empleados = query.execGetEmpleados()
                dgvDatos.DataSource = empleados
            Case "Sucursales"
                sucursales = New List(Of Sucursal)
                sucursales = query.execGetSucursales()
                dgvDatos.DataSource = sucursales
            Case "Productos"
                productos = New List(Of Producto)
                productos = query.execGetProductos()
                dgvDatos.DataSource = productos
        End Select
    End Sub

    Private Sub crearBtn_Click(sender As Object, e As EventArgs) Handles crearBtn.Click
        If cbMostrar.SelectedItem IsNot Nothing Then
            If cbMostrar.SelectedItem.ToString.Equals("Empleados") Then
                Me.Hide()
                Dim crear = New CrearEmpleado()
                crear.Show()
            ElseIf cbMostrar.SelectedItem.ToString.Equals("Sucursales") Then
                Me.Hide()
                Dim crearSucursal = New CrearSucursal()
                crearSucursal.Show()
            ElseIf cbMostrar.SelectedItem.ToString.Equals("Productos") Then
                Me.Hide()
                Dim crearProducto = New CrearProducto()
                crearProducto.Show()
            Else
                MessageBox.Show("Seleccione los datos a administrar", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Function getSelectedEmpleado(idEmpleado As Integer)
        For Each e As Personal In empleados
            If e IsNot Nothing Then
                If e.IdPersonal = idEmpleado Then
                    Return e
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Function getSelectedSucursal(idSucursal As Integer)
        For Each e As Sucursal In sucursales
            If e IsNot Nothing Then
                If e.IdSucursal = idSucursal Then
                    Return e
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Function getSelectedProducto(idProducto As Integer)
        For Each e As Producto In productos
            If e IsNot Nothing Then
                If e.IdProducto = idProducto Then
                    Return e
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub actualizarBtn_Click(sender As Object, e As EventArgs) Handles actualizarBtn.Click
        edit = True
        If Not dgvDatos.SelectedRows.Count < 1 Then
            If cbMostrar.SelectedItem IsNot Nothing Then
                If cbMostrar.SelectedItem.ToString.Equals("Empleados") Then
                    currentEmpleado = getSelectedEmpleado(Integer.Parse(dgvDatos.SelectedRows(0).Cells(0).FormattedValue.ToString))
                    Me.Hide()
                    Dim crear = New CrearEmpleado()
                    crear.Show()
                ElseIf cbMostrar.SelectedItem.ToString.Equals("Sucursales") Then
                    currentSucursal = getSelectedSucursal(Integer.Parse(dgvDatos.SelectedRows(0).Cells(0).FormattedValue.ToString))
                    Me.Hide()
                    Dim crearSucursal = New CrearSucursal()
                    crearSucursal.Show()
                ElseIf cbMostrar.SelectedItem.ToString.Equals("Productos") Then
                    currentProducto = getSelectedProducto(Integer.Parse(dgvDatos.SelectedRows(0).Cells(0).FormattedValue.ToString))
                    Me.Hide()
                    Dim crearProducto = New CrearProducto()
                    crearProducto.Show()
                Else
                    MessageBox.Show("Seleccione los datos a administrar", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
            edit = False
        End If
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        If cbMostrar.SelectedItem.ToString.Equals("Empleados") Then
            deleteEmpleado()
        ElseIf cbMostrar.SelectedItem.ToString.Equals("Sucursales") Then
            deleteSucursal()
        ElseIf cbMostrar.SelectedItem.ToString.Equals("Productos") Then
            deleteProducto()
        Else
            MessageBox.Show("Seleccione los datos a administrar", "Error", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function deleteEmpleado()
        Dim result = MessageBox.Show("Esta seguro de eliminar este personal?", "Eliminar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)
        If result = vbYes Then
            currentEmpleado = getSelectedEmpleado(Integer.Parse(dgvDatos.SelectedRows(0).Cells(0).FormattedValue.ToString))
            If query.execDeletePersonal(currentEmpleado) Then
                MessageBox.Show("Personal eliminado correctamente", "Eliminado correctamente", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
                updateWindow()
                Return True
            Else
                MessageBox.Show("Ocurrio un error al eliminar el personal", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return False
    End Function

    Private Function deleteProducto()
        Dim result = MessageBox.Show("Esta seguro de eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)
        If result = vbYes Then
            currentProducto = getSelectedProducto(Integer.Parse(dgvDatos.SelectedRows(0).Cells(0).FormattedValue.ToString))
            If query.execDeleteProducto(currentProducto) Then
                MessageBox.Show("Producto eliminado correctamente", "Eliminado correctamente", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
                updateWindow()
                Return True
            Else
                MessageBox.Show("Ocurrio un error al eliminar el producto", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return False
    End Function

    Private Function deleteSucursal()
        Dim result = MessageBox.Show("Esta seguro de eliminar esta sucursal?", "Eliminar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)
        If result = vbYes Then
            currentSucursal = getSelectedSucursal(Integer.Parse(dgvDatos.SelectedRows(0).Cells(0).FormattedValue.ToString))
            If query.execDeleteSucursal(currentSucursal) Then
                MessageBox.Show("Sucursal eliminada correctamente", "Eliminado correctamente", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
                updateWindow()
                Return True
            Else
                MessageBox.Show("Ocurrio un error al eliminar la sucursal", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return False
    End Function

    Private Sub DashboardAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComponents()
    End Sub
End Class