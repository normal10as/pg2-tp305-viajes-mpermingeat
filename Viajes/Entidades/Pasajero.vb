Imports Entidades

Public Class Pasajero
    Inherits Entidad
    Implements IPasajero
    Private _dni As UInteger
    Private _pasaporte As UInteger
    Private _fechaNacimiento As Date

    Public Sub New(nombre, domicilio, dni, fechaNacimiento)
        MyBase.New(nombre, domicilio)
        Me.Dni = dni
        Me.FechaNacimiento = fechaNacimiento
    End Sub

    Public Sub New(nombre, domicilio, dni, fechaNacimiento, pasaporte)
        MyBase.New(nombre, domicilio)
        Me.Dni = dni
        Me.FechaNacimiento = fechaNacimiento
        Me.Pasaporte = pasaporte
    End Sub

    ''/////////////Properties/////////////
    Public Property Pasaporte As UInteger Implements IPasajero.Pasaporte
        Get
            Return _pasaporte
        End Get
        Set(value As UInteger)
            _pasaporte = value
        End Set
    End Property

    Public Property Dni As UInteger Implements IPasajero.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property

    Public Property FechaNacimiento As Date Implements IPasajero.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    '//////////////////Methods/////////////
    Public Function EsMayorEdad(value As Date) As Boolean
        Dim aux As Date
        If (aux.Year - value.Year) >= 18 Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
