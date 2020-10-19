Imports PIZZA_HIT_201701012.Query
Public Class DashboardAdministrador

    Dim empleados As List(Of PersonalView)
    Dim productos As List(Of Producto)
    Dim sucursales As List(Of Sucursal)
    Dim admin_sucursal As List(Of Sucursal)
    Public Shared currentEmpleado As PersonalView
    Public Shared currentProducto As Producto
    Public Shared currentSucursal As Sucursal
    Dim query As Query
    Public Shared edit As Boolean = False
    Private Sub initComponents()
        query = New Query()
        dashboradTb.TabPages.Item(0).Text = "Administrar"
        dashboradTb.TabPages.Item(1).Text = "Reportes"
        lblCorreo.Text = LoginProcess.currentUser.Correo
        lblNombre.Text = LoginProcess.currentUser.NombrePersonal
        admin_sucursal = query.execGetSucursales()
        For Each s As Sucursal In admin_sucursal
            If s IsNot Nothing Then
                cbSucursal.Items.Add(s.Codigo)
            End If
        Next
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
                empleados = New List(Of PersonalView)
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
        For Each e As PersonalView In empleados
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
        End If
        edit = False
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
            If Not dgvDatos.SelectedRows.Count < 1 Then
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
            Else
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
            End If
        End If
        Return False
    End Function

    Private Function deleteProducto()
        Dim result = MessageBox.Show("Esta seguro de eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)
        If result = vbYes Then
            If Not dgvDatos.SelectedRows.Count < 1 Then
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
            Else
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
            End If
        End If
        Return False
    End Function

    Private Function deleteSucursal()
        Dim result = MessageBox.Show("Esta seguro de eliminar esta sucursal?", "Eliminar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)
        If result = vbYes Then
            If Not dgvDatos.SelectedRows.Count < 1 Then
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
            Else
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
            End If
        End If
        Return False
    End Function

    Private Sub DashboardAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComponents()
    End Sub

    Private Sub reportCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles reportCb.SelectedIndexChanged
        lblSucursal.Visible = False
        cbSucursal.Visible = False
        clearFields()
        query = New Query()
        Select Case reportCb.SelectedItem.ToString
            Case "Ordenes hechas"
                Dim ventas As List(Of VentaView) = query.execGetVentas()
                datosDv.DataSource = ventas
                reportChart.Series.Add("Ventas")
                For Each v As VentaView In ventas
                    reportChart.Series("Ventas").Points.AddXY(v.IdVenta, v.Total)
                Next
            Case "Ventas por sucursal"
                Dim ventas_sucursalas As List(Of VentasSucursal) = query.execGetVentasSucursal()
                datosDv.DataSource = ventas_sucursalas
                reportChart.Series.Add("Ventas por sucursal")
                For Each v As VentasSucursal In ventas_sucursalas
                    reportChart.Series("Ventas por sucursal").Points.AddXY(v.Codigo, v.Total)
                Next
            Case "Ventas por empleado"
                lblSucursal.Visible = True
                cbSucursal.Visible = True
            Case "Top 3 sucursales donde se vendio mas pizza"
                Dim ventas_top As List(Of Report4) = query.execGetTop3Pizza()
                datosDv.DataSource = ventas_top
                reportChart.Series.Add("Top 3 sucursales donde se vendio mas pizza")
                For Each v As Report4 In ventas_top
                    reportChart.Series("Top 3 sucursales donde se vendio mas pizza").Points.AddXY(v.Codigo, v.Total)
                Next
            Case "Top 3 sucursales donde se vendieron mas bebidas"
                Dim ventas_top As List(Of Report4) = query.execGetTop3Bebida()
                datosDv.DataSource = ventas_top
                reportChart.Series.Add("Top 3 sucursales donde se vendieron mas bebidas")
                For Each v As Report4 In ventas_top
                    reportChart.Series("Top 3 sucursales donde se vendieron mas bebidas").Points.AddXY(v.Codigo, v.Total)
                Next
        End Select


    End Sub

    Private Sub clearFields()
        reportChart.Series.Clear()
        datosDv.DataSource = ""
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub cbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSucursal.SelectedIndexChanged
        clearFields()
        query = New Query()
        Dim suc As Integer = getSucursal()
        Dim ventas As List(Of VentaEmpleado) = query.execGetVentasEmpleado(suc)
        datosDv.DataSource = ventas
        reportChart.Series.Add("Ventas por empleado")
        For Each v As VentaEmpleado In ventas
            reportChart.Series("Ventas por empleado").Points.AddXY(v.NombrePersonal, v.Total)
        Next
    End Sub

    Private Function getSucursal()
        For Each s As Sucursal In admin_sucursal
            If s IsNot Nothing Then
                If s.Codigo.Equals(cbSucursal.SelectedItem.ToString) Then
                    Return s.IdSucursal
                End If
            End If
        Next
        Return Nothing
    End Function
End Class