Public Class VentaEmpleado

    Private m_nombrePersonal As String
    Private m_total As Double

    Public Sub New(nombrePersonal As String, total As Double)
        m_nombrePersonal = nombrePersonal
        m_total = total
    End Sub

    Public Sub New()

    End Sub
    Public Property NombrePersonal As String
        Get
            Return m_nombrePersonal
        End Get
        Set(value As String)
            m_nombrePersonal = value
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
End Class
