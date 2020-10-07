Public Class VentaView

    Private m_idVenta As Integer
    Private m_cantidadPizza As Integer
    Private m_cantidadBebida As Integer
    Private m_total As Double
    Private m_nombreCliente As String
    Private m_telefonoCliente As String
    Private m_nombrePersonal As String
    Private m_codigo As String
    Private m_direccion As String

    Public Sub New()

    End Sub

    Public Sub New(idVenta As Integer, cantidadPizza As Integer, cantidadBebida As Integer, total As Double, nombreCliente As String, telefonoCliente As String, nombrePersonal As String, codigo As String, direccion As String)
        m_idVenta = idVenta
        m_cantidadPizza = cantidadPizza
        m_cantidadBebida = cantidadBebida
        m_total = total
        m_nombreCliente = nombreCliente
        m_telefonoCliente = telefonoCliente
        m_nombrePersonal = nombrePersonal
        m_codigo = codigo
        m_direccion = direccion
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

    Public Property NombrePersonal As String
        Get
            Return m_nombrePersonal
        End Get
        Set(value As String)
            m_nombrePersonal = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return m_codigo
        End Get
        Set(value As String)
            m_codigo = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return m_direccion
        End Get
        Set(value As String)
            m_direccion = value
        End Set
    End Property
End Class
