Imports PIZZA_HIT_201701012.Query
Public Class CrearSucursal

    Dim query As Query
    Dim codigoSucursal As String
    Dim direccionSucursal As String
    Dim sucursal As Sucursal
    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        If Not DashboardAdministrador.edit Then
            If agregarSucursal() Then
                MessageBox.Show("Registro exitoso", "Registro exitoso", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
                Me.Hide()
                Dim dash = New DashboardAdministrador()
                dash.Show()
            Else
                MessageBox.Show("Ocurrio un error al ingresar el registro", "Error de registro", MessageBoxButtons.OK,
                                          MessageBoxIcon.Error)
            End If
        Else
            If editarSucursal() Then
                MessageBox.Show("Registro editado exitosamente", "Registro exitoso", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
                Me.Hide()
                Dim dash = New DashboardAdministrador()
                dash.Show()
            Else
                MessageBox.Show("Ocurrio un error al editar el registro", "Error de registro", MessageBoxButtons.OK,
                                          MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cancelarBtn_Click(sender As Object, e As EventArgs) Handles cancelarBtn.Click
        Me.Hide()
        Dim dash = New DashboardAdministrador()
        dash.Show()
    End Sub

    Private Function editarSucursal()
        query = New Query()
        codigoSucursal = codigoTxt.Text
        direccionSucursal = direccionRtx.Text
        If Not (String.IsNullOrEmpty(codigoSucursal) And String.IsNullOrEmpty(direccionSucursal)) Then
            sucursal = New Sucursal()
            sucursal.Codigo = codigoSucursal
            sucursal.Direccion = direccionSucursal
            sucursal.IdSucursal = DashboardAdministrador.currentSucursal.IdSucursal
            Try
                query.execUpdateSucursal(sucursal)
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
        Return True
    End Function
    Private Function agregarSucursal()
        query = New Query()
        codigoSucursal = codigoTxt.Text
        direccionSucursal = direccionRtx.Text
        If Not (String.IsNullOrEmpty(codigoSucursal) And String.IsNullOrEmpty(direccionSucursal)) Then
            sucursal = New Sucursal()
            sucursal.Codigo = codigoSucursal
            sucursal.Direccion = direccionSucursal
            Try
                query.execInsertSucursal(sucursal)
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub CrearSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DashboardAdministrador.edit Then
            agregarBtn.Text = "Editar"
            codigoTxt.Text = DashboardAdministrador.currentSucursal.Codigo
            direccionRtx.Text = DashboardAdministrador.currentSucursal.Direccion
        End If
    End Sub
End Class