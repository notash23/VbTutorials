Module Oop

    ' A class is a way to encapsulate related data and codes together
    Class Deck
        ' Attribute
        Public cards(52) As Card

        ' Methods
        Public Overloads Sub PrintCardNumbers()
            For i = 1 To 52

                ' We should access the card number using the getter function
                Console.WriteLine("The Card number is " & cards(i).getCardNumber & " and the card type is " & cards(i).cardType)
            Next
        End Sub

        Public Overloads Sub PrintCardNumbers(filterCardType As String)
            For i = 1 To 52
                ' Overloading the previous method to now use a filter which is taken as parameter
                If cards(i).cardType = filterCardType Then
                    Console.WriteLine("The Card number is " & cards(i).getCardNumber & " and the card type is " & cards(i).cardType)
                End If
            Next
        End Sub

        Public Overloads Sub PrintCardNumbers(range As Integer)
            For i = 1 To range
                ' Overloading the method again to take an integer as parameter and print that range
                Console.WriteLine("The Card number is " & cards(i).getCardNumber & " and the card type is " & cards(i).cardType)
            Next
        End Sub

        Public Sub New()

            Dim types = {"Spade", "Heart", "Clover", "Diamond"}
            ' Constructors

            For j = 0 To 3
                For i = j * 13 + 1 To j * 13 + 13
                    If i = j * 13 + 1 Then
                        cards(i) = New Card("A", types(j))
                    ElseIf i = j * 13 + 11 Then
                        cards(i) = New Card("J", types(j))
                    ElseIf i = j * 13 + 12 Then
                        cards(i) = New Card("Q", types(j))
                    ElseIf i = j * 13 + 13 Then
                        cards(i) = New Card("K", types(j))
                    Else
                        cards(i) = New Card((i - j * 13).ToString, types(j))
                    End If
                Next
            Next
        End Sub
    End Class

    Class Card
        ' Attributes
        Public cardType As String

        ' Properties (can be acccessed outside the class only using the getter and setter)
        Private cardNumber As String

        ' Methods

        'Getter
        Public Function getCardNumber() As String
            Return cardNumber
        End Function

        ' Setter
        Public Sub setCardNumber(newCardNumber As String)
            cardNumber = newCardNumber
        End Sub

        ' Overridable function (Polymorphism, i.e this method can be changed when the class is inherited)
        Public Overridable Function IsCardHigher(otherCard As Card) As Boolean
            ' This function returns true if our card's number is higher than the other card's number
            If (cardNumber > otherCard.cardNumber) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub New(p_cardNumber As String, p_cardType As String)
            ' Constructor
            cardNumber = p_cardNumber
            cardType = p_cardType
        End Sub
    End Class

    ' Inheritance
    Class UnoCard : Inherits Card
        Public isWildCard As Boolean

        'methods
        Public Sub New(p_cardNumber As String, p_cardType As String, p_isWildCard As Boolean)
            MyBase.New(p_cardNumber, p_cardType)
            isWildCard = p_isWildCard
        End Sub

        'Overriding the isCardHigher function to modify for Uno's needs
        Public Overrides Function IsCardHigher(otherCard As Card) As Boolean
            ' Add another condition: I check if this card is a wild card before comparing the card number
            If isWildCard = True Then
                Return True
            Else
                ' if it is not a wild card, do the same code as written above
                Return MyBase.IsCardHigher(otherCard)
            End If
        End Function
    End Class
End Module
