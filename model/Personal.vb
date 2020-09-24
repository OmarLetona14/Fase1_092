Public Class Personal
    Private m_idPersonal As Integer
    Private m_nombrePersonal As String
    Private m_correo As String
    Private m_contrasenia As String
    Private m_tipo As String
    Private m_Sucursal As Sucursal

    Public Sub New(idPersonal As Integer, nombrePersonal As String, correo As String, contrasenia As String, tipo As String, sucursal As Sucursal)
        m_idPersonal = idPersonal
        m_nombrePersonal = nombrePersonal
        m_correo = correo
        m_contrasenia = contrasenia
        m_tipo = tipo
        m_Sucursal = sucursal
    End Sub
    Public Sub New()
    End Sub
    Public Property IdPersonal As Integer
        Get
            Return m_idPersonal
        End Get
        Set(value As Integer)
            m_idPersonal = value
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

    Public Property Correo As String
        Get
            Return m_correo
        End Get
        Set(value As String)
            m_correo = value
        End Set
    End Property

    Public Property Contrasenia As String
        Get
            Return m_contrasenia
        End Get
        Set(value As String)
            m_contrasenia = value
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

    Public Property Sucursal As Sucursal
        Get
            Return m_Sucursal
        End Get
        Set(value As Sucursal)
            m_Sucursal = value
        End Set
    End Property
End Class
