Imports PIZZA_HIT_201701012.Query
Public Class CrearEmpleado

    Dim nombre As String
    Dim correo As String
    Dim contrasenia As String
    Dim empleado_nuevo As Personal
    Dim sucursales As List(Of Sucursal)

    Dim query As Query
    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        nombre = nombreTxt.Text
        correo = correoTxt.Text
        contrasenia = contraseniaTxt.Text
        If Not nombre.Equals("") And Not correo.Equals("") And Not contrasenia.Equals("") Then
            empleado_nuevo = New Personal()
            empleado_nuevo.NombrePersonal = nombre
            empleado_nuevo.Correo = correo
            empleado_nuevo.Contrasenia = contrasenia
            If cbRol.SelectedItem.ToString = "Empleado" Then
                empleado_nuevo.Tipo = "Empleado"
                empleado_nuevo.Sucursal = getSucursal(sucursalCb.SelectedItem.ToString)
            Else
                empleado_nuevo.Tipo = "Administrador"
            End If
            If Not DashboardAdministrador.edit Then
                If query.execInsertEmpleado(empleado_nuevo) Then
                    MessageBox.Show("Registro exitoso", "Registro exitoso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
                    Me.Hide()
                    Dim d = New DashboardAdministrador()
                    d.Show()
                Else
                    MessageBox.Show("Ocurrio un error al ingresar el registro", "Error de registro", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
                End If
            Else
                empleado_nuevo.Sucursal = DashboardAdministrador.currentEmpleado.Sucursal
                empleado_nuevo.IdPersonal = DashboardAdministrador.currentEmpleado.IdPersonal
                If query.execUpdateEmpleado(empleado_nuevo) Then
                    MessageBox.Show("Se edito correctamente", "Registro exitoso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
                    DashboardAdministrador.edit = False
                    Me.Hide()
                    Dim d = New DashboardAdministrador()
                    d.Show()
                Else
                    MessageBox.Show("Ocurrio un error al editar el registro", "Error de registro", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning)
                    DashboardAdministrador.edit = False
                End If
            End If

        Else
            MessageBox.Show("Debe llenar todos los campos", "Error de registro", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CrearEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = New Query()
        sucursales = query.execGetSucursales()
        For Each element As Sucursal In sucursales
            If element IsNot Nothing Then
                sucursalCb.Items.Add(element.Codigo)
            End If
        Next
        If DashboardAdministrador.edit Then
            agregarBtn.Text = "Editar"
            nombreTxt.Text = DashboardAdministrador.currentEmpleado.NombrePersonal
            correoTxt.Text = DashboardAdministrador.currentEmpleado.Correo
            contraseniaTxt.Text = DashboardAdministrador.currentEmpleado.Contrasenia
            cbRol.SelectedItem = DashboardAdministrador.currentEmpleado.Tipo
            If DashboardAdministrador.currentEmpleado.Sucursal IsNot Nothing Then
                sucursalCb.SelectedItem = DashboardAdministrador.currentEmpleado.Sucursal.Codigo
            Else
                sucursalCb.Enabled = False
            End If
        Else
            agregarBtn.Text = "Agregar"
        End If
    End Sub

    Private Function getSucursal(codigo As String)
        For Each s As Sucursal In sucursales
            If s IsNot Nothing Then
                If s.Codigo.Equals(codigo) Then
                    Return s
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub cbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRol.SelectedIndexChanged
        If cbRol.SelectedItem.ToString.Equals("Administrador") Then
            sucursalCb.Enabled = False
            sucursalCb.SelectedItem = ""
        Else
            sucursalCb.Enabled = True
        End If
    End Sub

    Private Sub cancelarBtn_Click(sender As Object, e As EventArgs) Handles cancelarBtn.Click
        DashboardAdministrador.currentEmpleado = Nothing
        DashboardAdministrador.edit = False
        Me.Hide()
        Dim d = New DashboardAdministrador()
        d.Show()
    End Sub

    Private Sub sucursalCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sucursalCb.SelectedIndexChanged

    End Sub
End Class