Public Class SimulacionProcess
    Public Shared ventas As List(Of Venta)
    Private venta As Venta

    Private Function getRandomNumber(inicio As Integer, final As Integer, double_rand As Boolean)
        Dim numeroAleatorio As New Random(CInt(Date.Now.Ticks And Integer.MaxValue))
        Dim valorAleatorio As Double
        If Not double_rand Then
            valorAleatorio = Convert.ToDouble(numeroAleatorio.Next(inicio, final))
        Else
            valorAleatorio = (numeroAleatorio.NextDouble * (final - 100)) + inicio
        End If
        Return valorAleatorio
    End Function

    Private Function generateRandomPhone()
        Dim phone As String = ""
        For i = 0 To 7
            Dim numeroAleatorio As New Random(CInt(Date.Now.Ticks And Integer.MaxValue And i))
            Dim valorAleatorio = numeroAleatorio.Next(1, 9)
            Dim cadena As String = valorAleatorio.ToString()
            phone &= cadena
        Next
        Return phone
    End Function


    Public Function generateRandomProcess(cant As Integer, ByRef list As ListView)
        ventas = New List(Of Venta)
        For i = 1 To cant
            Try
                venta = New Venta()
                Dim nombreCliente = "Cliente #" & i
                Dim listofItems As ListViewItem = New ListViewItem(nombreCliente)
                venta.NombreCliente = nombreCliente
                Dim cantidadBebidas As Integer = Convert.ToInt64(getRandomNumber(1, 5, False))
                listofItems.SubItems.Add(cantidadBebidas)
                venta.CantidadBebida = cantidadBebidas
                Dim cantidadPizzas As Integer = Convert.ToInt64(getRandomNumber(1, 5, False))
                listofItems.SubItems.Add(cantidadPizzas)
                venta.CantidadPizza = cantidadPizzas
                Dim telefono As String = generateRandomPhone()
                listofItems.SubItems.Add(telefono)
                venta.TelefonoCliente = telefono
                Dim total As Double = getRandomNumber(100, 1000, True)
                listofItems.SubItems.Add("Q" & Math.Round(total, 2))
                venta.Total = Math.Round(total, 2)
                list.Items.Add(listofItems)
                venta.Personal = LoginProcess.currentUser
                ventas.Add(venta)
            Catch ex As Exception
                Return False
            End Try
        Next
        Return True
    End Function

End Class
