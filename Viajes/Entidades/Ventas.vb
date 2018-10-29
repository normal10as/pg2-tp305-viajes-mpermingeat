Imports Entidades

Public Class Ventas
    Implements ICotizacion
    Private _precioDolar As Decimal
    Private _precioPesos As Decimal
    Private _listaPasajeros As List(Of IPasajero)
    Private _fecha As Date

    Public Sub New(fecha As Date, ciente As Cliente)

    End Sub

    '//////////////////////////Properties////////////////////////////////////

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements ICotizacion.PrecioDolar
        Get
            Return PrecioDolar
        End Get
    End Property

    Public ReadOnly Property PrecioPesos As Decimal Implements ICotizacion.PrecioPesos
        Get
            Return _precioPesos
        End Get
    End Property

    '//////////////////////Methods///////////////////////////////////
    Private Function PrecioTotal() As Decimal
        Return
    End Function

    Public Sub AddPasajero(value As IPasajero)
        _listaPasajeros.Add(value)
    End Sub

    Public Sub RemovePasajero(value As IPasajero)
        _listaPasajeros.Remove(value)
    End Sub

    Public Function GetAllPasajero() As List(Of IPasajero)
        Return _listaPasajeros
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
