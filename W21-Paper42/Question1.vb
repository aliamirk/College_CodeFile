﻿Imports System
Imports System.Reflection.Metadata.Ecma335

Module Question1
    Sub Main(args As String())

        Console.WriteLine("----- Unknown -----")

        Console.WriteLine("10 and 15")
        Console.WriteLine(Unknown(10, 15))
        Console.WriteLine("-----------------")

        Console.WriteLine("10 and 10")
        Console.WriteLine(Unknown(10, 10))
        Console.WriteLine("-----------------")

        Console.WriteLine("15 and 10")
        Console.WriteLine(Unknown(15, 10))
        Console.WriteLine("-----------------")


        Console.WriteLine("")

        Console.WriteLine("-----Iterative Unknown-----")

        Console.WriteLine("10 and 15")
        Console.WriteLine(IterativeUnknown(10, 15))
        Console.WriteLine("-----------------")

        Console.WriteLine("10 and 10")
        Console.WriteLine(IterativeUnknown(10, 10))
        Console.WriteLine("-----------------")

        Console.WriteLine("15 and 10")
        Console.WriteLine(IterativeUnknown(15, 10))
        Console.WriteLine("-----------------")

    End Sub

    Function Unknown(ByVal X As Integer, ByVal Y As Integer) As Integer

        If X < Y Then
            Console.WriteLine(X + Y)
            Return (Unknown(X + 1, Y) * 2)
        ElseIf X = Y Then
            Return 1
        Else
            Console.WriteLine(X + Y)
            Return (Unknown(X - 1, Y) / 2)
        End If

    End Function

    Function IterativeUnknown(ByVal X As Integer, ByVal Y As Integer) As Integer

        ' Initialize result to 1 
        Dim result As Integer = 1

        ' Loop until X equals Y
        While X <> Y

            ' Print the sum of X and Y
            Console.WriteLine(X + Y)

            If X < Y Then
                ' If X is less than Y, increment X and multiply the result by 2
                X += 1
                result *= 2
            Else
                ' If X is greater than Y, decrement X and divide the result by 2
                X -= 1
                result /= 2
            End If
        End While

        ' Print the final sum of X and Y
        Console.WriteLine(X + Y)

        ' Return the final result
        Return result


    End Function


End Module
