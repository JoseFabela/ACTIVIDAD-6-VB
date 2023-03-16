Imports System.IO

Public Class Form1

    Private Const FILENAME As String = "peliculas.dat"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Crear un objeto de Pelicula a partir de la información ingresada por el usuario
            Dim pelicula As New Pelicula(txtTitulo.Text, txtDirector.Text, Integer.Parse(txtAño.Text))

            ' Abrir el archivo binario para escritura (creando uno nuevo si no existe)
            Using archivo As New FileStream(FILENAME, FileMode.Append, FileAccess.Write)
                ' Serializar el objeto de Pelicula y escribirlo en el archivo
                Dim escritor As New BinaryWriter(archivo)
                pelicula.Serializar(escritor)
            End Using

            MessageBox.Show("La película ha sido guardada correctamente.")
        Catch ex As FormatException
            MessageBox.Show("El año ingresado no es un número válido.")
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar guardar la película: " + ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            ' Abrir el archivo binario para lectura
            Using archivo As New FileStream(FILENAME, FileMode.Open, FileAccess.Read)
                ' Leer el archivo y mostrar las películas guardadas
                Dim lector As New BinaryReader(archivo)
                While archivo.Position < archivo.Length
                    Dim pelicula As New Pelicula()
                    pelicula.Deserializar(lector)
                    MessageBox.Show(pelicula.ToString())
                End While
            End Using
        Catch ex As FileNotFoundException
            MessageBox.Show("No se encontró el archivo de películas.")
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar leer el archivo de películas: " + ex.Message)
        End Try
    End Sub

End Class

