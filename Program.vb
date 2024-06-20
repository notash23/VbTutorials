Module Program

    Dim numbers(15) As Integer


    Sub initArray()
        numbers(0) = 1
        numbers(1) = 2
        numbers(2) = 21
        numbers(3) = 23
        numbers(4) = 51
        numbers(5) = 63
        numbers(6) = 72
        numbers(7) = 80
        numbers(8) = 81
        numbers(9) = 82
        numbers(10) = 101
        numbers(11) = 103
        numbers(12) = 121
        numbers(13) = 163
        numbers(14) = 172
        numbers(15) = 180
    End Sub



    Sub Main(args As String())
        initArray()
        ' Let's say we want to find the number 3 in the array
        ' There are two ways to do it


        ' This linear search is O(n)
        Dim isFound As Boolean = False
        Dim index As Integer

        While (isFound = False And index < numbers.Length)
            If (numbers(index) = 82) Then
                Console.WriteLine("Found value at index " & index)
                isFound = True
            End If
            index = index + 1
        End While

        ' The binary search is O(lg(n))
        ' So, it is comparatively faster for large array sizes
        Dim minIndex As Integer = 0
        Dim maxIndex As Integer = numbers.Length - 1
        isFound = False

        Dim middleIndex As Integer = (minIndex + maxIndex) \ 2
        While (minIndex < maxIndex - 1 And isFound = False)
            middleIndex = (minIndex + maxIndex) \ 2
            If (numbers(middleIndex) > 82) Then
                maxIndex = middleIndex
            ElseIf (numbers(middleIndex) < 82) Then
                minIndex = middleIndex
            Else
                Console.Write("Found value at index " & middleIndex)
                isFound = True
            End If
        End While
    End Sub
End Module
