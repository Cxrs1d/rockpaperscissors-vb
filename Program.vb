Imports System

Module Program
    Sub Main(args As String())

        Dim choices() As String = {"R", "P", "S"}
        Dim rnd As New Random()

        Console.WriteLine(" Rock, Paper, Scissors ")

        While True

            Console.Write("Choose [R]ock, [P]aper, [S]cissors, [E]xit: ")
            Dim userChoice As String
            userChoice = Console.ReadLine().ToUpper()

            If userChoice = "E" Then
                Console.WriteLine("Thanks for playing!")
                Exit While
            End If

            If userChoice <> "R" AndAlso userChoice <> "P" AndAlso userChoice <> "S" Then
                Console.WriteLine("Invalid choice! Please enter R, P, S or E.")
                Continue While
            End If

            Dim computerChoice As String
            computerChoice = choices(rnd.Next(choices.Length))
            Console.WriteLine("Computer chose: " & computerChoice)

            If userChoice = computerChoice Then
            Console.WriteLine("It's a tie!")
        ElseIf (userChoice = "R" And computerChoice = "S") Or
               (userChoice = "P" And computerChoice = "R") Or
               (userChoice = "S" And computerChoice = "P") Then
            Console.WriteLine("You win!")
        Else
            Console.WriteLine("Computer wins!")
        End If
        End While

    End Sub
End Module
