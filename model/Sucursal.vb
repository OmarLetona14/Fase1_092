Public Class Sucursal
    Private m_idSucursal As Integer
    Private m_codigo As String
    Private m_direccion As String

    Public Sub New(idSucursal As Integer, codigo As String, direccion As String)
        m_idSucursal = idSucursal
        m_codigo = codigo
        m_direccion = direccion
    End Sub
    Public Sub New()
    End Sub
    Public Property IdSucursal As Integer
        Get
            Return m_idSucursal
        End Get
        Set(value As Integer)
            m_idSucursal = value
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
