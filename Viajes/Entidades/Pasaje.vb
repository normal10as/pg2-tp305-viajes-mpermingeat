Imports Entidades

Public Class Pasaje
    Implements IServicios
    Implements ICotizacion
    Private _descripcion As String
    Private _fechaInicial As Date
    Private _precioDolar As Decimal
    Private _precioPesos As Decimal
    Private _asiento As Byte
    Private _precioUnitario As Decimal

    Public Sub New(descripcion, fecha, precio, asientos, origen, destino)
        Me.Descripcion = descripcion
        Me.FechaInicial = fecha
        Me.Asiento = Asiento
        Me.PrecioUnitario = precio
    End Sub

    '///////////Properties/////////////////////////
    Public Property Asiento As Byte
        Get
            Return _asiento
        End Get
        Set(value As Byte)
            _asiento = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
        End Set
    End Property


    Public Property Descripcion As String Implements IServicios.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            If value.Length > 30 Then
                Throw New ArgumentException("La descripcion debe conetener menos de 30 caracteres")
            End If
            _descripcion = value
        End Set
    End Property

    Public Property FechaInicial As Date Implements IServicios.FechaInicial
        Get
            Return _fechaInicial
        End Get
        Set(value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements ICotizacion.PrecioDolar
        Get
            Return _precioDolar
        End Get
    End Property

    Public ReadOnly Property PrecioPesos As Decimal Implements ICotizacion.PrecioPesos
        Get
            Return _precioPesos
        End Get
    End Property

    '//////////Methods////////////

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
