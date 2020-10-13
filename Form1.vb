Imports System.Drawing.Printing
Public Class Form1

    Private Sub print_PrintPage(ByVal sender As Object,
                            ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 24, FontStyle.Bold)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        ' imprimimos la cadena
        e.Graphics.DrawString("Hola, Mundo", prFont, Brushes.Black, xPos, yPos)
        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub


    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage
        ' indicamos que queremos imprimir
        printDoc.Print()
    End Sub

End Class
