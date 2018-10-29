Public Class Entidad
    Private _nombre As String
    Private _domicilio As String

    Public Sub New(nombre, domicilio)
        Me.Nombre = nombre
        Me.Domicilio = domicilio
    End Sub

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            If value > 30 Then
                Throw New ArgumentException("El nombre debe tener menos de 30 caracteres")
            End If
            _nombre = value
        End Set
    End Property

    Public Property Domicilio() As String
        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            If value > 50 Then
                Throw New ArgumentException("El nombre debe tener menos de 50 caracteres")
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
