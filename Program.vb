Module Program

    Sub Main(args As String())
        Dim newDeck As Deck
        newDeck = New Deck()
        newDeck.PrintCardNumbers()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        newDeck.PrintCardNumbers("Diamond")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        newDeck.PrintCardNumbers(11)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
    End Sub
End Module
