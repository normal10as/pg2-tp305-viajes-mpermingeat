Imports Entidades

Public Class ClientePasajero
    Inherits Cliente
    Implements IPasajero
    Private _pasaporte As UInteger
    Private _dni As UInteger
    Private _fechaNacimiento As Date

    Public Sub New(cuit_cuil, nombre, domicilio, dni, fechaNacimiento)
        MyBase.New(cuit_cuil, nombre, domicilio)
        Me.Dni = dni
        Me.FechaNacimiento = _fechaNacimiento
    End Sub

    Public Sub New(cuit_cuil, nombre, domicilio, dni, fechaNacimiento, pasaporte)
        MyBase.New(cuit_cuil, nombre, domicilio)
        Me.Dni = dni
        Me.FechaNacimiento = _fechaNacimiento
        Me.Pasaporte = _pasaporte
    End Sub

    '////////////////Properties////////////////////////////////////////
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

    '////////////////////Methods//////////////////////////////////
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
