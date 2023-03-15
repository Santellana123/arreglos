Imports System

Module Program
    Sub Main(args As String())
        Dim numero(9) As Integer
        For i As Integer = 0 To 9
            numero(i) = i + 1
        Next

        Console.WriteLine("Arreglo unidimensional de números del 1 al 10:")
        For i As Integer = 0 To 9
            Console.Write(numero(i) & " ")
        Next

        Console.WriteLine()
        Console.WriteLine("te mostrara un arreglo bidimencional de todos los numeros que tiene el ^2 del numero dado")
        Console.WriteLine("Ingrese un número: ")
        Dim n As Integer = Console.ReadLine()

        Dim matriz(n - 1, n - 1) As Integer
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - 1
                matriz(i, j) = i * n + j + 1
            Next
        Next

        Console.WriteLine("Arreglo bidimensional de números del 1 al " & n & "^2:")
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub
End Module
