Imports Entidades


Public Class Cliente
    Inherits Entidad
    Private _cuit_cuil As String

    Public Sub New(cuit_cuil, nombre, domicilio)
        MyBase.New(nombre, domicilio)
        Me.Cuit_cuil = cuit_cuil
    End Sub

    Public Property Cuit_cuil() As String
        Get
            Return _cuit_cuil
        End Get
        Set(ByVal value As String)
            If (value.Length <= 13) Then
                _cuit_cuil = value
            End If
        End Set
    End Property

    Public Function GetAllVentas() As List(Of Ventas)

    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function

End Class
