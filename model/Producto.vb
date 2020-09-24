Public Class Producto
    Private m_idProducto As Integer
    Private m_nombreProducto As String
    Private m_tipo As String
    Private m_precio As Double

    Public Sub New(idProducto As Integer, nombreProducto As String, tipo As String, precio As Double)
        m_idProducto = idProducto
        m_nombreProducto = nombreProducto
        m_tipo = tipo
        m_precio = precio
    End Sub
    Public Sub New()
    End Sub
    Public Property IdProducto As Integer
        Get
            Return m_idProducto
        End Get
        Set(value As Integer)
            m_idProducto = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return m_nombreProducto
        End Get
        Set(value As String)
            m_nombreProducto = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return m_tipo
        End Get
        Set(value As String)
            m_tipo = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return m_precio
        End Get
        Set(value As Double)
            m_precio = value
        End Set
    End Property
End Class
