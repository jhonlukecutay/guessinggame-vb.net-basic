Module Module1

    Sub Main()
        Console.WriteLine("Please Enter a number below:")
        Dim rAnswer As Integer = 3
        Dim attempt As Integer = 0
        Dim UInput As Integer = Console.ReadLine

        Do
            attempt += 1

            If UInput = rAnswer Then
                Console.WriteLine("You have guessed the correct number.")
                Console.WriteLine("Correct Number: {0}", rAnswer)
                Exit Do
            ElseIf attempt = 5 Then
                Console.WriteLine("You have reached the maximum number of attempts.")
                Console.WriteLine("Attempt count: {0}", attempt)
                Exit Do
            Else
                Console.WriteLine("It is not the correct number, please try again.")
                Console.WriteLine("Attempt count: {0}", attempt)
                UInput = Console.ReadLine()
            End If
        Loop

        Console.ReadLine()
    End Sub

End Module
