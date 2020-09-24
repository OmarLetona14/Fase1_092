Public Class Venta
    Private m_idVenta As Integer
    Private m_cantidadPizza As Integer
    Private m_cantidadBebida As Integer
    Private m_total As Double
    Private m_nombreCliente As String
    Private m_telefonoCliente As String
    Private m_personal As Personal

    Public Sub New(idVenta As Integer, cantidadPizza As Integer, cantidadBebida As Integer, total As Double, nombreCliente As String, telefonoCliente As String, personal As Personal)
        m_idVenta = idVenta
        m_cantidadPizza = cantidadPizza
        m_cantidadBebida = cantidadBebida
        m_total = total
        m_nombreCliente = nombreCliente
        m_telefonoCliente = telefonoCliente
        m_personal = personal
    End Sub
    Public Sub New()
    End Sub
    Public Property IdVenta As Integer
        Get
            Return m_idVenta
        End Get
        Set(value As Integer)
            m_idVenta = value
        End Set
    End Property

    Public Property CantidadPizza As Integer
        Get
            Return m_cantidadPizza
        End Get
        Set(value As Integer)
            m_cantidadPizza = value
        End Set
    End Property

    Public Property CantidadBebida As Integer
        Get
            Return m_cantidadBebida
        End Get
        Set(value As Integer)
            m_cantidadBebida = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return m_total
        End Get
        Set(value As Double)
            m_total = value
        End Set
    End Property

    Public Property NombreCliente As String
        Get
            Return m_nombreCliente
        End Get
        Set(value As String)
            m_nombreCliente = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return m_telefonoCliente
        End Get
        Set(value As String)
            m_telefonoCliente = value
        End Set
    End Property

    Public Property Personal As Personal
        Get
            Return m_personal
        End Get
        Set(value As Personal)
            m_personal = value
        End Set
    End Property
End Class
