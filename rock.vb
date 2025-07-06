

Public Class Form1
    Dim choices() As String = {"R", "P", "S"}
    Dim rnd As New Random()

    Private Sub rock_Click(sender As Object, e As EventArgs) Handles rock.Click
        Play("R")
    End Sub

    Private Sub paper_Click(sender As Object, e As EventArgs) Handles paper.Click
        Play("P")
    End Sub
    Private Sub scissor_Click(sender As Object, e As EventArgs) Handles scissor.Click
        Play("S")
    End Sub

    Private Sub Play(userChoice As String)
        Dim computerChoice As String
        computerChoice = choices(rnd.Next(choices.Length))

        Dim message As String
        message = "Computer chose: " & (computerChoice) & vbCrLf

        If userChoice = computerChoice Then
            message &= "It's a tie!"
        ElseIf (userChoice = "R" And computerChoice = "S") Or
                   (userChoice = "P" And computerChoice = "R") Or
                   (userChoice = "S" And computerChoice = "P") Then
            message &= "You win!"
        Else
            message &= "Computer wins!"
        End If

        lblResult.Text = message
    End Sub
End Class
