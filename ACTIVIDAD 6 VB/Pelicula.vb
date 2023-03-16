Imports System.IO

' Clase para representar una película
<Serializable>
Public Class Pelicula
    Public Property Titulo As String
    Public Property Director As String
    Public Property Anio As Integer

    Public Sub New()
    End Sub

    Public Sub New(ByVal titulo As String, ByVal director As String, ByVal anio As Integer)
        Me.Titulo = titulo
        Me.Director = director
        Me.Anio = anio
    End Sub

    Public Sub Serializar(ByVal escritor As BinaryWriter)
        escritor.Write(Titulo)
        escritor.Write(Director)
        escritor.Write(Anio)
    End Sub

    Public Sub Deserializar(ByVal lector As BinaryReader)
        Titulo = lector.ReadString()
        Director = lector.ReadString()
        Anio = lector.ReadInt32()
    End Sub

    Public Overrides Function ToString() As String
        Return $"Título: {Titulo}{vbCrLf}Director: {Director}{vbCrLf}Año: {Anio}{vbCrLf}"
    End Function
End Class

