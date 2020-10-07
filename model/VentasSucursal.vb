Public Class VentasSucursal

    Private m_codigo As String
    Private m_total As Double

    Public Sub New(codigo As String, total As Double)
        m_codigo = codigo
        m_total = total
    End Sub

    Public Sub New()

    End Sub
    Public Property Codigo As String
        Get
            Return m_codigo
        End Get
        Set(value As String)
            m_codigo = value
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
