Imports PIZZA_HIT_201701012.Query
Public Class LoginProcess
    Dim qury As Query
    Public Shared currentUser As Personal
    Public Function doLogin(user As String, pass As String)
        qury = New Query()
        currentUser = qury.execLoginQuery(user, pass)
        If currentUser IsNot Nothing Then
            Return True
        Else
            MessageBox.Show("Credenciales incorrectas", "Error de login", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Return False
        End If
    End Function
End Class
