Imports MySql.Data.MySqlClient
Public Class Connector
    Public Const PORT = "3306"
    Public Const DATABASE = "PIZZA_HIT"
    Public Const SERVER = "localhost"
    Public Const USERNAME = "root"
    Public Const PASSWORD = "nUUUxrq5h"
    Public Shared connection As MySqlConnection
    Public Sub connect()
        Try
            connection = New MySqlConnection()
            Dim connString As String = "server=" & SERVER & ";" & "user=" & USERNAME &
                ";" & "password=" & PASSWORD & ";" & "port=" & PORT & ";" & "database=" & DATABASE & ";"
            Console.WriteLine(connString)
            connection.ConnectionString = connString
            connection.Open()
            Console.WriteLine("DATABASE IS ON LINE")
        Catch e As Exception
            Console.WriteLine("CANNOT CONNECT TO DATABASE")
        End Try
    End Sub

    Public Sub closeConnection()
        connection.Close()
    End Sub
End Class
