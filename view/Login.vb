Imports System.Data.SqlClient
Imports PIZZA_HIT.Connector
Imports PIZZA_HIT.Query
Public Class Login
    Dim user As String
    Dim pass As String
    Dim newConnection As Connector
    Dim login As LoginProcess
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        pass = passwordTxt.Text
        user = usuarioTxt.Text
        If Not (user.Length.Equals(0)) Then
            If Not (pass.Length.Equals(0)) Then
                login = New LoginProcess()
                If login.doLogin(user, pass) Then
                    Me.Hide()
                    If LoginProcess.currentUser.Tipo = "Empleado" Then
                        Dim p = New DashboardEmpleado()
                        p.Show()
                    Else
                        Dim pA = New DashboardAdministrador()
                        pA.Show()
                    End If
                Else
                    usuarioTxt.Text = ""
                    passwordTxt.Text = ""
                End If
            Else
                MessageBox.Show("Debe introducir una contrasenia", "Error de login", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe introducir un nombre de usuario", "Error de login", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newConnection = New Connector()
        newConnection.connect()
    End Sub
End Class